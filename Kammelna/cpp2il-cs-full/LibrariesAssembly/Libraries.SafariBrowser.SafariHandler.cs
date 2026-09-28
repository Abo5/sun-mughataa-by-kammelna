using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;

namespace Libraries.SafariBrowser;

public class SafariHandler : MonoBehaviour
{
	private const string GameObjectName = "SafariHandler";

	private static SafariHandler _instance;

	public static event Action OnBrowserClosed
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 2624;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+8]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 2624;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+8]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public static event Action<string> OnCallback
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
			object obj = typeof(RegisteredWaitHandle) + 2624;
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
			object obj = typeof(RegisteredWaitHandle) + 2624;
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

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0140: Expected O, but got I
		//IL_016a: Expected O, but got I4
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2624;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
		object obj4 = 0;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj4 != null;
		GameObject gameObject = base.gameObject;
		if (flag2)
		{
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v9+E4]");
			if ((nint)0 != 0)
			{
				UnityEngine.Object.Destroy(gameObject);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			UnityEngine.Object.Destroy(gameObject);
			return;
		}
		object obj8 = "SERVICE_DISABLED" + 1456;
		gameObject.name = (string)obj8;
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v9+E4]");
		if ((nint)0 != 0)
		{
			UnityEngine.Object.DontDestroyOnLoad(this);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object.DontDestroyOnLoad(this);
	}

	private void OnDoneClicked(string message)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006c: Expected O, but got I
		//IL_007c: Expected O, but got I
		//IL_0029: Expected O, but got I
		//IL_0039: Expected O, but got I
		//IL_0049: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 2624;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v5+18]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v5+40]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v5+28]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v43 @ X2_v1 (should have been resolved before IL gen)");
		}
	}

	private void OnLoaded(string message)
	{
	}

	private void OnCallbackReceived(string link)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006c: Expected O, but got I
		//IL_007c: Expected O, but got I
		//IL_0029: Expected O, but got I
		//IL_0039: Expected O, but got I
		//IL_0049: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 2624;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+10]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5+18]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5+40]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5+28]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v51 @ X3_v1 (should have been resolved before IL gen)");
		}
	}
}
