using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using ListView;
using Sfs2X.Entities;
using Spine;
using Unity.Properties;
using UnityEngine;
using UnityEngine.UI;

public class StoreCardItem : ListViewItem<StoreDataHolder, int>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Comparison<StoreItem> <>9__15_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 1408;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal int <PopulateStoreItem>b__15_0(StoreItem item1, StoreItem item2)
		{
			//IL_0064: Expected I4, but got O
			if (item1 != null && item2 != null)
			{
				return item1.<tier>k__BackingField - item2.<tier>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private sealed class <>c__DisplayClass17_0
	{
		public Image cardImage;

		public StoreCardItem <>4__this;

		internal void <AssignCards>b__0(bool success)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_012d: Expected O, but got I4
			if (!success)
			{
				return;
			}
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				if (!(cardImage != null))
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag = cardImage != null;
				bool flag2 = !flag;
				object obj3 = !flag2;
				if (obj3 == null)
				{
					return;
				}
			}
			cardImage.enabled = true;
			GameObject gameObject = cardImage.gameObject;
			gameObject.SetActive(value: true);
			StoreCardItem storeCardItem = <>4__this;
			GameObject gameObject2 = storeCardItem.imageLoadingIndicator.gameObject;
			gameObject2.SetActive(value: false);
			StoreCardItem storeCardItem2 = <>4__this;
			storeCardItem2.imageLoadingIndicator.FinishLoading();
		}
	}

	private sealed class <>c__DisplayClass20_0
	{
		public StoreCardItem <>4__this;

		public int i;

		public Func<StoreOwnedItem, bool> <>9__0;

		internal bool <UpdateStatus>b__0(StoreOwnedItem item)
		{
			//IL_00c2: Expected I4, but got O
			//IL_00a0: Expected O, but got I
			if (item != null)
			{
				StoreCardItem storeCardItem = <>4__this;
				if ((object)<>4__this != null && storeCardItem.currentItems != null)
				{
					object obj = ((List<object>)(object)storeCardItem.currentItems).get_Item(i);
					if (obj != null)
					{
						int <itemId>k__BackingField = item.<itemId>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v5 (System.Object)+10]");
						object obj2 = (nint)<itemId>k__BackingField - (nint)0;
						return obj2 == null;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public Image itemImage;

	public Image titleImage;

	public RotatingLoadingIndicator imageLoadingIndicator;

	public Image statusImage;

	public Sprite empty;

	public Sprite owned;

	public Sprite active;

	private List<StoreItem> currentItems;

	private Image[] cardImages;

	private Image[] statusImages;

	private Store storeScript;

	private int maxNumOfCards;

	private int? templateId;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0061: Expected O, but got I
		//IL_008b: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)224;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj5 = this + 208;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public override void Setup(StoreDataHolder datum, bool firstTime)
	{
		bool firstTime2 = default(bool);
		((ListViewItem<object, int>)(object)this).Setup((object)datum, firstTime2);
		PopulateStoreItem(datum.CardsItem, datum.<tempId>k__BackingField);
	}

	public void PopulateStoreItem(List<StoreItem> items, int? tempId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0132: Expected O, but got I4
		//IL_0096: Expected O, but got I
		//IL_00a6: Expected O, but got I
		//IL_01cc: Expected O, but got I4
		//IL_016a: Expected O, but got I
		//IL_017a: Expected O, but got I
		//IL_019c: Expected O, but got I4
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected O, but got Unknown
		//IL_0405: Expected O, but got I
		//IL_0416: Expected I, but got O
		//IL_0434: Expected O, but got I
		//IL_00e5: Expected O, but got I4
		//IL_01fc: Expected O, but got I
		//IL_021a: Expected O, but got I
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_026f: Expected O, but got I
		//IL_02dd: Expected O, but got I
		//IL_0333: Expected O, but got I4
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected O, but got Unknown
		//IL_037f: Expected O, but got I
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected O, but got Unknown
		//IL_03b8: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1408;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A0D]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		if (obj2 != null)
		{
			templateId = tempId;
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v29+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			if (!flag)
			{
				goto IL_0086;
			}
		}
		else
		{
			_ = 1;
			templateId = tempId;
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v29+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_0086;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v29+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v8+8]");
		Comparison<object> comparison = (Comparison<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v8+8]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 != null)
		{
			goto IL_00cb;
		}
		goto IL_01aa;
		IL_020e:
		object obj8 = (nint)0 + (nint)2928;
		((List<object>)(object)items).Sort(comparison);
		object obj9 = this + 184;
		obj9 = items;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj10 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X21_v5-28]");
		((RotatingLoadingIndicator)0).StartLoading();
		if (ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)cardImages) && ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)statusImages))
		{
			InitializeContent();
		}
		object obj11 = (nint)0 + (nint)2200;
		ResetContent();
		AssignTitle();
		AssignCards();
		RepositionCards();
		GameObject go = base.gameObject;
		object obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v17+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj14 = typeof(SqlSingle[]) + 2376;
		object obj15 = (nint)0 + (nint)4008;
		object varName = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 1976;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj15);
		VariableBinderExtensions.Bind(go, localUser, (string)varName, action);
		return;
		IL_00cb:
		bool flag5 = items == null;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_020e;
		IL_01aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v29+E4]");
		bool flag6 = (nint)0 == 0;
		object obj17 = !flag6;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj18 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v14+B8]");
			obj6 = 0;
		}
		object obj19 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 3456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj20 = (nint)0 + (nint)1472;
		Comparison<object> comparison2 = default(Comparison<object>);
		comparison2..ctor(obj6, (IntPtr)obj20);
		object obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v13+B8]");
		object obj22 = (nint)0 + (nint)8;
		obj22 = comparison2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		comparison = comparison2;
		goto IL_020e;
		IL_0086:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v29+B8]");
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v8+8]");
		comparison = (Comparison<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v8+8]");
		if ((nint)0 != 0)
		{
			goto IL_00cb;
		}
		goto IL_01aa;
	}

	private void AssignTitle()
	{
		//IL_0026: Expected O, but got I
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005f: Expected O, but got I
		//IL_0077: Expected I, but got O
		titleImage.enabled = false;
		object obj = (nint)0 + (nint)2944;
		object obj2 = ((List<object>)(object)currentItems).get_Item(0);
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj4 = (nint)0 + (nint)4000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj4);
		Image img = titleImage;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v6 (System.Object)+10]");
		UIExtensions.LoadItemImage(img, 0, ImageCacher.ItemImageType.StoreTitle, FilterMode.Point, action);
	}

	private void AssignCards()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_00b2: Expected O, but got I4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00eb: Expected O, but got I
		//IL_012d: Expected I, but got O
		//IL_0189: Expected O, but got I4
		List<StoreItem> list = currentItems;
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1416;
		object obj2 = (nint)0 + (nint)2944;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj4 = (nint)0 + (nint)1480;
		int num = 0;
		object obj5 = default(object);
		Action<bool> action = default(Action<bool>);
		while (true)
		{
			if (num < list._size)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj5..ctor();
				object obj6 = obj5 + 24;
				obj6 = this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Image[] array = cardImages;
				bool flag = num < array.Length;
				object obj7 = !flag;
				if (obj7 != null)
				{
					break;
				}
				object obj8 = array + num;
				object obj9 = obj5 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v9+20]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj10 = ((List<object>)(object)currentItems).get_Item(num);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				action..ctor(obj5, (IntPtr)obj4);
				object img = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v15 (System.Object)+10]");
				UIExtensions.LoadItemImage((Image)img, 0, ImageCacher.ItemImageType.InGame, FilterMode.Point, action);
				num++;
				list = currentItems;
				bool flag2 = currentItems == null;
				object obj11 = !flag2;
				if (obj11 == null)
				{
					throw new NullReferenceException();
				}
				continue;
			}
			return;
		}
		throw new IndexOutOfRangeException();
	}

	private void InitializeContent()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_002c: Expected O, but got I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_007d: Expected O, but got I
		//IL_0089: Expected O, but got I
		//IL_00a2: Expected O, but got I4
		//IL_00ab: Expected O, but got I4
		//IL_04c6: Expected O, but got I4
		//IL_0504: Expected O, but got I4
		//IL_013e: Expected O, but got I4
		//IL_0187: Expected O, but got I4
		//IL_018f: Expected I4, but got O
		//IL_01b0: Expected I4, but got O
		//IL_0231: Expected O, but got I4
		//IL_023a: Expected O, but got I4
		//IL_01c6: Expected I, but got O
		//IL_01f8: Expected O, but got I4
		//IL_0288: Expected O, but got I4
		//IL_02cf: Expected O, but got I4
		//IL_0323: Expected I4, but got O
		//IL_0344: Expected I4, but got O
		//IL_03bc: Expected O, but got I4
		//IL_035a: Expected I, but got O
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected O, but got Unknown
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 2936;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj2 = this + 192;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj4 = this + 200;
		bool flag = default(bool);
		obj4 = flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag2 = maxNumOfCards < 1;
		bool flag3 = flag;
		if (flag2)
		{
			goto IL_044a;
		}
		object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj6 = (nint)0 + (nint)936;
		object obj7 = (nint)0 + (nint)552;
		object obj9 = default(object);
		object obj8 = obj9;
		object obj11 = default(object);
		object obj10 = obj11;
		object obj12 = 32;
		object obj13 = 0;
		bool flag4 = flag;
		bool flag10 = default(bool);
		bool flag18 = default(bool);
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		while (true)
		{
			bool flag5 = (object)itemImage == null;
			obj9 = obj8;
			obj11 = obj10;
			flag3 = flag4;
			if (flag5)
			{
				break;
			}
			Image[] array = cardImages;
			Transform transform = itemImage.transform;
			bool flag6 = (object)transform == null;
			obj9 = obj8;
			obj11 = obj10;
			flag3 = false;
			if (flag6)
			{
				break;
			}
			Transform parent = transform.parent;
			object obj14 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v28+E4]");
			bool flag7 = (nint)0 == 0;
			object obj15 = !flag7;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			obj11 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
			bool flag8 = cardImages == null;
			obj9 = 1;
			flag3 = (byte)(int)parent != 0;
			if (flag8)
			{
				break;
			}
			bool flag9 = !flag10;
			bool flag11 = (byte)(int)parent != 0;
			if (!flag9)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v16 (Il2CppClass<UnityEngine.UI.Image[]>)+40]");
				flag11 = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag12 = ex == null;
				obj9 = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v16 (Il2CppClass<UnityEngine.UI.Image[]>)+40]");
				flag3 = false;
				if (flag12)
				{
					goto IL_0546;
				}
			}
			bool flag13 = (nint)obj13 < array.Length;
			object obj16 = !flag13;
			obj9 = 1;
			flag3 = flag11;
			if (obj16 == null)
			{
				object obj17 = (object)cardImages + obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag14 = (object)statusImage == null;
				obj9 = 1;
				flag3 = flag10;
				if (flag14)
				{
					break;
				}
				Image[] array2 = statusImages;
				Transform transform2 = statusImage.transform;
				bool flag15 = (object)transform2 == null;
				obj9 = 1;
				flag3 = false;
				if (flag15)
				{
					break;
				}
				Transform parent2 = transform2.parent;
				obj9 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
				bool flag16 = statusImages == null;
				flag3 = (byte)(int)parent2 != 0;
				if (flag16)
				{
					break;
				}
				bool flag17 = !flag18;
				bool flag19 = (byte)(int)parent2 != 0;
				if (!flag17)
				{
					nint num2 = (nint)array2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X8_v15 (Il2CppClass<UnityEngine.UI.Image[]>)+40]");
					flag19 = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag20 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X8_v15 (Il2CppClass<UnityEngine.UI.Image[]>)+40]");
					flag3 = false;
					if (flag20)
					{
						goto IL_0546;
					}
				}
				bool flag21 = (nint)obj13 < array2.Length;
				object obj18 = !flag21;
				flag3 = flag19;
				if (obj18 == null)
				{
					object obj19 = (object)statusImages + obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					obj13++;
					obj12 += 8;
					bool flag22 = (nint)obj13 < maxNumOfCards;
					flag3 = flag18;
					obj8 = obj9;
					obj10 = obj11;
					flag4 = flag18;
					if (flag22)
					{
						continue;
					}
					goto IL_044a;
				}
			}
			goto IL_0538;
		}
		goto IL_052a;
		IL_0538:
		ex = new IndexOutOfRangeException();
		goto IL_0546;
		IL_052a:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0538;
		IL_044a:
		if ((object)statusImage != null)
		{
			GameObject gameObject = statusImage.gameObject;
			bool flag23 = (object)gameObject == null;
			flag3 = false;
			if (!flag23)
			{
				gameObject.SetActive(value: false);
				bool flag24 = (object)itemImage == null;
				obj9 = 0;
				flag3 = false;
				if (!flag24)
				{
					GameObject gameObject2 = itemImage.gameObject;
					bool flag25 = (object)gameObject2 == null;
					obj9 = 0;
					flag3 = false;
					if (!flag25)
					{
						gameObject2.SetActive(value: false);
						return;
					}
				}
			}
		}
		goto IL_052a;
		IL_0546:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	public void RepositionCards()
	{
		//IL_000f: Expected O, but got I4
		//IL_0027: Expected O, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected I4, but got Unknown
		//IL_0090: Expected O, but got I4
		//IL_01eb: Expected O, but got I4
		//IL_0215: Expected O, but got I4
		//IL_022f: Expected O, but got I4
		//IL_0251: Expected O, but got I4
		//IL_00d6: Expected O, but got I4
		//IL_0107: Expected O, but got I
		//IL_011c: Expected O, but got I
		//IL_0145: Expected O, but got I4
		//IL_0156: Expected O, but got I
		//IL_016d: Expected O, but got I4
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_01a2: Expected O, but got I4
		List<StoreItem> list = currentItems;
		object obj = 0;
		while (true)
		{
			if ((nint)obj < list._size)
			{
				object obj2 = list._size - 3;
				bool flag = (nint)obj2 < 0;
				int num = list._size ^ 3;
				int num2 = list._size ^ obj2;
				int num3 = num & num2;
				bool flag2 = num3 < 0;
				bool flag3 = flag == flag2;
				object obj3 = !flag3;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
				}
				bool flag4 = flag == flag2;
				object obj5 = !flag4;
				object obj6 = ~obj5;
				if (obj6 == null)
				{
				}
				object obj7 = list._size - 2;
				bool flag5 = obj7 == null;
				object obj8 = !flag5;
				object obj9 = ~obj8;
				if (obj9 == null)
				{
				}
				object obj10 = !flag5;
				object obj11 = ~obj10;
				if (obj11 == null)
				{
				}
				Image[] array = cardImages;
				bool flag6 = (nint)obj < array.Length;
				object obj12 = !flag6;
				if (obj12 != null)
				{
					break;
				}
				object obj13 = (object)array + obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v9+20]");
				RectTransform rectTransform = ((Graphic)0).rectTransform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v9+20]");
				RectTransform rectTransform2 = ((Graphic)0).rectTransform;
				Vector3 vector = rectTransform2.localPosition;
				rectTransform.localPosition = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v9+20]");
				RectTransform rectTransform3 = ((Graphic)0).rectTransform;
				rectTransform3.localEulerAngles = (Vector3)0;
				list = currentItems;
				obj++;
				bool flag7 = currentItems == null;
				object obj14 = !flag7;
				if (obj14 == null)
				{
					throw new NullReferenceException();
				}
				continue;
			}
			return;
		}
		throw new IndexOutOfRangeException();
	}

	private void UpdateStatus()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0080: Expected O, but got I4
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0132: Expected O, but got I
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0147: Expected O, but got I4
		//IL_04a7: Expected I, but got O
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Expected O, but got Unknown
		//IL_018f: Expected O, but got I
		//IL_04f9: Expected O, but got I4
		//IL_0502: Expected O, but got I4
		//IL_01f0: Expected O, but got I4
		//IL_021e: Expected O, but got I4
		//IL_0522: Expected O, but got I4
		//IL_0246: Expected O, but got I4
		//IL_0210: Expected O, but got I4
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected O, but got Unknown
		//IL_02a5: Expected O, but got I
		//IL_02f1: Expected O, but got I4
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected O, but got Unknown
		//IL_0351: Expected O, but got I
		//IL_039d: Expected O, but got I4
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected O, but got Unknown
		//IL_03f8: Expected O, but got I
		//IL_043d: Expected O, but got I
		//IL_0468: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Queue<string>) + 848;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2 + 16;
			obj5 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			if ((object)sessionModel != null)
			{
				User localUser = sessionModel.LocalUser;
				List<StoreOwnedItem> ownedCards = SFSKammelnaUserExtensions.GetOwnedCards(localUser);
				_ = 0;
				List<StoreItem> list = currentItems;
				if (currentItems != null)
				{
					object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3480;
					object obj9 = (nint)0 + (nint)1488;
					object obj10 = this + 160;
					object obj11 = 0;
					bool flag2 = false;
					object obj14 = default(object);
					Func<object, bool> func = default(Func<object, bool>);
					while (true)
					{
						if ((nint)obj11 >= list._size)
						{
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3 (System.Object)+20]");
						StoreOwnedItem storeOwnedItem;
						object obj13;
						object sprite;
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3 (System.Object)+20]");
							object obj12 = Enumerable.FirstOrDefault(ownedCards, (Func<object, bool>)0);
							bool flag3 = obj12 == null;
							storeOwnedItem = (StoreOwnedItem)obj12;
							obj13 = obj14;
							sprite = obj10;
							if (!flag3)
							{
								goto IL_01c9;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							func..ctor(obj2, (IntPtr)obj9);
							object obj15 = obj2 + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj16 = Enumerable.FirstOrDefault(ownedCards, func);
							bool flag4 = obj16 == null;
							object obj17 = !flag4;
							obj14 = 0;
							storeOwnedItem = (StoreOwnedItem)obj16;
							if (obj17 != null)
							{
								goto IL_01c9;
							}
							obj13 = 0;
							sprite = obj10;
						}
						goto IL_0575;
						IL_01c9:
						bool isActiveItem = storeOwnedItem.IsActiveItem;
						bool flag5 = !isActiveItem;
						object obj18 = !flag5;
						object obj19 = ~obj18;
						object obj20 = ((obj19 != null) ? ((object)168) : ((object)176));
						sprite = (object)this + obj20;
						obj13 = obj14;
						goto IL_0575;
						IL_0575:
						Image[] array = statusImages;
						if (statusImages == null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3 (System.Object)+18]");
						bool flag6 = (nint)0 < (nint)array.Length;
						object obj21 = !flag6;
						if (obj21 == null)
						{
							Image[] array2 = statusImages;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3 (System.Object)+18]");
							object obj22 = array2 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X9_v6+20]");
							if ((nint)0 == 0)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X9_v6+20]");
							((Image)0).sprite = (Sprite)sprite;
							Image[] array3 = statusImages;
							if (statusImages == null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3 (System.Object)+18]");
							bool flag7 = (nint)0 < (nint)array3.Length;
							object obj23 = !flag7;
							if (obj23 == null)
							{
								Image[] array4 = statusImages;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3 (System.Object)+18]");
								object obj24 = array4 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v11+20]");
								if ((nint)0 == 0)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v11+20]");
								((Behaviour)0).enabled = true;
								Image[] array5 = statusImages;
								if (statusImages == null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3 (System.Object)+18]");
								bool flag8 = (nint)0 < (nint)array5.Length;
								object obj25 = !flag8;
								if (obj25 == null)
								{
									Image[] array6 = statusImages;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3 (System.Object)+18]");
									object obj26 = array6 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v13+20]");
									if ((nint)0 == 0)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v13+20]");
									GameObject gameObject = ((Component)0).gameObject;
									if ((object)gameObject == null)
									{
										break;
									}
									gameObject.SetActive(value: true);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3 (System.Object)+18]");
									obj11 = (nint)0 + (nint)1;
									list = currentItems;
									bool flag9 = currentItems == null;
									object obj27 = !flag9;
									obj14 = obj13;
									flag2 = true;
									if (obj27 == null)
									{
										break;
									}
									continue;
								}
							}
						}
						goto IL_053e;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_053e;
		IL_053e:
		throw new IndexOutOfRangeException();
	}

	private void ResetContent()
	{
		//IL_0350: Expected O, but got I4
		//IL_002f: Expected O, but got I4
		//IL_0065: Expected O, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0093: Expected O, but got I4
		//IL_00dc: Expected O, but got I
		//IL_0120: Expected O, but got I4
		//IL_0164: Expected O, but got I
		//IL_01d7: Expected O, but got I4
		//IL_0220: Expected O, but got I
		//IL_0264: Expected O, but got I4
		//IL_02a8: Expected O, but got I
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected O, but got Unknown
		bool flag = ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)cardImages);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj != null)
		{
			return;
		}
		bool flag3 = ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)statusImages);
		bool flag4 = !flag3;
		object obj2 = !flag4;
		if (obj2 != null || maxNumOfCards < 1)
		{
			return;
		}
		object obj3 = 4;
		while (true)
		{
			Image[] array = cardImages;
			if (cardImages != null)
			{
				object obj4 = obj3 - 4;
				bool flag5 = (nint)obj4 < array.Length;
				object obj5 = !flag5;
				if (obj5 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v6 (UnityEngine.UI.Image[])+v147 @ X20_v6*8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v6 (UnityEngine.UI.Image[])+v147 @ X20_v6*8]");
					((Behaviour)0).enabled = false;
					Image[] array2 = cardImages;
					if (cardImages != null)
					{
						bool flag6 = (nint)obj4 < array2.Length;
						object obj6 = !flag6;
						if (obj6 != null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v9 (UnityEngine.UI.Image[])+v147 @ X20_v6*8]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v9 (UnityEngine.UI.Image[])+v147 @ X20_v6*8]");
							GameObject gameObject = ((Component)0).gameObject;
							if ((object)gameObject != null)
							{
								gameObject.SetActive(value: false);
								Image[] array3 = statusImages;
								if (statusImages != null)
								{
									bool flag7 = (nint)obj4 < array3.Length;
									object obj7 = !flag7;
									if (obj7 != null)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v10 (UnityEngine.UI.Image[])+v147 @ X20_v6*8]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v10 (UnityEngine.UI.Image[])+v147 @ X20_v6*8]");
										((Behaviour)0).enabled = false;
										Image[] array4 = statusImages;
										if (statusImages != null)
										{
											bool flag8 = (nint)obj4 < array4.Length;
											object obj8 = !flag8;
											if (obj8 != null)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v11 (UnityEngine.UI.Image[])+v147 @ X20_v6*8]");
											if ((nint)0 != 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v11 (UnityEngine.UI.Image[])+v147 @ X20_v6*8]");
												GameObject gameObject2 = ((Component)0).gameObject;
												if ((object)gameObject2 != null)
												{
													gameObject2.SetActive(value: false);
													obj3++;
													object obj9 = obj3 - 4;
													if ((nint)obj9 >= maxNumOfCards)
													{
														return;
													}
													continue;
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			break;
		}
		throw new IndexOutOfRangeException();
	}

	private void LoadContent()
	{
		AssignTitle();
		AssignCards();
		RepositionCards();
	}

	public void OpenBuyItem()
	{
		storeScript.ShowBuyCardPopup(currentItems, templateId);
	}

	public StoreCardItem()
	{
		_ = 3;
		((ListViewItem<object, int>)(object)this)..ctor();
	}

	private void <AssignTitle>b__16_0(bool success)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00b5: Expected O, but got I4
		if (!success)
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			if (!(titleImage != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = titleImage != null;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				return;
			}
		}
		titleImage.enabled = true;
	}
}
