using System;
using System.Buffers.Text;
using Cpp2ILInjected;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Networking;

public class AudioAssetTypeAdaptor : IRemoteAssetTypeAdaptor<AudioClip>
{
	private static readonly AudioType AudioType;

	public UnityWebRequest GetWebRequest(string url)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005a: Expected O, but got I4
		//IL_0078: Expected O, but got I
		//IL_0085: Expected I4, but got O
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1384;
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
		object obj4 = 0;
		return UnityWebRequestMultimedia.GetAudioClip(url, (AudioType)obj4);
	}

	public AudioClip ConvertRequestResultToAsset(UnityWebRequest assetRequest)
	{
		return DownloadHandlerAudioClip.GetContent(assetRequest);
	}

	public AudioClip ConvertBinaryDataToAsset(byte[] assetBinaryData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 784;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlatformNotSupportedException ex = default(PlatformNotSupportedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)1472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (AudioClip)(object)new OutOfMemoryException();
	}

	static AudioAssetTypeAdaptor()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I4
		//IL_0068: Expected O, but got I4
		//IL_00d1: Expected O, but got I
		//IL_005a: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1384;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RuntimePlatform platform = Application.platform;
		object obj5 = ((platform != RuntimePlatform.WebGLPlayer) ? ((object)14) : ((object)24));
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X9_v2+B8]");
		object obj7 = 0;
		obj7 = obj5;
	}
}
