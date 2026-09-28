using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Unity.Services.Authentication.Shared;

namespace Kammelna.Server.WebRequests;

public class BuyProfileGiftRequest : JsonWebRequest<BuyProfileGiftModel, bool>
{
	private readonly BuyProfileGiftModel <PostData>k__BackingField;

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
			object obj2 = "alignContent" + 1256;
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

	protected override BuyProfileGiftModel PostData => <PostData>k__BackingField;

	public BuyProfileGiftRequest(long giftId, string recipientId, string message)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		object obj = (nint)0 + (nint)176;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3792;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4D12340");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		BuyProfileGiftModel buyProfileGiftModel = default(BuyProfileGiftModel);
		buyProfileGiftModel..ctor();
		buyProfileGiftModel.<GiftId>k__BackingField = giftId;
		object obj3 = buyProfileGiftModel + 32;
		obj3 = recipientId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = buyProfileGiftModel + 24;
		obj4 = message;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = this + 48;
		obj5 = buyProfileGiftModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	protected override void OnSuccess()
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)3952;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4290BB4");
		SFS.SendRefreshInventory();
	}
}
