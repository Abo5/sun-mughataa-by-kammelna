using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.UI;

public class ProfileGiftsDisplayer : MonoBehaviour, IProfileGiftDisplayer
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<ProfileGiftDisplayItem> <>9__6_0;

		public static Func<ProfileGiftDisplayItem, int> <>9__8_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3504;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Populate>b__6_0(ProfileGiftDisplayItem i)
		{
			GameObject gameObject = i.gameObject;
			gameObject.SetActive(value: false);
		}

		internal int <UpdateItemCountsLabel>b__8_0(ProfileGiftDisplayItem i)
		{
			//IL_0035: Expected I4, but got O
			if ((object)i != null)
			{
				return i.<ItemCount>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private sealed class <>c__DisplayClass6_0
	{
		public ProfileGiftQuantityPair[] giftsArray;

		public ProfileGiftsDisplayer <>4__this;

		internal void <Populate>b__1(ProfileGiftDisplayItem i)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			//IL_007a: Expected I, but got O
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3520;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2944;
			object obj4 = (nint)0 + (nint)2536;
			object obj5 = obj2 + 16;
			obj5 = i;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			object obj6 = Enumerable.FirstOrDefault(giftsArray, func);
			if (obj6 != null)
			{
				object obj7 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v11 (System.Object)+18]");
				((ProfileGiftDisplayItem)obj7).SetCount(0);
				GameObject gameObject = ((Component)obj5).gameObject;
				gameObject.SetActive(value: true);
			}
			else
			{
				((ProfileGiftDisplayItem)obj5).SetCount(0);
			}
		}

		internal void <Populate>b__2(ProfileGiftQuantityPair g)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected O, but got Unknown
			//IL_0068: Expected O, but got I
			//IL_0074: Expected O, but got I
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Expected O, but got Unknown
			//IL_00a3: Expected I, but got O
			//IL_0186: Expected O, but got I4
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3528;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj2 + 16;
			obj3 = g;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			ProfileGiftsDisplayer profileGiftsDisplayer = <>4__this;
			object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2912;
			object obj5 = (nint)0 + (nint)2544;
			object obj6 = (nint)0 + (nint)1096;
			object obj7 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj5);
			object obj8 = Enumerable.FirstOrDefault(profileGiftsDisplayer.items, func);
			object obj9 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v12+E4]");
			if ((nint)0 != 0)
			{
				if (!(UnityEngine.Object)obj8)
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag = (UnityEngine.Object)obj8;
				bool flag2 = !flag;
				object obj10 = !flag2;
				if (obj10 == null)
				{
					return;
				}
			}
			object obj11 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v6+18]");
			((ProfileGiftDisplayItem)obj8).SetCount(0);
			GameObject gameObject = ((Component)obj8).gameObject;
			gameObject.SetActive(value: true);
		}
	}

	private sealed class <>c__DisplayClass6_1
	{
		public ProfileGiftDisplayItem i;

		internal bool <Populate>b__3(ProfileGiftQuantityPair g)
		{
			//IL_007f: Expected I4, but got O
			//IL_005d: Expected O, but got I8
			if (g != null)
			{
				ProfileGiftDisplayItem profileGiftDisplayItem = i;
				if ((object)i != null)
				{
					object obj = g.<GiftId>k__BackingField - profileGiftDisplayItem.<GiftId>k__BackingField;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass6_2
	{
		public ProfileGiftQuantityPair g;

		internal bool <Populate>b__4(ProfileGiftDisplayItem i)
		{
			//IL_007f: Expected I4, but got O
			//IL_005d: Expected O, but got I8
			if ((object)i != null)
			{
				ProfileGiftQuantityPair profileGiftQuantityPair = g;
				if (g != null)
				{
					object obj = i.<GiftId>k__BackingField - profileGiftQuantityPair.<GiftId>k__BackingField;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass7_0
	{
		public long giftId;

		internal bool <AddCount>b__0(ProfileGiftDisplayItem i)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I8
			if ((object)i != null)
			{
				object obj = i.<GiftId>k__BackingField - giftId;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private ProfileGiftDisplayItem itemPrefab;

	private Transform layout;

	private TextMeshProUGUI countDisplayer;

	private GameObject emptyLabel;

	private List<ProfileGiftDisplayItem> items;

	public void Initialize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_0114: Expected O, but got I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00a8: Expected O, but got I
		//IL_00c1: Expected I, but got O
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 2792;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		List<ProfileGiftModel> profileGifts = Store.GetProfileGifts();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj5 = this + 64;
		obj5 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (profileGifts != null)
		{
			object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3168;
			object obj7 = (nint)0 + (nint)3504;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj7);
			((List<object>)(object)profileGifts).ForEach(action);
		}
	}

	public void Populate(IEnumerable<ProfileGiftQuantityPair> gifts, bool isMine)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0080: Expected O, but got I4
		//IL_01af: Expected O, but got I4
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_00fb: Expected O, but got I
		//IL_010b: Expected O, but got I
		//IL_0277: Expected O, but got I4
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_0205: Expected O, but got I
		//IL_0215: Expected O, but got I
		//IL_0237: Expected O, but got I4
		//IL_0503: Expected O, but got I
		//IL_0514: Expected I, but got O
		//IL_0532: Expected O, but got I
		//IL_015a: Expected O, but got I4
		//IL_02a7: Expected O, but got I
		//IL_02d5: Expected O, but got I
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_0333: Expected O, but got I4
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected O, but got Unknown
		//IL_03e2: Expected O, but got I4
		//IL_038a: Expected O, but got I4
		//IL_043d: Expected O, but got I
		//IL_0458: Expected I, but got O
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected O, but got Unknown
		//IL_047d: Expected O, but got I
		//IL_0424: Expected O, but got I4
		//IL_03a1: Expected O, but got I4
		//IL_04ad: Expected I, but got O
		//IL_04c2: Expected O, but got I
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3512;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = (nint)0 + (nint)2712;
		object obj4 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3504;
		object obj5 = obj2 + 24;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag = ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)items);
		bool flag2 = !flag;
		object obj6 = !flag2;
		List<ProfileGiftDisplayItem> list;
		List<ProfileGiftDisplayItem> list2;
		object obj7;
		if (obj6 == null)
		{
			list = items;
			obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v38+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = obj7;
			list2 = items;
			if (!flag3)
			{
				goto IL_00d7;
			}
		}
		else
		{
			Initialize();
			list = items;
			obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v38+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			object obj8 = obj7;
			list2 = items;
			if (obj9 != null)
			{
				goto IL_00d7;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj7 = obj4;
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v38+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v13+8]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v13+8]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		list = list2;
		object obj13 = obj10;
		if (obj12 != null)
		{
			goto IL_0140;
		}
		goto IL_0255;
		IL_02c9:
		object obj14 = (nint)0 + (nint)2592;
		object obj15 = typeof(TypeConverter<ushort, char>) + 3552;
		object obj16 = typeof(MemberAchievementClanFeedData) + 2976;
		List<object> list3;
		list3.ForEach(action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		object[] array = default(object[]);
		bool flag6 = array == null;
		object obj17 = !flag6;
		object[] array2 = array;
		if (obj17 == null)
		{
			object[] array3 = Enumerable.ToArray((IEnumerable<object>)gifts);
			array2 = array3;
		}
		object obj18 = obj2 + 16;
		obj18 = array2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj19 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v18+E4]");
		object obj21;
		bool flag9;
		if ((nint)0 != 0)
		{
			bool flag7 = emptyLabel != null;
			bool flag8 = !flag7;
			object obj20 = !flag8;
			if (obj20 != null)
			{
				goto IL_03f9;
			}
			obj21 = 0;
			flag9 = false;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag10 = emptyLabel != null;
			bool flag11 = !flag10;
			obj21 = 0;
			flag9 = false;
			if (!flag11)
			{
				goto IL_03f9;
			}
		}
		goto IL_0431;
		IL_0140:
		bool flag12 = list == null;
		object obj22 = !flag12;
		list3 = (List<object>)(object)list;
		if (obj22 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_02c9;
		IL_03f9:
		bool flag13 = ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)obj18);
		emptyLabel.SetActive(flag13);
		obj21 = 0;
		flag9 = flag13;
		goto IL_0431;
		IL_00d7:
		obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v38+B8]");
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v13+8]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v13+8]");
		bool flag14 = (nint)0 == 0;
		obj13 = obj10;
		list2 = list;
		if (!flag14)
		{
			goto IL_0140;
		}
		goto IL_0255;
		IL_0255:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v38+E4]");
		bool flag15 = (nint)0 == 0;
		object obj23 = !flag15;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj24 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v17+B8]");
			obj11 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj25 = (nint)0 + (nint)2504;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj11, (IntPtr)obj25);
		object obj26 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v16+B8]");
		object obj27 = (nint)0 + (nint)8;
		obj27 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		action = action2;
		obj10 = obj13;
		list3 = (List<object>)(object)list2;
		goto IL_02c9;
		IL_0431:
		object obj28 = (nint)0 + (nint)2520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj2, (IntPtr)obj28);
		object obj29 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3176;
		object obj30 = (nint)0 + (nint)2528;
		((List<object>)(object)items).ForEach(action3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action4 = default(Action<object>);
		action4..ctor(obj2, (IntPtr)obj30);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3 (System.Object)+10]");
		ArraysExtensions.ForEach((IEnumerable<object>)0, action4);
		UpdateItemCountsLabel();
	}

	public void AddCount(long giftId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0051: Expected O, but got I
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_00b8: Expected I, but got O
		//IL_0120: Expected O, but got I4
		//IL_01a8: Expected O, but got I
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = (nint)0 + (nint)2712;
		object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2912;
		object obj5 = (nint)0 + (nint)2552;
		object obj6 = (nint)0 + (nint)1096;
		object obj7 = typeof(MemberAchievementClanFeedData) + 2976;
		if (ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)items))
		{
			Initialize();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj5);
		object obj8 = Enumerable.FirstOrDefault(items, func);
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v13+E4]");
		if ((nint)0 != 0)
		{
			bool flag = (UnityEngine.Object)obj8;
			bool flag2 = !flag;
			object obj10 = !flag2;
			if (obj10 != null)
			{
				goto IL_016a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if ((bool)(UnityEngine.Object)obj8)
			{
				goto IL_016a;
			}
		}
		goto IL_01d2;
		IL_016a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v12 (System.Object)+C0]");
		int count = (int)((nint)0 + (nint)1);
		((ProfileGiftDisplayItem)obj8).SetCount(count);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v12 (System.Object)+A0]");
		Sequence sequence = ((TweenAnimation)0).PlaySequence();
		GameObject gameObject = ((Component)obj8).gameObject;
		gameObject.SetActive(value: true);
		goto IL_01d2;
		IL_01d2:
		UpdateItemCountsLabel();
	}

	private unsafe void UpdateItemCountsLabel()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b7: Expected O, but got I4
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_026f: Expected O, but got I
		//IL_027f: Expected O, but got I
		//IL_028f: Expected O, but got I
		//IL_02b9: Expected O, but got I4
		//IL_0153: Expected O, but got I4
		//IL_015c: Expected O, but got I4
		//IL_0350: Expected O, but got I4
		//IL_01e4: Expected O, but got I
		//IL_01f4: Expected O, but got I
		//IL_0204: Expected O, but got I
		//IL_022e: Expected O, but got I4
		//IL_02f9: Expected O, but got I4
		//IL_0459: Expected O, but got Ref
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Expected O, but got Unknown
		//IL_04b4: Expected O, but got I
		//IL_04c5: Expected I, but got O
		//IL_04e3: Expected O, but got I
		//IL_0393: Expected O, but got Ref
		//IL_0329: Expected O, but got I
		//IL_03a9: Expected I, but got O
		//IL_03b9: Expected O, but got I
		//IL_03e2: Expected O, but got I
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E653A]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v34+E4]");
			bool flag = (nint)0 == 0;
			obj5 = countDisplayer;
			obj6 = countDisplayer;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = countDisplayer;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v34+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = countDisplayer;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		if (obj8 == null)
		{
			goto IL_016a;
		}
		return;
		IL_032e:
		Func<object, int> selector;
		int num = Enumerable.Sum(items, selector);
		object obj10 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object[] array = default(object[]);
		object obj12;
		int num2 = default(int);
		string text;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj13;
		if (array != null)
		{
			object obj11 = default(object);
			bool flag5 = obj11 == null;
			obj12 = (object)(&num2);
			if (!flag5)
			{
				nint num3 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v14 (Il2CppClass<System.Object[]>)+40]");
				obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag6 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v14 (Il2CppClass<System.Object[]>)+40]");
				obj13 = 0;
				if (flag6)
				{
					goto IL_0474;
				}
			}
			if (array.Length != 0)
			{
				object obj14 = array + 32;
				obj14 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				TextMeshProExtensions.Localize(countDisplayer, text, array);
				return;
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			obj12 = (object)(&num2);
		}
		ex = new IndexOutOfRangeException();
		obj13 = obj12;
		goto IL_0474;
		IL_02d7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v24+E4]");
		bool flag7 = (nint)0 == 0;
		object obj15 = !flag7;
		object obj17;
		object obj18;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj16 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v22+B8]");
			obj18 = 0;
		}
		object obj19 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj20 = (nint)0 + (nint)2512;
		Func<object, int> func = default(Func<object, int>);
		func..ctor(obj18, (IntPtr)obj20);
		object obj21 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v21+B8]");
		object obj22 = (nint)0 + (nint)16;
		obj22 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		selector = func;
		object obj24;
		object obj23 = obj24;
		string text2;
		text = text2;
		goto IL_032e;
		IL_0474:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0091:
		bool flag8 = obj5 == null;
		bool flag9 = !flag8;
		obj9 = 0;
		if (!flag9)
		{
			return;
		}
		goto IL_016a;
		IL_016a:
		object obj25 = typeof(TypeConverter<ushort, char>) + 3400;
		obj17 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3504;
		object obj26 = "Read object reference Id '{0}' for {1}." + 416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj27 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v24+E4]");
		if ((nint)0 != 0)
		{
			obj23 = (nint)0 + (nint)744;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v24+B8]");
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v16+10]");
			selector = (Func<object, int>)0;
			text = (string)obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v16+10]");
			bool flag10 = (nint)0 == 0;
			object obj28 = !flag10;
			if (obj28 == null)
			{
				obj24 = obj23;
				text2 = (string)obj26;
				goto IL_02d7;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj27 = obj17;
			obj24 = (nint)0 + (nint)744;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v24+B8]");
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v16+10]");
			selector = (Func<object, int>)0;
			text2 = (string)obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v16+10]");
			bool flag11 = (nint)0 == 0;
			object obj29 = !flag11;
			obj23 = obj24;
			text = (string)obj26;
			if (obj29 == null)
			{
				goto IL_02d7;
			}
		}
		goto IL_032e;
	}

	private void <Initialize>b__5_0(ProfileGiftModel g)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0102: Expected O, but got I
		//IL_0140: Expected O, but got I4
		//IL_00dd: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01a8: Expected O, but got I
		//IL_01c6: Expected I8, but got I
		//IL_01c6: Expected O, but got I
		//IL_022e: Expected O, but got I4
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E653B]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)608;
			ProfileGiftDisplayItem profileGiftDisplayItem = itemPrefab;
			Transform transform = layout;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			Transform transform2 = layout;
			object obj6 = obj4;
			ProfileGiftDisplayItem profileGiftDisplayItem2 = itemPrefab;
			if (!flag)
			{
				goto IL_00b9;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)608;
			ProfileGiftDisplayItem profileGiftDisplayItem = itemPrefab;
			Transform transform = layout;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			Transform transform2 = layout;
			object obj6 = obj4;
			ProfileGiftDisplayItem profileGiftDisplayItem2 = itemPrefab;
			if (obj7 != null)
			{
				goto IL_00b9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		goto IL_0183;
		IL_0183:
		_ = g.ID;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v3 (System.Object)+80]");
		UIExtensions.LoadProfileGiftImage((IEnumerable<Image>)0, g.ID);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v3 (System.Object)+88]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v3 (System.Object)+B8]");
		UIExtensions.LoadProfileGiftImage((Image)num, 0L);
		List<object> list = (List<object>)(object)items;
		int version = list._version + 1;
		list._version = version;
		object[] array = list._items;
		bool flag3 = list._size < array.Length;
		object obj8 = !flag3;
		object obj11 = default(object);
		if (obj8 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj9 = array + list._size;
			object obj10 = obj9 + 32;
			obj10 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize(obj11);
		}
		return;
		IL_00b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		bool flag4 = obj11 == null;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0183;
	}
}
