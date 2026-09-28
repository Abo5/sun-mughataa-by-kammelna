using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using Cpp2ILInjected;
using Kammelna.Server;
using Sfs2X.Entities;
using UnityEngine;

namespace UI.Conditions;

[Serializable]
public class MassTournamentExistsCondition : BoolCondition
{
	private MassTournamentsListEventsChannel eventsChannels;

	protected override bool ActualValue
	{
		get
		{
			IEnumerable<Room> massTournamentRooms = SFS.MassTournamentRooms;
			return Enumerable.Any((IEnumerable<object>)massTournamentRooms);
		}
	}

	public override void Setup(GameObject gm)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		eventsChannels.OnTournamentsChanged += action;
	}

	public override void Teardown()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		eventsChannels.OnTournamentsChanged -= action;
	}

	private void Refresh()
	{
		Actions.SafeInvoke(base.OnConditionChanged);
	}

	public MassTournamentExistsCondition()
	{
		isActive = true;
		((object)this)..ctor();
	}
}
