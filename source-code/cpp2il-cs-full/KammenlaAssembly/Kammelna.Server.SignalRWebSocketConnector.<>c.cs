using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Presence;
using Microsoft.AspNetCore.Http.Connections.Client;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;

namespace Kammelna.Server;

public class SignalRWebSocketConnector : ISignalRConnector
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Task<string>> <>9__2_5;

		public static Action<HttpConnectionOptions> <>9__2_0;

		public static Action<NewtonsoftJsonHubProtocolOptions> <>9__2_1;

		public static Func<string, Task> <>9__2_2;

		public static Action<string, long> <>9__3_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 4016;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Connect>b__2_0(HttpConnectionOptions options)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_011b: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a5: Expected O, but got I
			//IL_01b5: Expected O, but got I4
			//IL_0153: Expected O, but got I
			//IL_0163: Expected O, but got I
			//IL_0185: Expected O, but got I4
			//IL_0230: Unknown result type (might be due to invalid IL or missing references)
			//IL_0235: Expected O, but got Unknown
			//IL_024b: Expected O, but got I
			//IL_025c: Expected I, but got O
			//IL_027a: Expected O, but got I
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Expected O, but got Unknown
			//IL_0204: Expected O, but got I4
			//IL_01e5: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 4016;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E82D2]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			if (obj3 != null)
			{
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3+B8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v4+8]");
			Func<object> func = (Func<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v4+8]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 != null)
			{
				goto IL_00ca;
			}
			goto IL_0193;
			IL_00ca:
			object obj9 = options + 64;
			obj9 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return;
			IL_0193:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj11 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v10+B8]");
				obj7 = 0;
			}
			object obj12 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2040;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj13 = (nint)0 + (nint)3728;
			Func<object> func2 = default(Func<object>);
			func2..ctor(obj7, (IntPtr)obj13);
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v9+B8]");
			object obj15 = (nint)0 + (nint)8;
			obj15 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag5 = options == null;
			object obj16 = !flag5;
			func = func2;
			if (obj16 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_00ca;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v4+8]");
			func = (Func<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v4+8]");
			if ((nint)0 != 0)
			{
				goto IL_00ca;
			}
			goto IL_0193;
		}

		internal Task<string> <Connect>b__2_5()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 3912;
			string currentAccessTokenString = Authentication.CurrentAccessTokenString;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3+E4]");
			if ((nint)0 != 0)
			{
				return (Task<string>)(object)Task.FromResult((object)currentAccessTokenString);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return (Task<string>)(object)Task.FromResult((object)currentAccessTokenString);
		}

		internal void <Connect>b__2_1(NewtonsoftJsonHubProtocolOptions options)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			JsonSerializerSettings jsonSerializerSettings = default(JsonSerializerSettings);
			jsonSerializerSettings..ctor();
			jsonSerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
			object obj2 = options + 16;
			obj2 = jsonSerializerSettings;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal Task <Connect>b__2_2(string _)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0151: Expected O, but got I4
			//IL_00a2: Expected O, but got I
			//IL_01d7: Expected O, but got I4
			//IL_017f: Expected O, but got I
			//IL_0199: Expected O, but got I4
			//IL_0104: Expected O, but got I
			//IL_0111: Expected O, but got I
			//IL_020f: Expected O, but got I
			//IL_021c: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3912;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E82D5]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				CoordinatorService.OnSignalRConnected();
				CoordinatorService.OnReconnected();
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v10+E4]");
				if ((nint)0 != 0)
				{
					goto IL_008c;
				}
			}
			else
			{
				int num = 1;
				CoordinatorService.OnSignalRConnected();
				CoordinatorService.OnReconnected();
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v10+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_008c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45F3]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00bf;
			}
			goto IL_01a7;
			IL_00f4:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v16+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v12+30]");
			return (Task)0;
			IL_01ed:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v3+B8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v3+30]");
			return (Task)0;
			IL_00bf:
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v16+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = obj11;
			if (!flag3)
			{
				goto IL_00f4;
			}
			goto IL_01ed;
			IL_008c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45F3]");
			object obj13 = (nint)0 & (nint)1;
			if (obj13 != null)
			{
				goto IL_00bf;
			}
			goto IL_01a7;
			IL_01a7:
			int num2 = 1;
			obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v16+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			obj12 = obj11;
			if (obj14 != null)
			{
				goto IL_00f4;
			}
			goto IL_01ed;
		}

		internal void <SetHandlers>b__3_0(string wireKey, long stamp)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_006a: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
			long num = default(long);
			string text = num.ToString();
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			ContentPushService.OnContentChangedReceived(wireKey, null);
		}
	}

	private sealed class <>c__DisplayClass10_0
	{
		public SignalRWebSocketConnector <>4__this;

		public Action callback;

		internal void <Disconnect>b__0(Task task)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected O, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected O, but got Unknown
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected O, but got Unknown
			//IL_009e: Expected O, but got I
			//IL_00da: Expected O, but got I4
			//IL_0124: Expected I, but got O
			object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 4032;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj2 + 24;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 16;
			obj4 = task;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			SignalRWebSocketConnector signalRWebSocketConnector = <>4__this;
			object obj5 = typeof(UsageHint) + 616;
			object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3648;
			object obj7 = (nint)0 + (nint)3752;
			ValueTask valueTask = signalRWebSocketConnector._connection.DisposeAsync();
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			object obj9 = !flag;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			ValueTask valueTask2 = default(ValueTask);
			Task task2 = valueTask2.AsTask();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj7);
			Task task3 = task2.ContinueWith(action);
		}
	}

	private sealed class <>c__DisplayClass10_1
	{
		public Task task;

		public <>c__DisplayClass10_0 CS$<>8__locals1;

		internal void <Disconnect>b__1(Task task2)
		{
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Expected O, but got Unknown
			if (task.IsCompletedSuccessfully && task2.IsCompletedSuccessfully)
			{
				<>c__DisplayClass10_0 cS$<>8__locals = CS$<>8__locals1;
				object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v7+E4]");
				if ((nint)0 != 0)
				{
					CoroutineDummy.WaitForMainThread(cS$<>8__locals.callback);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				CoroutineDummy.WaitForMainThread(cS$<>8__locals.callback);
			}
		}
	}

	private sealed class <>c__DisplayClass2_0
	{
		[StructLayout((LayoutKind)3)]
		private struct <<Connect>b__3>d : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncTaskMethodBuilder <>t__builder;

			public <>c__DisplayClass2_0 <>4__this;

			private ValueTaskAwaiter <>u__1;

			private unsafe void MoveNext()
			{
				//IL_035e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0363: Expected O, but got Unknown
				//IL_0372: Unknown result type (might be due to invalid IL or missing references)
				//IL_0377: Expected O, but got Unknown
				//IL_0249: Expected O, but got I4
				//IL_025e: Expected I4, but got I8
				//IL_03c0: Expected O, but got I4
				//IL_0290: Expected I, but got O
				//IL_02a4: Expected I4, but got I8
				//IL_02af: Expected O, but got Ref
				//IL_02d9: Expected O, but got I4
				//IL_007c: Expected O, but got I4
				//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d2: Expected O, but got Unknown
				//IL_00fc: Expected O, but got I4
				//IL_0150: Expected O, but got I4
				//IL_0180: Unknown result type (might be due to invalid IL or missing references)
				//IL_0185: Expected O, but got Unknown
				//IL_019f: Expected O, but got I4
				//IL_01a4: Expected I, but got O
				//IL_01d2: Expected O, but got Ref
				//IL_0206: Expected O, but got I4
				//IL_022f: Expected O, but got Ref
				object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1192;
				object obj2 = typeof(UsageHint) + 624;
				ValueTaskAwaiter awaiter2 = default(ValueTaskAwaiter);
				nint num;
				if (<>1__state != 0)
				{
					<>c__DisplayClass2_0 <>c__DisplayClass2_ = <>4__this;
					if (<>4__this != null)
					{
						SignalRWebSocketConnector signalRWebSocketConnector = <>c__DisplayClass2_.<>4__this;
						if (<>c__DisplayClass2_.<>4__this != null)
						{
							bool flag = !signalRWebSocketConnector._intentionalClose;
							object obj3 = !flag;
							if (obj3 != null)
							{
								goto IL_0295;
							}
							if (<>c__DisplayClass2_.closing != null)
							{
								ValueTask valueTask = <>c__DisplayClass2_.closing.DisposeAsync();
								object obj4 = typeof(UsageHint) + 616;
								object obj5 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v23+E4]");
								bool flag2 = (nint)0 == 0;
								object obj6 = !flag2;
								if (obj6 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								ValueTask valueTask2 = default(ValueTask);
								ValueTaskAwaiter awaiter = valueTask2.GetAwaiter();
								object obj7 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v27+E4]");
								bool flag3 = (nint)0 == 0;
								object obj8 = !flag3;
								if (obj8 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @31AA8CC");
								object obj10 = default(object);
								object obj9 = obj10 & 1;
								bool flag4 = obj9 == null;
								object obj11 = !flag4;
								num = unchecked((nint)null);
								if (obj11 == null)
								{
									<>1__state = 0;
									<>u__1 = awaiter2;
									object obj12 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 40));
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									object obj13 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v33+E4]");
									bool flag5 = (nint)0 == 0;
									object obj14 = !flag5;
									if (obj14 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									AsyncTaskMethodBuilder asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
									((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_0396;
							}
							NullReferenceException ex = new NullReferenceException();
						}
						else
						{
							NullReferenceException ex = new NullReferenceException();
						}
					}
					else
					{
						NullReferenceException ex = new NullReferenceException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
					return;
				}
				<>u__1 = (ValueTaskAwaiter)0;
				_ = 0;
				<>1__state = -1;
				awaiter2 = <>u__1;
				goto IL_0396;
				IL_0295:
				<>1__state = -2;
				AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
				object obj15 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v9+E4]");
				bool flag6 = (nint)0 == 0;
				object obj16 = !flag6;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->SetResult();
				return;
				IL_0396:
				object obj17 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v3+E4]");
				bool flag7 = (nint)0 == 0;
				object obj18 = !flag7;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @31AAA48");
				CoordinatorService.OnSignalRClosed();
				num = unchecked((nint)null);
				goto IL_0295;
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

		public HubConnection closing;

		public SignalRWebSocketConnector <>4__this;

		internal unsafe Task <Connect>b__3(Exception _)
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
			<<Connect>b__3>d stateMachine = default(<<Connect>b__3>d);
			object obj4 = (nint)(&stateMachine) | (nint)8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 32));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)((nint)(&stateMachine) | (nint)8);
			((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->Start(ref stateMachine);
			AsyncTaskMethodBuilder asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder)((nint)(&stateMachine) | (nint)8);
			return ((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder3)->Task;
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct <MarkChatMessagesAsReceived>d__5 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public SignalRWebSocketConnector <>4__this;

		public int userId;

		private TaskAwaiter <>u__1;

		private unsafe void MoveNext()
		{
			//IL_0186: Expected O, but got I4
			//IL_0195: Expected I4, but got I8
			//IL_01b3: Expected I4, but got I8
			//IL_01be: Expected O, but got Ref
			//IL_0092: Expected O, but got I4
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected O, but got Unknown
			//IL_00c6: Expected O, but got I4
			//IL_0125: Expected O, but got I4
			//IL_0149: Expected O, but got Ref
			//IL_0167: Expected O, but got Ref
			TaskAwaiter awaiter2 = default(TaskAwaiter);
			if (<>1__state != 0)
			{
				SignalRWebSocketConnector signalRWebSocketConnector = <>4__this;
				NullReferenceException ex;
				if (<>4__this != null)
				{
					if (signalRWebSocketConnector._connection != null)
					{
						HubConnectionState state = signalRWebSocketConnector._connection.State;
						if (state == HubConnectionState.Connected)
						{
							object obj = 153100288 + 1024;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
							object methodName = "LAK" + 3816;
							object arg = default(object);
							Task task = HubConnectionExtensions.InvokeAsync(signalRWebSocketConnector._connection, (string)methodName, arg, (CancellationToken)0);
							if (task != null)
							{
								TaskAwaiter awaiter = task.GetAwaiter();
								bool isCompleted = awaiter2.IsCompleted;
								bool flag = !isCompleted;
								object obj2 = !flag;
								if (obj2 == null)
								{
									<>1__state = 0;
									object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 56));
									obj3 = awaiter2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
									((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_0228;
							}
							ex = new NullReferenceException();
							goto IL_01e4;
						}
					}
					goto IL_01a4;
				}
				ex = new NullReferenceException();
				goto IL_01e4;
			}
			<>u__1 = (TaskAwaiter)0;
			<>1__state = -1;
			awaiter2 = <>u__1;
			goto IL_0228;
			IL_01e4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_0228:
			awaiter2.GetResult();
			goto IL_01a4;
			IL_01a4:
			<>1__state = -2;
			AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_000b: Expected O, but got Ref
			AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct <SendGameInvitations>d__7 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public SignalRWebSocketConnector <>4__this;

		public int[] userIds;

		public int roomId;

		public int tournamentId;

		public string password;

		private TaskAwaiter <>u__1;

		private unsafe void MoveNext()
		{
			//IL_0298: Expected O, but got I4
			//IL_02a7: Expected I4, but got I8
			//IL_02c5: Expected I4, but got I8
			//IL_02d0: Expected O, but got Ref
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Expected O, but got Unknown
			//IL_00c0: Expected O, but got I4
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Expected O, but got Unknown
			//IL_0124: Expected O, but got I4
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected O, but got Unknown
			//IL_017d: Expected O, but got I4
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a6: Expected O, but got Unknown
			//IL_01d9: Expected O, but got I4
			//IL_0233: Expected O, but got I4
			//IL_0257: Expected O, but got Ref
			//IL_0275: Expected O, but got Ref
			TaskAwaiter awaiter2 = default(TaskAwaiter);
			if (<>1__state != 0)
			{
				SignalRWebSocketConnector signalRWebSocketConnector = <>4__this;
				NullReferenceException ex;
				if (<>4__this != null)
				{
					if (signalRWebSocketConnector._connection != null)
					{
						HubConnectionState state = signalRWebSocketConnector._connection.State;
						if (state == HubConnectionState.Connected)
						{
							object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
							object obj2 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X0_v15+E4]");
							bool flag = (nint)0 == 0;
							object obj3 = !flag;
							if (obj3 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							string serverID = Config.ServerID;
							object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
							object obj5 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v19+E4]");
							bool flag2 = (nint)0 == 0;
							object obj6 = !flag2;
							if (obj6 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Games currentGame = Preferences.CurrentGame;
							object obj7 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
							object obj8 = 153100288 + 1024;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
							object methodName = "SERVICE_DISABLED" + 2784;
							object arg = default(object);
							object arg2 = default(object);
							object arg3 = default(object);
							Task task = HubConnectionExtensions.InvokeAsync(signalRWebSocketConnector._connection, (string)methodName, userIds, serverID, arg, arg2, arg3, password, (CancellationToken)0);
							if (task != null)
							{
								TaskAwaiter awaiter = task.GetAwaiter();
								bool isCompleted = awaiter2.IsCompleted;
								bool flag3 = !isCompleted;
								object obj9 = !flag3;
								if (obj9 == null)
								{
									<>1__state = 0;
									object obj10 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 72));
									obj10 = awaiter2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
									((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_033f;
							}
							ex = new NullReferenceException();
							goto IL_02fb;
						}
					}
					goto IL_02b6;
				}
				ex = new NullReferenceException();
				goto IL_02fb;
			}
			<>u__1 = (TaskAwaiter)0;
			<>1__state = -1;
			awaiter2 = <>u__1;
			goto IL_033f;
			IL_02fb:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_033f:
			awaiter2.GetResult();
			goto IL_02b6;
			IL_02b6:
			<>1__state = -2;
			AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_000b: Expected O, but got Ref
			AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct <SendMessage>d__4 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public SignalRWebSocketConnector <>4__this;

		public int recipientId;

		public PrivateMessageModel model;

		private TaskAwaiter <>u__1;

		private unsafe void MoveNext()
		{
			//IL_01c7: Expected O, but got I4
			//IL_01d6: Expected I4, but got I8
			//IL_01f4: Expected I4, but got I8
			//IL_01ff: Expected O, but got Ref
			//IL_0092: Expected O, but got I4
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Expected O, but got Unknown
			//IL_0107: Expected O, but got I4
			//IL_023e: Expected I, but got O
			//IL_0166: Expected O, but got I4
			//IL_018a: Expected O, but got Ref
			//IL_01a8: Expected O, but got Ref
			TaskAwaiter awaiter2 = default(TaskAwaiter);
			if (<>1__state != 0)
			{
				SignalRWebSocketConnector signalRWebSocketConnector = <>4__this;
				NullReferenceException ex;
				if (<>4__this != null)
				{
					if (signalRWebSocketConnector._connection != null)
					{
						HubConnectionState state = signalRWebSocketConnector._connection.State;
						if (state == HubConnectionState.Connected)
						{
							object obj = 153100288 + 1024;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
							PrivateMessageModel privateMessageModel = model;
							if (model != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
								object obj2 = "SERVICE_DISABLED" + 2800;
								object arg = default(object);
								object arg2 = default(object);
								Task task = HubConnectionExtensions.InvokeAsync(signalRWebSocketConnector._connection, (string)obj2, arg, privateMessageModel.message, arg2, (CancellationToken)0);
								if (task != null)
								{
									TaskAwaiter awaiter = task.GetAwaiter();
									bool isCompleted = awaiter2.IsCompleted;
									bool flag = !isCompleted;
									object obj3 = !flag;
									if (obj3 == null)
									{
										<>1__state = 0;
										object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 64));
										obj4 = awaiter2;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
										((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										return;
									}
									goto IL_0287;
								}
								ex = new NullReferenceException();
								nint num = (nint)obj2;
							}
							else
							{
								ex = new NullReferenceException();
								int num2 = default(int);
								nint num = (nint)(&num2);
							}
							goto IL_0243;
						}
					}
					goto IL_01e5;
				}
				ex = new NullReferenceException();
				goto IL_0243;
			}
			<>u__1 = (TaskAwaiter)0;
			<>1__state = -1;
			awaiter2 = <>u__1;
			goto IL_0287;
			IL_0243:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_01e5:
			<>1__state = -2;
			AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->SetResult();
			return;
			IL_0287:
			awaiter2.GetResult();
			goto IL_01e5;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_000b: Expected O, but got Ref
			AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct <SetPresence>d__9 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public SignalRWebSocketConnector <>4__this;

		public PresenceState state;

		private TaskAwaiter <>u__1;

		private unsafe void MoveNext()
		{
			//IL_0169: Expected O, but got I4
			//IL_0178: Expected I4, but got I8
			//IL_0196: Expected I4, but got I8
			//IL_01a1: Expected O, but got Ref
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Expected O, but got Unknown
			//IL_00ae: Expected O, but got I4
			//IL_0108: Expected O, but got I4
			//IL_012c: Expected O, but got Ref
			//IL_014a: Expected O, but got Ref
			TaskAwaiter awaiter2 = default(TaskAwaiter);
			if (<>1__state != 0)
			{
				SignalRWebSocketConnector signalRWebSocketConnector = <>4__this;
				NullReferenceException ex;
				if (<>4__this != null)
				{
					if (signalRWebSocketConnector._connection != null)
					{
						HubConnectionState hubConnectionState = signalRWebSocketConnector._connection.State;
						if (hubConnectionState == HubConnectionState.Connected)
						{
							object methodName = "SERVICE_DISABLED" + 4032;
							Task task = HubConnectionExtensions.SendAsync(signalRWebSocketConnector._connection, (string)methodName, state, (CancellationToken)0);
							if (task != null)
							{
								TaskAwaiter awaiter = task.GetAwaiter();
								bool isCompleted = awaiter2.IsCompleted;
								bool flag = !isCompleted;
								object obj = !flag;
								if (obj == null)
								{
									<>1__state = 0;
									object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 56));
									obj2 = awaiter2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
									((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_020b;
							}
							ex = new NullReferenceException();
							goto IL_01c7;
						}
					}
					goto IL_0187;
				}
				ex = new NullReferenceException();
				goto IL_01c7;
			}
			<>u__1 = (TaskAwaiter)0;
			<>1__state = -1;
			awaiter2 = <>u__1;
			goto IL_020b;
			IL_01c7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_020b:
			awaiter2.GetResult();
			goto IL_0187;
			IL_0187:
			<>1__state = -2;
			AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_000b: Expected O, but got Ref
			AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct <UpdateConnectionStatus>d__6 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public SignalRWebSocketConnector <>4__this;

		public string serverId;

		private TaskAwaiter <>u__1;

		private unsafe void MoveNext()
		{
			//IL_0169: Expected O, but got I4
			//IL_0178: Expected I4, but got I8
			//IL_0196: Expected I4, but got I8
			//IL_01a1: Expected O, but got Ref
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Expected O, but got Unknown
			//IL_00ae: Expected O, but got I4
			//IL_0108: Expected O, but got I4
			//IL_012c: Expected O, but got Ref
			//IL_014a: Expected O, but got Ref
			TaskAwaiter awaiter2 = default(TaskAwaiter);
			if (<>1__state != 0)
			{
				SignalRWebSocketConnector signalRWebSocketConnector = <>4__this;
				NullReferenceException ex;
				if (<>4__this != null)
				{
					if (signalRWebSocketConnector._connection != null)
					{
						HubConnectionState state = signalRWebSocketConnector._connection.State;
						if (state == HubConnectionState.Connected)
						{
							object methodName = "Unsupported map type" + 176;
							Task task = HubConnectionExtensions.InvokeAsync(signalRWebSocketConnector._connection, (string)methodName, serverId, (CancellationToken)0);
							if (task != null)
							{
								TaskAwaiter awaiter = task.GetAwaiter();
								bool isCompleted = awaiter2.IsCompleted;
								bool flag = !isCompleted;
								object obj = !flag;
								if (obj == null)
								{
									<>1__state = 0;
									object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 56));
									obj2 = awaiter2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
									((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_020b;
							}
							ex = new NullReferenceException();
							goto IL_01c7;
						}
					}
					goto IL_0187;
				}
				ex = new NullReferenceException();
				goto IL_01c7;
			}
			<>u__1 = (TaskAwaiter)0;
			<>1__state = -1;
			awaiter2 = <>u__1;
			goto IL_020b;
			IL_01c7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_020b:
			awaiter2.GetResult();
			goto IL_0187;
			IL_0187:
			<>1__state = -2;
			AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_000b: Expected O, but got Ref
			AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct <UpdateFriendStatus>d__8 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public SignalRWebSocketConnector <>4__this;

		public long friendId;

		private TaskAwaiter <>u__1;

		private unsafe void MoveNext()
		{
			//IL_0186: Expected O, but got I4
			//IL_0195: Expected I4, but got I8
			//IL_01b3: Expected I4, but got I8
			//IL_01be: Expected O, but got Ref
			//IL_0092: Expected O, but got I4
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected O, but got Unknown
			//IL_00c6: Expected O, but got I4
			//IL_0125: Expected O, but got I4
			//IL_0149: Expected O, but got Ref
			//IL_0167: Expected O, but got Ref
			TaskAwaiter awaiter2 = default(TaskAwaiter);
			if (<>1__state != 0)
			{
				SignalRWebSocketConnector signalRWebSocketConnector = <>4__this;
				NullReferenceException ex;
				if (<>4__this != null)
				{
					if (signalRWebSocketConnector._connection != null)
					{
						HubConnectionState state = signalRWebSocketConnector._connection.State;
						if (state == HubConnectionState.Connected)
						{
							object obj = 153100288 + 1024;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
							object methodName = "Unsupported map type" + 184;
							object arg = default(object);
							Task task = HubConnectionExtensions.InvokeAsync(signalRWebSocketConnector._connection, (string)methodName, arg, (CancellationToken)0);
							if (task != null)
							{
								TaskAwaiter awaiter = task.GetAwaiter();
								bool isCompleted = awaiter2.IsCompleted;
								bool flag = !isCompleted;
								object obj2 = !flag;
								if (obj2 == null)
								{
									<>1__state = 0;
									object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 56));
									obj3 = awaiter2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
									((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_0228;
							}
							ex = new NullReferenceException();
							goto IL_01e4;
						}
					}
					goto IL_01a4;
				}
				ex = new NullReferenceException();
				goto IL_01e4;
			}
			<>u__1 = (TaskAwaiter)0;
			<>1__state = -1;
			awaiter2 = <>u__1;
			goto IL_0228;
			IL_01e4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_0228:
			awaiter2.GetResult();
			goto IL_01a4;
			IL_01a4:
			<>1__state = -2;
			AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_000b: Expected O, but got Ref
			AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private HubConnection _connection;

	private bool _intentionalClose;

	public void Connect(string hostUrl, string token)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_00b5: Expected O, but got I4
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_01bc: Expected O, but got I
		//IL_01cc: Expected O, but got I
		//IL_01ee: Expected O, but got I4
		//IL_0155: Expected O, but got I
		//IL_0165: Expected O, but got I
		//IL_0187: Expected O, but got I4
		//IL_0311: Expected O, but got I
		//IL_0321: Expected O, but got I
		//IL_0343: Expected O, but got I4
		//IL_0348: Expected I, but got O
		//IL_021e: Expected O, but got I4
		//IL_03b9: Expected O, but got I
		//IL_02a5: Expected O, but got I
		//IL_02b5: Expected O, but got I
		//IL_02d7: Expected O, but got I4
		//IL_02dc: Expected I, but got O
		//IL_0997: Unknown result type (might be due to invalid IL or missing references)
		//IL_099c: Expected O, but got Unknown
		//IL_09b2: Expected O, but got I
		//IL_09c3: Expected I, but got O
		//IL_09e1: Expected O, but got I
		//IL_0378: Expected O, but got I4
		//IL_024e: Expected O, but got I
		//IL_0a0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a14: Expected O, but got Unknown
		//IL_0a2a: Expected O, but got I
		//IL_0a3b: Expected I, but got O
		//IL_0a59: Expected O, but got I
		//IL_0a78: Expected I, but got O
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected O, but got Unknown
		//IL_0416: Expected I, but got O
		//IL_0426: Expected O, but got I
		//IL_03a8: Expected O, but got I
		//IL_0461: Expected O, but got I
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected O, but got Unknown
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Expected O, but got Unknown
		//IL_0539: Expected O, but got I4
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected O, but got Unknown
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Expected O, but got Unknown
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected O, but got Unknown
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected O, but got Unknown
		//IL_0881: Expected F8, but got I8
		//IL_063c: Expected O, but got I
		//IL_064c: Expected O, but got I
		//IL_066e: Expected O, but got I4
		//IL_05cd: Expected O, but got I
		//IL_05dd: Expected O, but got I
		//IL_05ff: Expected O, but got I4
		//IL_08a4: Expected F8, but got I8
		//IL_06a6: Expected O, but got I4
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Expected O, but got Unknown
		//IL_0ad4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad9: Expected O, but got Unknown
		//IL_0aef: Expected O, but got I
		//IL_0b00: Expected I, but got O
		//IL_0b1e: Expected O, but got I
		//IL_0b3d: Expected I, but got O
		//IL_0739: Unknown result type (might be due to invalid IL or missing references)
		//IL_073e: Expected O, but got Unknown
		//IL_0754: Expected O, but got I
		//IL_0765: Expected I, but got O
		//IL_06d6: Expected O, but got I
		//IL_08bf: Expected F8, but got I8
		//IL_08c4: Expected I, but got O
		//IL_08ef: Expected F8, but got I8
		//IL_08f4: Expected I, but got O
		//IL_07bf: Expected O, but got I4
		//IL_07d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d7: Expected O, but got Unknown
		//IL_07f2: Expected O, but got I
		//IL_0800: Expected I, but got O
		//IL_091c: Expected F8, but got I8
		//IL_0921: Expected I, but got O
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		HubConnectionBuilder hubConnectionBuilder = default(HubConnectionBuilder);
		string url;
		object obj9;
		object obj11;
		Action<HttpConnectionOptions> configureHttpConnection;
		if (obj2 != null)
		{
			object obj3 = obj2 + 24;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_intentionalClose = false;
			Authentication.SyncAccessTokenCache();
			object obj4 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 520;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			hubConnectionBuilder..ctor();
			object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v16+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string serverID = Config.ServerID;
			object obj8 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 1160;
			url = hostUrl + (string)obj8 + serverID;
			obj9 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 4016;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v85+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v85+B8]");
				obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v62+10]");
				configureHttpConnection = (Action<HttpConnectionOptions>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v62+10]");
				bool flag2 = (nint)0 == 0;
				object obj12 = !flag2;
				if (obj12 == null)
				{
					goto IL_01fc;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v85+B8]");
				obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v62+10]");
				configureHttpConnection = (Action<HttpConnectionOptions>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v62+10]");
				bool flag3 = (nint)0 == 0;
				object obj13 = !flag3;
				if (obj13 == null)
				{
					goto IL_01fc;
				}
			}
			goto IL_0253;
		}
		NullReferenceException ex = new NullReferenceException();
		object obj14 = null;
		goto IL_0933;
		IL_0aa1:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v180 @ X8_v20] (should have been resolved before IL gen)");
		object obj15;
		object obj16 = default(object);
		object obj21;
		Func<string, Task> value;
		if (this != null)
		{
			obj15 = this + 16;
			obj15 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj17 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X0_v37+E4]");
			bool flag4 = (nint)0 == 0;
			object obj19 = !flag4;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TimeSpan timeSpan = TimeSpan.FromSeconds(90.0);
			if (obj15 != null)
			{
				SetHandlers();
				object obj20 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v62+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v62+B8]");
					obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v37+20]");
					value = (Func<string, Task>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v37+20]");
					bool flag5 = (nint)0 == 0;
					object obj22 = !flag5;
					obj14 = obj16;
					if (obj22 == null)
					{
						goto IL_0684;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj20 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v62+B8]");
					obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v37+20]");
					value = (Func<string, Task>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v37+20]");
					bool flag6 = (nint)0 == 0;
					object obj23 = !flag6;
					obj14 = obj16;
					if (obj23 == null)
					{
						goto IL_0684;
					}
				}
				goto IL_06db;
			}
			ex = new NullReferenceException();
			double num = 4.63603360391286E+18;
			obj14 = obj16;
		}
		else
		{
			ex = new NullReferenceException();
			obj14 = obj16;
		}
		goto IL_0933;
		IL_0253:
		IHubConnectionBuilder hubConnectionBuilder2 = HubConnectionBuilderHttpExtensions.WithUrl(hubConnectionBuilder, url, configureHttpConnection);
		object obj24 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v75+E4]");
		object obj25;
		Action<object> action;
		nint num2;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v75+B8]");
			obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v51+18]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v51+18]");
			bool flag7 = (nint)0 == 0;
			object obj26 = !flag7;
			num2 = unchecked((nint)null);
			if (obj26 == null)
			{
				goto IL_0356;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj24 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v75+B8]");
			obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v51+18]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v51+18]");
			bool flag8 = (nint)0 == 0;
			object obj27 = !flag8;
			num2 = unchecked((nint)null);
			if (obj27 == null)
			{
				goto IL_0356;
			}
		}
		goto IL_03ad;
		IL_0356:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v75+E4]");
		bool flag9 = (nint)0 == 0;
		object obj28 = !flag9;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj29 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v57+B8]");
			obj25 = 0;
		}
		object obj30 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj31 = (nint)0 + (nint)3712;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj25, (IntPtr)obj31);
		object obj32 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v56+B8]");
		object obj33 = (nint)0 + (nint)24;
		obj33 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		action = action2;
		num2 = unchecked((nint)null);
		goto IL_03ad;
		IL_0933:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0684:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v62+E4]");
		bool flag10 = (nint)0 == 0;
		object obj34 = !flag10;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj35 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v43+B8]");
			obj21 = 0;
		}
		object obj36 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj37 = (nint)0 + (nint)3720;
		Func<object, object> func = default(Func<object, object>);
		func..ctor(obj21, (IntPtr)obj37);
		object obj38 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v42+B8]");
		object obj39 = (nint)0 + (nint)32;
		obj39 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		value = (Func<string, Task>)func;
		num2 = unchecked((nint)null);
		string text = (string)obj37;
		obj14 = func;
		goto IL_06db;
		IL_06db:
		if (obj15 != null)
		{
			((HubConnection)obj15).Reconnected += value;
			object obj40 = obj2 + 16;
			obj40 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj41 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj42 = (nint)0 + (nint)3760;
			Func<object, object> func2 = default(Func<object, object>);
			func2..ctor(obj2, (IntPtr)obj42);
			if (obj15 != null)
			{
				((HubConnection)obj15).Closed += (Func<Exception, Task>)func2;
				if (obj15 != null)
				{
					Task task = ((HubConnection)obj15).StartAsync((CancellationToken)0);
					object obj43 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3648;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj44 = (nint)0 + (nint)3888;
					Action<object> action3 = default(Action<object>);
					action3..ctor((object)this, (IntPtr)obj44);
					if (task != null)
					{
						Task task2 = task.ContinueWith(action3);
						return;
					}
					ex = new NullReferenceException();
					double num = 4.63603360391286E+18;
					num2 = unchecked((nint)null);
					text = (string)obj44;
					obj14 = this;
				}
				else
				{
					ex = new NullReferenceException();
					double num = 4.63603360391286E+18;
					num2 = unchecked((nint)null);
					text = null;
					obj14 = func2;
				}
			}
			else
			{
				ex = new NullReferenceException();
				double num = 4.63603360391286E+18;
				num2 = unchecked((nint)null);
				text = (string)obj42;
				obj14 = obj2;
			}
		}
		else
		{
			ex = new NullReferenceException();
			double num = 4.63603360391286E+18;
		}
		goto IL_0933;
		IL_01fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v85+E4]");
		bool flag11 = (nint)0 == 0;
		object obj45 = !flag11;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj46 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X8_v68+B8]");
			obj11 = 0;
		}
		object obj47 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj48 = (nint)0 + (nint)3704;
		Action<object> action4 = default(Action<object>);
		action4..ctor(obj11, (IntPtr)obj48);
		object obj49 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v67+B8]");
		object obj50 = (nint)0 + (nint)16;
		obj50 = action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		configureHttpConnection = action4;
		goto IL_0253;
		IL_04a2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		text = null;
		object obj52 = default(object);
		object obj51 = obj52;
		goto IL_0aa1;
		IL_03ad:
		object obj53 = (nint)0 + (nint)3032;
		text = (string)obj53;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE55B8");
		IHubConnectionBuilder hubConnectionBuilder4 = default(IHubConnectionBuilder);
		IHubConnectionBuilder hubConnectionBuilder3 = HubConnectionBuilderExtensions.WithAutomaticReconnect(hubConnectionBuilder4);
		if (hubConnectionBuilder3 != null)
		{
			object obj54 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3112;
			nint num3 = (nint)hubConnectionBuilder3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v19 (Il2CppClass<Microsoft.AspNetCore.SignalR.Client.IHubConnectionBuilder>)+12E]");
			object obj55 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v19 (Il2CppClass<Microsoft.AspNetCore.SignalR.Client.IHubConnectionBuilder>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_04a2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v19 (Il2CppClass<Microsoft.AspNetCore.SignalR.Client.IHubConnectionBuilder>)+B0]");
			object obj56 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X10_v6-8]");
				if (0 == (nint)obj54)
				{
					break;
				}
				obj56 += 16;
				obj55--;
				if ((nint)obj55 != 1)
				{
					continue;
				}
				goto IL_04a2;
			}
			object obj57 = num3 + obj56;
			obj51 = obj57 + 312;
			goto IL_0aa1;
		}
		ex = new NullReferenceException();
		obj14 = null;
		goto IL_0933;
	}

	public void SetHandlers()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_003b: Expected O, but got I
		//IL_0047: Expected O, but got I
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_057e: Expected I, but got O
		//IL_0082: Expected I, but got O
		//IL_00ac: Expected O, but got I
		//IL_00ba: Expected I, but got O
		//IL_00df: Expected O, but got I
		//IL_00ed: Expected I, but got O
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_0126: Expected O, but got I
		//IL_0134: Expected I, but got O
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_0168: Expected O, but got I
		//IL_0176: Expected I, but got O
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_01af: Expected O, but got I
		//IL_01bd: Expected I, but got O
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_0219: Expected O, but got I4
		//IL_0599: Expected O, but got I
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Expected O, but got Unknown
		//IL_05b9: Expected O, but got I
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected O, but got Unknown
		//IL_05d4: Expected O, but got I
		//IL_05e0: Expected O, but got I
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Expected O, but got Unknown
		//IL_05fb: Expected O, but got I
		//IL_060b: Expected O, but got I
		//IL_061b: Expected O, but got I
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Expected O, but got Unknown
		//IL_064c: Expected O, but got I4
		//IL_0700: Expected I, but got O
		//IL_0260: Expected O, but got I4
		//IL_0311: Expected I, but got O
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Expected O, but got Unknown
		//IL_0684: Expected O, but got I
		//IL_0695: Expected I, but got O
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a9: Expected O, but got Unknown
		//IL_06c7: Expected O, but got I
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected O, but got Unknown
		//IL_0359: Expected I, but got O
		//IL_02b5: Expected O, but got I
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02d0: Expected O, but got I
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected O, but got Unknown
		//IL_02a4: Expected O, but got I
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected O, but got Unknown
		//IL_0379: Expected O, but got I
		//IL_039e: Expected O, but got I
		//IL_03ac: Expected I, but got O
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected O, but got Unknown
		//IL_03e0: Expected O, but got I
		//IL_03ee: Expected I, but got O
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected O, but got Unknown
		//IL_0427: Expected O, but got I
		//IL_0435: Expected I, but got O
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected O, but got Unknown
		//IL_0469: Expected O, but got I
		//IL_0477: Expected I, but got O
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected O, but got Unknown
		//IL_04b0: Expected O, but got I
		//IL_04be: Expected I, but got O
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected O, but got Unknown
		//IL_04f2: Expected O, but got I
		//IL_0500: Expected I, but got O
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected O, but got Unknown
		//IL_0539: Expected O, but got I
		//IL_0547: Expected I, but got O
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj2 = (nint)0 + (nint)3848;
		object obj3 = "Read object reference Id '{0}' for {1}." + 288;
		object obj4 = (nint)0 + (nint)2784;
		object obj5 = (nint)0 + (nint)3800;
		object obj6 = "Complete" + 520;
		object obj7 = "October" + 752;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E5F1E8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)null, (IntPtr)obj5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E5F1E8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = (nint)0 + (nint)3856;
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)null, (IntPtr)obj8);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E5F1E8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = (nint)0 + (nint)3824;
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)null, (IntPtr)obj9);
		object obj10 = "Read object reference Id '{0}' for {1}." + 264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E5F1E8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)3816;
		Action<object> action5 = default(Action<object>);
		action5..ctor((object)null, (IntPtr)obj11);
		object obj12 = "Unsupported map type" + 184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E5F1E8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)3880;
		Action<object> action6 = default(Action<object>);
		action6..ctor((object)null, (IntPtr)obj13);
		object obj14 = "Read object reference Id '{0}' for {1}." + 1632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E5F1E8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)3808;
		Action<object> action7 = default(Action<object>);
		action7..ctor((object)null, (IntPtr)obj15);
		object obj16 = "DNQUALIFIER" + 3344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E5F1E8");
		object obj17 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 4016;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v31+E4]");
		bool flag = (nint)0 == 0;
		object obj19 = !flag;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj17;
		}
		object obj20 = (nint)0 + (nint)2792;
		object obj21 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 760;
		object obj22 = (nint)0 + (nint)2520;
		object methodName = "Complete" + 952;
		object obj23 = (nint)0 + (nint)2800;
		object obj24 = (nint)0 + (nint)2504;
		object methodName2 = "Complete" + 928;
		object obj25 = (nint)0 + (nint)3904;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v31+B8]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v54+28]");
		Action<object, long> action8 = (Action<object, long>)0;
		object obj27 = "Complete" + 944;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v54+28]");
		bool flag2 = (nint)0 == 0;
		object obj28 = !flag2;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v31+E4]");
			bool flag3 = (nint)0 == 0;
			object obj29 = !flag3;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj30 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 4016;
				object obj31 = obj30;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v64+B8]");
				obj26 = 0;
			}
			object obj32 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 752;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj33 = (nint)0 + (nint)3736;
			Action<object, long> action9 = default(Action<object, long>);
			action9..ctor(obj26, (IntPtr)obj33);
			object obj34 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 4016;
			object obj35 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v61+B8]");
			object obj36 = (nint)0 + (nint)40;
			obj36 = action9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj23 = (nint)0 + (nint)2800;
			methodName2 = "Complete" + 928;
			obj20 = (nint)0 + (nint)2792;
			action8 = action9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E5F748");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action10 = default(Action<object, object>);
		action10..ctor((object)null, (IntPtr)obj22);
		IDisposable disposable = HubConnectionExtensions.On(_connection, (string)methodName, action10);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action11 = default(Action<object, object>);
		action11..ctor((object)null, (IntPtr)obj24);
		IDisposable disposable2 = HubConnectionExtensions.On(_connection, (string)methodName2, action11);
		object obj37 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action12 = default(Action<object>);
		action12..ctor((object)null, (IntPtr)obj25);
		object obj38 = "Cannot populate JSON object onto type '{0}'." + 3200;
		object obj39 = (nint)0 + (nint)2784;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E5F1E8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj40 = (nint)0 + (nint)3752;
		Action<object> action13 = default(Action<object>);
		action13..ctor((object)null, (IntPtr)obj40);
		object obj41 = "Cannot populate JSON object onto type '{0}'." + 2944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E5F1E8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj42 = (nint)0 + (nint)3776;
		Action<object> action14 = default(Action<object>);
		action14..ctor((object)null, (IntPtr)obj42);
		object obj43 = "Cannot populate JSON object onto type '{0}'." + 2968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E5F1E8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj44 = (nint)0 + (nint)3768;
		Action<object> action15 = default(Action<object>);
		action15..ctor((object)null, (IntPtr)obj44);
		object obj45 = "Cannot populate JSON object onto type '{0}'." + 2960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E5F1E8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj46 = (nint)0 + (nint)3760;
		Action<object> action16 = default(Action<object>);
		action16..ctor((object)null, (IntPtr)obj46);
		object obj47 = "Cannot populate JSON object onto type '{0}'." + 2952;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E5F1E8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj48 = (nint)0 + (nint)3864;
		Action<object> action17 = default(Action<object>);
		action17..ctor((object)null, (IntPtr)obj48);
		object obj49 = "October" + 552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E5F1E8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj50 = (nint)0 + (nint)3784;
		Action<object> action18 = default(Action<object>);
		action18..ctor((object)null, (IntPtr)obj50);
		object obj51 = "Cannot populate JSON object onto type '{0}'." + 2992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E5F1E8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj52 = (nint)0 + (nint)3792;
		Action<object> action19 = default(Action<object>);
		action19..ctor((object)null, (IntPtr)obj52);
		object obj53 = "Cannot populate JSON object onto type '{0}'." + 3008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E5F1E8");
	}

	public unsafe void SendMessage(PrivateMessageModel model, int recipientId)
	{
		//IL_0056: Expected O, but got I
		//IL_006e: Expected O, but got Ref
		//IL_0014: Expected O, but got Ref
		//IL_002c: Expected O, but got I
		AsyncVoidMethodBuilder asyncVoidMethodBuilder = AsyncVoidMethodBuilder.Create();
		<SendMessage>d__4 stateMachine = default(<SendMessage>d__4);
		object obj = (nint)(&stateMachine) | (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 40));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 56));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)((nint)(&stateMachine) | (nint)8);
		((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->Start(ref stateMachine);
	}

	public unsafe void MarkChatMessagesAsReceived(int userId)
	{
		//IL_0039: Expected O, but got I
		//IL_0051: Expected O, but got Ref
		//IL_0014: Expected O, but got I
		AsyncVoidMethodBuilder asyncVoidMethodBuilder = AsyncVoidMethodBuilder.Create();
		<MarkChatMessagesAsReceived>d__5 stateMachine = default(<MarkChatMessagesAsReceived>d__5);
		object obj = (nint)(&stateMachine) | (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 40));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)((nint)(&stateMachine) | (nint)8);
		((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->Start(ref stateMachine);
	}

	public unsafe void UpdateConnectionStatus(string serverId)
	{
		//IL_0056: Expected O, but got I
		//IL_006e: Expected O, but got Ref
		//IL_0014: Expected O, but got Ref
		//IL_002c: Expected O, but got I
		AsyncVoidMethodBuilder asyncVoidMethodBuilder = AsyncVoidMethodBuilder.Create();
		<UpdateConnectionStatus>d__6 stateMachine = default(<UpdateConnectionStatus>d__6);
		object obj = (nint)(&stateMachine) | (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 40));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 48));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)((nint)(&stateMachine) | (nint)8);
		((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->Start(ref stateMachine);
	}

	public unsafe void SendGameInvitations(int[] userIds, int roomId, string password, int tournamentId)
	{
		//IL_006e: Expected O, but got I
		//IL_0086: Expected O, but got Ref
		//IL_0014: Expected O, but got Ref
		//IL_002c: Expected O, but got Ref
		//IL_0049: Expected O, but got I
		AsyncVoidMethodBuilder asyncVoidMethodBuilder = AsyncVoidMethodBuilder.Create();
		<SendGameInvitations>d__7 stateMachine = default(<SendGameInvitations>d__7);
		object obj = (nint)(&stateMachine) | (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 40));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 48));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 64));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)((nint)(&stateMachine) | (nint)8);
		((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->Start(ref stateMachine);
	}

	public unsafe void UpdateFriendStatus(long friendId)
	{
		//IL_0039: Expected O, but got I
		//IL_0051: Expected O, but got Ref
		//IL_0014: Expected O, but got I
		AsyncVoidMethodBuilder asyncVoidMethodBuilder = AsyncVoidMethodBuilder.Create();
		<UpdateFriendStatus>d__8 stateMachine = default(<UpdateFriendStatus>d__8);
		object obj = (nint)(&stateMachine) | (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 40));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)((nint)(&stateMachine) | (nint)8);
		((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->Start(ref stateMachine);
	}

	public unsafe void SetPresence(PresenceState state)
	{
		//IL_0056: Expected O, but got I
		//IL_006e: Expected O, but got Ref
		//IL_0014: Expected O, but got Ref
		//IL_002c: Expected O, but got I
		AsyncVoidMethodBuilder asyncVoidMethodBuilder = AsyncVoidMethodBuilder.Create();
		<SetPresence>d__9 stateMachine = default(<SetPresence>d__9);
		object obj = (nint)(&stateMachine) | (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 40));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 48));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)((nint)(&stateMachine) | (nint)8);
		((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->Start(ref stateMachine);
	}

	public void Disconnect(Action callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0095: Expected O, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00c8: Expected O, but got I
		//IL_00d9: Expected I, but got O
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 4024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		NullReferenceException ex;
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 24;
			Action action = default(Action);
			obj4 = action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_intentionalClose = true;
			if (_connection != null)
			{
				Task task = _connection.StopAsync((CancellationToken)0);
				object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3648;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj6 = (nint)0 + (nint)3744;
				Action<object> action2 = default(Action<object>);
				action2..ctor(obj2, (IntPtr)obj6);
				if (task != null)
				{
					Task task2 = task.ContinueWith(action2);
					return;
				}
				ex = new NullReferenceException();
				action = (Action)obj2;
				goto IL_013f;
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			Action action = null;
		}
		ex = new NullReferenceException();
		goto IL_013f;
		IL_013f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public bool IsConnected()
	{
		//IL_001b: Expected I4, but got O
		//IL_0046: Expected O, but got I4
		bool flag = _connection == null;
		bool result = (byte)(int)_connection != 0;
		if (!flag)
		{
			HubConnectionState state = _connection.State;
			object obj = state - 1;
			bool flag2 = obj == null;
			result = flag2;
		}
		return result;
	}

	private void <Connect>b__2_4(Task task)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00bb: Expected O, but got I4
		if (task.IsCompletedSuccessfully)
		{
			HubConnectionState state = _connection.State;
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format = "_InputUv1BufferOffset" + 3712;
			object arg = default(object);
			string text = string.Format((string)format, arg);
			object obj2 = typeof(DataRelation) + 856;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			object message = text;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				message = text;
			}
			Debug.Log(message);
			CoordinatorService.OnSignalRConnected();
		}
	}
}
