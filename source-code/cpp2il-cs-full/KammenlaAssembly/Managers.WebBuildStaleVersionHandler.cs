using System;
using System.Formats.Asn1;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;
using UnityEngine;

namespace Managers;

public class WebBuildStaleVersionHandler : MonoBehaviour
{
	private void Awake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01bf: Expected O, but got I4
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00da: Expected O, but got I
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_0118: Expected O, but got I4
		//IL_0158: Expected I, but got O
		object obj = 152993792;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8530]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Platform platform = KUtil.GetPlatform();
		if (platform != Platform.Web)
		{
			return;
		}
		goto IL_00a6;
		IL_00a6:
		object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj7 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1840;
		object obj8 = (nint)0 + (nint)3880;
		object obj9 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v23+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object.DontDestroyOnLoad(this);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Application.LogCallback logCallback = default(Application.LogCallback);
		logCallback..ctor(this, (IntPtr)obj8);
		object obj12 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v28+E4]");
		if ((nint)0 != 0)
		{
			Application.logMessageReceivedThreaded += logCallback;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Application.logMessageReceivedThreaded += logCallback;
		return;
		IL_007d:
		Platform platform2 = KUtil.GetPlatform();
		if (platform2 == Platform.Web)
		{
			goto IL_00a6;
		}
	}

	private void OnApplicationLogMessageReceived(string logMessage, string stacktrace, LogType type)
	{
		//IL_00dc: Expected O, but got I8
		//IL_00f6: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_00bb: Expected O, but got I4
		object obj = (long)type & 0xFFFFFFFBL;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 != null)
		{
			return;
		}
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object toCheck = "Read object reference Id '{0}' for {1}." + 1568;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			if (!StringsExtensions.ContainsIgnoreCase(logMessage, (string)toCheck))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = StringsExtensions.ContainsIgnoreCase(logMessage, (string)toCheck);
			bool flag3 = !flag2;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				return;
			}
		}
		WebInterface.ClearCacheAndPromptReloadPage();
	}
}
