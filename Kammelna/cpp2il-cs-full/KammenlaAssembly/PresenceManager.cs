using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Kammelna.Server.Models.Presence;
using Server.Coordinator.Models;
using Sfs2X.Entities;
using UnityEngine;

public class PresenceManager : Singleton<PresenceManager>
{
	private static readonly Dictionary<long, PresenceState> States;

	public static event Action OnPresenceChanged
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
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1680;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+8]");
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
				object obj11 = (nint)0 + (nint)8;
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
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1680;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+8]");
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
				object obj11 = (nint)0 + (nint)8;
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

	public static bool IsOnline(long userId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0125: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_019b: Expected I4, but got O
		//IL_015d: Expected O, but got I
		//IL_017f: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1680;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70BC]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v19+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v19+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v5+B8]");
		object obj7 = 0;
		Dictionary<long, object> dictionary = (Dictionary<long, object>)obj7;
		bool flag3 = obj7 == null;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00b1;
		}
		goto IL_018d;
		IL_00b1:
		object value;
		bool result = dictionary.TryGetValue(userId, out value);
		if (value == null)
		{
			result = false;
		}
		return result;
		IL_018d:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v19+B8]");
		object obj9 = 0;
		dictionary = (Dictionary<long, object>)obj9;
		if (obj9 != null)
		{
			goto IL_00b1;
		}
		goto IL_018d;
	}

	public static PresenceState GetState(long userId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_013f: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_0177: Expected O, but got I
		//IL_0199: Expected O, but got I4
		//IL_00e1: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1680;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70BD]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v19+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v19+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v5+B8]");
		object obj7 = 0;
		Dictionary<long, object> dictionary = (Dictionary<long, object>)obj7;
		bool flag3 = obj7 == null;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00b1;
		}
		goto IL_01a7;
		IL_00b1:
		object value;
		bool flag4 = dictionary.TryGetValue(userId, out value);
		bool flag5 = !flag4;
		object obj9 = !flag5;
		object obj10 = ~obj9;
		if (obj10 == null)
		{
			return (PresenceState)value;
		}
		return null;
		IL_01a7:
		return (PresenceState)(object)new NullReferenceException();
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v19+B8]");
		object obj11 = 0;
		dictionary = (Dictionary<long, object>)obj11;
		if (obj11 != null)
		{
			goto IL_00b1;
		}
		goto IL_01a7;
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_022e: Expected O, but got I4
		//IL_0237: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		//IL_0070: Expected O, but got I
		//IL_026f: Expected O, but got I
		//IL_0291: Expected O, but got I4
		//IL_0089: Expected O, but got I
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00a9: Expected O, but got I
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00c9: Expected O, but got I
		//IL_00d5: Expected O, but got I
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00f5: Expected O, but got I
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0115: Expected O, but got I
		//IL_013b: Expected I, but got O
		//IL_0161: Expected I, but got O
		//IL_018c: Expected I, but got O
		//IL_01b2: Expected I, but got O
		//IL_01dd: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1680;
		GameObject target = base.gameObject;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			UnityEngine.Object.DontDestroyOnLoad(target);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v30+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0060;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			UnityEngine.Object.DontDestroyOnLoad(target);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v30+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj5 = 0;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0060;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v8+B8]");
		object obj9 = 0;
		Dictionary<long, object> dictionary = (Dictionary<long, object>)obj9;
		bool flag3 = obj9 == null;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_007d;
		IL_0060:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v30+B8]");
		object obj11 = 0;
		dictionary = (Dictionary<long, object>)obj11;
		goto IL_007d;
		IL_007d:
		object obj12 = (nint)0 + (nint)3296;
		object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj14 = (nint)0 + (nint)2568;
		object obj15 = typeof(SqlSingle[]) + 2376;
		object obj16 = (nint)0 + (nint)2576;
		object obj17 = (nint)0 + (nint)2560;
		object obj18 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 528;
		object obj19 = (nint)0 + (nint)2584;
		object obj20 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1544;
		object obj21 = (nint)0 + (nint)2552;
		dictionary.Clear();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj14);
		SFS.OnJoinRoom += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj16);
		SFS.OnLogout += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj17);
		CoordinatorService.OnConnected += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<long, object> action4 = default(Action<long, object>);
		action4..ctor((object)this, (IntPtr)obj19);
		CoordinatorService.OnPresenceUpdated += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action5 = default(Action<object>);
		action5..ctor((object)this, (IntPtr)obj21);
		CoordinatorService.OnClanMembershipChanged += action5;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004c: Expected O, but got I
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_006c: Expected O, but got I
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_014c: Expected I, but got O
		//IL_009d: Expected I, but got O
		//IL_00c8: Expected I, but got O
		//IL_00ee: Expected I, but got O
		//IL_0117: Expected O, but got I
		//IL_0125: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj2 = (nint)0 + (nint)2568;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)2576;
		object obj5 = (nint)0 + (nint)2560;
		object obj6 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 528;
		object obj7 = (nint)0 + (nint)2584;
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnJoinRoom -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj4);
		SFS.OnLogout -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj5);
		CoordinatorService.OnConnected -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<long, object> action4 = default(Action<long, object>);
		action4..ctor((object)this, (IntPtr)obj7);
		CoordinatorService.OnPresenceUpdated -= action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = (nint)0 + (nint)2552;
		Action<object> action5 = default(Action<object>);
		action5..ctor((object)this, (IntPtr)obj9);
		CoordinatorService.OnClanMembershipChanged -= action5;
	}

	private void OnPresenceUpdated(long userId, PresenceState state)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0146: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_00ae: Expected O, but got I
		//IL_00d7: Expected O, but got I
		//IL_00e7: Expected O, but got I
		//IL_017e: Expected O, but got I
		//IL_01a0: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1680;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70C0]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_0116;
		}
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v17+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = obj4;
		if (!flag)
		{
			goto IL_0085;
		}
		goto IL_015c;
		IL_0116:
		_ = 1;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v17+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		obj5 = obj4;
		if (obj6 != null)
		{
			goto IL_0085;
		}
		goto IL_015c;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v17+B8]");
		object obj7 = 0;
		Dictionary<long, object> dictionary = (Dictionary<long, object>)obj7;
		goto IL_00a2;
		IL_00a2:
		object obj8 = (nint)0 + (nint)3320;
		dictionary.set_Item(userId, (object)state);
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v11+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v12+8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v12+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v80 @ X8_v13+18] (should have been resolved before IL gen)");
			goto IL_0116;
		}
		return;
		IL_015c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v6+B8]");
		object obj13 = 0;
		dictionary = (Dictionary<long, object>)obj13;
		bool flag3 = obj13 == null;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a2;
	}

	private static void ClearStates()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f1: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		//IL_0142: Expected O, but got I
		//IL_0129: Expected O, but got I
		//IL_0196: Expected O, but got I4
		//IL_0264: Expected O, but got I
		//IL_01dd: Expected O, but got I
		//IL_01ed: Expected O, but got I
		//IL_0222: Expected O, but got I
		//IL_0232: Expected O, but got I
		//IL_0242: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1680;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70C1]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v26+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v26+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v14+B8]");
		object obj7 = 0;
		Dictionary<long, object> dictionary = (Dictionary<long, object>)obj7;
		goto IL_0136;
		IL_0136:
		object obj8 = (nint)0 + (nint)3312;
		if (dictionary.Count != 0)
		{
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v7+B8]");
			object obj11 = 0;
			((Dictionary<long, object>)obj11).Clear();
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v11+B8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v12+8]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v12+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v13+18]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v13+40]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v13+28]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v97 @ X2_v1 (should have been resolved before IL gen)");
			}
		}
		return;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v26+B8]");
		object obj18 = 0;
		dictionary = (Dictionary<long, object>)obj18;
		bool flag4 = obj18 == null;
		object obj19 = !flag4;
		if (obj19 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0136;
	}

	private void OnClanMembershipChanged(ClanMembershipChanged change)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		object obj = (??)change.ClanId & 1;
		if (obj == null)
		{
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1680;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				ClearStates();
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			ClearStates();
		}
	}

	private void OnLogout()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00b2: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1680;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70C3]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v7+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ClearStates();
		return;
		IL_007c:
		ClearStates();
	}

	private void OnJoinRoom(Room room)
	{
		Publish(room);
	}

	private void OnCoordinatorConnected()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0073: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1680;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ClearStates();
		Room lastJoinedRoom = SFS.LastJoinedRoom;
		((PresenceManager)lastJoinedRoom).Publish(lastJoinedRoom);
	}

	private void Publish(Room room)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0111: Expected O, but got I4
		//IL_0165: Expected O, but got I4
		if (room == null)
		{
			return;
		}
		object obj = typeof(Queue<string>) + 736;
		object obj2 = (nint)0 + (nint)1992;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1680;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		CoordinatorService coordinatorService;
		CoordinatorService coordinatorService3;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			CoordinatorService coordinatorService2 = default(CoordinatorService);
			coordinatorService = coordinatorService2;
			coordinatorService3 = coordinatorService2;
			if (!flag)
			{
				goto IL_00ad;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			CoordinatorService coordinatorService4 = default(CoordinatorService);
			coordinatorService = coordinatorService4;
			coordinatorService3 = coordinatorService4;
			if (obj6 != null)
			{
				goto IL_00ad;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PresenceState presence = BuildPresenceState(room);
		bool flag3 = (object)coordinatorService3 == null;
		object obj7 = !flag3;
		coordinatorService = coordinatorService3;
		if (obj7 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00bf;
		IL_00bf:
		coordinatorService.SetPresence(presence);
		return;
		IL_00ad:
		presence = BuildPresenceState(room);
		goto IL_00bf;
	}

	private static PresenceState BuildPresenceState(Room room)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0852: Unknown result type (might be due to invalid IL or missing references)
		//IL_0857: Expected O, but got Unknown
		//IL_0881: Expected O, but got I4
		//IL_004b: Expected O, but got I4
		//IL_01a3: Expected O, but got I
		//IL_01bd: Expected O, but got I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_0099: Expected O, but got I
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_020f: Expected O, but got I4
		//IL_026f: Expected O, but got I4
		//IL_0170: Expected O, but got I4
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected O, but got Unknown
		//IL_02e6: Expected I, but got O
		//IL_02f6: Expected O, but got I
		//IL_038c: Expected O, but got I
		//IL_03ae: Expected O, but got I4
		//IL_0331: Expected O, but got I
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Expected O, but got Unknown
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected O, but got Unknown
		//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Expected O, but got Unknown
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Expected O, but got Unknown
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected O, but got Unknown
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected O, but got Unknown
		//IL_0545: Expected O, but got I
		//IL_0569: Expected O, but got I4
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected O, but got Unknown
		//IL_0439: Expected O, but got I
		//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Expected O, but got Unknown
		//IL_0468: Expected I, but got O
		//IL_0478: Expected O, but got I
		//IL_06f8: Expected I, but got O
		//IL_0708: Expected O, but got I
		//IL_0810: Expected O, but got I4
		//IL_0507: Expected O, but got I4
		//IL_0797: Expected O, but got I4
		//IL_094d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0952: Expected O, but got Unknown
		//IL_063f: Expected O, but got I
		//IL_091a: Expected O, but got I
		//IL_04b3: Expected O, but got I
		//IL_09a6: Expected O, but got I
		//IL_0743: Expected O, but got I
		//IL_09ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f2: Expected O, but got Unknown
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a9: Expected O, but got Unknown
		//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b7: Expected O, but got Unknown
		//IL_081d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0822: Expected O, but got Unknown
		//IL_082b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Expected O, but got Unknown
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected O, but got Unknown
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected O, but got Unknown
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected O, but got Unknown
		//IL_075f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		bool flag2 = currentGame < (Games)3;
		object obj5 = !flag2;
		object obj6 = ~obj5;
		GameCategory game = (GameCategory)((obj6 != null) ? (currentGame + 1) : Games.Baloot);
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E721A]");
			object obj8 = (nint)0 & (nint)1;
			if (obj8 != null)
			{
				goto IL_00b6;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E721A]");
			object obj9 = (nint)0 & (nint)1;
			bool flag3 = obj9 == null;
			object obj10 = !flag3;
			if (obj10 != null)
			{
				goto IL_00b6;
			}
		}
		_ = 1;
		object obj11 = typeof(DataRelation) + 712;
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v72+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		object obj14 = obj11;
		object obj15 = obj12;
		if (obj13 != null)
		{
			goto IL_0107;
		}
		goto IL_022d;
		IL_09e4:
		PresenceState presenceState;
		object obj16 = presenceState + 64;
		string text;
		obj16 = text;
		goto IL_09d0;
		IL_09d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return presenceState;
		IL_03bc:
		object obj17 = typeof(System.Buffers.Text.ParserHelpers) + 1688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PresenceState presenceState2 = default(PresenceState);
		presenceState2..ctor();
		if (presenceState2 == null)
		{
			goto IL_0835;
		}
		presenceState2.Kind = PresenceKind.InGame;
		presenceState2.Game = game;
		GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room);
		object obj18 = (nint)0 + (nint)2704;
		object obj19 = obj18;
		System.Int32Enum? gameType2 = (System.Int32Enum)gameType;
		presenceState2.GameType = (GameType?)gameType2;
		nint num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v34 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v34 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_04f4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v34 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj21 = (nint)0 + (nint)8;
		object obj22;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X10_v16-8]");
			if (0 == (nint)obj22)
			{
				break;
			}
			obj21 += 16;
			obj20--;
			if ((nint)obj20 != 1)
			{
				continue;
			}
			goto IL_04f4;
		}
		object obj23 = num + obj21;
		object obj24 = obj23 + 312;
		goto IL_0904;
		IL_057f:
		PresenceState presenceState4 = default(PresenceState);
		object obj27;
		if (SFSKammelnaRoomExtensions.IsMassTournament(room))
		{
			object obj25 = typeof(System.Buffers.Text.ParserHelpers) + 1688;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			PresenceState presenceState3 = default(PresenceState);
			presenceState3..ctor();
			if (presenceState3 != null)
			{
				presenceState3.Kind = PresenceKind.InMassTournament;
				presenceState3.Game = game;
				MassTournamentInfo massTournamentInfo = SFSKammelnaRoomExtensions.GetMassTournamentInfo(room);
				if (massTournamentInfo != null)
				{
					object obj26 = (nint)0 + (nint)3184;
					obj27 = obj26;
					long? num2 = massTournamentInfo.<Id>k__BackingField;
					long? num3 = num2;
				}
				else
				{
					long? num3 = (long?)(object)0;
				}
				obj16 = presenceState3 + 64;
				obj16 = text;
				presenceState = presenceState3;
				goto IL_09d0;
			}
		}
		else
		{
			bool flag5 = SFSKammelnaRoomExtensions.IsTournamentHub(room);
			object obj28 = typeof(System.Buffers.Text.ParserHelpers) + 1688;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			presenceState4..ctor();
			if (flag5)
			{
				if (presenceState4 != null)
				{
					presenceState4.Kind = PresenceKind.InTournament;
					presenceState4.Game = game;
					nint num4 = (nint)room;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					object obj29 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0784;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
					object obj30 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X10_v9-8]");
						if (0 == (nint)obj22)
						{
							break;
						}
						obj30 += 16;
						obj29--;
						if ((nint)obj29 != 1)
						{
							continue;
						}
						goto IL_0784;
					}
					object obj31 = num4 + obj30;
					object obj32 = obj31 + 312;
					goto IL_0990;
				}
			}
			else if (presenceState4 != null)
			{
				obj16 = presenceState4 + 64;
				obj16 = text;
				_ = 0;
				presenceState = presenceState4;
				goto IL_09d0;
			}
		}
		goto IL_0835;
		IL_0372:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X0_v49+8]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v284 @ X0_v49] (should have been resolved before IL gen)");
		object obj34 = default(object);
		bool flag6 = obj34 == null;
		obj27 = 6;
		if (!flag6)
		{
			goto IL_03bc;
		}
		goto IL_057f;
		IL_04f4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj19 = 0;
		goto IL_0904;
		IL_0904:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v518 @ X0_v41] (should have been resolved before IL gen)");
		object obj35 = (nint)0 + (nint)3136;
		obj27 = obj35;
		int value = default(int);
		int? num5 = value;
		presenceState = presenceState2;
		int? num6 = num5;
		goto IL_09e4;
		IL_0835:
		return (PresenceState)(object)new NullReferenceException();
		IL_00b6:
		obj11 = typeof(DataRelation) + 712;
		obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v72+E4]");
		bool flag7 = (nint)0 == 0;
		obj14 = obj11;
		obj15 = obj12;
		if (!flag7)
		{
			goto IL_0107;
		}
		goto IL_022d;
		IL_022d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		string currentServerId = Config.GetCurrentServerId();
		object obj36 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v55+E4]");
		bool flag8 = (nint)0 == 0;
		object obj37 = !flag8;
		text = currentServerId;
		string text2 = currentServerId;
		if (obj37 != null)
		{
			goto IL_014d;
		}
		goto IL_028d;
		IL_0107:
		string currentServerId2 = Config.GetCurrentServerId();
		obj36 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v55+E4]");
		bool flag9 = (nint)0 == 0;
		text = currentServerId2;
		text2 = currentServerId2;
		if (!flag9)
		{
			goto IL_014d;
		}
		goto IL_028d;
		IL_028d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		DateTime utcNow = DateTime.UtcNow;
		bool flag10 = room == null;
		text = text2;
		if (!flag10)
		{
			goto IL_02ca;
		}
		goto IL_0835;
		IL_014d:
		utcNow = DateTime.UtcNow;
		bool flag11 = room == null;
		object obj38 = !flag11;
		if (obj38 != null)
		{
			goto IL_02ca;
		}
		goto IL_0835;
		IL_02ca:
		obj22 = typeof(RegisteredWaitHandle) + 1376;
		nint num7 = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0372;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj40 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X10_v21-8]");
			if (0 == (nint)obj22)
			{
				break;
			}
			obj40 += 16;
			obj39--;
			if ((nint)obj39 != 1)
			{
				continue;
			}
			goto IL_0372;
		}
		object obj41 = obj40 + 6;
		object obj42 = num7 + obj41;
		object obj43 = obj42 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v52+8]");
		obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v384 @ X0_v52] (should have been resolved before IL gen)");
		object obj44 = default(object);
		bool flag12 = obj44 == null;
		object obj45 = !flag12;
		object obj46 = default(object);
		obj27 = obj46;
		if (obj45 != null)
		{
			goto IL_03bc;
		}
		goto IL_057f;
		IL_0784:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj27 = 0;
		goto IL_0990;
		IL_0990:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v648 @ X0_v22] (should have been resolved before IL gen)");
		object obj47 = (nint)0 + (nint)3136;
		obj27 = obj47;
		int value2 = default(int);
		int? num8 = value2;
		presenceState = presenceState4;
		num6 = num8;
		goto IL_09e4;
	}

	public PresenceManager()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ae: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_005c: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 800;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70C6]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2112;
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
			object obj4 = (nint)0 + (nint)2112;
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

	static PresenceManager()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 1600;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1680;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<long, object> dictionary = default(Dictionary<long, object>);
		dictionary..ctor();
		object obj3 = obj2;
		object obj4 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
