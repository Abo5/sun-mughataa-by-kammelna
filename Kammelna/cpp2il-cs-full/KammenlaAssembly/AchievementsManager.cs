using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Xml.Schema;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Managers.Achievemenets;
using Server.Models;
using Unity.Services.Authentication.Shared;
using UnityEngine;

public class AchievementsManager : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<GameAchievementViewModel, bool> <>9__4_0;

		public static Func<GameAchievementViewModel, bool> <>9__6_0;

		public static Func<GameAchievementViewModel, bool> <>9__8_0;

		public static Action<bool> <>9__13_0;

		public static Comparison<AchievementLevelModel> <>9__15_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(XmlSchemaInclude) + 3832;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <get_Achievements>b__4_0(GameAchievementViewModel a)
		{
			//IL_0044: Expected I4, but got O
			if (a != null)
			{
				return a.<type>k__BackingField == AchievementType.Achievement;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <get_Titles>b__6_0(GameAchievementViewModel a)
		{
			//IL_0052: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			if (a != null)
			{
				object obj = a.<type>k__BackingField - 1;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <get_Trophies>b__8_0(GameAchievementViewModel a)
		{
			//IL_0052: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			if (a != null)
			{
				object obj = a.<type>k__BackingField - 2;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal void <OnLogin>b__13_0(bool _)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00e2: Expected O, but got I4
			//IL_0097: Expected O, but got I4
			//IL_0121: Expected O, but got I
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Expected O, but got Unknown
			//IL_029f: Expected O, but got I
			//IL_02b9: Expected O, but got I4
			//IL_0189: Expected O, but got I4
			//IL_01f9: Expected O, but got I
			//IL_032f: Expected O, but got I
			//IL_033f: Expected O, but got I
			//IL_0361: Expected O, but got I4
			//IL_02f7: Expected O, but got I4
			//IL_025b: Expected O, but got I
			//IL_026b: Expected O, but got I
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B3A]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v26+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				int num = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v26+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			CachedModel<List<GameAchievementViewModel>> achievements = CachedModels.Achievements;
			CachedModel<object> cachedModel = (CachedModel<object>)(object)achievements;
			goto IL_0115;
			IL_036f:
			throw new NullReferenceException();
			IL_0270:
			OneShotEvent oneShotEvent;
			oneShotEvent.IsReady = true;
			return;
			IL_0216:
			object obj6;
			object obj5 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v18+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = obj5;
			if (!flag2)
			{
				goto IL_024b;
			}
			goto IL_030d;
			IL_0074:
			CachedModel<List<GameAchievementViewModel>> achievements2 = CachedModels.Achievements;
			bool flag3 = achievements2 == null;
			object obj8 = !flag3;
			cachedModel = (CachedModel<object>)(object)achievements2;
			if (obj8 != null)
			{
				goto IL_0115;
			}
			goto IL_036f;
			IL_0115:
			object obj9 = (nint)0 + (nint)400;
			obj6 = typeof(SqlSingle[]) + 2360;
			object model = cachedModel.Model;
			if (model != null)
			{
				object obj10 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v20+E4]");
				bool flag4 = (nint)0 == 0;
				object obj11 = !flag4;
				List<GameAchievementViewModel> achievements3 = (List<GameAchievementViewModel>)model;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					achievements3 = (List<GameAchievementViewModel>)model;
				}
				RebuildAchievements(achievements3);
			}
			object obj12 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45AE]");
				object obj13 = (nint)0 & (nint)1;
				if (obj13 != null)
				{
					goto IL_0216;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45AE]");
				object obj14 = (nint)0 & (nint)1;
				bool flag5 = obj14 == null;
				object obj15 = !flag5;
				if (obj15 != null)
				{
					goto IL_0216;
				}
			}
			int num2 = 1;
			obj5 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v18+E4]");
			bool flag6 = (nint)0 == 0;
			object obj16 = !flag6;
			obj7 = obj5;
			if (obj16 != null)
			{
				goto IL_024b;
			}
			goto IL_030d;
			IL_024b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v18+B8]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v16+8]");
			oneShotEvent = (OneShotEvent)0;
			goto IL_0270;
			IL_030d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj18 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v9+B8]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v9+8]");
			oneShotEvent = (OneShotEvent)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v9+8]");
			bool flag7 = (nint)0 == 0;
			object obj20 = !flag7;
			if (obj20 != null)
			{
				goto IL_0270;
			}
			goto IL_036f;
		}

		internal unsafe int <RebuildAchievements>b__15_0(AchievementLevelModel a, AchievementLevelModel b)
		{
			//IL_0008: Expected O, but got Ref
			//IL_0083: Expected I4, but got O
			object obj2 = default(object);
			object obj = (object)(&obj2);
			if (a != null)
			{
				_ = a.<levelId>k__BackingField;
				if (b != null)
				{
					int num = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 4));
					return ((int*)num)->CompareTo(b.<levelId>k__BackingField);
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private static readonly Dictionary<string, GameAchievementViewModel> AllAchievements;

	private static readonly OneShotEvent <readyState>k__BackingField;

	public static IEnumerable<GameAchievementViewModel> GameAchievements
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_015c: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_01b6: Expected O, but got I4
			//IL_00c6: Expected O, but got I
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Expected O, but got Unknown
			//IL_00e6: Expected O, but got I
			//IL_0111: Expected I, but got O
			object obj = 152985600;
			object obj2 = typeof(SqlSingle[]) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B2B]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v29+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v29+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v5+B8]");
			object obj8 = 0;
			Dictionary<object, object> dictionary = (Dictionary<object, object>)obj8;
			bool flag3 = obj8 == null;
			object obj9 = !flag3;
			if (obj9 != null)
			{
				goto IL_00ba;
			}
			goto IL_01c4;
			IL_00ba:
			object obj10 = (nint)0 + (nint)2624;
			object obj11 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1248;
			object obj12 = (nint)0 + (nint)1768;
			Dictionary<object, object>.ValueCollection values = dictionary.Values;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor((object)null, (IntPtr)obj12);
			return (IEnumerable<GameAchievementViewModel>)Enumerable.Where(values, func);
			IL_01c4:
			return (IEnumerable<GameAchievementViewModel>)new NullReferenceException();
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v29+B8]");
			object obj13 = 0;
			dictionary = (Dictionary<object, object>)obj13;
			if (obj13 != null)
			{
				goto IL_00ba;
			}
			goto IL_01c4;
		}
	}

	public static IEnumerable<GameAchievementViewModel> Achievements
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Expected O, but got Unknown
			//IL_01b4: Expected O, but got I4
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_0260: Expected O, but got I
			//IL_0270: Expected O, but got I
			//IL_0280: Expected O, but got I
			//IL_02a2: Expected O, but got I4
			//IL_0103: Expected O, but got I
			//IL_0113: Expected O, but got I
			//IL_0123: Expected O, but got I
			//IL_0145: Expected O, but got I4
			//IL_0214: Expected O, but got I4
			//IL_02e2: Expected O, but got I4
			//IL_033c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0341: Expected O, but got Unknown
			//IL_0357: Expected O, but got I
			//IL_0368: Expected I, but got O
			//IL_0386: Expected O, but got I
			//IL_0312: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(SqlSingle[]) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B2C]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			object obj7;
			if (obj3 != null)
			{
				obj4 = typeof(XmlSchemaInclude) + 3832;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj5;
				obj7 = obj4;
				if (!flag)
				{
					goto IL_00a1;
				}
			}
			else
			{
				_ = 1;
				obj4 = typeof(XmlSchemaInclude) + 3832;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				object obj6 = obj5;
				obj7 = obj4;
				if (obj8 != null)
				{
					goto IL_00a1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			IEnumerable<GameAchievementViewModel> gameAchievements = GameAchievements;
			object obj9 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			obj4 = obj7;
			IEnumerable<GameAchievementViewModel> enumerable = gameAchievements;
			object obj11 = obj9;
			IEnumerable<GameAchievementViewModel> enumerable2 = gameAchievements;
			if (obj10 != null)
			{
				goto IL_00f7;
			}
			goto IL_0242;
			IL_02c0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			object obj14;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj13 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v10+B8]");
				obj14 = 0;
			}
			object obj15 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1248;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj16 = (nint)0 + (nint)2264;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj14, (IntPtr)obj16);
			object obj17 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v9+B8]");
			object obj18 = (nint)0 + (nint)8;
			obj18 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj20;
			object obj19 = obj20;
			enumerable = enumerable2;
			Func<object, bool> predicate = func;
			goto IL_0317;
			IL_0317:
			return (IEnumerable<GameAchievementViewModel>)Enumerable.Where(enumerable, predicate);
			IL_00f7:
			obj19 = (nint)0 + (nint)3440;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v4+B8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4+8]");
			bool flag5 = (nint)0 == 0;
			object obj21 = !flag5;
			if (obj21 == null)
			{
				obj20 = obj19;
				obj7 = obj4;
				enumerable2 = enumerable;
				goto IL_02c0;
			}
			goto IL_0317;
			IL_00a1:
			IEnumerable<GameAchievementViewModel> gameAchievements2 = GameAchievements;
			obj9 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v4+E4]");
			bool flag6 = (nint)0 == 0;
			enumerable = gameAchievements2;
			obj11 = obj9;
			obj7 = obj4;
			enumerable2 = gameAchievements2;
			if (!flag6)
			{
				goto IL_00f7;
			}
			goto IL_0242;
			IL_0242:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj7;
			obj20 = (nint)0 + (nint)3440;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v4+B8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4+8]");
			bool flag7 = (nint)0 == 0;
			object obj22 = !flag7;
			obj19 = obj20;
			enumerable = enumerable2;
			if (obj22 == null)
			{
				goto IL_02c0;
			}
			goto IL_0317;
		}
	}

	public static IEnumerable<GameAchievementViewModel> Titles
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Expected O, but got Unknown
			//IL_01b4: Expected O, but got I4
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_0260: Expected O, but got I
			//IL_0270: Expected O, but got I
			//IL_0280: Expected O, but got I
			//IL_02a2: Expected O, but got I4
			//IL_0103: Expected O, but got I
			//IL_0113: Expected O, but got I
			//IL_0123: Expected O, but got I
			//IL_0145: Expected O, but got I4
			//IL_0214: Expected O, but got I4
			//IL_02e2: Expected O, but got I4
			//IL_033c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0341: Expected O, but got Unknown
			//IL_0357: Expected O, but got I
			//IL_0368: Expected I, but got O
			//IL_0386: Expected O, but got I
			//IL_0312: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(SqlSingle[]) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B2D]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			object obj7;
			if (obj3 != null)
			{
				obj4 = typeof(XmlSchemaInclude) + 3832;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj5;
				obj7 = obj4;
				if (!flag)
				{
					goto IL_00a1;
				}
			}
			else
			{
				_ = 1;
				obj4 = typeof(XmlSchemaInclude) + 3832;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				object obj6 = obj5;
				obj7 = obj4;
				if (obj8 != null)
				{
					goto IL_00a1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			IEnumerable<GameAchievementViewModel> gameAchievements = GameAchievements;
			object obj9 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			obj4 = obj7;
			IEnumerable<GameAchievementViewModel> enumerable = gameAchievements;
			object obj11 = obj9;
			IEnumerable<GameAchievementViewModel> enumerable2 = gameAchievements;
			if (obj10 != null)
			{
				goto IL_00f7;
			}
			goto IL_0242;
			IL_02c0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			object obj14;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj13 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v10+B8]");
				obj14 = 0;
			}
			object obj15 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1248;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj16 = (nint)0 + (nint)2272;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj14, (IntPtr)obj16);
			object obj17 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v9+B8]");
			object obj18 = (nint)0 + (nint)16;
			obj18 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj20;
			object obj19 = obj20;
			enumerable = enumerable2;
			Func<object, bool> predicate = func;
			goto IL_0317;
			IL_0317:
			return (IEnumerable<GameAchievementViewModel>)Enumerable.Where(enumerable, predicate);
			IL_00f7:
			obj19 = (nint)0 + (nint)3440;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v4+B8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4+10]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4+10]");
			bool flag5 = (nint)0 == 0;
			object obj21 = !flag5;
			if (obj21 == null)
			{
				obj20 = obj19;
				obj7 = obj4;
				enumerable2 = enumerable;
				goto IL_02c0;
			}
			goto IL_0317;
			IL_00a1:
			IEnumerable<GameAchievementViewModel> gameAchievements2 = GameAchievements;
			obj9 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v4+E4]");
			bool flag6 = (nint)0 == 0;
			enumerable = gameAchievements2;
			obj11 = obj9;
			obj7 = obj4;
			enumerable2 = gameAchievements2;
			if (!flag6)
			{
				goto IL_00f7;
			}
			goto IL_0242;
			IL_0242:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj7;
			obj20 = (nint)0 + (nint)3440;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v4+B8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4+10]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4+10]");
			bool flag7 = (nint)0 == 0;
			object obj22 = !flag7;
			obj19 = obj20;
			enumerable = enumerable2;
			if (obj22 == null)
			{
				goto IL_02c0;
			}
			goto IL_0317;
		}
	}

	public static IEnumerable<GameAchievementViewModel> Trophies
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Expected O, but got Unknown
			//IL_01b4: Expected O, but got I4
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_0260: Expected O, but got I
			//IL_0270: Expected O, but got I
			//IL_0280: Expected O, but got I
			//IL_02a2: Expected O, but got I4
			//IL_0103: Expected O, but got I
			//IL_0113: Expected O, but got I
			//IL_0123: Expected O, but got I
			//IL_0145: Expected O, but got I4
			//IL_0214: Expected O, but got I4
			//IL_02e2: Expected O, but got I4
			//IL_033c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0341: Expected O, but got Unknown
			//IL_0357: Expected O, but got I
			//IL_0368: Expected I, but got O
			//IL_0386: Expected O, but got I
			//IL_0312: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(SqlSingle[]) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B2E]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			object obj7;
			if (obj3 != null)
			{
				obj4 = typeof(XmlSchemaInclude) + 3832;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj5;
				obj7 = obj4;
				if (!flag)
				{
					goto IL_00a1;
				}
			}
			else
			{
				_ = 1;
				obj4 = typeof(XmlSchemaInclude) + 3832;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				object obj6 = obj5;
				obj7 = obj4;
				if (obj8 != null)
				{
					goto IL_00a1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			IEnumerable<GameAchievementViewModel> gameAchievements = GameAchievements;
			object obj9 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			obj4 = obj7;
			IEnumerable<GameAchievementViewModel> enumerable = gameAchievements;
			object obj11 = obj9;
			IEnumerable<GameAchievementViewModel> enumerable2 = gameAchievements;
			if (obj10 != null)
			{
				goto IL_00f7;
			}
			goto IL_0242;
			IL_02c0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			object obj14;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj13 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v10+B8]");
				obj14 = 0;
			}
			object obj15 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1248;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj16 = (nint)0 + (nint)2280;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj14, (IntPtr)obj16);
			object obj17 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v9+B8]");
			object obj18 = (nint)0 + (nint)24;
			obj18 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj20;
			object obj19 = obj20;
			enumerable = enumerable2;
			Func<object, bool> predicate = func;
			goto IL_0317;
			IL_0317:
			return (IEnumerable<GameAchievementViewModel>)Enumerable.Where(enumerable, predicate);
			IL_00f7:
			obj19 = (nint)0 + (nint)3440;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v4+B8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4+18]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4+18]");
			bool flag5 = (nint)0 == 0;
			object obj21 = !flag5;
			if (obj21 == null)
			{
				obj20 = obj19;
				obj7 = obj4;
				enumerable2 = enumerable;
				goto IL_02c0;
			}
			goto IL_0317;
			IL_00a1:
			IEnumerable<GameAchievementViewModel> gameAchievements2 = GameAchievements;
			obj9 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v4+E4]");
			bool flag6 = (nint)0 == 0;
			enumerable = gameAchievements2;
			obj11 = obj9;
			obj7 = obj4;
			enumerable2 = gameAchievements2;
			if (!flag6)
			{
				goto IL_00f7;
			}
			goto IL_0242;
			IL_0242:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj7;
			obj20 = (nint)0 + (nint)3440;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v4+B8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4+18]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4+18]");
			bool flag7 = (nint)0 == 0;
			object obj22 = !flag7;
			obj19 = obj20;
			enumerable = enumerable2;
			if (obj22 == null)
			{
				goto IL_02c0;
			}
			goto IL_0317;
		}
	}

	private static OneShotEvent readyState
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a2: Expected O, but got I
			//IL_010a: Expected O, but got I
			//IL_0117: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(SqlSingle[]) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B2F]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+8]");
			return (OneShotEvent)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+8]");
			return (OneShotEvent)0;
		}
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_010e: Expected O, but got I
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_0156: Expected O, but got I4
		//IL_0178: Expected O, but got I
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_01ad: Expected I, but got O
		//IL_005a: Expected O, but got I4
		//IL_009d: Expected I, but got O
		//IL_00c7: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)1784;
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		GameObject gameObject = base.gameObject;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		UnityEngine.Object target = gameObject;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			target = gameObject;
		}
		object obj7 = (nint)0 + (nint)1776;
		object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
		UnityEngine.Object.DontDestroyOnLoad(target);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj3);
		object obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Config.OnLoggedIn += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(null, (IntPtr)obj7);
		object obj11 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ContentPushService.OnAchievementsApplied += action2;
	}

	private static void OnLogin()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_0197: Expected O, but got I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00c0: Expected O, but got I
		//IL_00d0: Expected O, but got I
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0265: Expected O, but got I4
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01eb: Expected O, but got I
		//IL_01fb: Expected O, but got I
		//IL_0225: Expected O, but got I4
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_0333: Expected O, but got I
		//IL_0344: Expected I, but got O
		//IL_0362: Expected O, but got I
		//IL_02c4: Expected O, but got I4
		//IL_0295: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(XmlSchemaInclude) + 3832;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B31]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj7;
		object obj5;
		if (obj3 != null)
		{
			obj4 = "___# Content push apply failed [{0}]: {1}" + 2944;
			obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj5;
			obj7 = obj4;
			if (!flag)
			{
				goto IL_009c;
			}
		}
		else
		{
			_ = 1;
			obj4 = "___# Content push apply failed [{0}]: {1}" + 2944;
			obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			object obj6 = obj5;
			obj7 = obj4;
			if (obj8 != null)
			{
				goto IL_009c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj5 = obj2;
		object obj9 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2872;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v4+20]");
		Action<bool> action = (Action<bool>)0;
		string text = (string)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v4+20]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		object obj12 = obj9;
		string text2 = (string)obj7;
		if (obj11 != null)
		{
			goto IL_010d;
		}
		goto IL_0243;
		IL_010d:
		object obj13 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		Action<bool> action2 = action;
		text2 = text;
		if (!flag4)
		{
			goto IL_014a;
		}
		goto IL_02ea;
		IL_02ea:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		action = action2;
		text = text2;
		goto IL_014a;
		IL_014a:
		ContentSyncService.EnsureFresh(text, action);
		return;
		IL_009c:
		obj9 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2872;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+B8]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v4+20]");
		action = (Action<bool>)0;
		text = (string)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v4+20]");
		bool flag5 = (nint)0 == 0;
		obj12 = obj9;
		text2 = (string)obj4;
		if (!flag5)
		{
			goto IL_010d;
		}
		goto IL_0243;
		IL_0243:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v11+B8]");
			obj10 = 0;
		}
		object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)2248;
		Action<bool> action3 = default(Action<bool>);
		action3..ctor(obj10, (IntPtr)obj17);
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v9+B8]");
		object obj19 = (nint)0 + (nint)32;
		obj19 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v1+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		action = action3;
		text = text2;
		action2 = action3;
		if (obj20 != null)
		{
			goto IL_014a;
		}
		goto IL_02ea;
	}

	private static void OnAchievementsApplied()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00e2: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_0121: Expected O, but got I
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_0260: Expected O, but got I
		//IL_027a: Expected O, but got I4
		//IL_01ab: Expected O, but got I
		//IL_02b8: Expected O, but got I4
		//IL_02f0: Expected O, but got I
		//IL_0300: Expected O, but got I
		//IL_0322: Expected O, but got I4
		//IL_020d: Expected O, but got I
		//IL_021d: Expected O, but got I
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B32]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v22+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v22+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		CachedModel<List<GameAchievementViewModel>> achievements = CachedModels.Achievements;
		CachedModel<object> cachedModel = (CachedModel<object>)(object)achievements;
		goto IL_0115;
		IL_01c8:
		object obj6;
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v18+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = obj5;
		if (!flag2)
		{
			goto IL_01fd;
		}
		goto IL_02ce;
		IL_01fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v18+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v15+8]");
		OneShotEvent oneShotEvent = (OneShotEvent)0;
		goto IL_0222;
		IL_0222:
		oneShotEvent.IsReady = true;
		return;
		IL_0074:
		CachedModel<List<GameAchievementViewModel>> achievements2 = CachedModels.Achievements;
		bool flag3 = achievements2 == null;
		object obj9 = !flag3;
		cachedModel = (CachedModel<object>)(object)achievements2;
		if (obj9 != null)
		{
			goto IL_0115;
		}
		goto IL_0330;
		IL_0115:
		object obj10 = (nint)0 + (nint)400;
		object model = cachedModel.Model;
		if (model == null)
		{
			return;
		}
		obj6 = typeof(SqlSingle[]) + 2360;
		object obj11 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v6+E4]");
		if ((nint)0 != 0)
		{
			RebuildAchievements((List<GameAchievementViewModel>)model);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45AE]");
			object obj12 = (nint)0 & (nint)1;
			if (obj12 != null)
			{
				goto IL_01c8;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			RebuildAchievements((List<GameAchievementViewModel>)model);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45AE]");
			object obj13 = (nint)0 & (nint)1;
			bool flag4 = obj13 == null;
			object obj14 = !flag4;
			if (obj14 != null)
			{
				goto IL_01c8;
			}
		}
		_ = 1;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v18+E4]");
		bool flag5 = (nint)0 == 0;
		object obj15 = !flag5;
		obj7 = obj5;
		if (obj15 != null)
		{
			goto IL_01fd;
		}
		goto IL_02ce;
		IL_02ce:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj16 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v7+B8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v8+8]");
		oneShotEvent = (OneShotEvent)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v8+8]");
		bool flag6 = (nint)0 == 0;
		object obj18 = !flag6;
		if (obj18 != null)
		{
			goto IL_0222;
		}
		goto IL_0330;
		IL_0330:
		throw new NullReferenceException();
	}

	private static void RebuildAchievements(List<GameAchievementViewModel> achievements)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f1: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		//IL_015a: Expected O, but got I
		//IL_0162: Expected I, but got O
		//IL_0129: Expected O, but got I
		//IL_0195: Expected O, but got I
		//IL_01a1: Expected O, but got I
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_01c1: Expected O, but got I
		//IL_01cd: Expected O, but got I
		//IL_04a3: Expected O, but got I
		//IL_04ab: Expected I, but got O
		//IL_0424: Expected I, but got O
		//IL_0451: Expected O, but got I4
		//IL_03b0: Expected O, but got I4
		//IL_059e: Expected O, but got I
		//IL_043a: Expected I, but got O
		//IL_02c5: Expected O, but got I
		//IL_02d5: Expected O, but got I
		//IL_02f7: Expected O, but got I4
		//IL_03f6: Expected O, but got I
		//IL_0379: Expected O, but got I
		//IL_025e: Expected O, but got I
		//IL_026e: Expected O, but got I
		//IL_0290: Expected O, but got I4
		//IL_0327: Expected O, but got I4
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Expected O, but got Unknown
		//IL_0548: Expected I, but got O
		//IL_0566: Expected O, but got I
		//IL_0581: Expected O, but got I4
		//IL_0357: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B33]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v82+E4]");
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
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v82+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v46+B8]");
		object obj7 = 0;
		Dictionary<object, object> dictionary = (Dictionary<object, object>)obj7;
		if (obj7 != null)
		{
			goto IL_014e;
		}
		goto IL_050b;
		IL_050b:
		NullReferenceException ex = new NullReferenceException();
		nint num = default(nint);
		bool flag3 = num != 1;
		OutOfMemoryException ex2 = (OutOfMemoryException)(object)ex;
		List<object>.Enumerator enumerator = default(List<object>.Enumerator);
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj8 = (nint)0 + (nint)1016;
			num = (nint)obj8;
			enumerator.Dispose();
			object obj9 = default(object);
			if (obj9 == null)
			{
				return;
			}
			ex2 = new OutOfMemoryException();
			List<object>.Enumerator enumerator2 = (List<object>.Enumerator)obj9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2238B1C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_014e:
		object obj10 = (nint)0 + (nint)2616;
		num = (nint)obj10;
		dictionary.Clear();
		if (achievements != null)
		{
			object obj11 = (nint)0 + (nint)1024;
			object obj12 = (nint)0 + (nint)2632;
			object obj13 = typeof(XmlSchemaInclude) + 3832;
			object obj14 = (nint)0 + (nint)2256;
			object obj15 = (nint)0 + (nint)280;
			List<object>.Enumerator enumerator3 = ((List<object>)(object)achievements).GetEnumerator();
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			object obj16 = default(object);
			Comparison<object> comparison3 = default(Comparison<object>);
			while (true)
			{
				Comparison<object> comparison = (Comparison<object>)obj11;
				object obj18;
				Comparison<object> comparison2;
				if (enumerator4.MoveNext())
				{
					if (obj16 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ stack_-88 (System.Object)+38]");
						if ((nint)0 != 0)
						{
							object obj17 = obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v34+E4]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v34+B8]");
								obj18 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v25+28]");
								comparison2 = (Comparison<object>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v25+28]");
								bool flag4 = (nint)0 == 0;
								object obj19 = !flag4;
								if (obj19 == null)
								{
									goto IL_0305;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj17 = obj13;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v34+B8]");
								obj18 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v25+28]");
								comparison2 = (Comparison<object>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v25+28]");
								bool flag5 = (nint)0 == 0;
								object obj20 = !flag5;
								if (obj20 == null)
								{
									goto IL_0305;
								}
							}
							goto IL_035c;
						}
						goto IL_0386;
					}
					NullReferenceException ex3 = new NullReferenceException();
					num = (nint)obj11;
					break;
				}
				enumerator4.Dispose();
				return;
				IL_035c:
				object obj21 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ stack_-88 (System.Object)+38]");
				((List<object>)0).Sort(comparison2);
				comparison = comparison2;
				goto IL_0386;
				IL_0305:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v34+E4]");
				bool flag6 = (nint)0 == 0;
				object obj22 = !flag6;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj23 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v29+B8]");
					obj18 = 0;
				}
				object obj24 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 3240;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				comparison3..ctor(obj18, (IntPtr)obj14);
				object obj25 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v28+B8]");
				object obj26 = (nint)0 + (nint)40;
				obj26 = comparison3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj27 = 0;
				comparison2 = comparison3;
				goto IL_035c;
				IL_0386:
				object obj28 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v26+E4]");
				bool flag7 = (nint)0 == 0;
				object obj29 = !flag7;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj28 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v26+B8]");
				object obj30 = 0;
				if (obj30 != null)
				{
					obj27 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ stack_-88 (System.Object)+10]");
					((Dictionary<object, object>)obj30).set_Item((object)0, obj16);
					obj21 = obj16;
					continue;
				}
				NullReferenceException ex4 = new NullReferenceException();
				num = (nint)comparison;
				break;
			}
			List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
			enumerator = enumerator2;
			enumerator2 = (List<object>.Enumerator)0;
		}
		goto IL_050b;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v82+B8]");
		object obj31 = 0;
		dictionary = (Dictionary<object, object>)obj31;
		bool flag8 = obj31 == null;
		object obj32 = !flag8;
		if (obj32 != null)
		{
			goto IL_014e;
		}
		goto IL_050b;
	}

	private static bool IsGameAchievement(GameAchievementViewModel model)
	{
		//IL_00d7: Expected I4, but got O
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0065: Expected O, but got I4
		//IL_00af: Expected O, but got I4
		if (model != null)
		{
			if (model.<gameID>k__BackingField != GameCategory.Common)
			{
				object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Games currentGame = Preferences.CurrentGame;
				GameCategory gameCategory = GameCategoryExtensions.ToGameCategory(currentGame);
				object obj4 = model.<gameID>k__BackingField - gameCategory;
				return obj4 == null;
			}
			return true;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static GameAchievementViewModel GetAchievement(string achievementId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005b: Expected O, but got I4
		//IL_0079: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2360;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+B8]");
		object dictionary = 0;
		return (GameAchievementViewModel)CollectionExtensions.GetValueOrDefault((IReadOnlyDictionary<object, object>)dictionary, achievementId);
	}

	public static void ResetModels()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f1: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		//IL_0142: Expected O, but got I
		//IL_0154: Expected O, but got I4
		//IL_016a: Expected O, but got I
		//IL_0129: Expected O, but got I
		//IL_02ec: Expected O, but got I4
		//IL_01cc: Expected O, but got I
		//IL_01dc: Expected O, but got I
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_0201: Expected O, but got I
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0324: Expected O, but got I
		//IL_0334: Expected O, but got I
		//IL_0356: Expected O, but got I4
		//IL_0240: Expected I, but got O
		//IL_026a: Expected O, but got I4
		//IL_02ad: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B35]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v45+E4]");
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
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v45+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v27+B8]");
		object obj7 = 0;
		Dictionary<object, object> dictionary = (Dictionary<object, object>)obj7;
		goto IL_0136;
		IL_01bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v22+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v14+8]");
		OneShotEvent oneShotEvent = (OneShotEvent)0;
		goto IL_01e1;
		IL_01e1:
		object obj9 = typeof(SqlSingle[]) + 2376;
		object obj10 = (nint)0 + (nint)1784;
		object obj11 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		oneShotEvent.IsReady = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj10);
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Config.OnLoggedIn -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(null, (IntPtr)obj10);
		Config.OnLoggedIn += action2;
		return;
		IL_0364:
		throw new NullReferenceException();
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v45+B8]");
		object obj14 = 0;
		dictionary = (Dictionary<object, object>)obj14;
		bool flag4 = obj14 == null;
		object obj15 = !flag4;
		if (obj15 != null)
		{
			goto IL_0136;
		}
		goto IL_0364;
		IL_0136:
		object obj16 = (nint)0 + (nint)2616;
		dictionary.Clear();
		object obj17 = 146685952;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45AE]");
		object obj18 = (nint)0 & (nint)1;
		if (obj18 != null)
		{
			object obj19 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v22+E4]");
			bool flag5 = (nint)0 == 0;
			object obj20 = obj19;
			if (!flag5)
			{
				goto IL_01bc;
			}
		}
		else
		{
			_ = 1;
			object obj19 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v22+E4]");
			bool flag6 = (nint)0 == 0;
			object obj21 = !flag6;
			object obj20 = obj19;
			if (obj21 != null)
			{
				goto IL_01bc;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v6+B8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v8+8]");
		oneShotEvent = (OneShotEvent)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v8+8]");
		bool flag7 = (nint)0 == 0;
		object obj24 = !flag7;
		if (obj24 != null)
		{
			goto IL_01e1;
		}
		goto IL_0364;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00cb: Expected O, but got I
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00f7: Expected I, but got O
		//IL_0121: Expected O, but got I4
		//IL_006e: Expected I, but got O
		//IL_0098: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1784;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj4 = (nint)0 + (nint)1776;
		object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj2);
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Config.OnLoggedIn -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(null, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ContentPushService.OnAchievementsApplied -= action2;
	}

	public static void CallWhenLoaded(Action action)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_013f: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01c5: Expected O, but got I4
		//IL_016d: Expected O, but got I
		//IL_0187: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_00fc: Expected O, but got I
		//IL_01fd: Expected O, but got I
		//IL_020d: Expected O, but got I
		//IL_022f: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B37]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v12+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45AE]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_0195;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v19+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v14+8]");
		OneShotEvent oneShotEvent = (OneShotEvent)0;
		goto IL_0101;
		IL_0101:
		oneShotEvent.CallWhenReady(action);
		return;
		IL_01db:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v5+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v4+8]");
		oneShotEvent = (OneShotEvent)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0101;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45AE]");
		object obj11 = (nint)0 & (nint)1;
		if (obj11 != null)
		{
			goto IL_00a7;
		}
		goto IL_0195;
		IL_0195:
		_ = 1;
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v19+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		object obj14 = obj12;
		if (obj13 != null)
		{
			goto IL_00dc;
		}
		goto IL_01db;
		IL_00a7:
		obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v19+E4]");
		bool flag5 = (nint)0 == 0;
		obj14 = obj12;
		if (!flag5)
		{
			goto IL_00dc;
		}
		goto IL_01db;
	}

	static AchievementsManager()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0078: Expected O, but got I
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2368;
		object obj2 = typeof(SqlSingle[]) + 2360;
		object obj3 = typeof(MemberAchievementClanFeedData) + 3440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj4 = obj2;
		object obj5 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		OneShotEvent oneShotEvent = default(OneShotEvent);
		oneShotEvent..ctor();
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+B8]");
		object obj7 = (nint)0 + (nint)8;
		obj7 = oneShotEvent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
