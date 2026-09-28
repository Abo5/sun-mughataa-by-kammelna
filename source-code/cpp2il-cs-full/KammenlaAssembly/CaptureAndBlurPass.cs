using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.Rendering.Universal;
using UnityEngine.TextCore;

internal class CaptureAndBlurPass : ScriptableRenderPass
{
	private class BlitPassData
	{
		public Material Material;

		public int PassIndex;

		public Vector4 Parameter;

		public TextureHandle Source;
	}

	private class BlockerDrawData
	{
		public RendererListHandle RendererList;
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static BaseRenderFunc<BlockerDrawData, RasterGraphContext> <>9__14_0;

		public static BaseRenderFunc<BlitPassData, RasterGraphContext> <>9__15_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3824;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal unsafe void <ScheduleNoBlurLayerDraw>b__14_0(BlockerDrawData passData, RasterGraphContext context)
		{
			//IL_0024: Expected O, but got Ref
			//IL_0024: Expected O, but got I
			RendererList rendererList = passData.RendererList;
			IntPtr intPtr = default(IntPtr);
			object obj = default(object);
			((RasterCommandBuffer)(nint)intPtr).DrawRendererList((RendererList)(&obj));
		}

		internal void <ScheduleBlit>b__15_0(BlitPassData passData, RasterGraphContext context)
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
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 280;
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

	private const int VerticalPassIndex = 1;

	private const int HorizontalPassIndex = 2;

	private static readonly int ParameterId;

	private readonly Material _material;

	private readonly CaptureAndBlurFeature.Settings _settings;

	private RTHandle _backdropRT;

	private static readonly List<ShaderTagId> ForwardTransparentTags;

	private static readonly string NoBlurLayerName;

