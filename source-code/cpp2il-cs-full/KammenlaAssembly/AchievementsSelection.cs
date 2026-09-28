using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Xml.Schema;
using Cpp2ILInjected;
using DG.Tweening;
using HuaweiMobileServices.Location.Location;
using Managers.Achievemenets;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using TMPro;
using Unity.Properties;
using UnityEngine;

public class AchievementsSelection : MonoBehaviour
{
	private sealed class <>c__DisplayClass3_0
	{
		public AchievementsSelection <>4__this;

		public List<UserAchievementModel> achievementModels;

		internal void <Populate>b__0()
		{
			<>4__this.UpdateOwnedAchievementCount(achievementModels);
		}
	}

	private sealed class <>c__DisplayClass6_0
	{
		public string achievementId;

		internal bool <GetAchievementType>b__0(GameAchievementViewModel a)
		{
			//IL_0048: Expected I4, but got O
			if (a != null)
			{
				return a.<id>k__BackingField == achievementId;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private AchievementsListView list;

	private AchievementType type;

	private TextMeshProUGUI ownedAchievementsCount;

	public void Populate(List<UserAchievementModel> achievementModels, bool isMyProfile)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0075: Expected O, but got I4
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_00f6: Expected O, but got I
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0132: Expected O, but got I
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_0152: Expected I, but got O
		object obj = typeof(XmlSchemaInclude) + 3840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = achievementModels;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag = obj4 == null;
		object obj5 = !flag;
		if (obj5 == null)
		{
			object obj6 = typeof(List<Tween>) + 160;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list = default(List<object>);
			list..ctor();
			obj4 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		AchievementsListView achievementsListView = this.list;
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)2288;
		object obj9 = typeof(SqlSingle[]) + 2360;
		achievementsListView.<Type>k__BackingField = type;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+18]");
		achievementsListView.SetData((List<UserAchievementModel>)0, isMyProfile);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj8);
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v15+E4]");
		if ((nint)0 != 0)
		{
			AchievementsManager.CallWhenLoaded(action);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		AchievementsManager.CallWhenLoaded(action);
	}

	private unsafe void UpdateOwnedAchievementCount(List<UserAchievementModel> userAchievements)
	{
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01d6: Expected O, but got I
		//IL_01e2: Expected O, but got I
		//IL_0255: Expected I, but got O
		//IL_001e: Expected O, but got I4
		//IL_0144: Expected O, but got Ref
		//IL_0061: Expected O, but got Ref
		//IL_0077: Expected I, but got O
		//IL_0087: Expected O, but got I
		//IL_00b0: Expected O, but got I
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		object obj = "Network Authentication Required" + 2568;
		object obj2 = "Network Authentication Required" + 2576;
		object obj3 = "Network Authentication Required" + 2552;
		object obj4 = typeof(TypeConverter<ushort, char>) + 3400;
		object obj5 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 80;
		object obj6 = (nint)0 + (nint)1792;
		object obj7 = (nint)0 + (nint)3632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor((object)this, (IntPtr)obj6);
		int num = Enumerable.Count(userAchievements, func);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj8 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object[] array = default(object[]);
		object obj10;
		int num2 = default(int);
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj11;
		if (array != null)
		{
			object obj9 = default(object);
			bool flag = obj9 == null;
			obj10 = (object)(&num2);
			if (!flag)
			{
				nint num3 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v14 (Il2CppClass<System.Object[]>)+40]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag2 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v14 (Il2CppClass<System.Object[]>)+40]");
				obj11 = 0;
				if (flag2)
				{
					goto IL_015f;
				}
			}
			if (array.Length != 0)
			{
				string text = (string)((type != AchievementType.Trophy) ? obj3 : obj2);
				string text2 = (string)((type != AchievementType.Title) ? text : obj);
				object obj12 = array + 32;
				obj12 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				TextMeshProExtensions.Localize(ownedAchievementsCount, text2, array);
				return;
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			obj10 = (object)(&num2);
		}
		ex = new IndexOutOfRangeException();
		obj11 = obj10;
		goto IL_015f;
		IL_015f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	private int CountAchievements(List<UserAchievementModel> userAchievements)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0043: Expected I, but got O
		object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 80;
		object obj2 = (nint)0 + (nint)1792;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor((object)this, (IntPtr)obj2);
		return Enumerable.Count(userAchievements, func);
	}

	private AchievementType GetAchievementType(string achievementId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_013c: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0098: Expected O, but got I4
		//IL_00de: Expected I, but got O
		//IL_010b: Expected I4, but got O
		object obj = typeof(XmlSchemaInclude) + 3848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(SqlSingle[]) + 2360;
			object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1248;
			object obj5 = (nint)0 + (nint)2296;
			object obj6 = obj2 + 16;
			obj6 = achievementId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			IEnumerable<GameAchievementViewModel> gameAchievements = AchievementsManager.GameAchievements;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj5);
			object obj9 = Enumerable.FirstOrDefault(gameAchievements, func);
			bool flag2 = obj9 == null;
			AchievementType result = (AchievementType)obj9;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v14 (System.Object)+28]");
				result = AchievementType.Achievement;
			}
			return result;
		}
		NullReferenceException ex = new NullReferenceException();
		return (AchievementType)ex;
	}

	private bool <CountAchievements>b__5_0(UserAchievementModel ua)
	{
		//IL_0092: Expected I4, but got O
		//IL_0055: Expected O, but got I4
		//IL_0068: Expected O, but got I4
		if (ua != null)
		{
			bool flag = ua.isUnlocked;
			if (flag)
			{
				AchievementType achievementType = ((AchievementsSelection)flag).GetAchievementType(ua.<gameAchievementId>k__BackingField);
				object obj = achievementType - type;
				bool flag2 = obj == null;
				flag = flag2;
			}
			return flag;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
