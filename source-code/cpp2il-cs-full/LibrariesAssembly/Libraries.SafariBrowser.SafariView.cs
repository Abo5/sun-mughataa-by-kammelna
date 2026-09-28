using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Libraries.SafariBrowser;

public static class SafariView
{
	[PreserveSig]
	private static extern void launchUrl(string url);

	[PreserveSig]
	private static extern void launchUrlWithCallback(string url, string callbackUrl);

	[PreserveSig]
	private static extern void dismiss();

	public static void LaunchUrl(string url)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2120C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
	}

	public static void LaunchUrlWithCallback(string url, string callbackUrl)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2133C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
	}

	public static void Dismiss()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21594");
	}
}
