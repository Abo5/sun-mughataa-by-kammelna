using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using DataTracking;
using GoogleMobileAds.Api.AdManager;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Purchasing.Telemetry;

public class AnimatedRoomThemesController : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<GameObject> <>9__23_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1192;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <ClearSpineRoomElements>b__23_0(GameObject g)
		{
			g.SetActive(value: false);
		}
	}

	private sealed class <>c__DisplayClass21_0
	{
		public AnimatedRoomDataModel model;

		internal unsafe int <SortElementsBySortOrder>b__0(int a, int b)
		{
			//IL_016a: Expected I4, but got O
			//IL_00a2: Expected O, but got I4
			//IL_00cb: Expected O, but got I4
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Expected O, but got Unknown
			//IL_00fa: Expected O, but got I4
			//IL_0115: Expected O, but got I4
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Expected I4, but got Unknown
			AnimatedRoomDataModel animatedRoomDataModel = model;
			if (model != null)
			{
				AnimatedRoomDataInfo <AnimatedRoomInfo>k__BackingField = animatedRoomDataModel.<AnimatedRoomInfo>k__BackingField;
				if ((object)animatedRoomDataModel.<AnimatedRoomInfo>k__BackingField != null)
				{
					AnimatedRoomElementInfo[] elements = <AnimatedRoomInfo>k__BackingField.Elements;
					if (<AnimatedRoomInfo>k__BackingField.Elements != null)
					{
						bool flag = a < elements.Length;
						object obj = !flag;
						if (obj == null)
						{
							bool flag2 = b < elements.Length;
							object obj2 = !flag2;
							if (obj2 == null)
							{
								object obj3 = <AnimatedRoomInfo>k__BackingField.Elements + 32;
								object obj4 = a * 96;
								object obj5 = obj3 + obj4;
								object obj6 = b * 96;
								object obj7 = obj3 + obj6;
								int num = obj5 + 80;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v7+50]");
								return ((int*)num)->CompareTo(0);
							}
						}
						goto IL_015c;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_015c;
			IL_015c:
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return (int)ex2;
		}
	}

	private RoomThemeUi roomThemeUi;

	protected AnimatedRoomElementFactory factory;

	private KGame _game;

	private bool _isRoomThemeLoaded;

	private List<GameObject> _spineRoomElements;

	private Color <PrimaryColor>k__BackingField;

	private Color <SecondaryColor>k__BackingField;

	private Action m_OnElementsUpdated;

	public StoreItem activeItem;

	public Color PrimaryColor
	{
		get
		{
			return (Color)this;
		}
		private set
		{
			Color color = default(Color);
			<PrimaryColor>k__BackingField = color;
		}
	}

	public Color SecondaryColor
	{
		get
		{
			return (Color)this;
		}
		private set
		{
			Color color = default(Color);
			<SecondaryColor>k__BackingField = color;
		}
	}

	public event Action OnElementsUpdated
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 104;
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
			object obj2 = this + 104;
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

	protected virtual void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00e3: Expected O, but got I
		//IL_010d: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0083: Expected O, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00bc: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)136;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj5 = this + 48;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject go = base.gameObject;
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)1872;
		object varName = "placementId" + 2112;
		Room room = ((KGame)obj5).Room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj8);
		VariableBinderExtensions.Bind(go, room, (string)varName, action);
	}

	public void CreateRoomElements(int itemID)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0238: Expected O, but got I4
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01cd: Expected O, but got I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_0115: Expected O, but got I4
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected O, but got Unknown
		//IL_028d: Expected O, but got I4
		//IL_014d: Expected O, but got I
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_0190: Expected O, but got I
		//IL_019e: Expected I, but got O
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		StoreItem storeItem = Store.GetStoreItem(itemID);
		if (StoreItemExtensions.IsAnimatedRoomTheme(storeItem) && GamesFlagExtensions.MatchesCurrentGame(storeItem.<targetGames>k__BackingField))
		{
			object obj4 = this + 112;
			obj4 = storeItem;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			OnRoomThemeChanged(hasAnimatedRoom: true);
			ITrackEvent trackEvent = TrackerLibrary.GameAnimatedRoomThemeApplied(storeItem.<id>k__BackingField, storeItem.<name>k__BackingField);
			object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent);
			object obj8 = typeof(Queue<string>) + 688;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v26+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj11 = (nint)0 + (nint)1888;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			GameObject go = base.gameObject;
			object obj12 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1112;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj13 = (nint)0 + (nint)1856;
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj13);
			AnimatedAssetsLoader animatedAssetsLoader = default(AnimatedAssetsLoader);
			animatedAssetsLoader.LoadAnimatedRoomElements(itemID, go, action);
		}
		else
		{
			object obj14 = this + 112;
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			OnRoomThemeChanged(hasAnimatedRoom: false);
			if (this.OnElementsUpdated != null)
			{
				Actions.SafeInvoke(this.OnElementsUpdated);
			}
		}
	}

	private void RoomThemeChanged()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00a8: Expected I, but got O
		//IL_0063: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1864;
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		ClearSpineRoomElements();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Store.CallWhenLoaded(action);
	}

	private static string GetTextureName(string atlas)
	{
		if (atlas != null)
		{
			int length = atlas.IndexOf('.');
			return atlas.Substring(0, length);
		}
		return (string)(object)new NullReferenceException();
	}

	private static int[] SortElementsBySortOrder(AnimatedRoomDataModel model)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00c3: Expected O, but got I
		//IL_0222: Expected I, but got O
		//IL_00f3: Expected O, but got I4
		//IL_010d: Expected O, but got I4
		//IL_0159: Expected O, but got I4
		//IL_0169: Expected O, but got I
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected O, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected O, but got Unknown
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_0144: Expected O, but got I4
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01b3: Expected O, but got I4
		//IL_01bc: Expected O, but got I4
		//IL_01cd: Expected O, but got I4
		//IL_01d6: Expected O, but got I4
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		int[] array = default(int[]);
		object obj6;
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = model;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (obj3 != null)
			{
				object obj4 = typeof(TypeConverter<ushort, char>) + 3048;
				int elementCount = ((AnimatedRoomDataModel)obj3).ElementCount;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				if (array != null)
				{
					object obj5 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 3368;
					obj6 = (nint)0 + (nint)3560;
					if (array.Length >= 1)
					{
						object obj7 = array.Length & 0x7FFFFFFF;
						bool flag = (nint)obj7 < 8;
						object obj8 = !flag;
						object obj9;
						object obj11;
						object obj13;
						object obj15;
						object obj17;
						object obj16 = default(object);
						if (obj8 == null)
						{
							object obj10 = default(object);
							obj9 = obj10;
							object obj12 = default(object);
							obj11 = obj12;
							object obj14 = default(object);
							obj13 = obj14;
							obj15 = obj16;
							obj17 = 0;
						}
						else
						{
							obj17 = array.Length & 0x7FFFFFF8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70185E0]");
							obj15 = 0;
							object obj18 = array + 48;
							object obj19 = obj17;
							object obj20 = default(object);
							obj19 = obj20;
							obj15 = obj16;
							object obj21 = default(object);
							obj18 = obj21;
							do
							{
								obj9 = obj15 + 4;
								obj18 = obj9;
								obj15 += 8;
								obj18 += 32;
								obj19 -= 8;
							}
							while ((nint)obj19 != 8);
							bool flag2 = obj7 == obj17;
							obj11 = 8;
							obj13 = 4;
							object obj10 = obj9;
							object obj12 = 8;
							object obj14 = 4;
							obj16 = obj15;
							if (flag2)
							{
								goto IL_0207;
							}
						}
						object obj22 = array + 32;
						object obj23 = default(object);
						obj17 = obj23;
						bool flag3;
						do
						{
							obj17++;
							flag3 = obj7 != obj17;
							object obj10 = obj9;
							object obj12 = obj11;
							object obj14 = obj13;
							obj16 = obj15;
						}
						while (flag3);
					}
					goto IL_0207;
				}
			}
		}
		return (int[])(object)new NullReferenceException();
		IL_0207:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Comparison<int> comparison = default(Comparison<int>);
		comparison..ctor(obj2, (IntPtr)obj6);
		Array.Sort(array, comparison);
		return array;
	}

	private void RegisterThemeColors(AnimatedRoomDataInfo info)
	{
		<PrimaryColor>k__BackingField = info.primaryColor;
		<SecondaryColor>k__BackingField = info.secondaryColor;
	}

	private void ClearSpineRoomElements()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0171: Expected O, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I
		//IL_00cd: Expected O, but got I
		//IL_0239: Expected O, but got I4
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_01c7: Expected O, but got I
		//IL_01d7: Expected O, but got I
		//IL_01f9: Expected O, but got I4
		//IL_037b: Expected O, but got I
		//IL_038c: Expected I, but got O
		//IL_03aa: Expected O, but got I
		//IL_011c: Expected O, but got I4
		//IL_0269: Expected O, but got I
		//IL_0297: Expected O, but got I
		//IL_02a3: Expected O, but got I
		//IL_02cd: Expected I, but got O
		object obj = 152989696;
		object obj2 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1192;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7915]");
		object obj3 = (nint)0 & (nint)1;
		List<GameObject> list;
		List<GameObject> list2;
		object obj4;
		if (obj3 != null)
		{
			list = _spineRoomElements;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			list2 = _spineRoomElements;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			list = _spineRoomElements;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			list2 = _spineRoomElements;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v9+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v6+8]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v6+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		list = list2;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_0102;
		}
		goto IL_0217;
		IL_028b:
		object obj11 = (nint)0 + (nint)2560;
		object obj12 = (nint)0 + (nint)1120;
		List<object> list3;
		list3.ForEach(action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)null, (IntPtr)obj12);
		((List<object>)(object)_spineRoomElements).ForEach(action2);
		List<GameObject> spineRoomElements = _spineRoomElements;
		int version = spineRoomElements._version + 1;
		spineRoomElements._size = 0;
		spineRoomElements._version = version;
		if (spineRoomElements._size >= 1)
		{
			Array.Clear(spineRoomElements._items, 0, spineRoomElements._size);
		}
		return;
		IL_0102:
		bool flag4 = list == null;
		object obj13 = !flag4;
		list3 = (List<object>)(object)list;
		if (obj13 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_028b;
		IL_0217:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v9+E4]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v10+B8]");
			obj8 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj16 = (nint)0 + (nint)3552;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj8, (IntPtr)obj16);
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v9+B8]");
		object obj18 = (nint)0 + (nint)8;
		obj18 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		action = action3;
		obj7 = obj10;
		list3 = (List<object>)(object)list2;
		goto IL_028b;
		IL_0099:
		obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v9+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v6+8]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v6+8]");
		bool flag6 = (nint)0 == 0;
		obj10 = obj7;
		list2 = list;
		if (!flag6)
		{
			goto IL_0102;
		}
		goto IL_0217;
	}

	protected virtual void OnRoomThemeChanged(bool hasAnimatedRoom)
	{
	}

	protected virtual void OnLoadAnimatedElements()
	{
	}

	protected unsafe virtual void OnCreateSpineRoomElement(SpineRoomElementData data)
	{
		//IL_002c: Expected O, but got Ref
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0107: Expected O, but got I4
		//IL_0110: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_012a: Expected O, but got I
		//IL_00cc: Expected O, but got I4
		//IL_01a4: Expected O, but got I4
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected O, but got Unknown
		Transform animatedElementsParent = roomThemeUi.AnimatedElementsParent;
		AnimatedRoomElementInfo animatedRoomElementInfo = default(AnimatedRoomElementInfo);
		SpineRoomElement spineRoomElement = factory.CreateSpineRoomElement((SpineRoomElementData)(&animatedRoomElementInfo), animatedElementsParent);
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		GameObject gameObject = spineRoomElement.gameObject;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v4+E4]");
		object obj4;
		object obj5;
		if ((nint)0 != 0)
		{
			bool flag = data.<AudioClip>k__BackingField != null;
			bool flag2 = !flag;
			object obj3 = !flag2;
			obj4 = 0;
			if (obj3 != null)
			{
				goto IL_011e;
			}
			obj5 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = data.<AudioClip>k__BackingField != null;
			bool flag4 = !flag3;
			obj4 = 0;
			obj5 = 0;
			if (!flag4)
			{
				goto IL_011e;
			}
		}
		goto IL_0141;
		IL_0141:
		List<object> spineRoomElements = (List<object>)(object)_spineRoomElements;
		int version = spineRoomElements._version + 1;
		spineRoomElements._version = version;
		object[] items = spineRoomElements._items;
		bool flag5 = spineRoomElements._size < items.Length;
		object obj6 = !flag5;
		if (obj6 == null)
		{
			int size = spineRoomElements._size + 1;
			spineRoomElements._size = size;
			object obj7 = items + spineRoomElements._size;
			object obj8 = obj7 + 32;
			obj8 = gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			spineRoomElements.AddWithResize((object)gameObject);
		}
		return;
		IL_011e:
		object obj9 = (nint)0 + (nint)560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32E24");
		obj5 = obj4;
		goto IL_0141;
	}

	public AnimatedRoomThemesController()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 64;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private unsafe void <CreateRoomElements>b__18_0(AnimatedRoomDataModel model)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0018: Expected O, but got I
		//IL_0ac9: Expected O, but got I
		//IL_00a6: Expected I, but got O
		//IL_00b6: Expected O, but got I
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0126: Expected O, but got I
		//IL_0134: Expected O, but got I
		//IL_0155: Expected O, but got I4
		//IL_015d: Expected O, but got Ref
		//IL_0166: Expected O, but got I4
		//IL_0176: Expected O, but got I
		//IL_02b5: Expected O, but got I4
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		//IL_0364: Expected O, but got I
		//IL_0374: Expected O, but got I
		//IL_03f8: Expected O, but got I4
		//IL_0488: Expected O, but got I4
		//IL_04c4: Expected O, but got I
		//IL_04de: Expected O, but got I4
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Expected O, but got Unknown
		//IL_08f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fd: Expected O, but got Unknown
		//IL_091a: Expected O, but got I
		//IL_054d: Expected O, but got I4
		//IL_09e6: Expected O, but got Ref
		//IL_0a17: Expected O, but got I
		//IL_0a17: Expected O, but got Ref
		//IL_0a24: Expected O, but got I4
		//IL_0a54: Expected O, but got I
		//IL_0a5d: Expected O, but got Ref
		//IL_05c5: Expected O, but got I4
		//IL_0655: Expected O, but got I4
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_0695: Expected O, but got Unknown
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Expected O, but got Unknown
		//IL_0701: Unknown result type (might be due to invalid IL or missing references)
		//IL_0706: Expected O, but got Unknown
		//IL_071c: Expected O, but got I
		//IL_073a: Expected O, but got I
		//IL_078f: Expected O, but got I
		//IL_07be: Expected O, but got Ref
		//IL_07db: Expected O, but got I
		//IL_07f0: Expected O, but got Ref
		//IL_0810: Expected O, but got Ref
		//IL_082d: Expected O, but got Ref
		//IL_0845: Expected O, but got Ref
		//IL_0862: Expected O, but got Ref
		//IL_087a: Expected O, but got Ref
		//IL_088e: Expected I, but got O
		//IL_08a8: Expected O, but got Ref
		//IL_08c8: Expected O, but got I4
		//IL_08d1: Expected O, but got I4
		//IL_08d9: Expected O, but got Ref
		//IL_08e1: Expected O, but got Ref
		//IL_08ea: Expected O, but got I4
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj3 = 0;
		AnimatedRoomDataModel animatedRoomDataModel = default(AnimatedRoomDataModel);
		bool flag = animatedRoomDataModel == null;
		Action action = (Action)(object)this;
		if (flag)
		{
			goto IL_0ab9;
		}
		AnimatedRoomDataInfo <AnimatedRoomInfo>k__BackingField = animatedRoomDataModel.<AnimatedRoomInfo>k__BackingField;
		bool flag2 = (object)animatedRoomDataModel.<AnimatedRoomInfo>k__BackingField == null;
		AnimatedRoomDataModel animatedRoomDataModel2 = animatedRoomDataModel;
		AnimatedRoomThemesController animatedRoomThemesController;
		if (!flag2)
		{
			<PrimaryColor>k__BackingField = <AnimatedRoomInfo>k__BackingField.primaryColor;
			Color secondaryColor = <AnimatedRoomInfo>k__BackingField.secondaryColor;
			<SecondaryColor>k__BackingField = <AnimatedRoomInfo>k__BackingField.secondaryColor;
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v10 (Il2CppClass<AnimatedRoomThemesController>)+1A0]");
			animatedRoomDataModel2 = (AnimatedRoomDataModel)0;
			OnLoadAnimatedElements();
			int[] array = SortElementsBySortOrder(animatedRoomDataModel);
			if (array != null)
			{
				bool flag3 = array.Length < 1;
				animatedRoomThemesController = this;
				if (flag3)
				{
					goto IL_0a6a;
				}
				object obj4 = array + 32;
				Color color = default(Color);
				object obj5 = (nint)(&color) | (nint)4;
				Color color2 = default(Color);
				object obj6 = (nint)(&color2) | (nint)4;
				Transform transform2 = default(Transform);
				Transform transform = transform2;
				nint num3 = default(nint);
				nint num2 = num3;
				Color color4 = default(Color);
				Color color3 = color4;
				object obj7 = 96;
				object obj8 = (object)(&color2);
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v10 (Il2CppClass<AnimatedRoomThemesController>)+1A0]");
				AnimatedRoomDataModel animatedRoomDataModel3 = (AnimatedRoomDataModel)0;
				Color color5 = <AnimatedRoomInfo>k__BackingField.secondaryColor;
				object obj32 = default(object);
				while (true)
				{
					AnimatedRoomDataInfo <AnimatedRoomInfo>k__BackingField2 = animatedRoomDataModel.<AnimatedRoomInfo>k__BackingField;
					bool flag4 = (object)animatedRoomDataModel.<AnimatedRoomInfo>k__BackingField == null;
					transform2 = transform;
					num3 = num2;
					color4 = color3;
					animatedRoomDataModel2 = animatedRoomDataModel3;
					secondaryColor = color5;
					if (flag4)
					{
						break;
					}
					AnimatedRoomElementInfo[] elements = <AnimatedRoomInfo>k__BackingField2.Elements;
					bool flag5 = <AnimatedRoomInfo>k__BackingField2.Elements == null;
					transform2 = transform;
					num3 = num2;
					color4 = color3;
					animatedRoomDataModel2 = animatedRoomDataModel3;
					secondaryColor = color5;
					if (flag5)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X27_v11+v337 @ X26_v8*4]");
					bool flag6 = (nint)0 < (nint)elements.Length;
					object obj10 = !flag6;
					transform2 = transform;
					num3 = num2;
					color4 = color3;
					animatedRoomDataModel2 = animatedRoomDataModel3;
					secondaryColor = color5;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X27_v11+v337 @ X26_v8*4]");
						object obj11 = 0 * obj7;
						object obj12 = (object)<AnimatedRoomInfo>k__BackingField2.Elements + obj11;
						object obj13 = obj12 + 122;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X9_v14-36]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X9_v14-26]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X9_v14-16]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X9_v14-9]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X9_v14-56]");
						secondaryColor = (Color)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X9_v14-46]");
						color4 = (Color)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X9_v14-56]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X9_v14-46]");
						_ = 0;
						Texture2D[] <Images>k__BackingField = animatedRoomDataModel.<Images>k__BackingField;
						bool flag7 = animatedRoomDataModel.<Images>k__BackingField == null;
						transform2 = transform;
						num3 = num2;
						animatedRoomDataModel2 = animatedRoomDataModel3;
						if (flag7)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X27_v11+v337 @ X26_v8*4]");
						bool flag8 = (nint)0 < (nint)<Images>k__BackingField.Length;
						object obj14 = !flag8;
						transform2 = transform;
						num3 = num2;
						animatedRoomDataModel2 = animatedRoomDataModel3;
						if (obj14 == null)
						{
							AudioClip[] <Audios>k__BackingField = animatedRoomDataModel.<Audios>k__BackingField;
							bool flag9 = animatedRoomDataModel.<Audios>k__BackingField == null;
							transform2 = transform;
							num3 = num2;
							animatedRoomDataModel2 = animatedRoomDataModel3;
							if (flag9)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X27_v11+v337 @ X26_v8*4]");
							bool flag10 = (nint)0 < (nint)<Audios>k__BackingField.Length;
							object obj15 = !flag10;
							transform2 = transform;
							num3 = num2;
							animatedRoomDataModel2 = animatedRoomDataModel3;
							if (obj15 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X9_v14-1]");
								object obj16 = (nint)0 & (nint)1;
								bool flag11 = obj16 == null;
								object obj17 = !flag11;
								if (obj17 == null)
								{
									Texture2D[] <Images>k__BackingField2 = animatedRoomDataModel.<Images>k__BackingField;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X27_v11+v337 @ X26_v8*4]");
									object obj18 = <Images>k__BackingField2 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X9_v14-5A]");
									if ((nint)0 != 1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X9_v14-5A]");
										bool flag12 = (nint)0 == 0;
										object obj19 = !flag12;
										if (obj19 == null)
										{
											string[] <SpineSkeletonTexts>k__BackingField = animatedRoomDataModel.<SpineSkeletonTexts>k__BackingField;
											bool flag13 = animatedRoomDataModel.<SpineSkeletonTexts>k__BackingField == null;
											transform2 = transform;
											num3 = num2;
											animatedRoomDataModel2 = animatedRoomDataModel3;
											if (flag13)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X27_v11+v337 @ X26_v8*4]");
											bool flag14 = (nint)0 < (nint)<SpineSkeletonTexts>k__BackingField.Length;
											object obj20 = !flag14;
											transform2 = transform;
											num3 = num2;
											animatedRoomDataModel2 = animatedRoomDataModel3;
											if (obj20 == null)
											{
												string[] <SpineAtlasTexts>k__BackingField = animatedRoomDataModel.<SpineAtlasTexts>k__BackingField;
												bool flag15 = animatedRoomDataModel.<SpineAtlasTexts>k__BackingField == null;
												transform2 = transform;
												num3 = num2;
												animatedRoomDataModel2 = animatedRoomDataModel3;
												if (flag15)
												{
													break;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X27_v11+v337 @ X26_v8*4]");
												bool flag16 = (nint)0 < (nint)<SpineAtlasTexts>k__BackingField.Length;
												object obj21 = !flag16;
												transform2 = transform;
												num3 = num2;
												animatedRoomDataModel2 = animatedRoomDataModel3;
												if (obj21 == null)
												{
													string[] <SpineAtlasTexts>k__BackingField2 = animatedRoomDataModel.<SpineAtlasTexts>k__BackingField;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X27_v11+v337 @ X26_v8*4]");
													object obj22 = <SpineAtlasTexts>k__BackingField2 + 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X10_v12+20]");
													bool flag17 = (nint)0 == 0;
													transform2 = transform;
													num3 = num2;
													animatedRoomDataModel2 = animatedRoomDataModel3;
													if (flag17)
													{
														break;
													}
													AudioClip[] <Audios>k__BackingField2 = animatedRoomDataModel.<Audios>k__BackingField;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X27_v11+v337 @ X26_v8*4]");
													object obj23 = <Audios>k__BackingField2 + 0;
													string[] <SpineSkeletonTexts>k__BackingField2 = animatedRoomDataModel.<SpineSkeletonTexts>k__BackingField;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X27_v11+v337 @ X26_v8*4]");
													object obj24 = <SpineSkeletonTexts>k__BackingField2 + 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X10_v12+20]");
													int num4 = ((string)0).IndexOf('.');
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X10_v12+20]");
													string text = ((string)0).Substring(0, num4);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X12_v9+20]");
													bool flag18 = (nint)0 == 0;
													transform2 = null;
													num3 = num4;
													animatedRoomDataModel2 = null;
													if (flag18)
													{
														break;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X12_v9+20]");
													((UnityEngine.Object)0).name = text;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-A0]");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-90]");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-80]");
													_ = 0;
													object obj25 = (object)(&color2);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X8_v27+CD]");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-C0]");
													obj6 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
													_ = 0;
													object obj26 = (object)(&color2);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X9_v14+4]");
													_ = 0;
													object obj27 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref color2, 8));
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													object obj28 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref color2, 96));
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													object obj29 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref color2, 104));
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													object obj30 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref color2, 112));
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													object obj31 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref color2, 120));
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													nint num5 = (nint)this;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X8_v30 (Il2CppClass<AnimatedRoomThemesController>)+1B0]");
													num2 = 0;
													OnCreateSpineRoomElement((SpineRoomElementData)(&color));
													color = (Color)obj32;
													transform = null;
													color4 = (Color)0;
													obj7 = 96;
													obj8 = (object)(&color2);
													animatedRoomDataModel3 = (AnimatedRoomDataModel)(&color);
													secondaryColor = (Color)0;
													goto IL_0188;
												}
											}
											goto IL_0b07;
										}
									}
									else
									{
										obj32 = obj13 - 86;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X8_v19+4D]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X8_v19+10]");
										secondaryColor = (Color)0;
										bool flag19 = (object)roomThemeUi == null;
										transform2 = transform;
										num3 = num2;
										animatedRoomDataModel2 = animatedRoomDataModel3;
										if (flag19)
										{
											break;
										}
										Transform animatedElementsParent = roomThemeUi.AnimatedElementsParent;
										bool flag20 = (object)factory == null;
										transform2 = transform;
										num3 = num2;
										animatedRoomDataModel2 = null;
										if (flag20)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X8_v19+20]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X8_v19+30]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X8_v19+40]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X25_v11+4D]");
										_ = 0;
										obj5 = obj32;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X8_v19+10]");
										_ = 0;
										object obj33 = (object)(&color);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X9_v14+4]");
										_ = 0;
										AnimatedRoomElementFactory animatedRoomElementFactory = factory;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X12_v9+20]");
										SpriteSheetRoomElement spriteSheetRoomElement = animatedRoomElementFactory.CreateSpriteSheetRoomElement((AnimatedRoomElementInfo)(&color), (Texture2D)0, animatedElementsParent);
										color = (Color)1;
										color2 = (Color)obj32;
										transform = animatedElementsParent;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X12_v9+20]");
										num2 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X8_v19+10]");
										color4 = (Color)0;
										animatedRoomDataModel3 = (AnimatedRoomDataModel)(&color);
										secondaryColor = (Color)obj32;
									}
								}
								goto IL_0188;
							}
						}
					}
					goto IL_0b07;
					IL_0188:
					obj9++;
					bool flag21 = (nint)obj9 >= array.Length;
					color3 = color4;
					color5 = secondaryColor;
					transform2 = transform;
					num3 = num2;
					animatedRoomDataModel2 = animatedRoomDataModel3;
					animatedRoomThemesController = this;
					if (!flag21)
					{
						continue;
					}
					goto IL_0a6a;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0b07;
		IL_0b07:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		animatedRoomDataModel = animatedRoomDataModel2;
		goto IL_0b1d;
		IL_0ab9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-68]");
		bool flag22 = obj34 != null;
		ex2 = (IndexOutOfRangeException)(object)action;
		if (!flag22)
		{
			return;
		}
		goto IL_0b1d;
		IL_0b1d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
		return;
		IL_0a6a:
		action = animatedRoomThemesController.OnElementsUpdated;
		bool flag23 = animatedRoomThemesController.OnElementsUpdated == null;
		animatedRoomDataModel = animatedRoomDataModel2;
		if (!flag23)
		{
			Actions.SafeInvoke(animatedRoomThemesController.OnElementsUpdated);
			animatedRoomDataModel = null;
		}
		goto IL_0ab9;
	}

	private void <RoomThemeChanged>b__19_0()
	{
		Room room = _game.Room;
		int roomThemeID = SFSKammelnaRoomExtensions.GetRoomThemeID(room);
		CreateRoomElements(roomThemeID);
	}
}
