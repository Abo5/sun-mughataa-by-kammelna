using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Kammelna.Server.WebRequests;
using Sfs2X.Entities;
using Spine;
using TMPro;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;

public class TopBarQuickReplies : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<StoreItem, bool> <>9__20_1;

		public static Func<StoreItem, int> <>9__20_2;

		public static Func<StoreItem, bool> <>9__29_0;

		public static Func<StoreItem, int> <>9__29_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 3320;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <Initialize>b__20_1(StoreItem i)
		{
			//IL_003d: Expected I4, but got O
			if (i != null)
			{
				return i.IsActiveAndNotAd;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal int <Initialize>b__20_2(StoreItem i)
		{
			//IL_0035: Expected I4, but got O
			if (i != null)
			{
				return i.<Order>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal bool <UpdateEmotePrices>b__29_0(StoreItem i)
		{
			//IL_003d: Expected I4, but got O
			if (i != null)
			{
				return i.IsActiveAndNotAd;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal int <UpdateEmotePrices>b__29_1(StoreItem i)
		{
			//IL_0035: Expected I4, but got O
			if (i != null)
			{
				return i.<id>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private sealed class <>c__DisplayClass20_0
	{
		public List<int> emoteOrder;

		public TopBarQuickReplies <>4__this;

		public Func<StoreItem, bool> <>9__3;

		internal unsafe void <Initialize>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0a81: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a86: Expected O, but got Unknown
			//IL_0ab0: Expected O, but got I4
			//IL_00ea: Expected O, but got I
			//IL_00fa: Expected O, but got I
			//IL_010a: Expected O, but got I
			//IL_012c: Expected O, but got I4
			//IL_01e4: Expected O, but got I4
			//IL_006f: Expected O, but got I
			//IL_007f: Expected O, but got I
			//IL_008f: Expected O, but got I
			//IL_00b1: Expected O, but got I4
			//IL_0b53: Expected O, but got I
			//IL_0b5f: Expected O, but got I
			//IL_0b6e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b73: Expected O, but got Unknown
			//IL_0b7f: Expected O, but got I
			//IL_0b8f: Expected O, but got I
			//IL_0b9f: Expected O, but got I
			//IL_0bc1: Expected O, but got I4
			//IL_0152: Expected O, but got I
			//IL_0174: Expected O, but got I4
			//IL_0acd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ad2: Expected O, but got Unknown
			//IL_0ae8: Expected O, but got I
			//IL_0af9: Expected I, but got O
			//IL_0b17: Expected O, but got I
			//IL_0b32: Expected O, but got I4
			//IL_0219: Expected O, but got I
			//IL_023b: Expected O, but got I4
			//IL_01a4: Expected O, but got I
			//IL_02d6: Expected O, but got I4
			//IL_0bde: Unknown result type (might be due to invalid IL or missing references)
			//IL_0be3: Expected O, but got Unknown
			//IL_0bf9: Expected O, but got I
			//IL_0c0a: Expected I, but got O
			//IL_0c28: Expected O, but got I
			//IL_0c43: Expected O, but got I4
			//IL_026b: Expected O, but got I
			//IL_09b5: Expected O, but got I
			//IL_05a0: Expected O, but got I
			//IL_05af: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b4: Expected O, but got Unknown
			//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c8: Expected O, but got Unknown
			//IL_05d4: Expected O, but got I
			//IL_05e0: Expected O, but got I
			//IL_032d: Expected O, but got I
			//IL_033c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0341: Expected O, but got Unknown
			//IL_0350: Unknown result type (might be due to invalid IL or missing references)
			//IL_0355: Expected O, but got Unknown
			//IL_0361: Expected O, but got I
			//IL_036d: Expected O, but got I
			//IL_0a02: Expected O, but got I
			//IL_06f0: Expected O, but got I
			//IL_070d: Expected O, but got I
			//IL_0727: Expected O, but got I4
			//IL_0cbc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cc1: Expected O, but got Unknown
			//IL_0ce3: Expected O, but got I4
			//IL_074b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0750: Expected O, but got Unknown
			//IL_0766: Expected O, but got I
			//IL_0774: Expected I, but got O
			//IL_098e: Expected O, but got I4
			//IL_07ed: Expected O, but got I
			//IL_07fa: Expected O, but got I
			//IL_0809: Unknown result type (might be due to invalid IL or missing references)
			//IL_080e: Expected O, but got Unknown
			//IL_081a: Expected O, but got I
			//IL_079e: Expected O, but got I4
			//IL_063f: Expected I, but got O
			//IL_084a: Expected O, but got Ref
			//IL_0675: Expected O, but got I4
			//IL_0686: Expected O, but got I4
			//IL_0441: Expected I, but got O
			//IL_0477: Expected O, but got I4
			//IL_06bf: Expected O, but got I4
			//IL_0491: Expected O, but got I
			//IL_04e3: Expected O, but got I4
			//IL_093c: Expected O, but got I4
			//IL_08af: Expected O, but got I4
			//IL_0521: Expected O, but got I4
			//IL_0382: Expected O, but got I
			//IL_0392: Expected O, but got I
			//IL_03a2: Expected O, but got I
			//IL_03b8: Expected O, but got I4
			//IL_0954: Expected O, but got I4
			//IL_0561: Unknown result type (might be due to invalid IL or missing references)
			//IL_0566: Expected O, but got Unknown
			//IL_056f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0574: Expected O, but got Unknown
			//IL_058f: Expected O, but got I4
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			object obj2 = typeof(SkeletonBinary.SkeletonInput) + 3320;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			IEnumerable<StoreItem> categoryItems = Store.GetCategoryItems(ItemCategory.Emotes);
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v94+E4]");
			object obj7;
			Func<object, bool> predicate;
			object obj9;
			object obj6;
			if ((nint)0 != 0)
			{
				obj6 = (nint)0 + (nint)3768;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v94+B8]");
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v56+8]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v56+8]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					obj9 = obj6;
					goto IL_0142;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj2;
				obj9 = (nint)0 + (nint)3768;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v94+B8]");
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v56+8]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v56+8]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				obj6 = obj9;
				if (obj10 == null)
				{
					goto IL_0142;
				}
			}
			goto IL_01a9;
			IL_069c:
			NullReferenceException ex = new NullReferenceException();
			List<int>.Enumerator enumerator2 = default(List<int>.Enumerator);
			List<int>.Enumerator enumerator = enumerator2;
			List<int>.Enumerator enumerator3 = enumerator2;
			enumerator2 = (List<int>.Enumerator)0;
			object obj12;
			object obj11 = obj12;
			TopBarQuickReplies topBarQuickReplies2;
			TopBarQuickReplies topBarQuickReplies = topBarQuickReplies2;
			List<object> list2 = default(List<object>);
			List<object> list = list2;
			List<object> list3;
			List<object> source = list3;
			goto IL_0c50;
			IL_0cb6:
			object obj13 = this + 32;
			Func<object, bool> func = (Func<object, bool>)obj13;
			bool flag4 = obj13 == null;
			object obj14 = !flag4;
			if (obj14 == null)
			{
				object obj15 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3432;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj16 = (nint)0 + (nint)3544;
				Func<object, bool> func2 = default(Func<object, bool>);
				func2..ctor((object)this, (IntPtr)obj16);
				<>9__3 = func2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				func = func2;
				obj11 = 0;
			}
			object obj17;
			topBarQuickReplies = (TopBarQuickReplies)obj17;
			IEnumerable<object> collection = Enumerable.Where(source, func);
			bool flag5 = list == null;
			Func<object, bool> func3 = func;
			object obj20;
			object obj21;
			if (!flag5)
			{
				object obj18 = (nint)0 + (nint)2880;
				object obj19 = (nint)0 + (nint)1800;
				obj20 = typeof(MemberAchievementClanFeedData) + 2976;
				obj21 = (nint)0 + (nint)632;
				topBarQuickReplies = (TopBarQuickReplies)obj18;
				list.AddRange(collection);
				List<object>.Enumerator enumerator4 = list.GetEnumerator();
				List<object>.Enumerator enumerator5 = default(List<object>.Enumerator);
				source = (List<object>)(&enumerator5);
				QuickPhotoReply quickPhotoReply = default(QuickPhotoReply);
				while (true)
				{
					func3 = (Func<object, bool>)obj19;
					if (enumerator5.MoveNext())
					{
						TopBarQuickReplies topBarQuickReplies3 = <>4__this;
						if ((object)<>4__this != null)
						{
							source = (List<object>)(object)topBarQuickReplies3.replayPhotoPrefab;
							object obj22 = obj20;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v763 @ X0_v31+E4]");
							bool flag6 = (nint)0 == 0;
							object obj23 = !flag6;
							if (obj23 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							topBarQuickReplies = (TopBarQuickReplies)obj21;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
							if ((object)quickPhotoReply != null)
							{
								topBarQuickReplies = <>4__this;
								quickPhotoReply.Setup(null, <>4__this);
								list = null;
								continue;
							}
							NullReferenceException ex2 = new NullReferenceException();
							enumerator2 = (List<int>.Enumerator)0;
							func3 = (Func<object, bool>)(object)topBarQuickReplies3.photoReplayPanel;
							list = null;
							break;
						}
						NullReferenceException ex3 = new NullReferenceException();
						enumerator2 = (List<int>.Enumerator)0;
						break;
					}
					enumerator5.Dispose();
					return;
				}
			}
			goto IL_0c50;
			IL_0c50:
			NullReferenceException ex4 = new NullReferenceException();
			obj17 = (nint)0 + (nint)3768;
			bool flag7 = (nint)func3 != 1;
			OutOfMemoryException ex5 = (OutOfMemoryException)(object)ex4;
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				object obj24 = (nint)0 + (nint)2384;
				func3 = (Func<object, bool>)obj24;
				enumerator.Dispose();
				object obj25 = default(object);
				bool flag8 = obj25 == null;
				enumerator2 = (List<int>.Enumerator)obj25;
				if (flag8)
				{
					goto IL_0cb6;
				}
				ex5 = new OutOfMemoryException();
				enumerator2 = (List<int>.Enumerator)obj25;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CBC9E0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_01a9:
			IEnumerable<object> source2 = Enumerable.Where(categoryItems, predicate);
			object obj26 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v11+E4]");
			bool flag9 = (nint)0 == 0;
			object obj27 = !flag9;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj26 = obj2;
			}
			object obj28 = (nint)0 + (nint)2232;
			obj21 = (nint)0 + (nint)2720;
			obj20 = typeof(List<AdaptivePerformanceScaler>) + 3592;
			object obj29 = (nint)0 + (nint)2864;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v11+B8]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v47+10]");
			Func<object, int> keySelector = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v47+10]");
			bool flag10 = (nint)0 == 0;
			object obj31 = !flag10;
			object[] array;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v11+E4]");
				array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v11+E4]");
				bool flag11 = (nint)0 == 0;
				object obj32 = !flag11;
				if (obj32 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj33 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v53+B8]");
					obj30 = 0;
				}
				object obj34 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3448;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj35 = (nint)0 + (nint)3512;
				Func<object, int> func4 = default(Func<object, int>);
				func4..ctor(obj30, (IntPtr)obj35);
				object obj36 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v52+B8]");
				object obj37 = (nint)0 + (nint)16;
				obj37 = func4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj11 = 0;
				keySelector = func4;
			}
			topBarQuickReplies = (TopBarQuickReplies)obj28;
			IOrderedEnumerable<object> source3 = Enumerable.OrderBy(source2, keySelector);
			list3 = Enumerable.ToList(source3);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			func3 = (Func<object, bool>)obj29;
			list2..ctor();
			bool flag12 = emoteOrder == null;
			enumerator = (List<int>.Enumerator)0;
			list = list2;
			source = list3;
			if (flag12)
			{
				goto IL_0c50;
			}
			List<int>.Enumerator enumerator6 = emoteOrder.GetEnumerator();
			List<int>.Enumerator enumerator7 = default(List<int>.Enumerator);
			if (list2 != null)
			{
				obj21 = (nint)0 + (nint)2392;
				obj28 = typeof(SkeletonBinary.SkeletonInput) + 3336;
				object obj38 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3432;
				object obj39 = (nint)0 + (nint)3552;
				obj20 = (nint)0 + (nint)1256;
				object obj40 = default(object);
				Func<object, bool> func5 = default(Func<object, bool>);
				while (enumerator7.MoveNext())
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					obj40..ctor();
					bool flag13 = obj40 == null;
					func3 = null;
					if (!flag13)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						func5..ctor(obj40, (IntPtr)obj39);
						topBarQuickReplies = (TopBarQuickReplies)obj20;
						object obj41 = Enumerable.FirstOrDefault(list3, func5);
						bool flag14 = obj41 == null;
						obj11 = 0;
						if (flag14)
						{
							continue;
						}
						object obj42 = (nint)0 + (nint)2872;
						object obj43 = obj42;
						int version = list2._version + 1;
						list2._version = version;
						array = list2._items;
						bool flag15 = list2._items == null;
						obj12 = 0;
						topBarQuickReplies2 = (TopBarQuickReplies)obj20;
						func3 = (Func<object, bool>)obj41;
						if (!flag15)
						{
							bool flag16 = list2._size < array.Length;
							object obj44 = !flag16;
							if (obj44 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X8_v42+20]");
								object obj45 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X8_v44+C0]");
								object obj46 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v45+70]");
								topBarQuickReplies = (TopBarQuickReplies)0;
								list2.AddWithResize(obj41);
								obj11 = 0;
							}
							else
							{
								int size = list2._size + 1;
								list2._size = size;
								object obj47 = list2._items + list2._size;
								object obj48 = obj47 + 32;
								obj48 = obj41;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								obj11 = 0;
							}
							continue;
						}
						goto IL_069c;
					}
					goto IL_096b;
				}
			}
			else
			{
				object obj49 = (nint)0 + (nint)2392;
				obj20 = typeof(SkeletonBinary.SkeletonInput) + 3336;
				obj21 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3432;
				obj28 = (nint)0 + (nint)3552;
				object obj38 = (nint)0 + (nint)1256;
				object obj50 = default(object);
				Func<object, bool> func6 = default(Func<object, bool>);
				while (enumerator7.MoveNext())
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					obj50..ctor();
					bool flag17 = obj50 == null;
					func3 = null;
					if (!flag17)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						func6..ctor(obj50, (IntPtr)obj28);
						topBarQuickReplies2 = (TopBarQuickReplies)obj38;
						object obj51 = Enumerable.FirstOrDefault(list3, func6);
						bool flag18 = obj51 == null;
						obj12 = 0;
						func3 = func6;
						obj11 = 0;
						topBarQuickReplies = (TopBarQuickReplies)obj38;
						if (flag18)
						{
							continue;
						}
						goto IL_069c;
					}
					goto IL_096b;
				}
			}
			object obj52 = (nint)0 + (nint)2384;
			func3 = (Func<object, bool>)obj52;
			enumerator7.Dispose();
			obj17 = (nint)0 + (nint)3768;
			enumerator = enumerator2;
			enumerator3 = enumerator2;
			enumerator2 = (List<int>.Enumerator)0;
			list = list2;
			source = list3;
			goto IL_0cb6;
			IL_096b:
			NullReferenceException ex6 = new NullReferenceException();
			enumerator = enumerator2;
			enumerator3 = enumerator2;
			enumerator2 = (List<int>.Enumerator)0;
			list = list2;
			source = list3;
			goto IL_0c50;
			IL_0142:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v94+E4]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v94+E4]");
			bool flag19 = (nint)0 == 0;
			object obj53 = !flag19;
			if (obj53 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj54 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v62+B8]");
				obj7 = 0;
			}
			object obj55 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3432;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj56 = (nint)0 + (nint)3504;
			Func<object, bool> func7 = default(Func<object, bool>);
			func7..ctor(obj7, (IntPtr)obj56);
			object obj57 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v61+B8]");
			object obj58 = (nint)0 + (nint)8;
			obj58 = func7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj11 = 0;
			obj6 = obj9;
			predicate = func7;
			goto IL_01a9;
		}

		internal bool <Initialize>b__3(StoreItem i)
		{
			//IL_005e: Expected I4, but got O
			if (i != null && emoteOrder != null)
			{
				bool flag = emoteOrder.Contains(i.<id>k__BackingField);
				return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass20_1
	{
		public int savedId;

		internal bool <Initialize>b__4(StoreItem i)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (i != null)
			{
				object obj = i.<id>k__BackingField - savedId;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass28_0
	{
		public TopBarQuickReplies <>4__this;

		public StoreItem item;

		public AnimatedItemController controller;

		internal void <BuyEmote>b__0(KammelnaResponseModel<BuyItemResponseModel> callback)
		{
			//IL_0156: Unknown result type (might be due to invalid IL or missing references)
			//IL_015b: Expected O, but got Unknown
			//IL_004d: Expected O, but got I4
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected O, but got Unknown
			//IL_00d4: Expected O, but got I4
			//IL_0138: Expected F8, but got I4
			bool succeeded = ((KammelnaResponseModel<object>)(object)callback).Succeeded;
			if (succeeded)
			{
				StoreItem storeItem = item;
				((TopBarQuickReplies)succeeded).IncrementEmoteUsage(storeItem.<id>k__BackingField);
				StoreItem storeItem2 = item;
				controller.NotifyEmoteSent(storeItem2.<id>k__BackingField);
				int num = default(int);
				string emoteID = num.ToString();
				ITrackEvent trackEvent = TrackerLibrary.GameEmoteSent(emoteID);
				object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v15+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Tracker.DesignEvent(trackEvent);
				StoreItem storeItem3 = item;
				string itemId = Tracker.BuildItemId(ResourceItemId.Emote, storeItem3.<name>k__BackingField);
				int num2 = StorePricing.EffectivePrice(item);
				Tracker.ResourceEvent(ResourceFlowType.Sink, ResourceItemType.Cosmetic, itemId, num2, ResourceCurrency.Aces);
			}
			else
			{
				ITrackEvent trackEvent2 = TrackerLibrary.GameEmoteSentError(TrackerLibrary.EmoteSentErrorType.BuyError);
				object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v8+E4]");
				if ((nint)0 != 0)
				{
					Tracker.DesignEvent(trackEvent2);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Tracker.DesignEvent(trackEvent2);
			}
		}
	}

	private TextMeshProUGUI coinsText;

	private GameObject coinsRoot;

	private RectTransform textReplyPanel;

	private RectTransform textReplyGrid;

	private RectTransform photoReplayPanel;

	private RectTransform photoReplayRoot;

	private QuickPhotoReply replayPhotoPrefab;

	private ReplyButton replyButtonPrefab;

	private SlideAnimationHelper popup;

	private SlideAnimationHelper onlyForSubscribersMessage;

	private ContainerItemSelector replayTypeSelector;

	private SlideAnimationHelper emoteActionMessage;

	private TextMeshProUGUI emoteActionText;

	private GameEventsChannel gameEventsChannel;

	protected KGame game;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0189: Expected O, but got I
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01a9: Expected O, but got I
		//IL_01d3: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_006c: Expected I, but got O
		//IL_009d: Expected I, but got O
		//IL_00ae: Expected O, but got I
		//IL_00da: Expected I, but got O
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00ff: Expected O, but got I
		//IL_012b: Expected I, but got O
		//IL_013c: Expected O, but got I
		//IL_0168: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)136;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)176;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 144;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj4);
		gameEventsChannel.CloseQuickReplies += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj4);
		object obj9 = (nint)0 + (nint)200;
		gameEventsChannel.OnPanelShow += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj9);
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
		object obj11 = (nint)0 + (nint)192;
		gameEventsChannel.ShowQuickRepliesForSubscribersMessage += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action4 = default(Action<int>);
		action4..ctor((object)this, (IntPtr)obj11);
		object obj12 = (nint)0 + (nint)208;
		replayTypeSelector.OnSelectionChanged += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action5 = default(Action);
		action5..ctor(this, (IntPtr)obj12);
		StorePricing.OnPricingChanged += action5;
		SetupRepliesButtons();
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)184;
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Store.CallWhenLoaded(action);
	}

	private void ReplayTypeSelector_OnSelectionChanged(int index)
	{
		//IL_0157: Expected O, but got I4
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_01ac: Expected O, but got I4
		//IL_004b: Expected O, but got I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_00a0: Expected O, but got I4
		if (index == 1)
		{
			UpdateEmotePrices();
			GameObject gameObject = photoReplayRoot.gameObject;
			bool activeSelf = gameObject.activeSelf;
			bool flag = !activeSelf;
			object obj = !flag;
			if (obj == null)
			{
				ITrackEvent trackEvent = TrackerLibrary.GameQuickReplyEmoteClicked();
				object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v11+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Tracker.DesignEvent(trackEvent);
			}
			GameObject gameObject2 = textReplyPanel.gameObject;
			gameObject2.SetActive(value: false);
			GameObject gameObject3 = photoReplayRoot.gameObject;
			gameObject3.SetActive(value: true);
			coinsRoot.SetActive(value: true);
			return;
		}
		GameObject gameObject4 = textReplyPanel.gameObject;
		bool activeSelf2 = gameObject4.activeSelf;
		bool flag3 = !activeSelf2;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			ITrackEvent trackEvent2 = TrackerLibrary.GameQuickReplyTextClicked();
			object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v7+E4]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent2);
		}
		coinsRoot.SetActive(value: false);
		GameObject gameObject5 = textReplyPanel.gameObject;
		gameObject5.SetActive(value: true);
		GameObject gameObject6 = photoReplayRoot.gameObject;
		gameObject6.SetActive(value: false);
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0143: Expected I, but got O
		//IL_0051: Expected I, but got O
		//IL_0062: Expected O, but got I
		//IL_008e: Expected I, but got O
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00b3: Expected O, but got I
		//IL_00df: Expected I, but got O
		//IL_00f0: Expected O, but got I
		//IL_011c: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)176;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		gameEventsChannel.CloseQuickReplies -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)200;
		gameEventsChannel.OnPanelShow -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj3);
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
		object obj5 = (nint)0 + (nint)192;
		gameEventsChannel.ShowQuickRepliesForSubscribersMessage -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action4 = default(Action<int>);
		action4..ctor((object)this, (IntPtr)obj5);
		object obj6 = (nint)0 + (nint)208;
		replayTypeSelector.OnSelectionChanged -= action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action5 = default(Action);
		action5..ctor(this, (IntPtr)obj6);
		StorePricing.OnPricingChanged -= action5;
	}

	private void SetupRepliesButtons()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0081: Expected O, but got I
		//IL_00ac: Expected O, but got I4
		//IL_004e: Expected I, but got O
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2080;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1680;
		object obj3 = (nint)0 + (nint)168;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IEnumerable<CommonWord> words = CommonWordDictionary.Words;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj3);
		ArraysExtensions.ForEach(words, action);
	}

	private void Initialize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0080: Expected O, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_0122: Expected O, but got I
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_01a2: Expected I, but got O
		//IL_01d1: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 848;
		object obj4 = (nint)0 + (nint)2200;
		object obj5 = obj2 + 24;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object varName = "___# Content push apply failed [{0}]: {1}" + 2920;
		object defaultValue = "Material with texture name \"" + 3392;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		VariableBinderExtensions.Bind(coinsText, localUser, (string)varName, (string)defaultValue);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj8 = typeof(SqlSingle[]) + 2376;
		object obj9 = (nint)0 + (nint)3536;
		object obj10 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser2);
		List<int> personalizedEmotes = EmoteSaveData.GetPersonalizedEmotes(intDbId);
		object obj11 = obj2 + 16;
		obj11 = personalizedEmotes;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj9);
		object obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v25+E4]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Store.CallWhenLoaded(action);
	}

	private void IncrementEmoteUsage(int emoteId)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00df: Expected O, but got I
		//IL_0109: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0152: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E76C7]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
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
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		User localUser = sessionModel.LocalUser;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
		EmoteSaveData.IncrementEmoteUsage(emoteId, intDbId);
	}

	public void Toggle()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00e8: Expected O, but got I4
		//IL_00a4: Expected O, but got I4
		object obj = typeof(UsageHint) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E76C8]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UserInfo.ClickedOnEmotesButton = true;
		SlideAnimationHelper slideAnimationHelper = popup;
		goto IL_011f;
		IL_011f:
		if (slideAnimationHelper.<IsShown>k__BackingField)
		{
			slideAnimationHelper.SlideOut();
			emoteActionMessage.SlideOut();
		}
		else
		{
			Open();
		}
		return;
		IL_0074:
		UserInfo.ClickedOnEmotesButton = true;
		slideAnimationHelper = popup;
		bool flag2 = (object)popup == null;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_011f;
	}

	public void Open()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0070: Expected O, but got I4
		//IL_0104: Expected O, but got I4
		gameEventsChannel.TriggerPanelShow();
		popup.SlideIn();
		GameObject gameObject = photoReplayRoot.gameObject;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		bool activeInHierarchy = gameObject.activeInHierarchy;
		bool flag = !activeInHierarchy;
		object obj2 = !flag;
		ITrackEvent trackEvent;
		ITrackEvent trackEvent2;
		if (obj2 == null)
		{
			trackEvent = TrackerLibrary.GameQuickReplyPanelOpened();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v3+E4]");
			bool flag2 = (nint)0 == 0;
			trackEvent2 = trackEvent;
			if (!flag2)
			{
				goto IL_00bc;
			}
		}
		else
		{
			UpdateEmotePrices();
			trackEvent = TrackerLibrary.GameQuickReplyPanelOpened();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			trackEvent2 = trackEvent;
			if (obj4 != null)
			{
				goto IL_00bc;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent2);
		return;
		IL_00bc:
		Tracker.DesignEvent(trackEvent);
	}

	public void Close()
	{
		SlideAnimationHelper slideAnimationHelper = popup;
		if (slideAnimationHelper.<IsShown>k__BackingField)
		{
			slideAnimationHelper.SlideOut();
			emoteActionMessage.SlideOut();
		}
	}

	private void ShowForSubscribersMessage()
	{
		onlyForSubscribersMessage.SlideIn();
	}

	public void ShowNotEnoughAcesMessage()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object text = "not" + 88;
		TextMeshProExtensions.Localize(emoteActionText, (string)text);
		emoteActionMessage.SlideIn();
	}

	public void ShowOnlyForPlayersMessage()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object text = "October" + 872;
		TextMeshProExtensions.Localize(emoteActionText, (string)text);
		emoteActionMessage.SlideIn();
	}

	public void BuyEmote(StoreItem item)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_02cb: Expected O, but got I
		//IL_02e5: Expected O, but got I4
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00b2: Expected O, but got I
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_0337: Expected O, but got I4
		//IL_012c: Expected O, but got I
		//IL_013c: Expected O, but got I
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_016d: Expected O, but got I
		//IL_01a0: Expected O, but got I4
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_03d6: Expected O, but got I
		//IL_0232: Expected O, but got I4
		//IL_0402: Expected O, but got I
		//IL_028e: Expected O, but got I4
		//IL_076b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_079a: Expected O, but got I4
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected O, but got Unknown
		//IL_0431: Expected O, but got I
		//IL_0442: Expected I, but got O
		//IL_0462: Expected O, but got I
		//IL_047a: Expected O, but got I
		//IL_05fd: Expected O, but got I
		//IL_060d: Expected O, but got I
		//IL_0623: Expected O, but got I
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Expected O, but got Unknown
		//IL_064b: Expected O, but got I4
		//IL_065b: Expected O, but got I
		//IL_04af: Expected O, but got I
		//IL_04c5: Expected O, but got I
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected O, but got Unknown
		//IL_04f2: Expected O, but got I
		//IL_06bd: Expected O, but got I
		//IL_06cd: Expected O, but got I
		//IL_06e3: Expected O, but got I
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f1: Expected O, but got Unknown
		//IL_0695: Expected O, but got I4
		//IL_0535: Expected O, but got I
		//IL_0545: Expected O, but got I
		//IL_055b: Expected O, but got I
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Expected O, but got Unknown
		//IL_0583: Expected O, but got I4
		//IL_0593: Expected O, but got I
		//IL_05c0: Expected O, but got I
		//IL_05e2: Expected O, but got I4
		//IL_071e: Expected O, but got I
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 3832;
		object obj4 = obj2 + 16;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 24;
		obj5 = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v11+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
			object obj7 = (nint)0 & (nint)1;
			if (obj7 != null)
			{
				goto IL_00cf;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
			object obj8 = (nint)0 & (nint)1;
			bool flag = obj8 == null;
			object obj9 = !flag;
			if (obj9 != null)
			{
				goto IL_00cf;
			}
		}
		_ = 1;
		object obj10 = typeof(Queue<string>) + 848;
		object obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v21+E4]");
		bool flag2 = (nint)0 == 0;
		object obj12 = !flag2;
		object obj13 = obj10;
		object obj14 = obj11;
		if (obj12 != null)
		{
			goto IL_0120;
		}
		goto IL_0355;
		IL_05a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_05b0;
		IL_06a3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X20_v6+38]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v28+10]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v28+10]");
		object obj17 = (nint)0 + (nint)309;
		object obj18 = obj17 & 1;
		if (obj18 == null)
		{
			goto IL_05a1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v28+10]");
		object obj19 = 0;
		goto IL_05b0;
		IL_0500:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v47+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0525;
		}
		goto IL_06a3;
		IL_00cf:
		obj10 = typeof(Queue<string>) + 848;
		obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v21+E4]");
		bool flag3 = (nint)0 == 0;
		obj13 = obj10;
		obj14 = obj11;
		if (!flag3)
		{
			goto IL_0120;
		}
		goto IL_0355;
		IL_0355:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj11 = obj3;
		obj10 = obj13;
		goto IL_0120;
		IL_0120:
		object obj20 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v21+B8]");
		object obj21 = 0;
		object obj22 = obj2 + 32;
		obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X22_v8-8]");
		int num = StorePricing.EffectivePrice((StoreItem)0);
		object obj23 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v26+E4]");
		bool flag4 = (nint)0 == 0;
		object obj24 = !flag4;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int aces = SFSKammelnaUserExtensions.GetAces(localUser);
		TrackerLibrary.EmoteSentErrorType error;
		Action<object> action = default(Action<object>);
		IClientContext clientContext;
		if (num > aces)
		{
			object text = "not" + 88;
			TextMeshProExtensions.Localize(emoteActionText, (string)text);
			emoteActionMessage.SlideIn();
			object obj25 = 0;
			error = TrackerLibrary.EmoteSentErrorType.NotEnoughAces;
		}
		else
		{
			if (!((AnimatedItemController)obj22).isSpectator)
			{
				SlideAnimationHelper slideAnimationHelper = popup;
				if (slideAnimationHelper.<IsShown>k__BackingField)
				{
					slideAnimationHelper.SlideOut();
					emoteActionMessage.SlideOut();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7000]");
				object obj26 = 0;
				KGame kGame = game;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v18+10]");
				kGame.FakeEmoteSent(0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7000]");
				object obj27 = 0;
				object obj28 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 504;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj29 = (nint)0 + (nint)3560;
				action..ctor(obj2, (IntPtr)obj29);
				clientContext = KGameExtensions.GetClientContext(game);
				object obj30 = (nint)0 + (nint)3176;
				object obj31 = obj30;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X20_v6+38]");
				object obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X20_v6+38]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v26+10]");
					object obj33 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v26+10]");
					object obj34 = (nint)0 + (nint)309;
					object obj35 = obj34 & 1;
					bool flag5 = obj35 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v26+10]");
					object obj36 = 0;
					if (!flag5)
					{
						goto IL_0500;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X20_v6+38]");
					object obj37 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v33+10]");
					object obj33 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v33+10]");
					object obj38 = (nint)0 + (nint)309;
					object obj39 = obj38 & 1;
					bool flag6 = obj39 == null;
					object obj40 = !flag6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v33+10]");
					object obj36 = 0;
					if (obj40 != null)
					{
						goto IL_0500;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v47+E4]");
				bool flag7 = (nint)0 == 0;
				object obj41 = !flag7;
				if (obj41 != null)
				{
					goto IL_0525;
				}
				goto IL_06a3;
			}
			object text2 = "October" + 872;
			TextMeshProExtensions.Localize(emoteActionText, (string)text2);
			emoteActionMessage.SlideIn();
			object obj25 = 0;
			error = TrackerLibrary.EmoteSentErrorType.IsNotPlayer;
		}
		ITrackEvent trackEvent = TrackerLibrary.GameEmoteSentError(error);
		object obj42 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj43 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v16+E4]");
		bool flag8 = (nint)0 == 0;
		object obj44 = !flag8;
		if (obj44 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		return;
		IL_05b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X0_v55+B8]");
		object recipients = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v19+10]");
		KammelnaRequests.BuyItem(0, action, clientContext, (int?)(object)0, (long[])recipients);
		return;
		IL_0525:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X20_v6+38]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v40+10]");
		obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v40+10]");
		object obj46 = (nint)0 + (nint)309;
		object obj47 = obj46 & 1;
		bool flag9 = obj47 == null;
		object obj48 = !flag9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v40+10]");
		obj19 = 0;
		if (obj48 == null)
		{
			goto IL_05a1;
		}
		goto IL_05b0;
	}

	private void UpdateEmotePrices()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d6: Expected O, but got I4
		//IL_0093: Expected O, but got I4
		//IL_0121: Expected O, but got I
		//IL_0155: Expected O, but got I4
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_0258: Expected O, but got I
		//IL_0268: Expected O, but got I
		//IL_028a: Expected O, but got I4
		//IL_029a: Expected O, but got I
		//IL_0655: Expected O, but got I
		//IL_01d1: Expected O, but got I
		//IL_01e1: Expected O, but got I
		//IL_0203: Expected O, but got I4
		//IL_03e6: Expected O, but got I
		//IL_03f6: Expected O, but got I
		//IL_0418: Expected O, but got I4
		//IL_0438: Expected O, but got I
		//IL_02d2: Expected O, but got I4
		//IL_038d: Expected O, but got I
		//IL_03b1: Expected O, but got I4
		//IL_032c: Expected O, but got I
		//IL_033c: Expected O, but got I
		//IL_0373: Expected O, but got I
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Expected O, but got Unknown
		//IL_06bd: Expected O, but got I
		//IL_06ce: Expected I, but got O
		//IL_06ec: Expected O, but got I
		//IL_0231: Expected O, but got I
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected O, but got Unknown
		//IL_0456: Expected O, but got I
		//IL_0478: Expected O, but got I4
		//IL_0302: Expected O, but got I
		//IL_0712: Unknown result type (might be due to invalid IL or missing references)
		//IL_0717: Expected O, but got Unknown
		//IL_072d: Expected O, but got I
		//IL_073e: Expected I, but got O
		//IL_075c: Expected O, but got I
		//IL_04b9: Expected O, but got I
		//IL_04a8: Expected O, but got I
		//IL_0524: Expected O, but got I
		//IL_052d: Expected O, but got I4
		//IL_0577: Expected O, but got I
		//IL_058c: Expected O, but got I
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Expected O, but got Unknown
		//IL_05e8: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E76CA]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v54+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v54+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (Store.IsLoaded)
		{
			goto IL_0115;
		}
		return;
		IL_0381:
		object obj5 = (nint)0 + (nint)1592;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DE5C6C");
		object obj6 = default(object);
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			goto IL_04c8;
		}
		goto IL_0642;
		IL_04c8:
		object obj8 = obj6 + 32;
		Dictionary<int, object> dictionary = default(Dictionary<int, object>);
		if (dictionary != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v6+18]");
			if ((nint)0 < (nint)1)
			{
				return;
			}
			object obj9 = (nint)0 + (nint)1648;
			object obj10 = 0;
			int num2 = default(int);
			object obj15;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X22_v6+v211 @ X23_v7*8]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X21_v8+48]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v18+10]");
				if (dictionary.TryGetValue(0, out var value))
				{
					int num = StorePricing.EffectivePrice((StoreItem)value);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X21_v8+28]");
					object obj13 = 0;
					string text = num2.ToString();
					object obj14 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v445 @ X8_v19+558] (should have been resolved before IL gen)");
					num2 = num;
				}
				obj10++;
				obj15 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v6+18]");
			}
			while ((nint)obj15 < 0);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v6+18]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		goto IL_0642;
		IL_0649:
		object obj16 = (nint)0 + (nint)3768;
		IEnumerable<object> source;
		Func<object, bool> predicate;
		IEnumerable<object> enumerable = Enumerable.Where(source, predicate);
		object obj18;
		object obj17 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v25+E4]");
		object obj19;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v25+B8]");
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v23+20]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v23+20]");
			bool flag3 = (nint)0 == 0;
			IEnumerable<object> enumerable2 = enumerable;
			IEnumerable<object> enumerable3 = enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v23+20]");
			object obj21 = 0;
			if (!flag3)
			{
				goto IL_0381;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v25+B8]");
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v23+20]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v23+20]");
			bool flag4 = (nint)0 == 0;
			object obj22 = !flag4;
			IEnumerable<object> enumerable2 = enumerable;
			IEnumerable<object> enumerable3 = enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v23+20]");
			object obj21 = 0;
			if (obj22 != null)
			{
				goto IL_0381;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v25+E4]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v25+E4]");
		bool flag5 = (nint)0 == 0;
		object obj24 = !flag5;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj25 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v31+B8]");
			obj19 = 0;
		}
		object obj26 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj27 = (nint)0 + (nint)3528;
		Func<object, int> func = default(Func<object, int>);
		func..ctor(obj19, (IntPtr)obj27);
		object obj28 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v28+B8]");
		object obj29 = (nint)0 + (nint)32;
		obj29 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj30 = (nint)0 + (nint)1592;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DE5C6C");
		goto IL_04c8;
		IL_0074:
		bool isLoaded = Store.IsLoaded;
		bool flag6 = !isLoaded;
		object obj31 = !flag6;
		if (obj31 == null)
		{
			return;
		}
		goto IL_0115;
		IL_0115:
		object obj32 = (nint)0 + (nint)712;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31C20");
		object obj33 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X0_v7+E4]");
		bool flag7 = (nint)0 == 0;
		object obj34 = !flag7;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IEnumerable<StoreItem> categoryItems = Store.GetCategoryItems(ItemCategory.Emotes);
		obj18 = typeof(SkeletonBinary.SkeletonInput) + 3320;
		object obj35 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v38+E4]");
		object obj37;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v38+B8]");
			obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X9_v8+18]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X9_v8+18]");
			bool flag8 = (nint)0 == 0;
			object obj36 = !flag8;
			source = categoryItems;
			if (obj36 == null)
			{
				obj37 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X9_v8+18]");
				Func<object, bool> func2 = (Func<object, bool>)0;
				goto IL_02b0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj35 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v38+B8]");
			obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X9_v11+18]");
			Func<object, bool> func2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X9_v11+18]");
			bool flag9 = (nint)0 == 0;
			object obj38 = !flag9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X9_v11+18]");
			predicate = (Func<object, bool>)0;
			source = categoryItems;
			if (obj38 == null)
			{
				goto IL_02b0;
			}
		}
		goto IL_0649;
		IL_0642:
		throw new NullReferenceException();
		IL_02b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v38+E4]");
		bool flag10 = (nint)0 == 0;
		object obj39 = !flag10;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj40 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v45+B8]");
			obj37 = 0;
		}
		object obj41 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj42 = (nint)0 + (nint)3520;
		Func<object, bool> func3 = default(Func<object, bool>);
		func3..ctor(obj37, (IntPtr)obj42);
		object obj43 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v44+B8]");
		object obj44 = (nint)0 + (nint)24;
		obj44 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		predicate = func3;
		source = categoryItems;
		goto IL_0649;
	}

	private void <SetupRepliesButtons>b__19_0(CommonWord word)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0056: Expected O, but got I
		//IL_0080: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)1016;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
		ReplyButton replyButton = default(ReplyButton);
		replyButton.Populate(word, isTop4: false);
	}
}
