using System;

namespace Util;

public interface INotificationPermissionChecker
{
	bool IsGranted();

	void RequestPermission(Action<bool> onResult);
}
