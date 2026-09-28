using UnityEngine.Networking;

public interface IRemoteAssetTypeAdaptor<out T>
{
	UnityWebRequest GetWebRequest(string url);

	T ConvertRequestResultToAsset(UnityWebRequest assetRequest);

	T ConvertBinaryDataToAsset(byte[] assetBinaryData);
}
