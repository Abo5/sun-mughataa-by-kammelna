using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
	private static HashSet<Action> callbacks;

	public static event Action OnSaving
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00dc: Expected O, but got I4
			//IL_008c: Expected O, but got I
			//IL_0114: Expected O, but got I
			//IL_0136: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 2776;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D23]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v16+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v16+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v5+B8]");
			object obj7 = 0;
			HashSet<object> hashSet = (HashSet<object>)obj7;
			bool flag3 = obj7 == null;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_0099;
			IL_007c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v16+B8]");
			object obj9 = 0;
			hashSet = (HashSet<object>)obj9;
			goto IL_0099;
			IL_0099:
			bool flag4 = hashSet.Add(value);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00dc: Expected O, but got I4
			//IL_008c: Expected O, but got I
			//IL_0114: Expected O, but got I
			//IL_0136: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 2776;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D24]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v16+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v16+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v5+B8]");
			object obj7 = 0;
			HashSet<object> hashSet = (HashSet<object>)obj7;
			bool flag3 = obj7 == null;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_0099;
			IL_007c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v16+B8]");
			object obj9 = 0;
			hashSet = (HashSet<object>)obj9;
			goto IL_0099;
			IL_0099:
			bool flag4 = hashSet.Remove(value);
		}
	}

	private void Awake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e1: Expected O, but got I4
		//IL_00f2: Expected O, but got I4
		//IL_008a: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D25]");
		object obj3 = (nint)0 & (nint)1;
		GameObject gameObject;
		UnityEngine.Object target;
		if (obj3 != null)
		{
			gameObject = base.gameObject;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v2+E4]");
			bool flag = (nint)0 == 0;
			target = gameObject;
			object obj5 = 0;
			if (!flag)
			{
				goto IL_0098;
			}
		}
		else
		{
			_ = 1;
			gameObject = base.gameObject;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			target = gameObject;
			object obj5 = 0;
			if (obj6 != null)
			{
				goto IL_0098;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		return;
		IL_0098:
		UnityEngine.Object.DontDestroyOnLoad(target);
	}

	private void OnApplicationPause(bool pauseStatus)
	{
		if (pauseStatus)
		{
			TriggerCallbacks();
		}
	}

	private void OnApplicationFocus(bool hasFocus)
	{
		if (!hasFocus)
		{
			TriggerCallbacks();
		}
	}

	private void OnApplicationQuit()
	{
		TriggerCallbacks();
	}

	private void TriggerCallbacks()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_013a: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_0172: Expected O, but got I
		//IL_0194: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(RegisteredWaitHandle) + 2776;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D26]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v48+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v48+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v21+B8]");
		object obj8 = 0;
		HashSet<object> hashSet = (HashSet<object>)obj8;
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		if (obj9 != null)
		{
			goto IL_00ba;
		}
		goto IL_01a2;
		IL_00ba:
		HashSet<object>.Enumerator enumerator = hashSet.GetEnumerator();
		HashSet<object>.Enumerator enumerator2 = default(HashSet<object>.Enumerator);
		object obj10 = default(object);
		while (enumerator2.MoveNext())
		{
			if (obj10 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v89 @ stack_-68+18] (should have been resolved before IL gen)");
			}
		}
		enumerator2.Dispose();
		return;
		IL_01a2:
		throw new NullReferenceException();
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v48+B8]");
		object obj11 = 0;
		hashSet = (HashSet<object>)obj11;
		if (obj11 != null)
		{
			goto IL_00ba;
		}
		goto IL_01a2;
	}

	static SaveManager()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 1408;
		object obj2 = typeof(RegisteredWaitHandle) + 2776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		HashSet<object> hashSet = default(HashSet<object>);
		hashSet..ctor();
		object obj3 = obj2;
		object obj4 = hashSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
