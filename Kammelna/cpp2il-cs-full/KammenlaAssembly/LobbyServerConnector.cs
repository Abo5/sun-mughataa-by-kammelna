using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;

public abstract class LobbyServerConnector : MonoBehaviour
{
	protected LobbyPanel panel;

	private void Start()
	{
		//IL_0005: Expected I, but got O
		//IL_0015: Expected O, but got I
		//IL_0025: Expected O, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<LobbyServerConnector>)+178]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<LobbyServerConnector>)+180]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v2 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected virtual void Initialize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ac: Expected O, but got I
		//IL_00d6: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0076: Expected I, but got O
		//IL_0086: Expected O, but got I
		//IL_0096: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj6 = default(object);
		while (true)
		{
			object obj2 = (nint)0 + (nint)160;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			object obj5 = this + 32;
			obj5 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = obj5 + 168;
			obj7 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v4 (Il2CppClass<LobbyServerConnector>)+188]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v4 (Il2CppClass<LobbyServerConnector>)+190]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v69 @ X2_v1 (should have been resolved before IL gen)");
		}
	}

	protected abstract void AddServerListeners();

	public abstract void SendKickCommand(int playerId);

	public abstract void SendSetTeamCommand(int playerId, int team);

	public abstract void SendStartGame();
}
