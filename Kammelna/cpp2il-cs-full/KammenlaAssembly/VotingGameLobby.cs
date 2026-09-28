using System.Collections.Generic;
using Cpp2ILInjected;
using Sfs2X.Entities.Data;

public class VotingGameLobby
{
	private const string C_PlayerDecisions = "state";

	private const string C_TIME = "dt";

	public List<PlayerDecision> PlayerDecisions;

	public int Timer;

	public VotingGameLobby(ISFSObject data)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		object obj = "startPosition" + 112;
		object obj2 = (nint)0 + (nint)272;
		object varName = "destinationTimeZone" + 936;
		base..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301EE38");
		object obj3 = this + 16;
		object obj4 = default(object);
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int num = SFSExtensions.Get(data, (string)varName, 0);
	}
}
