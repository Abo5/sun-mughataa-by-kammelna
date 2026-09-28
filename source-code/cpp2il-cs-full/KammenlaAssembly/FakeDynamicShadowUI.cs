using System;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;

public class FakeDynamicShadowUI : MonoBehaviour
{
	public Vector3 lightDirection;

	public Transform target;

	public float offset;

	public Vector2 shadowOpacityRange;

	public Vector2 shadowScaleRange;

	public float maxShadowDistance;

	public bool useZPosition;

	public float zPosition;

	public bool ignoreEulerX;

	public bool ignoreEulerY;

	public bool igonreEulerZ;

	public float height;

	public bool isImageShadow;

	private Image uiShadow;

	private SpriteRenderer spriteShadow;

	private Func<float> <heightMethod>k__BackingField;

	public Func<float> heightMethod
	{
		get
		{
			return <heightMethod>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 120;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public SpriteRenderer spriteRenderer => spriteShadow;

	private bool useSpriteRenderer
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0067: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return spriteShadow != null;
		}
	}

	private bool ShowImageShadow()
	{
		return isImageShadow;
	}

	private void Start()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0192: Expected O, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_020d: Expected O, but got I
		//IL_0262: Expected O, but got I4
		//IL_01e6: Expected O, but got I4
		//IL_013a: Expected O, but got I4
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected O, but got Unknown
		//IL_02b6: Expected O, but got I4
		//IL_02c0: Expected O, but got I4
		//IL_0377: Expected O, but got I4
		//IL_032d: Expected O, but got I4
		//IL_0392: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E78D7]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		UnityEngine.Object obj5;
		UnityEngine.Object obj7;
		object obj8;
		if (obj3 != null)
		{
			obj4 = this + 104;
			obj5 = (UnityEngine.Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v24+E4]");
			bool flag = (nint)0 == 0;
			obj7 = (UnityEngine.Object)obj4;
			obj8 = obj4;
			if (!flag)
			{
				goto IL_00a0;
			}
		}
		else
		{
			_ = 1;
			obj4 = this + 104;
			obj5 = (UnityEngine.Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v24+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			obj7 = (UnityEngine.Object)obj4;
			obj8 = obj4;
			if (obj9 != null)
			{
				goto IL_00a0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj7;
		bool flag4 = !flag3;
		object obj10 = !flag4;
		Image image = null;
		obj4 = obj8;
		if (obj10 != null)
		{
			goto IL_00d7;
		}
		goto IL_0201;
		IL_0148:
		UpdateShadow();
		return;
		IL_02ce:
		object obj11 = this + 112;
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			bool flag5 = (UnityEngine.Object)obj11;
			bool flag6 = !flag5;
			object obj13 = !flag6;
			if (obj13 != null)
			{
				goto IL_0148;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = (UnityEngine.Object)obj11;
			bool flag8 = !flag7;
			object obj14 = !flag8;
			if (obj14 != null)
			{
				goto IL_0148;
			}
		}
		object obj15 = (nint)0 + (nint)72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		SpriteRenderer spriteRenderer = default(SpriteRenderer);
		spriteShadow = spriteRenderer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		UpdateShadow();
		return;
		IL_0114:
		UnityEngine.Object obj16;
		bool flag9 = obj16;
		bool flag10 = !flag9;
		object obj17 = 0;
		if (!flag10)
		{
			goto IL_0148;
		}
		goto IL_02ce;
		IL_00a0:
		bool flag11 = obj5;
		bool flag12 = !flag11;
		image = null;
		obj8 = obj4;
		if (!flag12)
		{
			goto IL_00d7;
		}
		goto IL_0201;
		IL_0201:
		object obj18 = (nint)0 + (nint)3872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Image image2 = default(Image);
		uiShadow = image2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj16 = (UnityEngine.Object)obj8;
		object obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v14+E4]");
		bool flag13 = (nint)0 == 0;
		object obj20 = !flag13;
		image = image2;
		UnityEngine.Object obj21 = (UnityEngine.Object)obj8;
		if (obj20 != null)
		{
			goto IL_0114;
		}
		goto IL_0280;
		IL_00d7:
		obj16 = (UnityEngine.Object)obj4;
		obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v14+E4]");
		bool flag14 = (nint)0 == 0;
		obj21 = (UnityEngine.Object)obj4;
		if (!flag14)
		{
			goto IL_0114;
		}
		goto IL_0280;
		IL_0280:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag15 = obj21;
		bool flag16 = !flag15;
		object obj22 = !flag16;
		obj17 = 0;
		if (obj22 != null)
		{
			goto IL_0148;
		}
		goto IL_02ce;
	}

