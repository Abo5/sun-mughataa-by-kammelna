using Cpp2ILInjected;
using Unity.Services.Authentication.Shared;
using UnityEngine;

public class BlurBackdropMarker : MonoBehaviour
{
	private static int _activeCount;

	private bool _isCounted;

	public static bool IsAnyActive
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			//IL_0091: Expected O, but got I4
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected I4, but got Unknown
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3112;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
			object obj3 = 0;
			bool flag = (nint)obj3 < 0;
			bool flag2 = obj3 == null;
			object obj4 = obj3 ^ obj3;
			object obj5 = obj3 & obj4;
			bool flag3 = (nint)obj5 < 0;
			bool flag4 = flag == flag3;
			object obj6 = !flag2;
			return (byte)((flag4 & obj6) ? 1 : 0) != 0;
		}
	}

	private void OnEnable()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_007e: Expected O, but got I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00b8: Expected O, but got I
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		object obj = 152989696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E73B5]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			if (_isCounted)
			{
				return;
			}
		}
		else
		{
			_ = 1;
			bool flag = !_isCounted;
			object obj3 = !flag;
			if (obj3 != null)
			{
				return;
			}
		}
		object obj4 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3112;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v5+B8]");
		object obj6 = 0;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		_isCounted = true;
	}

	private void OnDisable()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00b0: Expected O, but got I
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		object obj = 152989696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E73B6]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			if (!_isCounted)
			{
				return;
			}
		}
		else
		{
			_ = 1;
			if (!_isCounted)
			{
				return;
			}
		}
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3112;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v5+B8]");
		object obj5 = 0;
		object obj6 = obj5 - 1;
		obj5 = obj6;
		_isCounted = false;
	}
}
