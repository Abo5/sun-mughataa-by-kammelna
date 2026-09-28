using System.Buffers.Text;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;

public class ClanLogoSelectorDragReorder : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	private ClanLogoImageSelector selector;

	private RectTransform dragVisual;

	private float snapDuration = 0.2f;

	private Vector3 _dragVisualOriginalLocalPosition;

	private Vector3 _pointerOffset;

	public void OnPointerDown(PointerEventData eventData)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f8: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8922]");
		object obj3 = (nint)0 & (nint)1;
		Object obj5;
		Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			obj5 = selector;
			obj6 = selector;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = selector;
			obj6 = selector;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (obj6 != null)
		{
			goto IL_0150;
		}
		return;
		IL_0150:
		ClanLogoImageSelector clanLogoImageSelector = selector;
		if (clanLogoImageSelector.OnPressed != null)
		{
			clanLogoImageSelector.OnPressed.Invoke();
		}
		return;
		IL_0091:
		bool flag3 = obj5 != null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_0150;
	}

	public unsafe void OnBeginDrag(PointerEventData eventData)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01aa: Expected O, but got I4
		//IL_01b3: Expected O, but got I4
		//IL_01bc: Expected O, but got I4
		//IL_00c7: Expected O, but got I4
		//IL_00d0: Expected O, but got I4
		//IL_00de: Expected O, but got I4
		//IL_0078: Expected O, but got I4
		//IL_008b: Expected O, but got I4
		//IL_0205: Expected O, but got I4
		//IL_021b: Expected O, but got I4
		//IL_02cc: Expected O, but got I4
		//IL_026e: Expected O, but got I
		//IL_0161: Expected O, but got I4
		//IL_0458: Expected O, but got I4
		//IL_0412: Expected O, but got I4
		//IL_041b: Expected O, but got I4
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected O, but got Unknown
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected O, but got Unknown
		//IL_0502: Expected O, but got I4
		//IL_0531: Expected O, but got Ref
		//IL_04a1: Expected O, but got I4
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Expected O, but got Unknown
		//IL_05ff: Expected O, but got I
		//IL_0617: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8923]");
		object obj3 = (nint)0 & (nint)1;
		object obj5;
		Object obj6;
		object obj7;
		Object obj8;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v47+E4]");
			bool flag = (nint)0 == 0;
			obj5 = 0;
			obj6 = selector;
			obj7 = 0;
			obj8 = selector;
			if (!flag)
			{
				goto IL_00a3;
			}
		}
		else
		{
			_ = 1;
			obj6 = selector;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v47+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			obj5 = 0;
			obj7 = 0;
			obj8 = selector;
			if (obj9 != null)
			{
				goto IL_00a3;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj8 != null;
		bool flag4 = !flag3;
		object obj10 = 0;
		Object obj11 = null;
		obj5 = obj7;
		object obj12 = 0;
		if (flag4)
		{
			goto IL_00f4;
		}
		goto IL_0229;
		IL_04b7:
		Camera pressEventCamera = eventData.pressEventCamera;
		object obj13 = typeof(System.Buffers.Text.ParserHelpers) + 3608;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v19+E4]");
		bool flag5 = (nint)0 == 0;
		object obj15 = !flag5;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Object obj16;
		object obj17 = default(object);
		if (!RectTransformUtility.ScreenPointToWorldPointInRectangle((RectTransform)obj16, (Vector2)pressEventCamera, (Camera)(&obj17), out *(Vector3*)null))
		{
			goto IL_0581;
		}
		Vector3 position = dragVisual.position;
		Vector3 pointerOffset = (Vector3)((object)eventData.<position>k__BackingField - obj17);
		object obj19 = default(object);
		object obj18 = obj19 - obj5;
		goto IL_05d7;
		IL_03ee:
		bool flag6 = obj16 != null;
		bool flag7 = !flag6;
		object obj20 = !flag7;
		object obj21 = 0;
		if (obj20 != null)
		{
			goto IL_04b7;
		}
		goto IL_0581;
		IL_0337:
		int num = ShortcutExtensions.DOKill(dragVisual);
		Vector3 localPosition = dragVisual.localPosition;
		Vector3 dragVisualOriginalLocalPosition = default(Vector3);
		_dragVisualOriginalLocalPosition = dragVisualOriginalLocalPosition;
		Transform parent = dragVisual.parent;
		Object obj24;
		if ((object)parent != null)
		{
			object obj22 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
			Transform transform = ((parent != obj22) ? null : parent);
			object obj23 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X0_v26+E4]");
			bool flag8 = (nint)0 == 0;
			obj16 = transform;
			obj24 = transform;
			if (!flag8)
			{
				goto IL_03ee;
			}
		}
		else
		{
			object obj23 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X0_v26+E4]");
			bool flag9 = (nint)0 == 0;
			object obj25 = !flag9;
			obj16 = null;
			obj24 = null;
			if (obj25 != null)
			{
				goto IL_03ee;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag10 = obj24 != null;
		bool flag11 = !flag10;
		obj21 = 0;
		obj16 = obj24;
		if (!flag11)
		{
			goto IL_04b7;
		}
		goto IL_0581;
		IL_00a3:
		bool flag12 = obj6 != null;
		bool flag13 = !flag12;
		object obj26 = !flag13;
		obj10 = 0;
		obj11 = null;
		obj12 = 0;
		obj7 = obj5;
		if (obj26 == null)
		{
			goto IL_00f4;
		}
		goto IL_0229;
		IL_0229:
		Component component = selector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v42 (UnityEngine.Component)+A0]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v42 (UnityEngine.Component)+A0]");
			((UnityEvent)0).Invoke();
			component = selector;
		}
		Transform transform2 = component.transform;
		transform2.SetAsLastSibling();
		Object obj27 = dragVisual;
		object obj28 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v22+E4]");
		bool flag14 = (nint)0 == 0;
		object obj29 = !flag14;
		obj5 = obj7;
		obj10 = obj12;
		obj11 = null;
		Object obj30 = dragVisual;
		if (obj29 != null)
		{
			goto IL_013d;
		}
		goto IL_02f9;
		IL_0581:
		object obj31 = typeof(UsageHint) + 816;
		object obj32 = obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v8+B8]");
		object obj33 = 0;
		pointerOffset = (Vector3)obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v9+8]");
		obj18 = 0;
		goto IL_05d7;
		IL_05d7:
		_pointerOffset = pointerOffset;
		return;
		IL_00f4:
		obj27 = dragVisual;
		obj28 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v22+E4]");
		bool flag15 = (nint)0 == 0;
		obj30 = dragVisual;
		obj7 = obj5;
		if (!flag15)
		{
			goto IL_013d;
		}
		goto IL_02f9;
		IL_02f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag16 = obj30 != null;
		bool flag17 = !flag16;
		obj5 = obj7;
		if (flag17)
		{
			return;
		}
		goto IL_0337;
		IL_013d:
		bool flag18 = obj27 != null;
		bool flag19 = !flag18;
		object obj34 = !flag19;
		if (obj34 == null)
		{
			return;
		}
		goto IL_0337;
	}

	public unsafe void OnDrag(PointerEventData eventData)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0116: Expected O, but got I4
		//IL_011f: Expected O, but got I4
		//IL_0128: Expected O, but got I4
		//IL_00c9: Expected O, but got I4
		//IL_0078: Expected O, but got I4
		//IL_008b: Expected O, but got I4
		//IL_026f: Expected O, but got I4
		//IL_0177: Expected O, but got I4
		//IL_0180: Expected O, but got I4
		//IL_0232: Expected O, but got I4
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected O, but got Unknown
		//IL_0328: Expected O, but got I4
		//IL_0357: Expected O, but got Ref
		//IL_0376: Expected O, but got I
		//IL_02be: Expected O, but got I4
		//IL_02c7: Expected O, but got I4
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected O, but got Unknown
		//IL_03cd: Expected O, but got I4
		//IL_03de: Expected O, but got I4
		//IL_0436: Expected O, but got I4
		//IL_04ae: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89D7]");
		object obj3 = (nint)0 & (nint)1;
		object obj5;
		Object obj6;
		object obj7;
		Object obj8;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v40+E4]");
			bool flag = (nint)0 == 0;
			obj5 = 0;
			obj6 = dragVisual;
			obj7 = 0;
			obj8 = dragVisual;
			if (!flag)
			{
				goto IL_00a3;
			}
		}
		else
		{
			_ = 1;
			obj6 = dragVisual;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v40+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			obj5 = 0;
			obj7 = 0;
			obj8 = dragVisual;
			if (obj9 != null)
			{
				goto IL_00a3;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj8 == null;
		bool flag4 = !flag3;
		object obj10 = !flag4;
		object obj11 = 0;
		obj5 = obj7;
		if (obj10 == null)
		{
			goto IL_0196;
		}
		return;
		IL_020c:
		Object obj12;
		bool flag5 = obj12 == null;
		bool flag6 = !flag5;
		object obj13 = 0;
		if (!flag6)
		{
			return;
		}
		goto IL_02dd;
		IL_02dd:
		Camera pressEventCamera = eventData.pressEventCamera;
		object obj14 = typeof(System.Buffers.Text.ParserHelpers) + 3608;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v10+E4]");
		bool flag7 = (nint)0 == 0;
		object obj16 = !flag7;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj17 = default(object);
		bool flag8 = RectTransformUtility.ScreenPointToWorldPointInRectangle((RectTransform)obj12, (Vector2)pressEventCamera, (Camera)(&obj17), out *(Vector3*)null);
		bool flag9 = !flag8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [eventData @ X1 (UnityEngine.EventSystems.PointerEventData)+148]");
		object obj18 = 0;
		Vector2 <position>k__BackingField = eventData.<position>k__BackingField;
		Vector3 vector = (Vector3)pressEventCamera;
		if (!flag9)
		{
			object obj19 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanLogoSelectorDragReorder)+48]");
			object obj20 = obj19 + 0;
			<position>k__BackingField = (Vector2)(obj17 + (object)_pointerOffset);
			dragVisual.position = (Vector3)0;
			object obj21 = default(object);
			obj18 = obj21;
			vector = (Vector3)0;
		}
		object obj22 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v9+E4]");
		if ((nint)0 != 0)
		{
			bool flag10 = selector != null;
			bool flag11 = !flag10;
			object obj23 = !flag11;
			if (obj23 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!(selector != null))
			{
				return;
			}
		}
		ClanLogoImageSelector clanLogoImageSelector = selector;
		Camera pressEventCamera2 = eventData.pressEventCamera;
		if (clanLogoImageSelector.OnDragMoved != null)
		{
			object arg = (nint)0 + (nint)1368;
			((UnityEvent<Vector2, object>)(object)clanLogoImageSelector.OnDragMoved).Invoke((Vector2)pressEventCamera2, arg);
		}
		return;
		IL_0196:
		Transform parent = dragVisual.parent;
		Object obj26;
		if ((object)parent != null)
		{
			object obj24 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
			Transform transform = ((parent != obj24) ? null : parent);
			object obj25 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v31+E4]");
			bool flag12 = (nint)0 == 0;
			obj12 = transform;
			obj26 = transform;
			if (!flag12)
			{
				goto IL_020c;
			}
		}
		else
		{
			object obj25 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v31+E4]");
			bool flag13 = (nint)0 == 0;
			object obj27 = !flag13;
			obj12 = null;
			obj26 = null;
			if (obj27 != null)
			{
				goto IL_020c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag14 = obj26 == null;
		bool flag15 = !flag14;
		object obj28 = !flag15;
		obj13 = 0;
		obj12 = obj26;
		if (obj28 == null)
		{
			goto IL_02dd;
		}
		return;
		IL_00a3:
		bool flag16 = obj6 == null;
		bool flag17 = !flag16;
		obj11 = 0;
		if (!flag17)
		{
			return;
		}
		goto IL_0196;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0115: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00d6: Expected O, but got I4
		//IL_0168: Expected O, but got I4
		//IL_02dc: Expected O, but got I4
		//IL_01a3: Expected O, but got I
		//IL_02a8: Expected O, but got I4
		//IL_0253: Expected F4, but got O
		//IL_0253: Expected O, but got I4
		//IL_0268: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89D8]");
		object obj3 = (nint)0 & (nint)1;
		Object obj5;
		Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v25+E4]");
			bool flag = (nint)0 == 0;
			obj5 = selector;
			obj6 = selector;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = selector;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v25+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = selector;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object obj8 = null;
		object obj9 = null;
		Vector2 vector = (Vector2)0;
		if (!flag4)
		{
			goto IL_0176;
		}
		goto IL_01ce;
		IL_01ce:
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			if (!(dragVisual != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = dragVisual != null;
			bool flag6 = !flag5;
			object obj11 = !flag6;
			if (obj11 == null)
			{
				return;
			}
		}
		int num = ShortcutExtensions.DOKill(dragVisual);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMove(dragVisual, (Vector3)0, (float)_dragVisualOriginalLocalPosition);
		object obj12 = (nint)0 + (nint)2904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		return;
		IL_0176:
		ClanLogoImageSelector clanLogoImageSelector = selector;
		Camera pressEventCamera = eventData.pressEventCamera;
		bool flag7 = clanLogoImageSelector.OnDropRequested == null;
		obj9 = obj8;
		vector = (Vector2)0;
		if (!flag7)
		{
			object obj13 = (nint)0 + (nint)1368;
			obj9 = obj13;
			((UnityEvent<Vector2, object>)(object)clanLogoImageSelector.OnDropRequested).Invoke((Vector2)pressEventCamera, obj13);
			vector = (Vector2)pressEventCamera;
		}
		goto IL_01ce;
		IL_0091:
		bool flag8 = obj5 != null;
		bool flag9 = !flag8;
		object obj14 = !flag9;
		obj8 = null;
		if (obj14 != null)
		{
			goto IL_0176;
		}
		obj9 = null;
		vector = (Vector2)0;
		goto IL_01ce;
	}
}
