using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Server.Models.Products;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.UI;

public class SingleBundleCard : MonoBehaviour
{
	private GameObject titleRoot;

	private Image titleImage;

	private GameObject itemRoot;

	private Image itemImage;

	private Image itemImageReflection;

	private Image infoPanelImage;

	private TextMeshProUGUI rentText;

	private TextMeshProUGUI rentTitleText;

	private StoreItem <item>k__BackingField;

	private ProductViewModel _bundle;

	private StoreItem item
	{
		get
		{
			return <item>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 96;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public void SetupForItem(Bundle product, int itemId)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_00d8: Expected O, but got I
		//IL_0102: Expected O, but got I4
		//IL_00b3: Expected O, but got I4
		//IL_005a: Expected O, but got I
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_01a7: Expected O, but got I4
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 752;
		object obj3 = typeof(GenericSoundAlbumTrack) & 1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2024;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v19+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_008f;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2024;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_008f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0131;
		IL_0131:
		object obj8 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		IAPController iAPController = default(IAPController);
		ProductViewModel product2 = iAPController.GetProduct(product.<ProductId>k__BackingField);
		object obj9 = this + 104;
		obj9 = product2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		StoreItem storeItem = Store.GetStoreItem(itemId);
		object obj12 = this + 96;
		obj12 = storeItem;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ItemCategory category = ((StoreItem)obj12).GetCategory();
		SetUpItemImage(category);
		SetUpText(category);
		return;
		IL_008f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag4 = product == null;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0131;
	}

	private unsafe void SetUpText(ItemCategory category)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0111: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected O, but got Unknown
		//IL_03d4: Expected O, but got I4
		//IL_036b: Expected O, but got I4
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01c7: Expected O, but got I4
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected O, but got Unknown
		//IL_01e5: Expected O, but got I4
		//IL_0206: Expected O, but got Ref
		//IL_022b: Expected O, but got Ref
		//IL_0241: Expected I, but got O
		//IL_0251: Expected O, but got I
		//IL_027a: Expected O, but got I
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected O, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6958]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v34+E4]");
			bool flag = (nint)0 == 0;
			obj5 = rentText;
			obj6 = rentText;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = rentText;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v34+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = rentText;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object[] array = null;
		object[] array2 = null;
		string text = null;
		if (!flag4)
		{
			goto IL_016e;
		}
		goto IL_0306;
		IL_0347:
		UnityEngine.Object obj8;
		bool flag5 = obj8 != null;
		bool flag6 = !flag5;
		object obj9 = !flag6;
		if (obj9 == null)
		{
			return;
		}
		goto IL_0427;
		IL_0306:
		obj8 = rentTitleText;
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v8+E4]");
		bool flag7 = (nint)0 == 0;
		UnityEngine.Object obj11 = rentTitleText;
		if (!flag7)
		{
			goto IL_0347;
		}
		goto IL_03f1;
		IL_0427:
		object text2 = "Read object reference Id '{0}' for {1}." + 3496;
		object obj12 = "Cannot populate JSON object onto type '{0}'." + 1656;
		if (category != ItemCategory.Rooms)
		{
			text2 = obj12;
		}
		TextMeshProExtensions.Localize(rentTitleText, (string)text2);
		return;
		IL_0091:
		bool flag8 = obj5 != null;
		bool flag9 = !flag8;
		object obj13 = !flag9;
		array = null;
		if (obj13 != null)
		{
			goto IL_016e;
		}
		array2 = null;
		text = null;
		goto IL_0306;
		IL_016e:
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (category == ItemCategory.Rooms)
		{
			object obj14 = typeof(TypeConverter<ushort, char>) + 3400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			bool flag10 = _bundle == null;
			object obj15 = 1;
			if (!flag10)
			{
				object obj16 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object[] array3 = default(object[]);
				bool flag11 = array3 == null;
				int num = default(int);
				obj15 = (object)(&num);
				if (!flag11)
				{
					object obj17 = default(object);
					bool flag12 = obj17 == null;
					object obj18 = (object)(&num);
					if (!flag12)
					{
						nint num2 = (nint)array3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v30 (Il2CppClass<System.Object[]>)+40]");
						obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag13 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v30 (Il2CppClass<System.Object[]>)+40]");
						obj15 = 0;
						if (flag13)
						{
							goto IL_0493;
						}
					}
					bool flag14 = array3.Length == 0;
					obj15 = obj18;
					if (!flag14)
					{
						object obj19 = array3 + 32;
						obj19 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj20 = "Read object reference Id '{0}' for {1}." + 2224;
						text = (string)obj20;
						TextMeshProExtensions.Localize(rentText, (string)obj20, array3);
						array2 = array3;
						goto IL_0306;
					}
					goto IL_0485;
				}
			}
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_0485;
		}
		object obj21 = "Complete" + 3592;
		text = (string)obj21;
		TextMeshProExtensions.Localize(rentText, (string)obj21);
		obj8 = rentTitleText;
		obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v8+E4]");
		bool flag15 = (nint)0 == 0;
		object obj22 = !flag15;
		array2 = null;
		obj11 = rentTitleText;
		if (obj22 != null)
		{
			goto IL_0347;
		}
		goto IL_03f1;
		IL_0493:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0485:
		ex = new IndexOutOfRangeException();
		goto IL_0493;
		IL_03f1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (!(obj11 != null))
		{
			return;
		}
		goto IL_0427;
	}

	private void SetUpItemImage(ItemCategory category)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_030f: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_03af: Expected O, but got I4
		//IL_03b8: Expected O, but got I4
		//IL_013e: Expected O, but got I4
		//IL_0102: Expected I4, but got O
		//IL_0358: Expected O, but got I4
		//IL_048c: Expected O, but got I4
		//IL_0495: Expected O, but got I4
		//IL_04ac: Expected O, but got I4
		//IL_01a3: Expected I4, but got O
		//IL_01df: Expected O, but got I4
		//IL_01e8: Expected O, but got I4
		//IL_057b: Expected O, but got I4
		//IL_059c: Expected O, but got I4
		//IL_0524: Expected O, but got I4
		//IL_0298: Expected O, but got I4
		//IL_025c: Expected I4, but got O
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Expected O, but got Unknown
		//IL_0666: Expected O, but got I
		//IL_0674: Expected I, but got O
		//IL_06e4: Expected O, but got I4
		//IL_07be: Expected O, but got I4
		//IL_0746: Expected O, but got I4
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_083c: Expected O, but got Unknown
		//IL_0852: Expected O, but got I
		//IL_0860: Expected I, but got O
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6959]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v48+E4]");
			bool flag = (nint)0 == 0;
			obj5 = titleRoot;
			obj6 = titleRoot;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = titleRoot;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v48+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = titleRoot;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object obj8 = 0;
		UnityEngine.Object obj9 = null;
		if (flag4)
		{
			goto IL_00d1;
		}
		goto IL_036b;
		IL_076b:
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			bool flag5 = infoPanelImage != null;
			bool flag6 = !flag5;
			object obj11 = !flag6;
			if (obj11 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!(infoPanelImage != null))
			{
				return;
			}
		}
		infoPanelImage.enabled = false;
		StoreItem storeItem = <item>k__BackingField;
		object obj12 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)416;
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj13);
		UIExtensions.LoadItemImage(infoPanelImage, storeItem.<id>k__BackingField, ImageCacher.ItemImageType.InGame, FilterMode.Point, action);
		if (category == ItemCategory.Cards)
		{
			RectTransform rectTransform = infoPanelImage.rectTransform;
			rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 86f);
		}
		return;
		IL_061d:
		itemImage.enabled = false;
		StoreItem storeItem2 = <item>k__BackingField;
		object obj14 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)408;
		Action<bool> action2 = default(Action<bool>);
		action2..ctor((object)this, (IntPtr)obj15);
		UIExtensions.LoadItemImage(itemImage, storeItem2.<id>k__BackingField, ImageCacher.ItemImageType.InGame, FilterMode.Point, action2);
		StoreItem storeItem3 = <item>k__BackingField;
		UIExtensions.LoadItemImage(itemImageReflection, storeItem3.<id>k__BackingField, ImageCacher.ItemImageType.InGame);
		bool flag7 = category != ItemCategory.Cards;
		object obj16 = 0;
		Action<bool> action3 = null;
		FilterMode filterMode = FilterMode.Point;
		ImageCacher.ItemImageType itemImageType = ImageCacher.ItemImageType.InGame;
		RectTransform.Axis <id>k__BackingField = (RectTransform.Axis)storeItem3.<id>k__BackingField;
		if (!flag7)
		{
			RectTransform rectTransform2 = itemImage.rectTransform;
			rectTransform2.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 222f);
			obj16 = 0;
			action3 = null;
			filterMode = FilterMode.Point;
			itemImageType = ImageCacher.ItemImageType.InGame;
			<id>k__BackingField = RectTransform.Axis.Vertical;
		}
		goto IL_076b;
		IL_0274:
		UnityEngine.Object obj17;
		bool flag8 = obj17 != null;
		bool flag9 = !flag8;
		object obj18 = !flag9;
		if (obj18 != null)
		{
			goto IL_061d;
		}
		object obj19 = default(object);
		obj16 = obj19;
		Action<bool> action4 = default(Action<bool>);
		action3 = action4;
		FilterMode filterMode2 = default(FilterMode);
		filterMode = filterMode2;
		itemImageType = ImageCacher.ItemImageType.InGame;
		<id>k__BackingField = RectTransform.Axis.Horizontal;
		goto IL_076b;
		IL_0091:
		bool flag10 = obj5 != null;
		bool flag11 = !flag10;
		object obj20 = !flag11;
		obj8 = 0;
		obj9 = null;
		if (obj20 == null)
		{
			goto IL_00d1;
		}
		goto IL_036b;
		IL_036b:
		titleRoot.SetActive(value: true);
		UnityEngine.Object obj21 = titleImage;
		object obj22 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v41+E4]");
		bool flag12 = (nint)0 == 0;
		object obj23 = !flag12;
		obj8 = 0;
		bool flag13 = true;
		UnityEngine.Object obj24 = titleImage;
		if (obj23 != null)
		{
			goto IL_011a;
		}
		goto IL_03d9;
		IL_00d1:
		obj22 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v41+E4]");
		bool flag14 = (nint)0 == 0;
		obj21 = titleImage;
		flag13 = (byte)(int)obj9 != 0;
		obj24 = titleImage;
		if (!flag14)
		{
			goto IL_011a;
		}
		goto IL_03d9;
		IL_03d9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag15 = obj24 != null;
		bool flag16 = !flag15;
		ImageCacher.ItemImageType itemImageType2 = ImageCacher.ItemImageType.InGame;
		UnityEngine.Object obj25 = null;
		if (flag16)
		{
			goto IL_015a;
		}
		goto IL_041d;
		IL_011a:
		bool flag17 = obj21 != null;
		bool flag18 = !flag17;
		object obj26 = !flag18;
		itemImageType2 = ImageCacher.ItemImageType.InGame;
		obj25 = null;
		if (obj26 == null)
		{
			goto IL_015a;
		}
		goto IL_041d;
		IL_041d:
		StoreItem storeItem4 = <item>k__BackingField;
		int <id>k__BackingField2 = storeItem4.<id>k__BackingField;
		UIExtensions.LoadItemImage(titleImage, storeItem4.<id>k__BackingField, ImageCacher.ItemImageType.StoreTitle);
		UnityEngine.Object obj27 = itemRoot;
		object obj28 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X0_v34+E4]");
		bool flag19 = (nint)0 == 0;
		object obj29 = !flag19;
		obj19 = 0;
		action4 = null;
		filterMode2 = FilterMode.Point;
		obj16 = 0;
		action3 = null;
		filterMode = FilterMode.Point;
		itemImageType2 = ImageCacher.ItemImageType.StoreTitle;
		UnityEngine.Object obj30 = itemRoot;
		if (obj29 != null)
		{
			goto IL_01bb;
		}
		goto IL_04db;
		IL_015a:
		obj28 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X0_v34+E4]");
		bool flag20 = (nint)0 == 0;
		obj27 = itemRoot;
		obj16 = obj19;
		action3 = action4;
		filterMode = filterMode2;
		<id>k__BackingField2 = (int)obj25;
		obj30 = itemRoot;
		if (!flag20)
		{
			goto IL_01bb;
		}
		goto IL_04db;
		IL_04db:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag21 = obj30 != null;
		bool flag22 = !flag21;
		obj19 = obj16;
		action4 = action3;
		filterMode2 = filterMode;
		object obj31 = 0;
		UnityEngine.Object obj32 = null;
		if (flag22)
		{
			goto IL_0213;
		}
		goto IL_0537;
		IL_01bb:
		bool flag23 = obj27 != null;
		bool flag24 = !flag23;
		object obj33 = !flag24;
		obj31 = 0;
		obj32 = null;
		obj16 = obj19;
		action3 = action4;
		filterMode = filterMode2;
		if (obj33 == null)
		{
			goto IL_0213;
		}
		goto IL_0537;
		IL_0537:
		itemRoot.SetActive(value: true);
		obj17 = itemImage;
		object obj34 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v20+E4]");
		bool flag25 = (nint)0 == 0;
		object obj35 = !flag25;
		obj19 = obj16;
		action4 = action3;
		filterMode2 = filterMode;
		obj31 = 0;
		bool flag26 = true;
		UnityEngine.Object obj36 = itemImage;
		if (obj35 != null)
		{
			goto IL_0274;
		}
		goto IL_05bd;
		IL_0213:
		obj17 = itemImage;
		obj34 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v20+E4]");
		bool flag27 = (nint)0 == 0;
		obj16 = obj19;
		action3 = action4;
		filterMode = filterMode2;
		flag26 = (byte)(int)obj32 != 0;
		obj36 = itemImage;
		if (!flag27)
		{
			goto IL_0274;
		}
		goto IL_05bd;
		IL_05bd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag28 = obj36 != null;
		bool flag29 = !flag28;
		obj19 = obj16;
		action4 = action3;
		filterMode2 = filterMode;
		itemImageType = ImageCacher.ItemImageType.InGame;
		<id>k__BackingField = RectTransform.Axis.Horizontal;
		if (!flag29)
		{
			goto IL_061d;
		}
		goto IL_076b;
	}

	public void ShowPopup()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0068: Expected O, but got I4
		//IL_003d: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 1408;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RoomItemPopup.ShowRoomItemPopup(<item>k__BackingField, isPurchasable: false, (int?)(object)0);
	}

	private void <SetUpItemImage>b__15_0(bool _)
	{
		itemImage.enabled = true;
	}

	private void <SetUpItemImage>b__15_1(bool _)
	{
		infoPanelImage.enabled = true;
	}
}
