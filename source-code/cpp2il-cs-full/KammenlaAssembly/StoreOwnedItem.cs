using System;
using System.Collections.Generic;
using System.Data;
using System.Formats.Asn1;
using Cpp2ILInjected;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using SFSLitJson;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Sfs2X.Entities.Variables;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;

public class StoreOwnedItem
{
	private int <id>k__BackingField;

	private int <itemId>k__BackingField;

	private DateTime? <expirationDate>k__BackingField;

	private ItemCategory <category>k__BackingField;

	public int id
	{
		get
		{
			return <id>k__BackingField;
		}
		set
		{
			<id>k__BackingField = value;
		}
	}

	public bool IsActiveItem
	{
		get
		{
			//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fa: Expected O, but got Unknown
			//IL_0224: Expected O, but got I4
			//IL_024d: Expected O, but got I
			//IL_02ca: Expected I4, but got O
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Expected O, but got Unknown
			//IL_0154: Expected O, but got I4
			//IL_017d: Expected O, but got I
			//IL_02a2: Expected O, but got I4
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected O, but got Unknown
			//IL_0084: Expected O, but got I4
			//IL_01d2: Expected O, but got I4
			//IL_00ad: Expected O, but got I
			//IL_0102: Expected O, but got I4
			if (<category>k__BackingField != ItemCategory.Patterns)
			{
				if (<category>k__BackingField != ItemCategory.Rooms)
				{
					if (<category>k__BackingField != ItemCategory.Cards)
					{
						return false;
					}
					object obj = typeof(Queue<string>) + 848;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v21+E4]");
					bool flag = (nint)0 == 0;
					object obj3 = !flag;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj4 = (nint)0 + (nint)2200;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					SessionModel sessionModel = default(SessionModel);
					if ((object)sessionModel != null)
					{
						User localUser = sessionModel.LocalUser;
						int activeCardbackID = SFSKammelnaUserExtensions.GetActiveCardbackID(localUser);
						object obj5 = <itemId>k__BackingField - activeCardbackID;
						return obj5 == null;
					}
				}
				else
				{
					object obj6 = typeof(Queue<string>) + 848;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v12+E4]");
					bool flag2 = (nint)0 == 0;
					object obj8 = !flag2;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj9 = (nint)0 + (nint)2200;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					SessionModel sessionModel2 = default(SessionModel);
					if ((object)sessionModel2 != null)
					{
						User localUser2 = sessionModel2.LocalUser;
						int activeRoomThemeID = SFSKammelnaUserExtensions.GetActiveRoomThemeID(localUser2);
						object obj10 = <itemId>k__BackingField - activeRoomThemeID;
						return obj10 == null;
					}
				}
			}
			else
			{
				object obj11 = typeof(Queue<string>) + 848;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v4+E4]");
				bool flag3 = (nint)0 == 0;
				object obj13 = !flag3;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj14 = (nint)0 + (nint)2200;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel3 = default(SessionModel);
				if ((object)sessionModel3 != null)
				{
					User localUser3 = sessionModel3.LocalUser;
					int activePatternID = SFSKammelnaUserExtensions.GetActivePatternID(localUser3);
					object obj15 = <itemId>k__BackingField - activePatternID;
					return obj15 == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public int itemId
	{
		get
		{
			return <itemId>k__BackingField;
		}
		set
		{
			<itemId>k__BackingField = value;
		}
	}

	public DateTime? expirationDate
	{
		get
		{
			return <expirationDate>k__BackingField;
		}
		set
		{
			<expirationDate>k__BackingField = value;
		}
	}

	public ItemCategory category
	{
		get
		{
			return <category>k__BackingField;
		}
		set
		{
			<category>k__BackingField = value;
		}
	}

	public string name
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_0106: Expected O, but got I4
			//IL_0154: Expected O, but got I4
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A40]");
			object obj2 = (nint)0 & (nint)1;
			int itemID;
			int itemID2;
			if (obj2 != null)
			{
				itemID = <itemId>k__BackingField;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
				bool flag = (nint)0 == 0;
				itemID2 = <itemId>k__BackingField;
				if (!flag)
				{
					goto IL_0088;
				}
			}
			else
			{
				_ = 1;
				itemID = <itemId>k__BackingField;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				itemID2 = <itemId>k__BackingField;
				if (obj4 != null)
				{
					goto IL_0088;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			StoreItem storeItem = Store.GetStoreItem(itemID2);
			bool flag3 = storeItem == null;
			object obj5 = !flag3;
			if (obj5 != null)
			{
				goto IL_00ba;
			}
			string result = (string)(object)storeItem;
			goto IL_016f;
			IL_00ba:
			result = storeItem.<name>k__BackingField;
			goto IL_016f;
			IL_0088:
			storeItem = Store.GetStoreItem(itemID);
			bool flag4 = storeItem == null;
			result = (string)(object)storeItem;
			if (!flag4)
			{
				goto IL_00ba;
			}
			goto IL_016f;
			IL_016f:
			return result;
		}
	}

	public bool isExpired
	{
		get
		{
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected O, but got Unknown
			//IL_0011: Expected O, but got I
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			//IL_005c: Expected O, but got I4
			object obj = (??)<expirationDate>k__BackingField & 1;
			if (obj != null)
			{
				object obj2 = (nint)0 + (nint)2296;
				object obj3 = typeof(DataRelation) + 712;
				DateTime? dateTime = default(DateTime?);
				DateTime value = dateTime.Value;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v5+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime now = DateTime.Now;
				return value < now;
			}
			return false;
		}
	}

	public StoreOwnedItem()
	{
	}

