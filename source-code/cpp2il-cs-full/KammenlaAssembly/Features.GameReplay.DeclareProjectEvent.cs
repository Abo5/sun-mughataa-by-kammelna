namespace Features.GameReplay;

public class DeclareProjectEvent : ReplayEvent
{
	private BalootProjectExtra <BalootProject>k__BackingField;

	private long <ProjectsCards>k__BackingField;

	public BalootProjectExtra BalootProject
	{
		get
		{
			return <BalootProject>k__BackingField;
		}
		private set
		{
			<BalootProject>k__BackingField = value;
		}
	}

	public long ProjectsCards
	{
		get
		{
			return <ProjectsCards>k__BackingField;
		}
		private set
		{
			<ProjectsCards>k__BackingField = value;
		}
	}

	public DeclareProjectEvent()
	{
	}

	public DeclareProjectEvent(int playerIndex, BalootProjectExtra balootProject)
	{
		base.<PlayerIndex>k__BackingField = playerIndex;
		base.<ReplayEventType>k__BackingField = ReplayEventsTypes.DeclareProject;
		<BalootProject>k__BackingField = balootProject;
	}

	public DeclareProjectEvent(int playerIndex, long projectsCards)
	{
		base.<PlayerIndex>k__BackingField = playerIndex;
		base.<ReplayEventType>k__BackingField = ReplayEventsTypes.DeclareProject;
		<ProjectsCards>k__BackingField = projectsCards;
	}
}
