namespace DataTracking.Strategies;

public interface IAnalyticsStrategy
{
	void AdEvent(string adSDK, AdAction adAction, AdType adType, AdPlace adPlacement);

	void PurchaseEvent(string shop, TrackerPurchase purchaseType, string itemId, double price, string currencyCode);

	void DesignEvent(ITrackEvent trackEvent);

	void ResourceEvent(ResourceFlowType flowType, ResourceItemType type, string itemId, double amount, ResourceCurrency currency);

	void SetDimensions(DimensionsModel dimensions);
}
