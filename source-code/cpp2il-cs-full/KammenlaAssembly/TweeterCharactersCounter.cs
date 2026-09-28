using System;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TweeterCharactersCounter : MonoBehaviour
{
	private int maxCharacters;

	private int warningCharacters;

	private Color normalColor;

	private Color warningColor;

	private Color warningTextColor;

	private Color errorColor;

	private CanvasGroup baseImage;

	private Image progress;

	private TextMeshProUGUI count;

	private int _reservedCount;

	private void Start()
	{
		GameObject gameObject = count.gameObject;
		gameObject.SetActive(value: false);
	}

	public void UpdateUserLimit(int reservedCount)
	{
		_reservedCount = reservedCount;
		UpdateCount(reservedCount);
	}

	public void UpdateCount(int charactersCount)
	{
		//IL_0027: Expected O, but got I4
		//IL_0038: Expected O, but got I4
		//IL_00df: Expected O, but got I4
		//IL_00ff: Expected O, but got I
		//IL_0188: Expected O, but got I4
		//IL_01a8: Expected O, but got I
		//IL_00b0: Expected O, but got I4
		//IL_022e: Expected O, but got I4
		//IL_0257: Expected O, but got I4
		//IL_0260: Expected F4, but got I4
		//IL_0159: Expected O, but got I4
		//IL_02d0: Expected O, but got I
		TextMeshProUGUI textMeshProUGUI = count;
		int num = default(int);
		string text = num.ToString();
		textMeshProUGUI.text = text;
		object obj = charactersCount - _reservedCount;
		object obj2 = maxCharacters - _reservedCount;
		float fillAmount = (float)obj / (float)obj2;
		progress.fillAmount = fillAmount;
		if (num >= 1)
		{
			if (num > warningCharacters)
			{
				bool flag = (object)count == null;
				object obj3 = !flag;
				if (obj3 == null)
				{
					goto IL_02f1;
				}
			}
		}
		else
		{
			bool flag2 = (object)count == null;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				goto IL_02f1;
			}
		}
		count.color = (Color)0;
		if (num >= 1)
		{
			if (num > warningCharacters)
			{
				bool flag3 = (object)progress == null;
				object obj5 = !flag3;
				if (obj5 == null)
				{
					goto IL_02f1;
				}
			}
		}
		else
		{
			bool flag4 = (object)progress == null;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				goto IL_02f1;
			}
		}
		progress.color = (Color)0;
		float endValue;
		if (num > warningCharacters)
		{
			GameObject gameObject = count.gameObject;
			gameObject.SetActive(value: false);
			Transform target = baseImage.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target, 0.65f, 0.2f);
		}
		else
		{
			object obj7 = num + 9;
			bool flag5 = (nint)obj7 < 0;
			bool flag6 = !flag5;
			object obj8 = !flag6;
			endValue = 0f;
			if (obj8 != null)
			{
				goto IL_0314;
			}
			GameObject gameObject2 = count.gameObject;
			gameObject2.SetActive(value: true);
			Transform target2 = baseImage.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(target2, 1f, 0.2f);
			object obj9 = (nint)0 + (nint)2904;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		}
		endValue = 1f;
		goto IL_0314;
		IL_0314:
		TweenerCore<float, float, FloatOptions> tweenerCore3 = DOTweenModuleUI.DOFade(baseImage, endValue, 0.2f);
		return;
		IL_02f1:
		throw new NullReferenceException();
	}

	private Color GetColor(int newCount, Color warning)
	{
		if (newCount < 1 || newCount > warningCharacters)
		{
		}
		return (Color)this;
	}

	public TweeterCharactersCounter()
	{
		//IL_0024: Expected O, but got I
		//IL_0036: Expected O, but got I
		//IL_0048: Expected O, but got I
		//IL_005a: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252BB0]");
		maxCharacters = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252BC0]");
		normalColor = (Color)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252BD0]");
		warningColor = (Color)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70DC520]");
		warningTextColor = (Color)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252BE0]");
		errorColor = (Color)0;
		base..ctor();
	}
}
