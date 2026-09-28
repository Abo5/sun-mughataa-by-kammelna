using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using Util.Extensions;

public class StageMark : MonoBehaviour
{
	private TextMeshProUGUI stageNameField;

	private GameObject statusActive;

	private GameObject statusPlaying;

	private GameObject statusNotStarted;

	private GameObject statusWon;

	private GameObject statusKnockedOut;

	private GameObject statusReserved;

	private List<GameObject> _statusObjects;

	public unsafe void Initialize(int stageNumber, bool isFinalStage)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0062: Expected O, but got I4
		//IL_0088: Expected O, but got Ref
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_01a0: Expected O, but got I
		//IL_00ad: Expected O, but got Ref
		//IL_01d7: Expected I4, but got O
		//IL_00c3: Expected I, but got O
		//IL_00d3: Expected O, but got I
		//IL_00fc: Expected O, but got I
		//IL_01f1: Expected O, but got I
		//IL_024c: Expected I4, but got O
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_027a: Expected O, but got I4
		//IL_02fe: Expected O, but got I
		//IL_030e: Expected O, but got I
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected O, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_02e9: Expected I4, but got O
		//IL_03b3: Expected O, but got I4
		//IL_042f: Expected O, but got I
		//IL_043f: Expected O, but got I
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected O, but got Unknown
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected O, but got Unknown
		//IL_04e4: Expected O, but got I4
		//IL_0560: Expected O, but got I
		//IL_0570: Expected O, but got I
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Expected O, but got Unknown
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Expected O, but got Unknown
		//IL_0615: Expected O, but got I4
		//IL_0691: Expected O, but got I
		//IL_06a1: Expected O, but got I
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Expected O, but got Unknown
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected O, but got Unknown
		//IL_0746: Expected O, but got I4
		//IL_07c2: Expected O, but got I
		//IL_07d2: Expected O, but got I
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_078b: Expected O, but got Unknown
		//IL_0794: Unknown result type (might be due to invalid IL or missing references)
		//IL_0799: Expected O, but got Unknown
		//IL_0877: Expected O, but got I4
		//IL_08f3: Expected O, but got I
		//IL_0903: Expected O, but got I
		//IL_092d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0932: Expected O, but got Unknown
		//IL_08b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bc: Expected O, but got Unknown
		//IL_08c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ca: Expected O, but got Unknown
		//IL_09a0: Expected O, but got I
		object[] array;
		object obj4;
		bool flag = default(bool);
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj6;
		if (flag)
		{
			object obj = "fetch_products" + 256;
			string text = (string)obj;
			TextMeshProExtensions.Localize(stageNameField, (string)obj);
			array = null;
		}
		else
		{
			object obj2 = typeof(TypeConverter<ushort, char>) + 3400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object obj3 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object[] array2 = default(object[]);
			bool flag2 = array2 == null;
			int num = default(int);
			obj4 = (object)(&num);
			if (flag2)
			{
				goto IL_09a1;
			}
			object obj5 = default(object);
			bool flag3 = obj5 == null;
			obj4 = (object)(&num);
			if (!flag3)
			{
				nint num2 = (nint)array2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v47 (Il2CppClass<System.Object[]>)+40]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag4 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v47 (Il2CppClass<System.Object[]>)+40]");
				obj6 = 0;
				if (flag4)
				{
					goto IL_09c5;
				}
			}
			if (array2.Length == 0)
			{
				goto IL_09af;
			}
			object obj7 = array2 + 32;
			obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj8 = "SetRoomVariables request error" + 2568;
			string text = (string)obj8;
			TextMeshProExtensions.Localize(stageNameField, (string)obj8, array2);
			array = array2;
		}
		object obj9 = typeof(List<AdaptivePerformanceScaler>) + 1168;
		object obj10 = (nint)0 + (nint)2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		obj4 = obj10;
		List<object> list = default(List<object>);
		list..ctor();
		bool flag5 = list == null;
		flag = (byte)(int)array != 0;
		if (!flag5)
		{
			object obj11 = (nint)0 + (nint)2544;
			obj4 = statusActive;
			object obj12 = obj11;
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			bool flag6 = list._items == null;
			flag = (byte)(int)array != 0;
			if (!flag6)
			{
				bool flag7 = list._size < items.Length;
				object obj13 = !flag7;
				if (obj13 == null)
				{
					int size = list._size + 1;
					list._size = size;
					object obj14 = list._items + list._size;
					object obj15 = obj14 + 32;
					obj15 = statusActive;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					flag = (byte)(int)array != 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v9+20]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v36+C0]");
					object obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v37+70]");
					flag = false;
					list.AddWithResize((object)statusActive);
				}
				obj4 = statusPlaying;
				object obj18 = obj11;
				int version2 = list._version + 1;
				list._version = version2;
				object[] items2 = list._items;
				if (list._items != null)
				{
					bool flag8 = list._size < items2.Length;
					object obj19 = !flag8;
					if (obj19 == null)
					{
						int size2 = list._size + 1;
						list._size = size2;
						object obj20 = list._items + list._size;
						object obj21 = obj20 + 32;
						obj21 = statusPlaying;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v11+20]");
						object obj22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v33+C0]");
						object obj23 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v34+70]");
						flag = false;
						list.AddWithResize((object)statusPlaying);
					}
					obj4 = statusNotStarted;
					object obj24 = obj11;
					int version3 = list._version + 1;
					list._version = version3;
					object[] items3 = list._items;
					if (list._items != null)
					{
						bool flag9 = list._size < items3.Length;
						object obj25 = !flag9;
						if (obj25 == null)
						{
							int size3 = list._size + 1;
							list._size = size3;
							object obj26 = list._items + list._size;
							object obj27 = obj26 + 32;
							obj27 = statusNotStarted;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v13+20]");
							object obj28 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v30+C0]");
							object obj29 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v31+70]");
							flag = false;
							list.AddWithResize((object)statusNotStarted);
						}
						obj4 = statusWon;
						object obj30 = obj11;
						int version4 = list._version + 1;
						list._version = version4;
						object[] items4 = list._items;
						if (list._items != null)
						{
							bool flag10 = list._size < items4.Length;
							object obj31 = !flag10;
							if (obj31 == null)
							{
								int size4 = list._size + 1;
								list._size = size4;
								object obj32 = list._items + list._size;
								object obj33 = obj32 + 32;
								obj33 = statusWon;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v15+20]");
								object obj34 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v27+C0]");
								object obj35 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v28+70]");
								flag = false;
								list.AddWithResize((object)statusWon);
							}
							obj4 = statusKnockedOut;
							object obj36 = obj11;
							int version5 = list._version + 1;
							list._version = version5;
							object[] items5 = list._items;
							if (list._items != null)
							{
								bool flag11 = list._size < items5.Length;
								object obj37 = !flag11;
								if (obj37 == null)
								{
									int size5 = list._size + 1;
									list._size = size5;
									object obj38 = list._items + list._size;
									object obj39 = obj38 + 32;
									obj39 = statusKnockedOut;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v17+20]");
									object obj40 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v24+C0]");
									object obj41 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v25+70]");
									flag = false;
									list.AddWithResize((object)statusKnockedOut);
								}
								obj4 = statusReserved;
								object obj42 = obj11;
								int version6 = list._version + 1;
								list._version = version6;
								object[] items6 = list._items;
								if (list._items != null)
								{
									bool flag12 = list._size < items6.Length;
									object obj43 = !flag12;
									if (obj43 == null)
									{
										int size6 = list._size + 1;
										list._size = size6;
										object obj44 = list._items + list._size;
										object obj45 = obj44 + 32;
										obj45 = statusReserved;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v19+20]");
										object obj46 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v21+C0]");
										object obj47 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v22+70]");
										flag = false;
										list.AddWithResize((object)statusReserved);
									}
									object obj48 = this + 88;
									obj48 = list;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									ComponentListsExtensions.SetActive((IEnumerable<GameObject>)obj48, active: false);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X19_v5-20]");
									bool flag13 = (nint)0 == 0;
									flag = false;
									obj4 = null;
									if (!flag13)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X19_v5-20]");
										((GameObject)0).SetActive(value: true);
										return;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_09a1;
		IL_09af:
		ex = new IndexOutOfRangeException();
		obj6 = obj4;
		goto IL_09c5;
		IL_09c5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_09a1:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_09af;
	}

	public void SetActive()
	{
		ComponentListsExtensions.SetActive(_statusObjects, active: false);
		statusActive.SetActive(value: true);
	}

	public void SetPlaying()
	{
		ComponentListsExtensions.SetActive(_statusObjects, active: false);
		statusPlaying.SetActive(value: true);
	}

	public void SetNotStarted()
	{
		ComponentListsExtensions.SetActive(_statusObjects, active: false);
		statusNotStarted.SetActive(value: true);
	}

	public void SetWon()
	{
		ComponentListsExtensions.SetActive(_statusObjects, active: false);
		statusWon.SetActive(value: true);
	}

	public void SetKnockedOut()
	{
		ComponentListsExtensions.SetActive(_statusObjects, active: false);
		statusKnockedOut.SetActive(value: true);
	}

	public void SetReserved()
	{
		ComponentListsExtensions.SetActive(_statusObjects, active: false);
		statusReserved.SetActive(value: true);
	}

	private void SetStatus(GameObject status)
	{
		ComponentListsExtensions.SetActive(_statusObjects, active: false);
		status.SetActive(value: true);
	}
}
