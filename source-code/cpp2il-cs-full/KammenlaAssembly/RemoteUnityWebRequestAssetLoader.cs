using System;

public class RemoteUnityWebRequestAssetLoader : UnityWebRequestAssetLoader
{
	public override bool IsLocalOnly => false;

	protected override string GetAssetUrl<T>(AssetLoadingModel<T> asset)
	{
		if (asset != null)
		{
			return asset.<RemoteUrl>k__BackingField;
		}
		return (string)(object)new NullReferenceException();
	}

	public override void CacheLoadedAsset<T>(AssetLoadingModel<T> asset)
	{
	}
}
