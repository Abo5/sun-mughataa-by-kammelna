using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using UnityEngine.Rendering;

namespace Kammelna.Server.WebRequests;

public sealed class ForceUnlockAchievementRequest : JsonWebRequest<ForceUnlockAchievementRequest.Body, bool>
{
	public sealed class Body
	{
		private readonly long <UserId>k__BackingField;

		private readonly string <AchievementId>k__BackingField;

		public long UserId => <UserId>k__BackingField;

		public string AchievementId => <AchievementId>k__BackingField;

		public Body(long userId, string achievementId)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			object obj = this + 24;
			obj = achievementId;
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
			object obj2 = "alignContent" + 1848;
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

	public ForceUnlockAchievementRequest(long userId, string achievementId)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		object obj = (nint)0 + (nint)488;
		object obj2 = typeof(DebugUI.BitField) + 3024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4D12340");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		object obj4 = obj3 + 24;
		obj4 = achievementId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = this + 48;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
