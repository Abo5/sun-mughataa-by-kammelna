namespace Kammelna.Server.WebRequests;

public enum ClientCapability
{
	StatusCodesV2 = 1,
	PushV1 = 2,
	BackoffV1 = 4,
	ConfigV1 = 8,
	StoreSplit = 0x10,
	Integrity = 0x20
}
