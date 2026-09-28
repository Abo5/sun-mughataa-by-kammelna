using System;
using System.Collections.Generic;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using HuaweiMobileServices.Location.Location;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Rendering;

public class BalootProjectUtility : ProjectsUtility<BalootProject>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Project, BalootProject> <>9__4_0;

		public static Func<Project, IComparable> <>9__4_1;

		public static Func<Card, Rank> <>9__4_2;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal BalootProject <ProjectPrecedence>b__4_0(Project pair)
		{
			//IL_0005: Expected I4, but got O
			return (BalootProject)pair;
		}

		internal IComparable <ProjectPrecedence>b__4_1(Project pair)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2032;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			IComparable result = default(IComparable);
			return result;
		}

		internal Rank <ProjectPrecedence>b__4_2(Card card)
		{
			//IL_0035: Expected I4, but got O
			if (card != null)
			{
				return card.<Rank>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Rank)ex;
		}

		internal bool <.cctor>b__6_0(KeyValuePair<BalootProject, ProjectConditions> pair)
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			object obj = pair - 3;
			bool flag = obj == null;
			return !flag;
		}
	}

	private static readonly List<KeyValuePair<BalootProject, ProjectConditions>> ProjectDefinitions;

	private static readonly List<KeyValuePair<BalootProject, ProjectConditions>> HokomProjectDefinitions;

	public static List<Project> BestProjectCards(List<Card> cards, Func<BalootProject, int> valueFunction = null, bool isHokom = false)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_0179: Expected O, but got I4
		//IL_0081: Expected O, but got I
		//IL_0099: Expected O, but got I
		//IL_00e8: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_027c: Expected O, but got I4
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01b9: Expected O, but got I
		//IL_01c1: Expected I, but got O
		//IL_01cf: Expected I, but got O
		//IL_02d4: Expected O, but got I
		//IL_0120: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_01f8: Expected O, but got I
		//IL_0212: Expected O, but got I4
		//IL_0227: Expected I, but got O
		//IL_0244: Expected O, but got I
		//IL_02b7: Expected O, but got I
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8A73]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		Func<BalootProject, int> func = default(Func<BalootProject, int>);
		object obj4;
		if (obj2 != null)
		{
			obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2048;
			bool flag = func == null;
			obj4 = obj3;
			if (!flag)
			{
				goto IL_0075;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2048;
			bool flag2 = func == null;
			object obj5 = !flag2;
			obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_0075;
			}
		}
		object obj6 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj7 = (nint)0 + (nint)2352;
		nint num = (nint)obj7;
		Func<System.Int32Enum, int> func2 = default(Func<System.Int32Enum, int>);
		func2..ctor((object)null, (IntPtr)obj7);
		object obj8 = (nint)0 + (nint)224;
		object obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v25+E4]");
		object obj10 = 0;
		bool flag4 = default(bool);
		bool flag3 = !flag4;
		object obj11 = !flag3;
		obj3 = obj4;
		Func<BalootProject, int> func3 = (Func<BalootProject, int>)(object)func2;
		nint num2 = unchecked((nint)null);
		object obj12 = null;
		object obj13 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v25+E4]");
		object obj14 = 0;
		object obj15 = obj8;
		Func<System.Int32Enum, int> func4 = func2;
		if (obj11 != null)
		{
			goto IL_0106;
		}
		goto IL_0262;
		IL_0106:
		bool flag5 = obj10 == null;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v25+B8]");
		object obj17 = (nint)0 + (nint)8;
		func4 = (Func<System.Int32Enum, int>)(object)func3;
		goto IL_02e1;
		IL_02e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39D8724");
		List<Project> result = default(List<Project>);
		return result;
		IL_0262:
		bool flag6 = obj14 == null;
		object obj18 = !flag6;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v5+B8]");
		obj17 = 0;
		obj8 = obj15;
		goto IL_02e1;
		IL_0075:
		obj8 = (nint)0 + (nint)224;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v25+E4]");
		obj10 = 0;
		bool flag7 = !flag4;
		func3 = func;
		IntPtr intPtr = default(IntPtr);
		num2 = intPtr;
		obj12 = func;
		num = (flag4 ? 1 : 0);
		obj13 = obj9;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v25+E4]");
		obj14 = 0;
		obj15 = obj8;
		func4 = (Func<System.Int32Enum, int>)(object)func;
		if (!flag7)
		{
			goto IL_0106;
		}
		goto IL_0262;
	}

	public static int BestProjectsValue(List<Card> cards, bool isHokom = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_008b: Expected O, but got I
		//IL_0097: Expected O, but got I
		//IL_00c1: Expected O, but got I4
		//IL_0057: Expected I, but got O
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2048;
		object obj2 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 296;
		object obj3 = (nint)0 + (nint)2352;
		object obj4 = (nint)0 + (nint)232;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		List<Project> list = BestProjectCards(cards, null, isHokom);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<System.Int32Enum, int> func = default(Func<System.Int32Enum, int>);
		func..ctor((object)null, (IntPtr)obj3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39D9118");
		int result = default(int);
		return result;
	}

	public static int ProjectPrecedence(List<Card> cards, BalootGame.BalootGameMode gameMode)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_04c5: Expected O, but got I
		//IL_04ef: Expected O, but got I4
		//IL_0036: Expected O, but got I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00c8: Expected O, but got I4
		//IL_050e: Expected O, but got I
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected O, but got Unknown
		//IL_052e: Expected O, but got I
		//IL_053a: Expected O, but got I
		//IL_054a: Expected O, but got I
		//IL_055a: Expected O, but got I
		//IL_057c: Expected O, but got I4
		//IL_0172: Expected I, but got O
		//IL_010f: Expected O, but got I4
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected O, but got Unknown
		//IL_05b4: Expected O, but got I
		//IL_05c5: Expected I, but got O
		//IL_05e3: Expected O, but got I
		//IL_0245: Expected O, but got I
		//IL_0255: Expected O, but got I
		//IL_0265: Expected O, but got I
		//IL_0287: Expected O, but got I4
		//IL_0298: Expected O, but got I4
		//IL_013f: Expected O, but got I
		//IL_01c1: Expected O, but got I
		//IL_01d1: Expected O, but got I
		//IL_01e1: Expected O, but got I
		//IL_0203: Expected O, but got I4
		//IL_020c: Expected O, but got I4
		//IL_03d8: Expected O, but got I
		//IL_03e6: Expected O, but got I4
		//IL_03f6: Expected O, but got I
		//IL_0406: Expected O, but got I
		//IL_0428: Expected O, but got I4
		//IL_02c8: Expected O, but got I4
		//IL_04b4: Expected I4, but got O
		//IL_0347: Expected O, but got I
		//IL_0355: Expected O, but got I4
		//IL_0365: Expected O, but got I
		//IL_0375: Expected O, but got I
		//IL_0397: Expected O, but got I4
		//IL_0611: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Expected O, but got Unknown
		//IL_062c: Expected O, but got I
		//IL_063d: Expected I, but got O
		//IL_065b: Expected O, but got I
		//IL_067e: Expected O, but got I4
		//IL_0468: Expected O, but got I4
		//IL_02f8: Expected O, but got I
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Expected O, but got Unknown
		//IL_06b5: Expected O, but got I
		//IL_06c6: Expected I, but got O
		//IL_06e4: Expected O, but got I
		//IL_0498: Expected O, but got I
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2048;
		object obj2 = (nint)0 + (nint)2088;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = gameMode - 2;
		bool isHokom = obj5 == null;
		List<Project> source = BestProjectCards(cards, null, isHokom);
		bool flag2 = Enumerable.Any((IEnumerable<ProjectsUtility<System.Int32Enum>.Project>)source);
		bool flag3 = !flag2;
		int result = (flag2 ? 1 : 0);
		object obj6;
		int num;
		object obj23;
		Func<ProjectsUtility<System.Int32Enum>.Project, IComparable> func3;
		object obj26;
		object obj22;
		object obj25;
		if (!flag3)
		{
			obj6 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2656;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj6;
			}
			object obj9 = (nint)0 + (nint)2840;
			object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 296;
			object obj11 = (nint)0 + (nint)2352;
			object obj12 = (nint)0 + (nint)680;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v9+B8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v34+8]");
			Func<ProjectsUtility<System.Int32Enum>.Project, System.Int32Enum> selector = (Func<ProjectsUtility<System.Int32Enum>.Project, System.Int32Enum>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v34+8]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v9+E4]");
				bool flag6 = (nint)0 == 0;
				object obj15 = !flag6;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj16 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v40+B8]");
					obj13 = 0;
				}
				object obj17 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3776;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj18 = (nint)0 + (nint)864;
				Func<ProjectsUtility<System.Int32Enum>.Project, System.Int32Enum> func = default(Func<ProjectsUtility<System.Int32Enum>.Project, System.Int32Enum>);
				func..ctor(obj13, (IntPtr)obj18);
				object obj19 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v39+B8]");
				object obj20 = (nint)0 + (nint)8;
				obj20 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				selector = func;
			}
			IEnumerable<System.Int32Enum> source2 = Enumerable.Select((IEnumerable<ProjectsUtility<System.Int32Enum>.Project>)source, selector);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<System.Int32Enum, int> func2 = default(Func<System.Int32Enum, int>);
			func2..ctor((object)null, (IntPtr)obj11);
			num = Enumerable.Sum(source2, func2);
			object obj21 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v36+E4]");
			if ((nint)0 != 0)
			{
				obj22 = (nint)0 + (nint)2872;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v36+B8]");
				obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v24+10]");
				func3 = (Func<ProjectsUtility<System.Int32Enum>.Project, IComparable>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v24+10]");
				bool flag7 = (nint)0 == 0;
				object obj24 = !flag7;
				obj25 = 0;
				if (obj24 == null)
				{
					obj26 = obj22;
					goto IL_02a6;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj21 = obj6;
				obj26 = (nint)0 + (nint)2872;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v36+B8]");
				obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v24+10]");
				func3 = (Func<ProjectsUtility<System.Int32Enum>.Project, IComparable>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v24+10]");
				bool flag8 = (nint)0 == 0;
				object obj27 = !flag8;
				obj22 = obj26;
				obj25 = 0;
				if (obj27 == null)
				{
					goto IL_02a6;
				}
			}
			goto IL_02fd;
		}
		goto IL_04fd;
		IL_049d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DCACC4");
		object obj28 = default(object);
		object obj29;
		result = (int)(obj28 + obj29);
		goto IL_04fd;
		IL_04fd:
		return result;
		IL_02a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v36+E4]");
		bool flag9 = (nint)0 == 0;
		object obj30 = !flag9;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj31 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v30+B8]");
			obj23 = 0;
		}
		object obj32 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3784;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj33 = (nint)0 + (nint)872;
		Func<ProjectsUtility<System.Int32Enum>.Project, object> func4 = default(Func<ProjectsUtility<System.Int32Enum>.Project, object>);
		func4..ctor(obj23, (IntPtr)obj33);
		object obj34 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v29+B8]");
		object obj35 = (nint)0 + (nint)16;
		obj35 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj22 = obj26;
		obj25 = 0;
		func3 = (Func<ProjectsUtility<System.Int32Enum>.Project, IComparable>)func4;
		goto IL_02fd;
		IL_02fd:
		ProjectsUtility<System.Int32Enum>.Project project = ArraysExtensions.MaxBy((IEnumerable<ProjectsUtility<System.Int32Enum>.Project>)source, func3);
		object obj36 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v26+E4]");
		object obj38;
		object obj40;
		object obj41;
		object obj37;
		Func<object, System.Int32Enum> func5;
		if ((nint)0 != 0)
		{
			obj37 = (nint)0 + (nint)1920;
			obj29 = num * 100;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v26+B8]");
			obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v13+18]");
			func5 = (Func<object, System.Int32Enum>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v13+18]");
			bool flag10 = (nint)0 == 0;
			object obj39 = !flag10;
			if (obj39 == null)
			{
				obj40 = obj37;
				obj41 = obj29;
				goto IL_0446;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj36 = obj6;
			obj40 = (nint)0 + (nint)1920;
			obj41 = num * 100;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v26+B8]");
			obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v13+18]");
			func5 = (Func<object, System.Int32Enum>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v13+18]");
			bool flag11 = (nint)0 == 0;
			object obj42 = !flag11;
			obj37 = obj40;
			obj29 = obj41;
			if (obj42 == null)
			{
				goto IL_0446;
			}
		}
		goto IL_049d;
		IL_0446:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v26+E4]");
		bool flag12 = (nint)0 == 0;
		object obj43 = !flag12;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj44 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v19+B8]");
			obj38 = 0;
		}
		object obj45 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj46 = (nint)0 + (nint)880;
		Func<object, System.Int32Enum> func6 = default(Func<object, System.Int32Enum>);
		func6..ctor(obj38, (IntPtr)obj46);
		object obj47 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v18+B8]");
		object obj48 = (nint)0 + (nint)24;
		obj48 = func6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj37 = obj40;
		obj29 = obj41;
		func5 = func6;
		goto IL_049d;
	}

	public BalootProjectUtility()
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39DB20C");
	}

	unsafe static BalootProjectUtility()
	{
		//IL_0008: Expected O, but got Ref
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_06af: Expected O, but got Ref
		//IL_06bc: Expected native int or pointer, but got O
		//IL_003f: Expected O, but got I
		//IL_0056: Expected O, but got I
		//IL_006b: Expected O, but got I
		//IL_0099: Expected O, but got I4
		//IL_012e: Expected O, but got Ref
		//IL_00bd: Expected O, but got I
		//IL_00d8: Expected O, but got I
		//IL_06e6: Expected O, but got Ref
		//IL_06f3: Expected native int or pointer, but got O
		//IL_070f: Expected O, but got I
		//IL_0724: Expected O, but got I
		//IL_018b: Expected O, but got I4
		//IL_0220: Expected O, but got Ref
		//IL_01af: Expected O, but got I
		//IL_01ca: Expected O, but got I
		//IL_0749: Expected O, but got Ref
		//IL_0756: Expected native int or pointer, but got O
		//IL_0772: Expected O, but got I
		//IL_0787: Expected O, but got I
		//IL_027d: Expected O, but got I4
		//IL_0312: Expected O, but got Ref
		//IL_02a1: Expected O, but got I
		//IL_02bc: Expected O, but got I
		//IL_07ac: Expected O, but got Ref
		//IL_07b9: Expected native int or pointer, but got O
		//IL_07d5: Expected O, but got I
		//IL_07ea: Expected O, but got I
		//IL_036f: Expected O, but got I4
		//IL_0404: Expected O, but got Ref
		//IL_0393: Expected O, but got I
		//IL_03ae: Expected O, but got I
		//IL_080f: Expected O, but got Ref
		//IL_081c: Expected native int or pointer, but got O
		//IL_083f: Expected O, but got I
		//IL_0854: Expected O, but got I
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected O, but got Unknown
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected O, but got Unknown
		//IL_0489: Expected O, but got I4
		//IL_0526: Expected O, but got I
		//IL_0536: Expected O, but got I
		//IL_0546: Expected O, but got I
		//IL_0554: Expected O, but got Ref
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Expected O, but got Unknown
		//IL_0586: Expected O, but got I
		//IL_0592: Expected O, but got I
		//IL_059e: Expected O, but got I
		//IL_05d0: Expected O, but got I
		//IL_05fa: Expected O, but got I4
		//IL_04ad: Expected O, but got I
		//IL_04c8: Expected O, but got I
		//IL_0869: Expected O, but got I
		//IL_0884: Expected I, but got O
		//IL_0647: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj3 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3664;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<KeyValuePair<System.Int32Enum, ProjectConditions>> list = default(List<KeyValuePair<System.Int32Enum, ProjectConditions>>);
		list..ctor();
		ProjectConditions value = new ProjectConditions(ProjectType.SuitsGroup, Rank.ACE, 4);
		object obj4 = (nint)0 + (nint)1960;
		_ = 0;
		_ = 0;
		_ = 0;
		KeyValuePair<System.Int32Enum, ProjectConditions> keyValuePair = (KeyValuePair<System.Int32Enum, ProjectConditions>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
		*(KeyValuePair<System.Int32Enum, ProjectConditions>*)(nint)keyValuePair = new KeyValuePair<System.Int32Enum, ProjectConditions>((System.Int32Enum)3, value);
		object obj5 = (nint)0 + (nint)2624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.Int32Enum, ProjectConditions>>)+1C]");
		object obj6 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.Int32Enum, ProjectConditions>>)+10]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.Int32Enum, ProjectConditions>>)+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X9_v4+18]");
		bool flag = num < 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.Int32Enum, ProjectConditions>>)+18]");
			object obj9 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.Int32Enum, ProjectConditions>>)+18]");
			object obj10 = (nint)0 * (nint)20;
			object obj11 = obj7 + obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-50]");
			_ = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-50]");
			_ = 0;
			KeyValuePair<System.Int32Enum, ProjectConditions> item = (KeyValuePair<System.Int32Enum, ProjectConditions>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
			list.AddWithResize(item);
		}
		ProjectConditions value2 = new ProjectConditions(ProjectType.RankSequence, Rank.ACE, Rank.SEVEN, 5);
		_ = 0;
		_ = 0;
		_ = 0;
		KeyValuePair<System.Int32Enum, ProjectConditions> keyValuePair2 = (KeyValuePair<System.Int32Enum, ProjectConditions>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
		*(KeyValuePair<System.Int32Enum, ProjectConditions>*)(nint)keyValuePair2 = new KeyValuePair<System.Int32Enum, ProjectConditions>((System.Int32Enum)2, value2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.Int32Enum, ProjectConditions>>)+1C]");
		object obj12 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.Int32Enum, ProjectConditions>>)+10]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.Int32Enum, ProjectConditions>>)+18]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X9_v8+18]");
		bool flag2 = num2 < 0;
		object obj14 = !flag2;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.Int32Enum, ProjectConditions>>)+18]");
			object obj15 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.Int32Enum, ProjectConditions>>)+18]");
			object obj16 = (nint)0 * (nint)20;
			object obj17 = obj13 + obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-50]");
			_ = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-50]");
			_ = 0;
			KeyValuePair<System.Int32Enum, ProjectConditions> item2 = (KeyValuePair<System.Int32Enum, ProjectConditions>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
			list.AddWithResize(item2);
		}
		ProjectConditions value3 = new ProjectConditions(ProjectType.SuitsGroup, Rank.ACE, Rank.TEN, 4);
		_ = 0;
		_ = 0;
		_ = 0;
		KeyValuePair<System.Int32Enum, ProjectConditions> keyValuePair3 = (KeyValuePair<System.Int32Enum, ProjectConditions>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
		*(KeyValuePair<System.Int32Enum, ProjectConditions>*)(nint)keyValuePair3 = new KeyValuePair<System.Int32Enum, ProjectConditions>((System.Int32Enum)2, value3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.Int32Enum, ProjectConditions>>)+1C]");
		object obj18 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.Int32Enum, ProjectConditions>>)+10]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.Int32Enum, ProjectConditions>>)+18]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X9_v12+18]");
		bool flag3 = num3 < 0;
		object obj20 = !flag3;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.Int32Enum, ProjectConditions>>)+18]");
			object obj21 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.Int32Enum, ProjectConditions>>)+18]");
			object obj22 = (nint)0 * (nint)20;
			object obj23 = obj19 + obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-50]");
			_ = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-50]");
			_ = 0;
			KeyValuePair<System.Int32Enum, ProjectConditions> item3 = (KeyValuePair<System.Int32Enum, ProjectConditions>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
			list.AddWithResize(item3);
		}
		ProjectConditions value4 = new ProjectConditions(ProjectType.RankSequence, Rank.ACE, Rank.SEVEN, 4);
		_ = 0;
		_ = 0;
		_ = 0;
		KeyValuePair<System.Int32Enum, ProjectConditions> keyValuePair4 = (KeyValuePair<System.Int32Enum, ProjectConditions>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
		*(KeyValuePair<System.Int32Enum, ProjectConditions>*)(nint)keyValuePair4 = new KeyValuePair<System.Int32Enum, ProjectConditions>((System.Int32Enum)1, value4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.Int32Enum, ProjectConditions>>)+1C]");
		object obj24 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.Int32Enum, ProjectConditions>>)+10]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.Int32Enum, ProjectConditions>>)+18]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X9_v16+18]");
		bool flag4 = num4 < 0;
		object obj26 = !flag4;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.Int32Enum, ProjectConditions>>)+18]");
			object obj27 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.Int32Enum, ProjectConditions>>)+18]");
			object obj28 = (nint)0 * (nint)20;
			object obj29 = obj25 + obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-50]");
			_ = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-50]");
			_ = 0;
			KeyValuePair<System.Int32Enum, ProjectConditions> item4 = (KeyValuePair<System.Int32Enum, ProjectConditions>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
			list.AddWithResize(item4);
		}
		ProjectConditions projectConditions = new ProjectConditions(ProjectType.RankSequence, Rank.ACE, Rank.SEVEN, 3);
		_ = 0;
		_ = 0;
		_ = 0;
		KeyValuePair<System.Int32Enum, ProjectConditions> keyValuePair5 = (KeyValuePair<System.Int32Enum, ProjectConditions>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
		*(KeyValuePair<System.Int32Enum, ProjectConditions>*)(nint)keyValuePair5 = new KeyValuePair<System.Int32Enum, ProjectConditions>((System.Int32Enum)0, projectConditions);
		object obj30 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.Int32Enum, ProjectConditions>>)+1C]");
		object obj31 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.Int32Enum, ProjectConditions>>)+10]");
		object obj32 = 0;
		object obj33 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2048;
		object obj34 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2656;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.Int32Enum, ProjectConditions>>)+18]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X9_v20+18]");
		bool flag5 = num5 < 0;
		object obj35 = !flag5;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.Int32Enum, ProjectConditions>>)+18]");
			object obj36 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.Int32Enum, ProjectConditions>>)+18]");
			object obj37 = (nint)0 * (nint)20;
			object obj38 = obj32 + obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-50]");
			_ = 0;
			ProjectConditions projectConditions2 = projectConditions;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-50]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v25+20]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v33+C0]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v34+70]");
			ProjectConditions projectConditions2 = (ProjectConditions)0;
			KeyValuePair<System.Int32Enum, ProjectConditions> item5 = (KeyValuePair<System.Int32Enum, ProjectConditions>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
			list.AddWithResize(item5);
		}
		object obj41 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3448;
		object obj42 = (nint)0 + (nint)856;
		object obj43 = (nint)0 + (nint)3144;
		object obj44 = (nint)0 + (nint)1752;
		object obj45 = obj33;
		object obj46 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj47 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v28+B8]");
		object source = 0;
		object obj48 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X0_v29+E4]");
		bool flag6 = (nint)0 == 0;
		object obj49 = !flag6;
		if (obj49 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj48 = obj34;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X0_v29+B8]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<KeyValuePair<System.Int32Enum, ProjectConditions>, bool> func = default(Func<KeyValuePair<System.Int32Enum, ProjectConditions>, bool>);
		func..ctor(obj50, (IntPtr)obj42);
		IEnumerable<KeyValuePair<System.Int32Enum, ProjectConditions>> enumerable = Enumerable.Where((IEnumerable<KeyValuePair<System.Int32Enum, ProjectConditions>>)source, func);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DE9074");
		object obj51 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v32+B8]");
		object obj52 = (nint)0 + (nint)8;
		object obj53 = default(object);
		obj52 = obj53;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
