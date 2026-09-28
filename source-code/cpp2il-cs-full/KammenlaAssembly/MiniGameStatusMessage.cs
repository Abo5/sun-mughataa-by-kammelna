using System;
using System.Formats.Asn1;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using TMPro;
using Unity.Properties;
using UnityEngine;

public class MiniGameStatusMessage : MonoBehaviour
{
	private GameObject messageContainer;

	private TextMeshProUGUI messageTitle;

	private TextMeshProUGUI messageText;

	private CanvasGroup _fadeGroup;

	private void Awake()
	{
		//IL_0011: Expected O, but got I
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0063: Expected O, but got I4
		//IL_00f1: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		object obj = (nint)0 + (nint)968;
		messageContainer.SetActive(value: false);
		object obj2 = this + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
		object obj4 = default(object);
		object obj3 = obj4 & 1;
		bool flag = obj3 == null;
		object obj5 = !flag;
		if (obj5 == null)
		{
			GameObject gameObject = base.gameObject;
			object obj6 = (nint)0 + (nint)616;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32E24");
			CanvasGroup fadeGroup = default(CanvasGroup);
			_fadeGroup = fadeGroup;
			object obj7 = this + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		_fadeGroup.alpha = 0f;
		Transform transform = messageContainer.transform;
		transform.localScale = (Vector3)0;
	}

	public void ShowMessage(string message, string title = null)
	{
		SetTitle(title);
		TextMeshProExtensions.Localize(messageText, message);
		Show();
	}

	public unsafe void ShowMessage(string message, int count, string title = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_016d: Expected O, but got I4
		//IL_0119: Expected O, but got Ref
		//IL_004d: Expected O, but got Ref
		//IL_0063: Expected I, but got O
		//IL_0073: Expected O, but got I
		//IL_009c: Expected O, but got I
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		SetTitle(title);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object[] array = default(object[]);
		object obj4;
		int num = default(int);
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj5;
		if (array != null)
		{
			object obj3 = default(object);
			bool flag = obj3 == null;
			obj4 = (object)(&num);
			if (!flag)
			{
				nint num2 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v9 (Il2CppClass<System.Object[]>)+40]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag2 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v9 (Il2CppClass<System.Object[]>)+40]");
				obj5 = 0;
				if (flag2)
				{
					goto IL_0134;
				}
			}
			if (array.Length != 0)
			{
				object obj6 = array + 32;
				obj6 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				TextMeshProExtensions.Localize(messageText, message, array);
				Show();
				return;
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			obj4 = (object)(&num);
		}
		ex = new IndexOutOfRangeException();
		obj5 = obj4;
		goto IL_0134;
		IL_0134:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	private void SetTitle(string title)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00ff: Expected O, but got I4
		//IL_0149: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6421]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = StringsExtensions.IsNullOrEmpty(title);
		Component component = messageTitle;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		Component component2 = messageTitle;
		if (obj5 != null)
		{
			goto IL_00ae;
		}
		goto IL_0161;
		IL_00ae:
		GameObject gameObject = component.gameObject;
		gameObject.SetActive(value: false);
		return;
		IL_0161:
		GameObject gameObject2 = component2.gameObject;
		gameObject2.SetActive(value: true);
		TextMeshProExtensions.Localize(messageTitle, title);
		return;
		IL_0074:
		bool flag4 = StringsExtensions.IsNullOrEmpty(title);
		component = messageTitle;
		bool flag5 = !flag4;
		component2 = messageTitle;
		if (!flag5)
		{
			goto IL_00ae;
		}
		goto IL_0161;
	}

	private void Show()
	{
		if (!messageContainer.activeSelf)
		{
			_fadeGroup.interactable = true;
			messageContainer.SetActive(value: true);
			int num = ShortcutExtensions.DOKill(_fadeGroup);
			Transform target = messageContainer.transform;
			int num2 = ShortcutExtensions.DOKill(target);
			TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(_fadeGroup, 1f, 0.1f);
			Transform target2 = messageContainer.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(target2, 1f, 0.2f);
		}
	}

	public void Hide()
	{
		//IL_00f9: Expected O, but got I
		if (messageContainer.activeSelf)
		{
			_fadeGroup.interactable = false;
			messageContainer.SetActive(value: true);
			int num = ShortcutExtensions.DOKill(_fadeGroup);
			Transform target = messageContainer.transform;
			int num2 = ShortcutExtensions.DOKill(target);
			TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(_fadeGroup, 0f, 0.1f);
			Transform target2 = messageContainer.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(target2, 0.5f, 0.2f);
			TweenCallback tweenCallback = TweenHelpers.Disable(messageContainer);
			object obj = (nint)0 + (nint)2504;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		}
	}
}
