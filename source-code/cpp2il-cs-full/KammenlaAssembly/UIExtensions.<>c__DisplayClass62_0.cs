using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using GoogleMobileAds.Ump.Api;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Server.Models.Products;
using Sfs2X.Entities;
using UI.Loading;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.UI;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore;
using UnityEngine.UI;
using UnityStandardAssets.ImageEffects;

public static class UIExtensions
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Image, bool> <>9__2_1;

		public static Func<SpriteRenderer, bool> <>9__3_1;

		public static Func<Image, bool> <>9__6_1;

		public static Func<Image, bool> <>9__11_1;

		public static Func<Transform, IEnumerable<Transform>> <>9__41_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 704;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <LoadItemImage>b__2_1(Image image)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0065: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return image != null;
		}

		internal bool <LoadItemImage>b__3_1(SpriteRenderer image)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0065: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return image != null;
		}

		internal bool <LoadProfileGiftImage>b__6_1(Image image)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0065: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return image != null;
		}

		internal bool <LoadAchievementImage>b__11_1(Image image)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0065: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return image != null;
		}

		internal IEnumerable<Transform> <DescendantsAndSelf>b__41_0(Transform x)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 936;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			_ = 4294967294L;
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			object obj3 = obj2 + 48;
			obj3 = x;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (IEnumerable<Transform>)obj2;
		}
	}

	private sealed class <>c__DisplayClass0_0
	{
		public Image img;

		public bool setNative;

		public Action<bool> onSuccess;

		internal void <LoadImage>b__0(Sprite sprite)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00e9: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			//IL_0128: Expected O, but got I4
			//IL_0215: Expected O, but got I4
			//IL_0255: Expected O, but got I4
			//IL_0294: Expected O, but got I
			//IL_02a4: Expected O, but got I
			//IL_02b4: Expected O, but got I
			//IL_01db: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5EC9]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v19+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v19+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = sprite != null;
			bool flag3 = !flag2;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (!flag3)
			{
				goto IL_013b;
			}
			goto IL_0223;
			IL_0191:
			img.sprite = sprite;
			if (setNative)
			{
				img.SetNativeSize();
			}
			Action<bool> action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 1;
				goto IL_0284;
			}
			return;
			IL_0223:
			action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 0;
				goto IL_0284;
			}
			return;
			IL_0284:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+18]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+40]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+28]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v160 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
			IL_0074:
			bool flag4 = sprite != null;
			bool flag5 = !flag4;
			object obj11 = !flag5;
			obj5 = 0;
			obj6 = null;
			if (obj11 != null)
			{
				goto IL_013b;
			}
			goto IL_0223;
			IL_013b:
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				if (img != null)
				{
					goto IL_0191;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag6 = img != null;
				bool flag7 = !flag6;
				object obj13 = !flag7;
				if (obj13 != null)
				{
					goto IL_0191;
				}
			}
			goto IL_0223;
		}
	}

	private sealed class <>c__DisplayClass10_0
	{
		public Image img;

		public Action<bool> onSuccess;

		internal void <LoadAchievementImage>b__0(Sprite s)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00e9: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			//IL_0128: Expected O, but got I4
			//IL_020c: Expected O, but got I4
			//IL_024c: Expected O, but got I4
			//IL_01d2: Expected O, but got I4
			//IL_0262: Expected O, but got I
			//IL_0272: Expected O, but got I
			//IL_0282: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5ECA]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v15+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v15+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = s != null;
			bool flag3 = !flag2;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (!flag3)
			{
				goto IL_013b;
			}
			goto IL_021a;
			IL_0191:
			img.sprite = s;
			Action<bool> action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 1;
				goto IL_0252;
			}
			return;
			IL_0252:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v2 (System.Action`1<System.Boolean>)+18]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v2 (System.Action`1<System.Boolean>)+40]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v2 (System.Action`1<System.Boolean>)+28]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v120 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
			IL_021a:
			action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 0;
				goto IL_0252;
			}
			return;
			IL_0074:
			bool flag4 = s != null;
			bool flag5 = !flag4;
			object obj11 = !flag5;
			obj5 = 0;
			obj6 = null;
			if (obj11 != null)
			{
				goto IL_013b;
			}
			goto IL_021a;
			IL_013b:
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				if (img != null)
				{
					goto IL_0191;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag6 = img != null;
				bool flag7 = !flag6;
				object obj13 = !flag7;
				if (obj13 != null)
				{
					goto IL_0191;
				}
			}
			goto IL_021a;
		}
	}

	private sealed class <>c__DisplayClass11_0
	{
		public List<Image> imageList;

		public Action<bool> onSuccess;

		internal void <LoadAchievementImage>b__0(Sprite s)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_0105: Expected O, but got I4
			//IL_0113: Expected O, but got I4
			//IL_0121: Expected O, but got I4
			//IL_00b4: Expected O, but got I4
			//IL_00bd: Expected O, but got I4
			//IL_0074: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Expected O, but got Unknown
			//IL_032e: Expected O, but got I
			//IL_033e: Expected O, but got I
			//IL_034e: Expected O, but got I
			//IL_0370: Expected O, but got I4
			//IL_0160: Expected O, but got I4
			//IL_01c8: Expected O, but got I
			//IL_01d8: Expected O, but got I
			//IL_01e8: Expected O, but got I
			//IL_03a8: Expected O, but got I4
			//IL_0589: Unknown result type (might be due to invalid IL or missing references)
			//IL_058e: Expected O, but got Unknown
			//IL_05a4: Expected O, but got I
			//IL_05b5: Expected I, but got O
			//IL_05d3: Expected O, but got I
			//IL_045d: Expected O, but got I
			//IL_046d: Expected O, but got I
			//IL_047d: Expected O, but got I
			//IL_040e: Expected O, but got I4
			//IL_03d8: Expected O, but got I
			//IL_028c: Expected O, but got I
			//IL_04ed: Expected O, but got I
			//IL_049b: Expected O, but got I4
			//IL_02c4: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5ECB]");
			object obj2 = (nint)0 & (nint)1;
			Image image;
			Image image2;
			List<object>.Enumerator enumerator;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v47+E4]");
				bool flag = (nint)0 == 0;
				image = null;
				enumerator = (List<object>.Enumerator)0;
				image2 = null;
				enumerator = (List<object>.Enumerator)0;
				if (!flag)
				{
					goto IL_0090;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v47+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				image = null;
				enumerator = (List<object>.Enumerator)0;
				image2 = null;
				enumerator = (List<object>.Enumerator)0;
				if (obj4 != null)
				{
					goto IL_0090;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = s != null;
			bool flag4 = !flag3;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			image = image2;
			if (!flag4)
			{
				goto IL_017b;
			}
			goto IL_0424;
			IL_0215:
			object obj8;
			object obj7 = obj8;
			Func<object, bool> func;
			bool flag5 = Enumerable.All(imageList, func);
			bool flag6 = !flag5;
			Func<object, bool> func2 = func;
			if (!flag6)
			{
				goto IL_0251;
			}
			goto IL_0424;
			IL_02d8:
			Action<bool> action = onSuccess;
			if (onSuccess != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v226 @ X8_v23 (System.Action`1<System.Boolean>)+18] (should have been resolved before IL gen)");
			}
			return;
			IL_0424:
			Action<bool> action2 = onSuccess;
			if (onSuccess != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v4 (System.Action`1<System.Boolean>)+18]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v4 (System.Action`1<System.Boolean>)+40]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v4 (System.Action`1<System.Boolean>)+28]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v152 @ X3_v3 (should have been resolved before IL gen)");
			}
			return;
			IL_0090:
			bool flag7 = s != null;
			bool flag8 = !flag7;
			object obj12 = !flag8;
			obj5 = 0;
			obj6 = null;
			if (obj12 != null)
			{
				goto IL_017b;
			}
			goto IL_0424;
			IL_017b:
			object obj13 = typeof(TrackedDeviceRaycaster.<>c) + 704;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v6+E4]");
			object obj15;
			object obj16;
			if ((nint)0 != 0)
			{
				obj8 = (nint)0 + (nint)1880;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v6+B8]");
				obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v8+20]");
				func = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v8+20]");
				bool flag9 = (nint)0 == 0;
				obj16 = obj8;
				if (!flag9)
				{
					goto IL_0215;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj14 = obj13;
				obj8 = (nint)0 + (nint)1880;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v6+B8]");
				obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v8+20]");
				func = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v8+20]");
				bool flag10 = (nint)0 == 0;
				object obj17 = !flag10;
				obj16 = obj8;
				if (obj17 != null)
				{
					goto IL_0215;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v6+E4]");
			bool flag11 = (nint)0 == 0;
			object obj18 = !flag11;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj19 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v14+B8]");
				obj15 = 0;
			}
			object obj20 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1760;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj21 = (nint)0 + (nint)1472;
			Func<object, bool> func3 = default(Func<object, bool>);
			func3..ctor(obj15, (IntPtr)obj21);
			object obj22 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v13+B8]");
			object obj23 = (nint)0 + (nint)32;
			obj23 = func3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj7 = obj16;
			bool flag12 = Enumerable.All(imageList, func3);
			bool flag13 = !flag12;
			object obj24 = !flag13;
			func2 = func3;
			if (obj24 != null)
			{
				goto IL_0251;
			}
			goto IL_0424;
			IL_053a:
			NullReferenceException ex = new NullReferenceException();
			bool flag14 = (nint)func2 != 1;
			NullReferenceException ex2 = ex;
			object obj27;
			if (!flag14)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				object obj25 = (nint)0 + (nint)2120;
				func2 = (Func<object, bool>)obj25;
				enumerator.Dispose();
				object obj26 = default(object);
				if (obj26 == null)
				{
					goto IL_02d8;
				}
				OutOfMemoryException ex3 = new OutOfMemoryException();
				obj27 = obj26;
				ex2 = (NullReferenceException)(object)ex3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2237004");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_0488:
			NullReferenceException ex4 = new NullReferenceException();
			obj27 = 0;
			goto IL_053a;
			IL_0251:
			if (imageList != null)
			{
				List<object>.Enumerator enumerator2 = ((List<object>)(object)imageList).GetEnumerator();
				object obj28 = (nint)0 + (nint)2128;
				while (true)
				{
					func2 = (Func<object, bool>)obj28;
					if (!enumerator.MoveNext())
					{
						break;
					}
					if ((object)image != null)
					{
						image.sprite = s;
						obj7 = 0;
						continue;
					}
					goto IL_0488;
				}
				enumerator.Dispose();
				goto IL_02d8;
			}
			goto IL_053a;
		}
	}

	private sealed class <>c__DisplayClass12_0
	{
		public Image img;

		public bool setNative;

		public Action<bool> onSuccess;

		internal void <LoadHighlightImage>b__0(Sprite s)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00e9: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			//IL_0128: Expected O, but got I4
			//IL_0215: Expected O, but got I4
			//IL_0255: Expected O, but got I4
			//IL_0294: Expected O, but got I
			//IL_02a4: Expected O, but got I
			//IL_02b4: Expected O, but got I
			//IL_01db: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5ECC]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v19+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v19+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = s != null;
			bool flag3 = !flag2;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (!flag3)
			{
				goto IL_013b;
			}
			goto IL_0223;
			IL_0191:
			img.sprite = s;
			if (setNative)
			{
				img.SetNativeSize();
			}
			Action<bool> action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 1;
				goto IL_0284;
			}
			return;
			IL_0223:
			action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 0;
				goto IL_0284;
			}
			return;
			IL_0284:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+18]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+40]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+28]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v160 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
			IL_0074:
			bool flag4 = s != null;
			bool flag5 = !flag4;
			object obj11 = !flag5;
			obj5 = 0;
			obj6 = null;
			if (obj11 != null)
			{
				goto IL_013b;
			}
			goto IL_0223;
			IL_013b:
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				if (img != null)
				{
					goto IL_0191;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag6 = img != null;
				bool flag7 = !flag6;
				object obj13 = !flag7;
				if (obj13 != null)
				{
					goto IL_0191;
				}
			}
			goto IL_0223;
		}
	}

	private sealed class <>c__DisplayClass13_0
	{
		public Image img;

		public bool setNative;

		public Action<bool> onSuccess;

		internal void <LoadNotificationImage>b__0(Sprite s)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00e9: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			//IL_0128: Expected O, but got I4
			//IL_0215: Expected O, but got I4
			//IL_0255: Expected O, but got I4
			//IL_0294: Expected O, but got I
			//IL_02a4: Expected O, but got I
			//IL_02b4: Expected O, but got I
			//IL_01db: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5ECD]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v19+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v19+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = s != null;
			bool flag3 = !flag2;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (!flag3)
			{
				goto IL_013b;
			}
			goto IL_0223;
			IL_0191:
			img.sprite = s;
			if (setNative)
			{
				img.SetNativeSize();
			}
			Action<bool> action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 1;
				goto IL_0284;
			}
			return;
			IL_0223:
			action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 0;
				goto IL_0284;
			}
			return;
			IL_0284:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+18]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+40]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+28]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v160 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
			IL_0074:
			bool flag4 = s != null;
			bool flag5 = !flag4;
			object obj11 = !flag5;
			obj5 = 0;
			obj6 = null;
			if (obj11 != null)
			{
				goto IL_013b;
			}
			goto IL_0223;
			IL_013b:
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				if (img != null)
				{
					goto IL_0191;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag6 = img != null;
				bool flag7 = !flag6;
				object obj13 = !flag7;
				if (obj13 != null)
				{
					goto IL_0191;
				}
			}
			goto IL_0223;
		}
	}

	private sealed class <>c__DisplayClass14_0
	{
		public Image img;

		public bool setNative;

		public Action<bool> onSuccess;

		internal void <LoadMassTournamentImage>b__0(Sprite s)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00e9: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			//IL_0128: Expected O, but got I4
			//IL_0215: Expected O, but got I4
			//IL_0255: Expected O, but got I4
			//IL_0294: Expected O, but got I
			//IL_02a4: Expected O, but got I
			//IL_02b4: Expected O, but got I
			//IL_01db: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5ECE]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v19+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v19+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = s != null;
			bool flag3 = !flag2;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (!flag3)
			{
				goto IL_013b;
			}
			goto IL_0223;
			IL_0191:
			img.sprite = s;
			if (setNative)
			{
				img.SetNativeSize();
			}
			Action<bool> action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 1;
				goto IL_0284;
			}
			return;
			IL_0223:
			action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 0;
				goto IL_0284;
			}
			return;
			IL_0284:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+18]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+40]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+28]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v160 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
			IL_0074:
			bool flag4 = s != null;
			bool flag5 = !flag4;
			object obj11 = !flag5;
			obj5 = 0;
			obj6 = null;
			if (obj11 != null)
			{
				goto IL_013b;
			}
			goto IL_0223;
			IL_013b:
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				if (img != null)
				{
					goto IL_0191;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag6 = img != null;
				bool flag7 = !flag6;
				object obj13 = !flag7;
				if (obj13 != null)
				{
					goto IL_0191;
				}
			}
			goto IL_0223;
		}
	}

	private sealed class <>c__DisplayClass15_0
	{
		public Image img;

		public bool setNative;

		public Action<bool> onSuccess;

		internal void <LoadMassTournamentPrizeImage>b__0(Sprite s)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00e9: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			//IL_0128: Expected O, but got I4
			//IL_0215: Expected O, but got I4
			//IL_0255: Expected O, but got I4
			//IL_0294: Expected O, but got I
			//IL_02a4: Expected O, but got I
			//IL_02b4: Expected O, but got I
			//IL_01db: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5ECF]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v19+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v19+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = s != null;
			bool flag3 = !flag2;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (!flag3)
			{
				goto IL_013b;
			}
			goto IL_0223;
			IL_0191:
			img.sprite = s;
			if (setNative)
			{
				img.SetNativeSize();
			}
			Action<bool> action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 1;
				goto IL_0284;
			}
			return;
			IL_0223:
			action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 0;
				goto IL_0284;
			}
			return;
			IL_0284:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+18]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+40]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+28]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v160 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
			IL_0074:
			bool flag4 = s != null;
			bool flag5 = !flag4;
			object obj11 = !flag5;
			obj5 = 0;
			obj6 = null;
			if (obj11 != null)
			{
				goto IL_013b;
			}
			goto IL_0223;
			IL_013b:
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				if (img != null)
				{
					goto IL_0191;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag6 = img != null;
				bool flag7 = !flag6;
				object obj13 = !flag7;
				if (obj13 != null)
				{
					goto IL_0191;
				}
			}
			goto IL_0223;
		}
	}

	private sealed class <>c__DisplayClass16_0
	{
		public Image img;

		public bool setNative;

		public Action<bool> onSuccess;

		internal void <LoadMassTournamentBannerImage>b__0(Sprite s)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00e9: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			//IL_0128: Expected O, but got I4
			//IL_0215: Expected O, but got I4
			//IL_0255: Expected O, but got I4
			//IL_0294: Expected O, but got I
			//IL_02a4: Expected O, but got I
			//IL_02b4: Expected O, but got I
			//IL_01db: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5ED0]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v19+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v19+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = s != null;
			bool flag3 = !flag2;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (!flag3)
			{
				goto IL_013b;
			}
			goto IL_0223;
			IL_0191:
			img.sprite = s;
			if (setNative)
			{
				img.SetNativeSize();
			}
			Action<bool> action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 1;
				goto IL_0284;
			}
			return;
			IL_0223:
			action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 0;
				goto IL_0284;
			}
			return;
			IL_0284:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+18]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+40]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+28]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v160 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
			IL_0074:
			bool flag4 = s != null;
			bool flag5 = !flag4;
			object obj11 = !flag5;
			obj5 = 0;
			obj6 = null;
			if (obj11 != null)
			{
				goto IL_013b;
			}
			goto IL_0223;
			IL_013b:
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				if (img != null)
				{
					goto IL_0191;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag6 = img != null;
				bool flag7 = !flag6;
				object obj13 = !flag7;
				if (obj13 != null)
				{
					goto IL_0191;
				}
			}
			goto IL_0223;
		}
	}

	private sealed class <>c__DisplayClass17_0
	{
		public Image img;

		public bool setNative;

		public Action<bool> onSuccess;

		public ILoadingIndicator loading;

		internal void <LoadPredictAndWinImage>b__0(Sprite s)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00e9: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			//IL_0128: Expected O, but got I4
			//IL_0215: Expected O, but got I4
			//IL_0255: Expected O, but got I4
			//IL_0269: Unknown result type (might be due to invalid IL or missing references)
			//IL_026e: Expected O, but got Unknown
			//IL_0276: Expected I, but got O
			//IL_0286: Expected O, but got I
			//IL_01db: Expected O, but got I4
			//IL_02c1: Expected O, but got I
			//IL_0320: Unknown result type (might be due to invalid IL or missing references)
			//IL_0325: Expected O, but got Unknown
			//IL_032d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0332: Expected O, but got Unknown
			//IL_033b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0340: Expected O, but got Unknown
			//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d4: Expected O, but got Unknown
			//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e2: Expected O, but got Unknown
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5ED1]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v25+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v25+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = s != null;
			bool flag3 = !flag2;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (!flag3)
			{
				goto IL_013b;
			}
			goto IL_0223;
			IL_034a:
			Action<bool> action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 1;
				goto IL_0373;
			}
			goto IL_0382;
			IL_0223:
			action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 0;
				goto IL_0373;
			}
			goto IL_0382;
			IL_0302:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v215 @ X0_v3] (should have been resolved before IL gen)");
			return;
			IL_0074:
			bool flag4 = s != null;
			bool flag5 = !flag4;
			object obj8 = !flag5;
			obj5 = 0;
			obj6 = null;
			if (obj8 != null)
			{
				goto IL_013b;
			}
			goto IL_0223;
			IL_013b:
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v11+E4]");
			if ((nint)0 != 0)
			{
				if (img != null)
				{
					goto IL_0191;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag6 = img != null;
				bool flag7 = !flag6;
				object obj10 = !flag7;
				if (obj10 != null)
				{
					goto IL_0191;
				}
			}
			goto IL_0223;
			IL_0382:
			ILoadingIndicator loadingIndicator = loading;
			if (loading == null)
			{
				return;
			}
			object obj11 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3528;
			nint num = (nint)loadingIndicator;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v5 (Il2CppClass<UI.Loading.ILoadingIndicator>)+12E]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v5 (Il2CppClass<UI.Loading.ILoadingIndicator>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0302;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v5 (Il2CppClass<UI.Loading.ILoadingIndicator>)+B0]");
			object obj13 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X10_v4-8]");
				if (0 == (nint)obj11)
				{
					break;
				}
				obj13 += 16;
				obj12--;
				if ((nint)obj12 != 1)
				{
					continue;
				}
				goto IL_0302;
			}
			object obj14 = obj13 + 1;
			object obj15 = num + obj14;
			object obj16 = obj15 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v302 @ X0_v5] (should have been resolved before IL gen)");
			goto IL_034a;
			IL_0373:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v156 @ X8_v7 (System.Action`1<System.Boolean>)+18] (should have been resolved before IL gen)");
			goto IL_0382;
			IL_0191:
			img.sprite = s;
			if (setNative)
			{
				img.SetNativeSize();
			}
			goto IL_034a;
		}
	}

	private sealed class <>c__DisplayClass18_0
	{
		public Image img;

		public Action<bool> onSuccess;

		internal void <LoadPredictionSeasonImage>b__0(Sprite s)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00e9: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			//IL_0128: Expected O, but got I4
			//IL_020c: Expected O, but got I4
			//IL_024c: Expected O, but got I4
			//IL_01d2: Expected O, but got I4
			//IL_0262: Expected O, but got I
			//IL_0272: Expected O, but got I
			//IL_0282: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5ED2]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v15+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v15+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = s != null;
			bool flag3 = !flag2;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (!flag3)
			{
				goto IL_013b;
			}
			goto IL_021a;
			IL_0191:
			img.sprite = s;
			Action<bool> action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 1;
				goto IL_0252;
			}
			return;
			IL_0252:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v2 (System.Action`1<System.Boolean>)+18]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v2 (System.Action`1<System.Boolean>)+40]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v2 (System.Action`1<System.Boolean>)+28]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v120 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
			IL_021a:
			action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 0;
				goto IL_0252;
			}
			return;
			IL_0074:
			bool flag4 = s != null;
			bool flag5 = !flag4;
			object obj11 = !flag5;
			obj5 = 0;
			obj6 = null;
			if (obj11 != null)
			{
				goto IL_013b;
			}
			goto IL_021a;
			IL_013b:
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				if (img != null)
				{
					goto IL_0191;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag6 = img != null;
				bool flag7 = !flag6;
				object obj13 = !flag7;
				if (obj13 != null)
				{
					goto IL_0191;
				}
			}
			goto IL_021a;
		}
	}

	private sealed class <>c__DisplayClass19_0
	{
		public Image img;

		public bool setNative;

		public Action<bool> onSuccess;

		public ILoadingIndicator loading;

		internal void <LoadSportTeamImage>b__0(Sprite s)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00e9: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			//IL_0128: Expected O, but got I4
			//IL_0215: Expected O, but got I4
			//IL_0255: Expected O, but got I4
			//IL_0269: Unknown result type (might be due to invalid IL or missing references)
			//IL_026e: Expected O, but got Unknown
			//IL_0276: Expected I, but got O
			//IL_0286: Expected O, but got I
			//IL_01db: Expected O, but got I4
			//IL_02c1: Expected O, but got I
			//IL_0320: Unknown result type (might be due to invalid IL or missing references)
			//IL_0325: Expected O, but got Unknown
			//IL_032d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0332: Expected O, but got Unknown
			//IL_033b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0340: Expected O, but got Unknown
			//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d4: Expected O, but got Unknown
			//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e2: Expected O, but got Unknown
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5ED3]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v25+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v25+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = s != null;
			bool flag3 = !flag2;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (!flag3)
			{
				goto IL_013b;
			}
			goto IL_0223;
			IL_034a:
			Action<bool> action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 1;
				goto IL_0373;
			}
			goto IL_0382;
			IL_0223:
			action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 0;
				goto IL_0373;
			}
			goto IL_0382;
			IL_0302:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v215 @ X0_v3] (should have been resolved before IL gen)");
			return;
			IL_0074:
			bool flag4 = s != null;
			bool flag5 = !flag4;
			object obj8 = !flag5;
			obj5 = 0;
			obj6 = null;
			if (obj8 != null)
			{
				goto IL_013b;
			}
			goto IL_0223;
			IL_013b:
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v11+E4]");
			if ((nint)0 != 0)
			{
				if (img != null)
				{
					goto IL_0191;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag6 = img != null;
				bool flag7 = !flag6;
				object obj10 = !flag7;
				if (obj10 != null)
				{
					goto IL_0191;
				}
			}
			goto IL_0223;
			IL_0382:
			ILoadingIndicator loadingIndicator = loading;
			if (loading == null)
			{
				return;
			}
			object obj11 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3528;
			nint num = (nint)loadingIndicator;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v5 (Il2CppClass<UI.Loading.ILoadingIndicator>)+12E]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v5 (Il2CppClass<UI.Loading.ILoadingIndicator>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0302;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v5 (Il2CppClass<UI.Loading.ILoadingIndicator>)+B0]");
			object obj13 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X10_v4-8]");
				if (0 == (nint)obj11)
				{
					break;
				}
				obj13 += 16;
				obj12--;
				if ((nint)obj12 != 1)
				{
					continue;
				}
				goto IL_0302;
			}
			object obj14 = obj13 + 1;
			object obj15 = num + obj14;
			object obj16 = obj15 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v302 @ X0_v5] (should have been resolved before IL gen)");
			goto IL_034a;
			IL_0373:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v156 @ X8_v7 (System.Action`1<System.Boolean>)+18] (should have been resolved before IL gen)");
			goto IL_0382;
			IL_0191:
			img.sprite = s;
			if (setNative)
			{
				img.SetNativeSize();
			}
			goto IL_034a;
		}
	}

	private sealed class <>c__DisplayClass1_0
	{
		public Image img;

		public FilterMode filterMode;

		public Action<bool> onSuccess;

		internal void <LoadItemImage>b__0(Sprite s)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00e9: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			//IL_0128: Expected O, but got I4
			//IL_0251: Expected O, but got I4
			//IL_0291: Expected O, but got I4
			//IL_02a7: Expected O, but got I
			//IL_02b7: Expected O, but got I
			//IL_02c7: Expected O, but got I
			//IL_0217: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5ED4]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v19+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v19+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = s != null;
			bool flag3 = !flag2;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (!flag3)
			{
				goto IL_013b;
			}
			goto IL_025f;
			IL_0191:
			if (filterMode != FilterMode.Point)
			{
				Texture2D texture = s.texture;
				texture.filterMode = filterMode;
			}
			img.sprite = s;
			Action<bool> action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 1;
				goto IL_0297;
			}
			return;
			IL_025f:
			action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 0;
				goto IL_0297;
			}
			return;
			IL_0297:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v2 (System.Action`1<System.Boolean>)+18]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v2 (System.Action`1<System.Boolean>)+40]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v2 (System.Action`1<System.Boolean>)+28]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v120 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
			IL_0074:
			bool flag4 = s != null;
			bool flag5 = !flag4;
			object obj11 = !flag5;
			obj5 = 0;
			obj6 = null;
			if (obj11 != null)
			{
				goto IL_013b;
			}
			goto IL_025f;
			IL_013b:
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				if (img != null)
				{
					goto IL_0191;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag6 = img != null;
				bool flag7 = !flag6;
				object obj13 = !flag7;
				if (obj13 != null)
				{
					goto IL_0191;
				}
			}
			goto IL_025f;
		}
	}

	private sealed class <>c__DisplayClass20_0
	{
		public Image img;

		public bool setNative;

		public Action<bool> onSuccess;

		internal void <LoadProductImage>b__0(Sprite s)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00e9: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			//IL_0128: Expected O, but got I4
			//IL_0215: Expected O, but got I4
			//IL_0255: Expected O, but got I4
			//IL_0294: Expected O, but got I
			//IL_02a4: Expected O, but got I
			//IL_02b4: Expected O, but got I
			//IL_01db: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5ED5]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v19+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v19+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = s != null;
			bool flag3 = !flag2;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (!flag3)
			{
				goto IL_013b;
			}
			goto IL_0223;
			IL_0191:
			img.sprite = s;
			if (setNative)
			{
				img.SetNativeSize();
			}
			Action<bool> action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 1;
				goto IL_0284;
			}
			return;
			IL_0223:
			action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 0;
				goto IL_0284;
			}
			return;
			IL_0284:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+18]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+40]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+28]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v160 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
			IL_0074:
			bool flag4 = s != null;
			bool flag5 = !flag4;
			object obj11 = !flag5;
			obj5 = 0;
			obj6 = null;
			if (obj11 != null)
			{
				goto IL_013b;
			}
			goto IL_0223;
			IL_013b:
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				if (img != null)
				{
					goto IL_0191;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag6 = img != null;
				bool flag7 = !flag6;
				object obj13 = !flag7;
				if (obj13 != null)
				{
					goto IL_0191;
				}
			}
			goto IL_0223;
		}
	}

	private sealed class <>c__DisplayClass21_0
	{
		public Image img;

		public bool setNative;

		public Action<bool> onSuccess;

		internal void <LoadStoreBannerImage>b__0(Sprite s)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00e9: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			//IL_0128: Expected O, but got I4
			//IL_0215: Expected O, but got I4
			//IL_0255: Expected O, but got I4
			//IL_0294: Expected O, but got I
			//IL_02a4: Expected O, but got I
			//IL_02b4: Expected O, but got I
			//IL_01db: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5ED6]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v19+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v19+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = s != null;
			bool flag3 = !flag2;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (!flag3)
			{
				goto IL_013b;
			}
			goto IL_0223;
			IL_0191:
			img.sprite = s;
			if (setNative)
			{
				img.SetNativeSize();
			}
			Action<bool> action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 1;
				goto IL_0284;
			}
			return;
			IL_0223:
			action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 0;
				goto IL_0284;
			}
			return;
			IL_0284:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+18]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+40]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+28]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v160 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
			IL_0074:
			bool flag4 = s != null;
			bool flag5 = !flag4;
			object obj11 = !flag5;
			obj5 = 0;
			obj6 = null;
			if (obj11 != null)
			{
				goto IL_013b;
			}
			goto IL_0223;
			IL_013b:
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				if (img != null)
				{
					goto IL_0191;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag6 = img != null;
				bool flag7 = !flag6;
				object obj13 = !flag7;
				if (obj13 != null)
				{
					goto IL_0191;
				}
			}
			goto IL_0223;
		}
	}

	private sealed class <>c__DisplayClass24_0
	{
		public Image image;

		internal void <AssignAvatarImage>g__AssignAvatar|0(Sprite sprite)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0118: Expected O, but got I4
			//IL_019f: Expected O, but got I4
			//IL_0166: Expected O, but got I4
			object obj = 152981504;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5ED7]");
			object obj3 = (nint)0 & (nint)1;
			Image image;
			Image image2;
			if (obj3 != null)
			{
				image = this.image;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
				bool flag = (nint)0 == 0;
				image2 = this.image;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				image = this.image;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				image2 = this.image;
				if (obj5 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = sprite;
			bool flag4 = !flag3;
			object obj6 = !flag4;
			image = image2;
			if (obj6 != null)
			{
				goto IL_00c3;
			}
			goto IL_017c;
			IL_00c3:
			Sprite sprite2 = sprite;
			goto IL_00d0;
			IL_00d0:
			image.sprite = sprite2;
			return;
			IL_017c:
			Sprite avatarPlaceholder = ImageCacher.AvatarPlaceholder;
			bool flag5 = (object)image2 == null;
			object obj7 = !flag5;
			image = image2;
			sprite2 = avatarPlaceholder;
			if (obj7 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_00d0;
			IL_0091:
			flag3 = sprite;
			bool flag6 = !flag3;
			image2 = image;
			if (!flag6)
			{
				goto IL_00c3;
			}
			goto IL_017c;
		}
	}

	private sealed class <>c__DisplayClass2_0
	{
		public List<Image> imageList;

		public Action<bool> onSuccess;

		internal void <LoadItemImage>b__0(Sprite s)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_0105: Expected O, but got I4
			//IL_0113: Expected O, but got I4
			//IL_0121: Expected O, but got I4
			//IL_00b4: Expected O, but got I4
			//IL_00bd: Expected O, but got I4
			//IL_0074: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Expected O, but got Unknown
			//IL_032e: Expected O, but got I
			//IL_033e: Expected O, but got I
			//IL_034e: Expected O, but got I
			//IL_0370: Expected O, but got I4
			//IL_0160: Expected O, but got I4
			//IL_01c8: Expected O, but got I
			//IL_01d8: Expected O, but got I
			//IL_01e8: Expected O, but got I
			//IL_03a8: Expected O, but got I4
			//IL_0589: Unknown result type (might be due to invalid IL or missing references)
			//IL_058e: Expected O, but got Unknown
			//IL_05a4: Expected O, but got I
			//IL_05b5: Expected I, but got O
			//IL_05d3: Expected O, but got I
			//IL_045d: Expected O, but got I
			//IL_046d: Expected O, but got I
			//IL_047d: Expected O, but got I
			//IL_040e: Expected O, but got I4
			//IL_03d8: Expected O, but got I
			//IL_028c: Expected O, but got I
			//IL_04ed: Expected O, but got I
			//IL_049b: Expected O, but got I4
			//IL_02c4: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5ED8]");
			object obj2 = (nint)0 & (nint)1;
			Image image;
			Image image2;
			List<object>.Enumerator enumerator;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v47+E4]");
				bool flag = (nint)0 == 0;
				image = null;
				enumerator = (List<object>.Enumerator)0;
				image2 = null;
				enumerator = (List<object>.Enumerator)0;
				if (!flag)
				{
					goto IL_0090;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v47+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				image = null;
				enumerator = (List<object>.Enumerator)0;
				image2 = null;
				enumerator = (List<object>.Enumerator)0;
				if (obj4 != null)
				{
					goto IL_0090;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = s != null;
			bool flag4 = !flag3;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			image = image2;
			if (!flag4)
			{
				goto IL_017b;
			}
			goto IL_0424;
			IL_0215:
			object obj8;
			object obj7 = obj8;
			Func<object, bool> func;
			bool flag5 = Enumerable.All(imageList, func);
			bool flag6 = !flag5;
			Func<object, bool> func2 = func;
			if (!flag6)
			{
				goto IL_0251;
			}
			goto IL_0424;
			IL_02d8:
			Action<bool> action = onSuccess;
			if (onSuccess != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v226 @ X8_v23 (System.Action`1<System.Boolean>)+18] (should have been resolved before IL gen)");
			}
			return;
			IL_0424:
			Action<bool> action2 = onSuccess;
			if (onSuccess != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v4 (System.Action`1<System.Boolean>)+18]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v4 (System.Action`1<System.Boolean>)+40]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v4 (System.Action`1<System.Boolean>)+28]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v152 @ X3_v3 (should have been resolved before IL gen)");
			}
			return;
			IL_0090:
			bool flag7 = s != null;
			bool flag8 = !flag7;
			object obj12 = !flag8;
			obj5 = 0;
			obj6 = null;
			if (obj12 != null)
			{
				goto IL_017b;
			}
			goto IL_0424;
			IL_017b:
			object obj13 = typeof(TrackedDeviceRaycaster.<>c) + 704;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v6+E4]");
			object obj15;
			object obj16;
			if ((nint)0 != 0)
			{
				obj8 = (nint)0 + (nint)1880;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v6+B8]");
				obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v8+8]");
				func = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v8+8]");
				bool flag9 = (nint)0 == 0;
				obj16 = obj8;
				if (!flag9)
				{
					goto IL_0215;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj14 = obj13;
				obj8 = (nint)0 + (nint)1880;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v6+B8]");
				obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v8+8]");
				func = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v8+8]");
				bool flag10 = (nint)0 == 0;
				object obj17 = !flag10;
				obj16 = obj8;
				if (obj17 != null)
				{
					goto IL_0215;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v6+E4]");
			bool flag11 = (nint)0 == 0;
			object obj18 = !flag11;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj19 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v14+B8]");
				obj15 = 0;
			}
			object obj20 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1760;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj21 = (nint)0 + (nint)1480;
			Func<object, bool> func3 = default(Func<object, bool>);
			func3..ctor(obj15, (IntPtr)obj21);
			object obj22 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v13+B8]");
			object obj23 = (nint)0 + (nint)8;
			obj23 = func3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj7 = obj16;
			bool flag12 = Enumerable.All(imageList, func3);
			bool flag13 = !flag12;
			object obj24 = !flag13;
			func2 = func3;
			if (obj24 != null)
			{
				goto IL_0251;
			}
			goto IL_0424;
			IL_053a:
			NullReferenceException ex = new NullReferenceException();
			bool flag14 = (nint)func2 != 1;
			NullReferenceException ex2 = ex;
			object obj27;
			if (!flag14)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				object obj25 = (nint)0 + (nint)2120;
				func2 = (Func<object, bool>)obj25;
				enumerator.Dispose();
				object obj26 = default(object);
				if (obj26 == null)
				{
					goto IL_02d8;
				}
				OutOfMemoryException ex3 = new OutOfMemoryException();
				obj27 = obj26;
				ex2 = (NullReferenceException)(object)ex3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2237004");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_0488:
			NullReferenceException ex4 = new NullReferenceException();
			obj27 = 0;
			goto IL_053a;
			IL_0251:
			if (imageList != null)
			{
				List<object>.Enumerator enumerator2 = ((List<object>)(object)imageList).GetEnumerator();
				object obj28 = (nint)0 + (nint)2128;
				while (true)
				{
					func2 = (Func<object, bool>)obj28;
					if (!enumerator.MoveNext())
					{
						break;
					}
					if ((object)image != null)
					{
						image.sprite = s;
						obj7 = 0;
						continue;
					}
					goto IL_0488;
				}
				enumerator.Dispose();
				goto IL_02d8;
			}
			goto IL_053a;
		}
	}

	private sealed class <>c__DisplayClass3_0
	{
		public List<SpriteRenderer> imageList;

		public Action<bool> onSuccess;

		internal void <LoadItemImage>b__0(Sprite s)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_0105: Expected O, but got I4
			//IL_0113: Expected O, but got I4
			//IL_0121: Expected O, but got I4
			//IL_00b4: Expected O, but got I4
			//IL_00bd: Expected O, but got I4
			//IL_0074: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Expected O, but got Unknown
			//IL_032e: Expected O, but got I
			//IL_033e: Expected O, but got I
			//IL_034e: Expected O, but got I
			//IL_0370: Expected O, but got I4
			//IL_0160: Expected O, but got I4
			//IL_01c8: Expected O, but got I
			//IL_01d8: Expected O, but got I
			//IL_01e8: Expected O, but got I
			//IL_03a8: Expected O, but got I4
			//IL_0589: Unknown result type (might be due to invalid IL or missing references)
			//IL_058e: Expected O, but got Unknown
			//IL_05a4: Expected O, but got I
			//IL_05b5: Expected I, but got O
			//IL_05d3: Expected O, but got I
			//IL_045d: Expected O, but got I
			//IL_046d: Expected O, but got I
			//IL_047d: Expected O, but got I
			//IL_040e: Expected O, but got I4
			//IL_03d8: Expected O, but got I
			//IL_028c: Expected O, but got I
			//IL_04ed: Expected O, but got I
			//IL_049b: Expected O, but got I4
			//IL_02c4: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5ED9]");
			object obj2 = (nint)0 & (nint)1;
			SpriteRenderer spriteRenderer;
			SpriteRenderer spriteRenderer2;
			List<object>.Enumerator enumerator;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v47+E4]");
				bool flag = (nint)0 == 0;
				spriteRenderer = null;
				enumerator = (List<object>.Enumerator)0;
				spriteRenderer2 = null;
				enumerator = (List<object>.Enumerator)0;
				if (!flag)
				{
					goto IL_0090;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v47+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				spriteRenderer = null;
				enumerator = (List<object>.Enumerator)0;
				spriteRenderer2 = null;
				enumerator = (List<object>.Enumerator)0;
				if (obj4 != null)
				{
					goto IL_0090;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = s != null;
			bool flag4 = !flag3;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			spriteRenderer = spriteRenderer2;
			if (!flag4)
			{
				goto IL_017b;
			}
			goto IL_0424;
			IL_0215:
			object obj8;
			object obj7 = obj8;
			Func<object, bool> func;
			bool flag5 = Enumerable.All(imageList, func);
			bool flag6 = !flag5;
			Func<object, bool> func2 = func;
			if (!flag6)
			{
				goto IL_0251;
			}
			goto IL_0424;
			IL_02d8:
			Action<bool> action = onSuccess;
			if (onSuccess != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v226 @ X8_v23 (System.Action`1<System.Boolean>)+18] (should have been resolved before IL gen)");
			}
			return;
			IL_0424:
			Action<bool> action2 = onSuccess;
			if (onSuccess != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v4 (System.Action`1<System.Boolean>)+18]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v4 (System.Action`1<System.Boolean>)+40]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v4 (System.Action`1<System.Boolean>)+28]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v152 @ X3_v3 (should have been resolved before IL gen)");
			}
			return;
			IL_0090:
			bool flag7 = s != null;
			bool flag8 = !flag7;
			object obj12 = !flag8;
			obj5 = 0;
			obj6 = null;
			if (obj12 != null)
			{
				goto IL_017b;
			}
			goto IL_0424;
			IL_017b:
			object obj13 = typeof(TrackedDeviceRaycaster.<>c) + 704;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v6+E4]");
			object obj15;
			object obj16;
			if ((nint)0 != 0)
			{
				obj8 = (nint)0 + (nint)1936;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v6+B8]");
				obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v8+10]");
				func = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v8+10]");
				bool flag9 = (nint)0 == 0;
				obj16 = obj8;
				if (!flag9)
				{
					goto IL_0215;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj14 = obj13;
				obj8 = (nint)0 + (nint)1936;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v6+B8]");
				obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v8+10]");
				func = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v8+10]");
				bool flag10 = (nint)0 == 0;
				object obj17 = !flag10;
				obj16 = obj8;
				if (obj17 != null)
				{
					goto IL_0215;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v6+E4]");
			bool flag11 = (nint)0 == 0;
			object obj18 = !flag11;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj19 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v14+B8]");
				obj15 = 0;
			}
			object obj20 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj21 = (nint)0 + (nint)1488;
			Func<object, bool> func3 = default(Func<object, bool>);
			func3..ctor(obj15, (IntPtr)obj21);
			object obj22 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v13+B8]");
			object obj23 = (nint)0 + (nint)16;
			obj23 = func3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj7 = obj16;
			bool flag12 = Enumerable.All(imageList, func3);
			bool flag13 = !flag12;
			object obj24 = !flag13;
			func2 = func3;
			if (obj24 != null)
			{
				goto IL_0251;
			}
			goto IL_0424;
			IL_053a:
			NullReferenceException ex = new NullReferenceException();
			bool flag14 = (nint)func2 != 1;
			NullReferenceException ex2 = ex;
			object obj27;
			if (!flag14)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				object obj25 = (nint)0 + (nint)1624;
				func2 = (Func<object, bool>)obj25;
				enumerator.Dispose();
				object obj26 = default(object);
				if (obj26 == null)
				{
					goto IL_02d8;
				}
				OutOfMemoryException ex3 = new OutOfMemoryException();
				obj27 = obj26;
				ex2 = (NullReferenceException)(object)ex3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2237044");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_0488:
			NullReferenceException ex4 = new NullReferenceException();
			obj27 = 0;
			goto IL_053a;
			IL_0251:
			if (imageList != null)
			{
				List<object>.Enumerator enumerator2 = ((List<object>)(object)imageList).GetEnumerator();
				object obj28 = (nint)0 + (nint)1632;
				while (true)
				{
					func2 = (Func<object, bool>)obj28;
					if (!enumerator.MoveNext())
					{
						break;
					}
					if ((object)spriteRenderer != null)
					{
						spriteRenderer.sprite = s;
						obj7 = 0;
						continue;
					}
					goto IL_0488;
				}
				enumerator.Dispose();
				goto IL_02d8;
			}
			goto IL_053a;
		}
	}

	private sealed class <>c__DisplayClass42_0
	{
		public BlurOptimized blur;

		internal int <TweenShowBlur>b__0()
		{
			//IL_0041: Expected I4, but got O
			BlurOptimized blurOptimized = blur;
			if ((object)blur != null)
			{
				return blurOptimized.downsample;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal void <TweenShowBlur>b__1(int x)
		{
			BlurOptimized blurOptimized = blur;
			blurOptimized.downsample = x;
		}

		internal float <TweenShowBlur>b__2()
		{
			BlurOptimized blurOptimized = blur;
			return blurOptimized.blurSize;
		}

		internal void <TweenShowBlur>b__3(float x)
		{
			BlurOptimized blurOptimized = blur;
			blurOptimized.blurSize = x;
		}

		internal int <TweenShowBlur>b__4()
		{
			//IL_0041: Expected I4, but got O
			BlurOptimized blurOptimized = blur;
			if ((object)blur != null)
			{
				return blurOptimized.blurIterations;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal void <TweenShowBlur>b__5(int x)
		{
			BlurOptimized blurOptimized = blur;
			blurOptimized.blurIterations = x;
		}
	}

	private sealed class <>c__DisplayClass43_0
	{
		public BlurOptimized blur;

		public Action onComplete;

		internal int <TweenHideBlur>b__0()
		{
			//IL_0041: Expected I4, but got O
			BlurOptimized blurOptimized = blur;
			if ((object)blur != null)
			{
				return blurOptimized.downsample;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal void <TweenHideBlur>b__1(int x)
		{
			BlurOptimized blurOptimized = blur;
			blurOptimized.downsample = x;
		}

		internal float <TweenHideBlur>b__2()
		{
			BlurOptimized blurOptimized = blur;
			return blurOptimized.blurSize;
		}

		internal void <TweenHideBlur>b__3(float x)
		{
			BlurOptimized blurOptimized = blur;
			blurOptimized.blurSize = x;
		}

		internal int <TweenHideBlur>b__4()
		{
			//IL_0041: Expected I4, but got O
			BlurOptimized blurOptimized = blur;
			if ((object)blur != null)
			{
				return blurOptimized.blurIterations;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal void <TweenHideBlur>b__5(int x)
		{
			BlurOptimized blurOptimized = blur;
			blurOptimized.blurIterations = x;
		}

		internal void <TweenHideBlur>b__6()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00ff: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			object obj = 152981504;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5EDA]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj5;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
				bool flag = (nint)0 == 0;
				obj5 = blur;
				obj6 = blur;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj5 = blur;
				obj6 = blur;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!(obj6 != null))
			{
				goto IL_00c3;
			}
			goto IL_0157;
			IL_00c3:
			Actions.SafeInvoke(onComplete);
			return;
			IL_0157:
			blur.enabled = false;
			Actions.SafeInvoke(onComplete);
			return;
			IL_0091:
			bool flag3 = obj5 != null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				goto IL_00c3;
			}
			goto IL_0157;
		}
	}

	private sealed class <>c__DisplayClass4_0
	{
		public bool mainDone;

		public bool maskDone;

		public Action<bool> onSuccess;

		public bool mainOk;

		public bool maskOk;

		public Image img;

		internal void <LoadClanLogoImage>g__TryComplete|0()
		{
			//IL_0011: Expected O, but got I4
			//IL_0067: Expected O, but got I
			//IL_0077: Expected O, but got I
			//IL_0087: Expected O, but got I
			//IL_0098: Expected O, but got I4
			object obj = maskDone & mainDone;
			if (obj != null)
			{
				Action<bool> action = onSuccess;
				if (onSuccess != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X8_v3 (System.Action`1<System.Boolean>)+18]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X8_v3 (System.Action`1<System.Boolean>)+40]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X8_v3 (System.Action`1<System.Boolean>)+28]");
					object obj4 = 0;
					object obj5 = mainOk & maskOk;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v14 @ X3_v1 (should have been resolved before IL gen)");
				}
			}
		}

		internal void <LoadClanLogoImage>b__1(Sprite s)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00e9: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			//IL_0128: Expected O, but got I4
			//IL_018e: Expected O, but got I4
			//IL_02a7: Expected O, but got I4
			//IL_01f9: Expected O, but got I
			//IL_0209: Expected O, but got I
			//IL_0219: Expected O, but got I
			//IL_022a: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5EDB]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v15+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v15+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = s != null;
			bool flag3 = !flag2;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (!flag3)
			{
				goto IL_013b;
			}
			goto IL_019c;
			IL_026c:
			img.sprite = s;
			mainOk = true;
			mainDone = true;
			bool flag4 = (byte)(~(maskDone ? 1u : 0u)) != 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				return;
			}
			goto IL_01c0;
			IL_01c0:
			Action<bool> action = onSuccess;
			if (onSuccess != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v4 (System.Action`1<System.Boolean>)+18]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v4 (System.Action`1<System.Boolean>)+40]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v4 (System.Action`1<System.Boolean>)+28]");
				object obj10 = 0;
				object obj11 = mainOk & maskOk;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v124 @ X3_v1 (should have been resolved before IL gen)");
				goto IL_0234;
			}
			return;
			IL_019c:
			mainDone = true;
			if (~(maskDone ? 1u : 0u) == 0)
			{
				goto IL_01c0;
			}
			return;
			IL_0074:
			bool flag5 = s != null;
			bool flag6 = !flag5;
			object obj12 = !flag6;
			obj5 = 0;
			obj6 = null;
			if (obj12 != null)
			{
				goto IL_013b;
			}
			goto IL_019c;
			IL_013b:
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v6+E4]");
			if ((nint)0 == 0)
			{
				goto IL_0234;
			}
			bool flag7 = img != null;
			bool flag8 = !flag7;
			object obj14 = !flag8;
			if (obj14 == null)
			{
				goto IL_019c;
			}
			goto IL_026c;
			IL_0234:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!(img != null))
			{
				goto IL_019c;
			}
			goto IL_026c;
		}

		internal void <LoadClanLogoImage>b__2(Sprite s)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00e9: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			//IL_0128: Expected O, but got I4
			//IL_018e: Expected O, but got I4
			//IL_029c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a1: Expected O, but got Unknown
			//IL_02cc: Expected O, but got I4
			//IL_01f9: Expected O, but got I
			//IL_0209: Expected O, but got I
			//IL_0219: Expected O, but got I
			//IL_022a: Expected O, but got I4
			//IL_0375: Unknown result type (might be due to invalid IL or missing references)
			//IL_037a: Expected O, but got Unknown
			//IL_03b7: Expected O, but got I4
			//IL_02f1: Expected I, but got O
			//IL_0328: Expected O, but got I4
			//IL_03d2: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5EDC]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v34+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v34+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = s != null;
			bool flag3 = !flag2;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (!flag3)
			{
				goto IL_013b;
			}
			goto IL_019c;
			IL_026c:
			UnityEngine.Object material = img.material;
			string name = material.name;
			object value = "&action=sign-up" + 2272;
			bool flag4 = name.EndsWith((string)value);
			bool flag5 = !flag4;
			object obj7 = !flag5;
			if (obj7 == null)
			{
				Image image = img;
				nint num = (nint)image;
				Material material2 = image.material;
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v22+E4]");
				bool flag6 = (nint)0 == 0;
				object obj9 = !flag6;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj10 = (nint)0 + (nint)392;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9A80");
				Material material3 = default(Material);
				image.material = material3;
			}
			Material material4 = img.material;
			Texture2D texture = s.texture;
			object name2 = "_InputUv1BufferOffset" + 696;
			material4.SetTexture((string)name2, texture);
			maskOk = true;
			maskDone = true;
			bool flag7 = (byte)(~(mainDone ? 1u : 0u)) != 0;
			object obj11 = !flag7;
			if (obj11 == null)
			{
				return;
			}
			goto IL_01c0;
			IL_01c0:
			Action<bool> action = onSuccess;
			if (onSuccess != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v4 (System.Action`1<System.Boolean>)+18]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v4 (System.Action`1<System.Boolean>)+40]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v4 (System.Action`1<System.Boolean>)+28]");
				object obj14 = 0;
				object obj15 = mainOk & maskOk;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v144 @ X3_v3 (should have been resolved before IL gen)");
				goto IL_0234;
			}
			return;
			IL_019c:
			maskDone = true;
			if (~(mainDone ? 1u : 0u) == 0)
			{
				goto IL_01c0;
			}
			return;
			IL_0074:
			bool flag8 = s != null;
			bool flag9 = !flag8;
			object obj16 = !flag9;
			obj5 = 0;
			obj6 = null;
			if (obj16 != null)
			{
				goto IL_013b;
			}
			goto IL_019c;
			IL_013b:
			object obj17 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v6+E4]");
			if ((nint)0 == 0)
			{
				goto IL_0234;
			}
			bool flag10 = img != null;
			bool flag11 = !flag10;
			object obj18 = !flag11;
			if (obj18 == null)
			{
				goto IL_019c;
			}
			goto IL_026c;
			IL_0234:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!(img != null))
			{
				goto IL_019c;
			}
			goto IL_026c;
		}
	}

	private sealed class <>c__DisplayClass50_0
	{
		public Transform destination;

		public bool worldPositionStays;

		internal void <MoveChildren>b__0(Transform child)
		{
			child.SetParent(destination, worldPositionStays);
		}
	}

	private sealed class <>c__DisplayClass5_0
	{
		public Image img;

		public Action<bool> onSuccess;

		internal void <LoadClanEmblem>b__0(Sprite sprite)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00ff: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			//IL_0158: Expected O, but got I4
			//IL_0161: Expected O, but got I4
			//IL_02ca: Expected O, but got I4
			//IL_01c5: Expected O, but got I4
			//IL_01ce: Expected O, but got I4
			//IL_0312: Expected O, but got I4
			//IL_031b: Expected O, but got I4
			//IL_0234: Expected O, but got I4
			//IL_026f: Expected O, but got I
			//IL_027f: Expected O, but got I
			//IL_028f: Expected O, but got I
			object obj = 152981504;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5EDD]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj5;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v20+E4]");
				bool flag = (nint)0 == 0;
				obj5 = img;
				obj6 = img;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v20+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj5 = img;
				obj6 = img;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj6 == null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			object obj9 = 0;
			UnityEngine.Object obj10 = null;
			if (obj8 == null)
			{
				goto IL_0174;
			}
			return;
			IL_02dd:
			img.sprite = sprite;
			Action<bool> action = onSuccess;
			bool flag5 = onSuccess == null;
			object obj11 = !flag5;
			object obj12 = 0;
			UnityEngine.Object obj13 = sprite;
			if (obj11 == null)
			{
				return;
			}
			goto IL_020a;
			IL_020a:
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v11+E4]");
			bool flag6 = (nint)0 == 0;
			object obj15 = !flag6;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag7 = sprite != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X20_v5 (System.Action`1<System.Boolean>)+18]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X20_v5 (System.Action`1<System.Boolean>)+40]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X20_v5 (System.Action`1<System.Boolean>)+28]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v113 @ X3_v1 (should have been resolved before IL gen)");
			goto IL_0299;
			IL_01e1:
			action = onSuccess;
			if (onSuccess != null)
			{
				goto IL_020a;
			}
			return;
			IL_0091:
			bool flag8 = obj5 == null;
			bool flag9 = !flag8;
			obj9 = 0;
			obj10 = null;
			if (!flag9)
			{
				return;
			}
			goto IL_0174;
			IL_0174:
			object obj19 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v3+E4]");
			if ((nint)0 == 0)
			{
				goto IL_0299;
			}
			bool flag10 = sprite != null;
			bool flag11 = !flag10;
			object obj20 = !flag11;
			obj12 = 0;
			obj13 = null;
			if (obj20 == null)
			{
				goto IL_01e1;
			}
			goto IL_02dd;
			IL_0299:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag12 = sprite != null;
			bool flag13 = !flag12;
			obj12 = 0;
			obj13 = null;
			if (flag13)
			{
				goto IL_01e1;
			}
			goto IL_02dd;
		}
	}

	private sealed class <>c__DisplayClass61_0
	{
		private sealed class <<WaitForSeconds>g__InternalWaitForSeconds|0>d : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int <>1__state;

			private object <>2__current;

			public <>c__DisplayClass61_0 <>4__this;

			object IEnumerator<object>.Current => <>2__current;

			object IEnumerator.Current => <>2__current;

			public <<WaitForSeconds>g__InternalWaitForSeconds|0>d(int <>1__state)
			{
				this.<>1__state = <>1__state;
			}

			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				//IL_0077: Expected I4, but got I8
				//IL_0101: Expected I4, but got O
				//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00aa: Expected O, but got Unknown
				//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d6: Expected O, but got Unknown
				//IL_0036: Expected I4, but got I8
				<>c__DisplayClass61_0 <>c__DisplayClass61_ = <>4__this;
				if (<>1__state != 0)
				{
					if (<>1__state == 1)
					{
						<>1__state = -1;
						if (<>4__this == null)
						{
							goto IL_00f3;
						}
						Actions.SafeInvoke(<>c__DisplayClass61_.callback);
					}
				}
				else
				{
					<>1__state = -1;
					if (<>4__this == null)
					{
						goto IL_00f3;
					}
					object obj = typeof(UsageHint) + 1640;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					WaitForSeconds waitForSeconds = default(WaitForSeconds);
					waitForSeconds..ctor(<>c__DisplayClass61_.seconds);
					object obj2 = this + 24;
					obj2 = waitForSeconds;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					_ = 1;
				}
				return <>1__state == 0;
				IL_00f3:
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			void IEnumerator.Reset()
			{
				//IL_000f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0014: Expected O, but got Unknown
				//IL_0042: Expected O, but got I
				object obj = typeof(MemberAchievementClanFeedData) + 2648;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				NotSupportedException ex = default(NotSupportedException);
				ex..ctor();
				object obj2 = (nint)0 + (nint)1352;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				throw new OutOfMemoryException();
			}
		}

		public float seconds;

		public Action callback;

		internal IEnumerator <WaitForSeconds>g__InternalWaitForSeconds|0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			object obj = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 1880;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			_ = 0;
			object obj3 = obj2 + 32;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (IEnumerator)obj2;
		}
	}

	private sealed class <>c__DisplayClass62_0
	{
		private sealed class <<SetTimeout>g__InternalWaitForSeconds|0>d : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int <>1__state;

			private object <>2__current;

			public <>c__DisplayClass62_0 <>4__this;

			private float <startTime>5__2;

			object IEnumerator<object>.Current => <>2__current;

			object IEnumerator.Current => <>2__current;

			public <<SetTimeout>g__InternalWaitForSeconds|0>d(int <>1__state)
			{
				this.<>1__state = <>1__state;
			}

			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				//IL_0065: Expected I4, but got I8
				//IL_0021: Expected O, but got I4
				//IL_020b: Expected I4, but got O
				//IL_003e: Expected I4, but got I8
				//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b1: Expected O, but got Unknown
				//IL_00cb: Expected O, but got I4
				//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01bc: Expected O, but got Unknown
				//IL_01d6: Expected O, but got I4
				//IL_0126: Unknown result type (might be due to invalid IL or missing references)
				//IL_012b: Expected O, but got Unknown
				//IL_0152: Unknown result type (might be due to invalid IL or missing references)
				//IL_0157: Expected O, but got Unknown
				<>c__DisplayClass62_0 <>c__DisplayClass62_ = <>4__this;
				if (<>1__state != 1)
				{
					bool flag = <>1__state == 0;
					object obj = !flag;
					if (obj != null)
					{
						goto IL_01f7;
					}
					<>1__state = -1;
					float time = Time.time;
					<startTime>5__2 = time;
				}
				else
				{
					<>1__state = -1;
				}
				if (<>4__this != null)
				{
					Func<bool> cancelCondition = <>c__DisplayClass62_.cancelCondition;
					if (<>c__DisplayClass62_.cancelCondition != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v162 @ X8_v6 (System.Func`1<System.Boolean>)+18] (should have been resolved before IL gen)");
						object obj3 = default(object);
						object obj2 = obj3 & 1;
						bool flag2 = obj2 == null;
						object obj4 = !flag2;
						if (obj4 == null)
						{
							float time2 = Time.time;
							float time = time2 - <startTime>5__2;
							if (time < <>c__DisplayClass62_.seconds)
							{
								object obj5 = typeof(UsageHint) + 1640;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								WaitForSeconds waitForSeconds = default(WaitForSeconds);
								waitForSeconds..ctor(1f);
								object obj6 = this + 24;
								obj6 = waitForSeconds;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								_ = 1;
								return true;
							}
						}
						Func<bool> cancelCondition2 = <>c__DisplayClass62_.cancelCondition;
						if (<>c__DisplayClass62_.cancelCondition != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v92 @ X8_v7 (System.Func`1<System.Boolean>)+18] (should have been resolved before IL gen)");
							object obj8 = default(object);
							object obj7 = obj8 & 1;
							bool flag3 = obj7 == null;
							object obj9 = !flag3;
							if (obj9 == null)
							{
								Actions.SafeInvoke(<>c__DisplayClass62_.fallback);
							}
							goto IL_01f7;
						}
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
				IL_01f7:
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			void IEnumerator.Reset()
			{
				//IL_000f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0014: Expected O, but got Unknown
				//IL_0042: Expected O, but got I
				object obj = typeof(MemberAchievementClanFeedData) + 2648;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				NotSupportedException ex = default(NotSupportedException);
				ex..ctor();
				object obj2 = (nint)0 + (nint)1360;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				throw new OutOfMemoryException();
			}
		}

		public Func<bool> cancelCondition;

		public float seconds;

		public Action fallback;

		internal IEnumerator <SetTimeout>g__InternalWaitForSeconds|0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			object obj = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 1888;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			_ = 0;
			object obj3 = obj2 + 32;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (IEnumerator)obj2;
		}
	}

	private sealed class <>c__DisplayClass6_0
	{
		public List<Image> imageList;

		public Action<bool> onSuccess;

		internal void <LoadProfileGiftImage>b__0(Sprite s)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_0105: Expected O, but got I4
			//IL_0113: Expected O, but got I4
			//IL_0121: Expected O, but got I4
			//IL_00b4: Expected O, but got I4
			//IL_00bd: Expected O, but got I4
			//IL_0074: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Expected O, but got Unknown
			//IL_032e: Expected O, but got I
			//IL_033e: Expected O, but got I
			//IL_034e: Expected O, but got I
			//IL_0370: Expected O, but got I4
			//IL_0160: Expected O, but got I4
			//IL_01c8: Expected O, but got I
			//IL_01d8: Expected O, but got I
			//IL_01e8: Expected O, but got I
			//IL_03a8: Expected O, but got I4
			//IL_0589: Unknown result type (might be due to invalid IL or missing references)
			//IL_058e: Expected O, but got Unknown
			//IL_05a4: Expected O, but got I
			//IL_05b5: Expected I, but got O
			//IL_05d3: Expected O, but got I
			//IL_045d: Expected O, but got I
			//IL_046d: Expected O, but got I
			//IL_047d: Expected O, but got I
			//IL_040e: Expected O, but got I4
			//IL_03d8: Expected O, but got I
			//IL_028c: Expected O, but got I
			//IL_04ed: Expected O, but got I
			//IL_049b: Expected O, but got I4
			//IL_02c4: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5EE0]");
			object obj2 = (nint)0 & (nint)1;
			Image image;
			Image image2;
			List<object>.Enumerator enumerator;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v47+E4]");
				bool flag = (nint)0 == 0;
				image = null;
				enumerator = (List<object>.Enumerator)0;
				image2 = null;
				enumerator = (List<object>.Enumerator)0;
				if (!flag)
				{
					goto IL_0090;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v47+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				image = null;
				enumerator = (List<object>.Enumerator)0;
				image2 = null;
				enumerator = (List<object>.Enumerator)0;
				if (obj4 != null)
				{
					goto IL_0090;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = s != null;
			bool flag4 = !flag3;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			image = image2;
			if (!flag4)
			{
				goto IL_017b;
			}
			goto IL_0424;
			IL_0215:
			object obj8;
			object obj7 = obj8;
			Func<object, bool> func;
			bool flag5 = Enumerable.All(imageList, func);
			bool flag6 = !flag5;
			Func<object, bool> func2 = func;
			if (!flag6)
			{
				goto IL_0251;
			}
			goto IL_0424;
			IL_02d8:
			Action<bool> action = onSuccess;
			if (onSuccess != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v226 @ X8_v23 (System.Action`1<System.Boolean>)+18] (should have been resolved before IL gen)");
			}
			return;
			IL_0424:
			Action<bool> action2 = onSuccess;
			if (onSuccess != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v4 (System.Action`1<System.Boolean>)+18]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v4 (System.Action`1<System.Boolean>)+40]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v4 (System.Action`1<System.Boolean>)+28]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v152 @ X3_v3 (should have been resolved before IL gen)");
			}
			return;
			IL_0090:
			bool flag7 = s != null;
			bool flag8 = !flag7;
			object obj12 = !flag8;
			obj5 = 0;
			obj6 = null;
			if (obj12 != null)
			{
				goto IL_017b;
			}
			goto IL_0424;
			IL_017b:
			object obj13 = typeof(TrackedDeviceRaycaster.<>c) + 704;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v6+E4]");
			object obj15;
			object obj16;
			if ((nint)0 != 0)
			{
				obj8 = (nint)0 + (nint)1880;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v6+B8]");
				obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v8+18]");
				func = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v8+18]");
				bool flag9 = (nint)0 == 0;
				obj16 = obj8;
				if (!flag9)
				{
					goto IL_0215;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj14 = obj13;
				obj8 = (nint)0 + (nint)1880;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v6+B8]");
				obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v8+18]");
				func = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v8+18]");
				bool flag10 = (nint)0 == 0;
				object obj17 = !flag10;
				obj16 = obj8;
				if (obj17 != null)
				{
					goto IL_0215;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v6+E4]");
			bool flag11 = (nint)0 == 0;
			object obj18 = !flag11;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj19 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v14+B8]");
				obj15 = 0;
			}
			object obj20 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1760;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj21 = (nint)0 + (nint)1496;
			Func<object, bool> func3 = default(Func<object, bool>);
			func3..ctor(obj15, (IntPtr)obj21);
			object obj22 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v13+B8]");
			object obj23 = (nint)0 + (nint)24;
			obj23 = func3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj7 = obj16;
			bool flag12 = Enumerable.All(imageList, func3);
			bool flag13 = !flag12;
			object obj24 = !flag13;
			func2 = func3;
			if (obj24 != null)
			{
				goto IL_0251;
			}
			goto IL_0424;
			IL_053a:
			NullReferenceException ex = new NullReferenceException();
			bool flag14 = (nint)func2 != 1;
			NullReferenceException ex2 = ex;
			object obj27;
			if (!flag14)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				object obj25 = (nint)0 + (nint)2120;
				func2 = (Func<object, bool>)obj25;
				enumerator.Dispose();
				object obj26 = default(object);
				if (obj26 == null)
				{
					goto IL_02d8;
				}
				OutOfMemoryException ex3 = new OutOfMemoryException();
				obj27 = obj26;
				ex2 = (NullReferenceException)(object)ex3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2237004");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_0488:
			NullReferenceException ex4 = new NullReferenceException();
			obj27 = 0;
			goto IL_053a;
			IL_0251:
			if (imageList != null)
			{
				List<object>.Enumerator enumerator2 = ((List<object>)(object)imageList).GetEnumerator();
				object obj28 = (nint)0 + (nint)2128;
				while (true)
				{
					func2 = (Func<object, bool>)obj28;
					if (!enumerator.MoveNext())
					{
						break;
					}
					if ((object)image != null)
					{
						image.sprite = s;
						obj7 = 0;
						continue;
					}
					goto IL_0488;
				}
				enumerator.Dispose();
				goto IL_02d8;
			}
			goto IL_053a;
		}
	}

	private sealed class <>c__DisplayClass7_0
	{
		public Image img;

		public Action<bool> onSuccess;

		internal void <LoadProfileGiftImage>b__0(Sprite sprite)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0142: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			//IL_01bb: Expected O, but got I4
			//IL_00e8: Expected O, but got I
			//IL_00f8: Expected O, but got I
			//IL_0108: Expected O, but got I
			object obj = 152981504;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5EE1]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 == null)
			{
				goto IL_0112;
			}
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
			goto IL_0150;
			IL_0186:
			img.sprite = sprite;
			Action<bool> action = onSuccess;
			bool flag = onSuccess == null;
			object obj5 = !flag;
			if (obj5 == null)
			{
				return;
			}
			goto IL_00d8;
			IL_007d:
			bool flag2 = sprite != null;
			bool flag3 = !flag2;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				goto IL_00af;
			}
			goto IL_0186;
			IL_00af:
			action = onSuccess;
			if (onSuccess != null)
			{
				goto IL_00d8;
			}
			return;
			IL_00d8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v8 (System.Action`1<System.Boolean>)+18]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v8 (System.Action`1<System.Boolean>)+40]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v8 (System.Action`1<System.Boolean>)+28]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v95 @ X3_v1 (should have been resolved before IL gen)");
			goto IL_0112;
			IL_0112:
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v5+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 != null)
			{
				goto IL_007d;
			}
			goto IL_0150;
			IL_0150:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!(sprite != null))
			{
				goto IL_00af;
			}
			goto IL_0186;
		}
	}

	private sealed class <>c__DisplayClass8_0
	{
		public Image img;

		public bool setNative;

		public Action<bool> onSuccess;

		internal void <LoadAppAnnouncementImage>b__0(Sprite s)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00e9: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			//IL_0128: Expected O, but got I4
			//IL_0215: Expected O, but got I4
			//IL_0255: Expected O, but got I4
			//IL_0294: Expected O, but got I
			//IL_02a4: Expected O, but got I
			//IL_02b4: Expected O, but got I
			//IL_01db: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5EE2]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v19+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v19+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = s != null;
			bool flag3 = !flag2;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (!flag3)
			{
				goto IL_013b;
			}
			goto IL_0223;
			IL_0191:
			img.sprite = s;
			if (setNative)
			{
				img.SetNativeSize();
			}
			Action<bool> action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 1;
				goto IL_0284;
			}
			return;
			IL_0223:
			action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 0;
				goto IL_0284;
			}
			return;
			IL_0284:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+18]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+40]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+28]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v160 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
			IL_0074:
			bool flag4 = s != null;
			bool flag5 = !flag4;
			object obj11 = !flag5;
			obj5 = 0;
			obj6 = null;
			if (obj11 != null)
			{
				goto IL_013b;
			}
			goto IL_0223;
			IL_013b:
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				if (img != null)
				{
					goto IL_0191;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag6 = img != null;
				bool flag7 = !flag6;
				object obj13 = !flag7;
				if (obj13 != null)
				{
					goto IL_0191;
				}
			}
			goto IL_0223;
		}
	}

	private sealed class <>c__DisplayClass9_0
	{
		public Image img;

		public bool setNative;

		public Action<bool> onSuccess;

		internal void <LoadAdCampaignLogo>b__0(Sprite s)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00e9: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			//IL_0128: Expected O, but got I4
			//IL_0215: Expected O, but got I4
			//IL_0255: Expected O, but got I4
			//IL_0294: Expected O, but got I
			//IL_02a4: Expected O, but got I
			//IL_02b4: Expected O, but got I
			//IL_01db: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5EE3]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v19+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v19+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = s != null;
			bool flag3 = !flag2;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (!flag3)
			{
				goto IL_013b;
			}
			goto IL_0223;
			IL_0191:
			img.sprite = s;
			if (setNative)
			{
				img.SetNativeSize();
			}
			Action<bool> action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 1;
				goto IL_0284;
			}
			return;
			IL_0223:
			action = onSuccess;
			if (onSuccess != null)
			{
				object obj7 = 0;
				goto IL_0284;
			}
			return;
			IL_0284:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+18]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+40]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v2 (System.Action`1<System.Boolean>)+28]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v160 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
			IL_0074:
			bool flag4 = s != null;
			bool flag5 = !flag4;
			object obj11 = !flag5;
			obj5 = 0;
			obj6 = null;
			if (obj11 != null)
			{
				goto IL_013b;
			}
			goto IL_0223;
			IL_013b:
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				if (img != null)
				{
					goto IL_0191;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag6 = img != null;
				bool flag7 = !flag6;
				object obj13 = !flag7;
				if (obj13 != null)
				{
					goto IL_0191;
				}
			}
			goto IL_0223;
		}
	}

	private sealed class <DescendantsAndSelf>d__41 : IEnumerable<Transform>, IEnumerable, IEnumerator<Transform>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private Transform <>2__current;

		private int <>l__initialThreadId;

		private Transform transform;

		public Transform <>3__transform;

		private IEnumerator<Transform> <>7__wrap1;

		Transform IEnumerator<Transform>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <DescendantsAndSelf>d__41(int <>1__state)
		{
			this.<>1__state = <>1__state;
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			<>l__initialThreadId = currentManagedThreadId;
		}

		void IDisposable.Dispose()
		{
			//IL_0010: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			//IL_0165: Expected O, but got I4
			//IL_0051: Expected O, but got I4
			//IL_0182: Expected I4, but got I8
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Expected O, but got Unknown
			//IL_0094: Expected I, but got O
			//IL_00a4: Expected O, but got I
			//IL_00df: Expected O, but got I
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Expected O, but got Unknown
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Expected O, but got Unknown
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected O, but got Unknown
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Expected O, but got Unknown
			object obj = <>1__state - 2;
			bool flag = obj == null;
			object obj2 = !flag;
			object obj3 = ~obj2;
			bool flag2;
			if (obj3 == null)
			{
				object obj4 = <>1__state - -3;
				flag2 = obj4 == null;
			}
			else
			{
				flag2 = true;
			}
			while (true)
			{
				object obj5 = !flag2;
				if (obj5 != null)
				{
					break;
				}
				<>1__state = -1;
				IEnumerator<Transform> enumerator = <>7__wrap1;
				if (<>7__wrap1 == null)
				{
					break;
				}
				object obj6 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				nint num = (nint)enumerator;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v8 (Il2CppClass<System.Collections.Generic.IEnumerator`1<UnityEngine.Transform>>)+12E]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v8 (Il2CppClass<System.Collections.Generic.IEnumerator`1<UnityEngine.Transform>>)+12E]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v8 (Il2CppClass<System.Collections.Generic.IEnumerator`1<UnityEngine.Transform>>)+B0]");
					object obj8 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X10_v4-8]");
						if (0 == (nint)obj6)
						{
							break;
						}
						obj8 += 16;
						obj7--;
						if ((nint)obj7 != 1)
						{
							continue;
						}
						goto IL_0120;
					}
					object obj9 = num + obj8;
					object obj10 = obj9 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v187 @ X0_v6] (should have been resolved before IL gen)");
					continue;
				}
				goto IL_0120;
				IL_0120:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v174 @ X0_v4] (should have been resolved before IL gen)");
				break;
			}
		}

		private bool MoveNext()
		{
			//IL_09ae: Expected I4, but got I8
			//IL_038c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0391: Expected O, but got Unknown
			//IL_0399: Expected I, but got O
			//IL_03a9: Expected O, but got I
			//IL_0094: Expected I4, but got I8
			//IL_00a0: Expected O, but got I
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Expected O, but got Unknown
			//IL_06c0: Expected O, but got I4
			//IL_0438: Expected O, but got I4
			//IL_0177: Expected O, but got I
			//IL_0187: Expected O, but got I
			//IL_01a9: Expected O, but got I4
			//IL_0040: Expected O, but got I4
			//IL_0887: Unknown result type (might be due to invalid IL or missing references)
			//IL_088c: Expected O, but got Unknown
			//IL_03e4: Expected O, but got I
			//IL_022a: Expected O, but got I
			//IL_0100: Expected O, but got I
			//IL_0110: Expected O, but got I
			//IL_0132: Expected O, but got I4
			//IL_0676: Expected I, but got O
			//IL_01e9: Expected O, but got I4
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected O, but got Unknown
			//IL_0917: Expected I4, but got I8
			//IL_0445: Unknown result type (might be due to invalid IL or missing references)
			//IL_044a: Expected O, but got Unknown
			//IL_0453: Unknown result type (might be due to invalid IL or missing references)
			//IL_0458: Expected O, but got Unknown
			//IL_026f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0274: Expected O, but got Unknown
			//IL_027c: Expected I, but got O
			//IL_028c: Expected O, but got I
			//IL_0784: Unknown result type (might be due to invalid IL or missing references)
			//IL_0789: Expected O, but got Unknown
			//IL_079f: Expected O, but got I
			//IL_07b0: Expected I, but got O
			//IL_07ce: Expected O, but got I
			//IL_09e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_09eb: Expected O, but got Unknown
			//IL_09f4: Expected O, but got I4
			//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f7: Expected O, but got Unknown
			//IL_0400: Unknown result type (might be due to invalid IL or missing references)
			//IL_0405: Expected O, but got Unknown
			//IL_031b: Expected O, but got I4
			//IL_0219: Expected O, but got I
			//IL_0560: Unknown result type (might be due to invalid IL or missing references)
			//IL_0565: Expected O, but got Unknown
			//IL_056d: Expected I, but got O
			//IL_057d: Expected O, but got I
			//IL_049b: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a0: Expected O, but got Unknown
			//IL_04a8: Expected I, but got O
			//IL_04b8: Expected O, but got I
			//IL_02c7: Expected O, but got I
			//IL_060c: Expected O, but got I4
			//IL_0547: Expected O, but got I4
			//IL_05b8: Expected O, but got I
			//IL_08e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e5: Expected O, but got Unknown
			//IL_04f3: Expected O, but got I
			//IL_0351: Unknown result type (might be due to invalid IL or missing references)
			//IL_0356: Expected O, but got Unknown
			//IL_035e: Expected O, but got I
			//IL_0330: Unknown result type (might be due to invalid IL or missing references)
			//IL_0335: Expected O, but got Unknown
			//IL_033e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0343: Expected O, but got Unknown
			//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02da: Expected O, but got Unknown
			//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e8: Expected O, but got Unknown
			//IL_0639: Unknown result type (might be due to invalid IL or missing references)
			//IL_063e: Expected O, but got Unknown
			//IL_0647: Unknown result type (might be due to invalid IL or missing references)
			//IL_064c: Expected O, but got Unknown
			//IL_0619: Unknown result type (might be due to invalid IL or missing references)
			//IL_061e: Expected O, but got Unknown
			//IL_0627: Unknown result type (might be due to invalid IL or missing references)
			//IL_062c: Expected O, but got Unknown
			//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05cb: Expected O, but got Unknown
			//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d9: Expected O, but got Unknown
			//IL_0501: Unknown result type (might be due to invalid IL or missing references)
			//IL_0506: Expected O, but got Unknown
			//IL_050f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0514: Expected O, but got Unknown
			bool flag = <>1__state == 2;
			<DescendantsAndSelf>d__41 <DescendantsAndSelf>d__ = this;
			int num;
			IEnumerable<object> source;
			object obj4;
			object obj6;
			Func<object, IEnumerable<object>> func;
			<DescendantsAndSelf>d__41 <DescendantsAndSelf>d__2;
			<DescendantsAndSelf>d__41 <DescendantsAndSelf>d__3 = default(<DescendantsAndSelf>d__41);
			<DescendantsAndSelf>d__41 <DescendantsAndSelf>d__4;
			if (!flag)
			{
				if (<>1__state != 1)
				{
					bool flag2 = <>1__state == 0;
					object obj = !flag2;
					if (obj != null)
					{
						goto IL_0651;
					}
					object obj2 = this + 24;
					obj2 = transform;
					_ = 4294967295L;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					num = 1;
					goto IL_0762;
				}
				<>1__state = -1;
				object obj3 = (nint)0 + (nint)3120;
				source = Enumerable.Cast<object>(transform);
				obj4 = typeof(TrackedDeviceRaycaster.<>c) + 704;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X0_v66+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X0_v66+B8]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X8_v49+28]");
					func = (Func<object, IEnumerable<object>>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X8_v49+28]");
					bool flag3 = (nint)0 == 0;
					object obj7 = !flag3;
					<DescendantsAndSelf>d__2 = <DescendantsAndSelf>d__3;
					if (obj7 == null)
					{
						<DescendantsAndSelf>d__4 = <DescendantsAndSelf>d__3;
						goto IL_01c7;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X0_v66+B8]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X8_v49+28]");
					func = (Func<object, IEnumerable<object>>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X8_v49+28]");
					bool flag4 = (nint)0 == 0;
					object obj8 = !flag4;
					<DescendantsAndSelf>d__4 = <DescendantsAndSelf>d__3;
					<DescendantsAndSelf>d__2 = <DescendantsAndSelf>d__3;
					if (obj8 == null)
					{
						goto IL_01c7;
					}
				}
				goto IL_021e;
			}
			goto IL_099c;
			IL_0308:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj9 = 0;
			object obj11 = default(object);
			object obj10 = obj11;
			goto IL_0819;
			IL_0534:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj9 = 0;
			goto IL_08cd;
			IL_06a5:
			nint num2 = default(nint);
			bool flag5 = num2 != 1;
			object obj12 = 0;
			NullReferenceException ex2;
			NullReferenceException ex = ex2;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				object obj13 = default(object);
				if (obj13 == null)
				{
					goto IL_0651;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22370F8");
				OutOfMemoryException ex3 = new OutOfMemoryException();
				obj12 = obj13;
				ex = (NullReferenceException)(object)ex3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2237084");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			bool result = default(bool);
			return result;
			IL_099c:
			<DescendantsAndSelf>d__.<>1__state = -3;
			IEnumerator<Transform> enumerator = <DescendantsAndSelf>d__.<>7__wrap1;
			if (<DescendantsAndSelf>d__.<>7__wrap1 != null)
			{
				object obj14 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
				nint num3 = (nint)enumerator;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v9 (Il2CppClass<System.Collections.Generic.IEnumerator`1<UnityEngine.Transform>>)+12E]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v9 (Il2CppClass<System.Collections.Generic.IEnumerator`1<UnityEngine.Transform>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0425;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v9 (Il2CppClass<System.Collections.Generic.IEnumerator`1<UnityEngine.Transform>>)+B0]");
				object obj16 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X10_v19-8]");
					if (0 == (nint)obj14)
					{
						break;
					}
					obj16 += 16;
					obj15--;
					if ((nint)obj15 != 1)
					{
						continue;
					}
					goto IL_0425;
				}
				object obj17 = num3 + obj16;
				object obj18 = obj17 + 312;
				goto IL_0864;
			}
			ex2 = new NullReferenceException();
			goto IL_06a5;
			IL_08cd:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v680 @ X0_v22] (should have been resolved before IL gen)");
			object obj19 = <DescendantsAndSelf>d__3 + 24;
			object obj20 = default(object);
			obj19 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			num = 2;
			goto IL_0762;
			IL_01c7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X0_v66+E4]");
			bool flag6 = (nint)0 == 0;
			object obj21 = !flag6;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj22 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v55+B8]");
				obj6 = 0;
			}
			object obj23 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3992;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj24 = (nint)0 + (nint)1464;
			Func<object, object> func2 = default(Func<object, object>);
			func2..ctor(obj6, (IntPtr)obj24);
			object obj25 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v54+B8]");
			object obj26 = (nint)0 + (nint)40;
			obj26 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			func = (Func<object, IEnumerable<object>>)func2;
			<DescendantsAndSelf>d__2 = <DescendantsAndSelf>d__4;
			goto IL_021e;
			IL_05f9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj9 = 0;
			goto IL_096a;
			IL_0762:
			<DescendantsAndSelf>d__3.<>1__state = num;
			return true;
			IL_021e:
			object obj27 = (nint)0 + (nint)368;
			obj9 = obj27;
			IEnumerable<object> enumerable = Enumerable.SelectMany(source, func);
			if (enumerable != null)
			{
				object obj28 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3816;
				nint num4 = (nint)enumerable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v43 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
				object obj29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v43 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0308;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v43 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
				object obj30 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X10_v28-8]");
					if (0 == (nint)obj28)
					{
						break;
					}
					obj30 += 16;
					obj29--;
					if ((nint)obj29 != 1)
					{
						continue;
					}
					goto IL_0308;
				}
				object obj31 = num4 + obj30;
				obj10 = obj31 + 312;
				goto IL_0819;
			}
			ex2 = new NullReferenceException();
			num2 = (nint)func;
			goto IL_06a5;
			IL_0651:
			return false;
			IL_096a:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v716 @ X0_v12] (should have been resolved before IL gen)");
			goto IL_09dd;
			IL_0425:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj9 = 0;
			goto IL_0864;
			IL_0864:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X0_v4+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v444 @ X0_v4] (should have been resolved before IL gen)");
			object obj33 = default(object);
			object obj32 = obj33 & 1;
			if (obj32 != null)
			{
				IEnumerator<Transform> enumerator2 = <DescendantsAndSelf>d__3.<>7__wrap1;
				if (<DescendantsAndSelf>d__3.<>7__wrap1 != null)
				{
					object obj34 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1272;
					nint num5 = (nint)enumerator2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerator`1<UnityEngine.Transform>>)+12E]");
					object obj35 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerator`1<UnityEngine.Transform>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0534;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerator`1<UnityEngine.Transform>>)+B0]");
					object obj36 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X10_v14-8]");
						if (0 == (nint)obj34)
						{
							break;
						}
						obj36 += 16;
						obj35--;
						if ((nint)obj35 != 1)
						{
							continue;
						}
						goto IL_0534;
					}
					object obj37 = num5 + obj36;
					object obj38 = obj37 + 312;
					goto IL_08cd;
				}
				ex2 = new NullReferenceException();
				goto IL_06a5;
			}
			<DescendantsAndSelf>d__3.<>1__state = -1;
			IEnumerator<Transform> enumerator3 = <DescendantsAndSelf>d__3.<>7__wrap1;
			if (<DescendantsAndSelf>d__3.<>7__wrap1 != null)
			{
				object obj39 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				nint num6 = (nint)enumerator3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v18 (Il2CppClass<System.Collections.Generic.IEnumerator`1<UnityEngine.Transform>>)+12E]");
				object obj40 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v18 (Il2CppClass<System.Collections.Generic.IEnumerator`1<UnityEngine.Transform>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_05f9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v18 (Il2CppClass<System.Collections.Generic.IEnumerator`1<UnityEngine.Transform>>)+B0]");
				object obj41 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X10_v8-8]");
					if (0 == (nint)obj39)
					{
						break;
					}
					obj41 += 16;
					obj40--;
					if ((nint)obj40 != 1)
					{
						continue;
					}
					goto IL_05f9;
				}
				object obj42 = num6 + obj41;
				object obj43 = obj42 + 312;
				goto IL_096a;
			}
			goto IL_09dd;
			IL_09dd:
			object obj44 = <DescendantsAndSelf>d__3 + 56;
			obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			goto IL_0651;
			IL_0819:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v119 @ X8_v44] (should have been resolved before IL gen)");
			IntPtr intPtr = default(IntPtr);
			if (<DescendantsAndSelf>d__2 != null)
			{
				object obj45 = <DescendantsAndSelf>d__2 + 56;
				obj45 = (nint)intPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				num2 = intPtr;
				<DescendantsAndSelf>d__ = <DescendantsAndSelf>d__3;
				goto IL_099c;
			}
			ex2 = new NullReferenceException();
			num2 = intPtr;
			goto IL_06a5;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void <>m__Finally1()
		{
			//IL_00f6: Expected I4, but got I8
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			while (true)
			{
				<>1__state = -1;
				IEnumerator<Transform> enumerator = <>7__wrap1;
				if (<>7__wrap1 == null)
				{
					break;
				}
				object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				nint num = (nint)enumerator;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v6 (Il2CppClass<System.Collections.Generic.IEnumerator`1<UnityEngine.Transform>>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v6 (Il2CppClass<System.Collections.Generic.IEnumerator`1<UnityEngine.Transform>>)+12E]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v6 (Il2CppClass<System.Collections.Generic.IEnumerator`1<UnityEngine.Transform>>)+B0]");
					object obj3 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v4-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj3 += 16;
						obj2--;
						if ((nint)obj2 != 1)
						{
							continue;
						}
						goto IL_00ad;
					}
					object obj4 = num + obj3;
					object obj5 = obj4 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v151 @ X0_v5] (should have been resolved before IL gen)");
					continue;
				}
				goto IL_00ad;
				IL_00ad:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v90 @ X0_v3] (should have been resolved before IL gen)");
				break;
			}
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)1808;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}

		IEnumerator<Transform> IEnumerable<Transform>.GetEnumerator()
		{
			//IL_00a1: Expected O, but got I4
			//IL_00bb: Expected O, but got I4
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected O, but got Unknown
			object obj = <>1__state + 2;
			bool flag = obj == null;
			object obj2 = !flag;
			object obj3;
			if (obj2 == null)
			{
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				if (<>l__initialThreadId == currentManagedThreadId)
				{
					<>1__state = 0;
					obj3 = this;
					goto IL_00c9;
				}
			}
			object obj4 = typeof(TrackedDeviceRaycaster.<>c) + 936;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj5 = default(object);
			obj5..ctor();
			_ = 0;
			int currentManagedThreadId2 = Environment.CurrentManagedThreadId;
			obj3 = obj5;
			goto IL_00c9;
			IL_00c9:
			object obj6 = obj3 + 40;
			obj6 = <>3__transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (IEnumerator<Transform>)obj3;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<Transform>)this).GetEnumerator();
		}
	}

	private static Texture2D _invalidTexture;

	private static Texture2D InvalidTexture
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			//IL_0047: Expected O, but got I
			//IL_011e: Expected O, but got I
			//IL_0150: Expected O, but got I4
			//IL_007c: Expected O, but got I
			//IL_00fb: Expected O, but got I
			//IL_019c: Expected O, but got I4
			object obj = 152981504;
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2864;
			object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5EB2]");
			object obj4 = (nint)0 & (nint)1;
			UnityEngine.Object obj7;
			UnityEngine.Object obj9;
			if (obj4 != null)
			{
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X8_v13+B8]");
				object obj6 = 0;
				obj7 = (UnityEngine.Object)obj6;
				object obj8 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v6+E4]");
				bool flag = (nint)0 == 0;
				obj9 = (UnityEngine.Object)obj6;
				if (!flag)
				{
					goto IL_00b9;
				}
			}
			else
			{
				_ = 1;
				object obj10 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v6+B8]");
				object obj11 = 0;
				obj7 = (UnityEngine.Object)obj11;
				object obj8 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v6+E4]");
				bool flag2 = (nint)0 == 0;
				object obj12 = !flag2;
				obj9 = (UnityEngine.Object)obj11;
				if (obj12 != null)
				{
					goto IL_00b9;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj9;
			bool flag4 = !flag3;
			object obj13 = !flag4;
			if (obj13 != null)
			{
				goto IL_00e3;
			}
			goto IL_01aa;
			IL_00e3:
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v10+B8]");
			return (Texture2D)0;
			IL_01aa:
			Texture2D texture2D = CreateInvalidTexture();
			object obj15 = obj2;
			object obj16 = texture2D;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return texture2D;
			IL_00b9:
			if ((bool)obj7)
			{
				goto IL_00e3;
			}
			goto IL_01aa;
		}
	}

	public static void LoadImage(Image img, string imageId, string url, bool setNative = false, bool storeLocally = true, DateTime? timestamp = null, Action<bool> onSuccess = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0088: Expected O, but got I
		//IL_00b2: Expected I, but got O
		//IL_00e1: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
		object obj4 = (nint)0 + (nint)1504;
		object obj5 = typeof(RegisteredWaitHandle) + 40;
		object obj6 = obj2 + 16;
		obj6 = img;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 32;
		IntPtr intPtr = default(IntPtr);
		obj7 = (nint)intPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEEFBC");
	}

	public static void LoadItemImage(Image img, int itemId, ImageCacher.ItemImageType imagetype, FilterMode filterMode = FilterMode.Point, Action<bool> onSuccess = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I4
		//IL_0114: Expected I, but got O
		//IL_013a: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 760;
		object obj4 = (nint)0 + (nint)2040;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
		object obj6 = (nint)0 + (nint)1592;
		object obj7 = obj2 + 16;
		obj7 = img;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 32;
		obj8 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3 (System.Object)+10]");
		((ImageCacher)(object)action).LoadItemImage(itemId, imagetype, (UnityEngine.Object)0, (Action<Sprite>)action);
	}

	public static void LoadItemImage(IEnumerable<Image> images, int itemId, ImageCacher.ItemImageType imageType, Action<bool> onSuccess = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00dd: Expected O, but got I4
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I4
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_0174: Expected O, but got I4
		//IL_019d: Expected O, but got I
		//IL_01b3: Expected O, but got I
		//IL_01c4: Expected O, but got I
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		//IL_01f7: Expected O, but got I
		//IL_0208: Expected I, but got O
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (images != null)
		{
			List<object> list = Enumerable.ToList((IEnumerable<object>)images);
			object obj4 = obj2 + 16;
			obj4 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj4;
			bool flag = obj4 == null;
			object obj6 = !flag;
			List<object> list2 = list;
			if (obj6 == null)
			{
				return;
			}
		}
		else
		{
			object obj7 = obj2 + 16;
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj7;
			bool flag2 = obj7 == null;
			List<object> list2 = null;
			if (flag2)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v5+18]");
		if ((nint)0 != 0)
		{
			object obj8 = typeof(Queue<string>) + 760;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v11+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj11 = (nint)0 + (nint)2040;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj12 = (nint)0 + (nint)4008;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Object)+10]");
			object go = Enumerable.First((IEnumerable<object>)0);
			object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)1624;
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj14);
			((ImageCacher)(object)action).LoadItemImage(itemId, imageType, (UnityEngine.Object)go, (Action<Sprite>)action);
		}
	}

	public static void LoadItemImage(IEnumerable<SpriteRenderer> images, int itemId, ImageCacher.ItemImageType imageType, Action<bool> onSuccess = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00dd: Expected O, but got I4
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I4
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_0174: Expected O, but got I4
		//IL_019d: Expected O, but got I
		//IL_01ad: Expected O, but got I
		//IL_01be: Expected O, but got I
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01f1: Expected O, but got I
		//IL_0202: Expected I, but got O
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (images != null)
		{
			List<object> list = Enumerable.ToList((IEnumerable<object>)images);
			object obj4 = obj2 + 16;
			obj4 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj4;
			bool flag = obj4 == null;
			object obj6 = !flag;
			List<object> list2 = list;
			if (obj6 == null)
			{
				return;
			}
		}
		else
		{
			object obj7 = obj2 + 16;
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj7;
			bool flag2 = obj7 == null;
			List<object> list2 = null;
			if (flag2)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v5+18]");
		if ((nint)0 != 0)
		{
			object obj8 = typeof(Queue<string>) + 760;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v11+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj11 = (nint)0 + (nint)2040;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Object)+10]");
			object go = Enumerable.First((IEnumerable<object>)0);
			object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)1632;
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj14);
			((ImageCacher)(object)action).LoadItemImage(itemId, imageType, (UnityEngine.Object)go, (Action<Sprite>)action);
		}
	}

	public static void LoadClanLogoImage(Image img, int id, int tier, Action<bool> onSuccess = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_00b4: Expected O, but got I4
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0100: Expected O, but got I
		//IL_012d: Expected I, but got O
		//IL_013e: Expected O, but got I
		//IL_0186: Expected I, but got O
		//IL_01b1: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 760;
		object obj4 = (nint)0 + (nint)2040;
		object obj5 = obj2 + 24;
		obj5 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 40;
		obj6 = img;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 0;
		_ = 0;
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
		object obj10 = (nint)0 + (nint)1744;
		GameObject gameObject = ((UnityEngine.Component)obj6).gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj10);
		object obj11 = (nint)0 + (nint)1752;
		((ImageCacher)(object)action).LoadClanLogoElementImage(id, tier, ImageCacher.ClanLogoElementImageType.Main, (UnityEngine.Object)gameObject, (Action<Sprite>)action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj2, (IntPtr)obj11);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+28]");
		((ImageCacher)(object)action2).LoadClanLogoElementImage(id, tier, ImageCacher.ClanLogoElementImageType.Mask, (UnityEngine.Object)0, (Action<Sprite>)action2);
	}

	public static void LoadClanEmblem(Image img, int clanId, FileInfoModel emblem, Action<bool> onSuccess = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0114: Expected O, but got I4
		//IL_011d: Expected O, but got I4
		//IL_00c5: Expected O, but got I4
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_018b: Expected O, but got I4
		//IL_025a: Expected O, but got I
		//IL_026a: Expected O, but got I
		//IL_027a: Expected O, but got I
		//IL_01b4: Expected O, but got I
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_01ed: Expected O, but got I
		//IL_01fe: Expected I, but got O
		//IL_0224: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 880;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj2 + 16;
		obj4 = img;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 24;
		obj5 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v10+E4]");
		if ((nint)0 != 0)
		{
			bool flag = (UnityEngine.Object)obj4 == null;
			bool flag2 = !flag;
			object obj7 = 0;
			UnityEngine.Object obj8 = null;
			if (!flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = (UnityEngine.Object)obj4 == null;
			bool flag4 = !flag3;
			object obj9 = !flag4;
			object obj7 = 0;
			UnityEngine.Object obj8 = null;
			if (obj9 != null)
			{
				return;
			}
		}
		if (emblem != null)
		{
			object obj10 = typeof(Queue<string>) + 760;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v14+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj13 = (nint)0 + (nint)2040;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj14 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj15 = (nint)0 + (nint)1768;
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj15);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Object)+10]");
			((ImageCacher)(object)action).LoadClanEmblem(clanId, emblem, (UnityEngine.Object)0, (Action<Sprite>)action);
		}
		else
		{
			object obj16 = obj5;
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v6+18]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v6+40]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v6+28]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v123 @ X3_v2 (should have been resolved before IL gen)");
			}
		}
	}

	public static void LoadProfileGiftImage(IEnumerable<Image> images, long giftId, Action<bool> onSuccess = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00dd: Expected O, but got I4
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I4
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_0174: Expected O, but got I4
		//IL_019d: Expected O, but got I
		//IL_01b3: Expected O, but got I
		//IL_01c4: Expected O, but got I
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		//IL_01f7: Expected O, but got I
		//IL_0208: Expected I, but got O
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (images != null)
		{
			List<object> list = Enumerable.ToList((IEnumerable<object>)images);
			object obj4 = obj2 + 16;
			obj4 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj4;
			bool flag = obj4 == null;
			object obj6 = !flag;
			List<object> list2 = list;
			if (obj6 == null)
			{
				return;
			}
		}
		else
		{
			object obj7 = obj2 + 16;
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj7;
			bool flag2 = obj7 == null;
			List<object> list2 = null;
			if (flag2)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v5+18]");
		if ((nint)0 != 0)
		{
			object obj8 = typeof(Queue<string>) + 760;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v11+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj11 = (nint)0 + (nint)2040;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj12 = (nint)0 + (nint)4008;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+10]");
			object go = Enumerable.First((IEnumerable<object>)0);
			object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)1776;
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj14);
			((ImageCacher)(object)action).LoadProfileGiftImage(giftId, (UnityEngine.Object)go, (Action<Sprite>)action);
		}
	}

	public static void LoadProfileGiftImage(Image img, long giftId, Action<bool> onSuccess = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00c8: Expected O, but got I4
		//IL_010f: Expected I, but got O
		//IL_0131: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 912;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 760;
		object obj4 = (nint)0 + (nint)2040;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
		object obj6 = (nint)0 + (nint)1784;
		object obj7 = obj2 + 16;
		obj7 = img;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 24;
		obj8 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
		((ImageCacher)(object)action).LoadProfileGiftImage(giftId, (UnityEngine.Object)0, (Action<Sprite>)action);
	}

	public static void LoadAppAnnouncementImage(Image img, AppAnnouncementModel announcement, bool setNative = false, Action<bool> onSuccess = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I4
		//IL_0114: Expected I, but got O
		//IL_0136: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 760;
		object obj4 = (nint)0 + (nint)2040;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
		object obj6 = (nint)0 + (nint)1792;
		object obj7 = obj2 + 16;
		obj7 = img;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 32;
		obj8 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+10]");
		((ImageCacher)(object)action).LoadAppAnnouncementImage(announcement, (UnityEngine.Object)0, (Action<Sprite>)action);
	}

	public static void LoadAdCampaignLogo(Image img, int adCampaignId, bool setNative = false, Action<bool> onSuccess = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I4
		//IL_0114: Expected I, but got O
		//IL_0136: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 928;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 760;
		object obj4 = (nint)0 + (nint)2040;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
		object obj6 = (nint)0 + (nint)1800;
		object obj7 = obj2 + 16;
		obj7 = img;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 32;
		obj8 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+10]");
		((ImageCacher)(object)action).LoadAdCampaignLogoImage(adCampaignId, (UnityEngine.Object)0, (Action<Sprite>)action);
	}

	public static void LoadAchievementImage(Image img, string achievementId, int level, Action<bool> onSuccess = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00c8: Expected O, but got I4
		//IL_010f: Expected I, but got O
		//IL_0135: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 760;
		object obj4 = (nint)0 + (nint)2040;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
		object obj6 = (nint)0 + (nint)1512;
		object obj7 = obj2 + 16;
		obj7 = img;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 24;
		obj8 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+10]");
		((ImageCacher)(object)action).LoadAchievementImage(achievementId, level, (UnityEngine.Object)0, (Action<Sprite>)action);
	}

	public static void LoadAchievementImage(IEnumerable<Image> images, string achievementId, int level, Action<bool> onSuccess = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00dd: Expected O, but got I4
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I4
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_0174: Expected O, but got I4
		//IL_019d: Expected O, but got I
		//IL_01b3: Expected O, but got I
		//IL_01c4: Expected O, but got I
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		//IL_01f7: Expected O, but got I
		//IL_0208: Expected I, but got O
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 728;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (images != null)
		{
			List<object> list = Enumerable.ToList((IEnumerable<object>)images);
			object obj4 = obj2 + 16;
			obj4 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj4;
			bool flag = obj4 == null;
			object obj6 = !flag;
			List<object> list2 = list;
			if (obj6 == null)
			{
				return;
			}
		}
		else
		{
			object obj7 = obj2 + 16;
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj7;
			bool flag2 = obj7 == null;
			List<object> list2 = null;
			if (flag2)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v5+18]");
		if ((nint)0 != 0)
		{
			object obj8 = typeof(Queue<string>) + 760;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v11+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj11 = (nint)0 + (nint)2040;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj12 = (nint)0 + (nint)4008;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Object)+10]");
			object go = Enumerable.First((IEnumerable<object>)0);
			object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)1520;
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj14);
			((ImageCacher)(object)action).LoadAchievementImage(achievementId, level, (UnityEngine.Object)go, (Action<Sprite>)action);
		}
	}

	public static void LoadHighlightImage(Image img, string highlightId, bool setNative = false, Action<bool> onSuccess = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I4
		//IL_0114: Expected I, but got O
		//IL_0136: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 760;
		object obj4 = (nint)0 + (nint)2040;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
		object obj6 = (nint)0 + (nint)1528;
		object obj7 = obj2 + 16;
		obj7 = img;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 32;
		obj8 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+10]");
		((ImageCacher)(object)action).LoadHighlightImage(highlightId, (UnityEngine.Object)0, (Action<Sprite>)action);
	}

	public static void LoadNotificationImage(Image img, Notification notification, ImageCacher.NotificationImageType type, bool setNative = false, Action<bool> onSuccess = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I4
		//IL_0114: Expected I, but got O
		//IL_013a: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 744;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 760;
		object obj4 = (nint)0 + (nint)2040;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
		object obj6 = (nint)0 + (nint)1536;
		object obj7 = obj2 + 16;
		obj7 = img;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 32;
		obj8 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3 (System.Object)+10]");
		((ImageCacher)(object)action).LoadNotificationImage(notification, type, (UnityEngine.Object)0, (Action<Sprite>)action);
	}

	public static void LoadMassTournamentImage(Image img, MassEventModel model, ImageCacher.MassTournamentImageType type, bool setNative = false, Action<bool> onSuccess = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I4
		//IL_0114: Expected I, but got O
		//IL_013a: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 752;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 760;
		object obj4 = (nint)0 + (nint)2040;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
		object obj6 = (nint)0 + (nint)1544;
		object obj7 = obj2 + 16;
		obj7 = img;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 32;
		obj8 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3 (System.Object)+10]");
		((ImageCacher)(object)action).LoadMassTournamentImage(model, type, (UnityEngine.Object)0, (Action<Sprite>)action);
	}

	public static void LoadMassTournamentPrizeImage(Image img, MassEventPrizeViewModel prize, long massTournamentId, bool setNative = false, Action<bool> onSuccess = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I4
		//IL_0114: Expected I, but got O
		//IL_013a: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 760;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 760;
		object obj4 = (nint)0 + (nint)2040;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
		object obj6 = (nint)0 + (nint)1552;
		object obj7 = obj2 + 16;
		obj7 = img;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 32;
		obj8 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3 (System.Object)+10]");
		((ImageCacher)(object)action).LoadMassTournamentPrizeImage(prize, massTournamentId, (UnityEngine.Object)0, (Action<Sprite>)action);
	}

	public static void LoadMassTournamentBannerImage(Image img, MassEventSponsorBannerViewModel banner, long massTournamentId, bool setNative = false, Action<bool> onSuccess = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I4
		//IL_0114: Expected I, but got O
		//IL_013a: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 760;
		object obj4 = (nint)0 + (nint)2040;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
		object obj6 = (nint)0 + (nint)1560;
		object obj7 = obj2 + 16;
		obj7 = img;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 32;
		obj8 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3 (System.Object)+10]");
		((ImageCacher)(object)action).LoadMassTournamentBannerImage(banner, massTournamentId, (UnityEngine.Object)0, (Action<Sprite>)action);
	}

	public static void LoadPredictAndWinImage(Image img, MatchPredictionModel model, ImageCacher.PredictAndWinImageType type, bool setNative = false, Action<bool> onSuccess = null, ILoadingIndicator loading = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0238: Expected O, but got I
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_0258: Expected O, but got I
		//IL_0282: Expected O, but got I4
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00f8: Expected O, but got I
		//IL_01ed: Expected I, but got O
		//IL_0213: Expected O, but got I
		//IL_02c4: Expected O, but got I
		//IL_0133: Expected O, but got I
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 760;
		object obj4 = obj2 + 16;
		obj4 = img;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 32;
		obj5 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 40;
		obj6 = loading;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj6;
		bool flag = obj6 == null;
		ImageCacher.PredictAndWinImageType predictAndWinImageType = type;
		ILoadingIndicator loadingIndicator = loading;
		if (flag)
		{
			goto IL_022c;
		}
		object obj8 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3528;
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v8+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v8+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0174;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v8+B0]");
		object obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X10_v7-8]");
			if (0 == (nint)obj8)
			{
				break;
			}
			obj11 += 16;
			obj10--;
			if ((nint)obj10 != 1)
			{
				continue;
			}
			goto IL_0174;
		}
		object obj12 = obj9 + obj11;
		object obj13 = obj12 + 312;
		predictAndWinImageType = type;
		goto IL_02b4;
		IL_02b4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v22+8]");
		loadingIndicator = (ILoadingIndicator)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v289 @ X0_v22] (should have been resolved before IL gen)");
		goto IL_022c;
		IL_022c:
		object obj14 = (nint)0 + (nint)2040;
		object obj15 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
		object obj16 = (nint)0 + (nint)1568;
		object obj17 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v15+E4]");
		bool flag2 = (nint)0 == 0;
		object obj18 = !flag2;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj16);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3 (System.Object)+10]");
		((ImageCacher)(object)action).LoadPredictAndWinImage(model, type, (UnityEngine.Object)0, (Action<Sprite>)action);
		return;
		IL_0174:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		predictAndWinImageType = ImageCacher.PredictAndWinImageType.LeagueLogo;
		goto IL_02b4;
	}

	public static void LoadPredictionSeasonImage(Image img, PredictionSeasonModel model, Action<bool> onSuccess = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00c8: Expected O, but got I4
		//IL_010f: Expected I, but got O
		//IL_0131: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 784;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 760;
		object obj4 = (nint)0 + (nint)2040;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
		object obj6 = (nint)0 + (nint)1576;
		object obj7 = obj2 + 16;
		obj7 = img;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 24;
		obj8 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
		((ImageCacher)(object)action).LoadPredictionSeasonImage(model, (UnityEngine.Object)0, (Action<Sprite>)action);
	}

	public static void LoadSportTeamImage(Image img, SportTeam team, ImageCacher.SportTeamImageType type, bool setNative = false, Action<bool> onSuccess = null, ILoadingIndicator loading = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0238: Expected O, but got I
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_0258: Expected O, but got I
		//IL_0282: Expected O, but got I4
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00f8: Expected O, but got I
		//IL_01ed: Expected I, but got O
		//IL_0213: Expected O, but got I
		//IL_02c4: Expected O, but got I
		//IL_0133: Expected O, but got I
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 792;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 760;
		object obj4 = obj2 + 16;
		obj4 = img;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 32;
		obj5 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 40;
		obj6 = loading;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj6;
		bool flag = obj6 == null;
		ImageCacher.SportTeamImageType sportTeamImageType = type;
		ILoadingIndicator loadingIndicator = loading;
		if (flag)
		{
			goto IL_022c;
		}
		object obj8 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3528;
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v8+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v8+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0174;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v8+B0]");
		object obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X10_v7-8]");
			if (0 == (nint)obj8)
			{
				break;
			}
			obj11 += 16;
			obj10--;
			if ((nint)obj10 != 1)
			{
				continue;
			}
			goto IL_0174;
		}
		object obj12 = obj9 + obj11;
		object obj13 = obj12 + 312;
		sportTeamImageType = type;
		goto IL_02b4;
		IL_02b4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v22+8]");
		loadingIndicator = (ILoadingIndicator)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v289 @ X0_v22] (should have been resolved before IL gen)");
		goto IL_022c;
		IL_022c:
		object obj14 = (nint)0 + (nint)2040;
		object obj15 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
		object obj16 = (nint)0 + (nint)1584;
		object obj17 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v15+E4]");
		bool flag2 = (nint)0 == 0;
		object obj18 = !flag2;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj16);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3 (System.Object)+10]");
		((ImageCacher)(object)action).LoadSportTeamImage(team, type, (UnityEngine.Object)0, (Action<Sprite>)action);
		return;
		IL_0174:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		sportTeamImageType = ImageCacher.SportTeamImageType.Prediction;
		goto IL_02b4;
	}

	public static void LoadProductImage(Image img, ProductViewModel product, bool setNative = false, Action<bool> onSuccess = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I4
		//IL_0114: Expected I, but got O
		//IL_0136: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 808;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 760;
		object obj4 = (nint)0 + (nint)2040;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
		object obj6 = (nint)0 + (nint)1600;
		object obj7 = obj2 + 16;
		obj7 = img;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 32;
		obj8 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+10]");
		((ImageCacher)(object)action).LoadProductImage(product, (UnityEngine.Object)0, (Action<Sprite>)action);
	}

	public static void LoadStoreBannerImage(Image img, StoreBannerViewModel banner, ImageCacher.BannerSize type, bool setNative = false, Action<bool> onSuccess = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I4
		//IL_0114: Expected I, but got O
		//IL_013a: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 760;
		object obj4 = (nint)0 + (nint)2040;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
		object obj6 = (nint)0 + (nint)1608;
		object obj7 = obj2 + 16;
		obj7 = img;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 32;
		obj8 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3 (System.Object)+10]");
		((ImageCacher)(object)action).LoadStoreBannerImage(banner, type, (UnityEngine.Object)0, (Action<Sprite>)action);
	}

	public static void AssignAvatarImage(Image image, User user)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_006c: Expected O, but got I
		//IL_013e: Expected O, but got I4
		//IL_0157: Expected I4, but got O
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		object obj = typeof(UsageHint) + 8;
		nint num = (nint)user;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X10_v5-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj3 += 16;
			obj2--;
			if ((nint)obj2 != 1)
			{
				continue;
			}
			goto IL_00ad;
		}
		object obj4 = obj3 + 1;
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		goto IL_010e;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_010e;
		IL_010e:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v177 @ X0_v3] (should have been resolved before IL gen)");
		object obj7 = "___# Content push apply failed [{0}]: {1}" + 3224;
		DateTime? variable = SFSExtensions.GetVariable(user, (string)obj7, (DateTime?)(object)0);
		string dbId = default(string);
		AssignAvatarImage(image, dbId, variable, (byte)(int)obj7 != 0);
	}

	public static void AssignAvatarImage(Image image, PlayerInfo user)
	{
		int num = default(int);
		string dbId = num.ToString();
		DateTime? <AvatarDate>k__BackingField = user.<AvatarDate>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [user @ X1 (PlayerInfo)+38]");
		AssignAvatarImage(image, dbId, <AvatarDate>k__BackingField, fullSize: false);
	}

	public static void AssignAvatarImage(Image image, string dbId, DateTime? avatarDate, bool fullSize = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_00ef: Expected O, but got I4
		//IL_00f8: Expected O, but got I4
		//IL_00a0: Expected O, but got I4
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_01bc: Expected O, but got I4
		//IL_0171: Expected O, but got I4
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_0347: Expected O, but got I4
		//IL_0370: Expected O, but got I
		//IL_0386: Expected O, but got I
		//IL_0252: Expected O, but got I4
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_03c2: Expected O, but got I
		//IL_03d3: Expected I, but got O
		//IL_027b: Expected O, but got I
		//IL_0291: Expected O, but got I
		//IL_03f9: Expected O, but got I
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_02cd: Expected O, but got I
		//IL_02de: Expected I, but got O
		//IL_0304: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj2 + 16;
		obj4 = image;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			bool flag = (UnityEngine.Object)obj4 == null;
			bool flag2 = !flag;
			object obj6 = 0;
			UnityEngine.Object obj7 = null;
			if (!flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = (UnityEngine.Object)obj4 == null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			object obj6 = 0;
			UnityEngine.Object obj7 = null;
			if (obj8 != null)
			{
				return;
			}
		}
		object obj9 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v11+E4]");
		if ((nint)0 != 0)
		{
			int num = Convert.ToInt32(dbId);
			bool flag5 = num > 0;
			object obj11 = 0;
			if (flag5)
			{
				goto IL_01cb;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			int num = Convert.ToInt32(dbId);
			bool flag6 = num <= 0;
			object obj11 = 0;
			if (!flag6)
			{
				goto IL_01cb;
			}
		}
		goto IL_0309;
		IL_01cb:
		object obj12 = (??)avatarDate & 1;
		if (obj12 != null)
		{
			object obj13 = typeof(Queue<string>) + 760;
			object obj14 = obj13;
			IntPtr intPtr = default(IntPtr);
			DateTime? dateTime = default(DateTime?);
			if (intPtr != (IntPtr)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v16+E4]");
				bool flag7 = (nint)0 == 0;
				object obj15 = !flag7;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj16 = (nint)0 + (nint)2040;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				object obj17 = (nint)0 + (nint)2296;
				DateTime value = dateTime.Value;
				object obj18 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj19 = (nint)0 + (nint)1616;
				Action<object> action = default(Action<object>);
				action..ctor(obj2, (IntPtr)obj19);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3 (System.Object)+10]");
				((ImageCacher)(object)action).LoadFullAvatarImage(dbId, (UnityEngine.Object)0, value, (Action<Sprite>)action);
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v16+E4]");
				bool flag8 = (nint)0 == 0;
				object obj20 = !flag8;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj21 = (nint)0 + (nint)2040;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				object obj22 = (nint)0 + (nint)2296;
				DateTime value2 = dateTime.Value;
				object obj23 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj24 = (nint)0 + (nint)1616;
				Action<object> action2 = default(Action<object>);
				action2..ctor(obj2, (IntPtr)obj24);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3 (System.Object)+10]");
				((ImageCacher)(object)action2).LoadAvatarThumbnail(dbId, (UnityEngine.Object)0, value2, (Action<Sprite>)action2);
			}
			return;
		}
		goto IL_0309;
		IL_0309:
		Sprite avatarPlaceholder = ImageCacher.AvatarPlaceholder;
		((Image)obj4).sprite = avatarPlaceholder;
	}

	public static void AssignAvatarImageButLookForAvatarTimestampFirstBecauseIDontHaveIt(Image image, int dbId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01f2: Expected O, but got I4
		//IL_010f: Expected O, but got I4
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_021a: Expected O, but got I4
		//IL_01af: Expected O, but got I4
		//IL_0245: Expected I4, but got O
		//IL_019c: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FriendProfile profile = FriendsManager.GetProfile(dbId);
		int num = default(int);
		string userDbId = num.ToString();
		User onlineUser = SFS.GetOnlineUser(userDbId);
		string userId = num.ToString();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v4+E4]");
		bool flag2;
		PlayerProfileModel playerProfileModel;
		if ((nint)0 != 0)
		{
			flag2 = PlayerProfilesHandler.TryGetCached(userId, out playerProfileModel);
			if (onlineUser != null)
			{
				goto IL_00c1;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			flag2 = PlayerProfilesHandler.TryGetCached(userId, out playerProfileModel);
			bool flag3 = onlineUser == null;
			object obj6 = !flag3;
			if (obj6 != null)
			{
				goto IL_00c1;
			}
		}
		DateTime? dateTime;
		string text;
		if (profile != null)
		{
			dateTime = profile.AvatarDate;
			text = null;
			goto IL_0151;
		}
		DateTime? avatarDate;
		string text2;
		if (flag2)
		{
			avatarDate = playerProfileModel.<avatarDate>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ stack_-40_v7 (PlayerProfileModel)+60]");
			text2 = (string)0;
		}
		else
		{
			text2 = null;
			avatarDate = (DateTime?)(object)0;
		}
		goto IL_0223;
		IL_00c1:
		object obj7 = "___# Content push apply failed [{0}]: {1}" + 3224;
		text = (string)obj7;
		dateTime = SFSExtensions.GetVariable(onlineUser, (string)obj7, (DateTime?)(object)0);
		goto IL_0151;
		IL_0223:
		string dbId2 = num.ToString();
		AssignAvatarImage(image, dbId2, avatarDate, (byte)(int)text2 != 0);
		return;
		IL_0151:
		text2 = text;
		avatarDate = dateTime;
		goto IL_0223;
	}

	public static void SetAlpha(Graphic img, float alpha)
	{
		//IL_0015: Expected I, but got O
		//IL_0025: Expected O, but got I
		//IL_0035: Expected O, but got I
		Color color = img.color;
		nint num = (nint)img;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v2 (Il2CppClass<UnityEngine.UI.Graphic>)+2A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v2 (Il2CppClass<UnityEngine.UI.Graphic>)+2B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v37 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public static void SetAlphaChildren(Graphic img, float alpha, bool includeParent = true)
	{
		//IL_0011: Expected O, but got I
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_011f: Expected O, but got I4
		//IL_0169: Expected O, but got I
		//IL_007d: Expected O, but got I4
		//IL_020d: Expected O, but got I
		//IL_02a2: Expected O, but got I
		//IL_0230: Expected O, but got I4
		//IL_0235: Expected I, but got O
		//IL_0242: Expected I, but got O
		//IL_01ab: Expected O, but got I
		//IL_01c9: Expected O, but got I4
		//IL_01ce: Expected I, but got O
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_0258: Expected I, but got O
		//IL_026a: Expected I, but got O
		//IL_027a: Expected O, but got I
		//IL_01e9: Expected I, but got O
		object obj = (nint)0 + (nint)688;
		UnityEngine.Object obj2 = (UnityEngine.Object)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31C20");
		object obj4 = default(object);
		object obj3 = obj4 + 32;
		if (includeParent)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v5+18]");
			if ((nint)0 >= (nint)1)
			{
				object obj5 = 0;
				object obj9;
				do
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X22_v2+v130 @ X21_v8*8]");
					object obj6 = 0;
					obj5++;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v249 @ X8_v15+298] (should have been resolved before IL gen)");
					object obj8 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v254 @ X8_v16+2A8] (should have been resolved before IL gen)");
					obj9 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v5+18]");
				}
				while ((nint)obj9 < 0);
			}
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v5+18]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		object obj10 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj11 = 0;
		object obj16;
		do
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X22_v2+v66 @ X23_v5*8]");
			UnityEngine.Object obj12 = (UnityEngine.Object)0;
			object obj13 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v8+E4]");
			nint num2;
			nint num;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X22_v2+v66 @ X23_v5*8]");
				bool flag = (UnityEngine.Object)0 == img;
				bool flag2 = !flag;
				object obj14 = !flag2;
				num = unchecked((nint)null);
				obj2 = img;
				if (obj14 != null)
				{
					goto IL_0124;
				}
				num2 = unchecked((nint)null);
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X22_v2+v66 @ X23_v5*8]");
				bool flag3 = (UnityEngine.Object)0 == img;
				bool flag4 = !flag3;
				object obj15 = !flag4;
				num = unchecked((nint)null);
				obj2 = img;
				num2 = unchecked((nint)null);
				if (obj15 != null)
				{
					goto IL_0124;
				}
			}
			nint num3 = (nint)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v281 @ X8_v10 (Il2CppClass<UnityEngine.Object>)+298] (should have been resolved before IL gen)");
			nint num4 = (nint)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v11 (Il2CppClass<UnityEngine.Object>)+2B0]");
			obj2 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v276 @ X8_v11 (Il2CppClass<UnityEngine.Object>)+2A8] (should have been resolved before IL gen)");
			num = num2;
			goto IL_0124;
			IL_0124:
			obj11++;
			obj16 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v5+18]");
		}
		while ((nint)obj16 < 0);
	}

	private static Texture2D CreateInvalidTexture()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Texture2D texture2D = default(Texture2D);
		texture2D..ctor(8, 8);
		if ((object)texture2D != null)
		{
			object obj2 = typeof(TypeConverter<ushort, char>) + 1880;
			texture2D.filterMode = FilterMode.Point;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			byte[] data = default(byte[]);
			bool flag = ImageConversion.LoadImage(texture2D, data);
			return texture2D;
		}
		return (Texture2D)(object)new NullReferenceException();
	}

	public static bool IsValid(Texture2D tex)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00de: Expected O, but got I4
		//IL_023e: Expected I4, but got O
		//IL_0123: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5EB4]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v22+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v22+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = tex == null;
		bool flag3 = !flag2;
		object obj6 = !flag3;
		if (obj6 != null)
		{
			goto IL_00a8;
		}
		goto IL_0131;
		IL_00a8:
		return false;
		IL_0131:
		Texture2D invalidTexture = InvalidTexture;
		if ((object)tex != null)
		{
			int width = tex.width;
			if ((object)invalidTexture != null)
			{
				int width2 = invalidTexture.width;
				if (width == width2)
				{
					int height = tex.height;
					int height2 = invalidTexture.height;
					if (height == height2)
					{
						Color[] pixels = tex.GetPixels();
						Color[] pixels2 = invalidTexture.GetPixels();
						bool flag4 = Enumerable.SequenceEqual(pixels, pixels2);
						return (byte)((flag4 ? 1u : 0u) ^ 1u) != 0;
					}
				}
				return true;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_007d:
		if (tex == null)
		{
			goto IL_00a8;
		}
		goto IL_0131;
	}

	public static RectTransform rectTransform(UnityEngine.Component go)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		UnityEngine.Component component = default(UnityEngine.Component);
		if ((object)component != null)
		{
			Transform transform = component.transform;
			bool flag = (object)transform == null;
			RectTransform result = (RectTransform)transform;
			if (!flag)
			{
				object obj = typeof(System.Buffers.Text.ParserHelpers) + 3600;
				result = (RectTransform)((transform != obj) ? null : transform);
			}
			return result;
		}
		return (RectTransform)(object)new NullReferenceException();
	}

	public static RectTransform parent(RectTransform rt)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		if ((object)rt != null)
		{
			Transform transform = rt.parent;
			bool flag = (object)transform == null;
			RectTransform result = (RectTransform)transform;
			if (!flag)
			{
				object obj = typeof(System.Buffers.Text.ParserHelpers) + 3600;
				result = (RectTransform)((transform != obj) ? null : transform);
			}
			return result;
		}
		return (RectTransform)(object)new NullReferenceException();
	}

	public static RectTransform parentRt(Transform transform)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		Transform transform2 = default(Transform);
		if ((object)transform2 != null)
		{
			Transform transform3 = transform2.parent;
			bool flag = (object)transform3 == null;
			RectTransform result = (RectTransform)transform3;
			if (!flag)
			{
				object obj = typeof(System.Buffers.Text.ParserHelpers) + 3600;
				result = (RectTransform)((transform3 != obj) ? null : transform3);
			}
			return result;
		}
		return (RectTransform)(object)new NullReferenceException();
	}

	public static void SetPivot(RectTransform rectTransform, Vector2 pivot)
	{
		//IL_004d: Expected O, but got I4
		//IL_004d: Expected O, but got I4
		//IL_005f: Expected O, but got I4
		//IL_007f: Expected O, but got I4
		Vector2 pivot2 = rectTransform.pivot;
		Vector2 sizeDelta = rectTransform.sizeDelta;
		Vector3 localScale = rectTransform.localScale;
		Quaternion rotation = rectTransform.rotation;
		Vector3 vector = (Quaternion)0 * (Vector3)0;
		rectTransform.pivot = (Vector2)0;
		Vector2 anchoredPosition = rectTransform.anchoredPosition;
		rectTransform.anchoredPosition = (Vector2)0;
	}

	public static Rect GetScreenPositionFromRect(RectTransform rt)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0122: Expected O, but got I4
		//IL_0050: Expected O, but got I4
		//IL_0058: Expected O, but got I4
		//IL_00e5: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = rt == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		Rect result = (Rect)flag2;
		if (obj4 == null)
		{
			if ((object)rt == null)
			{
				return (Rect)new NullReferenceException();
			}
			Vector2 sizeDelta = rt.sizeDelta;
			float scaleFactor = ScreenUtility.ScaleFactor;
			Vector3 position = rt.position;
			float scaleFactor2 = ScreenUtility.ScaleFactor;
			Vector3 lossyScale = rt.lossyScale;
			int height = UnityEngine.Device.Screen.height;
			int width = UnityEngine.Device.Screen.width;
			result = (Rect)width;
		}
		return result;
	}

	public static void MaximizeInParent(RectTransform rect)
	{
		//IL_0013: Expected O, but got I4
		//IL_0026: Expected O, but got I4
		//IL_0039: Expected O, but got I4
		//IL_004c: Expected O, but got I4
		rect.anchorMin = (Vector2)0;
		rect.anchorMax = (Vector2)0;
		rect.sizeDelta = (Vector2)0;
		rect.anchoredPosition = (Vector2)0;
	}

	public unsafe static void DestroyAllChildren(Transform transform, GameObject[] except)
	{
		//IL_05f8: Expected O, but got I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0080: Expected O, but got I
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_010a: Expected I, but got O
		//IL_011a: Expected O, but got I
		//IL_01b5: Expected I, but got O
		//IL_06cf: Expected I, but got O
		//IL_06df: Expected O, but got I
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected O, but got Unknown
		//IL_0155: Expected O, but got I
		//IL_049d: Expected O, but got I4
		//IL_04a6: Expected O, but got I4
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected O, but got Unknown
		//IL_0792: Expected O, but got I4
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_017e: Expected O, but got I
		//IL_04c3: Expected O, but got I
		//IL_020f: Expected I, but got O
		//IL_021f: Expected O, but got I
		//IL_0556: Expected I, but got O
		//IL_07d4: Expected O, but got I
		//IL_04fe: Expected O, but got I
		//IL_0741: Expected I, but got O
		//IL_0751: Expected O, but got I
		//IL_025a: Expected O, but got I
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Expected I, but got Unknown
		//IL_0309: Expected I, but got O
		//IL_0319: Expected O, but got I
		//IL_0356: Expected O, but got I4
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected O, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected O, but got Unknown
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Expected O, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_0283: Expected O, but got I
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected O, but got Unknown
		//IL_03d8: Expected I, but got O
		//IL_0408: Expected O, but got I4
		//IL_0465: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5EB9]");
		nint num = 0;
		Transform transform2 = default(Transform);
		GameObject[] array;
		nint num2;
		object obj6;
		object obj7 = default(object);
		nint num3 = default(nint);
		object obj16;
		GameObject[] array2 = default(GameObject[]);
		if ((object)transform2 != null)
		{
			IEnumerator enumerator = transform2.GetEnumerator();
			bool flag = enumerator == null;
			array = null;
			object obj = default(object);
			num = (nint)(&obj);
			if (flag)
			{
				goto IL_05a2;
			}
			object obj2 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
			object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1952;
			object obj4 = (nint)0 + (nint)3208;
			object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
			num2 = num3;
			obj6 = obj7;
			IEnumerator enumerator2 = enumerator;
			object obj10 = default(object);
			object obj12 = default(object);
			IEnumerator enumerator3 = default(IEnumerator);
			object obj15 = default(object);
			object obj19 = default(object);
			object obj25 = default(object);
			IntPtr intPtr = default(IntPtr);
			UnityEngine.Component component = default(UnityEngine.Component);
			while (true)
			{
				nint num4 = (nint)enumerator2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v17 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				GameObject gameObject = (GameObject)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v17 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_01a6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v17 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
				object obj8 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X10_v25-8]");
					if (0 == (nint)obj2)
					{
						break;
					}
					obj6 = obj8 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v17 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					gameObject = (GameObject)(-1);
					bool flag2 = (nint)gameObject != 1;
					obj8 = obj6;
					if (flag2)
					{
						continue;
					}
					goto IL_01a6;
				}
				gameObject = (GameObject)obj8;
				object obj9 = num4 + obj8;
				obj10 = obj9 + 312;
				obj6 = obj8;
				goto IL_06c7;
				IL_06c7:
				num = (nint)obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X0_v27+8]");
				array = (GameObject[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v389 @ X0_v27] (should have been resolved before IL gen)");
				object obj11 = obj12 & 1;
				if (obj11 != null)
				{
					if (enumerator3 == null)
					{
						break;
					}
					nint num5 = (nint)enumerator3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v20 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					gameObject = (GameObject)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v20 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_02ab;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v20 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
					object obj13 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X10_v20-8]");
						if (0 == (nint)obj2)
						{
							break;
						}
						obj6 = obj13 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v20 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
						gameObject = (GameObject)(-1);
						bool flag3 = (nint)gameObject != 1;
						obj13 = obj6;
						if (flag3)
						{
							continue;
						}
						goto IL_02ab;
					}
					gameObject = (GameObject)(obj13 + 1);
					object obj14 = num5 + gameObject;
					obj15 = obj14 + 312;
					obj6 = obj13;
					goto IL_0739;
				}
				num3 = num2;
				obj7 = obj6;
				obj16 = 0;
				object obj17 = 0;
				while (true)
				{
					object obj18 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
					array2 = (GameObject[])obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					if (obj19 == null)
					{
						goto IL_0778;
					}
					object obj20 = obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X8_v6+12E]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X8_v6+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0547;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X8_v6+B0]");
					object obj22 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X10_v8-8]");
						if (0 == (nint)obj18)
						{
							break;
						}
						obj7 = obj22 + 16;
						obj21--;
						bool flag4 = (nint)obj21 != 1;
						obj22 = obj7;
						if (flag4)
						{
							continue;
						}
						goto IL_0547;
					}
					object obj23 = obj20 + obj22;
					num = (nint)(obj23 + 312);
					obj7 = obj22;
					goto IL_07c4;
					IL_0778:
					bool flag5 = obj17 == null;
					object obj24 = !flag5;
					if (obj24 == null)
					{
						return;
					}
					OutOfMemoryException ex = new OutOfMemoryException();
					if ((nint)array2 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
					obj17 = obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
					obj16 = obj25;
					continue;
					IL_0547:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					num3 = unchecked((nint)null);
					num = intPtr;
					goto IL_07c4;
					IL_07c4:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v29 (Il2CppClass<UnityEngine.Component>)+8]");
					array2 = (GameObject[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v240 @ X8_v29 (Il2CppClass<UnityEngine.Component>)] (should have been resolved before IL gen)");
					goto IL_0778;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99B68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
				return;
				IL_02ab:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num2 = 1;
				goto IL_0739;
				IL_0739:
				num = (nint)obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X0_v31+8]");
				array = (GameObject[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v571 @ X0_v31] (should have been resolved before IL gen)");
				if ((object)component != null)
				{
					array = (GameObject[])obj3;
					num = (nint)component;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v29 (Il2CppClass<UnityEngine.Component>)+130]");
					obj7 = 0;
					gameObject = array[34];
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v29 (Il2CppClass<UnityEngine.Component>)+130]");
					bool flag6 = 0 < (nint)array[34];
					object obj26 = !flag6;
					object obj27 = ~obj26;
					if (obj27 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v29 (Il2CppClass<UnityEngine.Component>)+C8]");
						object obj28 = 0 + array[34];
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X8_v26-8]");
						num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X8_v26-8]");
						if (0 == (nint)array)
						{
							GameObject gameObject2 = component.gameObject;
							num2 = (nint)obj4;
							bool flag7 = Enumerable.Contains((IEnumerable<object>)array2, (object)gameObject2);
							bool flag8 = !flag7;
							object obj29 = !flag8;
							object obj30 = gameObject2;
							if (obj29 == null)
							{
								GameObject gameObject3 = component.gameObject;
								object obj31 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X0_v43+E4]");
								num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X0_v43+E4]");
								bool flag9 = (nint)0 == 0;
								object obj32 = !flag9;
								if (obj32 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								UnityEngine.Object.Destroy(gameObject3);
								obj30 = null;
							}
							bool flag10 = enumerator3 == null;
							obj6 = obj7;
							enumerator2 = enumerator3;
							num3 = num2;
							array = (GameObject[])obj30;
							if (!flag10)
							{
								continue;
							}
							goto IL_05a2;
						}
					}
					goto IL_058c;
				}
				goto IL_05b0;
				IL_01a6:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num2 = unchecked((nint)null);
				goto IL_06c7;
			}
			NullReferenceException ex2 = new NullReferenceException();
			num3 = num2;
			obj7 = obj6;
			goto IL_05ec;
		}
		goto IL_0826;
		IL_05a2:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_05ec;
		IL_05b0:
		NullReferenceException ex4 = new NullReferenceException();
		num3 = num2;
		obj7 = obj6;
		goto IL_05ec;
		IL_0826:
		throw new NullReferenceException();
		IL_058c:
		InvalidCastException ex5 = new InvalidCastException();
		num3 = num2;
		goto IL_05ec;
		IL_05ec:
		obj16 = 0;
		array2 = array;
		goto IL_0826;
	}

	public static IEnumerable<Transform> DescendantsAndSelf(GameObject go)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		if ((object)go != null)
		{
			Transform transform = go.transform;
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 936;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			_ = 4294967294L;
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			object obj3 = obj2 + 48;
			obj3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (IEnumerable<Transform>)obj2;
		}
		return (IEnumerable<Transform>)new NullReferenceException();
	}

	public static IEnumerable<Transform> DescendantsAndSelf(Transform transform)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 936;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 4294967294L;
		int currentManagedThreadId = Environment.CurrentManagedThreadId;
		object obj3 = obj2 + 48;
		obj3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerable<Transform>)obj2;
	}

	public static void TweenShowBlur(BlurOptimized blur, int downsample, float size, int iternations, float duration)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0072: Expected O, but got I
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0092: Expected O, but got I
		//IL_00e1: Expected O, but got I4
		//IL_012b: Expected I, but got O
		//IL_014b: Expected I, but got O
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_01a9: Expected O, but got I
		//IL_01ba: Expected I, but got O
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01e9: Expected O, but got I
		//IL_01fa: Expected I, but got O
		//IL_0244: Expected O, but got I
		//IL_0255: Expected I, but got O
		//IL_0270: Expected O, but got I
		//IL_0281: Expected I, but got O
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = blur;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj5 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 32;
		object obj6 = (nint)0 + (nint)1640;
		object obj7 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 112;
		object obj8 = (nint)0 + (nint)1648;
		((Behaviour)obj3).enabled = true;
		int num = ShortcutExtensions.DOKill((UnityEngine.Component)obj3);
		object obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence s = DOTween.Sequence(obj3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DOGetter<int> dOGetter = default(DOGetter<int>);
		dOGetter..ctor(obj2, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DOSetter<int> dOSetter = default(DOSetter<int>);
		dOSetter..ctor(obj2, (IntPtr)obj8);
		TweenerCore<int, int, NoOptions> t = DOTween.To(dOGetter, dOSetter, downsample, duration);
		Sequence sequence = TweenSettingsExtensions.Join(s, t);
		object obj11 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)1656;
		DOGetter<float> dOGetter2 = default(DOGetter<float>);
		dOGetter2..ctor(obj2, (IntPtr)obj12);
		object obj13 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)1664;
		DOSetter<float> dOSetter2 = default(DOSetter<float>);
		dOSetter2..ctor(obj2, (IntPtr)obj14);
		TweenerCore<float, float, FloatOptions> t2 = DOTween.To(dOGetter2, dOSetter2, size, duration);
		Sequence sequence2 = TweenSettingsExtensions.Join(s, t2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)1672;
		DOGetter<int> dOGetter3 = default(DOGetter<int>);
		dOGetter3..ctor(obj2, (IntPtr)obj15);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj16 = (nint)0 + (nint)1680;
		DOSetter<int> dOSetter3 = default(DOSetter<int>);
		dOSetter3..ctor(obj2, (IntPtr)obj16);
		TweenerCore<int, int, NoOptions> t3 = DOTween.To(dOGetter3, dOSetter3, iternations, duration);
		Sequence sequence3 = TweenSettingsExtensions.Join(s, t3);
	}

	public static void TweenHideBlur(BlurOptimized blur, float duration, Action onComplete = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006d: Expected O, but got I
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_0102: Expected O, but got I4
		//IL_014c: Expected I, but got O
		//IL_016c: Expected I, but got O
		//IL_01b7: Expected O, but got I
		//IL_01c8: Expected I, but got O
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_01f7: Expected O, but got I
		//IL_0208: Expected I, but got O
		//IL_0253: Expected O, but got I
		//IL_0264: Expected I, but got O
		//IL_027f: Expected O, but got I
		//IL_0290: Expected I, but got O
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		//IL_02d9: Expected O, but got I
		//IL_02ea: Expected I, but got O
		//IL_02fb: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj4 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 32;
		object obj5 = (nint)0 + (nint)1688;
		object obj6 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 112;
		object obj7 = (nint)0 + (nint)1696;
		object obj8 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 56;
		object obj9 = obj2 + 16;
		obj9 = blur;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj10 = obj2 + 24;
		obj10 = onComplete;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int num = ShortcutExtensions.DOKill((UnityEngine.Component)obj9);
		object obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj12 = !flag;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence s = DOTween.Sequence(obj9);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DOGetter<int> dOGetter = default(DOGetter<int>);
		dOGetter..ctor(obj2, (IntPtr)obj5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DOSetter<int> dOSetter = default(DOSetter<int>);
		dOSetter..ctor(obj2, (IntPtr)obj7);
		TweenerCore<int, int, NoOptions> t = DOTween.To(dOGetter, dOSetter, 0, duration);
		Sequence sequence = TweenSettingsExtensions.Join(s, t);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)1704;
		DOGetter<float> dOGetter2 = default(DOGetter<float>);
		dOGetter2..ctor(obj2, (IntPtr)obj13);
		object obj14 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)1712;
		DOSetter<float> dOSetter2 = default(DOSetter<float>);
		dOSetter2..ctor(obj2, (IntPtr)obj15);
		TweenerCore<float, float, FloatOptions> t2 = DOTween.To(dOGetter2, dOSetter2, 0f, duration);
		Sequence sequence2 = TweenSettingsExtensions.Join(s, t2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj16 = (nint)0 + (nint)1720;
		DOGetter<int> dOGetter3 = default(DOGetter<int>);
		dOGetter3..ctor(obj2, (IntPtr)obj16);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)1728;
		DOSetter<int> dOSetter3 = default(DOSetter<int>);
		dOSetter3..ctor(obj2, (IntPtr)obj17);
		TweenerCore<int, int, NoOptions> tweenerCore = DOTween.To(dOGetter3, dOSetter3, 0, duration);
		object obj18 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj19 = (nint)0 + (nint)1736;
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(obj2, (IntPtr)obj19);
		object obj20 = (nint)0 + (nint)2464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		Tween t3 = default(Tween);
		Sequence sequence3 = TweenSettingsExtensions.Join(s, t3);
	}

	public static void MoveTo(Transform gObject, bool isWorldPositions = false, float? x = null, float? y = null, float? z = null)
	{
		//IL_000e: Expected F4, but got O
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00fa: Expected O, but got I4
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_0288: Expected O, but got I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0048: Expected O, but got I4
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01c2: Expected O, but got I4
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02d4: Expected O, but got I4
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_020e: Expected O, but got I4
		//IL_016d: Expected O, but got I4
		//IL_00bb: Expected O, but got I4
		float num = (object?)x >> 32;
		float value = default(float);
		float num3 = default(float);
		float num4 = default(float);
		float num6 = default(float);
		float num7 = default(float);
		if (isWorldPositions)
		{
			Vector3 position = gObject.position;
			object obj = (??)x & 1;
			bool flag = obj == null;
			object obj2 = !flag;
			object obj3 = ~obj2;
			if (obj3 == null)
			{
				value = num;
			}
			float? num2 = value;
			object obj4 = (??)y & 1;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			object obj6 = ~obj5;
			float value2 = ((obj6 != null) ? num3 : num4);
			float? num5 = value2;
			object obj7 = (??)z & 1;
			bool flag3 = obj7 == null;
			object obj8 = !flag3;
			object obj9 = ~obj8;
			float value3 = ((obj9 != null) ? num6 : num7);
			float? num8 = value3;
			float value4 = num2.Value;
			float value5 = num5.Value;
			float value6 = num8.Value;
			gObject.position = (Vector3)0;
		}
		else
		{
			Vector3 localPosition = gObject.localPosition;
			object obj10 = (??)x & 1;
			bool flag4 = obj10 == null;
			object obj11 = !flag4;
			object obj12 = ~obj11;
			if (obj12 == null)
			{
				value = num;
			}
			float? num2 = value;
			object obj13 = (??)y & 1;
			bool flag5 = obj13 == null;
			object obj14 = !flag5;
			object obj15 = ~obj14;
			float value7 = ((obj15 != null) ? num3 : num4);
			float? num5 = value7;
			object obj16 = (??)z & 1;
			bool flag6 = obj16 == null;
			object obj17 = !flag6;
			object obj18 = ~obj17;
			float value8 = ((obj18 != null) ? num6 : num7);
			float? num8 = value8;
			float value9 = num2.Value;
			float value10 = num5.Value;
			float value11 = num8.Value;
			gObject.localPosition = (Vector3)0;
		}
	}

	public static void MoveTo(RectTransform gObject, bool isWorldPositions = false, float? x = null, float? y = null)
	{
		//IL_000e: Expected F4, but got O
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00ce: Expected O, but got I4
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_01e9: Expected O, but got I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0048: Expected O, but got I4
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_016f: Expected O, but got I4
		//IL_011a: Expected O, but got I4
		//IL_0094: Expected O, but got I4
		float num = (object?)x >> 32;
		float value = default(float);
		float num3 = default(float);
		float num4 = default(float);
		if (isWorldPositions)
		{
			Vector3 position = gObject.position;
			object obj = (??)x & 1;
			bool flag = obj == null;
			object obj2 = !flag;
			object obj3 = ~obj2;
			if (obj3 == null)
			{
				value = num;
			}
			float? num2 = value;
			object obj4 = (??)y & 1;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			object obj6 = ~obj5;
			float value2 = ((obj6 != null) ? num3 : num4);
			float? num5 = value2;
			float value3 = num2.Value;
			float value4 = num5.Value;
			gObject.position = (Vector3)0;
		}
		else
		{
			Vector2 anchoredPosition = gObject.anchoredPosition;
			object obj7 = (??)x & 1;
			bool flag3 = obj7 == null;
			object obj8 = !flag3;
			object obj9 = ~obj8;
			if (obj9 == null)
			{
				value = num;
			}
			float? num2 = value;
			object obj10 = (??)y & 1;
			bool flag4 = obj10 == null;
			object obj11 = !flag4;
			object obj12 = ~obj11;
			float value5 = ((obj12 != null) ? num3 : num4);
			float? num5 = value5;
			float value6 = num2.Value;
			float value7 = num5.Value;
			gObject.anchoredPosition = (Vector2)0;
		}
	}

	public static void Scale(Transform transform, float? x = null, float? y = null, float? z = null)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_012a: Expected O, but got I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0091: Expected O, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_00ee: Expected O, but got I4
		Vector3 localScale = transform.localScale;
		object obj = (??)x & 1;
		float? num = default(float?);
		if (obj != null)
		{
			object obj2 = (??)y & 1;
			if (obj2 != null)
			{
				goto IL_0068;
			}
		}
		else
		{
			float value = default(float);
			num = value;
			object obj3 = (??)y & 1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0068;
			}
		}
		float value2 = default(float);
		float? num2 = value2;
		object obj5 = (??)z & 1;
		if (obj5 == null)
		{
			goto IL_00a0;
		}
		goto IL_00b4;
		IL_00b4:
		float value3 = num.Value;
		float value4 = num2.Value;
		float? num3 = default(float?);
		float value5 = num3.Value;
		transform.localScale = (Vector3)0;
		return;
		IL_00a0:
		float value6 = default(float);
		num3 = value6;
		goto IL_00b4;
		IL_0068:
		object obj6 = (??)z & 1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			goto IL_00a0;
		}
		goto IL_00b4;
	}

	public static void UniScale(Transform transform, float xyz)
	{
		//IL_000e: Expected O, but got I4
		transform.localScale = (Vector3)0;
	}

	public static void SetAnchorX(RectTransform rectTransform, float value)
	{
		//IL_002d: Expected O, but got I4
		//IL_003b: Expected O, but got I4
		Vector2 anchorMax = rectTransform.anchorMax;
		Vector2 anchorMin = rectTransform.anchorMin;
		rectTransform.anchorMax = (Vector2)0;
		rectTransform.anchorMin = (Vector2)0;
	}

	public static void SetAnchorY(RectTransform rectTransform, float value)
	{
		//IL_002d: Expected O, but got I4
		//IL_003b: Expected O, but got I4
		Vector2 anchorMax = rectTransform.anchorMax;
		Vector2 anchorMin = rectTransform.anchorMin;
		rectTransform.anchorMax = (Vector2)0;
		rectTransform.anchorMin = (Vector2)0;
	}

	public static void MoveChildren(Transform source, Transform destination, bool worldPositionStays = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_006b: Expected O, but got I
		//IL_0081: Expected I, but got O
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3856;
		object obj4 = (nint)0 + (nint)1760;
		object obj5 = obj2 + 16;
		obj5 = destination;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = (nint)0 + (nint)2824;
		IEnumerable<object> source2 = Enumerable.Cast<object>(source);
		List<object> list = Enumerable.ToList(source2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		list.ForEach(action);
	}

	public static List<Transform> GetChildren(Transform transform)
	{
		IEnumerable<object> source = Enumerable.Cast<object>(transform);
		return (List<Transform>)(object)Enumerable.ToList(source);
	}

	public unsafe static T CloneObjectWithoutChildren<T>(T original, Transform parent) where T : UnityEngine.Component
	{
		//IL_0044: Expected O, but got I4
		//IL_0398: Expected O, but got Ref
		//IL_0096: Expected O, but got I4
		//IL_02cc: Expected O, but got I
		//IL_00c6: Expected O, but got I
		//IL_0313: Expected I, but got O
		//IL_0112: Expected O, but got I
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0159: Expected O, but got I4
		//IL_01a9: Expected I, but got O
		//IL_0223: Expected I, but got O
		//IL_00fc: Expected I, but got O
		//IL_0101: Expected I, but got O
		//IL_0246: Expected I, but got O
		//IL_01ef: Expected I, but got O
		//IL_01f4: Expected I, but got O
		bool flag = (object)original == null;
		Transform transform = parent;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		Transform result = parent;
		nint num2 = default(nint);
		Transform transform4;
		Transform transform5;
		if (!flag)
		{
			Transform transform2 = original.transform;
			List<Transform> children = GetChildren(transform2);
			bool flag2 = children == null;
			transform = null;
			enumerator = (List<object>.Enumerator)0;
			result = parent;
			if (!flag2)
			{
				List<object>.Enumerator enumerator2 = ((List<object>)(object)children).GetEnumerator();
				object obj = (nint)0 + (nint)2664;
				List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
				Transform transform3 = default(Transform);
				nint num;
				while (true)
				{
					transform = (Transform)obj;
					if (!enumerator3.MoveNext())
					{
						break;
					}
					if ((object)transform3 != null)
					{
						transform3.SetParent(null, worldPositionStays: false);
						num = unchecked((nint)null);
						num2 = unchecked((nint)null);
						continue;
					}
					goto IL_0215;
				}
				object obj2 = (nint)0 + (nint)2656;
				enumerator3.Dispose();
				object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v27+E4]");
				bool flag3 = (nint)0 == 0;
				object obj5 = !flag3;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				transform4 = (Transform)(object)UnityEngine.Object.Instantiate(original, parent, worldPositionStays: false);
				List<object>.Enumerator enumerator4 = ((List<object>)(object)children).GetEnumerator();
				num = 0;
				num2 = unchecked((nint)null);
				List<object>.Enumerator enumerator5 = default(List<object>.Enumerator);
				while (enumerator5.MoveNext())
				{
					transform5 = original.transform;
					if ((object)transform3 != null)
					{
						transform3.SetParent(transform5, worldPositionStays: false);
						num = unchecked((nint)null);
						num2 = unchecked((nint)null);
						continue;
					}
					goto IL_0238;
				}
				enumerator5.Dispose();
				result = transform4;
				goto IL_0210;
			}
		}
		goto IL_031d;
		IL_0238:
		NullReferenceException ex = new NullReferenceException();
		nint num3 = unchecked((nint)null);
		transform = transform5;
		List<object>.Enumerator enumerator6 = default(List<object>.Enumerator);
		enumerator = enumerator6;
		result = transform4;
		goto IL_031d;
		IL_0210:
		return (T)(object)result;
		IL_0215:
		NullReferenceException ex2 = new NullReferenceException();
		num3 = unchecked((nint)null);
		List<object>.Enumerator enumerator7 = default(List<object>.Enumerator);
		enumerator = enumerator7;
		result = parent;
		goto IL_031d;
		IL_031d:
		NullReferenceException ex3 = new NullReferenceException();
		bool flag4 = (nint)transform != 1;
		NullReferenceException original2 = ex3;
		if (!flag4)
		{
			T val = UnityEngine.Object.Instantiate((T)(object)ex3, transform, (byte)num2 != 0);
			T val2 = UnityEngine.Object.Instantiate(val, transform, (byte)num2 != 0);
			object obj6 = (nint)0 + (nint)2656;
			transform = (Transform)obj6;
			enumerator.Dispose();
			if ((object)val == null)
			{
				goto IL_0210;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			original2 = (NullReferenceException)(object)ex4;
			num3 = (nint)val;
		}
		T val3 = UnityEngine.Object.Instantiate((T)(&num3), transform, (byte)num2 != 0);
		T original3 = UnityEngine.Object.Instantiate((T)(object)original2, transform, (byte)num2 != 0);
		return UnityEngine.Object.Instantiate(original3, transform, (byte)num2 != 0);
	}

	public static void AttachToCanvas(Transform transform, CanvasLayer layer, bool worldPositionStays = false)
	{
		Transform canvas = CanvasLayerExtensions.GetCanvas(layer);
		transform.SetParent(canvas, worldPositionStays);
		transform.SetAsLastSibling();
	}

	public static void AttachToCanvas(Transform transform, Transform newParent, bool worldPositionStays = false)
	{
		transform.SetParent(newParent, worldPositionStays);
		transform.SetAsLastSibling();
	}

	public static Transform GetChildByPath(Transform parent, string localObjectPath)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0085: Expected O, but got I4
		//IL_009f: Expected O, but got I
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		Transform transform2 = default(Transform);
		if (localObjectPath != null)
		{
			object separator = "[{0}]:{1}" + 48;
			string[] array = localObjectPath.Split((string)separator);
			if (array != null)
			{
				if (array.Length < 1)
				{
					goto IL_00d7;
				}
				object obj = array + 32;
				Transform transform = transform2;
				object obj2 = 0;
				while ((object)transform != null)
				{
					Transform transform3 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X21_v5+v93 @ X20_v6*8]");
					transform2 = transform3.Find((string)0);
					obj2++;
					bool flag = (nint)obj2 < array.Length;
					transform = transform2;
					if (flag)
					{
						continue;
					}
					goto IL_00d7;
				}
			}
		}
		return (Transform)(object)new NullReferenceException();
		IL_00d7:
		return transform2;
	}

	public static Transform GetChildByIndexes(Transform parent, int[] indexes)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_005b: Expected O, but got I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		Transform child = default(Transform);
		if (indexes != null)
		{
			if (indexes.Length < 1)
			{
				goto IL_00ad;
			}
			object obj = indexes + 32;
			Transform transform = child;
			object obj2 = 0;
			while ((object)transform != null)
			{
				Transform transform2 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v4+v40 @ X20_v5*4]");
				child = transform2.GetChild(0);
				obj2++;
				bool flag = (nint)obj2 < indexes.Length;
				transform = child;
				if (flag)
				{
					continue;
				}
				goto IL_00ad;
			}
		}
		return (Transform)(object)new NullReferenceException();
		IL_00ad:
		return child;
	}

	public static void ShowKeyboard(InputField input)
	{
		input.Select();
		input.ActivateInputField();
	}

	public static bool IsSubmitted(InputField input)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ec: Expected O, but got I4
		//IL_00a0: Expected O, but got I4
		//IL_00a9: Expected O, but got I4
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_0176: Expected O, but got I4
		//IL_012a: Expected O, but got I4
		//IL_041c: Expected I4, but got O
		//IL_028b: Expected O, but got I4
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_0434: Expected O, but got I
		//IL_0469: Expected O, but got I
		//IL_03cc: Expected I4, but got O
		//IL_03fa: Expected O, but got I4
		//IL_0319: Expected O, but got I
		//IL_0333: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5EC1]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v38+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v38+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = input;
		bool flag3 = !flag2;
		object obj6 = 0;
		if (flag3)
		{
			goto IL_00b7;
		}
		goto IL_0138;
		IL_040e:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_00b7:
		return flag2;
		IL_0138:
		object obj7 = typeof(DataRelation) + 3776;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v2+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		EventSystem current = EventSystem.current;
		if ((object)current != null && (object)input != null)
		{
			GameObject gameObject = input.gameObject;
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v10+E4]");
			if ((nint)0 != 0)
			{
				flag2 = current.m_CurrentSelected == gameObject;
				if (!flag2)
				{
					goto IL_00b7;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				flag2 = current.m_CurrentSelected == gameObject;
				if (!flag2)
				{
					goto IL_00b7;
				}
			}
			object obj11 = 146685952;
			object obj12 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1328;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v10+B8]");
			object obj14 = 0;
			if (obj14 != null)
			{
				KeyControl keyControl = ((Keyboard)obj14).get_Item(Key.Enter);
				if (keyControl == null)
				{
					goto IL_040e;
				}
				if (keyControl.wasPressedThisFrame)
				{
					return true;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X20_v4+584]");
				object obj15 = (nint)0 & (nint)1;
				bool flag5 = obj15 == null;
				object obj16 = !flag5;
				if (obj16 == null)
				{
					_ = 1;
				}
			}
			object obj17 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v13+B8]");
			object obj18 = 0;
			if (obj18 != null)
			{
				KeyControl keyControl2 = ((Keyboard)obj18).get_Item(Key.NumpadEnter);
				if (keyControl2 == null)
				{
					goto IL_040e;
				}
				if (keyControl2.wasPressedThisFrame)
				{
					return true;
				}
			}
			bool flag6 = input.m_Keyboard == null;
			flag2 = (byte)(int)input.m_Keyboard != 0;
			if (!flag6)
			{
				TouchScreenKeyboard.Status status = input.m_Keyboard.status;
				object obj19 = status - 1;
				return obj19 == null;
			}
			goto IL_00b7;
		}
		goto IL_040e;
		IL_007d:
		flag2 = input;
		bool flag7 = !flag2;
		object obj20 = !flag7;
		obj6 = 0;
		if (obj20 == null)
		{
			goto IL_00b7;
		}
		goto IL_0138;
	}

	public static void EnsureNumeric(InputFieldTMProUGUI inputField, double max = 1000000.0)
	{
		//IL_02aa: Invalid comparison between F8 and I4
		//IL_01ee: Expected O, but got I4
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0282: Expected O, but got I
		//IL_0135: Expected O, but got I4
		//IL_00a1: Expected I4, but got I8
		//IL_00bb: Expected O, but got I4
		//IL_0172: Invalid comparison between F8 and I4
		//IL_014f: Expected O, but got I
		//IL_00d1: Invalid comparison between F8 and I4
		//IL_030e: Expected O, but got I4
		//IL_0329: Expected I4, but got O
		//IL_0331: Invalid comparison between F8 and I4
		int result;
		string text2;
		if (!(max < 0.0))
		{
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
			string text = inputField.Text;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v6+E4]");
			if ((nint)0 != 0)
			{
				string s = StringUtil.HinduToArabicNumber(text);
				if (int.TryParse(s, out result))
				{
					goto IL_008f;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				string s2 = StringUtil.HinduToArabicNumber(text);
				bool flag = int.TryParse(s2, out result);
				bool flag2 = !flag;
				object obj3 = !flag2;
				if (obj3 != null)
				{
					goto IL_008f;
				}
			}
			object obj4 = (nint)0 + (nint)2000;
			text2 = (string)obj4;
			goto IL_02ee;
		}
		object obj5 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj6 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj7 = "m_StencilDeferredPS" + 688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		object obj8 = "m_StencilDeferredPS" + 696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		string message = default(string);
		ex..ctor(paramName, actualValue, message);
		object obj9 = (nint)0 + (nint)576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		throw new NullReferenceException();
		IL_008f:
		int num = (int)(result & 0x80000000L);
		bool flag3 = num == 0;
		object obj10 = !flag3;
		int num2;
		if (obj10 == null)
		{
			bool flag4 = max < (double)result;
			num2 = result;
			if (flag4)
			{
				goto IL_0191;
			}
		}
		else
		{
			num2 = -result;
			bool flag5 = !(max < (double)num2);
			result = num2;
			if (!flag5)
			{
				goto IL_0191;
			}
		}
		goto IL_02be;
		IL_02ee:
		inputField.Text = text2;
		return;
		IL_0191:
		int num3 = default(int);
		num2 = num3;
		do
		{
			object obj11 = num2 * 1717986919;
			object obj12 = obj11 >> 34;
			num2 = (int)(obj12 + obj12);
		}
		while (max < (double)num2);
		result = num2;
		goto IL_02be;
		IL_02be:
		string text3 = inputField.Text;
		string text4 = result.ToString();
		if (text3 != text4)
		{
			string text5 = result.ToString();
			text2 = text5;
			goto IL_02ee;
		}
	}

	public static void EnsurePin(InputFieldTMProUGUI inputField, int minDigitCount = 4, int maxDigitCount = 8)
	{
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Expected O, but got Unknown
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a6: Expected O, but got Unknown
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected O, but got Unknown
		//IL_0024: Expected I4, but got I8
		//IL_003e: Expected O, but got I4
		//IL_05eb: Expected O, but got I
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_00c4: Expected O, but got I4
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_063e: Expected O, but got Unknown
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0652: Expected O, but got Unknown
		//IL_067c: Expected O, but got I4
		//IL_015c: Expected I4, but got O
		//IL_012f: Expected I4, but got O
		//IL_0176: Expected O, but got I
		//IL_01a3: Expected I4, but got O
		//IL_01c0: Expected O, but got I4
		//IL_0238: Expected O, but got I
		//IL_025a: Expected O, but got I4
		//IL_0382: Expected O, but got I
		//IL_039c: Expected O, but got I4
		//IL_02c7: Expected O, but got I
		//IL_03da: Expected O, but got I4
		//IL_0435: Expected I4, but got O
		//IL_0346: Expected I4, but got O
		//IL_0453: Expected O, but got I
		//IL_0475: Expected O, but got I4
		//IL_020a: Expected I4, but got O
		int num = default(int);
		int num2 = default(int);
		string text3;
		if (num <= num2)
		{
			int num3 = num2 | num;
			int num4 = (int)(num3 & 0x80000000L);
			bool flag = num4 == 0;
			object obj = !flag;
			if (obj == null)
			{
				bool flag2 = (object)inputField == null;
				int num5 = num2;
				int num6 = num;
				if (!flag2)
				{
					object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
					string text = inputField.Text;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v6+E4]");
					bool flag3 = (nint)0 == 0;
					object obj4 = !flag3;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string text2 = StringUtil.HinduToArabicNumber(text);
					object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 3920;
					object obj6 = "[{0}]:{1}" + 744;
					object obj7 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v26+E4]");
					bool flag4 = (nint)0 == 0;
					object obj8 = !flag4;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (Regex.IsMatch(text2, (string)obj6))
					{
						num5 = 0;
						num6 = (int)obj6;
						text3 = text2;
					}
					else
					{
						bool flag5 = text2 == null;
						num5 = 0;
						num6 = (int)obj6;
						if (flag5)
						{
							goto IL_055f;
						}
						object obj9 = (nint)0 + (nint)2000;
						text3 = (string)obj9;
						bool flag6 = text2._stringLength < 1;
						num5 = 0;
						num6 = (int)obj6;
						if (!flag6)
						{
							object obj10 = 153100288 + 1024;
							int num7 = 0;
							string text4 = (string)obj9;
							char c2 = default(char);
							bool flag15;
							do
							{
								char c = text2.get_Chars(num7);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X20_v8+88]");
								object obj11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v42+E4]");
								bool flag7 = (nint)0 == 0;
								object obj12 = !flag7;
								if (obj12 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								string input = c2.ToString();
								object obj13 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v46+E4]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FDE]");
									object obj14 = (nint)0 & (nint)1;
									if (obj14 != null)
									{
										goto IL_02e4;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FDE]");
									object obj15 = (nint)0 & (nint)1;
									bool flag8 = obj15 == null;
									object obj16 = !flag8;
									if (obj16 != null)
									{
										goto IL_02e4;
									}
								}
								_ = 1;
								object obj17 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X0_v56+E4]");
								bool flag9 = (nint)0 == 0;
								object obj18 = !flag9;
								if (obj18 != null)
								{
									goto IL_0311;
								}
								goto IL_03e8;
								IL_0311:
								string text5 = (string)obj6;
								bool flag10 = Regex.IsMatch(input, (string)obj6);
								bool flag11 = !flag10;
								num5 = 0;
								num6 = (int)obj6;
								int num8;
								if (!flag11)
								{
									num8 = 0;
									goto IL_0443;
								}
								goto IL_068a;
								IL_02e4:
								obj17 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X0_v56+E4]");
								if ((nint)0 != 0)
								{
									goto IL_0311;
								}
								goto IL_03e8;
								IL_03e8:
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								text5 = (string)obj6;
								bool flag12 = Regex.IsMatch(input, (string)obj6);
								bool flag13 = !flag12;
								num8 = 0;
								num5 = 0;
								num6 = (int)obj6;
								if (!flag13)
								{
									goto IL_0443;
								}
								goto IL_068a;
								IL_0443:
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X20_v8+88]");
								object obj19 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X0_v49+E4]");
								bool flag14 = (nint)0 == 0;
								object obj20 = !flag14;
								if (obj20 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								string text6 = c2.ToString();
								string text7 = text4 + text6;
								num5 = 0;
								num6 = (int)text6;
								text4 = text7;
								goto IL_068a;
								IL_068a:
								num7++;
								flag15 = num7 >= text2._stringLength;
								text3 = text4;
							}
							while (!flag15);
						}
					}
					if (text3 != null)
					{
						int count = num - text3._stringLength;
						string text9;
						if (num > text3._stringLength)
						{
							string text8 = ((string)null).CreateString('0', count);
							text9 = text8 + text3;
						}
						else
						{
							if (text3._stringLength <= num2)
							{
								goto IL_06c4;
							}
							text9 = text3.Substring(0, num2);
						}
						text3 = text9;
						goto IL_06c4;
					}
				}
				goto IL_055f;
			}
		}
		object obj21 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj22 = "AvailableVoices" + 2512;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		object obj23 = "m_StencilDeferredPS" + 776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentException ex = default(ArgumentException);
		string message = default(string);
		string paramName = default(string);
		ex..ctor(message, paramName);
		object obj24 = (nint)0 + (nint)584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
		IL_055f:
		throw new NullReferenceException();
		IL_06c4:
		inputField.Text = text3;
	}

	public static Coroutine WaitForSeconds(MonoBehaviour comp, float seconds, Action callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = obj2 + 24;
			obj3 = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 1880;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj5 = default(object);
			obj5..ctor();
			_ = 0;
			object obj6 = obj5 + 32;
			obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if ((object)comp != null)
			{
				return comp.StartCoroutine((IEnumerator)obj5);
			}
		}
		return (Coroutine)(object)new NullReferenceException();
	}

	public static Coroutine SetTimeout(MonoBehaviour comp, float seconds, Func<bool> cancelCondition, Action fallback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 896;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = cancelCondition;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 32;
			obj4 = fallback;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 1888;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj6 = default(object);
			obj6..ctor();
			_ = 0;
			object obj7 = obj6 + 32;
			obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if ((object)comp != null)
			{
				return comp.StartCoroutine((IEnumerator)obj6);
			}
		}
		return (Coroutine)(object)new NullReferenceException();
	}

	public static string GetPath(GameObject current)
	{
		if ((object)current != null)
		{
			Transform transform = current.transform;
			return GetPath(transform);
		}
		return (string)(object)new NullReferenceException();
	}

	public static string GetPath(Transform current, Transform root = null)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010f: Expected O, but got I4
		//IL_00a2: Expected O, but got I4
		//IL_0153: Expected O, but got I4
		//IL_015c: Expected O, but got I4
		//IL_02a0: Expected O, but got I4
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5EC3]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v29+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v29+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = current == root;
		bool flag3 = !flag2;
		object obj6 = !flag3;
		object obj7 = 0;
		if (obj6 != null)
		{
			goto IL_00b0;
		}
		goto IL_016a;
		IL_00b0:
		if ((object)current != null)
		{
			return current.name;
		}
		goto IL_030d;
		IL_030d:
		return (string)(object)new NullReferenceException();
		IL_01e9:
		GameObject gameObject = current.gameObject;
		if ((object)gameObject != null)
		{
			Scene scene = gameObject.scene;
			Scene scene2 = default(Scene);
			string name = scene2.name;
			string name2 = current.name;
			object obj8 = ", stale={0}" + 2920;
			return name + (string)obj8 + name2;
		}
		goto IL_030d;
		IL_007d:
		bool flag4 = current == root;
		bool flag5 = !flag4;
		obj7 = 0;
		if (!flag5)
		{
			goto IL_00b0;
		}
		goto IL_016a;
		IL_016a:
		if ((object)current != null)
		{
			Transform transform = current.parent;
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v4+E4]");
			if ((nint)0 != 0)
			{
				if (transform == null)
				{
					goto IL_01e9;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag6 = transform == null;
				bool flag7 = !flag6;
				object obj10 = !flag7;
				if (obj10 != null)
				{
					goto IL_01e9;
				}
			}
			Transform current2 = current.parent;
			string path = GetPath(current2, root);
			string name3 = current.name;
			object obj11 = ", stale={0}" + 2920;
			return path + (string)obj11 + name3;
		}
		goto IL_030d;
	}

	public static void Enable(CanvasGroup canvasGroup)
	{
		canvasGroup.interactable = true;
		canvasGroup.blocksRaycasts = true;
		canvasGroup.alpha = 1f;
	}

	public static void Disable(CanvasGroup canvasGroup)
	{
		canvasGroup.interactable = false;
		canvasGroup.blocksRaycasts = false;
		canvasGroup.alpha = 0f;
	}
}
