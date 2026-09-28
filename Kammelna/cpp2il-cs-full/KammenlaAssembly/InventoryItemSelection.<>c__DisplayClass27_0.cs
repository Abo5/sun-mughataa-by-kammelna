using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DataTracking;
using Features.GameReplay;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Purchasing.Telemetry;

public class InventoryItemSelection : MonoBehaviour
{
	private enum InventoryType
	{
		CardBack,
		RoomTheme,
		Pattern
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<InventoryItem, bool> <>9__15_0;

		public static Func<InventoryItem, bool> <>9__18_0;

		public static Func<InventoryItem, bool> <>9__18_1;

		public static Func<StoreOwnedItem, bool> <>9__24_0;

		public static Func<InventoryItem, bool> <>9__24_1;

		public static Func<InventoryItem, GameObject> <>9__24_2;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 4072;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <get_defaultItem>b__15_0(InventoryItem i)
		{
			//IL_0035: Expected I4, but got O
			if ((object)i != null)
			{
				return i.<isDefaultItem>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <get_activeItem>b__18_0(InventoryItem i)
		{
			//IL_01e9: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_017c: Expected O, but got I
			//IL_01a6: Expected O, but got I4
			//IL_01af: Expected O, but got I4
			//IL_0054: Expected O, but got I
			//IL_007f: Expected O, but got I
			//IL_00a9: Expected O, but got I4
			//IL_01cd: Expected I4, but got O
			//IL_01d6: Expected O, but got I4
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Expected O, but got Unknown
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Expected I4, but got Unknown
			object obj3;
			int? num2;
			int? num3;
			object obj6;
			if ((object)i != null)
			{
				object obj = typeof(Queue<string>) + 848;
				StoreOwnedItem <OwnedItem>k__BackingField = i.<OwnedItem>k__BackingField;
				if (i.<OwnedItem>k__BackingField != null)
				{
					object obj2 = (nint)0 + (nint)3136;
					int <itemId>k__BackingField = <OwnedItem>k__BackingField.<itemId>k__BackingField;
					int? num = <OwnedItem>k__BackingField.<itemId>k__BackingField;
					obj3 = (nint)0 + (nint)2200;
					object obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v11+E4]");
					bool flag = (nint)0 == 0;
					object obj5 = !flag;
					num2 = num;
					obj6 = obj3;
					num3 = num;
					if (obj5 == null)
					{
						goto IL_00cf;
					}
				}
				else
				{
					obj6 = (nint)0 + (nint)2200;
					object obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v11+E4]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					num3 = (int?)(object)0;
					if (obj7 == null)
					{
						obj3 = obj6;
						int <itemId>k__BackingField = (int)i;
						num2 = (int?)(object)0;
						goto IL_00cf;
					}
				}
				goto IL_00ee;
			}
			goto IL_01db;
			IL_00cf:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj3;
			num3 = num2;
			goto IL_00ee;
			IL_00ee:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			if ((object)sessionModel != null)
			{
				object obj8 = (object?)num3 >> 32;
				User localUser = sessionModel.LocalUser;
				int activeCardbackID = SFSKammelnaUserExtensions.GetActiveCardbackID(localUser);
				object obj9 = activeCardbackID - obj8;
				bool flag3 = obj9 == null;
				return (byte)((flag3 & (??)num3) ? 1 : 0) != 0;
			}
			goto IL_01db;
			IL_01db:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <get_activeItem>b__18_1(InventoryItem i)
		{
			//IL_01e9: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_017c: Expected O, but got I
			//IL_01a6: Expected O, but got I4
			//IL_01af: Expected O, but got I4
			//IL_0054: Expected O, but got I
			//IL_007f: Expected O, but got I
			//IL_00a9: Expected O, but got I4
			//IL_01cd: Expected I4, but got O
			//IL_01d6: Expected O, but got I4
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Expected O, but got Unknown
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Expected I4, but got Unknown
			object obj3;
			int? num2;
			int? num3;
			object obj6;
			if ((object)i != null)
			{
				object obj = typeof(Queue<string>) + 848;
				StoreOwnedItem <OwnedItem>k__BackingField = i.<OwnedItem>k__BackingField;
				if (i.<OwnedItem>k__BackingField != null)
				{
					object obj2 = (nint)0 + (nint)3136;
					int <itemId>k__BackingField = <OwnedItem>k__BackingField.<itemId>k__BackingField;
					int? num = <OwnedItem>k__BackingField.<itemId>k__BackingField;
					obj3 = (nint)0 + (nint)2200;
					object obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v11+E4]");
					bool flag = (nint)0 == 0;
					object obj5 = !flag;
					num2 = num;
					obj6 = obj3;
					num3 = num;
					if (obj5 == null)
					{
						goto IL_00cf;
					}
				}
				else
				{
					obj6 = (nint)0 + (nint)2200;
					object obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v11+E4]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					num3 = (int?)(object)0;
					if (obj7 == null)
					{
						obj3 = obj6;
						int <itemId>k__BackingField = (int)i;
						num2 = (int?)(object)0;
						goto IL_00cf;
					}
				}
				goto IL_00ee;
			}
			goto IL_01db;
			IL_00cf:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj3;
			num3 = num2;
			goto IL_00ee;
			IL_00ee:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			if ((object)sessionModel != null)
			{
				object obj8 = (object?)num3 >> 32;
				User localUser = sessionModel.LocalUser;
				int activeRoomThemeID = SFSKammelnaUserExtensions.GetActiveRoomThemeID(localUser);
				object obj9 = activeRoomThemeID - obj8;
				bool flag3 = obj9 == null;
				return (byte)((flag3 & (??)num3) ? 1 : 0) != 0;
			}
			goto IL_01db;
			IL_01db:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <PopulateItems>b__24_0(StoreOwnedItem i)
		{
			//IL_00b4: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			if (i != null)
			{
				object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				StoreItem storeItem = Store.GetStoreItem(i.<itemId>k__BackingField);
				if (storeItem != null)
				{
					return GamesFlagExtensions.MatchesCurrentGame(storeItem.<targetGames>k__BackingField);
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <PopulateItems>b__24_1(InventoryItem i)
		{
			//IL_0035: Expected I4, but got O
			if ((object)i != null)
			{
				return i._isHighlighted;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal GameObject <PopulateItems>b__24_2(InventoryItem c)
		{
			if ((object)c != null)
			{
				return c.gameObject;
			}
			return (GameObject)(object)new NullReferenceException();
		}
	}

	private sealed class <>c__DisplayClass25_0
	{
		public InventoryItemSelection <>4__this;

		public StoreOwnedItem ownedItem;

		internal void <SendActivation>b__0(KammelnaResponseModel<bool> response)
		{
			bool succeeded = response.Succeeded;
			<>4__this.FinalizeAll(succeeded, ownedItem);
		}
	}

	private sealed class <>c__DisplayClass27_0
	{
		public StoreOwnedItem ownedItem;

		internal bool <FinalizeAll>b__0(InventoryItem i)
		{
			//IL_0117: Expected I4, but got O
			//IL_00da: Expected O, but got I4
			//IL_00e3: Expected O, but got I4
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Expected O, but got Unknown
			//IL_0104: Expected O, but got I4
			int? num;
			int? num3;
			int? num4;
			int? num5;
			if ((object)i != null)
			{
				StoreOwnedItem <OwnedItem>k__BackingField = i.<OwnedItem>k__BackingField;
				if (i.<OwnedItem>k__BackingField != null)
				{
					num = <OwnedItem>k__BackingField.<id>k__BackingField;
					int? num2 = (int?)ownedItem;
					bool flag = ownedItem == null;
					num3 = num;
					num4 = (int?)ownedItem;
					num5 = num;
					if (!flag)
					{
						goto IL_008a;
					}
				}
				else
				{
					int? num2 = (int?)ownedItem;
					bool flag2 = ownedItem == null;
					object obj = !flag2;
					num3 = (int?)(object)0;
					if (obj != null)
					{
						goto IL_008a;
					}
					num4 = (int?)ownedItem;
					num5 = (int?)(object)0;
				}
				goto IL_0134;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0134:
			object obj2 = (object?)num4 ^ (object?)num5;
			object obj3 = obj2 & -4294967295L;
			return obj3 == null;
			IL_008a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v7 (System.Nullable`1<System.Int32>)+10]");
			num = 0;
			num4 = num;
			num5 = num3;
			goto IL_0134;
		}

		internal bool <FinalizeAll>b__1(InventoryItem i)
		{
			//IL_0117: Expected I4, but got O
			//IL_00da: Expected O, but got I4
			//IL_00e3: Expected O, but got I4
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Expected O, but got Unknown
			//IL_0104: Expected O, but got I4
			int? num;
			int? num3;
			int? num4;
			int? num5;
			if ((object)i != null)
			{
				StoreOwnedItem <OwnedItem>k__BackingField = i.<OwnedItem>k__BackingField;
				if (i.<OwnedItem>k__BackingField != null)
				{
					num = <OwnedItem>k__BackingField.<id>k__BackingField;
					int? num2 = (int?)ownedItem;
					bool flag = ownedItem == null;
					num3 = num;
					num4 = (int?)ownedItem;
					num5 = num;
					if (!flag)
					{
						goto IL_008a;
					}
				}
				else
				{
					int? num2 = (int?)ownedItem;
					bool flag2 = ownedItem == null;
					object obj = !flag2;
					num3 = (int?)(object)0;
					if (obj != null)
					{
						goto IL_008a;
					}
					num4 = (int?)ownedItem;
					num5 = (int?)(object)0;
				}
				goto IL_0134;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0134:
			object obj2 = (object?)num4 ^ (object?)num5;
			object obj3 = obj2 & -4294967295L;
			return obj3 == null;
			IL_008a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v7 (System.Nullable`1<System.Int32>)+10]");
			num = 0;
			num4 = num;
			num5 = num3;
			goto IL_0134;
		}
	}

	public InventoryItem DefaultItemPrefab;

	public InventoryItem DefaultItem;

	public UIPicker uiPicker;

	public GameObject ItemsParent;

	private TextMeshProUGUI itemCountLabel;

	private StoreSoundAlbum soundAlbum;

	private List<InventoryItem> InventoryItems;

	private InventoryItem _activeItem;

	private string countLabelText
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_00db: Expected O, but got I
			//IL_00f5: Expected O, but got I4
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected O, but got Unknown
			//IL_00a4: Expected O, but got I4
			//IL_0052: Expected O, but got I
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Expected O, but got Unknown
			//IL_016d: Expected I, but got O
			//IL_0196: Expected O, but got I4
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Expected O, but got Unknown
			//IL_01d2: Expected O, but got I
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e1: Expected O, but got Unknown
			object obj = 152993792;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CCD]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CCE]");
				object obj3 = (nint)0 & (nint)1;
				if (obj3 != null)
				{
					goto IL_006f;
				}
			}
			else
			{
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CCE]");
				object obj4 = (nint)0 & (nint)1;
				bool flag = obj4 == null;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_006f;
				}
			}
			_ = 1;
			object obj6 = "Network Authentication Required" + 1296;
			InventoryItem inventoryItem = DefaultItem;
			bool flag2 = (object)DefaultItem == null;
			object obj7 = obj6;
			if (flag2)
			{
				goto IL_00ba;
			}
			goto IL_0149;
			IL_00ba:
			return (string)obj6;
			IL_0149:
			object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 368;
			object obj9 = obj8;
			nint num = (nint)inventoryItem;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X10_v2 (Il2CppClass<InventoryItem>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X9_v3+130]");
			bool flag3 = num2 < 0;
			object obj10 = !flag3;
			object obj11 = ~obj10;
			obj6 = obj7;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X10_v2 (Il2CppClass<InventoryItem>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X9_v3+130]");
				object obj12 = num3 + 0;
				object obj13 = "Network Authentication Required" + 1288;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X10_v4-8]");
				if (0 == (nint)obj9)
				{
					obj7 = obj13;
				}
				return (string)obj7;
			}
			goto IL_00ba;
			IL_006f:
			obj6 = "Network Authentication Required" + 1296;
			inventoryItem = DefaultItem;
			bool flag4 = (object)DefaultItem == null;
			object obj14 = !flag4;
			obj7 = obj6;
			if (obj14 == null)
			{
				goto IL_00ba;
			}
			goto IL_0149;
		}
	}

	private InventoryType inventoryType
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0083: Expected O, but got I
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Expected O, but got Unknown
			InventoryItem inventoryItem = DefaultItem;
			if ((object)DefaultItem != null)
			{
				object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 368;
				object obj2 = obj;
				nint num = (nint)inventoryItem;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X9_v3 (Il2CppClass<InventoryItem>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v6+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				if (obj3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X9_v3 (Il2CppClass<InventoryItem>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v6+130]");
					object obj4 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X9_v5-8]");
					object obj5 = 0 - obj2;
					bool flag2 = obj5 == null;
					return (!flag2) ? InventoryType.RoomTheme : InventoryType.CardBack;
				}
			}
			return InventoryType.RoomTheme;
		}
	}

	private ItemCategory ItemCategory
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0083: Expected O, but got I
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Expected O, but got Unknown
			//IL_00b2: Expected O, but got I4
			InventoryItem inventoryItem = DefaultItem;
			if ((object)DefaultItem != null)
			{
				object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 368;
				object obj2 = obj;
				nint num = (nint)inventoryItem;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X9_v3 (Il2CppClass<InventoryItem>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v6+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				if (obj3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X9_v3 (Il2CppClass<InventoryItem>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v6+130]");
					object obj4 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X9_v5-8]");
					object obj5 = 0 - obj2;
					bool flag2 = obj5 == null;
					object obj6 = !flag2;
					object obj7 = ~obj6;
					if (obj7 == null)
					{
						return ItemCategory.Rooms;
					}
					return ItemCategory.Cards;
				}
			}
			return ItemCategory.Rooms;
		}
	}

	private InventoryItem defaultItem
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_014c: Expected O, but got I4
			//IL_00a5: Expected O, but got I
			//IL_00b5: Expected O, but got I
			//IL_00c5: Expected O, but got I
			//IL_00e7: Expected O, but got I4
			//IL_018a: Expected O, but got I
			//IL_019a: Expected O, but got I
			//IL_01aa: Expected O, but got I
			//IL_01cc: Expected O, but got I4
			//IL_0214: Expected O, but got I4
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0273: Expected O, but got Unknown
			//IL_0289: Expected O, but got I
			//IL_029a: Expected I, but got O
			//IL_02b8: Expected O, but got I
			//IL_0244: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 4072;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8C12]");
			object obj3 = (nint)0 & (nint)1;
			List<InventoryItem> inventoryItems;
			List<InventoryItem> inventoryItems2;
			object obj4;
			if (obj3 != null)
			{
				inventoryItems = InventoryItems;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				inventoryItems2 = InventoryItems;
				if (!flag)
				{
					goto IL_0099;
				}
			}
			else
			{
				_ = 1;
				inventoryItems = InventoryItems;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				inventoryItems2 = InventoryItems;
				if (obj6 != null)
				{
					goto IL_0099;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
			object obj7 = (nint)0 + (nint)952;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			Func<object, bool> predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			IEnumerable<object> enumerable = inventoryItems2;
			object obj10 = obj7;
			IEnumerable<object> source = inventoryItems2;
			if (obj9 == null)
			{
				goto IL_01f2;
			}
			goto IL_0249;
			IL_01f2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj12 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v10+B8]");
				obj8 = 0;
			}
			object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2008;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)1088;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj8, (IntPtr)obj14);
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v9+B8]");
			object obj16 = (nint)0 + (nint)8;
			obj16 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj10 = obj7;
			predicate = func;
			source = enumerable;
			goto IL_0249;
			IL_0249:
			return (InventoryItem)Enumerable.FirstOrDefault(source, predicate);
			IL_0099:
			obj10 = (nint)0 + (nint)952;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			source = inventoryItems;
			if (obj17 == null)
			{
				obj7 = obj10;
				enumerable = inventoryItems;
				goto IL_01f2;
			}
			goto IL_0249;
		}
	}

	private InventoryItem activeItem
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_010f: Expected O, but got I4
			//IL_00b3: Expected O, but got I4
			//IL_015a: Expected O, but got I4
			//IL_0163: Expected O, but got I4
			//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bd: Expected O, but got Unknown
			//IL_036b: Expected O, but got I
			//IL_037b: Expected O, but got I
			//IL_039d: Expected O, but got I4
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Expected O, but got Unknown
			//IL_019f: Expected I, but got O
			//IL_01c8: Expected O, but got I4
			//IL_0418: Expected O, but got I
			//IL_045b: Expected O, but got I4
			//IL_02fa: Expected O, but got I
			//IL_030a: Expected O, but got I
			//IL_032c: Expected O, but got I4
			//IL_0228: Expected I, but got O
			//IL_0251: Expected O, but got I4
			//IL_03d7: Expected O, but got I4
			//IL_01fc: Expected O, but got I
			//IL_060f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0614: Expected O, but got Unknown
			//IL_062a: Expected O, but got I
			//IL_0632: Expected I, but got O
			//IL_0643: Expected I, but got O
			//IL_0661: Expected O, but got I
			//IL_0672: Expected O, but got I4
			//IL_0285: Expected O, but got I
			//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e2: Expected O, but got Unknown
			//IL_050c: Expected O, but got I4
			//IL_0407: Expected O, but got I
			//IL_05b2: Expected O, but got I4
			//IL_069e: Expected O, but got I
			//IL_06ae: Expected O, but got I
			//IL_06d0: Expected O, but got I4
			//IL_0553: Expected O, but got I4
			//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_06fc: Expected O, but got Unknown
			//IL_0712: Expected O, but got I
			//IL_071a: Expected I, but got O
			//IL_072b: Expected I, but got O
			//IL_0749: Expected O, but got I
			//IL_075a: Expected O, but got I4
			//IL_0583: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CCF]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj5;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v41+E4]");
				bool flag = (nint)0 == 0;
				obj5 = _activeItem;
				obj6 = _activeItem;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				obj5 = _activeItem;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v41+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj6 = _activeItem;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj6 != null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			object obj9 = 0;
			UnityEngine.Object obj10 = null;
			if (obj8 != null)
			{
				goto IL_00c6;
			}
			goto IL_05d7;
			IL_00c6:
			InventoryItem result = _activeItem;
			goto IL_0689;
			IL_0481:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12;
			object obj11 = obj12;
			goto IL_0498;
			IL_03b5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v18+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			object obj15;
			object obj16;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj14 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X8_v22+B8]");
				obj16 = 0;
			}
			object obj17 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2008;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj18 = (nint)0 + (nint)1080;
			nint num = (nint)obj18;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj16, (IntPtr)obj18);
			object obj19 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X8_v21+B8]");
			object obj20 = (nint)0 + (nint)24;
			obj20 = func;
			object obj21 = 0;
			Func<object, bool> func2 = func;
			IEnumerable<object> inventoryItems = InventoryItems;
			goto IL_0771;
			IL_0091:
			bool flag6 = obj5 != null;
			bool flag7 = !flag6;
			obj9 = 0;
			obj10 = null;
			if (!flag7)
			{
				goto IL_00c6;
			}
			goto IL_05d7;
			IL_05d7:
			InventoryItem inventoryItem = DefaultItem;
			Func<object, bool> func3;
			object obj40;
			Func<object, bool> func5;
			if ((object)DefaultItem != null)
			{
				object obj22 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 368;
				object obj23 = obj22;
				nint num2 = (nint)inventoryItem;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X10_v7 (Il2CppClass<InventoryItem>)+130]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v28+130]");
				bool flag8 = num3 < 0;
				object obj24 = !flag8;
				object obj25 = ~obj24;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X10_v7 (Il2CppClass<InventoryItem>)+C8]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v28+130]");
					object obj26 = num4 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X10_v11-8]");
					if (0 == (nint)obj23)
					{
						object obj27 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 4072;
						object obj28 = obj27;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X0_v29+E4]");
						bool flag9 = (nint)0 == 0;
						object obj29 = !flag9;
						if (obj29 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj28 = obj27;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X0_v29+B8]");
						object obj30 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v32+10]");
						func3 = (Func<object, bool>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v32+10]");
						bool flag10 = (nint)0 == 0;
						object obj31 = !flag10;
						inventoryItems = InventoryItems;
						if (obj31 != null)
						{
							goto IL_040c;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X0_v29+E4]");
						bool flag11 = (nint)0 == 0;
						object obj32 = !flag11;
						if (obj32 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj33 = obj27;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X8_v38+B8]");
							obj30 = 0;
						}
						object obj34 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2008;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj35 = (nint)0 + (nint)1072;
						num = (nint)obj35;
						Func<object, bool> func4 = default(Func<object, bool>);
						func4..ctor(obj30, (IntPtr)obj35);
						object obj36 = obj27;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X8_v37+B8]");
						obj20 = (nint)0 + (nint)16;
						obj20 = func4;
						obj21 = 0;
						func2 = func4;
						inventoryItems = InventoryItems;
						goto IL_0771;
					}
				}
				nint num5 = (nint)inventoryItem;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X9_v9 (Il2CppClass<InventoryItem>)+130]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v28+130]");
				bool flag12 = num6 < 0;
				object obj37 = !flag12;
				object obj38 = ~obj37;
				if (obj38 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X9_v9 (Il2CppClass<InventoryItem>)+C8]");
					nint num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v28+130]");
					object obj39 = num7 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X9_v11-8]");
					if (0 == (nint)obj23)
					{
						obj40 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v11+E4]");
						bool flag13 = (nint)0 == 0;
						object obj41 = !flag13;
						obj11 = null;
						if (obj41 == null)
						{
							func5 = (Func<object, bool>)(object)obj10;
							obj12 = null;
							goto IL_0481;
						}
						goto IL_0498;
					}
				}
			}
			obj15 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 4072;
			object obj42 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v18+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v18+B8]");
				obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v16+18]");
				func3 = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v16+18]");
				bool flag14 = (nint)0 == 0;
				object obj43 = !flag14;
				inventoryItems = InventoryItems;
				if (obj43 == null)
				{
					goto IL_03b5;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj42 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v18+B8]");
				obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v16+18]");
				func3 = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v16+18]");
				bool flag15 = (nint)0 == 0;
				object obj44 = !flag15;
				inventoryItems = InventoryItems;
				if (obj44 == null)
				{
					goto IL_03b5;
				}
			}
			goto IL_040c;
			IL_0689:
			return result;
			IL_0771:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			func3 = func2;
			goto IL_040c;
			IL_040c:
			object obj45 = (nint)0 + (nint)952;
			obj9 = obj45;
			object obj46 = Enumerable.FirstOrDefault(inventoryItems, func3);
			obj40 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v11+E4]");
			bool flag16 = (nint)0 == 0;
			object obj47 = !flag16;
			func5 = func3;
			obj12 = obj46;
			obj11 = obj46;
			if (obj47 == null)
			{
				goto IL_0481;
			}
			goto IL_0498;
			IL_0498:
			bool flag17 = (UnityEngine.Object)obj11 == null;
			bool flag18 = !flag17;
			result = (InventoryItem)obj11;
			if (!flag18)
			{
				return DefaultItem;
			}
			goto IL_0689;
		}
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
		object obj2 = (nint)0 + (nint)3128;
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

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		uiPicker.onUIPickerInitialized -= action;
	}

	public void Refresh()
	{
		ClearItems();
		PopulateItems();
	}

	private void LerpToActiveItem()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00b9: Expected O, but got I
		//IL_00c7: Expected I, but got O
		//IL_0054: Expected O, but got I
		//IL_0062: Expected I, but got O
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		UIPicker uIPicker = uiPicker;
		object obj = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		if (uIPicker.isInitialized)
		{
			object obj2 = (nint)0 + (nint)3104;
			action..ctor(this, (IntPtr)obj2);
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v8+E4]");
			if ((nint)0 != 0)
			{
				CoroutineDummy.WaitForEndOfFrame(action);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			CoroutineDummy.WaitForEndOfFrame(action);
		}
		else
		{
			object obj5 = (nint)0 + (nint)3120;
			action..ctor(this, (IntPtr)obj5);
			uIPicker.onUIPickerInitialized += action;
		}
	}

	private void ClearItems()
	{
		//IL_0012: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0032: Expected O, but got I
		//IL_005c: Expected I, but got O
		//IL_00e4: Expected I, but got O
		//IL_00f7: Expected O, but got I4
		//IL_01f9: Expected I, but got O
		//IL_01ab: Expected O, but got I4
		object obj3 = default(object);
		nint num = default(nint);
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (InventoryItems != null)
		{
			object obj = (nint)0 + (nint)2584;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			obj3 = (nint)0 + (nint)2576;
			List<object>.Enumerator enumerator = ((List<object>)(object)InventoryItems).GetEnumerator();
			num = (nint)obj;
			object obj4;
			if (!enumerator2.MoveNext())
			{
				num = (nint)obj3;
				enumerator2.Dispose();
				obj4 = 0;
				goto IL_00fc;
			}
			NullReferenceException ex = new NullReferenceException();
			obj4 = 0;
		}
		goto IL_0280;
		IL_0280:
		NullReferenceException ex2 = new NullReferenceException();
		bool flag = num != 1;
		OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex2;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj3;
			enumerator2.Dispose();
			object obj5 = default(object);
			bool flag2 = obj5 == null;
			object obj4 = obj5;
			if (flag2)
			{
				goto IL_00fc;
			}
			ex3 = new OutOfMemoryException();
			obj4 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223ECF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_00fc:
		List<InventoryItem> inventoryItems = InventoryItems;
		if (InventoryItems != null)
		{
			int version = inventoryItems._version + 1;
			inventoryItems._size = 0;
			inventoryItems._version = version;
			if (inventoryItems._size >= 1)
			{
				Array.Clear(inventoryItems._items, 0, inventoryItems._size);
			}
			return;
		}
		goto IL_0280;
	}

	private unsafe void PopulateItems()
	{
		//IL_141e: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_005e: Expected O, but got I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00bf: Expected O, but got I
		//IL_0101: Expected O, but got I
		//IL_0189: Expected O, but got I4
		//IL_020c: Expected O, but got I
		//IL_021c: Expected O, but got I
		//IL_0241: Expected O, but got I
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_028b: Expected O, but got I
		//IL_143b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1440: Expected O, but got Unknown
		//IL_144f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1454: Expected O, but got Unknown
		//IL_1463: Unknown result type (might be due to invalid IL or missing references)
		//IL_1468: Expected O, but got Unknown
		//IL_1474: Expected O, but got I
		//IL_041e: Expected O, but got I4
		//IL_030b: Expected O, but got I4
		//IL_0394: Expected O, but got I4
		//IL_033f: Expected O, but got I
		//IL_04ab: Expected O, but got I4
		//IL_03c8: Expected O, but got I
		//IL_135e: Expected O, but got I4
		//IL_14c2: Expected O, but got I
		//IL_14ce: Expected O, but got I
		//IL_14de: Expected O, but got I
		//IL_14ee: Expected O, but got I
		//IL_1510: Expected O, but got I4
		//IL_1712: Expected I4, but got O
		//IL_0502: Expected O, but got I4
		//IL_152d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1532: Expected O, but got Unknown
		//IL_1548: Expected O, but got I
		//IL_1559: Expected I, but got O
		//IL_1577: Expected O, but got I
		//IL_0960: Unknown result type (might be due to invalid IL or missing references)
		//IL_0965: Expected O, but got Unknown
		//IL_0532: Expected O, but got I
		//IL_0584: Expected O, but got I
		//IL_0590: Expected O, but got I
		//IL_059c: Expected O, but got I
		//IL_05a8: Expected O, but got I
		//IL_0b70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b75: Expected O, but got Unknown
		//IL_09b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b6: Expected O, but got Unknown
		//IL_09cc: Expected O, but got I4
		//IL_0661: Expected I4, but got O
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Expected O, but got Unknown
		//IL_06b0: Expected O, but got I4
		//IL_0bbf: Expected O, but got I
		//IL_0f31: Expected O, but got I
		//IL_0f41: Expected O, but got I
		//IL_0f51: Expected O, but got I
		//IL_0f73: Expected O, but got I4
		//IL_0c77: Expected O, but got I
		//IL_0c91: Expected O, but got I4
		//IL_0ae7: Expected I4, but got O
		//IL_0a6a: Expected O, but got I
		//IL_0a7a: Expected O, but got I
		//IL_0a8a: Expected O, but got I
		//IL_0c19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1e: Expected O, but got Unknown
		//IL_0c40: Expected O, but got I4
		//IL_0bf2: Expected O, but got I
		//IL_0714: Expected I, but got O
		//IL_0724: Expected O, but got I
		//IL_0fd3: Expected O, but got I4
		//IL_0cf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf5: Expected O, but got Unknown
		//IL_0d2e: Expected O, but got I4
		//IL_0caf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb4: Expected O, but got Unknown
		//IL_0b2d: Expected I4, but got O
		//IL_1639: Unknown result type (might be due to invalid IL or missing references)
		//IL_163e: Expected O, but got Unknown
		//IL_1654: Expected O, but got I
		//IL_1665: Expected I, but got O
		//IL_1683: Expected O, but got I
		//IL_15dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e1: Expected O, but got Unknown
		//IL_15fb: Expected O, but got I4
		//IL_161c: Expected O, but got Ref
		//IL_10b6: Expected O, but got I
		//IL_1010: Expected I4, but got O
		//IL_103b: Expected O, but got I4
		//IL_1058: Expected I4, but got O
		//IL_1003: Expected O, but got I
		//IL_0d6a: Expected O, but got I
		//IL_0d74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d79: Expected O, but got Unknown
		//IL_0dd1: Expected O, but got Ref
		//IL_0de7: Expected I, but got O
		//IL_0df7: Expected O, but got I
		//IL_0e20: Expected O, but got I
		//IL_0805: Expected O, but got I
		//IL_0e5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e63: Expected O, but got Unknown
		//IL_1223: Expected O, but got I
		//IL_1233: Expected O, but got I
		//IL_1243: Expected O, but got I
		//IL_1265: Expected O, but got I4
		//IL_0ec1: Expected O, but got I4
		//IL_0892: Expected O, but got I4
		//IL_11b3: Expected I4, but got O
		//IL_11e2: Expected O, but got I4
		//IL_115e: Expected O, but got I
		//IL_116e: Expected O, but got I
		//IL_117e: Expected O, but got I
		//IL_05d6: Expected O, but got I
		//IL_05e6: Expected O, but got I
		//IL_0639: Expected O, but got I
		//IL_129d: Expected O, but got I4
		//IL_08d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d7: Expected O, but got Unknown
		//IL_08e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e5: Expected O, but got Unknown
		//IL_0928: Expected O, but got I
		//IL_16a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ae: Expected O, but got Unknown
		//IL_16c4: Expected O, but got I
		//IL_16d5: Expected I, but got O
		//IL_16f3: Expected O, but got I
		//IL_12da: Expected I4, but got O
		//IL_12cd: Expected O, but got I
		bool flag = (object)ItemsParent == null;
		IntPtr intPtr = default(IntPtr);
		object obj = (nint)intPtr;
		object obj6;
		List<object> list3;
		List<object> list4;
		bool flag4;
		InventoryItemSelection inventoryItemSelection;
		if (!flag)
		{
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj3 = (nint)0 + (nint)944;
			Transform transform = ItemsParent.transform;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			inventoryItemSelection = (InventoryItemSelection)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
			obj6 = this + 40;
			object obj7 = default(object);
			obj6 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X20_v7+28]");
			List<object> list = (List<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X20_v7+28]");
			bool flag3 = (nint)0 == 0;
			flag4 = false;
			obj = obj7;
			if (!flag3)
			{
				object obj8 = (nint)0 + (nint)1808;
				obj = obj6;
				object obj9 = obj8;
				int version = list._version + 1;
				list._version = version;
				object[] items = list._items;
				bool flag5 = list._items == null;
				flag4 = false;
				if (!flag5)
				{
					bool flag6 = list._size < items.Length;
					object obj10 = !flag6;
					if (obj10 == null)
					{
						int size = list._size + 1;
						list._size = size;
						object obj11 = list._items + list._size;
						object obj12 = obj11 + 32;
						obj12 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						flag4 = false;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v9+20]");
						object obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X8_v107+C0]");
						object obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X8_v108+70]");
						flag4 = false;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X20_v7+28]");
						((List<object>)0).AddWithResize(obj6);
					}
					object obj15 = obj6;
					if (obj6 != null)
					{
						object obj16 = typeof(List<AdaptivePerformanceScaler>) + 3608;
						object obj17 = (nint)0 + (nint)2976;
						object obj18 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v11+180]");
						flag4 = false;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v542 @ X8_v11+178] (should have been resolved before IL gen)");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						obj = obj17;
						List<object> list2 = default(List<object>);
						list2..ctor();
						object obj19 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 368;
						object obj20 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 4072;
						object obj21 = typeof(Queue<string>) + 848;
						object obj22 = (nint)0 + (nint)2200;
						object obj23 = obj6;
						if (obj6 != null)
						{
							object obj24 = obj19;
							object obj25 = obj23;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X11_v21+130]");
							nint num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X9_v36+130]");
							bool flag7 = num < 0;
							object obj26 = !flag7;
							object obj27 = ~obj26;
							if (obj27 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X11_v21+C8]");
								nint num2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X9_v36+130]");
								object obj28 = num2 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X11_v25-8]");
								if (0 == (nint)obj24)
								{
									object obj29 = obj21;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X0_v147+E4]");
									bool flag8 = (nint)0 == 0;
									object obj30 = !flag8;
									if (obj30 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
									SessionModel sessionModel = default(SessionModel);
									if ((object)sessionModel != null)
									{
										User localUser = sessionModel.LocalUser;
										List<StoreOwnedItem> ownedCards = SFSKammelnaUserExtensions.GetOwnedCards(localUser);
										obj = null;
										list3 = (List<object>)(object)ownedCards;
										goto IL_0549;
									}
									goto IL_13d3;
								}
							}
							object obj31 = obj23;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X10_v26+130]");
							nint num3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X9_v36+130]");
							bool flag9 = num3 < 0;
							object obj32 = !flag9;
							object obj33 = ~obj32;
							if (obj33 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X10_v26+C8]");
								nint num4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X9_v36+130]");
								object obj34 = num4 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X10_v28-8]");
								bool flag10 = 0 == (nint)obj24;
								list4 = list2;
								if (flag10)
								{
									goto IL_1499;
								}
							}
						}
						object obj35 = obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X0_v125+E4]");
						bool flag11 = (nint)0 == 0;
						object obj36 = !flag11;
						if (obj36 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
						SessionModel sessionModel2 = default(SessionModel);
						if ((object)sessionModel2 != null)
						{
							User localUser2 = sessionModel2.LocalUser;
							List<StoreOwnedItem> ownedRoomThemes = SFSKammelnaUserExtensions.GetOwnedRoomThemes(localUser2);
							object obj37 = obj20;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X0_v132+E4]");
							bool flag12 = (nint)0 == 0;
							object obj38 = !flag12;
							List<StoreOwnedItem> source = ownedRoomThemes;
							if (obj38 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj37 = obj20;
								source = ownedRoomThemes;
							}
							object obj39 = (nint)0 + (nint)3776;
							object obj40 = (nint)0 + (nint)2728;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X0_v132+B8]");
							object obj41 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v870 @ X8_v97+20]");
							Func<object, bool> predicate = (Func<object, bool>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v870 @ X8_v97+20]");
							bool flag13 = (nint)0 == 0;
							object obj42 = !flag13;
							if (obj42 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X0_v132+E4]");
								bool flag14 = (nint)0 == 0;
								object obj43 = !flag14;
								if (obj43 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									object obj44 = obj20;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ X8_v103+B8]");
									obj41 = 0;
								}
								object obj45 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3480;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								object obj46 = (nint)0 + (nint)1048;
								Func<object, bool> func = default(Func<object, bool>);
								func..ctor(obj41, (IntPtr)obj46);
								object obj47 = obj20;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X8_v102+B8]");
								object obj48 = (nint)0 + (nint)32;
								obj48 = func;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								inventoryItemSelection = null;
								predicate = func;
							}
							flag4 = (byte)(int)obj39 != 0;
							IEnumerable<object> source2 = Enumerable.Where(source, predicate);
							obj = obj40;
							list3 = Enumerable.ToList(source2);
							goto IL_0549;
						}
					}
				}
			}
		}
		goto IL_13d3;
		IL_11ab:
		object obj49;
		flag4 = (byte)(int)obj49 != 0;
		Func<object, object> func2;
		IEnumerable<object> itemsList = Enumerable.Select(InventoryItems, func2);
		bool flag15 = (object)uiPicker == null;
		object obj50 = !flag15;
		if (obj50 != null)
		{
			goto IL_1319;
		}
		InventoryItemSelection inventoryItemSelection2;
		inventoryItemSelection = inventoryItemSelection2;
		obj = func2;
		goto IL_13d3;
		IL_0adf:
		object obj51;
		flag4 = (byte)(int)obj51 != 0;
		IEnumerable<object> source3;
		Func<object, bool> func3;
		bool flag16 = Enumerable.Any(source3, func3);
		bool flag17 = !flag16;
		obj = func3;
		if (flag17)
		{
			goto IL_1073;
		}
		object obj53;
		object obj52 = obj53;
		bool flag18 = (byte)(int)obj51 != 0;
		inventoryItemSelection2 = inventoryItemSelection;
		object obj54 = func3;
		goto IL_158e;
		IL_1319:
		uiPicker.setItemsList((IEnumerable<GameObject>)itemsList);
		LerpToActiveItem();
		return;
		IL_1073:
		object obj55 = obj6;
		if (obj6 == null)
		{
			goto IL_13d3;
		}
		_ = 1;
		object obj56 = obj55;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1137 @ X8_v39+1B0]");
		obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1137 @ X8_v39+1A8] (should have been resolved before IL gen)");
		obj52 = obj53;
		flag18 = flag4;
		inventoryItemSelection2 = inventoryItemSelection;
		goto IL_158e;
		IL_0fb1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1016 @ X0_v53+E4]");
		bool flag19 = (nint)0 == 0;
		object obj57 = !flag19;
		object obj59;
		if (obj57 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj58 = obj52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1098 @ X8_v47+B8]");
			obj59 = 0;
		}
		object obj60 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj61 = (nint)0 + (nint)1056;
		Func<object, bool> func4 = default(Func<object, bool>);
		func4..ctor(obj59, (IntPtr)obj61);
		object obj62 = obj52;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1097 @ X8_v46+B8]");
		object obj63 = (nint)0 + (nint)40;
		obj63 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj64;
		flag4 = (byte)(int)obj64 != 0;
		IEnumerable<object> source4;
		bool flag20 = Enumerable.Any(source4, func4);
		bool flag21 = !flag20;
		object obj65 = !flag21;
		obj53 = obj52;
		inventoryItemSelection = null;
		obj = func4;
		flag18 = (byte)(int)obj64 != 0;
		inventoryItemSelection2 = null;
		obj54 = func4;
		if (obj65 == null)
		{
			goto IL_1073;
		}
		goto IL_158e;
		IL_0ce1:
		object obj66 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 368;
		object obj67 = obj66;
		object obj69;
		object obj68 = obj69;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1072 @ X10_v14+130]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1071 @ X9_v24+130]");
		bool flag22 = num5 < 0;
		object obj70 = !flag22;
		object obj71 = ~obj70;
		object obj73;
		object obj72 = obj73;
		if (obj71 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1072 @ X10_v14+C8]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1071 @ X9_v24+130]");
			object obj74 = num6 + 0;
			object obj75 = "Network Authentication Required" + 1288;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ X10_v16-8]");
			obj72 = ((0 != (nint)obj67) ? obj73 : obj75);
		}
		goto IL_15cd;
		IL_0c0f:
		obj73 = "Network Authentication Required" + 1296;
		obj69 = obj6;
		bool flag23 = obj6 == null;
		object obj76 = !flag23;
		if (obj76 != null)
		{
			goto IL_0ce1;
		}
		obj72 = obj73;
		goto IL_15cd;
		IL_0a5e:
		obj51 = (nint)0 + (nint)2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1016 @ X0_v53+B8]");
		obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1054 @ X8_v41+28]");
		func3 = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1054 @ X8_v41+28]");
		bool flag24 = (nint)0 == 0;
		List<InventoryItem> inventoryItems;
		source3 = inventoryItems;
		obj64 = obj51;
		obj52 = obj53;
		InventoryItemSelection inventoryItemSelection3 = inventoryItemSelection;
		source4 = inventoryItems;
		UnityEngine.Object obj77;
		string text = (string)(object)obj77;
		if (!flag24)
		{
			goto IL_0adf;
		}
		goto IL_0fb1;
		IL_0951:
		object obj78 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj79 = obj78;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v21+E4]");
		object[] array;
		if ((nint)0 != 0)
		{
			bool flag25 = itemCountLabel != null;
			obj53 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 4072;
			bool flag26 = !flag25;
			object obj80 = !flag26;
			array = null;
			obj77 = null;
			obj52 = obj53;
			flag4 = false;
			if (obj80 == null)
			{
				goto IL_09f5;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag27 = itemCountLabel != null;
			obj53 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 4072;
			bool flag28 = !flag27;
			array = null;
			obj77 = null;
			obj52 = obj53;
			flag4 = false;
			if (flag28)
			{
				goto IL_09f5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CCD]");
		object obj81 = (nint)0 & (nint)1;
		if (obj81 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CCE]");
			object obj82 = (nint)0 & (nint)1;
			if (obj82 != null)
			{
				goto IL_0c0f;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CCE]");
			object obj83 = (nint)0 & (nint)1;
			bool flag29 = obj83 == null;
			object obj84 = !flag29;
			if (obj84 != null)
			{
				goto IL_0c0f;
			}
		}
		_ = 1;
		obj73 = "Network Authentication Required" + 1296;
		obj69 = obj6;
		bool flag30 = obj6 == null;
		obj72 = obj73;
		if (!flag30)
		{
			goto IL_0ce1;
		}
		goto IL_15cd;
		IL_1499:
		if (list4 != null)
		{
			if (list4._size < 1)
			{
				goto IL_0951;
			}
			object obj85 = (nint)0 + (nint)3008;
			object obj86 = (nint)0 + (nint)376;
			object obj87 = (nint)0 + (nint)4040;
			object obj88 = (nint)0 + (nint)1360;
			object obj90 = default(object);
			object obj89 = obj90;
			InventoryItemSelection inventoryItemSelection4 = inventoryItemSelection;
			int num7 = 0;
			object obj95 = default(object);
			Transform transform2 = default(Transform);
			Transform transform3 = default(Transform);
			while (true)
			{
				flag4 = (byte)(int)obj85 != 0;
				object obj91 = list4.get_Item(num7);
				object obj92 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj93 = obj92;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ X0_v109+E4]");
				bool flag31 = (nint)0 == 0;
				object obj94 = !flag31;
				if (obj94 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				obj = obj86;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9A80");
				bool flag32 = obj95 == null;
				obj90 = obj89;
				inventoryItemSelection = inventoryItemSelection4;
				if (flag32)
				{
					break;
				}
				nint num8 = (nint)obj95;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v83 (Il2CppClass<System.Object>)+190]");
				obj90 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v343 @ X8_v83 (Il2CppClass<System.Object>)+188] (should have been resolved before IL gen)");
				obj = obj87;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
				bool flag33 = (object)ItemsParent == null;
				flag4 = (byte)num7 != 0;
				inventoryItemSelection = this;
				if (flag33)
				{
					break;
				}
				obj = obj88;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
				bool flag34 = (object)transform2 == null;
				flag4 = (byte)num7 != 0;
				inventoryItemSelection = this;
				if (flag34)
				{
					break;
				}
				transform2.SetParent(transform3, worldPositionStays: false);
				List<object> inventoryItems2 = (List<object>)(object)InventoryItems;
				bool flag35 = InventoryItems == null;
				flag4 = false;
				inventoryItemSelection = null;
				obj = transform3;
				if (flag35)
				{
					break;
				}
				object obj96 = (nint)0 + (nint)1808;
				object obj97 = obj96;
				int version2 = inventoryItems2._version + 1;
				inventoryItems2._version = version2;
				object[] items2 = inventoryItems2._items;
				bool flag36 = inventoryItems2._items == null;
				flag4 = false;
				inventoryItemSelection = null;
				obj = transform3;
				if (flag36)
				{
					break;
				}
				bool flag37 = inventoryItems2._size < items2.Length;
				object obj98 = !flag37;
				if (obj98 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v86+20]");
					object obj99 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1176 @ X8_v89+C0]");
					object obj100 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1177 @ X8_v90+70]");
					flag4 = false;
					((List<object>)(object)InventoryItems).AddWithResize(obj95);
					num7++;
					bool flag38 = num7 >= list4._size;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v83 (Il2CppClass<System.Object>)+190]");
					obj89 = 0;
					inventoryItemSelection4 = null;
					inventoryItemSelection = null;
					obj = obj95;
					if (!flag38)
					{
						continue;
					}
				}
				else
				{
					int size2 = inventoryItems2._size + 1;
					inventoryItems2._size = size2;
					object obj101 = inventoryItems2._items + inventoryItems2._size;
					object obj102 = obj101 + 32;
					obj102 = obj95;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					num7++;
					bool flag39 = num7 < list4._size;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v83 (Il2CppClass<System.Object>)+190]");
					obj89 = 0;
					inventoryItemSelection4 = null;
					flag4 = false;
					inventoryItemSelection = null;
					obj = obj95;
					if (flag39)
					{
						continue;
					}
				}
				goto IL_0951;
			}
		}
		goto IL_13d3;
		IL_0f13:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj103 = obj52;
		obj51 = (nint)0 + (nint)2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1016 @ X0_v53+B8]");
		obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1054 @ X8_v41+28]");
		func3 = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1054 @ X8_v41+28]");
		bool flag40 = (nint)0 == 0;
		object obj104 = !flag40;
		obj53 = obj52;
		inventoryItemSelection = inventoryItemSelection3;
		List<InventoryItem> inventoryItems3;
		source3 = inventoryItems3;
		obj64 = obj51;
		object[] array2;
		array = array2;
		source4 = inventoryItems3;
		if (obj104 != null)
		{
			goto IL_0adf;
		}
		goto IL_0fb1;
		IL_09f5:
		inventoryItems = InventoryItems;
		obj103 = obj53;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1016 @ X0_v53+E4]");
		bool flag41 = (nint)0 == 0;
		obj52 = obj53;
		array2 = array;
		inventoryItemSelection3 = inventoryItemSelection;
		inventoryItems3 = InventoryItems;
		text = (string)(object)obj77;
		object obj105 = obj103;
		if (!flag41)
		{
			goto IL_0a5e;
		}
		goto IL_0f13;
		IL_13e1:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_13ef;
		IL_13ef:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_13d3:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_13e1;
		IL_15cd:
		object obj106 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj107 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object[] array3 = default(object[]);
		bool flag42 = array3 == null;
		int num9 = default(int);
		obj = (object)(&num9);
		if (flag42)
		{
			goto IL_13d3;
		}
		object obj108 = default(object);
		bool flag43 = obj108 == null;
		object obj109 = (object)(&num9);
		if (!flag43)
		{
			nint num10 = (nint)array3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v61 (Il2CppClass<System.Object[]>)+40]");
			obj109 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag44 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v61 (Il2CppClass<System.Object[]>)+40]");
			obj = 0;
			if (flag44)
			{
				goto IL_13ef;
			}
		}
		bool flag45 = array3.Length == 0;
		obj = obj109;
		if (!flag45)
		{
			object obj110 = array3 + 32;
			obj110 = obj108;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			TextMeshProExtensions.Localize(itemCountLabel, (string)obj72, array3);
			inventoryItems = InventoryItems;
			obj103 = obj52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1016 @ X0_v53+E4]");
			bool flag46 = (nint)0 == 0;
			object obj111 = !flag46;
			obj53 = obj52;
			array = array3;
			inventoryItemSelection = null;
			obj77 = (UnityEngine.Object)obj72;
			array2 = array3;
			inventoryItemSelection3 = null;
			inventoryItems3 = InventoryItems;
			text = (string)obj72;
			obj105 = obj103;
			if (obj111 != null)
			{
				goto IL_0a5e;
			}
			goto IL_0f13;
		}
		goto IL_13e1;
		IL_158e:
		InventoryItem inventoryItem = activeItem;
		bool flag47 = (object)inventoryItem == null;
		flag4 = flag18;
		inventoryItemSelection = inventoryItemSelection2;
		obj = obj54;
		if (!flag47)
		{
			Transform transform4 = inventoryItem.transform;
			bool flag48 = (object)transform4 == null;
			flag4 = flag18;
			inventoryItemSelection = inventoryItemSelection2;
			obj = null;
			if (!flag48)
			{
				transform4.SetAsLastSibling();
				object obj112 = obj52;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1201 @ X0_v35+E4]");
				object obj113;
				object obj114;
				if ((nint)0 != 0)
				{
					obj49 = (nint)0 + (nint)3576;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1201 @ X0_v35+B8]");
					obj113 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1211 @ X8_v26+30]");
					func2 = (Func<object, object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1211 @ X8_v26+30]");
					bool flag49 = (nint)0 == 0;
					obj114 = obj49;
					if (!flag49)
					{
						goto IL_11ab;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj112 = obj52;
					obj49 = (nint)0 + (nint)3576;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1201 @ X0_v35+B8]");
					obj113 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1211 @ X8_v26+30]");
					func2 = (Func<object, object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1211 @ X8_v26+30]");
					bool flag50 = (nint)0 == 0;
					object obj115 = !flag50;
					obj114 = obj49;
					if (obj115 != null)
					{
						goto IL_11ab;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1201 @ X0_v35+E4]");
				bool flag51 = (nint)0 == 0;
				object obj116 = !flag51;
				if (obj116 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj117 = obj52;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1224 @ X8_v32+B8]");
					obj113 = 0;
				}
				object obj118 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2016;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj119 = (nint)0 + (nint)1064;
				Func<object, object> func5 = default(Func<object, object>);
				func5..ctor(obj113, (IntPtr)obj119);
				object obj120 = obj52;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v31+B8]");
				object obj121 = (nint)0 + (nint)48;
				obj121 = func5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				flag4 = (byte)(int)obj114 != 0;
				itemsList = Enumerable.Select(InventoryItems, func5);
				bool flag52 = (object)uiPicker == null;
				inventoryItemSelection = null;
				obj = func5;
				if (!flag52)
				{
					goto IL_1319;
				}
			}
		}
		goto IL_13d3;
		IL_0549:
		list4 = list3;
		goto IL_1499;
	}

	public void SendActivation(StoreOwnedItem ownedItem)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0088: Expected O, but got I
		//IL_00a3: Expected I, but got O
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 4080;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = ownedItem;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj4;
		object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj7 = (nint)0 + (nint)1096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v4+10]");
		KammelnaRequests.SetItemAsDefault(0, action);
	}

	public void ResetItemToDefault()
	{
		//IL_0016: Expected O, but got I
		//IL_00eb: Expected O, but got I
		//IL_0105: Expected O, but got I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0086: Expected O, but got I
		//IL_00ac: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0196: Expected I, but got O
		//IL_01bf: Expected O, but got I4
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0139: Expected O, but got I
		//IL_0208: Expected O, but got I
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_0237: Expected O, but got I4
		//IL_02a9: Expected I, but got O
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CD1]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CCE]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_0066;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CCE]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0066;
			}
		}
		_ = 1;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj6 = (nint)0 + (nint)3112;
		InventoryItem inventoryItem = DefaultItem;
		bool flag2 = (object)DefaultItem == null;
		object obj7 = obj6;
		object obj8 = obj5;
		if (!flag2)
		{
			goto IL_0172;
		}
		goto IL_01dd;
		IL_0291:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj7);
		ItemCategory category;
		KammelnaRequests.ResetDefaultItem(category, action);
		return;
		IL_01dd:
		category = ItemCategory.Rooms;
		goto IL_0291;
		IL_0172:
		object obj9 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 368;
		object obj10 = obj9;
		nint num = (nint)inventoryItem;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X10_v4 (Il2CppClass<InventoryItem>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X9_v5+130]");
		bool flag3 = num2 < 0;
		object obj11 = !flag3;
		obj7 = obj6;
		obj8 = obj5;
		if (obj11 == null)
		{
			goto IL_01dd;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X10_v4 (Il2CppClass<InventoryItem>)+C8]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X9_v5+130]");
		object obj12 = num3 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X10_v6-8]");
		object obj13 = 0 - obj10;
		bool flag4 = obj13 == null;
		object obj14 = !flag4;
		object obj15 = ~obj14;
		if (obj15 == null)
		{
			category = ItemCategory.Rooms;
			obj7 = obj6;
			obj8 = obj5;
		}
		else
		{
			obj7 = obj6;
			obj8 = obj5;
			category = ItemCategory.Cards;
		}
		goto IL_0291;
		IL_0066:
		obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		obj6 = (nint)0 + (nint)3112;
		inventoryItem = DefaultItem;
		bool flag5 = (object)DefaultItem == null;
		object obj16 = !flag5;
		if (obj16 != null)
		{
			goto IL_0172;
		}
		obj7 = obj6;
		obj8 = obj5;
		goto IL_01dd;
	}

	private void FinalizeAll(bool isSuccess, StoreOwnedItem ownedItem)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_05b7: Expected O, but got I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0111: Expected O, but got I
		//IL_0122: Expected I, but got O
		//IL_0133: Expected O, but got I
		//IL_0168: Expected O, but got I4
		//IL_006d: Expected O, but got I4
		//IL_0536: Expected O, but got I
		//IL_01f3: Expected I, but got O
		//IL_01fd: Expected O, but got I4
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_02aa: Expected O, but got I
		//IL_02bb: Expected I, but got O
		//IL_019c: Expected I, but got O
		//IL_01a6: Expected O, but got I4
		//IL_00a7: Expected O, but got I
		//IL_02cc: Expected O, but got I
		//IL_0301: Expected O, but got I4
		//IL_0618: Unknown result type (might be due to invalid IL or missing references)
		//IL_061d: Expected O, but got Unknown
		//IL_064d: Expected I, but got O
		//IL_0248: Expected O, but got I
		//IL_0273: Expected O, but got I4
		//IL_0355: Expected I, but got O
		//IL_04dc: Expected O, but got I4
		//IL_038c: Expected I, but got O
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected O, but got Unknown
		//IL_0406: Expected O, but got I4
		//IL_0472: Expected I, but got O
		//IL_0491: Expected O, but got I
		Func<object, bool> ownedItem2 = (Func<object, bool>)(typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 4088);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj = default(object);
		obj..ctor();
		bool flag = obj == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		StoreOwnedItem storeOwnedItem = null;
		object obj2 = obj;
		nint num;
		StoreOwnedItem storeOwnedItem2 = default(StoreOwnedItem);
		List<object>.Enumerator enumerator5;
		List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
		if (!flag)
		{
			ownedItem2 = (Func<object, bool>)(obj + 16);
			ownedItem2 = (Func<object, bool>)(object)storeOwnedItem2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (isSuccess)
			{
				bool flag2 = InventoryItems == null;
				enumerator = (List<object>.Enumerator)0;
				storeOwnedItem = storeOwnedItem2;
				obj2 = obj;
				if (!flag2)
				{
					List<object>.Enumerator enumerator2 = ((List<object>)(object)InventoryItems).GetEnumerator();
					object obj3 = (nint)0 + (nint)2584;
					List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
					object obj4 = default(object);
					while (true)
					{
						storeOwnedItem = (StoreOwnedItem)obj3;
						if (!enumerator3.MoveNext())
						{
							break;
						}
						if (obj4 != null)
						{
							_ = 0;
							object obj5 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v243 @ X8_v37+1A8] (should have been resolved before IL gen)");
							continue;
						}
						goto IL_04b8;
					}
					object obj6 = (nint)0 + (nint)2576;
					storeOwnedItem = (StoreOwnedItem)obj6;
					enumerator3.Dispose();
					enumerator = enumerator4;
					enumerator5 = enumerator4;
					enumerator4 = (List<object>.Enumerator)0;
					obj2 = obj;
					goto IL_0280;
				}
			}
			else
			{
				object obj7 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2008;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj8 = (nint)0 + (nint)1112;
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj, (IntPtr)obj8);
				object obj9 = (nint)0 + (nint)952;
				storeOwnedItem2 = (StoreOwnedItem)obj9;
				object obj10 = Enumerable.FirstOrDefault(InventoryItems, func);
				bool flag3 = obj10 == null;
				object obj11 = !flag3;
				InventoryItem inventoryItem = (InventoryItem)obj10;
				if (obj11 == null)
				{
					inventoryItem = defaultItem;
					bool flag4 = (object)inventoryItem == null;
					num = unchecked((nint)null);
					enumerator = (List<object>.Enumerator)0;
					storeOwnedItem = (StoreOwnedItem)(object)func;
					ownedItem2 = func;
					obj2 = obj;
					if (flag4)
					{
						goto IL_05d2;
					}
				}
				inventoryItem.isPendingActivatiion = false;
				bool flag5 = (object)inventoryItem.LoadingIndicator == null;
				num = unchecked((nint)null);
				enumerator = (List<object>.Enumerator)0;
				storeOwnedItem = (StoreOwnedItem)(object)func;
				ownedItem2 = func;
				obj2 = obj;
				if (!flag5)
				{
					inventoryItem.LoadingIndicator.SetActive(value: false);
					goto IL_04b1;
				}
			}
		}
		goto IL_05d2;
		IL_04b1:
		LerpToActiveItem();
		return;
		IL_05d2:
		NullReferenceException ex = new NullReferenceException();
		bool flag6 = (nint)storeOwnedItem != 1;
		NullReferenceException ex2 = ex;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj12 = (nint)0 + (nint)2576;
			storeOwnedItem = (StoreOwnedItem)obj12;
			enumerator.Dispose();
			object obj13 = default(object);
			bool flag7 = obj13 == null;
			enumerator4 = (List<object>.Enumerator)obj13;
			if (flag7)
			{
				goto IL_0280;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			enumerator4 = (List<object>.Enumerator)obj13;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223ECF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0280:
		object obj14 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)1104;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor(obj2, (IntPtr)obj15);
		object obj16 = (nint)0 + (nint)952;
		storeOwnedItem2 = (StoreOwnedItem)obj16;
		object obj17 = Enumerable.FirstOrDefault(InventoryItems, func2);
		bool flag8 = obj17 == null;
		object obj18 = !flag8;
		storeOwnedItem = (StoreOwnedItem)obj17;
		if (obj18 == null)
		{
			InventoryItem inventoryItem2 = defaultItem;
			storeOwnedItem = (StoreOwnedItem)(object)inventoryItem2;
		}
		object obj19 = this + 88;
		obj19 = storeOwnedItem;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		InventoryItem inventoryItem3 = activeItem;
		bool flag9 = (object)inventoryItem3 == null;
		num = unchecked((nint)null);
		if (!flag9)
		{
			inventoryItem3.isPendingActivatiion = false;
			bool flag10 = (object)inventoryItem3.LoadingIndicator == null;
			num = unchecked((nint)null);
			obj2 = inventoryItem3;
			if (!flag10)
			{
				inventoryItem3.LoadingIndicator.SetActive(value: false);
				_ = 1;
				nint num2 = (nint)inventoryItem3;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v370 @ X8_v16 (Il2CppClass<System.Object>)+1A8] (should have been resolved before IL gen)");
				obj2 = soundAlbum;
				object obj20 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj21 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v34+E4]");
				if ((nint)0 != 0)
				{
					bool flag11 = soundAlbum;
					bool flag12 = !flag11;
					object obj22 = !flag12;
					storeOwnedItem = null;
					if (obj22 != null)
					{
						goto IL_045c;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag13 = soundAlbum;
					bool flag14 = !flag13;
					storeOwnedItem = null;
					if (!flag14)
					{
						goto IL_045c;
					}
				}
				goto IL_04a1;
			}
		}
		goto IL_05d2;
		IL_045c:
		bool flag15 = (object)soundAlbum == null;
		num = unchecked((nint)null);
		storeOwnedItem2 = null;
		if (!flag15)
		{
			object obj23 = (nint)0 + (nint)2464;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF2BC");
			goto IL_04a1;
		}
		goto IL_05d2;
		IL_04a1:
		TrackAnimatedRoomThemeActivated((StoreOwnedItem)(object)ownedItem2);
		goto IL_04b1;
		IL_04b8:
		NullReferenceException ex4 = new NullReferenceException();
		enumerator = enumerator4;
		enumerator5 = enumerator4;
		enumerator4 = (List<object>.Enumerator)0;
		obj2 = obj;
		goto IL_05d2;
	}

	private void TrackAnimatedRoomThemeActivated(StoreOwnedItem ownedItem)
	{
		//IL_0016: Expected O, but got I
		//IL_00bb: Expected O, but got I
		//IL_00d5: Expected O, but got I4
		//IL_008c: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0136: Expected I, but got O
		//IL_015f: Expected O, but got I4
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_02f3: Expected O, but got I4
		//IL_0193: Expected O, but got I
		//IL_021a: Expected I4, but got O
		//IL_01fd: Expected O, but got I4
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CD2]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CCE]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_0066;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CCE]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0066;
			}
		}
		_ = 1;
		InventoryItem inventoryItem = DefaultItem;
		if ((object)DefaultItem != null)
		{
			goto IL_0112;
		}
		goto IL_01b7;
		IL_01b7:
		object obj5 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		bool flag2 = ownedItem == null;
		StoreOwnedItem storeOwnedItem = ownedItem;
		if (!flag2)
		{
			storeOwnedItem = (StoreOwnedItem)ownedItem.<itemId>k__BackingField;
		}
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v3+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		StoreItem storeItem = Store.GetStoreItem((int)storeOwnedItem);
		if (StoreItemExtensions.IsAnimatedRoomTheme(storeItem))
		{
			ITrackEvent trackEvent = TrackerLibrary.SettingsAnimatedRoomThemeActivated(storeItem.<id>k__BackingField, storeItem.<name>k__BackingField);
			object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v9+E4]");
			if ((nint)0 != 0)
			{
				Tracker.DesignEvent(trackEvent);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
		}
		return;
		IL_0112:
		object obj10 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 368;
		object obj11 = obj10;
		nint num = (nint)inventoryItem;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X9_v5 (Il2CppClass<InventoryItem>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v13+130]");
		bool flag4 = num2 < 0;
		object obj12 = !flag4;
		object obj13 = ~obj12;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X9_v5 (Il2CppClass<InventoryItem>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v13+130]");
			object obj14 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X9_v7-8]");
			if (0 == (nint)obj11)
			{
				return;
			}
		}
		goto IL_01b7;
		IL_0066:
		inventoryItem = DefaultItem;
		bool flag5 = (object)DefaultItem == null;
		object obj15 = !flag5;
		if (obj15 != null)
		{
			goto IL_0112;
		}
		goto IL_01b7;
	}

	public InventoryItemSelection()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 80;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <LerpToActiveItem>b__22_0()
	{
		//IL_0011: Expected O, but got I
		InventoryItem inventoryItem = activeItem;
		object obj = (nint)0 + (nint)4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		RectTransform item = default(RectTransform);
		uiPicker.SmoothLerpToItem(item);
	}

	private void <ResetItemToDefault>b__26_0(KammelnaResponseModel<bool> response)
	{
		bool succeeded = response.Succeeded;
		FinalizeAll(succeeded, null);
	}
}
