using System;
using UnityEngine;

public abstract class TournamentAddonSelector : MonoBehaviour
{
	protected TournamentsCreationPopupEventsChannel eventsChannel;

	public abstract string Title { get; }

	public abstract string Subtitle { get; }

	public abstract TournamentAddonType addonType { get; }

	public abstract bool IsValid { get; }

	public abstract event Action OnValidStateChange;

	public abstract void OnConfirm();

	public virtual void Refresh()
	{
	}

	public virtual void ShowConfirmedSelection(TournamentAddonModel addon)
	{
	}

	public abstract void Clear();
}
