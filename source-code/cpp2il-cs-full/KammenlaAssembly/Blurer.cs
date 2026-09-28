using System.ComponentModel;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.UI;

public class Blurer : MonoBehaviour
{
	private void Start()
	{
		Blur();
	}

	public void Blur()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_019f: Expected O, but got I
		//IL_01d2: Expected O, but got I4
		//IL_0034: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0084: Expected O, but got I
		//IL_00b1: Expected O, but got I
		//IL_00dc: Expected O, but got I4
		//IL_00ee: Expected I4, but got I8
		//IL_0175: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)352;
		Camera main = Camera.main;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9A80");
		object obj5 = (nint)0 + (nint)3600;
		object obj6 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Object obj7 = default(Object);
		Object.Destroy(obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GameObject gameObject = default(GameObject);
		gameObject..ctor();
		object obj8 = (nint)0 + (nint)608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32E24");
		UnityEngine.Component component = default(UnityEngine.Component);
		GameObject gameObject2 = component.gameObject;
		object obj9 = (nint)0 + (nint)632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32E24");
		CanvasScaler canvasScaler = default(CanvasScaler);
		canvasScaler.m_UiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
		canvasScaler.referenceResolution = (Vector2)0;
		canvasScaler.m_ScreenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
		Camera worldCamera = default(Camera);
		((Canvas)component).worldCamera = worldCamera;
		((Canvas)component).renderMode = RenderMode.ScreenSpaceCamera;
		GameObject gameObject3 = base.gameObject;
		Transform transform = gameObject3.transform;
		Transform parent = component.transform;
		transform.SetParent(parent);
		Camera main2 = Camera.main;
		GameObject gameObject4 = main2.gameObject;
		object obj10 = (nint)0 + (nint)1104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		Behaviour behaviour = default(Behaviour);
		behaviour.enabled = true;
	}
}