	private void LateUpdate()
	{
		UpdateShadow();
	}

	private void UpdateShadow()
	{
		//IL_019e: Expected O, but got I4
		//IL_01bb: Expected O, but got I4
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_0214: Invalid comparison between F8 and I4
		//IL_0223: Invalid comparison between F8 and I4
		//IL_023d: Expected O, but got F8
		//IL_024c: Expected O, but got F8
		//IL_0281: Expected O, but got I4
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_0669: Invalid comparison between F4 and I4
		//IL_06db: Expected O, but got I4
		//IL_06e4: Expected O, but got I4
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Expected O, but got Unknown
		//IL_070e: Expected O, but got I
		//IL_03a9: Expected O, but got I4
		//IL_02cf: Expected F8, but got I4
		//IL_033b: Expected O, but got I4
		//IL_0344: Expected O, but got I4
		//IL_042f: Expected I, but got O
		//IL_043f: Expected O, but got I
		//IL_036a: Expected O, but got I4
		//IL_03f8: Expected O, but got I4
		//IL_0401: Expected O, but got I4
		//IL_040a: Expected O, but got I4
		//IL_074a: Invalid comparison between F8 and I4
		//IL_0759: Invalid comparison between F8 and I4
		//IL_0773: Expected O, but got F8
		//IL_0782: Expected O, but got F8
		//IL_07b7: Expected O, but got I4
		//IL_07bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c4: Expected O, but got Unknown
		//IL_07e6: Invalid comparison between F4 and I4
		//IL_080f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0814: Expected O, but got Unknown
		//IL_082a: Expected O, but got I
		//IL_0483: Expected F8, but got I4
		//IL_0576: Expected O, but got I4
		//IL_060a: Expected I, but got O
		//IL_061a: Expected O, but got I
		//IL_062a: Expected O, but got I
		//IL_0536: Expected O, but got I4
		//IL_05e4: Expected O, but got I4
		Func<float> func = <heightMethod>k__BackingField;
		if (<heightMethod>k__BackingField != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v32 @ X8_v1 (System.Func`1<System.Single>)+18] (should have been resolved before IL gen)");
			float num = default(float);
			height = num;
		}
		Vector3 position = target.position;
		float num2 = offset;
		float num3 = height * maxShadowDistance;
		float num4 = offset + num3;
		if (!useZPosition)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FakeDynamicShadowUI)+28]");
			num2 = 0f * num4;
		}
		Vector3 eulerAngles = target.eulerAngles;
		if (ignoreEulerX)
		{
			Transform transform = base.transform;
			Vector3 eulerAngles2 = transform.eulerAngles;
		}
		bool flag = !ignoreEulerY;
		float num5 = num3;
		if (!flag)
		{
			Transform transform2 = base.transform;
			Vector3 eulerAngles3 = transform2.eulerAngles;
			num5 = num3;
		}
		object obj2 = default(object);
		while (true)
		{
			bool flag2 = !igonreEulerZ;
			object obj = obj2;
			if (!flag2)
			{
				Transform transform3 = base.transform;
				Vector3 eulerAngles4 = transform3.eulerAngles;
				obj = obj2;
			}
			Transform transform4 = base.transform;
			transform4.position = (Vector3)0;
			Transform transform5 = base.transform;
			transform5.eulerAngles = (Vector3)0;
			Transform transform6 = base.transform;
			Vector3 localScale = target.localScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FakeDynamicShadowUI)+48]");
			object obj3 = 0 - shadowScaleRange;
			double num6 = (double)height - 1.0;
			bool flag3 = num6 < 0.0;
			bool flag4 = num6 == 0.0;
			object obj4 = (double)height ^ 1.0;
			object obj5 = (double)height ^ num6;
			object obj6 = obj4 & obj5;
			bool flag5 = (nint)obj6 < 0;
			bool flag6 = flag3 == flag5;
			object obj7 = !flag4;
			object obj8 = flag6 & obj7;
			object obj9 = ~obj8;
			double num7 = ((obj9 != null) ? ((double)height) : 1.0);
			if (height < 0f)
			{
				num7 = 0.0;
			}
			double num8 = (double)obj3 * num7;
			double num9 = (double)shadowScaleRange + num8;
			double num10 = (double)obj * num9;
			double num11 = (double)num5 * num9;
			double num12 = (double)num2 * num9;
			transform6.localScale = (Vector3)0;
			object obj10 = 152989696;
			object obj11 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E78D6]");
			object obj12 = (nint)0 & (nint)1;
			UnityEngine.Object obj13;
			UnityEngine.Object obj15;
			if (obj12 != null)
			{
				obj13 = spriteShadow;
				object obj14 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v20+E4]");
				bool flag7 = (nint)0 == 0;
				obj15 = spriteShadow;
				if (!flag7)
				{
					goto IL_0315;
				}
			}
			else
			{
				_ = 1;
				obj13 = spriteShadow;
				object obj14 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v20+E4]");
				bool flag8 = (nint)0 == 0;
				object obj16 = !flag8;
				obj15 = spriteShadow;
				if (obj16 != null)
				{
					goto IL_0315;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag9 = obj15 != null;
			bool flag10 = !flag9;
			object obj17 = !flag10;
			object obj18 = 0;
			object obj19 = 0;
			if (obj17 != null)
			{
				goto IL_0352;
			}
			goto IL_0418;
			IL_04ed:
			double num14;
			double num13 = (double)shadowOpacityRange + num14;
			UnityEngine.Object obj20;
			if (obj20 != null)
			{
				break;
			}
			goto IL_05f3;
			IL_0352:
			Color color = spriteShadow.color;
			object obj21 = 0;
			goto IL_072b;
			IL_072b:
			double num15 = (double)height - 1.0;
			bool flag11 = num15 < 0.0;
			bool flag12 = num15 == 0.0;
			object obj22 = (double)height ^ 1.0;
			object obj23 = (double)height ^ num15;
			object obj24 = obj22 & obj23;
			bool flag13 = (nint)obj24 < 0;
			bool flag14 = flag11 == flag13;
			object obj25 = !flag12;
			object obj26 = flag14 & obj25;
			object obj27 = ~obj26;
			double num16 = ((obj27 != null) ? ((double)height) : 1.0);
			double num17 = ((!(height < 0f)) ? num16 : 0.0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FakeDynamicShadowUI)+40]");
			object obj28 = 0 - shadowOpacityRange;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E78D6]");
			object obj29 = (nint)0 & (nint)1;
			UnityEngine.Object obj31;
			double num18;
			if (obj29 != null)
			{
				num14 = (double)obj28 * num17;
				object obj30 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X0_v23+E4]");
				bool flag15 = (nint)0 == 0;
				obj20 = spriteShadow;
				obj31 = spriteShadow;
				num18 = num14;
				if (!flag15)
				{
					goto IL_04ed;
				}
			}
			else
			{
				_ = 1;
				num14 = (double)obj28 * num17;
				object obj30 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X0_v23+E4]");
				bool flag16 = (nint)0 == 0;
				object obj32 = !flag16;
				obj20 = spriteShadow;
				obj31 = spriteShadow;
				num18 = num14;
				if (obj32 != null)
				{
					goto IL_04ed;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num13 = (double)shadowOpacityRange + num18;
			bool flag17 = obj31 != null;
			bool flag18 = !flag17;
			object obj33 = !flag18;
			if (obj33 != null)
			{
				break;
			}
			goto IL_05f3;
			IL_0315:
			bool flag19 = obj13 != null;
			bool flag20 = !flag19;
			obj18 = 0;
			obj19 = 0;
			if (!flag20)
			{
				goto IL_0352;
			}
			goto IL_0418;
			IL_05f3:
			Image image = uiShadow;
			nint num19 = (nint)image;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v11 (Il2CppClass<UnityEngine.UI.Image>)+2A8]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v11 (Il2CppClass<UnityEngine.UI.Image>)+2B0]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v280 @ X2_v4 (should have been resolved before IL gen)");
			continue;
			IL_0418:
			Image image2 = uiShadow;
			nint num20 = (nint)image2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v19 (Il2CppClass<UnityEngine.UI.Image>)+2A0]");
			obj21 = 0;
			Color color2 = image2.color;
			obj18 = obj19;
			goto IL_072b;
		}
		spriteShadow.color = (Color)0;
	}

	public FakeDynamicShadowUI()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		object obj = typeof(UsageHint) + 816;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+24]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+2C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252FC0]");
		_ = 0;
		_ = 1065353216;
		_ = 1;
		base..ctor();
	}
}
