using System;
using System.Data;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Unity.Services.Authentication.Shared;
using UnityEngine;

public class Diffusion : MonoBehaviour
{
	public delegate void OnCompleted(DiffusionPlatform platform);

	public delegate void OnCancelled();

	public string message;

	public string url;

	public int platformsToHide;

	public string[] customPlatforms;

	public GameObject eventReceiver;

	public OnCompleted onCompleted;

	public OnCancelled onCancelled;

	private void Start()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_018a: Expected O, but got I4
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00e8: Expected O, but got I4
		//IL_01ba: Expected O, but got I
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8D09]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RuntimePlatform platform = Application.platform;
		if (platform != RuntimePlatform.IPhonePlayer)
		{
			goto IL_00a3;
		}
		goto IL_0164;
		IL_00a3:
		string[] array = customPlatforms;
		goto IL_00b2;
		IL_00b2:
		if (array.Length >= 1)
		{
			object obj6 = array + 32;
			object obj7 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X21_v5+v192 @ X20_v5*8]");
				AddCustomPlatform((string)0);
				obj7++;
			}
			while ((nint)obj7 < array.Length);
		}
		return;
		IL_0164:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17754");
		bool flag2 = customPlatforms == null;
		object obj8 = !flag2;
		array = customPlatforms;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00b2;
		IL_007d:
		platform = Application.platform;
		if (platform != RuntimePlatform.IPhonePlayer)
		{
			goto IL_00a3;
		}
		goto IL_0164;
	}

	public static bool isFacebookConnected()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f6: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8D48]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.IPhonePlayer)
		{
			goto IL_009d;
		}
		goto IL_0139;
		IL_009d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @177F4");
		object obj5 = default(object);
		bool flag2 = obj5 == null;
		return !flag2;
		IL_0139:
		return false;
		IL_0074:
		platform = Application.platform;
		if (platform == RuntimePlatform.IPhonePlayer)
		{
			goto IL_009d;
		}
		goto IL_0139;
	}

	public static bool isTwitterConnected()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f6: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8D49]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.IPhonePlayer)
		{
			goto IL_009d;
		}
		goto IL_0139;
		IL_009d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17838");
		object obj5 = default(object);
		bool flag2 = obj5 == null;
		return !flag2;
		IL_0139:
		return false;
		IL_0074:
		platform = Application.platform;
		if (platform == RuntimePlatform.IPhonePlayer)
		{
			goto IL_009d;
		}
		goto IL_0139;
	}

	public void PostToTwitter()
	{
		PostToTwitter(message, url, null);
	}

	public void PostToTwitter(string message)
	{
		PostToTwitter(message, null, null);
	}

	public void PostToTwitter(string message, string imagePath)
	{
		PostToTwitter(message, null, imagePath);
	}

	public void PostToTwitter(string message, string url, string imagePath)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0529: Expected O, but got I4
		//IL_0567: Expected O, but got I4
		//IL_05a5: Expected O, but got I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00db: Expected O, but got I8
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_013a: Expected O, but got I4
		//IL_0150: Expected O, but got I
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01cc: Expected O, but got I8
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_022b: Expected O, but got I4
		//IL_0241: Expected O, but got I
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		//IL_02b6: Expected O, but got I4
		//IL_02cc: Expected O, but got I
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected O, but got Unknown
		//IL_048f: Expected O, but got I4
		//IL_0498: Expected O, but got I4
		//IL_04a1: Expected O, but got I4
		//IL_03b7: Expected O, but got I4
		//IL_03c0: Expected O, but got I4
		object obj = (nint)0 + (nint)2000;
		object obj2 = typeof(SqlSingle[]) + 32;
		bool flag = string.IsNullOrEmpty(message);
		bool flag2 = !flag;
		object obj3 = !flag2;
		object obj4 = ~obj3;
		string text = (string)((obj4 != null) ? message : obj);
		bool flag3 = string.IsNullOrEmpty(url);
		bool flag4 = !flag3;
		object obj5 = !flag4;
		object obj6 = ~obj5;
		string text2 = (string)((obj6 != null) ? url : obj);
		bool flag5 = string.IsNullOrEmpty(imagePath);
		bool flag6 = !flag5;
		object obj7 = !flag6;
		object obj8 = ~obj7;
		string text3 = (string)((obj8 != null) ? imagePath : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		string[] array = default(string[]);
		if (array.Length != 0)
		{
			object obj9 = "WhiteSmoke" + 3096;
			object obj10 = array + 32;
			obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X23_v6-8]");
			object obj11 = 0 & 0xFFFFFFFEL;
			if (obj11 != null)
			{
				object obj12 = array + 40;
				obj12 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X23_v8-10]");
				bool flag7 = (nint)0 < (nint)2;
				object obj13 = !flag7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X23_v8-10]");
				object obj14 = -2;
				bool flag8 = obj14 == null;
				object obj15 = ~obj13;
				object obj16 = obj15 | flag8;
				if (obj16 == null)
				{
					object obj17 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2400;
					object obj18 = array + 48;
					obj18 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X23_v10-18]");
					object obj19 = 0 & 0xFFFFFFFCL;
					if (obj19 != null)
					{
						object obj20 = array + 56;
						obj20 = text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X23_v12-20]");
						bool flag9 = (nint)0 < (nint)4;
						object obj21 = !flag9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X23_v12-20]");
						object obj22 = -4;
						bool flag10 = obj22 == null;
						object obj23 = ~obj21;
						object obj24 = obj23 | flag10;
						if (obj24 == null)
						{
							object obj25 = array + 64;
							obj25 = obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X23_v14-28]");
							bool flag11 = (nint)0 < (nint)5;
							object obj26 = !flag11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X23_v14-28]");
							object obj27 = -5;
							bool flag12 = obj27 == null;
							object obj28 = ~obj26;
							object obj29 = obj28 | flag12;
							if (obj29 == null)
							{
								object obj30 = typeof(DataRelation) + 856;
								object obj31 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
								object obj32 = array + 72;
								obj32 = text3;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								string text4 = string.Concat(array);
								object obj33 = obj30;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v16+E4]");
								object obj36;
								object obj35;
								if ((nint)0 != 0)
								{
									Debug.Log(text4);
									object obj34 = obj31;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v30+E4]");
									bool flag13 = (nint)0 == 0;
									obj35 = 0;
									obj36 = 0;
									if (!flag13)
									{
										goto IL_03ce;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									Debug.Log(text4);
									object obj34 = obj31;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v30+E4]");
									bool flag14 = (nint)0 == 0;
									object obj37 = !flag14;
									obj35 = 0;
									obj36 = 0;
									if (obj37 != null)
									{
										goto IL_03ce;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								RuntimePlatform platform = Application.platform;
								bool flag15 = platform == RuntimePlatform.IPhonePlayer;
								obj35 = obj36;
								if (!flag15)
								{
									return;
								}
								goto IL_03f7;
							}
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_03f7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @175E4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
		return;
		IL_03ce:
		RuntimePlatform platform2 = Application.platform;
		if (platform2 == RuntimePlatform.IPhonePlayer)
		{
			goto IL_03f7;
		}
	}

	public void PostToFacebook()
	{
		PostToFacebook(message, url, null);
	}

	public void PostToFacebook(string message)
	{
		PostToFacebook(message, null, null);
	}

	public void PostToFacebook(string message, string imagePath)
	{
		PostToFacebook(message, null, imagePath);
	}

	public void PostToFacebook(string message, string url, string imagePath)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0529: Expected O, but got I4
		//IL_0567: Expected O, but got I4
		//IL_05a5: Expected O, but got I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00db: Expected O, but got I8
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_013a: Expected O, but got I4
		//IL_0150: Expected O, but got I
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01cc: Expected O, but got I8
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_022b: Expected O, but got I4
		//IL_0241: Expected O, but got I
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		//IL_02b6: Expected O, but got I4
		//IL_02cc: Expected O, but got I
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected O, but got Unknown
		//IL_048f: Expected O, but got I4
		//IL_0498: Expected O, but got I4
		//IL_04a1: Expected O, but got I4
		//IL_03b7: Expected O, but got I4
		//IL_03c0: Expected O, but got I4
		object obj = (nint)0 + (nint)2000;
		object obj2 = typeof(SqlSingle[]) + 32;
		bool flag = string.IsNullOrEmpty(message);
		bool flag2 = !flag;
		object obj3 = !flag2;
		object obj4 = ~obj3;
		string text = (string)((obj4 != null) ? message : obj);
		bool flag3 = string.IsNullOrEmpty(url);
		bool flag4 = !flag3;
		object obj5 = !flag4;
		object obj6 = ~obj5;
		string text2 = (string)((obj6 != null) ? url : obj);
		bool flag5 = string.IsNullOrEmpty(imagePath);
		bool flag6 = !flag5;
		object obj7 = !flag6;
		object obj8 = ~obj7;
		string text3 = (string)((obj8 != null) ? imagePath : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		string[] array = default(string[]);
		if (array.Length != 0)
		{
			object obj9 = "WhiteSmoke" + 3096;
			object obj10 = array + 32;
			obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X23_v6-8]");
			object obj11 = 0 & 0xFFFFFFFEL;
			if (obj11 != null)
			{
				object obj12 = array + 40;
				obj12 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X23_v8-10]");
				bool flag7 = (nint)0 < (nint)2;
				object obj13 = !flag7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X23_v8-10]");
				object obj14 = -2;
				bool flag8 = obj14 == null;
				object obj15 = ~obj13;
				object obj16 = obj15 | flag8;
				if (obj16 == null)
				{
					object obj17 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2400;
					object obj18 = array + 48;
					obj18 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X23_v10-18]");
					object obj19 = 0 & 0xFFFFFFFCL;
					if (obj19 != null)
					{
						object obj20 = array + 56;
						obj20 = text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X23_v12-20]");
						bool flag9 = (nint)0 < (nint)4;
						object obj21 = !flag9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X23_v12-20]");
						object obj22 = -4;
						bool flag10 = obj22 == null;
						object obj23 = ~obj21;
						object obj24 = obj23 | flag10;
						if (obj24 == null)
						{
							object obj25 = array + 64;
							obj25 = obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X23_v14-28]");
							bool flag11 = (nint)0 < (nint)5;
							object obj26 = !flag11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X23_v14-28]");
							object obj27 = -5;
							bool flag12 = obj27 == null;
							object obj28 = ~obj26;
							object obj29 = obj28 | flag12;
							if (obj29 == null)
							{
								object obj30 = typeof(DataRelation) + 856;
								object obj31 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
								object obj32 = array + 72;
								obj32 = text3;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								string text4 = string.Concat(array);
								object obj33 = obj30;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v16+E4]");
								object obj36;
								object obj35;
								if ((nint)0 != 0)
								{
									Debug.Log(text4);
									object obj34 = obj31;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v30+E4]");
									bool flag13 = (nint)0 == 0;
									obj35 = 0;
									obj36 = 0;
									if (!flag13)
									{
										goto IL_03ce;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									Debug.Log(text4);
									object obj34 = obj31;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v30+E4]");
									bool flag14 = (nint)0 == 0;
									object obj37 = !flag14;
									obj35 = 0;
									obj36 = 0;
									if (obj37 != null)
									{
										goto IL_03ce;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								RuntimePlatform platform = Application.platform;
								bool flag15 = platform == RuntimePlatform.IPhonePlayer;
								obj35 = obj36;
								if (!flag15)
								{
									return;
								}
								goto IL_03f7;
							}
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_03f7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1769C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
		return;
		IL_03ce:
		RuntimePlatform platform2 = Application.platform;
		if (platform2 == RuntimePlatform.IPhonePlayer)
		{
			goto IL_03f7;
		}
	}

	public void Share()
	{
		Share(message, url, null, platformsToHide);
	}

	public void Share(string message, string filePath)
	{
		Share(message, null, filePath, platformsToHide);
	}

	public void Share(string message, string url, string filePath)
	{
		Share(message, url, filePath, platformsToHide);
	}

	public void Share(string message, string url, string filePath, int platforms)
	{
		//IL_000c: Expected O, but got I
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_01fd: Expected O, but got I8
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_025c: Expected O, but got I4
		//IL_0272: Expected O, but got I
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected O, but got Unknown
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		//IL_02ee: Expected O, but got I8
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected O, but got Unknown
		//IL_034d: Expected O, but got I4
		//IL_0363: Expected O, but got I
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected O, but got Unknown
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected O, but got Unknown
		//IL_03d8: Expected O, but got I4
		//IL_03ee: Expected O, but got I
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected O, but got Unknown
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected O, but got Unknown
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected O, but got Unknown
		//IL_05b1: Expected O, but got I4
		//IL_05ba: Expected O, but got I4
		//IL_05c3: Expected O, but got I4
		//IL_04d9: Expected O, but got I4
		//IL_04e2: Expected O, but got I4
		object obj = (nint)0 + (nint)2000;
		string text = (string)((message != null) ? message : obj);
		string text2;
		if (string.IsNullOrEmpty(url))
		{
			text2 = (string)obj;
			string text3 = filePath;
			string text4 = url;
		}
		else
		{
			object obj2 = "getSecondRescanTask" + 3376;
			string text5 = (string)obj2;
			string text6 = url.Substring(0, text5._stringLength);
			bool flag = text6 != text5;
			bool flag2 = !flag;
			string text3 = null;
			string text4 = null;
			text2 = url;
			if (!flag2)
			{
				string text7 = text5 + url;
				text3 = null;
				text4 = null;
				text2 = text7;
			}
		}
		string text8;
		if (string.IsNullOrEmpty(filePath))
		{
			text8 = (string)obj;
		}
		else
		{
			object obj3 = "fetch_products" + 136;
			string text9 = (string)obj3;
			string text10 = filePath.Substring(0, text9._stringLength);
			bool flag3 = text10 != text9;
			bool flag4 = !flag3;
			string text3 = null;
			string text4 = null;
			text8 = filePath;
			if (!flag4)
			{
				string text11 = text9 + filePath;
				text3 = null;
				text4 = null;
				text8 = text11;
			}
		}
		object obj4 = typeof(SqlSingle[]) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		string[] array = default(string[]);
		if (array.Length != 0)
		{
			object obj5 = "WhiteSmoke" + 3096;
			object obj6 = array + 32;
			obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X24_v5-8]");
			object obj7 = 0 & 0xFFFFFFFEL;
			if (obj7 != null)
			{
				object obj8 = array + 40;
				obj8 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X24_v7-10]");
				bool flag5 = (nint)0 < (nint)2;
				object obj9 = !flag5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X24_v7-10]");
				object obj10 = -2;
				bool flag6 = obj10 == null;
				object obj11 = ~obj9;
				object obj12 = obj11 | flag6;
				if (obj12 == null)
				{
					object obj13 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2400;
					object obj14 = array + 48;
					obj14 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X24_v9-18]");
					object obj15 = 0 & 0xFFFFFFFCL;
					if (obj15 != null)
					{
						object obj16 = array + 56;
						obj16 = text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X24_v11-20]");
						bool flag7 = (nint)0 < (nint)4;
						object obj17 = !flag7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X24_v11-20]");
						object obj18 = -4;
						bool flag8 = obj18 == null;
						object obj19 = ~obj17;
						object obj20 = obj19 | flag8;
						if (obj20 == null)
						{
							object obj21 = array + 64;
							obj21 = obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X24_v13-28]");
							bool flag9 = (nint)0 < (nint)5;
							object obj22 = !flag9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X24_v13-28]");
							object obj23 = -5;
							bool flag10 = obj23 == null;
							object obj24 = ~obj22;
							object obj25 = obj24 | flag10;
							if (obj25 == null)
							{
								object obj26 = typeof(DataRelation) + 856;
								object obj27 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
								object obj28 = array + 72;
								obj28 = text8;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								string text12 = string.Concat(array);
								object obj29 = obj26;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v17+E4]");
								object obj32;
								object obj31;
								if ((nint)0 != 0)
								{
									Debug.Log(text12);
									object obj30 = obj27;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X0_v28+E4]");
									bool flag11 = (nint)0 == 0;
									obj31 = 0;
									obj32 = 0;
									if (!flag11)
									{
										goto IL_04f0;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									Debug.Log(text12);
									object obj30 = obj27;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X0_v28+E4]");
									bool flag12 = (nint)0 == 0;
									object obj33 = !flag12;
									obj31 = 0;
									obj32 = 0;
									if (obj33 != null)
									{
										goto IL_04f0;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								RuntimePlatform platform = Application.platform;
								bool flag13 = platform == RuntimePlatform.IPhonePlayer;
								obj31 = obj32;
								if (!flag13)
								{
									return;
								}
								goto IL_0519;
							}
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_0519:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @174FC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
		return;
		IL_04f0:
		RuntimePlatform platform2 = Application.platform;
		if (platform2 == RuntimePlatform.IPhonePlayer)
		{
			goto IL_0519;
		}
	}

	private void Completed(string platformAsInt)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00c1: Expected O, but got I4
		//IL_003f: Expected O, but got I4
		//IL_0048: Expected O, but got I4
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_013f: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		int num = int.Parse(platformAsInt);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			bool flag = eventReceiver != null;
			bool flag2 = !flag;
			object obj3 = !flag2;
			object obj4 = 0;
			if (obj3 == null)
			{
				goto IL_0056;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = eventReceiver != null;
			bool flag4 = !flag3;
			object obj4 = 0;
			if (flag4)
			{
				goto IL_0056;
			}
		}
		object obj5 = typeof(DataRelation) + 2216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object methodName = "October" + 328;
		object value = default(object);
		eventReceiver.SendMessage((string)methodName, value, SendMessageOptions.DontRequireReceiver);
		OnCompleted onCompleted = this.onCompleted;
		bool flag5 = this.onCompleted == null;
		object obj6 = !flag5;
		if (obj6 == null)
		{
			return;
		}
		goto IL_007f;
		IL_007f:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v102.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		return;
		IL_0056:
		onCompleted = this.onCompleted;
		if (this.onCompleted != null)
		{
			goto IL_007f;
		}
	}

	private void Cancelled()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0157: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01ee: Expected O, but got I4
		//IL_01f7: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8D08]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_011d;
		}
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		UnityEngine.Object obj5 = eventReceiver;
		UnityEngine.Object obj6 = eventReceiver;
		if (!flag)
		{
			goto IL_0091;
		}
		goto IL_016f;
		IL_01a5:
		object methodName = "October" + 304;
		eventReceiver.SendMessage((string)methodName, SendMessageOptions.DontRequireReceiver);
		OnCancelled onCancelled = this.onCancelled;
		bool flag2 = this.onCancelled == null;
		object obj7 = !flag2;
		object obj8 = 0;
		if (obj7 == null)
		{
			return;
		}
		goto IL_00ec;
		IL_0091:
		bool flag3 = obj5 != null;
		bool flag4 = !flag3;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			goto IL_00c3;
		}
		goto IL_01a5;
		IL_00c3:
		onCancelled = this.onCancelled;
		if (this.onCancelled != null)
		{
			goto IL_00ec;
		}
		return;
		IL_00ec:
		IntPtr invoke_impl = ((Delegate)onCancelled).invoke_impl;
		IntPtr method_code = ((Delegate)onCancelled).method_code;
		IntPtr method = ((Delegate)onCancelled).method;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v101 @ X2_v6 (System.IntPtr) (should have been resolved before IL gen)");
		goto IL_011d;
		IL_011d:
		_ = 1;
		obj5 = eventReceiver;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		obj6 = eventReceiver;
		if (obj10 != null)
		{
			goto IL_0091;
		}
		goto IL_016f;
		IL_016f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (!(obj6 != null))
		{
			goto IL_00c3;
		}
		goto IL_01a5;
	}

	private static void Prewarm()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8D09]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RuntimePlatform platform = Application.platform;
		if (platform != RuntimePlatform.IPhonePlayer)
		{
			return;
		}
		goto IL_009d;
		IL_009d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17754");
		return;
		IL_0074:
		platform = Application.platform;
		if (platform == RuntimePlatform.IPhonePlayer)
		{
			goto IL_009d;
		}
	}

	private static void AddCustomPlatform(string platformClass)
	{
		//IL_00f0: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		bool flag = string.IsNullOrEmpty(platformClass);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj != null)
		{
			return;
		}
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			RuntimePlatform platform = Application.platform;
			if (platform != RuntimePlatform.IPhonePlayer)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			RuntimePlatform platform2 = Application.platform;
			if (platform2 != RuntimePlatform.IPhonePlayer)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1778C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
	}

	private string AddPrefix(string prefix, string url)
	{
		if (prefix != null && url != null)
		{
			string text = url.Substring(0, prefix._stringLength);
			if (text != prefix)
			{
				return prefix + url;
			}
			return url;
		}
		return (string)(object)new NullReferenceException();
	}

	[PreserveSig]
	private static extern void _share(string message, string url, string filePath, int platforms);

	[PreserveSig]
	private static extern void _postToTwitter(string message, string url, string imagePath);

	[PreserveSig]
	private static extern void _postToFacebook(string message, string url, string imagePath);

	[PreserveSig]
	private static extern void _prewarm();

	[PreserveSig]
	private static extern void _addCustomActivity(string activityClass);

	[PreserveSig]
	private static extern bool _isFacebookConnected();

	[PreserveSig]
	private static extern bool _isTwitterConnected();

	public Diffusion()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj2 = this + 56;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
