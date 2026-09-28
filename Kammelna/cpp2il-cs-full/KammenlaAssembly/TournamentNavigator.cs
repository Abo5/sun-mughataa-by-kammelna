using System;
using UnityEngine;
using UnityEngine.UI;

public class TournamentNavigator : MonoBehaviour
{
	private Toggle PublicTournamentsListTab;

	private Toggle OfficialTournamentsListTab;

	private Toggle PrivateTournamentsListTab;

	private Toggle MassTournamentsListTab;

	public void OnRoute(RoutingCommand command, string commandParam)
	{
		//IL_00dc: Expected O, but got I4
		//IL_01ee: Expected O, but got I4
		//IL_002d: Expected O, but got I4
		//IL_0113: Expected O, but got I4
		//IL_01a6: Expected O, but got I4
		//IL_005f: Expected O, but got I4
		//IL_00b9: Expected O, but got I4
		Toggle toggle;
		NullReferenceException ex;
		if (command <= RoutingCommand.OfficialTournamentsListTab)
		{
			object obj = command - 3301;
			if (command != RoutingCommand.PublicTournamentsListTab)
			{
				obj = command - 3302;
				bool flag = obj == null;
				if (command != RoutingCommand.OfficialTournamentsListTab)
				{
					return;
				}
				toggle = OfficialTournamentsListTab;
				bool flag2 = (object)OfficialTournamentsListTab == null;
				object obj2 = !flag2;
				if (obj2 != null)
				{
					goto IL_0170;
				}
			}
			else
			{
				toggle = PublicTournamentsListTab;
				bool flag3 = (object)PublicTournamentsListTab == null;
				object obj3 = !flag3;
				if (obj3 != null)
				{
					goto IL_0170;
				}
			}
		}
		else
		{
			object obj = command - 3303;
			bool flag = command == RoutingCommand.PrivateTournamentsListTab;
			ex = (NullReferenceException)(object)this;
			if (flag)
			{
				goto IL_01c2;
			}
			obj = command - 3304;
			flag = obj == null;
			if (command != RoutingCommand.MassTournamentsListTab)
			{
				return;
			}
			toggle = MassTournamentsListTab;
			if ((object)MassTournamentsListTab != null)
			{
				goto IL_0170;
			}
		}
		goto IL_01b4;
		IL_01b4:
		ex = new NullReferenceException();
		goto IL_01c2;
		IL_01c2:
		toggle = (Toggle)(object)((Exception)ex)._helpURL;
		bool flag4 = ((Exception)ex)._helpURL == null;
		object obj4 = !flag4;
		if (obj4 != null)
		{
			goto IL_0170;
		}
		goto IL_01b4;
		IL_0170:
		toggle.isOn = true;
	}
}
