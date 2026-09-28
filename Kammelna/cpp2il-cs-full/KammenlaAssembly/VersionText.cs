using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using Unity.Services.Authentication.Shared;
using UnityEngine;

public class VersionText : MonoBehaviour
{
	private void Start()
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_011c: Expected O, but got I4
		//IL_0040: Expected O, but got I
		//IL_0077: Expected O, but got I4
		object obj = (nint)0 + (nint)152;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object input = "Unsupported map type" + 2536;
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj6 = (nint)0 + (nint)3072;
		string text = LocalizationUtil.Localize((string)input);
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string version = Application.version;
		string text2 = text + (string)obj6 + version;
		TextMeshProUGUI textMesh = default(TextMeshProUGUI);
		TextMeshProExtensions.FixArabic(textMesh, text2);
	}
}
