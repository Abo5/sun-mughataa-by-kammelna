using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Server.Models;
using UnityEngine;
using UnityEngine.UI;

public class MassFinalePrizeUi : TournamentPrizeUi
{
	private Image image;

	public override void Initialize(TournamentData tournament)
	{
		//IL_0038: Expected O, but got I
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0058: Expected O, but got I
		//IL_0082: Expected I, but got O
		GameObject gameObject = image.gameObject;
		gameObject.SetActive(value: false);
		object obj = (nint)0 + (nint)3232;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2616;
		object obj3 = (nint)0 + (nint)3096;
		long? num = default(long?);
		long value = num.Value;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj3);
		MassTournamentManager.GetMassEvent(value, action);
	}

	private void <Initialize>b__1_0(MassEventModel model)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj2 = (nint)0 + (nint)3104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj2);
		UIExtensions.LoadMassTournamentImage(image, model, ImageCacher.MassTournamentImageType.PrizesGrouped, setNative: false, action);
	}

	private void <Initialize>b__1_1(bool success)
	{
		GameObject gameObject = image.gameObject;
		gameObject.SetActive(success);
	}
}
