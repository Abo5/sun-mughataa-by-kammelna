using Cpp2ILInjected;
using UnityEngine;

public class BoolPlayerPref : PlayerPrefReference<bool>
{
	public override bool Value
	{
		get
		{
			//IL_000c: Expected O, but got I
			//IL_0026: Expected O, but got I
			//IL_0051: Expected O, but got I4
			object obj = (nint)0 + (nint)2000;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BoolPlayerPref)+18]");
			string text = (string)0 + (string)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BoolPlayerPref)+20]");
			int num = PlayerPrefs.GetInt(text, 0);
			object obj2 = num - 1;
			return obj2 == null;
		}
		set
		{
			//IL_000c: Expected O, but got I
			//IL_0026: Expected O, but got I
			object obj = (nint)0 + (nint)2000;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BoolPlayerPref)+18]");
			string text = (string)0 + (string)obj;
			bool flag = PlayerPrefsX.SetBool(text, value);
		}
	}
}
