using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using Mono.Btls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.TextCore;

public class PlayerPrefsX
{
	private enum ArrayType
	{
		Float,
		Int32,
		Bool,
		String,
		Vector2,
		Vector3,
		Quaternion,
		Color
	}

	private static int endianDiff1;

	private static int endianDiff2;

	private static int idx;

	private static byte[] byteBlock;

	public static bool SetBool(string name, bool value)
	{
		PlayerPrefs.SetInt(name, value ? 1 : 0);
		return true;
	}

	public static bool GetBool(string name)
	{
		//IL_001b: Expected O, but got I4
		int num = PlayerPrefs.GetInt(name);
		object obj = num - 1;
		return obj == null;
	}

	public static bool GetBool(string name, bool defaultValue)
	{
		//IL_001f: Expected O, but got I4
		int num = PlayerPrefs.GetInt(name, defaultValue ? 1 : 0);
		object obj = num - 1;
		return obj == null;
	}

	public static long GetLong(string key, long defaultValue = 0L)
	{
		//IL_003d: Expected O, but got I4
		string s = PlayerPrefs.GetString(key);
		long result;
		bool flag = long.TryParse(s, out result);
		bool flag2 = !flag;
		object obj = !flag2;
		object obj2 = ~obj;
		if (obj2 == null)
		{
			return result;
		}
		return defaultValue;
	}

	public static void SetLong(string key, long value)
	{
		long num = default(long);
		string value2 = num.ToString();
		PlayerPrefs.SetString(key, value2);
	}

