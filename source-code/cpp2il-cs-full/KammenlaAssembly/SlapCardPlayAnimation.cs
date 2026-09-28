using System.Formats.Asn1;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class SlapCardPlayAnimation : SlapCardAnimationBase
{
	private AnimationCurve bindCardCurve;

	private float bindDuration = 0.1f;

	private Material defaultCardMaterial;

	private Material originalBindMaterial;

	private ParticleSystem hitEffect;

	private Material _bindedCardMaterial;

	private static readonly int BendProperty;

	private static readonly int MainTexProperty;

	protected override void ApplyStartRotation(Transform playedCard, Quaternion startRotation)
	{
		//IL_000e: Expected O, but got I4
		playedCard.rotation = (Quaternion)0;
	}

	protected override void OnScaleComplete(SpriteRenderer card, Transform playedCard)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0032: Expected I, but got O
		//IL_0042: Expected O, but got I
		//IL_0052: Expected O, but got I
		card.material = defaultCardMaterial;
		int cardOrder = base.GetCardOrder();
		object obj = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 3648;
		while (true)
		{
			int sortingLayerID = SortingLayer.NameToID((string)obj);
			card.sortingLayerID = sortingLayerID;
			card.sortingOrder = cardOrder;
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v4 (Il2CppClass<SlapCardPlayAnimation>)+1E8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v4 (Il2CppClass<SlapCardPlayAnimation>)+1F0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v68 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	protected override void OnBeforeAudioPlay(SpriteRenderer card)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0057: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_00a0: Expected I4, but got O
		//IL_00cc: Expected O, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3912;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 680;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Material material = default(Material);
		material..ctor(originalBindMaterial);
		_bindedCardMaterial = material;
		object obj3 = this + 272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v5+B8]");
		object obj7 = 0;
		_bindedCardMaterial.SetFloat((int)obj7, 0f);
		card.material = _bindedCardMaterial;
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v7+B8]");
		object obj9 = 0;
		Sprite sprite = card.sprite;
		Texture2D texture = sprite.texture;
		object materialProperty = "_InputUv1BufferOffset" + 3072;
		Material bindedCardMaterial = _bindedCardMaterial;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v8+4]");
		bindedCardMaterial.SetTexture(0, texture);
		SpriteExensions.SetAtlasRectInfo(card, isSharedMaterial: true, (string)materialProperty);
	}

	protected override void OnAnimationStarted()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003c: Expected O, but got I
		//IL_006c: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_00a8: Expected I4, but got O
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 680;
		object obj2 = (nint)0 + (nint)2856;
		base.OnAnimationStarted();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+B8]");
		object obj5 = 0;
		TweenerCore<float, float, FloatOptions> tweenerCore = ShortcutExtensions.DOFloat(_bindedCardMaterial, 1f, (int)obj5, bindDuration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058E14");
	}

	protected override void OnGrounded(Transform card)
	{
		//IL_0045: Expected O, but got I4
		//IL_0080: Expected O, but got I4
		base.OnGrounded(card);
		Transform transform = hitEffect.transform;
		Vector3 position = _playGround.position;
		transform.position = (Vector3)0;
		Transform transform2 = hitEffect.transform;
		Quaternion rotation = _playGround.rotation;
		transform2.rotation = (Quaternion)0;
		hitEffect.Play();
	}

	public SlapCardPlayAnimation()
	{
		//IL_001d: Expected F4, but got I
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0093: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252FD0]");
		distanceFromCenter = 0f;
		groundScale = 1f;
		object obj = typeof(UsageHint) + 744;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v7+B8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v8+8]");
		object obj4 = default(object);
		object obj3 = 0 * obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v8+8]");
		object obj5 = (nint)0 * (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252FA0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252F98]");
		_ = 0;
		_ = 1061997773;
		((MonoBehaviour)this)..ctor();
	}

	static SlapCardPlayAnimation()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_005c: Expected O, but got I
		//IL_0064: Expected O, but got I4
		//IL_0089: Expected O, but got I
		object obj = "[{0}]:{1}" + 1456;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 680;
		object obj3 = "_InputUv1BufferOffset" + 688;
		int num = Shader.PropertyToID((string)obj);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v3+B8]");
		object obj5 = 0;
		obj5 = num;
		int num2 = Shader.PropertyToID((string)obj3);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v5+B8]");
		object obj7 = 0;
	}
}
