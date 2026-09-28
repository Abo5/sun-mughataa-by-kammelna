using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using UnityEngine.Purchasing.Telemetry;

namespace Kammelna.Server.WebRequests;

public sealed class ResetTestAccountsRequest : JsonWebRequest<ResetTestAccountsRequest.Body, List<TestAccountResetResultModel>>
{
	public sealed class Body
	{
		private readonly List<string> <Roles>k__BackingField;

		private readonly int? <AcesBaseline>k__BackingField;

		private readonly bool <RefillMiniGameTrials>k__BackingField;

		private readonly bool <LeaveClans>k__BackingField;

		private readonly bool <RevokeTokens>k__BackingField;

		public List<string> Roles => <Roles>k__BackingField;

		public int? AcesBaseline => <AcesBaseline>k__BackingField;

		public bool RefillMiniGameTrials => <RefillMiniGameTrials>k__BackingField;

		public bool LeaveClans => <LeaveClans>k__BackingField;

		public bool RevokeTokens => <RevokeTokens>k__BackingField;

		public Body(List<string> roles, int? acesBaseline, bool refillMiniGameTrials, bool leaveClans, bool revokeTokens)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			object obj = this + 16;
			obj = roles;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private readonly Body <PostData>k__BackingField;

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
			object obj2 = "alignContent" + 1872;
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

	protected override Body PostData => <PostData>k__BackingField;

	public ResetTestAccountsRequest(string testKey, List<string> roles = null, int? acesBaseline = null, bool refillMiniGameTrials = true, bool leaveClans = true, bool revokeTokens = false)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		object obj = (nint)0 + (nint)512;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 144;
		((JsonWebRequest<object, object>)(object)this)..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj6 = default(object);
		object obj5 = obj6 + 16;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj6..ctor();
		object obj7 = obj6 + 24;
		obj7 = testKey;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = this + 16;
		obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 912;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = default(object);
		obj10..ctor();
		object obj11 = obj10 + 16;
		obj11 = roles;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj12 = this + 48;
		obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
