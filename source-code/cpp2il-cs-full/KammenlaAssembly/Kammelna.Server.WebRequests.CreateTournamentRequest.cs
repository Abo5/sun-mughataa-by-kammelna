using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using UnityEngine.InputSystem.XR;

namespace Kammelna.Server.WebRequests;

public class CreateTournamentRequest : JsonWebRequest<TournamentCreationModel, Tournament>
{
	private readonly TournamentCreationModel <PostData>k__BackingField;

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
			object obj2 = "alignContent" + 1632;
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

	protected override TournamentCreationModel PostData => <PostData>k__BackingField;

	public CreateTournamentRequest(TournamentCreationModel creationModel)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		((JsonWebRequest<object, object>)(object)this)..ctor();
		object obj = this + 48;
		obj = creationModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	protected override void OnSuccess()
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0036: Expected O, but got I
		//IL_011f: Expected O, but got I4
		//IL_00a7: Expected O, but got I
		//IL_00c9: Expected O, but got I4
		//IL_0155: Expected O, but got I
		//IL_01ae: Expected O, but got I4
		//IL_0232: Expected O, but got I
		//IL_0250: Expected O, but got I
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_020c: Expected O, but got I
		//IL_0265: Expected O, but got I
		//IL_027b: Expected I8, but got I
		object obj = (nint)0 + (nint)136;
		object obj2 = typeof(UsageHint) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E84F1]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj;
			((BaseWebRequest<object>)(object)this).OnSuccess();
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v12+E4]");
			if ((nint)0 != 0)
			{
				goto IL_008e;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj;
			((BaseWebRequest<object>)(object)this).OnSuccess();
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 != null)
			{
				goto IL_008e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		List<Tournament> createdTournaments = UserInfo.CreatedTournaments;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.CreateTournamentRequest)+20]");
		object obj7 = 0;
		goto IL_015a;
		IL_015a:
		int version = createdTournaments._version + 1;
		createdTournaments._version = version;
		Tournament[] items = createdTournaments._items;
		bool flag2 = createdTournaments._size < items.Length;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			int size = createdTournaments._size + 1;
			createdTournaments._size = size;
			object obj9 = items + createdTournaments._size;
			object obj10 = obj9 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v3+30]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			List<Tournament> list = createdTournaments;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v3+30]");
			((List<object>)(object)list).AddWithResize((object)0);
		}
		UserInfo.CreatedTournaments = createdTournaments;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.CreateTournamentRequest)+20]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v6+30]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v7+10]");
		SFS.SendLoadTournamentRequest(0L);
		SFS.SendRefreshStatus();
		return;
		IL_008e:
		createdTournaments = UserInfo.CreatedTournaments;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.CreateTournamentRequest)+20]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.CreateTournamentRequest)+20]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		if (obj13 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_015a;
	}
}
