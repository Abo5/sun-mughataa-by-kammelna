using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Unity.Properties;
using Unity.Services.Authentication.Shared;

namespace Kammelna.Server.WebRequests;

public class BuyItemRequest : JsonWebRequest<BuyItemRequestModel, BuyItemResponseModel>
{
	private readonly BuyItemRequestModel <PostData>k__BackingField;

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
			object obj2 = "alignContent" + 1248;
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

	protected override BuyItemRequestModel PostData => <PostData>k__BackingField;

	public BuyItemRequest(int itemId, int? templateId, long[] recipients, IClientContext clientContext = null)
	{
		//IL_000c: Expected O, but got I
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_002d: Expected O, but got I4
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_00ab: Expected I8, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		object obj = (nint)0 + (nint)168;
		((JsonWebRequest<object, object>)(object)this)..ctor();
		long[] array;
		if (recipients != null)
		{
			object obj2 = recipients.Length != 0;
			array = recipients;
			if (obj2 != null)
			{
				goto IL_016b;
			}
		}
		object obj3 = typeof(TypeConverter<ushort, char>) + 3056;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(SFS.MySelf);
		long[] array2 = default(long[]);
		if (array2 == null)
		{
			goto IL_012b;
		}
		array2[0] = intDbId;
		obj = 0;
		array = array2;
		goto IL_016b;
		IL_016b:
		object obj4 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3784;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = default(object);
		obj5..ctor();
		if (obj5 != null)
		{
			object obj6 = obj5 + 32;
			obj6 = array;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = this + 48;
			obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj8 = this + 16;
			obj8 = clientContext;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return;
		}
		goto IL_012b;
		IL_012b:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	protected override void OnSuccess()
	{
		((BaseWebRequest<object>)(object)this).OnSuccess();
		SFS.SendRefreshInventory();
	}
}
