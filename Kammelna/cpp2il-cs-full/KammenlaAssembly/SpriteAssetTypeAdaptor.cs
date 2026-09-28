using System;
using System.Formats.Asn1;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Purchasing.Telemetry;

public class SpriteAssetTypeAdaptor : IRemoteAssetTypeAdaptor<Sprite>
{
	private static readonly DownloadedTextureParams DownloadedTextureParams;

	public UnityWebRequest GetWebRequest(string url)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005a: Expected O, but got I4
		//IL_0078: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1200;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+B8]");
		object parameters = 0;
		return UnityWebRequestTexture.GetTexture(url, (DownloadedTextureParams)parameters);
	}

	public Sprite ConvertRequestResultToAsset(UnityWebRequest assetRequest)
	{
		//IL_00ac: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		Texture2D content = DownloadHandlerTexture.GetContent(assetRequest);
		if ((object)content != null)
		{
			content.filterMode = FilterMode.Point;
			content.wrapMode = TextureWrapMode.Clamp;
			if (UIExtensions.IsValid(content))
			{
				int width = content.width;
				int height = content.height;
				SpriteMeshType meshType = default(SpriteMeshType);
				return Sprite.Create(content, (Rect)0, (Vector2)0, 0f, 0u, meshType);
			}
			return null;
		}
		return (Sprite)(object)new NullReferenceException();
	}

	public Sprite ConvertBinaryDataToAsset(byte[] assetBinaryData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_008c: Expected O, but got I4
		//IL_008c: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Texture2D texture2D = default(Texture2D);
		texture2D..ctor(2, 2, TextureFormat.ARGB32, mipChain: false, linear: false);
		if ((object)texture2D != null)
		{
			texture2D.filterMode = FilterMode.Point;
			texture2D.wrapMode = TextureWrapMode.Clamp;
			bool flag = ImageConversion.LoadImage(texture2D, assetBinaryData, markNonReadable: false);
			int width = texture2D.width;
			int height = texture2D.height;
			return Sprite.Create(texture2D, (Rect)0, (Vector2)0, 0f, 0u, SpriteMeshType.FullRect);
		}
		return (Sprite)(object)new NullReferenceException();
	}

	static SpriteAssetTypeAdaptor()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1200;
		DownloadedTextureParams downloadedTextureParams = default(DownloadedTextureParams);
		downloadedTextureParams.readable = false;
		downloadedTextureParams.mipmapChain = false;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X9_v1+B8]");
		object obj3 = 0;
		obj3 = downloadedTextureParams;
	}
}
