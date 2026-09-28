using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine;

public class MassActiveTournamentsPopup : MonoBehaviour
{
	private PopupUI popup;

	private TournamentsListView roomsListView;

	public void Show(MassTournamentServerConnector connector)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 888;
		object obj2 = (nint)0 + (nint)3024;
		popup.SlideFromBottom();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		connector.RequestRoomsList(action);
	}

	private void OnRoomsLoaded(List<TournamentRoomModel> rooms)
	{
		roomsListView.SetTournamentRooms(rooms);
	}
}
