using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using DataTracking;
using Jackaroo;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public class JackarooCustomRules : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal int <.cctor>b__32_0(JackarooCustomRulesSave save1, JackarooCustomRulesSave save2)
		{
			//IL_0064: Expected I4, but got O
			long num = default(long);
			if (save2 != null && save1 != null)
			{
				return num.CompareTo(save1.<CreationTime>k__BackingField);
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct <LoadItems>d__25 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public Action<List<JackarooCustomRulesSave>> callback;

		private CancellationTokenSource <cts>5__2;

		private TaskAwaiter <>u__1;

		private unsafe void MoveNext()
		{
			//IL_0008: Expected O, but got Ref
			//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_07bd: Expected O, but got Unknown
			//IL_03ac: Expected O, but got Ref
			//IL_07f3: Expected O, but got I
			//IL_0813: Expected O, but got I
			//IL_0820: Expected O, but got I8
			//IL_0830: Expected O, but got I
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			//IL_004d: Expected O, but got I4
			//IL_089d: Expected O, but got I4
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Expected O, but got Unknown
			//IL_09a3: Expected O, but got I
			//IL_09b4: Expected O, but got I
			//IL_09c4: Expected O, but got I
			//IL_09d4: Expected O, but got I
			//IL_00c2: Expected O, but got I
			//IL_0a0c: Expected O, but got Ref
			//IL_0a19: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a1e: Expected O, but got Unknown
			//IL_0a36: Expected O, but got I4
			//IL_0a3f: Expected O, but got I4
			//IL_00e7: Expected O, but got Ref
			//IL_0985: Expected O, but got I4
			//IL_03fa: Expected O, but got I4
			//IL_0437: Expected O, but got I
			//IL_0aa5: Expected O, but got I
			//IL_0ab5: Expected O, but got I
			//IL_0ad8: Expected O, but got I4
			//IL_0150: Expected O, but got I4
			//IL_0845: Expected O, but got I
			//IL_0639: Expected O, but got I
			//IL_0646: Expected O, but got I8
			//IL_064f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0654: Expected O, but got Unknown
			//IL_065d: Expected O, but got I4
			//IL_0676: Unknown result type (might be due to invalid IL or missing references)
			//IL_067b: Expected O, but got Unknown
			//IL_06a5: Expected O, but got I4
			//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c0: Expected O, but got Unknown
			//IL_04d8: Expected O, but got I
			//IL_06d8: Expected O, but got I
			//IL_05c7: Expected O, but got I4
			//IL_0185: Expected O, but got I
			//IL_0196: Expected O, but got I
			//IL_0b11: Expected O, but got I
			//IL_0513: Expected O, but got I
			//IL_01c0: Expected O, but got I
			//IL_01d8: Expected O, but got I
			//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e7: Expected O, but got Unknown
			//IL_01fb: Expected O, but got I
			//IL_05e4: Expected O, but got I4
			//IL_075a: Expected O, but got I4
			//IL_0b68: Expected O, but got Ref
			//IL_0b78: Expected O, but got I
			//IL_0b85: Expected O, but got I8
			//IL_0b8e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b93: Expected O, but got Unknown
			//IL_0b9c: Expected O, but got I4
			//IL_0bb5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bba: Expected O, but got Unknown
			//IL_0be6: Expected O, but got I4
			//IL_057e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0583: Expected O, but got Unknown
			//IL_060e: Expected O, but got I
			//IL_0623: Expected O, but got I
			//IL_0521: Unknown result type (might be due to invalid IL or missing references)
			//IL_0526: Expected O, but got Unknown
			//IL_052f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0534: Expected O, but got Unknown
			//IL_0263: Expected O, but got I4
			//IL_026c: Expected O, but got I4
			//IL_02ad: Expected O, but got I
			//IL_02b6: Expected O, but got I4
			//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c4: Expected O, but got Unknown
			//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ea: Expected O, but got Unknown
			//IL_0314: Expected O, but got I4
			//IL_08b7: Expected O, but got I
			//IL_08d5: Expected O, but got I
			//IL_08f4: Expected O, but got Ref
			//IL_0901: Unknown result type (might be due to invalid IL or missing references)
			//IL_0906: Expected O, but got Unknown
			//IL_091e: Expected O, but got I4
			//IL_0927: Expected O, but got I4
			//IL_0947: Expected O, but got Ref
			//IL_095d: Expected O, but got I4
			//IL_035a: Expected O, but got I4
			//IL_0363: Expected O, but got I4
			//IL_0383: Expected O, but got Ref
			//IL_0399: Expected O, but got I4
			object obj2 = default(object);
			object obj = (object)(&obj2);
			object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 184;
			_ = <>1__state;
			object obj10;
			ref <LoadItems>d__25 reference = default(ref <LoadItems>d__25);
			double num = default(double);
			TaskAwaiter awaiter2 = default(TaskAwaiter);
			object obj31;
			object obj34;
			object obj35;
			object obj36;
			object obj37;
			object obj38;
			object obj39;
			object obj40;
			CancellationTokenSource cancellationTokenSource3;
			object obj41;
			CancellationTokenSource cancellationTokenSource2;
			double num2;
			ref <LoadItems>d__25 reference2;
			OutOfMemoryException ex2;
			object obj24 = default(object);
			object obj22 = default(object);
			object obj20 = default(object);
			object obj18 = default(object);
			object obj17 = default(object);
			if (<>1__state != 0)
			{
				object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v49+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = !flag;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				TimeSpan delay = TimeSpan.FromSeconds(8.000000000465661);
				object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 224;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				CancellationTokenSource cancellationTokenSource = default(CancellationTokenSource);
				cancellationTokenSource..ctor(delay);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
				object obj8 = (nint)0 + (nint)40;
				obj8 = cancellationTokenSource;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj9 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-2C]");
				bool flag2 = (nint)0 == 0;
				obj10 = obj9;
				reference = ref *(<LoadItems>d__25*)null;
				num = 8.000000000465661;
				if (!flag2)
				{
					object obj11 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v59+E4]");
					bool flag3 = (nint)0 == 0;
					object obj12 = !flag3;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj11 = obj3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v46+28]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v59+B8]");
						object obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v46+28]");
						CancellationToken token = ((CancellationTokenSource)0).Token;
						string savingPath = SavingPath;
						object obj15 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v48+B8]");
						object obj16 = 0;
						obj17 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v49+8]");
						obj18 = 0;
						object obj19 = ", stale={0}" + 2488;
						obj20 = obj19;
						object obj21 = (nint)0 + (nint)784;
						obj22 = obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @302115C");
						Task task = default(Task);
						if (task != null)
						{
							TaskAwaiter awaiter = task.GetAwaiter();
							bool isCompleted = awaiter2.IsCompleted;
							bool flag4 = !isCompleted;
							object obj23 = !flag4;
							obj24 = 0;
							obj10 = obj9;
							reference = ref *(<LoadItems>d__25*)savingPath;
							num = 8.000000000465661;
							if (obj23 != null)
							{
								goto IL_086a;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
							object obj25 = 0;
							obj25 = 0;
							object obj26 = obj25 + 48;
							obj26 = awaiter2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj27 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1192;
							object obj28 = obj27;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X0_v73+E4]");
							bool flag5 = (nint)0 == 0;
							object obj29 = !flag5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
							reference2 = ref *(<LoadItems>d__25*)null;
							if (obj29 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
								reference2 = ref *(<LoadItems>d__25*)null;
							}
							object obj30 = (nint)0 + (nint)1144;
							obj31 = obj30;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
							AsyncTaskMethodBuilder asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)((nint)0 + (nint)8);
							((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->AwaitUnsafeOnCompleted(ref awaiter2, ref reference2);
							object obj32 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 44));
							object obj33 = obj32 & 0x80000000L;
							bool flag6 = obj33 == null;
							obj34 = 5;
							obj35 = 0;
							obj36 = obj22;
							obj37 = obj18;
							obj38 = obj17;
							cancellationTokenSource2 = (CancellationTokenSource)(&awaiter2);
							num2 = 8.000000000465661;
							obj39 = 0;
							if (!flag6)
							{
								obj40 = 5;
								obj24 = 0;
								obj20 = obj30;
								obj10 = obj9;
								reference = ref reference2;
								cancellationTokenSource3 = (CancellationTokenSource)(&awaiter2);
								num = 8.000000000465661;
								obj41 = 0;
								goto IL_041f;
							}
							goto IL_096b;
						}
						NullReferenceException ex = new NullReferenceException();
						obj24 = 0;
						reference2 = ref *(<LoadItems>d__25*)savingPath;
						cancellationTokenSource2 = (CancellationTokenSource)token;
						num2 = 8.000000000465661;
						ex2 = (OutOfMemoryException)(object)ex;
					}
					else
					{
						NullReferenceException ex3 = new NullReferenceException();
						reference2 = ref *(<LoadItems>d__25*)null;
						cancellationTokenSource2 = cancellationTokenSource;
						num2 = 8.000000000465661;
						ex2 = (OutOfMemoryException)(object)ex3;
					}
					goto IL_0784;
				}
			}
			else
			{
				object obj42 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
				obj10 = obj42;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
			object obj43 = 0;
			_ = 0;
			_ = 4294967295L;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
			object obj44 = 0;
			obj44 = 4294967295L;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v25+30]");
			awaiter2 = (TaskAwaiter)0;
			goto IL_086a;
			IL_0554:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			reference2 = ref *(<LoadItems>d__25*)null;
			goto IL_0b01;
			IL_086a:
			awaiter2.GetResult();
			object obj45 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v25+E4]");
			bool flag7 = (nint)0 == 0;
			object obj46 = !flag7;
			if (obj46 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj45 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v25+B8]");
			object obj47 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v16+20]");
			InitializeCurrentJackarooCustomRule((IReadOnlyList<JackarooCustomRulesSave>)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
			object obj48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v17+20]");
			obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v17+20]");
			bool flag8 = (nint)0 == 0;
			cancellationTokenSource3 = null;
			if (!flag8)
			{
				object obj49 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v29+E4]");
				bool flag9 = (nint)0 == 0;
				object obj50 = !flag9;
				if (obj50 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj49 = obj3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v29+B8]");
				object obj51 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v22+20]");
				cancellationTokenSource3 = (CancellationTokenSource)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X19_v16+28]");
				reference = ref *(<LoadItems>d__25*)null;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v228 @ X19_v16+18] (should have been resolved before IL gen)");
				obj41 = 0;
			}
			object obj52 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 44));
			object obj53 = obj52 & 0x80000000L;
			bool flag10 = obj53 == null;
			obj40 = 12;
			obj34 = 12;
			obj35 = obj24;
			obj36 = obj22;
			obj31 = obj20;
			obj37 = obj18;
			obj38 = obj17;
			reference2 = ref reference;
			cancellationTokenSource2 = cancellationTokenSource3;
			num2 = num;
			obj39 = obj41;
			if (!flag10)
			{
				goto IL_041f;
			}
			goto IL_096b;
			IL_0b01:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X0_v43+8]");
			cancellationTokenSource2 = (CancellationTokenSource)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v449 @ X0_v43] (should have been resolved before IL gen)");
			obj34 = obj40;
			obj35 = obj24;
			obj36 = obj22;
			obj31 = obj20;
			obj37 = obj18;
			obj38 = obj17;
			num2 = num;
			obj39 = obj41;
			goto IL_096b;
			IL_0784:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_041f:
			object obj54 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v30+28]");
			object obj55 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v30+28]");
			bool flag11 = (nint)0 == 0;
			obj34 = obj40;
			obj35 = obj24;
			obj36 = obj22;
			obj31 = obj20;
			obj37 = obj18;
			obj38 = obj17;
			reference2 = ref reference;
			cancellationTokenSource2 = cancellationTokenSource3;
			num2 = num;
			obj39 = obj41;
			if (flag11)
			{
				goto IL_096b;
			}
			object obj56 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			object obj57 = obj55;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v33+12E]");
			object obj58 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v33+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0554;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v33+B0]");
			object obj59 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X10_v7-8]");
				if (0 == (nint)obj56)
				{
					break;
				}
				obj59 += 16;
				obj58--;
				if ((nint)obj58 != 1)
				{
					continue;
				}
				goto IL_0554;
			}
			object obj60 = obj57 + obj59;
			object obj61 = obj60 + 312;
			reference2 = ref reference;
			goto IL_0b01;
			IL_096b:
			bool flag12 = obj39 == null;
			object obj62 = !flag12;
			if (obj62 == null)
			{
				if ((nint)obj34 != 12)
				{
					bool flag13 = obj34 == null;
					object obj63 = !flag13;
					if (obj63 == null)
					{
						object obj64 = -1;
						object obj66 = default(object);
						object obj65 = (object)(&obj66);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
						object obj67 = 0;
						obj67 = 4294967294L;
						object obj68 = obj67 + 40;
						obj68 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj69 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1192;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X0_v18+E4]");
						bool flag14 = (nint)0 == 0;
						object obj70 = !flag14;
						if (obj70 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
						AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)((nint)0 + (nint)8);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v11+v415 @ X19_v7*8]");
						((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->SetException((Exception)0);
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
					object obj71 = 0;
					obj71 = 4294967294L;
					object obj72 = obj71 + 40;
					obj72 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj73 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1192;
					object obj74 = obj73;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X0_v8+E4]");
					bool flag15 = (nint)0 == 0;
					object obj75 = !flag15;
					if (obj75 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
					AsyncTaskMethodBuilder asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder)((nint)0 + (nint)8);
					((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder3)->SetResult();
				}
				return;
			}
			ex2 = new OutOfMemoryException();
			obj24 = obj35;
			obj22 = obj36;
			obj20 = obj31;
			obj18 = obj37;
			obj17 = obj38;
			goto IL_0784;
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

	private sealed class <LoadItemsWeb>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public Action<List<JackarooCustomRulesSave>> callback;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <LoadItemsWeb>d__26(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00f7: Expected I4, but got I8
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Expected O, but got Unknown
			//IL_0135: Expected O, but got I4
			//IL_0224: Expected O, but got I
			//IL_0245: Expected O, but got I
			//IL_024f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0254: Expected O, but got Unknown
			//IL_0260: Expected O, but got I
			//IL_0270: Unknown result type (might be due to invalid IL or missing references)
			//IL_0275: Expected O, but got Unknown
			//IL_0036: Expected I4, but got I8
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected O, but got Unknown
			//IL_0074: Expected O, but got I4
			//IL_01bb: Expected O, but got I
			//IL_01cc: Expected O, but got I
			//IL_00c3: Expected O, but got I4
			//IL_0205: Expected O, but got I
			if (<>1__state != 0)
			{
				if (<>1__state == 1)
				{
					<>1__state = -1;
					object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 184;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v15+E4]");
					bool flag = (nint)0 == 0;
					object obj3 = !flag;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj2 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v15+B8]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v16+20]");
					InitializeCurrentJackarooCustomRule((IReadOnlyList<JackarooCustomRulesSave>)0);
					Action<List<JackarooCustomRulesSave>> action = callback;
					if (callback != null)
					{
						object obj5 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v18+E4]");
						bool flag2 = (nint)0 == 0;
						object obj6 = !flag2;
						if (obj6 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj5 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v18+B8]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v89 @ X19_v6 (System.Action`1<System.Collections.Generic.List`1<JackarooCustomRulesSave>>)+18] (should have been resolved before IL gen)");
					}
				}
				return <>1__state == 0;
			}
			<>1__state = -1;
			object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 184;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = obj8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v3+B8]");
			object obj11 = 0;
			string savingPath = SavingPath;
			object obj12 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v6+B8]");
			object obj13 = 0;
			object obj14 = ", stale={0}" + 2488;
			object obj15 = (nint)0 + (nint)792;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3021410");
			object obj16 = this + 24;
			object obj17 = default(object);
			obj16 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 1;
			return <>1__state == 0;
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
			object obj2 = (nint)0 + (nint)1832;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private const string JsonEx = ".json";

	private const string SavedGamesString = "savedCustomRules";

	private static readonly JsonSerializerSettings SerializerSettings;

	private static Comparison<JackarooCustomRulesSave> Comparison;

	private static JackarooCustomRulesSave <CurrentJackarooCustomRuleSave>k__BackingField;

	private static readonly List<JackarooCustomRulesSave> _jackarooCustomRulesSaves;

	private unsafe static string SavingPath
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Expected O, but got Unknown
			//IL_0157: Expected O, but got I4
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected O, but got Unknown
			//IL_0070: Expected O, but got I4
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected O, but got Unknown
			//IL_00af: Expected O, but got Ref
			//IL_00e2: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 72;
			string cachePath = Config.CachePath;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object path = "rightCtrl" + 1016;
			Games currentGame = Preferences.CurrentGame;
			object obj8 = default(object);
			string path2 = ((Enum)(&obj8)).ToString();
			object obj9 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v12+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return Path.Combine(cachePath, (string)path, path2);
		}
	}

	public static JackarooCustomRulesSave CurrentJackarooCustomRuleSave
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a2: Expected O, but got I
			//IL_010a: Expected O, but got I
			//IL_0117: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 184;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7729]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+10]");
			return (JackarooCustomRulesSave)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+10]");
			return (JackarooCustomRulesSave)0;
		}
		private set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_005a: Expected O, but got I4
			//IL_007e: Expected O, but got I
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 184;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+B8]");
			object obj4 = (nint)0 + (nint)16;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public static string CurrentJackarooCustomRuleName
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_01b5: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_023b: Expected O, but got I4
			//IL_01e3: Expected O, but got I
			//IL_01fd: Expected O, but got I4
			//IL_00f1: Expected O, but got I
			//IL_0101: Expected O, but got I
			//IL_0111: Expected O, but got I
			//IL_0138: Expected O, but got I
			//IL_026f: Expected O, but got I
			//IL_027f: Expected O, but got I
			//IL_028f: Expected O, but got I
			//IL_02b1: Expected O, but got I4
			//IL_015e: Expected O, but got I
			//IL_02cf: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 184;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E772B]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v13+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v13+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45DA]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00b0;
			}
			goto IL_020b;
			IL_014e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X9_v4 (System.String)+18]");
			string text = (string)0;
			object obj8;
			object result = obj8;
			goto IL_02dc;
			IL_00e5:
			obj8 = (nint)0 + (nint)2000;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v23+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X9_v6+10]");
			string text2 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X9_v6+10]");
			bool flag3 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X9_v6+10]");
			text = (string)0;
			result = obj8;
			if (!flag3)
			{
				goto IL_014e;
			}
			goto IL_02dc;
			IL_02dc:
			if (text == null)
			{
				return (string)result;
			}
			return text;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45DA]");
			object obj10 = (nint)0 & (nint)1;
			if (obj10 != null)
			{
				goto IL_00b0;
			}
			goto IL_020b;
			IL_020b:
			_ = 1;
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v23+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			object obj13 = obj11;
			if (obj12 != null)
			{
				goto IL_00e5;
			}
			goto IL_0251;
			IL_00b0:
			obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v23+E4]");
			bool flag5 = (nint)0 == 0;
			obj13 = obj11;
			if (!flag5)
			{
				goto IL_00e5;
			}
			goto IL_0251;
			IL_0251:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj14 = obj2;
			obj8 = (nint)0 + (nint)2000;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v7+B8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X9_v2+10]");
			text2 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X9_v2+10]");
			bool flag6 = (nint)0 == 0;
			object obj16 = !flag6;
			if (obj16 != null)
			{
				goto IL_014e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X9_v2+10]");
			text = (string)0;
			result = obj8;
			goto IL_02dc;
		}
	}

	public static int CurrentJackarooCustomRule
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00da: Expected O, but got I4
			//IL_0097: Expected O, but got I4
			//IL_0505: Expected I4, but got O
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			//IL_0185: Expected O, but got Unknown
			//IL_0340: Expected O, but got I
			//IL_035a: Expected O, but got I4
			//IL_0363: Expected O, but got I4
			//IL_036c: Expected O, but got I4
			//IL_01c8: Expected O, but got I
			//IL_01e0: Expected O, but got I4
			//IL_01e9: Expected O, but got I4
			//IL_03ea: Expected O, but got I
			//IL_040c: Expected O, but got I4
			//IL_03aa: Expected O, but got I4
			//IL_0244: Expected O, but got I
			//IL_0448: Expected O, but got I
			//IL_0462: Expected O, but got I4
			//IL_02a4: Expected O, but got I
			//IL_04d8: Expected O, but got I
			//IL_04e9: Expected O, but got I
			//IL_04a0: Expected O, but got I4
			//IL_0306: Expected O, but got I
			//IL_0317: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E772C]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v36+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v36+E4]");
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
			goto IL_04f7;
			IL_0422:
			return 0;
			IL_0234:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v16+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v29+10]");
			if ((nint)0 != 0)
			{
				goto IL_0269;
			}
			goto IL_0422;
			IL_03c8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7;
			object obj6 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v16+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v9+10]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			object obj11;
			object obj10 = obj11;
			if (obj9 != null)
			{
				goto IL_0269;
			}
			goto IL_0422;
			IL_0074:
			current = RemoteConfig.Current;
			bool flag3 = current == null;
			object obj12 = !flag3;
			if (obj12 != null)
			{
				goto IL_011d;
			}
			goto IL_04f7;
			IL_011d:
			JackarooConfig <Jackaroo>k__BackingField = current.<Jackaroo>k__BackingField;
			object obj18;
			if (current.<Jackaroo>k__BackingField != null)
			{
				if (<Jackaroo>k__BackingField.<CustomRulesEnabled>k__BackingField)
				{
					obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 184;
					object obj13 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v6+E4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45DA]");
						object obj14 = (nint)0 & (nint)1;
						bool flag4 = obj14 == null;
						obj10 = 146685952;
						obj11 = 146685952;
						if (!flag4)
						{
							goto IL_01f7;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45DA]");
						object obj15 = (nint)0 & (nint)1;
						bool flag5 = obj15 == null;
						object obj16 = !flag5;
						obj10 = 146685952;
						obj11 = 146685952;
						if (obj16 != null)
						{
							goto IL_01f7;
						}
					}
					_ = 1;
					obj6 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v16+E4]");
					bool flag6 = (nint)0 == 0;
					object obj17 = !flag6;
					obj10 = obj11;
					obj18 = obj6;
					if (obj17 != null)
					{
						goto IL_0234;
					}
					goto IL_03c8;
				}
				goto IL_0422;
			}
			goto IL_04f7;
			IL_0269:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v16+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45DA]");
				object obj19 = (nint)0 & (nint)1;
				if (obj19 != null)
				{
					goto IL_02c1;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X20_v8+5DA]");
				object obj20 = (nint)0 & (nint)1;
				bool flag7 = obj20 == null;
				object obj21 = !flag7;
				if (obj21 != null)
				{
					goto IL_02c1;
				}
			}
			_ = 1;
			object obj22 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v28+E4]");
			bool flag8 = (nint)0 == 0;
			object obj23 = !flag8;
			object obj24 = obj22;
			if (obj23 != null)
			{
				goto IL_02f6;
			}
			goto IL_04b6;
			IL_04f7:
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
			IL_02c1:
			obj22 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v28+E4]");
			bool flag9 = (nint)0 == 0;
			obj24 = obj22;
			if (!flag9)
			{
				goto IL_02f6;
			}
			goto IL_04b6;
			IL_04b6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj25 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v19+B8]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v18+10]");
			return JackarooCustomRulesExtensions.ToInt((JackarooCustomRulesSave)0);
			IL_02f6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v28+B8]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v24+10]");
			return JackarooCustomRulesExtensions.ToInt((JackarooCustomRulesSave)0);
			IL_01f7:
			obj6 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v16+E4]");
			bool flag10 = (nint)0 == 0;
			obj18 = obj6;
			obj11 = obj10;
			if (!flag10)
			{
				goto IL_0234;
			}
			goto IL_03c8;
		}
	}

	public static int CurrentJackarooCustomRuleIndex
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00b2: Expected O, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7776]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return Preferences.JackarooPreferredCustomRulesIndex;
			IL_0074:
			return Preferences.JackarooPreferredCustomRulesIndex;
		}
	}

	public static IReadOnlyList<JackarooCustomRulesSave> JackarooCustomRulesSaves
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a2: Expected O, but got I
			//IL_010a: Expected O, but got I
			//IL_0117: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 184;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E772F]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+20]");
			return (IReadOnlyList<JackarooCustomRulesSave>)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+20]");
			return (IReadOnlyList<JackarooCustomRulesSave>)0;
		}
	}

	public static event Action<int, string> OnJackarooCustomRuleChanged
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
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 184;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 520;
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
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 184;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 520;
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
		Init();
	}

	private void Init()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0337: Expected O, but got I4
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00e4: Expected O, but got I4
		//IL_04d8: Expected O, but got I
		//IL_04e8: Expected O, but got I
		//IL_011f: Expected O, but got I
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_0179: Expected O, but got I
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_042a: Expected O, but got I4
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected O, but got Unknown
		//IL_02a2: Expected O, but got I
		//IL_02bc: Expected O, but got I4
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected O, but got Unknown
		//IL_047c: Expected O, but got I
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected O, but got Unknown
		//IL_051d: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7777]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Games currentGame = Preferences.CurrentGame;
		if (currentGame != Games.Jackaroo)
		{
			return;
		}
		goto IL_00a6;
		IL_0278:
		object obj6 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7779]");
		object obj7 = (nint)0 & (nint)1;
		bool flag2 = obj7 == null;
		object obj8 = !flag2;
		object obj9 = obj6;
		CoroutineDummy coroutineDummy2;
		CoroutineDummy coroutineDummy = coroutineDummy2;
		if (obj8 == null)
		{
			goto IL_02da;
		}
		goto IL_04ed;
		IL_04ed:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = default(object);
		obj10..ctor();
		_ = 0;
		object obj11 = obj10 + 32;
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = coroutineDummy.StartCoroutine((IEnumerator)obj10);
		return;
		IL_02da:
		_ = 1;
		obj9 = obj6;
		coroutineDummy = coroutineDummy2;
		goto IL_04ed;
		IL_007d:
		Games currentGame2 = Preferences.CurrentGame;
		if (currentGame2 == Games.Jackaroo)
		{
			goto IL_00a6;
		}
		return;
		IL_00a6:
		object obj12 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 184;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v24+E4]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj12;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v24+B8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v8+20]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v9+1C]");
		object obj17 = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v9+18]");
		bool flag4 = (nint)0 < (nint)1;
		IntPtr intPtr = default(IntPtr);
		int num = (int)(nint)intPtr;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v9+10]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v9+18]");
			Array.Clear((Array)num2, 0, 0);
			num = 0;
		}
		object obj18 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v28+E4]");
		if ((nint)0 != 0)
		{
			Platform platform = KUtil.GetPlatform();
			if (platform == Platform.Web)
			{
				goto IL_01f1;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Platform platform2 = KUtil.GetPlatform();
			if (platform2 == Platform.Web)
			{
				goto IL_01f1;
			}
		}
		object obj20 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v30+E4]");
		if ((nint)0 != 0)
		{
			Task task = LoadItems(null);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Task task2 = LoadItems(null);
		return;
		IL_01f1:
		object obj21 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v40+E4]");
		if ((nint)0 != 0)
		{
			CoroutineDummy instance = CoroutineDummy.Instance;
			object obj23 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X0_v49+E4]");
			bool flag5 = (nint)0 == 0;
			coroutineDummy2 = instance;
			coroutineDummy = instance;
			if (!flag5)
			{
				goto IL_0278;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			CoroutineDummy instance2 = CoroutineDummy.Instance;
			object obj23 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X0_v49+E4]");
			bool flag6 = (nint)0 == 0;
			object obj24 = !flag6;
			coroutineDummy2 = instance2;
			coroutineDummy = instance2;
			if (obj24 != null)
			{
				goto IL_0278;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj6 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7779]");
		object obj25 = (nint)0 & (nint)1;
		bool flag7 = obj25 == null;
		coroutineDummy2 = coroutineDummy;
		if (flag7)
		{
			goto IL_02da;
		}
		obj9 = obj6;
		goto IL_04ed;
	}

	public static void SetCurrentJackarooCustomRuleSave(JackarooCustomRulesSave rulesSave, int saveIndex)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_021c: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_02a2: Expected O, but got I4
		//IL_024a: Expected O, but got I
		//IL_0264: Expected O, but got I4
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0109: Expected O, but got I
		//IL_03af: Expected O, but got I
		//IL_0553: Expected O, but got I4
		//IL_055c: Expected O, but got I4
		//IL_0565: Expected O, but got I4
		//IL_0405: Expected O, but got I4
		//IL_040e: Expected O, but got I4
		//IL_02ef: Expected O, but got I
		//IL_0309: Expected O, but got I4
		//IL_0432: Expected O, but got I
		//IL_0593: Expected O, but got I
		//IL_05ad: Expected O, but got I4
		//IL_016b: Expected O, but got I
		//IL_05f3: Expected O, but got I4
		//IL_032d: Expected O, but got I
		//IL_034f: Expected O, but got I4
		//IL_04a2: Expected O, but got I
		//IL_04cc: Expected O, but got I
		//IL_0383: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_0639: Expected O, but got I
		//IL_065b: Expected O, but got I4
		//IL_0510: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 184;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7778]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v9+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45DA]");
		object obj6 = (nint)0 & (nint)1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			goto IL_00b0;
		}
		goto IL_0272;
		IL_048c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X0_v37+B8]");
		object obj8 = (nint)0 + (nint)16;
		obj8 = rulesSave;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v23+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4000]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v42+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int jackarooPreferredCustomRulesIndex = Preferences.JackarooPreferredCustomRulesIndex;
		string currentJackarooCustomRuleName = CurrentJackarooCustomRuleName;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v24+18]");
		Actions.SafeInvoke((Action<int, object>)0, jackarooPreferredCustomRulesIndex, currentJackarooCustomRuleName);
		return;
		IL_039f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4000]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v23+E4]");
		object obj16;
		object obj15;
		if ((nint)0 != 0)
		{
			Preferences.JackarooPreferredCustomRulesIndex = saveIndex;
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v32+E4]");
			bool flag4 = (nint)0 == 0;
			obj15 = 0;
			obj16 = 0;
			if (!flag4)
			{
				goto IL_041c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Preferences.JackarooPreferredCustomRulesIndex = saveIndex;
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v32+E4]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			obj15 = 0;
			obj16 = 0;
			if (obj17 != null)
			{
				goto IL_041c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45DB]");
		object obj18 = (nint)0 & (nint)1;
		bool flag6 = obj18 == null;
		object obj19 = !flag6;
		obj15 = obj16;
		if (obj19 != null)
		{
			goto IL_0457;
		}
		goto IL_05c3;
		IL_01b5:
		int jackarooPreferredCustomRulesIndex2 = Preferences.JackarooPreferredCustomRulesIndex;
		object obj20 = saveIndex + 1;
		if ((nint)obj20 == jackarooPreferredCustomRulesIndex2)
		{
			return;
		}
		goto IL_039f;
		IL_007d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45DA]");
		object obj21 = (nint)0 & (nint)1;
		if (obj21 != null)
		{
			goto IL_00b0;
		}
		goto IL_0272;
		IL_0272:
		_ = 1;
		object obj22 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v21+E4]");
		bool flag7 = (nint)0 == 0;
		object obj23 = !flag7;
		object obj24 = obj22;
		if (obj23 != null)
		{
			goto IL_00e5;
		}
		goto IL_02b8;
		IL_00b0:
		obj22 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v21+E4]");
		bool flag8 = (nint)0 == 0;
		obj24 = obj22;
		if (!flag8)
		{
			goto IL_00e5;
		}
		goto IL_02b8;
		IL_02b8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj22 = obj2;
		goto IL_00e5;
		IL_00e5:
		object obj25 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v21+B8]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v11+10]");
		object obj30;
		if (rulesSave == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v21+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7776]");
				object obj27 = (nint)0 & (nint)1;
				if (obj27 != null)
				{
					goto IL_0188;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7776]");
				object obj28 = (nint)0 & (nint)1;
				bool flag9 = obj28 == null;
				object obj29 = !flag9;
				if (obj29 != null)
				{
					goto IL_0188;
				}
			}
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4000]");
			obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v57+E4]");
			bool flag10 = (nint)0 == 0;
			object obj31 = !flag10;
			if (obj31 != null)
			{
				goto IL_01b5;
			}
			goto IL_035d;
		}
		goto IL_039f;
		IL_0611:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj32 = obj2;
		goto IL_048c;
		IL_05c3:
		_ = 1;
		obj32 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X0_v37+E4]");
		bool flag11 = (nint)0 == 0;
		object obj33 = !flag11;
		obj15 = obj16;
		object obj34 = obj32;
		if (obj33 != null)
		{
			goto IL_048c;
		}
		goto IL_0611;
		IL_041c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45DB]");
		object obj35 = (nint)0 & (nint)1;
		bool flag12 = obj35 == null;
		obj16 = obj15;
		if (!flag12)
		{
			goto IL_0457;
		}
		goto IL_05c3;
		IL_0457:
		obj32 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X0_v37+E4]");
		bool flag13 = (nint)0 == 0;
		obj34 = obj32;
		if (!flag13)
		{
			goto IL_048c;
		}
		goto IL_0611;
		IL_0188:
		obj30 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v57+E4]");
		if ((nint)0 != 0)
		{
			goto IL_01b5;
		}
		goto IL_035d;
		IL_035d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		int jackarooPreferredCustomRulesIndex3 = Preferences.JackarooPreferredCustomRulesIndex;
		object obj36 = saveIndex + 1;
		if ((nint)obj36 == jackarooPreferredCustomRulesIndex3)
		{
			return;
		}
		goto IL_039f;
	}

	public unsafe static Task LoadItems(Action<List<JackarooCustomRulesSave>> callback)
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
		<LoadItems>d__25 stateMachine = default(<LoadItems>d__25);
		object obj4 = (nint)(&stateMachine) | (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 32));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)((nint)(&stateMachine) | (nint)8);
		((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->Start(ref stateMachine);
		AsyncTaskMethodBuilder asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder)((nint)(&stateMachine) | (nint)8);
		return ((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder3)->Task;
	}

	public static IEnumerator LoadItemsWeb(Action<List<JackarooCustomRulesSave>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private unsafe static void InitializeCurrentJackarooCustomRule(IReadOnlyList<JackarooCustomRulesSave> jackarooCustomRulesSaves)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected I4, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ff: Expected O, but got I
		//IL_013e: Expected O, but got I4
		//IL_00da: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_031e: Expected O, but got I4
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		//IL_037b: Expected O, but got I
		//IL_0395: Expected O, but got I4
		//IL_039e: Expected O, but got I4
		//IL_03a7: Expected O, but got I4
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_0252: Expected O, but got I
		//IL_026a: Expected O, but got I4
		//IL_0273: Expected O, but got I4
		//IL_03ed: Expected O, but got I4
		//IL_02e9: Expected O, but got I4
		//IL_0641: Expected O, but got I
		//IL_065b: Expected O, but got I4
		//IL_0493: Expected O, but got I
		//IL_06a9: Expected O, but got I4
		//IL_06f9: Expected O, but got I4
		//IL_0702: Expected O, but got I4
		//IL_051e: Expected O, but got I4
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Expected O, but got Unknown
		//IL_0548: Expected I, but got O
		//IL_0558: Expected O, but got I
		//IL_05ee: Expected O, but got I
		//IL_0612: Expected O, but got I4
		//IL_0593: Expected O, but got I
		//IL_08d6: Expected O, but got I
		//IL_08f0: Expected O, but got I4
		//IL_0a46: Expected O, but got I4
		//IL_07b7: Expected O, but got I
		//IL_072b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0730: Expected O, but got Unknown
		//IL_0739: Unknown result type (might be due to invalid IL or missing references)
		//IL_073e: Expected O, but got Unknown
		//IL_074e: Expected O, but got I
		//IL_092e: Expected O, but got I4
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a6: Expected O, but got Unknown
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected O, but got Unknown
		//IL_0812: Expected I, but got O
		//IL_0822: Expected O, but got I
		//IL_08b1: Expected O, but got I4
		//IL_0a99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9e: Expected O, but got Unknown
		//IL_0aa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aab: Expected O, but got Unknown
		//IL_0ab3: Expected I, but got O
		//IL_0ac3: Expected O, but got I
		//IL_085d: Expected O, but got I
		//IL_0b2c: Expected O, but got I
		//IL_0b46: Expected O, but got I4
		//IL_0981: Expected O, but got I
		//IL_0953: Unknown result type (might be due to invalid IL or missing references)
		//IL_0958: Expected O, but got Unknown
		//IL_0961: Unknown result type (might be due to invalid IL or missing references)
		//IL_0966: Expected O, but got Unknown
		//IL_0b7e: Expected O, but got I4
		//IL_086b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Expected O, but got Unknown
		//IL_0879: Unknown result type (might be due to invalid IL or missing references)
		//IL_087e: Expected O, but got Unknown
		//IL_09d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09de: Expected O, but got Unknown
		//IL_09e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ec: Expected O, but got Unknown
		//IL_098f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0994: Expected O, but got Unknown
		//IL_099d: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a2: Expected O, but got Unknown
		object obj = 152989696;
		int num = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E777A]");
		object obj2 = (nint)0 & (nint)1;
		nint num3;
		object obj4;
		object obj3;
		nint num2;
		if (obj2 != null)
		{
			obj3 = (nint)0 + (nint)2200;
			int value = ((int*)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v89 (System.Int32)+E4]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v89 (System.Int32)+E4]");
			bool flag = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v89 (System.Int32)+E4]");
			num3 = 0;
			obj4 = obj3;
			if (!flag)
			{
				goto IL_00b6;
			}
		}
		else
		{
			_ = 1;
			obj3 = (nint)0 + (nint)2200;
			int value = ((int*)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v89 (System.Int32)+E4]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v89 (System.Int32)+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v89 (System.Int32)+E4]");
			num3 = 0;
			obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_00b6;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		num2 = num3;
		obj3 = obj4;
		if (!flag3)
		{
			goto IL_01aa;
		}
		goto IL_0718;
		IL_052c:
		object obj6 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2240;
		num2 = (nint)jackarooCustomRulesSaves;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v27 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<JackarooCustomRulesSave>>)+12E]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v27 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<JackarooCustomRulesSave>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_05d4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v27 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<JackarooCustomRulesSave>>)+B0]");
		object obj8 = (nint)0 + (nint)8;
		int jackarooPreferredCustomRulesIndex;
		object obj9;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X10_v14-8]");
			bool flag4 = 0 == (nint)obj6;
			obj9 = 0;
			num = jackarooPreferredCustomRulesIndex;
			if (flag4)
			{
				break;
			}
			obj8 += 16;
			obj7--;
			if ((nint)obj7 != 1)
			{
				continue;
			}
			goto IL_05d4;
		}
		object obj10 = num2 + obj8;
		object obj11 = obj10 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v39+8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v165 @ X0_v39] (should have been resolved before IL gen)");
		object obj13 = default(object);
		if (num > (nint)obj13)
		{
			return;
		}
		goto IL_0774;
		IL_04fd:
		jackarooPreferredCustomRulesIndex = Preferences.JackarooPreferredCustomRulesIndex;
		bool flag5 = jackarooCustomRulesSaves == null;
		obj9 = 0;
		if (!flag5)
		{
			goto IL_052c;
		}
		goto IL_0718;
		IL_06c7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		jackarooPreferredCustomRulesIndex = Preferences.JackarooPreferredCustomRulesIndex;
		bool flag6 = jackarooCustomRulesSaves == null;
		object obj14 = !flag6;
		obj9 = 0;
		nint num4;
		num2 = num4;
		if (obj14 != null)
		{
			goto IL_052c;
		}
		goto IL_0718;
		IL_00b6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag7 = (object)sessionModel == null;
		object obj15 = !flag7;
		if (obj15 != null)
		{
			goto IL_01aa;
		}
		goto IL_0718;
		IL_01aa:
		object obj16 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 184;
		User localUser = sessionModel.LocalUser;
		bool flag8 = SFSKammelnaUserExtensions.IsSubscribed(localUser);
		object obj17 = obj16;
		object obj20;
		object obj21;
		object obj24;
		object obj19;
		if (flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v48+E4]");
			if ((nint)0 != 0)
			{
				obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7776]");
				object obj18 = (nint)0 & (nint)1;
				bool flag9 = obj18 == null;
				obj19 = 152989696;
				obj20 = 152989696;
				obj21 = obj3;
				if (!flag9)
				{
					goto IL_0289;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7776]");
				object obj22 = (nint)0 & (nint)1;
				bool flag10 = obj22 == null;
				object obj23 = !flag10;
				obj19 = 152989696;
				obj20 = 152989696;
				obj21 = obj3;
				if (obj23 != null)
				{
					goto IL_0289;
				}
			}
			_ = 1;
			obj24 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v74+E4]");
			bool flag11 = (nint)0 == 0;
			object obj25 = !flag11;
			obj19 = obj20;
			obj3 = obj21;
			if (obj25 != null)
			{
				goto IL_02c6;
			}
			goto IL_040b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v48+E4]");
		bool flag12 = (nint)0 == 0;
		object obj26 = !flag12;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SetCurrentJackarooCustomRuleSave(null, 0);
		return;
		IL_07d4:
		object obj27 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0801;
		}
		goto IL_093c;
		IL_0a80:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v497 @ X0_v14] (should have been resolved before IL gen)");
		object obj28 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2464;
		object obj30 = default(object);
		int jackarooPreferredCustomRulesIndex2;
		object obj29 = obj30 - jackarooPreferredCustomRulesIndex2;
		nint num5 = (nint)jackarooCustomRulesSaves;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v15 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<JackarooCustomRulesSave>>)+12E]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v15 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<JackarooCustomRulesSave>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_09c2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v15 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<JackarooCustomRulesSave>>)+B0]");
		object obj32 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X10_v7-8]");
			if (0 == (nint)obj28)
			{
				break;
			}
			obj32 += 16;
			obj31--;
			if ((nint)obj31 != 1)
			{
				continue;
			}
			goto IL_09c2;
		}
		object obj33 = num5 + obj32;
		object obj34 = obj33 + 312;
		goto IL_0b0c;
		IL_0718:
		throw new NullReferenceException();
		IL_0801:
		jackarooPreferredCustomRulesIndex2 = Preferences.JackarooPreferredCustomRulesIndex;
		nint num6 = (nint)jackarooCustomRulesSaves;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v10 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<JackarooCustomRulesSave>>)+12E]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v10 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<JackarooCustomRulesSave>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_089e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v10 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<JackarooCustomRulesSave>>)+B0]");
		object obj36 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X10_v12-8]");
			if (0 == (nint)obj6)
			{
				break;
			}
			obj36 += 16;
			obj35--;
			if ((nint)obj35 != 1)
			{
				continue;
			}
			goto IL_089e;
		}
		object obj37 = num6 + obj36;
		object obj38 = obj37 + 312;
		goto IL_0a80;
		IL_05d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X0_v66+8]");
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v640 @ X0_v66] (should have been resolved before IL gen)");
		object obj39 = default(object);
		bool flag13 = jackarooPreferredCustomRulesIndex <= (nint)obj39;
		obj9 = 0;
		if (!flag13)
		{
			return;
		}
		goto IL_0774;
		IL_0b0c:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v593 @ X0_v17] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X22_v1+776]");
		object obj40 = (nint)0 & (nint)1;
		bool flag14 = obj40 == null;
		object obj41 = !flag14;
		if (obj41 == null)
		{
			_ = 1;
		}
		object obj42 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X0_v21+E4]");
		bool flag15 = (nint)0 == 0;
		object obj43 = !flag15;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int jackarooPreferredCustomRulesIndex3 = Preferences.JackarooPreferredCustomRulesIndex;
		JackarooCustomRulesSave rulesSave = default(JackarooCustomRulesSave);
		SetCurrentJackarooCustomRuleSave(rulesSave, jackarooPreferredCustomRulesIndex3);
		return;
		IL_093c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_0801;
		IL_0289:
		obj24 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v74+E4]");
		bool flag16 = (nint)0 == 0;
		obj20 = obj19;
		obj21 = obj3;
		if (!flag16)
		{
			goto IL_02c6;
		}
		goto IL_040b;
		IL_040b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		int jackarooPreferredCustomRulesIndex4 = Preferences.JackarooPreferredCustomRulesIndex;
		bool flag17 = jackarooPreferredCustomRulesIndex4 == 0;
		obj19 = obj20;
		obj3 = obj21;
		if (!flag17)
		{
			goto IL_0450;
		}
		return;
		IL_02c6:
		int jackarooPreferredCustomRulesIndex5 = Preferences.JackarooPreferredCustomRulesIndex;
		bool flag18 = jackarooPreferredCustomRulesIndex5 == 0;
		object obj44 = !flag18;
		if (obj44 == null)
		{
			return;
		}
		goto IL_0450;
		IL_0450:
		object obj45 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X0_v53+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7776]");
			object obj46 = (nint)0 & (nint)1;
			if (obj46 != null)
			{
				goto IL_04b0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X22_v1+776]");
			object obj47 = (nint)0 & (nint)1;
			bool flag19 = obj47 == null;
			object obj48 = !flag19;
			if (obj48 != null)
			{
				goto IL_04b0;
			}
		}
		_ = 1;
		object obj49 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X0_v54+E4]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X0_v54+E4]");
		bool flag20 = (nint)0 == 0;
		object obj50 = !flag20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X0_v54+E4]");
		num4 = 0;
		if (obj50 != null)
		{
			goto IL_04fd;
		}
		goto IL_06c7;
		IL_089e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj9 = 0;
		goto IL_0a80;
		IL_09c2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0b0c;
		IL_0774:
		object obj51 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X22_v1+776]");
			object obj52 = (nint)0 & (nint)1;
			if (obj52 != null)
			{
				goto IL_07d4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X22_v1+776]");
			object obj53 = (nint)0 & (nint)1;
			bool flag21 = obj53 == null;
			object obj54 = !flag21;
			if (obj54 != null)
			{
				goto IL_07d4;
			}
		}
		_ = 1;
		obj27 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X0_v3+E4]");
		bool flag22 = (nint)0 == 0;
		object obj55 = !flag22;
		if (obj55 != null)
		{
			goto IL_0801;
		}
		goto IL_093c;
		IL_04b0:
		obj49 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X0_v54+E4]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X0_v54+E4]");
		bool flag23 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X0_v54+E4]");
		num4 = 0;
		if (!flag23)
		{
			goto IL_04fd;
		}
		goto IL_06c7;
	}

	public static void Save(JackarooCustomRulesSave jackarooCustomRuleSave, long? creationTimeOverride = null)
	{
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0073: Expected O, but got I
		//IL_009d: Expected O, but got I4
		//IL_00db: Expected O, but got I
		//IL_0011: Expected O, but got I
		long? num = default(long?);
		object obj = (??)num & 1;
		if (obj != null)
		{
			object obj2 = (nint)0 + (nint)3232;
			long? num2 = default(long?);
			long value = num2.Value;
			jackarooCustomRuleSave.<CreationTime>k__BackingField = value;
		}
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 184;
		object obj4 = ", stale={0}" + 2488;
		object obj5 = "[{0}]:{1}" + 912;
		object obj6 = (nint)0 + (nint)800;
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string savingPath = SavingPath;
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v6+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3021614");
	}

	public static void Delete(JackarooCustomRulesSave jackarooCustomRuleSave)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0061: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 184;
		object extension = ", stale={0}" + 2488;
		object separator = "[{0}]:{1}" + 912;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string savingPath = SavingPath;
		SaveLoadUtils.Delete(jackarooCustomRuleSave.<Name>k__BackingField, (string)extension, savingPath, (string)separator);
	}

	public static void TrackCreateGameCustomRules()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02df: Expected O, but got I4
		//IL_006d: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 184;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int currentJackarooCustomRule = CurrentJackarooCustomRule;
		ITrackEvent trackEvent = TrackerLibrary.JackarooCreateRoomClicked_AllRules((JackarooAllowedRules)currentJackarooCustomRule);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		string activeRuleString = JackarooAllowedRulesExtensions.GetActiveRuleString((JackarooAllowedRules)currentJackarooCustomRule, JackarooAllowedRulesCategory.Ace);
		ITrackEvent trackEvent2 = TrackerLibrary.JackarooCreateRoomClicked_Ace(activeRuleString);
		Tracker.DesignEvent(trackEvent2);
		string activeRuleString2 = JackarooAllowedRulesExtensions.GetActiveRuleString((JackarooAllowedRules)currentJackarooCustomRule, JackarooAllowedRulesCategory.KingBlack);
		ITrackEvent trackEvent3 = TrackerLibrary.JackarooCreateRoomClicked_KingBlack(activeRuleString2);
		Tracker.DesignEvent(trackEvent3);
		string activeRuleString3 = JackarooAllowedRulesExtensions.GetActiveRuleString((JackarooAllowedRules)currentJackarooCustomRule, JackarooAllowedRulesCategory.KingRed);
		ITrackEvent trackEvent4 = TrackerLibrary.JackarooCreateRoomClicked_KingRed(activeRuleString3);
		Tracker.DesignEvent(trackEvent4);
		string activeRuleString4 = JackarooAllowedRulesExtensions.GetActiveRuleString((JackarooAllowedRules)currentJackarooCustomRule, JackarooAllowedRulesCategory.QueenBlack);
		ITrackEvent trackEvent5 = TrackerLibrary.JackarooCreateRoomClicked_QueenBlack(activeRuleString4);
		Tracker.DesignEvent(trackEvent5);
		string activeRuleString5 = JackarooAllowedRulesExtensions.GetActiveRuleString((JackarooAllowedRules)currentJackarooCustomRule, JackarooAllowedRulesCategory.QueenRed);
		ITrackEvent trackEvent6 = TrackerLibrary.JackarooCreateRoomClicked_QueenRed(activeRuleString5);
		Tracker.DesignEvent(trackEvent6);
		string activeRuleString6 = JackarooAllowedRulesExtensions.GetActiveRuleString((JackarooAllowedRules)currentJackarooCustomRule, JackarooAllowedRulesCategory.JackBlack);
		ITrackEvent trackEvent7 = TrackerLibrary.JackarooCreateRoomClicked_JackBlack(activeRuleString6);
		Tracker.DesignEvent(trackEvent7);
		string activeRuleString7 = JackarooAllowedRulesExtensions.GetActiveRuleString((JackarooAllowedRules)currentJackarooCustomRule, JackarooAllowedRulesCategory.JackRed);
		ITrackEvent trackEvent8 = TrackerLibrary.JackarooCreateRoomClicked_JackRed(activeRuleString7);
		Tracker.DesignEvent(trackEvent8);
		string activeRuleString8 = JackarooAllowedRulesExtensions.GetActiveRuleString((JackarooAllowedRules)currentJackarooCustomRule, JackarooAllowedRulesCategory.Ten);
		ITrackEvent trackEvent9 = TrackerLibrary.JackarooCreateRoomClicked_Ten(activeRuleString8);
		Tracker.DesignEvent(trackEvent9);
		string activeRuleString9 = JackarooAllowedRulesExtensions.GetActiveRuleString((JackarooAllowedRules)currentJackarooCustomRule, JackarooAllowedRulesCategory.Seven);
		ITrackEvent trackEvent10 = TrackerLibrary.JackarooCreateRoomClicked_Seven(activeRuleString9);
		Tracker.DesignEvent(trackEvent10);
		string activeRuleString10 = JackarooAllowedRulesExtensions.GetActiveRuleString((JackarooAllowedRules)currentJackarooCustomRule, JackarooAllowedRulesCategory.BlockBase);
		ITrackEvent trackEvent11 = TrackerLibrary.JackarooCreateRoomClicked_BlockedBase(activeRuleString10);
		Tracker.DesignEvent(trackEvent11);
		string activeRuleString11 = JackarooAllowedRulesExtensions.GetActiveRuleString((JackarooAllowedRules)currentJackarooCustomRule, JackarooAllowedRulesCategory.TwoConsecutive);
		ITrackEvent trackEvent12 = TrackerLibrary.JackarooCreateRoomClicked_TwoConsecutive(activeRuleString11);
		Tracker.DesignEvent(trackEvent12);
		string activeRuleString12 = JackarooAllowedRulesExtensions.GetActiveRuleString((JackarooAllowedRules)currentJackarooCustomRule, JackarooAllowedRulesCategory.PassSameColor);
		ITrackEvent trackEvent13 = TrackerLibrary.JackarooCreateRoomClicked_PassSameColor(activeRuleString12);
		Tracker.DesignEvent(trackEvent13);
	}

	static JackarooCustomRules()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0061: Expected O, but got I
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_00db: Expected O, but got I4
		//IL_0171: Expected O, but got I
		//IL_018c: Expected I, but got O
		//IL_01aa: Expected O, but got I
		//IL_0136: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		JsonSerializerSettings jsonSerializerSettings = default(JsonSerializerSettings);
		jsonSerializerSettings..ctor();
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 184;
		object obj3 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 528;
		object obj4 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 3376;
		object obj5 = (nint)0 + (nint)1824;
		object obj6 = typeof(List<AdaptivePerformanceScaler>) + 1928;
		jsonSerializerSettings.NullValueHandling = NullValueHandling.Ignore;
		jsonSerializerSettings.DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate;
		object obj7 = obj2;
		object obj8 = jsonSerializerSettings;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v10+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Comparison<object> comparison = default(Comparison<object>);
		comparison..ctor(obj11, (IntPtr)obj5);
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v6+B8]");
		object obj13 = (nint)0 + (nint)8;
		obj13 = comparison;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v7+B8]");
		object obj15 = (nint)0 + (nint)32;
		obj15 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
