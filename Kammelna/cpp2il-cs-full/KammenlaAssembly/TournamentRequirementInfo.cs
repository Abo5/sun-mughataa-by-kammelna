using UnityEngine;

public class TournamentRequirementInfo : MonoBehaviour
{
	private GameObject clusterInfo;

	private GameObject separator;

	private GameObject titleRequirement;

	private TitleSetter titleSetter;

	private RankSetter rankSetter;

	public void Initialize(TournamentData tournament)
	{
		separator.SetActive(value: false);
		clusterInfo.SetActive(value: false);
		titleRequirement.SetActive(value: false);
		if (tournament.<IsCluster>k__BackingField)
		{
			separator.SetActive(value: true);
			clusterInfo.SetActive(value: true);
		}
		TitleRestrictionTournamentAddon tournamentAddonsTitleRestriction = tournament.TournamentAddonsTitleRestriction;
		if (tournamentAddonsTitleRestriction != null)
		{
			titleRequirement.SetActive(value: true);
			TitleRestrictionTournamentAddon tournamentAddonsTitleRestriction2 = tournament.TournamentAddonsTitleRestriction;
			string achievementID = tournamentAddonsTitleRestriction2.RestrictionTitleId();
			TitleRestrictionTournamentAddon tournamentAddonsTitleRestriction3 = tournament.TournamentAddonsTitleRestriction;
			int titleLevelId = tournamentAddonsTitleRestriction3.RestrictionTitleLevel();
			titleSetter.AssignTitle(achievementID, titleLevelId);
		}
		rankSetter.SetRank(tournament.<RankLimit>k__BackingField);
	}
}
