using System;
using Server.Models;
using UnityEngine;

public interface ILeaderboardSource
{
	string Name { get; }

	string Title { get; }

	bool IsLive { get; }

	bool IsGameDependent { get; }

	void Load(GameObject lifecycle, Action<LeaderboardModel> successCallback, Action useCacheCallback, Action<string> onError);

	void GetMyRanking(Action<LeaderBoardPlayer> callback);

	string GetETag();

	void SetETag(string newETag);

	string GetCacheFilePath();
}
