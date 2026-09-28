using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;

namespace Kammelna.Server.WebRequests;

public class MuteClanMemberRequest : JsonWebRequest<MuteClanMemberModel, ClanChatMuteModel>
{
	private readonly MuteClanMemberModel <PostData>k__BackingField;

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
			object obj2 = "alignContent" + 976;
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

	protected override MuteClanMemberModel PostData => <PostData>k__BackingField;

	public MuteClanMemberRequest(long userId, int durationSeconds, string reason = null)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		object obj = (nint)0 + (nint)336;
		object obj2 = typeof(MemberAchievementClanFeedData) + 1848;
		((JsonWebRequest<object, object>)(object)this)..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		object obj4 = obj3 + 32;
		obj4 = reason;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = this + 48;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
