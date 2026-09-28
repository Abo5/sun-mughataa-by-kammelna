using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Mono.Btls;
using UnityEngine.Purchasing.Telemetry;

namespace Kammelna.Server.WebRequests;

public sealed class ProvisionTestAccountsRequest : JsonWebRequest<ProvisionTestAccountsRequest.Body, TestAccountProvisionResultModel>
{
	public sealed class Body
	{
		private readonly string <PasswordOverride>k__BackingField;

		private readonly bool <RetirePreviousRuns>k__BackingField;

		private readonly int? <AcesBaseline>k__BackingField;

		public string PasswordOverride => <PasswordOverride>k__BackingField;

		public bool RetirePreviousRuns => <RetirePreviousRuns>k__BackingField;

		public int? AcesBaseline => <AcesBaseline>k__BackingField;

		public Body(string passwordOverride, bool retirePreviousRuns, int? acesBaseline)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			object obj = this + 16;
			obj = passwordOverride;
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
			object obj2 = "alignContent" + 1864;
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

	public ProvisionTestAccountsRequest(string testKey, string passwordOverride = null, bool retirePreviousRuns = true, int? acesBaseline = null)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		object obj = (nint)0 + (nint)496;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 144;
		object obj3 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3704;
		((JsonWebRequest<object, object>)(object)this)..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = default(object);
		obj5..ctor();
		object obj7 = default(object);
		object obj6 = obj7 + 16;
		obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj7..ctor();
		object obj8 = obj7 + 24;
		obj8 = testKey;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = this + 16;
		obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = default(object);
		obj10..ctor();
		object obj11 = obj10 + 16;
		obj11 = passwordOverride;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj12 = this + 48;
		obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