	public CaptureAndBlurPass(Material material, CaptureAndBlurFeature.Settings settings)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		object obj = this + 96;
		obj = material;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 104;
		obj2 = settings;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void Setup(RTHandle backdropRT)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 112;
		obj = backdropRT;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public unsafe override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0019: Expected O, but got I
		//IL_0025: Expected O, but got I
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_0147: Expected O, but got Ref
		//IL_0186: Expected O, but got I4
		//IL_01c3: Expected O, but got Ref
		//IL_01e8: Expected O, but got Ref
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_0249: Expected O, but got Ref
		//IL_0249: Expected I4, but got O
		//IL_0249: Expected O, but got I4
		//IL_0278: Expected O, but got I4
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected I4, but got Unknown
		//IL_02f0: Expected O, but got I4
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_0501: Expected O, but got I4
		//IL_0510: Expected O, but got I4
		//IL_0519: Expected O, but got I4
		//IL_0521: Expected O, but got Ref
		//IL_0529: Expected I4, but got O
		//IL_0532: Expected O, but got I4
		//IL_0543: Expected O, but got I4
		//IL_054c: Expected O, but got I4
		//IL_0374: Expected O, but got F8
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected O, but got Unknown
		//IL_03ce: Expected O, but got Ref
		//IL_03ce: Expected I4, but got O
		//IL_03ce: Expected O, but got Ref
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected O, but got Unknown
		//IL_03f6: Expected O, but got I4
		//IL_055c: Expected O, but got I4
		//IL_0435: Expected O, but got Ref
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected O, but got Unknown
		//IL_05b2: Expected I4, but got O
		//IL_05b2: Expected O, but got Ref
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Expected O, but got Unknown
		//IL_046f: Expected O, but got I4
		//IL_0478: Expected O, but got I4
		//IL_0488: Expected I4, but got O
		//IL_0490: Expected O, but got Ref
		//IL_04a1: Expected O, but got I4
		//IL_04ce: Expected O, but got I4
		object obj2 = default(object);
		object obj = (object)(&obj2);
		if (_backdropRT != null)
		{
			object obj3 = (nint)0 + (nint)2664;
			object obj4 = (nint)0 + (nint)2632;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @50E7FD0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @50E7FD0");
			UniversalResourceData universalResourceData = default(UniversalResourceData);
			TextureHandle activeColorTexture = universalResourceData.activeColorTexture;
			TextureHandle textureHandle = renderGraph.ImportTexture(_backdropRT);
			CaptureAndBlurFeature.Settings settings = _settings;
			object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3744;
			object name = "[{0}]:{1}" + 1616;
			object name2 = "[{0}]:{1}" + 1624;
			int num = ~settings.downsample;
			int num2 = settings.downsample & num;
			int num3 = num2 & 0x1F;
			object obj7 = default(object);
			object obj6 = obj7 + 248;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction SSHL not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction SMAX not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X22_v5+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X22_v5+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X22_v5+20]");
			_ = 0;
			RenderTextureDescriptor renderTextureDescriptor = (RenderTextureDescriptor)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 176));
			((RenderTextureDescriptor*)renderTextureDescriptor)->depthBufferBits = 0;
			_ = 1;
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			object obj9 = !flag;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj10 = default(object);
			TextureHandle textureHandle2 = UniversalRenderer.CreateRenderGraphTexture(renderGraph, (RenderTextureDescriptor)(&obj10), (string)name, clear: false, FilterMode.Bilinear);
			TextureHandle textureHandle3 = UniversalRenderer.CreateRenderGraphTexture(renderGraph, (RenderTextureDescriptor)(&obj10), (string)name2, clear: false, FilterMode.Bilinear);
			object obj11 = "AvailableVoices" + 2288;
			int num4 = 1 << num3;
			double num5 = 1.0 / (double)num4;
			string text = (string)obj11;
			ScheduleBlit(renderGraph, (string)obj11, activeColorTexture, (TextureHandle)0, (int)textureHandle2, (Vector4)(&obj10));
			CaptureAndBlurFeature.Settings settings2 = _settings;
			int num6 = settings2.blurIterations;
			object obj12 = settings2.blurIterations - 1;
			bool flag2 = (nint)obj12 < 0;
			bool flag3 = obj12 == null;
			int num7 = settings2.blurIterations ^ 1;
			int num8 = settings2.blurIterations ^ obj12;
			int num9 = num7 & num8;
			bool flag4 = num9 < 0;
			bool flag5 = flag2 == flag4;
			object obj13 = !flag3;
			object obj14 = flag5 & obj13;
			object obj15 = ~obj14;
			if (obj15 != null)
			{
				num6 = 1;
			}
			object obj16 = -num6;
			object obj17 = 153100288 + 1024;
			object obj18 = 0;
			Vector4 vector = (Vector4)(&obj10);
			int num10 = (int)textureHandle2;
			TextureHandle textureHandle4 = (TextureHandle)0;
			TextureHandle textureHandle5 = activeColorTexture;
			object obj19 = 0;
			object obj20 = 0;
			object arg = default(object);
			object arg2 = default(object);
			object obj28;
			do
			{
				CaptureAndBlurFeature.Settings settings3 = _settings;
				object obj21 = obj16 + obj20;
				double num11 = num5 * (double)settings3.blurSize;
				double num12 = num11 + (double)obj20;
				double num13 = (double)settings3.blurSize * num5;
				object obj22 = 0.0 - num13;
				object obj23 = obj22 - obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object format = "AvailableVoices" + 2304;
				string passLabel = string.Format((string)format, arg);
				ScheduleBlit(renderGraph, passLabel, textureHandle2, (TextureHandle)(&obj10), (int)textureHandle3, (Vector4)(&obj10));
				object obj24 = obj21 + 1;
				bool flag6 = obj24 == null;
				object obj25 = !flag6;
				TextureHandle textureHandle6 = ((obj25 != null) ? textureHandle2 : textureHandle);
				object obj26 = !flag6;
				RenderTextureDescriptor renderTextureDescriptor2 = (RenderTextureDescriptor)((obj26 != null) ? ((object)(RenderTextureDescriptor)(&obj10)) : ((object)_backdropRT));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object format2 = "AvailableVoices" + 2296;
				string text2 = string.Format((string)format2, arg2);
				ScheduleBlit(renderGraph, text2, textureHandle3, (TextureHandle)(&obj10), (int)textureHandle6, (Vector4)renderTextureDescriptor2);
				obj20++;
				object obj27 = obj16 + obj20;
				bool flag7 = obj27 == null;
				obj28 = !flag7;
				obj18 = 2;
				vector = (Vector4)renderTextureDescriptor2;
				num10 = (int)textureHandle6;
				textureHandle4 = (TextureHandle)(&obj10);
				textureHandle5 = textureHandle3;
				obj19 = 0;
				text = text2;
			}
			while (obj28 != null);
			ScheduleNoBlurLayerDraw(renderGraph, frameData, activeColorTexture, (TextureHandle)0);
		}
	}

	private unsafe void ScheduleNoBlurLayerDraw(RenderGraph renderGraph, ContextContainer frameData, TextureHandle cameraColor, TextureHandle backdrop)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0018: Expected O, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_1007: Expected I, but got O
		//IL_00ea: Expected I, but got O
		//IL_010b: Expected O, but got I
		//IL_0126: Expected I4, but got I8
		//IL_0140: Expected O, but got I4
		//IL_014f: Expected I, but got O
		//IL_0159: Expected O, but got I4
		//IL_0162: Expected O, but got I4
		//IL_016b: Expected O, but got I4
		//IL_0181: Expected O, but got I4
		//IL_0057: Expected O, but got I
		//IL_006d: Expected I4, but got I8
		//IL_0cb1: Expected O, but got I
		//IL_01b8: Expected I, but got O
		//IL_01c2: Expected O, but got I4
		//IL_01cb: Expected O, but got I4
		//IL_01d4: Expected O, but got I4
		//IL_01dd: Expected O, but got I4
		//IL_00a1: Expected I, but got O
		//IL_00ab: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_00bd: Expected O, but got I4
		//IL_00d3: Expected O, but got I4
		//IL_0207: Expected O, but got I
		//IL_0213: Expected O, but got I
		//IL_021f: Expected O, but got I
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_0281: Expected O, but got I4
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_02fa: Expected I4, but got I8
		//IL_0324: Expected O, but got I4
		//IL_103b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1040: Expected O, but got Unknown
		//IL_1050: Expected O, but got I
		//IL_107a: Expected O, but got I4
		//IL_0377: Expected O, but got I4
		//IL_0394: Expected I, but got O
		//IL_039e: Expected O, but got I4
		//IL_03a7: Expected O, but got I4
		//IL_03b0: Expected O, but got I4
		//IL_03b5: Expected I, but got O
		//IL_03be: Expected O, but got I4
		//IL_1375: Expected O, but got I4
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected O, but got Unknown
		//IL_0436: Expected O, but got I
		//IL_0460: Expected O, but got I4
		//IL_0ba4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba9: Expected O, but got Unknown
		//IL_0bb1: Expected I, but got O
		//IL_0bc1: Expected O, but got I
		//IL_04a5: Expected O, but got Ref
		//IL_0d47: Expected I, but got O
		//IL_0d51: Expected O, but got I4
		//IL_0d62: Expected O, but got I
		//IL_0d74: Expected O, but got I4
		//IL_0d85: Expected O, but got I4
		//IL_0d8a: Expected I, but got O
		//IL_0d92: Expected O, but got Ref
		//IL_0d9a: Expected O, but got Ref
		//IL_13bf: Expected O, but got I
		//IL_0bfc: Expected O, but got I
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected O, but got Unknown
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected O, but got Unknown
		//IL_04fd: Expected O, but got I
		//IL_0512: Expected O, but got I4
		//IL_051a: Expected I, but got O
		//IL_0c71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c76: Expected O, but got Unknown
		//IL_0c7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c84: Expected O, but got Unknown
		//IL_0dcb: Expected O, but got I4
		//IL_0dd7: Expected O, but got I4
		//IL_0de8: Expected O, but got I4
		//IL_0df1: Expected O, but got I4
		//IL_0df9: Expected O, but got Ref
		//IL_0c0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0f: Expected O, but got Unknown
		//IL_0c25: Expected O, but got I
		//IL_0e12: Expected O, but got I4
		//IL_0e1b: Expected O, but got Ref
		//IL_0e2e: Expected O, but got I4
		//IL_0e3f: Expected O, but got I4
		//IL_0e48: Expected O, but got I4
		//IL_0e50: Expected O, but got Ref
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected O, but got Unknown
		//IL_0599: Expected O, but got I
		//IL_05b8: Expected O, but got Ref
		//IL_10b5: Expected O, but got I
		//IL_10c5: Expected O, but got I
		//IL_05dc: Expected O, but got I
		//IL_0e7f: Expected O, but got I4
		//IL_0e8b: Expected O, but got I4
		//IL_0e9c: Expected O, but got I4
		//IL_0ea5: Expected O, but got I4
		//IL_0eae: Expected O, but got I4
		//IL_0eb7: Expected O, but got Ref
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Expected O, but got Unknown
		//IL_0680: Expected I, but got O
		//IL_0690: Expected O, but got I
		//IL_0652: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Expected I, but got Unknown
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Expected O, but got Unknown
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Expected O, but got Unknown
		//IL_1119: Expected I, but got O
		//IL_06cb: Expected O, but got I
		//IL_0ecf: Expected O, but got I4
		//IL_0edb: Expected O, but got I4
		//IL_0eec: Expected O, but got I4
		//IL_0ef5: Expected O, but got I4
		//IL_0efe: Expected O, but got I4
		//IL_0763: Expected I, but got O
		//IL_0773: Expected O, but got I
		//IL_073b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0740: Expected O, but got Unknown
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		//IL_074e: Expected O, but got Unknown
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06de: Expected O, but got Unknown
		//IL_06f4: Expected O, but got I
		//IL_117d: Expected I, but got O
		//IL_118d: Expected O, but got I
		//IL_07ae: Expected O, but got I
		//IL_0f27: Expected O, but got I4
		//IL_0f3b: Expected O, but got I4
		//IL_0f4c: Expected O, but got I4
		//IL_0f55: Expected O, but got I4
		//IL_0f5e: Expected O, but got I4
		//IL_0f67: Expected O, but got Ref
		//IL_084c: Expected I, but got O
		//IL_085c: Expected O, but got I
		//IL_0817: Unknown result type (might be due to invalid IL or missing references)
		//IL_081c: Expected O, but got Unknown
		//IL_0824: Unknown result type (might be due to invalid IL or missing references)
		//IL_0829: Expected O, but got Unknown
		//IL_0832: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Expected O, but got Unknown
		//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c1: Expected O, but got Unknown
		//IL_07d7: Expected O, but got I
		//IL_11e9: Expected O, but got I
		//IL_1202: Unknown result type (might be due to invalid IL or missing references)
		//IL_1207: Expected O, but got Unknown
		//IL_120f: Expected I, but got O
		//IL_0897: Expected O, but got I
		//IL_09ba: Expected I, but got O
		//IL_09da: Expected O, but got I
		//IL_09fc: Expected O, but got I4
		//IL_0a05: Expected O, but got I4
		//IL_094d: Expected O, but got I
		//IL_096f: Expected O, but got I4
		//IL_0978: Expected O, but got I4
		//IL_0900: Unknown result type (might be due to invalid IL or missing references)
		//IL_0905: Expected O, but got Unknown
		//IL_090d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0912: Expected O, but got Unknown
		//IL_091b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0920: Expected O, but got Unknown
		//IL_0f7f: Expected O, but got I4
		//IL_0f8b: Expected O, but got I4
		//IL_0f9c: Expected O, but got I4
		//IL_0fa5: Expected O, but got I4
		//IL_0a38: Expected O, but got I
		//IL_0a5a: Expected O, but got I4
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08aa: Expected O, but got Unknown
		//IL_08c0: Expected O, but got I
		//IL_0aa0: Expected O, but got I
		//IL_0ab0: Expected I, but got O
		//IL_0ac0: Expected O, but got I
		//IL_123d: Expected O, but got I4
		//IL_124c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1251: Expected O, but got Unknown
		//IL_1267: Expected O, but got I
		//IL_1279: Expected I, but got O
		//IL_1279: Expected O, but got I4
		//IL_1281: Expected I, but got O
		//IL_1297: Expected O, but got I
		//IL_12b2: Expected O, but got I4
		//IL_1316: Expected O, but got I4
		//IL_1322: Expected O, but got I4
		//IL_1333: Expected O, but got I4
		//IL_133c: Expected O, but got I4
		//IL_1356: Expected O, but got I4
		//IL_0afb: Expected O, but got I
		//IL_0b75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7a: Expected O, but got Unknown
		//IL_0b83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b88: Expected O, but got Unknown
		//IL_0b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0e: Expected O, but got Unknown
		//IL_0b24: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj3 = 0;
		UniversalCameraData universalCameraData = (UniversalCameraData)(typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 280);
		nint num = (nint)universalCameraData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v2 (Il2CppClass<UnityEngine.Rendering.Universal.UniversalCameraData>)+E4]");
		int num3;
		UniversalRenderingData universalRenderingData;
		RenderGraph renderGraph2;
		nint num6;
		RendererListHandle rendererListHandle;
		UniversalRenderingData universalRenderingData2;
		DrawingSettings drawingSettings;
		FilteringSettings filteringSettings;
		nint num5;
		ContextContainer contextContainer;
		RenderGraph renderGraph3;
		ContextContainer contextContainer2 = default(ContextContainer);
		RendererListParams rendererListParams;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v2 (Il2CppClass<UnityEngine.Rendering.Universal.UniversalCameraData>)+B8]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v77 (Il2CppStaticFields<UnityEngine.Rendering.Universal.UniversalCameraData>)+10]");
			num3 = LayerMask.NameToLayer((string)0);
			int num4 = (int)(num3 & 0x80000000L);
			bool flag = num4 == 0;
			universalRenderingData = null;
			num5 = num2;
			if (flag)
			{
				goto IL_019f;
			}
			renderGraph2 = null;
			num6 = unchecked((nint)null);
			rendererListHandle = (RendererListHandle)0;
			rendererListParams = (RendererListParams)0;
			filteringSettings = (FilteringSettings)0;
			universalRenderingData2 = null;
			int num7 = num3;
			drawingSettings = (DrawingSettings)152989696;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			nint num8 = (nint)universalCameraData;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v108 (Il2CppClass<UnityEngine.Rendering.Universal.UniversalCameraData>)+B8]");
			num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v17 (Il2CppStaticFields<UnityEngine.Rendering.Universal.UniversalCameraData>)+10]");
			num3 = LayerMask.NameToLayer((string)0);
			int num9 = (int)(num3 & 0x80000000L);
			bool flag2 = num9 == 0;
			object obj4 = !flag2;
			universalRenderingData = null;
			renderGraph2 = null;
			num6 = unchecked((nint)null);
			rendererListHandle = (RendererListHandle)0;
			rendererListParams = (RendererListParams)0;
			filteringSettings = (FilteringSettings)0;
			universalRenderingData2 = null;
			int num7 = num3;
			drawingSettings = (DrawingSettings)152989696;
			renderGraph3 = renderGraph;
			contextContainer = contextContainer2;
			if (obj4 == null)
			{
				goto IL_019f;
			}
		}
		goto IL_0c91;
		IL_13dd:
		if (renderGraph2 == null)
		{
			goto IL_135b;
		}
		object obj5 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		nint num10 = (nint)renderGraph2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v838 @ X8_v11 (Il2CppClass<UnityEngine.Rendering.RenderGraphModule.RenderGraph>)+12E]");
		RendererListHandle rendererListHandle2 = (RendererListHandle)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v838 @ X8_v11 (Il2CppClass<UnityEngine.Rendering.RenderGraphModule.RenderGraph>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0c4d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v838 @ X8_v11 (Il2CppClass<UnityEngine.Rendering.RenderGraphModule.RenderGraph>)+B0]");
		object obj6 = (nint)0 + (nint)8;
		object obj7;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ X10_v7-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj7 = obj6 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v838 @ X8_v11 (Il2CppClass<UnityEngine.Rendering.RenderGraphModule.RenderGraph>)+12E]");
			rendererListHandle2 = (RendererListHandle)(-1);
			bool flag3 = (nint)rendererListHandle2 != 1;
			obj6 = obj7;
			if (flag3)
			{
				continue;
			}
			goto IL_0c4d;
		}
		rendererListHandle2 = (RendererListHandle)obj6;
		object obj8 = num10 + obj6;
		object obj9 = obj8 + 312;
		obj7 = obj6;
		goto IL_13af;
		IL_0b4c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_12f8;
		IL_019f:
		bool flag4 = contextContainer2 == null;
		renderGraph2 = null;
		num6 = unchecked((nint)null);
		rendererListHandle = (RendererListHandle)0;
		rendererListParams = (RendererListParams)0;
		filteringSettings = (FilteringSettings)0;
		UniversalRenderingData universalRenderingData3 = (UniversalRenderingData)152989696;
		renderGraph3 = renderGraph;
		contextContainer = contextContainer2;
		if (flag4)
		{
			goto IL_0d00;
		}
		object obj10 = (nint)0 + (nint)2656;
		object obj11 = (nint)0 + (nint)2632;
		object obj12 = (nint)0 + (nint)2640;
		object obj13 = typeof(RegisteredWaitHandle) + 384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @50E7FD0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @50E7FD0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @50E7FD0");
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X0_v34+E4]");
		bool flag5 = (nint)0 == 0;
		object obj15 = !flag5;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RenderQueueRange transparent = RenderQueueRange.transparent;
		RenderQueueRange? renderQueueRange = transparent;
		object obj16 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 280;
		uint renderingLayerMask = (uint)(1 << num3);
		filteringSettings = new FilteringSettings(renderQueueRange, 0, renderingLayerMask, -1);
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X0_v41+E4]");
		bool flag6 = (nint)0 == 0;
		object obj18 = !flag6;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj16;
		}
		object obj19 = typeof(RegisteredWaitHandle) + 568;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X0_v41+B8]");
		rendererListHandle2 = (RendererListHandle)0;
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X0_v42+E4]");
		bool flag7 = (nint)0 == 0;
		object obj21 = !flag7;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UniversalRenderingData universalRenderingData4 = default(UniversalRenderingData);
		UniversalCameraData universalCameraData2 = default(UniversalCameraData);
		ContextContainer contextContainer3 = default(ContextContainer);
		DrawingSettings drawingSettings2 = RenderingUtils.CreateDrawingSettings((List<ShaderTagId>)rendererListHandle2.<handle>k__BackingField, universalRenderingData4, universalCameraData2, (UniversalLightData)(object)contextContainer3, SortingCriteria.CommonTransparent);
		bool flag8 = universalRenderingData4 == null;
		renderGraph2 = null;
		num6 = unchecked((nint)null);
		rendererListHandle = (RendererListHandle)0;
		rendererListParams = (RendererListParams)0;
		object obj22 = 0;
		nint num11 = unchecked((nint)null);
		TextureHandle textureHandle = (TextureHandle)23;
		TextureHandle textureHandle2 = (TextureHandle)contextContainer3;
		contextContainer2 = (ContextContainer)(object)universalCameraData2;
		universalRenderingData = universalRenderingData4;
		universalRenderingData3 = universalRenderingData4;
		object obj23 = default(object);
		nint num12 = (nint)(&obj23);
		renderGraph3 = renderGraph;
		contextContainer = contextContainer3;
		if (flag8)
		{
			goto IL_0d1e;
		}
		object obj24 = typeof(RegisteredWaitHandle) + 536;
		contextContainer = (ContextContainer)universalRenderingData4.cullResults;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v29 (UnityEngine.Rendering.Universal.UniversalRenderingData)+18]");
		drawingSettings = (DrawingSettings)0;
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X0_v46+E4]");
		bool flag9 = (nint)0 == 0;
		object obj26 = !flag9;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		nint num13 = (nint)(&obj23);
		object obj27 = default(object);
		RendererListParams desc = new RendererListParams((CullingResults)contextContainer, drawingSettings, (FilteringSettings)(&obj27));
		RendererListHandle rendererListHandle3;
		RendererListParams rendererListParams2;
		NullReferenceException ex;
		if (renderGraph != null)
		{
			rendererListHandle3 = renderGraph.CreateRendererList(ref desc);
			object obj28 = "DNQUALIFIER" + 4064;
			rendererListHandle2 = (RendererListHandle)(", stale={0}" + 3032);
			obj7 = (nint)0 + (nint)3280;
			universalRenderingData = (UniversalRenderingData)obj28;
			textureHandle2 = (TextureHandle)rendererListHandle2.type;
			num11 = (nint)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEFD8C");
			if (num6 != 0)
			{
				_ = ref desc;
				object obj29 = default(object);
				if (obj29 != null)
				{
					contextContainer = (ContextContainer)(typeof(UnityEngine.TextCore.HorizontalAlignment) + 1184);
					object obj30 = obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v966 @ X8_v38+12E]");
					object obj31 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v966 @ X8_v38+12E]");
					bool flag10 = (nint)0 == 0;
					obj7 = (object)(&desc);
					if (flag10)
					{
						goto IL_0625;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v966 @ X8_v38+B0]");
					object obj32 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1008 @ X10_v44-8]");
						if (0 == (nint)contextContainer)
						{
							break;
						}
						obj7 = obj32 + 16;
						obj31--;
						bool flag11 = (nint)obj31 != 1;
						obj32 = obj7;
						if (flag11)
						{
							continue;
						}
						goto IL_0625;
					}
					object obj33 = obj30 + obj32;
					num12 = (nint)(obj33 + 312);
					obj7 = obj32;
					goto IL_10ad;
				}
				ex = new NullReferenceException();
				obj23 = 0;
				obj7 = (object)(&desc);
				rendererListHandle2 = rendererListHandle3;
				rendererListParams2 = (RendererListParams)0;
				rendererListParams = (RendererListParams)filteringSettings;
				obj22 = 0;
				textureHandle = (TextureHandle)240;
				contextContainer2 = (ContextContainer)(&num6);
			}
			else
			{
				ex = new NullReferenceException();
				obj23 = 0;
				rendererListParams2 = (RendererListParams)0;
				rendererListParams = (RendererListParams)filteringSettings;
				obj22 = 0;
				textureHandle = (TextureHandle)240;
				contextContainer2 = (ContextContainer)(&num6);
			}
		}
		else
		{
			ex = new NullReferenceException();
			renderGraph2 = null;
			num6 = unchecked((nint)null);
			rendererListHandle = (RendererListHandle)0;
			RendererListParams rendererListParams3 = (RendererListParams)filteringSettings;
			obj27 = num13;
			RendererListHandle rendererListHandle4 = default(RendererListHandle);
			rendererListHandle2 = rendererListHandle4;
			rendererListParams2 = (RendererListParams)0;
			rendererListParams = (RendererListParams)filteringSettings;
			obj22 = 0;
			num11 = unchecked((nint)null);
			textureHandle = (TextureHandle)(&rendererListParams3);
			textureHandle2 = (TextureHandle)(&obj27);
			contextContainer2 = (ContextContainer)drawingSettings;
			universalRenderingData = (UniversalRenderingData)(object)contextContainer;
			num12 = (nint)(&obj23);
		}
		goto IL_0fb1;
		IL_10ad:
		rendererListHandle2 = (RendererListHandle)num12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v8 (Il2CppClass<UnityEngine.Rendering.ContextContainer>)+8]");
		textureHandle2 = (TextureHandle)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v268 @ X8_v8 (Il2CppClass<UnityEngine.Rendering.ContextContainer>)] (should have been resolved before IL gen)");
		object obj37 = default(object);
		if (renderGraph2 != null)
		{
			object obj34 = typeof(System.IOAsyncCallback) + 728;
			nint num14 = (nint)renderGraph2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X8_v42 (Il2CppClass<UnityEngine.Rendering.RenderGraphModule.RenderGraph>)+12E]");
			rendererListHandle2 = (RendererListHandle)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X8_v42 (Il2CppClass<UnityEngine.Rendering.RenderGraphModule.RenderGraph>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_071c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X8_v42 (Il2CppClass<UnityEngine.Rendering.RenderGraphModule.RenderGraph>)+B0]");
			object obj35 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1075 @ X10_v39-8]");
				if (0 == (nint)obj34)
				{
					break;
				}
				obj7 = obj35 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X8_v42 (Il2CppClass<UnityEngine.Rendering.RenderGraphModule.RenderGraph>)+12E]");
				rendererListHandle2 = (RendererListHandle)(-1);
				bool flag12 = (nint)rendererListHandle2 != 1;
				obj35 = obj7;
				if (flag12)
				{
					continue;
				}
				goto IL_071c;
			}
			rendererListHandle2 = (RendererListHandle)obj35;
			object obj36 = num14 + obj35;
			obj37 = obj36 + 312;
			obj7 = obj35;
			goto IL_1111;
		}
		ex = new NullReferenceException();
		obj23 = 0;
		rendererListParams2 = (RendererListParams)0;
		rendererListParams = (RendererListParams)filteringSettings;
		obj22 = 0;
		textureHandle = (TextureHandle)240;
		contextContainer2 = (ContextContainer)1;
		IntPtr intPtr = default(IntPtr);
		universalRenderingData = (UniversalRenderingData)(&intPtr);
		goto IL_0fb1;
		IL_0a77:
		if (renderGraph2 != null)
		{
			object obj38 = (nint)0 + (nint)1520;
			renderGraph3 = (RenderGraph)obj38;
			nint num15 = (nint)renderGraph2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1261 @ X8_v55 (Il2CppClass<UnityEngine.Rendering.RenderGraphModule.RenderGraph>)+12E]");
			rendererListHandle2 = (RendererListHandle)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1261 @ X8_v55 (Il2CppClass<UnityEngine.Rendering.RenderGraphModule.RenderGraph>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0b4c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1261 @ X8_v55 (Il2CppClass<UnityEngine.Rendering.RenderGraphModule.RenderGraph>)+B0]");
			object obj39 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1313 @ X10_v24-8]");
				if (0 == (nint)renderGraph3.m_Resources)
				{
					break;
				}
				obj7 = obj39 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1261 @ X8_v55 (Il2CppClass<UnityEngine.Rendering.RenderGraphModule.RenderGraph>)+12E]");
				rendererListHandle2 = (RendererListHandle)(-1);
				bool flag13 = (nint)rendererListHandle2 != 1;
				obj39 = obj7;
				if (flag13)
				{
					continue;
				}
				goto IL_0b4c;
			}
			rendererListHandle2 = (RendererListHandle)(obj39 + (object)renderGraph3.m_FrameInformationLogger);
			object obj40 = num15 + rendererListHandle2;
			object obj41 = obj40 + 312;
			obj7 = obj39;
			goto IL_12f8;
		}
		ex = new NullReferenceException();
		obj23 = 0;
		rendererListParams2 = (RendererListParams)0;
		rendererListParams = (RendererListParams)filteringSettings;
		obj22 = 0;
		textureHandle = (TextureHandle)3;
		goto IL_0fb1;
		IL_0625:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		IntPtr intPtr2 = default(IntPtr);
		num12 = intPtr2;
		goto IL_10ad;
		IL_13af:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v947 @ X0_v7+8]");
		universalRenderingData = (UniversalRenderingData)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v947 @ X0_v7] (should have been resolved before IL gen)");
		goto IL_135b;
		IL_12f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1950");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1335 @ X0_v75 (UnityEngine.Rendering.ContextContainer)+8] (should have been resolved before IL gen)");
		obj23 = 0;
		rendererListParams2 = (RendererListParams)0;
		rendererListParams = (RendererListParams)filteringSettings;
		obj22 = 0;
		textureHandle = (TextureHandle)3;
		ContextContainer contextContainer4 = default(ContextContainer);
		contextContainer2 = contextContainer4;
		UniversalRenderingData universalRenderingData5;
		universalRenderingData = universalRenderingData5;
		object obj42 = 0;
		goto IL_13dd;
		IL_0fb1:
		if ((nint)universalRenderingData == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			object obj43 = default(object);
			obj42 = obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj23 = obj43;
			goto IL_13dd;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		return;
		IL_08e8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_11d9;
		IL_071c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_1111;
		IL_0d1e:
		ex = new NullReferenceException();
		drawingSettings = (DrawingSettings)universalRenderingData3;
		goto IL_0fb1;
		IL_1111:
		num12 = (nint)obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1091 @ X0_v59+8]");
		num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1091 @ X0_v59] (should have been resolved before IL gen)");
		object obj46 = default(object);
		if (renderGraph2 != null)
		{
			nint num16 = (nint)renderGraph2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1096 @ X8_v45 (Il2CppClass<UnityEngine.Rendering.RenderGraphModule.RenderGraph>)+12E]");
			rendererListHandle2 = (RendererListHandle)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1096 @ X8_v45 (Il2CppClass<UnityEngine.Rendering.RenderGraphModule.RenderGraph>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_07ff;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1096 @ X8_v45 (Il2CppClass<UnityEngine.Rendering.RenderGraphModule.RenderGraph>)+B0]");
			object obj44 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1138 @ X10_v34-8]");
				if (0 == (nint)contextContainer)
				{
					break;
				}
				obj7 = obj44 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1096 @ X8_v45 (Il2CppClass<UnityEngine.Rendering.RenderGraphModule.RenderGraph>)+12E]");
				rendererListHandle2 = (RendererListHandle)(-1);
				bool flag14 = (nint)rendererListHandle2 != 1;
				obj44 = obj7;
				if (flag14)
				{
					continue;
				}
				goto IL_07ff;
			}
			rendererListHandle2 = (RendererListHandle)(obj44 + 9);
			object obj45 = num16 + rendererListHandle2;
			obj46 = obj45 + 312;
			obj7 = obj44;
			goto IL_1175;
		}
		ex = new NullReferenceException();
		obj23 = 0;
		rendererListParams2 = (RendererListParams)0;
		rendererListParams = (RendererListParams)filteringSettings;
		obj22 = 0;
		textureHandle = (TextureHandle)3;
		textureHandle2 = (TextureHandle)0;
		TextureHandle textureHandle3 = default(TextureHandle);
		contextContainer2 = (ContextContainer)textureHandle3;
		TextureHandle textureHandle4 = default(TextureHandle);
		universalRenderingData = (UniversalRenderingData)textureHandle4;
		goto IL_0fb1;
		IL_0c91:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-68]");
		num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj47 = 0;
		rendererListHandle2 = (RendererListHandle)obj47;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-68]");
		if (obj47 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
		universalRenderingData = universalRenderingData2;
		universalRenderingData3 = (UniversalRenderingData)drawingSettings;
		goto IL_0d00;
		IL_11d9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1220 @ X0_v67+8]");
		contextContainer2 = (ContextContainer)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1220 @ X0_v67] (should have been resolved before IL gen)");
		contextContainer = (ContextContainer)(typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3824);
		nint num17 = (nint)contextContainer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1228 @ X0_v70 (Il2CppClass<UnityEngine.Rendering.ContextContainer>)+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1228 @ X0_v70 (Il2CppClass<UnityEngine.Rendering.ContextContainer>)+B8]");
			nint num18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1231 @ X8_v69 (Il2CppStaticFields<UnityEngine.Rendering.ContextContainer>)+8]");
			universalRenderingData5 = (UniversalRenderingData)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1231 @ X8_v69 (Il2CppStaticFields<UnityEngine.Rendering.ContextContainer>)+8]");
			bool flag15 = (nint)0 == 0;
			object obj48 = !flag15;
			textureHandle2 = (TextureHandle)0;
			universalRenderingData = null;
			num12 = num18;
			renderGraph3 = renderGraph2;
			if (obj48 == null)
			{
				nint num19 = num17;
				goto IL_0a28;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			nint num19 = (nint)contextContainer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X0_v81 (Il2CppClass<UnityEngine.Rendering.ContextContainer>)+B8]");
			nint num20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1247 @ X8_v68 (Il2CppStaticFields<UnityEngine.Rendering.ContextContainer>)+8]");
			universalRenderingData5 = (UniversalRenderingData)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1247 @ X8_v68 (Il2CppStaticFields<UnityEngine.Rendering.ContextContainer>)+8]");
			bool flag16 = (nint)0 == 0;
			object obj49 = !flag16;
			textureHandle2 = (TextureHandle)0;
			universalRenderingData = null;
			num12 = num20;
			renderGraph3 = renderGraph2;
			if (obj49 == null)
			{
				goto IL_0a28;
			}
		}
		goto IL_0a77;
		IL_0a28:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X0_v81 (Il2CppClass<UnityEngine.Rendering.ContextContainer>)+E4]");
		rendererListHandle2 = (RendererListHandle)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X0_v81 (Il2CppClass<UnityEngine.Rendering.ContextContainer>)+E4]");
		bool flag17 = (nint)0 == 0;
		object obj50 = !flag17;
		if (obj50 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		renderGraph3 = (RenderGraph)ContextContainer.s_TypeCount;
		object obj51 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 1976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj52 = (nint)0 + (nint)2256;
		BaseRenderFunc<object, RasterGraphContext> baseRenderFunc = default(BaseRenderFunc<object, RasterGraphContext>);
		baseRenderFunc..ctor((object)ContextContainer.s_TypeCount, (IntPtr)obj52);
		num12 = (nint)contextContainer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v8 (Il2CppClass<UnityEngine.Rendering.ContextContainer>)+B8]");
		object obj53 = (nint)0 + (nint)8;
		obj53 = baseRenderFunc;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		textureHandle2 = (TextureHandle)0;
		contextContainer2 = (ContextContainer)obj52;
		universalRenderingData = (UniversalRenderingData)(object)baseRenderFunc;
		universalRenderingData5 = (UniversalRenderingData)(object)baseRenderFunc;
		goto IL_0a77;
		IL_0d00:
		NullReferenceException ex2 = new NullReferenceException();
		textureHandle = textureHandle;
		textureHandle2 = textureHandle2;
		goto IL_0d1e;
		IL_07ff:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_1175;
		IL_0c4d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		contextContainer2 = null;
		goto IL_13af;
		IL_1175:
		num12 = (nint)obj46;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1155 @ X0_v63+8]");
		contextContainer2 = (ContextContainer)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1155 @ X0_v63] (should have been resolved before IL gen)");
		if (renderGraph2 != null)
		{
			nint num21 = (nint)renderGraph2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1160 @ X8_v48 (Il2CppClass<UnityEngine.Rendering.RenderGraphModule.RenderGraph>)+12E]");
			rendererListHandle2 = (RendererListHandle)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1160 @ X8_v48 (Il2CppClass<UnityEngine.Rendering.RenderGraphModule.RenderGraph>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_08e8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1160 @ X8_v48 (Il2CppClass<UnityEngine.Rendering.RenderGraphModule.RenderGraph>)+B0]");
			object obj54 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1202 @ X10_v29-8]");
				if (0 == (nint)contextContainer)
				{
					break;
				}
				obj7 = obj54 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1160 @ X8_v48 (Il2CppClass<UnityEngine.Rendering.RenderGraphModule.RenderGraph>)+12E]");
				rendererListHandle2 = (RendererListHandle)(-1);
				bool flag18 = (nint)rendererListHandle2 != 1;
				obj54 = obj7;
				if (flag18)
				{
					continue;
				}
				goto IL_08e8;
			}
			rendererListHandle2 = (RendererListHandle)(obj54 + 11);
			object obj55 = num21 + rendererListHandle2;
			object obj56 = obj55 + 312;
			obj7 = obj54;
			goto IL_11d9;
		}
		ex = new NullReferenceException();
		obj23 = 0;
		rendererListHandle = rendererListHandle3;
		rendererListParams2 = (RendererListParams)0;
		rendererListParams = (RendererListParams)filteringSettings;
		obj22 = 0;
		textureHandle = (TextureHandle)3;
		textureHandle2 = (TextureHandle)0;
		universalRenderingData = (UniversalRenderingData)(&rendererListHandle);
		goto IL_0fb1;
		IL_135b:
		bool flag19 = obj42 == null;
		object obj57 = !flag19;
		universalRenderingData2 = universalRenderingData;
		if (obj57 != null)
		{
			OutOfMemoryException ex3 = new OutOfMemoryException();
			ex = (NullReferenceException)(object)ex3;
			goto IL_0fb1;
		}
		goto IL_0c91;
	}

	private unsafe void ScheduleBlit(RenderGraph renderGraph, string passLabel, TextureHandle source, TextureHandle destination, int passIndex, Vector4 parameter)
	{
		//IL_06a4: Expected I, but got O
		//IL_06a9: Expected I, but got O
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
		//IL_0703: Expected O, but got I4
		//IL_070c: Expected O, but got I4
		//IL_0714: Expected O, but got Ref
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_0162: Expected O, but got I
		//IL_0172: Expected O, but got I
		//IL_09f6: Expected O, but got I4
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Expected O, but got Unknown
		//IL_05b5: Expected O, but got I
		//IL_05c5: Expected O, but got I
		//IL_081b: Expected I, but got O
		//IL_082b: Expected O, but got I
		//IL_01ad: Expected O, but got I
		//IL_0734: Expected O, but got I4
		//IL_073d: Expected O, but got I4
		//IL_0745: Expected O, but got Ref
		//IL_074e: Expected O, but got I4
		//IL_0a38: Expected O, but got I
		//IL_0600: Expected O, but got I
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_0259: Expected O, but got I
		//IL_0269: Expected O, but got I
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01d6: Expected O, but got I
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_0688: Expected O, but got Unknown
		//IL_08a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a5: Expected O, but got Unknown
		//IL_08ad: Expected I, but got O
		//IL_02a4: Expected O, but got I
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Expected O, but got Unknown
		//IL_0629: Expected O, but got I
		//IL_03be: Expected I, but got O
		//IL_03f2: Expected O, but got I4
		//IL_03fa: Expected O, but got I4
		//IL_040b: Expected O, but got I4
		//IL_0368: Expected O, but got I4
		//IL_0370: Expected O, but got I4
		//IL_0381: Expected O, but got I4
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_076e: Expected O, but got I4
		//IL_0777: Expected O, but got I4
		//IL_0439: Expected O, but got I
		//IL_045b: Expected O, but got I4
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_02cd: Expected O, but got I
		//IL_04a1: Expected O, but got I
		//IL_04a9: Expected I, but got O
		//IL_04b1: Expected O, but got I
		//IL_04c1: Expected O, but got I
		//IL_08ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ef: Expected O, but got Unknown
		//IL_0905: Expected O, but got I
		//IL_0917: Expected I, but got O
		//IL_0917: Expected O, but got I4
		//IL_091f: Expected I, but got O
		//IL_0935: Expected O, but got I
		//IL_0960: Expected O, but got I4
		//IL_09b5: Expected O, but got I4
		//IL_09be: Expected O, but got I4
		//IL_09d7: Expected O, but got I4
		//IL_04fc: Expected O, but got I
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Expected O, but got Unknown
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Expected O, but got Unknown
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Expected O, but got Unknown
		//IL_0525: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E73CA]");
		nint num = 0;
		RenderGraph renderGraph2 = default(RenderGraph);
		nint num3 = default(nint);
		nint num4 = default(nint);
		object obj10 = default(object);
		CaptureAndBlurPass captureAndBlurPass;
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
			object obj = ", stale={0}" + 3032;
			obj2 = (nint)0 + (nint)3272;
			textureHandle = (TextureHandle)obj;
			num2 = (int)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEFD8C");
			bool flag = num3 == 0;
			obj3 = 0;
			textureHandle2 = (TextureHandle)256;
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
				textureHandle2 = (TextureHandle)256;
				text = (string)(&num3);
				num = num3;
				captureAndBlurPass = this;
				IntPtr intPtr = default(IntPtr);
				num5 = intPtr;
				if (flag2)
				{
					goto IL_06da;
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
					goto IL_0813;
				}
				ex = new NullReferenceException();
				textureHandle3 = source;
				obj3 = 0;
				textureHandle2 = (TextureHandle)256;
				text = (string)(&num3);
				goto IL_0782;
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
		goto IL_0782;
		IL_0478:
		if (num4 != 0)
		{
			object obj11 = (nint)0 + (nint)1512;
			num5 = (nint)obj11;
			object obj12 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X8_v32+12E]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X8_v32+12E]");
			if ((nint)0 == 0)
			{
				goto IL_054d;
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
				goto IL_054d;
			}
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X21_v2 (Il2CppMethodInfo)+50]");
			obj2 = obj14 + 0;
			object obj15 = obj12 + obj2;
			object obj16 = obj15 + 312;
			obj8 = obj13;
			goto IL_098f;
		}
		ex = new NullReferenceException();
		textureHandle3 = source;
		obj3 = 0;
		textureHandle2 = (TextureHandle)2;
		goto IL_0782;
		IL_0651:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		text = null;
		goto IL_0a28;
		IL_0429:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X0_v50 (Il2CppClass<CaptureAndBlurPass>)+E4]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X0_v50 (Il2CppClass<CaptureAndBlurPass>)+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		num5 = ParameterId;
		object obj18 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj19 = (nint)0 + (nint)2248;
		BaseRenderFunc<object, RasterGraphContext> baseRenderFunc = default(BaseRenderFunc<object, RasterGraphContext>);
		baseRenderFunc..ctor((object)ParameterId, (IntPtr)obj19);
		num = (nint)captureAndBlurPass;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v4 (Il2CppClass<CaptureAndBlurPass>)+B8]");
		object obj20 = (nint)0 + (nint)16;
		obj20 = baseRenderFunc;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		renderGraph2 = (RenderGraph)(object)baseRenderFunc;
		text = (string)obj19;
		textureHandle = (TextureHandle)0;
		RenderGraph renderGraph3 = (RenderGraph)(object)baseRenderFunc;
		goto IL_0478;
		IL_098f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1950");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v722 @ X0_v44 (System.String)+8] (should have been resolved before IL gen)");
		textureHandle3 = source;
		obj3 = 0;
		textureHandle2 = (TextureHandle)2;
		renderGraph2 = renderGraph3;
		string text2 = default(string);
		text = text2;
		object obj21 = 0;
		goto IL_0a6a;
		IL_0782:
		if ((nint)renderGraph2 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			object obj22 = default(object);
			obj21 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj3 = obj22;
			goto IL_0a6a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0877:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X0_v36+8]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v599 @ X0_v36] (should have been resolved before IL gen)");
		captureAndBlurPass = (CaptureAndBlurPass)(typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3824);
		nint num6 = (nint)captureAndBlurPass;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X0_v39 (Il2CppClass<CaptureAndBlurPass>)+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X0_v39 (Il2CppClass<CaptureAndBlurPass>)+B8]");
			nint num7 = 0;
			renderGraph3 = (RenderGraph)(object)NoBlurLayerName;
			bool flag6 = NoBlurLayerName == null;
			object obj23 = !flag6;
			renderGraph2 = (RenderGraph)passIndex;
			text = (string)parameter;
			textureHandle = (TextureHandle)0;
			num = num7;
			num5 = num4;
			if (obj23 == null)
			{
				nint num8 = num6;
				goto IL_0429;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			nint num8 = (nint)captureAndBlurPass;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X0_v50 (Il2CppClass<CaptureAndBlurPass>)+B8]");
			nint num9 = 0;
			renderGraph3 = (RenderGraph)(object)NoBlurLayerName;
			bool flag7 = NoBlurLayerName == null;
			object obj24 = !flag7;
			renderGraph2 = (RenderGraph)passIndex;
			text = (string)parameter;
			textureHandle = (TextureHandle)0;
			num = num9;
			num5 = num4;
			if (obj24 == null)
			{
				goto IL_0429;
			}
		}
		goto IL_0478;
		IL_02f5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0877;
		IL_0a6a:
		if (0 == 0)
		{
			goto IL_09dc;
		}
		object obj25 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		object obj26 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v7+12E]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v7+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0651;
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
			goto IL_0651;
		}
		obj2 = obj27;
		object obj28 = obj26 + obj27;
		object obj29 = obj28 + 312;
		obj8 = obj27;
		goto IL_0a28;
		IL_054d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_098f;
		IL_0a28:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X0_v6+8]");
		renderGraph2 = (RenderGraph)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v615 @ X0_v6] (should have been resolved before IL gen)");
		goto IL_09dc;
		IL_06da:
		ex = new NullReferenceException();
		goto IL_0782;
		IL_01fe:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0813;
		IL_0813:
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
			goto IL_0877;
		}
		ex = new NullReferenceException();
		textureHandle3 = source;
		obj3 = 0;
		textureHandle2 = (TextureHandle)256;
		TextureHandle textureHandle4 = default(TextureHandle);
		renderGraph2 = (RenderGraph)(&textureHandle4);
		text = (string)1;
		goto IL_0782;
		IL_09dc:
		bool flag10 = obj21 == null;
		object obj35 = !flag10;
		if (obj35 == null)
		{
			return;
		}
		OutOfMemoryException ex3 = new OutOfMemoryException();
		goto IL_06da;
	}

	static CaptureAndBlurPass()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_039c: Expected O, but got I
		//IL_03a4: Expected O, but got I4
		//IL_006a: Expected O, but got I
		//IL_0081: Expected O, but got I
		//IL_0096: Expected O, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00d3: Expected O, but got I4
		//IL_0153: Expected O, but got I
		//IL_0168: Expected O, but got I
		//IL_00f7: Expected O, but got I
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_01a5: Expected O, but got I4
		//IL_022c: Expected O, but got I
		//IL_0241: Expected O, but got I
		//IL_01c9: Expected O, but got I
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_027e: Expected O, but got I4
		//IL_02df: Expected O, but got I
		//IL_02ef: Expected O, but got I
		//IL_02ff: Expected O, but got I
		//IL_032f: Expected O, but got I
		//IL_035f: Expected O, but got I
		//IL_02a2: Expected O, but got I
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_02ca: Expected O, but got I4
		object name = "_InputUv1BufferOffset" + 1304;
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 280;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 3296;
		object name2 = "UInt16" + 2992;
		int num = Shader.PropertyToID((string)name);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v3+B8]");
		object obj4 = 0;
		obj4 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<ShaderTagId> list = default(List<ShaderTagId>);
		list..ctor();
		ShaderTagId item = new ShaderTagId((string)name2);
		object obj5 = (nint)0 + (nint)1256;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Rendering.ShaderTagId>)+1C]");
		object obj6 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Rendering.ShaderTagId>)+10]");
		object obj7 = 0;
		object name3 = "UInt16" + 3000;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Rendering.ShaderTagId>)+18]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X9_v4+18]");
		bool flag = num2 < 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Rendering.ShaderTagId>)+18]");
			object obj9 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Rendering.ShaderTagId>)+18]");
			object obj10 = obj7 + 0;
		}
		else
		{
			list.AddWithResize(item);
		}
		ShaderTagId item2 = new ShaderTagId((string)name3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Rendering.ShaderTagId>)+1C]");
		object obj11 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Rendering.ShaderTagId>)+10]");
		object obj12 = 0;
		object name4 = "SERVICE_DISABLED" + 544;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Rendering.ShaderTagId>)+18]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X9_v7+18]");
		bool flag2 = num3 < 0;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Rendering.ShaderTagId>)+18]");
			object obj14 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Rendering.ShaderTagId>)+18]");
			object obj15 = obj12 + 0;
		}
		else
		{
			list.AddWithResize(item2);
		}
		ShaderTagId item3 = new ShaderTagId((string)name4);
		object obj16 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Rendering.ShaderTagId>)+1C]");
		object obj17 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Rendering.ShaderTagId>)+10]");
		object obj18 = 0;
		object obj19 = "Network Authentication Required" + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Rendering.ShaderTagId>)+18]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X9_v10+18]");
		bool flag3 = num4 < 0;
		object obj20 = !flag3;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Rendering.ShaderTagId>)+18]");
			object obj21 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Rendering.ShaderTagId>)+18]");
			object obj22 = obj18 + 0;
			object obj23 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v10+20]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v14+C0]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v15+70]");
			object obj23 = 0;
			list.AddWithResize(item3);
		}
		object obj26 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v12+B8]");
		object obj27 = (nint)0 + (nint)8;
		obj27 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj28 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v13+B8]");
		object obj29 = (nint)0 + (nint)16;
		obj29 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
