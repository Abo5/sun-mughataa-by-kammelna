using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Server.Models;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public class MassEventUserFeedListener : MonoBehaviour
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
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2912;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <OnFeedsReceived>b__3_0(UserFeedItem item)
		{
			//IL_007c: Expected I4, but got O
			//IL_0055: Expected O, but got I4
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected I4, but got Unknown
			if (item != null)
			{
				if (item.<Type>k__BackingField == UserFeedType.MassEventStageResult)
				{
					object obj = (item.<IsSeen>k__BackingField ? 1 : 0) ^ 1;
					return (byte)(obj & 1) != 0;
				}
				return false;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass3_0
	{
		public UserFeedItem feedItem;

		public MassEventUserFeedListener <>4__this;

		internal void <OnFeedsReceived>b__1()
		{
			MassEventUserFeedListener massEventUserFeedListener = <>4__this;
			massEventUserFeedListener.eventsChannel.TriggerMarkFeedSeen(feedItem);
		}
	}

	private UserFeedEventsChannel eventsChannel;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_00df: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_007e: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 288;
		object obj2 = (nint)0 + (nint)3080;
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
		UserFeedManager userFeedManager = default(UserFeedManager);
		IEnumerable<UserFeedItem> unreadFeeds = userFeedManager.UnreadFeeds;
		OnFeedsReceived(unreadFeeds);
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 288;
		object obj2 = (nint)0 + (nint)3080;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		eventsChannel.OnFeedsReceived -= action;
	}

	private void OnFeedsReceived(IEnumerable<UserFeedItem> feeds)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_026a: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_00b3: Expected O, but got I
		//IL_0322: Expected O, but got I4
		//IL_02a0: Expected O, but got I
		//IL_02c0: Expected O, but got I
		//IL_02e2: Expected O, but got I4
		//IL_09f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fc: Expected O, but got Unknown
		//IL_0a12: Expected O, but got I
		//IL_0a23: Expected I, but got O
		//IL_0a23: Expected O, but got I
		//IL_0a2b: Expected I, but got O
		//IL_0a41: Expected O, but got I
		//IL_00f0: Expected I, but got O
		//IL_0120: Expected I, but got O
		//IL_035f: Expected I, but got O
		//IL_038a: Expected O, but got I4
		//IL_0393: Expected O, but got I4
		//IL_039c: Expected O, but got I4
		//IL_03a4: Expected I, but got O
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_014a: Expected I, but got O
		//IL_015a: Expected O, but got I
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected O, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected O, but got Unknown
		//IL_095f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0964: Expected O, but got Unknown
		//IL_0973: Unknown result type (might be due to invalid IL or missing references)
		//IL_0978: Expected O, but got Unknown
		//IL_0987: Unknown result type (might be due to invalid IL or missing references)
		//IL_098c: Expected O, but got Unknown
		//IL_099b: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a0: Expected O, but got Unknown
		//IL_09ac: Expected O, but got I
		//IL_09bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c0: Expected O, but got Unknown
		//IL_09d8: Expected O, but got I
		//IL_0195: Expected O, but got I
		//IL_08e8: Expected O, but got I
		//IL_08fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ff: Expected O, but got Unknown
		//IL_03f0: Expected I, but got O
		//IL_0400: Expected O, but got I
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_0ab9: Expected O, but got I
		//IL_0acc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad1: Expected O, but got Unknown
		//IL_044b: Expected O, but got I
		//IL_0711: Expected O, but got I4
		//IL_071a: Expected O, but got I4
		//IL_0a68: Expected O, but got I
		//IL_0a7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7f: Expected O, but got Unknown
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Expected O, but got Unknown
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected O, but got Unknown
		//IL_0bc0: Expected O, but got I4
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected O, but got Unknown
		//IL_047c: Expected O, but got I
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected O, but got Unknown
		//IL_0727: Expected I, but got O
		//IL_0737: Expected O, but got I
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Expected O, but got Unknown
		//IL_0c0a: Expected O, but got I
		//IL_0772: Expected O, but got I
		//IL_0587: Expected I, but got O
		//IL_0597: Expected O, but got I
		//IL_07eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f0: Expected O, but got Unknown
		//IL_07f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fe: Expected O, but got Unknown
		//IL_0b52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b57: Expected O, but got Unknown
		//IL_0b84: Expected I, but got O
		//IL_05e2: Expected O, but got I
		//IL_0780: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Expected O, but got Unknown
		//IL_079b: Expected O, but got I
		//IL_0afe: Expected O, but got I
		//IL_0b10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b15: Expected O, but got Unknown
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected O, but got Unknown
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Expected O, but got Unknown
		//IL_06f2: Expected O, but got I4
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Expected O, but got Unknown
		//IL_0613: Expected O, but got I
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2912;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6041]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v53+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0087;
			}
		}
		else
		{
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v53+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0087;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = (nint)0 + (nint)3856;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v53+B8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+8]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+8]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		object obj9 = obj7;
		nint num2 = num;
		if (obj8 != null)
		{
			goto IL_00e8;
		}
		goto IL_0300;
		IL_0950:
		object obj10 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj11 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2920;
		object obj12 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1320;
		object obj13 = typeof(SqlSingle[]) + 2376;
		object obj14 = (nint)0 + (nint)688;
		object obj15 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		object obj17;
		object obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v2+8]");
		Action action = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v280 @ X8_v2] (should have been resolved before IL gen)");
		Func<object, bool> func = default(Func<object, bool>);
		object obj20 = default(object);
		object obj22 = default(object);
		bool flag6 = default(bool);
		nint num5;
		Action action2;
		object obj28 = default(object);
		object obj29 = default(object);
		object obj35;
		object obj37 = default(object);
		Action action3 = default(Action);
		object obj38 = default(object);
		while (true)
		{
			object obj19;
			object obj21;
			nint num4;
			if (func != null)
			{
				nint num3 = (nint)func;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v13 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v13 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
				bool flag4 = (nint)0 == 0;
				obj19 = obj20;
				obj21 = obj22;
				if (flag4)
				{
					goto IL_04d0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v13 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+B0]");
				object obj23 = (nint)0 + (nint)8;
				bool flag5 = flag6;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X10_v23-8]");
					obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X10_v23-8]");
					object obj24 = 0 - obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X10_v23-8]");
					if (0 == (nint)obj10)
					{
						break;
					}
					obj21 = obj23 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v13 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
					obj18 = -1;
					obj24 = obj18 - 1;
					bool flag7 = obj24 == null;
					flag6 = (nint)obj18 != 1;
					flag5 = flag6;
					obj23 = obj21;
					if (flag6)
					{
						continue;
					}
					goto IL_04d0;
				}
				obj18 = obj23;
				object obj25 = num3 + obj23;
				object obj26 = obj25 + 312;
				flag6 = flag5;
				obj21 = obj23;
				num4 = num5;
				goto IL_0aa8;
			}
			throw new NullReferenceException();
			IL_04d0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num4 = 0;
			goto IL_0aa8;
			IL_0aa8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X0_v24+8]");
			action2 = (Action)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v468 @ X0_v24] (should have been resolved before IL gen)");
			object obj27 = obj28 & 1;
			nint num7;
			if (obj27 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj29..ctor();
				if (obj29 != null)
				{
					object obj30 = obj29 + 24;
					obj30 = this;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					nint num6 = (nint)func;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X8_v16 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
					obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X8_v16 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
					bool flag8 = (nint)0 == 0;
					obj20 = obj19;
					obj22 = obj21;
					if (flag8)
					{
						goto IL_0667;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X8_v16 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+B0]");
					object obj31 = (nint)0 + (nint)8;
					bool flag9 = flag6;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X10_v18-8]");
						obj20 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X10_v18-8]");
						object obj24 = 0 - obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X10_v18-8]");
						if (0 == (nint)obj12)
						{
							break;
						}
						obj22 = obj31 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X8_v16 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
						obj16 = -1;
						obj24 = obj16 - 1;
						bool flag7 = obj24 == null;
						flag6 = (nint)obj16 != 1;
						flag9 = flag6;
						obj31 = obj22;
						if (flag6)
						{
							continue;
						}
						goto IL_0667;
					}
					obj16 = obj31;
					object obj32 = num6 + obj31;
					object obj33 = obj32 + 312;
					flag6 = flag9;
					obj22 = obj31;
					num7 = num4;
					goto IL_0b3e;
				}
				throw new NullReferenceException();
			}
			object obj34 = 0;
			obj35 = 0;
			break;
			IL_0667:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num7 = 0;
			goto IL_0b3e;
			IL_0b3e:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v751 @ X0_v34] (should have been resolved before IL gen)");
			object obj36 = obj29 + 16;
			obj36 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action3..ctor(obj29, (IntPtr)obj14);
			if (obj36 != null)
			{
				((UserFeedItem)obj36).ShowPreview(action3);
				obj38 = 0;
				action = action3;
				num5 = 0;
				continue;
			}
			throw new NullReferenceException();
		}
		object obj43 = default(object);
		while (true)
		{
			if (func == null)
			{
				goto IL_0ba6;
			}
			nint num8 = (nint)func;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X8_v8 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X8_v8 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_07c3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X8_v8 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+B0]");
			object obj39 = (nint)0 + (nint)8;
			object obj21;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X10_v10-8]");
				if (0 == (nint)obj15)
				{
					break;
				}
				obj21 = obj39 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X8_v8 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
				obj18 = -1;
				bool flag10 = (nint)obj18 != 1;
				obj39 = obj21;
				if (flag10)
				{
					continue;
				}
				goto IL_07c3;
			}
			obj18 = obj39;
			object obj40 = num8 + obj39;
			object obj41 = obj40 + 312;
			obj21 = obj39;
			goto IL_0bfa;
			IL_0ba6:
			bool flag11 = obj35 == null;
			object obj42 = !flag11;
			action = action2;
			if (obj42 == null)
			{
				return;
			}
			OutOfMemoryException ex = new OutOfMemoryException();
			if ((nint)action != 1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			obj35 = obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj34 = obj43;
			action2 = action;
			continue;
			IL_07c3:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			nint num4 = 0;
			goto IL_0bfa;
			IL_0bfa:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X0_v16+8]");
			action2 = (Action)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v693 @ X0_v16] (should have been resolved before IL gen)");
			goto IL_0ba6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_012e:
		object obj44 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3856;
		IEnumerable<object> enumerable;
		num = (nint)enumerable;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0212;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
		object obj46 = (nint)0 + (nint)8;
		bool flag12 = flag6;
		object obj47;
		nint num9;
		NullReferenceException ex2;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X10_v30-8]");
			obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X10_v30-8]");
			object obj24 = 0 - obj44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X10_v30-8]");
			bool flag7 = 0 == (nint)obj44;
			obj47 = obj38;
			flag6 = flag12;
			obj22 = obj46;
			num5 = num9;
			ex2 = (NullReferenceException)enumerable;
			if (flag7)
			{
				break;
			}
			obj22 = obj46 + 16;
			obj45--;
			obj24 = obj45 - 1;
			flag7 = obj24 == null;
			flag6 = (nint)obj45 != 1;
			flag12 = flag6;
			obj46 = obj22;
			if (flag6)
			{
				continue;
			}
			goto IL_0212;
		}
		goto IL_03c0;
		IL_03b2:
		ex2 = new NullReferenceException();
		goto IL_03c0;
		IL_0087:
		obj7 = (nint)0 + (nint)3856;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v53+B8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+8]");
		predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+8]");
		bool flag13 = (nint)0 == 0;
		obj9 = obj7;
		num2 = num;
		if (!flag13)
		{
			goto IL_00e8;
		}
		goto IL_0300;
		IL_0300:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v53+E4]");
		bool flag14 = (nint)0 == 0;
		object obj48 = !flag14;
		if (obj48 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj49 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v33+B8]");
			num2 = 0;
		}
		object obj50 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 96;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj51 = (nint)0 + (nint)680;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor((object)num2, (IntPtr)obj51);
		num = (nint)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B8]");
		object obj52 = (nint)0 + (nint)8;
		obj52 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		num9 = (nint)obj9;
		enumerable = Enumerable.Where(feeds, func2);
		bool flag15 = enumerable == null;
		object obj53 = !flag15;
		obj38 = 0;
		obj47 = 0;
		num5 = (nint)obj9;
		if (obj53 != null)
		{
			goto IL_012e;
		}
		goto IL_03b2;
		IL_03c0:
		object obj54 = num + obj22;
		obj17 = obj54 + 312;
		obj38 = obj47;
		goto IL_0950;
		IL_0212:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num5 = 0;
		ex2 = (NullReferenceException)enumerable;
		object obj55 = default(object);
		obj17 = obj55;
		goto IL_0950;
		IL_00e8:
		num9 = (nint)obj7;
		enumerable = Enumerable.Where(feeds, predicate);
		bool flag16 = enumerable == null;
		obj47 = obj38;
		num5 = (nint)obj7;
		if (!flag16)
		{
			goto IL_012e;
		}
		goto IL_03b2;
	}
}
