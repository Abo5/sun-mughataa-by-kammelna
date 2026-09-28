using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using ListView;
using Spine;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.UI;

public class StoreBannersList : ListViewItem<StoreDataHolder, int>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<StoreBannerItem, GameObject> <>9__10_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 1376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal GameObject <PopulateBanners>b__10_0(StoreBannerItem c)
		{
			if ((object)c != null)
			{
				return c.gameObject;
			}
			return (GameObject)(object)new NullReferenceException();
		}
	}

	private RectTransform bannersList;

	private StoreBannerItem bannersItemPrefab;

	private DiscreteProgressIndicator pagination;

	private List<StoreBannerViewModel> _banners;

	private ImageCacher.BannerSize bannerType;

	public UIPicker uiPicker;

	private int currentPage;

	private StoreBannerItem selectedItem;

	private List<StoreBannerItem> banners;

	public override void Setup(StoreDataHolder datum, bool firstTime)
	{
		bool firstTime2 = default(bool);
		((ListViewItem<object, int>)(object)this).Setup((object)datum, firstTime2);
		PopulateBanners(datum.BannerList, datum.Type);
	}

	private void PopulateBanners(List<StoreBannerViewModel> storeBanners, ImageCacher.BannerSize type)
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_018d: Expected O, but got I
		//IL_019d: Expected O, but got I
		//IL_01bf: Expected O, but got I4
		//IL_01cf: Expected O, but got I
		//IL_0158: Expected O, but got I4
		//IL_00e3: Expected O, but got I
		//IL_00f3: Expected O, but got I
		//IL_011a: Expected O, but got I
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_027c: Expected O, but got I
		//IL_01ff: Expected O, but got I4
		//IL_0357: Expected I, but got O
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_02f9: Expected O, but got I
		//IL_030a: Expected I, but got O
		//IL_0328: Expected O, but got I
		//IL_022f: Expected O, but got I
		if (!ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)banners))
		{
			return;
		}
		DeleteOldObject();
		bannerType = type;
		((List<object>)(object)_banners).AddRange((IEnumerable<object>)storeBanners);
		if (ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)_banners))
		{
			return;
		}
		InitializeBanners();
		List<StoreBannerViewModel> list = _banners;
		pagination.MaxProgress = list._size;
		pagination.CurrentProgress = 1;
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1376;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v28+E4]");
		object obj3;
		Func<object, object> selector;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v28+B8]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v18+8]");
			selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v18+8]");
			bool flag = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v18+8]");
			Func<object, object> func = (Func<object, object>)0;
			if (!flag)
			{
				goto IL_0128;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v28+B8]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v18+8]");
			selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v18+8]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v18+8]");
			Func<object, object> func = (Func<object, object>)0;
			if (obj4 != null)
			{
				goto IL_0128;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v28+E4]");
		bool flag3 = (nint)0 == 0;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v26+B8]");
			obj3 = 0;
		}
		object obj7 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = (nint)0 + (nint)1376;
		Func<object, object> func2 = default(Func<object, object>);
		func2..ctor(obj3, (IntPtr)obj8);
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v23+B8]");
		object obj10 = (nint)0 + (nint)8;
		obj10 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		IEnumerable<object> itemsList = Enumerable.Select(banners, func2);
		goto IL_024d;
		IL_0128:
		itemsList = Enumerable.Select(banners, selector);
		bool flag4 = (object)uiPicker == null;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_024d;
		IL_024d:
		uiPicker.setItemsList((IEnumerable<GameObject>)itemsList);
		object obj12 = typeof(TrackedDeviceRaycaster.<>c) + 968;
		object obj13 = (nint)0 + (nint)3992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UIPicker.OnSelectDelegate onSelectDelegate = default(UIPicker.OnSelectDelegate);
		onSelectDelegate..ctor(this, (IntPtr)obj13);
		uiPicker.OnChange += onSelectDelegate;
	}

	private void InitializeBanners()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0033: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_0189: Expected O, but got I4
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_0296: Expected O, but got I
		//IL_02bd: Expected O, but got I4
		//IL_0078: Expected O, but got I
		//IL_0081: Expected O, but got I4
		List<StoreBannerViewModel> list = _banners;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)1024;
		object obj3 = (nint)0 + (nint)2792;
		int num = 0;
		object obj9 = default(object);
		while (num < list._size)
		{
			List<object> list2 = (List<object>)(object)banners;
			Transform transform = bannersList.transform;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
			int version = list2._version + 1;
			list2._version = version;
			object[] items = list2._items;
			bool flag2 = list2._size < items.Length;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				int size = list2._size + 1;
				list2._size = size;
				object obj7 = items + list2._size;
				object obj8 = obj7 + 32;
				obj8 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				list2.AddWithResize(obj9);
			}
			object obj10 = ((List<object>)(object)banners).get_Item(num);
			object obj11 = obj3;
			object obj12 = ((List<object>)(object)_banners).get_Item(num);
			object obj13 = obj10 + 152;
			obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (obj13 != null)
			{
				((StoreBannerItem)obj10).LoadImage(bannerType);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v14 (System.Object)+98]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v14 (System.Object)+88]");
				bool flag3 = (nint)0 == 0;
				object obj15 = !flag3;
				if (obj15 == null)
				{
					throw new NullReferenceException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v12+20]");
				bool flag4 = (nint)0 == 0;
				bool flag5 = !flag4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v14 (System.Object)+88]");
				((Behaviour)0).enabled = flag5;
				obj11 = 0;
			}
			num++;
			list = _banners;
		}
	}

	private void InitializePagination()
	{
		List<StoreBannerViewModel> list = _banners;
		pagination.MaxProgress = list._size;
		pagination.CurrentProgress = 1;
	}

	private void SetPickersEvents()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 968;
		object obj2 = (nint)0 + (nint)3992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UIPicker.OnSelectDelegate onSelectDelegate = default(UIPicker.OnSelectDelegate);
		onSelectDelegate..ctor(this, (IntPtr)obj2);
		uiPicker.OnChange += onSelectDelegate;
	}

	public void SwitchPage()
	{
		//IL_0042: Expected O, but got I
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		UIPicker uIPicker = uiPicker;
		int currentProgress = uIPicker._currentSelectionIndex + 1;
		pagination.CurrentProgress = currentProgress;
		UIPicker uIPicker2 = uiPicker;
		object obj = (nint)0 + (nint)2744;
		object obj2 = ((List<object>)(object)banners).get_Item(uIPicker2._currentSelectionIndex);
		object obj3 = this + 184;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void DeleteOldObject()
	{
		//IL_0011: Expected O, but got I
		//IL_00ab: Expected O, but got I
		//IL_021b: Expected O, but got I
		//IL_022b: Expected O, but got I
		//IL_0241: Expected O, but got I
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_0269: Expected O, but got I4
		//IL_0279: Expected O, but got I
		//IL_00e0: Expected O, but got I
		//IL_00f6: Expected O, but got I
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0123: Expected O, but got I
		//IL_02db: Expected O, but got I
		//IL_02eb: Expected O, but got I
		//IL_0301: Expected O, but got I
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected O, but got Unknown
		//IL_02b3: Expected O, but got I4
		//IL_0166: Expected O, but got I
		//IL_0176: Expected O, but got I
		//IL_018c: Expected O, but got I
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_01b4: Expected O, but got I4
		//IL_01c4: Expected O, but got I
		//IL_01f1: Expected O, but got I
		//IL_033c: Expected O, but got I
		List<StoreBannerViewModel> list = _banners;
		object obj = (nint)0 + (nint)3120;
		int version = list._version + 1;
		list._size = 0;
		list._version = version;
		bool flag = list._size < 1;
		IntPtr intPtr = default(IntPtr);
		int num = (int)(nint)intPtr;
		if (!flag)
		{
			Array.Clear(list._items, 0, list._size);
			num = 0;
		}
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X20_v4+38]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X20_v4+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v4+10]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v4+10]");
			object obj5 = (nint)0 + (nint)309;
			object obj6 = obj5 & 1;
			bool flag2 = obj6 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v4+10]");
			object obj7 = 0;
			if (!flag2)
			{
				goto IL_0131;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X20_v4+38]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v11+10]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v11+10]");
			object obj9 = (nint)0 + (nint)309;
			object obj10 = obj9 & 1;
			bool flag3 = obj10 == null;
			object obj11 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v11+10]");
			object obj7 = 0;
			if (obj11 != null)
			{
				goto IL_0131;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v4+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 != null)
		{
			goto IL_0156;
		}
		goto IL_02c1;
		IL_02c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X20_v4+38]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v6+10]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v6+10]");
		object obj15 = (nint)0 + (nint)309;
		object obj16 = obj15 & 1;
		if (obj16 == null)
		{
			goto IL_01d2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v6+10]");
		object obj17 = 0;
		goto IL_01e1;
		IL_0131:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0156;
		}
		goto IL_02c1;
		IL_01d2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_01e1;
		IL_0156:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X20_v4+38]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v18+10]");
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v18+10]");
		object obj19 = (nint)0 + (nint)309;
		object obj20 = obj19 & 1;
		bool flag5 = obj20 == null;
		object obj21 = !flag5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v18+10]");
		obj17 = 0;
		if (obj21 == null)
		{
			goto IL_01d2;
		}
		goto IL_01e1;
		IL_01e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v12+B8]");
		object except = 0;
		UIExtensions.DestroyAllChildren(bannersList, (GameObject[])except);
	}

	public StoreBannersList()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3568;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 3560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj3 = this + 152;
		obj3 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj4 = this + 192;
		obj4 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
