using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

namespace Kammelna.Server;

public static class ContentSyncService
{
	private sealed class <>c__DisplayClass5_0
	{
		public bool done;

		internal void <EnsureFreshRoutine>b__0(bool _)
		{
			done = true;
		}

		internal bool <EnsureFreshRoutine>b__1()
		{
			return done;
		}
	}

	private sealed class <>c__DisplayClass8_0
	{
		public IDeltaSyncApplier applier;

		public List<Action<bool>> waiters;

		internal void <Fetch>b__0(bool success)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_011a: Expected O, but got I4
			//IL_0128: Expected O, but got I4
			//IL_013e: Expected O, but got I4
			//IL_00c7: Expected O, but got I4
			//IL_007d: Expected O, but got I4
			//IL_0093: Expected O, but got I4
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b3: Expected O, but got Unknown
			//IL_01c3: Expected O, but got I
			//IL_01cb: Expected I, but got O
			//IL_01db: Expected O, but got I
			//IL_0295: Expected O, but got I4
			//IL_031b: Expected O, but got I
			//IL_0323: Expected I, but got O
			//IL_034d: Expected I4, but got O
			//IL_0216: Expected O, but got I
			//IL_02a8: Expected I, but got O
			//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c2: Expected O, but got Unknown
			//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d0: Expected O, but got Unknown
			//IL_0224: Unknown result type (might be due to invalid IL or missing references)
			//IL_0229: Expected O, but got Unknown
			//IL_0232: Unknown result type (might be due to invalid IL or missing references)
			//IL_0237: Expected O, but got Unknown
			//IL_03f0: Expected I4, but got O
			object obj = 152993792;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2872;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8268]");
			object obj3 = (nint)0 & (nint)1;
			Action<bool> action;
			Action<bool> action2;
			List<object>.Enumerator enumerator;
			object obj4;
			if (obj3 != null)
			{
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v16+E4]");
				bool flag = (nint)0 == 0;
				action = null;
				enumerator = (List<object>.Enumerator)0;
				object obj5 = obj4;
				action2 = null;
				enumerator = (List<object>.Enumerator)0;
				if (!flag)
				{
					goto IL_00a1;
				}
			}
			else
			{
				_ = 1;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v16+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				action = null;
				enumerator = (List<object>.Enumerator)0;
				object obj5 = obj4;
				action2 = null;
				enumerator = (List<object>.Enumerator)0;
				if (obj6 != null)
				{
					goto IL_00a1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
			IDeltaSyncApplier deltaSyncApplier = applier;
			bool flag3 = applier == null;
			action = action2;
			bool flag4 = success;
			List<object>.Enumerator enumerator2 = enumerator;
			if (!flag3)
			{
				goto IL_019f;
			}
			goto IL_039c;
			IL_039c:
			NullReferenceException ex = new NullReferenceException();
			bool flag5 = !flag4;
			NullReferenceException ex2 = ex;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				flag4 = (byte)(int)this != 0;
				enumerator2.Dispose();
				object obj7 = default(object);
				if (obj7 == null)
				{
					return;
				}
				OutOfMemoryException ex3 = new OutOfMemoryException();
				object obj8 = obj7;
				ex2 = (NullReferenceException)(object)ex3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C999E8");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_030f:
			object obj9 = (nint)0 + (nint)1328;
			nint num = (nint)obj9;
			object obj10;
			object obj11 = default(object);
			bool flag6 = ((Dictionary<object, object>)obj10).Remove(obj11);
			bool flag7 = waiters == null;
			flag4 = (byte)(int)obj11 != 0;
			enumerator2 = enumerator;
			if (!flag7)
			{
				List<object>.Enumerator enumerator3 = ((List<object>)(object)waiters).GetEnumerator();
				while (enumerator.MoveNext())
				{
					Actions.SafeInvoke(action, success);
				}
				enumerator.Dispose();
				return;
			}
			goto IL_039c;
			IL_0257:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v28+8]");
			flag4 = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v196 @ X0_v28] (should have been resolved before IL gen)");
			bool flag8 = obj10 == null;
			object obj12 = !flag8;
			if (obj12 != null)
			{
				goto IL_030f;
			}
			num = unchecked((nint)null);
			enumerator2 = enumerator;
			goto IL_039c;
			IL_00a1:
			deltaSyncApplier = applier;
			bool flag9 = applier == null;
			object obj13 = !flag9;
			if (obj13 != null)
			{
				goto IL_019f;
			}
			flag4 = success;
			enumerator2 = enumerator;
			goto IL_039c;
			IL_019f:
			object obj14 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2152;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v16+B8]");
			obj10 = 0;
			nint num2 = (nint)deltaSyncApplier;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v7 (Il2CppClass<Kammelna.Server.IDeltaSyncApplier>)+12E]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v7 (Il2CppClass<Kammelna.Server.IDeltaSyncApplier>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0257;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v7 (Il2CppClass<Kammelna.Server.IDeltaSyncApplier>)+B0]");
			object obj16 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X10_v7-8]");
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
				goto IL_0257;
			}
			object obj17 = num2 + obj16;
			object obj18 = obj17 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v31+8]");
			flag4 = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v229 @ X0_v31] (should have been resolved before IL gen)");
			bool flag10 = obj10 == null;
			enumerator2 = enumerator;
			if (!flag10)
			{
				goto IL_030f;
			}
			goto IL_039c;
		}
	}

	private sealed class <EnsureFreshRoutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public string wireKey;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <EnsureFreshRoutine>d__5(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0048: Expected I4, but got I8
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected O, but got Unknown
			//IL_01ef: Expected I4, but got O
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected O, but got Unknown
			//IL_00c1: Expected O, but got I
			//IL_00d2: Expected I, but got O
			//IL_0034: Expected I4, but got I8
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected O, but got Unknown
			//IL_0115: Expected O, but got I4
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Expected O, but got Unknown
			//IL_0170: Expected O, but got I
			//IL_0181: Expected I, but got O
			//IL_0190: Unknown result type (might be due to invalid IL or missing references)
			//IL_0195: Expected O, but got Unknown
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bc: Expected O, but got Unknown
			int num;
			if (<>1__state != 0)
			{
				if (<>1__state != 1)
				{
					goto IL_020e;
				}
				num = -1;
			}
			else
			{
				<>1__state = -1;
				object obj = typeof(CardUtils.<>c) + 2408;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj2 = default(object);
				obj2..ctor();
				if (obj2 == null)
				{
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
				_ = 0;
				object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj4 = (nint)0 + (nint)2208;
				Action<bool> action = default(Action<bool>);
				action..ctor(obj2, (IntPtr)obj4);
				object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2872;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v10+E4]");
				bool flag = (nint)0 == 0;
				object obj7 = !flag;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				EnsureFresh(wireKey, action);
				object obj8 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2128;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj9 = (nint)0 + (nint)2216;
				Func<bool> func = default(Func<bool>);
				func..ctor(obj2, (IntPtr)obj9);
				object obj10 = typeof(UsageHint) + 1680;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				WaitUntil waitUntil = default(WaitUntil);
				waitUntil..ctor(func);
				object obj11 = this + 24;
				obj11 = waitUntil;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				num = 1;
			}
			<>1__state = num;
			goto IL_020e;
			IL_020e:
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
			object obj2 = (nint)0 + (nint)2232;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private static readonly Dictionary<string, List<Action<bool>>> IN_FLIGHT;

	private static MonoBehaviour _host;

	public static void SetHost(MonoBehaviour host)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005a: Expected O, but got I4
		//IL_007e: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2872;
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
		object obj4 = (nint)0 + (nint)8;
		obj4 = host;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public static void EnsureFresh(string wireKey, Action<bool> onDone = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0116: Expected O, but got I4
		//IL_00bb: Expected O, but got I4
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0199: Expected I, but got O
		//IL_01a9: Expected O, but got I
		//IL_023f: Expected I, but got O
		//IL_0263: Expected O, but got I4
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_0334: Expected O, but got I
		//IL_01e4: Expected O, but got I
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Expected O, but got Unknown
		//IL_06af: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b4: Expected O, but got Unknown
		//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Expected O, but got Unknown
		//IL_046d: Expected I, but got O
		//IL_047d: Expected O, but got I
		//IL_036f: Expected O, but got I
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected O, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected O, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		//IL_02c9: Expected I, but got O
		//IL_07a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a6: Expected O, but got Unknown
		//IL_07d0: Expected O, but got I4
		//IL_0513: Expected I, but got O
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_04b8: Expected O, but got I
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected O, but got Unknown
		//IL_044f: Expected O, but got I4
		//IL_0564: Expected I, but got O
		//IL_0574: Expected O, but got I
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected O, but got Unknown
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected O, but got Unknown
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Expected O, but got Unknown
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Expected O, but got Unknown
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Expected O, but got Unknown
		//IL_0649: Expected I, but got O
		//IL_066d: Expected O, but got I4
		//IL_05af: Expected O, but got I
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected O, but got Unknown
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Expected O, but got Unknown
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected O, but got Unknown
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8263]");
		object obj2 = (nint)0 & (nint)1;
		nint num;
		nint num2;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v36+E4]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v36+E4]");
			bool flag = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v36+E4]");
			num2 = 0;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v36+E4]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v36+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v36+E4]");
			num2 = 0;
			if (obj4 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		IDeltaSyncApplier deltaSyncApplier = ContentPushService.GetDeltaSyncApplier(wireKey);
		bool flag3 = deltaSyncApplier == null;
		num = num2;
		IDeltaSyncApplier applier = (IDeltaSyncApplier)(object)wireKey;
		if (!flag3)
		{
			goto IL_017d;
		}
		goto IL_068b;
		IL_03b8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v377 @ X0_v25] (should have been resolved before IL gen)");
		object obj5 = default(object);
		bool flag4 = obj5 == null;
		nint num3 = 7;
		if (!flag4)
		{
			goto IL_03f2;
		}
		goto IL_0465;
		IL_0788:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v294 @ X8_v2] (should have been resolved before IL gen)");
		object obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2872;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v3+E4]");
		bool flag5 = (nint)0 == 0;
		object obj8 = !flag5;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		long cursor = default(long);
		Fetch(applier, cursor, onDone);
		return;
		IL_03f2:
		Actions.SafeInvoke(onDone, arg: true);
		return;
		IL_0094:
		deltaSyncApplier = ContentPushService.GetDeltaSyncApplier(wireKey);
		bool flag6 = deltaSyncApplier == null;
		object obj9 = !flag6;
		if (obj9 != null)
		{
			goto IL_017d;
		}
		applier = (IDeltaSyncApplier)(object)wireKey;
		goto IL_068b;
		IL_017d:
		object obj10 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2152;
		nint num4 = (nint)deltaSyncApplier;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v11 (Il2CppClass<Kammelna.Server.IDeltaSyncApplier>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v11 (Il2CppClass<Kammelna.Server.IDeltaSyncApplier>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_022d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v11 (Il2CppClass<Kammelna.Server.IDeltaSyncApplier>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		object obj13 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X10_v12-8]");
			if (0 == (nint)obj10)
			{
				break;
			}
			obj13 = obj12 + 16;
			obj11--;
			bool flag7 = (nint)obj11 != 1;
			obj12 = obj13;
			if (flag7)
			{
				continue;
			}
			goto IL_022d;
		}
		object obj14 = obj12 + 1;
		object obj15 = num4 + obj14;
		object obj16 = obj15 + 312;
		num = (nint)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v312 @ X0_v33] (should have been resolved before IL gen)");
		object obj17 = default(object);
		bool flag8 = obj17 == null;
		nint num5 = default(nint);
		num3 = num5;
		obj13 = obj12;
		applier = deltaSyncApplier;
		if (!flag8)
		{
			goto IL_0308;
		}
		goto IL_068b;
		IL_068b:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0699;
		IL_0465:
		nint num6 = (nint)deltaSyncApplier;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X8_v15 (Il2CppClass<Kammelna.Server.IDeltaSyncApplier>)+12E]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X8_v15 (Il2CppClass<Kammelna.Server.IDeltaSyncApplier>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0501;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X8_v15 (Il2CppClass<Kammelna.Server.IDeltaSyncApplier>)+B0]");
		obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X10_v2-8]");
			if (0 == (nint)obj10)
			{
				break;
			}
			obj12 = obj13 + 16;
			obj18--;
			bool flag9 = (nint)obj18 != 1;
			obj13 = obj12;
			if (flag9)
			{
				continue;
			}
			goto IL_0501;
		}
		object obj19 = obj13 + 1;
		object obj20 = num6 + obj19;
		object obj21 = obj20 + 312;
		num = (nint)obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v521 @ X0_v20] (should have been resolved before IL gen)");
		bool flag10 = ex == null;
		object obj22 = !flag10;
		num5 = num3;
		applier = deltaSyncApplier;
		if (obj22 != null)
		{
			goto IL_055c;
		}
		goto IL_068b;
		IL_05f0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num5 = 5;
		object obj24 = default(object);
		object obj23 = obj24;
		applier = deltaSyncApplier;
		goto IL_0788;
		IL_0699:
		object obj25 = obj13 + 5;
		object obj26 = num + obj25;
		obj23 = obj26 + 312;
		goto IL_0788;
		IL_022d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj27 = default(object);
		num = (nint)obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v201 @ X0_v30] (should have been resolved before IL gen)");
		bool flag11 = obj17 == null;
		object obj28 = !flag11;
		num3 = 1;
		obj12 = obj13;
		if (obj28 != null)
		{
			goto IL_0308;
		}
		num5 = 1;
		applier = deltaSyncApplier;
		goto IL_068b;
		IL_0308:
		object obj29 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1344;
		object obj30 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v13+12E]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v13+12E]");
		if ((nint)0 == 0)
		{
			goto IL_03b8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v13+B0]");
		object obj32 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X10_v21-8]");
			if (0 == (nint)obj29)
			{
				break;
			}
			obj12 = obj32 + 16;
			obj31--;
			bool flag12 = (nint)obj31 != 1;
			obj32 = obj12;
			if (flag12)
			{
				continue;
			}
			goto IL_03b8;
		}
		object obj33 = obj32 + 7;
		object obj34 = obj30 + obj33;
		object obj35 = obj34 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v459 @ X8_v27] (should have been resolved before IL gen)");
		object obj36 = default(object);
		bool flag13 = obj36 == null;
		object obj37 = !flag13;
		obj12 = obj32;
		if (obj37 != null)
		{
			goto IL_03f2;
		}
		goto IL_0465;
		IL_0501:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj38 = default(object);
		num = (nint)obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v505 @ X0_v17] (should have been resolved before IL gen)");
		bool flag14 = ex == null;
		num3 = 1;
		num5 = 1;
		obj13 = obj12;
		applier = deltaSyncApplier;
		if (!flag14)
		{
			goto IL_055c;
		}
		goto IL_068b;
		IL_055c:
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v6 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v6 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_05f0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v6 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X10_v2-8]");
			bool flag15 = 0 == (nint)obj29;
			num5 = num3;
			applier = deltaSyncApplier;
			if (flag15)
			{
				break;
			}
			obj13 += 16;
			obj39--;
			if ((nint)obj39 != 1)
			{
				continue;
			}
			goto IL_05f0;
		}
		goto IL_0699;
	}

	public static Coroutine EnsureFreshCoroutine(string wireKey)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I4
		//IL_0107: Expected O, but got I
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_006a: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2872;
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
		object obj4 = 0;
		object obj5 = typeof(CardUtils.<>c) + 2424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj6 = default(object);
		obj6..ctor();
		_ = 0;
		object obj7 = obj6 + 32;
		obj7 = wireKey;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+8]");
			return ((MonoBehaviour)0).StartCoroutine((IEnumerator)obj6);
		}
		return (Coroutine)(object)new NullReferenceException();
	}

	private static IEnumerator EnsureFreshRoutine(string wireKey)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(CardUtils.<>c) + 2424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = wireKey;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	public unsafe static void CatchUpAll()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_026f: Expected O, but got I4
		//IL_0278: Expected O, but got I4
		//IL_0289: Expected O, but got I4
		//IL_007f: Expected O, but got I4
		//IL_0090: Expected O, but got I4
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0330: Expected I8, but got I
		//IL_0353: Expected O, but got I4
		//IL_036d: Expected O, but got I4
		//IL_038d: Expected O, but got Ref
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00f0: Expected I, but got O
		//IL_0100: Expected O, but got I
		//IL_02d9: Expected O, but got I4
		//IL_01e6: Expected O, but got I4
		//IL_01f0: Expected O, but got I4
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected O, but got Unknown
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected O, but got Unknown
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected O, but got Unknown
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_013b: Expected O, but got I
		//IL_0482: Expected O, but got I
		//IL_0215: Expected O, but got I4
		//IL_022a: Expected O, but got Ref
		//IL_0e8a: Expected O, but got I
		//IL_0e9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea1: Expected O, but got Unknown
		//IL_0f4a: Expected I8, but got I
		//IL_0f5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f62: Expected O, but got Unknown
		//IL_04bd: Expected O, but got I
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0c0c: Expected O, but got I4
		//IL_0ef2: Expected O, but got I
		//IL_0f04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f09: Expected O, but got Unknown
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Expected O, but got Unknown
		//IL_1237: Expected O, but got I4
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected O, but got Unknown
		//IL_04ee: Expected O, but got I
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Expected O, but got Unknown
		//IL_0c20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c25: Expected O, but got Unknown
		//IL_0c3d: Expected O, but got I
		//IL_05c3: Expected O, but got I
		//IL_12c1: Expected I8, but got I
		//IL_0c78: Expected O, but got I
		//IL_060e: Expected O, but got I
		//IL_1285: Expected O, but got I
		//IL_0f8f: Expected O, but got I
		//IL_0fa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa6: Expected O, but got Unknown
		//IL_0cfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d00: Expected O, but got Unknown
		//IL_06ef: Expected I, but got O
		//IL_06ff: Expected O, but got I
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Expected O, but got Unknown
		//IL_0c86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8b: Expected O, but got Unknown
		//IL_0ca1: Expected O, but got I
		//IL_07e2: Expected O, but got I4
		//IL_0624: Unknown result type (might be due to invalid IL or missing references)
		//IL_0629: Expected O, but got Unknown
		//IL_063f: Expected O, but got I
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Expected O, but got Unknown
		//IL_074a: Expected O, but got I
		//IL_1006: Expected O, but got I
		//IL_1018: Unknown result type (might be due to invalid IL or missing references)
		//IL_101d: Expected O, but got Unknown
		//IL_084a: Expected O, but got I
		//IL_07f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f5: Expected O, but got Unknown
		//IL_07fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0802: Expected O, but got Unknown
		//IL_080b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0810: Expected O, but got Unknown
		//IL_0915: Expected O, but got I4
		//IL_0760: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Expected O, but got Unknown
		//IL_077b: Expected O, but got I
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_078b: Expected O, but got Unknown
		//IL_10d5: Expected I8, but got I
		//IL_0885: Expected O, but got I
		//IL_107d: Expected O, but got I
		//IL_108f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1094: Expected O, but got Unknown
		//IL_0968: Expected I, but got O
		//IL_0978: Expected O, but got I
		//IL_092b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Expected O, but got Unknown
		//IL_0938: Unknown result type (might be due to invalid IL or missing references)
		//IL_093d: Expected O, but got Unknown
		//IL_0946: Unknown result type (might be due to invalid IL or missing references)
		//IL_094b: Expected O, but got Unknown
		//IL_0a53: Expected O, but got I4
		//IL_089b: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a0: Expected O, but got Unknown
		//IL_08a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ae: Expected O, but got Unknown
		//IL_08b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08be: Expected O, but got Unknown
		//IL_1164: Expected I8, but got I
		//IL_09b3: Expected O, but got I
		//IL_0ac6: Expected O, but got I
		//IL_110c: Expected O, but got I
		//IL_111e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1123: Expected O, but got Unknown
		//IL_0ba1: Expected O, but got I4
		//IL_0a69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6e: Expected O, but got Unknown
		//IL_0a76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7b: Expected O, but got Unknown
		//IL_0a84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a89: Expected O, but got Unknown
		//IL_0a99: Expected O, but got I
		//IL_11ed: Expected O, but got I
		//IL_120f: Expected O, but got I4
		//IL_0b11: Expected O, but got I
		//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ce: Expected O, but got Unknown
		//IL_09e4: Expected O, but got I
		//IL_09ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f4: Expected O, but got Unknown
		//IL_1183: Expected O, but got I
		//IL_1195: Unknown result type (might be due to invalid IL or missing references)
		//IL_119a: Expected O, but got Unknown
		//IL_0bb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbc: Expected O, but got Unknown
		//IL_0bd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd7: Expected O, but got Unknown
		//IL_0b27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2c: Expected O, but got Unknown
		//IL_0b35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3a: Expected O, but got Unknown
		//IL_0b45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4a: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8264]");
		object obj2 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		nint num2;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v101+E4]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v101+E4]");
			bool flag = (nint)0 == 0;
			obj4 = 0;
			object obj5 = obj3;
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v101+E4]");
			num2 = 0;
			if (!flag)
			{
				goto IL_00ae;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v101+E4]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v101+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj4 = 0;
			object obj5 = obj3;
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v101+E4]");
			num2 = 0;
			if (obj6 != null)
			{
				goto IL_00ae;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		IEnumerable<IDeltaSyncApplier> deltaSyncAppliers = ContentPushService.DeltaSyncAppliers;
		bool flag3 = deltaSyncAppliers == null;
		object obj7 = !flag3;
		num = num2;
		if (obj7 != null)
		{
			goto IL_00d4;
		}
		goto IL_02ef;
		IL_0d0e:
		throw new NullReferenceException();
		IL_02fd:
		object obj9 = default(object);
		object obj8 = num + obj9;
		object obj10 = obj8 + 312;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v45+8]");
		long num3 = 0L;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v163 @ X8_v45] (should have been resolved before IL gen)");
		object obj12 = default(object);
		bool flag4 = obj12 == null;
		object obj13 = 0;
		obj4 = obj12;
		object obj15 = default(object);
		object obj14 = obj15;
		obj13 = 0;
		Action<bool> action2 = default(Action<bool>);
		Action<bool> action = action2;
		object obj16 = obj9;
		obj4 = obj12;
		object obj17 = (object)(&obj4);
		if (!flag4)
		{
			goto IL_039b;
		}
		goto IL_0d0e;
		IL_039b:
		object obj18 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj19 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 640;
		object obj20 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2152;
		object obj21 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1344;
		object obj22 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2872;
		object obj23 = obj12;
		bool flag6 = default(bool);
		object obj29 = default(object);
		IDeltaSyncApplier deltaSyncApplier = default(IDeltaSyncApplier);
		long num4 = default(long);
		long num5 = default(long);
		bool flag10;
		object obj39 = default(object);
		object obj52 = default(object);
		object obj58 = default(object);
		object obj59 = default(object);
		object obj61 = default(object);
		object obj66 = default(object);
		object obj67 = default(object);
		object obj72 = default(object);
		do
		{
			object obj24 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v15+12E]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v15+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0542;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v15+B0]");
			object obj26 = (nint)0 + (nint)8;
			bool flag5 = flag6;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X10_v49-8]");
				obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X10_v49-8]");
				object obj27 = 0 - obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X10_v49-8]");
				if (0 == (nint)obj18)
				{
					break;
				}
				obj9 = obj26 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v15+12E]");
				obj25 = -1;
				obj27 = obj25 - 1;
				bool flag7 = obj27 == null;
				flag6 = (nint)obj25 != 1;
				flag5 = flag6;
				obj26 = obj9;
				if (flag6)
				{
					continue;
				}
				goto IL_0542;
			}
			obj25 = obj26;
			object obj28 = obj24 + obj26;
			obj29 = obj28 + 312;
			flag6 = flag5;
			obj9 = obj26;
			goto IL_0f32;
			IL_11c3:
			object obj30;
			obj11 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1036 @ X8_v30] (should have been resolved before IL gen)");
			object obj31 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1040 @ X0_v44+E4]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1040 @ X0_v44+E4]");
			bool flag8 = (nint)0 == 0;
			object obj32 = !flag8;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Fetch(deltaSyncApplier, num4, null);
			action = null;
			num3 = num4;
			goto IL_042d;
			IL_1046:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v806 @ X0_v32] (should have been resolved before IL gen)");
			if (num5 != 0)
			{
				long value = ((long*)num5)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X8_v24 (System.Int64)+12E]");
				object obj33 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X8_v24 (System.Int64)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0902;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X8_v24 (System.Int64)+B0]");
				object obj34 = (nint)0 + (nint)8;
				bool flag9 = flag6;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X10_v34-8]");
					obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X10_v34-8]");
					object obj27 = 0 - obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X10_v34-8]");
					if (0 == (nint)obj21)
					{
						break;
					}
					obj16 = obj34 + 16;
					obj33--;
					obj27 = obj33 - 1;
					bool flag7 = obj27 == null;
					flag6 = (nint)obj33 != 1;
					flag9 = flag6;
					obj34 = obj16;
					if (flag6)
					{
						continue;
					}
					goto IL_0902;
				}
				object obj35 = obj34 + 5;
				object obj36 = value + obj35;
				obj17 = obj36 + 312;
				flag6 = flag9;
				obj16 = obj34;
				goto IL_10bd;
			}
			throw new NullReferenceException();
			IL_042d:
			flag10 = obj4 == null;
			obj15 = obj14;
			action2 = action;
			obj9 = obj16;
			obj23 = obj4;
			continue;
			IL_0542:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			action2 = null;
			goto IL_0f32;
			IL_0f32:
			object obj37 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X0_v24+8]");
			long num6 = 0L;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v518 @ X0_v24] (should have been resolved before IL gen)");
			object obj38 = obj39 & 1;
			object obj42;
			object obj43;
			Action<bool> action3;
			if (obj38 != null)
			{
				if (obj4 != null)
				{
					object obj40 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v18+12E]");
					object obj41 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v18+12E]");
					bool flag11 = (nint)0 == 0;
					obj42 = obj15;
					obj43 = obj9;
					if (flag11)
					{
						goto IL_0693;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v18+B0]");
					object obj44 = (nint)0 + (nint)8;
					bool flag12 = flag6;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X10_v44-8]");
						obj42 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X10_v44-8]");
						object obj27 = 0 - obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X10_v44-8]");
						if (0 == (nint)obj19)
						{
							break;
						}
						obj43 = obj44 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v18+12E]");
						obj41 = -1;
						obj27 = obj41 - 1;
						bool flag7 = obj27 == null;
						flag6 = (nint)obj41 != 1;
						flag12 = flag6;
						obj44 = obj43;
						if (flag6)
						{
							continue;
						}
						goto IL_0693;
					}
					obj41 = obj44;
					object obj45 = obj40 + obj44;
					object obj46 = obj45 + 312;
					action3 = action2;
					flag6 = flag12;
					obj43 = obj44;
					goto IL_0fcf;
				}
				throw new NullReferenceException();
			}
			object obj47 = 0;
			object obj54;
			Action<bool> action4;
			object obj55;
			object obj57;
			long num7;
			object obj56;
			while (true)
			{
				if (obj4 == null)
				{
					goto IL_121d;
				}
				object obj48 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				object obj49 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X8_v7+12E]");
				obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X8_v7+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0cc9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X8_v7+B0]");
				object obj50 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X10_v8-8]");
					obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X10_v8-8]");
					if (0 == (nint)obj48)
					{
						break;
					}
					obj9 = obj50 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X8_v7+12E]");
					obj25 = -1;
					bool flag13 = (nint)obj25 != 1;
					obj50 = obj9;
					if (flag13)
					{
						continue;
					}
					goto IL_0cc9;
				}
				obj25 = obj50;
				object obj51 = obj49 + obj50;
				obj52 = obj51 + 312;
				obj9 = obj50;
				goto IL_12a9;
				IL_121d:
				bool flag14 = obj47 == null;
				object obj53 = !flag14;
				obj54 = obj15;
				action4 = action2;
				obj55 = obj9;
				obj56 = obj25;
				num7 = num6;
				obj57 = obj37;
				if (obj53 == null)
				{
					return;
				}
				OutOfMemoryException ex = new OutOfMemoryException();
				if (num7 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj47 = obj58;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj15 = obj54;
				obj13 = obj58;
				action2 = action4;
				obj9 = obj55;
				obj25 = obj56;
				num6 = num7;
				obj37 = obj57;
				continue;
				IL_0cc9:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				action2 = null;
				goto IL_12a9;
				IL_12a9:
				obj37 = obj52;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X0_v13+8]");
				num6 = 0L;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v748 @ X0_v13] (should have been resolved before IL gen)");
				goto IL_121d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_07cf:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			action = (Action<bool>)1;
			goto IL_1046;
			IL_0a38:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj54 = obj14;
			action4 = (Action<bool>)1;
			obj55 = obj16;
			goto IL_114c;
			IL_114c:
			obj57 = obj59;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v968 @ X0_v38+8]");
			num7 = 0L;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v968 @ X0_v38] (should have been resolved before IL gen)");
			object obj60 = obj61;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v973 @ X8_v29+12E]");
			object obj62 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v973 @ X8_v29+12E]");
			bool flag15 = (nint)0 == 0;
			obj14 = obj54;
			obj16 = obj55;
			if (flag15)
			{
				goto IL_0b8e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v973 @ X8_v29+B0]");
			object obj63 = (nint)0 + (nint)8;
			bool flag16 = flag6;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1015 @ X10_v23-8]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1015 @ X10_v23-8]");
				object obj27 = 0 - obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1015 @ X10_v23-8]");
				if (0 == (nint)obj21)
				{
					break;
				}
				obj16 = obj63 + 16;
				obj62--;
				obj27 = obj62 - 1;
				bool flag7 = obj27 == null;
				flag6 = (nint)obj62 != 1;
				flag16 = flag6;
				obj63 = obj16;
				if (flag6)
				{
					continue;
				}
				goto IL_0b8e;
			}
			object obj64 = obj63 + 5;
			object obj65 = obj60 + obj64;
			obj30 = obj65 + 312;
			Action<bool> action5 = action4;
			flag6 = flag16;
			obj16 = obj63;
			goto IL_11c3;
			IL_0b8e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			action5 = (Action<bool>)5;
			obj30 = obj66;
			goto IL_11c3;
			IL_0902:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			action = (Action<bool>)5;
			obj17 = obj67;
			goto IL_10bd;
			IL_0693:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			action3 = null;
			goto IL_0fcf;
			IL_0fcf:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v685 @ X0_v28] (should have been resolved before IL gen)");
			if (deltaSyncApplier != null)
			{
				nint num8 = (nint)deltaSyncApplier;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X8_v21 (Il2CppClass<Kammelna.Server.IDeltaSyncApplier>)+12E]");
				object obj68 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X8_v21 (Il2CppClass<Kammelna.Server.IDeltaSyncApplier>)+12E]");
				bool flag17 = (nint)0 == 0;
				obj14 = obj42;
				obj16 = obj43;
				if (flag17)
				{
					goto IL_07cf;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X8_v21 (Il2CppClass<Kammelna.Server.IDeltaSyncApplier>)+B0]");
				object obj69 = (nint)0 + (nint)8;
				bool flag18 = flag6;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X10_v39-8]");
					obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X10_v39-8]");
					object obj27 = 0 - obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X10_v39-8]");
					if (0 == (nint)obj20)
					{
						break;
					}
					obj16 = obj69 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X8_v21 (Il2CppClass<Kammelna.Server.IDeltaSyncApplier>)+12E]");
					obj68 = -1;
					obj27 = obj68 - 1;
					bool flag7 = obj27 == null;
					flag6 = (nint)obj68 != 1;
					flag18 = flag6;
					obj69 = obj16;
					if (flag6)
					{
						continue;
					}
					goto IL_07cf;
				}
				obj68 = obj69 + 1;
				object obj70 = num8 + obj68;
				object obj71 = obj70 + 312;
				action = action3;
				flag6 = flag18;
				obj16 = obj69;
				goto IL_1046;
			}
			throw new NullReferenceException();
			IL_10bd:
			obj11 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v12+8]");
			num3 = 0L;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v270 @ X8_v12] (should have been resolved before IL gen)");
			if (obj72 == null)
			{
				goto IL_042d;
			}
			nint num9 = (nint)deltaSyncApplier;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v891 @ X8_v26 (Il2CppClass<Kammelna.Server.IDeltaSyncApplier>)+12E]");
			obj56 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v891 @ X8_v26 (Il2CppClass<Kammelna.Server.IDeltaSyncApplier>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0a38;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v891 @ X8_v26 (Il2CppClass<Kammelna.Server.IDeltaSyncApplier>)+B0]");
			obj55 = (nint)0 + (nint)8;
			bool flag19 = flag6;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X10_v1-8]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X10_v1-8]");
				object obj27 = 0 - obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X10_v1-8]");
				if (0 == (nint)obj20)
				{
					break;
				}
				obj16 = obj55 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v891 @ X8_v26 (Il2CppClass<Kammelna.Server.IDeltaSyncApplier>)+12E]");
				obj56 = -1;
				obj27 = obj56 - 1;
				bool flag7 = obj27 == null;
				flag6 = (nint)obj56 != 1;
				flag19 = flag6;
				obj55 = obj16;
				if (flag6)
				{
					continue;
				}
				goto IL_0a38;
			}
			obj56 = obj55 + 1;
			object obj73 = num9 + obj56;
			obj59 = obj73 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X10_v1-8]");
			obj54 = 0;
			action4 = action;
			flag6 = flag19;
			goto IL_114c;
		}
		while (!flag10);
		goto IL_0d0e;
		IL_00ae:
		deltaSyncAppliers = ContentPushService.DeltaSyncAppliers;
		if (deltaSyncAppliers != null)
		{
			goto IL_00d4;
		}
		goto IL_02ef;
		IL_02ef:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_02fd;
		IL_00d4:
		object obj74 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3264;
		num = (nint)deltaSyncAppliers;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v43 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Kammelna.Server.IDeltaSyncApplier>>)+12E]");
		object obj75 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v43 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Kammelna.Server.IDeltaSyncApplier>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01b8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v43 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Kammelna.Server.IDeltaSyncApplier>>)+B0]");
		object obj76 = (nint)0 + (nint)8;
		bool flag20 = flag6;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X10_v55-8]");
			obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X10_v55-8]");
			object obj27 = 0 - obj74;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X10_v55-8]");
			bool flag7 = 0 == (nint)obj74;
			flag6 = flag20;
			obj9 = obj76;
			ex2 = (NullReferenceException)deltaSyncAppliers;
			if (flag7)
			{
				break;
			}
			obj9 = obj76 + 16;
			obj75--;
			obj27 = obj75 - 1;
			flag7 = obj27 == null;
			flag6 = (nint)obj75 != 1;
			flag20 = flag6;
			obj76 = obj9;
			if (flag6)
			{
				continue;
			}
			goto IL_01b8;
		}
		goto IL_02fd;
		IL_01b8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v131 @ X0_v98] (should have been resolved before IL gen)");
		bool flag21 = obj12 == null;
		object obj77 = !flag21;
		obj13 = 0;
		action2 = null;
		obj4 = obj12;
		if (obj77 != null)
		{
			goto IL_039b;
		}
		obj13 = 0;
		action = null;
		obj4 = obj12;
		obj17 = (object)(&obj4);
		goto IL_0d0e;
	}

	public static void Rebaseline(string wireKey)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_012f: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_01ba: Expected I8, but got I4
		//IL_00ea: Expected I8, but got I4
		//IL_018b: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8265]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2872;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v5+E4]");
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
			obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2872;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		IDeltaSyncApplier deltaSyncApplier = ContentPushService.GetDeltaSyncApplier(wireKey);
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		IDeltaSyncApplier applier = deltaSyncApplier;
		if (obj9 != null)
		{
			goto IL_00db;
		}
		goto IL_01a1;
		IL_00db:
		Fetch(deltaSyncApplier, 0L, null);
		return;
		IL_01a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Fetch(applier, 0L, null);
		return;
		IL_0099:
		deltaSyncApplier = ContentPushService.GetDeltaSyncApplier(wireKey);
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v2+E4]");
		bool flag4 = (nint)0 == 0;
		applier = deltaSyncApplier;
		if (!flag4)
		{
			goto IL_00db;
		}
		goto IL_01a1;
	}

	private unsafe static void Fetch(IDeltaSyncApplier applier, long cursor, Action<bool> onDone)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0077: Expected O, but got I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00c0: Expected O, but got I
		//IL_00d8: Expected O, but got I
		//IL_0182: Expected O, but got I4
		//IL_01cb: Expected O, but got I
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected Ref, but got Unknown
		//IL_0113: Expected O, but got I
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_046f: Expected O, but got I4
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_036d: Expected O, but got I
		//IL_0234: Expected O, but got I
		//IL_04bc: Expected O, but got I
		//IL_04d4: Expected O, but got I
		//IL_037e: Expected O, but got I
		//IL_057e: Expected O, but got I4
		//IL_03d8: Expected O, but got I4
		//IL_028d: Expected O, but got I4
		//IL_05c8: Expected O, but got I
		//IL_05e1: Expected O, but got I
		//IL_05f1: Expected O, but got I
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_0605: Expected O, but got Unknown
		//IL_050f: Expected O, but got I
		//IL_0727: Expected O, but got I
		//IL_0737: Expected O, but got I
		//IL_077e: Expected O, but got I4
		//IL_0620: Expected O, but got I
		//IL_0631: Expected I, but got O
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected O, but got Unknown
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected O, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_064e: Expected O, but got I
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Expected O, but got Unknown
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected O, but got Unknown
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected O, but got Unknown
		//IL_086e: Expected O, but got I
		//IL_0689: Expected O, but got I
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Expected O, but got Unknown
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0702: Expected O, but got Unknown
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Expected O, but got Unknown
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06aa: Expected O, but got Unknown
		object obj = typeof(CardUtils.<>c) + 2416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2872;
		object obj4 = obj2 + 16;
		obj4 = applier;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj3;
		}
		object obj7 = obj4;
		object obj8 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2152;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v9+B8]");
		object obj9 = 0;
		object obj10 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v6+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v6+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0154;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v6+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X10_v23-8]");
			if (0 == (nint)obj8)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_0154;
		}
		object obj13 = obj10 + obj12;
		object obj14 = obj13 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v416 @ X0_v52] (should have been resolved before IL gen)");
		goto IL_01bf;
		IL_0856:
		object obj16 = default(object);
		object obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X0_v22+8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v264 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_0550:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v527 @ X0_v28] (should have been resolved before IL gen)");
		object obj18;
		bool flag2 = obj18 == null;
		object obj19 = !flag2;
		if (obj19 != null)
		{
			goto IL_05bc;
		}
		goto IL_07b1;
		IL_048d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj20 = obj3;
		ref object reference2;
		ref object reference = ref reference2;
		goto IL_0801;
		IL_05bc:
		object obj21 = (nint)0 + (nint)1344;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+18]");
		object key = default(object);
		((Dictionary<object, object>)obj18).set_Item(key, (object)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
		object obj22 = 0;
		object obj23 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj24 = (nint)0 + (nint)2224;
		Action<bool> action = default(Action<bool>);
		action..ctor(obj2, (IntPtr)obj24);
		object obj25 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v24+12E]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v24+12E]");
		if ((nint)0 == 0)
		{
			goto IL_06ca;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v24+B0]");
		object obj27 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X10_v9-8]");
			if (0 == (nint)obj8)
			{
				break;
			}
			obj27 += 16;
			obj26--;
			if ((nint)obj26 != 1)
			{
				continue;
			}
			goto IL_06ca;
		}
		object obj28 = obj27 + 2;
		object obj29 = obj25 + obj28;
		obj16 = obj29 + 312;
		goto IL_0856;
		IL_07b1:
		throw new NullReferenceException();
		IL_06ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0856;
		IL_0154:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v395 @ X0_v49] (should have been resolved before IL gen)");
		bool flag3 = obj9 == null;
		object obj30 = !flag3;
		if (obj30 != null)
		{
			goto IL_01bf;
		}
		goto IL_07b1;
		IL_01bf:
		object obj31 = (nint)0 + (nint)1336;
		reference2 = ref *(object*)(obj2 + 24);
		object key2 = default(object);
		if (((Dictionary<object, object>)obj9).TryGetValue(key2, out reference2))
		{
			if (onDone != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+18]");
				List<object> list = (List<object>)0;
				int version = list._version + 1;
				list._version = version;
				object[] items = list._items;
				bool flag4 = list._size < items.Length;
				object obj32 = !flag4;
				if (obj32 == null)
				{
					int size = list._size + 1;
					list._size = size;
					object obj33 = items + list._size;
					object obj34 = obj33 + 32;
					obj34 = onDone;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				}
				else
				{
					list.AddWithResize((object)onDone);
				}
			}
			return;
		}
		object obj35 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj36 = obj2 + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag5 = onDone == null;
		List<object> list3 = list2;
		object obj43;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+18]");
			List<object> list4 = (List<object>)0;
			object obj37 = (nint)0 + (nint)2208;
			object obj38 = obj37;
			int version2 = list4._version + 1;
			list4._version = version2;
			object[] items2 = list4._items;
			bool flag6 = list4._size < items2.Length;
			object obj39 = !flag6;
			if (obj39 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v35+20]");
				object obj40 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v36+C0]");
				object obj41 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v37+70]");
				reference = ref *(object*)null;
				list4.AddWithResize((object)onDone);
				obj20 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v17+E4]");
				bool flag7 = (nint)0 == 0;
				object obj42 = !flag7;
				if (obj42 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v37+70]");
					reference2 = ref *(object*)null;
					list3 = (List<object>)(object)onDone;
					obj43 = obj20;
					goto IL_048d;
				}
				goto IL_0801;
			}
			int size2 = list4._size + 1;
			list4._size = size2;
			object obj44 = items2 + list4._size;
			object obj45 = obj44 + 32;
			obj45 = onDone;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			list3 = (List<object>)(object)onDone;
		}
		obj43 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X0_v34+E4]");
		bool flag8 = (nint)0 == 0;
		object obj46 = !flag8;
		reference = ref reference2;
		obj20 = obj43;
		if (obj46 == null)
		{
			goto IL_048d;
		}
		goto IL_0801;
		IL_0801:
		object obj47 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v17+B8]");
		obj18 = 0;
		object obj48 = obj47;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X8_v16+12E]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X8_v16+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0550;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X8_v16+B0]");
		object obj50 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X10_v14-8]");
			if (0 == (nint)obj8)
			{
				break;
			}
			obj50 += 16;
			obj49--;
			if ((nint)obj49 != 1)
			{
				continue;
			}
			goto IL_0550;
		}
		object obj51 = obj48 + obj50;
		object obj52 = obj51 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v544 @ X0_v31] (should have been resolved before IL gen)");
		goto IL_05bc;
	}

	static ContentSyncService()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2072;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj3 = obj2;
		object obj4 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
