using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class PredictAndWinNavigator : MonoBehaviour
{
	private RoutingEventsChannel _routingEventsChannel;

	private Toggle PredictionsLeaderboardTab;

	private Toggle UpcomingPredictionMatchesTab;

	private Toggle MyPredictionsTab;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 656;
		object obj2 = (nint)0 + (nint)1640;
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
		object obj2 = (nint)0 + (nint)1640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum, object> action = default(Action<System.Int32Enum, object>);
		action..ctor((object)this, (IntPtr)obj2);
		_routingEventsChannel.OnRoute -= (Action<RoutingCommand, string>)(object)action;
	}

	private void OnRoute(RoutingCommand command, string commandParam)
	{
		//IL_00d7: Expected O, but got I4
		//IL_0080: Expected O, but got I4
		Toggle toggle;
		if (command != RoutingCommand.UpcomingPredictionMatches)
		{
			if (command != RoutingCommand.MyPredictions)
			{
				if (command != RoutingCommand.PredictionsLeaderboard)
				{
					return;
				}
				toggle = PredictionsLeaderboardTab;
				bool flag = (object)PredictionsLeaderboardTab == null;
				object obj = !flag;
				if (obj == null)
				{
					goto IL_00e5;
				}
			}
			else
			{
				toggle = MyPredictionsTab;
			}
		}
		else
		{
			toggle = UpcomingPredictionMatchesTab;
			bool flag2 = (object)UpcomingPredictionMatchesTab == null;
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