	public static bool SetVector2(string key, Vector2 vector)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00bf: Expected I4, but got O
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_008d: Expected O, but got I
		//IL_0099: Expected O, but got I
		//IL_00fe: Expected I, but got O
		object obj = typeof(TypeConverter<ushort, char>) + 3912;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj2 = default(object);
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+18]");
				if ((nint)0 != 1)
				{
					object obj3 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 880;
					object obj4 = (nint)0 + (nint)912;
					object obj5 = (nint)0 + (nint)880;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Action<object, object, int> action = default(Action<object, object, int>);
					action..ctor((object)null, (IntPtr)obj4);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F706C8");
					bool result = default(bool);
					return result;
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
	}

	private static Vector2 GetVector2(string key)
	{
		Vector2 floatArray = (Vector2)GetFloatArray(key);
		if ((object)floatArray != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal3 @ X0_v3 (UnityEngine.Vector2)+18]");
			if ((nint)0 > (nint)1)
			{
				return floatArray;
			}
			return floatArray;
		}
		return (Vector2)new NullReferenceException();
	}

	public static Vector2 GetVector2(string key, Vector2 defaultValue)
	{
		//IL_0020: Expected O, but got I4
		bool flag = PlayerPrefs.HasKey(key);
		bool flag2 = !flag;
		Vector2 result = (Vector2)flag;
		if (!flag2)
		{
			float[] floatArray = GetFloatArray(key);
			if (floatArray == null)
			{
				return (Vector2)new NullReferenceException();
			}
			result = (Vector2)((floatArray.Length <= 1) ? floatArray : floatArray);
		}
		return result;
	}

	public static bool SetVector3(string key, Vector3 vector)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_012f: Expected I4, but got O
		//IL_008f: Expected O, but got I4
		//IL_00a5: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_00fd: Expected O, but got I
		//IL_0109: Expected O, but got I
		//IL_016e: Expected I, but got O
		object obj = typeof(TypeConverter<ushort, char>) + 3912;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj2 = default(object);
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+18]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+18]");
					bool flag = (nint)0 < (nint)2;
					object obj3 = !flag;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+18]");
					object obj4 = -2;
					bool flag2 = obj4 == null;
					object obj5 = ~obj3;
					object obj6 = obj5 | flag2;
					if (obj6 == null)
					{
						object obj7 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 880;
						object obj8 = (nint)0 + (nint)912;
						object obj9 = (nint)0 + (nint)880;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						Action<object, object, int> action = default(Action<object, object, int>);
						action..ctor((object)null, (IntPtr)obj8);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F706C8");
						bool result = default(bool);
						return result;
					}
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
	}

	public static Vector3 GetVector3(string key)
	{
		Vector3 floatArray = (Vector3)GetFloatArray(key);
		if ((object)floatArray != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal3 @ X0_v3 (UnityEngine.Vector3)+18]");
			if ((nint)0 > (nint)2)
			{
				return floatArray;
			}
			return floatArray;
		}
		return (Vector3)new NullReferenceException();
	}

	public static Vector3 GetVector3(string key, Vector3 defaultValue)
	{
		//IL_0020: Expected O, but got I4
		bool flag = PlayerPrefs.HasKey(key);
		bool flag2 = !flag;
		Vector3 result = (Vector3)flag;
		if (!flag2)
		{
			float[] floatArray = GetFloatArray(key);
			if (floatArray == null)
			{
				return (Vector3)new NullReferenceException();
			}
			result = (Vector3)((floatArray.Length <= 2) ? floatArray : floatArray);
		}
		return result;
	}

	public static bool SetQuaternion(string key, Quaternion vector)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0159: Expected I4, but got O
		//IL_008f: Expected O, but got I4
		//IL_00a5: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0127: Expected O, but got I
		//IL_0133: Expected O, but got I
		//IL_0198: Expected I, but got O
		object obj = typeof(TypeConverter<ushort, char>) + 3912;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj2 = default(object);
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+18]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+18]");
					bool flag = (nint)0 < (nint)2;
					object obj3 = !flag;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+18]");
					object obj4 = -2;
					bool flag2 = obj4 == null;
					object obj5 = ~obj3;
					object obj6 = obj5 | flag2;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+18]");
						if ((nint)0 != 3)
						{
							object obj7 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 880;
							object obj8 = (nint)0 + (nint)912;
							object obj9 = (nint)0 + (nint)880;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							Action<object, object, int> action = default(Action<object, object, int>);
							action..ctor((object)null, (IntPtr)obj8);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F706C8");
							bool result = default(bool);
							return result;
						}
					}
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
	}

	public static Quaternion GetQuaternion(string key)
	{
		float[] floatArray = GetFloatArray(key);
		if (floatArray != null)
		{
			if (floatArray.Length > 3)
			{
				return (Quaternion)floatArray;
			}
			return (Quaternion)floatArray;
		}
		return (Quaternion)new NullReferenceException();
	}

	public static Quaternion GetQuaternion(string key, Quaternion defaultValue)
	{
		//IL_0020: Expected O, but got I4
		bool flag = PlayerPrefs.HasKey(key);
		bool flag2 = !flag;
		Quaternion result = (Quaternion)flag;
		if (!flag2)
		{
			float[] floatArray = GetFloatArray(key);
			if (floatArray == null)
			{
				return (Quaternion)new NullReferenceException();
			}
			result = (Quaternion)((floatArray.Length <= 3) ? floatArray : floatArray);
		}
		return result;
	}

	public static bool SetColor(string key, Color color)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0159: Expected I4, but got O
		//IL_008f: Expected O, but got I4
		//IL_00a5: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0127: Expected O, but got I
		//IL_0133: Expected O, but got I
		//IL_0198: Expected I, but got O
		object obj = typeof(TypeConverter<ushort, char>) + 3912;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj2 = default(object);
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+18]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+18]");
					bool flag = (nint)0 < (nint)2;
					object obj3 = !flag;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+18]");
					object obj4 = -2;
					bool flag2 = obj4 == null;
					object obj5 = ~obj3;
					object obj6 = obj5 | flag2;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+18]");
						if ((nint)0 != 3)
						{
							object obj7 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 880;
							object obj8 = (nint)0 + (nint)912;
							object obj9 = (nint)0 + (nint)880;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							Action<object, object, int> action = default(Action<object, object, int>);
							action..ctor((object)null, (IntPtr)obj8);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F706C8");
							bool result = default(bool);
							return result;
						}
					}
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
	}

	public static Color GetColor(string key)
	{
		Color floatArray = (Color)GetFloatArray(key);
		if ((object)floatArray != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v1 (UnityEngine.Color)+18]");
			if ((nint)0 < (nint)4)
			{
				return floatArray;
			}
		}
		return (Color)new NullReferenceException();
	}

	public static Color GetColor(string key, Color defaultValue)
	{
		//IL_0020: Expected O, but got I4
		bool flag = PlayerPrefs.HasKey(key);
		bool flag2 = !flag;
		Color result = (Color)flag;
		if (!flag2)
		{
			float[] floatArray = GetFloatArray(key);
			if (floatArray == null)
			{
				return (Color)new NullReferenceException();
			}
			bool flag3 = floatArray.Length < 4;
			result = (Color)floatArray;
			if (!flag3)
			{
				result = (Color)floatArray;
			}
		}
		return result;
	}

	public static bool SetBoolArray(string key, bool[] boolArray)
	{
		//IL_03b7: Expected I4, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0051: Expected O, but got I4
		//IL_0061: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected O, but got Unknown
		//IL_042e: Expected O, but got I4
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_017c: Expected O, but got I4
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_01a6: Expected O, but got I
		//IL_02b0: Expected O, but got I
		//IL_02b9: Expected O, but got I4
		//IL_02db: Expected O, but got I4
		//IL_022f: Expected O, but got I
		//IL_0249: Expected O, but got I4
		//IL_0252: Expected O, but got I4
		//IL_01db: Expected O, but got I
		//IL_01e4: Expected O, but got I4
		//IL_0491: Expected O, but got I
		//IL_0311: Expected O, but got I
		//IL_0340: Expected O, but got I
		//IL_0366: Expected O, but got I
		//IL_037e: Expected O, but got I4
		Array array = default(Array);
		object obj16;
		int num;
		int value2;
		object obj27;
		if (boolArray != null)
		{
			object obj = typeof(TypeConverter<ushort, char>) + 1880;
			object obj2 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2456;
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
			object obj4 = boolArray.Length + 7;
			object obj5 = boolArray.Length + 14;
			bool flag = (nint)obj4 < 0;
			object obj6 = obj4 ^ obj4;
			object obj7 = obj4 & obj6;
			bool flag2 = (nint)obj7 < 0;
			bool flag3 = flag == flag2;
			object obj8 = !flag3;
			object obj9 = ~obj8;
			if (obj9 != null)
			{
				obj5 = obj4;
			}
			object obj10 = obj5 >> 3;
			object obj11 = obj10 + 5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object obj12 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object value = default(object);
			byte b = Convert.ToByte(value);
			if (array != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v7 (System.Array)+18]");
				if ((nint)0 == 0)
				{
					goto IL_03a9;
				}
				object obj14 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2848;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				BitArray bitArray = default(BitArray);
				bitArray..ctor(boolArray);
				if (bitArray != null)
				{
					bitArray.CopyTo(array, 5);
					object obj15 = 152985600;
					obj16 = typeof(System.Buffers.Text.ParserHelpers) + 1032;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B9B]");
					object obj17 = (nint)0 & (nint)1;
					if (obj17 != null)
					{
						object obj18 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v28+B8]");
						object obj19 = 0;
						obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v26+10]");
						if ((nint)0 != 0)
						{
							goto IL_0209;
						}
					}
					else
					{
						_ = 1;
						object obj20 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v23+B8]");
						object obj19 = 0;
						obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v26+10]");
						bool flag5 = (nint)0 == 0;
						object obj21 = !flag5;
						if (obj21 != null)
						{
							goto IL_0209;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					object obj22 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v18+B8]");
					object obj23 = (nint)0 + (nint)16;
					Array array2 = default(Array);
					obj23 = array2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj24 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v19+B8]");
					object obj25 = 0;
					_ = 1;
					num = boolArray.Length;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B9D]");
					object obj26 = (nint)0 & (nint)1;
					bool flag6 = obj26 == null;
					obj27 = 1;
					if (flag6)
					{
						goto IL_026a;
					}
					value2 = boolArray.Length;
					goto IL_0466;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_03a9;
		IL_026a:
		value2 = num;
		goto IL_0466;
		IL_03a9:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
		IL_0209:
		_ = 1;
		num = boolArray.Length;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B9D]");
		object obj28 = (nint)0 & (nint)1;
		bool flag7 = obj28 == null;
		object obj29 = !flag7;
		obj27 = 1;
		value2 = boolArray.Length;
		if (obj29 == null)
		{
			goto IL_026a;
		}
		goto IL_0466;
		IL_0466:
		byte[] bytes = BitConverter.GetBytes(value2);
		object obj30 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v16+B8]");
		object obj31 = (nint)0 + (nint)16;
		obj31 = bytes;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ConvertTo4Bytes((byte[])array);
		return SaveBytes(key, (byte[])array);
	}

	public static bool[] GetBoolArray(string key)
	{
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0050: Expected O, but got I4
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_03a5: Expected O, but got I4
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_02c5: Expected O, but got I
		//IL_02ce: Expected O, but got I4
		//IL_02f0: Expected O, but got I4
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected O, but got Unknown
		//IL_03f3: Expected O, but got I4
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_010e: Expected O, but got I
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_013d: Expected O, but got I
		//IL_031f: Expected O, but got I
		//IL_0335: Expected O, but got I
		object obj = typeof(TypeConverter<ushort, char>) + 1832;
		if (PlayerPrefs.HasKey(key))
		{
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
			string s = PlayerPrefs.GetString(key);
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			byte[] array = Convert.FromBase64String(s);
			if (array == null)
			{
				goto IL_023b;
			}
			string text;
			string text2;
			if (array.Length > 4)
			{
				if (array[0] == 2)
				{
					object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1032;
					object obj6 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v18+B8]");
					object obj7 = 0;
					obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v20+10]");
					bool flag2 = (nint)0 == 0;
					object obj8 = !flag2;
					if (obj8 == null)
					{
						object obj9 = typeof(TypeConverter<ushort, char>) + 1880;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
						object obj10 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v33+B8]");
						object obj11 = (nint)0 + (nint)16;
						object obj12 = default(object);
						obj11 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj13 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v34+B8]");
						obj7 = 0;
					}
					_ = 1;
					object obj14 = typeof(TypeConverter<ushort, char>) + 1880;
					object obj15 = array.Length - 5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					Array array2 = default(Array);
					if (array2 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v24 (System.Array)+18]");
						Array.Copy(array, 5, array2, 0, 0);
						object obj16 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2848;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						BitArray bitArray = default(BitArray);
						bitArray..ctor((byte[])array2);
						ConvertFrom4Bytes(array);
						object obj17 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v28+B8]");
						object obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v29+10]");
						int length = BitConverter.ToInt32((byte[])0, 0);
						if (bitArray != null)
						{
							bitArray.Length = length;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
							Array array3 = default(Array);
							bitArray.CopyTo(array3, 0);
							return (bool[])array3;
						}
					}
					goto IL_023b;
				}
				object obj19 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 1304;
				text = (string)obj19;
				text2 = key;
			}
			else
			{
				object obj20 = "Complete" + 1864;
				text2 = (string)obj20;
				text = key;
			}
			string text3 = text2 + text;
			object obj21 = typeof(DataRelation) + 856;
			object obj22 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj23 = !flag3;
			object message = text3;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				message = text3;
			}
			Debug.LogError(message);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		bool[] result = default(bool[]);
		return result;
		IL_023b:
		return (bool[])(object)new NullReferenceException();
	}

	public static bool[] GetBoolArray(string key, bool defaultValue, int defaultSize)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_007d: Expected O, but got I4
		//IL_0098: Expected O, but got I4
		//IL_00c7: Expected O, but got I4
		//IL_020b: Expected O, but got I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_0110: Expected O, but got I4
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I4
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_0127: Expected O, but got I4
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		if (PlayerPrefs.HasKey(key))
		{
			return GetBoolArray(key);
		}
		object obj = typeof(TypeConverter<ushort, char>) + 1832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		bool[] array = default(bool[]);
		if (defaultSize >= 1)
		{
			if (array != null)
			{
				object obj2 = defaultSize - 1;
				bool flag = (nint)obj2 < array.Length;
				object obj3 = !flag;
				object obj4 = ~obj3;
				object obj5 = ~obj4;
				if (obj5 != null)
				{
					obj2 = array.Length;
				}
				bool flag2 = (nint)obj2 < 32;
				object obj6 = !flag2;
				object obj7;
				if (obj6 == null)
				{
					obj7 = 0;
				}
				else
				{
					object obj8 = obj2 + 1;
					object obj9 = obj8 & 0x1F;
					bool flag3 = obj9 == null;
					object obj10 = !flag3;
					if (obj10 == null)
					{
						obj9 = 32;
					}
					obj7 = obj8 - obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					object obj11 = array + 48;
					object obj12 = obj7;
					object obj13 = default(object);
					obj12 = obj13;
					object obj14 = default(object);
					obj11 = obj14;
					object obj15 = default(object);
					do
					{
						obj11 = obj15;
						obj11 += 32;
						obj12 -= 32;
					}
					while ((nint)obj12 != 32);
				}
				object obj16 = array.Length - obj7;
				object obj17 = obj7 + 32;
				object obj18 = defaultSize - obj7;
				while (obj16 != null)
				{
					obj16--;
					obj17++;
					obj18--;
					if ((nint)obj18 != 1)
					{
						continue;
					}
					goto IL_01aa;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
			return (bool[])(object)new NullReferenceException();
		}
		goto IL_01aa;
		IL_01aa:
		return array;
	}

	public static bool SetStringArray(string key, string[] stringArray)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0051: Expected O, but got I4
		//IL_0094: Expected O, but got I4
		//IL_04ef: Expected O, but got I4
		//IL_0553: Expected O, but got I4
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00ff: Expected O, but got I4
		//IL_0115: Expected O, but got I
		//IL_01cd: Expected O, but got I
		//IL_01d6: Expected O, but got I4
		//IL_01f8: Expected O, but got I4
		//IL_014a: Expected O, but got I
		//IL_0153: Expected O, but got I4
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_02a9: Expected O, but got I4
		//IL_022e: Expected O, but got I
		//IL_05fc: Expected O, but got I
		//IL_025d: Expected O, but got I
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected O, but got Unknown
		//IL_03b5: Expected O, but got I4
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected O, but got Unknown
		//IL_0675: Expected O, but got I4
		//IL_03eb: Expected O, but got I
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected O, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		//IL_02ee: Expected O, but got I
		//IL_02fe: Expected O, but got I
		//IL_0314: Expected O, but got I
		//IL_033c: Expected O, but got I4
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected O, but got Unknown
		bool flag = stringArray == null;
		string[] array = stringArray;
		object obj3;
		byte[] array2 = default(byte[]);
		object obj7;
		string[] array4;
		if (!flag)
		{
			object obj = typeof(TypeConverter<ushort, char>) + 1880;
			object obj2 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2456;
			obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
			object obj4 = stringArray.Length + 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object value = default(object);
			byte b = Convert.ToByte(value);
			bool flag3 = array2 == null;
			array = null;
			if (!flag3)
			{
				bool flag4 = array2.Length == 0;
				array = null;
				if (!flag4)
				{
					obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1032;
					object obj8 = array2 + 32;
					obj8 = b;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B9B]");
					object obj9 = (nint)0 & (nint)1;
					if (obj9 != null)
					{
						object obj10 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v45+B8]");
						object obj11 = 0;
						obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v43+10]");
						if ((nint)0 != 0)
						{
							goto IL_0178;
						}
					}
					else
					{
						_ = 1;
						object obj12 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v41+B8]");
						object obj11 = 0;
						obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v43+10]");
						bool flag5 = (nint)0 == 0;
						object obj13 = !flag5;
						if (obj13 != null)
						{
							goto IL_0178;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					object obj14 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v36+B8]");
					object obj15 = (nint)0 + (nint)16;
					string[] array3 = default(string[]);
					obj15 = array3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj16 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v37+B8]");
					object obj17 = 0;
					_ = 1;
					bool flag6 = stringArray.Length < 1;
					array = array3;
					array4 = array3;
					if (!flag6)
					{
						goto IL_0292;
					}
					goto IL_038b;
				}
				goto IL_0492;
			}
		}
		goto IL_04a0;
		IL_0492:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_04a0;
		IL_0178:
		_ = 1;
		bool flag7 = stringArray.Length >= 1;
		array = null;
		if (flag7)
		{
			goto IL_0292;
		}
		array4 = null;
		goto IL_038b;
		IL_038b:
		object obj18 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X0_v29+E4]");
		bool flag8 = (nint)0 == 0;
		object obj19 = !flag8;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = Convert.ToBase64String(array2);
		object separator = (nint)0 + (nint)2000;
		string text2 = string.Join((string)separator, stringArray);
		object obj20 = "{0} color encoding is currently unsupported for outputting to HDR." + 1784;
		string value2 = text + (string)obj20 + text2;
		PlayerPrefs.SetString(key, value2);
		return true;
		IL_0292:
		object obj21 = stringArray + 32;
		object obj22 = 0;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X9_v8+v228 @ X8_v25*8]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X9_v8+v228 @ X8_v25*8]");
			object obj29;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X10_v7+10]");
				if ((nint)0 < (nint)256)
				{
					object obj24 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X11_v7+B8]");
					object obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X12_v7+8]");
					object obj26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X12_v7+8]");
					object obj27 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X12_v7+8]");
					bool flag9 = (nint)0 < (nint)array2.Length;
					object obj28 = !flag9;
					if (obj28 != null)
					{
						break;
					}
					obj22++;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X10_v7+10]");
					_ = 0;
					bool flag10 = (nint)obj22 < stringArray.Length;
					array4 = array;
					if (flag10)
					{
						continue;
					}
					goto IL_038b;
				}
				obj29 = "SetRoomVariables request error" + 3864;
			}
			else
			{
				obj29 = "COORDINATE_TYPE_GCJ_02" + 1656;
			}
			string text3 = (string)obj29 + key;
			object obj30 = typeof(DataRelation) + 856;
			object obj31 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v29+E4]");
			bool flag11 = (nint)0 == 0;
			object obj32 = !flag11;
			object message = text3;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				message = text3;
			}
			Debug.LogError(message);
			goto IL_0484;
		}
		goto IL_0492;
		IL_04a0:
		NullReferenceException ex2 = new NullReferenceException();
		bool flag12 = (nint)array != 1;
		NullReferenceException ex3 = ex2;
		if (!flag12)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			object obj33 = 153100288 + 1024;
			object obj35 = default(object);
			object obj34 = obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F90");
			object obj36 = default(object);
			if (obj36 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				goto IL_0484;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B68");
			object obj37 = obj35;
			array = (string[])(139026432 + 4064);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0C04");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			NullReferenceException ex4 = default(NullReferenceException);
			ex3 = ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		bool result = default(bool);
		return result;
		IL_0484:
		return false;
	}

	public static string[] GetStringArray(string key)
	{
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Expected O, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Expected O, but got Unknown
		//IL_0752: Expected O, but got I4
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_010d: Expected O, but got I4
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected O, but got Unknown
		//IL_038f: Expected O, but got I4
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Expected O, but got Unknown
		//IL_0642: Expected O, but got I
		//IL_064b: Expected O, but got I4
		//IL_066d: Expected O, but got I4
		//IL_07ac: Expected O, but got I4
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01dd: Expected O, but got I
		//IL_020c: Expected O, but got I
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected O, but got Unknown
		//IL_03ed: Expected O, but got I
		//IL_03fd: Expected O, but got I
		//IL_0413: Expected O, but got I
		//IL_043b: Expected O, but got I4
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_0253: Expected O, but got I4
		//IL_025c: Expected O, but got I4
		//IL_0476: Expected O, but got I
		//IL_0495: Expected O, but got I4
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Expected O, but got Unknown
		//IL_06a7: Expected O, but got I
		//IL_06b7: Expected O, but got I
		//IL_06cd: Expected O, but got I
		//IL_06f5: Expected O, but got I4
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected O, but got Unknown
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected O, but got Unknown
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Expected O, but got Unknown
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected O, but got Unknown
		//IL_02e7: Expected O, but got I4
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected O, but got Unknown
		//IL_0330: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 32;
		string text2;
		string[] array2 = default(string[]);
		string text3;
		int num2;
		if (PlayerPrefs.HasKey(key))
		{
			object obj2 = "{0} color encoding is currently unsupported for outputting to HDR." + 1784;
			string text = PlayerPrefs.GetString(key);
			bool flag = obj2 == null;
			int num = 0;
			if (!flag)
			{
				char value = ((string)obj2).get_Chars(0);
				bool flag2 = text == null;
				num2 = 0;
				num = 0;
				if (!flag2)
				{
					int num3 = text.IndexOf(value);
					if (num3 <= 3)
					{
						object obj3 = "Complete" + 1864;
						text2 = (string)obj3;
						text3 = key;
						goto IL_0703;
					}
					string s = text.Substring(0, num3);
					object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
					object obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v16+E4]");
					bool flag3 = (nint)0 == 0;
					object obj6 = !flag3;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					byte[] array = Convert.FromBase64String(s);
					bool flag4 = array == null;
					num2 = num3;
					num = 0;
					if (!flag4)
					{
						bool flag5 = array.Length == 0;
						num2 = num3;
						num = 0;
						if (!flag5)
						{
							object obj7 = array + 32;
							if ((nint)obj7 != 3)
							{
								object obj8 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 1320;
								text3 = (string)obj8;
								object obj9 = 0;
								text2 = key;
								goto IL_0703;
							}
							object obj10 = typeof(System.Buffers.Text.ParserHelpers) + 1032;
							object obj11 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X8_v26+B8]");
							object obj12 = 0;
							obj12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X8_v28+10]");
							bool flag6 = (nint)0 == 0;
							object obj13 = !flag6;
							if (obj13 == null)
							{
								object obj14 = typeof(TypeConverter<ushort, char>) + 1880;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
								object obj15 = typeof(System.Buffers.Text.ParserHelpers) + 1032;
								object obj16 = obj15;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v51+B8]");
								object obj17 = (nint)0 + (nint)16;
								object obj18 = default(object);
								obj17 = obj18;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								object obj19 = obj15;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X8_v52+B8]");
								obj12 = 0;
							}
							_ = 1;
							object obj20 = array.Length - 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
							if ((nint)obj20 < 1)
							{
								goto IL_0346;
							}
							num = num3 + 1;
							if (array2 != null)
							{
								object obj21 = array2 + 32;
								object obj22 = 0;
								object obj9 = 0;
								num2 = num3;
								while (true)
								{
									object obj23 = typeof(System.Buffers.Text.ParserHelpers) + 1032;
									object obj24 = obj23;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v45+B8]");
									object obj25 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X9_v19+8]");
									object obj26 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X9_v19+8]");
									object obj27 = (nint)0 + (nint)1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X9_v19+8]");
									bool flag7 = (nint)0 < (nint)array.Length;
									object obj28 = !flag7;
									if (obj28 != null)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X26_v10+v521 @ X8_v46]");
									num2 = 0;
									int num4 = num;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X26_v10+v521 @ X8_v46]");
									int num5 = (int)((nint)num4 + (nint)0);
									if (num5 <= text._stringLength)
									{
										int startIndex = num;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X26_v10+v521 @ X8_v46]");
										string text4 = text.Substring(startIndex, 0);
										bool flag8 = (nint)obj22 < array2.Length;
										object obj29 = !flag8;
										if (obj29 != null)
										{
											break;
										}
										obj21 = text4;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										obj22++;
										bool flag9 = obj20 != obj22;
										obj9 = 0;
										num = num5;
										if (flag9)
										{
											continue;
										}
										goto IL_0346;
									}
									goto IL_04a3;
								}
							}
							else
							{
								object obj30 = typeof(System.Buffers.Text.ParserHelpers) + 1032;
								object obj31 = obj30;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v39+B8]");
								object obj32 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X9_v15+8]");
								object obj33 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X9_v15+8]");
								object obj34 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X9_v15+8]");
								bool flag10 = (nint)0 < (nint)array.Length;
								object obj35 = !flag10;
								num2 = num3;
								if (obj35 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X26_v10+v523 @ X8_v40]");
									num2 = 0;
									int num6 = num;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X26_v10+v523 @ X8_v40]");
									object obj36 = (nint)num6 + (nint)0;
									bool flag11 = (nint)obj36 <= text._stringLength;
									object obj9 = 0;
									if (!flag11)
									{
										goto IL_04a3;
									}
									string text5 = text.Substring(num, num2);
									return (string[])(object)new NullReferenceException();
								}
							}
						}
						IndexOutOfRangeException ex = new IndexOutOfRangeException();
					}
				}
			}
			throw new NullReferenceException();
		}
		goto IL_03b2;
		IL_03b2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		string[] result = default(string[]);
		return result;
		IL_04a3:
		object obj37 = "Complete" + 1864;
		string text6 = (string)obj37 + key;
		object obj38 = typeof(DataRelation) + 856;
		object obj39 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v6+E4]");
		object message;
		if ((nint)0 != 0)
		{
			obj = typeof(SqlSingle[]) + 32;
			num2 = 0;
			message = text6;
			goto IL_0771;
		}
		obj = typeof(SqlSingle[]) + 32;
		num2 = 0;
		text3 = key;
		string text7 = text6;
		goto IL_077f;
		IL_0771:
		Debug.LogError(message);
		goto IL_03b2;
		IL_0346:
		return array2;
		IL_0703:
		string text8 = text2 + text3;
		object obj40 = typeof(DataRelation) + 856;
		obj39 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v6+E4]");
		bool flag12 = (nint)0 == 0;
		object obj41 = !flag12;
		num2 = 0;
		message = text8;
		if (obj41 != null)
		{
			goto IL_0771;
		}
		num2 = 0;
		text7 = text8;
		goto IL_077f;
		IL_077f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		message = text7;
		goto IL_0771;
	}

	public static string[] GetStringArray(string key, string defaultValue, int defaultSize)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_0086: Expected O, but got I4
		//IL_012d: Expected O, but got I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		if (PlayerPrefs.HasKey(key))
		{
			return GetStringArray(key);
		}
		object obj = typeof(SqlSingle[]) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		string[] array = default(string[]);
		if (defaultSize >= 1)
		{
			if (array != null)
			{
				object obj2 = array + 32;
				object obj3 = 0;
				while (true)
				{
					bool flag = (nint)obj3 < array.Length;
					object obj4 = !flag;
					if (obj4 != null)
					{
						break;
					}
					obj2 = defaultValue;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					obj3++;
					if (defaultSize != (nint)obj3)
					{
						continue;
					}
					goto IL_00cb;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
			return (string[])(object)new NullReferenceException();
		}
		goto IL_00cb;
		IL_00cb:
		return array;
	}

	public static bool SetIntArray(string key, int[] intArray)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_004e: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 864;
		object obj2 = (nint)0 + (nint)920;
		object obj3 = (nint)0 + (nint)864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object, int> action = default(Action<object, object, int>);
		action..ctor((object)null, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F706C8");
		bool result = default(bool);
		return result;
	}

	public static bool SetFloatArray(string key, float[] floatArray)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_004e: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 880;
		object obj2 = (nint)0 + (nint)912;
		object obj3 = (nint)0 + (nint)880;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object, int> action = default(Action<object, object, int>);
		action..ctor((object)null, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F706C8");
		bool result = default(bool);
		return result;
	}

	public static bool SetVector2Array(string key, Vector2[] vector2Array)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_004e: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 888;
		object obj2 = (nint)0 + (nint)936;
		object obj3 = (nint)0 + (nint)888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object, int> action = default(Action<object, object, int>);
		action..ctor((object)null, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F706C8");
		bool result = default(bool);
		return result;
	}

	public static bool SetVector3Array(string key, Vector3[] vector3Array)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_004e: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 896;
		object obj2 = (nint)0 + (nint)944;
		object obj3 = (nint)0 + (nint)896;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object, int> action = default(Action<object, object, int>);
		action..ctor((object)null, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F706C8");
		bool result = default(bool);
		return result;
	}

	public static bool SetQuaternionArray(string key, Quaternion[] quaternionArray)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_004e: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 872;
		object obj2 = (nint)0 + (nint)928;
		object obj3 = (nint)0 + (nint)872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object, int> action = default(Action<object, object, int>);
		action..ctor((object)null, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F706C8");
		bool result = default(bool);
		return result;
	}

	public static bool SetColorArray(string key, Color[] colorArray)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_004e: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 856;
		object obj2 = (nint)0 + (nint)904;
		object obj3 = (nint)0 + (nint)856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object, int> action = default(Action<object, object, int>);
		action..ctor((object)null, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F706C8");
		bool result = default(bool);
		return result;
	}

	private static bool SetValue<T>(string key, T array, ArrayType arrayType, int vectorNumber, Action<T, byte[], int> convert) where T : IList
	{
		//IL_050c: Expected I4, but got O
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0052: Expected I, but got O
		//IL_0062: Expected O, but got I
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected O, but got Unknown
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected O, but got Unknown
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Expected O, but got Unknown
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Expected O, but got Unknown
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a6: Expected O, but got Unknown
		//IL_05d0: Expected O, but got I4
		//IL_009d: Expected O, but got I
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_03ca: Expected I, but got O
		//IL_03da: Expected O, but got I
		//IL_018f: Expected I, but got O
		//IL_019f: Expected O, but got I
		//IL_01e0: Expected O, but got I4
		//IL_0415: Expected O, but got I
		//IL_0494: Expected O, but got I4
		//IL_0325: Expected O, but got I
		//IL_034d: Expected I, but got O
		//IL_035d: Expected O, but got I
		//IL_037f: Expected O, but got I4
		//IL_0215: Expected O, but got I
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected O, but got Unknown
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected O, but got Unknown
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected O, but got Unknown
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected O, but got Unknown
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		//IL_03ad: Expected O, but got I
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		if (array == null)
		{
			goto IL_04f0;
		}
		object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1616;
		nint num = (nint)array;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v5 (Il2CppClass<T>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v5 (Il2CppClass<T>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00de;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v5 (Il2CppClass<T>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X10_v21-8]");
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
			goto IL_00de;
		}
		object obj4 = obj3 + 1;
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		goto IL_0531;
		IL_0487:
		ArrayType arrayType2 = default(ArrayType);
		return SaveBytes(key, (byte[])arrayType2);
		IL_0456:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v437 @ X0_v20] (should have been resolved before IL gen)");
		object obj7 = default(object);
		if ((nint)obj7 <= 0)
		{
			goto IL_0487;
		}
		goto IL_04f0;
		IL_04fe:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (byte)(int)ex != 0;
		IL_01ff:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v28 (Il2CppClass<T>)+B0]");
		object obj8 = (nint)0 + (nint)8;
		object obj9;
		object obj11;
		int num3;
		Action<T, byte[], int> action2;
		int num4;
		int num2;
		Action<T, byte[], int> action;
		object obj10;
		object obj12;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X10_v16-8]");
			if (0 == (nint)obj9)
			{
				break;
			}
			obj10 = obj8 + 16;
			obj11--;
			bool flag = (nint)obj11 != 1;
			num2 = num3;
			action = action2;
			obj12 = obj9;
			num3 = num4;
			obj8 = obj10;
			if (flag)
			{
				continue;
			}
			goto IL_027e;
		}
		object obj13 = obj8 + 1;
		nint num5;
		object obj14 = num5 + obj13;
		object obj15 = obj14 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v501 @ X0_v35] (should have been resolved before IL gen)");
		object obj16 = default(object);
		bool flag2 = num4 >= (nint)obj16;
		obj10 = obj8;
		num3 = num4;
		if (!flag2)
		{
			goto IL_0315;
		}
		goto IL_0487;
		IL_0315:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [convert @ X4 (System.Action`3<T, System.Byte[], System.Int32>)+28]");
		action2 = (Action<T, byte[], int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [convert @ X4 (System.Action`3<T, System.Byte[], System.Int32>)+18] (should have been resolved before IL gen)");
		num4 = num3 + 1;
		obj9 = obj;
		num5 = (nint)array;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v28 (Il2CppClass<T>)+12E]");
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v28 (Il2CppClass<T>)+12E]");
		bool flag3 = (nint)0 == 0;
		object obj17 = !flag3;
		ArrayType arrayType3 = arrayType2;
		if (obj17 != null)
		{
			goto IL_01ff;
		}
		num2 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [convert @ X4 (System.Action`3<T, System.Byte[], System.Int32>)+28]");
		action = (Action<T, byte[], int>)0;
		obj12 = obj;
		num3 = num4;
		goto IL_027e;
		IL_00de:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		arrayType3 = ArrayType.Int32;
		goto IL_0531;
		IL_0531:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v242 @ X0_v6] (should have been resolved before IL gen)");
		object obj18 = typeof(TypeConverter<ushort, char>) + 1880;
		int num6 = default(int);
		object obj20 = default(object);
		object obj19 = num6 * obj20;
		object obj21 = 1 | obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj22 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj23 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v15+E4]");
		bool flag4 = (nint)0 == 0;
		object obj25 = !flag4;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object value = default(object);
		byte b = Convert.ToByte(value);
		if (arrayType2 != ArrayType.Float)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v10 (PlayerPrefsX+ArrayType)+18]");
			if ((nint)0 == 0)
			{
				goto IL_04fe;
			}
			Initialize();
			if (convert != null)
			{
				obj9 = obj;
				num5 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v28 (Il2CppClass<T>)+12E]");
				obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v28 (Il2CppClass<T>)+12E]");
				bool flag5 = (nint)0 == 0;
				action2 = convert;
				num4 = 0;
				num2 = num6;
				action = convert;
				obj10 = 1;
				obj12 = obj;
				num3 = 0;
				if (!flag5)
				{
					goto IL_01ff;
				}
				goto IL_027e;
			}
			nint num7 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v18 (Il2CppClass<T>)+12E]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v18 (Il2CppClass<T>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0456;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v18 (Il2CppClass<T>)+B0]");
			object obj27 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X10_v9-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj27 += 16;
				obj26--;
				if ((nint)obj26 != 1)
				{
					continue;
				}
				goto IL_0456;
			}
			object obj28 = obj27 + 1;
			object obj29 = num7 + obj28;
			object obj30 = obj29 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v532 @ X0_v23] (should have been resolved before IL gen)");
			object obj31 = default(object);
			if ((nint)obj31 <= 0)
			{
				goto IL_0487;
			}
		}
		goto IL_04f0;
		IL_027e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v413 @ X0_v31] (should have been resolved before IL gen)");
		object obj32 = default(object);
		if (num3 < (nint)obj32)
		{
			goto IL_0315;
		}
		goto IL_0487;
		IL_04f0:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_04fe;
	}

	private static void ConvertFromInt(int[] array, byte[] bytes, int i)
	{
		//IL_0038: Expected O, but got I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_00b5: Expected O, but got I
		if (array != null)
		{
			bool flag = i < array.Length;
			object obj = !flag;
			if (obj == null)
			{
				object obj2 = array + i;
				object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1032;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3+20]");
				byte[] bytes2 = BitConverter.GetBytes(0);
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v6+B8]");
				object obj5 = (nint)0 + (nint)16;
				obj5 = bytes2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				ConvertTo4Bytes(bytes);
				return;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		throw new IndexOutOfRangeException();
	}

	private static void ConvertFromFloat(float[] array, byte[] bytes, int i)
	{
		//IL_0038: Expected O, but got I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0093: Expected F4, but got I
		//IL_00b5: Expected O, but got I
		if (array != null)
		{
			bool flag = i < array.Length;
			object obj = !flag;
			if (obj == null)
			{
				object obj2 = array + i;
				object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1032;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+20]");
				byte[] bytes2 = BitConverter.GetBytes(0f);
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v6+B8]");
				object obj5 = (nint)0 + (nint)16;
				obj5 = bytes2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				ConvertTo4Bytes(bytes);
				return;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		throw new IndexOutOfRangeException();
	}

	private static void ConvertFromVector2(Vector2[] array, byte[] bytes, int i)
	{
		//IL_001b: Expected O, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_00aa: Expected F4, but got O
		//IL_00cc: Expected O, but got I
		//IL_0078: Expected O, but got I4
		//IL_00fd: Expected F4, but got I
		//IL_011f: Expected O, but got I
		bool flag = i < array.Length;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = array + i;
			object obj3 = obj2 + 32;
			object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1032;
			byte[] bytes2 = BitConverter.GetBytes((float)obj3);
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v6+B8]");
			object obj6 = (nint)0 + (nint)16;
			obj6 = bytes2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			ConvertTo4Bytes(bytes);
			bool flag2 = i < array.Length;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X24_v4+4]");
				byte[] bytes3 = BitConverter.GetBytes(0f);
				object obj8 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v10+B8]");
				object obj9 = (nint)0 + (nint)16;
				obj9 = bytes3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				ConvertTo4Bytes(bytes);
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private static void ConvertFromVector3(Vector3[] array, byte[] bytes, int i)
	{
		//IL_001b: Expected O, but got I4
		//IL_0037: Expected O, but got I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_00e6: Expected F4, but got O
		//IL_0108: Expected O, but got I
		//IL_0086: Expected O, but got I4
		//IL_0139: Expected F4, but got I
		//IL_015b: Expected O, but got I
		//IL_00b4: Expected O, but got I4
		//IL_018c: Expected F4, but got I
		//IL_01ae: Expected O, but got I
		bool flag = i < array.Length;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = i * 12;
			object obj3 = (object)array + obj2;
			object obj4 = obj3 + 32;
			object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1032;
			byte[] bytes2 = BitConverter.GetBytes((float)obj4);
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v7+B8]");
			object obj7 = (nint)0 + (nint)16;
			obj7 = bytes2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			ConvertTo4Bytes(bytes);
			bool flag2 = i < array.Length;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X24_v4+4]");
				byte[] bytes3 = BitConverter.GetBytes(0f);
				object obj9 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v11+B8]");
				object obj10 = (nint)0 + (nint)16;
				obj10 = bytes3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				ConvertTo4Bytes(bytes);
				bool flag3 = i < array.Length;
				object obj11 = !flag3;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X24_v4+8]");
					byte[] bytes4 = BitConverter.GetBytes(0f);
					object obj12 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v15+B8]");
					object obj13 = (nint)0 + (nint)16;
					obj13 = bytes4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					ConvertTo4Bytes(bytes);
					return;
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private static void ConvertFromQuaternion(Quaternion[] array, byte[] bytes, int i)
	{
		//IL_001b: Expected O, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0106: Expected F4, but got O
		//IL_0128: Expected O, but got I
		//IL_0078: Expected O, but got I4
		//IL_0159: Expected F4, but got I
		//IL_017b: Expected O, but got I
		//IL_00a6: Expected O, but got I4
		//IL_01ac: Expected F4, but got I
		//IL_01ce: Expected O, but got I
		//IL_00d4: Expected O, but got I4
		//IL_01ff: Expected F4, but got I
		//IL_0221: Expected O, but got I
		bool flag = i < array.Length;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = array + i;
			object obj3 = obj2 + 32;
			object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1032;
			byte[] bytes2 = BitConverter.GetBytes((float)obj3);
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v6+B8]");
			object obj6 = (nint)0 + (nint)16;
			obj6 = bytes2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			ConvertTo4Bytes(bytes);
			bool flag2 = i < array.Length;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X24_v4+4]");
				byte[] bytes3 = BitConverter.GetBytes(0f);
				object obj8 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v10+B8]");
				object obj9 = (nint)0 + (nint)16;
				obj9 = bytes3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				ConvertTo4Bytes(bytes);
				bool flag3 = i < array.Length;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X24_v4+8]");
					byte[] bytes4 = BitConverter.GetBytes(0f);
					object obj11 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v14+B8]");
					object obj12 = (nint)0 + (nint)16;
					obj12 = bytes4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					ConvertTo4Bytes(bytes);
					bool flag4 = i < array.Length;
					object obj13 = !flag4;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X24_v4+C]");
						byte[] bytes5 = BitConverter.GetBytes(0f);
						object obj14 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v18+B8]");
						object obj15 = (nint)0 + (nint)16;
						obj15 = bytes5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						ConvertTo4Bytes(bytes);
						return;
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private static void ConvertFromColor(Color[] array, byte[] bytes, int i)
	{
		//IL_001b: Expected O, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0106: Expected F4, but got O
		//IL_0128: Expected O, but got I
		//IL_0078: Expected O, but got I4
		//IL_0159: Expected F4, but got I
		//IL_017b: Expected O, but got I
		//IL_00a6: Expected O, but got I4
		//IL_01ac: Expected F4, but got I
		//IL_01ce: Expected O, but got I
		//IL_00d4: Expected O, but got I4
		//IL_01ff: Expected F4, but got I
		//IL_0221: Expected O, but got I
		bool flag = i < array.Length;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = array + i;
			object obj3 = obj2 + 32;
			object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1032;
			byte[] bytes2 = BitConverter.GetBytes((float)obj3);
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v6+B8]");
			object obj6 = (nint)0 + (nint)16;
			obj6 = bytes2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			ConvertTo4Bytes(bytes);
			bool flag2 = i < array.Length;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X24_v4+4]");
				byte[] bytes3 = BitConverter.GetBytes(0f);
				object obj8 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v10+B8]");
				object obj9 = (nint)0 + (nint)16;
				obj9 = bytes3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				ConvertTo4Bytes(bytes);
				bool flag3 = i < array.Length;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X24_v4+8]");
					byte[] bytes4 = BitConverter.GetBytes(0f);
					object obj11 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v14+B8]");
					object obj12 = (nint)0 + (nint)16;
					obj12 = bytes4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					ConvertTo4Bytes(bytes);
					bool flag4 = i < array.Length;
					object obj13 = !flag4;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X24_v4+C]");
						byte[] bytes5 = BitConverter.GetBytes(0f);
						object obj14 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v18+B8]");
						object obj15 = (nint)0 + (nint)16;
						obj15 = bytes5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						ConvertTo4Bytes(bytes);
						return;
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	public static int[] GetIntArray(string key)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004c: Expected O, but got I
		//IL_005f: Expected I, but got O
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1800;
		object obj2 = (nint)0 + (nint)1312;
		object obj3 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 120;
		object obj4 = (nint)0 + (nint)968;
		object obj5 = (nint)0 + (nint)816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<int> list = default(List<int>);
		list..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action = default(Action<object, object>);
		action..ctor((object)null, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F6FE40");
		if (list != null)
		{
			return list.ToArray();
		}
		return (int[])(object)new NullReferenceException();
	}

	public static int[] GetIntArray(string key, int defaultValue, int defaultSize)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_007d: Expected O, but got I4
		//IL_0098: Expected O, but got I4
		//IL_00c7: Expected O, but got I4
		//IL_0219: Expected O, but got I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_0110: Expected O, but got I4
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I4
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_0127: Expected O, but got I4
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		if (PlayerPrefs.HasKey(key))
		{
			return GetIntArray(key);
		}
		object obj = typeof(TypeConverter<ushort, char>) + 3048;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		int[] array = default(int[]);
		if (defaultSize >= 1)
		{
			if (array != null)
			{
				object obj2 = defaultSize - 1;
				bool flag = (nint)obj2 < array.Length;
				object obj3 = !flag;
				object obj4 = ~obj3;
				object obj5 = ~obj4;
				if (obj5 != null)
				{
					obj2 = array.Length;
				}
				bool flag2 = (nint)obj2 < 8;
				object obj6 = !flag2;
				object obj7;
				if (obj6 == null)
				{
					obj7 = 0;
				}
				else
				{
					object obj8 = obj2 + 1;
					object obj9 = obj8 & 7;
					bool flag3 = obj9 == null;
					object obj10 = !flag3;
					if (obj10 == null)
					{
						obj9 = 8;
					}
					obj7 = obj8 - obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					object obj11 = array + 48;
					object obj12 = obj7;
					object obj13 = default(object);
					obj12 = obj13;
					object obj14 = default(object);
					obj11 = obj14;
					object obj15 = default(object);
					do
					{
						obj11 = obj15;
						obj11 += 32;
						obj12 -= 8;
					}
					while ((nint)obj12 != 8);
				}
				object obj16 = array.Length - obj7;
				object obj17 = obj7 << 2;
				object obj18 = obj17 + 32;
				object obj19 = defaultSize - obj7;
				while (obj16 != null)
				{
					obj16--;
					obj18 += 4;
					obj19--;
					if ((nint)obj19 != 1)
					{
						continue;
					}
					goto IL_01b8;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
			return (int[])(object)new NullReferenceException();
		}
		goto IL_01b8;
		IL_01b8:
		return array;
	}

	public static float[] GetFloatArray(string key)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004c: Expected O, but got I
		//IL_005f: Expected I, but got O
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3320;
		object obj2 = (nint)0 + (nint)1376;
		object obj3 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 152;
		object obj4 = (nint)0 + (nint)960;
		object obj5 = (nint)0 + (nint)832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<float> list = default(List<float>);
		list..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action = default(Action<object, object>);
		action..ctor((object)null, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F6FE40");
		if (list != null)
		{
			return list.ToArray();
		}
		return (float[])(object)new NullReferenceException();
	}

	public static float[] GetFloatArray(string key, float defaultValue, int defaultSize)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_007d: Expected O, but got I4
		//IL_0098: Expected O, but got I4
		//IL_00c7: Expected O, but got I4
		//IL_0219: Expected O, but got I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_0110: Expected O, but got I4
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I4
		//IL_0293: Expected O, but got F4
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_0127: Expected O, but got I4
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		if (PlayerPrefs.HasKey(key))
		{
			return GetFloatArray(key);
		}
		object obj = typeof(TypeConverter<ushort, char>) + 3912;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		float[] array = default(float[]);
		if (defaultSize >= 1)
		{
			if (array != null)
			{
				object obj2 = defaultSize - 1;
				bool flag = (nint)obj2 < array.Length;
				object obj3 = !flag;
				object obj4 = ~obj3;
				object obj5 = ~obj4;
				if (obj5 != null)
				{
					obj2 = array.Length;
				}
				bool flag2 = (nint)obj2 < 8;
				object obj6 = !flag2;
				object obj7;
				if (obj6 == null)
				{
					obj7 = 0;
				}
				else
				{
					object obj8 = obj2 + 1;
					object obj9 = obj8 & 7;
					bool flag3 = obj9 == null;
					object obj10 = !flag3;
					if (obj10 == null)
					{
						obj9 = 8;
					}
					obj7 = obj8 - obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					object obj11 = array + 48;
					object obj12 = obj7;
					object obj13 = default(object);
					obj12 = obj13;
					object obj14 = default(object);
					obj11 = obj14;
					do
					{
						obj11 = defaultValue;
						obj11 += 32;
						obj12 -= 8;
					}
					while ((nint)obj12 != 8);
				}
				object obj15 = array.Length - obj7;
				object obj16 = obj7 << 2;
				object obj17 = obj16 + 32;
				object obj18 = defaultSize - obj7;
				while (obj15 != null)
				{
					obj15--;
					obj17 += 4;
					obj18--;
					if ((nint)obj18 != 1)
					{
						continue;
					}
					goto IL_01b8;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
			return (float[])(object)new NullReferenceException();
		}
		goto IL_01b8;
		IL_01b8:
		return array;
	}

	public static Vector2[] GetVector2Array(string key)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004c: Expected O, but got I
		//IL_005f: Expected I, but got O
		object obj = typeof(List<Tween>) + 264;
		object obj2 = (nint)0 + (nint)3288;
		object obj3 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 160;
		object obj4 = (nint)0 + (nint)984;
		object obj5 = (nint)0 + (nint)840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<Vector2> list = default(List<Vector2>);
		list..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action = default(Action<object, object>);
		action..ctor((object)null, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F6FE40");
		if (list != null)
		{
			return list.ToArray();
		}
		return (Vector2[])(object)new NullReferenceException();
	}

	public static Vector2[] GetVector2Array(string key, Vector2 defaultValue, int defaultSize)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_0098: Expected O, but got I4
		//IL_00c7: Expected O, but got I4
		//IL_0220: Expected O, but got I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_0110: Expected O, but got I4
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I4
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		//IL_0127: Expected O, but got I4
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		if (PlayerPrefs.HasKey(key))
		{
			return GetVector2Array(key);
		}
		object obj = typeof(SqlSingle[]) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Vector2[] array = default(Vector2[]);
		if ((nint)defaultValue >= 1)
		{
			if (array != null)
			{
				object obj2 = defaultValue - 1;
				bool flag = (nint)obj2 < array.Length;
				object obj3 = !flag;
				object obj4 = ~obj3;
				object obj5 = ~obj4;
				if (obj5 != null)
				{
					obj2 = array.Length;
				}
				bool flag2 = (nint)obj2 < 8;
				object obj6 = !flag2;
				object obj7;
				if (obj6 == null)
				{
					obj7 = 0;
				}
				else
				{
					object obj8 = obj2 + 1;
					object obj9 = obj8 & 7;
					bool flag3 = obj9 == null;
					object obj10 = !flag3;
					if (obj10 == null)
					{
						obj9 = 8;
					}
					obj7 = obj8 - obj9;
					object obj11 = array + 64;
					object obj12 = obj7;
					object obj13 = default(object);
					obj12 = obj13;
					object obj14 = default(object);
					obj11 = obj14;
					object obj15 = default(object);
					do
					{
						obj11 = obj15;
						obj11 += 64;
						obj12 -= 8;
					}
					while ((nint)obj12 != 8);
				}
				object obj16 = array.Length - obj7;
				object obj17 = (object)array + obj7;
				object obj18 = obj17 + 36;
				object obj19 = (object)defaultValue - obj7;
				object obj20 = default(object);
				while (obj16 != null)
				{
					obj18 = obj20;
					obj16--;
					obj18 += 8;
					obj19--;
					if ((nint)obj19 != 1)
					{
						continue;
					}
					goto IL_01bf;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
			return (Vector2[])(object)new NullReferenceException();
		}
		goto IL_01bf;
		IL_01bf:
		return array;
	}

	public static Vector3[] GetVector3Array(string key)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004c: Expected O, but got I
		//IL_005f: Expected I, but got O
		object obj = typeof(List<Tween>) + 272;
		object obj2 = (nint)0 + (nint)3368;
		object obj3 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 168;
		object obj4 = (nint)0 + (nint)992;
		object obj5 = (nint)0 + (nint)848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<Vector3> list = default(List<Vector3>);
		list..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action = default(Action<object, object>);
		action..ctor((object)null, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F6FE40");
		if (list != null)
		{
			return list.ToArray();
		}
		return (Vector3[])(object)new NullReferenceException();
	}

	public static Vector3[] GetVector3Array(string key, Vector3 defaultValue, int defaultSize)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_0098: Expected O, but got I4
		//IL_00c7: Expected O, but got I4
		//IL_0233: Expected O, but got I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_0110: Expected O, but got I4
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I4
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		//IL_0127: Expected O, but got I4
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		if (PlayerPrefs.HasKey(key))
		{
			return GetVector3Array(key);
		}
		object obj = typeof(SqlSingle[]) + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Vector3[] array = default(Vector3[]);
		if ((nint)defaultValue >= 1)
		{
			if (array != null)
			{
				object obj2 = defaultValue - 1;
				bool flag = (nint)obj2 < array.Length;
				object obj3 = !flag;
				object obj4 = ~obj3;
				object obj5 = ~obj4;
				if (obj5 != null)
				{
					obj2 = array.Length;
				}
				bool flag2 = (nint)obj2 < 8;
				object obj6 = !flag2;
				object obj7;
				if (obj6 == null)
				{
					obj7 = 0;
				}
				else
				{
					object obj8 = obj2 + 1;
					object obj9 = obj8 & 7;
					bool flag3 = obj9 == null;
					object obj10 = !flag3;
					if (obj10 == null)
					{
						obj9 = 8;
					}
					obj7 = obj8 - obj9;
					object obj11 = array + 80;
					object obj12 = obj7;
					object obj13 = default(object);
					obj12 = obj13;
					object obj14 = default(object);
					obj11 = obj14;
					object obj15 = default(object);
					do
					{
						obj11 = obj15;
						obj11 += 96;
						obj12 -= 8;
					}
					while ((nint)obj12 != 8);
				}
				object obj16 = array.Length - obj7;
				object obj17 = (object)defaultValue - obj7;
				object obj18 = obj7 * 12;
				object obj19 = (object)array + obj18;
				object obj20 = obj19 + 40;
				object obj21 = default(object);
				while (obj16 != null)
				{
					obj16--;
					obj20 = obj21;
					obj20 += 12;
					obj17--;
					if ((nint)obj17 != 1)
					{
						continue;
					}
					goto IL_01d2;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
			return (Vector3[])(object)new NullReferenceException();
		}
		goto IL_01d2;
		IL_01d2:
		return array;
	}

	public static Quaternion[] GetQuaternionArray(string key)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004c: Expected O, but got I
		//IL_005f: Expected I, but got O
		object obj = typeof(List<AdaptivePerformanceScaler>) + 2856;
		object obj2 = (nint)0 + (nint)2872;
		object obj3 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 144;
		object obj4 = (nint)0 + (nint)976;
		object obj5 = (nint)0 + (nint)824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<Quaternion> list = default(List<Quaternion>);
		list..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action = default(Action<object, object>);
		action..ctor((object)null, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F6FE40");
		if (list != null)
		{
			return list.ToArray();
		}
		return (Quaternion[])(object)new NullReferenceException();
	}

	public static Quaternion[] GetQuaternionArray(string key, Quaternion defaultValue, int defaultSize)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_0098: Expected O, but got I4
		//IL_00c7: Expected O, but got I4
		//IL_022a: Expected O, but got I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_0110: Expected O, but got I4
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I4
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected O, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected O, but got Unknown
		//IL_0127: Expected O, but got I4
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		if (PlayerPrefs.HasKey(key))
		{
			return GetQuaternionArray(key);
		}
		object obj = typeof(TypeConverter<ushort, char>) + 3584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Quaternion[] array = default(Quaternion[]);
		if ((nint)defaultValue >= 1)
		{
			if (array != null)
			{
				object obj2 = defaultValue - 1;
				bool flag = (nint)obj2 < array.Length;
				object obj3 = !flag;
				object obj4 = ~obj3;
				object obj5 = ~obj4;
				if (obj5 != null)
				{
					obj2 = array.Length;
				}
				bool flag2 = (nint)obj2 < 8;
				object obj6 = !flag2;
				object obj7;
				if (obj6 == null)
				{
					obj7 = 0;
				}
				else
				{
					object obj8 = obj2 + 1;
					object obj9 = obj8 & 7;
					bool flag3 = obj9 == null;
					object obj10 = !flag3;
					if (obj10 == null)
					{
						obj9 = 8;
					}
					obj7 = obj8 - obj9;
					object obj11 = array + 96;
					object obj12 = obj7;
					object obj13 = default(object);
					obj12 = obj13;
					object obj14 = default(object);
					obj11 = obj14;
					object obj15 = default(object);
					do
					{
						obj11 = obj15;
						obj11 += 128;
						obj12 -= 8;
					}
					while ((nint)obj12 != 8);
				}
				object obj16 = array.Length - obj7;
				object obj17 = (object)defaultValue - obj7;
				object obj18 = (object)array + obj7;
				object obj19 = obj18 + 44;
				object obj20 = default(object);
				while (obj16 != null)
				{
					obj16--;
					obj19 = obj20;
					obj19 += 16;
					obj17--;
					if ((nint)obj17 != 1)
					{
						continue;
					}
					goto IL_01c9;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
			return (Quaternion[])(object)new NullReferenceException();
		}
		goto IL_01c9;
		IL_01c9:
		return array;
	}

	public static Color[] GetColorArray(string key)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004c: Expected O, but got I
		//IL_005f: Expected I, but got O
		object obj = typeof(List<AdaptivePerformanceScaler>) + 600;
		object obj2 = (nint)0 + (nint)3608;
		object obj3 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 104;
		object obj4 = (nint)0 + (nint)952;
		object obj5 = (nint)0 + (nint)808;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<Color> list = default(List<Color>);
		list..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action = default(Action<object, object>);
		action..ctor((object)null, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F6FE40");
		if (list != null)
		{
			return list.ToArray();
		}
		return (Color[])(object)new NullReferenceException();
	}

	public static Color[] GetColorArray(string key, Color defaultValue, int defaultSize)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_0098: Expected O, but got I4
		//IL_00c7: Expected O, but got I4
		//IL_022a: Expected O, but got I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_0110: Expected O, but got I4
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I4
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected O, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected O, but got Unknown
		//IL_0127: Expected O, but got I4
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		if (PlayerPrefs.HasKey(key))
		{
			return GetColorArray(key);
		}
		object obj = typeof(TypeConverter<ushort, char>) + 1976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Color[] array = default(Color[]);
		if ((nint)defaultValue >= 1)
		{
			if (array != null)
			{
				object obj2 = defaultValue - 1;
				bool flag = (nint)obj2 < array.Length;
				object obj3 = !flag;
				object obj4 = ~obj3;
				object obj5 = ~obj4;
				if (obj5 != null)
				{
					obj2 = array.Length;
				}
				bool flag2 = (nint)obj2 < 8;
				object obj6 = !flag2;
				object obj7;
				if (obj6 == null)
				{
					obj7 = 0;
				}
				else
				{
					object obj8 = obj2 + 1;
					object obj9 = obj8 & 7;
					bool flag3 = obj9 == null;
					object obj10 = !flag3;
					if (obj10 == null)
					{
						obj9 = 8;
					}
					obj7 = obj8 - obj9;
					object obj11 = array + 96;
					object obj12 = obj7;
					object obj13 = default(object);
					obj12 = obj13;
					object obj14 = default(object);
					obj11 = obj14;
					object obj15 = default(object);
					do
					{
						obj11 = obj15;
						obj11 += 128;
						obj12 -= 8;
					}
					while ((nint)obj12 != 8);
				}
				object obj16 = array.Length - obj7;
				object obj17 = (object)defaultValue - obj7;
				object obj18 = (object)array + obj7;
				object obj19 = obj18 + 44;
				object obj20 = default(object);
				while (obj16 != null)
				{
					obj16--;
					obj19 = obj20;
					obj19 += 16;
					obj17--;
					if ((nint)obj17 != 1)
					{
						continue;
					}
					goto IL_01c9;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
			return (Color[])(object)new NullReferenceException();
		}
		goto IL_01c9;
		IL_01c9:
		return array;
	}

	private unsafe static void GetValue<T>(string key, T list, ArrayType arrayType, int vectorNumber, Action<T, byte[]> convert) where T : IList
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_007b: Expected O, but got I4
		//IL_00a8: Expected O, but got I4
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected I4, but got Unknown
		//IL_00d0: Expected O, but got I4
		//IL_0285: Expected O, but got Ref
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_014a: Expected O, but got I4
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected O, but got Unknown
		//IL_0303: Expected O, but got I4
		//IL_01b5: Expected O, but got I4
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected I4, but got Unknown
		if (!PlayerPrefs.HasKey(key))
		{
			return;
		}
		string s = PlayerPrefs.GetString(key);
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		byte[] array = Convert.FromBase64String(s);
		if (array != null)
		{
			object obj4 = array.Length - 1;
			int num = vectorNumber << 2;
			int num2 = obj4 / num;
			object obj5 = num2 * num;
			if (obj4 != obj5)
			{
				object obj6 = "Complete" + 1864;
				string text = (string)obj6 + key;
				object obj7 = typeof(DataRelation) + 856;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v29+E4]");
				bool flag2 = (nint)0 == 0;
				object obj9 = !flag2;
				object message = text;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					message = text;
				}
				Debug.LogError(message);
				return;
			}
			if (arrayType != (ArrayType)array[0])
			{
				object obj10 = default(object);
				string text2 = ((Enum)(&obj10)).ToString();
				object obj11 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 1296;
				object obj12 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 248;
				string text3 = key + (string)obj11 + text2 + (string)obj12;
				object obj13 = typeof(DataRelation) + 856;
				object obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v20+E4]");
				bool flag3 = (nint)0 == 0;
				object obj15 = !flag3;
				object message2 = text3;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					message2 = text3;
				}
				Debug.LogError(message2);
				return;
			}
			Initialize();
			object obj16 = array.Length - 1;
			int num3 = obj16 / num;
			if (num3 < 1)
			{
				return;
			}
			if (convert != null)
			{
				do
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [convert @ X4 (System.Action`2<T, System.Byte[]>)+18] (should have been resolved before IL gen)");
					num3--;
				}
				while (num3 != 1);
				return;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private static void ConvertToInt(List<int> list, byte[] bytes)
	{
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00ee: Expected O, but got I
		//IL_0104: Expected O, but got I
		//IL_001d: Expected O, but got I
		//IL_0032: Expected O, but got I
		//IL_0060: Expected O, but got I4
		//IL_0084: Expected O, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1032;
		ConvertFrom4Bytes(bytes);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v5+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v6+10]");
		int item = BitConverter.ToInt32((byte[])0, 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<System.Int32>)+1C]");
		object obj4 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<System.Int32>)+10]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<System.Int32>)+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X9_v4+18]");
		bool flag = num < 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj7 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj8 = obj5 + 0;
		}
		else
		{
			list.AddWithResize(item);
		}
	}

	private static void ConvertToFloat(List<float> list, byte[] bytes)
	{
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00ee: Expected O, but got I
		//IL_0104: Expected O, but got I
		//IL_001d: Expected O, but got I
		//IL_0032: Expected O, but got I
		//IL_0060: Expected O, but got I4
		//IL_0084: Expected O, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1032;
		ConvertFrom4Bytes(bytes);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v5+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v6+10]");
		float item = BitConverter.ToSingle((byte[])0, 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<System.Single>)+1C]");
		object obj4 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<System.Single>)+10]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<System.Single>)+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X9_v4+18]");
		bool flag = num < 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<System.Single>)+18]");
			object obj7 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<System.Single>)+18]");
			object obj8 = obj5 + 0;
		}
		else
		{
			list.AddWithResize(item);
		}
	}

	private static void ConvertToVector2(List<Vector2> list, byte[] bytes)
	{
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_016b: Expected O, but got I
		//IL_0181: Expected O, but got I
		//IL_012b: Expected O, but got I
		//IL_0141: Expected O, but got I
		//IL_0011: Expected O, but got I
		//IL_002f: Expected O, but got I
		//IL_0044: Expected O, but got I
		//IL_0072: Expected O, but got I4
		//IL_00cb: Expected O, but got I
		//IL_00db: Expected O, but got I
		//IL_00f0: Expected O, but got I
		//IL_0096: Expected O, but got I
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1032;
		ConvertFrom4Bytes(bytes);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v5+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v6+10]");
		float num = BitConverter.ToSingle((byte[])0, 0);
		ConvertFrom4Bytes(bytes);
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v9+B8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v10+10]");
		float num2 = BitConverter.ToSingle((byte[])0, 0);
		object obj6 = (nint)0 + (nint)3304;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
		object obj8 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v4+18]");
		bool flag = num3 < 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
			object obj11 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
			object obj12 = obj9 + 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v14+20]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v15+C0]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v16+70]");
			list.AddWithResize((Vector2)0);
		}
	}

	private static void ConvertToVector3(List<Vector3> list, byte[] bytes)
	{
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_01be: Expected O, but got I
		//IL_01d4: Expected O, but got I
		//IL_013e: Expected O, but got I
		//IL_0154: Expected O, but got I
		//IL_017e: Expected O, but got I
		//IL_0194: Expected O, but got I
		//IL_0011: Expected O, but got I
		//IL_002f: Expected O, but got I
		//IL_0044: Expected O, but got I
		//IL_0072: Expected O, but got I4
		//IL_00de: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_0103: Expected O, but got I
		//IL_0096: Expected O, but got I
		//IL_00b1: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1032;
		ConvertFrom4Bytes(bytes);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v5+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v6+10]");
		float num = BitConverter.ToSingle((byte[])0, 0);
		ConvertFrom4Bytes(bytes);
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v9+B8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v10+10]");
		float num2 = BitConverter.ToSingle((byte[])0, 0);
		ConvertFrom4Bytes(bytes);
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v13+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v14+10]");
		float num3 = BitConverter.ToSingle((byte[])0, 0);
		object obj8 = (nint)0 + (nint)3384;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
		object obj10 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X9_v4+18]");
		bool flag = num4 < 0;
		object obj12 = !flag;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			object obj13 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			object obj14 = (nint)0 * (nint)12;
			object obj15 = obj11 + obj14;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v18+20]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v19+C0]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v20+70]");
			list.AddWithResize((Vector3)0);
		}
	}

	private static void ConvertToQuaternion(List<Quaternion> list, byte[] bytes)
	{
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_01f5: Expected O, but got I
		//IL_020b: Expected O, but got I
		//IL_0135: Expected O, but got I
		//IL_014b: Expected O, but got I
		//IL_0175: Expected O, but got I
		//IL_018b: Expected O, but got I
		//IL_01b5: Expected O, but got I
		//IL_01cb: Expected O, but got I
		//IL_0011: Expected O, but got I
		//IL_002f: Expected O, but got I
		//IL_0044: Expected O, but got I
		//IL_0072: Expected O, but got I4
		//IL_00d5: Expected O, but got I
		//IL_00e5: Expected O, but got I
		//IL_00fa: Expected O, but got I
		//IL_0096: Expected O, but got I
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1032;
		ConvertFrom4Bytes(bytes);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v5+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v6+10]");
		float num = BitConverter.ToSingle((byte[])0, 0);
		ConvertFrom4Bytes(bytes);
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v9+B8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v10+10]");
		float num2 = BitConverter.ToSingle((byte[])0, 0);
		ConvertFrom4Bytes(bytes);
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v13+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v14+10]");
		float num3 = BitConverter.ToSingle((byte[])0, 0);
		ConvertFrom4Bytes(bytes);
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v17+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v18+10]");
		float num4 = BitConverter.ToSingle((byte[])0, 0);
		object obj10 = (nint)0 + (nint)2880;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<UnityEngine.Quaternion>)+1C]");
		object obj12 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<UnityEngine.Quaternion>)+10]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<UnityEngine.Quaternion>)+18]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X9_v4+18]");
		bool flag = num5 < 0;
		object obj14 = !flag;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<UnityEngine.Quaternion>)+18]");
			object obj15 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<UnityEngine.Quaternion>)+18]");
			object obj16 = obj13 + 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v22+20]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v23+C0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v24+70]");
			list.AddWithResize((Quaternion)0);
		}
	}

	private static void ConvertToColor(List<Color> list, byte[] bytes)
	{
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_01f5: Expected O, but got I
		//IL_020b: Expected O, but got I
		//IL_0135: Expected O, but got I
		//IL_014b: Expected O, but got I
		//IL_0175: Expected O, but got I
		//IL_018b: Expected O, but got I
		//IL_01b5: Expected O, but got I
		//IL_01cb: Expected O, but got I
		//IL_0011: Expected O, but got I
		//IL_002f: Expected O, but got I
		//IL_0044: Expected O, but got I
		//IL_0072: Expected O, but got I4
		//IL_00d5: Expected O, but got I
		//IL_00e5: Expected O, but got I
		//IL_00fa: Expected O, but got I
		//IL_0096: Expected O, but got I
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1032;
		ConvertFrom4Bytes(bytes);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v5+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v6+10]");
		float num = BitConverter.ToSingle((byte[])0, 0);
		ConvertFrom4Bytes(bytes);
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v9+B8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v10+10]");
		float num2 = BitConverter.ToSingle((byte[])0, 0);
		ConvertFrom4Bytes(bytes);
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v13+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v14+10]");
		float num3 = BitConverter.ToSingle((byte[])0, 0);
		ConvertFrom4Bytes(bytes);
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v17+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v18+10]");
		float num4 = BitConverter.ToSingle((byte[])0, 0);
		object obj10 = (nint)0 + (nint)3624;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<UnityEngine.Color>)+1C]");
		object obj12 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<UnityEngine.Color>)+10]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<UnityEngine.Color>)+18]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X9_v4+18]");
		bool flag = num5 < 0;
		object obj14 = !flag;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<UnityEngine.Color>)+18]");
			object obj15 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<UnityEngine.Color>)+18]");
			object obj16 = obj13 + 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v22+20]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v23+C0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v24+70]");
			list.AddWithResize((Color)0);
		}
	}

	public unsafe static void ShowArrayType(string key)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01dd: Expected O, but got I4
		//IL_01e6: Expected O, but got I4
		//IL_0085: Expected O, but got I4
		//IL_0232: Expected O, but got I4
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_0121: Expected O, but got Ref
		//IL_016d: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6AD7]");
		object obj3 = (nint)0 & (nint)1;
		string text;
		string s;
		if (obj3 != null)
		{
			text = PlayerPrefs.GetString(key);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = 0;
			s = text;
			if (!flag)
			{
				goto IL_009b;
			}
		}
		else
		{
			_ = 1;
			text = PlayerPrefs.GetString(key);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = 0;
			s = text;
			if (obj6 != null)
			{
				goto IL_009b;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		byte[] array = Convert.FromBase64String(s);
		bool flag3 = array == null;
		object obj7 = !flag3;
		byte[] array2 = array;
		if (obj7 != null)
		{
			goto IL_00c5;
		}
		goto IL_0248;
		IL_00c5:
		if (array2.Length != 0)
		{
			object obj8 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 1200;
			object obj9 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 248;
			object obj10 = typeof(DataRelation) + 856;
			object obj11 = default(object);
			string text2 = ((Enum)(&obj11)).ToString();
			string text3 = key + (string)obj8 + text2 + (string)obj9;
			object obj12 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v13+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			object message = text3;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				message = text3;
			}
			Debug.Log(message);
		}
		return;
		IL_0248:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_009b:
		array2 = Convert.FromBase64String(text);
		if (array2 != null)
		{
			goto IL_00c5;
		}
		goto IL_0248;
	}

	private static void Initialize()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00bb: Expected O, but got I
		//IL_00c4: Expected O, but got I4
		//IL_00e6: Expected O, but got I4
		//IL_0068: Expected O, but got I
		//IL_0071: Expected O, but got I4
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0130: Expected O, but got I
		//IL_015f: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1032;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B9B]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X8_v12+B8]");
			object obj5 = 0;
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v11+10]");
			if ((nint)0 != 0)
			{
				goto IL_0096;
			}
		}
		else
		{
			_ = 1;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v9+B8]");
			object obj5 = 0;
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v11+10]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 != null)
			{
				goto IL_0096;
			}
		}
		object obj8 = typeof(TypeConverter<ushort, char>) + 1880;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v5+B8]");
		object obj10 = (nint)0 + (nint)16;
		object obj11 = default(object);
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v6+B8]");
		object obj13 = 0;
		_ = 1;
		return;
		IL_0096:
		_ = 1;
	}

	private static bool SaveBytes(string key, byte[] bytes)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0077: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string value = Convert.ToBase64String(bytes);
		PlayerPrefs.SetString(key, value);
		return true;
	}

	private static void ConvertFloatToBytes(float f, byte[] bytes)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1032;
		float value = default(float);
		byte[] bytes2 = BitConverter.GetBytes(value);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v3+B8]");
		object obj3 = (nint)0 + (nint)16;
		obj3 = bytes2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ConvertTo4Bytes(bytes);
	}

	private static float ConvertBytesToFloat(byte[] bytes)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Expected O, but got I
		//IL_0050: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1032;
		ConvertFrom4Bytes(bytes);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+10]");
		return BitConverter.ToSingle((byte[])0, 0);
	}

	private static void ConvertInt32ToBytes(int i, byte[] bytes)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1032;
		int value = default(int);
		byte[] bytes2 = BitConverter.GetBytes(value);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
		object obj3 = (nint)0 + (nint)16;
		obj3 = bytes2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ConvertTo4Bytes(bytes);
	}

	private static int ConvertBytesToInt32(byte[] bytes)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Expected O, but got I
		//IL_0050: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1032;
		ConvertFrom4Bytes(bytes);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+10]");
		return BitConverter.ToInt32((byte[])0, 0);
	}

	private static void ConvertTo4Bytes(byte[] bytes)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_035b: Expected O, but got I
		//IL_036b: Expected O, but got I
		//IL_003a: Expected O, but got I4
		//IL_006b: Expected O, but got I4
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00b9: Expected O, but got I
		//IL_00c9: Expected O, but got I
		//IL_00e4: Expected O, but got I
		//IL_0105: Expected O, but got I4
		//IL_0129: Expected O, but got I
		//IL_0144: Expected O, but got I4
		//IL_0184: Expected O, but got I
		//IL_0194: Expected O, but got I
		//IL_01af: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01f4: Expected O, but got I
		//IL_020f: Expected O, but got I4
		//IL_024f: Expected O, but got I
		//IL_025f: Expected O, but got I
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		//IL_0293: Expected O, but got I4
		//IL_02b7: Expected O, but got I
		//IL_02d2: Expected O, but got I4
		//IL_0312: Expected O, but got I
		//IL_0328: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1032;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X9_v1+10]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v4+18]");
		bool flag = (nint)obj3 < 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X9_v1+8]");
			bool flag2 = (nint)0 < (nint)bytes.Length;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				object obj7 = obj4 + obj3;
				object obj8 = bytes + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v7+20]");
				_ = 0;
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X9_v5+B8]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X11_v5+10]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X11_v5+4]");
				object obj12 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X9_v6+18]");
				bool flag3 = (nint)obj12 < 0;
				object obj13 = !flag3;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X11_v5+8]");
					object obj14 = (nint)0 + (nint)1;
					bool flag4 = (nint)obj14 < bytes.Length;
					object obj15 = !flag4;
					if (obj15 == null)
					{
						object obj16 = obj11 + obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X9_v7+20]");
						_ = 0;
						object obj17 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X9_v9+B8]");
						object obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X10_v7+10]");
						object obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X10_v7+4]");
						object obj20 = (nint)2 - (nint)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X9_v10+18]");
						bool flag5 = (nint)obj20 < 0;
						object obj21 = !flag5;
						if (obj21 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X10_v7+8]");
							object obj22 = (nint)0 + (nint)2;
							bool flag6 = (nint)obj22 < bytes.Length;
							object obj23 = !flag6;
							if (obj23 == null)
							{
								object obj24 = obj19 + obj20;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X9_v11+20]");
								_ = 0;
								object obj25 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X9_v13+B8]");
								object obj26 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X10_v10+10]");
								object obj27 = 0;
								object obj28 = 3 - obj26;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X9_v14+18]");
								bool flag7 = (nint)obj28 < 0;
								object obj29 = !flag7;
								if (obj29 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X10_v10+8]");
									object obj30 = (nint)0 + (nint)3;
									bool flag8 = (nint)obj30 < bytes.Length;
									object obj31 = !flag8;
									if (obj31 == null)
									{
										object obj32 = obj27 + obj28;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X9_v15+20]");
										_ = 0;
										object obj33 = obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v9+B8]");
										object obj34 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v10+8]");
										object obj35 = (nint)0 + (nint)4;
										return;
									}
								}
							}
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private static void ConvertFrom4Bytes(byte[] bytes)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_0041: Expected O, but got I
		//IL_0064: Expected O, but got I4
		//IL_0082: Expected O, but got I
		//IL_00a8: Expected O, but got I4
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00f6: Expected O, but got I
		//IL_010c: Expected O, but got I
		//IL_0127: Expected O, but got I4
		//IL_0145: Expected O, but got I
		//IL_0160: Expected O, but got I
		//IL_0181: Expected O, but got I4
		//IL_01c1: Expected O, but got I
		//IL_01d7: Expected O, but got I
		//IL_01f2: Expected O, but got I4
		//IL_0210: Expected O, but got I
		//IL_022b: Expected O, but got I
		//IL_024c: Expected O, but got I4
		//IL_028c: Expected O, but got I
		//IL_02a2: Expected O, but got I
		//IL_02bd: Expected O, but got I4
		//IL_02db: Expected O, but got I
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		//IL_030f: Expected O, but got I4
		//IL_034f: Expected O, but got I
		//IL_0365: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1032;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X9_v2+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X9_v3+8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X9_v3+8]");
		bool flag = (nint)0 < (nint)bytes.Length;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X9_v3+10]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X11_v4+18]");
			bool flag2 = (nint)obj3 < 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				object obj8 = bytes + 32;
				object obj9 = obj6 + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X9_v6+v43 @ X10_v2]");
				_ = 0;
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X10_v5+B8]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X12_v4+8]");
				object obj12 = (nint)0 + (nint)1;
				bool flag3 = (nint)obj12 < bytes.Length;
				object obj13 = !flag3;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X12_v4+10]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X12_v4+4]");
					object obj15 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X11_v7+18]");
					bool flag4 = (nint)obj15 < 0;
					object obj16 = !flag4;
					if (obj16 == null)
					{
						object obj17 = obj14 + obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X9_v6+v122 @ X10_v7]");
						_ = 0;
						object obj18 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X10_v9+B8]");
						object obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X12_v7+8]");
						object obj20 = (nint)0 + (nint)2;
						bool flag5 = (nint)obj20 < bytes.Length;
						object obj21 = !flag5;
						if (obj21 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X12_v7+10]");
							object obj22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X12_v7+4]");
							object obj23 = (nint)2 - (nint)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X11_v10+18]");
							bool flag6 = (nint)obj23 < 0;
							object obj24 = !flag6;
							if (obj24 == null)
							{
								object obj25 = obj22 + obj23;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X9_v6+v123 @ X10_v11]");
								_ = 0;
								object obj26 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X10_v13+B8]");
								object obj27 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X12_v10+8]");
								object obj28 = (nint)0 + (nint)3;
								bool flag7 = (nint)obj28 < bytes.Length;
								object obj29 = !flag7;
								if (obj29 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X12_v10+10]");
									object obj30 = 0;
									object obj31 = 3 - obj27;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X11_v13+18]");
									bool flag8 = (nint)obj31 < 0;
									object obj32 = !flag8;
									if (obj32 == null)
									{
										object obj33 = obj30 + obj31;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X9_v6+v124 @ X10_v15]");
										_ = 0;
										object obj34 = obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v6+B8]");
										object obj35 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v7+8]");
										object obj36 = (nint)0 + (nint)4;
										return;
									}
								}
							}
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	public static DateTime GetDate(string name, DateTime defaultValue)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ca: Expected O, but got I4
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime dateTime2 = default(DateTime);
		DateTime dateTime = dateTime2.ToUniversalTime();
		DateTime dateTime3 = default(DateTime);
		long ticks = dateTime3.Ticks;
		long num = default(long);
		string defaultValue2 = num.ToString();
		string s = PlayerPrefs.GetString(name, defaultValue2);
		long ticks2 = long.Parse(s);
		DateTime dateTime4 = new DateTime(ticks2, DateTimeKind.Utc);
		return dateTime3.ToLocalTime();
	}

	public static void SetDate(string name, DateTime value)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0091: Expected O, but got I4
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime dateTime2 = default(DateTime);
		DateTime dateTime = dateTime2.ToUniversalTime();
		DateTime dateTime3 = default(DateTime);
		long ticks = dateTime3.Ticks;
		long num = default(long);
		string value2 = num.ToString();
		PlayerPrefs.SetString(name, value2);
	}

	public static T GetEnum<T>(string name, T defaultValue) where T : Enum
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0075: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object value = default(object);
		int defaultValue2 = Convert.ToInt32(value);
		int index = PlayerPrefs.GetInt(name, defaultValue2);
		return EnumExtensions.ToEnum(index, defaultValue);
	}

	public static void SetEnum<T>(string name, T value) where T : Enum
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0070: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object value3 = default(object);
		int value2 = Convert.ToInt32(value3);
		PlayerPrefs.SetInt(name, value2);
	}

	public static T GetData<T>(string key, T defaultValue)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		if (PlayerPrefs.HasKey(key))
		{
			string value = PlayerPrefs.GetString(key);
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v6+E4]");
			if ((nint)0 != 0)
			{
				return JsonConvert.DeserializeObject<T>(value);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return JsonConvert.DeserializeObject<T>(value);
		}
		return defaultValue;
	}

	public static void SetData<T>(string key, T value)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0072: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string value2 = JsonConvert.SerializeObject(value);
		PlayerPrefs.SetString(key, value2);
	}
}
