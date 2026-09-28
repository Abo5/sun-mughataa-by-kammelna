using System;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using Cpp2ILInjected;

namespace Util.Extensions;

public static class TaskExtensions
{
	private sealed class <>c__DisplayClass0_0<T>
	{
		public Action<Task<T>> continuationAction;

		internal void <ContinueInMainThread>b__0(Task<T> t)
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_01bb: Expected O, but got I
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c9: Expected O, but got Unknown
			//IL_01e3: Expected O, but got I4
			//IL_0058: Expected O, but got I
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected O, but got Unknown
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected O, but got Unknown
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Expected O, but got Unknown
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Expected O, but got Unknown
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Expected O, but got Unknown
			//IL_0235: Expected O, but got I4
			//IL_0172: Expected O, but got I4
			object obj = 152961024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E0C92]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				nint num = 0;
				IntPtr intPtr = num;
				object obj3 = num + 309;
				object obj4 = obj3 & 1;
				bool flag = obj4 == null;
				IntPtr intPtr2 = num;
				if (!flag)
				{
					goto IL_008b;
				}
			}
			else
			{
				_ = 1;
				nint num2 = 0;
				IntPtr intPtr = num2;
				object obj5 = num2 + 309;
				object obj6 = obj5 & 1;
				bool flag2 = obj6 == null;
				object obj7 = !flag2;
				IntPtr intPtr2 = num2;
				if (obj7 != null)
				{
					goto IL_008b;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj8 = default(object);
			obj8..ctor();
			bool flag3 = obj8 == null;
			object obj9 = !flag3;
			object obj10 = obj8;
			if (obj9 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_00b0;
			IL_008b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = default(object);
			obj11..ctor();
			obj10 = obj11;
			goto IL_00b0;
			IL_00b0:
			object obj12 = typeof(SqlSingle[]) + 2376;
			object obj13 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj14 = obj10 + 24;
			obj14 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj15 = obj10 + 16;
			obj15 = t;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			nint num3 = 0;
			object obj16 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v11 (Il2CppRgctx<Util.Extensions.TaskExtensions+<>c__DisplayClass0_0`1>)+20]");
			Action action = default(Action);
			action..ctor(obj16, (IntPtr)0);
			object obj17 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v22+E4]");
			bool flag4 = (nint)0 == 0;
			object obj18 = !flag4;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CoroutineDummy.WaitForMainThread(action);
		}
	}

	private sealed class <>c__DisplayClass0_1<T>
	{
		public Task<T> t;

		public <>c__DisplayClass0_0<T> CS$<>8__locals1;

		internal void <ContinueInMainThread>b__1()
		{
			//IL_003b: Expected O, but got I
			//IL_004b: Expected O, but got I
			//IL_005b: Expected O, but got I
			<>c__DisplayClass0_0<T> cS$<>8__locals = CS$<>8__locals1;
			Action<Task<T>> continuationAction = cS$<>8__locals.continuationAction;
			Task<T> task = t;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X8_v3 (System.Action`1<System.Threading.Tasks.Task`1<T>>)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X8_v3 (System.Action`1<System.Threading.Tasks.Task`1<T>>)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X8_v3 (System.Action`1<System.Threading.Tasks.Task`1<T>>)+28]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v30 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	public unsafe static void ContinueInMainThread<T>(Task<T> task, Action<Task<T>> continuationAction)
	{
		//IL_0011: Expected O, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_0148: Expected O, but got I
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0170: Expected O, but got I4
		//IL_007a: Expected O, but got I4
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		nint num = 0;
		nint num2 = 0;
		object obj4;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			<>c__DisplayClass0_0<T> <>c__DisplayClass0_ = default(<>c__DisplayClass0_0<T>);
			<>c__DisplayClass0_..ctor();
			bool flag2 = <>c__DisplayClass0_ == null;
			object obj3 = !flag2;
			obj4 = <>c__DisplayClass0_;
			if (obj3 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			<>c__DisplayClass0_0<T> <>c__DisplayClass0_2 = default(<>c__DisplayClass0_0<T>);
			<>c__DisplayClass0_2..ctor();
			obj4 = <>c__DisplayClass0_2;
		}
		object obj5 = obj4 + 16;
		obj5 = continuationAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = (nint)0 + (nint)309;
		object obj7 = obj6 & 1;
		bool flag3 = obj7 == null;
		object obj8 = !flag3;
		nint num3 = 0;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj4, (IntPtr)(nint)__ldftn(<>c__DisplayClass0_0<T>.<ContinueInMainThread>b__0));
		Task task2 = ((Task<object>)(object)task).ContinueWith((Action<Task<object>>)action);
	}
}
