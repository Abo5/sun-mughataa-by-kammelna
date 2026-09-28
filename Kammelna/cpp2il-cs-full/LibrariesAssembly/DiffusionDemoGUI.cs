using System;
using System.ComponentModel;
using System.Data;
using Cpp2ILInjected;
using Unity.Services.Authentication.Shared;
using UnityEngine;

public class DiffusionDemoGUI : MonoBehaviour
{
	public Diffusion diffusion;

	private void Start()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		GameObject gameObject = base.gameObject;
		object obj = diffusion + 64;
		obj = gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void OnGUI()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_09ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ef: Expected O, but got Unknown
		//IL_0a19: Expected O, but got I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00f2: Expected O, but got I4
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_026b: Expected O, but got I4
		//IL_00af: Expected O, but got I4
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0183: Expected O, but got I4
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected O, but got Unknown
		//IL_03c4: Expected O, but got I4
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		//IL_02f2: Expected O, but got I4
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected O, but got Unknown
		//IL_051d: Expected O, but got I4
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected O, but got Unknown
		//IL_044b: Expected O, but got I4
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected O, but got Unknown
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected O, but got Unknown
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Expected O, but got Unknown
		//IL_056a: Expected O, but got I4
		//IL_0580: Expected O, but got I
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected O, but got Unknown
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Expected O, but got Unknown
		//IL_06eb: Expected O, but got I4
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Expected O, but got Unknown
		//IL_074d: Expected O, but got I4
		//IL_075d: Expected O, but got I
		//IL_077f: Expected O, but got I4
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Expected O, but got Unknown
		//IL_064a: Expected O, but got I4
		//IL_065a: Expected O, but got I
		//IL_067c: Expected O, but got I4
		//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0804: Expected O, but got Unknown
		//IL_091c: Expected O, but got I
		//IL_0936: Expected O, but got I4
		//IL_093f: Expected O, but got I4
		//IL_0948: Expected O, but got I4
		//IL_0850: Expected O, but got I
		//IL_0868: Expected O, but got I4
		//IL_0871: Expected O, but got I4
		//IL_0986: Expected O, but got I4
		//IL_0a3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a43: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1872;
		object position = "SetRoomVariables request error" + 408;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = GUI.Button((Rect)position, null);
		bool flag3 = !flag2;
		string text = null;
		if (!flag3)
		{
			Diffusion diffusion = this.diffusion;
			text = diffusion.message;
			string url = diffusion.url;
			int platformsToHide = diffusion.platformsToHide;
			((Diffusion)flag2).Share(diffusion.message, diffusion.url, null, diffusion.platformsToHide);
			string text2 = null;
		}
		object position2 = "SetRoomVariables request error" + 416;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj5 = !flag4;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = GUI.Button((Rect)position2, null);
		bool flag6 = !flag5;
		string text3 = null;
		if (!flag6)
		{
			Diffusion diffusion2 = this.diffusion;
			object obj6 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v94+E4]");
			bool flag7 = (nint)0 == 0;
			object obj8 = !flag7;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string streamingAssetsPath = Application.streamingAssetsPath;
			object obj9 = "fetch_products" + 136;
			object obj10 = ", stale={0}" + 3072;
			string text4 = (string)obj9 + streamingAssetsPath + (string)obj10;
			object obj11 = "Cannot populate JSON object onto type '{0}'." + 2424;
			text3 = (string)obj11;
			int platformsToHide = diffusion2.platformsToHide;
			((Diffusion)(object)text4).Share((string)obj11, (string)null, text4, diffusion2.platformsToHide);
			string text2 = text4;
			string url = null;
		}
		object position3 = "Picking audio files is not supported on iOS" + 1040;
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v13+E4]");
		bool flag8 = (nint)0 == 0;
		object obj13 = !flag8;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag9 = GUI.Button((Rect)position3, null);
		bool flag10 = !flag9;
		string text5 = null;
		if (!flag10)
		{
			object obj14 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v86+E4]");
			bool flag11 = (nint)0 == 0;
			object obj16 = !flag11;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string streamingAssetsPath2 = Application.streamingAssetsPath;
			object obj17 = "fetch_products" + 136;
			object obj18 = ", stale={0}" + 3072;
			string text6 = (string)obj17 + streamingAssetsPath2 + (string)obj18;
			object obj19 = "Cannot populate JSON object onto type '{0}'." + 2424;
			text5 = (string)obj19;
			((Diffusion)(object)text6).PostToTwitter((string)obj19, (string)null, text6);
			string text2 = text6;
			string url = null;
		}
		object position4 = "Picking audio files is not supported on iOS" + 1032;
		object obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v18+E4]");
		bool flag12 = (nint)0 == 0;
		object obj21 = !flag12;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag13 = GUI.Button((Rect)position4, null);
		bool flag14 = !flag13;
		string text7 = null;
		if (!flag14)
		{
			object obj22 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
			object obj23 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v78+E4]");
			bool flag15 = (nint)0 == 0;
			object obj24 = !flag15;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string streamingAssetsPath3 = Application.streamingAssetsPath;
			object obj25 = "fetch_products" + 136;
			object obj26 = ", stale={0}" + 3072;
			string text8 = (string)obj25 + streamingAssetsPath3 + (string)obj26;
			object obj27 = "Cannot populate JSON object onto type '{0}'." + 2424;
			text7 = (string)obj27;
			((Diffusion)(object)text8).PostToFacebook((string)obj27, (string)null, text8);
			string text2 = text8;
			string url = null;
		}
		object position5 = "Cannot populate JSON object onto type '{0}'." + 2416;
		object obj28 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X0_v23+E4]");
		bool flag16 = (nint)0 == 0;
		object obj29 = !flag16;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!GUI.Button((Rect)position5, null))
		{
			return;
		}
		object obj30 = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8D48]");
		object obj31 = (nint)0 & (nint)1;
		object obj32;
		object obj34;
		if (obj31 != null)
		{
			obj32 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
			object obj33 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v62+E4]");
			bool flag17 = (nint)0 == 0;
			obj34 = obj32;
			if (!flag17)
			{
				goto IL_05e6;
			}
		}
		else
		{
			_ = 1;
			obj32 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
			object obj33 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v62+E4]");
			bool flag18 = (nint)0 == 0;
			object obj35 = !flag18;
			obj34 = obj32;
			if (obj35 != null)
			{
				goto IL_05e6;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RuntimePlatform platform = Application.platform;
		bool flag19 = platform == RuntimePlatform.IPhonePlayer;
		obj32 = obj34;
		if (flag19)
		{
			goto IL_0617;
		}
		goto IL_073e;
		IL_0617:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @177F4");
		object obj36 = default(object);
		bool flag20 = obj36 == null;
		bool flag21 = !flag20;
		object obj37 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v62+28]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X0_v58+E4]");
		bool flag22 = (nint)0 == 0;
		object obj39 = !flag22;
		bool flag23 = flag21;
		if (obj39 == null)
		{
			flag23 = flag21;
			obj34 = obj32;
			goto IL_07a7;
		}
		goto IL_07be;
		IL_05e6:
		platform = Application.platform;
		bool flag24 = platform != RuntimePlatform.IPhonePlayer;
		obj34 = obj32;
		if (!flag24)
		{
			goto IL_0617;
		}
		goto IL_073e;
		IL_087f:
		object obj40 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X0_v39+E4]");
		bool flag25 = (nint)0 == 0;
		object obj42;
		object obj41 = obj42;
		if (!flag25)
		{
			goto IL_08b4;
		}
		goto IL_099c;
		IL_07a7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj32 = obj34;
		goto IL_07be;
		IL_07be:
		string text9 = flag23.ToString();
		object obj43 = "Error reading data from socket: " + 2944;
		string message = (string)obj43 + text9;
		object obj44 = typeof(DataRelation) + 856;
		object obj45 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v33+E4]");
		if ((nint)0 != 0)
		{
			Debug.Log(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8D49]");
			object obj46 = (nint)0 & (nint)1;
			bool flag26 = obj46 == null;
			obj42 = 0;
			obj41 = 0;
			if (!flag26)
			{
				goto IL_087f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Debug.Log(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8D49]");
			object obj47 = (nint)0 & (nint)1;
			bool flag27 = obj47 == null;
			object obj48 = !flag27;
			obj42 = 0;
			obj41 = 0;
			if (obj48 != null)
			{
				goto IL_087f;
			}
		}
		_ = 1;
		obj40 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X0_v39+E4]");
		bool flag28 = (nint)0 == 0;
		object obj49 = !flag28;
		obj42 = obj41;
		if (obj49 != null)
		{
			goto IL_08b4;
		}
		goto IL_099c;
		IL_0a27:
		string text10 = flag23.ToString();
		object obj50 = "ThisIsFakeReceiptData" + 2736;
		string message2 = (string)obj50 + text10;
		Debug.Log(message2);
		return;
		IL_08b4:
		RuntimePlatform platform2 = Application.platform;
		if (platform2 == RuntimePlatform.IPhonePlayer)
		{
			goto IL_08dd;
		}
		goto IL_0a27;
		IL_099c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		platform2 = Application.platform;
		bool flag29 = platform2 == RuntimePlatform.IPhonePlayer;
		obj42 = obj41;
		if (flag29)
		{
			goto IL_08dd;
		}
		goto IL_0a27;
		IL_073e:
		object obj51 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v54+28]");
		obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X0_v58+E4]");
		bool flag30 = (nint)0 == 0;
		object obj52 = !flag30;
		flag23 = false;
		flag23 = false;
		obj32 = obj34;
		if (obj52 == null)
		{
			goto IL_07a7;
		}
		goto IL_07be;
		IL_08dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17838");
		goto IL_0a27;
	}

	private unsafe void OnCompleted(DiffusionPlatform platform)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_00f7: Expected O, but got Ref
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_0156: Expected O, but got I4
		object obj = "SubscribeGroup request Error" + 3880;
		object obj2 = typeof(DataRelation) + 856;
		object obj3 = default(object);
		string text = ((Enum)(&obj3)).ToString();
		string message = (string)obj + text;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+E4]");
		Camera main;
		Camera camera;
		if ((nint)0 != 0)
		{
			Debug.Log(message);
			main = Camera.main;
			bool flag = platform == DiffusionPlatform.Twitter;
			camera = main;
			if (!flag)
			{
				goto IL_0065;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Debug.Log(message);
			main = Camera.main;
			bool flag2 = platform != DiffusionPlatform.Twitter;
			camera = main;
			if (flag2)
			{
				goto IL_0065;
			}
		}
		goto IL_0139;
		IL_0139:
		object methodName = "Read object reference Id '{0}' for {1}." + 2768;
		camera.backgroundColor = (Color)0;
		Invoke((string)methodName, 2f);
		return;
		IL_0065:
		camera = ((platform != DiffusionPlatform.SaveToCameraRoll) ? main : main);
		goto IL_0139;
	}

	private void OnCancelled()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_0120: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00c8: Expected O, but got I4
		//IL_0171: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(DataRelation) + 856;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8D03]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object message;
		if (obj3 != null)
		{
			obj4 = "Unsupported map type" + 648;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			message = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "Unsupported map type" + 648;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			message = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Debug.Log(message);
		Camera main = Camera.main;
		bool flag3 = (object)main == null;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00ab;
		IL_0094:
		Debug.Log(obj4);
		main = Camera.main;
		goto IL_00ab;
		IL_00ab:
		object methodName = "Read object reference Id '{0}' for {1}." + 2768;
		main.backgroundColor = (Color)0;
		Invoke((string)methodName, 2f);
	}

	private void ResetColor()
	{
		//IL_001c: Expected O, but got I4
		Camera main = Camera.main;
		main.backgroundColor = (Color)0;
	}
}
