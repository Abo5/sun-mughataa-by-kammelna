using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public static class LanBackendScanner
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<string, bool> <>9__6_0;

		public static Func<Task, AggregateException> <>9__7_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1528;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <SweepSubnet>b__6_0(string url)
		{
			bool flag = url == null;
			return !flag;
		}

		internal AggregateException <ProbeHost>b__7_0(Task t)
		{
			if (t != null)
			{
				return t.Exception;
			}
			return (AggregateException)(object)new NullReferenceException();
		}
	}

	private sealed class <>c__DisplayClass5_0
	{
		[StructLayout((LayoutKind)3)]
		private struct <<Scan>b__2>d : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncTaskMethodBuilder <>t__builder;

			public <>c__DisplayClass5_0 <>4__this;

			private <>c__DisplayClass5_1 <>8__1;

			private TaskAwaiter<List<string>> <>u__1;

			private unsafe void MoveNext()
			{
				//IL_0622: Unknown result type (might be due to invalid IL or missing references)
				//IL_0627: Expected O, but got Unknown
				//IL_01c5: Expected O, but got I4
				//IL_01d4: Expected I4, but got I8
				//IL_01e1: Expected I4, but got I8
				//IL_067e: Expected O, but got Ref
				//IL_0014: Unknown result type (might be due to invalid IL or missing references)
				//IL_0019: Expected I, but got Unknown
				//IL_003c: Expected O, but got Ref
				//IL_05d7: Expected I4, but got I8
				//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fe: Expected O, but got Unknown
				//IL_021f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0224: Expected O, but got Unknown
				//IL_06e9: Expected O, but got I4
				//IL_023f: Expected O, but got I
				//IL_0247: Expected I, but got O
				//IL_0258: Expected I, but got O
				//IL_0267: Unknown result type (might be due to invalid IL or missing references)
				//IL_026c: Expected O, but got Unknown
				//IL_02a6: Expected O, but got I4
				//IL_0074: Unknown result type (might be due to invalid IL or missing references)
				//IL_0079: Expected O, but got Unknown
				//IL_02d5: Expected O, but got I4
				//IL_0431: Unknown result type (might be due to invalid IL or missing references)
				//IL_0436: Expected O, but got Unknown
				//IL_06b2: Expected I4, but got I8
				//IL_0495: Unknown result type (might be due to invalid IL or missing references)
				//IL_049a: Expected O, but got Unknown
				//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f8: Expected O, but got Unknown
				//IL_04b1: Expected I, but got O
				//IL_0116: Expected O, but got I4
				//IL_0591: Expected O, but got I4
				//IL_04f1: Expected I4, but got I8
				//IL_04fc: Expected O, but got Ref
				//IL_050b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0510: Expected O, but got Unknown
				//IL_0142: Expected O, but got Ref
				//IL_017e: Expected O, but got I4
				//IL_0541: Expected O, but got I4
				//IL_01a7: Expected O, but got Ref
				object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1192;
				int num = <>1__state;
				<>c__DisplayClass5_0 <>c__DisplayClass5_ = <>4__this;
				TaskAwaiter<object> taskAwaiter;
				object obj9;
				nint num2;
				if (<>1__state != 0)
				{
					num2 = (nint)(typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1544);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj2 = default(object);
					obj2..ctor();
					object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 40));
					obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					if (obj3 != null)
					{
						object obj4 = obj3 + 24;
						obj4 = <>4__this;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						if (<>4__this != null)
						{
							Task<List<string>> task = SweepSubnet(<>c__DisplayClass5_.localIp);
							if (task != null)
							{
								TaskAwaiter<object> awaiter = ((Task<object>)(object)task).GetAwaiter();
								TaskAwaiter<object> awaiter2 = default(TaskAwaiter<object>);
								bool isCompleted = awaiter2.IsCompleted;
								bool flag = !isCompleted;
								object obj5 = !flag;
								taskAwaiter = awaiter2;
								if (obj5 == null)
								{
									<>1__state = 0;
									object obj6 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 48));
									obj6 = awaiter2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									object obj7 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v64+E4]");
									bool flag2 = (nint)0 == 0;
									object obj8 = !flag2;
									if (obj8 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									AsyncTaskMethodBuilder asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
									((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_065a;
							}
							NullReferenceException ex = new NullReferenceException();
							obj9 = <>4__this;
							OutOfMemoryException ex2 = (OutOfMemoryException)(object)ex;
						}
						else
						{
							NullReferenceException ex3 = new NullReferenceException();
							obj9 = <>4__this;
							OutOfMemoryException ex2 = (OutOfMemoryException)(object)ex3;
						}
					}
					else
					{
						NullReferenceException ex4 = new NullReferenceException();
						obj9 = obj2;
						OutOfMemoryException ex2 = (OutOfMemoryException)(object)ex4;
					}
					goto IL_05c4;
				}
				<>u__1 = (TaskAwaiter<List<string>>)0;
				<>1__state = -1;
				num = -1;
				taskAwaiter = (TaskAwaiter<object>)<>u__1;
				goto IL_065a;
				IL_065a:
				num2 = (nint)0 + (nint)3360;
				object result = taskAwaiter.GetResult();
				object obj10 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 40));
				if (obj10 != null)
				{
					object obj11 = obj10 + 16;
					obj11 = result;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj12 = typeof(SqlSingle[]) + 2376;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj13 = (nint)0 + (nint)3440;
					nint num3 = (nint)obj13;
					Action action = default(Action);
					action..ctor(obj10, (IntPtr)obj13);
					object obj14 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
					object obj15 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v11+E4]");
					num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v11+E4]");
					bool flag3 = (nint)0 == 0;
					object obj16 = !flag3;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					CoroutineDummy.WaitForMainThread(action);
					obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					if ((int)(num & 0x80000000L) != 0)
					{
						object obj17 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1480;
						object obj18 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v18+B8]");
						num2 = 0;
						num2 = 0;
					}
					OutOfMemoryException ex2 = new OutOfMemoryException();
					obj9 = null;
					<>c__DisplayClass5_ = null;
				}
				else
				{
					NullReferenceException ex5 = new NullReferenceException();
					obj9 = result;
					OutOfMemoryException ex2 = (OutOfMemoryException)(object)ex5;
				}
				goto IL_05c4;
				IL_05c4:
				<>c__DisplayClass5_0 <>c__DisplayClass5_2 = default(<>c__DisplayClass5_0);
				object obj23 = default(object);
				while (true)
				{
					if ((int)(num & 0x80000000L) != 0)
					{
						object obj19 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1480;
						object obj20 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v28+B8]");
						num2 = 0;
						num2 = 0;
					}
					bool flag4 = <>c__DisplayClass5_ == null;
					object obj21 = !flag4;
					if (obj21 == null)
					{
						if ((nint)obj9 != 1)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
						object obj22 = typeof(DataRelation) + 3808;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
						nint num4 = (nint)<>c__DisplayClass5_2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F90");
						if (obj23 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
							<>1__state = -2;
							AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
							object obj24 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1192;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v41+E4]");
							bool flag5 = (nint)0 == 0;
							object obj25 = !flag5;
							if (obj25 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->SetException((Exception)(object)<>c__DisplayClass5_2);
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B68");
						object obj26 = <>c__DisplayClass5_2;
						obj9 = 139026432 + 4064;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0C04");
						nint num3 = 0;
						<>c__DisplayClass5_ = <>c__DisplayClass5_2;
					}
					else
					{
						OutOfMemoryException ex2 = new OutOfMemoryException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			private unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//IL_000f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0014: Expected O, but got Unknown
				//IL_006b: Expected O, but got I4
				//IL_0033: Expected O, but got Ref
				object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1192;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				AsyncTaskMethodBuilder asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
				((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		public Action<List<string>> onComplete;

		public string localIp;

		public Action <>9__4;

		internal void <Scan>b__0()
		{
			Actions.SafeInvoke((Action<object>)onComplete, null);
		}

		internal void <Scan>b__1()
		{
			Actions.SafeInvoke((Action<object>)onComplete, null);
		}

		internal unsafe Task <Scan>b__2()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00d1: Expected O, but got I4
			//IL_003f: Expected O, but got I
			//IL_005c: Expected O, but got Ref
			//IL_0074: Expected O, but got I
			//IL_0094: Expected O, but got I
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1192;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			<<Scan>b__2>d stateMachine = default(<<Scan>b__2>d);
			object obj4 = (nint)(&stateMachine) | (nint)8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 32));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)((nint)(&stateMachine) | (nint)8);
			((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->Start(ref stateMachine);
			AsyncTaskMethodBuilder asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder)((nint)(&stateMachine) | (nint)8);
			return ((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder3)->Task;
		}

		internal void <Scan>b__4()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(List<AdaptivePerformanceScaler>) + 3624;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list = default(List<object>);
			list..ctor();
			Actions.SafeInvoke((Action<object>)onComplete, list);
		}
	}

	private sealed class <>c__DisplayClass5_1
	{
		public List<string> found;

		public <>c__DisplayClass5_0 CS$<>8__locals1;

		internal void <Scan>b__3()
		{
			<>c__DisplayClass5_0 cS$<>8__locals = CS$<>8__locals1;
			Actions.SafeInvoke((Action<object>)cS$<>8__locals.onComplete, found);
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct <ProbeHost>d__7 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<string> <>t__builder;

		public string ip;

		private string <baseUrl>5__2;

		private TcpClient <tcp>5__3;

		private Task <connect>5__4;

		private TaskAwaiter<Task> <>u__1;

		private HttpClient <http>5__5;

		private TaskAwaiter<HttpResponseMessage> <>u__2;

		private unsafe void MoveNext()
		{
			//IL_0008: Expected O, but got Ref
			//IL_12c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_12ca: Expected O, but got Unknown
			//IL_160b: Expected O, but got I
			//IL_162b: Expected O, but got I
			//IL_1638: Expected O, but got I8
			//IL_1648: Expected O, but got I
			//IL_1659: Expected O, but got I
			//IL_002b: Expected O, but got I4
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Expected O, but got Unknown
			//IL_0080: Expected O, but got I
			//IL_04d0: Expected O, but got I
			//IL_04f0: Expected O, but got I
			//IL_04fd: Expected O, but got I8
			//IL_050d: Expected O, but got I
			//IL_150e: Expected O, but got I4
			//IL_151c: Expected O, but got I4
			//IL_0bc4: Expected O, but got I
			//IL_0bd4: Expected O, but got I
			//IL_12fc: Expected O, but got I
			//IL_1321: Expected O, but got I
			//IL_1331: Expected O, but got I
			//IL_00c7: Expected O, but got I
			//IL_1719: Expected O, but got I8
			//IL_153b: Expected O, but got I4
			//IL_0521: Unknown result type (might be due to invalid IL or missing references)
			//IL_0526: Expected O, but got Unknown
			//IL_010e: Expected O, but got I
			//IL_010e: Expected O, but got I
			//IL_0128: Expected O, but got I
			//IL_0bf3: Expected O, but got I
			//IL_0c03: Expected O, but got I
			//IL_0616: Expected O, but got I
			//IL_062a: Expected O, but got I
			//IL_0787: Expected O, but got I
			//IL_0797: Expected O, but got I
			//IL_07b9: Expected O, but got I4
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Expected O, but got Unknown
			//IL_06ef: Expected O, but got I
			//IL_06fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0703: Expected O, but got Unknown
			//IL_072d: Expected O, but got I4
			//IL_0757: Expected O, but got I
			//IL_0583: Expected O, but got I
			//IL_0593: Expected O, but got I
			//IL_05b5: Expected O, but got I4
			//IL_10df: Expected O, but got I4
			//IL_10e8: Expected O, but got I4
			//IL_10f1: Expected O, but got I4
			//IL_0c37: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c3c: Expected O, but got Unknown
			//IL_0c54: Expected O, but got I
			//IL_0656: Unknown result type (might be due to invalid IL or missing references)
			//IL_065b: Expected O, but got Unknown
			//IL_067f: Expected O, but got I8
			//IL_0697: Expected O, but got I4
			//IL_06a5: Expected O, but got I4
			//IL_07f9: Expected O, but got I4
			//IL_018a: Expected O, but got I
			//IL_01aa: Expected O, but got I4
			//IL_159a: Expected O, but got I8
			//IL_15b0: Expected O, but got I
			//IL_15b9: Expected O, but got I4
			//IL_15ed: Expected O, but got I4
			//IL_1403: Expected O, but got I4
			//IL_0857: Expected O, but got I
			//IL_0883: Expected O, but got I8
			//IL_089b: Expected O, but got I4
			//IL_08a4: Expected O, but got I4
			//IL_08b5: Expected O, but got I4
			//IL_08be: Expected O, but got I4
			//IL_08cf: Expected O, but got I4
			//IL_08e0: Expected O, but got I4
			//IL_1420: Unknown result type (might be due to invalid IL or missing references)
			//IL_1425: Expected O, but got Unknown
			//IL_143b: Expected O, but got I
			//IL_144c: Expected I, but got O
			//IL_146a: Expected O, but got I
			//IL_1485: Expected O, but got I4
			//IL_1043: Expected O, but got I
			//IL_157d: Expected O, but got I
			//IL_0c8f: Expected O, but got I
			//IL_06bc: Expected O, but got I4
			//IL_06da: Expected O, but got I4
			//IL_0829: Expected O, but got I
			//IL_1110: Expected O, but got I4
			//IL_1119: Expected O, but got I4
			//IL_01c0: Expected I, but got O
			//IL_01d0: Expected O, but got I
			//IL_08fe: Expected O, but got I
			//IL_090e: Expected O, but got I
			//IL_021f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0224: Expected O, but got Unknown
			//IL_0234: Expected O, but got I
			//IL_024d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0252: Expected O, but got Unknown
			//IL_027c: Expected O, but got I4
			//IL_0fd9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fde: Expected O, but got Unknown
			//IL_0ab7: Expected O, but got I
			//IL_0ac0: Expected O, but got I4
			//IL_0ada: Expected O, but got I
			//IL_0ae9: Expected O, but got I4
			//IL_11d8: Expected O, but got I4
			//IL_11e1: Expected O, but got I4
			//IL_0c9d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ca2: Expected O, but got Unknown
			//IL_0cab: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cb0: Expected O, but got Unknown
			//IL_0b02: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b07: Expected O, but got Unknown
			//IL_0b20: Expected O, but got I
			//IL_0b3a: Expected O, but got I
			//IL_096a: Unknown result type (might be due to invalid IL or missing references)
			//IL_096f: Expected O, but got Unknown
			//IL_0987: Expected O, but got I
			//IL_031c: Expected O, but got I8
			//IL_0b74: Expected O, but got I4
			//IL_1138: Expected O, but got I4
			//IL_1141: Expected O, but got I4
			//IL_02d1: Expected I, but got O
			//IL_02e1: Expected O, but got I
			//IL_0cfd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d02: Expected O, but got Unknown
			//IL_0a93: Expected O, but got I4
			//IL_14de: Expected O, but got I
			//IL_09c2: Expected O, but got I
			//IL_0342: Unknown result type (might be due to invalid IL or missing references)
			//IL_0347: Expected O, but got Unknown
			//IL_0d29: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d2e: Expected O, but got Unknown
			//IL_0d58: Expected O, but got I4
			//IL_120c: Expected O, but got I4
			//IL_1215: Expected O, but got I4
			//IL_0a2d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a32: Expected O, but got Unknown
			//IL_1160: Expected O, but got I4
			//IL_1169: Expected O, but got I4
			//IL_1191: Expected F8, but got I8
			//IL_119a: Expected O, but got I4
			//IL_09d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_09d5: Expected O, but got Unknown
			//IL_09de: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e3: Expected O, but got Unknown
			//IL_0dc7: Expected O, but got I
			//IL_03c3: Expected O, but got I4
			//IL_03d4: Expected O, but got I4
			//IL_03dd: Expected O, but got I4
			//IL_0e02: Expected F8, but got I8
			//IL_0e0b: Expected O, but got I4
			//IL_0401: Expected O, but got I
			//IL_040a: Expected O, but got I4
			//IL_0413: Unknown result type (might be due to invalid IL or missing references)
			//IL_0418: Expected O, but got Unknown
			//IL_0454: Expected O, but got I4
			//IL_0e2e: Expected O, but got I
			//IL_0e38: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e3d: Expected O, but got Unknown
			//IL_0e52: Expected O, but got I
			//IL_1361: Expected O, but got I
			//IL_137f: Expected O, but got I
			//IL_13aa: Expected O, but got I8
			//IL_13c2: Expected O, but got I4
			//IL_13ca: Expected O, but got Ref
			//IL_13d2: Expected O, but got Ref
			//IL_13db: Expected O, but got I4
			//IL_1235: Expected F8, but got I8
			//IL_123e: Expected O, but got I4
			//IL_0e90: Expected O, but got I
			//IL_049a: Expected O, but got I4
			//IL_04aa: Expected O, but got Ref
			//IL_04b2: Expected O, but got Ref
			//IL_04bb: Expected O, but got I4
			//IL_126e: Expected F8, but got I8
			//IL_1277: Expected O, but got I4
			//IL_0eec: Expected O, but got I4
			//IL_0f01: Expected F8, but got I8
			//IL_0f0a: Expected O, but got I4
			//IL_0f33: Expected O, but got I
			//IL_0f3c: Expected O, but got I4
			//IL_0f45: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f4a: Expected O, but got Unknown
			//IL_0f86: Expected O, but got I4
			//IL_1697: Expected O, but got I
			//IL_16b5: Expected O, but got I
			//IL_16d3: Expected F8, but got I8
			//IL_16dc: Expected O, but got I4
			//IL_16e4: Expected O, but got Ref
			//IL_16ec: Expected O, but got Ref
			//IL_16f5: Expected O, but got I4
			object obj2 = default(object);
			object obj = (object)(&obj2);
			object obj3 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 1800;
			_ = <>1__state;
			TaskAwaiter<object> taskAwaiter;
			object obj28;
			object obj29;
			object obj30;
			object obj31;
			object obj32;
			TcpClient tcpClient3;
			object obj33;
			OutOfMemoryException ex;
			object obj12 = default(object);
			TcpClient tcpClient2;
			object obj13 = default(object);
			if (<>1__state != 1)
			{
				bool flag = <>1__state == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					object obj5 = typeof(System.Formats.Asn1.SetOfValueComparer) + 4016;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					TcpClient tcpClient = default(TcpClient);
					tcpClient..ctor();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
					object obj6 = (nint)0 + (nint)48;
					obj6 = tcpClient;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-3C]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v97+30]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v97+30]");
							nint num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v97+20]");
							Task task = ((TcpClient)num).ConnectAsync((string)0, 5000);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
							object obj8 = (nint)0 + (nint)56;
							obj8 = task;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj9 = typeof(SqlSingle[]) + 168;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
							Task[] array = default(Task[]);
							if (array != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
								object obj10 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v100+38]");
								bool flag2 = (nint)0 == 0;
								tcpClient2 = (TcpClient)2;
								if (!flag2)
								{
									nint num2 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v118 (Il2CppClass<System.Threading.Tasks.Task[]>)+40]");
									tcpClient2 = (TcpClient)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									object obj11 = default(object);
									if (obj11 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
										ex = new OutOfMemoryException();
										obj12 = 0;
										obj13 = 5000;
										tcpClient2 = null;
										goto IL_1291;
									}
								}
								if (array.Length != 0)
								{
									object obj14 = array + 32;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v100+38]");
									obj14 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									object obj15 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3912;
									object obj16 = obj15;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X0_v127+E4]");
									bool flag3 = (nint)0 == 0;
									object obj17 = !flag3;
									if (obj17 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Task task2 = Task.Delay(500);
									bool flag4 = task2 == null;
									tcpClient2 = null;
									if (!flag4)
									{
										nint num3 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X8_v117 (Il2CppClass<System.Threading.Tasks.Task[]>)+40]");
										tcpClient2 = (TcpClient)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
										object obj18 = default(object);
										if (obj18 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
											ex = new OutOfMemoryException();
											obj12 = 0;
											obj13 = 5000;
											tcpClient2 = null;
											goto IL_1291;
										}
									}
									object obj19 = array.Length & 0xFFFFFFFEL;
									if (obj19 != null)
									{
										object obj20 = array + 40;
										obj20 = task2;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										Task<Task> task3 = Task.WhenAny(array);
										if (task3 != null)
										{
											TaskAwaiter<object> awaiter = ((Task<object>)(object)task3).GetAwaiter();
											TaskAwaiter<object> awaiter2 = default(TaskAwaiter<object>);
											bool isCompleted = awaiter2.IsCompleted;
											bool flag5 = !isCompleted;
											object obj21 = !flag5;
											taskAwaiter = awaiter2;
											obj12 = 0;
											obj13 = 5000;
											if (obj21 != null)
											{
												goto IL_12f0;
											}
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
											object obj22 = 0;
											obj22 = 0;
											object obj23 = obj22 + 64;
											obj23 = awaiter2;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											object obj24 = obj3;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1098 @ X0_v145+E4]");
											bool flag6 = (nint)0 == 0;
											object obj25 = !flag6;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
											ref <ProbeHost>d__7 reference = ref *(<ProbeHost>d__7*)null;
											if (obj25 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
												reference = ref *(<ProbeHost>d__7*)null;
											}
											object obj26 = (nint)0 + (nint)1672;
											obj12 = obj26;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
											AsyncTaskMethodBuilder<object> asyncTaskMethodBuilder = (AsyncTaskMethodBuilder<object>)((nint)0 + (nint)8);
											((AsyncTaskMethodBuilder<object>*)asyncTaskMethodBuilder)->AwaitUnsafeOnCompleted(ref awaiter2, ref reference);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-3C]");
											object obj27 = 0 & 0x80000000L;
											bool flag7 = obj27 == null;
											obj28 = 6;
											obj13 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
											tcpClient2 = (TcpClient)(&awaiter2);
											obj29 = 0;
											if (!flag7)
											{
												obj30 = 6;
												obj31 = obj26;
												obj32 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
												tcpClient3 = (TcpClient)(&awaiter2);
												obj33 = 0;
												goto IL_08ee;
											}
											goto IL_13e9;
										}
										NullReferenceException ex2 = new NullReferenceException();
										obj12 = 0;
										obj13 = 5000;
										tcpClient2 = null;
										ex = (OutOfMemoryException)(object)ex2;
									}
									else
									{
										IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
										obj12 = 0;
										obj13 = 5000;
										ex = (OutOfMemoryException)(object)ex3;
									}
								}
								else
								{
									IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
									obj12 = 0;
									obj13 = 5000;
									ex = (OutOfMemoryException)(object)ex4;
								}
							}
							else
							{
								NullReferenceException ex5 = new NullReferenceException();
								obj12 = 0;
								obj13 = 5000;
								tcpClient2 = (TcpClient)2;
								ex = (OutOfMemoryException)(object)ex5;
							}
						}
						else
						{
							NullReferenceException ex6 = new NullReferenceException();
							tcpClient2 = tcpClient;
							ex = (OutOfMemoryException)(object)ex6;
						}
						goto IL_1291;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
				object obj34 = 0;
				_ = 0;
				_ = 4294967295L;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
				object obj35 = 0;
				obj35 = 4294967295L;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v92+40]");
				taskAwaiter = (TaskAwaiter<object>)0;
				goto IL_12f0;
			}
			goto IL_15fb;
			IL_15fb:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
			object obj36 = 0;
			_ = 0;
			_ = 4294967295L;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
			object obj37 = 0;
			obj37 = 4294967295L;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v20+50]");
			TaskAwaiter<object> taskAwaiter2 = (TaskAwaiter<object>)0;
			goto IL_164d;
			IL_1521:
			object obj38;
			bool flag8 = obj38 == null;
			object obj39 = !flag8;
			object obj40;
			object result;
			if (obj39 == null)
			{
				if (obj40 != null)
				{
					if ((nint)obj40 != 10)
					{
						return;
					}
				}
				else
				{
					result = null;
				}
				goto IL_158c;
			}
			ex = new OutOfMemoryException();
			goto IL_1291;
			IL_07d7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X0_v81+E4]");
			bool flag9 = (nint)0 == 0;
			object obj41 = !flag9;
			object obj43;
			object obj44;
			if (obj41 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj42 = obj43;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X8_v73+B8]");
				obj44 = 0;
			}
			object obj45 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3800;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj46 = (nint)0 + (nint)3392;
			Func<object, object> func = default(Func<object, object>);
			func..ctor(obj44, (IntPtr)obj46);
			object obj47 = obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v72+B8]");
			object obj48 = (nint)0 + (nint)16;
			obj48 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj12 = 0;
			obj13 = obj46;
			tcpClient2 = (TcpClient)(object)func;
			Func<object, object> func2 = func;
			object obj50;
			object obj49 = obj50;
			goto IL_082e;
			IL_16ff:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-3C]");
			object obj51 = 0 & 0x80000000L;
			if (obj51 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
				object obj52 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v7+48]");
				object obj53 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v7+48]");
				if ((nint)0 != 0)
				{
					object obj54 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
					object obj55 = obj53;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X8_v10+12E]");
					object obj56 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X8_v10+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0cd0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X8_v10+B0]");
					object obj57 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ X10_v7-8]");
						if (0 == (nint)obj54)
						{
							break;
						}
						obj57 += 16;
						obj56--;
						if ((nint)obj56 != 1)
						{
							continue;
						}
						goto IL_0cd0;
					}
					object obj58 = obj55 + obj57;
					object obj59 = obj58 + 312;
					goto IL_156d;
				}
			}
			goto IL_1521;
			IL_14ce:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1013 @ X0_v101+8]");
			tcpClient2 = (TcpClient)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1013 @ X0_v101] (should have been resolved before IL gen)");
			obj28 = obj30;
			obj12 = obj31;
			obj29 = obj33;
			goto IL_13e9;
			IL_13e9:
			bool flag10 = obj29 == null;
			object obj60 = !flag10;
			if (obj60 == null)
			{
				if ((nint)obj28 != 11)
				{
					if ((nint)obj28 == 10)
					{
						result = null;
						goto IL_158c;
					}
					bool flag11 = obj28 == null;
					object obj61 = !flag11;
					if (obj61 != null)
					{
						return;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
				object obj62 = (nint)0 + (nint)48;
				obj62 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
				object obj63 = 0;
				object obj64 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object format = "getSecondRescanTask" + 3688;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v982 @ X8_v31+20]");
				object obj65 = default(object);
				string text = string.Format((string)format, 0, obj65);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
				object obj66 = (nint)0 + (nint)40;
				obj66 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-3C]");
				bool flag12 = (nint)0 != 1;
				obj12 = 0;
				obj13 = obj65;
				if (!flag12)
				{
					goto IL_15fb;
				}
				object obj67 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				HttpClient httpClient = default(HttpClient);
				httpClient..ctor();
				object obj68 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
				object obj69 = obj68;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1067 @ X0_v48+E4]");
				bool flag13 = (nint)0 == 0;
				object obj70 = !flag13;
				if (obj70 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				TimeSpan timeSpan = TimeSpan.FromMilliseconds(2000.0);
				if (httpClient != null)
				{
					httpClient.Timeout = timeSpan;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
					object obj71 = (nint)0 + (nint)72;
					obj71 = httpClient;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-3C]");
					bool flag14 = (nint)0 == 1;
					double num4 = 4.65651090846856E+18;
					obj12 = 0;
					obj13 = null;
					if (flag14)
					{
						goto IL_15fb;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
					object obj72 = 0;
					object obj73 = "alignContent" + 1888;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1103 @ X8_v46+28]");
					string text2 = (string)0 + (string)obj73;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1103 @ X8_v46+48]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1103 @ X8_v46+48]");
						Task<HttpResponseMessage> async = ((HttpClient)0).GetAsync(text2);
						if (async != null)
						{
							TaskAwaiter<object> awaiter3 = ((Task<object>)(object)async).GetAwaiter();
							TaskAwaiter<object> awaiter4 = default(TaskAwaiter<object>);
							bool isCompleted2 = awaiter4.IsCompleted;
							bool flag15 = !isCompleted2;
							object obj74 = !flag15;
							taskAwaiter2 = awaiter4;
							num4 = 4.65651090846856E+18;
							obj12 = 0;
							obj13 = null;
							if (obj74 != null)
							{
								goto IL_164d;
							}
							_ = 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
							object obj75 = 0;
							obj75 = 1;
							object obj76 = obj75 + 80;
							obj76 = awaiter4;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj77 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1132 @ X0_v69+E4]");
							bool flag16 = (nint)0 == 0;
							object obj78 = !flag16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
							ref <ProbeHost>d__7 reference2 = ref *(<ProbeHost>d__7*)null;
							if (obj78 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
								reference2 = ref *(<ProbeHost>d__7*)null;
							}
							object obj79 = (nint)0 + (nint)1656;
							obj12 = obj79;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
							AsyncTaskMethodBuilder<object> asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder<object>)((nint)0 + (nint)8);
							((AsyncTaskMethodBuilder<object>*)asyncTaskMethodBuilder2)->AwaitUnsafeOnCompleted(ref awaiter4, ref reference2);
							num4 = 4.65651090846856E+18;
							obj40 = 6;
							obj13 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
							tcpClient2 = (TcpClient)(&awaiter4);
							obj38 = 0;
							result = null;
							goto IL_16ff;
						}
						NullReferenceException ex7 = new NullReferenceException();
						num4 = 4.65651090846856E+18;
						obj12 = 0;
						obj13 = null;
						tcpClient2 = (TcpClient)(object)text2;
						ex = (OutOfMemoryException)(object)ex7;
					}
					else
					{
						NullReferenceException ex8 = new NullReferenceException();
						num4 = 4.65651090846856E+18;
						obj12 = 0;
						obj13 = null;
						tcpClient2 = (TcpClient)(object)text2;
						ex = (OutOfMemoryException)(object)ex8;
					}
				}
				else
				{
					NullReferenceException ex9 = new NullReferenceException();
					double num4 = 4.65651090846856E+18;
					obj12 = 0;
					obj13 = obj65;
					tcpClient2 = (TcpClient)timeSpan;
					ex = (OutOfMemoryException)(object)ex9;
				}
			}
			else
			{
				ex = new OutOfMemoryException();
			}
			goto IL_1291;
			IL_082e:
			if (obj49 != null)
			{
				object obj80 = (nint)0 + (nint)448;
				obj31 = obj80;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30411A8");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-3C]");
				object obj81 = 0 & 0x80000000L;
				bool flag17 = obj81 == null;
				obj30 = 10;
				obj32 = 327680;
				tcpClient3 = (TcpClient)(object)func2;
				obj33 = 0;
				obj28 = 10;
				obj12 = obj80;
				obj13 = 327680;
				tcpClient2 = (TcpClient)(object)func2;
				obj29 = 0;
				if (!flag17)
				{
					goto IL_08ee;
				}
				goto IL_13e9;
			}
			NullReferenceException ex10 = new NullReferenceException();
			ex = (OutOfMemoryException)(object)ex10;
			goto IL_1291;
			IL_0573:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X0_v81+B8]");
			obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X8_v67+10]");
			func2 = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X8_v67+10]");
			bool flag18 = (nint)0 == 0;
			object obj82 = !flag18;
			object obj83;
			TcpClient tcpClient4;
			if (obj82 == null)
			{
				obj43 = obj83;
				tcpClient4 = tcpClient2;
				obj50 = obj49;
				goto IL_07d7;
			}
			goto IL_082e;
			IL_12f0:
			object obj84 = (nint)0 + (nint)3920;
			tcpClient2 = (TcpClient)obj84;
			object result2 = taskAwaiter.GetResult();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
			object obj85 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v61+38]");
			obj49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v61+38]");
			object obj86;
			if (result2 != null)
			{
				obj83 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1528;
				obj86 = obj83;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X0_v81+E4]");
				bool flag19 = (nint)0 == 0;
				obj43 = obj83;
				tcpClient4 = tcpClient2;
				object obj87 = obj86;
				obj50 = obj49;
				if (!flag19)
				{
					goto IL_0573;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v61+30]");
				if ((nint)0 == 0)
				{
					NullReferenceException ex11 = new NullReferenceException();
					ex = (OutOfMemoryException)(object)ex11;
					goto IL_1291;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v61+30]");
				bool connected = ((TcpClient)0).Connected;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
				object obj88 = 0;
				if (connected)
				{
					_ = 0;
					object obj89 = obj88 + 56;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-3C]");
					object obj90 = 0 & 0x80000000L;
					bool flag20 = obj90 == null;
					obj28 = 11;
					tcpClient2 = null;
					obj29 = 0;
					if (!flag20)
					{
						obj30 = 11;
						obj31 = obj12;
						obj32 = obj13;
						tcpClient3 = null;
						obj33 = 0;
						goto IL_08ee;
					}
					goto IL_13e9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v77+38]");
				obj49 = 0;
				obj83 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1528;
				obj86 = obj83;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X0_v81+E4]");
				bool flag21 = (nint)0 == 0;
				object obj91 = !flag21;
				tcpClient2 = null;
				obj43 = obj83;
				tcpClient4 = null;
				object obj87 = obj86;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v77+38]");
				obj50 = 0;
				if (obj91 != null)
				{
					goto IL_0573;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj86 = obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X0_v81+B8]");
			obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X8_v67+10]");
			func2 = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X8_v67+10]");
			bool flag22 = (nint)0 == 0;
			object obj92 = !flag22;
			tcpClient2 = tcpClient4;
			obj49 = obj50;
			if (obj92 == null)
			{
				goto IL_07d7;
			}
			goto IL_082e;
			IL_156d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1000 @ X0_v6+8]");
			tcpClient2 = (TcpClient)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1000 @ X0_v6] (should have been resolved before IL gen)");
			goto IL_1521;
			IL_1291:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_164d:
			object obj93 = (nint)0 + (nint)3648;
			tcpClient2 = (TcpClient)obj93;
			object result3 = taskAwaiter2.GetResult();
			if (result3 != null)
			{
				if (((HttpResponseMessage)result3).IsSuccessStatusCode)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
					object obj94 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v18+28]");
					result = 0;
				}
				else
				{
					result = null;
				}
				obj40 = 10;
				tcpClient2 = null;
				obj38 = 0;
				goto IL_16ff;
			}
			NullReferenceException ex12 = new NullReferenceException();
			ex = (OutOfMemoryException)(object)ex12;
			goto IL_1291;
			IL_158c:
			object obj95 = 4294967294L;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
			object obj96 = (nint)0 + (nint)40;
			obj96 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj97 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1004 @ X0_v22+E4]");
			bool flag23 = (nint)0 == 0;
			object obj98 = !flag23;
			if (obj98 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
			AsyncTaskMethodBuilder<object> asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder<object>)((nint)0 + (nint)8);
			((AsyncTaskMethodBuilder<object>*)asyncTaskMethodBuilder3)->SetResult(result);
			return;
			IL_0cd0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj13 = null;
			goto IL_156d;
			IL_0a03:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj13 = null;
			goto IL_14ce;
			IL_08ee:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
			object obj99 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X8_v84+30]");
			object obj100 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X8_v84+30]");
			bool flag24 = (nint)0 == 0;
			obj28 = obj30;
			obj12 = obj31;
			obj13 = obj32;
			tcpClient2 = tcpClient3;
			obj29 = obj33;
			if (flag24)
			{
				goto IL_13e9;
			}
			object obj101 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			object obj102 = obj100;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v798 @ X8_v87+12E]");
			object obj103 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v798 @ X8_v87+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0a03;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v798 @ X8_v87+B0]");
			object obj104 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v962 @ X10_v20-8]");
				if (0 == (nint)obj101)
				{
					break;
				}
				obj104 += 16;
				obj103--;
				if ((nint)obj103 != 1)
				{
					continue;
				}
				goto IL_0a03;
			}
			object obj105 = obj102 + obj104;
			object obj106 = obj105 + 312;
			obj13 = obj32;
			goto IL_14ce;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_006c: Expected O, but got I4
			//IL_0033: Expected O, but got Ref
			object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 1800;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncTaskMethodBuilder<object> asyncTaskMethodBuilder = (AsyncTaskMethodBuilder<object>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncTaskMethodBuilder<object>*)asyncTaskMethodBuilder)->SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct <SweepSubnet>d__6 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<List<string>> <>t__builder;

		public string localIp;

		private TaskAwaiter<string[]> <>u__1;

		private unsafe void MoveNext()
		{
			//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f5: Expected O, but got Unknown
			//IL_044f: Expected O, but got I4
			//IL_045e: Expected I4, but got I8
			//IL_0720: Expected O, but got I
			//IL_073c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0741: Expected O, but got Unknown
			//IL_04e4: Expected O, but got I
			//IL_04f4: Expected O, but got I
			//IL_0516: Expected O, but got I4
			//IL_0587: Expected O, but got I
			//IL_05a4: Expected O, but got I
			//IL_047d: Expected O, but got I
			//IL_048d: Expected O, but got I
			//IL_04af: Expected O, but got I4
			//IL_05c6: Expected I4, but got I8
			//IL_05d1: Expected O, but got Ref
			//IL_05fb: Expected O, but got I4
			//IL_0546: Expected O, but got I4
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected O, but got Unknown
			//IL_008d: Expected O, but got I
			//IL_077d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0782: Expected O, but got Unknown
			//IL_0798: Expected O, but got I
			//IL_07a9: Expected I, but got O
			//IL_07c7: Expected O, but got I
			//IL_07ea: Expected O, but got I4
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected O, but got Unknown
			//IL_0576: Expected O, but got I
			//IL_0648: Expected O, but got I4
			//IL_0682: Expected O, but got I4
			//IL_0692: Expected I, but got O
			//IL_00e0: Expected O, but got I
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected O, but got Unknown
			//IL_0100: Expected O, but got I
			//IL_0110: Expected O, but got I4
			//IL_0119: Expected O, but got I4
			//IL_0122: Expected O, but got I4
			//IL_0220: Expected O, but got I4
			//IL_0230: Expected I, but got O
			//IL_025e: Expected O, but got I4
			//IL_0137: Expected O, but got I
			//IL_0147: Expected O, but got I
			//IL_0157: Expected O, but got I
			//IL_0172: Unknown result type (might be due to invalid IL or missing references)
			//IL_0177: Expected O, but got Unknown
			//IL_018f: Expected O, but got I4
			//IL_029e: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a3: Expected O, but got Unknown
			//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b1: Expected O, but got Unknown
			//IL_02fa: Expected O, but got I4
			//IL_031f: Expected I, but got O
			//IL_06b7: Expected O, but got I4
			//IL_0378: Unknown result type (might be due to invalid IL or missing references)
			//IL_037d: Expected O, but got Unknown
			//IL_0397: Expected O, but got I4
			//IL_03a8: Expected O, but got I4
			//IL_03cc: Expected O, but got Ref
			//IL_0408: Expected O, but got I4
			//IL_0431: Expected O, but got Ref
			object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 1456;
			List<object> list = default(List<object>);
			object obj6;
			object obj7;
			nint num2;
			NullReferenceException ex;
			object obj13;
			if (<>1__state != 0)
			{
				if (localIp != null)
				{
					int num = localIp.LastIndexOf('.');
					int length = num + 1;
					string text = localIp.Substring(0, length);
					object obj2 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3848;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj3 = (nint)0 + (nint)3328;
					object obj4 = obj3;
					list..ctor(254);
					object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1400;
					if (list != null)
					{
						object obj5 = (nint)0 + (nint)3336;
						obj6 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3912;
						obj7 = (nint)0 + (nint)728;
						object obj8 = 153100288 + 1024;
						object obj9 = 1;
						object obj10 = 0;
						object obj11 = default(object);
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
							string ip = string.Format((string)format, text, obj11);
							Task<string> task = ProbeHost(ip);
							object obj12 = obj5;
							int version = list._version + 1;
							list._version = version;
							object[] items = list._items;
							bool flag = list._items == null;
							obj13 = 0;
							obj4 = obj11;
							num2 = (nint)task;
							if (flag)
							{
								break;
							}
							bool flag2 = list._size < items.Length;
							object obj14 = !flag2;
							if (obj14 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v39+20]");
								object obj15 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v49+C0]");
								object obj16 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v50+70]");
								obj4 = 0;
								list.AddWithResize((object)task);
							}
							else
							{
								int size = list._size + 1;
								list._size = size;
								object obj17 = list._items + list._size;
								object obj18 = obj17 + 32;
								obj18 = task;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								obj4 = obj11;
							}
							obj9++;
							bool flag3 = (nint)obj9 == 255;
							obj10 = 0;
							if (!flag3)
							{
								continue;
							}
							goto IL_02d0;
						}
					}
					else
					{
						object obj19 = 153100288 + 1024;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						object obj20 = default(object);
						string ip2 = string.Format((string)format, text, obj20);
						Task<string> task2 = ProbeHost(ip2);
						obj13 = 0;
						obj4 = obj20;
						num2 = (nint)text;
					}
					ex = new NullReferenceException();
				}
				else
				{
					ex = new NullReferenceException();
				}
				goto IL_06bc;
			}
			<>u__1 = (TaskAwaiter<string[]>)0;
			<>1__state = -1;
			TaskAwaiter<object> taskAwaiter = (TaskAwaiter<object>)<>u__1;
			goto IL_0714;
			IL_02d0:
			object obj21 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X0_v54+E4]");
			bool flag4 = (nint)0 == 0;
			object obj22 = !flag4;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			num2 = (nint)obj7;
			Task<object[]> task3 = Task.WhenAll((IEnumerable<Task<object>>)list);
			if (task3 != null)
			{
				TaskAwaiter<object> awaiter = ((Task<object>)(object)task3).GetAwaiter();
				TaskAwaiter<object> awaiter2 = default(TaskAwaiter<object>);
				bool isCompleted = awaiter2.IsCompleted;
				obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 1456;
				bool flag5 = !isCompleted;
				object obj23 = !flag5;
				taskAwaiter = awaiter2;
				obj13 = 0;
				if (obj23 == null)
				{
					<>1__state = 0;
					object obj24 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 40));
					obj24 = awaiter2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj25 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X0_v65+E4]");
					bool flag6 = (nint)0 == 0;
					object obj26 = !flag6;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					AsyncTaskMethodBuilder<object> asyncTaskMethodBuilder = (AsyncTaskMethodBuilder<object>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
					((AsyncTaskMethodBuilder<object>*)asyncTaskMethodBuilder)->AwaitUnsafeOnCompleted(ref awaiter2, ref this);
					return;
				}
				goto IL_0714;
			}
			ex = new NullReferenceException();
			obj13 = 0;
			goto IL_06bc;
			IL_0524:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v14+E4]");
			bool flag7 = (nint)0 == 0;
			object obj27 = !flag7;
			object obj29;
			object obj30;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj28 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v22+B8]");
				obj30 = 0;
			}
			object obj31 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3552;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj32 = (nint)0 + (nint)3400;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj30, (IntPtr)obj32);
			object obj33 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v21+B8]");
			object obj34 = (nint)0 + (nint)8;
			obj34 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Func<object, bool> predicate = func;
			obj13 = 0;
			goto IL_057b;
			IL_0714:
			object obj35 = (nint)0 + (nint)3488;
			object result = taskAwaiter.GetResult();
			obj29 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1528;
			object obj36 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v14+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v14+B8]");
				obj30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v16+8]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v16+8]");
				bool flag8 = (nint)0 == 0;
				object obj37 = !flag8;
				if (obj37 == null)
				{
					goto IL_0524;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj36 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v14+B8]");
				obj30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v16+8]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v16+8]");
				bool flag9 = (nint)0 == 0;
				object obj38 = !flag9;
				if (obj38 == null)
				{
					goto IL_0524;
				}
			}
			goto IL_057b;
			IL_06bc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_057b:
			object obj39 = (nint)0 + (nint)3784;
			IEnumerable<object> source = Enumerable.Where((IEnumerable<object>)result, predicate);
			object obj40 = (nint)0 + (nint)2736;
			List<object> result2 = Enumerable.ToList(source);
			<>1__state = -2;
			AsyncTaskMethodBuilder<object> asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder<object>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			object obj41 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v10+E4]");
			bool flag10 = (nint)0 == 0;
			object obj42 = !flag10;
			if (obj42 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			((AsyncTaskMethodBuilder<object>*)asyncTaskMethodBuilder2)->SetResult(result2);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_006c: Expected O, but got I4
			//IL_0033: Expected O, but got Ref
			object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 1456;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncTaskMethodBuilder<object> asyncTaskMethodBuilder = (AsyncTaskMethodBuilder<object>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncTaskMethodBuilder<object>*)asyncTaskMethodBuilder)->SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private const int BackendPort = 5000;

	private const string ProbePath = "api/servers";

	private const int TcpTimeoutMs = 500;

	private const int HttpTimeoutMs = 2000;

	private static bool _scanning;

	public static void Scan(Action<List<string>> onComplete)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0065: Expected O, but got I
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00af: Expected O, but got I
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01e1: Expected O, but got I
		//IL_0257: Expected I, but got O
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected O, but got Unknown
		//IL_011f: Expected O, but got I
		//IL_0128: Expected O, but got I4
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_0152: Expected O, but got I
		//IL_0163: Expected I, but got O
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1480;
		object obj4 = obj2 + 16;
		obj4 = onComplete;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v3+B8]");
		object obj6 = 0;
		object obj8;
		Action callback;
		Action action = default(Action);
		if ((nint)obj6 == 1)
		{
			object obj7 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj8 = (nint)0 + (nint)3408;
			callback = action;
		}
		else
		{
			string localIPv = GetLocalIPv4();
			object obj9 = obj2 + 24;
			obj9 = localIPv;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (obj9 != null)
			{
				object obj10 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v15+B8]");
				object obj11 = 0;
				obj11 = 1;
				object obj12 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2840;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj13 = (nint)0 + (nint)3424;
				Func<object> func = default(Func<object>);
				func..ctor(obj2, (IntPtr)obj13);
				object obj14 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3912;
				object obj15 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v20+E4]");
				if ((nint)0 != 0)
				{
					Task task = Task.Run((Func<Task>)func);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Task task2 = Task.Run((Func<Task>)func);
				return;
			}
			object obj16 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj8 = (nint)0 + (nint)3416;
			callback = action;
		}
		action..ctor(obj2, (IntPtr)obj8);
		object obj17 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v9+E4]");
		if ((nint)0 != 0)
		{
			CoroutineDummy.WaitForMainThread(callback);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		CoroutineDummy.WaitForMainThread(callback);
	}

	private unsafe static Task<List<string>> SweepSubnet(string localIp)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00d3: Expected O, but got I4
		//IL_003f: Expected O, but got I
		//IL_005c: Expected O, but got Ref
		//IL_0074: Expected O, but got I
		//IL_0094: Expected O, but got I
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 1456;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncTaskMethodBuilder<object> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<object>.Create();
		<SweepSubnet>d__6 stateMachine = default(<SweepSubnet>d__6);
		object obj4 = (nint)(&stateMachine) | (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 32));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AsyncTaskMethodBuilder<object> asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder<object>)((nint)(&stateMachine) | (nint)8);
		((AsyncTaskMethodBuilder<object>*)asyncTaskMethodBuilder2)->Start(ref stateMachine);
		AsyncTaskMethodBuilder<object> asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder<object>)((nint)(&stateMachine) | (nint)8);
		return (Task<List<string>>)(object)((AsyncTaskMethodBuilder<object>*)asyncTaskMethodBuilder3)->Task;
	}

	private unsafe static Task<string> ProbeHost(string ip)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00d3: Expected O, but got I4
		//IL_003f: Expected O, but got I
		//IL_005c: Expected O, but got Ref
		//IL_0074: Expected O, but got I
		//IL_0094: Expected O, but got I
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 1800;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncTaskMethodBuilder<object> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<object>.Create();
		<ProbeHost>d__7 stateMachine = default(<ProbeHost>d__7);
		object obj4 = (nint)(&stateMachine) | (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 32));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AsyncTaskMethodBuilder<object> asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder<object>)((nint)(&stateMachine) | (nint)8);
		((AsyncTaskMethodBuilder<object>*)asyncTaskMethodBuilder2)->Start(ref stateMachine);
		AsyncTaskMethodBuilder<object> asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder<object>)((nint)(&stateMachine) | (nint)8);
		return (Task<string>)(object)((AsyncTaskMethodBuilder<object>*)asyncTaskMethodBuilder3)->Task;
	}

	private static string GetLocalIPv4()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0064: Expected O, but got I4
		//IL_00ad: Expected O, but got I
		//IL_00ea: Expected O, but got I
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_012c: Expected O, but got I
		//IL_016b: Expected O, but got I
		//IL_01aa: Expected O, but got I
		//IL_01e9: Expected O, but got I
		//IL_0228: Expected O, but got I
		//IL_024c: Expected O, but got I4
		//IL_02be: Expected I, but got O
		//IL_02ce: Expected O, but got I
		//IL_0365: Expected O, but got I4
		//IL_027c: Expected O, but got I4
		//IL_0906: Expected O, but got I
		//IL_0919: Unknown result type (might be due to invalid IL or missing references)
		//IL_091e: Expected O, but got Unknown
		//IL_0309: Expected O, but got I
		//IL_0636: Expected O, but got I4
		//IL_0647: Expected O, but got I4
		//IL_0658: Expected O, but got I4
		//IL_0671: Expected O, but got I4
		//IL_08d2: Expected O, but got I
		//IL_09c0: Expected O, but got I4
		//IL_09c9: Expected O, but got I4
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected O, but got Unknown
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected O, but got Unknown
		//IL_0696: Unknown result type (might be due to invalid IL or missing references)
		//IL_069b: Expected O, but got Unknown
		//IL_06a3: Expected I, but got O
		//IL_06b3: Expected O, but got I
		//IL_0813: Expected O, but got I4
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		//IL_0788: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Expected O, but got Unknown
		//IL_07b5: Expected O, but got I4
		//IL_074a: Expected O, but got I4
		//IL_03b7: Expected I, but got O
		//IL_03c7: Expected O, but got I
		//IL_0a1b: Expected O, but got I
		//IL_06ee: Expected O, but got I
		//IL_045e: Expected O, but got I4
		//IL_09e7: Expected O, but got I
		//IL_097f: Expected O, but got I
		//IL_0402: Expected O, but got I
		//IL_0757: Unknown result type (might be due to invalid IL or missing references)
		//IL_075c: Expected O, but got Unknown
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Expected O, but got Unknown
		//IL_07ec: Expected O, but got I4
		//IL_094b: Expected O, but got I
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Expected O, but got Unknown
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		//IL_070f: Expected O, but got Unknown
		//IL_04a3: Expected O, but got I
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Expected O, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected O, but got Unknown
		//IL_083a: Expected O, but got I4
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected O, but got Unknown
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected O, but got Unknown
		//IL_04f2: Expected O, but got I4
		//IL_0518: Expected O, but got I
		//IL_0861: Expected O, but got I4
		//IL_0569: Expected O, but got I
		//IL_05b7: Expected O, but got I4
		//IL_05c0: Expected O, but got I4
		//IL_05d1: Expected O, but got I4
		//IL_05f8: Expected O, but got I4
		//IL_0611: Expected O, but got I4
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		string text5;
		if (allNetworkInterfaces != null)
		{
			if (allNetworkInterfaces.Length < 1)
			{
				goto IL_086e;
			}
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
			object obj2 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1296;
			object obj3 = allNetworkInterfaces + 32;
			object obj4 = 0;
			string text = null;
			object obj8 = default(object);
			object obj10 = default(object);
			object obj12 = default(object);
			object obj14 = default(object);
			object obj16 = default(object);
			string text2 = default(string);
			object obj23 = default(object);
			object obj24 = default(object);
			object obj28 = default(object);
			object obj33 = default(object);
			IPAddress iPAddress = default(IPAddress);
			object obj36 = default(object);
			IPAddress address = default(IPAddress);
			string result = default(string);
			string text6 = default(string);
			object obj20 = default(object);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X27_v7+v116 @ X23_v8*8]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X27_v7+v116 @ X23_v8*8]");
				if ((nint)0 == 0)
				{
					break;
				}
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v10+1A0]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v438 @ X8_v10+198] (should have been resolved before IL gen)");
				object obj19;
				object obj39;
				string text4;
				object obj40;
				object obj41;
				object obj42;
				object obj43;
				object obj44;
				if ((nint)obj8 == 1)
				{
					object obj9 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X8_v11+1B0]");
					obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v488 @ X8_v11+1A8] (should have been resolved before IL gen)");
					if ((nint)obj10 != 24)
					{
						object obj11 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v12+1B0]");
						obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v515 @ X8_v12+1A8] (should have been resolved before IL gen)");
						if ((nint)obj12 != 131)
						{
							object obj13 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v13+190]");
							obj7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v165 @ X8_v13+188] (should have been resolved before IL gen)");
							if (obj14 == null)
							{
								break;
							}
							object obj15 = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v14+180]");
							obj7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v166 @ X8_v14+178] (should have been resolved before IL gen)");
							if (obj16 == null)
							{
								break;
							}
							object obj17 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X8_v15+260]");
							obj7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v522 @ X8_v15+258] (should have been resolved before IL gen)");
							bool flag = text2 == null;
							object obj18 = !flag;
							obj19 = obj20;
							string text3 = text2;
							if (obj18 == null)
							{
								goto IL_026a;
							}
							while (true)
							{
								nint num = (nint)text3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v17 (Il2CppClass<System.String>)+12E]");
								object obj21 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v17 (Il2CppClass<System.String>)+12E]");
								if ((nint)0 == 0)
								{
									goto IL_0352;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v17 (Il2CppClass<System.String>)+B0]");
								object obj22 = (nint)0 + (nint)8;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X10_v26-8]");
									obj23 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X10_v26-8]");
									if (0 == (nint)obj)
									{
										break;
									}
									obj24 = obj22 + 16;
									obj21--;
									bool flag2 = (nint)obj21 != 1;
									obj22 = obj24;
									if (flag2)
									{
										continue;
									}
									goto IL_0352;
								}
								object obj25 = num + obj22;
								object obj26 = obj25 + 312;
								obj24 = obj22;
								goto IL_08f6;
								IL_08f6:
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X0_v30+8]");
								obj7 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v613 @ X0_v30] (should have been resolved before IL gen)");
								object obj27 = obj28 & 1;
								if (obj27 == null)
								{
									break;
								}
								if (text2 == null)
								{
									goto IL_07f9;
								}
								nint num2 = (nint)text2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v28 (Il2CppClass<System.String>)+12E]");
								object obj29 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v28 (Il2CppClass<System.String>)+12E]");
								if ((nint)0 == 0)
								{
									goto IL_044b;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v28 (Il2CppClass<System.String>)+B0]");
								object obj30 = (nint)0 + (nint)8;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X10_v21-8]");
									obj23 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X10_v21-8]");
									if (0 == (nint)obj2)
									{
										break;
									}
									obj24 = obj30 + 16;
									obj29--;
									bool flag3 = (nint)obj29 != 1;
									obj30 = obj24;
									if (flag3)
									{
										continue;
									}
									goto IL_044b;
								}
								object obj31 = num2 + obj30;
								object obj32 = obj31 + 312;
								obj24 = obj30;
								goto IL_096f;
								IL_096f:
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ X0_v42+8]");
								obj7 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v785 @ X0_v42] (should have been resolved before IL gen)");
								if (obj33 == null)
								{
									goto IL_07d2;
								}
								object obj34 = obj33;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v31+180]");
								obj7 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v435 @ X8_v31+178] (should have been resolved before IL gen)");
								if (iPAddress != null)
								{
									AddressFamily addressFamily = iPAddress.AddressFamily;
									bool flag4 = addressFamily != AddressFamily.InterNetwork;
									obj7 = 0;
									if (!flag4)
									{
										object obj35 = obj33;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v32+180]");
										obj7 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v436 @ X8_v32+178] (should have been resolved before IL gen)");
										if (obj36 == null)
										{
											goto IL_0847;
										}
										object obj37 = obj36;
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v806 @ X8_v33+168] (should have been resolved before IL gen)");
										object obj38 = obj33;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X8_v34+180]");
										obj7 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v656 @ X8_v34+178] (should have been resolved before IL gen)");
										if (IsPrivate(address))
										{
											goto IL_059d;
										}
									}
									bool flag5 = text2 == null;
									obj20 = obj19;
									text3 = text2;
									if (!flag5)
									{
										continue;
									}
									goto IL_026a;
								}
								goto IL_0820;
								IL_044b:
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
								obj19 = 0;
								goto IL_096f;
								IL_0352:
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
								obj19 = 0;
								goto IL_08f6;
							}
							bool flag6 = text2 == null;
							obj39 = 4;
							text4 = text2;
							obj40 = 0;
							obj41 = obj23;
							obj42 = 4;
							obj20 = obj19;
							obj43 = obj24;
							obj44 = 0;
							text5 = text;
							if (!flag6)
							{
								goto IL_0687;
							}
							goto IL_09a6;
						}
					}
				}
				goto IL_006e;
				IL_07d2:
				NullReferenceException ex = new NullReferenceException();
				obj20 = obj19;
				object obj45 = 0;
				OutOfMemoryException ex2 = (OutOfMemoryException)(object)ex;
				goto IL_0a57;
				IL_07f9:
				NullReferenceException ex3 = new NullReferenceException();
				obj20 = obj19;
				obj45 = 0;
				ex2 = (OutOfMemoryException)(object)ex3;
				goto IL_0a57;
				IL_0737:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj20 = 0;
				goto IL_0a0b;
				IL_0687:
				object obj46 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				nint num3 = (nint)text4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X8_v24 (Il2CppClass<System.String>)+12E]");
				object obj47 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X8_v24 (Il2CppClass<System.String>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0737;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X8_v24 (Il2CppClass<System.String>)+B0]");
				object obj48 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X10_v15-8]");
					obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X10_v15-8]");
					if (0 == (nint)obj46)
					{
						break;
					}
					obj24 = obj48 + 16;
					obj47--;
					bool flag7 = (nint)obj47 != 1;
					obj48 = obj24;
					if (flag7)
					{
						continue;
					}
					goto IL_0737;
				}
				object obj49 = num3 + obj48;
				object obj50 = obj49 + 312;
				obj20 = obj19;
				obj24 = obj48;
				goto IL_0a0b;
				IL_09a6:
				bool flag8 = obj44 == null;
				object obj51 = !flag8;
				obj45 = 0;
				if (obj51 == null)
				{
					object obj52 = obj42 & 3;
					bool flag9 = obj52 == null;
					obj23 = obj41;
					obj24 = obj43;
					obj45 = 0;
					text = text5;
					if (flag9)
					{
						goto IL_006e;
					}
					goto IL_0a52;
				}
				ex2 = new OutOfMemoryException();
				goto IL_0a57;
				IL_0a57:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
				return result;
				IL_006e:
				obj4++;
				if ((nint)obj4 < allNetworkInterfaces.Length)
				{
					continue;
				}
				goto IL_086e;
				IL_059d:
				bool flag10 = text2 == null;
				object obj53 = !flag10;
				obj39 = 7;
				text4 = text2;
				obj40 = 0;
				text = text6;
				if (obj53 != null)
				{
					goto IL_0687;
				}
				obj41 = obj23;
				obj42 = 7;
				obj20 = obj19;
				obj43 = obj24;
				obj44 = 0;
				text5 = text6;
				goto IL_09a6;
				IL_0a0b:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X0_v35+8]");
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v793 @ X0_v35] (should have been resolved before IL gen)");
				obj41 = obj23;
				obj42 = obj39;
				obj43 = obj24;
				obj44 = obj40;
				text5 = text;
				goto IL_09a6;
				IL_0847:
				NullReferenceException ex4 = new NullReferenceException();
				obj20 = obj19;
				obj45 = 0;
				ex2 = (OutOfMemoryException)(object)ex4;
				goto IL_0a57;
				IL_026a:
				NullReferenceException ex5 = new NullReferenceException();
				obj45 = 0;
				ex2 = (OutOfMemoryException)(object)ex5;
				goto IL_0a57;
				IL_0820:
				NullReferenceException ex6 = new NullReferenceException();
				obj20 = obj19;
				obj45 = 0;
				ex2 = (OutOfMemoryException)(object)ex6;
				goto IL_0a57;
			}
		}
		throw new NullReferenceException();
		IL_086e:
		text5 = null;
		goto IL_0a52;
		IL_0a52:
		return text5;
	}

	private static bool IsPrivate(IPAddress address)
	{
		//IL_01aa: Expected I4, but got O
		//IL_016e: Expected O, but got I4
		//IL_0123: Expected O, but got I4
		if (address != null)
		{
			byte[] addressBytes = address.GetAddressBytes();
			if (addressBytes != null)
			{
				if (addressBytes.Length != 0)
				{
					if (addressBytes[0] == 10)
					{
						return true;
					}
					if (addressBytes[0] != 192)
					{
						if (addressBytes[0] != 172)
						{
							return false;
						}
						if (addressBytes.Length != 1)
						{
							int num = addressBytes[1] & 0xF0;
							object obj = num - 16;
							return obj == null;
						}
					}
					else if (addressBytes.Length != 1)
					{
						object obj2 = addressBytes[1] - 168;
						return obj2 == null;
					}
				}
				goto IL_019c;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_019c;
		IL_019c:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}
}
