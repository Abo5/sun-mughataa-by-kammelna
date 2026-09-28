using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Core;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

public class SfsConnectionManager : Singleton<SfsConnectionManager>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<DateTime, bool> <>9__18_0;

		public static Action<bool> <>9__31_0;

		public static Func<bool> <>9__42_0;

		public static Func<bool> <>9__43_0;

		public static Func<SFSConfig, bool> <>9__45_0;

		public static Action<bool> <>9__53_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3144;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <get__isSpammingConnection>b__18_0(DateTime t)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00f9: Expected O, but got I4
			//IL_0071: Expected O, but got I4
			object obj = typeof(DataRelation) + 712;
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			TimeSpan timeSpan = now - t;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TimeSpan timeSpan2 = TimeSpan.FromMinutes(2.0000000002328306);
			return timeSpan <= timeSpan2;
		}

		internal void <ForceDisconnectAndSwitchServer>b__31_0(bool success)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0061: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 3136;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.LoadScene(Scenes.FetchServer);
		}

		internal bool <ConnectToSfs>b__42_0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00dc: Expected O, but got I
			//IL_0106: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_016b: Expected I4, but got O
			//IL_014f: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6022]");
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
			goto IL_015d;
			IL_00b8:
			return sessionModel.IsConnected;
			IL_015d:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_00b8;
			}
			goto IL_015d;
		}

		internal bool <LoginToSfs>b__43_0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00f6: Expected O, but got I
			//IL_0120: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_0185: Expected I4, but got O
			//IL_0169: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6023]");
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
			goto IL_0177;
			IL_00b8:
			Room currentRoom = sessionModel.CurrentRoom;
			bool flag4 = currentRoom == null;
			return !flag4;
			IL_0177:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_00b8;
			}
			goto IL_0177;
		}

		internal bool <OnServerLockedDown>b__45_0(SFSConfig s)
		{
			//IL_00e0: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			if (s != null)
			{
				object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string serverID = Config.ServerID;
				if (s.<ID>k__BackingField != serverID && s.<IsOnline>k__BackingField)
				{
					return s.<IsMain>k__BackingField;
				}
				return false;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal void <ShowNewVersionPopup>b__53_0(bool success)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00aa: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2456;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6025]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v1+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			NewVersionPopup.Show();
			return;
			IL_0074:
			NewVersionPopup.Show();
		}
	}

	private sealed class <PingPongWatchdogCoroutine>d__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public SfsConnectionManager <>4__this;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <PingPongWatchdogCoroutine>d__41(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0052: Expected I4, but got I8
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected O, but got Unknown
			//IL_0551: Expected O, but got I
			//IL_0560: Unknown result type (might be due to invalid IL or missing references)
			//IL_0565: Expected O, but got Unknown
			//IL_0021: Expected O, but got I4
			//IL_00e7: Expected O, but got I4
			//IL_00e7: Expected O, but got I
			//IL_010a: Expected O, but got I4
			//IL_0113: Expected O, but got I4
			//IL_011c: Expected O, but got I4
			//IL_0125: Expected O, but got I4
			//IL_012a: Expected I, but got O
			//IL_0081: Expected O, but got I4
			//IL_0081: Expected O, but got I
			//IL_009d: Expected O, but got I4
			//IL_00a6: Expected O, but got I4
			//IL_003e: Expected I4, but got I8
			//IL_024a: Unknown result type (might be due to invalid IL or missing references)
			//IL_024f: Expected O, but got Unknown
			//IL_025b: Expected O, but got I
			//IL_0285: Expected O, but got I4
			//IL_0162: Expected O, but got I4
			//IL_00bd: Expected O, but got I4
			//IL_00c2: Expected I, but got O
			//IL_051a: Expected I4, but got O
			//IL_05aa: Expected O, but got I
			//IL_05bf: Expected O, but got I
			//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d7: Expected O, but got Unknown
			//IL_0228: Expected O, but got I4
			//IL_022d: Expected I, but got O
			//IL_01c6: Expected O, but got I4
			//IL_01cb: Expected I, but got O
			//IL_0302: Unknown result type (might be due to invalid IL or missing references)
			//IL_0307: Expected O, but got Unknown
			//IL_030f: Expected I, but got O
			//IL_031f: Expected O, but got I
			//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ee: Expected O, but got Unknown
			//IL_04f7: Expected O, but got I4
			//IL_03b5: Expected O, but got I
			//IL_03d7: Expected O, but got I4
			//IL_03e0: Expected O, but got I4
			//IL_035a: Expected O, but got I
			//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0402: Expected O, but got Unknown
			//IL_0429: Unknown result type (might be due to invalid IL or missing references)
			//IL_042e: Expected O, but got Unknown
			//IL_0455: Unknown result type (might be due to invalid IL or missing references)
			//IL_045a: Expected O, but got Unknown
			//IL_0462: Unknown result type (might be due to invalid IL or missing references)
			//IL_0467: Expected O, but got Unknown
			//IL_0470: Unknown result type (might be due to invalid IL or missing references)
			//IL_0475: Expected O, but got Unknown
			//IL_0485: Expected O, but got I
			//IL_04a9: Expected O, but got I4
			//IL_0368: Unknown result type (might be due to invalid IL or missing references)
			//IL_036d: Expected O, but got Unknown
			//IL_0376: Unknown result type (might be due to invalid IL or missing references)
			//IL_037b: Expected O, but got Unknown
			object obj2;
			object obj5;
			object obj8 = default(object);
			if (<>1__state != 1)
			{
				bool flag = <>1__state == 0;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_0506;
				}
				<>1__state = -1;
			}
			else
			{
				<>1__state = -1;
				obj2 = typeof(RegisteredWaitHandle) + 1880;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v23+B8]");
				object obj4 = 0;
				obj5 = typeof(DataRelation) + 712;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v25+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v24+108]");
					bool flag2 = (DateTime)0 == (DateTime)0;
					bool flag3 = !flag2;
					object obj7 = 0;
					DateTime dateTime = (DateTime)0;
					if (flag3)
					{
						goto IL_0138;
					}
					obj8 = 0;
					nint num = unchecked((nint)null);
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v24+108]");
					bool flag4 = (DateTime)0 == (DateTime)0;
					bool flag5 = !flag4;
					object obj9 = !flag5;
					object obj7 = 0;
					DateTime dateTime = (DateTime)0;
					obj8 = 0;
					nint num = unchecked((nint)null);
					if (obj9 == null)
					{
						goto IL_0138;
					}
				}
			}
			goto IL_023b;
			IL_0506:
			return false;
			IL_023b:
			object obj10 = typeof(Queue<string>) + 848;
			object obj11 = (nint)0 + (nint)2200;
			object obj12 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v5+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			object obj20;
			object obj23;
			if ((object)sessionModel != null)
			{
				Room currentRoom = sessionModel.CurrentRoom;
				if (currentRoom != null)
				{
					object obj14 = typeof(RegisteredWaitHandle) + 1376;
					nint num2 = (nint)currentRoom;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_039b;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
					object obj16 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X10_v8-8]");
						if (0 == (nint)obj14)
						{
							break;
						}
						obj16 += 16;
						obj15--;
						if ((nint)obj15 != 1)
						{
							continue;
						}
						goto IL_039b;
					}
					object obj17 = obj16 + 6;
					object obj18 = num2 + obj17;
					object obj19 = obj18 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v19+8]");
					obj20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v389 @ X8_v19] (should have been resolved before IL gen)");
					object obj21 = default(object);
					bool flag7 = obj21 == null;
					object obj22 = !flag7;
					obj23 = obj8;
					if (obj22 != null)
					{
						goto IL_03ee;
					}
				}
				goto IL_04bf;
			}
			goto IL_050c;
			IL_01d9:
			SFS.ReestablishConnection();
			goto IL_0506;
			IL_0138:
			object obj24 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X0_v29+E4]");
			bool flag8 = (nint)0 == 0;
			object obj25 = !flag8;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			object obj26 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v29+B8]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v30+108]");
			TimeSpan timeSpan = now - (DateTime)0;
			object obj28 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			object obj29 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X0_v35+E4]");
			TimeSpan timeSpan2 = default(TimeSpan);
			if ((nint)0 != 0)
			{
				double totalSeconds = timeSpan2.TotalSeconds;
				bool flag9 = !(totalSeconds > 16.00000000325963);
				double num3 = 16.00000000325963;
				obj8 = 0;
				nint num = unchecked((nint)null);
				if (!flag9)
				{
					goto IL_01d9;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				double totalSeconds = timeSpan2.TotalSeconds;
				bool flag10 = totalSeconds > 16.00000000325963;
				double num3 = 16.00000000325963;
				obj8 = 0;
				nint num = unchecked((nint)null);
				if (flag10)
				{
					goto IL_01d9;
				}
			}
			goto IL_023b;
			IL_03ee:
			object obj30 = typeof(UsageHint) + 1640;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			WaitForSeconds waitForSeconds = default(WaitForSeconds);
			waitForSeconds..ctor(1f);
			object obj31 = this + 24;
			obj31 = waitForSeconds;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 1;
			return true;
			IL_050c:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_04bf:
			if ((object)<>4__this != null)
			{
				object obj32 = <>4__this + 40;
				obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				goto IL_0506;
			}
			goto IL_050c;
			IL_039b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X0_v21+8]");
			obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v418 @ X0_v21] (should have been resolved before IL gen)");
			object obj33 = default(object);
			bool flag11 = obj33 == null;
			obj23 = 6;
			obj8 = 6;
			if (!flag11)
			{
				goto IL_03ee;
			}
			goto IL_04bf;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)2032;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private const float PingPongTimeoutSeconds = 30f;

	private static bool DidAppFirstLaunchInNonFTServer;

	private static bool IsTryingAutoLogin;

	private static RequestJoinRoomInfo _joinRoomRequest;

	private readonly List<DateTime> _disconnectionHistory;

	private Coroutine _pingPongWatchdogCoroutine;

	private LoginError <LastLoginError>k__BackingField;

	[NonSerialized]
	public LoginStatus LoginStatus;

	private static bool InLoginScenes
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_016d: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_00ab: Expected O, but got I4
			//IL_00b4: Expected O, but got I4
			//IL_0205: Expected O, but got I4
			//IL_019b: Expected O, but got I
			//IL_01b5: Expected O, but got I4
			//IL_01be: Expected O, but got I4
			//IL_01c7: Expected O, but got I4
			//IL_010f: Expected O, but got I
			//IL_0245: Expected O, but got I
			//IL_0359: Expected O, but got I
			//IL_0373: Expected O, but got I4
			//IL_02ad: Expected O, but got I
			//IL_03b1: Expected O, but got I4
			//IL_030f: Expected O, but got I
			//IL_0325: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(RegisteredWaitHandle) + 3136;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6004]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v23+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v23+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			object obj8 = 146685952;
			object obj9 = 146685952;
			if (obj7 != null)
			{
				goto IL_00c2;
			}
			goto IL_01d5;
			IL_02ca:
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v11+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = obj10;
			if (!flag3)
			{
				goto IL_02ff;
			}
			goto IL_03c7;
			IL_03c7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj2;
			goto IL_02ff;
			IL_02ff:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v11+B8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v10+18]");
			object obj13 = -1;
			return obj13 == null;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
			object obj14 = (nint)0 & (nint)1;
			bool flag4 = obj14 == null;
			obj8 = 146685952;
			obj9 = 146685952;
			if (!flag4)
			{
				goto IL_00c2;
			}
			goto IL_01d5;
			IL_01d5:
			_ = 1;
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v1+E4]");
			bool flag5 = (nint)0 == 0;
			object obj16 = !flag5;
			obj8 = obj9;
			object obj17 = obj15;
			if (obj16 != null)
			{
				goto IL_00ff;
			}
			goto IL_0223;
			IL_00c2:
			obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v1+E4]");
			bool flag6 = (nint)0 == 0;
			obj17 = obj15;
			obj9 = obj8;
			if (!flag6)
			{
				goto IL_00ff;
			}
			goto IL_0223;
			IL_0223:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v1+B8]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v16+18]");
			bool flag7 = (nint)0 == 2;
			obj8 = obj9;
			if (flag7)
			{
				goto IL_0137;
			}
			goto IL_0272;
			IL_00ff:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v1+B8]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v27+18]");
			if ((nint)0 == 2)
			{
				goto IL_0137;
			}
			goto IL_0272;
			IL_0272:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
				object obj20 = (nint)0 & (nint)1;
				if (obj20 != null)
				{
					goto IL_02ca;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X20_v2+588]");
				object obj21 = (nint)0 & (nint)1;
				bool flag8 = obj21 == null;
				object obj22 = !flag8;
				if (obj22 != null)
				{
					goto IL_02ca;
				}
			}
			_ = 1;
			obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v11+E4]");
			bool flag9 = (nint)0 == 0;
			object obj23 = !flag9;
			obj11 = obj10;
			if (obj23 != null)
			{
				goto IL_02ff;
			}
			goto IL_03c7;
			IL_0137:
			return true;
		}
	}

	private bool _isSpammingConnection
	{
		get
		{
			//IL_01ba: Expected I4, but got O
			//IL_0036: Expected O, but got I
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Expected O, but got Unknown
			//IL_00fe: Expected O, but got I
			//IL_010e: Expected O, but got I
			//IL_0130: Expected O, but got I4
			//IL_0091: Expected O, but got I
			//IL_00a1: Expected O, but got I
			//IL_00c3: Expected O, but got I4
			//IL_0160: Expected O, but got I4
			//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f7: Expected O, but got Unknown
			//IL_020d: Expected O, but got I
			//IL_021e: Expected I, but got O
			//IL_023c: Expected O, but got I
			//IL_0190: Expected O, but got I
			List<DateTime> disconnectionHistory = _disconnectionHistory;
			object obj2;
			object obj4;
			Func<DateTime, bool> predicate;
			if (_disconnectionHistory != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2 (System.Collections.Generic.List`1<System.DateTime>)+18]");
				if ((nint)0 >= (nint)3)
				{
					object obj = (nint)0 + (nint)3024;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9B6A8");
					obj2 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3144;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v10+E4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v10+B8]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v11+8]");
						predicate = (Func<DateTime, bool>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v11+8]");
						bool flag = (nint)0 == 0;
						object obj5 = !flag;
						if (obj5 == null)
						{
							goto IL_013e;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj3 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v10+B8]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v11+8]");
						predicate = (Func<DateTime, bool>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v11+8]");
						bool flag2 = (nint)0 == 0;
						object obj6 = !flag2;
						if (obj6 == null)
						{
							goto IL_013e;
						}
					}
					goto IL_0195;
				}
				return false;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0195:
			IEnumerable<DateTime> source = default(IEnumerable<DateTime>);
			return Enumerable.All(source, predicate);
			IL_013e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj8 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v17+B8]");
				obj4 = 0;
			}
			object obj9 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 912;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = (nint)0 + (nint)2024;
			Func<DateTime, bool> func = default(Func<DateTime, bool>);
			func..ctor(obj4, (IntPtr)obj10);
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v16+B8]");
			object obj12 = (nint)0 + (nint)8;
			obj12 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			predicate = func;
			goto IL_0195;
		}
	}

	public LoginError LastLoginError
	{
		get
		{
			return <LastLoginError>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 48;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public static event Action<string> OnUpdateStatusText
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
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 64;
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
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 64;
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

	public static event Action<LoginStatus> OnConnectionStateChange
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
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 64;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2592;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+18]");
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
				object obj11 = (nint)0 + (nint)24;
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
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 64;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2592;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+18]");
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
				object obj11 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<LoginError> OnLoginError
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
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 64;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2584;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+20]");
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
				object obj11 = (nint)0 + (nint)32;
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
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 64;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2584;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+20]");
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
				object obj11 = (nint)0 + (nint)32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public void LoginIfNotSpamming()
	{
		if (_isSpammingConnection)
		{
			SFS.Disconnect();
			UpdateStatus(LoginStatus.ConnectionFailed);
			ShowErrorInLoginScene();
		}
		else
		{
			Login();
		}
	}

	public void AutoLogin()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 64;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
		object obj3 = 0;
		_ = 1;
		Login();
	}

	public void Login()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0290: Expected O, but got I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00e0: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_02e2: Expected O, but got I4
		//IL_018a: Expected O, but got I4
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0229: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E600D]");
		object obj3 = (nint)0 & (nint)1;
		LoginStatus loginStatus2;
		LoginStatus loginStatus;
		if (obj3 != null)
		{
			UpdateStatus(LoginStatus.Initiated);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			loginStatus = LoginStatus.Initiated;
			loginStatus2 = LoginStatus.Initiated;
			if (!flag)
			{
				goto IL_009a;
			}
		}
		else
		{
			_ = 1;
			UpdateStatus(LoginStatus.Initiated);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			loginStatus = LoginStatus.Initiated;
			loginStatus2 = LoginStatus.Initiated;
			if (obj5 != null)
			{
				goto IL_009a;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = Config.Validate();
		bool flag4 = !flag3;
		object obj6 = !flag4;
		loginStatus = loginStatus2;
		if (obj6 != null)
		{
			goto IL_00c0;
		}
		goto IL_02f8;
		IL_00c0:
		object obj7 = typeof(Queue<string>) + 848;
		object obj8 = (nint)0 + (nint)2200;
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v22+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		if (sessionModel.IsConnected)
		{
			object obj11 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v30+E4]");
			bool flag6 = (nint)0 == 0;
			object obj12 = !flag6;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			if (sessionModel2.IsLoggedIn)
			{
				UpdateStatus(LoginStatus.LoggedIn);
				object obj13 = typeof(RegisteredWaitHandle) + 3136;
				object obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v37+E4]");
				bool flag7 = (nint)0 == 0;
				object obj15 = !flag7;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.LoadScene(Scenes.Menu);
			}
			else
			{
				LoginToSfs();
			}
		}
		else
		{
			ConnectToSfs();
		}
		return;
		IL_02f8:
		UpdateStatus(LoginStatus.LoginFailed);
		ShowErrorInLoginScene();
		return;
		IL_009a:
		if (Config.Validate())
		{
			goto IL_00c0;
		}
		goto IL_02f8;
	}

	public void SwitchServerAndReloadScene(string serverId = "0")
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cb: Expected O, but got I4
		//IL_00d4: Expected O, but got I4
		//IL_0078: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E600E]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			SFS.SwitchServer(serverId);
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = 0;
			if (!flag)
			{
				goto IL_0086;
			}
		}
		else
		{
			_ = 1;
			SFS.SwitchServer(serverId);
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = 0;
			if (obj5 != null)
			{
				goto IL_0086;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ScreenManager.AnimateTransitionOut();
		return;
		IL_0086:
		ScreenManager.AnimateTransitionOut();
	}

	public static void SwitchGame(string serverId, Games game, Action callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected O, but got Unknown
		//IL_055e: Expected O, but got I4
		//IL_0034: Expected O, but got I
		//IL_0067: Expected O, but got I4
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00ca: Expected O, but got I4
		//IL_01ba: Expected O, but got I4
		//IL_0220: Expected O, but got I4
		//IL_0143: Expected O, but got I4
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_027b: Expected O, but got I4
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected O, but got Unknown
		//IL_02b0: Expected O, but got I4
		//IL_0462: Expected O, but got I4
		//IL_046b: Expected O, but got I4
		//IL_038c: Expected O, but got I4
		//IL_03b9: Expected O, but got I4
		//IL_03c2: Expected O, but got I4
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected O, but got Unknown
		//IL_04fa: Expected O, but got I4
		//IL_0503: Expected O, but got I4
		//IL_04a5: Expected O, but got I4
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj2 = typeof(Queue<string>) + 848;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = (nint)0 + (nint)2200;
		bool isInitialized = Config.IsInitialized;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj8 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		SessionModel sessionModel = default(SessionModel);
		bool isConnected = sessionModel.IsConnected;
		bool flag3 = !isInitialized;
		object obj9 = !flag3;
		Action action;
		string text;
		bool flag5;
		bool flag6;
		Action action2;
		string text2;
		if (obj9 == null)
		{
			object obj10 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v36+E4]");
			bool flag4 = (nint)0 == 0;
			action = callback;
			text = null;
			flag5 = isInitialized;
			action2 = callback;
			text2 = null;
			flag6 = isInitialized;
			if (!flag4)
			{
				goto IL_012f;
			}
		}
		else
		{
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v40+E4]");
			bool flag7 = (nint)0 == 0;
			object obj12 = !flag7;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string serverID = Config.ServerID;
			bool flag8 = serverID != serverId;
			object obj10 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v36+E4]");
			bool flag9 = (nint)0 == 0;
			object obj13 = !flag9;
			action = null;
			text = serverId;
			flag5 = flag8;
			action2 = null;
			text2 = serverId;
			flag6 = flag8;
			if (obj13 != null)
			{
				goto IL_012f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Games currentGame = Preferences.CurrentGame;
		object obj14 = !isConnected;
		object obj15 = flag6 | obj14;
		object obj16 = obj15 & 1;
		bool flag10 = obj16 == null;
		object obj17 = !flag10;
		action = action2;
		text = text2;
		if (obj17 == null)
		{
			goto IL_02ce;
		}
		goto IL_032e;
		IL_012f:
		currentGame = Preferences.CurrentGame;
		object obj18 = !isConnected;
		object obj19 = flag5 | obj18;
		object obj20 = obj19 & 1;
		if (obj20 == null)
		{
			goto IL_02ce;
		}
		action2 = action;
		text2 = text;
		goto IL_032e;
		IL_039a:
		Preferences.CurrentGame = game;
		bool flag11 = !isConnected;
		object obj21 = !flag11;
		object obj22 = 0;
		if (obj21 == null)
		{
			goto IL_03d0;
		}
		goto IL_04b3;
		IL_04b3:
		SFS.SwitchGame(game);
		object obj23 = typeof(RegisteredWaitHandle) + 3136;
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X0_v15+E4]");
		bool flag12 = (nint)0 == 0;
		object obj25 = !flag12;
		obj22 = 0;
		if (obj25 != null)
		{
			goto IL_0411;
		}
		goto IL_0511;
		IL_02ce:
		bool flag13 = currentGame != game;
		action2 = action;
		text2 = text;
		if (!flag13)
		{
			IntPtr invoke_impl = ((Delegate)callback).invoke_impl;
			IntPtr method_code = ((Delegate)callback).method_code;
			IntPtr method = ((Delegate)callback).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v169 @ X2_v5 (System.IntPtr) (should have been resolved before IL gen)");
		}
		goto IL_032e;
		IL_0411:
		ScreenManager.WaitForSceneExclusively(Scenes.Menu, callback);
		return;
		IL_03d0:
		object obj26 = typeof(RegisteredWaitHandle) + 3136;
		obj24 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X0_v15+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0411;
		}
		goto IL_0511;
		IL_0511:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_0411;
		IL_032e:
		object obj27 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v14+E4]");
		if ((nint)0 != 0)
		{
			Config.ServerID = serverId;
			object obj28 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v20+E4]");
			bool flag14 = (nint)0 == 0;
			object obj29 = 0;
			if (!flag14)
			{
				goto IL_039a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Config.ServerID = serverId;
			object obj28 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v20+E4]");
			bool flag15 = (nint)0 == 0;
			object obj30 = !flag15;
			object obj29 = 0;
			if (obj30 != null)
			{
				goto IL_039a;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Preferences.CurrentGame = game;
		bool flag16 = !isConnected;
		obj22 = 0;
		if (flag16)
		{
			goto IL_03d0;
		}
		goto IL_04b3;
	}

	public static void RequestJoinRoomOnLogin(RequestJoinRoomInfo info)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0037: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 64;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
		object obj3 = (nint)0 + (nint)8;
		obj3 = info;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void OnConnectionLost(string reason)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		UpdateStatus(LoginStatus.ConnectionLost);
		if (!InLoginScenes)
		{
			object obj = typeof(DataRelation) + 2304;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				DisconnectionPopup.Show();
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			DisconnectionPopup.Show();
		}
	}

	public void ForceDisconnectAndSwitchServer()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_01b5: Expected O, but got I
		//IL_01cf: Expected O, but got I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0057: Expected O, but got I
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected O, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_0221: Expected O, but got I4
		//IL_0308: Expected O, but got I4
		//IL_02a7: Expected O, but got I4
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected O, but got Unknown
		//IL_035c: Expected O, but got I
		//IL_036c: Expected O, but got I
		//IL_038e: Expected O, but got I4
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0118: Expected O, but got I
		//IL_0128: Expected O, but got I
		//IL_03ce: Expected O, but got I4
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		//IL_048e: Expected O, but got I
		//IL_049f: Expected I, but got O
		//IL_04bd: Expected O, but got I
		//IL_042d: Expected O, but got I4
		//IL_03fe: Expected O, but got I
		object obj = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E60E5]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			SFS.Disconnect();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E60E9]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				goto IL_0075;
			}
		}
		else
		{
			_ = 1;
			SFS.Disconnect();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E60E9]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_0075;
			}
		}
		_ = 1;
		object obj6 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3144;
		bool inLoginScenes = InLoginScenes;
		bool flag2 = !inLoginScenes;
		object obj7 = !flag2;
		object obj8 = obj6;
		if (obj7 != null)
		{
			goto IL_00b7;
		}
		goto IL_0237;
		IL_03ac:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v4+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj11;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj10 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v11+B8]");
			obj11 = 0;
		}
		object obj12 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)1992;
		Action<bool> action = default(Action<bool>);
		action..ctor(obj11, (IntPtr)obj13);
		object obj14 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v9+B8]");
		object obj15 = (nint)0 + (nint)16;
		obj15 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj17;
		object obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		object obj18 = !flag4;
		Action<bool> action2 = action;
		Action<bool> action3 = action;
		if (obj18 != null)
		{
			goto IL_018a;
		}
		goto IL_044b;
		IL_00f4:
		object obj19 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v4+B8]");
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v4+10]");
		action2 = (Action<bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v4+10]");
		bool flag5 = (nint)0 == 0;
		obj17 = obj19;
		if (!flag5)
		{
			goto IL_0155;
		}
		goto IL_03ac;
		IL_0326:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj20 = obj8;
		obj19 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v4+B8]");
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v4+10]");
		action2 = (Action<bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v4+10]");
		bool flag6 = (nint)0 == 0;
		object obj21 = !flag6;
		obj17 = obj19;
		obj6 = obj8;
		if (obj21 != null)
		{
			goto IL_0155;
		}
		goto IL_03ac;
		IL_0075:
		obj6 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3144;
		bool inLoginScenes2 = InLoginScenes;
		bool flag7 = !inLoginScenes2;
		obj8 = obj6;
		if (!flag7)
		{
			goto IL_00b7;
		}
		goto IL_0237;
		IL_0237:
		object obj22 = typeof(DataRelation) + 2304;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v17+E4]");
		object obj25;
		if ((nint)0 != 0)
		{
			DisconnectionPopup.Show();
			obj20 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v4+E4]");
			bool flag8 = (nint)0 == 0;
			object obj24 = !flag8;
			obj6 = obj8;
			if (obj24 != null)
			{
				goto IL_00f4;
			}
			obj25 = obj20;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			DisconnectionPopup.Show();
			obj20 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v4+E4]");
			bool flag9 = (nint)0 == 0;
			object obj26 = !flag9;
			obj6 = obj8;
			obj25 = obj20;
			if (obj26 != null)
			{
				goto IL_00f4;
			}
		}
		goto IL_0326;
		IL_044b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Config.LoadServersConfig(action3);
		return;
		IL_018a:
		Config.LoadServersConfig(action2);
		return;
		IL_0155:
		obj16 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v1+E4]");
		bool flag10 = (nint)0 == 0;
		action3 = action2;
		if (!flag10)
		{
			goto IL_018a;
		}
		goto IL_044b;
		IL_00b7:
		obj20 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v4+E4]");
		bool flag11 = (nint)0 == 0;
		obj8 = obj6;
		obj25 = obj20;
		if (!flag11)
		{
			goto IL_00f4;
		}
		goto IL_0326;
	}

	public void GoOffline()
	{
		UpdateStatus(LoginStatus.OfflineGame);
	}

	public void OnLogout(BaseEvent _ = null)
	{
		UpdateStatus(LoginStatus.LoggedOut);
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0060: Expected O, but got I
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0223: Expected I, but got O
		//IL_00a5: Expected I, but got O
		//IL_00d0: Expected I, but got O
		//IL_00f4: Expected O, but got I
		//IL_0102: Expected I, but got O
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_013f: Expected O, but got I
		//IL_014d: Expected I, but got O
		//IL_0171: Expected O, but got I
		//IL_017f: Expected I, but got O
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_01bc: Expected O, but got I
		//IL_01ca: Expected I, but got O
		//IL_01ee: Expected O, but got I
		//IL_01fc: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 280;
		object obj2 = (nint)0 + (nint)3416;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj4 = (nint)0 + (nint)3424;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1264;
		object obj6 = (nint)0 + (nint)3448;
		object obj7 = typeof(DataRelation) + 3728;
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool, object> action = default(Action<bool, object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnConnection += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj4);
		SFS.OnConnectionLost += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj6);
		SFS.OnLogin += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = (nint)0 + (nint)3456;
		EventListenerDelegate eventListenerDelegate = default(EventListenerDelegate);
		eventListenerDelegate..ctor(this, (IntPtr)obj9);
		SFS.OnLogoutNotReliable += eventListenerDelegate;
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)3464;
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj11);
		SFS.OnLoginError += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)3432;
		Action<object> action5 = default(Action<object>);
		action5..ctor((object)this, (IntPtr)obj12);
		SFS.OnJoinRoom += action5;
		object obj13 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)3440;
		Action<object, object> action6 = default(Action<object, object>);
		action6..ctor((object)this, (IntPtr)obj14);
		SFS.OnJoinRoomFailed += action6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)3472;
		Action<object> action7 = default(Action<object>);
		action7..ctor((object)this, (IntPtr)obj15);
		SFS.OnJoinGameRoom += action7;
	}

	private void OnConnection(bool success, string error)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_005a: Expected O, but got I4
		if (success)
		{
			UpdateStatus(LoginStatus.Connected);
			LoginToSfs();
			return;
		}
		object obj = typeof(DataRelation) + 856;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogError(error);
		UpdateStatus(LoginStatus.ConnectionFailed);
		ShowErrorInLoginScene();
	}

	private void OnLogin(BaseEvent evt)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_088e: Expected O, but got I4
		//IL_08c0: Expected O, but got I
		//IL_021d: Expected O, but got I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0081: Expected O, but got I
		//IL_0099: Expected O, but got I
		//IL_02f8: Expected O, but got I4
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_0269: Expected O, but got I
		//IL_0281: Expected O, but got I
		//IL_0761: Expected O, but got I
		//IL_077b: Expected O, but got I4
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected O, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_0364: Expected I, but got O
		//IL_0374: Expected O, but got I
		//IL_0133: Expected O, but got I
		//IL_0446: Expected O, but got I
		//IL_046f: Expected O, but got I
		//IL_07f1: Expected O, but got I
		//IL_0821: Expected O, but got I4
		//IL_07b9: Expected O, but got I4
		//IL_03af: Expected O, but got I
		//IL_0195: Expected O, but got I
		//IL_0934: Unknown result type (might be due to invalid IL or missing references)
		//IL_0939: Expected O, but got Unknown
		//IL_0948: Unknown result type (might be due to invalid IL or missing references)
		//IL_094d: Expected O, but got Unknown
		//IL_0984: Expected O, but got I4
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Expected I, but got Unknown
		//IL_04b5: Expected O, but got I4
		//IL_08ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f4: Expected O, but got Unknown
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Expected O, but got Unknown
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected O, but got Unknown
		//IL_051c: Expected O, but got I
		//IL_0540: Expected O, but got I4
		//IL_0560: Expected O, but got I
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Expected O, but got Unknown
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected O, but got Unknown
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected O, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected O, but got Unknown
		//IL_0624: Expected O, but got I4
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected O, but got Unknown
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Expected O, but got Unknown
		//IL_06a2: Expected O, but got I4
		//IL_06c4: Expected O, but got I
		//IL_0671: Expected O, but got I4
		//IL_0704: Unknown result type (might be due to invalid IL or missing references)
		//IL_0709: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		ISFSObject data = SFSExtensions.GetData(evt);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Config.SetServerExtraConfigs(data, isLogin: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4591]");
		object obj4 = (nint)0 & (nint)1;
		object obj5;
		if (obj4 != null)
		{
			obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v62+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = obj5;
			if (!flag2)
			{
				goto IL_005d;
			}
		}
		else
		{
			_ = 1;
			obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v62+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			object obj6 = obj5;
			if (obj7 != null)
			{
				goto IL_005d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj5 = obj;
		object obj8 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v62+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v32+50]");
		object obj10 = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v32+50]");
		bool flag4 = (nint)0 == 1;
		bool flag6 = default(bool);
		bool flag5 = flag6;
		bool flag7 = flag4;
		object obj11 = obj10;
		object obj12 = obj8;
		if (flag4)
		{
			goto IL_00f8;
		}
		goto IL_02ce;
		IL_01c8:
		Store.ClearCacheAndRefreshStore();
		flag5 = flag6;
		flag7 = flag4;
		obj11 = obj10;
		goto IL_031f;
		IL_082f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_01c8;
		IL_0925:
		object obj13 = typeof(UsageHint) + 72;
		object obj14 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		User user;
		string dbId = SFSKammelnaUserExtensions.GetDbId(user);
		object obj15 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v10+E4]");
		bool flag8 = (nint)0 == 0;
		object obj16 = !flag8;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UserInfo.UserDbId = dbId;
		string email = SFSKammelnaUserExtensions.GetEmail(user);
		object obj17 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v11+E4]");
		object obj18;
		object obj19;
		if ((nint)0 != 0)
		{
			obj18 = typeof(System.Formats.Asn1.SetOfValueComparer) + 64;
			if (!StringsExtensions.IsNullOrEmpty(email))
			{
				goto IL_063a;
			}
			obj19 = obj18;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = typeof(System.Formats.Asn1.SetOfValueComparer) + 64;
			bool flag9 = StringsExtensions.IsNullOrEmpty(email);
			bool flag10 = !flag9;
			object obj20 = !flag10;
			obj19 = obj18;
			if (obj20 == null)
			{
				goto IL_063a;
			}
		}
		goto IL_068e;
		IL_056e:
		object obj22;
		object obj21 = obj22;
		user = null;
		goto IL_0925;
		IL_031f:
		IDictionary<string, object> dictionary = evt.Params;
		object obj23 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2496;
		object obj24 = "tournament_participate_warning_body_with_tickets_warning_daily" + 3904;
		User user2 = (User)obj24;
		nint num = (nint)dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v21 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v21 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_042c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v21 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
		object obj26 = (nint)0 + (nint)8;
		bool flag11 = flag5;
		object obj27 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X10_v3-8]");
			obj11 = 0 - obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X10_v3-8]");
			flag7 = 0 == (nint)obj23;
			InvalidCastException ex = (InvalidCastException)dictionary;
			if (flag7)
			{
				break;
			}
			obj27 = obj26 + 16;
			obj25--;
			obj11 = obj25 - 1;
			flag7 = obj11 == null;
			flag5 = (nint)obj25 != 1;
			obj26 = obj27;
			flag11 = flag5;
			if (flag5)
			{
				continue;
			}
			goto IL_042c;
		}
		goto IL_04f1;
		IL_005d:
		obj8 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v62+B8]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v53+50]");
		obj10 = -1;
		flag4 = obj10 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v53+50]");
		flag6 = (nint)0 != 1;
		flag5 = flag6;
		flag7 = flag4;
		obj11 = obj10;
		obj12 = obj8;
		if (!flag6)
		{
			goto IL_00f8;
		}
		goto IL_02ce;
		IL_02ce:
		object obj29 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v51+E4]");
		bool flag12 = (nint)0 == 0;
		object obj30 = !flag12;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Store.LoadStore();
		goto IL_031f;
		IL_04f1:
		object obj31 = num + obj26;
		object obj32 = obj31 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v23+8]");
		obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v439 @ X8_v23] (should have been resolved before IL gen)");
		object obj33 = default(object);
		bool flag13 = obj33 == null;
		object obj34 = !flag13;
		obj27 = obj26;
		flag5 = flag11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v23+8]");
		obj22 = 0;
		if (obj34 != null)
		{
			goto IL_047d;
		}
		goto IL_056e;
		IL_063a:
		string email2 = SFSKammelnaUserExtensions.GetEmail(user);
		object obj35 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X8_v19+E4]");
		bool flag14 = (nint)0 == 0;
		object obj36 = !flag14;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UserInfo.Email = email2;
		obj19 = obj18;
		goto IL_068e;
		IL_00f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v62+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4592]");
			object obj37 = (nint)0 & (nint)1;
			if (obj37 != null)
			{
				goto IL_0150;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4592]");
			object obj38 = (nint)0 & (nint)1;
			bool flag15 = obj38 == null;
			object obj39 = !flag15;
			if (obj39 != null)
			{
				goto IL_0150;
			}
		}
		_ = 1;
		object obj40 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v77+E4]");
		bool flag16 = (nint)0 == 0;
		object obj41 = !flag16;
		object obj42 = obj40;
		if (obj41 != null)
		{
			goto IL_0185;
		}
		goto IL_07cf;
		IL_047d:
		num = (nint)(typeof(UsageHint) + 8);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		User user3 = default(User);
		bool flag17 = user3 == null;
		object obj43 = !flag17;
		user = user3;
		if (obj43 == null)
		{
			InvalidCastException ex = new InvalidCastException();
			obj26 = obj27;
			flag11 = flag5;
			user2 = user3;
			goto IL_04f1;
		}
		goto IL_0925;
		IL_042c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v46+8]");
		obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v367 @ X0_v46] (should have been resolved before IL gen)");
		bool flag18 = obj33 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v46+8]");
		obj22 = 0;
		if (!flag18)
		{
			goto IL_047d;
		}
		goto IL_056e;
		IL_068e:
		object obj44 = this + 48;
		obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj45 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X8_v13+B8]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v14+1]");
		if ((nint)0 == 1)
		{
			ITrackEvent trackEvent = TrackerLibrary.AccountAutoLoginSucceeded();
			object obj47 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj48 = obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v18+E4]");
			if ((nint)0 != 0)
			{
				Tracker.DesignEvent(trackEvent);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
		}
		return;
		IL_0150:
		obj40 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v77+E4]");
		bool flag19 = (nint)0 == 0;
		obj42 = obj40;
		if (!flag19)
		{
			goto IL_0185;
		}
		goto IL_07cf;
		IL_07cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj49 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v67+B8]");
		object obj50 = 0;
		_ = 0;
		object obj51 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v63+E4]");
		bool flag20 = (nint)0 == 0;
		object obj52 = !flag20;
		if (obj52 != null)
		{
			goto IL_01c8;
		}
		goto IL_082f;
		IL_0185:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v77+B8]");
		object obj53 = 0;
		_ = 0;
		obj51 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v63+E4]");
		if ((nint)0 != 0)
		{
			goto IL_01c8;
		}
		goto IL_082f;
	}

	private void OnSfsLoginError(LoginError loginError)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_003d: Expected O, but got I
		//IL_0052: Expected O, but got I
		//IL_006a: Expected O, but got I4
		//IL_0084: Expected O, but got I4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00ac: Expected O, but got I4
		//IL_00d6: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 64;
		object obj2 = (nint)0 + (nint)2248;
		object obj3 = this + 48;
		obj3 = loginError;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		StopAllCoroutines();
		SFS.DiscardClient();
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v3+B8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v4+20]");
		Actions.SafeInvoke((Action<object>)0, loginError);
		object obj6 = loginError.<Error>k__BackingField + 1;
		bool flag = (nint)obj6 < 12;
		object obj7 = !flag;
		object obj8 = obj6 - 12;
		bool flag2 = obj8 == null;
		object obj9 = !flag2;
		object obj10 = obj7 & obj9;
		if (obj10 == null)
		{
			object obj11 = 119873536 + 2844;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X10_v2+v74 @ X9_v1]");
			object obj12 = (nint)82788292 + (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v91 @ X11_v2 (should have been resolved before IL gen)");
		}
		UpdateStatus(LoginStatus.LoginFailed);
		ShowErrorInLoginScene();
	}

	private void OnJoinRoom(Room room)
	{
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_01d1: Expected O, but got I
		//IL_01eb: Expected O, but got I4
		//IL_0122: Expected O, but got I
		//IL_0261: Expected O, but got I
		//IL_0229: Expected O, but got I4
		//IL_02f8: Expected O, but got I
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_009b: Expected O, but got I4
		//IL_0184: Expected O, but got I
		//IL_02a8: Expected O, but got I4
		if (LoginStatus != LoginStatus.LoggingIn)
		{
			return;
		}
		UpdateStatus(LoginStatus.LoggedIn);
		if (InLoginScenes)
		{
			if (SFSKammelnaRoomExtensions.IsLobby(room))
			{
				object obj = typeof(RegisteredWaitHandle) + 3136;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v27+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.LoadScene(Scenes.Menu);
			}
			goto IL_02d3;
		}
		object obj4 = typeof(RegisteredWaitHandle) + 3136;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
			object obj6 = (nint)0 & (nint)1;
			if (obj6 != null)
			{
				goto IL_013f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			if (obj8 != null)
			{
				goto IL_013f;
			}
		}
		_ = 1;
		object obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		object obj11 = obj9;
		if (obj10 != null)
		{
			goto IL_0174;
		}
		goto IL_023f;
		IL_013f:
		obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		obj11 = obj9;
		if (!flag4)
		{
			goto IL_0174;
		}
		goto IL_023f;
		IL_0174:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v8+B8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v19+18]");
		if ((nint)0 != 4)
		{
			goto IL_0286;
		}
		goto IL_02d3;
		IL_02d3:
		List<DateTime> disconnectionHistory = _disconnectionHistory;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v6 (System.Collections.Generic.List`1<System.DateTime>)+1C]");
		object obj13 = (nint)0 + (nint)1;
		_ = 0;
		return;
		IL_0286:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v8+E4]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncOperationHandle<SceneInstance> asyncOperationHandle2 = ScreenManager.ReloadScene();
		goto IL_02d3;
		IL_023f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v8+B8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v12+18]");
		if ((nint)0 != 4)
		{
			goto IL_0286;
		}
		goto IL_02d3;
	}

	private void OnJoinRoomFailed(Room room, string error)
	{
		StopAllCoroutines();
		if (LoginStatus == LoginStatus.LoggingIn)
		{
			SFS.Disconnect();
			UpdateStatus(LoginStatus.LoginFailed);
		}
	}

	private void StartPingPongWatchdog(Room room)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		object obj = this + 40;
		if (obj != null)
		{
			StopCoroutine((Coroutine)obj);
		}
		object obj2 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		_ = 0;
		object obj4 = obj3 + 32;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine pingPongWatchdogCoroutine = StartCoroutine((IEnumerator)obj3);
		_pingPongWatchdogCoroutine = pingPongWatchdogCoroutine;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private IEnumerator PingPongWatchdogCoroutine()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private void ConnectToSfs()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01f0: Expected O, but got I
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_0218: Expected O, but got I4
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_036d: Expected O, but got I4
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		//IL_0246: Expected O, but got I
		//IL_0256: Expected O, but got I
		//IL_0266: Expected O, but got I
		//IL_0288: Expected O, but got I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0057: Expected O, but got I4
		//IL_01b7: Expected I, but got O
		//IL_016a: Expected O, but got I4
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected O, but got Unknown
		//IL_02c9: Expected O, but got I
		//IL_02da: Expected I, but got O
		//IL_02f8: Expected O, but got I
		//IL_0312: Expected I4, but got O
		//IL_0123: Expected O, but got I
		//IL_012c: Expected O, but got I4
		//IL_019a: Expected O, but got I
		//IL_00d1: Expected O, but got I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 64;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3+B8]");
		object obj3 = 0;
		object obj4 = obj3 & 1;
		bool flag = obj4 == null;
		object obj5 = !flag;
		if (obj5 == null)
		{
			object obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v21+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SFSConfig currentSFS = Config.CurrentSFS;
			if (currentSFS.<IsFastTrack>k__BackingField)
			{
				object obj9 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v27+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object serverID = ", stale={0}" + 3424;
				Config.ServerID = (string)serverID;
			}
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v21+B8]");
			object obj12 = 0;
			obj12 = 1;
		}
		object obj13 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3144;
		UpdateStatus(LoginStatus.Connecting);
		SFS.Connect();
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v6+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj13;
		}
		object obj16 = typeof(SqlSingle[]) + 2376;
		object obj17 = (nint)0 + (nint)3480;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v6+B8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v10+18]");
		Func<bool> cancelCondition = (Func<bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v10+18]");
		bool flag5 = (nint)0 == 0;
		object obj19 = !flag5;
		LoginStatus loginStatus = LoginStatus.Connecting;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v6+E4]");
			bool flag6 = (nint)0 == 0;
			object obj20 = !flag6;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj21 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v16+B8]");
				obj18 = 0;
			}
			object obj22 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2128;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj23 = (nint)0 + (nint)1984;
			Func<bool> func = default(Func<bool>);
			func..ctor(obj18, (IntPtr)obj23);
			object obj24 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v15+B8]");
			object obj25 = (nint)0 + (nint)24;
			obj25 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			loginStatus = (LoginStatus)func;
			cancelCondition = func;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj17);
		Coroutine coroutine = UIExtensions.SetTimeout(this, 15f, cancelCondition, action);
	}

	private void LoginToSfs()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0149: Expected I, but got O
		//IL_0071: Expected O, but got I4
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_016e: Expected O, but got I
		//IL_017e: Expected O, but got I
		//IL_018e: Expected O, but got I
		//IL_01b0: Expected O, but got I4
		//IL_01b9: Expected O, but got I4
		//IL_0105: Expected I, but got O
		//IL_00b8: Expected O, but got I4
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_0203: Expected O, but got I
		//IL_020b: Expected I, but got O
		//IL_021c: Expected I, but got O
		//IL_023a: Expected O, but got I
		//IL_0255: Expected O, but got I4
		//IL_025d: Expected I4, but got O
		//IL_00e8: Expected O, but got I
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 480;
		object obj2 = (nint)0 + (nint)3408;
		object obj3 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3144;
		UpdateStatus(LoginStatus.LoggingIn);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		KammelnaRequests.RefreshAuthTokens(action);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj3;
		}
		object obj6 = typeof(SqlSingle[]) + 2376;
		object obj7 = (nint)0 + (nint)3480;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v7+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v6+20]");
		Func<bool> cancelCondition = (Func<bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v6+20]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		object obj10 = 0;
		bool flag3 = false;
		nint num = 0;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v7+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj12 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v12+B8]");
				obj8 = 0;
			}
			object obj13 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2128;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)2000;
			num = (nint)obj14;
			Func<bool> func = default(Func<bool>);
			func..ctor(obj8, (IntPtr)obj14);
			object obj15 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v11+B8]");
			object obj16 = (nint)0 + (nint)32;
			obj16 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj10 = 0;
			flag3 = (byte)(int)func != 0;
			cancelCondition = func;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj7);
		Coroutine coroutine = UIExtensions.SetTimeout(this, 15f, cancelCondition, action2);
	}

	private void LoginWithToken(KammelnaResponseModel<AuthModel> response)
	{
		//IL_0011: Expected O, but got I
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0087: Expected O, but got I
		//IL_00a1: Expected O, but got I
		//IL_00bf: Expected O, but got I
		//IL_00c8: Expected O, but got I4
		object obj = (nint)0 + (nint)984;
		if (((KammelnaResponseModel<object>)(object)response).Succeeded)
		{
			AuthModel <Model>k__BackingField = response.<Model>k__BackingField;
			TokenModel <AccessToken>k__BackingField = <Model>k__BackingField.<AccessToken>k__BackingField;
			object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 64;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v10+B8]");
			object obj4 = 0;
			string <Token>k__BackingField = <AccessToken>k__BackingField.<Token>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v11+8]");
			SFS.Login(<Token>k__BackingField, (RequestJoinRoomInfo)0);
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v12+B8]");
			object obj6 = (nint)0 + (nint)8;
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			object obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3072;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			LoginError loginError = default(LoginError);
			loginError..ctor(LoginErrorCode.IncorrectInfo);
			OnSfsLoginError(loginError);
			UpdateStatus(LoginStatus.LoginFailed);
			ShowErrorInLoginScene();
		}
	}

	private void OnServerLockedDown()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		//IL_034c: Expected O, but got I4
		//IL_013d: Expected O, but got I
		//IL_014d: Expected O, but got I
		//IL_015d: Expected O, but got I
		//IL_017f: Expected O, but got I4
		//IL_00c9: Expected I, but got O
		//IL_00f4: Expected O, but got I4
		//IL_0074: Expected O, but got I
		//IL_0084: Expected O, but got I
		//IL_0094: Expected O, but got I
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_025b: Expected O, but got I
		//IL_0285: Expected O, but got I4
		//IL_01b7: Expected O, but got I4
		//IL_02b3: Expected O, but got I
		//IL_011a: Expected I, but got O
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected O, but got Unknown
		//IL_0384: Expected O, but got I
		//IL_0395: Expected I, but got O
		//IL_03b3: Expected O, but got I
		//IL_02ca: Expected I, but got O
		//IL_02d8: Expected I, but got O
		//IL_02ea: Expected O, but got I4
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected O, but got Unknown
		//IL_0303: Expected O, but got I4
		//IL_01f4: Expected I, but got O
		//IL_0225: Expected O, but got I4
		//IL_022d: Expected I, but got O
		//IL_01e7: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj2 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3144;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		List<SFSConfig> allServers = Config.GetAllServers(includeRestricted: true);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v18+E4]");
		object obj6;
		object obj7;
		Func<object, bool> func;
		object obj8;
		if ((nint)0 != 0)
		{
			obj6 = (nint)0 + (nint)1176;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v18+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v9+28]");
			func = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v9+28]");
			bool flag2 = (nint)0 == 0;
			obj8 = obj6;
			if (!flag2)
			{
				goto IL_00c1;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj2;
			obj6 = (nint)0 + (nint)1176;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v18+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v9+28]");
			func = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v9+28]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			obj8 = obj6;
			if (obj9 != null)
			{
				goto IL_00c1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v18+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v15+B8]");
			obj7 = 0;
		}
		object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)2008;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor(obj7, (IntPtr)obj13);
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v14+B8]");
		object obj15 = (nint)0 + (nint)40;
		obj15 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num = (nint)obj8;
		object obj16 = Enumerable.FirstOrDefault(allServers, func2);
		bool flag5 = obj16 == null;
		Func<object, bool> func3 = func2;
		object obj17 = 0;
		nint num2 = (nint)obj8;
		if (!flag5)
		{
			goto IL_023b;
		}
		goto IL_02ef;
		IL_02ef:
		object obj18 = this + 48;
		obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_023b:
		object obj19 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj20 = (nint)0 + (nint)3392;
		object obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v11+E4]");
		bool flag6 = (nint)0 == 0;
		object obj22 = !flag6;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v10 (System.Object)+10]");
		Config.ServerID = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		num2 = (nint)obj20;
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj20);
		Config.LoadServersConfig(action);
		obj17 = 0;
		goto IL_02ef;
		IL_00c1:
		num = (nint)obj6;
		obj16 = Enumerable.FirstOrDefault(allServers, func);
		bool flag7 = obj16 == null;
		object obj23 = !flag7;
		func3 = func;
		if (obj23 != null)
		{
			goto IL_023b;
		}
		object obj24 = default(object);
		obj17 = obj24;
		num2 = (nint)obj6;
		goto IL_02ef;
	}

	private void UpdateStatus(LoginStatus status)
	{
		//IL_0269: Expected O, but got I4
		//IL_0283: Expected O, but got I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_008c: Expected O, but got I
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_02ca: Expected O, but got I
		//IL_02e9: Expected O, but got I
		//IL_0115: Expected O, but got I4
		//IL_00e0: Expected O, but got I
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_017c: Expected O, but got I4
		//IL_0224: Expected O, but got I4
		//IL_0196: Expected O, but got I
		//IL_01ae: Expected O, but got I
		//IL_01cb: Expected O, but got I
		LoginStatus = status;
		object obj = status - 4;
		bool flag = (nint)obj < 2;
		object obj2 = !flag;
		object obj3 = ~obj2;
		if (obj3 == null)
		{
			if (status == LoginStatus.LoginFailed)
			{
				goto IL_004d;
			}
			if (status != LoginStatus.ConnectionLost)
			{
				goto IL_0058;
			}
		}
		RecordDisconnectionEvent();
		goto IL_004d;
		IL_004d:
		StopAllCoroutines();
		goto IL_0058;
		IL_0058:
		object obj4 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3120;
		object obj5 = typeof(System.Formats.Asn1.SetOfValueComparer) + 64;
		object obj6 = (nint)0 + (nint)2256;
		object obj7 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		if (LoginStatusExtensions.IsFailingStatus(LoginStatus))
		{
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v14+B8]");
			object obj9 = 0;
			_ = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		object obj10 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v6+B8]");
		object obj11 = 0;
		object obj12 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v7+18]");
		Actions.SafeInvoke((Action<System.Int32Enum>)0, (System.Int32Enum)LoginStatus);
		object obj13 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj14 = !flag2;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object format = "___# Content push apply failed [{0}]: {1}" + 536;
		object obj15 = typeof(DataRelation) + 856;
		bool flag3 = StringsExtensions.IsNullOrEmpty(friendlyName);
		bool flag4 = !flag3;
		object obj16 = !flag4;
		if (obj16 == null)
		{
			object obj17 = (nint)0 + (nint)2336;
			object obj18 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X9_v3+B8]");
			object obj19 = 0;
			obj12 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X9_v4+10]");
			Actions.SafeInvoke((Action<object>)0, friendlyName);
			SplashAnimation.SetStatusMessage(friendlyName);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string text = string.Format((string)format, arg);
		object obj20 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v11+E4]");
		bool flag5 = (nint)0 == 0;
		object obj21 = !flag5;
		object message = text;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message = text;
		}
		Debug.Log(message);
	}

	private void RecordDisconnectionEvent()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0100: Expected O, but got I4
		//IL_00ab: Expected O, but got I4
		//IL_0155: Expected O, but got I
		//IL_016a: Expected O, but got I
		//IL_0198: Expected O, but got I4
		//IL_01bc: Expected O, but got I
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		object obj = typeof(DataRelation) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E601B]");
		object obj2 = (nint)0 & (nint)1;
		List<DateTime> disconnectionHistory;
		List<DateTime> disconnectionHistory2;
		if (obj2 != null)
		{
			disconnectionHistory = _disconnectionHistory;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			disconnectionHistory2 = _disconnectionHistory;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			disconnectionHistory = _disconnectionHistory;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			disconnectionHistory2 = _disconnectionHistory;
			if (obj4 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		DateTime now = DateTime.Now;
		List<DateTime> list = disconnectionHistory2;
		goto IL_013d;
		IL_013d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X19_v3 (System.Collections.Generic.List`1<System.DateTime>)+1C]");
		object obj5 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X19_v3 (System.Collections.Generic.List`1<System.DateTime>)+10]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X19_v3 (System.Collections.Generic.List`1<System.DateTime>)+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X9_v4+18]");
		bool flag3 = num < 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X19_v3 (System.Collections.Generic.List`1<System.DateTime>)+18]");
			object obj8 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X19_v3 (System.Collections.Generic.List`1<System.DateTime>)+18]");
			object obj9 = obj6 + 0;
		}
		else
		{
			list.AddWithResize(now);
		}
		return;
		IL_0088:
		now = DateTime.Now;
		bool flag4 = disconnectionHistory == null;
		object obj10 = !flag4;
		list = disconnectionHistory;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_013d;
	}

	private void SwitchToDefaultServer()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00d4: Expected O, but got I4
		//IL_0114: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E60E7]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = Config.SwitchToDefaultServer();
		bool flag3 = !flag2;
		object obj6 = !flag3;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0122;
		IL_0122:
		UpdateStatus(LoginStatus.LoginFailed);
		ShowErrorInLoginScene();
		return;
		IL_007d:
		if (Config.SwitchToDefaultServer())
		{
			return;
		}
		goto IL_0122;
	}

	private void LoginFailed_GoToLogin()
	{
		UpdateStatus(LoginStatus.LoginFailed);
		ShowErrorInLoginScene();
	}

	private void ConnectionFailed_GoToLogin()
	{
		UpdateStatus(LoginStatus.ConnectionFailed);
		ShowErrorInLoginScene();
	}

	public static void ShowErrorInLoginScene()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_014e: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_01d4: Expected O, but got I4
		//IL_017c: Expected O, but got I
		//IL_0196: Expected O, but got I4
		//IL_00f5: Expected O, but got I
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		//IL_026f: Expected O, but got I4
		//IL_020c: Expected O, but got I
		//IL_029c: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E601C]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v14+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
		object obj6 = (nint)0 & (nint)1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			goto IL_00b0;
		}
		goto IL_01a4;
		IL_0231:
		object obj8 = typeof(RegisteredWaitHandle) + 1552;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RoutingManager.Route(RoutingCommand.Login_Error, null, (Games?)(object)0);
		return;
		IL_00e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v24+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v18+18]");
		if ((nint)0 == 2)
		{
			return;
		}
		goto IL_0231;
		IL_01ea:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v8+B8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v7+18]");
		if ((nint)0 == 2)
		{
			return;
		}
		goto IL_0231;
		IL_007d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
		object obj14 = (nint)0 & (nint)1;
		if (obj14 != null)
		{
			goto IL_00b0;
		}
		goto IL_01a4;
		IL_01a4:
		_ = 1;
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v24+E4]");
		bool flag4 = (nint)0 == 0;
		object obj16 = !flag4;
		object obj17 = obj15;
		if (obj16 != null)
		{
			goto IL_00e5;
		}
		goto IL_01ea;
		IL_00b0:
		obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v24+E4]");
		bool flag5 = (nint)0 == 0;
		obj17 = obj15;
		if (!flag5)
		{
			goto IL_00e5;
		}
		goto IL_01ea;
	}

	private void RegisterInNewGame()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj2 = (nint)0 + (nint)3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		KammelnaRequests.RegisterInGame(action);
	}

	private void ShowNewVersionPopup()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0155: Expected O, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a9: Expected O, but got I
		//IL_00b9: Expected O, but got I
		//IL_020b: Expected O, but got I4
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_01a1: Expected O, but got I
		//IL_01b1: Expected O, but got I
		//IL_01d3: Expected O, but got I4
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02cb: Expected O, but got I
		//IL_02dc: Expected I, but got O
		//IL_02fa: Expected O, but got I
		//IL_026a: Expected O, but got I4
		//IL_023b: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3144;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E601D]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v4+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v4+E4]");
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
		object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v4+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+30]");
		Action<bool> action = (Action<bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+30]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_00e6;
		}
		goto IL_01e9;
		IL_00e6:
		object obj11 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		Action<bool> action2 = action;
		if (!flag4)
		{
			goto IL_011b;
		}
		goto IL_0288;
		IL_0288:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Config.LoadServersConfig(action2);
		return;
		IL_011b:
		Config.LoadServersConfig(action);
		return;
		IL_0085:
		obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v4+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+30]");
		action = (Action<bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+30]");
		bool flag5 = (nint)0 == 0;
		obj10 = obj7;
		if (!flag5)
		{
			goto IL_00e6;
		}
		goto IL_01e9;
		IL_01e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v4+E4]");
		bool flag6 = (nint)0 == 0;
		object obj12 = !flag6;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v11+B8]");
			obj8 = 0;
		}
		object obj14 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)2016;
		Action<bool> action3 = default(Action<bool>);
		action3..ctor(obj8, (IntPtr)obj15);
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v9+B8]");
		object obj17 = (nint)0 + (nint)48;
		obj17 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v1+E4]");
		bool flag7 = (nint)0 == 0;
		object obj18 = !flag7;
		action = action3;
		action2 = action3;
		if (obj18 != null)
		{
			goto IL_011b;
		}
		goto IL_0288;
	}

	private void TimeoutCallback()
	{
		UpdateStatus(LoginStatus.ConnectionTimeout);
		SFS.Disconnect();
	}

	private void ShowDisconnectionPopup()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		if (!InLoginScenes)
		{
			object obj = typeof(DataRelation) + 2304;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				DisconnectionPopup.Show();
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			DisconnectionPopup.Show();
		}
	}

	public SfsConnectionManager()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_008c: Expected O, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_0058: Expected O, but got I4
		object obj = typeof(List<AdaptivePerformanceScaler>) + 776;
		object obj2 = typeof(Queue<string>) + 856;
		object obj3 = (nint)0 + (nint)2208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<DateTime> list = default(List<DateTime>);
		list..ctor();
		object obj4 = this + 32;
		obj4 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v7+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
	}

	private void <OnServerLockedDown>b__45_1(bool _)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_00a7: Expected O, but got I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00f3: Expected O, but got I4
		object obj = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E60E9]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			if (InLoginScenes)
			{
				goto IL_0062;
			}
		}
		else
		{
			int num = 1;
			bool inLoginScenes = InLoginScenes;
			bool flag = !inLoginScenes;
			object obj3 = !flag;
			if (obj3 != null)
			{
				goto IL_0062;
			}
		}
		object obj4 = typeof(DataRelation) + 2304;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DisconnectionPopup.Show();
		UpdateStatus(LoginStatus.LoginFailed);
		ShowErrorInLoginScene();
		return;
		IL_0062:
		UpdateStatus(LoginStatus.LoginFailed);
		ShowErrorInLoginScene();
	}

	private void <RegisterInNewGame>b__52_0(KammelnaResponseModel<bool> response)
	{
		Login();
	}
}
