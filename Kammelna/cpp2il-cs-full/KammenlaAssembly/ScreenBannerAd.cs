using UnityEngine;
using UnityEngine.Device;

public class ScreenBannerAd : BaseBannerAd
{
	private Camera mainCamera => Camera.main;

	protected override void SendShowBannerRequest()
	{
		adsController.ShowBannerAdOnTop();
	}

	protected override void PrepareAd(float adHeight, bool isLocalAd)
	{
		//IL_0033: Expected O, but got I4
		Camera main = Camera.main;
		int width = UnityEngine.Device.Screen.width;
		int height = UnityEngine.Device.Screen.height;
		main.pixelRect = (Rect)0;
	}
}
