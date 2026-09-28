using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server;
using Server.Models;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public static class RecentGiftBombsManager
{
	private sealed class <>c__DisplayClass6_0
	{
		public Action<List<GiftBombData>> callback;

		internal void <GetRecentBombers>g__SuccessCallback|0(RecentGiftBombsModel model)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0211: Unknown result type (might be due to invalid IL or missing references)
			//IL_0216: Expected O, but got Unknown
			//IL_022c: Expected O, but got I
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Expected O, but got Unknown
			//IL_006b: Expected O, but got I
			//IL_0085: Expected O, but got I4
			//IL_0299: Unknown result type (might be due to invalid IL or missing references)
			//IL_029e: Expected O, but got Unknown
			//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b7: Expected O, but got Unknown
			//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c6: Expected O, but got Unknown
			//IL_02f0: Expected O, but got I4
			//IL_0121: Expected O, but got I4
			//IL_0328: Expected O, but got I
			//IL_01c2: Expected O, but got I
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 3464;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
			object obj3;
			long <ETag>k__BackingField;
			object key;
			if ((nint)0 != 0)
			{
				obj3 = "Drop Menu Toggle" + 1640;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6296]");
				object obj4 = (nint)0 & (nint)1;
				bool flag = obj4 == null;
				object obj5 = !flag;
				<ETag>k__BackingField = model.<ETag>k__BackingField;
				<ETag>k__BackingField = model.<ETag>k__BackingField;
				key = obj3;
				if (obj5 == null)
				{
					goto IL_00b5;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = "Drop Menu Toggle" + 1640;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6296]");
				object obj6 = (nint)0 & (nint)1;
				bool flag2 = obj6 == null;
				<ETag>k__BackingField = model.<ETag>k__BackingField;
				if (flag2)
				{
					goto IL_00b5;
				}
				<ETag>k__BackingField = model.<ETag>k__BackingField;
				key = obj3;
			}
			goto IL_0270;
			IL_00b5:
			_ = 1;
			key = obj3;
			goto IL_0270;
			IL_0270:
			string value = <ETag>k__BackingField.ToString();
			Prefs.SetString((string)key, value);
			object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj8 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
			object obj9 = "java.io.FileOutputStream" + 1976;
			object obj10 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string cachePath = Config.CachePath;
			string path = cachePath + (string)obj9;
			object obj12 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			FileUtils.SaveObject(path, (object)model.<GiftBombs>k__BackingField);
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v10+B8]");
			object obj15 = 0;
			List<object> list = (List<object>)obj15;
			int version = list._version + 1;
			list._size = 0;
			list._version = version;
			if (list._size >= 1)
			{
				Array.Clear(list._items, 0, list._size);
				object obj16 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v17+B8]");
				object obj17 = 0;
				list = (List<object>)obj17;
			}
			list.AddRange(model.<GiftBombs>k__BackingField);
			Actions.SafeInvoke((Action<object>)callback, model.<GiftBombs>k__BackingField);
		}

		internal unsafe void <GetRecentBombers>g__UseCacheCallback|1()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_02c3: Expected O, but got I4
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Expected O, but got Unknown
			//IL_00a7: Expected O, but got I
			//IL_00c1: Expected O, but got I4
			//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ae: Expected O, but got Unknown
			//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bd: Expected O, but got Unknown
			//IL_03e7: Expected O, but got I4
			//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ef: Expected O, but got Unknown
			//IL_0305: Expected O, but got I
			//IL_0105: Expected O, but got I
			//IL_036e: Expected O, but got I4
			//IL_0376: Expected O, but got Ref
			//IL_017e: Expected O, but got Ref
			//IL_01b7: Expected O, but got I4
			//IL_0405: Expected O, but got I
			//IL_0260: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3464;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6299]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v29+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v29+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6294]");
			object obj7 = (nint)0 & (nint)1;
			if (obj7 == null)
			{
				goto IL_00d7;
			}
			object obj8 = obj6;
			goto IL_039a;
			IL_018d:
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v16+B8]");
			object obj11 = 0;
			List<object> list = (List<object>)obj11;
			int version = list._version + 1;
			list._size = 0;
			list._version = version;
			if (list._size >= 1)
			{
				Array.Clear(list._items, 0, list._size);
				object obj12 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v14+B8]");
				object obj13 = 0;
				list = (List<object>)obj13;
			}
			object obj14;
			list.AddRange((IEnumerable<object>)obj14);
			Action<object> action = (Action<object>)callback;
			object arg = obj14;
			goto IL_0412;
			IL_039a:
			object obj15 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
			object obj16 = "java.io.FileOutputStream" + 1976;
			object obj17 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v2+E4]");
			bool flag3 = (nint)0 == 0;
			object obj18 = !flag3;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj19 = (nint)0 + (nint)3360;
			string cachePath = Config.CachePath;
			string path = cachePath + (string)obj16;
			object obj20 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v4+E4]");
			if ((nint)0 != 0)
			{
				object obj21 = obj19;
				bool flag4 = FileUtils.TryLoadObject<object>(path, out obj14);
				bool flag5 = !flag4;
				object obj22 = (object)(&obj14);
				if (!flag5)
				{
					goto IL_018d;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj21 = obj19;
				bool flag6 = FileUtils.TryLoadObject<object>(path, out obj14);
				bool flag7 = !flag6;
				object obj23 = !flag7;
				object obj22 = (object)(&obj14);
				if (obj23 != null)
				{
					goto IL_018d;
				}
			}
			action = (Action<object>)callback;
			arg = null;
			goto IL_0412;
			IL_00d7:
			_ = 1;
			obj8 = obj6;
			goto IL_039a;
			IL_0412:
			Actions.SafeInvoke(action, arg);
			return;
			IL_007d:
			obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6294]");
			object obj24 = (nint)0 & (nint)1;
			bool flag8 = obj24 == null;
			object obj25 = !flag8;
			obj8 = obj6;
			if (obj25 == null)
			{
				goto IL_00d7;
			}
			goto IL_039a;
		}

		internal void <GetRecentBombers>g__ErrorCallback|2(string error)
		{
			//IL_000c: Expected O, but got I
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Expected O, but got Unknown
			//IL_0141: Expected O, but got I4
			//IL_0068: Expected O, but got I4
			//IL_015f: Expected O, but got I
			//IL_00a3: Expected O, but got I
			//IL_00f5: Expected O, but got I
			object obj = (nint)0 + (nint)1992;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 3464;
			Actions.SafeInvoke((Action<object>)callback, null);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PopupWindow.ShowError(error);
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v7+B8]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v6+1C]");
			object obj10 = (nint)0 + (nint)1;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v6+18]");
			if ((nint)0 >= (nint)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v6+10]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v6+18]");
				Array.Clear((Array)num, 0, 0);
			}
		}
	}

	private static readonly List<GiftBombData> RecentBombersList;

	private static string CachePath
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_0085: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = "java.io.FileOutputStream" + 1976;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string cachePath = Config.CachePath;
			return cachePath + (string)obj2;
		}
	}

	private static long ETag
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			//IL_007a: Expected O, but got I4
			//IL_0039: Expected I8, but got I4
			object key = "Drop Menu Toggle" + 1640;
			object defaultValue = ", stale={0}" + 3424;
			string s = Prefs.GetString((string)key, (string)defaultValue);
			long result;
			bool flag = long.TryParse(s, out result);
			bool flag2 = !flag;
			object obj = !flag2;
			object obj2 = ~obj;
			if (obj2 == null)
			{
				return result;
			}
			return 0L;
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Drop Menu Toggle" + 1640;
			long num = default(long);
			string value2 = num.ToString();
			Prefs.SetString((string)key, value2);
		}
	}

	public static void GetRecentBombers(Action<List<GiftBombData>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_026d: Expected O, but got I
		//IL_02a1: Expected O, but got I4
		//IL_0096: Expected O, but got I
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_010e: Expected O, but got I4
		//IL_0170: Expected O, but got I4
		//IL_0306: Expected O, but got I4
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_0405: Expected O, but got I
		//IL_041d: Expected O, but got I
		//IL_042d: Expected O, but got I
		//IL_043d: Expected O, but got I
		//IL_0380: Expected O, but got I4
		//IL_01c6: Expected I8, but got I4
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected O, but got Unknown
		//IL_03c1: Expected O, but got I
		//IL_03d2: Expected I, but got O
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Expected O, but got Unknown
		//IL_01d7: Expected O, but got I
		//IL_01e8: Expected I, but got O
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_0217: Expected O, but got I
		//IL_0228: Expected I, but got O
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 3464;
		object obj4 = (nint)0 + (nint)2584;
		object obj5 = obj2 + 16;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v8+B8]");
			object list = 0;
			object obj7 = obj4;
			bool flag = ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)list);
			bool flag2 = !flag;
			object obj8 = obj4;
			if (!flag2)
			{
				goto IL_00d0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v17+B8]");
			object list2 = 0;
			object obj7 = obj4;
			bool flag3 = ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)list2);
			bool flag4 = !flag3;
			object obj10 = !flag4;
			object obj8 = obj4;
			if (obj10 != null)
			{
				goto IL_00d0;
			}
		}
		object obj11 = obj5;
		if (obj5 != null)
		{
			object obj12 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v12+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v12+B8]");
			object obj14 = 0;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X19_v5+18]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X19_v5+40]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X19_v5+28]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v109 @ X3_v2 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
		return;
		IL_00d0:
		object obj19 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v21+E4]");
		bool flag6 = (nint)0 == 0;
		object obj21 = !flag6;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy permanentInstance = CoroutineDummy.PermanentInstance;
		GameObject gameObject = permanentInstance.gameObject;
		object obj22 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v26+E4]");
		bool flag7 = (nint)0 == 0;
		object obj23 = !flag7;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object key = "Drop Menu Toggle" + 1640;
		object defaultValue = ", stale={0}" + 3424;
		string s = Prefs.GetString((string)key, (string)defaultValue);
		long result;
		bool flag8 = long.TryParse(s, out result);
		bool flag9 = !flag8;
		object obj24 = !flag9;
		object obj25 = ~obj24;
		long etag = ((obj25 != null) ? 0 : result);
		object obj26 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3240;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj27 = (nint)0 + (nint)3344;
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj27);
		object obj28 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj29 = (nint)0 + (nint)3352;
		Action action2 = default(Action);
		action2..ctor(obj2, (IntPtr)obj29);
		object obj30 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj31 = (nint)0 + (nint)3336;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj2, (IntPtr)obj31);
		SFS.GetRecentGiftBombs(gameObject, etag, action, action2, action3);
	}

	public static void ResetModels()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_013b: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_00b8: Expected O, but got I
		//IL_0173: Expected O, but got I
		//IL_0195: Expected O, but got I4
		//IL_010a: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3464;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6237]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v16+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v6+B8]");
		object obj8 = 0;
		object obj9 = obj8;
		bool flag3 = obj8 == null;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a2;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v16+B8]");
		object obj11 = 0;
		obj9 = obj11;
		goto IL_00a2;
		IL_00a2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v9+1C]");
		object obj12 = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v9+18]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v9+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v9+18]");
			Array.Clear((Array)num, 0, 0);
		}
	}

	static RecentGiftBombsManager()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1216;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj3 = obj2;
		object obj4 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
