using System;
using System.Buffers.Text;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.UI;

public class PopupInput : IPopupWindowBuilderInput
{
	private PopupWindowInputData _instance;

	private PopupInput()
	{
	}

	public static IPopupWindowBuilderInput OfType(InputField.ContentType type)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0067: Expected O, but got I4
		//IL_0077: Expected O, but got I
		//IL_0087: Expected O, but got I
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1416;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		if (obj4 != null)
		{
			object obj5 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v5+90]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v6+B8]");
			object text = 0;
			LocalizableText localizableText = TextMeshProExtensions.FixOnly((string)text);
			object obj7 = obj4 + 24;
			obj7 = localizableText;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (obj3 != null)
			{
				object obj8 = obj3 + 16;
				obj8 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				return (IPopupWindowBuilderInput)obj3;
			}
		}
		return (IPopupWindowBuilderInput)new NullReferenceException();
	}

	public static IPopupWindowBuilderInput From(InputField.ContentType type, Action<string> callback = null, LocalizableText placeholder = null, Sprite icon = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0072: Expected O, but got I4
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0097: Expected O, but got I4
		//IL_00a7: Expected O, but got I
		//IL_00b7: Expected O, but got I
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1416;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		if (obj4 != null)
		{
			bool flag = placeholder == null;
			object obj5 = !flag;
			LocalizableText localizableText = placeholder;
			if (obj5 == null)
			{
				object obj6 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v6+90]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v7+B8]");
				object text = 0;
				LocalizableText localizableText2 = TextMeshProExtensions.FixOnly((string)text);
				localizableText = localizableText2;
			}
			object obj8 = obj4 + 24;
			obj8 = localizableText;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj9 = obj4 + 40;
			obj9 = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj10 = obj4 + 32;
			obj10 = icon;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (obj3 != null)
			{
				object obj11 = obj3 + 16;
				obj11 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				return (IPopupWindowBuilderInput)obj3;
			}
		}
		return (IPopupWindowBuilderInput)new NullReferenceException();
	}

	public IPopupWindowBuilderInput WithIcon(Sprite icon)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		if (_instance != null)
		{
			object obj = _instance + 32;
			obj = icon;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return this;
		}
		return (IPopupWindowBuilderInput)new NullReferenceException();
	}

	public IPopupWindowBuilderInput WithPlaceholder(string placeholder)
	{
		//IL_0009: Expected O, but got I4
		//IL_0015: Expected O, but got I
		//IL_002b: Expected O, but got I
		//IL_026d: Expected O, but got I
		//IL_028f: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		//IL_00c7: Expected O, but got I
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00f4: Expected O, but got I
		//IL_006a: Expected O, but got I
		//IL_0371: Expected O, but got I4
		//IL_02c9: Expected O, but got I
		//IL_02d9: Expected O, but got I
		//IL_02ef: Expected O, but got I
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_0317: Expected O, but got I4
		//IL_0337: Expected O, but got I
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_016b: Expected O, but got I
		//IL_017b: Expected O, but got I
		//IL_0191: Expected O, but got I
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01b9: Expected O, but got I4
		//IL_01e6: Expected O, but got I
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = (nint)0 + (nint)3232;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7949]");
		object obj3 = (nint)0 & (nint)1;
		PopupWindowInputData popupWindowInputData;
		object obj6;
		PopupWindowInputData popupWindowInputData2;
		object obj4;
		if (obj3 != null)
		{
			popupWindowInputData = _instance;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X22_v7+38]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X22_v7+38]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			popupWindowInputData2 = _instance;
			if (!flag)
			{
				goto IL_00a1;
			}
		}
		else
		{
			_ = 1;
			popupWindowInputData = _instance;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X22_v7+38]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X22_v7+38]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			popupWindowInputData2 = _instance;
			if (obj7 != null)
			{
				goto IL_00a1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X22_v3+38]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v6+10]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v6+10]");
		object obj10 = (nint)0 + (nint)309;
		object obj11 = obj10 & 1;
		bool flag3 = obj11 == null;
		object obj12 = !flag3;
		obj4 = obj6;
		popupWindowInputData = popupWindowInputData2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v6+10]");
		object obj13 = 0;
		if (obj12 != null)
		{
			goto IL_0112;
		}
		goto IL_0345;
		IL_0147:
		object obj14 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2640;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X22_v7+38]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v12+10]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v12+10]");
		object obj17 = (nint)0 + (nint)309;
		object obj18 = obj17 & 1;
		bool flag4 = obj18 == null;
		object obj19 = !flag4;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v17+B8]");
		object arguments = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		LocalizableText localizableText = default(LocalizableText);
		localizableText..ctor(placeholder, (object[])arguments);
		if (popupWindowInputData != null)
		{
			object obj20 = popupWindowInputData + 24;
			obj20 = localizableText;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return this;
		}
		return (IPopupWindowBuilderInput)new NullReferenceException();
		IL_038f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj6;
		popupWindowInputData = popupWindowInputData2;
		goto IL_0147;
		IL_0112:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v1+E4]");
		bool flag5 = (nint)0 == 0;
		obj6 = obj4;
		popupWindowInputData2 = popupWindowInputData;
		if (!flag5)
		{
			goto IL_0147;
		}
		goto IL_038f;
		IL_00a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v18+10]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v18+10]");
		object obj21 = (nint)0 + (nint)309;
		object obj22 = obj21 & 1;
		bool flag6 = obj22 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v18+10]");
		obj13 = 0;
		obj6 = obj4;
		popupWindowInputData2 = popupWindowInputData;
		if (!flag6)
		{
			goto IL_0112;
		}
		goto IL_0345;
		IL_0345:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v1+E4]");
		bool flag7 = (nint)0 == 0;
		object obj23 = !flag7;
		obj4 = obj6;
		popupWindowInputData = popupWindowInputData2;
		if (obj23 != null)
		{
			goto IL_0147;
		}
		goto IL_038f;
	}

	public IPopupWindowBuilderInput WithPlaceholder(LocalizableText placeholder)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		if (_instance != null)
		{
			object obj = _instance + 24;
			obj = placeholder;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return this;
		}
		return (IPopupWindowBuilderInput)new NullReferenceException();
	}

	public IPopupWindowBuilderInput SetCallback(Action<string> callback)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		if (_instance != null)
		{
			object obj = _instance + 40;
			obj = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return this;
		}
		return (IPopupWindowBuilderInput)new NullReferenceException();
	}

	public PopupWindowInputData Build()
	{
		return _instance;
	}
}
