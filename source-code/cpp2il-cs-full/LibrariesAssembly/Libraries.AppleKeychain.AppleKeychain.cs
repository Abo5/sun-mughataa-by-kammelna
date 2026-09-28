using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Libraries.AppleKeychain;

public static class AppleKeychain
{
	[PreserveSig]
	private static extern string _Get(string dataType);

	[PreserveSig]
	private static extern int _Add(string dataType, string value);

	[PreserveSig]
	private static extern int _Delete(string dataType);

	public static bool Add(string name, string value)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @20A9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
		object obj = default(object);
		return obj == null;
	}

	public static string Get(string name)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @20914");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FA0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
		string result = default(string);
		return result;
	}

	public static bool Delete(string name)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @20E20");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
		object obj = default(object);
		return obj == null;
	}
}
