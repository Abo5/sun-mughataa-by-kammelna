using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using ListView;
using Mono.Btls;
using Unity.Properties;
using UnityEngine;

public class ProfileGiftsDisplayerListView : UiListView<ProfileGiftDataHolder, ProfileGiftDisplayItem>, IProfileGiftDisplayer
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ProfileGiftQuantityPair, long> <>9__9_0;

		public static Action<ProfileGiftDisplayItem> <>9__12_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3544;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal long <SetItems>b__9_0(ProfileGiftQuantityPair a)
		{
			//IL_0035: Expected I8, but got O
			if (a != null)
			{
				return a.<GiftId>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (long)ex;
		}

		internal void <AddCount>b__12_1(ProfileGiftDisplayItem i)
		{
			((ListViewItem<object, int>)(object)i).ForceRefresh();
		}
	}

	private sealed class <>c__DisplayClass10_0
	{
		public float size;

		internal void <SetTemplateSizes>b__0(ProfileGiftDataHolder d)
		{
			d.<Width>k__BackingField = size;
		}
	}

	private sealed class <>c__DisplayClass12_0
	{
		public long giftId;

		internal bool <AddCount>b__0(ProfileGiftDataHolder i)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I8
			if (i != null)
			{
				object obj = i.<GiftId>k__BackingField - giftId;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass9_0
	{
		public ProfileGiftsDisplayerListView <>4__this;

		public float size;

		internal ProfileGiftDataHolder <SetItems>b__1(ProfileGiftQuantityPair g)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_008c: Expected I4, but got I8
			ProfileGiftsDisplayerListView profileGiftsDisplayerListView = <>4__this;
			if ((object)<>4__this != null)
			{
				object obj = typeof(System.Buffers.Text.ParserHelpers) + 2192;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj2 = default(object);
				obj2..ctor();
				if (g != null)
				{
					_ = g.<Quantity>k__BackingField;
					_ = g.<GiftId>k__BackingField;
					_ = size;
					_ = 0;
					_ = profileGiftsDisplayerListView.<IsMine>k__BackingField;
					int num = UnityEngine.Random.Range(-10, 10);
					return (ProfileGiftDataHolder)obj2;
				}
			}
			return (ProfileGiftDataHolder)(object)new NullReferenceException();
		}
	}

	private GameObject emptyLabel;

	private float[] CountToSize;

	private int minCountToLoop;

	private bool <IsMine>k__BackingField;

	private bool IsMine
	{
		get
		{
			return <IsMine>k__BackingField;
		}
		set
		{
			<IsMine>k__BackingField = value;
		}
	}

	protected override bool loopScroll
	{
		get
		{
			//IL_005a: Expected I4, but got O
			List<ProfileGiftDataHolder> list = base.data;
			if (list != null)
			{
				if (list._size < minCountToLoop)
				{
					return false;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ProfileGiftsDisplayerListView)+F0]");
				return (byte)((nuint)0u & (nuint)1u) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public void SetItems(IEnumerable<ProfileGiftQuantityPair> gifts, bool isMine)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0100: Expected O, but got I
		//IL_013b: Expected O, but got I4
		//IL_00ef: Expected I, but got O
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0209: Expected O, but got I
		//IL_0219: Expected O, but got I
		//IL_023b: Expected O, but got I4
		//IL_02ac: Expected O, but got I
		//IL_02b4: Expected I4, but got O
		//IL_01a2: Expected O, but got I
		//IL_01b2: Expected O, but got I
		//IL_01d4: Expected O, but got I4
		//IL_0312: Expected O, but got I4
		//IL_0322: Expected O, but got I4
		//IL_038d: Expected O, but got I4
		//IL_026b: Expected O, but got I4
		//IL_05e0: Expected O, but got I4
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Expected O, but got Unknown
		//IL_053c: Expected O, but got I
		//IL_054d: Expected I, but got O
		//IL_056b: Expected O, but got I
		//IL_0582: Expected I, but got O
		//IL_0612: Expected O, but got I4
		//IL_029b: Expected O, but got I
		//IL_03ba: Expected O, but got I4
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected O, but got Unknown
		//IL_03df: Expected O, but got I
		//IL_0419: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3568;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		IEnumerable<object> enumerable2;
		object obj7;
		object obj9;
		Func<object, long> keySelector;
		int num;
		nint num2;
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			List<ProfileGiftDataHolder> list = base.data;
			if (list != null)
			{
				object obj4 = typeof(TypeConverter<ushort, char>) + 3552;
				num = list._size;
				int version = list._version + 1;
				list._size = 0;
				list._version = version;
				if (list._size >= 1)
				{
					Array.Clear(list._items, 0, list._size);
					num2 = unchecked((nint)null);
				}
				object obj5 = (nint)0 + (nint)3416;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ProfileGiftsDisplayerListView)+E8]");
				_ = 0;
				<IsMine>k__BackingField = isMine;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				IEnumerable<object> enumerable = default(IEnumerable<object>);
				bool flag = enumerable == null;
				object obj6 = !flag;
				enumerable2 = enumerable;
				if (obj6 == null)
				{
					obj7 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3544;
					object obj8 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v36+E4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v36+B8]");
						obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v28+8]");
						keySelector = (Func<object, long>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v28+8]");
						bool flag2 = (nint)0 == 0;
						object obj10 = !flag2;
						if (obj10 == null)
						{
							goto IL_0249;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj8 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v36+B8]");
						obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v28+8]");
						keySelector = (Func<object, long>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v28+8]");
						bool flag3 = (nint)0 == 0;
						object obj11 = !flag3;
						if (obj11 == null)
						{
							goto IL_0249;
						}
					}
					goto IL_02a0;
				}
				goto IL_04d2;
			}
		}
		goto IL_048d;
		IL_04d2:
		float[] countToSize = CountToSize;
		int num3 = Enumerable.Count(enumerable2);
		float[] countToSize2 = CountToSize;
		if (CountToSize != null && CountToSize != null)
		{
			object obj12 = num3 - 1;
			object obj13 = countToSize2.Length - 1;
			object obj14 = obj12 - obj13;
			bool flag4 = (nint)obj14 < 0;
			object obj15 = obj12 ^ obj13;
			object obj16 = obj12 ^ obj14;
			object obj17 = obj15 & obj16;
			bool flag5 = (nint)obj17 < 0;
			bool flag6 = flag4 == flag5;
			object obj18 = !flag6;
			object obj19 = ~obj18;
			if (obj19 == null)
			{
				obj13 = obj12;
			}
			bool flag7 = (nint)obj12 < 0;
			object obj20 = obj12 ^ obj12;
			object obj21 = obj12 & obj20;
			bool flag8 = (nint)obj21 < 0;
			bool flag9 = flag7 == flag8;
			object obj22 = !flag9;
			object obj23 = ~obj22;
			if (obj23 == null)
			{
				obj13 = 0;
			}
			bool flag10 = (nint)obj13 < countToSize.Length;
			object obj24 = !flag10;
			if (obj24 != null)
			{
				goto IL_049b;
			}
			object obj25 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2968;
			object obj26 = (nint)0 + (nint)2592;
			object obj27 = (object)CountToSize + obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v14+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, object> func = default(Func<object, object>);
			func..ctor(obj2, (IntPtr)obj26);
			IEnumerable<object> source = Enumerable.Select(enumerable2, func);
			List<object> list2 = Enumerable.ToList(source);
			base.data = (List<ProfileGiftDataHolder>)(object)list2;
			SetTemplateSizes();
			bool active = ArraysExtensions.IsNullOrEmpty(enumerable2);
			if ((object)emptyLabel != null)
			{
				emptyLabel.SetActive(active);
				return;
			}
		}
		goto IL_048d;
		IL_02a0:
		object obj28 = (nint)0 + (nint)2192;
		num = (int)obj28;
		IOrderedEnumerable<object> source2 = Enumerable.OrderBy(gifts, keySelector);
		object[] array = Enumerable.ToArray(source2);
		enumerable2 = array;
		goto IL_04d2;
		IL_048d:
		NullReferenceException ex = new NullReferenceException();
		goto IL_049b;
		IL_0249:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v36+E4]");
		bool flag11 = (nint)0 == 0;
		object obj29 = !flag11;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj30 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v34+B8]");
			obj9 = 0;
		}
		object obj31 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj32 = (nint)0 + (nint)2568;
		Func<object, long> func2 = default(Func<object, long>);
		func2..ctor(obj9, (IntPtr)obj32);
		object obj33 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v33+B8]");
		object obj34 = (nint)0 + (nint)8;
		obj34 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		num2 = unchecked((nint)null);
		keySelector = func2;
		goto IL_02a0;
		IL_049b:
		throw new IndexOutOfRangeException();
	}

	protected override void SetTemplateSizes()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0049: Expected O, but got I4
		//IL_0071: Expected O, but got I4
		//IL_008d: Expected O, but got I4
		//IL_009d: Expected O, but got I4
		//IL_0108: Expected O, but got I4
		//IL_047b: Expected O, but got I4
		//IL_04ad: Expected O, but got I4
		//IL_04b6: Expected O, but got I4
		//IL_0135: Expected O, but got I4
		//IL_0152: Expected O, but got I4
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0180: Expected O, but got I
		//IL_019f: Expected O, but got I
		//IL_01b1: Expected I, but got O
		//IL_01cd: Expected I, but got O
		//IL_01de: Expected I, but got O
		//IL_01fb: Expected O, but got I4
		//IL_0225: Expected O, but got I
		//IL_022d: Expected I, but got O
		//IL_025a: Expected O, but got I4
		//IL_0285: Expected O, but got I
		//IL_0291: Expected O, but got I
		//IL_029d: Expected O, but got I
		//IL_02ae: Expected O, but got I
		//IL_0331: Expected O, but got I4
		//IL_033a: Expected O, but got I4
		//IL_02ec: Expected O, but got I
		//IL_0302: Expected O, but got I
		//IL_030a: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3552;
		Action<object> action = (Action<object>)((nint)0 + (nint)3408);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		float[] countToSize = CountToSize;
		IEnumerable<object> source = base.data;
		object obj3 = action;
		int num = Enumerable.Count(source);
		float[] countToSize2 = CountToSize;
		bool flag = CountToSize == null;
		Dictionary<object, object>.Enumerator enumerator = (Dictionary<object, object>.Enumerator)0;
		Dictionary<object, object>.Enumerator enumerator3 = default(Dictionary<object, object>.Enumerator);
		if (!flag)
		{
			bool flag2 = CountToSize == null;
			enumerator = (Dictionary<object, object>.Enumerator)0;
			if (!flag2)
			{
				object obj4 = num - 1;
				object obj5 = countToSize2.Length - 1;
				object obj6 = obj4 - obj5;
				bool flag3 = (nint)obj6 < 0;
				object obj7 = obj4 ^ obj5;
				object obj8 = obj4 ^ obj6;
				object obj9 = obj7 & obj8;
				bool flag4 = (nint)obj9 < 0;
				bool flag5 = flag3 == flag4;
				object obj10 = !flag5;
				object obj11 = ~obj10;
				if (obj11 == null)
				{
					obj5 = obj4;
				}
				bool flag6 = (nint)obj4 < 0;
				object obj12 = obj4 ^ obj4;
				object obj13 = obj4 & obj12;
				bool flag7 = (nint)obj13 < 0;
				bool flag8 = flag6 == flag7;
				object obj14 = !flag8;
				object obj15 = ~obj14;
				if (obj15 == null)
				{
					obj5 = 0;
				}
				bool flag9 = (nint)obj5 < countToSize.Length;
				object obj16 = !flag9;
				enumerator = (Dictionary<object, object>.Enumerator)0;
				if (obj16 != null)
				{
					goto IL_033f;
				}
				bool flag10 = obj2 == null;
				enumerator = (Dictionary<object, object>.Enumerator)0;
				if (!flag10)
				{
					object obj17 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3152;
					object obj18 = (nint)0 + (nint)2576;
					object obj19 = (object)CountToSize + obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v12+20]");
					enumerator = (Dictionary<object, object>.Enumerator)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v12+20]");
					_ = 0;
					nint num2 = (nint)this;
					List<ProfileGiftDataHolder> list = base.data;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					nint num3 = (nint)obj18;
					Action<object> action2 = default(Action<object>);
					action2..ctor(obj2, (IntPtr)obj18);
					bool flag11 = list == null;
					object obj20 = 0;
					obj3 = obj2;
					action = action2;
					if (!flag11)
					{
						object obj21 = (nint)0 + (nint)2552;
						num3 = (nint)obj21;
						((List<object>)(object)list).ForEach(action2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ProfileGiftsDisplayerListView)+A8]");
						bool flag12 = (nint)0 == 0;
						obj20 = 0;
						obj3 = action2;
						action = action2;
						if (!flag12)
						{
							object obj22 = (nint)0 + (nint)2376;
							object obj23 = (nint)0 + (nint)1200;
							action = (Action<object>)((nint)0 + (nint)2368);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ProfileGiftsDisplayerListView)+A8]");
							Dictionary<object, object>.Enumerator enumerator2 = ((Dictionary<object, object>)0).GetEnumerator();
							while (true)
							{
								obj3 = obj22;
								if (enumerator3.MoveNext())
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ProfileGiftsDisplayerListView)+130]");
									if ((nint)0 == 0)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
									enumerator = (Dictionary<object, object>.Enumerator)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ProfileGiftsDisplayerListView)+130]");
									((Dictionary<object, Vector3>)0).set_Item((object)null, (Vector3)obj23);
									num3 = (nint)obj23;
									continue;
								}
								enumerator3.Dispose();
								return;
							}
							NullReferenceException ex = new NullReferenceException();
							object obj24 = 0;
							obj20 = 0;
						}
					}
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_033f;
		IL_033f:
		IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
		bool flag13 = (nint)obj3 != 1;
		IndexOutOfRangeException ex4 = ex3;
		if (!flag13)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj3 = action;
			enumerator3.Dispose();
			object obj25 = default(object);
			if (obj25 == null)
			{
				return;
			}
			OutOfMemoryException ex5 = new OutOfMemoryException();
			object obj24 = obj25;
			ex4 = (IndexOutOfRangeException)(object)ex5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22380AC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public void Populate(IEnumerable<ProfileGiftQuantityPair> gifts, bool isMine)
	{
		SetItems(gifts, isMine);
	}

	public void AddCount(long giftId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_004f: Expected I, but got O
		//IL_0074: Expected I, but got O
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_010d: Expected I8, but got I
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I
		//IL_0178: Expected I4, but got I8
		//IL_01e4: Expected O, but got I4
		//IL_02a9: Expected O, but got I
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected O, but got Unknown
		//IL_02ce: Expected O, but got I
		//IL_03a6: Expected O, but got I
		//IL_03b6: Expected O, but got I
		//IL_03c6: Expected O, but got I
		//IL_03e8: Expected O, but got I4
		//IL_0410: Expected O, but got I
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_030b: Expected O, but got I
		//IL_031b: Expected O, but got I
		//IL_032b: Expected O, but got I
		//IL_034d: Expected O, but got I4
		//IL_0440: Expected O, but got I4
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected O, but got Unknown
		//IL_0519: Expected O, but got I
		//IL_052a: Expected I, but got O
		//IL_0548: Expected O, but got I
		//IL_0383: Expected O, but got I
		//IL_0470: Expected O, but got I
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2904;
		object obj4 = (nint)0 + (nint)2584;
		object obj5 = (nint)0 + (nint)1088;
		nint num = (nint)this;
		List<ProfileGiftDataHolder> source = base.data;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj4);
		object obj6 = Enumerable.FirstOrDefault(source, func);
		object item;
		if (obj6 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v11 (System.Object)+18]");
			object obj7 = (nint)0 + (nint)1;
			_ = 1;
			item = obj6;
		}
		else
		{
			object obj8 = typeof(System.Buffers.Text.ParserHelpers) + 2208;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Object)+10]");
			ProfileGiftQuantityPair profileGiftQuantityPair = default(ProfileGiftQuantityPair);
			profileGiftQuantityPair..ctor(0L, 1);
			object obj9 = typeof(System.Buffers.Text.ParserHelpers) + 2192;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = default(object);
			obj10..ctor();
			_ = profileGiftQuantityPair.<GiftId>k__BackingField;
			_ = profileGiftQuantityPair.<Quantity>k__BackingField;
			_ = 1137180672;
			_ = 1;
			_ = <IsMine>k__BackingField;
			int num2 = UnityEngine.Random.Range(-10, 10);
			List<object> list = (List<object>)(object)base.data;
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			bool flag = list._size < items.Length;
			object obj11 = !flag;
			if (obj11 == null)
			{
				int num3 = list._size + 1;
				list._size = num3;
				object obj12 = items + list._size;
				object obj13 = obj12 + 32;
				obj13 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				int num4 = num2;
				item = obj10;
			}
			else
			{
				list.AddWithResize(obj10);
				int num4 = num2;
				item = obj10;
			}
		}
		SetTemplateSizes();
		emptyLabel.SetActive(value: false);
		object obj14 = (nint)0 + (nint)1328;
		object obj15 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3544;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ProfileGiftsDisplayerListView)+B0]");
		Dictionary<int, object>.ValueCollection values = ((Dictionary<int, object>)0).Values;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X0_v25+E4]");
		object obj18;
		Action<object> action;
		Dictionary<int, object>.ValueCollection enumeration;
		Dictionary<int, object>.ValueCollection valueCollection;
		object obj20;
		object obj17;
		if ((nint)0 != 0)
		{
			obj17 = (nint)0 + (nint)2280;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X0_v25+B8]");
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v17+10]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v17+10]");
			bool flag2 = (nint)0 == 0;
			object obj19 = !flag2;
			enumeration = values;
			if (obj19 == null)
			{
				valueCollection = values;
				obj20 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v17+10]");
				Action<object> action2 = (Action<object>)0;
				goto IL_041e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj16 = obj15;
			obj20 = (nint)0 + (nint)2280;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X0_v25+B8]");
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v17+10]");
			Action<object> action2 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v17+10]");
			bool flag3 = (nint)0 == 0;
			object obj21 = !flag3;
			valueCollection = values;
			enumeration = values;
			obj17 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v17+10]");
			action = (Action<object>)0;
			if (obj21 == null)
			{
				goto IL_041e;
			}
		}
		goto IL_04d3;
		IL_041e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X0_v25+E4]");
		bool flag4 = (nint)0 == 0;
		object obj22 = !flag4;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj23 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v23+B8]");
			obj18 = 0;
		}
		object obj24 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj25 = (nint)0 + (nint)2560;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj18, (IntPtr)obj25);
		object obj26 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v22+B8]");
		object obj27 = (nint)0 + (nint)16;
		obj27 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		enumeration = valueCollection;
		obj17 = obj20;
		action = action3;
		goto IL_04d3;
		IL_04d3:
		ArraysExtensions.ForEach(enumeration, action);
		List<object> list2 = (List<object>)(object)base.data;
		int index = list2.IndexOf(item);
		((UiListView<object, object>)(object)this).AnimateCenteredScrollTo(index, 0.3f, (Action)null);
	}

	public ProfileGiftsDisplayerListView()
	{
		_ = 2;
		((UiListView<object, object>)(object)this)..ctor();
	}
}
