using System;

namespace Testing.Achievements;

public interface ITestPanel
{
	void Show(Action onHide);

	void Hide();
}
