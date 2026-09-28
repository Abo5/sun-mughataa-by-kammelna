namespace Managers.IAP;

public interface IStoreKitListener
{
	void OnStoreKitProductsLoaded();

	void OnIntroOfferEligibilityChecked(bool isEligible);
}
