using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Unity.Services.Authentication;
using Unity.Services.Core;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;

public class UnityServicesInitializer : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	private struct <Start>d__1 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		private TaskAwaiter <>u__1;

		private unsafe void MoveNext()
		{
			//IL_005b: Expected O, but got I4
			//IL_006a: Expected I4, but got I8
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			//IL_00b7: Expected O, but got I4
			//IL_04f8: Expected I, but got O
			//IL_0032: Expected O, but got I4
			//IL_0041: Expected I4, but got I8
			//IL_0179: Unknown result type (might be due to invalid IL or missing references)
			//IL_017e: Expected O, but got Unknown
			//IL_0186: Expected I, but got O
			//IL_0196: Expected O, but got I
			//IL_03f1: Expected I, but got O
			//IL_0225: Expected O, but got I4
			//IL_0405: Unknown result type (might be due to invalid IL or missing references)
			//IL_040a: Expected O, but got Unknown
			//IL_0434: Expected O, but got I4
			//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bc: Expected O, but got Unknown
			//IL_05d6: Expected O, but got I4
			//IL_01d1: Expected O, but got I
			//IL_064f: Expected O, but got I
			//IL_0248: Expected O, but got Ref
			//IL_0266: Expected O, but got Ref
			//IL_0283: Unknown result type (might be due to invalid IL or missing references)
			//IL_0288: Expected O, but got Unknown
			//IL_0290: Unknown result type (might be due to invalid IL or missing references)
			//IL_0295: Expected O, but got Unknown
			//IL_029e: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a3: Expected O, but got Unknown
			//IL_0476: Expected I4, but got I8
			//IL_0481: Expected O, but got Ref
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e4: Expected O, but got Unknown
			//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f2: Expected O, but got Unknown
			//IL_02d6: Expected I, but got O
			//IL_02e6: Expected O, but got I
			//IL_0618: Expected O, but got I
			//IL_0321: Expected O, but got I
			//IL_0527: Expected I, but got O
			//IL_0382: Unknown result type (might be due to invalid IL or missing references)
			//IL_0387: Expected O, but got Unknown
			//IL_038f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0394: Expected O, but got Unknown
			//IL_039d: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a2: Expected O, but got Unknown
			//IL_032f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0334: Expected O, but got Unknown
			//IL_033d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0342: Expected O, but got Unknown
			//IL_04a6: Expected O, but got Ref
			//IL_04c4: Expected O, but got Ref
			TaskAwaiter awaiter = default(TaskAwaiter);
			NullReferenceException ex;
			if (<>1__state != 0)
			{
				if (<>1__state == 1)
				{
					<>u__1 = (TaskAwaiter)0;
					<>1__state = -1;
					awaiter = <>u__1;
					goto IL_03e3;
				}
				object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3536;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v42+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Task task = UnityServices.InitializeAsync();
				if (task == null)
				{
					ex = new NullReferenceException();
					goto IL_052c;
				}
				TaskAwaiter awaiter2 = task.GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					<>1__state = 0;
					object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 40));
					obj4 = awaiter;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
					((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
			}
			else
			{
				<>u__1 = (TaskAwaiter)0;
				<>1__state = -1;
				awaiter = <>u__1;
			}
			awaiter.GetResult();
			IAuthenticationService instance = AuthenticationService.Instance;
			object obj5;
			object obj10;
			if (instance != null)
			{
				obj5 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1136;
				nint num = (nint)instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v12 (Il2CppClass<Unity.Services.Authentication.IAuthenticationService>)+12E]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v12 (Il2CppClass<Unity.Services.Authentication.IAuthenticationService>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0212;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v12 (Il2CppClass<Unity.Services.Authentication.IAuthenticationService>)+B0]");
				object obj7 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X10_v15-8]");
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
					goto IL_0212;
				}
				object obj8 = obj7 + 18;
				object obj9 = num + obj8;
				obj10 = obj9 + 312;
				goto IL_0594;
			}
			ex = new NullReferenceException();
			nint num2 = unchecked((nint)null);
			goto IL_052c;
			IL_0362:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj12 = default(object);
			object obj11 = obj12;
			goto IL_0608;
			IL_0594:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v13+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v191 @ X8_v13] (should have been resolved before IL gen)");
			object obj14 = default(object);
			object obj13 = obj14 & 1;
			bool flag2 = obj13 == null;
			object obj15 = !flag2;
			if (obj15 != null)
			{
				goto IL_03f6;
			}
			IAuthenticationService instance2 = AuthenticationService.Instance;
			if (instance2 != null)
			{
				nint num3 = (nint)instance2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v14 (Il2CppClass<Unity.Services.Authentication.IAuthenticationService>)+12E]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v14 (Il2CppClass<Unity.Services.Authentication.IAuthenticationService>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0362;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v14 (Il2CppClass<Unity.Services.Authentication.IAuthenticationService>)+B0]");
				object obj17 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X10_v10-8]");
					if (0 == (nint)obj5)
					{
						break;
					}
					obj17 += 16;
					obj16--;
					if ((nint)obj16 != 1)
					{
						continue;
					}
					goto IL_0362;
				}
				object obj18 = obj17 + 30;
				object obj19 = num3 + obj18;
				obj11 = obj19 + 312;
				goto IL_0608;
			}
			ex = new NullReferenceException();
			goto IL_052c;
			IL_03f6:
			object obj20 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3552;
			object obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj22 = !flag3;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj21 = obj20;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v9+B8]");
			object obj23 = 0;
			if (obj23 != null)
			{
				((OneShotEvent)obj23).IsReady = true;
				<>1__state = -2;
				AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
				((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->SetResult();
				return;
			}
			ex = new NullReferenceException();
			goto IL_052c;
			IL_03e3:
			awaiter.GetResult();
			num2 = unchecked((nint)null);
			goto IL_03f6;
			IL_0608:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v15+8]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v145 @ X8_v15] (should have been resolved before IL gen)");
			Task task2 = default(Task);
			if (task2 != null)
			{
				TaskAwaiter awaiter3 = task2.GetAwaiter();
				if (awaiter.IsCompleted)
				{
					goto IL_03e3;
				}
				<>1__state = 1;
				object obj25 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 40));
				obj25 = awaiter;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				AsyncVoidMethodBuilder asyncVoidMethodBuilder3 = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
				((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder3)->AwaitUnsafeOnCompleted(ref awaiter, ref this);
				return;
			}
			ex = new NullReferenceException();
			num2 = unchecked((nint)null);
			goto IL_052c;
			IL_0212:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj24 = 18;
			object obj26 = default(object);
			obj10 = obj26;
			goto IL_0594;
			IL_052c:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
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

	private static readonly OneShotEvent ReadyState;

	private unsafe void Start()
	{
		//IL_001e: Expected O, but got I
		//IL_0036: Expected O, but got I
		AsyncVoidMethodBuilder asyncVoidMethodBuilder = AsyncVoidMethodBuilder.Create();
		<Start>d__1 stateMachine = default(<Start>d__1);
		object obj = (nint)(&stateMachine) | (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)((nint)(&stateMachine) | (nint)8);
		((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->Start(ref stateMachine);
	}

	public static void CallWhenReady(Action callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d7: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_010f: Expected O, but got I
		//IL_0131: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3552;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7383]");
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
		OneShotEvent oneShotEvent = (OneShotEvent)obj7;
		bool flag3 = obj7 == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0099;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v12+B8]");
		object obj9 = 0;
		oneShotEvent = (OneShotEvent)obj9;
		goto IL_0099;
		IL_0099:
		oneShotEvent.CallWhenReady(callback);
	}

	static UnityServicesInitializer()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 3440;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		OneShotEvent oneShotEvent = default(OneShotEvent);
		oneShotEvent..ctor();
		object obj3 = obj2;
		object obj4 = oneShotEvent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
