using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Sfs2X.Entities;

namespace Kammelna.Server.WebRequests;

public class SetFeaturedSlotRequest : BaseWebRequest<bool>
{
	private readonly string <SlotId>k__BackingField;

	private readonly int <SlotLevel>k__BackingField;

	protected override HttpMethod Method => HttpMethod.PUT;

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
			object obj2 = "alignContent" + 1320;
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

	private string SlotId => <SlotId>k__BackingField;

	private int SlotLevel => <SlotLevel>k__BackingField;

	protected override Dictionary<string, object> QueryParams
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected O, but got Unknown
			//IL_0035: Expected O, but got I
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected O, but got Unknown
			//IL_0067: Expected O, but got I4
			object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Dictionary<object, object> dictionary = default(Dictionary<object, object>);
			dictionary..ctor();
			if (dictionary != null)
			{
				object key = "setMimeType" + 3032;
				object obj2 = (nint)0 + (nint)4088;
				object key2 = "setMimeType" + 3048;
				dictionary.Add(key, <SlotId>k__BackingField);
				object obj3 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object value = default(object);
				dictionary.Add(key2, value);
				return (Dictionary<string, object>)(object)dictionary;
			}
			return (Dictionary<string, object>)(object)new NullReferenceException();
		}
	}

	public SetFeaturedSlotRequest(string slotId, int slotLevel)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		object obj = this + 48;
		obj = slotId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	protected override void OnSuccess()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0089: Expected O, but got I4
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 296;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		base.OnSuccess();
		SFS.SendRefreshInventory();
		User mySelf = SFS.MySelf;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(mySelf);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		FeaturedSlotModel featuredSlotModel = default(FeaturedSlotModel);
		featuredSlotModel..ctor(<SlotId>k__BackingField, <SlotLevel>k__BackingField);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerProfilesHandler.RaiseFeaturedSlotChanged(intDbId, featuredSlotModel);
		SFS.SendRefreshStatus();
		PlayerProfilesHandler.RemoveMyselfFromCache();
	}
}
