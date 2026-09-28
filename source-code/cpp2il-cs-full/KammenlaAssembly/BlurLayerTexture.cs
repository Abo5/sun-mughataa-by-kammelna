using System;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.UI;

public class BlurLayerTexture : MonoBehaviour
{
	public RawImage BlurTexture;

	public Button BlockerTint;

	public Blur2RT BlurCamera;

	private float <BlurTextureAlpha>k__BackingField;

	private float <BlockerTintAlpha>k__BackingField;

	public float BlurTextureAlpha
	{
		get
		{
			return <BlurTextureAlpha>k__BackingField;
		}
		set
		{
			<BlurTextureAlpha>k__BackingField = value;
		}
	}

	public float BlockerTintAlpha
	{
		get
		{
			return <BlockerTintAlpha>k__BackingField;
		}
		set
		{
			<BlockerTintAlpha>k__BackingField = value;
		}
	}

	private void Awake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_017e: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_00cc: Expected O, but got I4
		//IL_0204: Expected I, but got O
		//IL_0214: Expected O, but got I
		//IL_025f: Expected O, but got I4
		//IL_01d1: Expected O, but got I4
		//IL_01df: Expected O, but got I4
		//IL_013f: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E73B8]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object blurTexture;
		UnityEngine.Object blurTexture2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			blurTexture = BlurTexture;
			blurTexture2 = BlurTexture;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v15+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			blurTexture = BlurTexture;
			blurTexture2 = BlurTexture;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = blurTexture2 != null;
		bool flag4 = !flag3;
		object obj6 = 0;
		UnityEngine.Object obj7 = null;
		object obj8 = 0;
		if (flag4)
		{
			goto IL_00da;
		}
		goto IL_01ed;
		IL_02b5:
		Image image = BlockerTint.image;
		Color color = image.color;
		float num = default(float);
		<BlockerTintAlpha>k__BackingField = num;
		return;
		IL_011b:
		UnityEngine.Object blockerTint;
		bool flag5 = blockerTint != null;
		bool flag6 = !flag5;
		object obj9 = !flag6;
		if (obj9 == null)
		{
			return;
		}
		goto IL_02b5;
		IL_027f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object blockerTint2;
		if (!(blockerTint2 != null))
		{
			return;
		}
		goto IL_02b5;
		IL_0091:
		bool flag7 = blurTexture != null;
		bool flag8 = !flag7;
		object obj10 = !flag8;
		obj6 = 0;
		obj7 = null;
		obj8 = 0;
		if (obj10 == null)
		{
			goto IL_00da;
		}
		goto IL_01ed;
		IL_01ed:
		RawImage blurTexture3 = BlurTexture;
		nint num2 = (nint)blurTexture3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v7 (Il2CppClass<UnityEngine.UI.RawImage>)+2A0]");
		obj7 = (UnityEngine.Object)0;
		Color color2 = blurTexture3.color;
		<BlurTextureAlpha>k__BackingField = num;
		blockerTint = BlockerTint;
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v7+E4]");
		bool flag9 = (nint)0 == 0;
		object obj12 = !flag9;
		obj6 = obj8;
		blockerTint2 = BlockerTint;
		if (obj12 != null)
		{
			goto IL_011b;
		}
		goto IL_027f;
		IL_00da:
		obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v7+E4]");
		bool flag10 = (nint)0 == 0;
		blockerTint = BlockerTint;
		blockerTint2 = BlockerTint;
		if (!flag10)
		{
			goto IL_011b;
		}
		goto IL_027f;
	}

	public void StartBlur(bool blurOnlyOnce = true)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0058: Expected I, but got O
		//IL_0081: Expected O, but got I4
		//IL_00b5: Expected O, but got I
		RawImage blurTexture = BlurTexture;
		RenderTexture texture = (RenderTexture)blurTexture.m_Texture;
		if ((object)blurTexture.m_Texture != null)
		{
			object obj = typeof(RegisteredWaitHandle) + 432;
			object obj2 = obj;
			nint num = (nint)texture;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X9_v4 (Il2CppClass<UnityEngine.RenderTexture>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v9+130]");
			bool flag = num2 < 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X9_v4 (Il2CppClass<UnityEngine.RenderTexture>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v9+130]");
				object obj5 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X9_v6-8]");
				if (0 == (nint)obj2)
				{
					goto IL_00dc;
				}
			}
			throw new InvalidCastException();
		}
		goto IL_00dc;
		IL_00dc:
		BlurCamera.renderTexture = (RenderTexture)blurTexture.m_Texture;
		_ = 0;
		BlurCamera.enabled = true;
		ActivateComponents();
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
	}

	public void EndBlurNow()
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
	}

	private void ActivateComponents()
	{
		GameObject gameObject = BlurTexture.gameObject;
		gameObject.SetActive(value: true);
		GameObject gameObject2 = BlockerTint.gameObject;
		gameObject2.SetActive(value: true);
		GameObject gameObject3 = BlurCamera.gameObject;
		gameObject3.SetActive(value: true);
	}
}
