using System.Collections;

public interface IAssetLoader
{
	bool IsLocalOnly { get; }

	IEnumerator LoadAsset<T>(AssetLoadingModel<T> asset) where T : class;

	void CacheLoadedAsset<T>(AssetLoadingModel<T> asset) where T : class;

	void DeleteAsset(string assetId, string localAssetPath);

	void ResetEnvironment();
}
