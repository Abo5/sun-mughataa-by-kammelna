using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.TextCore;
using UnityEngine.UI;

public class BuyProfileGiftHandler : MonoBehaviour
{
	private ProfileGiftStoreItem itemPrefab;

	private Transform itemContainer;

	private TextMeshProUGUI totalPriceText;

	private PopupUI slider;

	private Button buyButton;

	private InputFieldTMProUGUI messageInput;

	private StoreSoundAlbum storeSoundAlbum;

	private ItemPicker<ProfileGiftStoreItem> itemPicker;

	private string targetUserId;

	private ProfileGiftsControls displayer;

	private ProfileGiftStoreItem selectedItem
	{
		get
		{
			ItemPicker<ProfileGiftStoreItem> itemPicker = this.itemPicker;
			if (this.itemPicker != null)
			{
				return itemPicker._selectedItem;
			}
			return (ProfileGiftStoreItem)(object)new NullReferenceException();
		}
	}

	public void SetTargetUserId(string userId, ProfileGiftsControls giftsDisplayer)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0050: Expected O, but got I
		object obj = this + 96;
		obj = userId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 104;
		obj2 = giftsDisplayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X20_v2-30]");
		((PopupUI)0).SlideFromBottom();
	}

	public void Hide()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)3920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4CC615C");
		UpdateTotalPrice();
		messageInput.ClearInput();
		slider.SlideToBottom();
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
		object obj2 = (nint)0 + (nint)1760;
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

	private void SelectItem(ProfileGiftStoreItem item)
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)3920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4CC615C");
		UpdateTotalPrice();
	}

	private unsafe void InitializeItems(IEnumerable<ProfileGiftModel> giftIds)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0036: Expected I, but got O
		//IL_0046: Expected O, but got I
		//IL_00f1: Expected I, but got O
		//IL_0a88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8d: Expected O, but got Unknown
		//IL_0a99: Expected O, but got I
		//IL_0aa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aad: Expected O, but got Unknown
		//IL_0ab9: Expected O, but got I
		//IL_0ac5: Expected O, but got I
		//IL_0ad5: Expected O, but got I
		//IL_0a55: Expected O, but got I
		//IL_0103: Expected O, but got I4
		//IL_0115: Expected O, but got I
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0150: Expected O, but got I
		//IL_00b2: Expected O, but got I
		//IL_020b: Expected I, but got O
		//IL_0b28: Expected I4, but got O
		//IL_0b38: Expected O, but got I
		//IL_0b4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b50: Expected O, but got Unknown
		//IL_060f: Expected O, but got I4
		//IL_0620: Expected O, but got I4
		//IL_0629: Expected O, but got I4
		//IL_0632: Expected O, but got I4
		//IL_065b: Expected O, but got I4
		//IL_0664: Expected O, but got I4
		//IL_0afc: Expected O, but got I
		//IL_0c2e: Expected O, but got I4
		//IL_021d: Expected O, but got I4
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Expected O, but got Unknown
		//IL_069e: Expected O, but got I
		//IL_01cc: Expected O, but got I
		//IL_0739: Expected I, but got O
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_02a3: Expected O, but got I
		//IL_0c98: Expected I4, but got O
		//IL_0ca8: Expected O, but got I
		//IL_035e: Expected I, but got O
		//IL_07b7: Expected O, but got I4
		//IL_0c6c: Expected O, but got I
		//IL_0bba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbf: Expected O, but got Unknown
		//IL_0be9: Expected O, but got I4
		//IL_080f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0814: Expected O, but got Unknown
		//IL_074b: Expected O, but got I4
		//IL_0758: Unknown result type (might be due to invalid IL or missing references)
		//IL_075d: Expected O, but got Unknown
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Expected O, but got Unknown
		//IL_0b7d: Expected O, but got I
		//IL_0974: Expected O, but got I4
		//IL_09a5: Expected O, but got I4
		//IL_0702: Expected O, but got I
		//IL_0370: Expected O, but got I4
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected O, but got Unknown
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected O, but got Unknown
		//IL_0404: Expected I4, but got O
		//IL_031f: Expected O, but got I
		//IL_09dc: Expected O, but got I4
		//IL_0480: Expected O, but got I4
		//IL_050f: Expected O, but got I
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected O, but got Unknown
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected O, but got Unknown
		//IL_0573: Expected I, but got O
		//IL_05a0: Expected I, but got O
		//IL_05b5: Expected O, but got I
		//IL_05be: Expected O, but got I4
		//IL_05c8: Expected O, but got I4
		object obj = typeof(List<AdaptivePerformanceScaler>) + 2800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		if (giftIds == null)
		{
			return;
		}
		object obj2 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3648;
		nint num = (nint)giftIds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v6 (Il2CppClass<System.Collections.Generic.IEnumerable`1<ProfileGiftModel>>)+12E]");
		object[] array = (object[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v6 (Il2CppClass<System.Collections.Generic.IEnumerable`1<ProfileGiftModel>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00e2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v6 (Il2CppClass<System.Collections.Generic.IEnumerable`1<ProfileGiftModel>>)+B0]");
		int num2 = (int)((nint)0 + (nint)8);
		bool flag2 = default(bool);
		bool flag = flag2;
		object obj3 = default(object);
		int num3 = default(int);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X10_v31 (System.Int32)-8]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X10_v31 (System.Int32)-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			num3 = num2 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v6 (Il2CppClass<System.Collections.Generic.IEnumerable`1<ProfileGiftModel>>)+12E]");
			array = (object[])(-1);
			flag2 = (nint)array != 1;
			flag = flag2;
			num2 = num3;
			if (flag2)
			{
				continue;
			}
			goto IL_00e2;
		}
		array = (object[])((int*)num2)->m_value;
		object obj4 = num + ((int*)num2)->m_value;
		object obj5 = obj4 + 312;
		flag2 = flag;
		num3 = num2;
		goto IL_0a79;
		IL_0a79:
		object obj6 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj7 = (nint)0 + (nint)2624;
		object obj8 = typeof(TypeConverter<ushort, char>) + 424;
		object obj9 = (nint)0 + (nint)1768;
		object obj10 = (nint)0 + (nint)1056;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X0_v5+8]");
		UnityAction<object> unityAction = (UnityAction<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v300 @ X0_v5] (should have been resolved before IL gen)");
		object obj11 = default(object);
		int num4 = (int)(&obj11);
		object obj12 = default(object);
		object obj16 = default(object);
		nint num8 = default(nint);
		object obj21 = default(object);
		object obj28 = default(object);
		ProfileGiftModel giftId = default(ProfileGiftModel);
		UnityAction<object> unityAction3 = default(UnityAction<object>);
		object obj30 = default(object);
		object obj32 = default(object);
		object obj47 = default(object);
		while (true)
		{
			object[] array2;
			object obj14;
			int num5;
			nint num7;
			if (obj12 != null)
			{
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v22+12E]");
				array2 = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v22+12E]");
				bool flag3 = (nint)0 == 0;
				obj14 = obj3;
				num5 = num3;
				if (flag3)
				{
					goto IL_01fc;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v22+B0]");
				int num6 = (int)((nint)0 + (nint)8);
				bool flag4 = flag2;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X10_v26 (System.Int32)-8]");
					obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X10_v26 (System.Int32)-8]");
					if (0 == (nint)obj6)
					{
						break;
					}
					num5 = num6 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v22+12E]");
					array2 = (object[])(-1);
					flag2 = (nint)array2 != 1;
					flag4 = flag2;
					num6 = num5;
					if (flag2)
					{
						continue;
					}
					goto IL_01fc;
				}
				array2 = (object[])((int*)num6)->m_value;
				object obj15 = obj13 + ((int*)num6)->m_value;
				obj16 = obj15 + 312;
				num7 = num8;
				flag2 = flag4;
				num5 = num6;
				goto IL_0b20;
			}
			throw new NullReferenceException();
			IL_072a:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			nint num9 = unchecked((nint)null);
			goto IL_0c90;
			IL_0672:
			object obj17 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			object obj19;
			object obj18 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X8_v18+12E]");
			array2 = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X8_v18+12E]");
			if ((nint)0 == 0)
			{
				goto IL_072a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X8_v18+B0]");
			int num10 = (int)((nint)0 + (nint)8);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X10_v13 (System.Int32)-8]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X10_v13 (System.Int32)-8]");
				if (0 == (nint)obj17)
				{
					break;
				}
				num5 = num10 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X8_v18+12E]");
				array2 = (object[])(-1);
				bool flag5 = (nint)array2 != 1;
				num10 = num5;
				if (flag5)
				{
					continue;
				}
				goto IL_072a;
			}
			array2 = (object[])((int*)num10)->m_value;
			object obj20 = obj18 + ((int*)num10)->m_value;
			obj21 = obj20 + 312;
			num9 = num7;
			num5 = num10;
			goto IL_0c90;
			IL_034f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			nint num11 = unchecked((nint)null);
			goto IL_0ba1;
			IL_0ba1:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v724 @ X0_v39] (should have been resolved before IL gen)");
			object obj22 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj23 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X0_v42+E4]");
			bool flag6 = (nint)0 == 0;
			object obj24 = !flag6;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num12 = (int)((nint)0 + (nint)616);
			num9 = ((int*)num12)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
			if (list != null)
			{
				num12 = (int)obj7;
				int version = list._version + 1;
				list._version = version;
				object[] items = list._items;
				bool flag7 = list._items == null;
				object[] items2 = list._items;
				if (!flag7)
				{
					bool flag8 = list._size < items.Length;
					object obj25 = !flag8;
					int num13;
					if (obj25 == null)
					{
						num13 = ++list._size;
						object obj26 = list._items + list._size;
						object obj27 = obj26 + 32;
						obj27 = obj28;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						nint num14 = ((int*)num12)->m_value;
						UnityAction<object> unityAction2 = (UnityAction<object>)obj28;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v13 (System.Int32)+20]");
						object obj29 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ X8_v38+C0]");
						num13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v37 (System.Int32)+70]");
						nint num14 = 0;
						list.AddWithResize(obj28);
						UnityAction<object> unityAction2 = (UnityAction<object>)obj28;
					}
					((ProfileGiftStoreItem)obj28).Initialize(giftId);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					unityAction3..ctor((object)this, (IntPtr)obj9);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X0_v45 (System.Object)+48]");
					if ((nint)0 == 0)
					{
						break;
					}
					num8 = (nint)obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X0_v45 (System.Object)+48]");
					((UnityEvent<object>)0).AddListener(unityAction3);
					obj30 = 0;
					obj3 = items.Length;
					num3 = list._size;
					array = list._items;
					unityAction = unityAction3;
					num4 = num13;
					continue;
				}
			}
			throw new NullReferenceException();
			IL_01fc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num7 = unchecked((nint)null);
			goto IL_0b20;
			IL_0b20:
			int num15 = (int)obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v35+8]");
			UnityAction<object> unityAction4 = (UnityAction<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v496 @ X0_v35] (should have been resolved before IL gen)");
			object obj31 = obj32 & 1;
			object obj35;
			int num16;
			if (obj31 != null)
			{
				if (obj12 != null)
				{
					object obj33 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1080;
					object obj34 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v27+12E]");
					object[] items2 = (object[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v27+12E]");
					bool flag9 = (nint)0 == 0;
					obj35 = obj14;
					num16 = num5;
					if (flag9)
					{
						goto IL_034f;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v27+B0]");
					int num17 = (int)((nint)0 + (nint)8);
					bool flag10 = flag2;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X10_v21 (System.Int32)-8]");
						obj35 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X10_v21 (System.Int32)-8]");
						if (0 == (nint)obj33)
						{
							break;
						}
						num16 = num17 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v27+12E]");
						items2 = (object[])(-1);
						flag2 = (nint)items2 != 1;
						flag10 = flag2;
						num17 = num16;
						if (flag2)
						{
							continue;
						}
						goto IL_034f;
					}
					items2 = (object[])((int*)num17)->m_value;
					object obj36 = obj34 + ((int*)num17)->m_value;
					object obj37 = obj36 + 312;
					num11 = num7;
					flag2 = flag10;
					num16 = num17;
					goto IL_0ba1;
				}
				throw new NullReferenceException();
			}
			bool flag11 = obj12 == null;
			object obj38 = 0;
			obj19 = obj12;
			object obj39 = 5;
			object obj40 = 0;
			obj38 = 0;
			object obj41 = obj30;
			obj35 = obj14;
			num9 = num7;
			num16 = num5;
			object obj42 = 5;
			object obj43 = 0;
			if (!flag11)
			{
				goto IL_0672;
			}
			goto IL_0c14;
			IL_0c14:
			while (true)
			{
				bool flag12 = obj43 == null;
				object obj44 = !flag12;
				obj30 = obj41;
				object[] items2 = array2;
				unityAction = unityAction4;
				num12 = num15;
				if (obj44 == null)
				{
					if ((nint)obj42 != 5)
					{
						bool flag13 = obj42 == null;
						object obj45 = !flag13;
						if (obj45 != null)
						{
							return;
						}
					}
					bool flag14 = itemPicker == null;
					obj30 = obj41;
					items2 = array2;
					unityAction = unityAction4;
					num12 = num15;
					if (!flag14)
					{
						object obj46 = itemPicker + 24;
						obj46 = list;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						UpdateTotalPrice();
						return;
					}
				}
				else
				{
					OutOfMemoryException ex = new OutOfMemoryException();
				}
				NullReferenceException ex2 = new NullReferenceException();
				if ((nint)unityAction == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
					obj40 = obj47;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
					bool flag15 = obj12 == null;
					object obj48 = !flag15;
					obj38 = obj47;
					obj14 = obj35;
					num7 = num9;
					num5 = num16;
					obj19 = obj12;
					obj39 = 0;
					if (obj48 != null)
					{
						break;
					}
					obj38 = obj47;
					obj41 = obj30;
					array2 = items2;
					unityAction4 = unityAction;
					obj42 = 0;
					num15 = num12;
					obj43 = obj47;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
				return;
			}
			goto IL_0672;
			IL_0c90:
			num15 = (int)obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X0_v29+8]");
			unityAction4 = (UnityAction<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v740 @ X0_v29] (should have been resolved before IL gen)");
			obj41 = obj30;
			obj35 = obj14;
			num16 = num5;
			obj42 = obj39;
			obj43 = obj40;
			goto IL_0c14;
		}
		throw new NullReferenceException();
		IL_00e2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num8 = unchecked((nint)null);
		goto IL_0a79;
	}

	public void BuyProfileGifts()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_005e: Expected O, but got I
		//IL_008a: Expected I, but got O
		buyButton.interactable = false;
		ItemPicker<ProfileGiftStoreItem> itemPicker = this.itemPicker;
		ProfileGiftStoreItem profileGiftStoreItem = itemPicker._selectedItem;
		ProfileGiftModel <GiftModel>k__BackingField = profileGiftStoreItem.<GiftModel>k__BackingField;
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj2 = (nint)0 + (nint)1752;
		string text = messageInput.Text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		KammelnaRequests.BuyProfileGift(<GiftModel>k__BackingField.ID, targetUserId, text, action);
	}

	private void UpdateTotalPrice()
	{
		//IL_0016: Expected O, but got I
		//IL_00bb: Expected O, but got I
		//IL_00d5: Expected O, but got I4
		//IL_008c: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_01d8: Expected O, but got I4
		//IL_021e: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E660C]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E660A]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_0066;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E660A]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0066;
			}
		}
		_ = 1;
		ItemPicker<ProfileGiftStoreItem> itemPicker = this.itemPicker;
		goto IL_00f8;
		IL_0261:
		int price;
		TextMeshProExtensions.SetPriceText(totalPriceText, price, useCommas: false, animate: true);
		ItemPicker<ProfileGiftStoreItem> itemPicker2 = this.itemPicker;
		object obj6;
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool interactable = itemPicker2._selectedItem != null;
		buyButton.interactable = interactable;
		return;
		IL_01e6:
		price = 0;
		goto IL_0261;
		IL_00f8:
		obj6 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			if (!(itemPicker._selectedItem != null))
			{
				goto IL_01e6;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = itemPicker._selectedItem != null;
			bool flag4 = !flag3;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				goto IL_01e6;
			}
		}
		ItemPicker<ProfileGiftStoreItem> itemPicker3 = this.itemPicker;
		ProfileGiftStoreItem profileGiftStoreItem = itemPicker3._selectedItem;
		ProfileGiftModel <GiftModel>k__BackingField = profileGiftStoreItem.<GiftModel>k__BackingField;
		price = <GiftModel>k__BackingField.Price;
		goto IL_0261;
		IL_0066:
		itemPicker = this.itemPicker;
		bool flag5 = this.itemPicker == null;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00f8;
	}

	private void DeselectItem()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)3920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4CC615C");
		UpdateTotalPrice();
	}

	public BuyProfileGiftHandler()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2872;
		object obj2 = (nint)0 + (nint)3896;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4CC6128");
		object obj3 = this + 88;
		object obj4 = default(object);
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <Start>b__14_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		List<ProfileGiftModel> profileGifts = Store.GetProfileGifts();
		InitializeItems(profileGifts);
	}

	private void <BuyProfileGifts>b__17_0(KammelnaResponseModel<bool> b)
	{
		//IL_0011: Expected O, but got I
		//IL_0019: Expected I4, but got O
		//IL_0169: Expected O, but got I
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_01b4: Expected O, but got I4
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_014a: Expected O, but got I4
		//IL_0262: Expected O, but got I
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_02e1: Expected O, but got I4
		//IL_0369: Expected F8, but got I4
		object obj = (nint)0 + (nint)1048;
		bool flag = (byte)(int)obj != 0;
		if (b.Succeeded)
		{
			ProfileGiftsControls profileGiftsControls = displayer;
			if ((object)displayer != null)
			{
				ItemPicker<ProfileGiftStoreItem> itemPicker = this.itemPicker;
				ProfileGiftStoreItem profileGiftStoreItem = itemPicker._selectedItem;
				ProfileGiftModel <GiftModel>k__BackingField = profileGiftStoreItem.<GiftModel>k__BackingField;
				profileGiftsControls.displayer.AddCount(<GiftModel>k__BackingField.ID);
				GameObject gameObject = profileGiftsControls.openSupportersButton.gameObject;
				gameObject.SetActive(value: true);
				flag = true;
			}
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v15+E4]");
			PlayerProfileModel playerProfileModel;
			if ((nint)0 != 0)
			{
				bool flag2 = PlayerProfilesHandler.TryGetCached(targetUserId, out playerProfileModel);
				bool flag3 = !flag2;
				object obj4 = !flag3;
				if (obj4 == null)
				{
					goto IL_0256;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				if (!PlayerProfilesHandler.TryGetCached(targetUserId, out playerProfileModel))
				{
					goto IL_0256;
				}
			}
			ItemPicker<ProfileGiftStoreItem> itemPicker2 = this.itemPicker;
			ProfileGiftStoreItem profileGiftStoreItem2 = itemPicker2._selectedItem;
			ProfileGiftModel <GiftModel>k__BackingField2 = profileGiftStoreItem2.<GiftModel>k__BackingField;
			ProfileGiftQuantityPairExtension.AddCount(playerProfileModel.<profileGifts>k__BackingField, <GiftModel>k__BackingField2.ID, 1);
			goto IL_0256;
		}
		object obj5 = (nint)0 + (nint)1024;
		string errorMessage = b.ErrorMessage;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowError(errorMessage);
		goto IL_0375;
		IL_0256:
		object obj9 = (nint)0 + (nint)2456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
		ItemPicker<ProfileGiftStoreItem> itemPicker3 = this.itemPicker;
		ProfileGiftStoreItem profileGiftStoreItem3 = itemPicker3._selectedItem;
		ProfileGiftModel <GiftModel>k__BackingField3 = profileGiftStoreItem3.<GiftModel>k__BackingField;
		object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v20+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string itemId = Tracker.BuildItemId(ResourceItemId.Like, <GiftModel>k__BackingField3.Name);
		ItemPicker<ProfileGiftStoreItem> itemPicker4 = this.itemPicker;
		ProfileGiftStoreItem profileGiftStoreItem4 = itemPicker4._selectedItem;
		ProfileGiftModel <GiftModel>k__BackingField4 = profileGiftStoreItem4.<GiftModel>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Tracker.ResourceEvent(ResourceFlowType.Sink, ResourceItemType.Social, itemId, <GiftModel>k__BackingField4.Price, ResourceCurrency.Aces);
		Hide();
		goto IL_0375;
		IL_0375:
		UpdateTotalPrice();
	}
}
