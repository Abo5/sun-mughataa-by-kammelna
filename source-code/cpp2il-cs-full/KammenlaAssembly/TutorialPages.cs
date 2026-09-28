using UI.Pickers;
using UnityEngine;
using UnityEngine.UI;

public class TutorialPages : MonoBehaviour
{
	private Button _backButton;

	private PageScrollButtonsHandler _pageScrollButtonsHandler;

	private UIPicker _uiPicker;

	private GameObject _pagesParent;

	public Button BackButton => _backButton;

	public PageScrollButtonsHandler PageScrollButtonsHandler => _pageScrollButtonsHandler;

	public UIPicker UiPicker => _uiPicker;

	public GameObject PagesParent => _pagesParent;
}
