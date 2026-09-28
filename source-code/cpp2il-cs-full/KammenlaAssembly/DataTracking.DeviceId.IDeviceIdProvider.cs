namespace DataTracking.DeviceId;

public interface IDeviceIdProvider
{
	bool TryGetDeviceId(out string deviceId);
}
