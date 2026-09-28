using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Sfs2X.Entities;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public class FeaturedSlotPicker : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<UserAchievementModel, bool> <>9__6_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 2272;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <Populate>b__6_1(UserAchievementModel ua)
		{
			//IL_003d: Expected I4, but got O
			if (ua != null)
			{
				return ua.isUnlocked;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass6_0
	{
		public FeaturedSlotPicker <>4__this;

		public EmptySelectable emptyItem;

		internal void <Populate>b__0()
		{
			<>4__this.UnequipItem(emptyItem);
		}
	}

	private sealed class <>c__DisplayClass6_1
	{
		public UserAchievementModel achievement;

		public Achievement achievementItem;

		public <>c__DisplayClass6_0 CS$<>8__locals1;

		internal void <Populate>b__2(GameAchievementViewModel a)
		{
			<>c__DisplayClass6_0 cS$<>8__locals = CS$<>8__locals1;
			cS$<>8__locals.<>4__this.EquipAchievement(achievement, achievementItem);
		}
	}

	private sealed class <>c__DisplayClass7_0
	{
		public FeaturedSlotPicker <>4__this;

		public ISelectable selectable;

		internal void <EquipAchievement>b__0(KammelnaResponseModel<bool> b)
		{
			if (b.Succeeded)
			{
				FeaturedSlotPicker featuredSlotPicker = <>4__this;
				featuredSlotPicker.selectionManager.SetSelected(selectable);
			}
		}
	}

	private sealed class <>c__DisplayClass8_0
	{
		public FeaturedSlotPicker <>4__this;

		public ISelectable selectable;

		internal void <UnequipItem>b__0(KammelnaResponseModel<bool> b)
		{
			if (b.Succeeded)
			{
				FeaturedSlotPicker featuredSlotPicker = <>4__this;
				featuredSlotPicker.selectionManager.SetSelected(selectable);
			}
		}
	}

	private Transform layout;

	private Achievement achievementItemPrefab;

	private EmptySelectable emptyItemPrefab;

	private SelectableItemsList selectionManager;

	private void ClearLayout()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_029a: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6910]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v24+E4]");
			bool flag = (nint)0 == 0;
			obj5 = layout;
			obj6 = layout;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v24+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = layout;
			obj6 = layout;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if ((bool)obj6)
		{
			goto IL_014e;
		}
		return;
		IL_014e:
		int childCount = layout.childCount;
		if (childCount < 1)
		{
			return;
		}
		int num = childCount;
		do
		{
			num--;
			Transform child = layout.GetChild(num);
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v10+E4]");
			if ((nint)0 != 0)
			{
				if (!child)
				{
					continue;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				if (!child)
				{
					continue;
				}
			}
			GameObject gameObject = child.gameObject;
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			UnityEngine.Object obj11 = gameObject;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj11 = gameObject;
			}
			UnityEngine.Object.Destroy(obj11);
		}
		while (num > 0);
		return;
		IL_0091:
		bool flag4 = obj5;
		bool flag5 = !flag4;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			return;
		}
		goto IL_014e;
	}

	private void Start()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0178: Expected O, but got I
		//IL_01a2: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00c0: Expected O, but got I
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_010b: Expected I, but got O
		//IL_01eb: Expected O, but got I4
		//IL_013a: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6911]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
		object obj10 = (nint)0 + (nint)2584;
		object obj11 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		User localUser = sessionModel.LocalUser;
		string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj10);
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v28+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerProfilesHandler.RequestUserProfile(dbId, action);
	}

	public unsafe void Populate(PlayerProfileModel user)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0049: Expected O, but got I
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e3: Expected O, but got I
		//IL_0108: Expected O, but got I
		//IL_012a: Expected O, but got I4
		//IL_1843: Expected I, but got O
		//IL_1856: Unknown result type (might be due to invalid IL or missing references)
		//IL_185b: Expected O, but got Unknown
		//IL_1875: Expected I, but got O
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_017b: Expected O, but got I
		//IL_018b: Expected O, but got I
		//IL_01a6: Expected I, but got O
		//IL_01d0: Expected O, but got I4
		//IL_01d8: Expected I, but got O
		//IL_021b: Expected O, but got I
		//IL_0243: Expected I, but got O
		//IL_02e3: Expected O, but got I4
		//IL_0275: Expected O, but got I4
		//IL_027a: Expected I, but got O
		//IL_0315: Expected O, but got I
		//IL_0325: Expected I, but got O
		//IL_0374: Expected O, but got I4
		//IL_02b9: Expected I, but got O
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected O, but got Unknown
		//IL_03c5: Expected O, but got I4
		//IL_03e5: Expected O, but got I4
		//IL_04d1: Expected O, but got I
		//IL_04e1: Expected O, but got I
		//IL_0513: Expected I, but got O
		//IL_0535: Expected O, but got I4
		//IL_18bb: Expected O, but got I
		//IL_18db: Expected O, but got I
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected O, but got Unknown
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected O, but got Unknown
		//IL_045f: Expected I, but got O
		//IL_0481: Expected O, but got I4
		//IL_0664: Expected O, but got I
		//IL_0686: Expected O, but got I4
		//IL_058a: Expected I, but got O
		//IL_1908: Expected O, but got I
		//IL_1917: Unknown result type (might be due to invalid IL or missing references)
		//IL_191c: Expected O, but got Unknown
		//IL_1932: Expected O, but got I
		//IL_1943: Expected I, but got O
		//IL_1943: Expected O, but got I
		//IL_194b: Expected I, but got O
		//IL_1961: Expected O, but got I
		//IL_05af: Expected I, but got O
		//IL_05c4: Expected O, but got I
		//IL_05e2: Expected O, but got I4
		//IL_05eb: Expected O, but got I4
		//IL_06cb: Expected I, but got O
		//IL_06f4: Expected O, but got I4
		//IL_070a: Expected O, but got I4
		//IL_0712: Expected I, but got O
		//IL_071a: Expected O, but got I
		//IL_06ae: Expected I, but got O
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0754: Expected O, but got Unknown
		//IL_075c: Expected I, but got O
		//IL_076c: Expected O, but got I
		//IL_0822: Expected O, but got I
		//IL_0846: Expected O, but got I4
		//IL_085f: Expected O, but got I4
		//IL_0864: Expected I, but got O
		//IL_060f: Expected O, but got I4
		//IL_0617: Expected I, but got O
		//IL_062f: Expected O, but got I
		//IL_063f: Expected O, but got I
		//IL_0985: Unknown result type (might be due to invalid IL or missing references)
		//IL_098a: Expected O, but got Unknown
		//IL_0aad: Expected I, but got O
		//IL_0abd: Expected O, but got I
		//IL_088b: Expected O, but got I4
		//IL_08a0: Expected I, but got O
		//IL_1988: Expected O, but got I
		//IL_0b68: Expected I, but got O
		//IL_08c7: Expected O, but got I
		//IL_08d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d5: Expected O, but got Unknown
		//IL_08ed: Expected O, but got I
		//IL_091f: Expected O, but got I4
		//IL_0948: Expected O, but got I4
		//IL_0958: Expected O, but got I
		//IL_19e8: Expected I, but got O
		//IL_19f8: Expected O, but got I
		//IL_1a0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a10: Expected O, but got Unknown
		//IL_07cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d0: Expected O, but got Unknown
		//IL_10f2: Expected O, but got I4
		//IL_1103: Expected O, but got I4
		//IL_113c: Expected O, but got I4
		//IL_114d: Expected O, but got I4
		//IL_19bc: Expected O, but got I
		//IL_1b66: Expected O, but got I4
		//IL_0bbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc3: Expected I, but got Unknown
		//IL_0b7a: Expected O, but got I4
		//IL_0b8c: Expected O, but got I
		//IL_0b95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9a: Expected O, but got Unknown
		//IL_116a: Unknown result type (might be due to invalid IL or missing references)
		//IL_116f: Expected O, but got Unknown
		//IL_1177: Expected I, but got O
		//IL_1187: Expected O, but got I
		//IL_0b29: Expected O, but got I
		//IL_1222: Expected I, but got O
		//IL_12c2: Expected O, but got I
		//IL_1c08: Expected I, but got O
		//IL_1c18: Expected O, but got I
		//IL_0c01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c06: Expected O, but got Unknown
		//IL_12a0: Expected O, but got I4
		//IL_1bdc: Expected O, but got I
		//IL_1730: Expected O, but got I4
		//IL_1751: Expected O, but got I4
		//IL_1351: Unknown result type (might be due to invalid IL or missing references)
		//IL_1356: Expected O, but got Unknown
		//IL_1234: Expected O, but got I4
		//IL_1246: Expected O, but got I
		//IL_124f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1254: Expected O, but got Unknown
		//IL_0c44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c49: Expected O, but got Unknown
		//IL_0c51: Expected I, but got O
		//IL_0c61: Expected O, but got I
		//IL_11eb: Expected O, but got I
		//IL_0d0c: Expected I, but got O
		//IL_17c8: Expected O, but got I4
		//IL_1a74: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a79: Expected O, but got Unknown
		//IL_1aa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa9: Expected O, but got Unknown
		//IL_1ad3: Expected O, but got I4
		//IL_0d89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8e: Expected O, but got Unknown
		//IL_1a3d: Expected O, but got I
		//IL_0d1e: Expected O, but got I4
		//IL_0d30: Expected O, but got I
		//IL_0d39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3e: Expected O, but got Unknown
		//IL_0ccd: Expected O, but got I
		//IL_0dd7: Expected I, but got O
		//IL_0e04: Expected O, but got I
		//IL_0e13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e18: Expected O, but got Unknown
		//IL_0e8a: Expected O, but got I
		//IL_0eb6: Expected I, but got O
		//IL_1af5: Expected O, but got I
		//IL_1afd: Expected I, but got O
		//IL_1018: Expected O, but got I4
		//IL_1038: Expected O, but got I4
		//IL_09d7: Expected O, but got I
		//IL_0eee: Expected I, but got O
		//IL_0a29: Expected O, but got I4
		//IL_0a72: Expected O, but got I4
		//IL_1078: Unknown result type (might be due to invalid IL or missing references)
		//IL_107d: Expected O, but got Unknown
		//IL_1086: Unknown result type (might be due to invalid IL or missing references)
		//IL_108b: Expected O, but got Unknown
		//IL_0f25: Expected O, but got I
		//IL_0f3d: Expected I, but got O
		//IL_0f53: Expected I, but got O
		//IL_0f83: Expected O, but got I4
		//IL_0f88: Expected I, but got O
		//IL_0fa0: Expected O, but got I
		//IL_0fe1: Expected I, but got O
		//IL_0ffc: Expected I, but got O
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6912]");
		nint num = 0;
		List<object> list = (List<object>)(typeof(DebugUI.BitField) + 2280);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj = default(object);
		obj..ctor();
		bool flag = obj == null;
		PlayerProfileModel playerProfileModel = null;
		object obj2 = null;
		PlayerProfileModel playerProfileModel2 = user;
		List<object> list2 = default(List<object>);
		FeaturedSlotModel <featuredSlot>k__BackingField;
		UnityAction unityAction2 = default(UnityAction);
		ISelectable selectable2;
		nint num5;
		PlayerProfileModel <gameAchievements>k__BackingField;
		nint num4;
		UnityEvent unityEvent;
		object[] array;
		ISelectable selectable;
		object obj14;
		int num3;
		object obj12;
		nint num2;
		UnityEvent<object> unityEvent2;
		UnityAction unityAction;
		if (!flag)
		{
			object obj3 = typeof(List<AdaptivePerformanceScaler>) + 1600;
			object obj4 = (nint)0 + (nint)344;
			object obj5 = obj + 16;
			obj5 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			ClearLayout();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj2 = obj4;
			list2..ctor();
			bool flag2 = user == null;
			playerProfileModel = null;
			list = list2;
			playerProfileModel2 = user;
			if (!flag2)
			{
				object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj7 = (nint)0 + (nint)520;
				<featuredSlot>k__BackingField = user.<featuredSlot>k__BackingField;
				object obj8 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v20+E4]");
				array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v20+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					unityAction = (UnityAction)(object)layout;
					unityEvent = (UnityEvent)(object)emptyItemPrefab;
				}
				num2 = (nint)obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
				object obj10 = obj + 24;
				object obj11 = default(object);
				obj10 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				num = (nint)obj10;
				bool flag4 = obj10 == null;
				playerProfileModel = null;
				obj2 = obj11;
				list = list2;
				playerProfileModel2 = user;
				if (!flag4)
				{
					array = (object[])(typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408);
					unityEvent2 = (UnityEvent<object>)((nint)0 + (nint)3752);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v4 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+30]");
					unityEvent = (UnityEvent)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					unityAction2..ctor(obj, (IntPtr)unityEvent2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v4 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+30]");
					bool flag5 = (nint)0 == 0;
					playerProfileModel = null;
					obj12 = 0;
					num2 = (nint)unityEvent2;
					unityAction = unityAction2;
					obj2 = obj;
					list = list2;
					playerProfileModel2 = user;
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v4 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+30]");
						((UnityEvent)0).AddListener(unityAction2);
						bool flag6 = user.<featuredSlot>k__BackingField == null;
						bool flag7 = !flag6;
						num2 = unchecked((nint)null);
						obj2 = null;
						if (!flag7)
						{
							bool flag8 = selectionManager == null;
							playerProfileModel = null;
							obj12 = 0;
							num2 = unchecked((nint)null);
							unityAction = unityAction2;
							obj2 = null;
							list = list2;
							playerProfileModel2 = user;
							if (flag8)
							{
								goto IL_16b6;
							}
							selectionManager.SetSelected((ISelectable)obj10);
							num2 = unchecked((nint)null);
							obj2 = obj10;
						}
						bool flag9 = list2 == null;
						playerProfileModel = null;
						obj12 = 0;
						unityAction = unityAction2;
						list = list2;
						playerProfileModel2 = user;
						if (!flag9)
						{
							object obj13 = (nint)0 + (nint)352;
							obj2 = obj10;
							num = (nint)obj13;
							int version = list2._version + 1;
							list2._version = version;
							array = list2._items;
							bool flag10 = list2._items == null;
							playerProfileModel = null;
							obj12 = 0;
							unityAction = unityAction2;
							list = list2;
							playerProfileModel2 = user;
							if (!flag10)
							{
								unityEvent2 = (UnityEvent<object>)(typeof(DebugUI.BitField) + 2272);
								num3 = list2._size;
								obj14 = array.Length;
								bool flag11 = list2._size < array.Length;
								object obj15 = !flag11;
								if (obj15 == null)
								{
									int size = list2._size + 1;
									list2._size = size;
									object obj16 = list2._items + list2._size;
									object obj17 = obj16 + 32;
									obj17 = obj10;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									playerProfileModel2 = (PlayerProfileModel)(object)user.<gameAchievements>k__BackingField;
									num4 = (nint)unityEvent2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X0_v50 (Il2CppClass<UnityEngine.Events.UnityEvent`1<System.Object>>)+E4]");
									bool flag12 = (nint)0 == 0;
									object obj18 = !flag12;
									selectable = (ISelectable)obj10;
									if (obj18 == null)
									{
										selectable2 = (ISelectable)obj10;
										num5 = num2;
										nint num6 = num4;
										<gameAchievements>k__BackingField = (PlayerProfileModel)(object)user.<gameAchievements>k__BackingField;
										goto IL_0578;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v4 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+20]");
									object obj19 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X8_v84+C0]");
									object obj20 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X8_v85+70]");
									num5 = 0;
									list2.AddWithResize(obj10);
									<gameAchievements>k__BackingField = (PlayerProfileModel)(object)user.<gameAchievements>k__BackingField;
									nint num6 = (nint)unityEvent2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X0_v119 (Il2CppClass<UnityEngine.Events.UnityEvent`1<System.Object>>)+E4]");
									bool flag13 = (nint)0 == 0;
									object obj21 = !flag13;
									selectable2 = (ISelectable)obj10;
									selectable = (ISelectable)obj10;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X8_v85+70]");
									num2 = 0;
									num4 = num6;
									playerProfileModel2 = (PlayerProfileModel)(object)user.<gameAchievements>k__BackingField;
									if (obj21 == null)
									{
										goto IL_0578;
									}
								}
								goto IL_18af;
							}
						}
					}
				}
			}
		}
		goto IL_16b6;
		IL_1213:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		nint num7 = unchecked((nint)null);
		goto IL_1c00;
		IL_0800:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj22 = default(object);
		array = (object[])obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X0_v104+8]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v853 @ X0_v104] (should have been resolved before IL gen)");
		PlayerProfileModel playerProfileModel3 = default(PlayerProfileModel);
		bool flag14 = playerProfileModel3 == null;
		object obj23 = !flag14;
		playerProfileModel = playerProfileModel3;
		nint num8 = (nint)(&playerProfileModel);
		object obj24 = 0;
		num7 = unchecked((nint)null);
		if (obj23 != null)
		{
			goto IL_0976;
		}
		playerProfileModel = playerProfileModel3;
		nint num9 = (nint)(&playerProfileModel);
		obj24 = 0;
		object obj25 = obj14;
		int num10 = num3;
		num2 = unchecked((nint)null);
		num = (nint)(&playerProfileModel);
		IEnumerable<object> enumerable;
		playerProfileModel2 = (PlayerProfileModel)enumerable;
		goto IL_13fc;
		IL_18af:
		object obj26 = (nint)0 + (nint)3848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X0_v50 (Il2CppClass<UnityEngine.Events.UnityEvent`1<System.Object>>)+B8]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v26 (Il2CppStaticFields<UnityEngine.Events.UnityEvent`1<System.Object>>)+8]");
		Func<object, bool> func = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v26 (Il2CppStaticFields<UnityEngine.Events.UnityEvent`1<System.Object>>)+8]");
		object obj28;
		UnityAction unityAction3;
		if ((nint)0 != 0)
		{
			num7 = (nint)obj26;
			PlayerProfileModel source = playerProfileModel2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v26 (Il2CppStaticFields<UnityEngine.Events.UnityEvent`1<System.Object>>)+8]");
			enumerable = Enumerable.Where((IEnumerable<object>)source, (Func<object, bool>)0);
			bool flag15 = enumerable == null;
			object obj27 = !flag15;
			obj28 = 0;
			unityAction3 = unityAction2;
			if (obj27 != null)
			{
				goto IL_0740;
			}
			playerProfileModel = null;
			obj12 = 0;
			num2 = (nint)obj26;
			unityAction = unityAction2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v26 (Il2CppStaticFields<UnityEngine.Events.UnityEvent`1<System.Object>>)+8]");
			unityEvent = (UnityEvent)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v26 (Il2CppStaticFields<UnityEngine.Events.UnityEvent`1<System.Object>>)+8]");
			obj2 = 0;
			list = list2;
			num = num11;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X0_v50 (Il2CppClass<UnityEngine.Events.UnityEvent`1<System.Object>>)+E4]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X0_v50 (Il2CppClass<UnityEngine.Events.UnityEvent`1<System.Object>>)+E4]");
			bool flag16 = (nint)0 == 0;
			object obj29 = !flag16;
			nint num12 = num11;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				nint num13 = (nint)unityEvent2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X8_v81 (Il2CppClass<UnityEngine.Events.UnityEvent`1<System.Object>>)+B8]");
				num12 = 0;
			}
			unityAction3 = (UnityAction)num12;
			object obj30 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 80;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj31 = (nint)0 + (nint)3744;
			Func<object, bool> func2 = default(Func<object, bool>);
			func2..ctor((object)num12, (IntPtr)obj31);
			num = (nint)unityEvent2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v4 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+B8]");
			object obj32 = (nint)0 + (nint)8;
			obj32 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			num7 = (nint)obj26;
			enumerable = Enumerable.Where((IEnumerable<object>)playerProfileModel2, func2);
			bool flag17 = enumerable == null;
			obj28 = 0;
			func = func2;
			playerProfileModel = null;
			obj12 = 0;
			num2 = (nint)obj26;
			unityAction = (UnityAction)num12;
			unityEvent = (UnityEvent)(object)func2;
			obj2 = func2;
			list = list2;
			if (!flag17)
			{
				goto IL_0740;
			}
		}
		goto IL_16b6;
		IL_0578:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		num4 = (nint)unityEvent2;
		selectable = selectable2;
		num2 = num5;
		playerProfileModel2 = <gameAchievements>k__BackingField;
		goto IL_18af;
		IL_115b:
		object obj33 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		PlayerProfileModel playerProfileModel4;
		nint num14 = (nint)playerProfileModel4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v14 (Il2CppClass<PlayerProfileModel>)+12E]");
		array = (object[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v14 (Il2CppClass<PlayerProfileModel>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_1213;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v14 (Il2CppClass<PlayerProfileModel>)+B0]");
		int num15 = (int)((nint)0 + (nint)8);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X10_v11 (System.Int32)-8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X10_v11 (System.Int32)-8]");
			if (0 == (nint)obj33)
			{
				break;
			}
			num3 = num15 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v14 (Il2CppClass<PlayerProfileModel>)+12E]");
			array = (object[])(-1);
			bool flag18 = (nint)array != 1;
			num15 = num3;
			if (flag18)
			{
				continue;
			}
			goto IL_1213;
		}
		array = (object[])((int*)num15)->m_value;
		object obj34 = num14 + ((int*)num15)->m_value;
		object obj35 = obj34 + 312;
		num3 = num15;
		num7 = num2;
		goto IL_1c00;
		IL_1c00:
		num = (nint)obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X0_v27+8]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v720 @ X0_v27] (should have been resolved before IL gen)");
		UnityAction<object> unityAction5 = default(UnityAction<object>);
		UnityAction<object> unityAction4 = unityAction5;
		num8 = num9;
		ISelectable selectable3 = selectable;
		object obj36 = obj14;
		int num16 = num3;
		object obj37 = obj12;
		UnityEvent<object> unityEvent3 = unityEvent2;
		UnityAction unityAction6 = unityAction;
		Func<object, bool> func3;
		unityEvent = (UnityEvent)(object)func3;
		object obj39;
		object obj38 = obj39;
		List<object> list3 = list;
		object obj41;
		object obj40 = obj41;
		PlayerProfileModel playerProfileModel5 = playerProfileModel2;
		goto IL_1b4c;
		IL_0976:
		object obj42 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		unityAction4 = unityAction5;
		selectable3 = selectable;
		obj12 = obj28;
		unityEvent3 = unityEvent2;
		unityAction = unityAction3;
		func3 = func;
		playerProfileModel5 = playerProfileModel3;
		bool flag20 = default(bool);
		object obj44 = default(object);
		object obj46 = default(object);
		object obj47 = default(object);
		object obj52 = default(object);
		object obj56 = default(object);
		UnityAction<object> unityAction7 = default(UnityAction<object>);
		while (true)
		{
			nint num17 = (nint)playerProfileModel5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X8_v34 (Il2CppClass<PlayerProfileModel>)+12E]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X8_v34 (Il2CppClass<PlayerProfileModel>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0b59;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X8_v34 (Il2CppClass<PlayerProfileModel>)+B0]");
			int num18 = (int)((nint)0 + (nint)8);
			bool flag19 = flag20;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v999 @ X10_v28 (System.Int32)-8]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v999 @ X10_v28 (System.Int32)-8]");
				if (0 == (nint)obj42)
				{
					break;
				}
				num3 = num18 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X8_v34 (Il2CppClass<PlayerProfileModel>)+12E]");
				array = (object[])(-1);
				flag20 = (nint)array != 1;
				flag19 = flag20;
				num18 = num3;
				if (flag20)
				{
					continue;
				}
				goto IL_0b59;
			}
			array = (object[])((int*)num18)->m_value;
			object obj43 = num17 + ((int*)num18)->m_value;
			obj44 = obj43 + 312;
			flag20 = flag19;
			num3 = num18;
			goto IL_19e0;
			IL_19e0:
			num = (nint)obj44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1014 @ X0_v56+8]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1014 @ X0_v56] (should have been resolved before IL gen)");
			object obj45 = obj46 & 1;
			if (obj45 == null)
			{
				break;
			}
			num = (nint)(typeof(DebugUI.BitField) + 2288);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj47..ctor();
			if (obj47 != null)
			{
				object obj48 = obj47 + 32;
				obj48 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if (playerProfileModel != null)
				{
					object obj49 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1312;
					nint num19 = (nint)playerProfileModel;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1028 @ X8_v41 (Il2CppClass<UnityEngine.Events.UnityEvent>)+12E]");
					array = (object[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1028 @ X8_v41 (Il2CppClass<UnityEngine.Events.UnityEvent>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0cfd;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1028 @ X8_v41 (Il2CppClass<UnityEngine.Events.UnityEvent>)+B0]");
					int num20 = (int)((nint)0 + (nint)8);
					bool flag21 = flag20;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1070 @ X10_v23 (System.Int32)-8]");
						obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1070 @ X10_v23 (System.Int32)-8]");
						if (0 == (nint)obj49)
						{
							break;
						}
						num3 = num20 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1028 @ X8_v41 (Il2CppClass<UnityEngine.Events.UnityEvent>)+12E]");
						array = (object[])(-1);
						flag20 = (nint)array != 1;
						flag21 = flag20;
						num20 = num3;
						if (flag20)
						{
							continue;
						}
						goto IL_0cfd;
					}
					array = (object[])((int*)num20)->m_value;
					object obj50 = num19 + ((int*)num20)->m_value;
					object obj51 = obj50 + 312;
					flag20 = flag21;
					num3 = num20;
					goto IL_1a61;
				}
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
			IL_0cfd:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num7 = unchecked((nint)null);
			goto IL_1a61;
			IL_1a61:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1086 @ X0_v66] (should have been resolved before IL gen)");
			func3 = (Func<object, bool>)(obj47 + 16);
			func3 = (Func<object, bool>)obj52;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			unityEvent2 = (UnityEvent<object>)(object)layout;
			object obj53 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj54 = obj53;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1099 @ X0_v71+E4]");
			bool flag22 = (nint)0 == 0;
			object obj55 = !flag22;
			if (obj55 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			num = (nint)0 + (nint)448;
			num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
			unityAction = (UnityAction)(obj47 + 24);
			unityAction = (UnityAction)obj56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (unityAction != null)
			{
				((Achievement)(object)unityAction).Initialize((UserAchievementModel)(object)func3);
				nint num21 = (nint)unityAction;
				if (unityAction != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v49 (Il2CppClass<UnityEngine.Events.UnityAction>)+118]");
					unityEvent2 = (UnityEvent<object>)0;
					object obj57 = typeof(TypeConverter<ushort, char>) + 392;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					num = (nint)0 + (nint)3760;
					unityAction7..ctor(obj47, (IntPtr)num);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v49 (Il2CppClass<UnityEngine.Events.UnityAction>)+118]");
					if ((nint)0 != 0)
					{
						num = (nint)0 + (nint)904;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v49 (Il2CppClass<UnityEngine.Events.UnityAction>)+118]");
						((UnityEvent<object>)0).AddListener(unityAction7);
						bool flag23 = user.<featuredSlot>k__BackingField != null;
						bool flag24 = !flag23;
						num2 = unchecked((nint)null);
						if (!flag24)
						{
							if ((object)user.<featuredSlot>k__BackingField == null)
							{
								throw new NullReferenceException();
							}
							nint num22 = (nint)func3;
							if (func3 == null)
							{
								throw new NullReferenceException();
							}
							string <id>k__BackingField = <featuredSlot>k__BackingField.<id>k__BackingField;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v64 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+10]");
							bool flag25 = <id>k__BackingField == (string)0;
							bool flag26 = !flag25;
							num2 = unchecked((nint)null);
							if (!flag26)
							{
								num = (nint)func3;
								bool flag27 = func3 == null;
								unityAction5 = unityAction7;
								num9 = num8;
								selectable = selectable3;
								obj12 = 0;
								num2 = unchecked((nint)null);
								unityEvent = (UnityEvent)(object)func3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v64 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+10]");
								obj2 = 0;
								list = list2;
								playerProfileModel2 = (PlayerProfileModel)obj47;
								if (flag27)
								{
									goto IL_16c4;
								}
								int <levelId>k__BackingField = <featuredSlot>k__BackingField.<levelId>k__BackingField;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v4 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+1C]");
								flag20 = (nint)<levelId>k__BackingField != 0;
								num2 = unchecked((nint)null);
								if (!flag20)
								{
									selectable3 = (ISelectable)(object)unityAction;
									num2 = unchecked((nint)null);
								}
							}
						}
						obj2 = unityAction;
						object obj58 = (nint)0 + (nint)352;
						num = (nint)obj58;
						int version2 = list2._version + 1;
						list2._version = version2;
						object[] items = list2._items;
						if (list2._items != null)
						{
							num3 = list2._size;
							obj14 = items.Length;
							bool flag28 = list2._size < items.Length;
							object obj59 = !flag28;
							if (obj59 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v4 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+20]");
								object obj60 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1155 @ X8_v62+C0]");
								num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v4 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+70]");
								num2 = 0;
								list2.AddWithResize((object)unityAction);
							}
							else
							{
								int num23 = ++list2._size;
								object obj61 = list2._items + list2._size;
								object obj62 = obj61 + 32;
								obj62 = unityAction;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								num = num23;
							}
							bool flag29 = playerProfileModel == null;
							unityAction4 = unityAction7;
							obj12 = 0;
							num7 = num2;
							unityEvent3 = unityEvent2;
							playerProfileModel5 = playerProfileModel;
							unityAction5 = unityAction7;
							num9 = num8;
							selectable = selectable3;
							obj25 = obj14;
							num10 = num3;
							obj28 = 0;
							unityAction3 = unityAction;
							func = func3;
							array = list2._items;
							playerProfileModel2 = playerProfileModel;
							if (!flag29)
							{
								continue;
							}
							goto IL_13fc;
						}
						throw new NullReferenceException();
					}
					throw new NullReferenceException();
				}
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
			IL_0b59:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num7 = unchecked((nint)null);
			goto IL_19e0;
		}
		bool flag30 = playerProfileModel == null;
		unityAction5 = unityAction4;
		num9 = num8;
		selectable = selectable3;
		num2 = num7;
		unityEvent2 = unityEvent3;
		playerProfileModel4 = playerProfileModel;
		obj39 = 0;
		list = list2;
		obj41 = 7;
		playerProfileModel2 = playerProfileModel5;
		obj36 = obj14;
		num16 = num3;
		obj37 = obj12;
		unityAction6 = unityAction;
		unityEvent = (UnityEvent)(object)func3;
		obj38 = 0;
		list3 = list2;
		obj40 = 7;
		if (!flag30)
		{
			goto IL_115b;
		}
		goto IL_1b4c;
		IL_0740:
		object obj63 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3848;
		nint num24 = (nint)enumerable;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v817 @ X8_v30 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
		object obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v817 @ X8_v30 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0800;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v817 @ X8_v30 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
		num10 = (int)((nint)0 + (nint)8);
		bool flag31 = flag20;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X10_v14 (System.Int32)-8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X10_v14 (System.Int32)-8]");
			if (0 == (nint)obj63)
			{
				break;
			}
			num3 = num10 + 16;
			obj64--;
			flag20 = (nint)obj64 != 1;
			flag31 = flag20;
			num10 = num3;
			if (flag20)
			{
				continue;
			}
			goto IL_0800;
		}
		object obj65 = num24 + ((int*)num10)->m_value;
		object obj66 = obj65 + 312;
		array = (object[])obj66;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v894 @ X8_v73+8]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v894 @ X8_v73] (should have been resolved before IL gen)");
		bool flag32 = playerProfileModel3 == null;
		playerProfileModel = playerProfileModel3;
		num8 = (nint)(&playerProfileModel);
		obj24 = 0;
		flag20 = flag31;
		num3 = num10;
		playerProfileModel = playerProfileModel3;
		num9 = (nint)(&playerProfileModel);
		obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X10_v14 (System.Int32)-8]");
		obj25 = 0;
		num2 = num7;
		num = (nint)(&playerProfileModel);
		if (!flag32)
		{
			goto IL_0976;
		}
		goto IL_13fc;
		IL_16b6:
		NullReferenceException ex = new NullReferenceException();
		goto IL_16c4;
		IL_1b4c:
		object obj68 = default(object);
		while (true)
		{
			bool flag33 = obj38 == null;
			object obj67 = !flag33;
			unityAction5 = unityAction4;
			num9 = num8;
			selectable = selectable3;
			obj14 = obj36;
			num3 = num16;
			obj12 = obj37;
			num2 = num7;
			unityEvent2 = unityEvent3;
			unityAction = unityAction6;
			list = list3;
			playerProfileModel2 = playerProfileModel5;
			if (obj67 == null)
			{
				break;
			}
			OutOfMemoryException ex2 = new OutOfMemoryException();
			if ((nint)obj2 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj39 = obj68;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				bool flag34 = playerProfileModel == null;
				object obj69 = !flag34;
				obj24 = obj68;
				func3 = (Func<object, bool>)(object)unityEvent;
				playerProfileModel4 = playerProfileModel;
				obj41 = 0;
				if (obj69 == null)
				{
					unityAction4 = unityAction5;
					num8 = num9;
					obj24 = obj68;
					selectable3 = selectable;
					obj36 = obj14;
					num16 = num3;
					obj37 = obj12;
					num7 = num2;
					unityEvent3 = unityEvent2;
					unityAction6 = unityAction;
					obj38 = obj68;
					list3 = list;
					obj40 = 0;
					playerProfileModel5 = playerProfileModel2;
					continue;
				}
				goto IL_115b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
		}
		if ((nint)obj40 != 7)
		{
			bool flag35 = obj40 == null;
			object obj70 = !flag35;
			if (obj70 != null)
			{
				return;
			}
		}
		num = (nint)0 + (nint)360;
		obj2 = num;
		object[] array2 = list3.ToArray();
		bool flag36 = selectionManager == null;
		unityAction5 = unityAction4;
		num9 = num8;
		selectable = selectable3;
		obj14 = obj36;
		num3 = num16;
		obj12 = obj37;
		num2 = num7;
		unityEvent2 = unityEvent3;
		unityAction = unityAction6;
		list = list3;
		playerProfileModel2 = playerProfileModel5;
		if (!flag36)
		{
			object obj71 = selectionManager + 16;
			obj71 = array2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag37 = selectionManager == null;
			unityAction5 = unityAction4;
			num9 = num8;
			selectable = selectable3;
			obj14 = obj36;
			num3 = num16;
			obj12 = obj37;
			num2 = num7;
			unityEvent2 = unityEvent3;
			unityAction = unityAction6;
			obj2 = array2;
			list = list3;
			playerProfileModel2 = playerProfileModel5;
			if (!flag37)
			{
				selectionManager.SetSelected(selectable3);
				return;
			}
		}
		goto IL_16b6;
		IL_16c4:
		throw new NullReferenceException();
		IL_13fc:
		throw new NullReferenceException();
	}

	private void EquipAchievement(UserAchievementModel achievement, ISelectable selectable)
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
		//IL_0096: Expected I, but got O
		object obj = typeof(DebugUI.BitField) + 2296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj4 = (nint)0 + (nint)3768;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 24;
		obj6 = selectable;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		KammelnaRequests.SetFeaturedSlotRequest(achievement, action);
	}

	private void UnequipItem(ISelectable selectable)
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
		//IL_0096: Expected I, but got O
		object obj = typeof(DebugUI.BitField) + 2304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj4 = (nint)0 + (nint)3776;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 24;
		obj6 = selectable;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		KammelnaRequests.ResetFeaturedSlot(action);
	}

	public FeaturedSlotPicker()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 3384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SelectableItemsList selectableItemsList = default(SelectableItemsList);
		selectableItemsList..ctor();
		object obj2 = this + 56;
		obj2 = selectableItemsList;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
