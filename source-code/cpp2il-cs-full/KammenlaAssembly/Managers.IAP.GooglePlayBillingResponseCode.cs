namespace Managers.IAP;

public enum GooglePlayBillingResponseCode
{
	FeatureNotSupported = -2,
	ServiceDisconnected = -1,
	Ok = 0,
	UserCanceled = 1,
	ServiceUnavailable = 2,
	BillingUnavailable = 3,
	ItemUnavailable = 4,
	DeveloperError = 5,
	Error = 6,
	ItemAlreadyOwned = 7,
	ItemNotOwned = 8,
	NetworkError = 12
}
