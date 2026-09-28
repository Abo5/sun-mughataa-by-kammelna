using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;

public class TournamentListGroup
{
	private readonly string <Title>k__BackingField;

	private readonly List<TournamentModel> <Tournaments>k__BackingField;

	private bool <IsMonthlyAnnouncementGroup>k__BackingField;

	public string Title => <Title>k__BackingField;

	public List<TournamentModel> Tournaments => <Tournaments>k__BackingField;

	public bool IsMonthlyAnnouncementGroup
	{
		get
		{
			return <IsMonthlyAnnouncementGroup>k__BackingField;
		}
		set
		{
			<IsMonthlyAnnouncementGroup>k__BackingField = value;
		}
	}

	public TournamentListGroup()
	{
	}

	public TournamentListGroup(List<TournamentModel> tournaments)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 24;
		obj = tournaments;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public TournamentListGroup(string title, IEnumerable<TournamentModel> tournaments)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 16;
		obj = title;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		List<object> list = Enumerable.ToList((IEnumerable<object>)tournaments);
		object obj2 = this + 24;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
