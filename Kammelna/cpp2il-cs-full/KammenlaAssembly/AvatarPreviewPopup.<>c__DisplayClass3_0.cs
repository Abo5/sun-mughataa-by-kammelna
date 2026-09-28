using System;
using System.Buffers.Text;
using System.Diagnostics;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using GoogleMobileAds.Ump.Api;
using Unity.Services.Authentication.Shared;
using UnityEngine;

public class AvatarPreviewPopup : MonoBehaviour
{
	private sealed class <>c__DisplayClass3_0
	{
		public string dbId;

		internal void <Show>b__0(AvatarPreviewPopup popup)
		{
			popup.ShowPopup(dbId);
		}
	}

	private static readonly AddressReference<AvatarPreviewPopup> Address;

	private PopupUI popup;

	private AvatarInitializer avatar;

	public static void Show(string dbId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I4
		//IL_010e: Expected O, but got I
		//IL_011e: Expected O, but got I
		//IL_0139: Expected I, but got O
		//IL_0163: Expected O, but got I4
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1792;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1240;
		object obj5 = (nint)0 + (nint)576;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj7 = obj2 + 16;
		obj7 = dbId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj3;
		}
		object obj10 = (nint)0 + (nint)1824;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v9+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj5);
		object obj12 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v12+E4]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80C64");
	}

	private void ShowPopup(string dbId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006f: Expected I, but got O
		//IL_0099: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
		object obj2 = (nint)0 + (nint)2120;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerProfilesHandler.RequestUserProfile(dbId, action);
	}

	static AvatarPreviewPopup()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object obj = "AvailableVoices" + 16;
		object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 3000;
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1792;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj4 = obj3;
		object obj6 = default(object);
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void <ShowPopup>b__4_0(PlayerProfileModel profileModel)
	{
		popup.PopFromCenter(1f);
		AvatarData data = profileModel;
		avatar.Initialize(data);
	}
}
