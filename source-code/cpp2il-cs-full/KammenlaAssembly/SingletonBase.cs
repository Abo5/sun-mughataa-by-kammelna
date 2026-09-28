using System.Formats.Asn1;
using Cpp2ILInjected;
using UnityEngine;

public abstract class SingletonBase : MonoBehaviour
{
	private static bool <_quitting>k__BackingField;

	protected static bool _quitting
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			//IL_0036: Expected I4, but got O
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 536;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
			object obj3 = 0;
			return (byte)(int)obj3 != 0;
		}
		private set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			//IL_0039: Expected O, but got I4
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 536;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
			object obj3 = 0;
			obj3 = value;
		}
	}

	private void OnApplicationQuit()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_003a: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 536;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		obj3 = 1;
	}
}
