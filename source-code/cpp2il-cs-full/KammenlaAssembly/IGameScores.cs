using Sfs2X.Entities.Data;

public interface IGameScores
{
	void SaveRoundScore(ISFSObject data);

	void Reset();
}
