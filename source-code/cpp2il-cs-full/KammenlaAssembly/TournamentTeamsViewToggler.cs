using System;
using System.Buffers.Text;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.UI;

public class TournamentTeamsViewToggler : MonoBehaviour
{
	private PublicChatBox chat;

	private RectTransform teamsView;

	private float chatMinHeight;

	private float teamsMinHeight;

	private Image chatPanel;

	private CanvasGroup chatExtra;

	private GameObject toggleOn;

	private GameObject toggleOff;

	private RectTransform chatView;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_0047: Expected I, but got O
		//IL_0071: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1520;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		RectTransform rectTransform = UIExtensions.rectTransform(chat);
		object obj4 = this + 88;
		obj4 = rectTransform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy.WaitForEndOfFrame(action);
	}

	private void OnEnable()
	{
		bool activeSelf = toggleOn.activeSelf;
		ChatHandler.ChatActive = activeSelf;
	}

	private void SetDefaultView()
	{
		//IL_0049: Expected O, but got I4
		//IL_005e: Expected O, but got I4
		toggleOn.SetActive(value: false);
		toggleOff.SetActive(value: true);
		(Vector2, Vector2) tuple = CalculateOffsets(isOn: true);
		chatView.offsetMin = (Vector2)0;
		teamsView.offsetMax = (Vector2)0;
		chatPanel.pixelsPerUnitMultiplier = 5f;
		chatExtra.alpha = 0f;
		chatExtra.interactable = false;
		ChatHandler.ChatActive = false;
	}

	public void ToggleView()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_00cf: Expected O, but got I4
		//IL_01d5: Expected O, but got I4
		//IL_00ef: Expected F4, but got I4
		//IL_01fd: Expected O, but got I4
		//IL_024e: Expected O, but got I4
		//IL_014d: Expected O, but got I4
		int num = ShortcutExtensions.DOKill(chatExtra);
		int num2 = ShortcutExtensions.DOKill(chatPanel);
		int num3 = ShortcutExtensions.DOKill(chatView);
		int num4 = ShortcutExtensions.DOKill(teamsView);
		bool activeSelf = toggleOn.activeSelf;
		bool active = (byte)((activeSelf ? 1u : 0u) ^ 1u) != 0;
		toggleOn.SetActive(active);
		toggleOff.SetActive(activeSelf);
		object obj = typeof(SqlSingle[]) + 3912;
		bool interactable = (byte)((activeSelf ? 1u : 0u) ^ 1u) != 0;
		chatExtra.interactable = interactable;
		bool chatActive = (byte)((activeSelf ? 1u : 0u) ^ 1u) != 0;
		ChatHandler.ChatActive = chatActive;
		bool flag = !activeSelf;
		object obj2 = !flag;
		object obj3 = ~obj2;
		float endValue = ((obj3 != null) ? 1f : 0f);
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(chatExtra, endValue, 0.3f);
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = !activeSelf;
		object obj6 = !flag3;
		object obj7 = ~obj6;
		float num5 = ((obj7 != null) ? 1f : 5f);
		Tween tween = AnimationExtensions.DOPixelsPerUnitMultiplier(chatPanel, num5, 0.3f);
		(Vector2, Vector2) tuple = CalculateOffsets(activeSelf);
		Tween tween2 = AnimationExtensions.DOOffsetMin(chatView, (Vector2)0, num5);
		float duration = default(float);
		Tween tween3 = AnimationExtensions.DOOffsetMax(teamsView, (Vector2)0, duration);
	}

	private unsafe (Vector2, Vector2) CalculateOffsets(bool isOn)
	{
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01c7: Expected O, but got I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_009f: Expected O, but got I4
		//IL_024a: Expected O, but got I
		//IL_025b: Expected O, but got I
		//IL_0260: Expected O, but got Ref
		if (isOn)
		{
			if ((object)chatView != null)
			{
				Vector2 offsetMin = chatView.offsetMin;
				if ((object)chatView != null)
				{
					Rect rect = chatView.rect;
					object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v19+E4]");
					bool flag = (nint)0 == 0;
					object obj3 = !flag;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if ((object)teamsView != null)
					{
						Vector2 offsetMax = teamsView.offsetMax;
						RectTransform rectTransform = UIExtensions.rectTransform(chatExtra);
						if ((object)rectTransform != null)
						{
							Rect rect2 = rectTransform.rect;
							goto IL_023e;
						}
					}
				}
			}
		}
		else if ((object)teamsView != null)
		{
			Vector2 offsetMax2 = teamsView.offsetMax;
			if ((object)teamsView != null)
			{
				Rect rect3 = teamsView.rect;
				object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v10+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if ((object)chatView != null)
				{
					Vector2 offsetMin2 = chatView.offsetMin;
					goto IL_023e;
				}
			}
		}
		return ((Vector2, Vector2))new NullReferenceException();
		IL_023e:
		object item = (nint)0 + (nint)4000;
		IntPtr intPtr = default(IntPtr);
		(Vector2, Vector2) tuple = ((Vector2)item, (Vector2)(nint)intPtr);
		return ((Vector2, Vector2))(&tuple);
	}
}
