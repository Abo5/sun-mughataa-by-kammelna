using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Server.Models;
using Spine;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;

public class ChampionshipAddonSelector : TournamentAddonSelector
{
	private sealed class <>c__DisplayClass17_0
	{
		public TournamentAddonConfig.ChampionshipConfig.TrophyConfig trophy;

		internal bool <Populate>b__0(TournamentChampionshipTrophyItem ct)
		{
			//IL_007c: Expected I4, but got O
			if ((object)ct != null)
			{
				string name = ct.name;
				TournamentAddonConfig.ChampionshipConfig.TrophyConfig trophyConfig = trophy;
				if (trophy != null)
				{
					return name != trophyConfig.<Name>k__BackingField;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass19_0
	{
		public TournamentChampionshipTrophyItem trophy;

		internal bool <Repopulate>b__0(KeyValuePair<string, TournamentAddonConfig.ChampionshipConfig.TrophyConfig> f)
		{
			//IL_0064: Expected I4, but got O
			//IL_0048: Expected O, but got I
			IntPtr intPtr = default(IntPtr);
			if (intPtr != (IntPtr)0 && (object)trophy != null)
			{
				string name = trophy.name;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ X2 (Il2CppMethodInfo)+10]");
				return (string)0 == name;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <Repopulate>b__1(TournamentAddonConfig.ChampionshipConfig.TrophyConfig t)
		{
			//IL_0079: Expected I4, but got O
			if (t != null && (object)trophy != null)
			{
				string name = trophy.name;
				return t.<Name>k__BackingField == name;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass22_0
	{
		public ChampionshipTournamentAddon addon;

		internal bool <ShowConfirmedSelection>b__0(TournamentChampionshipTrophyItem championshipItem)
		{
			//IL_008c: Expected I4, but got O
			if ((object)championshipItem != null)
			{
				ChampionshipTournamentAddon championshipTournamentAddon = addon;
				if (addon != null)
				{
					return championshipItem.<TrophyName>k__BackingField == championshipTournamentAddon.<trophyName>k__BackingField;
				}
				return championshipItem.<TrophyName>k__BackingField == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private new Action m_OnValidStateChange;

	private TournamentChampionshipTrophyItem itemPrefab;

	private Transform parent;

	private List<TournamentChampionshipTrophyItem> populatedItems;

	private TournamentChampionshipTrophyItem selectedItem;

	public override string Title => "Cannot populate JSON object onto type '{0}'." + 2080;

	public override string Subtitle => "Cannot populate JSON object onto type '{0}'." + 2712;

	public override TournamentAddonType addonType => TournamentAddonType.Championship;

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
			return selectedItem != null;
		}
	}

	private TournamentAddonConfig.ChampionshipConfig championshipConfig
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00da: Expected O, but got I4
			//IL_0097: Expected O, but got I4
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Expected O, but got Unknown
			//IL_01b3: Expected I, but got O
			//IL_01dc: Expected O, but got I4
			//IL_0211: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6C56]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v12+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v12+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			RemoteConfigModel current = RemoteConfig.Current;
			if (current != null)
			{
				goto IL_011d;
			}
			goto IL_024f;
			IL_024f:
			return (TournamentAddonConfig.ChampionshipConfig)(object)new NullReferenceException();
			IL_011d:
			if (current.<Tournaments>k__BackingField != null)
			{
				Dictionary<TournamentAddonType, TournamentAddonConfig.AddonConfig> addons = current.<Tournaments>k__BackingField.Addons;
				object obj5 = DictionaryExtensions.Get((IDictionary<System.Int32Enum, object>)addons, (System.Int32Enum)5);
				bool flag2 = obj5 == null;
				TournamentAddonConfig.ChampionshipConfig result = (TournamentAddonConfig.ChampionshipConfig)obj5;
				if (!flag2)
				{
					object obj6 = typeof(SkeletonBinary.SkeletonInput) + 3408;
					object obj7 = obj6;
					nint num = (nint)obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X9_v2 (Il2CppClass<System.Object>)+130]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v7+130]");
					bool flag3 = num2 < 0;
					object obj8 = !flag3;
					if (obj8 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X9_v2 (Il2CppClass<System.Object>)+C8]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v7+130]");
						object obj9 = num3 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X9_v4-8]");
						if (0 == (nint)obj7)
						{
							return (TournamentAddonConfig.ChampionshipConfig)obj5;
						}
						return null;
					}
					result = null;
				}
				return result;
			}
			goto IL_024f;
			IL_0074:
			current = RemoteConfig.Current;
			bool flag4 = current == null;
			object obj10 = !flag4;
			if (obj10 != null)
			{
				goto IL_011d;
			}
			goto IL_024f;
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

	public void Populate()
	{
		//IL_05c9: Expected O, but got I4
		//IL_0022: Expected O, but got I4
		//IL_003c: Expected O, but got I
		//IL_0044: Expected I, but got O
		//IL_006e: Expected O, but got I4
		//IL_053f: Expected O, but got I
		//IL_0547: Expected I, but got O
		//IL_0089: Expected O, but got I
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I
		//IL_00c9: Expected O, but got I
		//IL_0499: Expected I, but got O
		//IL_04ed: Expected O, but got I4
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_01c7: Expected I, but got O
		//IL_01cf: Expected I, but got O
		//IL_01ff: Expected O, but got I4
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_024b: Expected O, but got I4
		//IL_0274: Expected O, but got I
		//IL_027c: Expected I, but got O
		//IL_04b0: Expected O, but got I4
		//IL_04ba: Expected I, but got O
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02df: Expected O, but got I
		//IL_02e7: Expected I, but got O
		//IL_02f5: Expected I, but got O
		//IL_04d1: Expected O, but got I4
		//IL_04d6: Expected I, but got O
		//IL_0323: Expected O, but got I
		//IL_032b: Expected I, but got O
		//IL_047e: Expected O, but got I4
		//IL_0486: Expected I, but got O
		//IL_0372: Expected O, but got I
		//IL_03e9: Expected O, but got I4
		//IL_00eb: Expected O, but got I
		//IL_00fb: Expected O, but got I
		//IL_0123: Expected O, but got I4
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected O, but got Unknown
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected O, but got Unknown
		//IL_0457: Expected O, but got I4
		TournamentAddonConfig.ChampionshipConfig championshipConfig = this.championshipConfig;
		bool flag = championshipConfig == null;
		Dictionary<object, object>.ValueCollection.Enumerator enumerator = (Dictionary<object, object>.ValueCollection.Enumerator)0;
		nint num = default(nint);
		if (!flag)
		{
			bool flag2 = championshipConfig.<Trophies>k__BackingField == null;
			enumerator = (Dictionary<object, object>.ValueCollection.Enumerator)0;
			if (!flag2)
			{
				object obj = (nint)0 + (nint)1912;
				num = (nint)obj;
				Dictionary<object, object>.ValueCollection values = ((Dictionary<object, object>)(object)championshipConfig.<Trophies>k__BackingField).Values;
				bool flag3 = values == null;
				enumerator = (Dictionary<object, object>.ValueCollection.Enumerator)0;
				if (!flag3)
				{
					object obj2 = (nint)0 + (nint)3480;
					object obj3 = typeof(CardUtils.<>c) + 104;
					object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3880;
					object obj5 = (nint)0 + (nint)2840;
					object obj6 = (nint)0 + (nint)1976;
					Dictionary<object, object>.ValueCollection.Enumerator enumerator2 = values.GetEnumerator();
					Dictionary<object, object>.ValueCollection.Enumerator enumerator3 = default(Dictionary<object, object>.ValueCollection.Enumerator);
					object obj7 = default(object);
					object obj9 = default(object);
					Func<object, bool> func = default(Func<object, bool>);
					TournamentChampionshipTrophyItem tournamentChampionshipTrophyItem = default(TournamentChampionshipTrophyItem);
					UnityAction<object> unityAction = default(UnityAction<object>);
					while (true)
					{
						if (enumerator3.MoveNext())
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							obj7..ctor();
							if (obj7 != null)
							{
								object obj8 = obj7 + 16;
								obj8 = obj9;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								func..ctor(obj7, (IntPtr)obj5);
								nint num2 = (nint)obj6;
								bool flag4 = Enumerable.All(populatedItems, func);
								bool flag5 = !flag4;
								object obj10 = 0;
								if (flag5)
								{
									continue;
								}
								object obj11 = typeof(MemberAchievementClanFeedData) + 2976;
								object obj12 = obj11;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X0_v34+E4]");
								bool flag6 = (nint)0 == 0;
								object obj13 = !flag6;
								if (obj13 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								object obj14 = (nint)0 + (nint)800;
								num2 = (nint)obj14;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
								if ((object)tournamentChampionshipTrophyItem != null)
								{
									tournamentChampionshipTrophyItem.PopulateInfo((TournamentAddonConfig.ChampionshipConfig.TrophyConfig)obj8);
									object obj15 = typeof(TypeConverter<ushort, char>) + 472;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									object obj16 = (nint)0 + (nint)3616;
									num2 = (nint)obj16;
									unityAction..ctor((object)this, (IntPtr)obj16);
									if (tournamentChampionshipTrophyItem.OnSelected != null)
									{
										object obj17 = (nint)0 + (nint)1248;
										num2 = (nint)obj17;
										((UnityEvent<object>)(object)tournamentChampionshipTrophyItem.OnSelected).AddListener(unityAction);
										List<object> list = (List<object>)(object)populatedItems;
										if (populatedItems != null)
										{
											object obj18 = (nint)0 + (nint)1320;
											object obj19 = obj18;
											int version = list._version + 1;
											list._version = version;
											object[] items = list._items;
											if (list._items != null)
											{
												bool flag7 = list._size < items.Length;
												object obj20 = !flag7;
												if (obj20 != null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v33+20]");
													object obj21 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v35+C0]");
													object obj22 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v36+70]");
													num2 = 0;
													((List<object>)(object)populatedItems).AddWithResize((object)tournamentChampionshipTrophyItem);
													obj10 = 0;
												}
												else
												{
													int size = list._size + 1;
													list._size = size;
													object obj23 = list._items + list._size;
													object obj24 = obj23 + 32;
													obj24 = tournamentChampionshipTrophyItem;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													obj10 = 0;
												}
												continue;
											}
										}
										NullReferenceException ex = new NullReferenceException();
										obj10 = 0;
										num = (nint)unityAction;
									}
									else
									{
										NullReferenceException ex2 = new NullReferenceException();
										obj10 = 0;
										num = (nint)this;
									}
								}
								else
								{
									NullReferenceException ex3 = new NullReferenceException();
									obj10 = 0;
									num = (nint)parent;
								}
								break;
							}
							NullReferenceException ex4 = new NullReferenceException();
							num = unchecked((nint)null);
							break;
						}
						enumerator3.Dispose();
						return;
					}
					Dictionary<object, object>.ValueCollection.Enumerator enumerator4 = default(Dictionary<object, object>.ValueCollection.Enumerator);
					enumerator = enumerator4;
					enumerator4 = (Dictionary<object, object>.ValueCollection.Enumerator)0;
				}
			}
		}
		NullReferenceException ex5 = new NullReferenceException();
		bool flag8 = num != 1;
		OutOfMemoryException ex6 = (OutOfMemoryException)(object)ex5;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj25 = (nint)0 + (nint)3472;
			num = (nint)obj25;
			enumerator.Dispose();
			object obj26 = default(object);
			if (obj26 == null)
			{
				return;
			}
			ex6 = new OutOfMemoryException();
			Dictionary<object, object>.ValueCollection.Enumerator enumerator4 = (Dictionary<object, object>.ValueCollection.Enumerator)obj26;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22391FC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public override void Clear()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		object obj = this + 72;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Repopulate();
	}

