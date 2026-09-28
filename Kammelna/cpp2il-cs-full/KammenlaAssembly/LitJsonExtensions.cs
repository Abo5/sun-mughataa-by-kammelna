using System;
using System.Collections.Generic;
using System.Data;
using Cpp2ILInjected;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using SFSLitJson;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public static class LitJsonExtensions
{
	public static JsonData Get(JsonData jsonData, string name, JsonData defaultValue)
	{
		if (jsonData != null)
		{
			return jsonData.get_Item(name);
		}
		NullReferenceException ex = new NullReferenceException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		JsonData result = default(JsonData);
		return result;
	}

	public static string Get(JsonData jsonData, string name, string defaultValue)
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00f6: Expected O, but got I4
		//IL_016f: Expected O, but got I
		//IL_0128: Expected O, but got I
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01ca: Expected O, but got I4
		string text = default(string);
		string message;
		NullReferenceException ex;
		string text2;
		if (jsonData != null)
		{
			JsonData jsonData2 = jsonData.get_Item(text);
			if (jsonData2 != null)
			{
				if (jsonData2.IsString)
				{
					JsonData jsonData3 = jsonData.get_Item(text);
					return (string)jsonData3;
				}
				object obj = "_InputUv1BufferOffset" + 3984;
				object obj2 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 1048;
				message = (string)obj + text + (string)obj2;
				object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v15+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj6 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v18+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v18+B8]");
					object obj7 = 0;
					if ((nint)obj7 >= 2)
					{
						goto IL_018c;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj8 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v30+B8]");
					object obj9 = 0;
					if ((nint)obj9 >= 2)
					{
						goto IL_018c;
					}
				}
				goto IL_01f5;
			}
			ex = new NullReferenceException();
			text2 = null;
		}
		else
		{
			ex = new NullReferenceException();
		}
		goto IL_0269;
		IL_01f5:
		JsonData jsonData4 = jsonData.get_Item(text);
		if (jsonData4 != null)
		{
			return jsonData4.ToString();
		}
		ex = new NullReferenceException();
		text2 = null;
		goto IL_0269;
		IL_0269:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		string result = default(string);
		return result;
		IL_018c:
		object obj10 = typeof(DataRelation) + 856;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v25+E4]");
		bool flag2 = (nint)0 == 0;
		object obj12 = !flag2;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogWarning(message);
		goto IL_01f5;
	}

	public static int Get(JsonData jsonData, string name, int defaultValue)
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00f6: Expected O, but got I4
		//IL_016f: Expected O, but got I
		//IL_0128: Expected O, but got I
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01ca: Expected O, but got I4
		string text = default(string);
		string message;
		NullReferenceException ex;
		int num;
		if (jsonData != null)
		{
			JsonData jsonData2 = jsonData.get_Item(text);
			if (jsonData2 != null)
			{
				if (jsonData2.IsInt)
				{
					JsonData jsonData3 = jsonData.get_Item(text);
					return (int)jsonData3;
				}
				object obj = "_InputUv1BufferOffset" + 3984;
				object obj2 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 1032;
				message = (string)obj + text + (string)obj2;
				object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v15+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj6 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v18+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v18+B8]");
					object obj7 = 0;
					if ((nint)obj7 >= 2)
					{
						goto IL_018c;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj8 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v31+B8]");
					object obj9 = 0;
					if ((nint)obj9 >= 2)
					{
						goto IL_018c;
					}
				}
				goto IL_01f5;
			}
			ex = new NullReferenceException();
			num = 0;
		}
		else
		{
			ex = new NullReferenceException();
		}
		goto IL_0283;
		IL_01f5:
		JsonData jsonData4 = jsonData.get_Item(text);
		if (jsonData4 != null)
		{
			string s = jsonData4.ToString();
			return int.Parse(s);
		}
		ex = new NullReferenceException();
		num = 0;
		goto IL_0283;
		IL_0283:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		int result = default(int);
		return result;
		IL_018c:
		object obj10 = typeof(DataRelation) + 856;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v26+E4]");
		bool flag2 = (nint)0 == 0;
		object obj12 = !flag2;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogWarning(message);
		goto IL_01f5;
	}

	public static long Get(JsonData jsonData, string name, long defaultValue)
	{
		//IL_0267: Expected I8, but got I4
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00f6: Expected O, but got I4
		//IL_016f: Expected O, but got I
		//IL_0128: Expected O, but got I
		//IL_027e: Expected I8, but got I4
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01ca: Expected O, but got I4
		string text = default(string);
		string message;
		NullReferenceException ex;
		long num;
		if (jsonData != null)
		{
			JsonData jsonData2 = jsonData.get_Item(text);
			if (jsonData2 != null)
			{
				if (jsonData2.IsLong)
				{
					JsonData jsonData3 = jsonData.get_Item(text);
					return (long)jsonData3;
				}
				object obj = "_InputUv1BufferOffset" + 3984;
				object obj2 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 1040;
				message = (string)obj + text + (string)obj2;
				object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v15+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj6 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v18+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v18+B8]");
					object obj7 = 0;
					if ((nint)obj7 >= 2)
					{
						goto IL_018c;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj8 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v31+B8]");
					object obj9 = 0;
					if ((nint)obj9 >= 2)
					{
						goto IL_018c;
					}
				}
				goto IL_01f5;
			}
			ex = new NullReferenceException();
			num = 0L;
		}
		else
		{
			ex = new NullReferenceException();
		}
		goto IL_0283;
		IL_01f5:
		JsonData jsonData4 = jsonData.get_Item(text);
		if (jsonData4 != null)
		{
			string s = jsonData4.ToString();
			return long.Parse(s);
		}
		ex = new NullReferenceException();
		num = 0L;
		goto IL_0283;
		IL_0283:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		long result = default(long);
		return result;
		IL_018c:
		object obj10 = typeof(DataRelation) + 856;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v26+E4]");
		bool flag2 = (nint)0 == 0;
		object obj12 = !flag2;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogWarning(message);
		goto IL_01f5;
	}

	public static double Get(JsonData jsonData, string name, double defaultValue)
	{
		//IL_025e: Expected I, but got O
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00f6: Expected O, but got I4
		//IL_016f: Expected O, but got I
		//IL_0128: Expected O, but got I
		//IL_0271: Expected I, but got O
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01ca: Expected O, but got I4
		string text = default(string);
		string message;
		NullReferenceException ex;
		nint num;
		if (jsonData != null)
		{
			JsonData jsonData2 = jsonData.get_Item(text);
			if (jsonData2 != null)
			{
				if (jsonData2.IsDouble)
				{
					JsonData jsonData3 = jsonData.get_Item(text);
					return (double)jsonData3;
				}
				object obj = "_InputUv1BufferOffset" + 3984;
				object obj2 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 1040;
				message = (string)obj + text + (string)obj2;
				object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v15+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj6 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v18+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v18+B8]");
					object obj7 = 0;
					if ((nint)obj7 >= 2)
					{
						goto IL_018c;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj8 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v30+B8]");
					object obj9 = 0;
					if ((nint)obj9 >= 2)
					{
						goto IL_018c;
					}
				}
				goto IL_01f5;
			}
			ex = new NullReferenceException();
			num = unchecked((nint)null);
		}
		else
		{
			ex = new NullReferenceException();
		}
		goto IL_0276;
		IL_01f5:
		JsonData jsonData4 = jsonData.get_Item(text);
		if (jsonData4 != null)
		{
			string s = jsonData4.ToString();
			return double.Parse(s);
		}
		ex = new NullReferenceException();
		num = unchecked((nint)null);
		goto IL_0276;
		IL_0276:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return defaultValue;
		IL_018c:
		object obj10 = typeof(DataRelation) + 856;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v25+E4]");
		bool flag2 = (nint)0 == 0;
		object obj12 = !flag2;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogWarning(message);
		goto IL_01f5;
	}

	public static bool Get(JsonData jsonData, string name, bool defaultValue)
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00f6: Expected O, but got I4
		//IL_016f: Expected O, but got I
		//IL_0128: Expected O, but got I
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01ca: Expected O, but got I4
		//IL_022b: Expected I, but got O
		//IL_0247: Expected O, but got I4
		//IL_0257: Expected O, but got I
		//IL_0279: Expected O, but got I4
		string text = default(string);
		string message;
		NullReferenceException ex;
		bool flag2;
		if (jsonData != null)
		{
			JsonData jsonData2 = jsonData.get_Item(text);
			if (jsonData2 != null)
			{
				if (jsonData2.IsBoolean)
				{
					JsonData jsonData3 = jsonData.get_Item(text);
					return (bool)jsonData3;
				}
				object obj = "_InputUv1BufferOffset" + 3984;
				object obj2 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 1024;
				message = (string)obj + text + (string)obj2;
				object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v15+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj6 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v18+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v18+B8]");
					object obj7 = 0;
					if ((nint)obj7 >= 2)
					{
						goto IL_018c;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj8 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v35+B8]");
					object obj9 = 0;
					if ((nint)obj9 >= 2)
					{
						goto IL_018c;
					}
				}
				goto IL_01f5;
			}
			ex = new NullReferenceException();
			flag2 = false;
		}
		else
		{
			ex = new NullReferenceException();
		}
		goto IL_02e9;
		IL_01f5:
		JsonData jsonData4 = jsonData.get_Item(text);
		if (jsonData4 != null)
		{
			nint num = (nint)jsonData4;
			string value = jsonData4.ToString();
			object obj10 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v16+28]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v24+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return bool.Parse(value);
		}
		ex = new NullReferenceException();
		flag2 = false;
		goto IL_02e9;
		IL_02e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		bool result = default(bool);
		return result;
		IL_018c:
		object obj13 = typeof(DataRelation) + 856;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v30+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogWarning(message);
		goto IL_01f5;
	}

	public static T GetEnum<T>(JsonData obj, string varName, T defaultValue) where T : Enum
	{
		//IL_002a: Expected I4, but got I8
		JsonData jsonData = default(JsonData);
		string name = default(string);
		int index = Get(jsonData, name, -1);
		return EnumExtensions.ToEnum(index, defaultValue);
	}

	public static long[] GetArray(JsonData jsonData, string name, long[] defaultValue)
	{
		//IL_0457: Expected I4, but got O
		//IL_047a: Expected I4, but got O
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_01ea: Expected O, but got I4
		//IL_0263: Expected O, but got I
		//IL_021c: Expected O, but got I
		//IL_018f: Expected O, but got I4
		//IL_042c: Expected I, but got O
		//IL_02aa: Expected O, but got I4
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_0403: Expected I, but got O
		//IL_0355: Expected O, but got I4
		//IL_0363: Expected I, but got O
		//IL_037f: Expected I, but got O
		JsonData jsonData2 = default(JsonData);
		if (jsonData2 != null)
		{
			JsonData jsonData3 = jsonData2.get_Item(name);
			if (jsonData3 != null)
			{
				int count = jsonData3.Count;
				object obj = typeof(TypeConverter<ushort, char>) + 3056;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				object obj2 = "_InputUv1BufferOffset" + 3984;
				object obj3 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 1008;
				object obj4 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
				object obj5 = typeof(DataRelation) + 856;
				int num = 0;
				long[] array = default(long[]);
				while (true)
				{
					int count2 = jsonData3.Count;
					string message;
					long[] array2;
					int num3;
					IndexOutOfRangeException ex;
					if (num < count2)
					{
						JsonData jsonData4 = jsonData3.get_Item(num);
						if (jsonData4 != null)
						{
							if (jsonData4.IsLong)
							{
								JsonData jsonData5 = jsonData3.get_Item(num);
								int num2 = (int)jsonData5;
								if (array != null)
								{
									bool flag = num < array.Length;
									object obj6 = !flag;
									object obj7 = ~obj6;
									if (obj7 == null)
									{
										ex = new IndexOutOfRangeException();
										array2 = null;
										num3 = 0;
										break;
									}
									goto IL_00b7;
								}
								NullReferenceException ex2 = new NullReferenceException();
								array2 = null;
								num3 = 0;
								ex = (IndexOutOfRangeException)(object)ex2;
								break;
							}
							message = (string)obj2 + name + (string)obj3;
							object obj8 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v24+E4]");
							bool flag2 = (nint)0 == 0;
							object obj9 = !flag2;
							if (obj9 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj10 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X0_v27+E4]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X0_v27+B8]");
								object obj11 = 0;
								if ((nint)obj11 >= 2)
								{
									goto IL_0280;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj12 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v42+B8]");
								object obj13 = 0;
								if ((nint)obj13 >= 2)
								{
									goto IL_0280;
								}
							}
							goto IL_02d5;
						}
						NullReferenceException ex3 = new NullReferenceException();
						array2 = null;
						num3 = num;
						ex = (IndexOutOfRangeException)(object)ex3;
						break;
					}
					return array;
					IL_02d5:
					JsonData jsonData6 = jsonData3.get_Item(num);
					nint num4;
					if (jsonData6 != null)
					{
						string s = jsonData6.ToString();
						int num2 = int.Parse(s);
						if (array != null)
						{
							bool flag3 = num < array.Length;
							object obj14 = !flag3;
							object obj15 = ~obj14;
							num4 = unchecked((nint)null);
							if (obj15 == null)
							{
								ex = new IndexOutOfRangeException();
								num4 = unchecked((nint)null);
								array2 = null;
								num3 = 0;
								break;
							}
							goto IL_00b7;
						}
						NullReferenceException ex4 = new NullReferenceException();
						num4 = unchecked((nint)null);
						array2 = null;
						num3 = 0;
						ex = (IndexOutOfRangeException)(object)ex4;
						break;
					}
					NullReferenceException ex5 = new NullReferenceException();
					num4 = unchecked((nint)null);
					array2 = null;
					num3 = num;
					ex = (IndexOutOfRangeException)(object)ex5;
					break;
					IL_00b7:
					object obj16 = array + num;
					num++;
					continue;
					IL_0280:
					object obj17 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v37+E4]");
					bool flag4 = (nint)0 == 0;
					object obj18 = !flag4;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Debug.LogWarning(message);
					goto IL_02d5;
				}
			}
			else
			{
				NullReferenceException ex6 = new NullReferenceException();
				long[] array2 = null;
				int num3 = (int)name;
				IndexOutOfRangeException ex = (IndexOutOfRangeException)(object)ex6;
			}
		}
		else
		{
			NullReferenceException ex7 = new NullReferenceException();
			int num3 = (int)name;
			IndexOutOfRangeException ex = (IndexOutOfRangeException)(object)ex7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		long[] result = default(long[]);
		return result;
	}

	public static List<string> GetArray(JsonData jsonData, string name, List<string> defaultValue)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_04d1: Expected O, but got I4
		//IL_0260: Expected O, but got I4
		//IL_02d9: Expected O, but got I
		//IL_0292: Expected O, but got I
		//IL_04ff: Expected I, but got O
		//IL_050c: Expected O, but got I4
		//IL_0320: Expected O, but got I4
		//IL_01b7: Expected O, but got I4
		//IL_04a9: Expected I, but got O
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0413: Expected O, but got I4
		//IL_0496: Expected I, but got O
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected O, but got Unknown
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected O, but got Unknown
		//IL_047d: Expected I, but got O
		JsonData jsonData2 = default(JsonData);
		if (jsonData2 != null)
		{
			JsonData jsonData3 = jsonData2.get_Item(name);
			if (jsonData3 != null)
			{
				object obj = "_InputUv1BufferOffset" + 3984;
				object obj2 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 1016;
				object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
				object obj4 = typeof(DataRelation) + 856;
				int num = 0;
				List<string> list = default(List<string>);
				while (true)
				{
					int count = jsonData3.Count;
					string message;
					if (num < count)
					{
						JsonData jsonData4 = jsonData3.get_Item(num);
						NullReferenceException ex;
						object obj8;
						if (jsonData4 != null)
						{
							if (jsonData4.IsString)
							{
								JsonData jsonData5 = jsonData3.get_Item(num);
								string text = (string)jsonData5;
								if (list != null)
								{
									int version = list._version + 1;
									list._version = version;
									string[] items = list._items;
									if (list._items != null)
									{
										bool flag = list._size < items.Length;
										object obj5 = !flag;
										if (obj5 != null)
										{
											((List<object>)(object)list).AddWithResize((object)text);
										}
										else
										{
											int size = list._size + 1;
											list._size = size;
											object obj6 = list._items + list._size;
											object obj7 = obj6 + 32;
											obj7 = text;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										}
										goto IL_009c;
									}
								}
								ex = new NullReferenceException();
								list = null;
								obj8 = text;
								break;
							}
							message = (string)obj + name + (string)obj2;
							object obj9 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v20+E4]");
							bool flag2 = (nint)0 == 0;
							object obj10 = !flag2;
							if (obj10 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj11 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v23+E4]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v23+B8]");
								object obj12 = 0;
								if ((nint)obj12 >= 2)
								{
									goto IL_02f6;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj13 = obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v40+B8]");
								object obj14 = 0;
								if ((nint)obj14 >= 2)
								{
									goto IL_02f6;
								}
							}
							goto IL_034b;
						}
						ex = new NullReferenceException();
						list = null;
						obj8 = num;
						break;
					}
					return list;
					IL_034b:
					JsonData jsonData6 = jsonData3.get_Item(num);
					if (jsonData6 != null)
					{
						object obj15 = jsonData6.ToString();
						nint num2;
						if (list != null)
						{
							int version2 = list._version + 1;
							list._version = version2;
							string[] items2 = list._items;
							if (list._items != null)
							{
								bool flag3 = list._size < items2.Length;
								object obj16 = !flag3;
								if (obj16 == null)
								{
									int size2 = list._size + 1;
									list._size = size2;
									object obj17 = list._items + list._size;
									object obj18 = obj17 + 32;
									obj18 = obj15;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									num2 = unchecked((nint)null);
								}
								else
								{
									((List<object>)(object)list).AddWithResize(obj15);
									num2 = unchecked((nint)null);
								}
								goto IL_009c;
							}
						}
						NullReferenceException ex = new NullReferenceException();
						num2 = unchecked((nint)null);
						list = null;
						object obj8 = obj15;
					}
					else
					{
						NullReferenceException ex = new NullReferenceException();
						nint num2 = unchecked((nint)null);
						list = null;
						object obj8 = num;
					}
					break;
					IL_02f6:
					object obj19 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v35+E4]");
					bool flag4 = (nint)0 == 0;
					object obj20 = !flag4;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Debug.LogWarning(message);
					goto IL_034b;
					IL_009c:
					num++;
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
				List<string> list = null;
				object obj8 = name;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
			object obj8 = name;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		List<string> result = default(List<string>);
		return result;
	}

	public static List<JsonData> GetArray(JsonData jsonData, string name, List<JsonData> defaultValue)
	{
		//IL_0114: Expected O, but got I4
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		JsonData jsonData2 = default(JsonData);
		List<JsonData> list2;
		NullReferenceException ex;
		List<JsonData> list = default(List<JsonData>);
		if (jsonData2 != null)
		{
			string prop_name = default(string);
			JsonData jsonData3 = jsonData2.get_Item(prop_name);
			if (jsonData3 != null)
			{
				if (list != null)
				{
					int num = 0;
					while (true)
					{
						int count = jsonData3.Count;
						if (num >= count)
						{
							break;
						}
						JsonData jsonData4 = jsonData3.get_Item(num);
						int version = list._version + 1;
						list._version = version;
						JsonData[] items = list._items;
						bool flag = list._items == null;
						list2 = null;
						prop_name = (string)jsonData4;
						if (!flag)
						{
							bool flag2 = list._size < items.Length;
							object obj = !flag2;
							if (obj != null)
							{
								((List<object>)(object)list).AddWithResize((object)jsonData4);
							}
							else
							{
								int size = list._size + 1;
								list._size = size;
								object obj2 = list._items + list._size;
								object obj3 = obj2 + 32;
								obj3 = jsonData4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							}
							num++;
							continue;
						}
						goto IL_01f2;
					}
				}
				else
				{
					int count2 = jsonData3.Count;
					if (count2 >= 1)
					{
						JsonData jsonData5 = jsonData3.get_Item(0);
						list2 = null;
						prop_name = null;
						goto IL_01f2;
					}
				}
				return list;
			}
			ex = new NullReferenceException();
			list = null;
		}
		else
		{
			ex = new NullReferenceException();
		}
		goto IL_0208;
		IL_0208:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		List<JsonData> result = default(List<JsonData>);
		return result;
		IL_01f2:
		ex = new NullReferenceException();
		list = list2;
		goto IL_0208;
	}

	public static List<List<int>> GetArrayOfArrays(JsonData jsonData, string name, List<List<int>> defaultValue)
	{
		//IL_07cb: Expected I4, but got O
		//IL_07e6: Expected I4, but got O
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_05d1: Expected O, but got I
		//IL_0648: Expected O, but got I4
		//IL_008e: Expected O, but got I
		//IL_009e: Expected O, but got I
		//IL_00ae: Expected O, but got I
		//IL_0688: Unknown result type (might be due to invalid IL or missing references)
		//IL_068d: Expected O, but got Unknown
		//IL_0696: Unknown result type (might be due to invalid IL or missing references)
		//IL_069b: Expected O, but got Unknown
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		//IL_0363: Expected O, but got I4
		//IL_03dc: Expected O, but got I
		//IL_0395: Expected O, but got I
		//IL_076c: Expected I, but got O
		//IL_0423: Expected O, but got I4
		//IL_026f: Expected O, but got I
		//IL_0284: Expected O, but got I
		//IL_078c: Expected I, but got O
		//IL_02b9: Expected O, but got I
		//IL_02e2: Expected O, but got I4
		//IL_0731: Expected I, but got O
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_04f8: Expected O, but got I
		//IL_050d: Expected O, but got I
		//IL_0542: Expected O, but got I
		//IL_056b: Expected O, but got I4
		//IL_0579: Expected I, but got O
		//IL_05a3: Expected I, but got O
		JsonData jsonData2 = default(JsonData);
		if (jsonData2 != null)
		{
			JsonData jsonData3 = jsonData2.get_Item(name);
			if (jsonData3 != null)
			{
				object obj = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 1000;
				object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
				object obj3 = typeof(DataRelation) + 856;
				int num = 0;
				List<List<int>> list = null;
				List<int> list2 = default(List<int>);
				List<List<int>> list3 = default(List<List<int>>);
				while (true)
				{
					int count = jsonData3.Count;
					int num2;
					int num3;
					int num6;
					nint num8;
					NullReferenceException ex;
					int num9;
					if (num < count)
					{
						object obj4 = typeof(List<AdaptivePerformanceScaler>) + 1800;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						list2..ctor();
						num2 = 0;
						while (true)
						{
							JsonData jsonData4 = jsonData3.get_Item(num);
							if (jsonData4 == null)
							{
								break;
							}
							int count2 = jsonData4.Count;
							if (num2 >= count2)
							{
								goto IL_05a8;
							}
							JsonData jsonData5 = jsonData3.get_Item(num);
							if (jsonData5 == null)
							{
								goto IL_06d2;
							}
							JsonData jsonData6 = jsonData5.get_Item(num2);
							if (jsonData6 == null)
							{
								goto IL_0708;
							}
							object obj6;
							object obj7;
							if (jsonData6.IsInt)
							{
								JsonData jsonData7 = jsonData3.get_Item(num);
								if (jsonData7 != null)
								{
									JsonData jsonData8 = jsonData7.get_Item(num2);
									num3 = (int)jsonData8;
									if (list2 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v15 (System.Collections.Generic.List`1<System.Int32>)+1C]");
										object obj5 = (nint)0 + (nint)1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v15 (System.Collections.Generic.List`1<System.Int32>)+10]");
										obj6 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v15 (System.Collections.Generic.List`1<System.Int32>)+10]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v15 (System.Collections.Generic.List`1<System.Int32>)+18]");
											obj7 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v15 (System.Collections.Generic.List`1<System.Int32>)+18]");
											nint num4 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v46+18]");
											bool flag = num4 < 0;
											object obj8 = !flag;
											object obj9 = ~obj8;
											int num5 = num3;
											if (obj9 == null)
											{
												list2.AddWithResize(num3);
												goto IL_0890;
											}
											goto IL_010e;
										}
									}
									goto IL_06ed;
								}
								goto IL_0743;
							}
							object obj10 = "_InputUv1BufferOffset" + 3984;
							string message = (string)obj10 + name + (string)obj;
							object obj11 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v36+E4]");
							bool flag2 = (nint)0 == 0;
							object obj12 = !flag2;
							if (obj12 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj13 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v39+E4]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v39+B8]");
								object obj14 = 0;
								if ((nint)obj14 >= 2)
								{
									goto IL_03f9;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj15 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X0_v56+B8]");
								object obj16 = 0;
								if ((nint)obj16 >= 2)
								{
									goto IL_03f9;
								}
							}
							goto IL_044e;
							IL_044e:
							JsonData jsonData9 = jsonData3.get_Item(num);
							if (jsonData9 == null)
							{
								goto IL_075e;
							}
							JsonData jsonData10 = jsonData9.get_Item(num2);
							if (jsonData10 != null)
							{
								string s = jsonData10.ToString();
								num6 = int.Parse(s);
								if (list2 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v15 (System.Collections.Generic.List`1<System.Int32>)+1C]");
									object obj17 = (nint)0 + (nint)1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v15 (System.Collections.Generic.List`1<System.Int32>)+10]");
									obj6 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v15 (System.Collections.Generic.List`1<System.Int32>)+10]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v15 (System.Collections.Generic.List`1<System.Int32>)+18]");
										obj7 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v15 (System.Collections.Generic.List`1<System.Int32>)+18]");
										nint num7 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v46+18]");
										bool flag3 = num7 < 0;
										object obj18 = !flag3;
										object obj19 = ~obj18;
										num8 = unchecked((nint)null);
										int num5 = num6;
										if (obj19 == null)
										{
											list2.AddWithResize(num6);
											num8 = unchecked((nint)null);
											goto IL_0890;
										}
										goto IL_010e;
									}
								}
								goto IL_0723;
							}
							goto IL_077e;
							IL_010e:
							object obj20 = obj7 + 1;
							object obj21 = obj6 + obj7;
							goto IL_0890;
							IL_03f9:
							object obj22 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X0_v51+E4]");
							bool flag4 = (nint)0 == 0;
							object obj23 = !flag4;
							if (obj23 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Debug.LogWarning(message);
							goto IL_044e;
							IL_0890:
							num2++;
						}
						ex = new NullReferenceException();
						list3 = null;
						num9 = num;
						break;
					}
					return list3;
					IL_06d2:
					ex = new NullReferenceException();
					list3 = null;
					num9 = num;
					break;
					IL_05a8:
					if (list3 != null)
					{
						object obj24 = (nint)0 + (nint)2920;
						object obj25 = obj24;
						int version = ((List<object>)(object)list3)._version + 1;
						((List<object>)(object)list3)._version = version;
						object[] items = ((List<object>)(object)list3)._items;
						if (((List<object>)(object)list3)._items != null)
						{
							bool flag5 = ((List<object>)(object)list3)._size < items.Length;
							object obj26 = !flag5;
							if (obj26 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v13+20]");
								object obj27 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v16+C0]");
								object obj28 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v17+70]");
								list = (List<List<int>>)0;
								((List<object>)(object)list3).AddWithResize((object)list2);
							}
							else
							{
								int size = ((List<object>)(object)list3)._size + 1;
								((List<object>)(object)list3)._size = size;
								object obj29 = ((List<object>)(object)list3)._items + ((List<object>)(object)list3)._size;
								object obj30 = obj29 + 32;
								obj30 = list2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								list = null;
							}
							num++;
							continue;
						}
					}
					ex = new NullReferenceException();
					list3 = null;
					num9 = 0;
					break;
					IL_06ed:
					ex = new NullReferenceException();
					list3 = null;
					num9 = num3;
					break;
					IL_0743:
					ex = new NullReferenceException();
					list3 = null;
					num9 = num;
					break;
					IL_0723:
					ex = new NullReferenceException();
					num8 = unchecked((nint)null);
					list3 = null;
					num9 = num6;
					break;
					IL_077e:
					ex = new NullReferenceException();
					num8 = unchecked((nint)null);
					list3 = null;
					num9 = num2;
					break;
					IL_075e:
					ex = new NullReferenceException();
					num8 = unchecked((nint)null);
					list3 = null;
					num9 = num;
					break;
					IL_0708:
					ex = new NullReferenceException();
					list3 = null;
					num9 = num2;
					break;
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
				List<List<int>> list3 = null;
				int num9 = (int)name;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
			int num9 = (int)name;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		List<List<int>> result = default(List<List<int>>);
		return result;
	}

	public static bool Contains(JsonData jsonData, string name)
	{
		//IL_0187: Expected I4, but got O
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0071: Expected I, but got O
		//IL_0081: Expected O, but got I
		//IL_011f: Expected O, but got I
		//IL_00bc: Expected O, but got I
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_016f: Expected O, but got I
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		bool isObject;
		if (jsonData != null)
		{
			isObject = jsonData.IsObject;
			if (!isObject)
			{
				goto IL_0129;
			}
			ICollection<string> keys = jsonData.Keys;
			if (keys != null)
			{
				object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2240;
				nint num = (nint)keys;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v5 (Il2CppClass<System.Collections.Generic.ICollection`1<System.String>>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v5 (Il2CppClass<System.Collections.Generic.ICollection`1<System.String>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00fd;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v5 (Il2CppClass<System.Collections.Generic.ICollection`1<System.String>>)+B0]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v4-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj3 += 16;
					obj2--;
					if ((nint)obj2 != 1)
					{
						continue;
					}
					goto IL_00fd;
				}
				object obj4 = obj3 + 4;
				object obj5 = num + obj4;
				object obj6 = obj5 + 312;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v8+8]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v74 @ X3_v2 (should have been resolved before IL gen)");
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_00fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj10 = default(object);
		object obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v8+8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v73 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_0129;
		IL_0129:
		return isObject;
	}
}
