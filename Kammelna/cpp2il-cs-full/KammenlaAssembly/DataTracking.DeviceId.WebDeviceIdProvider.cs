using System;
using System.Formats.Asn1;
using Cpp2ILInjected;

namespace DataTracking.DeviceId;

public class WebDeviceIdProvider : IDeviceIdProvider
{
	private const string DeviceIdKey = "WebDeviceId";

	public unsafe bool TryGetDeviceId(out string deviceId)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I4
		//IL_0057: Expected O, but got I4
		//IL_006e: Expected O, but got I4
		//IL_014f: Expected I4, but got O
		//IL_011c: Expected O, but got I4
		object key = "Unsupported map type" + 3736;
		object defaultValue = (nint)0 + (nint)2000;
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		string text = Prefs.GetString((string)key, (string)defaultValue);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v4+E4]");
		string text2;
		if ((nint)0 != 0)
		{
			bool flag = StringsExtensions.IsNullOrEmpty(text);
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 != null)
			{
				goto IL_00c1;
			}
			object obj4 = 0;
			text2 = text;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = StringsExtensions.IsNullOrEmpty(text);
			bool flag4 = !flag3;
			object obj4 = 0;
			text2 = text;
			if (!flag4)
			{
				goto IL_00c1;
			}
		}
		goto IL_0129;
		IL_0129:
		ref string reference = ref *(string*)text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return true;
		IL_00c1:
		Guid guid = Guid.NewGuid();
		Guid guid2 = default(Guid);
		string text3 = guid2.ToString();
		if (text3 != null)
		{
			string text4 = text3.ToUpper();
			Prefs.SetString((string)key, text4);
			object obj4 = 0;
			text2 = text4;
			goto IL_0129;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
