using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Cpp2ILInjected;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Server.Models;
using UnityEngine;
using UnityEngine.InputSystem.UI;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public class UserFeedListener : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<UserFeedItem, bool> <>9__3_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 1512;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <OnFeedsReceived>b__3_0(UserFeedItem f)
		{
			//IL_0065: Expected I4, but got O
			if (f != null)
			{
				if (f.<IsSeen>k__BackingField)
				{
					return false;
				}
				return f.ForcedPreview;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass3_0
	{
		public UserFeedItem feedItem;

		public UserFeedListener <>4__this;

		internal void <OnFeedsReceived>b__1()
		{
			UserFeedListener userFeedListener = <>4__this;
			userFeedListener.eventsChannel.TriggerMarkFeedSeen(feedItem);
		}
	}

	private UserFeedEventsChannel eventsChannel;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_00f3: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_007e: Expected O, but got I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00ca: Expected O, but got I
		//IL_0113: Expected I, but got O
		//IL_0128: Expected O, but got I
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 288;
		object obj2 = (nint)0 + (nint)4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = typeof(Queue<string>) + 888;
		object obj4 = (nint)0 + (nint)2272;
		eventsChannel.OnFeedsReceived += action;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj7 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 96;
		object obj8 = (nint)0 + (nint)4072;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		object obj9 = default(object);
		func..ctor(obj9, (IntPtr)obj8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v10 (System.Object)+28]");
		IEnumerable<object> feeds = Enumerable.Where((IEnumerable<object>)0, func);
		OnFeedsReceived((IEnumerable<UserFeedItem>)feeds);
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 288;
		object obj2 = (nint)0 + (nint)4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		eventsChannel.OnFeedsReceived -= action;
	}

	private unsafe void OnFeedsReceived(IEnumerable<UserFeedItem> feeds)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0283: Expected O, but got I4
		//IL_028c: Expected O, but got I4
		//IL_029d: Expected O, but got I4
		//IL_00a3: Expected O, but got I
		//IL_00c3: Expected O, but got I
		//IL_0078: Expected O, but got I4
		//IL_0089: Expected O, but got I4
		//IL_034b: Expected O, but got I4
		//IL_02c9: Expected O, but got I
		//IL_02e9: Expected O, but got I
		//IL_030b: Expected O, but got I4
		//IL_0b52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b57: Expected O, but got Unknown
		//IL_0b6d: Expected O, but got I
		//IL_0b7e: Expected I, but got O
		//IL_0b7e: Expected O, but got I
		//IL_0b86: Expected I, but got O
		//IL_0b9c: Expected O, but got I
		//IL_0100: Expected I, but got O
		//IL_0131: Expected I, but got O
		//IL_0388: Expected I, but got O
		//IL_03b3: Expected O, but got I4
		//IL_03bc: Expected O, but got I4
		//IL_03ce: Expected O, but got I4
		//IL_03d6: Expected I, but got O
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_0163: Expected I, but got O
		//IL_0173: Expected O, but got I
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected O, but got Unknown
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected O, but got Unknown
		//IL_0ab2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab7: Expected O, but got Unknown
		//IL_0ac6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acb: Expected O, but got Unknown
		//IL_0ada: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adf: Expected O, but got Unknown
		//IL_0aee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af3: Expected O, but got Unknown
		//IL_0aff: Expected O, but got I
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Expected O, but got Unknown
		//IL_0b2b: Expected O, but got I
		//IL_01ae: Expected O, but got I
		//IL_0a33: Expected O, but got I
		//IL_0a45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4a: Expected O, but got Unknown
		//IL_0432: Expected I, but got O
		//IL_0442: Expected O, but got I
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_0c0b: Expected I, but got O
		//IL_0c1b: Expected O, but got I
		//IL_0c2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c33: Expected O, but got Unknown
		//IL_048d: Expected O, but got I
		//IL_07c5: Expected O, but got I4
		//IL_07ce: Expected O, but got I4
		//IL_0bc3: Expected O, but got I
		//IL_0bd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bda: Expected O, but got Unknown
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected O, but got Unknown
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected O, but got Unknown
		//IL_0d26: Expected O, but got I4
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected O, but got Unknown
		//IL_04be: Expected O, but got I
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected O, but got Unknown
		//IL_07db: Expected I, but got O
		//IL_07eb: Expected O, but got I
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Expected O, but got Unknown
		//IL_0d98: Expected I, but got O
		//IL_0da8: Expected O, but got I
		//IL_0826: Expected O, but got I
		//IL_0d6c: Expected O, but got I
		//IL_05e1: Expected I, but got O
		//IL_05f1: Expected O, but got I
		//IL_089f: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a4: Expected O, but got Unknown
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Expected O, but got Unknown
		//IL_0834: Unknown result type (might be due to invalid IL or missing references)
		//IL_0839: Expected O, but got Unknown
		//IL_084f: Expected O, but got I
		//IL_0cb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb8: Expected O, but got Unknown
		//IL_0cd2: Expected I, but got O
		//IL_062c: Expected O, but got I
		//IL_0c60: Expected O, but got I
		//IL_0c72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c77: Expected O, but got Unknown
		//IL_0731: Expected O, but got I
		//IL_0743: Expected I, but got O
		//IL_0754: Expected I, but got O
		//IL_06e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Expected O, but got Unknown
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fc: Expected O, but got Unknown
		//IL_070c: Expected O, but got I
		//IL_0761: Expected I, but got O
		//IL_0771: Expected O, but got I
		//IL_079f: Expected O, but got I4
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Expected O, but got Unknown
		//IL_065d: Expected O, but got I
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_066d: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 1512;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F27]");
		object obj3 = (nint)0 & (nint)1;
		object obj5;
		object obj4;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v55+E4]");
			bool flag = (nint)0 == 0;
			obj5 = 0;
			object obj6 = obj4;
			obj5 = 0;
			if (!flag)
			{
				goto IL_0097;
			}
		}
		else
		{
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v55+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = 0;
			object obj6 = obj4;
			obj5 = 0;
			if (obj7 != null)
			{
				goto IL_0097;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj8 = (nint)0 + (nint)3856;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v55+B8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v24 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+8]");
		Func<object, bool> func = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v24 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj8;
		nint num2 = num;
		if (obj9 != null)
		{
			goto IL_00f8;
		}
		goto IL_0329;
		IL_0aa3:
		object obj11 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj12 = typeof(TrackedDeviceRaycaster.<>c) + 1520;
		object obj13 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1320;
		object obj14 = typeof(SqlSingle[]) + 2376;
		object obj15 = (nint)0 + (nint)2256;
		object obj16 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		object obj18;
		object obj17 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v2+8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v280 @ X8_v2] (should have been resolved before IL gen)");
		nint num3 = (nint)(&obj5);
		Func<object, bool> func2 = default(Func<object, bool>);
		object obj20;
		object obj21;
		object obj22 = default(object);
		object obj23;
		object obj24 = default(object);
		bool flag6 = default(bool);
		object obj28 = default(object);
		nint num6;
		nint num7;
		object obj29;
		object obj31 = default(object);
		object obj32 = default(object);
		object obj40;
		object obj41 = default(object);
		Action action = default(Action);
		object obj42 = default(object);
		while (true)
		{
			nint num5;
			if (func2 != null)
			{
				nint num4 = (nint)func2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v13 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
				obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v13 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
				bool flag4 = (nint)0 == 0;
				obj21 = obj22;
				obj23 = obj24;
				if (flag4)
				{
					goto IL_0512;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v13 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+B0]");
				object obj25 = (nint)0 + (nint)8;
				bool flag5 = flag6;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X10_v23-8]");
					obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X10_v23-8]");
					object obj26 = 0 - obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X10_v23-8]");
					if (0 == (nint)obj11)
					{
						break;
					}
					obj23 = obj25 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v13 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
					obj20 = -1;
					obj26 = obj20 - 1;
					bool flag7 = obj26 == null;
					flag6 = (nint)obj20 != 1;
					flag5 = flag6;
					obj25 = obj23;
					if (flag6)
					{
						continue;
					}
					goto IL_0512;
				}
				obj20 = obj25;
				object obj27 = num4 + obj25;
				obj28 = obj27 + 312;
				flag6 = flag5;
				obj23 = obj25;
				num5 = num6;
				goto IL_0c03;
			}
			throw new NullReferenceException();
			IL_0512:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num5 = 0;
			goto IL_0c03;
			IL_0c03:
			num7 = (nint)obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X0_v24+8]");
			obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v475 @ X0_v24] (should have been resolved before IL gen)");
			object obj30 = obj31 & 1;
			object obj35;
			object obj38;
			nint num9;
			if (obj30 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj32..ctor();
				if (obj32 != null)
				{
					object obj33 = obj32 + 24;
					obj33 = this;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					if (func2 != null)
					{
						nint num8 = (nint)func2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X8_v16 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
						object obj34 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X8_v16 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_06b1;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X8_v16 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+B0]");
						obj35 = (nint)0 + (nint)8;
						bool flag8 = flag6;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X10_v3-8]");
							obj21 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X10_v3-8]");
							object obj26 = 0 - obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X10_v3-8]");
							if (0 == (nint)obj13)
							{
								break;
							}
							obj23 = obj35 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X8_v16 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
							obj34 = -1;
							obj26 = obj34 - 1;
							bool flag7 = obj26 == null;
							flag6 = (nint)obj34 != 1;
							flag8 = flag6;
							obj35 = obj23;
							if (flag6)
							{
								continue;
							}
							goto IL_06b1;
						}
						obj34 = obj35;
						object obj36 = num8 + obj35;
						object obj37 = obj36 + 312;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X10_v3-8]");
						obj38 = 0;
						flag6 = flag8;
						num9 = num5;
						goto IL_0ca0;
					}
					throw new NullReferenceException();
				}
				throw new NullReferenceException();
			}
			object obj39 = 0;
			obj40 = 0;
			break;
			IL_06b1:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj38 = obj21;
			obj35 = obj23;
			num9 = 0;
			goto IL_0ca0;
			IL_0ca0:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v757 @ X0_v34] (should have been resolved before IL gen)");
			Func<object, bool> func3 = (Func<object, bool>)(obj32 + 16);
			func3 = (Func<object, bool>)obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			nint num10 = (nint)func3;
			if (func3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v5 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+30]");
				Func<object, bool> func4 = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				num5 = (nint)obj15;
				action..ctor(obj32, (IntPtr)obj15);
				num3 = (nint)func4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v4 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+1B8]");
				obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v4 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+1C0]");
				num6 = 0;
				MethodInfo methodImpl = ((MulticastDelegate)func4).GetMethodImpl();
				obj22 = obj38;
				obj42 = 0;
				obj24 = obj35;
				obj19 = action;
				func = func4;
				continue;
			}
			throw new NullReferenceException();
		}
		object obj45 = default(object);
		object obj47 = default(object);
		while (true)
		{
			if (func2 == null)
			{
				goto IL_0d0c;
			}
			nint num11 = (nint)func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v8 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
			obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v8 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0877;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v8 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+B0]");
			object obj43 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X10_v10-8]");
				obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X10_v10-8]");
				if (0 == (nint)obj16)
				{
					break;
				}
				obj23 = obj43 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v8 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
				obj20 = -1;
				bool flag9 = (nint)obj20 != 1;
				obj43 = obj23;
				if (flag9)
				{
					continue;
				}
				goto IL_0877;
			}
			obj20 = obj43;
			object obj44 = num11 + obj43;
			obj45 = obj44 + 312;
			obj23 = obj43;
			goto IL_0d90;
			IL_0d0c:
			bool flag10 = obj40 == null;
			object obj46 = !flag10;
			object obj38 = obj21;
			object obj35 = obj23;
			object obj34 = obj20;
			nint num10 = num7;
			Func<object, bool> func4 = func;
			if (obj46 == null)
			{
				return;
			}
			OutOfMemoryException ex = new OutOfMemoryException();
			if ((nint)obj29 != 1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			obj40 = obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj21 = obj38;
			object obj39 = obj47;
			obj23 = obj35;
			obj20 = obj34;
			num7 = num10;
			func = func4;
			continue;
			IL_0877:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			nint num5 = 0;
			goto IL_0d90;
			IL_0d90:
			num7 = (nint)obj45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X0_v16+8]");
			obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v700 @ X0_v16] (should have been resolved before IL gen)");
			goto IL_0d0c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0147:
		object obj48 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3856;
		IEnumerable<object> enumerable;
		num = (nint)enumerable;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v24 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v24 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_022b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v24 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
		object obj50 = (nint)0 + (nint)8;
		bool flag11 = flag6;
		object obj51;
		nint num12;
		Func<object, bool> func5;
		NullReferenceException ex2;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X10_v30-8]");
			obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X10_v30-8]");
			object obj26 = 0 - obj48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X10_v30-8]");
			bool flag7 = 0 == (nint)obj48;
			obj51 = obj42;
			flag6 = flag11;
			obj24 = obj50;
			num6 = num12;
			ex2 = (NullReferenceException)enumerable;
			func5 = func;
			if (flag7)
			{
				break;
			}
			obj24 = obj50 + 16;
			obj49--;
			obj26 = obj49 - 1;
			flag7 = obj26 == null;
			flag6 = (nint)obj49 != 1;
			flag11 = flag6;
			obj50 = obj24;
			if (flag6)
			{
				continue;
			}
			goto IL_022b;
		}
		goto IL_03fa;
		IL_03ec:
		ex2 = new NullReferenceException();
		goto IL_03fa;
		IL_0097:
		obj8 = (nint)0 + (nint)3856;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v55+B8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v24 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+8]");
		func = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v24 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+8]");
		bool flag12 = (nint)0 == 0;
		obj10 = obj8;
		num2 = num;
		if (!flag12)
		{
			goto IL_00f8;
		}
		goto IL_0329;
		IL_0329:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v55+E4]");
		bool flag13 = (nint)0 == 0;
		object obj52 = !flag13;
		if (obj52 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj53 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v35+B8]");
			num2 = 0;
		}
		object obj54 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 96;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj55 = (nint)0 + (nint)2248;
		Func<object, bool> func6 = default(Func<object, bool>);
		func6..ctor((object)num2, (IntPtr)obj55);
		num = (nint)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v24 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B8]");
		object obj56 = (nint)0 + (nint)8;
		obj56 = func6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		num12 = (nint)obj10;
		enumerable = Enumerable.Where(feeds, func6);
		bool flag14 = enumerable == null;
		object obj57 = !flag14;
		obj42 = 0;
		func = func6;
		obj51 = 0;
		num6 = (nint)obj10;
		func5 = func6;
		if (obj57 != null)
		{
			goto IL_0147;
		}
		goto IL_03ec;
		IL_03fa:
		object obj58 = num + obj24;
		obj18 = obj58 + 312;
		obj42 = obj51;
		func = func5;
		goto IL_0aa3;
		IL_022b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num6 = 0;
		ex2 = (NullReferenceException)enumerable;
		object obj59 = default(object);
		obj18 = obj59;
		goto IL_0aa3;
		IL_00f8:
		num12 = (nint)obj8;
		enumerable = Enumerable.Where(feeds, func);
		bool flag15 = enumerable == null;
		obj51 = obj42;
		num6 = (nint)obj8;
		func5 = func;
		if (!flag15)
		{
			goto IL_0147;
		}
		goto IL_03ec;
	}
}
