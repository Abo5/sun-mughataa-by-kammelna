using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Server.Models.Products;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class BundleInfoPopup : MonoBehaviour
{
	private SingleBundleCard infocardTemplate;

	private Transform infocardParent;

	private GameObject infocardSub;

	private GameObject infocardCurrency;

	private TextMeshProUGUI infoTitledescriptionSub;

	private GameObject infoCardPanel;

	private readonly List<SingleBundleCard> spawnedInfoCards;

	private ProductViewModel _bundleStoreItem;

	private Bundle _bundle;

	private PopupUI Popup
	{
		get
		{
			//IL_000c: Expected O, but got I
			object obj = (nint)0 + (nint)4008;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			PopupUI result = default(PopupUI);
			return result;
		}
	}

	public void PopulatePopup(Bundle item)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0709: Expected O, but got I
		//IL_070f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0714: Expected O, but got Unknown
		//IL_0750: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		//IL_0080: Expected O, but got I4
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_0695: Expected O, but got I
		//IL_00e3: Expected O, but got I
		//IL_0796: Expected O, but got I4
		//IL_079b: Expected I, but got O
		//IL_010b: Expected O, but got I4
		//IL_0110: Expected I, but got O
		//IL_0130: Expected O, but got I
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0150: Expected O, but got I
		//IL_015c: Expected O, but got I
		//IL_0168: Expected O, but got I
		//IL_0174: Expected O, but got I
		//IL_023c: Expected O, but got I4
		//IL_024d: Expected O, but got I4
		//IL_0252: Expected I, but got O
		//IL_01ea: Expected O, but got I4
		//IL_0303: Expected O, but got I4
		//IL_0314: Expected O, but got I4
		//IL_034a: Expected O, but got I4
		//IL_035b: Expected O, but got I4
		//IL_0383: Expected O, but got I
		//IL_0424: Expected O, but got I4
		//IL_0449: Expected I, but got O
		//IL_0643: Expected O, but got I4
		//IL_04b9: Expected I4, but got O
		//IL_05f1: Expected I, but got O
		//IL_055e: Expected O, but got I4
		//IL_039c: Expected O, but got I
		//IL_03ac: Expected O, but got I
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected O, but got Unknown
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Expected O, but got Unknown
		//IL_05cb: Expected I4, but got O
		object obj = typeof(Queue<string>) + 752;
		object obj2 = (nint)0 + (nint)2024;
		object obj3 = this + 96;
		obj3 = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj6 = obj3;
		bool flag2 = obj3 == null;
		List<long>.Enumerator enumerator = (List<long>.Enumerator)0;
		Bundle bundle = item;
		if (!flag2)
		{
			IAPController iAPController = default(IAPController);
			bool flag3 = (object)iAPController == null;
			enumerator = (List<long>.Enumerator)0;
			bundle = item;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v4+18]");
				ProductViewModel product = iAPController.GetProduct(0);
				object obj7 = this + 88;
				obj7 = product;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				LoadImage();
				object obj8 = (nint)0 + (nint)4008;
				bundle = (Bundle)obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
				PopupUI popupUI = default(PopupUI);
				bool flag4 = (object)popupUI == null;
				enumerator = (List<long>.Enumerator)0;
				nint num = unchecked((nint)null);
				if (!flag4)
				{
					popupUI.PopFromParent();
					bool flag5 = spawnedInfoCards == null;
					enumerator = (List<long>.Enumerator)0;
					num = unchecked((nint)null);
					bundle = null;
					if (!flag5)
					{
						object obj9 = (nint)0 + (nint)1248;
						object obj10 = typeof(MemberAchievementClanFeedData) + 2976;
						object obj11 = (nint)0 + (nint)2440;
						object obj12 = (nint)0 + (nint)664;
						object obj13 = (nint)0 + (nint)1464;
						object obj14 = (nint)0 + (nint)1240;
						List<object>.Enumerator enumerator2 = ((List<object>)(object)spawnedInfoCards).GetEnumerator();
						List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
						UnityEngine.Object obj17 = default(UnityEngine.Object);
						while (enumerator3.MoveNext())
						{
							object obj15 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X0_v59+E4]");
							bool flag6 = (nint)0 == 0;
							object obj16 = !flag6;
							if (obj16 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							UnityEngine.Object.Destroy(obj17);
						}
						bundle = (Bundle)obj14;
						enumerator3.Dispose();
						List<SingleBundleCard> list = spawnedInfoCards;
						bool flag7 = spawnedInfoCards == null;
						enumerator = (List<long>.Enumerator)0;
						List<object>.Enumerator enumerator5 = default(List<object>.Enumerator);
						List<long>.Enumerator enumerator4 = (List<long>.Enumerator)enumerator5;
						enumerator5 = (List<object>.Enumerator)0;
						num = unchecked((nint)null);
						if (!flag7)
						{
							int size = list._size;
							int version = list._version + 1;
							list._size = 0;
							list._version = version;
							if (list._size >= 1)
							{
								Array.Clear(list._items, 0, list._size);
								bundle = null;
							}
							object obj18 = obj7;
							bool flag8 = obj7 == null;
							enumerator = (List<long>.Enumerator)0;
							enumerator4 = (List<long>.Enumerator)enumerator5;
							enumerator5 = (List<object>.Enumerator)0;
							num = size;
							if (!flag8)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v19+30]");
								bool flag9 = (nint)0 == 0;
								enumerator = (List<long>.Enumerator)0;
								enumerator4 = (List<long>.Enumerator)enumerator5;
								enumerator5 = (List<object>.Enumerator)0;
								num = size;
								if (!flag9)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v19+30]");
									List<long>.Enumerator enumerator6 = ((List<long>)0).GetEnumerator();
									List<long>.Enumerator enumerator7 = default(List<long>.Enumerator);
									Component component = default(Component);
									while (true)
									{
										if (enumerator7.MoveNext())
										{
											object obj19 = obj10;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X0_v42+E4]");
											bool flag10 = (nint)0 == 0;
											object obj20 = !flag10;
											if (obj20 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											num = (nint)obj12;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
											if ((object)component != null)
											{
												GameObject gameObject = component.gameObject;
												if ((object)gameObject != null)
												{
													gameObject.SetActive(value: true);
													((SingleBundleCard)component).SetupForItem(item, (int)obj17);
													List<object> list2 = (List<object>)(object)spawnedInfoCards;
													if (spawnedInfoCards != null)
													{
														object obj21 = obj13;
														int version2 = list2._version + 1;
														list2._version = version2;
														object[] items = list2._items;
														if (list2._items != null)
														{
															bool flag11 = list2._size < items.Length;
															object obj22 = !flag11;
															if (obj22 != null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v31+20]");
																object obj23 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X8_v33+C0]");
																object obj24 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v34+70]");
																size = 0;
																((List<object>)(object)spawnedInfoCards).AddWithResize((object)component);
															}
															else
															{
																int size2 = list2._size + 1;
																list2._size = size2;
																object obj25 = list2._items + list2._size;
																object obj26 = obj25 + 32;
																obj26 = component;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																size = (int)obj17;
															}
															continue;
														}
													}
													NullReferenceException ex = new NullReferenceException();
													num = (nint)obj17;
													bundle = item;
												}
												else
												{
													NullReferenceException ex2 = new NullReferenceException();
													bundle = null;
												}
											}
											else
											{
												NullReferenceException ex3 = new NullReferenceException();
												bundle = (Bundle)(object)infocardParent;
											}
											break;
										}
										enumerator7.Dispose();
										return;
									}
									List<long>.Enumerator enumerator8 = default(List<long>.Enumerator);
									enumerator = enumerator8;
									enumerator4 = enumerator8;
									enumerator5 = (List<object>.Enumerator)0;
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex4 = new NullReferenceException();
		bool flag12 = (nint)bundle != 1;
		OutOfMemoryException ex5 = (OutOfMemoryException)(object)ex4;
		if (!flag12)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj27 = (nint)0 + (nint)2432;
			bundle = (Bundle)obj27;
			enumerator.Dispose();
			object obj28 = default(object);
			if (obj28 == null)
			{
				return;
			}
			ex5 = new OutOfMemoryException();
			List<object>.Enumerator enumerator5 = (List<object>.Enumerator)obj28;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2238694");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private unsafe void LoadImage()
	{
		//IL_0081: Expected I, but got O
		//IL_0305: Expected I, but got O
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00fe: Expected O, but got I4
		//IL_015f: Expected I, but got O
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_0242: Expected O, but got I4
		//IL_0252: Expected I, but got O
		//IL_025b: Expected O, but got I4
		//IL_026b: Expected I, but got O
		ProductViewModel bundleStoreItem = _bundleStoreItem;
		object obj;
		object[] array;
		nint num;
		object obj2 = default(object);
		object[] array2 = default(object[]);
		nint num2 = default(nint);
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (_bundleStoreItem != null)
		{
			bool flag = bundleStoreItem.<days>k__BackingField < 1;
			obj = obj2;
			array = array2;
			num = num2;
			if (flag)
			{
				goto IL_0279;
			}
			if ((object)infocardSub != null)
			{
				GameObject gameObject = infocardSub.gameObject;
				bool flag2 = (object)gameObject == null;
				num2 = unchecked((nint)null);
				if (!flag2)
				{
					object obj3 = typeof(TypeConverter<ushort, char>) + 3400;
					gameObject.SetActive(value: true);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					bool flag3 = _bundleStoreItem == null;
					array2 = null;
					num2 = 1;
					if (!flag3)
					{
						object obj4 = 153100288 + 1024;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						object[] array3 = default(object[]);
						bool flag4 = array3 == null;
						array2 = null;
						int num3 = default(int);
						num2 = (nint)(&num3);
						if (!flag4)
						{
							object obj5 = default(object);
							bool flag5 = obj5 == null;
							nint num4 = (nint)(&num3);
							if (!flag5)
							{
								nint num5 = (nint)array3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
								num4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag6 = ex == null;
								array2 = null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
								num2 = 0;
								if (flag6)
								{
									goto IL_0343;
								}
							}
							bool flag7 = array3.Length == 0;
							array2 = null;
							num2 = num4;
							if (flag7)
							{
								goto IL_0335;
							}
							object obj6 = "SERVICE_DISABLED" + 1344;
							object obj7 = array3 + 32;
							obj7 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							TextMeshProExtensions.Localize(infoTitledescriptionSub, (string)obj6, array3);
							bundleStoreItem = _bundleStoreItem;
							bool flag8 = _bundleStoreItem == null;
							obj = 0;
							array = array3;
							num = (nint)obj6;
							obj2 = 0;
							array2 = array3;
							num2 = (nint)obj6;
							if (!flag8)
							{
								goto IL_0279;
							}
						}
					}
				}
			}
		}
		goto IL_0327;
		IL_0327:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0335;
		IL_0279:
		if (bundleStoreItem.<coins>k__BackingField < 1)
		{
			return;
		}
		bool flag9 = (object)infocardCurrency == null;
		obj2 = obj;
		array2 = array;
		num2 = num;
		if (!flag9)
		{
			GameObject gameObject2 = infocardCurrency.gameObject;
			bool flag10 = (object)gameObject2 == null;
			obj2 = obj;
			array2 = array;
			num2 = unchecked((nint)null);
			if (!flag10)
			{
				gameObject2.SetActive(value: true);
				return;
			}
		}
		goto IL_0327;
		IL_0343:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0335:
		ex = new IndexOutOfRangeException();
		goto IL_0343;
	}

	public BundleInfoPopup()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 80;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
