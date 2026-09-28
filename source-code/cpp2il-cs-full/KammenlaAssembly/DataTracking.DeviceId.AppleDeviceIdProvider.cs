using Cpp2ILInjected;
using Libraries.AppleKeychain;
using UnityEngine.Device;

namespace DataTracking.DeviceId;

public class AppleDeviceIdProvider : IDeviceIdProvider
{
	private const string DeviceIdKey = "KammelnaId";

	public unsafe bool TryGetDeviceId(out string deviceId)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_009f: Expected O, but got I4
		object name = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3632;
		object obj = "m_StencilDeferredPS" + 2856;
		string text = AppleKeychain.Get((string)name);
		bool flag = text == null;
		object obj2 = !flag;
		string text2 = text;
		if (obj2 == null)
		{
			string deviceUniqueIdentifier = SystemInfo.deviceUniqueIdentifier;
			bool flag2 = AppleKeychain.Add((string)name, deviceUniqueIdentifier);
			text2 = deviceUniqueIdentifier;
		}
		ref string reference = ref *(string*)text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return deviceId != (string)obj;
	}
}