	private StoreOwnedItem(ISFSObject sfsObject)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0048: Expected O, but got I
		//IL_0069: Expected O, but got I4
		object varName = "not" + 2904;
		object varName2 = "https://www.kammelna.com/Home/Terms" + 3848;
		object varName3 = "destinationTimeZone" + 3376;
		object obj = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2456;
		object obj2 = (nint)0 + (nint)112;
		base..ctor();
		int num = SFSExtensions.Get(sfsObject, (string)varName, 0);
		<id>k__BackingField = num;
		int num2 = SFSExtensions.Get(sfsObject, (string)varName2, 0);
		<itemId>k__BackingField = num2;
		<expirationDate>k__BackingField = SFSExtensions.Get(sfsObject, (string)varName3, (DateTime?)(object)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
		ItemCategory itemCategory = default(ItemCategory);
		<category>k__BackingField = itemCategory;
	}

	public sealed override string ToString()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00bc: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 728;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A43]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return JsonMapper.ToJson(this);
		IL_007d:
		return JsonMapper.ToJson(this);
	}

	public static List<StoreOwnedItem> ConvertUserVar(UserVariable var)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0036: Expected I, but got O
		//IL_0046: Expected O, but got I
		//IL_00f0: Expected O, but got I4
		//IL_00f9: Expected O, but got I4
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_0190: Expected O, but got I
		//IL_0199: Expected O, but got I4
		//IL_0081: Expected O, but got I
		//IL_0502: Expected O, but got I
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_02e9: Expected O, but got I
		//IL_0209: Expected O, but got I
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_057f: Expected O, but got I
		//IL_0324: Expected O, but got I
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected O, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected O, but got Unknown
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Expected O, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected O, but got Unknown
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected O, but got Unknown
		//IL_0419: Expected O, but got I4
		//IL_01ae: Expected O, but got I
		//IL_01be: Expected O, but got I
		//IL_01ce: Expected O, but got I
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected O, but got Unknown
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		if (var == null)
		{
			goto IL_0483;
		}
		object obj2 = typeof(UsageHint) + 664;
		nint num = (nint)var;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Variables.UserVariable>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Variables.UserVariable>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00c2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Variables.UserVariable>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X10_v21-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj4 += 16;
			obj3--;
			if ((nint)obj3 != 1)
			{
				continue;
			}
			goto IL_00c2;
		}
		object obj5 = obj4 + 8;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v278 @ X0_v35] (should have been resolved before IL gen)");
		object obj8 = default(object);
		if (obj8 != null)
		{
			goto IL_015c;
		}
		goto IL_0488;
		IL_0488:
		return (List<StoreOwnedItem>)(object)new NullReferenceException();
		IL_00c2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v193 @ X0_v32] (should have been resolved before IL gen)");
		bool flag = obj8 == null;
		object obj9 = !flag;
		object obj10 = 8;
		if (obj9 != null)
		{
			goto IL_015c;
		}
		goto IL_0488;
		IL_015c:
		object obj11 = typeof(System.IOAsyncCallback) + 960;
		object obj12 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2136;
		object obj13 = (nint)0 + (nint)2984;
		object obj14 = 0;
		object obj21 = default(object);
		StoreOwnedItem storeOwnedItem = default(StoreOwnedItem);
		ISFSObject sfsObject = default(ISFSObject);
		object obj34 = default(object);
		while (true)
		{
			object obj15 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v10+12E]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v10+12E]");
			if ((nint)0 == 0)
			{
				goto IL_024a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v10+B0]");
			object obj17 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X10_v16-8]");
				if (0 == (nint)obj11)
				{
					break;
				}
				obj17 += 16;
				obj16--;
				if ((nint)obj16 != 1)
				{
					continue;
				}
				goto IL_024a;
			}
			object obj18 = obj17 + 4;
			object obj19 = obj15 + obj18;
			object obj20 = obj19 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v412 @ X0_v28] (should have been resolved before IL gen)");
			if (obj14 >= obj21)
			{
				break;
			}
			goto IL_02d1;
			IL_02d1:
			object obj22 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v12+12E]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v12+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0365;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v12+B0]");
			object obj24 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X10_v11-8]");
				if (0 == (nint)obj11)
				{
					break;
				}
				obj24 += 16;
				obj23--;
				if ((nint)obj23 != 1)
				{
					continue;
				}
				goto IL_0365;
			}
			object obj25 = obj24 + 51;
			object obj26 = obj22 + obj25;
			object obj27 = obj26 + 312;
			goto IL_056f;
			IL_056f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X0_v11+8]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v491 @ X0_v11] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			storeOwnedItem..ctor(sfsObject);
			if (list != null)
			{
				object obj28 = obj13;
				int version = list._version + 1;
				list._version = version;
				object[] items = list._items;
				if (list._items != null)
				{
					bool flag2 = list._size < items.Length;
					object obj29 = !flag2;
					if (obj29 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v15+20]");
						object obj30 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v18+C0]");
						object obj31 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X8_v19+70]");
						obj10 = 0;
						list.AddWithResize((object)storeOwnedItem);
					}
					else
					{
						int size = list._size + 1;
						list._size = size;
						object obj32 = list._items + list._size;
						object obj33 = obj32 + 32;
						obj33 = storeOwnedItem;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					}
					obj14++;
					continue;
				}
			}
			goto IL_0488;
			IL_0365:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_056f;
			IL_024a:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v385 @ X0_v25] (should have been resolved before IL gen)");
			if (obj14 >= obj34)
			{
				break;
			}
			goto IL_02d1;
		}
		goto IL_0483;
		IL_0483:
		return (List<StoreOwnedItem>)(object)list;
	}
}
