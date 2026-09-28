using System;
using UnityEngine;
using UnityEngine.UI;

public class CommunityNavigator : MonoBehaviour
{
	private Toggle OnlinePlayersTab;

	private Toggle OfficialTournamentsLeaderboardTab;

	private Toggle RankLeaderboardTab;

	public void OnRoute(RoutingCommand command, string commandParam)
	{
		//IL_00d7: Expected O, but got I4
		//IL_0080: Expected O, but got I4
		Toggle toggle;
		if (command != RoutingCommand.OfficialTournamentsLeaderboardTab)
		{
			if (command != RoutingCommand.RankLeaderboardTab)
			{
				if (command != RoutingCommand.OnlinePlayersTab)
				{
					return;
				}
				toggle = OnlinePlayersTab;
				bool flag = (object)OnlinePlayersTab == null;
				object obj = !flag;
				if (obj == null)
				{
					goto IL_00e5;
				}
			}
			else
			{
				toggle = RankLeaderboardTab;
			}
		}
		else
		{
			toggle = OfficialTournamentsLeaderboardTab;
			bool flag2 = (object)OfficialTournamentsLeaderboardTab == null;
			object obj2 = !flag2;
			if (obj2 == null)
			{
				goto IL_00e5;
			}
		}
		toggle.isOn = true;
		return;
		IL_00e5:
		throw new NullReferenceException();
	}
}
