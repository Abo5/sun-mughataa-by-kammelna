using System;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class InformationPopup : MonoBehaviour
{
	public Image InfoContainer;

	public Image InfoButtonExtender;

	public TextMeshProUGUI InfoText;

	public bool localizeFirst;

	private bool isInitialized;

	private Vector2 originalSizeDelta;

	private bool isOpened;

	private void Initialize()
	{
		if (localizeFirst)
		{
			TextMeshProExtensions.Localize(InfoText);
		}
		RectTransform rectTransform = InfoContainer.rectTransform;
		Vector2 sizeDelta = rectTransform.sizeDelta;
		Vector2 vector = default(Vector2);
		originalSizeDelta = vector;
		isInitialized = true;
	}

	public void Toggle()
	{
		if (isOpened)
		{
			Close();
		}
		else
		{
			Open();
		}
	}

	public void Open()
	{
		//IL_00c2: Expected O, but got I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00f0: Expected O, but got I
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_011c: Expected I, but got O
		isOpened = true;
		bool flag = !isInitialized;
		object obj = !flag;
		if (obj == null)
		{
			if (localizeFirst)
			{
				TextMeshProExtensions.Localize(InfoText);
			}
			RectTransform rectTransform = InfoContainer.rectTransform;
			Vector2 sizeDelta = rectTransform.sizeDelta;
			Vector2 vector = default(Vector2);
			originalSizeDelta = vector;
			isInitialized = true;
		}
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)2504;
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj3);
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			CoroutineDummy.WaitForEndOfFrame(action);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		CoroutineDummy.WaitForEndOfFrame(action);
	}

	public void Close()
	{
		//IL_00a0: Expected F4, but got O
		//IL_00a0: Expected O, but got I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00c9: Expected O, but got I
		//IL_00d5: Expected O, but got I
		//IL_0136: Expected I, but got O
		isOpened = false;
		int num = ShortcutExtensions.DOKill(InfoText);
		Transform target = InfoText.transform;
		int num2 = ShortcutExtensions.DOKill(target);
		RectTransform rectTransform = InfoContainer.rectTransform;
		int num3 = ShortcutExtensions.DOKill(rectTransform);
		GameObject gameObject = InfoButtonExtender.gameObject;
		gameObject.SetActive(value: false);
		RectTransform rectTransform2 = InfoContainer.rectTransform;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOSizeDelta(rectTransform2, (Vector2)0, (float)originalSizeDelta);
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj2 = (nint)0 + (nint)2496;
		object obj3 = (nint)0 + (nint)2456;
		Transform target2 = InfoText.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(target2, 0f, 0.4f);
		TweenerCore<Color, Color, ColorOptions> tweenerCore3 = ShortcutExtensionsTMPText.DOFade(InfoText, 0f, 0.4f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	private void <Open>b__9_0()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_00a0: Expected O, but got I4
		//IL_0144: Expected O, but got I4
		//IL_016f: Expected O, but got I4
		if (isOpened)
		{
			GameObject gameObject = InfoText.gameObject;
			gameObject.SetActive(value: true);
			GameObject gameObject2 = InfoButtonExtender.gameObject;
			gameObject2.SetActive(value: true);
			RectTransform rectTransform = InfoText.rectTransform;
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1648;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate(rectTransform);
			int num = ShortcutExtensions.DOKill(InfoText);
			Transform target = InfoText.transform;
			int num2 = ShortcutExtensions.DOKill(target);
			RectTransform rectTransform2 = InfoContainer.rectTransform;
			int num3 = ShortcutExtensions.DOKill(rectTransform2);
			RectTransform rectTransform3 = InfoContainer.rectTransform;
			float preferredHeight = InfoText.preferredHeight;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOSizeDelta(rectTransform3, (Vector2)0, 880f);
			Transform transform = InfoText.transform;
			transform.localScale = (Vector3)0;
			Transform target2 = InfoText.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(target2, 1f, 0.4f);
			UIExtensions.SetAlpha(InfoText, 0f);
			TweenerCore<Color, Color, ColorOptions> tweenerCore3 = ShortcutExtensionsTMPText.DOFade(InfoText, 1f, 0.4f);
		}
	}

	private void <Close>b__10_0()
	{
		GameObject gameObject = InfoText.gameObject;
		gameObject.SetActive(value: false);
	}
}
