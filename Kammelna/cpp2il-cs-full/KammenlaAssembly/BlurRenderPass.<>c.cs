using System;
using System.Threading;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.Rendering.Universal;
using UnityEngine.TextCore;
using UnityStandardAssets.ImageEffects;

internal class BlurRenderPass : ScriptableRenderPass
{
	private class BlitPassData
	{
		public Material Material;

		public int PassIndex;

		public Vector4 Parameter;

		public TextureHandle Source;
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static BaseRenderFunc<BlitPassData, RasterGraphContext> <>9__12_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3256;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <ScheduleBlit>b__12_0(BlitPassData passData, RasterGraphContext context)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Expected O, but got Unknown
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Expected O, but got Unknown
			//IL_00a0: Expected O, but got I
			//IL_00b7: Expected O, but got I4
			//IL_00b7: Expected I4, but got O
			//IL_00e1: Expected O, but got I4
			//IL_013a: Expected O, but got I4
			//IL_017b: Expected O, but got I4
			//IL_017b: Expected O, but got I
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3136;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 744;
			object obj5 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3000;
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v5+B8]");
			object obj7 = 0;
			passData.Material.SetVector((int)obj7, (Vector4)0);
			object obj8 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			RTHandle source = passData.Source;
			object obj10 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v11+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			IntPtr intPtr = default(IntPtr);
			Blitter.BlitTexture((RasterCommandBuffer)(nint)intPtr, source, (Vector4)passData.Material, (Material)passData.PassIndex, 0);
		}
	}

	private const int DownsamplePassIndex = 0;

	private const int StandardVerticalPassIndex = 1;

	private const int StandardHorizontalPassIndex = 2;

	private static readonly int ParameterId;

	private readonly Material _material;

	private BlurOptimized _config;

	public BlurRenderPass(Material material)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 96;
		obj = material;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void Setup(BlurOptimized config)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 104;
		obj = config;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public unsafe override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
	{
		//IL_0011: Expected O, but got I
		//IL_001d: Expected O, but got I
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_0120: Expected O, but got I4
		//IL_015d: Expected O, but got Ref
		//IL_0181: Expected O, but got Ref
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01f1: Expected O, but got Ref
		//IL_01f1: Expected I4, but got O
		//IL_01f1: Expected O, but got I4
		//IL_023c: Expected O, but got I4
		//IL_08a0: Expected O, but got I4
		//IL_08de: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e3: Expected I4, but got Unknown
		//IL_0918: Expected O, but got I4
		//IL_0920: Unknown result type (might be due to invalid IL or missing references)
		//IL_0925: Expected O, but got Unknown
		//IL_022e: Expected O, but got I4
		//IL_094b: Expected O, but got I4
		//IL_0954: Expected O, but got I4
		//IL_095c: Expected O, but got Ref
		//IL_0964: Expected I4, but got O
		//IL_096d: Expected O, but got I4
		//IL_097e: Expected O, but got I4
		//IL_098c: Expected O, but got I4
		//IL_02a1: Expected O, but got F8
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		//IL_030c: Expected O, but got Ref
		//IL_030c: Expected I4, but got O
		//IL_030c: Expected O, but got Ref
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected O, but got Unknown
		//IL_0367: Expected O, but got Ref
		//IL_0367: Expected I4, but got O
		//IL_0367: Expected O, but got Ref
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected O, but got Unknown
		//IL_0393: Expected O, but got Ref
		//IL_039b: Expected I4, but got O
		//IL_03a3: Expected O, but got Ref
		//IL_03bc: Expected O, but got I4
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected O, but got Unknown
		//IL_041b: Expected O, but got I4
		//IL_0441: Expected O, but got I4
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected O, but got Unknown
		//IL_046b: Expected O, but got I
		//IL_0557: Expected O, but got I4
		//IL_04cb: Expected O, but got I
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Expected O, but got Unknown
		//IL_0585: Expected O, but got I
		//IL_059f: Expected O, but got I4
		//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0803: Expected O, but got Unknown
		//IL_0822: Expected O, but got I4
		//IL_0822: Expected I4, but got O
		//IL_0822: Expected O, but got Ref
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Expected O, but got Unknown
		//IL_0514: Expected O, but got I4
		//IL_0665: Expected O, but got I
		//IL_061f: Expected O, but got I
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d1: Expected O, but got Unknown
		//IL_07ef: Expected I4, but got O
		//IL_07ef: Expected O, but got Ref
		//IL_06f1: Expected O, but got I
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Expected O, but got Unknown
		//IL_0741: Expected I, but got O
		//IL_076a: Expected O, but got I4
		//IL_079e: Expected O, but got I
		//IL_0832: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Expected O, but got Unknown
		//IL_0855: Expected I4, but got O
		//IL_0855: Expected O, but got Ref
		//IL_086b: Expected O, but got I
		object obj = (nint)0 + (nint)2664;
		object obj2 = (nint)0 + (nint)2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @50E7FD0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @50E7FD0");
		UniversalResourceData universalResourceData = default(UniversalResourceData);
		TextureHandle activeColorTexture = universalResourceData.activeColorTexture;
		BlurOptimized config = _config;
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3744;
		object name = "[{0}]:{1}" + 1640;
		object name2 = "[{0}]:{1}" + 1648;
		int num = ~config.downsample;
		int num2 = config.downsample & num;
		int num3 = num2 & 0x1F;
		object obj5 = default(object);
		object obj4 = obj5 + 248;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction SSHL not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction SMAX not yet implemented.\"");
		RenderTextureDescriptor renderTextureDescriptor = default(RenderTextureDescriptor);
		renderTextureDescriptor.depthBufferBits = 0;
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RenderTextureDescriptor renderTextureDescriptor2 = default(RenderTextureDescriptor);
		TextureHandle textureHandle = UniversalRenderer.CreateRenderGraphTexture(renderGraph, (RenderTextureDescriptor)(&renderTextureDescriptor2), (string)name, clear: false, FilterMode.Bilinear);
		TextureHandle textureHandle2 = UniversalRenderer.CreateRenderGraphTexture(renderGraph, (RenderTextureDescriptor)(&renderTextureDescriptor2), (string)name2, clear: false, FilterMode.Bilinear);
		BlurOptimized config2 = _config;
		object obj8 = "AvailableVoices" + 2336;
		int num4 = 1 << num3;
		double num5 = 1.0 / (double)num4;
		string text = (string)obj8;
		ScheduleBlit(renderGraph, (string)obj8, activeColorTexture, (TextureHandle)0, (int)textureHandle, (Vector4)(&renderTextureDescriptor2));
		BlurOptimized config3 = _config;
		object obj9 = ((config2.blurType != BlurOptimized.BlurType.StandardGauss) ? ((object)2) : ((object)0));
		object obj10 = config3.blurIterations - 1;
		bool flag2 = (nint)obj10 < 0;
		bool flag3 = obj10 == null;
		int num6 = config3.blurIterations ^ 1;
		int num7 = config3.blurIterations ^ obj10;
		int num8 = num6 & num7;
		bool flag4 = num8 < 0;
		bool flag5 = flag2 == flag4;
		object obj11 = !flag3;
		object obj12 = flag5 & obj11;
		object obj13 = ~obj12;
		int num9 = ((obj13 != null) ? 1 : config3.blurIterations);
		object obj14 = 153100288 + 1024;
		object obj15 = 0;
		Vector4 vector = (Vector4)(&renderTextureDescriptor2);
		int num10 = (int)textureHandle;
		TextureHandle textureHandle3 = (TextureHandle)0;
		TextureHandle textureHandle4 = activeColorTexture;
		object obj16 = 0;
		BlurRenderPass blurRenderPass = this;
		object obj17 = 0;
		object arg = default(object);
		object arg2 = default(object);
		bool flag6;
		do
		{
			BlurOptimized config4 = blurRenderPass._config;
			double num11 = num5 * (double)config4.blurSize;
			double num12 = num11 + (double)obj17;
			double num13 = (double)config4.blurSize * num5;
			object obj18 = 0.0 - num13;
			object obj19 = obj18 - obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format = "AvailableVoices" + 2352;
			string passLabel = string.Format((string)format, arg);
			object obj20 = obj9 | 1;
			blurRenderPass.ScheduleBlit(renderGraph, passLabel, textureHandle, (TextureHandle)(&renderTextureDescriptor2), (int)textureHandle2, (Vector4)(&renderTextureDescriptor2));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format2 = "AvailableVoices" + 2344;
			string text2 = string.Format((string)format2, arg2);
			obj15 = obj9 + 2;
			ScheduleBlit(renderGraph, text2, textureHandle2, (TextureHandle)(&renderTextureDescriptor2), (int)textureHandle, (Vector4)(&renderTextureDescriptor2));
			obj17++;
			flag6 = num9 != (nint)obj17;
			vector = (Vector4)(&renderTextureDescriptor2);
			num10 = (int)textureHandle;
			textureHandle3 = (TextureHandle)(&renderTextureDescriptor2);
			textureHandle4 = textureHandle2;
			text = text2;
			obj16 = 0;
			blurRenderPass = this;
		}
		while (flag6);
		TextureHandle textureHandle5 = TryImportExternalTarget(renderGraph);
		object obj21 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 744;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X0_v31+E4]");
		bool flag7 = (nint)0 == 0;
		object obj23 = !flag7;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj24 = 146685952;
		object obj25 = typeof(RegisteredWaitHandle) + 920;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D4]");
		object obj26 = (nint)0 & (nint)1;
		if (obj26 != null)
		{
			object obj27 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X0_v53+E4]");
			if ((nint)0 != 0)
			{
				goto IL_04b5;
			}
		}
		else
		{
			_ = 1;
			object obj27 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X0_v53+E4]");
			bool flag8 = (nint)0 == 0;
			object obj28 = !flag8;
			if (obj28 != null)
			{
				goto IL_04b5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D5]");
		object obj29 = (nint)0 & (nint)1;
		bool flag9 = obj29 == null;
		object obj30 = !flag9;
		if (obj30 != null)
		{
			goto IL_04e8;
		}
		goto IL_05ad;
		IL_04b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D5]");
		object obj31 = (nint)0 & (nint)1;
		if (obj31 != null)
		{
			goto IL_04e8;
		}
		goto IL_05ad;
		IL_0681:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X0_v45+E4]");
		object obj33;
		if ((nint)0 != 0)
		{
			object obj32 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X8_v42+4]");
			if (obj32 != null)
			{
				goto IL_07f4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj34 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ X8_v43+B8]");
			object obj35 = 0;
			object obj36 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ X8_v44+4]");
			if (obj36 != null)
			{
				goto IL_07f4;
			}
		}
		goto IL_09a3;
		IL_04e8:
		obj33 = textureHandle5 & 0xFFFF0000L;
		bool flag10 = obj33 == null;
		object obj37 = !flag10;
		if (obj37 != null)
		{
			goto IL_05e2;
		}
		goto IL_07f4;
		IL_05e2:
		object obj38 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X0_v45+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X0_v45+B8]");
			object obj39 = 0;
			if (obj33 != obj39)
			{
				goto IL_0681;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj38 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X0_v45+B8]");
			object obj39 = 0;
			if (obj33 != obj39)
			{
				goto IL_0681;
			}
		}
		goto IL_09a3;
		IL_05ad:
		_ = 1;
		obj33 = textureHandle5 & 0xFFFF0000L;
		if (obj33 != null)
		{
			goto IL_05e2;
		}
		goto IL_07f4;
		IL_09a3:
		BlurOptimized config5 = _config;
		if ((object)_config != null)
		{
			object obj40 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3104;
			object obj41 = obj40;
			nint num14 = (nint)config5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X10_v6 (Il2CppClass<UnityStandardAssets.ImageEffects.BlurOptimized>)+130]");
			nint num15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X9_v11+130]");
			bool flag11 = num15 < 0;
			object obj42 = !flag11;
			object obj43 = ~obj42;
			if (obj43 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X10_v6 (Il2CppClass<UnityStandardAssets.ImageEffects.BlurOptimized>)+C8]");
				nint num16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X9_v11+130]");
				object obj44 = num16 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X10_v8-8]");
				if (0 == (nint)obj41)
				{
					object passLabel2 = "AvailableVoices" + 2328;
					ScheduleBlit(renderGraph, (string)passLabel2, textureHandle, (TextureHandle)(&renderTextureDescriptor2), (int)textureHandle5, (Vector4)renderGraph);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ X8_v36 (UnityStandardAssets.ImageEffects.BlurOptimized)+48]");
					object obj45 = (nint)0 & (nint)1;
					if (obj45 != null)
					{
						return;
					}
					goto IL_07f4;
				}
			}
		}
		object passLabel3 = "AvailableVoices" + 2328;
		ScheduleBlit(renderGraph, (string)passLabel3, textureHandle, (TextureHandle)(&renderTextureDescriptor2), (int)textureHandle5, (Vector4)renderGraph);
		goto IL_07f4;
		IL_07f4:
		object passLabel4 = "AvailableVoices" + 2320;
		ScheduleBlit(renderGraph, (string)passLabel4, textureHandle, (TextureHandle)(&renderTextureDescriptor2), (int)activeColorTexture, (Vector4)0);
	}

	private TextureHandle TryImportExternalTarget(RenderGraph renderGraph)
	{
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected O, but got Unknown
		//IL_0184: Expected O, but got I
		//IL_019e: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0029: Expected I, but got O
		//IL_0052: Expected O, but got I4
		//IL_00fd: Expected O, but got I
		//IL_0214: Expected O, but got I
		//IL_01dc: Expected O, but got I4
		//IL_008e: Expected O, but got I
		//IL_015f: Expected O, but got I
		//IL_0240: Expected O, but got I
		//IL_0280: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 744;
		BlurOptimized config = _config;
		bool flag = (object)_config == null;
		RenderGraph renderGraph2 = renderGraph;
		if (!flag)
		{
			object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3104;
			object obj3 = obj2;
			nint num = (nint)config;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X10_v2 (Il2CppClass<UnityStandardAssets.ImageEffects.BlurOptimized>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X9_v4+130]");
			bool flag2 = num2 < 0;
			object obj4 = !flag2;
			object obj5 = ~obj4;
			renderGraph2 = renderGraph;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X10_v2 (Il2CppClass<UnityStandardAssets.ImageEffects.BlurOptimized>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X9_v4+130]");
				object obj6 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X10_v4-8]");
				bool flag3 = 0 == (nint)obj3;
				renderGraph2 = renderGraph;
				if (flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3 (UnityStandardAssets.ImageEffects.BlurOptimized)+40]");
					bool flag4 = (nint)0 == 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3 (UnityStandardAssets.ImageEffects.BlurOptimized)+40]");
					renderGraph2 = (RenderGraph)0;
					if (!flag4)
					{
						if (renderGraph != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3 (UnityStandardAssets.ImageEffects.BlurOptimized)+40]");
							return renderGraph.ImportTexture((RTHandle)0);
						}
						return (TextureHandle)new NullReferenceException();
					}
				}
			}
		}
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D6]");
			object obj8 = (nint)0 & (nint)1;
			if (obj8 != null)
			{
				goto IL_011a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D6]");
			object obj9 = (nint)0 & (nint)1;
			bool flag5 = obj9 == null;
			object obj10 = !flag5;
			if (obj10 != null)
			{
				goto IL_011a;
			}
		}
		_ = 1;
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v13+E4]");
		bool flag6 = (nint)0 == 0;
		object obj12 = !flag6;
		object obj13 = obj11;
		if (obj12 != null)
		{
			goto IL_014f;
		}
		goto IL_01f2;
		IL_011a:
		obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v13+E4]");
		bool flag7 = (nint)0 == 0;
		obj13 = obj11;
		if (!flag7)
		{
			goto IL_014f;
		}
		goto IL_01f2;
		IL_01f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v5+B8]");
		return (TextureHandle)0;
		IL_014f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v13+B8]");
		return (TextureHandle)0;
	}

	private bool IsExternalOnly()
	{
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected I4, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0029: Expected I, but got O
		//IL_0052: Expected O, but got I4
		//IL_0087: Expected O, but got I
		BlurOptimized blurOptimized = _config;
		if ((object)_config != null)
		{
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3104;
			object obj2 = obj;
			nint num = (nint)blurOptimized;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X10_v2 (Il2CppClass<UnityStandardAssets.ImageEffects.BlurOptimized>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X9_v4+130]");
			bool flag = num2 < 0;
			object obj3 = !flag;
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X10_v2 (Il2CppClass<UnityStandardAssets.ImageEffects.BlurOptimized>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X9_v4+130]");
				object obj4 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X10_v4-8]");
				if (0 != (nint)obj2)
				{
					return false;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v4 (UnityStandardAssets.ImageEffects.BlurOptimized)+48]");
				return (byte)((nuint)0u & (nuint)1u) != 0;
			}
			blurOptimized = null;
		}
		return (byte)(blurOptimized & 1) != 0;
	}

	private unsafe void ScheduleBlit(RenderGraph renderGraph, string passLabel, TextureHandle source, TextureHandle destination, int passIndex, Vector4 parameter)
	{
		//IL_06c0: Expected I, but got O
		//IL_06c5: Expected I, but got O
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0030: Expected O, but got I
		//IL_0040: Expected I4, but got O
		//IL_0063: Expected O, but got I4
		//IL_006c: Expected O, but got I4
		//IL_007c: Expected O, but got Ref
		//IL_00aa: Expected O, but got I
		//IL_00d7: Expected O, but got I4
		//IL_00e0: Expected O, but got I4
		//IL_00e8: Expected O, but got Ref
		//IL_071f: Expected O, but got I4
		//IL_0728: Expected O, but got I4
		//IL_0730: Expected O, but got Ref
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_0162: Expected O, but got I
		//IL_0172: Expected O, but got I
		//IL_0a12: Expected O, but got I4
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Expected O, but got Unknown
		//IL_05d1: Expected O, but got I
		//IL_05e1: Expected O, but got I
		//IL_0837: Expected I, but got O
		//IL_0847: Expected O, but got I
		//IL_01ad: Expected O, but got I
		//IL_0750: Expected O, but got I4
		//IL_0759: Expected O, but got I4
		//IL_0761: Expected O, but got Ref
		//IL_076a: Expected O, but got I4
		//IL_0a54: Expected O, but got I
		//IL_061c: Expected O, but got I
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_0259: Expected O, but got I
		//IL_0269: Expected O, but got I
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01d6: Expected O, but got I
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Expected O, but got Unknown
		//IL_08bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c1: Expected O, but got Unknown
		//IL_08c9: Expected I, but got O
		//IL_02a4: Expected O, but got I
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Expected O, but got Unknown
		//IL_0645: Expected O, but got I
		//IL_03cc: Expected I, but got O
		//IL_03ec: Expected O, but got I
		//IL_040e: Expected O, but got I4
		//IL_0416: Expected O, but got I4
		//IL_0427: Expected O, but got I4
		//IL_0354: Expected O, but got I
		//IL_0376: Expected O, but got I4
		//IL_037e: Expected O, but got I4
		//IL_038f: Expected O, but got I4
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_078a: Expected O, but got I4
		//IL_0793: Expected O, but got I4
		//IL_0455: Expected O, but got I
		//IL_0477: Expected O, but got I4
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_02cd: Expected O, but got I
		//IL_04bd: Expected O, but got I
		//IL_04c5: Expected I, but got O
		//IL_04cd: Expected O, but got I
		//IL_04dd: Expected O, but got I
		//IL_0906: Unknown result type (might be due to invalid IL or missing references)
		//IL_090b: Expected O, but got Unknown
		//IL_0921: Expected O, but got I
		//IL_0933: Expected I, but got O
		//IL_0933: Expected O, but got I4
		//IL_093b: Expected I, but got O
		//IL_0951: Expected O, but got I
		//IL_097c: Expected O, but got I4
		//IL_09d1: Expected O, but got I4
		//IL_09da: Expected O, but got I4
		//IL_09f3: Expected O, but got I4
		//IL_0518: Expected O, but got I
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Expected O, but got Unknown
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected O, but got Unknown
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected O, but got Unknown
		//IL_0541: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E73BF]");
		nint num = 0;
		RenderGraph renderGraph2 = default(RenderGraph);
		nint num3 = default(nint);
		nint num4 = default(nint);
		object obj10 = default(object);
		BlurRenderPass blurRenderPass;
		int num2;
		nint num5;
		TextureHandle textureHandle;
		object obj2;
		object obj8;
		NullReferenceException ex;
		TextureHandle textureHandle3;
		object obj3;
		TextureHandle textureHandle2;
		string text = default(string);
		if (renderGraph2 != null)
		{
			object obj = ", stale={0}" + 3024;
			obj2 = (nint)0 + (nint)3264;
			textureHandle = (TextureHandle)obj;
			num2 = (int)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEFD8C");
			bool flag = num3 == 0;
			obj3 = 0;
			textureHandle2 = (TextureHandle)181;
			renderGraph2 = (RenderGraph)(object)text;
			text = (string)(&num3);
			num = (nint)(&num4);
			if (!flag)
			{
				renderGraph2 = (RenderGraph)(object)_material;
				object obj4 = num3 + 16;
				obj4 = _material;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag2 = num3 == 0;
				obj3 = 0;
				textureHandle2 = (TextureHandle)181;
				text = (string)(&num3);
				num = num3;
				blurRenderPass = this;
				IntPtr intPtr = default(IntPtr);
				num5 = intPtr;
				if (flag2)
				{
					goto IL_06f6;
				}
				if (num4 != 0)
				{
					object obj5 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1184;
					object obj6 = num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v20+12E]");
					obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v20+12E]");
					if ((nint)0 == 0)
					{
						goto IL_01fe;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v20+B0]");
					object obj7 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X10_v27-8]");
						if (0 == (nint)obj5)
						{
							break;
						}
						obj8 = obj7 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v20+12E]");
						obj2 = -1;
						bool flag3 = (nint)obj2 != 1;
						obj7 = obj8;
						if (flag3)
						{
							continue;
						}
						goto IL_01fe;
					}
					obj2 = obj7;
					object obj9 = obj6 + obj7;
					obj10 = obj9 + 312;
					obj8 = obj7;
					goto IL_082f;
				}
				ex = new NullReferenceException();
				textureHandle3 = source;
				obj3 = 0;
				textureHandle2 = (TextureHandle)181;
				text = (string)(&num3);
				goto IL_079e;
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			num4 = unchecked((nint)null);
			num3 = unchecked((nint)null);
			num2 = passIndex;
			textureHandle = source;
		}
		ex = new NullReferenceException();
		goto IL_079e;
		IL_0494:
		if (num4 != 0)
		{
			object obj11 = (nint)0 + (nint)1504;
			num5 = (nint)obj11;
			object obj12 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X8_v32+12E]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X8_v32+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0569;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X8_v32+B0]");
			object obj13 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X10_v17-8]");
				if ((nint)0 == 0)
				{
					break;
				}
				obj8 = obj13 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X8_v32+12E]");
				obj2 = -1;
				bool flag4 = (nint)obj2 != 1;
				obj13 = obj8;
				if (flag4)
				{
					continue;
				}
				goto IL_0569;
			}
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X21_v2 (Il2CppMethodInfo)+50]");
			obj2 = obj14 + 0;
			object obj15 = obj12 + obj2;
			object obj16 = obj15 + 312;
			obj8 = obj13;
			goto IL_09ab;
		}
		ex = new NullReferenceException();
		textureHandle3 = source;
		obj3 = 0;
		textureHandle2 = (TextureHandle)2;
		goto IL_079e;
		IL_066d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		text = null;
		goto IL_0a44;
		IL_0445:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X0_v50 (Il2CppClass<BlurRenderPass>)+E4]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X0_v50 (Il2CppClass<BlurRenderPass>)+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		num5 = ParameterId;
		object obj18 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 1960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj19 = (nint)0 + (nint)1784;
		BaseRenderFunc<object, RasterGraphContext> baseRenderFunc = default(BaseRenderFunc<object, RasterGraphContext>);
		baseRenderFunc..ctor((object)ParameterId, (IntPtr)obj19);
		num = (nint)blurRenderPass;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v4 (Il2CppClass<BlurRenderPass>)+B8]");
		object obj20 = (nint)0 + (nint)8;
		obj20 = baseRenderFunc;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		renderGraph2 = (RenderGraph)(object)baseRenderFunc;
		text = (string)obj19;
		textureHandle = (TextureHandle)0;
		RenderGraph renderGraph3 = (RenderGraph)(object)baseRenderFunc;
		goto IL_0494;
		IL_09ab:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1950");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v722 @ X0_v44 (System.String)+8] (should have been resolved before IL gen)");
		textureHandle3 = source;
		obj3 = 0;
		textureHandle2 = (TextureHandle)2;
		renderGraph2 = renderGraph3;
		string text2 = default(string);
		text = text2;
		object obj21 = 0;
		goto IL_0a86;
		IL_079e:
		if ((nint)renderGraph2 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			object obj22 = default(object);
			obj21 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj3 = obj22;
			goto IL_0a86;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0893:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X0_v36+8]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v599 @ X0_v36] (should have been resolved before IL gen)");
		blurRenderPass = (BlurRenderPass)(typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3256);
		nint num6 = (nint)blurRenderPass;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X0_v39 (Il2CppClass<BlurRenderPass>)+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X0_v39 (Il2CppClass<BlurRenderPass>)+B8]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v46 (Il2CppStaticFields<BlurRenderPass>)+8]");
			renderGraph3 = (RenderGraph)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v46 (Il2CppStaticFields<BlurRenderPass>)+8]");
			bool flag6 = (nint)0 == 0;
			object obj23 = !flag6;
			renderGraph2 = (RenderGraph)passIndex;
			text = (string)parameter;
			textureHandle = (TextureHandle)0;
			num = num7;
			num5 = num4;
			if (obj23 == null)
			{
				nint num8 = num6;
				goto IL_0445;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			nint num8 = (nint)blurRenderPass;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X0_v50 (Il2CppClass<BlurRenderPass>)+B8]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X8_v45 (Il2CppStaticFields<BlurRenderPass>)+8]");
			renderGraph3 = (RenderGraph)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X8_v45 (Il2CppStaticFields<BlurRenderPass>)+8]");
			bool flag7 = (nint)0 == 0;
			object obj24 = !flag7;
			renderGraph2 = (RenderGraph)passIndex;
			text = (string)parameter;
			textureHandle = (TextureHandle)0;
			num = num9;
			num5 = num4;
			if (obj24 == null)
			{
				goto IL_0445;
			}
		}
		goto IL_0494;
		IL_02f5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0893;
		IL_0a86:
		if (0 == 0)
		{
			goto IL_09f8;
		}
		object obj25 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		object obj26 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v7+12E]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v7+12E]");
		if ((nint)0 == 0)
		{
			goto IL_066d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v7+B0]");
		object obj27 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X10_v7-8]");
			if (0 == (nint)obj25)
			{
				break;
			}
			obj8 = obj27 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v7+12E]");
			obj2 = -1;
			bool flag8 = (nint)obj2 != 1;
			obj27 = obj8;
			if (flag8)
			{
				continue;
			}
			goto IL_066d;
		}
		obj2 = obj27;
		object obj28 = obj26 + obj27;
		object obj29 = obj28 + 312;
		obj8 = obj27;
		goto IL_0a44;
		IL_0569:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_09ab;
		IL_0a44:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X0_v6+8]");
		renderGraph2 = (RenderGraph)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v615 @ X0_v6] (should have been resolved before IL gen)");
		goto IL_09f8;
		IL_06f6:
		ex = new NullReferenceException();
		goto IL_079e;
		IL_01fe:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_082f;
		IL_082f:
		num = (nint)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v32+8]");
		textureHandle = (TextureHandle)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v366 @ X0_v32] (should have been resolved before IL gen)");
		if (num4 != 0)
		{
			object obj30 = typeof(System.IOAsyncCallback) + 728;
			object obj31 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v25+12E]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v25+12E]");
			if ((nint)0 == 0)
			{
				goto IL_02f5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v25+B0]");
			object obj32 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X10_v22-8]");
				if (0 == (nint)obj30)
				{
					break;
				}
				obj8 = obj32 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v25+12E]");
				obj2 = -1;
				bool flag9 = (nint)obj2 != 1;
				obj32 = obj8;
				if (flag9)
				{
					continue;
				}
				goto IL_02f5;
			}
			obj2 = obj32;
			object obj33 = obj31 + obj32;
			object obj34 = obj33 + 312;
			obj8 = obj32;
			goto IL_0893;
		}
		ex = new NullReferenceException();
		textureHandle3 = source;
		obj3 = 0;
		textureHandle2 = (TextureHandle)181;
		TextureHandle textureHandle4 = default(TextureHandle);
		renderGraph2 = (RenderGraph)(&textureHandle4);
		text = (string)1;
		goto IL_079e;
		IL_09f8:
		bool flag10 = obj21 == null;
		object obj35 = !flag10;
		if (obj35 == null)
		{
			return;
		}
		OutOfMemoryException ex3 = new OutOfMemoryException();
		goto IL_06f6;
	}

	static BlurRenderPass()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_0055: Expected O, but got I4
		object name = "_InputUv1BufferOffset" + 1304;
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3136;
		int num = Shader.PropertyToID((string)name);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
		object obj3 = 0;
		obj3 = num;
	}
}
