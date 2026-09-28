using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using UnityEngine;

public static class ClanLogoElementCatalog
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<KammelnaResponseModel<List<ClanLogoElementViewModel>>> <>9__3_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 1096;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Fetch>b__3_0(KammelnaResponseModel<List<ClanLogoElementViewModel>> response)
		{
			//IL_0011: Expected O, but got I
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			//IL_00fd: Expected O, but got I4
			//IL_015e: Expected O, but got I
			//IL_012e: Expected O, but got I
			//IL_0097: Expected O, but got I4
			//IL_0149: Expected O, but got I
			//IL_00c8: Expected O, but got I
			object obj = (nint)0 + (nint)624;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1272;
			if (((KammelnaResponseModel<object>)(object)response).Succeeded && response.<Model>k__BackingField != null)
			{
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v12+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj3 = obj2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v12+B8]");
				object obj5 = 0;
				object obj6 = (nint)0 + (nint)2288;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3997724");
			}
			else
			{
				object obj7 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v7+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj7 = obj2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v7+B8]");
				object obj9 = 0;
				object obj10 = (nint)0 + (nint)2280;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3997898");
			}
		}
	}

	private sealed class <>c__DisplayClass1_0
	{
		public Action callback;

		internal void <CallWhenLoaded>b__0(List<ClanLogoElementViewModel> _)
		{
			Action action = callback;
			if (callback != null)
			{
				IntPtr invoke_impl = ((Delegate)action).invoke_impl;
				IntPtr method_code = ((Delegate)action).method_code;
				IntPtr method = ((Delegate)action).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass2_0
	{
		public int id;

		public int tier;

		public ImageCacher.ClanLogoElementImageType type;

		internal bool <GetImage>b__0(ClanLogoElementViewModel e)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (e != null)
			{
				object obj = e.Id - id;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <GetImage>b__1(ClanLogoElementTierViewModel t)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (t != null)
			{
				object obj = t.Tier - tier;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <GetImage>b__2(ImageInfoModel<ImageCacher.ClanLogoElementImageType> image)
		{
			//IL_003e: Expected I4, but got O
			//IL_001c: Expected O, but got I
			if (image != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [image @ X1 (ImageInfoModel`1<ImageCacher+ClanLogoElementImageType>)+20]");
				object obj = (nint)0 - (nint)type;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private static readonly OneShotEvent<List<ClanLogoElementViewModel>> Elements;

	public static void CallWhenLoaded(Action callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0097: Expected O, but got I4
		//IL_00fb: Expected O, but got I
		//IL_0116: Expected I, but got O
		//IL_00c8: Expected O, but got I
		object obj = typeof(CardUtils.<>c) + 1104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1272;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 744;
		object obj5 = (nint)0 + (nint)184;
		object obj6 = obj2 + 16;
		obj6 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v10+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj5);
		object obj10 = (nint)0 + (nint)2272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39978C8");
	}

	public static ImageInfoModel<ImageCacher.ClanLogoElementImageType> GetImage(int id, int tier, ImageCacher.ClanLogoElementImageType type)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0066: Expected O, but got I4
		//IL_02ad: Expected O, but got I
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00d0: Expected O, but got I
		//IL_00dc: Expected O, but got I
		//IL_00f7: Expected I, but got O
		//IL_0111: Expected O, but got I
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_0181: Expected O, but got I
		//IL_0192: Expected I, but got O
		//IL_01a3: Expected O, but got I
		//IL_01b8: Expected O, but got I
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_0228: Expected O, but got I
		//IL_0239: Expected I, but got O
		//IL_0254: Expected O, but got I
		object obj = typeof(CardUtils.<>c) + 1112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1272;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v7+B8]");
			object obj6 = 0;
			object obj7 = obj6;
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v6+20]");
				if ((nint)0 != 0)
				{
					object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 672;
					object obj9 = (nint)0 + (nint)192;
					object obj10 = (nint)0 + (nint)696;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Func<object, bool> func = default(Func<object, bool>);
					func..ctor(obj2, (IntPtr)obj9);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v6+20]");
					object obj11 = Enumerable.FirstOrDefault((IEnumerable<object>)0, func);
					if (obj11 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v13 (System.Object)+20]");
						if ((nint)0 != 0)
						{
							object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 664;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj13 = (nint)0 + (nint)200;
							Func<object, bool> func2 = default(Func<object, bool>);
							func2..ctor(obj2, (IntPtr)obj13);
							object obj14 = (nint)0 + (nint)688;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v13 (System.Object)+20]");
							object obj15 = Enumerable.FirstOrDefault((IEnumerable<object>)0, func2);
							if (obj15 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v17 (System.Object)+18]");
								if ((nint)0 != 0)
								{
									object obj16 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3408;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									object obj17 = (nint)0 + (nint)208;
									Func<object, bool> func3 = default(Func<object, bool>);
									func3..ctor(obj2, (IntPtr)obj17);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v17 (System.Object)+18]");
									return (ImageInfoModel<ImageCacher.ClanLogoElementImageType>)Enumerable.FirstOrDefault((IEnumerable<object>)0, func3);
								}
							}
						}
					}
				}
				return null;
			}
		}
		return (ImageInfoModel<ImageCacher.ClanLogoElementImageType>)(object)new NullReferenceException();
	}

	private static void Fetch()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_009c: Expected O, but got I
		//IL_0195: Expected O, but got I4
		//IL_0133: Expected O, but got I
		//IL_0143: Expected O, but got I
		//IL_0165: Expected O, but got I4
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_01fe: Expected O, but got I
		//IL_020f: Expected I, but got O
		//IL_022d: Expected O, but got I
		//IL_01c5: Expected O, but got I
		object obj = typeof(CardUtils.<>c) + 1096;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88F8]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		if (obj2 != null)
		{
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			if (!flag)
			{
				goto IL_007c;
			}
		}
		else
		{
			_ = 1;
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v1+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X9_v2+8]");
		Action<KammelnaResponseModel<List<ClanLogoElementViewModel>>> callback = (Action<KammelnaResponseModel<List<ClanLogoElementViewModel>>>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X9_v2+8]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 != null)
		{
			goto IL_00c1;
		}
		goto IL_0173;
		IL_00c1:
		KammelnaRequests.GetClanLogoElements(callback);
		return;
		IL_0173:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v10+B8]");
			obj6 = 0;
		}
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)176;
		Action<object> action = default(Action<object>);
		action..ctor(obj6, (IntPtr)obj11);
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v9+B8]");
		object obj13 = (nint)0 + (nint)8;
		obj13 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		KammelnaRequests.GetClanLogoElements(action);
		return;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v1+B8]");
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X9_v2+8]");
		callback = (Action<KammelnaResponseModel<List<ClanLogoElementViewModel>>>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X9_v2+8]");
		if ((nint)0 != 0)
		{
			goto IL_00c1;
		}
		goto IL_0173;
	}

	static ClanLogoElementCatalog()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_009b: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1264;
		object obj3 = typeof(List<Tween>) + 2904;
		object obj4 = (nint)0 + (nint)2264;
		object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @399769C");
		object obj6 = obj5;
		object obj8 = default(object);
		object obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
