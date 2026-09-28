using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Libraries.AppCheck;
using Server.Models;
using Unity.Services.Authentication.Shared;

namespace Kammelna.Server.WebRequests;

public class GetAuthTokenRequest : JsonWebRequest<UserCredentials, AuthModel>
{
	private readonly UserCredentials <PostData>k__BackingField;

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
			object obj2 = "alignContent" + 1896;
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

	protected override UserCredentials PostData => <PostData>k__BackingField;

	public GetAuthTokenRequest(UserCredentials userCredentials)
	{
		//IL_000c: Expected O, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_002e: Expected O, but got I4
		//IL_003e: Expected O, but got I
		//IL_004e: Expected O, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00ae: Expected O, but got I
		//IL_00be: Expected O, but got I
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_011e: Expected O, but got I
		//IL_012e: Expected O, but got I
		//IL_0081: Expected O, but got I4
		//IL_00f1: Expected O, but got I4
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_0161: Expected O, but got I4
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_0239: Expected O, but got I
		object obj = (nint)0 + (nint)464;
		((JsonWebRequest<object, object>)(object)this)..ctor();
		object obj2 = userCredentials + 16;
		object obj3 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X22_v5+90]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4+B8]");
		if ((string)obj2 == (string)0)
		{
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		object obj5 = userCredentials + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X22_v5+90]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v6+B8]");
		if ((string)obj5 == (string)0)
		{
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		object obj7 = userCredentials + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X22_v5+90]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v8+B8]");
		if ((string)obj7 == (string)0)
		{
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		if (userCredentials.IsValid())
		{
			object obj9 = this + 48;
			obj9 = userCredentials;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return;
		}
		object obj10 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = "not" + 3552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		object obj12 = "tournament_participate_warning_body_with_tickets_warning_daily" + 3928;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentException ex = default(ArgumentException);
		string message = default(string);
		string paramName = default(string);
		ex..ctor(message, paramName);
		object obj13 = (nint)0 + (nint)3008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	protected override void OnSuccess()
	{
		//IL_009c: Expected O, but got I
		//IL_0016: Expected O, but got I
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_00b6: Expected O, but got I
		//IL_00c6: Expected O, but got I
		//IL_003f: Expected O, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_00e0: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_0085: Expected O, but got I4
		((BaseWebRequest<object>)(object)this).OnSuccess();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.GetAuthTokenRequest)+20]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3+30]");
		object obj2 = 0;
		object key = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3176;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v5+10]");
		Authentication.SetToken((TokenModel)0, (string)key);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.GetAuthTokenRequest)+20]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v8+30]");
		object obj4 = 0;
		object obj5 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
		object key2 = "Read object reference Id '{0}' for {1}." + 1120;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v9+18]");
		Authentication.SetToken((TokenModel)0, (string)key2);
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CachedModels.ClearLastUpdates((DateTime?)(object)0);
	}

	protected override void OnError()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0026: Expected O, but got I4
		//IL_005f: Expected O, but got I
		((BaseWebRequest<object>)(object)this).OnError();
		UserCredentials postData = PostData;
		object format = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3184;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string reason = string.Format((string)format, arg);
		Authentication.Clear(reason);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.GetAuthTokenRequest)+20]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v9+14]");
		if ((nint)0 == 2008)
		{
			AppCheckManager.Clear();
		}
	}
}
