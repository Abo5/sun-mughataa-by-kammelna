using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using Cpp2ILInjected;
using DG.Tweening;
using GoogleMobileAds.Ump.Api;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Managers.Achievemenets;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Rendering;

public class AchievementsListView : UiGridView<AchievementHolder, Achievement>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<GameAchievementViewModel, string> <>9__9_2;

		public static Func<UserAchievementModel, string> <>9__9_3;

		public static Func<GameAchievementViewModel, IEnumerable<UserAchievementModel>, <>f__AnonymousType10<GameAchievementViewModel, IEnumerable<UserAchievementModel>>> <>9__9_4;

		public static Func<<>f__AnonymousType10<GameAchievementViewModel, IEnumerable<UserAchievementModel>>, IEnumerable<UserAchievementModel>> <>9__9_5;

		public static Func<<>f__AnonymousType10<GameAchievementViewModel, IEnumerable<UserAchievementModel>>, UserAchievementModel, <>f__AnonymousType11<<>f__AnonymousType10<GameAchievementViewModel, IEnumerable<UserAchievementModel>>, UserAchievementModel>> <>9__9_6;

		public static Func<<>f__AnonymousType11<<>f__AnonymousType10<GameAchievementViewModel, IEnumerable<UserAchievementModel>>, UserAchievementModel>, bool> <>9__9_8;

		public static Func<<>f__AnonymousType11<<>f__AnonymousType10<GameAchievementViewModel, IEnumerable<UserAchievementModel>>, UserAchievementModel>, int?> <>9__9_9;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(XmlSchemaInclude) + 3816;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal string <SetData>b__9_2(GameAchievementViewModel model)
		{
			if (model != null)
			{
				return model.<id>k__BackingField;
			}
			return (string)(object)new NullReferenceException();
		}

		internal string <SetData>b__9_3(UserAchievementModel userAchievement)
		{
			if (userAchievement != null)
			{
				return userAchievement.<gameAchievementId>k__BackingField;
			}
			return (string)(object)new NullReferenceException();
		}

		internal <>f__AnonymousType10<GameAchievementViewModel, IEnumerable<UserAchievementModel>> <SetData>b__9_4(GameAchievementViewModel model, IEnumerable<UserAchievementModel> gj)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 40;
			object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 2488;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FD2C80");
			<>f__AnonymousType10<GameAchievementViewModel, IEnumerable<UserAchievementModel>> result = default(<>f__AnonymousType10<GameAchievementViewModel, IEnumerable<UserAchievementModel>>);
			return result;
		}

		internal IEnumerable<UserAchievementModel> <SetData>b__9_5(<>f__AnonymousType10<GameAchievementViewModel, IEnumerable<UserAchievementModel>> <>h__TransparentIdentifier0)
		{
			//IL_0011: Expected O, but got I
			if (<>h__TransparentIdentifier0 != null)
			{
				object obj = (nint)0 + (nint)3664;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DBDC48");
				IEnumerable<UserAchievementModel> result = default(IEnumerable<UserAchievementModel>);
				return result;
			}
			return (IEnumerable<UserAchievementModel>)new NullReferenceException();
		}

		internal <>f__AnonymousType11<<>f__AnonymousType10<GameAchievementViewModel, IEnumerable<UserAchievementModel>>, UserAchievementModel> <SetData>b__9_6(<>f__AnonymousType10<GameAchievementViewModel, IEnumerable<UserAchievementModel>> <>h__TransparentIdentifier0, UserAchievementModel userModel)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 48;
			object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 2512;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FD39EC");
			<>f__AnonymousType11<<>f__AnonymousType10<GameAchievementViewModel, IEnumerable<UserAchievementModel>>, UserAchievementModel> result = default(<>f__AnonymousType11<<>f__AnonymousType10<GameAchievementViewModel, IEnumerable<UserAchievementModel>>, UserAchievementModel>);
			return result;
		}

		internal bool <SetData>b__9_8(<>f__AnonymousType11<<>f__AnonymousType10<GameAchievementViewModel, IEnumerable<UserAchievementModel>>, UserAchievementModel> <>h__TransparentIdentifier1)
		{
			//IL_00c4: Expected I4, but got O
			//IL_0041: Expected O, but got I4
			//IL_00b1: Expected O, but got I4
			if (<>h__TransparentIdentifier1 != null)
			{
				UserAchievementModel userAchievementModel = <>h__TransparentIdentifier1.<userModel>i__Field;
				if (<>h__TransparentIdentifier1.<userModel>i__Field != null)
				{
					userAchievementModel = (UserAchievementModel)userAchievementModel.<levelId>k__BackingField;
				}
				<>f__AnonymousType10<GameAchievementViewModel, IEnumerable<UserAchievementModel>> <<>h__TransparentIdentifier0>i__Field = <>h__TransparentIdentifier1.<<>h__TransparentIdentifier0>i__Field;
				if (<>h__TransparentIdentifier1.<<>h__TransparentIdentifier0>i__Field != null)
				{
					GameAchievementViewModel <model>i__Field = <<>h__TransparentIdentifier0>i__Field.<model>i__Field;
					if (<<>h__TransparentIdentifier0>i__Field.<model>i__Field != null)
					{
						List<AchievementLevelModel> list = <model>i__Field.<achievementLevels>k__BackingField;
						if (<model>i__Field.<achievementLevels>k__BackingField != null)
						{
							list = (List<AchievementLevelModel>)list._size;
						}
						object obj = (object)userAchievementModel - (object)list;
						return obj == null;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal int? <SetData>b__9_9(<>f__AnonymousType11<<>f__AnonymousType10<GameAchievementViewModel, IEnumerable<UserAchievementModel>>, UserAchievementModel> <>h__TransparentIdentifier1)
		{
			//IL_0052: Expected O, but got I4
			if (<>h__TransparentIdentifier1 != null)
			{
				UserAchievementModel <userModel>i__Field = <>h__TransparentIdentifier1.<userModel>i__Field;
				if (<>h__TransparentIdentifier1.<userModel>i__Field != null)
				{
					return <userModel>i__Field.<levelId>k__BackingField;
				}
				return (int?)(object)0;
			}
			return (int?)new NullReferenceException();
		}
	}

	private sealed class <>c__DisplayClass9_0
	{
		public List<UserAchievementModel> userAchievements;

		public AchievementsListView <>4__this;

		public bool isItMine;

		internal unsafe void <SetData>g__ProcessAchievements|0()
		{
			//IL_0f8a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f8f: Expected O, but got Unknown
			//IL_0fb5: Expected O, but got I4
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected O, but got Unknown
			//IL_0065: Expected O, but got I
			//IL_0071: Expected O, but got I
			//IL_007d: Expected O, but got I
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Expected O, but got Unknown
			//IL_00bb: Expected O, but got I4
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_002f: Expected O, but got I
			//IL_00fe: Expected I, but got O
			//IL_0106: Expected I, but got O
			//IL_0377: Expected O, but got I
			//IL_0387: Expected O, but got I
			//IL_03a9: Expected O, but got I4
			//IL_01cb: Expected O, but got I4
			//IL_01d4: Expected O, but got I4
			//IL_016e: Expected O, but got I
			//IL_017e: Expected O, but got I
			//IL_04b2: Expected O, but got I
			//IL_04c2: Expected O, but got I
			//IL_04e4: Expected O, but got I4
			//IL_03e1: Expected O, but got I4
			//IL_0212: Expected O, but got I
			//IL_0222: Expected O, but got I
			//IL_0fd2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fd7: Expected O, but got Unknown
			//IL_0fed: Expected O, but got I
			//IL_0ff5: Expected I, but got O
			//IL_1006: Expected I, but got O
			//IL_1024: Expected O, but got I
			//IL_0611: Expected O, but got I
			//IL_0621: Expected O, but got I
			//IL_0631: Expected O, but got I
			//IL_0653: Expected O, but got I4
			//IL_053c: Expected O, but got I4
			//IL_0440: Expected O, but got I4
			//IL_0449: Expected O, but got I4
			//IL_0462: Expected O, but got I4
			//IL_046a: Expected I, but got O
			//IL_0411: Expected O, but got I
			//IL_06d8: Expected I4, but got O
			//IL_02d0: Expected O, but got I
			//IL_02e0: Expected O, but got I
			//IL_02f0: Expected O, but got I
			//IL_0312: Expected O, but got I4
			//IL_104a: Unknown result type (might be due to invalid IL or missing references)
			//IL_104f: Expected O, but got Unknown
			//IL_1065: Expected O, but got I
			//IL_106d: Expected I, but got O
			//IL_107e: Expected I, but got O
			//IL_109c: Expected O, but got I
			//IL_09a9: Expected O, but got I
			//IL_09b9: Expected O, but got I
			//IL_09db: Expected O, but got I4
			//IL_069b: Expected O, but got I4
			//IL_059b: Expected O, but got I4
			//IL_05a4: Expected O, but got I4
			//IL_05c5: Expected O, but got I4
			//IL_05cd: Expected I, but got O
			//IL_056c: Expected O, but got I
			//IL_0783: Expected I, but got O
			//IL_079b: Expected I, but got O
			//IL_071f: Expected O, but got I
			//IL_072f: Expected O, but got I
			//IL_10c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_10c7: Expected O, but got Unknown
			//IL_10dd: Expected O, but got I
			//IL_10ee: Expected I, but got O
			//IL_110c: Expected O, but got I
			//IL_0a13: Expected O, but got I4
			//IL_06cb: Expected O, but got I
			//IL_07cd: Expected O, but got I
			//IL_07dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e1: Expected O, but got Unknown
			//IL_07ed: Expected O, but got I
			//IL_07f9: Expected O, but got I
			//IL_0809: Expected O, but got I
			//IL_0819: Expected O, but got I
			//IL_083b: Expected O, but got I4
			//IL_11ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_11cf: Expected O, but got Unknown
			//IL_11e5: Expected O, but got I
			//IL_11ed: Expected I, but got O
			//IL_11fe: Expected I, but got O
			//IL_121c: Expected O, but got I
			//IL_0a72: Expected O, but got I4
			//IL_0a94: Expected I, but got O
			//IL_0a43: Expected O, but got I
			//IL_08d2: Expected I, but got O
			//IL_086b: Expected O, but got I4
			//IL_1152: Unknown result type (might be due to invalid IL or missing references)
			//IL_1157: Expected O, but got Unknown
			//IL_116d: Expected O, but got I
			//IL_117e: Expected I, but got O
			//IL_119c: Expected O, but got I
			//IL_0b0f: Expected O, but got I
			//IL_0b1f: Expected O, but got I
			//IL_0b2f: Expected O, but got I
			//IL_0b51: Expected O, but got I4
			//IL_0b5a: Expected O, but got I4
			//IL_089b: Expected O, but got I
			//IL_0c02: Expected O, but got I4
			//IL_0921: Expected O, but got I
			//IL_0931: Expected O, but got I
			//IL_0941: Expected O, but got I
			//IL_0963: Expected O, but got I4
			//IL_096c: Expected O, but got I4
			//IL_12b4: Expected O, but got I
			//IL_12c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_12c8: Expected O, but got Unknown
			//IL_12d4: Expected O, but got I
			//IL_12e0: Expected O, but got I
			//IL_12ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_12f4: Expected O, but got Unknown
			//IL_1304: Expected O, but got I
			//IL_1314: Expected O, but got I
			//IL_1336: Expected O, but got I4
			//IL_0b92: Expected O, but got I4
			//IL_0c8b: Expected O, but got I
			//IL_1249: Expected O, but got I
			//IL_125a: Expected I, but got O
			//IL_1278: Expected O, but got I
			//IL_1293: Expected O, but got I4
			//IL_0cb2: Expected I, but got O
			//IL_0c49: Expected O, but got I4
			//IL_0bc2: Expected O, but got I
			//IL_0cf4: Expected O, but got I4
			//IL_1353: Unknown result type (might be due to invalid IL or missing references)
			//IL_1358: Expected O, but got Unknown
			//IL_136e: Expected O, but got I
			//IL_137f: Expected I, but got O
			//IL_139d: Expected O, but got I
			//IL_13b8: Expected O, but got I4
			//IL_0c79: Expected O, but got I
			//IL_0d0e: Expected O, but got I
			//IL_0d72: Expected I4, but got O
			//IL_13d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_13d9: Expected O, but got Unknown
			//IL_13e5: Expected O, but got I
			//IL_13f1: Expected O, but got I
			//IL_1409: Expected I, but got O
			//IL_0db4: Expected O, but got I
			//IL_0dd2: Expected O, but got I
			//IL_0de7: Expected O, but got I
			//IL_0e15: Expected O, but got I4
			//IL_0ebe: Expected O, but got I
			//IL_0ece: Expected O, but got I
			//IL_0ede: Expected O, but got I
			//IL_0eeb: Expected O, but got Ref
			//IL_0ef4: Expected O, but got I4
			//IL_0f04: Expected O, but got Ref
			//IL_0e39: Expected O, but got I
			//IL_0e54: Expected O, but got I
			//IL_0e7b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e80: Expected O, but got Unknown
			//IL_0e93: Expected O, but got I4
			//IL_0ea9: Expected O, but got I4
			object obj = typeof(SqlSingle[]) + 2360;
			List<object> list = (List<object>)(object)userAchievements;
			bool flag = userAchievements == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				object obj3 = typeof(List<Tween>) + 160;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj4 = (nint)0 + (nint)2864;
				List<object> list2 = default(List<object>);
				list2..ctor();
				list = list2;
			}
			object obj5 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1248;
			object obj6 = (nint)0 + (nint)2208;
			object obj7 = (nint)0 + (nint)3440;
			object obj8 = (nint)0 + (nint)2088;
			object obj9 = typeof(XmlSchemaInclude) + 3816;
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			IEnumerable<GameAchievementViewModel> gameAchievements = AchievementsManager.GameAchievements;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor((object)this, (IntPtr)obj6);
			nint num = (nint)obj7;
			IEnumerable<object> source = Enumerable.Where(gameAchievements, func);
			Func<object, object> func2 = (Func<object, object>)obj8;
			List<object> list3 = Enumerable.ToList(source);
			object obj12 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v103+E4]");
			object obj13;
			Func<object, object> func3;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v103+B8]");
				obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v99+8]");
				func3 = (Func<object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v99+8]");
				bool flag3 = (nint)0 == 0;
				object obj14 = obj12;
				if (!flag3)
				{
					goto IL_01ab;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v103+B8]");
				obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v99+8]");
				func3 = (Func<object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v99+8]");
				bool flag4 = (nint)0 == 0;
				object obj15 = !flag4;
				object obj14 = obj12;
				if (obj15 != null)
				{
					goto IL_01ab;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v126+E4]");
			bool flag5 = (nint)0 == 0;
			object obj16 = !flag5;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj17 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v106+B8]");
				obj13 = 0;
			}
			object obj18 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1264;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj19 = (nint)0 + (nint)2152;
			num = (nint)obj19;
			Func<object, object> func4 = default(Func<object, object>);
			func4..ctor(obj13, (IntPtr)obj19);
			object obj20 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v104+B8]");
			object obj21 = (nint)0 + (nint)8;
			obj21 = func4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj12 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v103+E4]");
			bool flag6 = (nint)0 == 0;
			object obj22 = !flag6;
			object obj23 = 0;
			func3 = func4;
			func2 = func4;
			object obj24 = 0;
			nint num2 = (nint)obj19;
			Func<object, object> func5 = func4;
			Func<object, object> func6 = func4;
			object obj25 = obj12;
			if (obj22 != null)
			{
				goto IL_0202;
			}
			goto IL_0490;
			IL_026f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v103+E4]");
			bool flag7 = (nint)0 == 0;
			object obj26 = obj23;
			nint num3 = num;
			Func<object, object> func8;
			Func<object, object> func7 = func8;
			func5 = func3;
			Func<object, object> func9 = func2;
			object obj27 = obj12;
			if (!flag7)
			{
				goto IL_02c4;
			}
			goto IL_05f3;
			IL_07c1:
			object obj28 = (nint)0 + (nint)392;
			object obj29 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3112;
			object obj30 = (nint)0 + (nint)2232;
			object obj31 = (nint)0 + (nint)3056;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v31+B8]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X8_v64+28]");
			Func<object, object, object> resultSelector = (Func<object, object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X8_v64+28]");
			bool flag8 = (nint)0 == 0;
			object obj33 = !flag8;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v31+E4]");
				bool flag9 = (nint)0 == 0;
				object obj34 = !flag9;
				if (obj34 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj35 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v70+B8]");
					obj32 = 0;
				}
				object obj36 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 592;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj37 = (nint)0 + (nint)2184;
				Func<object, object, object> func10 = default(Func<object, object, object>);
				func10..ctor(obj32, (IntPtr)obj37);
				object obj38 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v69+B8]");
				object obj39 = (nint)0 + (nint)40;
				obj39 = func10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				resultSelector = func10;
			}
			IEnumerable<object> source3 = default(IEnumerable<object>);
			Func<object, IEnumerable<object>> func11;
			IEnumerable<object> source2 = Enumerable.SelectMany(source3, func11, resultSelector);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func12 = default(Func<object, bool>);
			func12..ctor((object)this, (IntPtr)obj30);
			IEnumerable<object> source4 = Enumerable.Where(source2, func12);
			object obj40 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X0_v85+E4]");
			object obj42;
			Func<object, bool> keySelector;
			object obj45;
			object obj41;
			object obj44;
			if ((nint)0 != 0)
			{
				obj41 = (nint)0 + (nint)2328;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X0_v85+B8]");
				obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X8_v56+30]");
				keySelector = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X8_v56+30]");
				bool flag10 = (nint)0 == 0;
				object obj43 = !flag10;
				obj44 = 0;
				if (obj43 == null)
				{
					obj45 = obj41;
					goto IL_0b70;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj40 = obj9;
				obj45 = (nint)0 + (nint)2328;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X0_v85+B8]");
				obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X8_v56+30]");
				keySelector = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X8_v56+30]");
				bool flag11 = (nint)0 == 0;
				object obj46 = !flag11;
				obj44 = 0;
				obj41 = obj45;
				if (obj46 == null)
				{
					goto IL_0b70;
				}
			}
			goto IL_0bc7;
			IL_02c4:
			object obj47 = (nint)0 + (nint)1584;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v103+B8]");
			object obj48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v76+18]");
			Func<object, object, object> func13 = (Func<object, object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v76+18]");
			bool flag12 = (nint)0 == 0;
			object obj49 = !flag12;
			object obj50;
			if (obj49 == null)
			{
				obj50 = obj47;
				obj26 = obj23;
				num3 = num;
				func7 = func8;
				func5 = func3;
				func9 = func2;
				goto IL_0679;
			}
			goto IL_06d0;
			IL_05f3:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj12 = obj9;
			obj50 = (nint)0 + (nint)1584;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v103+B8]");
			obj48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v76+18]");
			func13 = (Func<object, object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v76+18]");
			bool flag13 = (nint)0 == 0;
			object obj51 = !flag13;
			obj47 = obj50;
			func8 = func7;
			func3 = func5;
			if (obj51 == null)
			{
				goto IL_0679;
			}
			goto IL_06d0;
			IL_0b70:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X0_v85+E4]");
			bool flag14 = (nint)0 == 0;
			object obj52 = !flag14;
			if (obj52 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj53 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X8_v60+B8]");
				obj42 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj54 = (nint)0 + (nint)2192;
			Func<object, bool> func14 = default(Func<object, bool>);
			func14..ctor(obj42, (IntPtr)obj54);
			object obj55 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v59+B8]");
			object obj56 = (nint)0 + (nint)48;
			obj56 = func14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj44 = 0;
			keySelector = func14;
			obj41 = obj45;
			goto IL_0bc7;
			IL_0679:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v103+E4]");
			bool flag15 = (nint)0 == 0;
			object obj57 = !flag15;
			if (obj57 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj58 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v82+B8]");
				obj48 = 0;
			}
			object obj59 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 752;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj60 = (nint)0 + (nint)2168;
			Func<object, object, object> func15 = default(Func<object, object, object>);
			func15..ctor(obj48, (IntPtr)obj60);
			object obj61 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v81+B8]");
			object obj62 = (nint)0 + (nint)24;
			obj62 = func15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj47 = obj50;
			func8 = func7;
			func13 = func15;
			func3 = func5;
			goto IL_06d0;
			IL_075c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v31+E4]");
			bool flag16 = (nint)0 == 0;
			Func<object, object> func16 = func8;
			nint num4 = (nint)func3;
			List<object> list4 = list;
			Func<object, object> func17 = func8;
			nint num5 = (nint)func3;
			Func<object, IEnumerable<object>> func18 = func11;
			List<object> list5 = list;
			object obj64;
			object obj63 = obj64;
			if (!flag16)
			{
				goto IL_07c1;
			}
			goto IL_0aba;
			IL_06d0:
			int num6 = (int)obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC6298");
			obj64 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v31+E4]");
			object obj65;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v31+B8]");
				obj65 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v10+20]");
				func11 = (Func<object, IEnumerable<object>>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v10+20]");
				bool flag17 = (nint)0 == 0;
				object obj66 = obj64;
				if (!flag17)
				{
					goto IL_075c;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj64 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v31+B8]");
				obj65 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v10+20]");
				func11 = (Func<object, IEnumerable<object>>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v10+20]");
				bool flag18 = (nint)0 == 0;
				object obj67 = !flag18;
				object obj66 = obj64;
				if (obj67 != null)
				{
					goto IL_075c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v20+E4]");
			bool flag19 = (nint)0 == 0;
			object obj68 = !flag19;
			if (obj68 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj69 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v17+B8]");
				obj65 = 0;
			}
			object obj70 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3088;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj71 = (nint)0 + (nint)2176;
			num4 = (nint)obj71;
			Func<object, object> func19 = default(Func<object, object>);
			func19..ctor(obj65, (IntPtr)obj71);
			object obj72 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X8_v15+B8]");
			object obj73 = (nint)0 + (nint)32;
			obj73 = func19;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj64 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v31+E4]");
			bool flag20 = (nint)0 == 0;
			object obj74 = !flag20;
			func16 = null;
			func11 = (Func<object, IEnumerable<object>>)func19;
			list4 = (List<object>)(object)func19;
			func17 = null;
			num5 = (nint)obj71;
			func18 = (Func<object, IEnumerable<object>>)func19;
			list5 = (List<object>)(object)func19;
			obj63 = obj64;
			if (obj74 != null)
			{
				goto IL_07c1;
			}
			goto IL_0aba;
			IL_0bc7:
			IOrderedEnumerable<object> orderedEnumerable = Enumerable.OrderByDescending(source4, keySelector);
			object obj75 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X0_v44+E4]");
			bool flag21 = (nint)0 == 0;
			object obj76 = !flag21;
			if (obj76 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj75 = obj9;
			}
			object obj77 = (nint)0 + (nint)1032;
			object obj78 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3104;
			object obj79 = (nint)0 + (nint)2216;
			object obj80 = (nint)0 + (nint)2632;
			object obj81 = typeof(TypeConverter<ushort, char>) + 1592;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X0_v44+B8]");
			object obj82 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v47+38]");
			Func<object, int?> func20 = (Func<object, int?>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v47+38]");
			bool flag22 = (nint)0 == 0;
			object obj83 = !flag22;
			if (obj83 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X0_v44+E4]");
				bool flag23 = (nint)0 == 0;
				object obj84 = !flag23;
				if (obj84 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj85 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X8_v53+B8]");
					obj82 = 0;
				}
				object obj86 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3096;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj87 = (nint)0 + (nint)2200;
				Func<object, int?> func21 = default(Func<object, int?>);
				func21..ctor(obj82, (IntPtr)obj87);
				object obj88 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X8_v52+B8]");
				object obj89 = (nint)0 + (nint)56;
				obj89 = func21;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj44 = 0;
				func20 = func21;
			}
			object obj90 = (nint)0 + (nint)1816;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DE4D40");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, AchievementHolder> func22 = default(Func<object, AchievementHolder>);
			func22..ctor((object)this, (IntPtr)obj79);
			UserAchievementModel userAchievementModel = (UserAchievementModel)obj80;
			IEnumerable<object> source5 = default(IEnumerable<object>);
			IEnumerable<AchievementHolder> enumerable = Enumerable.Select(source5, func22);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			IEnumerable<AchievementHolder> enumerable2 = default(IEnumerable<AchievementHolder>);
			bool flag24 = enumerable2 == null;
			object obj91 = !flag24;
			if (obj91 == null)
			{
				object obj92 = (nint)0 + (nint)1104;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DE5250");
			}
			bool flag25 = Enumerable.Any(enumerable2);
			AchievementHolder achievementHolder = (AchievementHolder)obj90;
			List<AchievementHolder> list6 = Enumerable.ToList(enumerable2);
			AchievementsListView achievementsListView = <>4__this;
			bool flag26 = !achievementsListView.isEditMode;
			bool flag27 = (byte)(int)func13 != 0;
			bool flag28 = false;
			if (!flag26)
			{
				AchievementHolder achievementHolder2 = new AchievementHolder(null, null, isItMine: false, isEdit: true);
				object obj93 = (nint)0 + (nint)272;
				object obj94 = obj93;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X0_v56 (System.Collections.Generic.List`1<AchievementHolder>)+1C]");
				object obj95 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X0_v56 (System.Collections.Generic.List`1<AchievementHolder>)+10]");
				object obj96 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X0_v56 (System.Collections.Generic.List`1<AchievementHolder>)+18]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X9_v13+18]");
				bool flag29 = num7 < 0;
				object obj97 = !flag29;
				if (obj97 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X0_v56 (System.Collections.Generic.List`1<AchievementHolder>)+18]");
					object obj98 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X0_v56 (System.Collections.Generic.List`1<AchievementHolder>)+18]");
					object obj99 = (nint)0 * (nint)40;
					object obj100 = obj96 + obj99;
					_ = 0;
					_ = 0;
					object obj101 = obj100 + 40;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj102 = 0;
					AchievementHolder achievementHolder3 = achievementHolder2;
					userAchievementModel = null;
					achievementHolder = (AchievementHolder)0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X8_v37+20]");
					object obj103 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X8_v39+C0]");
					object obj104 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v947 @ X8_v40+70]");
					userAchievementModel = (UserAchievementModel)0;
					AchievementHolder achievementHolder4 = default(AchievementHolder);
					list6.AddWithResize((AchievementHolder)(&achievementHolder4));
					object obj102 = 0;
					AchievementHolder achievementHolder3 = achievementHolder2;
					achievementHolder = (AchievementHolder)(&achievementHolder4);
				}
				achievementsListView = <>4__this;
				flag27 = true;
				num6 = 0;
				flag28 = false;
			}
			object obj105 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 632;
			object obj106 = (nint)0 + (nint)2224;
			object obj107 = (nint)0 + (nint)2888;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<AchievementHolder, int, AchievementHolder> func23 = default(Func<AchievementHolder, int, AchievementHolder>);
			func23..ctor((object)this, (IntPtr)obj106);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DCF848");
			IEnumerable<AchievementHolder> source6 = default(IEnumerable<AchievementHolder>);
			List<AchievementHolder> data = Enumerable.ToList(source6);
			achievementsListView.data = data;
			bool isEmpty = (byte)((flag25 ? 1u : 0u) ^ 1u) != 0;
			<>4__this.UpdateEmptyState(isEmpty, isItMine);
			return;
			IL_01ab:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v103+E4]");
			bool flag30 = (nint)0 == 0;
			obj23 = 0;
			obj24 = 0;
			num2 = num;
			func5 = func3;
			func6 = func2;
			obj25 = obj12;
			if (!flag30)
			{
				goto IL_0202;
			}
			goto IL_0490;
			IL_0490:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj12 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v103+B8]");
			object obj108 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v87+10]");
			func8 = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v87+10]");
			bool flag31 = (nint)0 == 0;
			object obj109 = !flag31;
			obj23 = obj24;
			num = num2;
			func3 = func5;
			func2 = func6;
			object obj110 = obj12;
			if (obj109 != null)
			{
				goto IL_026f;
			}
			goto IL_051a;
			IL_0202:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v103+B8]");
			obj108 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v87+10]");
			func8 = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v87+10]");
			bool flag32 = (nint)0 == 0;
			obj24 = obj23;
			num2 = num;
			func5 = func3;
			func6 = func2;
			obj110 = obj12;
			if (!flag32)
			{
				goto IL_026f;
			}
			goto IL_051a;
			IL_051a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v114+E4]");
			bool flag33 = (nint)0 == 0;
			object obj111 = !flag33;
			if (obj111 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj112 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v94+B8]");
				obj108 = 0;
			}
			object obj113 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 88;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj114 = (nint)0 + (nint)2160;
			num = (nint)obj114;
			Func<object, object> func24 = default(Func<object, object>);
			func24..ctor(obj108, (IntPtr)obj114);
			object obj115 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v92+B8]");
			object obj116 = (nint)0 + (nint)16;
			obj116 = func24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj12 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v103+E4]");
			bool flag34 = (nint)0 == 0;
			object obj117 = !flag34;
			obj23 = 0;
			func8 = func24;
			func3 = func5;
			func2 = func24;
			obj26 = 0;
			num3 = (nint)obj114;
			func7 = func24;
			func9 = func24;
			obj27 = obj12;
			if (obj117 != null)
			{
				goto IL_02c4;
			}
			goto IL_05f3;
			IL_0aba:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj64 = obj9;
			func16 = func17;
			num4 = num5;
			func11 = func18;
			list4 = list5;
			goto IL_07c1;
		}

		internal bool <SetData>b__1(GameAchievementViewModel m)
		{
			//IL_007f: Expected I4, but got O
			//IL_005d: Expected O, but got I4
			if (m != null)
			{
				AchievementsListView achievementsListView = <>4__this;
				if ((object)<>4__this != null)
				{
					object obj = m.<type>k__BackingField - achievementsListView.<Type>k__BackingField;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <SetData>b__7(<>f__AnonymousType11<<>f__AnonymousType10<GameAchievementViewModel, IEnumerable<UserAchievementModel>>, UserAchievementModel> <>h__TransparentIdentifier1)
		{
			//IL_00a6: Expected I4, but got O
			//IL_0073: Expected I4, but got O
			AchievementsListView achievementsListView = <>4__this;
			if ((object)<>4__this != null)
			{
				bool result;
				if (achievementsListView.isPopulateNotOwned)
				{
					result = true;
				}
				else
				{
					if (<>h__TransparentIdentifier1 == null)
					{
						goto IL_0098;
					}
					bool flag = <>h__TransparentIdentifier1.<userModel>i__Field == null;
					result = (byte)(int)<>h__TransparentIdentifier1.<userModel>i__Field != 0;
					if (!flag)
					{
						return <>h__TransparentIdentifier1.<userModel>i__Field.isUnlocked;
					}
				}
				return result;
			}
			goto IL_0098;
			IL_0098:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal unsafe AchievementHolder <SetData>b__10(<>f__AnonymousType11<<>f__AnonymousType10<GameAchievementViewModel, IEnumerable<UserAchievementModel>>, UserAchievementModel> <>h__TransparentIdentifier1)
		{
			//IL_0066: Expected native int or pointer, but got O
			//IL_0070: Expected native int or pointer, but got O
			//IL_007e: Expected native int or pointer, but got O
			//IL_00ad: Expected native int or pointer, but got O
			if (<>h__TransparentIdentifier1 != null)
			{
				<>f__AnonymousType10<GameAchievementViewModel, IEnumerable<UserAchievementModel>> <<>h__TransparentIdentifier0>i__Field = <>h__TransparentIdentifier1.<<>h__TransparentIdentifier0>i__Field;
				if (<>h__TransparentIdentifier1.<<>h__TransparentIdentifier0>i__Field != null)
				{
					AchievementsListView achievementsListView = <>4__this;
					if ((object)<>4__this != null)
					{
						AchievementHolder achievementHolder = default(AchievementHolder);
						((AchievementHolder*)(nint)achievementHolder)-><index>k__BackingField = 0;
						System.Runtime.CompilerServices.Unsafe.Write(&((AchievementHolder*)(nint)achievementHolder)-><Model>k__BackingField, null);
						((AchievementHolder*)(nint)achievementHolder)-><IsItMine>k__BackingField = false;
						System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)achievementHolder, new AchievementHolder(<<>h__TransparentIdentifier0>i__Field.<model>i__Field, <>h__TransparentIdentifier1.<userModel>i__Field, isItMine, achievementsListView.isEditMode));
						return achievementHolder;
					}
				}
			}
			return (AchievementHolder)new NullReferenceException();
		}

		internal unsafe AchievementHolder <SetData>b__11(AchievementHolder h, int i)
		{
			//IL_003f: Expected native int or pointer, but got O
			//IL_0049: Expected native int or pointer, but got O
			//IL_0057: Expected native int or pointer, but got O
			//IL_008d: Expected O, but got I4
			//IL_0088: Expected native int or pointer, but got O
			AchievementsListView achievementsListView = <>4__this;
			if ((object)<>4__this != null)
			{
				GameAchievementViewModel <Model>k__BackingField = h.<Model>k__BackingField;
				AchievementHolder achievementHolder = default(AchievementHolder);
				((AchievementHolder*)(nint)achievementHolder)-><index>k__BackingField = 0;
				System.Runtime.CompilerServices.Unsafe.Write(&((AchievementHolder*)(nint)achievementHolder)-><Model>k__BackingField, null);
				((AchievementHolder*)(nint)achievementHolder)-><IsItMine>k__BackingField = false;
				System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)achievementHolder, new AchievementHolder(h.<Model>k__BackingField, (UserAchievementModel)<Model>k__BackingField.<gameID>k__BackingField, h.<IsItMine>k__BackingField, achievementsListView.isEditMode, i));
				return achievementHolder;
			}
			return (AchievementHolder)new NullReferenceException();
		}
	}

	public RectTransform childContent;

	private AchievementType <Type>k__BackingField;

	private bool isEditMode;

	private bool isPopulateNotOwned;

	private TextMeshProUGUI emptyListText;

	public AchievementType Type
	{
		get
		{
			return <Type>k__BackingField;
		}
		set
		{
			<Type>k__BackingField = value;
		}
	}

	protected override void Start()
	{
		//IL_000c: Expected O, but got I
		//IL_007d: Expected I, but got O
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0044: Expected I, but got O
		//IL_0054: Expected O, but got I
		//IL_0064: Expected O, but got I
		object obj = (nint)0 + (nint)328;
		List<AchievementHolder> list2 = default(List<AchievementHolder>);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9A484");
			nint num = (nint)this;
			List<AchievementHolder> list = base.data;
			if (list != null)
			{
				break;
			}
			object obj2 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 4064;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			list2..ctor();
			nint num2 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v8 (Il2CppClass<AchievementsListView>)+2A8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v8 (Il2CppClass<AchievementsListView>)+2B0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v71 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	public void SetData(List<UserAchievementModel> userAchievements, bool isItMine)
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
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00bc: Expected I, but got O
		//IL_00eb: Expected O, but got I4
		object obj = typeof(XmlSchemaInclude) + 3824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)2240;
		object obj5 = typeof(SqlSingle[]) + 2360;
		object obj6 = obj2 + 16;
		obj6 = userAchievements;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 24;
		obj7 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AchievementsListView)+E8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AchievementsManager.CallWhenLoaded(action);
	}

	private void UpdateEmptyState(bool isEmpty, bool isItMine)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_014a: Expected O, but got I4
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01b2: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E77E0]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			obj5 = emptyListText;
			obj6 = emptyListText;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = emptyListText;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = emptyListText;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			goto IL_0158;
		}
		return;
		IL_0158:
		if (<Type>k__BackingField == AchievementType.Trophy)
		{
			object text = "WhiteSmoke" + 1872;
			object obj9 = "The operation is not allowed on non-connected sockets." + 3208;
			bool flag5 = !isItMine;
			object obj10 = !flag5;
			object obj11 = ~obj10;
			if (obj11 != null)
			{
				text = obj9;
			}
			TextMeshProExtensions.Localize(emptyListText, (string)text);
			GameObject gameObject = emptyListText.gameObject;
			gameObject.SetActive(isEmpty);
		}
		return;
		IL_0091:
		if (obj5 == null)
		{
			return;
		}
		goto IL_0158;
	}

	protected override void ComputeConditions()
	{
		//IL_000c: Expected O, but got I
		//IL_0062: Expected O, but got I4
		object obj = (nint)0 + (nint)320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9A4F4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AchievementsListView)+E8]");
		float num = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AchievementsListView)+20]");
		float value = num - 0f;
		UIExtensions.MoveTo(y: value, gObject: childContent, isWorldPositions: false, x: (float?)(object)0);
	}

	public AchievementsListView()
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)312;
		isPopulateNotOwned = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9AE10");
	}
}
