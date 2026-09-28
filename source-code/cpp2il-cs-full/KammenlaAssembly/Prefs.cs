using System;
using UnityEngine;

public static class Prefs
{
	public static string GetString(string key, string defaultValue = "")
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2000;
		string text = default(string);
		string key2 = text + (string)obj;
		return PlayerPrefs.GetString(key2, defaultValue);
	}

	public static void SetString(string key, string value)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2000;
		string text = default(string);
		string key2 = text + (string)obj;
		PlayerPrefs.SetString(key2, value);
	}

	public static int GetInt(string key, int defaultValue = 0)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2000;
		string text = default(string);
		string key2 = text + (string)obj;
		return PlayerPrefs.GetInt(key2, defaultValue);
	}

	public static void SetInt(string key, int value)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2000;
		string text = default(string);
		string key2 = text + (string)obj;
		PlayerPrefs.SetInt(key2, value);
	}

	public static float GetFloat(string key, float defaultValue = 0f)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2000;
		string text = default(string);
		string key2 = text + (string)obj;
		return PlayerPrefs.GetFloat(key2, defaultValue);
	}

	public static void SetFloat(string key, float value)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2000;
		string text = default(string);
		string key2 = text + (string)obj;
		PlayerPrefs.SetFloat(key2, value);
	}

	public static bool HasKey(string key)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2000;
		string text = default(string);
		string key2 = text + (string)obj;
		return PlayerPrefs.HasKey(key2);
	}

	public static void DeleteKey(string key)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2000;
		string text = default(string);
		string key2 = text + (string)obj;
		PlayerPrefs.DeleteKey(key2);
	}

	public static void DeleteAll()
	{
		PlayerPrefs.DeleteAll();
	}

	public static void Save()
	{
		PlayerPrefs.Save();
	}

	public static bool GetBool(string key, bool defaultValue = false)
	{
		//IL_000c: Expected O, but got I
		//IL_0041: Expected O, but got I4
		object obj = (nint)0 + (nint)2000;
		string text = default(string);
		string key2 = text + (string)obj;
		int num = PlayerPrefs.GetInt(key2, defaultValue ? 1 : 0);
		object obj2 = num - 1;
		return obj2 == null;
	}

	public static void SetBool(string key, bool value)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2000;
		string text = default(string);
		string name = text + (string)obj;
		bool flag = PlayerPrefsX.SetBool(name, value);
	}

	public static long GetLong(string key, long defaultValue = 0L)
	{
		//IL_000c: Expected O, but got I
		//IL_002b: Expected O, but got I4
		object obj = (nint)0 + (nint)2000;
		string text = default(string);
		string key2 = text + (string)obj;
		string s = PlayerPrefs.GetString(key2);
		long result;
		bool flag = long.TryParse(s, out result);
		bool flag2 = !flag;
		object obj2 = !flag2;
		object obj3 = ~obj2;
		if (obj3 == null)
		{
			return result;
		}
		return defaultValue;
	}

	public static void SetLong(string key, long value)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2000;
		string text = default(string);
		string key2 = text + (string)obj;
		long num = default(long);
		string value2 = num.ToString();
		PlayerPrefs.SetString(key2, value2);
	}

	public static DateTime GetDate(string key, DateTime defaultValue)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2000;
		string text = default(string);
		string name = text + (string)obj;
		return PlayerPrefsX.GetDate(name, defaultValue);
	}

	public static void SetDate(string key, DateTime value)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2000;
		string text = default(string);
		string name = text + (string)obj;
		PlayerPrefsX.SetDate(name, value);
	}

	public static T GetEnum<T>(string key, T defaultValue) where T : Enum
	{
		string key2 = default(string);
		string name = PlayerPrefsScope.Key(key2);
		return PlayerPrefsX.GetEnum(name, defaultValue);
	}

	public static void SetEnum<T>(string key, T value) where T : Enum
	{
		string key2 = default(string);
		string name = PlayerPrefsScope.Key(key2);
		PlayerPrefsX.SetEnum(name, value);
	}

	public static T GetData<T>(string key, T defaultValue)
	{
		string key3 = default(string);
		string key2 = PlayerPrefsScope.Key(key3);
		return PlayerPrefsX.GetData(key2, defaultValue);
	}

	public static void SetData<T>(string key, T value)
	{
		string key3 = default(string);
		string key2 = PlayerPrefsScope.Key(key3);
		PlayerPrefsX.SetData(key2, value);
	}

	public static Vector2 GetVector2(string key, Vector2 defaultValue)
	{
		//IL_000c: Expected O, but got I
		//IL_00b6: Expected O, but got I4
		object obj = (nint)0 + (nint)2000;
		string text = default(string);
		string key2 = text + (string)obj;
		bool flag = PlayerPrefs.HasKey(key2);
		bool flag2 = !flag;
		Vector2 result = (Vector2)flag;
		if (!flag2)
		{
			float[] floatArray = PlayerPrefsX.GetFloatArray(key2);
			if (floatArray == null)
			{
				return (Vector2)new NullReferenceException();
			}
			result = (Vector2)((floatArray.Length <= 1) ? floatArray : floatArray);
		}
		return result;
	}

	public static bool SetVector2(string key, Vector2 value)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2000;
		string text = default(string);
		string key2 = text + (string)obj;
		return PlayerPrefsX.SetVector2(key2, (Vector2)obj);
	}

	public static Vector3 GetVector3(string key, Vector3 defaultValue)
	{
		//IL_000c: Expected O, but got I
		//IL_00b6: Expected O, but got I4
		object obj = (nint)0 + (nint)2000;
		string text = default(string);
		string key2 = text + (string)obj;
		bool flag = PlayerPrefs.HasKey(key2);
		bool flag2 = !flag;
		Vector3 result = (Vector3)flag;
		if (!flag2)
		{
			float[] floatArray = PlayerPrefsX.GetFloatArray(key2);
			if (floatArray == null)
			{
				return (Vector3)new NullReferenceException();
			}
			result = (Vector3)((floatArray.Length <= 2) ? floatArray : floatArray);
		}
		return result;
	}

	public static bool SetVector3(string key, Vector3 value)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2000;
		string text = default(string);
		string key2 = text + (string)obj;
		return PlayerPrefsX.SetVector3(key2, (Vector3)obj);
	}

	public static Color GetColor(string key, Color defaultValue)
	{
		//IL_000c: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		object obj = (nint)0 + (nint)2000;
		string text = default(string);
		string key2 = text + (string)obj;
		bool flag = PlayerPrefs.HasKey(key2);
		bool flag2 = !flag;
		Color result = (Color)flag;
		if (!flag2)
		{
			float[] floatArray = PlayerPrefsX.GetFloatArray(key2);
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

	public static bool SetColor(string key, Color value)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2000;
		string text = default(string);
		string key2 = text + (string)obj;
		return PlayerPrefsX.SetColor(key2, (Color)obj);
	}
}
