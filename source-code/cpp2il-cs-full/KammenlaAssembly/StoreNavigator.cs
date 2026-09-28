using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class StoreNavigator : MonoBehaviour
{
	private RoutingEventsChannel _routingEventsChannel;

	private Toggle subscriptionTab;

	private Toggle goldenCardsTab;

	private Toggle homeStoreTab;

	private Toggle roomThemesTab;

	private Toggle cardsbackTab;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 656;
		object obj2 = (nint)0 + (nint)56;
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
		object obj2 = (nint)0 + (nint)56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum, object> action = default(Action<System.Int32Enum, object>);
		action..ctor((object)this, (IntPtr)obj2);
		_routingEventsChannel.OnRoute -= (Action<RoutingCommand, string>)(object)action;
	}

	public void OnRoute(RoutingCommand command, string commandParam)
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
		Toggle stackTrace;
		NullReferenceException ex;
		if (command > RoutingCommand.CardsStore)
		{
			object obj = command - 7003;
			if (command != RoutingCommand.RoomThemesStore)
			{
				obj = command - 7004;
				if (command != RoutingCommand.SubscriptionsStore)
				{
					obj = command - 7005;
					bool flag = obj == null;
					if (command != RoutingCommand.GoldenCardsStore)
					{
						return;
					}
					stackTrace = goldenCardsTab;
					bool flag2 = (object)goldenCardsTab == null;
					object obj2 = !flag2;
					if (obj2 != null)
					{
						goto IL_01e2;
					}
				}
				else
				{
					stackTrace = subscriptionTab;
					bool flag3 = (object)subscriptionTab == null;
					object obj3 = !flag3;
					if (obj3 != null)
					{
						goto IL_01e2;
					}
				}
			}
			else
			{
				stackTrace = roomThemesTab;
				if ((object)roomThemesTab != null)
				{
					goto IL_01e2;
				}
			}
		}
		else
		{
			object obj = command - 7001;
			bool flag = command == RoutingCommand.MainStore;
			ex = (NullReferenceException)(object)this;
			if (flag)
			{
				goto IL_0234;
			}
			obj = command - 7002;
			flag = obj == null;
			if (command != RoutingCommand.CardsStore)
			{
				return;
			}
			stackTrace = cardsbackTab;
			bool flag4 = (object)cardsbackTab == null;
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
		stackTrace = (Toggle)((Exception)ex)._stackTrace;
		bool flag5 = ((Exception)ex)._stackTrace == null;
		object obj5 = !flag5;
		if (obj5 != null)
		{
			goto IL_01e2;
		}
		goto IL_0226;
		IL_01e2:
		stackTrace.isOn = true;
	}
}
