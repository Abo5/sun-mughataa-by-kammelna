using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class TournamentViewNavigator : MonoBehaviour
{
	private RoutingEventsChannel _routingEventsChannel;

	private Toggle TournamentOverview;

	private Toggle TournamentBracket;

	private Toggle ClusterTournaments;

	private Toggle TournamentTeams;

	private Toggle TournamentChat;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 656;
		object obj2 = (nint)0 + (nint)1608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum, object> action = default(Action<System.Int32Enum, object>);
		action..ctor((object)this, (IntPtr)obj2);
		_routingEventsChannel.OnRoute += (Action<RoutingCommand, string>)(object)action;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 656;
		object obj2 = (nint)0 + (nint)1608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum, object> action = default(Action<System.Int32Enum, object>);
		action..ctor((object)this, (IntPtr)obj2);
		_routingEventsChannel.OnRoute -= (Action<RoutingCommand, string>)(object)action;
	}

	private void OnRoute(RoutingCommand command, string commandParam)
	{
		//IL_0112: Expected O, but got I4
		//IL_0260: Expected O, but got I4
		//IL_0030: Expected O, but got I4
		//IL_014a: Expected O, but got I4
		//IL_0062: Expected O, but got I4
		//IL_01a4: Expected O, but got I4
		//IL_0217: Expected O, but got I4
		//IL_0094: Expected O, but got I4
		//IL_00ee: Expected O, but got I4
		Toggle toggle;
		NullReferenceException ex;
		if (command > RoutingCommand.TournamentBracket)
		{
			object obj = command - 12003;
			if (command != RoutingCommand.ClusterTournaments)
			{
				obj = command - 12004;
				if (command != RoutingCommand.TournamentTeams)
				{
					obj = command - 12005;
					bool flag = obj == null;
					if (command != RoutingCommand.TournamentChat)
					{
						return;
					}
					toggle = TournamentChat;
					bool flag2 = (object)TournamentChat == null;
					object obj2 = !flag2;
					if (obj2 != null)
					{
						goto IL_01e2;
					}
				}
				else
				{
					toggle = TournamentTeams;
					bool flag3 = (object)TournamentTeams == null;
					object obj3 = !flag3;
					if (obj3 != null)
					{
						goto IL_01e2;
					}
				}
			}
			else
			{
				toggle = ClusterTournaments;
				if ((object)ClusterTournaments != null)
				{
					goto IL_01e2;
				}
			}
		}
		else
		{
			object obj = command - 12001;
			bool flag = command == RoutingCommand.TournamentOverview;
			ex = (NullReferenceException)(object)this;
			if (flag)
			{
				goto IL_0234;
			}
			obj = command - 12002;
			flag = obj == null;
			if (command != RoutingCommand.TournamentBracket)
			{
				return;
			}
			toggle = TournamentBracket;
			bool flag4 = (object)TournamentBracket == null;
			object obj4 = !flag4;
			if (obj4 != null)
			{
				goto IL_01e2;
			}
		}
		goto IL_0226;
		IL_0226:
		ex = new NullReferenceException();
		goto IL_0234;
		IL_0234:
		toggle = (Toggle)(object)((Exception)ex)._innerException;
		bool flag5 = ((Exception)ex)._innerException == null;
		object obj5 = !flag5;
		if (obj5 != null)
		{
			goto IL_01e2;
		}
		goto IL_0226;
		IL_01e2:
		toggle.isOn = true;
	}
}
