using System;
using System.Buffers.Text;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using Kammelna.Server.Models.Clans;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class CaptureAndBlurFeature : ScriptableRendererFeature
{
	[Serializable]
	public class Settings
	{
		public Shader blurShader;

		public RenderPassEvent renderPassEvent;

		public int downsample;

		public float blurSize;

		public int blurIterations;

		public Settings()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252EB8]");
			renderPassEvent = RenderPassEvent.BeforeRendering;
			blurSize = 4f;
			base..ctor();
		}
	}

	private static readonly int BlurBackdropTextureId;

	private Settings _settings;

	private CaptureAndBlurPass _pass;

	private Material _material;

	private RTHandle _backdropRT;

	public override void Create()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00cf: Expected O, but got I4
		//IL_00d8: Expected O, but got I4
		//IL_006f: Expected O, but got I4
		//IL_0078: Expected O, but got I4
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_008f: Expected O, but got I4
		//IL_0273: Expected O, but got I4
		//IL_027c: Expected O, but got I4
		//IL_028a: Expected O, but got I4
		//IL_01a6: Expected O, but got I4
		//IL_01b4: Expected O, but got I4
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_0205: Expected O, but got I4
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02ea: Expected O, but got I4
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected O, but got Unknown
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected O, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected O, but got Unknown
		//IL_0353: Expected O, but got I
		//IL_036d: Expected O, but got I
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected O, but got Unknown
		Settings settings = _settings;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
		object obj4;
		object obj5;
		UnityEngine.Object obj6;
		if ((nint)0 != 0)
		{
			bool flag = settings.blurShader == null;
			bool flag2 = !flag;
			object obj3 = !flag2;
			obj4 = 0;
			if (obj3 != null)
			{
				goto IL_00eb;
			}
			obj5 = 0;
			obj6 = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = settings.blurShader == null;
			bool flag4 = !flag3;
			obj4 = 0;
			obj5 = 0;
			obj6 = null;
			if (!flag4)
			{
				goto IL_00eb;
			}
		}
		goto IL_0143;
		IL_0143:
		Settings settings2 = _settings;
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v8+E4]");
		if ((nint)0 != 0)
		{
			bool flag5 = settings2.blurShader == null;
			bool flag6 = !flag5;
			object obj8 = 0;
			UnityEngine.Object obj9 = null;
			object obj10 = 0;
			UnityEngine.Object obj11 = null;
			if (!flag6)
			{
				goto IL_01c7;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = settings2.blurShader == null;
			bool flag8 = !flag7;
			object obj12 = !flag8;
			object obj8 = 0;
			UnityEngine.Object obj9 = null;
			object obj10 = 0;
			UnityEngine.Object obj11 = null;
			if (obj12 != null)
			{
				goto IL_01c7;
			}
		}
		Settings settings3 = _settings;
		object obj13 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3272;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v12+E4]");
		bool flag9 = (nint)0 == 0;
		object obj15 = !flag9;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Material material = CoreUtils.CreateEngineMaterial(settings3.blurShader);
		object obj16 = this + 48;
		obj16 = material;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj17 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ScriptableRenderPass scriptableRenderPass = default(ScriptableRenderPass);
		scriptableRenderPass..ctor();
		object obj18 = scriptableRenderPass + 96;
		obj18 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj19 = scriptableRenderPass + 104;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X21_v5-10]");
		obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X21_v5-10]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v15+18]");
		scriptableRenderPass.<renderPassEvent>k__BackingField = RenderPassEvent.BeforeRendering;
		object obj21 = this + 40;
		obj21 = scriptableRenderPass;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_01c7:
		object obj22 = typeof(DataRelation) + 856;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v31+E4]");
		bool flag10 = (nint)0 == 0;
		object obj24 = !flag10;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message = "WhiteSmoke" + 2840;
		Debug.LogError(message);
		return;
		IL_00eb:
		object obj25 = "HH:mm:ss.ffZ" + 1152;
		Shader shader = Shader.Find((string)obj25);
		object obj26 = _settings + 16;
		obj26 = shader;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj5 = obj4;
		obj6 = shader;
		goto IL_0143;
	}

	public unsafe override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00b1: Expected O, but got I4
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_030f: Expected O, but got I
		//IL_00e6: Expected O, but got Ref
		//IL_0126: Expected O, but got Ref
		//IL_0164: Expected O, but got Ref
		//IL_01b2: Expected I4, but got O
		//IL_01c0: Expected O, but got I4
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected I4, but got Unknown
		//IL_022e: Expected O, but got I4
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_034f: Expected O, but got I4
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected I4, but got Unknown
		//IL_03bd: Expected O, but got I4
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected O, but got Unknown
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected O, but got Unknown
		//IL_042d: Expected O, but got I4
		//IL_044b: Expected O, but got I
		//IL_0467: Expected I4, but got O
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		if (_pass == null)
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			if (_material == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = _material == null;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 != null)
			{
				return;
			}
		}
		object obj4 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3112;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v10+B8]");
		object obj6 = 0;
		if ((nint)obj6 < 1)
		{
			return;
		}
		CameraData cameraData = (CameraData)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref renderingData, 8));
		if (((CameraData*)cameraData)->cameraType != CameraType.Game)
		{
			return;
		}
		CameraData cameraData2 = (CameraData)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref renderingData, 8));
		if (((CameraData*)cameraData2)->renderType == CameraRenderType.Base)
		{
			CameraData cameraData3 = (CameraData)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref renderingData, 8));
			ref RenderTextureDescriptor cameraTargetDescriptor = ref ((CameraData*)cameraData3)->cameraTargetDescriptor;
			Settings settings = _settings;
			int num = ~settings.downsample;
			int num2 = settings.downsample & num;
			int num3 = (object)cameraTargetDescriptor >> num2;
			object obj7 = num3 - 1;
			bool flag3 = (nint)obj7 < 0;
			bool flag4 = obj7 == null;
			int num4 = num3 ^ 1;
			int num5 = num3 ^ obj7;
			int num6 = num4 & num5;
			bool flag5 = num6 < 0;
			bool flag6 = flag3 == flag5;
			object obj8 = !flag4;
			object obj9 = flag6 & obj8;
			object obj10 = ~obj9;
			int width = ((obj10 != null) ? 1 : num3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v11 (UnityEngine.RenderTextureDescriptor&)+4]");
			int num7 = (int)((nint)0 >> num2);
			object obj11 = num7 - 1;
			bool flag7 = (nint)obj11 < 0;
			bool flag8 = obj11 == null;
			int num8 = num7 ^ 1;
			int num9 = num7 ^ obj11;
			int num10 = num8 & num9;
			bool flag9 = num10 < 0;
			bool flag10 = flag7 == flag9;
			object obj12 = !flag8;
			object obj13 = flag10 & obj12;
			object obj14 = ~obj13;
			int height = ((obj14 != null) ? 1 : num7);
			EnsureBackdropRT(width, height);
			object obj15 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 272;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v16+E4]");
			bool flag11 = (nint)0 == 0;
			object obj17 = !flag11;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj16 = obj15;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v16+B8]");
			object obj18 = 0;
			Texture value = _backdropRT;
			Shader.SetGlobalTexture((int)obj18, value);
			object obj19 = _pass + 112;
			obj19 = _backdropRT;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			renderer.EnqueuePass(_pass);
		}
	}

	protected override void Dispose(bool disposing)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_012c: Expected O, but got I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00f1: Expected O, but got I4
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_0193: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3272;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E73C4]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object material;
		UnityEngine.Object material2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			material = _material;
			material2 = _material;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			material = _material;
			material2 = _material;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		CoreUtils.Destroy(material2);
		object obj6 = this + 56;
		RTHandle rTHandle = (RTHandle)obj6;
		bool flag3 = obj6 == null;
		object obj7 = !flag3;
		if (obj7 != null)
		{
			goto IL_00d2;
		}
		object obj8 = obj6;
		goto IL_00e8;
		IL_00d2:
		rTHandle.Release();
		obj8 = obj6;
		goto IL_00e8;
		IL_0091:
		CoreUtils.Destroy(material);
		obj6 = this + 56;
		rTHandle = (RTHandle)obj6;
		bool flag4 = obj6 == null;
		obj8 = obj6;
		if (!flag4)
		{
			goto IL_00d2;
		}
		goto IL_00e8;
		IL_00e8:
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void EnsureBackdropRT(int width, int height)
	{
		//IL_08d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08de: Expected O, but got Unknown
		//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e9: Expected O, but got Unknown
		//IL_0268: Expected O, but got I4
		//IL_0271: Expected O, but got I4
		//IL_027f: Expected O, but got I4
		//IL_0540: Expected O, but got I4
		//IL_054e: Expected O, but got I4
		//IL_00a8: Expected O, but got I
		//IL_029a: Expected O, but got I4
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected I4, but got Unknown
		//IL_0307: Expected O, but got I4
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected O, but got Unknown
		//IL_0044: Expected O, but got I
		//IL_005e: Expected O, but got I4
		//IL_0579: Expected O, but got I
		//IL_0596: Expected O, but got I
		//IL_05ad: Expected O, but got I4
		//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Expected I4, but got Unknown
		//IL_061a: Expected O, but got I4
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Expected O, but got Unknown
		//IL_0102: Expected O, but got I
		//IL_0682: Expected O, but got I4
		//IL_01ed: Expected O, but got I
		//IL_0217: Expected O, but got I4
		//IL_0227: Expected O, but got I
		//IL_09b5: Expected O, but got I4
		//IL_03bc: Expected O, but got I4
		//IL_0355: Expected O, but got I
		//IL_0384: Expected O, but got I
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_0718: Expected O, but got Unknown
		//IL_0725: Expected O, but got I4
		//IL_0758: Unknown result type (might be due to invalid IL or missing references)
		//IL_075d: Expected I4, but got Unknown
		//IL_0792: Expected O, but got I4
		//IL_079a: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Expected O, but got Unknown
		//IL_06e5: Expected O, but got I4
		//IL_06ee: Expected O, but got I4
		//IL_016a: Expected O, but got I
		//IL_03ef: Expected O, but got I
		//IL_0800: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Expected O, but got Unknown
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected O, but got Unknown
		//IL_0427: Expected O, but got I4
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected I4, but got Unknown
		//IL_0494: Expected O, but got I4
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected O, but got Unknown
		//IL_086b: Expected O, but got I4
		//IL_097d: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = this + 56;
		object obj3 = obj2;
		bool flag = obj2 == null;
		int num = height;
		int num2 = width;
		int num3;
		if (!flag)
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v47+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v3+18]");
				bool flag2 = (UnityEngine.Object)0 != null;
				bool flag3 = !flag2;
				object obj5 = !flag3;
				num3 = 0;
				if (obj5 != null)
				{
					goto IL_00e5;
				}
				num = 0;
				num2 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v3+18]");
				bool flag4 = (UnityEngine.Object)0 != null;
				bool flag5 = !flag4;
				num3 = 0;
				num = 0;
				num2 = 0;
				if (!flag5)
				{
					goto IL_00e5;
				}
			}
			goto IL_01b8;
		}
		goto IL_04e7;
		IL_028d:
		bool flag6;
		object obj6 = width - (flag6 ? 1 : 0);
		bool flag7 = (nint)obj6 < 0;
		bool flag8 = obj6 == null;
		int num4 = width ^ (flag6 ? 1 : 0);
		int num5 = width ^ obj6;
		int num6 = num4 & num5;
		bool flag9 = num6 < 0;
		bool flag10 = flag7 == flag9;
		object obj7 = !flag8;
		object obj8 = flag10 & obj7;
		object obj9 = ~obj8;
		bool flag11 = ((obj9 != null) ? flag6 : ((byte)width != 0));
		object obj10 = obj2;
		bool flag12 = obj2 == null;
		object obj12;
		object obj11 = obj12;
		UnityEngine.Object obj14;
		UnityEngine.Object obj13 = obj14;
		bool flag13 = flag11;
		if (!flag12)
		{
			goto IL_0345;
		}
		goto IL_0658;
		IL_039a:
		UnityEngine.Object obj15;
		bool flag14 = obj15 != null;
		bool flag15 = !flag14;
		object obj16 = 0;
		flag13 = flag11;
		if (!flag15)
		{
			goto IL_03d2;
		}
		goto IL_0704;
		IL_0704:
		object obj17 = typeof(System.Buffers.Text.ParserHelpers) + 3024;
		object obj18 = height - (flag14 ? 1 : 0);
		bool flag16 = (nint)obj18 < 0;
		bool flag17 = obj18 == null;
		int num7 = height ^ (flag14 ? 1 : 0);
		int num8 = height ^ obj18;
		int num9 = num7 & num8;
		bool flag18 = num9 < 0;
		bool flag19 = flag16 == flag18;
		object obj19 = !flag17;
		object obj20 = flag19 & obj19;
		object obj21 = ~obj20;
		bool flag20 = ((obj21 != null) ? flag14 : ((byte)height != 0));
		RTHandle rTHandle = (RTHandle)obj2;
		bool flag21 = obj2 == null;
		object obj22 = obj17;
		flag11 = flag13;
		bool height2 = flag20;
		if (!flag21)
		{
			goto IL_07d0;
		}
		goto IL_07f6;
		IL_00e5:
		object obj23 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v35+18]");
		object obj24 = 0;
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v36+190]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v256 @ X8_v36+188] (should have been resolved before IL gen)");
		object obj26 = default(object);
		bool flag22 = (nint)obj26 < width;
		num = num3;
		if (!flag22)
		{
			object obj27 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v37+18]");
			object obj28 = 0;
			object obj29 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v38+1B0]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v255 @ X8_v38+1A8] (should have been resolved before IL gen)");
			object obj30 = default(object);
			bool flag23 = (nint)obj30 >= height;
			num = num3;
			if (flag23)
			{
				return;
			}
		}
		goto IL_01b8;
		IL_0658:
		object obj31 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v12+E4]");
		bool flag24 = (nint)0 == 0;
		object obj32 = !flag24;
		obj15 = null;
		flag11 = flag13;
		obj12 = obj11;
		obj14 = obj13;
		UnityEngine.Object obj33 = null;
		if (obj32 != null)
		{
			goto IL_039a;
		}
		goto IL_06b2;
		IL_06b2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		flag14 = obj33 != null;
		bool flag25 = !flag14;
		object obj34 = !flag25;
		obj16 = 0;
		flag11 = flag13;
		if (obj34 != null)
		{
			goto IL_03d2;
		}
		goto IL_0704;
		IL_01b8:
		object obj35 = obj2;
		if (obj2 == null)
		{
			goto IL_04e7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v33+18]");
		UnityEngine.Object obj36 = (UnityEngine.Object)0;
		object obj37 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v30+E4]");
		bool flag26 = (nint)0 == 0;
		object obj38 = !flag26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v33+18]");
		UnityEngine.Object obj39 = (UnityEngine.Object)0;
		if (obj38 == null)
		{
			goto IL_0235;
		}
		goto IL_051e;
		IL_04e7:
		obj37 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v30+E4]");
		bool flag27 = (nint)0 == 0;
		obj36 = null;
		obj39 = null;
		if (flag27)
		{
			goto IL_0235;
		}
		goto IL_051e;
		IL_0345:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v26+18]");
		obj15 = (UnityEngine.Object)0;
		obj31 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v12+E4]");
		bool flag28 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v26+18]");
		obj33 = (UnityEngine.Object)0;
		flag13 = flag11;
		if (!flag28)
		{
			goto IL_039a;
		}
		goto IL_06b2;
		IL_051e:
		flag6 = obj39 != null;
		bool flag29 = !flag6;
		obj12 = 0;
		obj14 = null;
		obj11 = 0;
		if (flag29)
		{
			goto IL_028d;
		}
		goto IL_055c;
		IL_0235:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		flag6 = obj36 != null;
		bool flag30 = !flag6;
		object obj40 = !flag30;
		obj12 = 0;
		obj14 = null;
		obj11 = 0;
		if (obj40 == null)
		{
			goto IL_028d;
		}
		goto IL_055c;
		IL_055c:
		object obj41 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v16+18]");
		object obj42 = 0;
		object obj43 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v17+190]");
		obj14 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v311 @ X8_v17+188] (should have been resolved before IL gen)");
		bool flag31 = default(bool);
		object obj44 = width - (flag31 ? 1 : 0);
		bool flag32 = (nint)obj44 < 0;
		bool flag33 = obj44 == null;
		int num10 = width ^ (flag31 ? 1 : 0);
		int num11 = width ^ obj44;
		int num12 = num10 & num11;
		bool flag34 = num12 < 0;
		bool flag35 = flag32 == flag34;
		object obj45 = !flag33;
		object obj46 = flag35 & obj45;
		object obj47 = ~obj46;
		flag11 = ((obj47 != null) ? flag31 : ((byte)width != 0));
		obj10 = obj2;
		bool flag36 = obj2 == null;
		object obj48 = !flag36;
		obj12 = obj11;
		obj13 = obj14;
		flag13 = flag11;
		if (obj48 != null)
		{
			goto IL_0345;
		}
		goto IL_0658;
		IL_03d2:
		object obj49 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v23+18]");
		object obj50 = 0;
		object obj51 = obj50;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v590 @ X8_v24+1A8] (should have been resolved before IL gen)");
		obj17 = typeof(System.Buffers.Text.ParserHelpers) + 3024;
		bool flag37 = default(bool);
		object obj52 = height - (flag37 ? 1 : 0);
		bool flag38 = (nint)obj52 < 0;
		bool flag39 = obj52 == null;
		int num13 = height ^ (flag37 ? 1 : 0);
		int num14 = height ^ obj52;
		int num15 = num13 & num14;
		bool flag40 = num15 < 0;
		bool flag41 = flag38 == flag40;
		object obj53 = !flag39;
		object obj54 = flag41 & obj53;
		object obj55 = ~obj54;
		flag20 = ((obj55 != null) ? flag37 : ((byte)height != 0));
		rTHandle = (RTHandle)obj2;
		bool flag42 = obj2 == null;
		object obj56 = !flag42;
		flag13 = flag11;
		if (obj56 != null)
		{
			goto IL_07d0;
		}
		obj22 = obj17;
		height2 = flag20;
		goto IL_07f6;
		IL_07f6:
		object obj57 = "[{0}]:{1}" + 1632;
		RenderTextureDescriptor renderTextureDescriptor = new RenderTextureDescriptor(flag11 ? 1 : 0, height2 ? 1 : 0, RenderTextureFormat.ARGB32, 0);
		renderTextureDescriptor.useMipMap = false;
		renderTextureDescriptor.autoGenerateMips = false;
		object obj58 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X0_v9+E4]");
		bool flag43 = (nint)0 == 0;
		object obj59 = !flag43;
		if (obj59 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RenderTextureDescriptor descriptor = default(RenderTextureDescriptor);
		RTHandle rTHandle2 = RTHandles.Alloc(ref descriptor, FilterMode.Bilinear, TextureWrapMode.Clamp, isShadowMap: false, 1, 0f, (string)obj57);
		obj2 = rTHandle2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_07d0:
		rTHandle.Release();
		obj22 = obj17;
		flag11 = flag13;
		height2 = flag20;
		goto IL_07f6;
	}

	public CaptureAndBlurFeature()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252EB8]");
		_ = 0;
		_ = 9672065024L;
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = this + 32;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	static CaptureAndBlurFeature()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_0055: Expected O, but got I4
		object obj = "[{0}]:{1}" + 1632;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 272;
		int num = Shader.PropertyToID((string)obj);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
		object obj4 = 0;
		obj4 = num;
	}
}
