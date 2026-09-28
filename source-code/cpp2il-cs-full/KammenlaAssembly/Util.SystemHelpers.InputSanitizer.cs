using System;
using System.Buffers.Text;
using System.Formats.Asn1;
using System.Text.RegularExpressions;
using Cpp2ILInjected;

namespace Util.SystemHelpers;

public static class InputSanitizer
{
	private static Regex TagsRegex;

	public static string SanitizeHtmlTags(string input, int maxLength = 200)
	{
		//IL_014b: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_0171: Expected O, but got I
		//IL_0077: Expected O, but got I4
		//IL_0087: Expected O, but got I
		//IL_0097: Expected O, but got I
		bool flag = string.IsNullOrEmpty(input);
		bool flag2 = !flag;
		object obj = !flag2;
		string result = input;
		if (obj == null)
		{
			object obj2 = typeof(System.IOAsyncCallback) + 3096;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v7+B8]");
			object obj5 = 0;
			if (obj5 != null)
			{
				object obj6 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v8+90]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v9+B8]");
				object replacement = 0;
				string text = ((Regex)obj5).Replace(input, (string)replacement);
				if (text != null)
				{
					bool flag4 = text._stringLength <= maxLength;
					result = text;
					if (!flag4)
					{
						return text.Substring(0, 200);
					}
					goto IL_0111;
				}
			}
			return (string)(object)new NullReferenceException();
		}
		goto IL_0111;
		IL_0111:
		return result;
	}

	public static char UserInputValidationCallback(string text, int charindex, char addedchar)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I4
		//IL_004f: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = StringUtil.IsAllowedChatCharacter(addedchar);
		bool flag3 = !flag2;
		object obj4 = !flag3;
		object obj5 = ~obj4;
		if (obj5 == null)
		{
			return addedchar;
		}
		return '\0';
	}

	static InputSanitizer()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3920;
		object pattern = "1.2.840.113549.1.12.1.5" + 2224;
		object obj2 = typeof(System.IOAsyncCallback) + 3096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Regex regex = default(Regex);
		regex..ctor((string)pattern);
		object obj3 = obj2;
		object obj4 = regex;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
