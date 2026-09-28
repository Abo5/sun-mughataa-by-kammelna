using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Server.Models;
using UnityEngine;
using UnityEngine.UI;

public class MassImageSetter : MassWidget
{
	private Image image;

	private ImageCacher.MassTournamentImageType massImageType;

	protected override void Initialize()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0075: Expected O, but got I
		//IL_00a4: Expected I, but got O
		GameObject gameObject = image.gameObject;
		gameObject.SetActive(value: false);
		MassTournamentInfo tournamentLiveData = ((MassTournamentServerConnector)(object)gameObject).GetTournamentLiveData();
		MassEventModel cachedMassEvent = MassTournamentManager.GetCachedMassEvent(tournamentLiveData.<Id>k__BackingField);
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj2 = (nint)0 + (nint)1928;
		GameObject gameObject2 = image.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)gameObject2, (IntPtr)obj2);
		UIExtensions.LoadMassTournamentImage(image, cachedMassEvent, massImageType, setNative: false, action);
	}

	private void Reset()
	{
		//IL_000c: Expected O, but got I
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object obj = (nint)0 + (nint)1008;
		object obj2 = this + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
	}
}
