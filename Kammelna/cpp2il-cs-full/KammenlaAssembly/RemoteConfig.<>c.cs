using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server;
using Kammelna.Server.WebRequests;
using Server.Models;
using Unity.Services.Authentication.Shared;

public static class RemoteConfig
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<RemoteConfigModel> <>9__10_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Refresh>b__10_0(RemoteConfigModel _)
		{
		}
	}

	private static readonly RemoteConfigModel DEFAULTS;

	private static readonly OneShotEvent<RemoteConfigModel> <ReadyState>k__BackingField;

	public static OneShotEvent<RemoteConfigModel> ReadyState
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
			object obj2 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E71B8]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+8]");
			return (OneShotEvent<RemoteConfigModel>)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+8]");
			return (OneShotEvent<RemoteConfigModel>)0;
		}
	}

	public static RemoteConfigModel Current
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0194: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_021a: Expected O, but got I4
			//IL_01c2: Expected O, but got I
			//IL_01dc: Expected O, but got I4
			//IL_00f5: Expected O, but got I
			//IL_0105: Expected O, but got I
			//IL_0252: Expected O, but got I
			//IL_0262: Expected O, but got I
			//IL_0284: Expected O, but got I4
			//IL_02fc: Expected O, but got I
			//IL_0164: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E71B9]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v15+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v15+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D1]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00b0;
			}
			goto IL_01ea;
			IL_02b0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v1 (System.NullReferenceException)+E4]");
			object obj8;
			if ((nint)0 != 0)
			{
				return (RemoteConfigModel)obj8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v4+B8]");
			return (RemoteConfigModel)0;
			IL_0132:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v17+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v17+20]");
				return (RemoteConfigModel)0;
			}
			goto IL_02b0;
			IL_029a:
			NullReferenceException ex = new NullReferenceException();
			object obj10;
			obj8 = obj10;
			goto IL_02b0;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D1]");
			object obj11 = (nint)0 & (nint)1;
			if (obj11 != null)
			{
				goto IL_00b0;
			}
			goto IL_01ea;
			IL_01ea:
			_ = 1;
			ex = (NullReferenceException)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v1 (System.NullReferenceException)+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			NullReferenceException ex2 = ex;
			if (obj12 != null)
			{
				goto IL_00e5;
			}
			goto IL_0230;
			IL_00b0:
			ex = (NullReferenceException)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v1 (System.NullReferenceException)+E4]");
			bool flag4 = (nint)0 == 0;
			ex2 = ex;
			if (!flag4)
			{
				goto IL_00e5;
			}
			goto IL_0230;
			IL_0230:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			ex = (NullReferenceException)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v1 (System.NullReferenceException)+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X9_v1+8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X9_v1+8]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			obj10 = obj8;
			if (obj14 != null)
			{
				goto IL_0132;
			}
			goto IL_029a;
			IL_00e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v1 (System.NullReferenceException)+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X9_v1+8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X9_v1+8]");
			bool flag6 = (nint)0 == 0;
			obj10 = obj8;
			if (!flag6)
			{
				goto IL_0132;
			}
			goto IL_029a;
		}
	}

	public static event Action OnChanged
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
			object obj = typeof(RegisteredWaitHandle) + 56;
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
			object obj = typeof(RegisteredWaitHandle) + 56;
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

	public static void Initialize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_019c: Expected I, but got O
		//IL_01c6: Expected O, but got I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0082: Expected I, but got O
		//IL_00a8: Expected I, but got O
		//IL_00d7: Expected O, but got I4
		//IL_011a: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3000;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = typeof(RegisteredWaitHandle) + 56;
		Config.OnLoggedIn -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(null, (IntPtr)obj2);
		Config.OnLoggedIn += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(null, (IntPtr)obj2);
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v12+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Preferences.OnGameChanged -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(null, (IntPtr)obj2);
		Preferences.OnGameChanged += action4;
		object obj10 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v18+E4]");
		if ((nint)0 != 0)
		{
			Refresh();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Refresh();
	}

	public static void Refresh()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_016b: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_00a2: Expected O, but got I4
		//IL_01fb: Expected O, but got I4
		//IL_0199: Expected O, but got I
		//IL_01b3: Expected O, but got I4
		//IL_01bc: Expected O, but got I4
		//IL_00f6: Expected O, but got I
		//IL_0106: Expected O, but got I
		//IL_0128: Expected O, but got I4
		//IL_0254: Expected O, but got I
		//IL_0274: Expected O, but got I
		//IL_0233: Expected O, but got I
		//IL_0243: Expected O, but got I
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected O, but got Unknown
		//IL_040d: Expected O, but got I4
		//IL_02f2: Expected O, but got I
		//IL_0302: Expected O, but got I
		//IL_0341: Expected O, but got I
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		//IL_04d7: Expected O, but got I
		//IL_04e7: Expected O, but got I
		//IL_0509: Expected O, but got I4
		//IL_044d: Expected O, but got I
		//IL_045d: Expected O, but got I
		//IL_0487: Expected O, but got I4
		//IL_04a7: Expected O, but got I
		//IL_03b6: Expected O, but got I4
		//IL_035f: Expected O, but got I
		//IL_036f: Expected O, but got I
		//IL_059f: Expected O, but got I
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Expected O, but got Unknown
		//IL_05e7: Expected O, but got I4
		//IL_0549: Expected O, but got I4
		//IL_06af: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b4: Expected O, but got Unknown
		//IL_06ca: Expected O, but got I
		//IL_06db: Expected I, but got O
		//IL_06f9: Expected O, but got I
		//IL_061e: Expected O, but got I
		//IL_0579: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E71BD]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v48+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v48+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D1]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		object obj7 = 146685952;
		if (obj6 != null)
		{
			goto IL_00b1;
		}
		goto IL_01cb;
		IL_0527:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		object obj10;
		object obj11;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v21+B8]");
			obj11 = 0;
		}
		object obj12 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)3752;
		Action<object> action = default(Action<object>);
		action..ctor(obj11, (IntPtr)obj13);
		object obj14 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v20+B8]");
		object obj15 = (nint)0 + (nint)8;
		obj15 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Action<object> action2 = action;
		object obj17;
		object obj16 = obj17;
		goto IL_0593;
		IL_034f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v15+B8]");
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v15+8]");
		action2 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v15+8]");
		bool flag4 = (nint)0 == 0;
		obj17 = obj16;
		if (!flag4)
		{
			goto IL_039c;
		}
		goto IL_0527;
		IL_04b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj19;
		object obj18 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v15+B8]");
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v15+8]");
		action2 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v15+8]");
		bool flag5 = (nint)0 == 0;
		object obj20 = !flag5;
		obj16 = obj17;
		obj10 = obj19;
		if (obj20 != null)
		{
			goto IL_039c;
		}
		goto IL_0527;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D1]");
		object obj21 = (nint)0 & (nint)1;
		bool flag6 = obj21 == null;
		obj7 = 146685952;
		if (!flag6)
		{
			goto IL_00b1;
		}
		goto IL_01cb;
		IL_01cb:
		_ = 1;
		object obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v75+E4]");
		bool flag7 = (nint)0 == 0;
		object obj23 = !flag7;
		object obj24 = obj22;
		if (obj23 != null)
		{
			goto IL_00e6;
		}
		goto IL_0211;
		IL_00b1:
		obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v75+E4]");
		bool flag8 = (nint)0 == 0;
		obj24 = obj22;
		if (!flag8)
		{
			goto IL_00e6;
		}
		goto IL_0211;
		IL_0211:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj25 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v41+B8]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v38+8]");
		object obj27 = 0;
		goto IL_0248;
		IL_00e6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v75+B8]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v47+8]");
		obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v47+8]");
		bool flag9 = (nint)0 == 0;
		object obj29 = !flag9;
		if (obj29 != null)
		{
			goto IL_0248;
		}
		goto IL_0699;
		IL_0248:
		object obj30 = (nint)0 + (nint)2464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3997898");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D1]");
		object obj31 = (nint)0 & (nint)1;
		if (obj31 != null)
		{
			obj10 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 528;
			object obj32 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v36+E4]");
			bool flag10 = (nint)0 == 0;
			obj19 = obj10;
			object obj33 = obj32;
			if (!flag10)
			{
				goto IL_02e2;
			}
		}
		else
		{
			_ = 1;
			obj10 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 528;
			object obj32 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v36+E4]");
			bool flag11 = (nint)0 == 0;
			object obj34 = !flag11;
			obj19 = obj10;
			object obj33 = obj32;
			if (obj34 != null)
			{
				goto IL_02e2;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj35 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v28+B8]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v26+8]");
		obj16 = 0;
		obj18 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v15+E4]");
		bool flag12 = (nint)0 == 0;
		object obj37 = !flag12;
		obj10 = obj19;
		object obj38 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v26+8]");
		obj17 = 0;
		if (obj37 != null)
		{
			goto IL_034f;
		}
		goto IL_04b5;
		IL_039c:
		bool flag13 = obj16 == null;
		object obj39 = !flag13;
		if (obj39 != null)
		{
			goto IL_0593;
		}
		goto IL_0699;
		IL_0593:
		object obj40 = (nint)0 + (nint)2456;
		object obj41 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39978C8");
		object obj42 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v6+E4]");
		bool flag14 = (nint)0 == 0;
		object obj43 = !flag14;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CachedModel<RemoteConfigModel> remoteConfig = CachedModels.RemoteConfig;
		object obj44 = (nint)0 + (nint)624;
		object model = ((CachedModel<object>)(object)remoteConfig).Model;
		if (model != null)
		{
			object obj45 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v13+E4]");
			if ((nint)0 != 0)
			{
				Apply((RemoteConfigModel)model);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Apply((RemoteConfigModel)model);
		}
		return;
		IL_0699:
		throw new NullReferenceException();
		IL_02e2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v36+B8]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v34+8]");
		obj16 = 0;
		obj18 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v15+E4]");
		bool flag15 = (nint)0 == 0;
		obj19 = obj10;
		obj38 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v34+8]");
		obj17 = 0;
		if (!flag15)
		{
			goto IL_034f;
		}
		goto IL_04b5;
	}

	private static void Fetch()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_006a: Expected I, but got O
		if (SFS.IsLoggedIn)
		{
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2736;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 600;
			object obj3 = (nint)0 + (nint)2992;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			GetRemoteConfigRequest getRemoteConfigRequest = default(GetRemoteConfigRequest);
			getRemoteConfigRequest..ctor();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)null, (IntPtr)obj3);
			KammelnaRequests.Send((IWebRequest<object>)getRemoteConfigRequest, action);
		}
	}

	private static void OnResponse(KammelnaResponseModel<RemoteConfigModel> response)
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_01e2: Expected O, but got I
		//IL_01fc: Expected O, but got I4
		//IL_0205: Expected O, but got I4
		//IL_020e: Expected O, but got I4
		//IL_00f9: Expected O, but got I
		//IL_0111: Expected O, but got I4
		//IL_011a: Expected O, but got I4
		//IL_028c: Expected O, but got I
		//IL_029c: Expected O, but got I
		//IL_024c: Expected O, but got I4
		//IL_0175: Expected O, but got I
		//IL_0185: Expected O, but got I
		//IL_01a7: Expected O, but got I4
		//IL_02df: Expected O, but got I
		//IL_040e: Expected O, but got I
		//IL_0428: Expected O, but got I4
		//IL_0338: Expected O, but got I
		//IL_049e: Expected O, but got I
		//IL_04ae: Expected O, but got I
		//IL_04d0: Expected O, but got I4
		//IL_0466: Expected O, but got I4
		//IL_03e3: Expected O, but got I
		//IL_039a: Expected O, but got I
		//IL_03aa: Expected O, but got I
		bool flag = response == null;
		KammelnaResponseModel<RemoteConfigModel> kammelnaResponseModel = response;
		object obj2;
		KammelnaResponseModel<RemoteConfigModel> kammelnaResponseModel2;
		NullReferenceException ex;
		object obj9;
		object obj7;
		if (!flag)
		{
			object obj = (nint)0 + (nint)1408;
			obj2 = typeof(RegisteredWaitHandle) + 56;
			if (((KammelnaResponseModel<object>)(object)response).Succeeded)
			{
				kammelnaResponseModel = (KammelnaResponseModel<RemoteConfigModel>)(object)response.<Model>k__BackingField;
				if (response.<Model>k__BackingField != null)
				{
					ex = (NullReferenceException)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v2 (System.NullReferenceException)+E4]");
					if ((nint)0 != 0)
					{
						Apply(response.<Model>k__BackingField);
						return;
					}
					goto IL_04f4;
				}
			}
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v9+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D1]");
				object obj4 = (nint)0 & (nint)1;
				bool flag2 = obj4 == null;
				kammelnaResponseModel2 = (KammelnaResponseModel<RemoteConfigModel>)146685952;
				kammelnaResponseModel = (KammelnaResponseModel<RemoteConfigModel>)146685952;
				if (!flag2)
				{
					goto IL_0128;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D1]");
				object obj5 = (nint)0 & (nint)1;
				bool flag3 = obj5 == null;
				object obj6 = !flag3;
				kammelnaResponseModel2 = (KammelnaResponseModel<RemoteConfigModel>)146685952;
				kammelnaResponseModel = (KammelnaResponseModel<RemoteConfigModel>)146685952;
				if (obj6 != null)
				{
					goto IL_0128;
				}
			}
			_ = 1;
			obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			kammelnaResponseModel2 = kammelnaResponseModel;
			obj9 = obj7;
			if (obj8 != null)
			{
				goto IL_0165;
			}
			goto IL_026a;
		}
		goto IL_04e6;
		IL_04e6:
		ex = new NullReferenceException();
		goto IL_04f4;
		IL_04f4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Apply((RemoteConfigModel)(object)kammelnaResponseModel);
		return;
		IL_0355:
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v22+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = obj10;
		if (!flag5)
		{
			goto IL_038a;
		}
		goto IL_047c;
		IL_03d7:
		object obj12 = (nint)0 + (nint)2464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3997898");
		return;
		IL_038a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v22+B8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v21+8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v21+8]");
		bool flag6 = (nint)0 == 0;
		kammelnaResponseModel = kammelnaResponseModel2;
		if (!flag6)
		{
			goto IL_03d7;
		}
		goto IL_04e6;
		IL_047c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v13+B8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v12+8]");
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v12+8]");
		bool flag7 = (nint)0 == 0;
		object obj17 = !flag7;
		kammelnaResponseModel = kammelnaResponseModel2;
		if (obj17 != null)
		{
			goto IL_03d7;
		}
		goto IL_04e6;
		IL_0128:
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v10+E4]");
		bool flag8 = (nint)0 == 0;
		obj9 = obj7;
		kammelnaResponseModel = kammelnaResponseModel2;
		if (!flag8)
		{
			goto IL_0165;
		}
		goto IL_026a;
		IL_026a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v10+B8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v26+8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v26+8]");
		bool flag9 = (nint)0 == 0;
		kammelnaResponseModel2 = kammelnaResponseModel;
		if (!flag9)
		{
			goto IL_02c9;
		}
		goto IL_04e6;
		IL_0165:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v10+B8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v33+8]");
		obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v33+8]");
		bool flag10 = (nint)0 == 0;
		object obj21 = !flag10;
		if (obj21 != null)
		{
			goto IL_02c9;
		}
		kammelnaResponseModel = kammelnaResponseModel2;
		goto IL_04e6;
		IL_02c9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v8+28]");
		object obj22 = (nint)0 & (nint)1;
		if (obj22 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v10+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D1]");
			object obj23 = (nint)0 & (nint)1;
			if (obj23 != null)
			{
				goto IL_0355;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D1]");
			object obj24 = (nint)0 & (nint)1;
			bool flag11 = obj24 == null;
			object obj25 = !flag11;
			if (obj25 != null)
			{
				goto IL_0355;
			}
		}
		_ = 1;
		obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v22+E4]");
		bool flag12 = (nint)0 == 0;
		object obj26 = !flag12;
		obj11 = obj10;
		if (obj26 != null)
		{
			goto IL_038a;
		}
		goto IL_047c;
	}

	public static void Apply(RemoteConfigModel model)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0139: Expected O, but got I
		//IL_0153: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01c9: Expected O, but got I
		//IL_01d9: Expected O, but got I
		//IL_01fb: Expected O, but got I4
		//IL_0191: Expected O, but got I4
		//IL_00df: Expected O, but got I
		//IL_0101: Expected O, but got I
		//IL_0112: Expected O, but got I
		//IL_00be: Expected O, but got I
		//IL_00ce: Expected O, but got I
		if (model == null)
		{
			return;
		}
		object obj = typeof(RegisteredWaitHandle) + 56;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D1]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				goto IL_0079;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D1]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_0079;
			}
		}
		_ = 1;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v17+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		object obj8 = obj6;
		if (obj7 != null)
		{
			goto IL_00ae;
		}
		goto IL_01a7;
		IL_0079:
		obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v17+E4]");
		bool flag3 = (nint)0 == 0;
		obj8 = obj6;
		if (!flag3)
		{
			goto IL_00ae;
		}
		goto IL_01a7;
		IL_00ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v17+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v17+8]");
		object obj10 = 0;
		goto IL_00d3;
		IL_00d3:
		object obj11 = (nint)0 + (nint)2472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3997724");
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v14+B8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v15+10]");
		Actions.SafeInvoke((Action)0);
		return;
		IL_01a7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v7+B8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v6+8]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v6+8]");
		bool flag4 = (nint)0 == 0;
		object obj16 = !flag4;
		if (obj16 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00d3;
	}

	static RemoteConfig()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0048: Expected O, but got I
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0068: Expected O, but got I
		//IL_0085: Expected I, but got O
		//IL_00c1: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 64;
		object obj2 = typeof(RegisteredWaitHandle) + 56;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)2984;
		object obj5 = typeof(List<Tween>) + 2936;
		object obj6 = (nint)0 + (nint)2448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		RemoteConfigModel remoteConfigModel = default(RemoteConfigModel);
		remoteConfigModel..ctor();
		object obj7 = obj2;
		object obj8 = remoteConfigModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @399769C");
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v4+B8]");
		object obj10 = (nint)0 + (nint)8;
		object obj11 = default(object);
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
