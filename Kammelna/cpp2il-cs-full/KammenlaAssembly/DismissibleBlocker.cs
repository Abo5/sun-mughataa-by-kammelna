using System;
using System.Buffers.Text;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Jackaroo;
using UnityEngine;
using UnityEngine.EventSystems;

public class DismissibleBlocker : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	private GameObject blocker;

	private GameEventsChannel gameEventsChannel;

	private Camera _mainCamera;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_0033: Expected I, but got O
		//IL_0044: Expected O, but got I
		//IL_0070: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3520;
		Camera main = Camera.main;
		object obj3 = this + 48;
		obj3 = main;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = (nint)0 + (nint)3512;
		gameEventsChannel.ShowDismissibleBlocker += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj4);
		gameEventsChannel.HideDismissibleBlocker += action2;
		blocker.SetActive(value: false);
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_008a: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_005d: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)3512;
		gameEventsChannel.ShowDismissibleBlocker -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj3);
		gameEventsChannel.HideDismissibleBlocker -= action2;
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		OnBlockerClicked((Vector2)eventData);
	}

	private void Show()
	{
		blocker.SetActive(value: true);
	}

	private void Hide()
	{
		if (blocker.activeInHierarchy)
		{
			gameEventsChannel.TriggerDismissibleClicked(null);
		}
		blocker.SetActive(value: false);
	}

	private unsafe void OnBlockerClicked(Vector2 pointerPosition)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0258: Expected O, but got I4
		//IL_0286: Expected O, but got I4
		//IL_0050: Expected O, but got Ref
		//IL_018a: Expected O, but got I4
		//IL_007f: Expected O, but got Ref
		//IL_01b9: Expected O, but got Ref
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00ee: Expected O, but got Ref
		//IL_020b: Expected O, but got I
		//IL_011e: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 400;
		_ = 0;
		_ = 0;
		_ = 0;
		Ray ray = CameraInputExtensions.ScreenPointToRayThroughRenderTexture(_mainCamera, (Vector3)0);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj6 = default(object);
		GameCard gameCard;
		object obj9 = default(object);
		if (Physics.Raycast((Ray)(&obj6), out System.Runtime.CompilerServices.Unsafe.As<object, RaycastHit>(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96)), 250000f))
		{
			RaycastHit raycastHit = (RaycastHit)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
			Collider collider = ((RaycastHit*)raycastHit)->collider;
			GameObject gameObject = collider.gameObject;
			object tag = "Cannot populate JSON object onto type '{0}'." + 1648;
			if (gameObject.CompareTag((string)tag))
			{
				RaycastHit raycastHit2 = (RaycastHit)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
				Collider collider2 = ((RaycastHit*)raycastHit2)->collider;
				GameObject gameObject2 = collider2.gameObject;
				object obj7 = (nint)0 + (nint)1272;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
				GameCard gameCard2 = default(GameCard);
				gameCard = gameCard2;
			}
			else
			{
				gameCard = null;
			}
			object obj8 = obj9;
		}
		else
		{
			object obj8 = obj9;
			gameCard = null;
		}
		gameEventsChannel.TriggerDismissibleClicked(gameCard);
		object obj10 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RaycastHit hitInfo;
		bool flag3 = Physics.Raycast((Ray)(&obj9), out hitInfo, 2000f);
		bool flag4 = !flag3;
		JackarooMarbleMono marble = null;
		if (!flag4)
		{
			Transform transform = hitInfo.transform;
			Transform parent = transform.parent;
			object obj12 = (nint)0 + (nint)3896;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			JackarooMarbleMono jackarooMarbleMono = default(JackarooMarbleMono);
			marble = jackarooMarbleMono;
		}
		gameEventsChannel.TriggerMarbleDismissibleClicked(gameCard, marble);
	}
}
