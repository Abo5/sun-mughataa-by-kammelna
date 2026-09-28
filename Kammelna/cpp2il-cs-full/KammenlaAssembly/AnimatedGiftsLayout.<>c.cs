using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class AnimatedGiftsLayout : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<StoreItem, bool> <>9__8_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1064;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <InitializeGifts>b__8_0(StoreItem i)
		{
			//IL_003d: Expected I4, but got O
			if (i != null)
			{
				return i.IsActiveAndNotAd;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass9_0
	{
		public AnimatedGiftsLayout <>4__this;

		public StoreItem gift;

		internal void <InstantiateGift>b__0()
		{
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_0119: Expected I8, but got I4
			AnimatedGiftsLayout animatedGiftsLayout = <>4__this;
			if ((object)<>4__this != null)
			{
				StoreItem storeItem = gift;
				if (gift != null)
				{
					object obj = typeof(TypeConverter<ushort, char>) + 3056;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					AnimatedGiftsLayout animatedGiftsLayout2 = <>4__this;
					if ((object)<>4__this != null)
					{
						Userbox userBox = animatedGiftsLayout2.userBox;
						if ((object)animatedGiftsLayout2.userBox != null && userBox.<player>k__BackingField != null)
						{
							string dBId = userBox.<player>k__BackingField.DBId;
							int num = int.Parse(dBId);
							long[] array = default(long[]);
							if (array != null)
							{
								array[0] = num;
								if ((object)animatedGiftsLayout.game != null)
								{
									animatedGiftsLayout.game.NotifyAnimatedGiftSent(storeItem.<id>k__BackingField, array);
									return;
								}
							}
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			throw new IndexOutOfRangeException();
		}
	}

	private Transform GiftsGrid;

	private StoreItemUIElement GiftUIElementPrefab;

	private Userbox userBox;

	private GameEventsChannel _gameEventsChannel;

	private List<StoreItemUIElement> _instantiatedItems;

	private KGame game;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0134: Expected O, but got I
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_0154: Expected O, but got I
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0192: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_006c: Expected I, but got O
		//IL_009b: Expected O, but got I4
		//IL_00fa: Expected O, but got I
		//IL_0112: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)24;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)1696;
		object obj5 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj8 = this + 72;
		object obj9 = default(object);
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj4);
		object obj10 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Store.CallWhenLoaded(action);
		if ((bool)userBox)
		{
			object obj12 = (nint)0 + (nint)1720;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action2 = default(Action);
			action2..ctor(this, (IntPtr)obj12);
			userBox.OnUserRefreshed += action2;
		}
	}

	private void OnDestroy()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0147: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00e0: Expected O, but got I
		//IL_00f8: Expected I, but got O
		//IL_0191: Expected O, but got I4
		//IL_019a: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B5E]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = userBox;
			obj6 = userBox;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = userBox;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = userBox;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00c0;
		IL_00c0:
		object obj10 = typeof(SqlSingle[]) + 2376;
		object obj11 = (nint)0 + (nint)1720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj11);
		userBox.OnUserRefreshed -= action;
		return;
		IL_0091:
		bool flag5 = obj5;
		bool flag6 = !flag5;
		obj9 = 0;
		if (!flag6)
		{
			goto IL_00c0;
		}
	}

	private void InitializeGifts()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_015b: Expected O, but got I4
		//IL_0060: Expected O, but got I4
		//IL_0175: Expected O, but got I
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_0195: Expected O, but got I
		//IL_01a6: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d8: Expected O, but got I4
		//IL_010a: Expected I, but got O
		//IL_00a7: Expected O, but got I4
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_0210: Expected O, but got I
		//IL_0221: Expected I, but got O
		//IL_023f: Expected O, but got I
		//IL_00d7: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj2 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1064;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IEnumerable<StoreItem> categoryItems = Store.GetCategoryItems(ItemCategory.AnimatedGifts);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj2;
		}
		object obj7 = (nint)0 + (nint)3768;
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3544;
		object obj9 = (nint)0 + (nint)1704;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v7+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v7+8]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v7+8]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v7+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj13 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v13+B8]");
				obj10 = 0;
			}
			object obj14 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3432;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj15 = (nint)0 + (nint)3336;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj10, (IntPtr)obj15);
			object obj16 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v12+B8]");
			object obj17 = (nint)0 + (nint)8;
			obj17 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			predicate = func;
		}
		IEnumerable<object> enumeration = Enumerable.Where(categoryItems, predicate);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj9);
		ArraysExtensions.ForEach(enumeration, action);
	}

	private void InstantiateGift(StoreItem gift)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_00a5: Expected O, but got I4
		//IL_00ef: Expected O, but got I
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0149: Expected O, but got I
		//IL_0169: Expected O, but got I4
		//IL_01e6: Expected O, but got I
		//IL_01f6: Expected O, but got I
		//IL_0206: Expected O, but got I
		//IL_023b: Expected I, but got O
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1072;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = (nint)0 + (nint)720;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 24;
		obj6 = gift;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		List<object> instantiatedItems = (List<object>)(object)_instantiatedItems;
		object obj10 = (nint)0 + (nint)2960;
		object obj11 = obj10;
		int version = instantiatedItems._version + 1;
		instantiatedItems._version = version;
		object[] items = instantiatedItems._items;
		object obj12 = typeof(SqlSingle[]) + 2376;
		object obj13 = (nint)0 + (nint)3344;
		bool flag2 = instantiatedItems._size < items.Length;
		object obj14 = !flag2;
		object obj17 = default(object);
		if (obj14 == null)
		{
			int size = instantiatedItems._size + 1;
			instantiatedItems._size = size;
			object obj15 = items + instantiatedItems._size;
			object obj16 = obj15 + 32;
			obj16 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj18 = obj17;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v7+20]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v9+C0]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v10+70]");
			obj9 = 0;
			instantiatedItems.AddWithResize(obj17);
			object obj18 = obj17;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj13);
		((StoreItemUIElement)obj17).OnBuySuccess += action;
		((StoreItemUIElement)obj17).Populate((StoreItem)obj6);
	}

	private void RefreshRecipients()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004e: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3552;
		object obj2 = (nint)0 + (nint)1712;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		((List<object>)(object)_instantiatedItems).ForEach(action);
	}

	private void RefreshRecipient(StoreItemUIElement item)
	{
		//IL_0160: Expected O, but got I4
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_011f: Expected O, but got I4
		Userbox userbox = userBox;
		object obj4;
		if ((object)userBox != null)
		{
			CardGamePlayer <player>k__BackingField = userbox.<player>k__BackingField;
			if (userbox.<player>k__BackingField != null && ((KPlayer)<player>k__BackingField).<User>k__BackingField != null)
			{
				object obj = typeof(TypeConverter<ushort, char>) + 3056;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				Userbox userbox2 = userBox;
				if ((object)userBox != null && userbox2.<player>k__BackingField != null)
				{
					string dBId = userbox2.<player>k__BackingField.DBId;
					long num = long.Parse(dBId);
					object obj2 = default(object);
					if (obj2 != null)
					{
						bool flag = (object)item == null;
						object obj3 = !flag;
						obj4 = obj2;
						if (obj3 != null)
						{
							goto IL_01a3;
						}
					}
				}
			}
			else if ((object)item != null)
			{
				obj4 = 0;
				goto IL_01a3;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_01a3:
		object obj5 = item + 88;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public AnimatedGiftsLayout()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3600;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 64;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
