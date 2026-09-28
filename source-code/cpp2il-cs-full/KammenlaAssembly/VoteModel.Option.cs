using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using UnityEngine.InputSystem.UI;

public class VoteModel
{
	public class Option
	{
		public string Text;

		public int VoteCount;

		public Option()
		{
		}

		public Option(string text, int count)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			object obj = this + 16;
			obj = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Option, int> <>9__3_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 2448;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal int <get_votesSum>b__3_0(Option o)
		{
			//IL_0035: Expected I4, but got O
			if (o != null)
			{
				return o.VoteCount;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public string voteText;

	public Option[] options;

	public int votesSum
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_014c: Expected O, but got I4
			//IL_00a5: Expected O, but got I
			//IL_00b5: Expected O, but got I
			//IL_00c5: Expected O, but got I
			//IL_00e7: Expected O, but got I4
			//IL_018a: Expected O, but got I
			//IL_019a: Expected O, but got I
			//IL_01aa: Expected O, but got I
			//IL_01cc: Expected O, but got I4
			//IL_0214: Expected O, but got I4
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0273: Expected O, but got Unknown
			//IL_0289: Expected O, but got I
			//IL_029a: Expected I, but got O
			//IL_02b8: Expected O, but got I
			//IL_0244: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 2448;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8945]");
			object obj3 = (nint)0 & (nint)1;
			Option[] array;
			Option[] array2;
			object obj4;
			if (obj3 != null)
			{
				array = options;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				array2 = options;
				if (!flag)
				{
					goto IL_0099;
				}
			}
			else
			{
				_ = 1;
				array = options;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				array2 = options;
				if (obj6 != null)
				{
					goto IL_0099;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
			object obj7 = (nint)0 + (nint)768;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			Func<object, int> selector = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			IEnumerable<object> enumerable = array2;
			object obj10 = obj7;
			IEnumerable<object> source = array2;
			if (obj9 == null)
			{
				goto IL_01f2;
			}
			goto IL_0249;
			IL_01f2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj12 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v10+B8]");
				obj8 = 0;
			}
			object obj13 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 568;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)3440;
			Func<object, int> func = default(Func<object, int>);
			func..ctor(obj8, (IntPtr)obj14);
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v9+B8]");
			object obj16 = (nint)0 + (nint)8;
			obj16 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj10 = obj7;
			selector = func;
			source = enumerable;
			goto IL_0249;
			IL_0249:
			return Enumerable.Sum(source, selector);
			IL_0099:
			obj10 = (nint)0 + (nint)768;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			selector = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			source = array;
			if (obj17 == null)
			{
				obj7 = obj10;
				enumerable = array;
				goto IL_01f2;
			}
			goto IL_0249;
		}
	}
}
