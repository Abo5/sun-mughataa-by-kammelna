using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;

public static class ClanInterClanLeaderboardManager
{
	private sealed class <>c__DisplayClass7_0
	{
		public Action<List<InterClanLeaderboardEntryModel>> callback;

		public DateTime firstOfMonth;

		public string key;

		internal void <Get>b__0(KammelnaResponseModel<List<InterClanLeaderboardEntryModel>> response)
		{
			//IL_0011: Expected O, but got I
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected O, but got Unknown
			//IL_00f3: Expected O, but got I4
			//IL_012b: Expected O, but got I4
			//IL_0194: Expected O, but got I
			object obj = (nint)0 + (nint)736;
			object obj2;
			if (((KammelnaResponseModel<object>)(object)response).Succeeded)
			{
				obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1208;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v7+E4]");
				if ((nint)0 != 0)
				{
					if (!IsCurrentMonth(firstOfMonth))
					{
						goto IL_0101;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag = IsCurrentMonth(firstOfMonth);
					bool flag2 = !flag;
					object obj4 = !flag2;
					if (obj4 == null)
					{
						goto IL_0101;
					}
				}
				goto IL_016e;
			}
			Actions.SafeInvoke((Action<object>)callback, null);
			return;
			IL_0101:
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v12+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v12+B8]");
			object obj7 = 0;
			((Dictionary<object, object>)obj7).set_Item((object)key, (object)response.<Model>k__BackingField);
			goto IL_016e;
			IL_016e:
			Actions.SafeInvoke((Action<object>)callback, response.<Model>k__BackingField);
		}
	}

	private static readonly Dictionary<string, List<InterClanLeaderboardEntryModel>> Cache;

	public static DateTime CurrentMonth
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Expected O, but got Unknown
			//IL_01cd: Expected O, but got I4
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_0263: Expected O, but got I
			//IL_027d: Expected O, but got I4
			//IL_00f5: Expected O, but got I
			//IL_0225: Expected O, but got I4
			//IL_02cb: Expected O, but got I4
			object obj = 152993792;
			object obj2 = typeof(DataRelation) + 712;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86EA]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			object obj6;
			if (obj3 != null)
			{
				obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1208;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v10+E4]");
				bool flag = (nint)0 == 0;
				obj6 = obj4;
				if (!flag)
				{
					goto IL_0099;
				}
			}
			else
			{
				_ = 1;
				obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1208;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v10+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj6 = obj4;
				if (obj7 != null)
				{
					goto IL_0099;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			DateTime now = DateTime.Now;
			object obj8 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			DateTime dateTime = now;
			DateTime dateTime2 = now;
			if (obj9 != null)
			{
				goto IL_00df;
			}
			goto IL_0243;
			IL_014f:
			DateTime dateTime3;
			int year = dateTime3.Year;
			int month = dateTime3.Month;
			return new DateTime(year, month, 1);
			IL_02d9:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			goto IL_014f;
			IL_0122:
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_014f;
			}
			goto IL_02d9;
			IL_0099:
			DateTime now2 = DateTime.Now;
			obj8 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v8+E4]");
			bool flag4 = (nint)0 == 0;
			dateTime = now2;
			dateTime2 = now2;
			if (!flag4)
			{
				goto IL_00df;
			}
			goto IL_0243;
			IL_0243:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86EC]");
			object obj11 = (nint)0 & (nint)1;
			bool flag5 = obj11 == null;
			object obj12 = !flag5;
			dateTime3 = dateTime2;
			dateTime3 = dateTime2;
			if (obj12 != null)
			{
				goto IL_0122;
			}
			goto IL_029b;
			IL_00df:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86EC]");
			object obj13 = (nint)0 & (nint)1;
			bool flag6 = obj13 == null;
			dateTime3 = dateTime;
			dateTime3 = dateTime;
			if (!flag6)
			{
				goto IL_0122;
			}
			goto IL_029b;
			IL_029b:
			_ = 1;
			obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v1+E4]");
			bool flag7 = (nint)0 == 0;
			object obj14 = !flag7;
			if (obj14 != null)
			{
				goto IL_014f;
			}
			goto IL_02d9;
		}
	}

	public static DateTime LastMonth
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Expected O, but got Unknown
			//IL_01e8: Expected O, but got I4
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_027e: Expected O, but got I
			//IL_0298: Expected O, but got I4
			//IL_00f5: Expected O, but got I
			//IL_0240: Expected O, but got I4
			//IL_02e6: Expected O, but got I4
			//IL_0196: Expected I4, but got I8
			object obj = 152993792;
			object obj2 = typeof(DataRelation) + 712;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86EB]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			object obj6;
			if (obj3 != null)
			{
				obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1208;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v10+E4]");
				bool flag = (nint)0 == 0;
				obj6 = obj4;
				if (!flag)
				{
					goto IL_0099;
				}
			}
			else
			{
				_ = 1;
				obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1208;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v10+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj6 = obj4;
				if (obj7 != null)
				{
					goto IL_0099;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			DateTime now = DateTime.Now;
			object obj8 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			DateTime dateTime = now;
			DateTime dateTime2 = now;
			if (obj9 != null)
			{
				goto IL_00df;
			}
			goto IL_025e;
			IL_014f:
			DateTime dateTime3;
			int year = dateTime3.Year;
			int month = dateTime3.Month;
			DateTime dateTime4 = new DateTime(year, month, 1);
			DateTime dateTime5 = default(DateTime);
			return dateTime5.AddMonths(-1);
			IL_02f4:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			goto IL_014f;
			IL_0122:
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_014f;
			}
			goto IL_02f4;
			IL_0099:
			DateTime now2 = DateTime.Now;
			obj8 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v8+E4]");
			bool flag4 = (nint)0 == 0;
			dateTime = now2;
			dateTime2 = now2;
			if (!flag4)
			{
				goto IL_00df;
			}
			goto IL_025e;
			IL_025e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86EC]");
			object obj11 = (nint)0 & (nint)1;
			bool flag5 = obj11 == null;
			object obj12 = !flag5;
			dateTime3 = dateTime2;
			dateTime3 = dateTime2;
			if (obj12 != null)
			{
				goto IL_0122;
			}
			goto IL_02b6;
			IL_00df:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86EC]");
			object obj13 = (nint)0 & (nint)1;
			bool flag6 = obj13 == null;
			dateTime3 = dateTime;
			dateTime3 = dateTime;
			if (!flag6)
			{
				goto IL_0122;
			}
			goto IL_02b6;
			IL_02b6:
			_ = 1;
			obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v1+E4]");
			bool flag7 = (nint)0 == 0;
			object obj14 = !flag7;
			if (obj14 != null)
			{
				goto IL_014f;
			}
			goto IL_02f4;
		}
	}

	public static DateTime MonthStart(DateTime date)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_008c: Expected O, but got I4
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime dateTime = default(DateTime);
		int year = dateTime.Year;
		int month = dateTime.Month;
		return new DateTime(year, month, 1);
	}

	public static bool IsCurrentMonth(DateTime month)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01e1: Expected O, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00a7: Expected O, but got I
		//IL_0293: Expected O, but got I4
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_0223: Expected O, but got I
		//IL_023d: Expected O, but got I4
		//IL_017e: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1208;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86ED]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v8+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = typeof(DataRelation) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86EC]");
		object obj7 = (nint)0 & (nint)1;
		bool flag2 = obj7 == null;
		object obj8 = !flag2;
		DateTime dateTime = month;
		dateTime = month;
		object obj9 = obj6;
		if (obj8 != null)
		{
			goto IL_00dc;
		}
		goto IL_0263;
		IL_0111:
		int year = dateTime.Year;
		int month2 = dateTime.Month;
		DateTime dateTime2 = new DateTime(year, month2, 1);
		DateTime currentMonth = CurrentMonth;
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v24+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return dateTime2 == currentMonth;
		IL_02a9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj6 = obj9;
		goto IL_0111;
		IL_00dc:
		object obj12 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		obj9 = obj6;
		if (!flag4)
		{
			goto IL_0111;
		}
		goto IL_02a9;
		IL_007d:
		obj6 = typeof(DataRelation) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86EC]");
		object obj13 = (nint)0 & (nint)1;
		bool flag5 = obj13 == null;
		dateTime = month;
		dateTime = month;
		obj9 = obj6;
		if (!flag5)
		{
			goto IL_00dc;
		}
		goto IL_0263;
		IL_0263:
		_ = 1;
		obj12 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v1+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		obj6 = obj9;
		if (obj14 != null)
		{
			goto IL_0111;
		}
		goto IL_02a9;
	}

	public unsafe static void Get(Games game, DateTime month, Action<List<InterClanLeaderboardEntryModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_0332: Expected O, but got I
		//IL_034c: Expected O, but got I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_00a4: Expected O, but got I
		//IL_03a2: Expected O, but got I4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_01a1: Expected O, but got I
		//IL_01c4: Expected O, but got I4
		//IL_01cd: Expected O, but got I4
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected O, but got Unknown
		//IL_02bf: Expected O, but got I
		//IL_02da: Expected I, but got O
		//IL_02f8: Expected O, but got I
		//IL_0215: Expected O, but got I4
		//IL_0425: Expected O, but got I
		//IL_0246: Expected O, but got I
		//IL_0276: Expected O, but got Ref
		object obj = typeof(CardUtils.<>c) + 752;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1208;
		object obj4 = obj2 + 16;
		obj4 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v8+E4]");
		object obj8;
		DateTime dateTime;
		object obj6;
		if ((nint)0 != 0)
		{
			obj6 = typeof(DataRelation) + 712;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86EC]");
			object obj7 = (nint)0 & (nint)1;
			bool flag = obj7 == null;
			dateTime = month;
			dateTime = month;
			obj8 = obj6;
			if (!flag)
			{
				goto IL_00d9;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = typeof(DataRelation) + 712;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86EC]");
			object obj9 = (nint)0 & (nint)1;
			bool flag2 = obj9 == null;
			object obj10 = !flag2;
			dateTime = month;
			dateTime = month;
			obj8 = obj6;
			if (obj10 != null)
			{
				goto IL_00d9;
			}
		}
		_ = 1;
		object obj11 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v9+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		obj6 = obj8;
		if (obj12 != null)
		{
			goto IL_010e;
		}
		goto IL_03b8;
		IL_010e:
		int year = dateTime.Year;
		int month2 = dateTime.Month;
		DateTime dateTime2 = new DateTime(year, month2, 1);
		object obj13 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		object obj14 = default(object);
		string text = string.Format((string)format, arg, obj14);
		object obj15 = obj2 + 32;
		obj15 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X22_v12-8]");
		bool flag4 = IsCurrentMonth((DateTime)0);
		bool flag5 = !flag4;
		object obj16 = !flag5;
		object obj17 = 0;
		object obj18 = obj14;
		string text2 = text;
		if (obj16 == null)
		{
			object obj19 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v40+E4]");
			bool flag6 = (nint)0 == 0;
			object obj20 = !flag6;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj19 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v40+B8]");
			object obj21 = 0;
			object obj22 = (nint)0 + (nint)1608;
			obj17 = obj22;
			object value;
			bool flag7 = ((Dictionary<object, object>)obj21).TryGetValue(obj15, out value);
			bool flag8 = !flag7;
			obj18 = (object)(&value);
			text2 = (string)obj15;
			if (!flag8)
			{
				Actions.SafeInvoke((Action<object>)obj4, value);
				return;
			}
		}
		object obj23 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 376;
		object obj24 = (nint)0 + (nint)3752;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj24);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+18]");
		KammelnaRequests.GetClanInterClanLeaderboard((DateTime)0, game, action);
		return;
		IL_03b8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj6 = obj8;
		goto IL_010e;
		IL_00d9:
		obj11 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v9+E4]");
		bool flag9 = (nint)0 == 0;
		obj8 = obj6;
		if (!flag9)
		{
			goto IL_010e;
		}
		goto IL_03b8;
	}

	public static void Clear()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00dd: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_0115: Expected O, but got I
		//IL_0137: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1208;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8683]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v15+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v15+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v5+B8]");
		object obj8 = 0;
		Dictionary<object, object> dictionary = (Dictionary<object, object>)obj8;
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a2;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v15+B8]");
		object obj10 = 0;
		dictionary = (Dictionary<object, object>)obj10;
		goto IL_00a2;
		IL_00a2:
		dictionary.Clear();
	}

	private static string CacheKey(Games game, DateTime firstOfMonth)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
		object obj2 = typeof(DataRelation) + 712;
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		object arg2 = default(object);
		return string.Format((string)format, arg, arg2);
	}

	static ClanInterClanLeaderboardManager()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2136;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj3 = obj2;
		object obj4 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
