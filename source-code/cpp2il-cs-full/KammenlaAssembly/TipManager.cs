using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Spine;
using Unity.Services.Authentication.Shared;
using UnityEngine;

public static class TipManager
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<InGameHintModel, float> <>9__3_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 3136;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal float <GetValidTip>b__3_1(InGameHintModel t)
		{
			return UnityEngine.Random.value;
		}
	}

	private sealed class <>c__DisplayClass2_0
	{
		public Action<string> callback;

		public Games? game;

		internal void <LoadHints>b__0(KammelnaResponseModel<List<InGameHintModel>> response)
		{
			//IL_005d: Expected O, but got I
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected O, but got Unknown
			//IL_00a8: Expected O, but got I4
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Expected O, but got Unknown
			//IL_00fc: Expected O, but got I
			//IL_010c: Expected O, but got I
			//IL_011c: Expected O, but got I
			if (((KammelnaResponseModel<object>)(object)response).Succeeded)
			{
				string validTip = GetValidTip(game);
				Actions.SafeInvoke((Action<object>)callback, validTip);
				return;
			}
			object obj = (nint)0 + (nint)704;
			string errorMessage = ((KammelnaResponseModel<object>)(object)response).ErrorMessage;
			object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			object obj5 = errorMessage;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = errorMessage;
			}
			while (true)
			{
				KLogger.LogError(obj5);
				Action<string> action = callback;
				object obj6 = ", stale={0}" + 1624;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v11 (System.Action`1<System.String>)+18]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v11 (System.Action`1<System.String>)+40]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v11 (System.Action`1<System.String>)+28]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v83 @ X3_v1 (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass3_0
	{
		public Games? game;

		internal bool <GetValidTip>b__0(InGameHintModel tip)
		{
			//IL_0076: Expected I4, but got O
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected O, but got Unknown
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Expected O, but got Unknown
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected I4, but got Unknown
			if (tip != null)
			{
				object obj = (object?)game ^ (object?)tip.<Game>k__BackingField;
				object obj2 = obj & -4294967295L;
				bool flag = obj2 == null;
				object obj3 = ~tip.<Game>k__BackingField;
				object obj4 = flag | obj3;
				return (byte)(obj4 & 1) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private const string FallbackHint = "...";

	public static void RequestLoadingTip(Games? game, Action<string> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00e2: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_0122: Expected O, but got I
		//IL_015b: Expected O, but got I4
		//IL_0193: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A7A]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v17+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v17+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		CachedModel<List<InGameHintModel>> hints = CachedModels.Hints;
		CachedModel<object> cachedModel = (CachedModel<object>)(object)hints;
		goto IL_0115;
		IL_0115:
		object obj5 = (nint)0 + (nint)2624;
		object model = cachedModel.Model;
		bool flag2 = ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)model);
		bool flag3 = !flag2;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v8+E4]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CachedModel<List<InGameHintModel>> hints2 = CachedModels.Hints;
			if (((CachedModel<object>)(object)hints2).IsValid())
			{
				string validTip = GetValidTip(game);
				Actions.SafeInvoke((Action<object>)callback, validTip);
				return;
			}
		}
		LoadHints(game, callback);
		return;
		IL_0074:
		CachedModel<List<InGameHintModel>> hints3 = CachedModels.Hints;
		bool flag5 = hints3 == null;
		object obj9 = !flag5;
		cachedModel = (CachedModel<object>)(object)hints3;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0115;
	}

	private static void LoadHints(Games? game, Action<string> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_007e: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 368;
		object obj4 = (nint)0 + (nint)3360;
		object obj5 = obj2 + 16;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		KammelnaRequests.GetHints(action);
	}

	private static string GetValidTip(Games? game)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_005c: Expected O, but got I4
		//IL_00ab: Expected O, but got I
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0104: Expected O, but got I
		//IL_0110: Expected O, but got I
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_013f: Expected I, but got O
		//IL_017f: Expected O, but got I4
		//IL_02c4: Expected O, but got I
		//IL_02d4: Expected O, but got I
		//IL_02f6: Expected O, but got I4
		//IL_01c6: Expected O, but got I4
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_032e: Expected O, but got I
		//IL_033f: Expected I, but got O
		//IL_035d: Expected O, but got I
		//IL_024b: Expected O, but got I
		//IL_01f6: Expected O, but got I
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object result;
		string text;
		if (obj2 != null)
		{
			object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CachedModel<List<InGameHintModel>> hints = CachedModels.Hints;
			if (hints != null)
			{
				object obj6 = (nint)0 + (nint)424;
				result = ", stale={0}" + 1624;
				object model = ((CachedModel<object>)(object)hints).Model;
				if (model != null)
				{
					object obj7 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1768;
					object obj8 = (nint)0 + (nint)3368;
					object obj9 = (nint)0 + (nint)3512;
					object obj10 = typeof(SkeletonBinary.SkeletonInput) + 3136;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Func<object, bool> func = default(Func<object, bool>);
					func..ctor(obj2, (IntPtr)obj8);
					IEnumerable<object> source = Enumerable.Where((IEnumerable<object>)model, func);
					object obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v21+E4]");
					bool flag2 = (nint)0 == 0;
					object obj12 = !flag2;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj11 = obj10;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v21+B8]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v18+8]");
					Func<object, float> keySelector = (Func<object, float>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v18+8]");
					bool flag3 = (nint)0 == 0;
					object obj14 = !flag3;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v21+E4]");
						bool flag4 = (nint)0 == 0;
						object obj15 = !flag4;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj16 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v24+B8]");
							obj13 = 0;
						}
						object obj17 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1776;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj18 = (nint)0 + (nint)3352;
						Func<object, float> func2 = default(Func<object, float>);
						func2..ctor(obj13, (IntPtr)obj18);
						object obj19 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v23+B8]");
						object obj20 = (nint)0 + (nint)8;
						obj20 = func2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						keySelector = func2;
					}
					IOrderedEnumerable<object> source2 = Enumerable.OrderBy(source, keySelector);
					object obj21 = Enumerable.FirstOrDefault(source2);
					if (obj21 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v25 (System.Object)+20]");
						text = (string)0;
						goto IL_037c;
					}
				}
				text = null;
				goto IL_037c;
			}
		}
		return (string)(object)new NullReferenceException();
		IL_037c:
		if (text == null)
		{
			return (string)result;
		}
		return text;
	}
}
