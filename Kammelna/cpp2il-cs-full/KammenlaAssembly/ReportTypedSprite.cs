using System;
using System.Buffers.Text;
using System.Data;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
public class ReportTypedSprite
{
	public PerformanceReportType ReportType;

	public Sprite Sprite;

	public string ReportTitle;

	public string CongratsText;

	public string BodyText;

	public string ColorHex;

	public Color GetColor()
	{
		//IL_00d2: Expected O, but got I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0092: Expected O, but got I4
		Color color2;
		Color color = (Color)ColorUtility.TryParseHtmlString(ColorHex, out color2);
		if ((object)color != null)
		{
			return color;
		}
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 320;
		object format = "Index = {0} position = {1}" + 3048;
		object obj2 = typeof(DataRelation) + 856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string text = string.Format((string)format, ColorHex, arg);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		Color color3 = (Color)text;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			color3 = (Color)text;
		}
		Debug.LogWarning(color3);
		return color3;
	}
}
