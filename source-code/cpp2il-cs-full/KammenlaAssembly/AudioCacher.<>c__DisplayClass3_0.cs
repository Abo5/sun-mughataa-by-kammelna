using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Threading;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using UnityEngine;

public class AudioCacher : Singleton<AudioCacher>
{
	private sealed class <>c__DisplayClass2_0
	{
		public int itemID;

		public Action<AudioClip> callback;

		public UnityEngine.Object go;

		internal void <LoadItemAudio>b__0()
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DFF]");
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
			Action<AudioClip> action = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v4 (System.Action`1<UnityEngine.AudioClip>)+18]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v4 (System.Action`1<UnityEngine.AudioClip>)+40]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v4 (System.Action`1<UnityEngine.AudioClip>)+28]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v104 @ X3_v1 (should have been resolved before IL gen)");
			goto IL_0264;
			IL_0264:
			object obj9 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format = default(object);
			object arg = default(object);
			string text = string.Format((string)format, arg);
			FileInfoModel <audio>k__BackingField = storeItem.<audio>k__BackingField;
			Action<AudioClip> action2 = callback;
			object obj10 = (nint)0 + (nint)2264;
			DateTime? dateTime = <audio>k__BackingField.<lastModified>k__BackingField;
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
			if (storeItem.<audio>k__BackingField == null)
			{
				goto IL_021b;
			}
			format = "https://www.kammelna.com/Home/Terms" + 3912;
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

	private sealed class <>c__DisplayClass3_0
	{
		public int itemID;

		public Action<AudioClip, int> callback;

		public int elementIndex;

		public UnityEngine.Object go;

		public Action<AudioClip> <>9__1;

		internal void <LoadRoomElementAudio>b__0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0105: Expected O, but got I4
			//IL_00b8: Expected O, but got I4
			//IL_035f: Expected O, but got I
			//IL_036f: Expected O, but got I
			//IL_037f: Expected O, but got I
			//IL_0184: Expected O, but got I
			//IL_0398: Expected O, but got I4
			//IL_0209: Expected O, but got I
			//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d7: Expected O, but got Unknown
			//IL_0214: Unknown result type (might be due to invalid IL or missing references)
			//IL_0219: Expected O, but got Unknown
			//IL_023b: Expected O, but got I4
			//IL_0244: Expected O, but got I4
			//IL_02c5: Expected O, but got I
			//IL_02da: Expected O, but got I
			//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ee: Expected O, but got Unknown
			//IL_0318: Expected O, but got I4
			//IL_0261: Unknown result type (might be due to invalid IL or missing references)
			//IL_0266: Expected O, but got Unknown
			//IL_027c: Expected O, but got I
			//IL_028a: Expected I, but got O
			//IL_02ac: Expected O, but got I4
			object obj = 152981504;
			object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E00]");
			object obj3 = (nint)0 & (nint)1;
			int num;
			int num2;
			if (obj3 != null)
			{
				num = itemID;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v30+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v30+E4]");
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
			goto IL_0340;
			IL_0389:
			object obj6 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format = default(object);
			object arg = default(object);
			object arg2 = default(object);
			string text = string.Format((string)format, arg, arg2);
			object obj7 = ((List<object>)(object)storeItem.<animatedRoomFileInfoGroups>k__BackingField).get_Item(elementIndex);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v16 (System.Object)+20]");
			object obj8 = 0;
			object obj9 = this + 48;
			Action<object> action = (Action<object>)obj9;
			bool flag3 = obj9 == null;
			object obj10 = !flag3;
			object obj11 = 0;
			if (obj10 == null)
			{
				object obj12 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1184;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj13 = (nint)0 + (nint)48;
				Action<object> action2 = default(Action<object>);
				action2..ctor((object)this, (IntPtr)obj13);
				<>9__1 = action2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj11 = 0;
				action = action2;
			}
			object obj14 = (nint)0 + (nint)2264;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X25_v6+18]");
			DateTime? dateTime = (DateTime)0;
			object obj15 = typeof(RegisteredWaitHandle) + 40;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v19+E4]");
			bool flag4 = (nint)0 == 0;
			object obj17 = !flag4;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEEFBC");
			return;
			IL_0340:
			Action<AudioClip, int> action3 = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v4 (System.Action`2<UnityEngine.AudioClip, System.Int32>)+18]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v4 (System.Action`2<UnityEngine.AudioClip, System.Int32>)+40]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v4 (System.Action`2<UnityEngine.AudioClip, System.Int32>)+28]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v111 @ X4_v1 (should have been resolved before IL gen)");
			goto IL_0389;
			IL_0156:
			if (storeItem.<animatedRoomFileInfoGroups>k__BackingField != null)
			{
				object obj21 = (nint)0 + (nint)744;
				object obj22 = ((List<object>)(object)storeItem.<animatedRoomFileInfoGroups>k__BackingField).get_Item(elementIndex);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v7 (System.Object)+20]");
				if ((nint)0 != 0)
				{
					format = "https://www.kammelna.com/Home/Terms" + 3928;
					goto IL_0389;
				}
			}
			goto IL_0340;
			IL_0091:
			storeItem = Store.GetStoreItem(num);
			bool flag5 = storeItem == null;
			object obj23 = !flag5;
			if (obj23 != null)
			{
				goto IL_0156;
			}
			goto IL_0340;
		}

		internal void <LoadRoomElementAudio>b__1(AudioClip clip)
		{
			//IL_0029: Expected O, but got I
			//IL_0039: Expected O, but got I
			//IL_0049: Expected O, but got I
			Action<AudioClip, int> action = callback;
			int num = elementIndex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<UnityEngine.AudioClip, System.Int32>)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<UnityEngine.AudioClip, System.Int32>)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<UnityEngine.AudioClip, System.Int32>)+28]");
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
		object format = "https://www.kammelna.com/Home/Terms" + 3912;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		return string.Format((string)format, arg);
	}

	private static string GetRoomElementPath(int itemID, int elementIndex)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0028: Expected O, but got I4
		object format = "https://www.kammelna.com/Home/Terms" + 3928;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		object arg2 = default(object);
		return string.Format((string)format, arg, arg2);
	}

	public void LoadItemAudio(int itemID, UnityEngine.Object go, Action<AudioClip> callback)
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
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)32;
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

	public void LoadRoomElementAudio(int itemID, int elementIndex, UnityEngine.Object go, Action<AudioClip, int> callback)
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
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_00b7: Expected I, but got O
		//IL_00e6: Expected O, but got I4
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)40;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Store.CallWhenLoaded(action);
	}

	public AudioCacher()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ae: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_005c: Expected O, but got I
		object obj = 152981504;
		object obj2 = typeof(Queue<string>) + 704;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D2A]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)1912;
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
			object obj4 = (nint)0 + (nint)1912;
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
