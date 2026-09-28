using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Spine;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public class TitleAddonSelector : TournamentAddonSelector
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<TournamentTitleItem> <>9__17_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 3160;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Refresh>b__17_0(TournamentTitleItem p)
		{
			//IL_0047: Expected O, but got I
			//IL_001b: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (TournamentTitleItem)+40]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v4+48]");
			bool active = ((List<object>)0).Contains(p);
			p.checkMark.SetActive(active);
		}
	}

	private sealed class <>c__DisplayClass15_0
	{
		public GameAchievementViewModel titleModel;

		internal bool <Populate>b__0(TournamentTitleItem t)
		{
			//IL_00a3: Expected I4, but got O
			if ((object)t != null)
			{
				GameAchievementViewModel <TitleModel>k__BackingField = t.<TitleModel>k__BackingField;
				if (t.<TitleModel>k__BackingField != null)
				{
					GameAchievementViewModel gameAchievementViewModel = titleModel;
					if (titleModel != null)
					{
						return <TitleModel>k__BackingField.<id>k__BackingField != gameAchievementViewModel.<id>k__BackingField;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass18_0
	{
		public List<string> titles;

		internal void <OnConfirm>b__0(TournamentTitleItem item)
		{
			//IL_007a: Expected O, but got I4
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Expected O, but got Unknown
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Expected O, but got Unknown
			GameAchievementViewModel <TitleModel>k__BackingField = item.<TitleModel>k__BackingField;
			List<object> list = (List<object>)(object)titles;
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			bool flag = list._size < items.Length;
			object obj = !flag;
			if (obj == null)
			{
				int size = list._size + 1;
				list._size = size;
				object obj2 = items + list._size;
				object obj3 = obj2 + 32;
				obj3 = <TitleModel>k__BackingField.<id>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				list.AddWithResize((object)<TitleModel>k__BackingField.<id>k__BackingField);
			}
		}
	}

	private sealed class <>c__DisplayClass19_0
	{
		public TitleRestrictionTournamentAddon addon;

		public Func<TournamentTitleItem, bool> <>9__0;

		internal bool <ShowConfirmedSelection>b__0(TournamentTitleItem i)
		{
			//IL_00a8: Expected I4, but got O
			TitleRestrictionTournamentAddon titleRestrictionTournamentAddon = addon;
			if (addon != null)
			{
				if ((object)i != null)
				{
					GameAchievementViewModel <TitleModel>k__BackingField = i.<TitleModel>k__BackingField;
					if (i.<TitleModel>k__BackingField != null && titleRestrictionTournamentAddon.<TournamentTitles>k__BackingField != null)
					{
						return ((List<object>)(object)titleRestrictionTournamentAddon.<TournamentTitles>k__BackingField).Contains((object)<TitleModel>k__BackingField.<id>k__BackingField);
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	private new Action m_OnValidStateChange;

	private TournamentTitleItem itemPrefab;

	private Transform parent;

	private List<TournamentTitleItem> populatedItems;

	[NonSerialized]
	public List<TournamentTitleItem> selectedItems;

	public override string Title => "SERVICE_DISABLED" + 2544;

	public override string Subtitle => "Cannot populate JSON object onto type '{0}'." + 2704;

	public override TournamentAddonType addonType => TournamentAddonType.TitleRestriction;

	public override bool IsValid
	{
		get
		{
			bool flag = ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)selectedItems);
			return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
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

	public void Populate(List<GameAchievementViewModel> titles)
	{
		//IL_0012: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0046: Expected O, but got I
		//IL_0052: Expected O, but got I
		//IL_042a: Expected O, but got I
		//IL_03d8: Expected O, but got I4
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_0150: Expected I, but got O
		//IL_0158: Expected I, but got O
		//IL_0188: Expected O, but got I4
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_01d4: Expected O, but got I4
		//IL_01fd: Expected O, but got I
		//IL_0205: Expected I, but got O
		//IL_03b7: Expected O, but got I4
		//IL_0393: Expected O, but got I4
		//IL_0398: Expected I, but got O
		//IL_026f: Expected O, but got I
		//IL_02e6: Expected O, but got I4
		//IL_0074: Expected O, but got I
		//IL_0084: Expected O, but got I
		//IL_00ac: Expected O, but got I4
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_0354: Expected O, but got I4
		//IL_0359: Expected I, but got O
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		List<GameAchievementViewModel> list = default(List<GameAchievementViewModel>);
		if (list != null)
		{
			object obj = (nint)0 + (nint)1024;
			object obj2 = typeof(SkeletonBinary.SkeletonInput) + 3168;
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3984;
			object obj4 = (nint)0 + (nint)3384;
			object obj5 = (nint)0 + (nint)2008;
			List<object>.Enumerator enumerator = ((List<object>)(object)list).GetEnumerator();
			List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
			object obj6 = default(object);
			object obj8 = default(object);
			Func<object, bool> func = default(Func<object, bool>);
			TournamentTitleItem tournamentTitleItem = default(TournamentTitleItem);
			while (true)
			{
				if (enumerator2.MoveNext())
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					obj6..ctor();
					if (obj6 != null)
					{
						object obj7 = obj6 + 16;
						obj7 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						func..ctor(obj6, (IntPtr)obj4);
						nint num = (nint)obj5;
						bool flag = Enumerable.All(populatedItems, func);
						bool flag2 = !flag;
						object obj9 = 0;
						if (flag2)
						{
							continue;
						}
						object obj10 = typeof(MemberAchievementClanFeedData) + 2976;
						object obj11 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v32+E4]");
						bool flag3 = (nint)0 == 0;
						object obj12 = !flag3;
						if (obj12 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj13 = (nint)0 + (nint)848;
						num = (nint)obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
						if ((object)tournamentTitleItem != null)
						{
							tournamentTitleItem.PopulateInfo((GameAchievementViewModel)obj7, this);
							List<object> list2 = (List<object>)(object)populatedItems;
							if (populatedItems != null)
							{
								object obj14 = (nint)0 + (nint)1552;
								object obj15 = obj14;
								int version = list2._version + 1;
								list2._version = version;
								object[] items = list2._items;
								if (list2._items != null)
								{
									bool flag4 = list2._size < items.Length;
									object obj16 = !flag4;
									if (obj16 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v25+20]");
										object obj17 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v27+C0]");
										object obj18 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v28+70]");
										num = 0;
										((List<object>)(object)populatedItems).AddWithResize((object)tournamentTitleItem);
										obj9 = 0;
									}
									else
									{
										int size = list2._size + 1;
										list2._size = size;
										object obj19 = list2._items + list2._size;
										object obj20 = obj19 + 32;
										obj20 = tournamentTitleItem;
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
							list = (List<GameAchievementViewModel>)obj7;
						}
						else
						{
							NullReferenceException ex2 = new NullReferenceException();
							obj9 = 0;
							list = (List<GameAchievementViewModel>)(object)parent;
						}
						break;
					}
					NullReferenceException ex3 = new NullReferenceException();
					list = null;
					break;
				}
				enumerator2.Dispose();
				return;
			}
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			enumerator3 = enumerator4;
			enumerator4 = (List<object>.Enumerator)0;
		}
		NullReferenceException ex4 = new NullReferenceException();
		bool flag5 = (nint)list != 1;
		OutOfMemoryException ex5 = (OutOfMemoryException)(object)ex4;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj21 = (nint)0 + (nint)1016;
			list = (List<GameAchievementViewModel>)obj21;
			enumerator3.Dispose();
			object obj22 = default(object);
			if (obj22 == null)
			{
				return;
			}
			ex5 = new OutOfMemoryException();
			List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj22;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22392BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public override void Clear()
	{
		//IL_0084: Expected I, but got O
		//IL_0094: Expected O, but got I
		//IL_00a4: Expected O, but got I
		//IL_007a: Expected O, but got I4
		while (true)
		{
			List<TournamentTitleItem> list = selectedItems;
			int version = list._version + 1;
			list._size = 0;
			list._version = version;
			if (list._size >= 1)
			{
				Array.Clear(list._items, 0, list._size);
				object obj = 0;
			}
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v4 (Il2CppClass<TitleAddonSelector>)+1E8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v4 (Il2CppClass<TitleAddonSelector>)+1F0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v62 @ X2_v2 (should have been resolved before IL gen)");
		}
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
		object obj2 = typeof(SkeletonBinary.SkeletonInput) + 3160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6C88]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_015b;
		}
		List<TournamentTitleItem> list = populatedItems;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = obj4;
		List<TournamentTitleItem> list2 = populatedItems;
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
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)3376;
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
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_005c: Expected O, but got I
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_009c: Expected I, but got O
		//IL_00ad: Expected O, but got I
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3176;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 3624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3832;
		object obj5 = (nint)0 + (nint)3392;
		object obj6 = obj3 + 16;
		obj6 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj3, (IntPtr)obj5);
		object obj7 = (nint)0 + (nint)1576;
		object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1200;
		((List<object>)(object)selectedItems).ForEach(action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TitleRestrictionTournamentAddon titleRestrictionTournamentAddon = default(TitleRestrictionTournamentAddon);
		titleRestrictionTournamentAddon..ctor((List<string>)obj6);
		eventsChannel.TriggerAddAddon(titleRestrictionTournamentAddon);
	}

	public unsafe override void ShowConfirmedSelection(TournamentAddonModel tournamentAddonModel)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0d73: Expected O, but got I4
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0267: Expected O, but got I4
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da5: Expected O, but got Unknown
		//IL_0db2: Expected O, but got I
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_00b3: Expected O, but got I4
		//IL_00bc: Expected I4, but got O
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected O, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected O, but got Unknown
		//IL_02b9: Expected O, but got I4
		//IL_0339: Expected I, but got O
		//IL_034e: Expected O, but got I
		//IL_036a: Expected O, but got I4
		//IL_00e7: Expected O, but got I
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected O, but got Unknown
		//IL_039c: Expected I, but got O
		//IL_03ac: Expected O, but got I
		//IL_0324: Expected O, but got I4
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_013c: Expected I, but got O
		//IL_0175: Expected O, but got I4
		//IL_017e: Expected I4, but got O
		//IL_0462: Expected O, but got I
		//IL_0486: Expected O, but got I4
		//IL_049f: Expected O, but got I4
		//IL_04a4: Expected I, but got O
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected O, but got Unknown
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected O, but got Unknown
		//IL_05e2: Expected O, but got I
		//IL_01b9: Expected O, but got I
		//IL_04d3: Expected O, but got I4
		//IL_04d8: Expected I, but got O
		//IL_0de4: Expected O, but got I
		//IL_0741: Expected I, but got O
		//IL_0bdd: Expected I, but got O
		//IL_04ff: Expected O, but got I
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected O, but got Unknown
		//IL_0525: Expected O, but got I
		//IL_0557: Expected O, but got I4
		//IL_0577: Expected O, but got I
		//IL_0590: Expected O, but got I4
		//IL_0e44: Expected I4, but got O
		//IL_0e54: Expected O, but got I
		//IL_0e67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6c: Expected O, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		//IL_09cf: Expected O, but got I4
		//IL_09d8: Expected O, but got I4
		//IL_0a19: Expected O, but got I4
		//IL_0a22: Expected O, but got I4
		//IL_0e18: Expected O, but got I
		//IL_0f0e: Expected O, but got I4
		//IL_0760: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Expected O, but got Unknown
		//IL_076e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Expected O, but got Unknown
		//IL_0a3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a44: Expected O, but got Unknown
		//IL_0af7: Expected I, but got O
		//IL_07bd: Expected O, but got I
		//IL_0fa0: Expected O, but got I
		//IL_0868: Expected I, but got O
		//IL_0b75: Expected O, but got I4
		//IL_0f6c: Expected O, but got I
		//IL_0ec5: Expected I4, but got O
		//IL_0c9f: Expected O, but got I4
		//IL_0cb8: Expected O, but got I4
		//IL_0b16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1b: Expected O, but got Unknown
		//IL_0b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b29: Expected O, but got Unknown
		//IL_0bbf: Expected I, but got O
		//IL_0e99: Expected O, but got I
		//IL_08b7: Expected I4, but got O
		//IL_087a: Expected O, but got I4
		//IL_0887: Unknown result type (might be due to invalid IL or missing references)
		//IL_088c: Expected O, but got Unknown
		//IL_0895: Unknown result type (might be due to invalid IL or missing references)
		//IL_089a: Expected O, but got Unknown
		//IL_0d17: Expected O, but got I4
		//IL_0829: Expected O, but got I
		//IL_091d: Expected O, but got I4
		//IL_093d: Expected O, but got I4
		//IL_05ff: Expected O, but got I
		//IL_097d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0982: Expected O, but got Unknown
		//IL_098b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0990: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6C8A]");
		int num = 0;
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		object obj3 = 0;
		Func<object, bool> func = null;
		if (flag)
		{
			goto IL_0d86;
		}
		bool flag6 = default(bool);
		object obj8;
		int num9 = default(int);
		nint num10;
		if (tournamentAddonModel != null)
		{
			object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1200;
			object obj5 = obj4;
			nint num2 = (nint)tournamentAddonModel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X9_v43 (Il2CppClass<TournamentAddonModel>)+130]");
			int num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X1_v31+130]");
			int num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X9_v43 (Il2CppClass<TournamentAddonModel>)+130]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X1_v31+130]");
			bool flag2 = num5 < 0;
			object obj6 = !flag2;
			bool flag3 = (byte)(int)(~obj6) != 0;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X9_v43 (Il2CppClass<TournamentAddonModel>)+C8]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X1_v31+130]");
				object obj7 = num6 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X9_v45-8]");
				num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X9_v45-8]");
				flag3 = 0 != (nint)obj5;
				if (!flag3)
				{
					obj8 = obj2 + 16;
					obj8 = tournamentAddonModel;
					num2 = (nint)tournamentAddonModel;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X9_v43 (Il2CppClass<TournamentAddonModel>)+130]");
					num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X9_v43 (Il2CppClass<TournamentAddonModel>)+130]");
					nint num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X1_v31+130]");
					bool flag4 = num7 < 0;
					object obj9 = !flag4;
					flag3 = (byte)(int)(~obj9) != 0;
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X9_v43 (Il2CppClass<TournamentAddonModel>)+C8]");
						num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X9_v43 (Il2CppClass<TournamentAddonModel>)+C8]");
						nint num8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X1_v31+130]");
						object obj10 = num8 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v52-8]");
						num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v52-8]");
						bool flag5 = 0 == (nint)obj5;
						flag6 = flag3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X9_v43 (Il2CppClass<TournamentAddonModel>)+130]");
						num9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X9_v43 (Il2CppClass<TournamentAddonModel>)+C8]");
						num10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v52-8]");
						num = 0;
						if (flag5)
						{
							goto IL_0d91;
						}
					}
				}
			}
			flag6 = flag3;
			num9 = num3;
			num10 = num2;
			num = num4;
			throw new InvalidCastException();
		}
		obj8 = obj2 + 16;
		obj8 = 0;
		goto IL_0d91;
		IL_0a30:
		object obj11 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		object obj13;
		object obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v11+12E]");
		num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v11+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0ae8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v11+B0]");
		int num11 = (int)((nint)0 + (nint)8);
		object obj14 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X10_v9 (System.Int32)-8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X10_v9 (System.Int32)-8]");
			if (0 == (nint)obj11)
			{
				break;
			}
			num9 = num11 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v11+12E]");
			num10 = -1;
			bool flag7 = num10 != 1;
			num11 = num9;
			if (flag7)
			{
				continue;
			}
			goto IL_0ae8;
		}
		num10 = ((int*)num11)->m_value;
		object obj15 = obj12 + ((int*)num11)->m_value;
		object obj16 = obj15 + 312;
		nint num13;
		nint num12 = num13;
		num9 = num11;
		goto IL_0f90;
		IL_0440:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj17 = default(object);
		object[] array = (object[])obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X0_v60+8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v601 @ X0_v60] (should have been resolved before IL gen)");
		object obj19 = default(object);
		bool flag8 = obj19 == null;
		object obj20 = !flag8;
		obj3 = obj19;
		int num14 = (int)(&obj3);
		object obj21 = 0;
		num13 = unchecked((nint)null);
		if (obj20 != null)
		{
			goto IL_05ae;
		}
		object obj22 = obj14;
		obj3 = obj19;
		int num15 = (int)(&obj3);
		obj21 = 0;
		nint num16 = unchecked((nint)null);
		int num17 = num9;
		num = (int)(&obj3);
		goto IL_0bcc;
		IL_0ef4:
		object obj23;
		object obj25;
		object obj26;
		object obj27;
		object obj28 = default(object);
		object obj29;
		Func<object, bool> func3;
		object obj31;
		int num18;
		object obj32;
		object obj34;
		object obj35 = default(object);
		object obj37;
		object obj30;
		Func<object, bool> func2;
		while (true)
		{
			bool flag9 = obj23 == null;
			object obj24 = !flag9;
			obj25 = obj26;
			obj14 = obj27;
			num15 = num14;
			obj28 = obj29;
			num13 = num12;
			func2 = func3;
			obj30 = obj31;
			num9 = num18;
			if (obj24 == null)
			{
				if ((nint)obj32 != 5)
				{
					bool flag10 = obj32 == null;
					object obj33 = !flag10;
					if (obj33 != null)
					{
						return;
					}
				}
				Refresh();
				return;
			}
			OutOfMemoryException ex = new OutOfMemoryException();
			if ((nint)func == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj34 = obj35;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				bool flag11 = obj3 == null;
				object obj36 = !flag11;
				obj21 = obj35;
				obj13 = obj3;
				obj37 = 0;
				if (obj36 != null)
				{
					break;
				}
				obj26 = obj25;
				obj27 = obj14;
				num14 = num15;
				obj21 = obj35;
				obj29 = obj28;
				num12 = num13;
				func3 = func2;
				obj31 = obj30;
				num18 = num9;
				obj32 = 0;
				obj23 = obj35;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
		}
		goto IL_0a30;
		IL_0ae8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num12 = unchecked((nint)null);
		goto IL_0f90;
		IL_0d86:
		throw new NullReferenceException();
		IL_0c18:
		obj14 = obj22;
		num13 = num16;
		num9 = num17;
		goto IL_0d86;
		IL_0d91:
		object obj38 = typeof(List<AdaptivePerformanceScaler>) + 4040;
		obj25 = (nint)0 + (nint)3816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj39 = this + 72;
		obj39 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj30 = obj2 + 24;
		func2 = (Func<object, bool>)obj30;
		bool flag12 = obj30 == null;
		object obj40 = !flag12;
		if (obj40 == null)
		{
			object obj41 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3984;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			num = (int)((nint)0 + (nint)3400);
			Func<object, bool> func4 = default(Func<object, bool>);
			func4..ctor(obj2, (IntPtr)((int*)num)->m_value);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj28 = 0;
			func2 = func4;
		}
		num13 = (nint)obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X20_v9-8]");
		IEnumerable<object> enumerable = Enumerable.Where((IEnumerable<object>)0, func2);
		bool flag13 = enumerable == null;
		obj3 = 0;
		func = func2;
		if (!flag13)
		{
			object obj42 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3800;
			nint num19 = (nint)enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v19 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
			object obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v19 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0440;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v19 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
			num17 = (int)((nint)0 + (nint)8);
			bool flag14 = flag6;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X10_v12 (System.Int32)-8]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X10_v12 (System.Int32)-8]");
				if (0 == (nint)obj42)
				{
					break;
				}
				num9 = num17 + 16;
				obj43--;
				flag6 = (nint)obj43 != 1;
				flag14 = flag6;
				num17 = num9;
				if (flag6)
				{
					continue;
				}
				goto IL_0440;
			}
			object obj44 = num19 + ((int*)num17)->m_value;
			object obj45 = obj44 + 312;
			array = (object[])obj45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X8_v41+8]");
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v652 @ X8_v41] (should have been resolved before IL gen)");
			bool flag15 = obj19 == null;
			obj3 = obj19;
			num14 = (int)(&obj3);
			obj21 = 0;
			flag6 = flag14;
			num9 = num17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X10_v12 (System.Int32)-8]");
			obj22 = 0;
			obj3 = obj19;
			num15 = (int)(&obj3);
			obj21 = 0;
			num16 = num13;
			num = (int)(&obj3);
			if (!flag15)
			{
				goto IL_05ae;
			}
			goto IL_0bcc;
		}
		goto IL_0d86;
		IL_0b8e:
		NullReferenceException ex2 = new NullReferenceException();
		obj22 = obj14;
		num15 = num14;
		num16 = num13;
		num17 = num9;
		num10 = (nint)array;
		object obj46 = default(object);
		func = (Func<object, bool>)obj46;
		goto IL_0c18;
		IL_0bcc:
		NullReferenceException ex3 = new NullReferenceException();
		num10 = (nint)array;
		func = (Func<object, bool>)obj18;
		goto IL_0c18;
		IL_05ae:
		object obj47 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		func2 = (Func<object, bool>)(typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1256);
		obj30 = (nint)0 + (nint)1552;
		object obj48 = obj19;
		object obj51 = default(object);
		object obj53 = default(object);
		object obj56 = default(object);
		while (true)
		{
			object obj49 = obj48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v24+12E]");
			num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v24+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0732;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v24+B0]");
			int num20 = (int)((nint)0 + (nint)8);
			bool flag16 = flag6;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v806 @ X10_v27 (System.Int32)-8]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v806 @ X10_v27 (System.Int32)-8]");
				if (0 == (nint)obj47)
				{
					break;
				}
				num9 = num20 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v24+12E]");
				num10 = -1;
				flag6 = num10 != 1;
				flag16 = flag6;
				num20 = num9;
				if (flag6)
				{
					continue;
				}
				goto IL_0732;
			}
			num10 = ((int*)num20)->m_value;
			object obj50 = obj49 + ((int*)num20)->m_value;
			obj51 = obj50 + 312;
			flag6 = flag16;
			num9 = num20;
			goto IL_0e3c;
			IL_0e3c:
			num = (int)obj51;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X0_v41+8]");
			func = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v821 @ X0_v41] (should have been resolved before IL gen)");
			object obj52 = obj53 & 1;
			if (obj52 == null)
			{
				break;
			}
			if (obj3 == null)
			{
				goto IL_0bea;
			}
			object obj54 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X8_v27+12E]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X8_v27+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0859;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X8_v27+B0]");
			int num21 = (int)((nint)0 + (nint)8);
			bool flag17 = flag6;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X10_v22 (System.Int32)-8]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X10_v22 (System.Int32)-8]");
				if (0 == (nint)func2)
				{
					break;
				}
				num9 = num21 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X8_v27+12E]");
				array = (object[])(-1);
				flag6 = (nint)array != 1;
				flag17 = flag6;
				num21 = num9;
				if (flag6)
				{
					continue;
				}
				goto IL_0859;
			}
			array = (object[])((int*)num21)->m_value;
			object obj55 = obj54 + ((int*)num21)->m_value;
			obj56 = obj55 + 312;
			flag6 = flag17;
			num9 = num21;
			goto IL_0ebd;
			IL_0ebd:
			num = (int)obj56;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v885 @ X0_v45] (should have been resolved before IL gen)");
			List<object> list2 = (List<object>)obj39;
			if (obj39 != null)
			{
				num = (int)obj30;
				int version = list2._version + 1;
				list2._version = version;
				array = list2._items;
				if (list2._items != null)
				{
					num9 = list2._size;
					obj14 = array.Length;
					bool flag18 = list2._size < array.Length;
					object obj57 = !flag18;
					if (obj57 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v3 (System.Int32)+20]");
						object obj58 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X8_v34+C0]");
						num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v3 (System.Int32)+70]");
						num13 = 0;
						((List<object>)obj39).AddWithResize(obj46);
					}
					else
					{
						num = list2._size + 1;
						list2._size = num;
						object obj59 = list2._items + list2._size;
						object obj60 = obj59 + 32;
						obj60 = obj46;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					}
					bool flag19 = obj3 == null;
					obj48 = obj3;
					obj22 = obj14;
					num15 = num14;
					num16 = num13;
					num17 = num9;
					obj18 = obj46;
					if (!flag19)
					{
						continue;
					}
					goto IL_0bcc;
				}
			}
			goto IL_0b8e;
			IL_0859:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num13 = unchecked((nint)null);
			goto IL_0ebd;
			IL_0732:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num13 = unchecked((nint)null);
			goto IL_0e3c;
		}
		bool flag20 = obj3 == null;
		num15 = num14;
		obj13 = obj3;
		obj37 = 5;
		obj34 = 0;
		obj26 = obj25;
		obj27 = obj14;
		obj29 = obj28;
		num12 = num13;
		func3 = func2;
		obj31 = obj30;
		num18 = num9;
		obj32 = 5;
		obj23 = 0;
		if (!flag20)
		{
			goto IL_0a30;
		}
		goto IL_0ef4;
		IL_0bea:
		NullReferenceException ex4 = new NullReferenceException();
		obj22 = obj14;
		num15 = num14;
		num16 = num13;
		num17 = num9;
		goto IL_0c18;
		IL_0f90:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X0_v21+8]");
		func = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v614 @ X0_v21] (should have been resolved before IL gen)");
		obj26 = obj25;
		obj27 = obj14;
		num14 = num15;
		obj29 = obj28;
		func3 = func2;
		obj31 = obj30;
		num18 = num9;
		obj32 = obj37;
		obj23 = obj34;
		goto IL_0ef4;
	}

	public void SelectItem(TournamentTitleItem itemToSelect)
	{
		//IL_0011: Expected O, but got I
		//IL_003e: Expected O, but got I4
		//IL_01a3: Expected O, but got I4
		//IL_00af: Expected O, but got I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		object obj = (nint)0 + (nint)1568;
		bool flag = ((List<object>)(object)selectedItems).Contains((object)itemToSelect);
		bool flag2 = !flag;
		object obj2 = !flag2;
		List<object> list = default(List<object>);
		if (obj2 == null)
		{
			list = (List<object>)(object)selectedItems;
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			bool flag3 = list._size < items.Length;
			object obj3 = !flag3;
			if (obj3 != null)
			{
				goto IL_016e;
			}
			int size = list._size + 1;
			list._size = size;
			object obj4 = items + list._size;
			object obj5 = obj4 + 32;
			obj5 = itemToSelect;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		Action onValidStateChange = OnValidStateChange;
		if (OnValidStateChange != null)
		{
			goto IL_013d;
		}
		return;
		IL_013d:
		IntPtr invoke_impl = ((Delegate)onValidStateChange).invoke_impl;
		IntPtr method_code = ((Delegate)onValidStateChange).method_code;
		IntPtr method = ((Delegate)onValidStateChange).method;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v152 @ X2_v5 (System.IntPtr) (should have been resolved before IL gen)");
		goto IL_016e;
		IL_016e:
		list.AddWithResize((object)itemToSelect);
		onValidStateChange = OnValidStateChange;
		bool flag4 = OnValidStateChange == null;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			return;
		}
		goto IL_013d;
	}

	public void DeselectItem(TournamentTitleItem itemToDeselect)
	{
		if (((List<object>)(object)selectedItems).Contains((object)itemToDeselect))
		{
			bool flag = ((List<object>)(object)selectedItems).Remove((object)itemToDeselect);
		}
		Action onValidStateChange = OnValidStateChange;
		if (OnValidStateChange != null)
		{
			IntPtr invoke_impl = ((Delegate)onValidStateChange).invoke_impl;
			IntPtr method_code = ((Delegate)onValidStateChange).method_code;
			IntPtr method = ((Delegate)onValidStateChange).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v82 @ X2_v4 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public TitleAddonSelector()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 64;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj3 = this + 72;
		obj3 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((MonoBehaviour)this)..ctor();
	}
}
