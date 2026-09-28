using Cpp2ILInjected;
using TMPro;
using UnityEngine;

public class LocalizeTMProTextAsset : MonoBehaviour
{
	private TextAsset text;

	private void Start()
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		string text = this.text.text;
		TextMeshProUGUI textMesh = default(TextMeshProUGUI);
		TextMeshProExtensions.FixArabic(textMesh, text);
	}
}
