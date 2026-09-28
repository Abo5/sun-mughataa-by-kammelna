using System;
using System.Text;
using Cpp2ILInjected;
using UnityEngine.Networking;

public class TextAssetTypeAdaptor : IRemoteAssetTypeAdaptor<string>
{
	public UnityWebRequest GetWebRequest(string url)
	{
		return UnityWebRequest.Get(url);
	}

	public string ConvertRequestResultToAsset(UnityWebRequest assetRequest)
	{
		if (assetRequest != null)
		{
			DownloadHandler downloadHandler = assetRequest.downloadHandler;
			if (downloadHandler != null)
			{
				return downloadHandler.text;
			}
		}
		return (string)(object)new NullReferenceException();
	}

	public string ConvertBinaryDataToAsset(byte[] assetBinaryData)
	{
		//IL_002e: Expected I, but got O
		//IL_003e: Expected O, but got I
		//IL_004e: Expected O, but got I
		Encoding uTF = Encoding.UTF8;
		if (uTF != null)
		{
			nint num = (nint)uTF;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X8_v1 (Il2CppClass<System.Text.Encoding>)+378]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X8_v1 (Il2CppClass<System.Text.Encoding>)+380]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v16 @ X3_v1 (should have been resolved before IL gen)");
		}
		return (string)(object)new NullReferenceException();
	}
}
