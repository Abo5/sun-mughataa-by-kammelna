using System.Formats.Asn1;
using Cpp2ILInjected;
using UnityEngine;

public class SingletonsHolder : MonoBehaviour
{
	public static bool IsInitialized;

	private GameObject disabledContainer;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0064: Expected O, but got I
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_0023: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 552;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
		object obj3 = 0;
		object obj4 = obj3 & 1;
		if (obj4 == null)
		{
			obj3 = 1;
			Transform source = disabledContainer.transform;
			UIExtensions.MoveChildren(source, null);
		}
	}
}
