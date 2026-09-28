using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server.WebRequests;
using Libraries.AppCheck;
using Unity.Services.Authentication.Shared;
using UnityEngine;

namespace Util;

public class PerformIntegrityCheckOperation : CustomYieldInstruction
{
	private bool _keepWaiting;

	private AppIntegrityRequestModel <Result>k__BackingField;

	public override bool keepWaiting => _keepWaiting;

	public AppIntegrityRequestModel Result
	{
		get
		{
			return <Result>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public PerformIntegrityCheckOperation(BaseWebRequest<ServerChallengeResult> request)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_009d: Expected I, but got O
		//IL_005d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 480;
		object obj2 = (nint)0 + (nint)3072;
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 72;
		object obj4 = (nint)0 + (nint)3080;
		_keepWaiting = true;
		base..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		AppCheckResult appCheckResult = default(AppCheckResult);
		appCheckResult..ctor(this, (IntPtr)obj4);
		KammelnaRequests.PerformIntegrityCheck(request, action, appCheckResult);
	}

	private void <.ctor>b__7_0(KammelnaResponseModel<AuthModel> responseModel)
	{
		_keepWaiting = false;
	}

	private void <.ctor>b__7_1(AppIntegrityRequestModel integrityRequestModel)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 24;
		obj = integrityRequestModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 0;
	}
}
