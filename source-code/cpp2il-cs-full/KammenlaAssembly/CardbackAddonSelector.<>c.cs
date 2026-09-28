using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class CardbackAddonSelector : TournamentAddonSelector
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<TournamentCardBackItem> <>9__21_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Refresh>b__21_0(TournamentCardBackItem p)
		{
			p.Refresh();
		}
	}

	private sealed class <>c__DisplayClass19_0
	{
		public StoreOwnedItem item;

		internal bool <Populate>b__0(TournamentCardBackItem cb)
		{
			//IL_008a: Expected I4, but got O
			//IL_005d: Expected O, but got I4
			if ((object)cb != null)
			{
				StoreOwnedItem storeOwnedItem = item;
				if (item != null)
				{
					object obj = cb.<cardbackId>k__BackingField - storeOwnedItem.<itemId>k__BackingField;
					bool flag = obj == null;
					return !flag;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass23_0
	{
		public CardbackTournamentAddon addon;

		internal bool <ShowConfirmedSelection>b__0(TournamentCardBackItem cardbackItem)
		{
			//IL_005f: Expected I4, but got O
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected O, but got Unknown
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected I4, but got Unknown
			if ((object)cardbackItem != null)
			{
				int? num = (int?)addon;
				if (addon != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v4 (System.Nullable`1<System.Int32>)+10]");
					int? num2 = 0;
					num = num2;
				}
				object obj = (object?)num >> 32;
				object obj2 = cardbackItem.<cardbackId>k__BackingField - obj;
				bool flag = obj2 == null;
				return (byte)((flag & (??)num) ? 1 : 0) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private new Action m_OnValidStateChange;

	private TournamentCardBackItem itemPrefab;

	private Transform parent;

	private GameObject emptyState;

	private List<TournamentCardBackItem> populatedItems;

	private TournamentCardBackItem <selectedItem>k__BackingField;

	public override string Title => "Cannot populate JSON object onto type '{0}'." + 1680;

	public override string Subtitle => "ThisIsFakeReceiptData" + 456;

	public override TournamentAddonType addonType => TournamentAddonType.Cardback;

	public override bool IsValid
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0067: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return <selectedItem>k__BackingField != null;
		}
	}

	public TournamentCardBackItem selectedItem
	{
		get
		{
			return <selectedItem>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 80;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public override event Action OnValidStateChange
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 40;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 40;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public void Populate(List<StoreOwnedItem> items)
	{
		//IL_0565: Expected O, but got I4
		//IL_056e: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0046: Expected O, but got I
		//IL_0052: Expected O, but got I
		//IL_037e: Expected O, but got I
		//IL_03b1: Expected O, but got I4
		//IL_04d4: Expected O, but got I
		//IL_047a: Expected O, but got I4
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_0150: Expected I, but got O
		//IL_0158: Expected I, but got O
		//IL_0188: Expected O, but got I4
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01e8: Expected O, but got I4
		//IL_0211: Expected O, but got I
		//IL_0219: Expected I, but got O
		//IL_044a: Expected O, but got I4
		//IL_0426: Expected O, but got I4
		//IL_042b: Expected I, but got O
		//IL_0283: Expected O, but got I
		//IL_02fa: Expected O, but got I4
		//IL_0074: Expected O, but got I
		//IL_0084: Expected O, but got I
		//IL_00ac: Expected O, but got I4
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected O, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected O, but got Unknown
		//IL_0368: Expected O, but got I4
		//IL_036d: Expected I, but got O
		List<StoreOwnedItem> list = default(List<StoreOwnedItem>);
		bool flag = list == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		object obj = 152985600;
		List<StoreOwnedItem> list5 = default(List<StoreOwnedItem>);
		List<StoreOwnedItem> list6;
		if (!flag)
		{
			object obj2 = (nint)0 + (nint)1824;
			object obj3 = typeof(CardUtils.<>c) + 24;
			object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3872;
			object obj5 = (nint)0 + (nint)2696;
			obj = (nint)0 + (nint)1968;
			List<object>.Enumerator enumerator2 = ((List<object>)(object)list).GetEnumerator();
			List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
			object obj6 = default(object);
			object obj8 = default(object);
			Func<object, bool> func = default(Func<object, bool>);
			object obj14 = default(object);
			List<object>.Enumerator enumerator5;
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			while (enumerator3.MoveNext())
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj6..ctor();
				List<StoreOwnedItem> list4;
				if (obj6 != null)
				{
					object obj7 = obj6 + 16;
					obj7 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					func..ctor(obj6, (IntPtr)obj5);
					nint num = (nint)obj;
					bool flag2 = Enumerable.All(populatedItems, func);
					bool flag3 = !flag2;
					object obj9 = 0;
					List<StoreOwnedItem> list2 = (List<StoreOwnedItem>)(object)populatedItems;
					if (flag3)
					{
						continue;
					}
					list2 = (List<StoreOwnedItem>)(object)parent;
					object obj10 = typeof(MemberAchievementClanFeedData) + 2976;
					object obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X0_v33+E4]");
					bool flag4 = (nint)0 == 0;
					object obj12 = !flag4;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj13 = (nint)0 + (nint)792;
					num = (nint)obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
					if (obj14 != null)
					{
						((TournamentCardBackItem)obj14).PopulateInfo((StoreOwnedItem)obj7, this);
						List<object> list3 = (List<object>)(object)populatedItems;
						if (populatedItems != null)
						{
							object obj15 = (nint)0 + (nint)1296;
							object obj16 = obj15;
							int version = list3._version + 1;
							list3._version = version;
							object[] items2 = list3._items;
							if (list3._items != null)
							{
								bool flag5 = list3._size < items2.Length;
								object obj17 = !flag5;
								if (obj17 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v27+20]");
									object obj18 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v29+C0]");
									object obj19 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v30+70]");
									num = 0;
									((List<object>)(object)populatedItems).AddWithResize(obj14);
									obj9 = 0;
								}
								else
								{
									int size = list3._size + 1;
									list3._size = size;
									object obj20 = list3._items + list3._size;
									object obj21 = obj20 + 32;
									obj21 = obj14;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									obj9 = 0;
									num = (nint)this;
								}
								continue;
							}
						}
						NullReferenceException ex = new NullReferenceException();
						obj9 = 0;
						num = (nint)this;
						list4 = (List<StoreOwnedItem>)obj7;
					}
					else
					{
						NullReferenceException ex2 = new NullReferenceException();
						obj9 = 0;
						list4 = list2;
					}
				}
				else
				{
					NullReferenceException ex3 = new NullReferenceException();
					list4 = null;
				}
				enumerator = enumerator4;
				enumerator5 = enumerator4;
				list5 = list;
				enumerator4 = (List<object>.Enumerator)0;
				list = list4;
				goto IL_057c;
			}
			object obj22 = (nint)0 + (nint)1816;
			list6 = (List<StoreOwnedItem>)obj22;
			enumerator3.Dispose();
			enumerator = enumerator4;
			enumerator5 = enumerator4;
			list5 = list;
			enumerator4 = (List<object>.Enumerator)0;
			goto IL_03b6;
		}
		goto IL_057c;
		IL_03b6:
		bool flag6 = (object)emptyState == null;
		list = list6;
		if (!flag6)
		{
			bool active = list5._size == 0;
			emptyState.SetActive(active);
			return;
		}
		goto IL_057c;
		IL_057c:
		NullReferenceException ex4 = new NullReferenceException();
		bool flag7 = (nint)list != 1;
		OutOfMemoryException ex5 = (OutOfMemoryException)(object)ex4;
		if (!flag7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj23 = (nint)0 + (nint)1816;
			list6 = (List<StoreOwnedItem>)obj23;
			enumerator.Dispose();
			object obj24 = default(object);
			bool flag8 = obj24 == null;
			List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj24;
			if (flag8)
			{
				goto IL_03b6;
			}
			ex5 = new OutOfMemoryException();
			enumerator4 = (List<object>.Enumerator)obj24;
			list = (List<StoreOwnedItem>)obj23;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22391BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public override void Clear()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		//IL_0023: Expected I, but got O
		//IL_0033: Expected O, but got I
		//IL_0043: Expected O, but got I
		object obj = this + 80;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v1 (Il2CppClass<CardbackAddonSelector>)+1E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v1 (Il2CppClass<CardbackAddonSelector>)+1F0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v30 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public override void Refresh()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0195: Expected O, but got I4
		//IL_00a9: Expected O, but got I
		//IL_00b9: Expected O, but got I
		//IL_0241: Expected O, but got I4
		//IL_01d7: Expected O, but got I
		//IL_01e7: Expected O, but got I
		//IL_0209: Expected O, but got I4
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected O, but got Unknown
		//IL_02ed: Expected O, but got I
		//IL_02fe: Expected I, but got O
		//IL_031c: Expected O, but got I
		//IL_0290: Expected O, but got I4
		//IL_0299: Expected O, but got I4
		//IL_0271: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(CardUtils.<>c) + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6C4B]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_015b;
		}
		List<TournamentCardBackItem> list = populatedItems;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = obj4;
		List<TournamentCardBackItem> list2 = populatedItems;
		if (!flag)
		{
			goto IL_0099;
		}
		goto IL_01b5;
		IL_01b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v4+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v5+8]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v5+8]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		list = list2;
		if (obj7 != null)
		{
			goto IL_00e6;
		}
		goto IL_021f;
		IL_0099:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v4+B8]");
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v5+8]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v5+8]");
		bool flag3 = (nint)0 == 0;
		list2 = list;
		if (!flag3)
		{
			goto IL_00e6;
		}
		goto IL_021f;
		IL_00e6:
		List<object> list3 = (List<object>)(object)list;
		goto IL_00f3;
		IL_00f3:
		list3.ForEach(action);
		Action onValidStateChange = OnValidStateChange;
		if (OnValidStateChange != null)
		{
			IntPtr invoke_impl = ((Delegate)onValidStateChange).invoke_impl;
			IntPtr method_code = ((Delegate)onValidStateChange).method_code;
			IntPtr method = ((Delegate)onValidStateChange).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v161 @ X2_v6 (System.IntPtr) (should have been resolved before IL gen)");
			goto IL_015b;
		}
		return;
		IL_021f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v4+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v11+B8]");
			obj6 = 0;
		}
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3752;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)2688;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj6, (IntPtr)obj11);
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v10+B8]");
		object obj13 = (nint)0 + (nint)8;
		obj13 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag5 = list2 == null;
		object obj14 = !flag5;
		object obj15 = 0;
		action = action2;
		list3 = (List<object>)(object)list2;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00f3;
		IL_015b:
		_ = 1;
		list = populatedItems;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v4+E4]");
		bool flag6 = (nint)0 == 0;
		object obj16 = !flag6;
		obj5 = obj4;
		list2 = populatedItems;
		if (obj16 != null)
		{
			goto IL_0099;
		}
		goto IL_01b5;
	}

	public override void OnConfirm()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 384;
		int num = default(int);
		string s = num.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		int num2 = int.Parse(s);
		eventsChannel.TriggerAddAddon((TournamentAddonModel)obj2);
	}

	public override void ShowConfirmedSelection(TournamentAddonModel tournamentAddonModel)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_019f: Expected O, but got I4
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_0240: Expected O, but got I
		//IL_024c: Expected O, but got I
		//IL_0271: Expected I, but got O
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_005a: Expected I, but got O
		//IL_0083: Expected O, but got I4
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_01de: Expected I, but got O
		//IL_01ee: Expected O, but got I
		//IL_01fe: Expected O, but got I
		//IL_00b7: Expected O, but got I
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00fc: Expected I, but got O
		//IL_0125: Expected O, but got I4
		//IL_0159: Expected O, but got I
		object obj = typeof(CardUtils.<>c) + 32;
		object obj2 = default(object);
		Func<object, bool> func = default(Func<object, bool>);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj2..ctor();
			if (tournamentAddonModel != null)
			{
				object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 384;
				object obj4 = obj3;
				nint num = (nint)tournamentAddonModel;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X9_v3 (Il2CppClass<TournamentAddonModel>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X1_v9+130]");
				bool flag = num2 < 0;
				object obj5 = !flag;
				object obj6 = ~obj5;
				if (obj6 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X9_v3 (Il2CppClass<TournamentAddonModel>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X1_v9+130]");
				object obj7 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X9_v6-8]");
				if (0 != (nint)obj4)
				{
					break;
				}
				object obj8 = obj2 + 16;
				obj8 = tournamentAddonModel;
				nint num4 = (nint)tournamentAddonModel;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X9_v8 (Il2CppClass<TournamentAddonModel>)+130]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X1_v9+130]");
				bool flag2 = num5 < 0;
				object obj9 = !flag2;
				object obj10 = ~obj9;
				if (obj10 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X9_v8 (Il2CppClass<TournamentAddonModel>)+C8]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X1_v9+130]");
				object obj11 = num6 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v10-8]");
				if (0 != (nint)obj4)
				{
					break;
				}
			}
			else
			{
				object obj8 = obj2 + 16;
				obj8 = 0;
			}
			object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3872;
			object obj13 = (nint)0 + (nint)2704;
			object obj14 = (nint)0 + (nint)1312;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			func..ctor(obj2, (IntPtr)obj13);
			object obj15 = Enumerable.FirstOrDefault(populatedItems, func);
			object obj16 = this + 80;
			obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			nint num7 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v4 (Il2CppClass<CardbackAddonSelector>)+1E8]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v4 (Il2CppClass<CardbackAddonSelector>)+1F0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v192 @ X2_v3 (should have been resolved before IL gen)");
		}
		throw new InvalidCastException();
	}

	public void SelectItem(TournamentCardBackItem itemToSelect)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0022: Expected I, but got O
		//IL_0032: Expected O, but got I
		//IL_0042: Expected O, but got I
		object obj = this + 80;
		obj = itemToSelect;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v1 (Il2CppClass<CardbackAddonSelector>)+1E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v1 (Il2CppClass<CardbackAddonSelector>)+1F0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v30 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public CardbackAddonSelector()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 72;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((MonoBehaviour)this)..ctor();
	}
}
