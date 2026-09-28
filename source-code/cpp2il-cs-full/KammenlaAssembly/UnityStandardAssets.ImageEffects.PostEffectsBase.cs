using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Device;

namespace UnityStandardAssets.ImageEffects;

public class PostEffectsBase : MonoBehaviour
{
	protected bool supportHDRTextures;

	protected bool supportDX11;

	protected bool isSupported;

	private List<Material> createdMaterials;

	protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01a9: Expected O, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_026b: Expected O, but got I4
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_0201: Expected O, but got I4
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Expected O, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected O, but got Unknown
		//IL_015e: Expected O, but got I4
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Expected O, but got Unknown
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Expected O, but got Unknown
		//IL_057f: Expected O, but got I8
		//IL_0329: Expected O, but got I4
		//IL_044a: Expected O, but got I4
		//IL_0865: Expected O, but got I4
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Expected O, but got Unknown
		//IL_05de: Expected O, but got I4
		//IL_05f4: Expected O, but got I
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Expected O, but got Unknown
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Expected O, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected O, but got Unknown
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected O, but got Unknown
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0644: Expected O, but got Unknown
		//IL_067a: Expected O, but got I8
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Expected O, but got Unknown
		//IL_06d9: Expected O, but got I4
		//IL_06ef: Expected O, but got I
		//IL_070f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0714: Expected O, but got Unknown
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Expected O, but got Unknown
		//IL_073a: Unknown result type (might be due to invalid IL or missing references)
		//IL_073f: Expected O, but got Unknown
		//IL_078d: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B31]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v13+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = typeof(DataRelation) + 856;
		bool flag2 = s;
		bool flag3 = !flag2;
		object obj7 = !flag3;
		object obj8 = obj6;
		if (obj7 != null)
		{
			goto IL_00c3;
		}
		goto IL_0217;
		IL_0356:
		if (s.isSupported)
		{
			object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3912;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Material material = default(Material);
			material..ctor(s);
			List<object> list = (List<object>)(object)createdMaterials;
			if (createdMaterials != null)
			{
				int version = list._version + 1;
				list._version = version;
				object[] items = list._items;
				if (list._items != null)
				{
					bool flag4 = list._size < items.Length;
					object obj10 = !flag4;
					if (obj10 == null)
					{
						int size = list._size + 1;
						list._size = size;
						object obj11 = list._items + list._size;
						object obj12 = obj11 + 32;
						obj12 = material;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					}
					else
					{
						((List<object>)(object)createdMaterials).AddWithResize((object)material);
					}
					if ((object)material != null)
					{
						material.hideFlags = HideFlags.DontSave;
						return material;
					}
				}
			}
		}
		else
		{
			base.enabled = false;
			isSupported = false;
			object obj13 = typeof(SqlSingle[]) + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			string[] array = default(string[]);
			if (array != null)
			{
				if (array.Length != 0)
				{
					object obj14 = "The operation is not allowed on non-connected sockets." + 1224;
					object obj15 = array + 32;
					obj15 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					string text = s.ToString();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X22_v9-8]");
					object obj16 = 0 & 0xFFFFFFFEL;
					if (obj16 != null)
					{
						object obj17 = array + 40;
						obj17 = text;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X21_v5-10]");
						bool flag5 = (nint)0 < (nint)2;
						object obj18 = !flag5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X21_v5-10]");
						object obj19 = -2;
						bool flag6 = obj19 == null;
						object obj20 = ~obj18;
						object obj21 = obj20 | flag6;
						if (obj21 == null)
						{
							object obj22 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 1640;
							object obj23 = array + 48;
							obj23 = obj22;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							string text2 = ToString();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X21_v7-18]");
							object obj24 = 0 & 0xFFFFFFFCL;
							if (obj24 != null)
							{
								object obj25 = array + 56;
								obj25 = text2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X19_v5-20]");
								bool flag7 = (nint)0 < (nint)4;
								object obj26 = !flag7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X19_v5-20]");
								object obj27 = -4;
								bool flag8 = obj27 == null;
								object obj28 = ~obj26;
								object obj29 = obj28 | flag8;
								if (obj29 == null)
								{
									object obj30 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 1392;
									object obj31 = array + 64;
									obj31 = obj30;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									string text3 = string.Concat(array);
									object obj32 = obj6;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v28+E4]");
									bool flag9 = (nint)0 == 0;
									object obj33 = !flag9;
									object message = text3;
									if (obj33 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										message = text3;
									}
									Debug.Log(message);
									return null;
								}
							}
						}
					}
				}
				goto IL_080e;
			}
		}
		goto IL_0800;
		IL_02d5:
		if ((object)m2Create == null)
		{
			goto IL_0800;
		}
		Shader shader = m2Create.shader;
		object obj34 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v39+E4]");
		bool flag10 = (nint)0 == 0;
		object obj35 = !flag10;
		UnityEngine.Object obj36 = shader;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj36 = shader;
		}
		bool flag11 = obj36 == s;
		bool flag12 = !flag11;
		object obj37 = !flag12;
		Material material2 = null;
		Material result = m2Create;
		if (obj37 == null)
		{
			goto IL_0356;
		}
		goto IL_0880;
		IL_0880:
		return result;
		IL_007d:
		obj6 = typeof(DataRelation) + 856;
		bool flag13 = s;
		bool flag14 = !flag13;
		obj8 = obj6;
		if (!flag14)
		{
			goto IL_00c3;
		}
		goto IL_0217;
		IL_0217:
		object obj38 = "Material with texture name \"" + 2104;
		string text4 = ToString();
		string text5 = (string)obj38 + text4;
		object obj39 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v5+E4]");
		bool flag15 = (nint)0 == 0;
		object obj40 = !flag15;
		object message2 = text5;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message2 = text5;
		}
		Debug.Log(message2);
		base.enabled = false;
		result = null;
		goto IL_0880;
		IL_0800:
		NullReferenceException ex = new NullReferenceException();
		goto IL_080e;
		IL_080e:
		return (Material)(object)new IndexOutOfRangeException();
		IL_00c3:
		if ((object)s != null)
		{
			bool flag16 = s.isSupported;
			bool flag17 = !flag16;
			material2 = m2Create;
			if (!flag17)
			{
				object obj41 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v89+E4]");
				if ((nint)0 != 0)
				{
					bool flag18 = m2Create;
					bool flag19 = !flag18;
					object obj42 = !flag19;
					if (obj42 != null)
					{
						goto IL_02d5;
					}
					material2 = m2Create;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag20 = m2Create;
					bool flag21 = !flag20;
					material2 = m2Create;
					if (!flag21)
					{
						goto IL_02d5;
					}
				}
			}
			goto IL_0356;
		}
		goto IL_0800;
	}

	protected Material CreateMaterial(Shader s, Material m2Create)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0142: Expected O, but got I4
		//IL_0099: Expected O, but got I4
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_0205: Expected O, but got I4
		//IL_0186: Expected O, but got I4
		//IL_018f: Expected O, but got I4
		//IL_00f7: Expected O, but got I4
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected O, but got Unknown
		//IL_0397: Expected O, but got I4
		//IL_033e: Expected O, but got I4
		//IL_04c1: Expected O, but got I4
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Expected O, but got Unknown
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B32]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v12+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = s;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		object obj6 = 0;
		if (obj5 != null)
		{
			goto IL_00a7;
		}
		goto IL_019d;
		IL_03af:
		if ((object)s != null)
		{
			goto IL_03cc;
		}
		goto IL_0571;
		IL_026f:
		Material material;
		if ((object)m2Create != null)
		{
			Shader shader = m2Create.shader;
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v23+E4]");
			if ((nint)0 != 0)
			{
				bool flag4 = shader == s;
				bool flag5 = !flag4;
				material = null;
				Material material2 = null;
				if (!flag5)
				{
					goto IL_02fa;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag6 = shader == s;
				bool flag7 = !flag6;
				object obj8 = !flag7;
				material = null;
				Material material2 = null;
				if (obj8 != null)
				{
					goto IL_02fa;
				}
			}
			goto IL_03af;
		}
		goto IL_0571;
		IL_02fa:
		if ((object)s == null)
		{
			goto IL_0571;
		}
		bool flag8 = s.isSupported;
		bool flag9 = !flag8;
		object obj9 = !flag9;
		Material result = m2Create;
		if (obj9 == null)
		{
			Material material2 = material;
			goto IL_03cc;
		}
		goto IL_0592;
		IL_0074:
		bool flag10 = s;
		bool flag11 = !flag10;
		obj6 = 0;
		if (!flag11)
		{
			goto IL_00a7;
		}
		goto IL_019d;
		IL_019d:
		object obj10 = "Material with texture name \"" + 2104;
		object obj11 = typeof(DataRelation) + 856;
		string text = ToString();
		string text2 = (string)obj10 + text;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v5+E4]");
		bool flag12 = (nint)0 == 0;
		object obj13 = !flag12;
		object message = text2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message = text2;
		}
		Debug.Log(message);
		result = null;
		goto IL_0592;
		IL_0592:
		return result;
		IL_0571:
		return (Material)(object)new NullReferenceException();
		IL_00a7:
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v33+E4]");
		if ((nint)0 != 0)
		{
			bool flag13 = m2Create;
			bool flag14 = !flag13;
			object obj15 = !flag14;
			if (obj15 != null)
			{
				goto IL_026f;
			}
			Material material2 = m2Create;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag15 = m2Create;
			bool flag16 = !flag15;
			Material material2 = m2Create;
			if (!flag16)
			{
				goto IL_026f;
			}
		}
		goto IL_03af;
		IL_03cc:
		bool flag17 = s.isSupported;
		bool flag18 = !flag17;
		result = null;
		if (!flag18)
		{
			object obj16 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3912;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Material material3 = default(Material);
			material3..ctor(s);
			List<object> list = (List<object>)(object)createdMaterials;
			if (createdMaterials != null)
			{
				int version = list._version + 1;
				list._version = version;
				object[] items = list._items;
				if (list._items != null)
				{
					bool flag19 = list._size < items.Length;
					object obj17 = !flag19;
					if (obj17 == null)
					{
						int size = list._size + 1;
						list._size = size;
						object obj18 = list._items + list._size;
						object obj19 = obj18 + 32;
						obj19 = material3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					}
					else
					{
						((List<object>)(object)createdMaterials).AddWithResize((object)material3);
					}
					if ((object)material3 != null)
					{
						material3.hideFlags = HideFlags.DontSave;
						return material3;
					}
				}
			}
			goto IL_0571;
		}
		goto IL_0592;
	}

	private void OnEnable()
	{
		isSupported = true;
	}

	private void OnDestroy()
	{
		RemoveCreatedMaterials();
	}

	private void RemoveCreatedMaterials()
	{
		//IL_0012: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_00b9: Expected O, but got I4
		List<object> list = (List<object>)(object)createdMaterials;
		object obj = (nint)0 + (nint)4016;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		while (list._size > 0)
		{
			object obj3 = list.get_Item(0);
			((List<object>)(object)createdMaterials).RemoveAt(0);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy((UnityEngine.Object)obj3);
			list = (List<object>)(object)createdMaterials;
		}
	}

	protected bool CheckSupport()
	{
		isSupported = true;
		bool flag = UnityEngine.Device.SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf);
		supportHDRTextures = flag;
		int graphicsShaderLevel = UnityEngine.Device.SystemInfo.graphicsShaderLevel;
		if (graphicsShaderLevel < 50)
		{
			supportDX11 = false;
			return true;
		}
		bool supportsComputeShaders = UnityEngine.Device.SystemInfo.supportsComputeShaders;
		supportDX11 = supportsComputeShaders;
		return true;
	}

	public virtual bool CheckResources()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0097: Expected O, but got I4
		object obj = "Cannot populate JSON object onto type '{0}'." + 2464;
		object obj2 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 1808;
		object obj3 = typeof(DataRelation) + 856;
		string text = ToString();
		string text2 = (string)obj + text + (string)obj2;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		object message = text2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message = text2;
		}
		Debug.LogWarning(message);
		return isSupported;
	}

	protected void Start()
	{
		//IL_0005: Expected I, but got O
		//IL_0015: Expected O, but got I
		//IL_0025: Expected O, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<UnityStandardAssets.ImageEffects.PostEffectsBase>)+178]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<UnityStandardAssets.ImageEffects.PostEffectsBase>)+180]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v2 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected bool CheckSupport(bool needDepth)
	{
		//IL_0026: Expected O, but got I4
		//IL_009c: Expected O, but got I
		//IL_0120: Expected I4, but got O
		isSupported = true;
		bool flag = UnityEngine.Device.SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf);
		supportHDRTextures = flag;
		int graphicsShaderLevel = UnityEngine.Device.SystemInfo.graphicsShaderLevel;
		if (graphicsShaderLevel < 50)
		{
			supportDX11 = false;
			bool flag2 = !needDepth;
			object obj = !flag2;
			if (obj != null)
			{
				goto IL_0065;
			}
		}
		else
		{
			bool supportsComputeShaders = UnityEngine.Device.SystemInfo.supportsComputeShaders;
			supportDX11 = supportsComputeShaders;
			if (needDepth)
			{
				goto IL_0065;
			}
		}
		goto IL_00f0;
		IL_00f0:
		return true;
		IL_0065:
		if (UnityEngine.Device.SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			object obj2 = (nint)0 + (nint)3648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			Camera camera = default(Camera);
			if ((object)camera != null)
			{
				DepthTextureMode depthTextureMode = camera.depthTextureMode;
				DepthTextureMode depthTextureMode2 = depthTextureMode | DepthTextureMode.Depth;
				camera.depthTextureMode = depthTextureMode2;
				goto IL_00f0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		base.enabled = false;
		isSupported = false;
		return false;
	}

	protected bool CheckSupport(bool needDepth, bool needHdr)
	{
		bool flag = CheckSupport(needDepth);
		if (needHdr && flag)
		{
			if (!supportHDRTextures)
			{
				base.enabled = false;
				isSupported = false;
				return false;
			}
			flag = true;
		}
		return flag;
	}

	public bool Dx11Support()
	{
		return supportDX11;
	}

	protected void ReportAutoDisable()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		object obj = "The '{0}' attribute is not declared." + 3192;
		object obj2 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 992;
		object obj3 = typeof(DataRelation) + 856;
		string text = ToString();
		string message = (string)obj + text + (string)obj2;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			Debug.LogWarning(message);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Debug.LogWarning(message);
	}

	private bool CheckShader(Shader s)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_038d: Expected I4, but got O
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_00a5: Expected O, but got I8
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_0104: Expected O, but got I4
		//IL_011a: Expected O, but got I
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_01a0: Expected O, but got I8
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01ff: Expected O, but got I4
		//IL_0215: Expected O, but got I
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected O, but got Unknown
		//IL_0347: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		string[] array = default(string[]);
		if (array != null)
		{
			if (array.Length != 0)
			{
				object obj2 = "The operation is not allowed on non-connected sockets." + 1224;
				object obj3 = array + 32;
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if ((object)s == null)
				{
					goto IL_037f;
				}
				string text = s.ToString();
				object obj4 = array.Length & 0xFFFFFFFEL;
				if (obj4 != null)
				{
					object obj5 = array + 40;
					obj5 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X22_v6-10]");
					bool flag = (nint)0 < (nint)2;
					object obj6 = !flag;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X22_v6-10]");
					object obj7 = -2;
					bool flag2 = obj7 == null;
					object obj8 = ~obj6;
					object obj9 = obj8 | flag2;
					if (obj9 == null)
					{
						object obj10 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 1640;
						object obj11 = array + 48;
						obj11 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						string text2 = ToString();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X22_v8-18]");
						object obj12 = 0 & 0xFFFFFFFCL;
						if (obj12 != null)
						{
							object obj13 = array + 56;
							obj13 = text2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X22_v10-20]");
							bool flag3 = (nint)0 < (nint)4;
							object obj14 = !flag3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X22_v10-20]");
							object obj15 = -4;
							bool flag4 = obj15 == null;
							object obj16 = ~obj14;
							object obj17 = obj16 | flag4;
							if (obj17 == null)
							{
								object obj18 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 1376;
								object obj19 = typeof(DataRelation) + 856;
								object obj20 = array + 64;
								obj20 = obj18;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								string message = string.Concat(array);
								object obj21 = obj19;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v18+E4]");
								if ((nint)0 != 0)
								{
									Debug.Log(message);
									if (s.isSupported)
									{
										goto IL_0302;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									Debug.Log(message);
									bool flag5 = s.isSupported;
									bool flag6 = !flag5;
									object obj22 = !flag6;
									if (obj22 != null)
									{
										goto IL_0302;
									}
								}
								base.enabled = false;
								isSupported = false;
								return false;
							}
						}
					}
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		goto IL_037f;
		IL_0302:
		return false;
		IL_037f:
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
	}

	protected void NotSupported()
	{
		base.enabled = false;
		isSupported = false;
	}

	protected void DrawBorder(RenderTexture dest, Material material)
	{
		RenderTexture.active = dest;
		GL.PushMatrix();
		GL.LoadOrtho();
		int passCount = material.passCount;
		if ((object)dest != null)
		{
			if (passCount >= 1)
			{
				int num = 0;
				int passCount2;
				do
				{
					bool flag = material.SetPass(num);
					int width = dest.width;
					double num2 = 1.0 / (double)width;
					GL.Begin(7);
					GL.TexCoord2(0f, 1f);
					GL.Vertex3(0f, 0f, 0.1f);
					GL.TexCoord2(1f, 1f);
					GL.Vertex3((float)num2, 0f, 0.1f);
					GL.TexCoord2(1f, 0f);
					GL.Vertex3((float)num2, 1f, 0.1f);
					GL.TexCoord2(0f, 0f);
					GL.Vertex3(0f, 1f, 0.1f);
					int width2 = dest.width;
					GL.TexCoord2(0f, 1f);
					double num3 = 1.0 / (double)width2;
					double num4 = 1.0 - num3;
					GL.Vertex3((float)num4, 0f, 0.1f);
					GL.TexCoord2(1f, 1f);
					GL.Vertex3(1f, 0f, 0.1f);
					GL.TexCoord2(1f, 0f);
					GL.Vertex3(1f, 1f, 0.1f);
					GL.TexCoord2(0f, 0f);
					GL.Vertex3((float)num4, 1f, 0.1f);
					int height = dest.height;
					double num5 = 1.0 / (double)height;
					GL.TexCoord2(0f, 1f);
					GL.Vertex3(0f, 0f, 0.1f);
					GL.TexCoord2(1f, 1f);
					GL.Vertex3(1f, 0f, 0.1f);
					GL.TexCoord2(1f, 0f);
					GL.Vertex3(1f, (float)num5, 0.1f);
					GL.TexCoord2(0f, 0f);
					GL.Vertex3(0f, (float)num5, 0.1f);
					int height2 = dest.height;
					double num6 = 1.0 / (double)height2;
					double num7 = 1.0 - num6;
					GL.TexCoord2(0f, 1f);
					GL.Vertex3(0f, (float)num7, 0.1f);
					GL.TexCoord2(1f, 1f);
					GL.Vertex3(1f, (float)num7, 0.1f);
					GL.TexCoord2(1f, 0f);
					GL.Vertex3(1f, 1f, 0.1f);
					GL.TexCoord2(0f, 0f);
					GL.Vertex3(0f, 1f, 0.1f);
					GL.End();
					num++;
					passCount2 = material.passCount;
				}
				while (num < passCount2);
			}
		}
		else if (passCount >= 1)
		{
			bool flag2 = material.SetPass(0);
			throw new NullReferenceException();
		}
		GL.PopMatrix();
	}

	public PostEffectsBase()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 2272;
		supportHDRTextures = true;
		isSupported = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 40;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
