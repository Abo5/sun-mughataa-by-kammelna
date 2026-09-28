using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DataTracking;
using UnityEngine.Purchasing.Telemetry;

namespace Kammelna.Server.WebRequests;

public class ResetPasswordRequest : JsonWebRequest<ResetPasswordModel, bool>
{
	private readonly ResetPasswordModel <PostData>k__BackingField;

	protected override HttpMethod Method => HttpMethod.POST;

	public override string EndPoint
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_0085: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = "alignContent" + 1792;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string backendURL = Config.BackendURL;
			return backendURL + (string)obj2;
		}
	}

	protected override ResetPasswordModel PostData => <PostData>k__BackingField;

	public ResetPasswordRequest(ResetPasswordModel model)
	{
		//IL_000c: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		object obj = (nint)0 + (nint)376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4D12340");
		object obj2 = this + 48;
		obj2 = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	protected override void OnError()
	{
		//IL_000c: Expected O, but got I
		//IL_001d: Expected O, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		object obj = (nint)0 + (nint)3944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4290BB8");
		object obj2 = (nint)0 + (nint)1024;
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4D136BC");
		string error = default(string);
		ITrackEvent trackEvent = TrackerLibrary.AccountRestPasswordError(error);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v5+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}
}
