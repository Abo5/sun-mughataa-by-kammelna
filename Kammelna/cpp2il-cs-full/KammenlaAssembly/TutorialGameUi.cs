using Cpp2ILInjected;
using UnityEngine;

public class TutorialGameUi : ScriptableObject
{
	private string _tutorialButtonText;

	private TutorialPages _pagesPrefab;

	private TutorialPages _tabletPagesPrefab;

	private RoutingCommandPage[] _routingCommandPages;

	private int _numberOfPages;

	public string TutorialButtonText => _tutorialButtonText;

	public TutorialPages PagesPrefab
	{
		get
		{
			//IL_0023: Expected O, but got I4
			//IL_0051: Expected O, but got I4
			//IL_0063: Expected O, but got I
			//IL_0043: Expected O, but got I4
			bool isTablet = ScreenUtility.IsTablet;
			bool flag = !isTablet;
			object obj = !flag;
			object obj2 = ~obj;
			if (obj2 == null)
			{
				object obj3 = 40;
			}
			else
			{
				object obj3 = 32;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TutorialGameUi)+v29 @ X8_v2]");
			return (TutorialPages)0;
		}
	}

	public RoutingCommandPage[] RoutingCommandPages => _routingCommandPages;

	public int NumberOfPages => _numberOfPages;
}
