using System;
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

public class BlurRendererFeature : ScriptableRendererFeature
{
	[Serializable]
	public class Settings
	{
		public Shader blurShader;

		public RenderPassEvent renderPassEvent = RenderPassEvent.AfterRenderingTransparents;
	}

	private Settings _settings;

	private BlurRenderPass _pass;

	private Material _material;

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
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected O, but got Unknown
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected O, but got Unknown
		//IL_0345: Expected O, but got I
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected O, but got Unknown
		Settings settings = _settings;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v4+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v8+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v12+E4]");
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
		object obj17 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ScriptableRenderPass scriptableRenderPass = default(ScriptableRenderPass);
		scriptableRenderPass..ctor();
		object obj18 = scriptableRenderPass + 96;
		obj18 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X21_v5-10]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v15+18]");
		scriptableRenderPass.<renderPassEvent>k__BackingField = RenderPassEvent.BeforeRendering;
		object obj20 = this + 40;
		obj20 = scriptableRenderPass;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_01c7:
		object obj21 = typeof(DataRelation) + 856;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v28+E4]");
		bool flag10 = (nint)0 == 0;
		object obj23 = !flag10;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message = "WhiteSmoke" + 2768;
		Debug.LogError(message);
		return;
		IL_00eb:
		object obj24 = "HH:mm:ss.ffZ" + 1152;
		Shader shader = Shader.Find((string)obj24);
		object obj25 = _settings + 16;
		obj25 = shader;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj5 = obj4;
		obj6 = shader;
		goto IL_0143;
	}

	public unsafe override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00ad: Expected O, but got I4
		//IL_00c9: Expected O, but got Ref
		//IL_00e7: Expected O, but got I
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0175: Expected I, but got O
		//IL_019e: Expected O, but got I4
		//IL_01d2: Expected O, but got I
		if (_pass == null)
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
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
		CameraData cameraData = (CameraData)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref renderingData, 8));
		ref Camera camera = ref ((CameraData*)cameraData)->camera;
		object obj4 = (nint)0 + (nint)936;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
		object obj5 = default(object);
		Behaviour behaviour = default(Behaviour);
		if (obj5 == null || !behaviour.enabled)
		{
			return;
		}
		if ((object)behaviour != null)
		{
			object obj6 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3104;
			object obj7 = obj6;
			nint num = (nint)behaviour;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X9_v3 (Il2CppClass<UnityEngine.Behaviour>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v14+130]");
			bool flag3 = num2 < 0;
			object obj8 = !flag3;
			object obj9 = ~obj8;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X9_v3 (Il2CppClass<UnityEngine.Behaviour>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v14+130]");
				object obj10 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X9_v5-8]");
				if (0 == (nint)obj7)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ stack_-38_v4 (UnityEngine.Behaviour)+4A]");
					if ((nint)0 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ stack_-38_v4 (UnityEngine.Behaviour)+49]");
						if ((nint)0 == 1)
						{
							behaviour.enabled = false;
							return;
						}
						_ = 1;
					}
				}
			}
		}
		object obj11 = _pass + 104;
		obj11 = behaviour;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		renderer.EnqueuePass(_pass);
	}

	protected override void Dispose(bool disposing)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00c2: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3272;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E73BC]");
		object obj2 = (nint)0 & (nint)1;
		UnityEngine.Object material;
		UnityEngine.Object material2;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			material = _material;
			material2 = _material;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			material = _material;
			material2 = _material;
			if (obj4 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		CoreUtils.Destroy(material2);
		return;
		IL_0088:
		CoreUtils.Destroy(material);
	}

	public BlurRendererFeature()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		_ = 500;
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = this + 32;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
