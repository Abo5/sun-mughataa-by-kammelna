using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using TMPro;
using UnityEngine;

public class CurrentStageInfoPanel : MonoBehaviour
{
	private TextMeshProUGUI participantCountField;

	private TextMeshProUGUI advancingCountField;

	public void Populate(int participants, int advancing)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0081: Expected O, but got I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002b: Expected I, but got O
		object format = "Picking audio files is not supported on iOS" + 520;
		TextMeshProUGUI textMeshProUGUI = participantCountField;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string text = string.Format((string)format, arg);
		object format2 = "Picking audio files is not supported on iOS" + 512;
		nint num = (nint)textMeshProUGUI;
		textMeshProUGUI.text = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg2 = default(object);
		string text2 = string.Format((string)format2, arg2);
		advancingCountField.text = text2;
	}

	public void Show()
	{
		Transform target = base.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScaleY(target, 1f, 0.3f);
	}

	public void Hide()
	{
		Transform target = base.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScaleY(target, 0f, 0.3f);
	}
}
