using System;
using System.Buffers.Text;
using Cpp2ILInjected;
using UnityEngine;

public static class PlayerPrefsGame
{
	private unsafe static string Suffix
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected O, but got Unknown
			//IL_0094: Expected O, but got I4
			//IL_003b: Expected O, but got Ref
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj2 = "[{0}]:{1}" + 912;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Games currentGame = Preferences.CurrentGame;
			object obj5 = default(object);
			string text = ((Enum)(&obj5)).ToString();
			return (string)obj2 + text;
		}
	}

	public static string GetString(string key, string defaultValue)
	{
		//IL_002b: Expected O, but got I
		string suffix = Suffix;
		string text = key + suffix;
		object obj = (nint)0 + (nint)2000;
		string key2 = text + (string)obj;
		return PlayerPrefs.GetString(key2, defaultValue);
	}

	public static void SetString(string key, string value)
	{
		//IL_002b: Expected O, but got I
		string suffix = Suffix;
		string text = key + suffix;
		object obj = (nint)0 + (nint)2000;
		string key2 = text + (string)obj;
		PlayerPrefs.SetString(key2, value);
	}

	public static bool HasKey(string key)
	{
		//IL_002b: Expected O, but got I
		string suffix = Suffix;
		string text = key + suffix;
		object obj = (nint)0 + (nint)2000;
		string key2 = text + (string)obj;
		return PlayerPrefs.HasKey(key2);
	}

	public static DateTime GetDate(string key, DateTime defaultValue)
	{
		//IL_002b: Expected O, but got I
		string suffix = Suffix;
		string text = key + suffix;
		object obj = (nint)0 + (nint)2000;
		string name = text + (string)obj;
		return PlayerPrefsX.GetDate(name, defaultValue);
	}

	public static void SetDate(string key, DateTime value)
	{
		//IL_002b: Expected O, but got I
		string suffix = Suffix;
		string text = key + suffix;
		object obj = (nint)0 + (nint)2000;
		string name = text + (string)obj;
		PlayerPrefsX.SetDate(name, value);
	}
}
