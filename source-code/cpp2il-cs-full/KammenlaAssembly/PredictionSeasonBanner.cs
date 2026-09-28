using System;
using System.Diagnostics;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PredictionSeasonBanner : MonoBehaviour
{
	private Image logoImage;

	private TextMeshProUGUI descText;

	private float closedHeight;

	private float openHeight;

	private bool isOpen;

	public void Initialize(PredictionSeasonModel model)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0038: Expected O, but got I
		//IL_0069: Expected I, but got O
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj2 = (nint)0 + (nint)1744;
		TextMeshProExtensions.FixArabic(descText, model.<Description>k__BackingField);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj2);
		UIExtensions.LoadPredictionSeasonImage(logoImage, model, action);
	}

	public void ToggleReadMore()
	{
		//IL_0064: Expected O, but got I4
		RectTransform target = UIExtensions.rectTransform(this);
		RectTransform rectTransform = UIExtensions.rectTransform(this);
		if (isOpen)
		{
		}
		Vector2 sizeDelta = rectTransform.sizeDelta;
		float duration = default(float);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOSizeDelta(target, (Vector2)0, duration);
		bool flag = (byte)((isOpen ? 1u : 0u) ^ 1u) != 0;
		isOpen = flag;
	}

	private void <Initialize>b__5_0(bool onSuccess)
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(onSuccess);
	}
}
