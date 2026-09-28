using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Threading;
using Cpp2ILInjected;
using Spine;
using UnityEngine;

public class StringCacher : Singleton<StringCacher>
{
	public enum RoomElementDataType
	{
		RoomSpineAnimation,
		RoomSpineAtlas
	}

	private sealed class <>c__DisplayClass3_0
	{
		public int itemID;

		public Action<string> callback;

		public UnityEngine.Object go;

		internal void <LoadItemAnimationData>b__0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0105: Expected O, but got I4
			//IL_00b8: Expected O, but got I4
			//IL_023a: Expected O, but got I
			//IL_024a: Expected O, but got I
			//IL_025a: Expected O, but got I
			//IL_0183: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Expected O, but got Unknown
			//IL_0273: Expected O, but got I4
			//IL_01a3: Expected O, but got I
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c9: Expected O, but got Unknown
			//IL_01f3: Expected O, but got I4
			object obj = 152981504;
			object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FDC]");
			object obj3 = (nint)0 & (nint)1;
			int num;
			int num2;
			if (obj3 != null)
			{
				num = itemID;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v19+E4]");
				bool flag = (nint)0 == 0;
				num2 = itemID;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				num = itemID;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v19+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				num2 = itemID;
				if (obj5 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			StoreItem storeItem = Store.GetStoreItem(num2);
			if (storeItem != null)
			{
				goto IL_0156;
			}
			goto IL_021b;
			IL_021b:
			Action<string> action = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v4 (System.Action`1<System.String>)+18]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v4 (System.Action`1<System.String>)+40]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v4 (System.Action`1<System.String>)+28]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v104 @ X3_v1 (should have been resolved before IL gen)");
			goto IL_0264;
			IL_0264:
			object obj9 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format = default(object);
			object arg = default(object);
			string text = string.Format((string)format, arg);
			FileInfoModel <animationData>k__BackingField = storeItem.<animationData>k__BackingField;
			Action<string> action2 = callback;
			object obj10 = (nint)0 + (nint)2264;
			DateTime? dateTime = <animationData>k__BackingField.<lastModified>k__BackingField;
			object obj11 = typeof(RegisteredWaitHandle) + 40;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v12+E4]");
			bool flag3 = (nint)0 == 0;
			object obj13 = !flag3;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEEFBC");
			return;
			IL_0156:
			if (storeItem.<animationData>k__BackingField == null)
			{
				goto IL_021b;
			}
			format = "https://www.kammelna.com/Home/Terms" + 3904;
			goto IL_0264;
			IL_0091:
			storeItem = Store.GetStoreItem(num);
			bool flag4 = storeItem == null;
			object obj14 = !flag4;
			if (obj14 != null)
			{
				goto IL_0156;
			}
			goto IL_021b;
		}
	}

	private sealed class <>c__DisplayClass4_0
	{
		public int itemID;

		public Action<string, int> callback;

		public int elementIndex;

		public RoomElementDataType type;

		public UnityEngine.Object go;

		public Action<string> <>9__1;

		internal void <LoadRoomAnimationData>b__0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0105: Expected O, but got I4
			//IL_00b8: Expected O, but got I4
			//IL_028b: Expected O, but got I
			//IL_029b: Expected O, but got I
			//IL_02ab: Expected O, but got I
			//IL_0184: Expected O, but got I
			//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f2: Expected O, but got Unknown
			//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0302: Expected O, but got Unknown
			//IL_0324: Expected O, but got I4
			//IL_039c: Expected O, but got I
			//IL_03b1: Expected O, but got I
			//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c5: Expected O, but got Unknown
			//IL_03ef: Expected O, but got I4
			//IL_021c: Expected O, but got I4
			//IL_0341: Unknown result type (might be due to invalid IL or missing references)
			//IL_0346: Expected O, but got Unknown
			//IL_035c: Expected O, but got I
			//IL_036a: Expected I, but got O
			//IL_0262: Unknown result type (might be due to invalid IL or missing references)
			//IL_0267: Expected O, but got Unknown
			object obj = 152981504;
			object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F3C]");
			object obj3 = (nint)0 & (nint)1;
			int num;
			int num2;
			if (obj3 != null)
			{
				num = itemID;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v25+E4]");
				bool flag = (nint)0 == 0;
				num2 = itemID;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				num = itemID;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v25+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				num2 = itemID;
				if (obj5 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			StoreItem storeItem = Store.GetStoreItem(num2);
			if (storeItem != null)
			{
				goto IL_0156;
			}
			goto IL_026c;
			IL_02b5:
			int num3 = elementIndex;
			object obj7 = default(object);
			object obj6 = obj7;
			object obj8 = ((List<object>)(object)storeItem.<animatedRoomFileInfoGroups>k__BackingField).get_Item(elementIndex);
			object obj9 = obj8 + 24;
			goto IL_0417;
			IL_026c:
			Action<string, int> action = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v4 (System.Action`2<System.String, System.Int32>)+18]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v4 (System.Action`2<System.String, System.Int32>)+40]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v4 (System.Action`2<System.String, System.Int32>)+28]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v141 @ X4_v1 (should have been resolved before IL gen)");
			goto IL_02b5;
			IL_0417:
			object obj13 = obj9;
			object obj14 = this + 48;
			Action<object> action2 = (Action<object>)obj14;
			bool flag3 = obj14 == null;
			object obj15 = !flag3;
			if (obj15 == null)
			{
				object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj17 = (nint)0 + (nint)1952;
				Action<object> action3 = default(Action<object>);
				action3..ctor((object)this, (IntPtr)obj17);
				<>9__1 = action3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				action2 = action3;
			}
			object obj18 = (nint)0 + (nint)2264;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X25_v3+18]");
			DateTime? dateTime = (DateTime)0;
			object obj19 = typeof(RegisteredWaitHandle) + 40;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v13+E4]");
			bool flag4 = (nint)0 == 0;
			object obj21 = !flag4;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEEFBC");
			return;
			IL_0091:
			storeItem = Store.GetStoreItem(num);
			bool flag5 = storeItem == null;
			object obj22 = !flag5;
			if (obj22 != null)
			{
				goto IL_0156;
			}
			goto IL_026c;
			IL_0156:
			if (storeItem.<animatedRoomFileInfoGroups>k__BackingField != null)
			{
				obj7 = (nint)0 + (nint)744;
				object obj23 = ((List<object>)(object)storeItem.<animatedRoomFileInfoGroups>k__BackingField).get_Item(elementIndex);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v7 (System.Object)+10]");
				if ((nint)0 != 0)
				{
					string itemPath = GetItemPath(itemID, elementIndex, type);
					if (type == RoomElementDataType.RoomSpineAtlas)
					{
						goto IL_02b5;
					}
					bool flag6 = type == RoomElementDataType.RoomSpineAnimation;
					object obj24 = !flag6;
					if (obj24 == null)
					{
						num3 = elementIndex;
						obj6 = obj7;
						object obj25 = ((List<object>)(object)storeItem.<animatedRoomFileInfoGroups>k__BackingField).get_Item(elementIndex);
						obj9 = obj25 + 16;
						goto IL_0417;
					}
				}
			}
			goto IL_026c;
		}

		internal void <LoadRoomAnimationData>b__1(string animation)
		{
			//IL_0029: Expected O, but got I
			//IL_0039: Expected O, but got I
			//IL_0049: Expected O, but got I
			Action<string, int> action = callback;
			int num = elementIndex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<System.String, System.Int32>)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<System.String, System.Int32>)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<System.String, System.Int32>)+28]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X4_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private static string GetItemPath(int itemID)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0023: Expected O, but got I4
		object format = "https://www.kammelna.com/Home/Terms" + 3904;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		return string.Format((string)format, arg);
	}

	private unsafe static string GetItemPath(int itemID, int elementIndex, RoomElementDataType type)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0042: Expected O, but got I4
		//IL_0060: Expected O, but got Ref
		object format = "https://www.kammelna.com/Home/Terms" + 3944;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj2 = default(object);
		string arg = ((Enum)(&obj2)).ToString();
		object arg2 = default(object);
		object arg3 = default(object);
		return string.Format((string)format, arg2, arg3, arg);
	}

	public void LoadItemAnimationData(int itemID, UnityEngine.Object go, Action<string> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_00b2: Expected I, but got O
		//IL_00e1: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)1936;
		object obj5 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj6 = obj2 + 24;
		obj6 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 32;
		obj7 = go;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Store.CallWhenLoaded(action);
	}

	public void LoadRoomAnimationData(int itemID, int elementIndex, RoomElementDataType type, UnityEngine.Object go, Action<string, int> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00bc: Expected I, but got O
		//IL_00eb: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)1944;
		object obj5 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj6 = obj2 + 24;
		obj6 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 40;
		obj7 = go;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Store.CallWhenLoaded(action);
	}

	public StringCacher()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ae: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_005c: Expected O, but got I
		object obj = 152981504;
		object obj2 = typeof(Queue<string>) + 864;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F3B]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2224;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
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
			object obj4 = (nint)0 + (nint)2224;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
	}
}
