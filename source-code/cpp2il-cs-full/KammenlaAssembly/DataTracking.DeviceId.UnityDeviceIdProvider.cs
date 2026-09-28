using Cpp2ILInjected;
using UnityEngine.Device;

namespace DataTracking.DeviceId;

public class UnityDeviceIdProvider : IDeviceIdProvider
{
	public unsafe bool TryGetDeviceId(out string deviceId)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object obj = "m_StencilDeferredPS" + 2856;
		string deviceUniqueIdentifier = SystemInfo.deviceUniqueIdentifier;
		ref string reference = ref *(string*)deviceUniqueIdentifier;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return deviceId != (string)obj;
	}
}
