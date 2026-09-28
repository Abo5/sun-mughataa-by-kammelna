using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Server.Models;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;
using UnityEngine.InputSystem.UI;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.TextCore;
using UnityEngine.UI;
using Util.Extensions;

public class UserFeedList : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<BaseUserFeedItemUI, IEnumerable<UserFeedItem>> <>9__8_0;

		public static Func<UserFeedItem, UserFeedType> <>9__13_0;

		public static Predicate<BaseUserFeedItemUI> <>9__15_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 1496;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal IEnumerable<UserFeedItem> <get_ShownFeedItems>b__8_0(BaseUserFeedItemUI ui)
		{
			if ((object)ui != null)
			{
				return ui._feedItems;
			}
			return (IEnumerable<UserFeedItem>)new NullReferenceException();
		}

		internal UserFeedType <OnFeedsReceived>b__13_0(UserFeedItem item)
		{
			//IL_0035: Expected I4, but got O
			if (item != null)
			{
				return item.<Type>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (UserFeedType)ex;
		}

		internal bool <DismissUserFeed>b__15_0(BaseUserFeedItemUI ui)
		{
			//IL_0039: Expected I4, but got O
			if ((object)ui != null)
			{
				bool flag = Enumerable.Any((IEnumerable<object>)ui._feedItems);
				return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <AnimateDismissAll>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public UserFeedList <>4__this;

		private int <multiplier>5__2;

		private IEnumerator<BaseUserFeedItemUI> <>7__wrap2;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <AnimateDismissAll>d__17(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
			//IL_0010: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			//IL_0165: Expected O, but got I4
			//IL_0051: Expected O, but got I4
			//IL_0182: Expected I4, but got I8
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Expected O, but got Unknown
			//IL_0094: Expected I, but got O
			//IL_00a4: Expected O, but got I
			//IL_00df: Expected O, but got I
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Expected O, but got Unknown
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Expected O, but got Unknown
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected O, but got Unknown
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Expected O, but got Unknown
			object obj = <>1__state - 1;
			bool flag = obj == null;
			object obj2 = !flag;
			object obj3 = ~obj2;
			bool flag2;
			if (obj3 == null)
			{
				object obj4 = <>1__state - -3;
				flag2 = obj4 == null;
			}
			else
			{
				flag2 = true;
			}
			while (true)
			{
				object obj5 = !flag2;
				if (obj5 != null)
				{
					break;
				}
				<>1__state = -1;
				IEnumerator<BaseUserFeedItemUI> enumerator = <>7__wrap2;
				if (<>7__wrap2 == null)
				{
					break;
				}
				object obj6 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				nint num = (nint)enumerator;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v8 (Il2CppClass<System.Collections.Generic.IEnumerator`1<BaseUserFeedItemUI>>)+12E]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v8 (Il2CppClass<System.Collections.Generic.IEnumerator`1<BaseUserFeedItemUI>>)+12E]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v8 (Il2CppClass<System.Collections.Generic.IEnumerator`1<BaseUserFeedItemUI>>)+B0]");
					object obj8 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X10_v4-8]");
						if (0 == (nint)obj6)
						{
							break;
						}
						obj8 += 16;
						obj7--;
						if ((nint)obj7 != 1)
						{
							continue;
						}
						goto IL_0120;
					}
					object obj9 = num + obj8;
					object obj10 = obj9 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v187 @ X0_v6] (should have been resolved before IL gen)");
					continue;
				}
				goto IL_0120;
				IL_0120:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v174 @ X0_v4] (should have been resolved before IL gen)");
				break;
			}
		}

		private unsafe bool MoveNext()
		{
			//IL_026e: Expected I4, but got I8
			//IL_043a: Expected I4, but got I8
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0299: Expected O, but got I
			//IL_02af: Expected O, but got I
			//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c7: Expected O, but got Unknown
			//IL_0243: Expected I4, but got I8
			//IL_02e2: Expected O, but got I
			//IL_02f5: Expected I, but got O
			//IL_0301: Expected O, but got I
			//IL_0309: Expected I4, but got O
			//IL_0081: Expected O, but got I4
			//IL_032c: Expected O, but got I
			//IL_049a: Expected I, but got O
			//IL_0477: Expected I, but got O
			//IL_009e: Expected I4, but got I8
			//IL_0377: Expected O, but got I
			//IL_0680: Expected I, but got O
			//IL_041a: Expected I4, but got I8
			//IL_0aa2: Expected I4, but got O
			//IL_04e5: Expected O, but got I
			//IL_00cf: Expected O, but got I
			//IL_03c9: Expected O, but got I
			//IL_0b24: Expected I4, but got O
			//IL_0b47: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b4c: Expected O, but got Unknown
			//IL_0b66: Expected O, but got I4
			//IL_06cb: Expected O, but got I
			//IL_05fd: Invalid comparison between F4 and I4
			//IL_0610: Invalid comparison between F4 and I4
			//IL_058c: Expected I4, but got O
			//IL_0594: Unknown result type (might be due to invalid IL or missing references)
			//IL_0599: Expected O, but got Unknown
			//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a7: Expected O, but got Unknown
			//IL_0876: Unknown result type (might be due to invalid IL or missing references)
			//IL_087b: Expected O, but got Unknown
			//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0500: Expected O, but got Unknown
			//IL_0532: Invalid comparison between F4 and I4
			//IL_0772: Expected I4, but got O
			//IL_077a: Unknown result type (might be due to invalid IL or missing references)
			//IL_077f: Expected O, but got Unknown
			//IL_0788: Unknown result type (might be due to invalid IL or missing references)
			//IL_078d: Expected O, but got Unknown
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Expected O, but got Unknown
			//IL_014a: Expected I, but got O
			//IL_015a: Expected O, but got I
			//IL_08a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a5: Expected O, but got Unknown
			//IL_0b8e: Expected I4, but got I8
			//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e6: Expected O, but got Unknown
			//IL_0718: Invalid comparison between F4 and I4
			//IL_0c3b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c40: Expected O, but got Unknown
			//IL_0c49: Expected O, but got I4
			//IL_0c62: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c67: Expected O, but got Unknown
			//IL_09ca: Expected I4, but got O
			//IL_09dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e2: Expected O, but got Unknown
			//IL_09ea: Expected O, but got I
			//IL_0a06: Expected I4, but got I8
			//IL_0a1b: Expected I4, but got I8
			//IL_0195: Expected O, but got I
			//IL_08ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f3: Expected O, but got Unknown
			//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_07bb: Expected O, but got Unknown
			//IL_07c3: Expected I, but got O
			//IL_07d3: Expected O, but got I
			//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e1: Expected O, but got Unknown
			//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ef: Expected O, but got Unknown
			//IL_080e: Expected O, but got I
			//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b0: Expected O, but got Unknown
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Expected O, but got Unknown
			//IL_01da: Invalid comparison between F4 and I4
			//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_08d2: Expected O, but got Unknown
			//IL_08db: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e0: Expected O, but got Unknown
			//IL_081c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0821: Expected O, but got Unknown
			//IL_082a: Unknown result type (might be due to invalid IL or missing references)
			//IL_082f: Expected O, but got Unknown
			object obj = <>4__this;
			float num = (float)<>1__state - 2f;
			Action<object> action = default(Action<object>);
			object obj2 = default(object);
			int num2;
			bool flag;
			<AnimateDismissAll>d__17 <AnimateDismissAll>d__;
			<AnimateDismissAll>d__17 <AnimateDismissAll>d__2 = default(<AnimateDismissAll>d__17);
			bool flag4 = default(bool);
			object obj9;
			<AnimateDismissAll>d__17 <AnimateDismissAll>d__3;
			int num4;
			nint num3 = default(nint);
			bool flag5;
			bool value;
			int num6;
			if (<>1__state != 2)
			{
				action = (Action<object>)(typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528);
				obj2 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 304;
				num = (float)<>1__state - 1f;
				if (<>1__state == 1)
				{
					<>1__state = -3;
					num2 = <multiplier>5__2;
					flag = (byte)num3 != 0;
					<AnimateDismissAll>d__ = this;
					goto IL_0650;
				}
				bool flag2 = <>1__state == 0;
				object obj3 = !flag2;
				if (obj3 != null)
				{
					goto IL_03ce;
				}
				<>1__state = -1;
				if ((object)<>4__this != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X20_v2 (System.Object)+50]");
					IEnumerable<object> source = Enumerable.Reverse((IEnumerable<object>)0);
					<AnimateDismissAll>d__2.<multiplier>5__2 = 5;
					num4 = (int)((nint)0 + (nint)784);
					value = (byte)((int*)num4)->m_value != 0;
					IEnumerable<object> enumerable = Enumerable.Take(source, 10);
					if (enumerable != null)
					{
						object obj4 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2960;
						nint num5 = (nint)enumerable;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v60 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
						object obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v60 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0214;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v60 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
						object obj6 = (nint)0 + (nint)8;
						bool flag3 = flag4;
						object obj7;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X10_v29-8]");
							num = 0f - (float)obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X10_v29-8]");
							if (0 == (nint)obj4)
							{
								break;
							}
							obj7 = obj6 + 16;
							obj5--;
							num = (float)obj5 - 1f;
							flag5 = num == 0f;
							flag4 = (nint)obj5 != 1;
							flag3 = flag4;
							obj6 = obj7;
							if (flag4)
							{
								continue;
							}
							goto IL_0214;
						}
						object obj8 = num5 + obj6;
						obj9 = obj8 + 312;
						flag4 = flag3;
						obj7 = obj6;
						goto IL_09c2;
					}
					NullReferenceException ex = new NullReferenceException();
					num6 = 5;
					num3 = 10;
					<AnimateDismissAll>d__3 = this;
				}
				else
				{
					NullReferenceException ex2 = new NullReferenceException();
					num4 = -1;
					<AnimateDismissAll>d__3 = this;
				}
			}
			else
			{
				<>1__state = -1;
				if ((object)<>4__this != null)
				{
					object obj10 = (nint)0 + (nint)592;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X20_v2 (System.Object)+50]");
					IEnumerable<object> enumerable2 = Enumerable.Skip((IEnumerable<object>)0, 10);
					object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1288;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj12 = (nint)0 + (nint)4000;
					Action<object> action2 = default(Action<object>);
					action2..ctor((object)<>4__this, (IntPtr)obj12);
					object obj13 = (nint)0 + (nint)2064;
					value = (byte)(int)obj13 != 0;
					ArraysExtensions.ForEach(enumerable2, action2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X20_v2 (System.Object)+50]");
					ComponentListsExtensions.Destroy((IEnumerable<Component>)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X20_v2 (System.Object)+50]");
					num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X20_v2 (System.Object)+50]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v5 (System.Int32)+1C]");
						object obj14 = (nint)0 + (nint)1;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v5 (System.Int32)+18]");
						if ((nint)0 >= (nint)1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v5 (System.Int32)+10]");
							nint num7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v5 (System.Int32)+18]");
							Array.Clear((Array)num7, 0, 0);
						}
						goto IL_03ce;
					}
					NullReferenceException ex3 = new NullReferenceException();
					num3 = unchecked((nint)null);
					action = action2;
					<AnimateDismissAll>d__3 = (<AnimateDismissAll>d__17)(object)enumerable2;
				}
				else
				{
					NullReferenceException ex4 = new NullReferenceException();
					num4 = -1;
					<AnimateDismissAll>d__3 = this;
				}
			}
			goto IL_0c03;
			IL_09c2:
			num6 = (int)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v635 @ X8_v61] (should have been resolved before IL gen)");
			object obj15 = <AnimateDismissAll>d__2 + 48;
			IntPtr intPtr = default(IntPtr);
			obj15 = (nint)intPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			<AnimateDismissAll>d__2.<>1__state = -3;
			num3 = intPtr;
			num4 = -3;
			<AnimateDismissAll>d__ = <AnimateDismissAll>d__2;
			goto IL_0a28;
			IL_0b1c:
			object obj16 = default(object);
			num4 = (int)obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X0_v20+8]");
			num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v560 @ X0_v20] (should have been resolved before IL gen)");
			object obj18 = default(object);
			object obj17 = obj18 & 1;
			bool flag6 = obj17 == null;
			object obj19 = !flag6;
			<AnimateDismissAll>d__3 = <AnimateDismissAll>d__2;
			if (obj19 != null)
			{
				goto IL_0c03;
			}
			<AnimateDismissAll>d__2.<>1__state = -1;
			IEnumerator<BaseUserFeedItemUI> enumerator = <AnimateDismissAll>d__2.<>7__wrap2;
			if (<AnimateDismissAll>d__2.<>7__wrap2 != null)
			{
				object obj20 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				nint num8 = (nint)enumerator;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v30 (Il2CppClass<System.Collections.Generic.IEnumerator`1<BaseUserFeedItemUI>>)+12E]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v30 (Il2CppClass<System.Collections.Generic.IEnumerator`1<BaseUserFeedItemUI>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_084f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v30 (Il2CppClass<System.Collections.Generic.IEnumerator`1<BaseUserFeedItemUI>>)+B0]");
				object obj22 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X10_v16-8]");
					if (0 == (nint)obj20)
					{
						break;
					}
					obj22 += 16;
					obj21--;
					if ((nint)obj21 != 1)
					{
						continue;
					}
					goto IL_084f;
				}
				object obj23 = num8 + obj22;
				object obj24 = obj23 + 312;
				goto IL_0be1;
			}
			goto IL_0c32;
			IL_0bf0:
			int num9;
			<AnimateDismissAll>d__2.<>1__state = num9;
			return true;
			IL_0c32:
			object obj25 = <AnimateDismissAll>d__2 + 48;
			obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj26 = typeof(UsageHint) + 1640;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			WaitForSeconds waitForSeconds = default(WaitForSeconds);
			waitForSeconds..ctor(0.3f);
			object obj27 = <AnimateDismissAll>d__2 + 24;
			obj27 = waitForSeconds;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			num9 = 2;
			goto IL_0bf0;
			IL_0be1:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v766 @ X0_v33] (should have been resolved before IL gen)");
			goto IL_0c32;
			IL_0752:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			value = false;
			goto IL_0b1c;
			IL_0650:
			num4 = num2 - 1;
			<AnimateDismissAll>d__.<multiplier>5__2 = num4;
			num3 = (flag ? 1 : 0);
			goto IL_0a28;
			IL_0a28:
			<AnimateDismissAll>d__3 = (<AnimateDismissAll>d__17)(object)<AnimateDismissAll>d__.<>7__wrap2;
			if (<AnimateDismissAll>d__.<>7__wrap2 != null)
			{
				nint num10 = (nint)<AnimateDismissAll>d__3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v16 (Il2CppClass<UserFeedList+<AnimateDismissAll>d__17>)+12E]");
				num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v16 (Il2CppClass<UserFeedList+<AnimateDismissAll>d__17>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0752;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v16 (Il2CppClass<UserFeedList+<AnimateDismissAll>d__17>)+B0]");
				object obj28 = (nint)0 + (nint)8;
				bool flag7 = flag4;
				object obj7;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X10_v21-8]");
					num = 0f - (float)action;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X10_v21-8]");
					if (0 == (nint)action)
					{
						break;
					}
					obj7 = obj28 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v16 (Il2CppClass<UserFeedList+<AnimateDismissAll>d__17>)+12E]");
					num6 = (int)(-1);
					num = (float)num6 - 1f;
					flag5 = num == 0f;
					flag4 = num6 != 1;
					flag7 = flag4;
					obj28 = obj7;
					if (flag4)
					{
						continue;
					}
					goto IL_0752;
				}
				num6 = (int)obj28;
				object obj29 = num10 + obj28;
				obj16 = obj29 + 312;
				flag4 = flag7;
				obj7 = obj28;
				goto IL_0b1c;
			}
			NullReferenceException ex5 = new NullReferenceException();
			goto IL_0c03;
			IL_0214:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			value = false;
			object obj30 = default(object);
			obj9 = obj30;
			goto IL_09c2;
			IL_03ce:
			return false;
			IL_084f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			value = false;
			goto IL_0be1;
			IL_0c03:
			object obj33 = default(object);
			BaseUserFeedItemUI baseUserFeedItemUI = default(BaseUserFeedItemUI);
			while (true)
			{
				<AnimateDismissAll>d__3 = (<AnimateDismissAll>d__17)(object)<AnimateDismissAll>d__3.<>7__wrap2;
				if (<AnimateDismissAll>d__3.<>7__wrap2 != null)
				{
					nint num11 = (nint)<AnimateDismissAll>d__3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v6 (Il2CppClass<UserFeedList+<AnimateDismissAll>d__17>)+12E]");
					num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v6 (Il2CppClass<UserFeedList+<AnimateDismissAll>d__17>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_056c;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v6 (Il2CppClass<UserFeedList+<AnimateDismissAll>d__17>)+B0]");
					object obj31 = (nint)0 + (nint)8;
					bool flag8 = flag4;
					object obj7;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X10_v6-8]");
						num = 0f - (float)obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X10_v6-8]");
						if (0 == (nint)obj2)
						{
							break;
						}
						obj7 = obj31 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v6 (Il2CppClass<UserFeedList+<AnimateDismissAll>d__17>)+12E]");
						num6 = (int)(-1);
						num = (float)num6 - 1f;
						flag5 = num == 0f;
						flag4 = num6 != 1;
						flag8 = flag4;
						obj31 = obj7;
						if (flag4)
						{
							continue;
						}
						goto IL_056c;
					}
					num6 = (int)obj31;
					object obj32 = num11 + obj31;
					obj33 = obj32 + 312;
					flag4 = flag8;
					obj7 = obj31;
					goto IL_0a9a;
				}
				NullReferenceException ex6 = new NullReferenceException();
				continue;
				IL_0a9a:
				num4 = (int)obj33;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X0_v4+8]");
				num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v624 @ X0_v4] (should have been resolved before IL gen)");
				if ((object)baseUserFeedItemUI == null)
				{
					NullReferenceException ex7 = new NullReferenceException();
					continue;
				}
				break;
				IL_056c:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				value = false;
				goto IL_0a9a;
			}
			baseUserFeedItemUI.DismissUserFeed(toRight: false, collapse: false);
			num2 = <AnimateDismissAll>d__2.<multiplier>5__2;
			float num12 = (float)<AnimateDismissAll>d__2.<multiplier>5__2 * 1.0173704E+09f;
			flag5 = num12 == 0f;
			flag4 = num12 > 0f;
			value = false;
			num6 = 1017370378;
			flag = false;
			num = num12;
			<AnimateDismissAll>d__ = <AnimateDismissAll>d__2;
			if (!flag4)
			{
				goto IL_0650;
			}
			object obj34 = typeof(UsageHint) + 1640;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			WaitForSeconds waitForSeconds2 = default(WaitForSeconds);
			waitForSeconds2..ctor(num12);
			object obj35 = <AnimateDismissAll>d__2 + 24;
			obj35 = waitForSeconds2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			num9 = 1;
			goto IL_0bf0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void <>m__Finally1()
		{
			//IL_00f6: Expected I4, but got I8
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			while (true)
			{
				<>1__state = -1;
				IEnumerator<BaseUserFeedItemUI> enumerator = <>7__wrap2;
				if (<>7__wrap2 == null)
				{
					break;
				}
				object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				nint num = (nint)enumerator;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v6 (Il2CppClass<System.Collections.Generic.IEnumerator`1<BaseUserFeedItemUI>>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v6 (Il2CppClass<System.Collections.Generic.IEnumerator`1<BaseUserFeedItemUI>>)+12E]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v6 (Il2CppClass<System.Collections.Generic.IEnumerator`1<BaseUserFeedItemUI>>)+B0]");
					object obj3 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v4-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj3 += 16;
						obj2--;
						if ((nint)obj2 != 1)
						{
							continue;
						}
						goto IL_00ad;
					}
					object obj4 = num + obj3;
					object obj5 = obj4 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v151 @ X0_v5] (should have been resolved before IL gen)");
					continue;
				}
				goto IL_00ad;
				IL_00ad:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v90 @ X0_v3] (should have been resolved before IL gen)");
				break;
			}
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
			object obj2 = (nint)0 + (nint)2240;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private RectTransform itemsList;

	private UserFeedItemUI feedItemPrefab;

	private UserFeedItemsGroupUI feedItemsGroupPrefab;

	private GameObject placeholder;

	private Button clearButton;

	private UserFeedEventsChannel eventsChannel;

	private readonly List<BaseUserFeedItemUI> _shownFeedItemUis;

	private IEnumerable<UserFeedItem> ShownFeedItems
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
			object obj = 152985600;
			object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 1496;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6352]");
			object obj3 = (nint)0 & (nint)1;
			List<BaseUserFeedItemUI> shownFeedItemUis;
			List<BaseUserFeedItemUI> shownFeedItemUis2;
			object obj4;
			if (obj3 != null)
			{
				shownFeedItemUis = _shownFeedItemUis;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				shownFeedItemUis2 = _shownFeedItemUis;
				if (!flag)
				{
					goto IL_0099;
				}
			}
			else
			{
				_ = 1;
				shownFeedItemUis = _shownFeedItemUis;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				shownFeedItemUis2 = _shownFeedItemUis;
				if (obj6 != null)
				{
					goto IL_0099;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
			object obj7 = (nint)0 + (nint)312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			Func<object, IEnumerable<object>> selector = (Func<object, IEnumerable<object>>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			IEnumerable<object> enumerable = shownFeedItemUis2;
			object obj10 = obj7;
			IEnumerable<object> source = shownFeedItemUis2;
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
			object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 320;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)2232;
			Func<object, object> func = default(Func<object, object>);
			func..ctor(obj8, (IntPtr)obj14);
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v9+B8]");
			object obj16 = (nint)0 + (nint)8;
			obj16 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj10 = obj7;
			selector = (Func<object, IEnumerable<object>>)func;
			source = enumerable;
			goto IL_0249;
			IL_0249:
			return (IEnumerable<UserFeedItem>)Enumerable.SelectMany(source, selector);
			IL_0099:
			obj10 = (nint)0 + (nint)312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			selector = (Func<object, IEnumerable<object>>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			source = shownFeedItemUis;
			if (obj17 == null)
			{
				obj7 = obj10;
				enumerable = shownFeedItemUis;
				goto IL_01f2;
			}
			goto IL_0249;
		}
	}

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0062: Expected O, but got I
		//IL_0091: Expected I, but got O
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00b6: Expected O, but got I
		//IL_00e2: Expected I, but got O
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0107: Expected O, but got I
		//IL_0140: Expected O, but got I4
		//IL_0178: Expected O, but got I
		//IL_01da: Expected O, but got I4
		Button button = clearButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)4016;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 288;
		object obj4 = (nint)0 + (nint)4032;
		button.m_OnClick.AddListener(unityAction);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3952;
		object obj6 = (nint)0 + (nint)4024;
		eventsChannel.OnFeedsReceived += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj6);
		object obj7 = typeof(Queue<string>) + 888;
		object obj8 = (nint)0 + (nint)2272;
		eventsChannel.OnDismissFeed += action2;
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj11 = (nint)0 + (nint)2400;
		UserFeedManager userFeedManager = default(UserFeedManager);
		IEnumerable<UserFeedItem> feeds = userFeedManager.Feeds;
		if (Enumerable.Any((IEnumerable<object>)feeds))
		{
			object obj12 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj13 = !flag2;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			UserFeedManager userFeedManager2 = default(UserFeedManager);
			IEnumerable<UserFeedItem> feeds2 = userFeedManager2.Feeds;
			OnFeedsReceived(feeds2);
		}
	}

	private void OnEnable()
	{
		GameObject gameObject = clearButton.gameObject;
		gameObject.SetActive(value: true);
	}

	private void OnDisable()
	{
		GameObject gameObject = clearButton.gameObject;
		gameObject.SetActive(value: false);
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_009e: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0071: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 288;
		object obj2 = (nint)0 + (nint)4032;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3952;
		object obj4 = (nint)0 + (nint)4024;
		eventsChannel.OnFeedsReceived -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj4);
		eventsChannel.OnDismissFeed -= action2;
	}

	private unsafe void OnFeedsReceived(IEnumerable<UserFeedItem> newFeeds)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_010a: Expected O, but got I
		//IL_011a: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_014c: Expected O, but got I4
		//IL_00aa: Expected O, but got I4
		//IL_0031: Expected O, but got I
		//IL_0041: Expected O, but got I
		//IL_0051: Expected O, but got I
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_025c: Expected O, but got I
		//IL_0172: Expected O, but got I
		//IL_0194: Expected O, but got I4
		//IL_0302: Expected O, but got I
		//IL_0326: Expected O, but got I4
		//IL_032e: Expected O, but got Ref
		//IL_0337: Expected O, but got I4
		//IL_00c7: Expected O, but got I4
		//IL_14f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14fd: Expected O, but got Unknown
		//IL_1513: Expected O, but got I
		//IL_1524: Expected I, but got O
		//IL_1542: Expected O, but got I
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected O, but got Unknown
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected O, but got Unknown
		//IL_044f: Expected O, but got I
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected O, but got Unknown
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected O, but got Unknown
		//IL_0297: Expected O, but got I
		//IL_01f3: Expected O, but got I4
		//IL_0209: Expected O, but got I4
		//IL_0212: Expected O, but got I4
		//IL_01c4: Expected O, but got I
		//IL_0535: Expected O, but got I
		//IL_035f: Expected O, but got Ref
		//IL_0368: Expected O, but got I4
		//IL_1569: Expected O, but got I
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected O, but got Unknown
		//IL_03ad: Expected O, but got I
		//IL_03ce: Expected O, but got Ref
		//IL_03d7: Expected O, but got I4
		//IL_03ef: Expected O, but got I
		//IL_03fc: Expected O, but got Ref
		//IL_0405: Expected O, but got I4
		//IL_15d1: Expected O, but got I
		//IL_15e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e9: Expected O, but got Unknown
		//IL_0570: Expected O, but got I
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_0ebd: Expected O, but got Ref
		//IL_0ee5: Expected O, but got I4
		//IL_0f0e: Expected O, but got I4
		//IL_0f1f: Expected O, but got I4
		//IL_0f58: Expected O, but got I4
		//IL_159d: Expected O, but got I
		//IL_18e3: Expected O, but got I4
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Expected O, but got Unknown
		//IL_0f75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7a: Expected O, but got Unknown
		//IL_0f92: Expected O, but got I
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected O, but got Unknown
		//IL_0599: Expected O, but got I
		//IL_1073: Unknown result type (might be due to invalid IL or missing references)
		//IL_1078: Expected O, but got Unknown
		//IL_1092: Expected O, but got I4
		//IL_063a: Expected O, but got I
		//IL_1995: Expected O, but got I
		//IL_0fcd: Expected O, but got I
		//IL_1961: Expected O, but got I
		//IL_1669: Expected O, but got I4
		//IL_1688: Expected O, but got I4
		//IL_0675: Expected O, but got I
		//IL_1050: Unknown result type (might be due to invalid IL or missing references)
		//IL_1055: Expected O, but got Unknown
		//IL_1616: Expected O, but got I
		//IL_13f8: Expected O, but got I4
		//IL_1401: Expected O, but got I4
		//IL_0fdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe0: Expected O, but got Unknown
		//IL_0ff6: Expected O, but got I
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Expected O, but got Unknown
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_0688: Expected O, but got Unknown
		//IL_069e: Expected O, but got I
		//IL_1430: Expected O, but got I4
		//IL_0736: Unknown result type (might be due to invalid IL or missing references)
		//IL_073b: Expected O, but got Unknown
		//IL_0743: Expected I, but got O
		//IL_0753: Expected O, but got I
		//IL_1137: Expected O, but got I4
		//IL_1166: Unknown result type (might be due to invalid IL or missing references)
		//IL_116b: Expected I4, but got Unknown
		//IL_1705: Expected O, but got I
		//IL_078e: Expected O, but got I
		//IL_0bf0: Expected O, but got Ref
		//IL_0bf9: Expected O, but got I4
		//IL_16b5: Expected O, but got I
		//IL_16c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_16cc: Expected O, but got Unknown
		//IL_0867: Expected I, but got O
		//IL_0877: Expected O, but got I
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_083c: Expected O, but got Unknown
		//IL_0845: Unknown result type (might be due to invalid IL or missing references)
		//IL_084a: Expected O, but got Unknown
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a9: Expected O, but got Unknown
		//IL_07bf: Expected O, but got I
		//IL_07ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cf: Expected O, but got Unknown
		//IL_17ac: Expected O, but got I
		//IL_17bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c4: Expected O, but got Unknown
		//IL_08b2: Expected O, but got I
		//IL_175c: Expected O, but got I
		//IL_176e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1773: Expected O, but got Unknown
		//IL_095b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0960: Expected O, but got Unknown
		//IL_0969: Unknown result type (might be due to invalid IL or missing references)
		//IL_096e: Expected O, but got Unknown
		//IL_1305: Expected O, but got Ref
		//IL_130e: Expected O, but got I4
		//IL_0c42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c47: Expected O, but got Unknown
		//IL_0c4f: Expected I, but got O
		//IL_0c5f: Expected O, but got I
		//IL_0dcd: Expected O, but got Ref
		//IL_0dd6: Expected O, but got I4
		//IL_0e0e: Expected O, but got I
		//IL_08c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cd: Expected O, but got Unknown
		//IL_08e3: Expected O, but got I
		//IL_08ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f3: Expected O, but got Unknown
		//IL_09a8: Expected I, but got O
		//IL_09b8: Expected O, but got I
		//IL_18ab: Expected O, but got I
		//IL_0c9a: Expected O, but got I
		//IL_1877: Expected O, but got I
		//IL_09f3: Expected O, but got I
		//IL_0d0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d14: Expected O, but got Unknown
		//IL_0d1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d22: Expected O, but got Unknown
		//IL_0d7d: Expected O, but got Ref
		//IL_0d86: Expected O, but got I4
		//IL_0db7: Expected O, but got I4
		//IL_17f1: Expected O, but got I
		//IL_1803: Unknown result type (might be due to invalid IL or missing references)
		//IL_1808: Expected O, but got Unknown
		//IL_0ca8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cad: Expected O, but got Unknown
		//IL_0cc3: Expected O, but got I
		//IL_0adc: Expected O, but got I4
		//IL_0a9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa1: Expected O, but got Unknown
		//IL_0aaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaf: Expected O, but got Unknown
		//IL_0a09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0e: Expected O, but got Unknown
		//IL_0a24: Expected O, but got I
		//IL_0a2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a34: Expected O, but got Unknown
		//IL_0e24: Expected O, but got Ref
		//IL_0e2d: Expected O, but got I4
		//IL_0af2: Expected I, but got O
		//IL_0b02: Expected O, but got I
		//IL_0b57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5c: Expected O, but got Unknown
		//IL_0ba7: Expected O, but got I4
		//IL_0e7a: Expected O, but got Ref
		//IL_0e83: Expected O, but got I4
		object obj = (nint)0 + (nint)3896;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 1496;
		IEnumerable<UserFeedItem> shownFeedItems = ShownFeedItems;
		IEnumerable<object> enumerable = Enumerable.Except((IEnumerable<object>)newFeeds, (IEnumerable<object>)shownFeedItems);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v108+E4]");
		object obj4;
		object obj5;
		Func<object, System.Int32Enum> func;
		object obj6;
		if ((nint)0 != 0)
		{
			obj4 = (nint)0 + (nint)2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v108+B8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v74+10]");
			func = (Func<object, System.Int32Enum>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v74+10]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_007e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
			obj4 = (nint)0 + (nint)2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v108+B8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v74+10]");
			func = (Func<object, System.Int32Enum>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v74+10]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_007e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v108+E4]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v108+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v80+B8]");
			obj5 = 0;
		}
		object obj11 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)2224;
		Func<object, System.Int32Enum> func2 = default(Func<object, System.Int32Enum>);
		func2..ctor(obj5, (IntPtr)obj12);
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v79+B8]");
		object obj14 = (nint)0 + (nint)16;
		obj14 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		BaseUserFeedItemUI baseUserFeedItemUI = (BaseUserFeedItemUI)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9A3B8");
		object obj15 = default(object);
		bool flag4 = obj15 == null;
		object obj16 = 0;
		obj4 = obj6;
		object obj17 = null;
		object obj18 = 0;
		object obj19 = 0;
		BaseUserFeedItemUI baseUserFeedItemUI2 = (BaseUserFeedItemUI)obj6;
		Func<object, System.Int32Enum> func3 = func2;
		if (!flag4)
		{
			goto IL_0230;
		}
		goto IL_14de;
		IL_14de:
		throw new NullReferenceException();
		IL_0e5a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex = new OutOfMemoryException();
		object obj20 = (object)(&obj17);
		object obj21 = 0;
		object obj23 = default(object);
		object obj22 = obj23;
		object obj25;
		object obj24 = obj25;
		object obj27 = default(object);
		object obj26 = obj27;
		obj4 = obj6;
		baseUserFeedItemUI2 = baseUserFeedItemUI;
		func3 = null;
		goto IL_1381;
		IL_189b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1396 @ X0_v63+8]");
		IEnumerable<UserFeedItem> enumerable2 = (IEnumerable<UserFeedItem>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1396 @ X0_v63] (should have been resolved before IL gen)");
		goto IL_12f4;
		IL_1985:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1039 @ X0_v30+8]");
		func3 = (Func<object, System.Int32Enum>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1039 @ X0_v30] (should have been resolved before IL gen)");
		object obj28 = obj20;
		object obj29 = obj23;
		object obj31;
		object obj30 = obj31;
		object obj33 = default(object);
		object obj32 = obj33;
		object obj35;
		object obj34 = obj35;
		object obj37;
		object obj36 = obj37;
		object obj39;
		object obj38 = obj39;
		obj25 = obj24;
		object obj40 = obj27;
		obj16 = obj19;
		object obj41 = obj6;
		object obj42 = obj2;
		object obj44;
		object obj43 = obj44;
		goto IL_18c9;
		IL_101e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		baseUserFeedItemUI = null;
		goto IL_1985;
		IL_007e:
		baseUserFeedItemUI = (BaseUserFeedItemUI)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9A3B8");
		bool flag5 = obj15 == null;
		object obj45 = !flag5;
		if (obj45 != null)
		{
			goto IL_0230;
		}
		obj17 = null;
		obj18 = 0;
		obj19 = obj16;
		obj6 = obj4;
		baseUserFeedItemUI2 = (BaseUserFeedItemUI)obj4;
		func3 = func;
		goto IL_14de;
		IL_0230:
		object obj46 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2712;
		object obj47 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v24+12E]");
		object obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v24+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02e0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v24+B0]");
		obj26 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X10_v11-8]");
			obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X10_v11-8]");
			if (0 == (nint)obj46)
			{
				break;
			}
			obj27 = obj26 + 16;
			obj48--;
			bool flag6 = (nint)obj48 != 1;
			obj26 = obj27;
			if (flag6)
			{
				continue;
			}
			goto IL_02e0;
		}
		object obj49 = obj47 + obj26;
		object obj50 = obj49 + 312;
		obj8 = obj50;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v71+8]");
		enumerable2 = (IEnumerable<UserFeedItem>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v406 @ X8_v71] (should have been resolved before IL gen)");
		object obj51 = default(object);
		bool flag7 = obj51 == null;
		obj25 = (object)(&obj18);
		object obj52 = 0;
		obj27 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X10_v11-8]");
		obj22 = 0;
		obj17 = null;
		obj24 = (object)(&obj18);
		obj52 = 0;
		baseUserFeedItemUI2 = baseUserFeedItemUI;
		if (!flag7)
		{
			goto IL_041b;
		}
		goto IL_1298;
		IL_18c9:
		object obj54 = default(object);
		object obj55;
		while (true)
		{
			bool flag8 = obj43 == null;
			object obj53 = !flag8;
			obj20 = obj28;
			obj23 = obj29;
			obj33 = obj32;
			obj35 = obj34;
			obj37 = obj36;
			obj39 = obj38;
			obj24 = obj25;
			obj27 = obj40;
			obj19 = obj16;
			obj6 = obj41;
			baseUserFeedItemUI2 = baseUserFeedItemUI;
			obj2 = obj42;
			if (obj53 != null)
			{
				OutOfMemoryException ex2 = new OutOfMemoryException();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
				if ((nint)func3 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
					obj44 = obj54;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
					obj55 = obj24;
					bool flag9 = obj24 == null;
					object obj56 = !flag9;
					obj31 = 0;
					obj52 = obj54;
					if (obj56 == null)
					{
						obj28 = obj20;
						obj29 = obj23;
						obj30 = 0;
						obj32 = obj33;
						obj34 = obj35;
						obj36 = obj37;
						obj38 = obj39;
						obj25 = obj24;
						obj52 = obj54;
						obj40 = obj27;
						obj16 = obj19;
						obj41 = obj6;
						baseUserFeedItemUI = baseUserFeedItemUI2;
						obj42 = obj2;
						obj43 = obj54;
						continue;
					}
					goto IL_0f66;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
				return;
			}
			break;
		}
		object obj57 = obj30 & 7;
		bool flag10 = obj57 == null;
		object obj58 = !flag10;
		if (obj58 != null)
		{
			return;
		}
		List<BaseUserFeedItemUI> shownFeedItemUis = _shownFeedItemUis;
		bool flag11 = _shownFeedItemUis == null;
		obj20 = obj28;
		obj23 = obj29;
		obj33 = obj32;
		obj35 = obj34;
		obj37 = obj36;
		obj39 = obj38;
		obj24 = obj25;
		obj27 = obj40;
		obj19 = obj16;
		obj6 = obj41;
		baseUserFeedItemUI2 = baseUserFeedItemUI;
		obj2 = obj42;
		if (!flag11)
		{
			bool flag12 = (object)placeholder == null;
			obj20 = obj28;
			obj23 = obj29;
			obj33 = obj32;
			obj35 = obj34;
			obj37 = obj36;
			obj39 = obj38;
			obj24 = obj25;
			obj27 = obj40;
			obj19 = obj16;
			obj6 = obj41;
			baseUserFeedItemUI2 = baseUserFeedItemUI;
			obj2 = obj42;
			if (!flag12)
			{
				object obj59 = shownFeedItemUis._size - 1;
				bool flag13 = (nint)obj59 < 0;
				int num = shownFeedItemUis._size ^ 1;
				int num2 = shownFeedItemUis._size ^ obj59;
				int num3 = num & num2;
				bool flag14 = num3 < 0;
				bool flag15 = flag13 == flag14;
				bool active = !flag15;
				placeholder.SetActive(active);
				return;
			}
		}
		goto IL_14de;
		IL_1298:
		NullReferenceException ex3 = new NullReferenceException();
		func3 = (Func<object, System.Int32Enum>)(object)enumerable2;
		goto IL_1381;
		IL_1381:
		obj23 = obj22;
		obj27 = obj26;
		obj19 = obj16;
		obj6 = obj4;
		goto IL_14de;
		IL_0ceb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		baseUserFeedItemUI = null;
		goto IL_189b;
		IL_02e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj60 = default(object);
		obj8 = obj60;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v104+8]");
		enumerable2 = (IEnumerable<UserFeedItem>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v311 @ X0_v104] (should have been resolved before IL gen)");
		bool flag16 = obj51 == null;
		object obj61 = !flag16;
		obj25 = (object)(&obj18);
		obj52 = 0;
		baseUserFeedItemUI = null;
		if (obj61 != null)
		{
			goto IL_041b;
		}
		obj22 = obj23;
		obj17 = null;
		obj24 = (object)(&obj18);
		obj52 = 0;
		obj26 = obj27;
		baseUserFeedItemUI2 = null;
		goto IL_1298;
		IL_041b:
		obj6 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		obj39 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 4080;
		obj37 = (nint)0 + (nint)3480;
		obj2 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1320;
		obj35 = typeof(SqlSingle[]) + 480;
		obj28 = obj20;
		obj17 = null;
		obj32 = obj33;
		object obj62 = obj51;
		object obj68 = default(object);
		IEnumerable<object> enumerable3 = default(IEnumerable<object>);
		bool flag20;
		while (true)
		{
			object obj63 = obj62;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v29+12E]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v29+12E]");
			if ((nint)0 == 0)
			{
				goto IL_05c1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v29+B0]");
			object obj64 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ X10_v54-8]");
				obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ X10_v54-8]");
				if (0 == (nint)obj6)
				{
					break;
				}
				obj27 = obj64 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v29+12E]");
				obj8 = -1;
				bool flag17 = (nint)obj8 != 1;
				obj64 = obj27;
				if (flag17)
				{
					continue;
				}
				goto IL_05c1;
			}
			obj8 = obj64;
			object obj65 = obj63 + obj64;
			object obj66 = obj65 + 312;
			obj27 = obj64;
			goto IL_15c1;
			IL_15c1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X0_v42+8]");
			func3 = (Func<object, System.Int32Enum>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v738 @ X0_v42] (should have been resolved before IL gen)");
			object obj67 = obj68 & 1;
			if (obj67 == null)
			{
				break;
			}
			if (obj18 == null)
			{
				goto IL_12ae;
			}
			object obj69 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X8_v33+12E]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X8_v33+12E]");
			if ((nint)0 == 0)
			{
				goto IL_06c6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X8_v33+B0]");
			object obj70 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v967 @ X10_v49-8]");
				obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v967 @ X10_v49-8]");
				if (0 == (nint)obj39)
				{
					break;
				}
				obj27 = obj70 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X8_v33+12E]");
				obj8 = -1;
				bool flag18 = (nint)obj8 != 1;
				obj70 = obj27;
				if (flag18)
				{
					continue;
				}
				goto IL_06c6;
			}
			obj8 = obj70;
			object obj71 = obj69 + obj70;
			object obj72 = obj71 + 312;
			obj27 = obj70;
			goto IL_163a;
			IL_163a:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1029 @ X0_v46] (should have been resolved before IL gen)");
			func3 = (Func<object, System.Int32Enum>)obj37;
			int num4 = Enumerable.Count(enumerable3);
			object obj73 = num4 - 3;
			bool flag19 = obj73 == null;
			obj33 = !flag19;
			flag20 = num4 > 3;
			if (flag20)
			{
				baseUserFeedItemUI = feedItemsGroupPrefab;
				CreateItemUI((IEnumerable<UserFeedItem>)enumerable3, feedItemsGroupPrefab);
				enumerable2 = (IEnumerable<UserFeedItem>)enumerable3;
				bool flag21 = obj18 == null;
				obj32 = obj33;
				obj62 = obj18;
				obj20 = obj28;
				obj22 = obj23;
				obj24 = obj25;
				obj26 = obj27;
				obj4 = obj6;
				baseUserFeedItemUI2 = baseUserFeedItemUI;
				if (!flag21)
				{
					continue;
				}
				goto IL_1298;
			}
			goto IL_070a;
			IL_06c6:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			baseUserFeedItemUI = null;
			goto IL_163a;
			IL_05c1:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			baseUserFeedItemUI = null;
			goto IL_15c1;
		}
		object obj74 = (object)(&obj18);
		obj55 = obj74;
		bool flag22 = obj74 == null;
		obj20 = obj28;
		obj31 = 8;
		obj33 = obj32;
		obj24 = obj25;
		obj19 = obj16;
		baseUserFeedItemUI2 = baseUserFeedItemUI;
		obj44 = 0;
		obj29 = obj23;
		obj30 = 8;
		obj34 = obj35;
		obj36 = obj37;
		obj38 = obj39;
		obj40 = obj27;
		obj41 = obj6;
		obj42 = obj2;
		obj43 = 0;
		if (!flag22)
		{
			goto IL_0f66;
		}
		goto IL_18c9;
		IL_0dbc:
		NullReferenceException ex4 = new NullReferenceException();
		obj20 = (object)(&obj17);
		obj21 = 0;
		obj22 = obj23;
		obj24 = obj25;
		obj26 = obj27;
		obj4 = obj6;
		baseUserFeedItemUI2 = baseUserFeedItemUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1244 @ X0_v57+8]");
		func3 = (Func<object, System.Int32Enum>)0;
		goto IL_1381;
		IL_16f5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1152 @ X0_v51+8]");
		IEnumerable<UserFeedItem> enumerable4 = (IEnumerable<UserFeedItem>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1152 @ X0_v51] (should have been resolved before IL gen)");
		object obj75 = default(object);
		bool flag23 = obj75 == null;
		object obj76 = obj75;
		obj22 = obj23;
		obj26 = obj27;
		baseUserFeedItemUI2 = baseUserFeedItemUI;
		if (flag23)
		{
			goto IL_0bdf;
		}
		object obj81 = default(object);
		IEnumerable<UserFeedItem> enumerable5 = default(IEnumerable<UserFeedItem>);
		object obj85 = default(object);
		object obj86 = default(object);
		while (true)
		{
			nint num5 = (nint)obj76;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1186 @ X8_v44 (Il2CppClass<System.Object>)+12E]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1186 @ X8_v44 (Il2CppClass<System.Object>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0937;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1186 @ X8_v44 (Il2CppClass<System.Object>)+B0]");
			object obj77 = (nint)0 + (nint)8;
			bool flag24 = flag20;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1229 @ X10_v37-8]");
				obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1229 @ X10_v37-8]");
				object obj73 = 0 - obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1229 @ X10_v37-8]");
				if (0 == (nint)obj6)
				{
					break;
				}
				obj27 = obj77 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1186 @ X8_v44 (Il2CppClass<System.Object>)+12E]");
				obj8 = -1;
				obj73 = obj8 - 1;
				bool flag19 = obj73 == null;
				flag20 = (nint)obj8 != 1;
				flag24 = flag20;
				obj77 = obj27;
				if (flag20)
				{
					continue;
				}
				goto IL_0937;
			}
			obj8 = obj77;
			object obj78 = num5 + obj77;
			object obj79 = obj78 + 312;
			flag20 = flag24;
			obj27 = obj77;
			goto IL_179c;
			IL_179c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1244 @ X0_v57+8]");
			enumerable2 = (IEnumerable<UserFeedItem>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1244 @ X0_v57] (should have been resolved before IL gen)");
			object obj80 = obj81 & 1;
			if (obj80 == null)
			{
				break;
			}
			if (obj17 == null)
			{
				goto IL_0dbc;
			}
			nint num6 = (nint)obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X8_v55 (Il2CppClass<System.Object>)+12E]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X8_v55 (Il2CppClass<System.Object>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0a78;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X8_v55 (Il2CppClass<System.Object>)+B0]");
			object obj82 = (nint)0 + (nint)8;
			bool flag25 = flag20;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1348 @ X10_v32-8]");
				obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1348 @ X10_v32-8]");
				object obj73 = 0 - obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1348 @ X10_v32-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj27 = obj82 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X8_v55 (Il2CppClass<System.Object>)+12E]");
				obj8 = -1;
				obj73 = obj8 - 1;
				bool flag19 = obj73 == null;
				flag20 = (nint)obj8 != 1;
				flag25 = flag20;
				obj82 = obj27;
				if (flag20)
				{
					continue;
				}
				goto IL_0a78;
			}
			obj8 = obj82;
			object obj83 = num6 + obj82;
			object obj84 = obj83 + 312;
			flag20 = flag25;
			obj27 = obj82;
			goto IL_1831;
			IL_1831:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1385 @ X0_v70] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			if (enumerable5 == null)
			{
				goto IL_0d6c;
			}
			bool flag26 = obj85 == null;
			func3 = (Func<object, System.Int32Enum>)1;
			if (!flag26)
			{
				nint num7 = (nint)enumerable5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X8_v60 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Server.Models.UserFeedItem>>)+40]");
				func3 = (Func<object, System.Int32Enum>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				if (obj86 == null)
				{
					goto IL_0e5a;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1391 @ X0_v74 (System.Collections.Generic.IEnumerable`1<Server.Models.UserFeedItem>)+18]");
			if ((nint)0 != 0)
			{
				object obj87 = enumerable5 + 32;
				obj87 = obj85;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				baseUserFeedItemUI = feedItemPrefab;
				CreateItemUI(enumerable5, feedItemPrefab);
				bool flag27 = obj17 == null;
				object obj88 = !flag27;
				obj76 = obj17;
				obj22 = obj23;
				obj26 = obj27;
				baseUserFeedItemUI2 = feedItemPrefab;
				enumerable4 = enumerable5;
				if (obj88 != null)
				{
					continue;
				}
				goto IL_0bdf;
			}
			goto IL_0e13;
			IL_0a78:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			baseUserFeedItemUI = null;
			goto IL_1831;
			IL_0937:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			baseUserFeedItemUI = null;
			goto IL_179c;
		}
		if (obj17 != null)
		{
			object obj89 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			nint num8 = (nint)obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1258 @ X8_v51 (Il2CppClass<System.Object>)+12E]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1258 @ X8_v51 (Il2CppClass<System.Object>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0ceb;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1258 @ X8_v51 (Il2CppClass<System.Object>)+B0]");
			object obj90 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1369 @ X10_v26-8]");
				obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1369 @ X10_v26-8]");
				if (0 == (nint)obj89)
				{
					break;
				}
				obj27 = obj90 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1258 @ X8_v51 (Il2CppClass<System.Object>)+12E]");
				obj8 = -1;
				bool flag28 = (nint)obj8 != 1;
				obj90 = obj27;
				if (flag28)
				{
					continue;
				}
				goto IL_0ceb;
			}
			obj8 = obj90;
			object obj91 = num8 + obj90;
			object obj92 = obj91 + 312;
			obj27 = obj90;
			goto IL_189b;
		}
		goto IL_12f4;
		IL_070a:
		if (enumerable3 != null)
		{
			object obj93 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3856;
			nint num9 = (nint)enumerable3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1081 @ X8_v38 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1081 @ X8_v38 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0813;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1081 @ X8_v38 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
			object obj94 = (nint)0 + (nint)8;
			bool flag29 = flag20;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1124 @ X10_v42-8]");
				obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1124 @ X10_v42-8]");
				object obj73 = 0 - obj93;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1124 @ X10_v42-8]");
				if (0 == (nint)obj93)
				{
					break;
				}
				obj27 = obj94 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1081 @ X8_v38 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
				obj8 = -1;
				obj73 = obj8 - 1;
				bool flag19 = obj73 == null;
				flag20 = (nint)obj8 != 1;
				flag29 = flag20;
				obj94 = obj27;
				if (flag20)
				{
					continue;
				}
				goto IL_0813;
			}
			obj8 = obj94;
			object obj95 = num9 + obj94;
			object obj96 = obj95 + 312;
			flag20 = flag29;
			obj27 = obj94;
			goto IL_16f5;
		}
		NullReferenceException ex5 = new NullReferenceException();
		obj20 = obj28;
		obj22 = obj23;
		obj24 = obj25;
		obj26 = obj27;
		obj4 = obj6;
		baseUserFeedItemUI2 = baseUserFeedItemUI;
		goto IL_1381;
		IL_12f4:
		OutOfMemoryException ex6 = new OutOfMemoryException();
		obj20 = (object)(&obj17);
		obj21 = 0;
		obj22 = obj23;
		obj24 = obj25;
		obj26 = obj27;
		obj4 = obj6;
		baseUserFeedItemUI2 = baseUserFeedItemUI;
		func3 = (Func<object, System.Int32Enum>)(object)enumerable2;
		goto IL_1381;
		IL_0813:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		baseUserFeedItemUI = null;
		goto IL_16f5;
		IL_0bdf:
		NullReferenceException ex7 = new NullReferenceException();
		obj20 = (object)(&obj17);
		obj21 = 0;
		obj24 = obj25;
		obj4 = obj6;
		func3 = (Func<object, System.Int32Enum>)(object)enumerable4;
		goto IL_1381;
		IL_0d6c:
		NullReferenceException ex8 = new NullReferenceException();
		obj20 = (object)(&obj17);
		obj21 = 0;
		obj22 = obj23;
		obj24 = obj25;
		obj26 = obj27;
		obj4 = obj6;
		baseUserFeedItemUI2 = baseUserFeedItemUI;
		func3 = (Func<object, System.Int32Enum>)1;
		goto IL_1381;
		IL_12ae:
		NullReferenceException ex9 = new NullReferenceException();
		obj20 = obj28;
		obj22 = obj23;
		obj33 = obj32;
		obj24 = obj25;
		obj26 = obj27;
		obj4 = obj6;
		baseUserFeedItemUI2 = baseUserFeedItemUI;
		goto IL_1381;
		IL_0f66:
		object obj97 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		object obj98 = obj55;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X8_v17+12E]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X8_v17+12E]");
		if ((nint)0 == 0)
		{
			goto IL_101e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X8_v17+B0]");
		object obj99 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X10_v9-8]");
			obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X10_v9-8]");
			if (0 == (nint)obj97)
			{
				break;
			}
			obj27 = obj99 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X8_v17+12E]");
			obj8 = -1;
			bool flag30 = (nint)obj8 != 1;
			obj99 = obj27;
			if (flag30)
			{
				continue;
			}
			goto IL_101e;
		}
		obj8 = obj99;
		object obj100 = obj98 + obj99;
		object obj101 = obj100 + 312;
		obj27 = obj99;
		baseUserFeedItemUI = baseUserFeedItemUI2;
		goto IL_1985;
		IL_0e13:
		IndexOutOfRangeException ex10 = new IndexOutOfRangeException();
		obj20 = (object)(&obj17);
		obj21 = 0;
		obj22 = obj23;
		obj24 = obj25;
		obj26 = obj27;
		obj4 = obj6;
		baseUserFeedItemUI2 = baseUserFeedItemUI;
		goto IL_1381;
	}

	private void CreateItemUI(IEnumerable<UserFeedItem> feedItems, BaseUserFeedItemUI template)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ff: Expected O, but got I
		//IL_0133: Expected O, but got I4
		//IL_00d1: Expected O, but got I4
		//IL_00da: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_017d: Expected O, but got I4
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected O, but got Unknown
		//IL_0206: Expected O, but got I4
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63C2]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)880;
			RectTransform rectTransform = itemsList;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v18+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			RectTransform rectTransform2 = itemsList;
			if (!flag)
			{
				goto IL_00a5;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)880;
			RectTransform rectTransform = itemsList;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v18+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			RectTransform rectTransform2 = itemsList;
			if (obj7 != null)
			{
				goto IL_00a5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
		object obj9 = 0;
		goto IL_0182;
		IL_0182:
		Component component = default(Component);
		Transform transform = component.transform;
		transform.SetAsFirstSibling();
		object obj10 = component + 128;
		obj10 = feedItems;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object feedItem = Enumerable.First((IEnumerable<object>)obj10);
		((BaseUserFeedItemUI)component).Populate((UserFeedItem)feedItem);
		List<object> shownFeedItemUis = (List<object>)(object)_shownFeedItemUis;
		int version = shownFeedItemUis._version + 1;
		shownFeedItemUis._version = version;
		object[] items = shownFeedItemUis._items;
		bool flag3 = shownFeedItemUis._size < items.Length;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			int size = shownFeedItemUis._size + 1;
			shownFeedItemUis._size = size;
			object obj12 = items + shownFeedItemUis._size;
			object obj13 = obj12 + 32;
			obj13 = component;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			shownFeedItemUis.AddWithResize((object)component);
		}
		return;
		IL_00a5:
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
		bool flag4 = (object)component == null;
		object obj14 = !flag4;
		obj9 = 0;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0182;
	}

	private void DismissUserFeed(UserFeedItem feedItem)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0155: Expected O, but got I4
		//IL_00a9: Expected O, but got I
		//IL_00b9: Expected O, but got I
		//IL_0201: Expected O, but got I4
		//IL_0197: Expected O, but got I
		//IL_01a7: Expected O, but got I
		//IL_01c9: Expected O, but got I4
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected O, but got Unknown
		//IL_031f: Expected O, but got I
		//IL_0330: Expected I, but got O
		//IL_034e: Expected O, but got I
		//IL_0100: Expected O, but got I4
		//IL_0231: Expected O, but got I
		//IL_0275: Expected O, but got I4
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected I4, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 1496;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63C3]");
		object obj3 = (nint)0 & (nint)1;
		List<BaseUserFeedItemUI> list;
		List<BaseUserFeedItemUI> list2;
		object obj4;
		if (obj3 != null)
		{
			list = _shownFeedItemUis;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			list2 = _shownFeedItemUis;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			list = _shownFeedItemUis;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			list2 = _shownFeedItemUis;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v11+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v12+18]");
		Predicate<object> match = (Predicate<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v12+18]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		list = list2;
		if (obj8 != null)
		{
			goto IL_00e6;
		}
		goto IL_01df;
		IL_024b:
		List<object> list3;
		int num = list3.RemoveAll(match);
		List<BaseUserFeedItemUI> shownFeedItemUis = _shownFeedItemUis;
		object obj9 = shownFeedItemUis._size - 1;
		bool flag4 = (nint)obj9 < 0;
		int num2 = shownFeedItemUis._size ^ 1;
		int num3 = shownFeedItemUis._size ^ obj9;
		int num4 = num2 & num3;
		bool flag5 = num4 < 0;
		bool flag6 = flag4 == flag5;
		bool active = !flag6;
		placeholder.SetActive(active);
		return;
		IL_00e6:
		bool flag7 = list == null;
		object obj10 = !flag7;
		list3 = (List<object>)(object)list;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_024b;
		IL_01df:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v11+E4]");
		bool flag8 = (nint)0 == 0;
		object obj11 = !flag8;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v18+B8]");
			obj7 = 0;
		}
		object obj13 = typeof(List<Tween>) + 3088;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)2216;
		Predicate<object> predicate = default(Predicate<object>);
		predicate..ctor(obj7, (IntPtr)obj14);
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v17+B8]");
		object obj16 = (nint)0 + (nint)24;
		obj16 = predicate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		match = predicate;
		list3 = (List<object>)(object)list2;
		goto IL_024b;
		IL_0099:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v11+B8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v12+18]");
		match = (Predicate<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v12+18]");
		bool flag9 = (nint)0 == 0;
		list2 = list;
		if (!flag9)
		{
			goto IL_00e6;
		}
		goto IL_01df;
	}

	private void DismissAll()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 1504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = StartCoroutine((IEnumerator)obj2);
	}

	private IEnumerator AnimateDismissAll()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 1504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private void UpdatePlaceholder()
	{
		//IL_0018: Expected O, but got I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected I4, but got Unknown
		List<BaseUserFeedItemUI> shownFeedItemUis = _shownFeedItemUis;
		object obj = shownFeedItemUis._size - 1;
		bool flag = (nint)obj < 0;
		int num = shownFeedItemUis._size ^ 1;
		int num2 = shownFeedItemUis._size ^ obj;
		int num3 = num & num2;
		bool flag2 = num3 < 0;
		bool flag3 = flag == flag2;
		bool active = !flag3;
		placeholder.SetActive(active);
	}

	public UserFeedList()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 80;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <AnimateDismissAll>b__17_0(BaseUserFeedItemUI ui)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3952;
		object obj2 = (nint)0 + (nint)4008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		ArraysExtensions.ForEach(ui._feedItems, action);
	}

	private void <AnimateDismissAll>b__17_1(UserFeedItem feed)
	{
		eventsChannel.TriggerDismissFeed(feed);
	}
}
