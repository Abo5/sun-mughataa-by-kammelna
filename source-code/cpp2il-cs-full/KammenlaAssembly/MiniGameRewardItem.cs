using Cpp2ILInjected;
using TMPro;
using UnityEngine;

public class MiniGameRewardItem : MonoBehaviour
{
	protected TextMeshProUGUI nameText;

	protected TextMeshProUGUI valueText;

	protected MiniGameRewardDescription RewardDescription;

	public virtual void Setup(MiniGameRewardDescription rewardDescription)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0041: Expected O, but got I
		object obj = this + 48;
		obj = rewardDescription;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = obj;
		TextMeshProUGUI textMesh = nameText;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ X8_v1+10]");
		TextMeshProExtensions.Localize(textMesh, (string)0);
		int num = default(int);
		string text = num.ToString();
		valueText.text = text;
	}
}
