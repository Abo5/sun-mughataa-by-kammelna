using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

public static class RankExtensions
{
	public static Card Of(Rank rank, Suit suit)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card = default(Card);
		card..ctor(rank, suit);
		return card;
	}
}
