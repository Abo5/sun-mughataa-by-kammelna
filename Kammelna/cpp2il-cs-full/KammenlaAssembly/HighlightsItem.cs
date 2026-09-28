using System;
using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class HighlightsItem : MonoBehaviour
{
	public Image highlightsDeep;

	public AvatarInitializer player;

	public Image highlightSticker;

	public RotatingLoadingIndicator imageLoadingIndicator;

	private KPlayer _player;

	public void SetUp(string highlightName, KPlayer player)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0048: Expected O, but got I
		//IL_0075: Expected I, but got O
		Reset();
		object obj = this + 64;
		obj = player;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj3 = (nint)0 + (nint)1408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj3);
		UIExtensions.LoadHighlightImage(highlightSticker, highlightName, setNative: false, action);
		this.player.Initialize((KPlayer)obj);
	}

	private void Reset()
	{
		imageLoadingIndicator.StartLoading();
		GameObject gameObject = highlightsDeep.gameObject;
		gameObject.SetActive(value: false);
		highlightSticker.enabled = false;
		player.Clear();
		GameObject gameObject2 = base.gameObject;
		gameObject2.SetActive(value: true);
	}

	private void SetUpSticker(string highlightName)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj2 = (nint)0 + (nint)1408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj2);
		UIExtensions.LoadHighlightImage(highlightSticker, highlightName, setNative: false, action);
	}

	private void SetPlayer()
	{
		player.Initialize(_player);
	}

	private void <SetUpSticker>b__7_0(bool s)
	{
		highlightSticker.enabled = s;
		if (s)
		{
			imageLoadingIndicator.FinishLoading();
		}
	}
}
