using System.Buffers.Text;
using System.ComponentModel;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

public class BuyGiftBombRequest : JsonWebRequest<GiftBombCreationRequestModel, bool>
{
	private readonly GiftBombCreationRequestModel <PostData>k__BackingField;

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
			object obj2 = "alignContent" + 1336;
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

	protected override GiftBombCreationRequestModel PostData => <PostData>k__BackingField;

	public BuyGiftBombRequest(GiftBombType giftBombType, int size, int count, string message)
	{
		//IL_000c: Expected O, but got I
		//IL_0018: Expected O, but got I
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0078: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_012b: Expected O, but got I4
		//IL_0162: Expected O, but got I4
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		object obj = (nint)0 + (nint)288;
		object obj2 = (nint)0 + (nint)2000;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2840;
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4D12340");
		bool flag = message == (string)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = default(object);
		obj5..ctor();
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string serverID = Config.ServerID;
		int num = int.Parse(serverID);
		GameConfiguration currentGameConfiguration = Config.CurrentGameConfiguration;
		object obj8 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj9 = obj5 + 24;
		obj9 = currentGameConfiguration.<Zone>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v18+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = !flag;
		object obj12 = !flag4;
		object obj13 = ~obj12;
		string text = ((obj13 != null) ? message : null);
		Games currentGame = Preferences.CurrentGame;
		object obj14 = obj5 + 48;
		obj14 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj15 = this + 48;
		obj15 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
