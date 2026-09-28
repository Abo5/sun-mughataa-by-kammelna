using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Spine;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.UI;

public class SportTeamAddonSelector : TournamentAddonSelector
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<TournamentSportCelebrationItem> <>9__25_0;

		public static Action<Transform> <>9__28_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 856;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Refresh>b__25_0(TournamentSportCelebrationItem p)
		{
			p.Refresh();
		}

		internal void <OnTabToggle>b__28_0(Transform e)
		{
			GameObject gameObject = e.gameObject;
			gameObject.SetActive(value: false);
		}
	}

	private sealed class <>c__DisplayClass22_0
	{
		public SportTeam sportTeam;

		internal bool <Populate>b__0(TournamentSportCelebrationItem st)
		{
			//IL_008a: Expected I4, but got O
			//IL_005d: Expected O, but got I4
			if ((object)st != null)
			{
				SportTeam sportTeam = this.sportTeam;
				if (this.sportTeam != null)
				{
					object obj = st.<sportTeamId>k__BackingField - sportTeam.<id>k__BackingField;
					bool flag = obj == null;
					return !flag;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass29_0
	{
		public SportTeamsCelebrationTournamentAddon addon;

		internal bool <ShowConfirmedSelection>b__0(TournamentSportCelebrationItem sportCelebrationItem)
		{
			//IL_005f: Expected I4, but got O
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected O, but got Unknown
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected I4, but got Unknown
			if ((object)sportCelebrationItem != null)
			{
				int? num = (int?)addon;
				if (addon != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v4 (System.Nullable`1<System.Int32>)+14]");
					int? num2 = 0;
					num = num2;
				}
				object obj = (object?)num >> 32;
				object obj2 = sportCelebrationItem.<sportTeamId>k__BackingField - obj;
				bool flag = obj2 == null;
				return (byte)((flag & (??)num) ? 1 : 0) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass30_0
	{
		public SportTeamAddonSelector <>4__this;

		public Transform p;

		internal void <CreateGrouping>b__0(bool c)
		{
			<>4__this.OnTabToggle(p, c);
		}
	}

	private new Action m_OnValidStateChange;

	private TournamentSportCelebrationItem itemPrefab;

	private Transform parent;

	private Toggle toggle;

	private Transform togglesParent;

	private Dictionary<string, Transform> groupings;

	private List<Toggle> toggles;

	private List<TournamentSportCelebrationItem> populatedItems;

	private TournamentSportCelebrationItem <selectedItem>k__BackingField;

	public override string Title => "Cannot populate JSON object onto type '{0}'." + 1928;

	public override string Subtitle => "Cannot populate JSON object onto type '{0}'." + 2688;

	public override TournamentAddonType addonType => TournamentAddonType.SportCelebration;

	public override bool IsValid
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0102: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_0255: Expected I4, but got O
			object obj = 152985600;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6C75]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj5;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v12+E4]");
				bool flag = (nint)0 == 0;
				obj5 = <selectedItem>k__BackingField;
				obj6 = <selectedItem>k__BackingField;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				obj5 = <selectedItem>k__BackingField;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v12+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj6 = <selectedItem>k__BackingField;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj6 != null;
			if (!flag3)
			{
				goto IL_00c3;
			}
			goto IL_0150;
			IL_00c3:
			return flag3;
			IL_0150:
			TournamentSportCelebrationItem tournamentSportCelebrationItem = <selectedItem>k__BackingField;
			if ((object)<selectedItem>k__BackingField != null)
			{
				int? cardbackId = tournamentSportCelebrationItem.cardBackId;
				string groupName = GetGroupName(cardbackId);
				if (groupings != null)
				{
					flag3 = ((Dictionary<object, object>)(object)groupings).TryGetValue((object)groupName, out object value);
					if (!flag3)
					{
						goto IL_00c3;
					}
					if (value != null)
					{
						GameObject gameObject = ((Component)value).gameObject;
						if ((object)gameObject != null)
						{
							return gameObject.activeSelf;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0091:
			flag3 = obj5 != null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				goto IL_00c3;
			}
			goto IL_0150;
		}
	}

	public TournamentSportCelebrationItem selectedItem
	{
		get
		{
			return <selectedItem>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 104;
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

	public void Populate(List<SportTeam> sportTeams)
	{
		//IL_0707: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0046: Expected O, but got I
		//IL_0052: Expected O, but got I
		//IL_0484: Expected O, but got I
		//IL_04af: Expected O, but got I4
		//IL_067e: Expected O, but got I
		//IL_062c: Expected O, but got I4
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_015b: Expected I, but got O
		//IL_0163: Expected I, but got O
		//IL_0193: Expected O, but got I4
		//IL_05c6: Expected O, but got I4
		//IL_01d7: Expected O, but got I
		//IL_05e5: Expected O, but got I4
		//IL_0206: Expected O, but got I
		//IL_020e: Expected I, but got O
		//IL_023b: Expected O, but got I4
		//IL_05af: Expected O, but got I4
		//IL_029d: Expected O, but got I
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02ee: Expected O, but got I4
		//IL_0317: Expected O, but got I
		//IL_031f: Expected I, but got O
		//IL_0604: Expected O, but got I4
		//IL_058b: Expected O, but got I4
		//IL_0590: Expected I, but got O
		//IL_0389: Expected O, but got I
		//IL_0400: Expected O, but got I4
		//IL_0075: Expected O, but got I
		//IL_0085: Expected O, but got I
		//IL_00ad: Expected O, but got I4
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected O, but got Unknown
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_046e: Expected O, but got I4
		//IL_0473: Expected I, but got O
		List<SportTeam> list = default(List<SportTeam>);
		bool flag = list == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		if (!flag)
		{
			object obj = (nint)0 + (nint)1512;
			object obj2 = typeof(SkeletonBinary.SkeletonInput) + 864;
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3976;
			object obj4 = (nint)0 + (nint)752;
			object obj5 = (nint)0 + (nint)2000;
			List<object>.Enumerator enumerator2 = ((List<object>)(object)list).GetEnumerator();
			List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
			object obj6 = default(object);
			object obj8 = default(object);
			Func<object, bool> func = default(Func<object, bool>);
			object obj19 = default(object);
			List<object>.Enumerator enumerator5;
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			while (enumerator3.MoveNext())
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj6..ctor();
				if (obj6 != null)
				{
					object obj7 = obj6 + 16;
					obj7 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					IEnumerable<object> enumerable = populatedItems;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					func..ctor(obj6, (IntPtr)obj4);
					nint num = (nint)obj5;
					bool flag2 = Enumerable.All(populatedItems, func);
					bool flag3 = !flag2;
					object obj9 = 0;
					if (flag3)
					{
						continue;
					}
					object obj10 = obj7;
					if (obj7 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v19+20]");
						string groupName = GetGroupName((int?)(object)0);
						if (groupings != null)
						{
							object obj11 = (nint)0 + (nint)976;
							num = (nint)obj11;
							bool flag4 = ((Dictionary<object, object>)(object)groupings).ContainsKey((object)groupName);
							bool flag5 = !flag4;
							object obj12 = !flag5;
							list = (List<SportTeam>)(object)groupName;
							if (obj12 == null)
							{
								CreateGrouping(groupName);
								list = (List<SportTeam>)(object)groupName;
							}
							if (groupings != null)
							{
								enumerable = (IEnumerable<object>)itemPrefab;
								object obj13 = (nint)0 + (nint)1000;
								object obj14 = ((Dictionary<object, object>)(object)groupings).get_Item((object)groupName);
								object obj15 = typeof(MemberAchievementClanFeedData) + 2976;
								object obj16 = obj15;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v45+E4]");
								bool flag6 = (nint)0 == 0;
								object obj17 = !flag6;
								if (obj17 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								object obj18 = (nint)0 + (nint)840;
								num = (nint)obj18;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
								if (obj19 != null)
								{
									((TournamentSportCelebrationItem)obj19).PopulateInfo((SportTeam)obj7, this);
									List<object> list2 = (List<object>)(object)populatedItems;
									if (populatedItems != null)
									{
										object obj20 = (nint)0 + (nint)1528;
										object obj21 = obj20;
										int version = list2._version + 1;
										list2._version = version;
										object[] items = list2._items;
										if (list2._items != null)
										{
											bool flag7 = list2._size < items.Length;
											object obj22 = !flag7;
											if (obj22 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v32+20]");
												object obj23 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v34+C0]");
												object obj24 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v35+70]");
												num = 0;
												((List<object>)(object)populatedItems).AddWithResize(obj19);
												obj9 = 0;
											}
											else
											{
												int size = list2._size + 1;
												list2._size = size;
												object obj25 = list2._items + list2._size;
												object obj26 = obj25 + 32;
												obj26 = obj19;
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
									list = (List<SportTeam>)obj7;
								}
								else
								{
									NullReferenceException ex2 = new NullReferenceException();
									obj9 = 0;
									list = (List<SportTeam>)obj14;
								}
							}
							else
							{
								NullReferenceException ex3 = new NullReferenceException();
								obj9 = 0;
							}
						}
						else
						{
							NullReferenceException ex4 = new NullReferenceException();
							obj9 = 0;
							list = (List<SportTeam>)(object)func;
						}
					}
					else
					{
						NullReferenceException ex5 = new NullReferenceException();
						obj9 = 0;
						list = (List<SportTeam>)(object)func;
					}
				}
				else
				{
					NullReferenceException ex6 = new NullReferenceException();
					list = null;
				}
				enumerator = enumerator4;
				enumerator5 = enumerator4;
				enumerator4 = (List<object>.Enumerator)0;
				goto IL_0716;
			}
			object obj27 = (nint)0 + (nint)1504;
			list = (List<SportTeam>)obj27;
			enumerator3.Dispose();
			enumerator = enumerator4;
			enumerator5 = enumerator4;
			enumerator4 = (List<object>.Enumerator)0;
			goto IL_04b4;
		}
		goto IL_0716;
		IL_04b4:
		List<Toggle> list3 = toggles;
		if (toggles != null)
		{
			if (list3._size >= 2)
			{
				return;
			}
			if ((object)togglesParent != null)
			{
				GameObject gameObject = togglesParent.gameObject;
				bool flag8 = (object)gameObject == null;
				list = null;
				if (!flag8)
				{
					gameObject.SetActive(value: false);
					return;
				}
			}
		}
		goto IL_0716;
		IL_0716:
		NullReferenceException ex7 = new NullReferenceException();
		bool flag9 = (nint)list != 1;
		OutOfMemoryException ex8 = (OutOfMemoryException)(object)ex7;
		if (!flag9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj28 = (nint)0 + (nint)1504;
			list = (List<SportTeam>)obj28;
			enumerator.Dispose();
			object obj29 = default(object);
			bool flag10 = obj29 == null;
			List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj29;
			if (flag10)
			{
				goto IL_04b4;
			}
			ex8 = new OutOfMemoryException();
			enumerator4 = (List<object>.Enumerator)obj29;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223927C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private static string GetGroupName(int? cardbackId)
	{
		//IL_00dc: Expected O, but got I
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_005c: Expected O, but got I4
		object result = (nint)0 + (nint)2000;
		object obj = (??)cardbackId & 1;
		if (obj != null)
		{
			object obj2 = (nint)0 + (nint)3176;
			object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			int? num = default(int?);
			int value = num.Value;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			StoreItem storeItem = Store.GetStoreItem(value);
			if (storeItem != null)
			{
				if (storeItem.<group>k__BackingField == null)
				{
					return (string)result;
				}
				return storeItem.<group>k__BackingField;
			}
			return (string)(object)new NullReferenceException();
		}
		return (string)result;
	}

	public override void Clear()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		//IL_0023: Expected I, but got O
		//IL_0033: Expected O, but got I
		//IL_0043: Expected O, but got I
		object obj = this + 104;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v1 (Il2CppClass<SportTeamAddonSelector>)+1E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v1 (Il2CppClass<SportTeamAddonSelector>)+1F0]");
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
		object obj2 = typeof(SkeletonBinary.SkeletonInput) + 856;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6C7A]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_015b;
		}
		List<TournamentSportCelebrationItem> list = populatedItems;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = obj4;
		List<TournamentSportCelebrationItem> list2 = populatedItems;
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
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)744;
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
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_00b9: Expected O, but got I4
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1168;
		int num = default(int);
		string s = num.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1176;
		object obj3 = default(object);
		obj3..ctor();
		int teamId = int.Parse(s);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SportTeam sportTeamById = SportTeamsUtil.GetSportTeamById(teamId);
		object obj6 = obj3 + 24;
		obj6 = sportTeamById;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		eventsChannel.TriggerAddAddon((TournamentAddonModel)obj3);
	}

	public void SelectItem(TournamentSportCelebrationItem itemToSelect)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0022: Expected I, but got O
		//IL_0032: Expected O, but got I
		//IL_0042: Expected O, but got I
		object obj = this + 104;
		obj = itemToSelect;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v1 (Il2CppClass<SportTeamAddonSelector>)+1E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v1 (Il2CppClass<SportTeamAddonSelector>)+1F0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v30 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void OnTabToggle(Transform tab, bool isOn)
	{
		//IL_0011: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00d8: Expected O, but got I
		//IL_00e8: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_0071: Expected O, but got I
		//IL_0081: Expected O, but got I
		//IL_00a3: Expected O, but got I4
		//IL_013a: Expected O, but got I4
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_0240: Expected O, but got I
		//IL_0251: Expected I, but got O
		//IL_026f: Expected O, but got I
		//IL_0286: Expected I, but got O
		//IL_016a: Expected O, but got I
		if (!isOn)
		{
			return;
		}
		object obj = (nint)0 + (nint)1008;
		Dictionary<object, object>.ValueCollection values = ((Dictionary<object, object>)(object)groupings).Values;
		object obj2 = typeof(SkeletonBinary.SkeletonInput) + 856;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v13+E4]");
		object obj4;
		Action<object> action;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v13+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v13+10]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v13+10]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				goto IL_0118;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v13+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v13+10]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v13+10]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				goto IL_0118;
			}
		}
		goto IL_016f;
		IL_0118:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v13+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v19+B8]");
			obj4 = 0;
		}
		object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = (nint)0 + (nint)736;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj4, (IntPtr)obj10);
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v18+B8]");
		object obj12 = (nint)0 + (nint)16;
		obj12 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num = unchecked((nint)null);
		action = action2;
		goto IL_016f;
		IL_016f:
		ArraysExtensions.ForEach(values, action);
		GameObject gameObject = tab.gameObject;
		gameObject.SetActive(value: true);
		Action onValidStateChange = OnValidStateChange;
		if (OnValidStateChange != null)
		{
			IntPtr invoke_impl = ((Delegate)onValidStateChange).invoke_impl;
			IntPtr method_code = ((Delegate)onValidStateChange).method_code;
			IntPtr method = ((Delegate)onValidStateChange).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v118 @ X2_v6 (System.IntPtr) (should have been resolved before IL gen)");
		}
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
		object obj = typeof(SkeletonBinary.SkeletonInput) + 872;
		object obj2 = default(object);
		Func<object, bool> func = default(Func<object, bool>);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj2..ctor();
			if (tournamentAddonModel != null)
			{
				object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1168;
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
			object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3976;
			object obj13 = (nint)0 + (nint)760;
			object obj14 = (nint)0 + (nint)1352;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			func..ctor(obj2, (IntPtr)obj13);
			object obj15 = Enumerable.FirstOrDefault(populatedItems, func);
			object obj16 = this + 104;
			obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			nint num7 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v4 (Il2CppClass<SportTeamAddonSelector>)+1E8]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v4 (Il2CppClass<SportTeamAddonSelector>)+1F0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v192 @ X2_v3 (should have been resolved before IL gen)");
		}
		throw new InvalidCastException();
	}

	private void CreateGrouping(string group)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_005b: Expected O, but got I
		//IL_0094: Expected O, but got I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_0111: Expected O, but got I
		//IL_0170: Expected O, but got I
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01ac: Expected O, but got I
		//IL_01d1: Expected O, but got I
		//IL_01dd: Expected O, but got I
		//IL_02a8: Expected O, but got I4
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected O, but got Unknown
		object obj = typeof(SkeletonBinary.SkeletonInput) + 880;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj5 = (nint)0 + (nint)856;
		Transform transform = parent.parent;
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		object obj8 = obj2 + 24;
		object obj9 = default(object);
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject gameObject = ((Component)obj8).gameObject;
		gameObject.SetActive(value: true);
		object obj10 = (nint)0 + (nint)960;
		((Dictionary<object, object>)(object)groupings).Add((object)group, obj8);
		GameObject gameObject2 = parent.gameObject;
		gameObject2.SetActive(value: false);
		Transform transform2 = toggle.transform;
		object obj11 = (nint)0 + (nint)776;
		Transform transform3 = transform2.parent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		object obj12 = typeof(TypeConverter<ushort, char>) + 360;
		object obj13 = (nint)0 + (nint)768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4027FE0");
		object obj14 = (nint)0 + (nint)832;
		object obj15 = (nint)0 + (nint)288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4029444");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
		TextMeshProUGUI textMeshProUGUI = default(TextMeshProUGUI);
		if ((object)textMeshProUGUI != null)
		{
			TextMeshProExtensions.FixArabic(textMeshProUGUI, group);
		}
		Component component = default(Component);
		GameObject gameObject3 = component.gameObject;
		gameObject3.SetActive(value: true);
		List<object> list = (List<object>)(object)toggles;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag2 = list._size < items.Length;
		object obj16 = !flag2;
		if (obj16 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj17 = items + list._size;
			object obj18 = obj17 + 32;
			obj18 = component;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize((object)component);
		}
		GameObject gameObject4 = toggle.gameObject;
		gameObject4.SetActive(value: false);
		((Toggle)component).isOn = true;
		OnTabToggle((Transform)obj8, isOn: true);
	}

	public SportTeamAddonSelector()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2848;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 3960;
		object obj3 = typeof(List<AdaptivePerformanceScaler>) + 4032;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj4 = this + 80;
		obj4 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj5 = this + 88;
		obj5 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj6 = this + 96;
		obj6 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((MonoBehaviour)this)..ctor();
	}
}