	private void Repopulate()
	{
		//IL_0482: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_002a: Expected O, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_004a: Expected O, but got I
		//IL_0056: Expected O, but got I
		//IL_0400: Expected O, but got I
		//IL_0408: Expected I, but got O
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_033a: Expected I, but got O
		//IL_03ae: Expected O, but got I4
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c9: Expected O, but got I
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_012c: Expected O, but got I
		//IL_013d: Expected I, but got O
		//IL_0303: Expected O, but got I4
		//IL_030b: Expected I, but got O
		//IL_0322: Expected O, but got I4
		//IL_0327: Expected I, but got O
		//IL_02db: Expected O, but got I4
		//IL_02e4: Expected O, but got I4
		//IL_0367: Expected O, but got I4
		//IL_0370: Expected O, but got I4
		//IL_0237: Expected I, but got O
		//IL_026d: Expected O, but got I4
		//IL_038f: Expected O, but got I4
		//IL_0397: Expected I, but got O
		//IL_02ae: Expected O, but got I4
		bool flag = populatedItems == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		nint num = default(nint);
		if (!flag)
		{
			object obj = (nint)0 + (nint)2520;
			object obj2 = (nint)0 + (nint)2456;
			object obj3 = (nint)0 + (nint)1912;
			object obj4 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 576;
			object obj5 = (nint)0 + (nint)2856;
			object obj6 = (nint)0 + (nint)1504;
			List<object>.Enumerator enumerator2 = ((List<object>)(object)populatedItems).GetEnumerator();
			List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
			object obj8 = default(object);
			IntPtr intPtr = default(IntPtr);
			ChampionshipAddonSelector championshipAddonSelector = default(ChampionshipAddonSelector);
			Func<KeyValuePair<object, object>, bool> func = default(Func<KeyValuePair<object, object>, bool>);
			Func<object, bool> func2 = default(Func<object, bool>);
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			while (enumerator3.MoveNext())
			{
				object obj7 = typeof(CardUtils.<>c) + 112;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj8..ctor();
				if (obj8 != null)
				{
					object obj9 = obj8 + 16;
					obj9 = (nint)intPtr;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					TournamentAddonConfig.ChampionshipConfig championshipConfig = championshipAddonSelector.championshipConfig;
					if (championshipConfig != null)
					{
						object obj10 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3696;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj11 = (nint)0 + (nint)2848;
						func..ctor(obj8, (IntPtr)obj11);
						object obj12 = obj2;
						bool flag2 = Enumerable.Any((IEnumerable<KeyValuePair<object, object>>)championshipConfig.<Trophies>k__BackingField, func);
						if (obj9 != null)
						{
							GameObject gameObject = ((Component)obj9).gameObject;
							if ((object)gameObject != null)
							{
								gameObject.SetActive(flag2);
								TournamentAddonConfig.ChampionshipConfig championshipConfig2 = ((ChampionshipAddonSelector)(object)gameObject).championshipConfig;
								if (championshipConfig2 != null)
								{
									if (championshipConfig2.<Trophies>k__BackingField != null)
									{
										Dictionary<object, object>.ValueCollection values = ((Dictionary<object, object>)(object)championshipConfig2.<Trophies>k__BackingField).Values;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										func2..ctor(obj8, (IntPtr)obj5);
										obj12 = obj6;
										object obj13 = Enumerable.FirstOrDefault(values, func2);
										bool flag3 = obj13 == null;
										object obj14 = 0;
										if (flag3)
										{
											continue;
										}
										if (obj9 != null)
										{
											((TournamentChampionshipTrophyItem)obj9).PopulateInfo((TournamentAddonConfig.ChampionshipConfig.TrophyConfig)obj13);
											obj14 = 0;
											continue;
										}
										NullReferenceException ex = new NullReferenceException();
										obj14 = 0;
										num = (nint)obj13;
									}
									else
									{
										NullReferenceException ex2 = new NullReferenceException();
										object obj14 = 0;
										obj12 = 0;
										num = (flag2 ? 1 : 0);
									}
								}
								else
								{
									NullReferenceException ex3 = new NullReferenceException();
									object obj14 = 0;
									obj12 = 0;
									num = (flag2 ? 1 : 0);
								}
							}
							else
							{
								NullReferenceException ex4 = new NullReferenceException();
								object obj14 = 0;
								num = unchecked((nint)null);
							}
						}
						else
						{
							NullReferenceException ex5 = new NullReferenceException();
							object obj14 = 0;
							num = (nint)func;
						}
					}
					else
					{
						NullReferenceException ex6 = new NullReferenceException();
						num = intPtr;
					}
				}
				else
				{
					NullReferenceException ex7 = new NullReferenceException();
					num = unchecked((nint)null);
				}
				enumerator = enumerator4;
				enumerator4 = (List<object>.Enumerator)0;
				goto IL_04ba;
			}
			enumerator3.Dispose();
			goto IL_02c2;
		}
		goto IL_04ba;
		IL_02c2:
		Refresh();
		return;
		IL_04ba:
		NullReferenceException ex8 = new NullReferenceException();
		bool flag4 = num != 1;
		OutOfMemoryException ex9 = (OutOfMemoryException)(object)ex8;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj15 = (nint)0 + (nint)2512;
			num = (nint)obj15;
			enumerator.Dispose();
			object obj16 = default(object);
			if (obj16 == null)
			{
				goto IL_02c2;
			}
			ex9 = new OutOfMemoryException();
			List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj16;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223923C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public override void Refresh()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_00a8: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3760;
		object obj2 = (nint)0 + (nint)3608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		((List<object>)(object)populatedItems).ForEach(action);
		Action onValidStateChange = OnValidStateChange;
		if (OnValidStateChange != null)
		{
			IntPtr invoke_impl = ((Delegate)onValidStateChange).invoke_impl;
			IntPtr method_code = ((Delegate)onValidStateChange).method_code;
			IntPtr method = ((Delegate)onValidStateChange).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v68 @ X2_v3 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public override void OnConfirm()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		TournamentChampionshipTrophyItem tournamentChampionshipTrophyItem = selectedItem;
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = tournamentChampionshipTrophyItem.<TrophyName>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
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
		object obj = typeof(CardUtils.<>c) + 120;
		object obj2 = default(object);
		Func<object, bool> func = default(Func<object, bool>);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj2..ctor();
			if (tournamentAddonModel != null)
			{
				object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 584;
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
			object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3880;
			object obj13 = (nint)0 + (nint)2864;
			object obj14 = (nint)0 + (nint)1320;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			func..ctor(obj2, (IntPtr)obj13);
			object obj15 = Enumerable.FirstOrDefault(populatedItems, func);
			object obj16 = this + 72;
			obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			nint num7 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v4 (Il2CppClass<ChampionshipAddonSelector>)+1E8]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v4 (Il2CppClass<ChampionshipAddonSelector>)+1F0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v192 @ X2_v3 (should have been resolved before IL gen)");
		}
		throw new InvalidCastException();
	}

	public void SelectItem(TournamentChampionshipTrophyItem itemToSelect)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0022: Expected I, but got O
		//IL_0032: Expected O, but got I
		//IL_0042: Expected O, but got I
		object obj = this + 72;
		obj = itemToSelect;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v1 (Il2CppClass<ChampionshipAddonSelector>)+1E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v1 (Il2CppClass<ChampionshipAddonSelector>)+1F0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v30 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public ChampionshipAddonSelector()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 64;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((MonoBehaviour)this)..ctor();
	}

	private void <Refresh>b__20_0(TournamentChampionshipTrophyItem c)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f6: Expected O, but got I4
		//IL_00b3: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6C5D]");
		object obj2 = (nint)0 & (nint)1;
		UnityEngine.Object obj4;
		UnityEngine.Object obj5;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			obj4 = selectedItem;
			obj5 = selectedItem;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj4 = selectedItem;
			obj5 = selectedItem;
			if (obj6 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool active = c == obj5;
		goto IL_0138;
		IL_0138:
		GameObject gameObject = c.selectionFrame.gameObject;
		gameObject.SetActive(active);
		return;
		IL_0088:
		active = c == obj4;
		bool flag3 = (object)c == null;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0138;
	}
}
