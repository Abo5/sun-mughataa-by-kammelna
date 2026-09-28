using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;

public class BindCanvasScale : MonoBehaviour
{
	private RectTransform _canvasScaler;

	private void Start()
	{
		UpdateScale();
	}

	private void UpdateScale()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0119: Expected O, but got I4
		//IL_016d: Expected O, but got I4
		//IL_00e8: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E73EB]");
		object obj3 = (nint)0 & (nint)1;
		Object canvasScaler;
		Object canvasScaler2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			canvasScaler = _canvasScaler;
			canvasScaler2 = _canvasScaler;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			canvasScaler = _canvasScaler;
			canvasScaler2 = _canvasScaler;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = canvasScaler2;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			return;
		}
		goto IL_00b7;
		IL_00b7:
		Transform transform = base.transform;
		Vector3 localScale = _canvasScaler.localScale;
		transform.localScale = (Vector3)0;
		return;
		IL_0091:
		if ((bool)canvasScaler)
		{
			goto IL_00b7;
		}
	}
}
