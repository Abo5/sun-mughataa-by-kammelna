using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.UI;

public class ProfileGiftsSendersDisplayer : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<ProfileGiftsSenderUIItem> <>9__7_0;

		public static Func<ProfileGiftsSenderModel, int> <>9__7_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3576;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Populate>b__7_0(ProfileGiftsSenderUIItem i)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			GameObject gameObject = i.gameObject;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+E4]");
			if ((nint)0 != 0)
			{
				UnityEngine.Object.Destroy(gameObject);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			UnityEngine.Object.Destroy(gameObject);
		}

		internal int <Populate>b__7_1(ProfileGiftsSenderModel m)
		{
			//IL_0042: Expected I4, but got O
			if (m != null)
			{
				return ProfileGiftQuantityPairExtension.GetTotalValue(m.<SentGifts>k__BackingField);
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private ProfileGiftsSenderUIItem itemPrefab;

	private Transform layout;

	private PopupUI slider;

	private Button OpenBuyGiftsButton;

	private GameObject emptyLabel;

	private PlayerProfile playerProfile;

	private List<ProfileGiftsSenderUIItem> items;

	public void Populate(IEnumerable<ProfileGiftsSenderModel> model, PlayerProfile profile)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_014c: Expected O, but got I4
		//IL_00a0: Expected O, but got I
		//IL_00b0: Expected O, but got I
		//IL_01f8: Expected O, but got I4
		//IL_018e: Expected O, but got I
		//IL_019e: Expected O, but got I
		//IL_01c0: Expected O, but got I4
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Expected O, but got Unknown
		//IL_0663: Expected O, but got I
		//IL_0674: Expected I, but got O
		//IL_0692: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_0232: Expected I, but got O
		//IL_0228: Expected O, but got I
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected O, but got Unknown
		//IL_0331: Expected O, but got I4
		//IL_02d5: Expected I, but got O
		//IL_06bb: Expected O, but got I
		//IL_06cb: Expected O, but got I
		//IL_06ed: Expected O, but got I4
		//IL_0378: Expected O, but got I4
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		//IL_070f: Expected O, but got Unknown
		//IL_0725: Expected O, but got I
		//IL_0736: Expected I, but got O
		//IL_0754: Expected O, but got I
		//IL_076b: Expected I, but got O
		//IL_03fe: Expected O, but got I
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected O, but got Unknown
		//IL_041e: Expected O, but got I
		//IL_03a8: Expected O, but got I
		//IL_049b: Expected O, but got I4
		//IL_0548: Expected O, but got I4
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Expected O, but got Unknown
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected O, but got Unknown
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3576;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6548]");
		object obj2 = (nint)0 & (nint)1;
		List<ProfileGiftsSenderUIItem> list;
		List<ProfileGiftsSenderUIItem> list2;
		object obj3;
		if (obj2 != null)
		{
			list = items;
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v47+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			list2 = items;
			if (!flag)
			{
				goto IL_0090;
			}
		}
		else
		{
			_ = 1;
			list = items;
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v47+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			list2 = items;
			if (obj5 != null)
			{
				goto IL_0090;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v47+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v31+8]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v31+8]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		list = list2;
		if (obj7 != null)
		{
			goto IL_00dd;
		}
		goto IL_01d6;
		IL_0247:
		List<object> list3;
		list3.ForEach(action);
		List<ProfileGiftsSenderUIItem> list4 = items;
		int version = list4._version + 1;
		list4._size = 0;
		list4._version = version;
		nint num;
		if (list4._size >= 1)
		{
			Array.Clear(list4._items, 0, list4._size);
			num = unchecked((nint)null);
		}
		slider.SlideFromBottom();
		object obj8 = this + 72;
		obj8 = profile;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v11+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v22+10]");
		Func<object, int> keySelector = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v22+10]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v11+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj14 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v28+B8]");
				obj11 = 0;
			}
			object obj15 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj16 = (nint)0 + (nint)2608;
			Func<object, int> func = default(Func<object, int>);
			func..ctor(obj11, (IntPtr)obj16);
			object obj17 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v27+B8]");
			object obj18 = (nint)0 + (nint)16;
			obj18 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			num = unchecked((nint)null);
			keySelector = func;
		}
		IOrderedEnumerable<object> source = Enumerable.OrderByDescending(model, keySelector);
		List<object> list5 = Enumerable.ToList(source);
		if (list5._size >= 1)
		{
			object obj19 = (nint)0 + (nint)2640;
			object obj20 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj21 = (nint)0 + (nint)624;
			int num2 = 0;
			ProfileGiftsSenderUIItem profileGiftsSenderUIItem = default(ProfileGiftsSenderUIItem);
			while (true)
			{
				object model2 = list5.get_Item(num2);
				object obj22 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X0_v28+E4]");
				bool flag7 = (nint)0 == 0;
				object obj23 = !flag7;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
				num2++;
				profileGiftsSenderUIItem.Populate((ProfileGiftsSenderModel)model2, num2);
				List<object> list6 = (List<object>)(object)items;
				int version2 = list6._version + 1;
				list6._version = version2;
				object[] array = list6._items;
				bool flag8 = list6._size < array.Length;
				object obj24 = !flag8;
				if (obj24 != null)
				{
					list6.AddWithResize((object)profileGiftsSenderUIItem);
					if (num2 >= list5._size)
					{
						break;
					}
					continue;
				}
				int size = list6._size + 1;
				list6._size = size;
				object obj25 = array + list6._size;
				object obj26 = obj25 + 32;
				obj26 = profileGiftsSenderUIItem;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if (num2 >= list5._size)
				{
					break;
				}
			}
		}
		bool active = ArraysExtensions.IsNullOrEmpty(list5);
		emptyLabel.SetActive(active);
		GameObject gameObject = OpenBuyGiftsButton.gameObject;
		bool isMyProfile = profile.IsMyProfile;
		bool active2 = (byte)((isMyProfile ? 1u : 0u) ^ 1u) != 0;
		gameObject.SetActive(active2);
		return;
		IL_00dd:
		bool flag9 = list == null;
		object obj27 = !flag9;
		list3 = (List<object>)(object)list;
		if (obj27 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0247;
		IL_01d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v47+E4]");
		bool flag10 = (nint)0 == 0;
		object obj28 = !flag10;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj29 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v37+B8]");
			obj6 = 0;
		}
		object obj30 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3192;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj31 = (nint)0 + (nint)2600;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj6, (IntPtr)obj31);
		object obj32 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v36+B8]");
		object obj33 = (nint)0 + (nint)8;
		obj33 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		num = unchecked((nint)null);
		action = action2;
		list3 = (List<object>)(object)list2;
		goto IL_0247;
		IL_0090:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v47+B8]");
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v31+8]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v31+8]");
		bool flag11 = (nint)0 == 0;
		list2 = list;
		if (!flag11)
		{
			goto IL_00dd;
		}
		goto IL_01d6;
	}

	public void Hide()
	{
		slider.SlideToBottom();
	}

	public void OpenBuyGifts()
	{
		playerProfile.ShowSendProfileGift();
	}

	public ProfileGiftsSendersDisplayer()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 2808;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 80;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
