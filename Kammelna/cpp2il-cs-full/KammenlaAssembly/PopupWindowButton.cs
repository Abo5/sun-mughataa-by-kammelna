using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopupWindowButton : MonoBehaviour
{
	private Button <Button>k__BackingField;

	private TextMeshProUGUI _label;

	private TextMeshProUGUI _price;

	private Image _icon;

	private PopupWindow _popupWindow;

	public Button Button
	{
		get
		{
			return <Button>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public TextMeshProUGUI Label => _label;

	public TextMeshProUGUI Price => _price;

	public Image Icon => _icon;
}
