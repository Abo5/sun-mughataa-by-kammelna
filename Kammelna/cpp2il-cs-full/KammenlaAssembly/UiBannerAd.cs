using UnityEngine;

public class UiBannerAd : BaseBannerAd
{
	protected override void SendShowBannerRequest()
	{
		//IL_0031: Expected O, but got I4
		RectTransform rectTransform = bannerAdPlaceholder.rectTransform;
		Rect screenPositionFromRect = UIExtensions.GetScreenPositionFromRect(rectTransform);
		adsController.ShowBannerAd((Rect)0);
	}

	protected override void PrepareAd(float adHeight, bool isLocalAd)
	{
		//IL_001a: Expected O, but got I4
		//IL_004c: Expected F4, but got I4
		bool flag = !isLocalAd;
		object obj = !flag;
		object obj2 = ~obj;
		float alpha = ((obj2 != null) ? 0f : 1f);
		UIExtensions.SetAlpha(bannerAdPlaceholder, alpha);
		GameObject gameObject = bannerAdPlaceholder.gameObject;
		gameObject.SetActive(value: true);
		RectTransform rectTransform = bannerAdPlaceholder.rectTransform;
		float scaleFactor = ScreenUtility.ScaleFactor;
		float size = adHeight * scaleFactor;
		rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, size);
	}
}
