using Cpp2ILInjected;
using TMPro;
using UnityEngine;

public class MetricNumberFormatter : NumberFormatter
{
	private string normalTemplate;

	private string thousandsTemplate;

	private string millionsTemplate;

	private bool useCommas;

	public override void AssignValue(TextMeshProUGUI label, int value)
	{
		//IL_0072: Expected O, but got I4
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected I4, but got Unknown
		//IL_013e: Expected O, but got I4
		//IL_014e: Expected O, but got I
		//IL_00c7: Expected O, but got I4
		//IL_00d5: Expected I4, but got O
		//IL_00f1: Expected O, but got I4
		//IL_0101: Expected O, but got I
		//IL_00b4: Expected O, but got I4
		string template;
		int num2;
		object obj;
		object obj4;
		int num;
		if (value < 1000000)
		{
			if (value < 1000)
			{
				template = normalTemplate;
				num = value;
			}
			else
			{
				template = thousandsTemplate;
				if (useCommas)
				{
					num2 = value;
					obj = 1148846080;
					goto IL_0122;
				}
				object obj2 = value * 274877907;
				int num3 = obj2 >> 38;
				num = num3;
			}
			object obj3 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v11+48]");
			obj4 = 0;
			goto IL_0106;
		}
		template = millionsTemplate;
		num2 = value;
		obj = 1232348160;
		goto IL_0122;
		IL_0106:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object value2 = default(object);
		NumberFormatter.SetText(label, template, value2);
		return;
		IL_0122:
		int num4 = num2 / obj;
		object obj5 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5+78]");
		obj4 = 0;
		num = num4;
		goto IL_0106;
	}

	public MetricNumberFormatter()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		object obj = "startPosition" + 3088;
		object obj2 = "m_StencilDeferredPS" + 1568;
		object obj3 = this + 32;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = this + 40;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((ScriptableObject)this)..ctor();
	}
}
