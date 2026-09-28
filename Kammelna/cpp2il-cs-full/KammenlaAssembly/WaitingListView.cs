using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using UnityEngine;
using UnityEngine.InputSystem.UI;

public class WaitingListView : UiGridView<QueueTeam, TeamUi>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<QueuePlayer, int> <>9__0_0;

		public static Func<IEnumerable<QueuePlayer>, int, QueueTeam> <>9__0_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 2480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal int <SetData>b__0_0(QueuePlayer player)
		{
			//IL_0035: Expected I4, but got O
			if (player != null)
			{
				return player.<team>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal QueueTeam <SetData>b__0_1(IEnumerable<QueuePlayer> players, int i)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 2768;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			QueueTeam queueTeam = default(QueueTeam);
			queueTeam..ctor(players, i);
			return queueTeam;
		}
	}

	public void SetData(List<QueuePlayer> waitingPlayers)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0247: Expected O, but got I4
		//IL_03bf: Expected O, but got I
		//IL_03cf: Expected O, but got I
		//IL_03f1: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		//IL_011b: Expected O, but got I
		//IL_014f: Expected O, but got I4
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		//IL_027f: Expected O, but got I
		//IL_0290: Expected I, but got O
		//IL_02ae: Expected O, but got I
		//IL_02f5: Expected O, but got I
		//IL_0305: Expected O, but got I
		//IL_0327: Expected O, but got I4
		//IL_0082: Expected O, but got I
		//IL_01f3: Expected I, but got O
		//IL_0203: Expected O, but got I
		//IL_0213: Expected O, but got I
		//IL_0196: Expected O, but got I4
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected O, but got Unknown
		//IL_035f: Expected O, but got I
		//IL_0370: Expected I, but got O
		//IL_038e: Expected O, but got I
		//IL_01c6: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 2480;
		Func<object, int> func = default(Func<object, int>);
		Func<object, int, object> func2 = default(Func<object, int, object>);
		IEnumerable<object> source3 = default(IEnumerable<object>);
		while (true)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v26+8]");
			Func<object, int> keySelector = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v26+8]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+E4]");
				bool flag3 = (nint)0 == 0;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v32+B8]");
					obj4 = 0;
				}
				object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3000;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj9 = (nint)0 + (nint)3472;
				func..ctor(obj4, (IntPtr)obj9);
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v31+B8]");
				object obj11 = (nint)0 + (nint)8;
				obj11 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				keySelector = func;
			}
			IOrderedEnumerable<object> source = Enumerable.OrderByDescending(waitingPlayers, keySelector);
			List<object> list = Enumerable.ToList(source);
			if (list._size >= 1)
			{
				int num = 0;
				do
				{
					object obj12 = list.get_Item(num);
					num++;
				}
				while (num < list._size);
			}
			object obj13 = (nint)0 + (nint)1904;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C94A28");
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v14+E4]");
			bool flag4 = (nint)0 == 0;
			object obj15 = !flag4;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj14 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v14+B8]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v15+10]");
			Func<object, int, object> selector = (Func<object, int, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v15+10]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v14+E4]");
				bool flag6 = (nint)0 == 0;
				object obj18 = !flag6;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj19 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v21+B8]");
					obj16 = 0;
				}
				object obj20 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 600;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj21 = (nint)0 + (nint)3480;
				func2..ctor(obj16, (IntPtr)obj21);
				object obj22 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v20+B8]");
				object obj23 = (nint)0 + (nint)16;
				obj23 = func2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				selector = func2;
			}
			IEnumerable<object> source2 = Enumerable.Select(source3, selector);
			List<object> list2 = Enumerable.ToList(source2);
			nint num2 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v14 (Il2CppClass<WaitingListView>)+2A8]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v14 (Il2CppClass<WaitingListView>)+2B0]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v267 @ X3_v4 (should have been resolved before IL gen)");
		}
	}

	public WaitingListView()
	{
		((UiGridView<object, object>)(object)this)..ctor();
	}
}
