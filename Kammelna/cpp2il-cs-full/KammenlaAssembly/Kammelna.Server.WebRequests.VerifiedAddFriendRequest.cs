using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using UnityEngine.InputSystem.XR;

namespace Kammelna.Server.WebRequests;

public class VerifiedAddFriendRequest : JsonWebRequest<VerifiedAddFriendRequestModel, PlayerProfileModel>
{
	private readonly VerifiedAddFriendRequestModel <PostData>k__BackingField;

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
			object obj2 = "alignContent" + 1240;
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

	protected override VerifiedAddFriendRequestModel PostData => <PostData>k__BackingField;

	public VerifiedAddFriendRequest(string friendCode, string inviteToken, Games game)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		object obj = (nint)0 + (nint)480;
		object obj2 = typeof(UsageHint) + 976;
		((JsonWebRequest<object, object>)(object)this)..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		object obj4 = obj3 + 16;
		obj4 = friendCode;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3 + 24;
		obj5 = inviteToken;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = this + 48;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	protected override void OnSuccess()
	{
		//IL_015f: Expected O, but got I
		//IL_0016: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0047: Expected O, but got I
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0078: Expected O, but got I
		//IL_0090: Expected O, but got I
		//IL_01a0: Expected O, but got I
		//IL_00cb: Expected O, but got I
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		((BaseWebRequest<object>)(object)this).OnSuccess();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.VerifiedAddFriendRequest)+20]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3+30]");
		object obj2 = 0;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X9_v4+B8]");
		object obj5 = 0;
		object obj6 = obj5;
		object obj7 = typeof(System.IOAsyncCallback) + 1216;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v5+68]");
		object obj8 = 0;
		object obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6+12E]");
		if ((nint)0 == 0)
		{
			goto IL_010c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6+B0]");
		object obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X10_v5-8]");
			if (0 == (nint)obj7)
			{
				break;
			}
			obj11 += 16;
			obj10--;
			if ((nint)obj10 != 1)
			{
				continue;
			}
			goto IL_010c;
		}
		object obj12 = obj11 + 5;
		object obj13 = obj9 + obj12;
		object obj14 = obj13 + 312;
		goto IL_0188;
		IL_010c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0188;
		IL_0188:
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v4+8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v86 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
