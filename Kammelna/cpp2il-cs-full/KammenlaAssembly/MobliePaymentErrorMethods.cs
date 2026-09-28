using System;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Unity.Services.Authentication.Shared;

public static class MobliePaymentErrorMethods
{
	public unsafe static string GetErrorLanguageConstant(MobliePaymentError mobliePaymentError)
	{
		//IL_011b: Expected O, but got I4
		//IL_0135: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0050: Expected O, but got Ref
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		//IL_0024: Expected O, but got I
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00f0: Expected O, but got I
		object obj = mobliePaymentError - 1;
		bool flag = (nint)obj < 27;
		object obj2 = !flag;
		if (obj2 == null)
		{
			object obj3 = 139821056 + 2960;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X9_v2+v39 @ X8_v3*8]");
			return (string)0;
		}
		object obj4 = typeof(MemberAchievementClanFeedData) + 992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		object obj5 = default(object);
		string text = ((Enum)(&obj5)).ToString();
		object obj6 = "https://www.kammelna.com/Home/Terms" + 920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		string text2 = default(string);
		string message = text2 + text;
		object obj7 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = "m_StencilDeferredPS" + 2208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentException ex = default(ArgumentException);
		string paramName = default(string);
		ex..ctor(message, paramName);
		object obj9 = (nint)0 + (nint)3216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (string)(object)new OutOfMemoryException();
	}

	public static MobliePaymentError fromIntRepresentation(int mobilePaymentError)
	{
		//IL_001a: Expected O, but got I4
		bool flag = mobilePaymentError < 27;
		object obj = !flag;
		object obj2 = ~obj;
		object obj3 = ~obj2;
		if (obj3 == null)
		{
			return (MobliePaymentError)mobilePaymentError;
		}
		return MobliePaymentError.UNKNOWN_ERROR;
	}
}
