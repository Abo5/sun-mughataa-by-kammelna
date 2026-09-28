using System;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class MassBannerItem : MonoBehaviour
{
	private Image image;

	private ElegantLoadingIndicator loading;

	private MassEventSponsorBannerViewModel _banner;

	public void Populate(MassEventSponsorBannerViewModel banner, long massTournamentId)
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0016: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_003b: Expected O, but got I
		//IL_0068: Expected I, but got O
		object obj = this + 48;
		obj = banner;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X22_v3-8]");
		((ElegantLoadingIndicator)0).StartLoading();
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj3 = (nint)0 + (nint)3064;
		image.enabled = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj3);
		UIExtensions.LoadMassTournamentBannerImage(image, banner, massTournamentId, setNative: false, action);
	}

	public void OnClick()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_007c: Expected O, but got I4
		MassEventSponsorBannerViewModel banner = _banner;
		object obj = typeof(RegisteredWaitHandle) + 1552;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RoutingManager.Route(banner.<RoutingCommand>k__BackingField, banner.<RoutingParam>k__BackingField, (Games?)(object)0);
	}

	private void <Populate>b__3_0(bool success)
	{
		loading.FinishLoading();
		image.enabled = success;
	}
}
