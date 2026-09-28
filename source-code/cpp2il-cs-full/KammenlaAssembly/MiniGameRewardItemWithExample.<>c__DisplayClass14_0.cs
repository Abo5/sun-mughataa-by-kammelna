using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.UI;

public class MiniGameRewardItemWithExample : MiniGameRewardItem
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Suit, Suit> <>9__15_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3744;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal Suit <GenerateSuitsGroup>b__15_0(Suit suit)
		{
			return suit;
		}
	}

	private sealed class <>c__DisplayClass14_0
	{
		public MiniGameRewardItemWithExample <>4__this;

		public Suit suit;

		internal bool <GenerateRankSequence>b__0(Rank rank)
		{
			//IL_0192: Expected I4, but got O
			//IL_006d: Expected O, but got I
			//IL_00a0: Expected O, but got I
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Expected O, but got Unknown
			//IL_00e2: Expected O, but got I4
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Expected O, but got Unknown
			//IL_011b: Expected O, but got I
			//IL_013f: Expected O, but got I
			//IL_0147: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Expected O, but got Unknown
			MiniGameRewardItemWithExample miniGameRewardItemWithExample = <>4__this;
			if ((object)<>4__this != null)
			{
				MiniGameRewardDescription rewardDescription = miniGameRewardItemWithExample.RewardDescription;
				if (miniGameRewardItemWithExample.RewardDescription != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X8_v3 (MiniGameRewardDescription)+20]");
					object obj = (nint)rank - (nint)0;
					bool flag = (nint)obj < 0;
					bool flag2 = obj == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X8_v3 (MiniGameRewardDescription)+20]");
					object obj2 = (nint)rank ^ (nint)0;
					object obj3 = rank ^ obj;
					object obj4 = obj2 & obj3;
					bool flag3 = (nint)obj4 < 0;
					bool flag4 = flag == flag3;
					object obj5 = !flag4;
					object obj6 = obj5 | flag2;
					object obj7 = ~obj6;
					bool flag5;
					bool flag6;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X8_v3 (MiniGameRewardDescription)+24]");
						object obj8 = (nint)rank - (nint)0;
						flag5 = (nint)obj8 < 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X8_v3 (MiniGameRewardDescription)+24]");
						object obj9 = (nint)rank ^ (nint)0;
						object obj10 = rank ^ obj8;
						object obj11 = obj9 & obj10;
						flag6 = (nint)obj11 < 0;
					}
					else
					{
						flag6 = false;
						flag5 = true;
					}
					return flag5 == flag6;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal Card <GenerateRankSequence>b__1(Rank rank)
		{
			return RankExtensions.Of(rank, suit);
		}
	}

	private sealed class <>c__DisplayClass15_0
	{
		public MiniGameRewardItemWithExample <>4__this;

		public Rank rank;

		internal bool <GenerateSuitsGroup>b__1(Rank r)
		{
			//IL_0192: Expected I4, but got O
			//IL_006d: Expected O, but got I
			//IL_00a0: Expected O, but got I
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Expected O, but got Unknown
			//IL_00e2: Expected O, but got I4
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Expected O, but got Unknown
			//IL_011b: Expected O, but got I
			//IL_013f: Expected O, but got I
			//IL_0147: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Expected O, but got Unknown
			MiniGameRewardItemWithExample miniGameRewardItemWithExample = <>4__this;
			if ((object)<>4__this != null)
			{
				MiniGameRewardDescription rewardDescription = miniGameRewardItemWithExample.RewardDescription;
				if (miniGameRewardItemWithExample.RewardDescription != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X8_v3 (MiniGameRewardDescription)+20]");
					object obj = (nint)r - (nint)0;
					bool flag = (nint)obj < 0;
					bool flag2 = obj == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X8_v3 (MiniGameRewardDescription)+20]");
					object obj2 = (nint)r ^ (nint)0;
					object obj3 = r ^ obj;
					object obj4 = obj2 & obj3;
					bool flag3 = (nint)obj4 < 0;
					bool flag4 = flag == flag3;
					object obj5 = !flag4;
					object obj6 = obj5 | flag2;
					object obj7 = ~obj6;
					bool flag5;
					bool flag6;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X8_v3 (MiniGameRewardDescription)+24]");
						object obj8 = (nint)r - (nint)0;
						flag5 = (nint)obj8 < 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X8_v3 (MiniGameRewardDescription)+24]");
						object obj9 = (nint)r ^ (nint)0;
						object obj10 = r ^ obj8;
						object obj11 = obj9 & obj10;
						flag6 = (nint)obj11 < 0;
					}
					else
					{
						flag6 = false;
						flag5 = true;
					}
					return flag5 == flag6;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal Card <GenerateSuitsGroup>b__2(Suit suit)
		{
			return RankExtensions.Of(rank, suit);
		}
	}

	private TextMeshProUGUI descriptionText;

	private GameObject cardTemplate;

	private RectTransform examplesParent;

	private CardsSprites cardsSprites;

	private readonly List<Card> _exampleCards;

	private readonly List<Image> _cardImages;

	private ProjectConditions Conditions
	{
		get
		{
			MiniGameRewardDescription rewardDescription = RewardDescription;
			if (RewardDescription != null)
			{
				return rewardDescription.<Conditions>k__BackingField;
			}
			return (ProjectConditions)new NullReferenceException();
		}
	}

	public override void Setup(MiniGameRewardDescription rewardDescription)
	{
		base.Setup(rewardDescription);
		SetupDescriptionText();
		SetupExample();
	}

	private unsafe void SetupDescriptionText()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0052: Expected O, but got I4
		//IL_0085: Expected I8, but got I
		//IL_00a6: Expected O, but got Ref
		//IL_037e: Expected O, but got Ref
		//IL_03ac: Expected O, but got I4
		//IL_0105: Expected O, but got Ref
		//IL_0133: Expected O, but got I4
		//IL_03d3: Expected O, but got Ref
		//IL_06fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0703: Expected O, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected O, but got Unknown
		//IL_0427: Expected O, but got I4
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_01a9: Expected O, but got I8
		//IL_01d2: Expected O, but got I
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_0214: Expected O, but got I4
		//IL_022a: Expected O, but got I
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected O, but got Unknown
		//IL_04f7: Expected O, but got I8
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected O, but got Unknown
		//IL_0297: Expected O, but got I8
		//IL_0520: Expected O, but got I
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Expected O, but got Unknown
		//IL_0562: Expected O, but got I4
		//IL_0578: Expected O, but got I
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_0305: Expected O, but got I4
		//IL_031b: Expected O, but got I
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected O, but got Unknown
		//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Expected O, but got Unknown
		//IL_05e5: Expected O, but got I8
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected O, but got Unknown
		//IL_060e: Expected O, but got I
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_061c: Expected O, but got Unknown
		//IL_0650: Expected O, but got I4
		//IL_0666: Expected O, but got I
		//IL_0686: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Expected O, but got Unknown
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Expected O, but got Unknown
		MiniGameRewardDescription rewardDescription = RewardDescription;
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object input = "utf-32" + 3896;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3 (MiniGameRewardDescription)+24]");
		long quantity = (nint)0 >> 32;
		string text = LocalizationUtil.Localize((string)input, quantity);
		object obj4 = default(object);
		string input2 = ((Enum)(&obj4)).ToString();
		string text2 = LocalizationUtil.Localize(input2);
		MiniGameRewardDescription rewardDescription2 = RewardDescription;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v8 (MiniGameRewardDescription)+20]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v8 (MiniGameRewardDescription)+24]");
		string[] array = default(string[]);
		if (num == 0)
		{
			string input3 = ((Enum)(&obj4)).ToString();
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v32+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text3 = LocalizationUtil.Localize(input3);
			object obj7 = typeof(SqlSingle[]) + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			if (array.Length != 0)
			{
				object obj8 = array + 32;
				obj8 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X24_v8-8]");
				object obj9 = 0 & 0xFFFFFFFEL;
				if (obj9 != null)
				{
					object obj10 = (nint)0 + (nint)3312;
					object obj11 = array + 40;
					obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X21_v12-10]");
					bool flag3 = (nint)0 < (nint)2;
					object obj12 = !flag3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X21_v12-10]");
					object obj13 = -2;
					bool flag4 = obj13 == null;
					object obj14 = ~obj12;
					object obj15 = obj14 | flag4;
					if (obj15 == null)
					{
						object obj16 = array + 48;
						obj16 = text3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X21_v14-18]");
						object obj17 = 0 & 0xFFFFFFFCL;
						if (obj17 != null)
						{
							object obj18 = "&action=sign-up" + 2704;
							object obj19 = array + 56;
							obj19 = obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X21_v16-20]");
							bool flag5 = (nint)0 < (nint)4;
							object obj20 = !flag5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X21_v16-20]");
							object obj21 = -4;
							bool flag6 = obj21 == null;
							object obj22 = ~obj20;
							object obj23 = obj22 | flag6;
							if (obj23 == null)
							{
								object obj24 = array + 64;
								obj24 = text2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								goto IL_0712;
							}
						}
					}
				}
			}
		}
		else
		{
			string input4 = ((Enum)(&obj4)).ToString();
			object obj25 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v12+E4]");
			bool flag7 = (nint)0 == 0;
			object obj26 = !flag7;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string arg = LocalizationUtil.Localize(input4);
			object obj27 = default(object);
			string input5 = ((Enum)(&obj27)).ToString();
			string arg2 = LocalizationUtil.Localize(input5);
			object obj28 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
			object obj29 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v23+E4]");
			bool flag8 = (nint)0 == 0;
			object obj30 = !flag8;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object key = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 144;
			string text4 = LocalizationText.GetText((string)key);
			string text5 = string.Format(text4, arg, arg2);
			object obj31 = typeof(SqlSingle[]) + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			if (array.Length != 0)
			{
				object obj32 = array + 32;
				obj32 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X24_v6-8]");
				object obj33 = 0 & 0xFFFFFFFEL;
				if (obj33 != null)
				{
					object obj34 = (nint)0 + (nint)3072;
					object obj35 = array + 40;
					obj35 = obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X21_v8-10]");
					bool flag9 = (nint)0 < (nint)2;
					object obj36 = !flag9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X21_v8-10]");
					object obj37 = -2;
					bool flag10 = obj37 == null;
					object obj38 = ~obj36;
					object obj39 = obj38 | flag10;
					if (obj39 == null)
					{
						object obj40 = array + 48;
						obj40 = text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X21_v10-18]");
						object obj41 = 0 & 0xFFFFFFFCL;
						if (obj41 != null)
						{
							object obj42 = (nint)0 + (nint)2336;
							object obj43 = array + 56;
							obj43 = obj42;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X20_v10-20]");
							bool flag11 = (nint)0 < (nint)4;
							object obj44 = !flag11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X20_v10-20]");
							object obj45 = -4;
							bool flag12 = obj45 == null;
							object obj46 = ~obj44;
							object obj47 = obj46 | flag12;
							if (obj47 == null)
							{
								object obj48 = array + 64;
								obj48 = text5;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								goto IL_0712;
							}
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_0712:
		string text6 = string.Concat(array);
		TextMeshProExtensions.FixArabic(descriptionText, text6);
	}

	private void SetupExample()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0838: Expected O, but got I4
		//IL_0841: Expected O, but got I4
		//IL_0034: Expected O, but got I4
		//IL_003d: Expected O, but got I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_00a6: Expected O, but got I4
		//IL_079d: Expected O, but got I
		//IL_00e5: Expected O, but got I4
		//IL_0100: Expected I4, but got O
		//IL_0174: Expected O, but got I4
		//IL_014f: Expected O, but got I4
		//IL_01ba: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_01e7: Expected O, but got I
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_0207: Expected O, but got I
		//IL_0213: Expected O, but got I
		//IL_021f: Expected O, but got I
		//IL_022b: Expected O, but got I
		//IL_063e: Expected O, but got I
		//IL_0669: Expected O, but got I4
		//IL_02eb: Expected O, but got I4
		//IL_073d: Expected O, but got I4
		//IL_0447: Expected O, but got I4
		//IL_04d2: Expected O, but got I
		//IL_04e2: Expected O, but got I
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected O, but got Unknown
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected O, but got Unknown
		//IL_05bb: Expected O, but got I4
		//IL_0256: Expected O, but got I
		//IL_0266: Expected O, but got I
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Expected O, but got Unknown
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected O, but got Unknown
		GameObject[] array = (GameObject[])(typeof(TypeConverter<ushort, char>) + 2568);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		GameObject[] array2 = default(GameObject[]);
		bool flag = array2 == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		GameObject[] array3 = (GameObject[])1;
		List<object>.Enumerator enumerator2;
		if (!flag)
		{
			bool flag2 = array2.Length == 0;
			enumerator2 = (List<object>.Enumerator)0;
			array3 = (GameObject[])1;
			if (flag2)
			{
				goto IL_0742;
			}
			object obj = array2 + 32;
			obj = cardTemplate;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			UIExtensions.DestroyAllChildren(examplesParent, array2);
			List<Image> cardImages = _cardImages;
			bool flag3 = _cardImages == null;
			enumerator = (List<object>.Enumerator)0;
			int num = 0;
			array3 = array2;
			if (!flag3)
			{
				num = cardImages._size;
				object[] array4 = (object[])(cardImages._version + 1);
				cardImages._size = 0;
				cardImages._version = (int)array4;
				bool flag4 = cardImages._size < 1;
				array3 = array2;
				if (!flag4)
				{
					Array.Clear(cardImages._items, 0, cardImages._size);
					object obj2 = 0;
					array3 = null;
				}
				bool flag5 = (object)cardTemplate == null;
				enumerator = (List<object>.Enumerator)0;
				if (!flag5)
				{
					cardTemplate.SetActive(value: true);
					List<Card> list = GenerateExampleCards();
					bool flag6 = list == null;
					enumerator = (List<object>.Enumerator)0;
					num = 0;
					array3 = (GameObject[])1;
					if (!flag6)
					{
						object obj3 = (nint)0 + (nint)3800;
						object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
						object obj5 = (nint)0 + (nint)920;
						object obj6 = (nint)0 + (nint)1528;
						object obj7 = (nint)0 + (nint)2648;
						object obj8 = (nint)0 + (nint)816;
						List<object>.Enumerator enumerator3 = ((List<object>)(object)list).GetEnumerator();
						num = 0;
						object obj11 = default(object);
						GameObject[] array5 = default(GameObject[]);
						Image image = default(Image);
						List<object>.Enumerator enumerator5;
						List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
						while (enumerator.MoveNext())
						{
							object obj9 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v34+E4]");
							bool flag7 = (nint)0 == 0;
							object obj10 = !flag7;
							if (obj10 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj2 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
							if (obj11 != null)
							{
								array3 = (GameObject[])obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E331E4");
								if ((object)cardsSprites != null)
								{
									Sprite sprite = cardsSprites.GetFor((Card)(object)array5);
									if ((object)image != null)
									{
										image.sprite = sprite;
										List<object> exampleCards = (List<object>)(object)_exampleCards;
										if (_exampleCards != null)
										{
											object obj12 = obj7;
											int version = exampleCards._version + 1;
											exampleCards._version = version;
											array4 = exampleCards._items;
											if (exampleCards._items != null)
											{
												bool flag8 = exampleCards._size < array4.Length;
												object obj13 = !flag8;
												if (obj13 == null)
												{
													int size = exampleCards._size + 1;
													exampleCards._size = size;
													object obj14 = exampleCards._items + exampleCards._size;
													object obj15 = obj14 + 32;
													obj15 = array5;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													num = 0;
													array3 = array5;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v22+20]");
													object obj16 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v29+C0]");
													object obj17 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v30+70]");
													num = 0;
													((List<object>)(object)_exampleCards).AddWithResize((object)array5);
													array3 = array5;
												}
												List<object> cardImages2 = (List<object>)(object)_cardImages;
												if (_cardImages != null)
												{
													object obj18 = obj8;
													int version2 = cardImages2._version + 1;
													cardImages2._version = version2;
													object[] items = cardImages2._items;
													bool flag9 = cardImages2._items == null;
													array4 = cardImages2._items;
													if (!flag9)
													{
														bool flag10 = cardImages2._size < items.Length;
														object obj19 = !flag10;
														if (obj19 != null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v25+20]");
															object obj20 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v27+C0]");
															object obj21 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v28+70]");
															num = 0;
															((List<object>)(object)_cardImages).AddWithResize((object)image);
															array4 = cardImages2._items;
														}
														else
														{
															int size2 = cardImages2._size + 1;
															cardImages2._size = size2;
															object obj22 = cardImages2._items + cardImages2._size;
															object obj23 = obj22 + 32;
															obj23 = image;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
															array4 = cardImages2._items;
														}
														continue;
													}
												}
												NullReferenceException ex = new NullReferenceException();
												goto IL_0722;
											}
										}
										NullReferenceException ex2 = new NullReferenceException();
										num = 0;
										array3 = (GameObject[])(object)sprite;
									}
									else
									{
										NullReferenceException ex3 = new NullReferenceException();
										num = 0;
										array3 = (GameObject[])(object)sprite;
									}
								}
								else
								{
									NullReferenceException ex4 = new NullReferenceException();
									num = 0;
								}
							}
							else
							{
								NullReferenceException ex5 = new NullReferenceException();
								num = 0;
								array3 = (GameObject[])(object)examplesParent;
							}
							goto IL_0722;
							IL_0722:
							enumerator = enumerator4;
							enumerator5 = enumerator4;
							enumerator4 = (List<object>.Enumerator)0;
							goto IL_084f;
						}
						object obj24 = (nint)0 + (nint)3792;
						array3 = (GameObject[])obj24;
						enumerator.Dispose();
						enumerator = enumerator4;
						enumerator5 = enumerator4;
						enumerator4 = (List<object>.Enumerator)0;
						goto IL_066e;
					}
				}
			}
		}
		goto IL_084f;
		IL_0742:
		IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
		bool flag11 = (nint)array3 != 1;
		OutOfMemoryException ex7 = (OutOfMemoryException)(object)ex6;
		if (!flag11)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj25 = (nint)0 + (nint)3792;
			array3 = (GameObject[])obj25;
			enumerator2.Dispose();
			object obj26 = default(object);
			bool flag12 = obj26 == null;
			enumerator = enumerator2;
			List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj26;
			if (flag12)
			{
				goto IL_066e;
			}
			ex7 = new OutOfMemoryException();
			enumerator4 = (List<object>.Enumerator)obj26;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2237EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_066e:
		if ((object)cardTemplate != null)
		{
			cardTemplate.SetActive(value: false);
			return;
		}
		goto IL_084f;
		IL_084f:
		NullReferenceException ex8 = new NullReferenceException();
		enumerator2 = enumerator;
		goto IL_0742;
	}

	public void UpdateExample()
	{
		//IL_0134: Expected O, but got I4
		List<Card> differentExample = GetDifferentExample(_exampleCards);
		List<object> exampleCards = (List<object>)(object)_exampleCards;
		int version = exampleCards._version + 1;
		exampleCards._size = 0;
		exampleCards._version = version;
		if (exampleCards._size >= 1)
		{
			Array.Clear(exampleCards._items, 0, exampleCards._size);
			exampleCards = (List<object>)(object)_exampleCards;
		}
		exampleCards.AddRange(differentExample);
		List<object> cardImages = (List<object>)(object)_cardImages;
		int num = 0;
		while (num < cardImages._size)
		{
			object obj = cardImages.get_Item(num);
			object card = ((List<object>)(object)_exampleCards).get_Item(num);
			Sprite sprite = cardsSprites.GetFor((Card)card);
			((Image)obj).sprite = sprite;
			num++;
			cardImages = (List<object>)(object)_cardImages;
			bool flag = _cardImages == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				throw new NullReferenceException();
			}
		}
	}

	private List<Card> GetDifferentExample(List<Card> oldExample)
	{
		//IL_001f: Expected O, but got I8
		//IL_0117: Expected O, but got I4
		//IL_0061: Expected O, but got I
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0168: Expected O, but got I4
		MiniGameRewardDescription rewardDescription = RewardDescription;
		if (RewardDescription != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3 (MiniGameRewardDescription)+24]");
			object obj = 0 & -4294967296L;
			bool flag;
			if ((nint)rewardDescription.<Conditions>k__BackingField == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3 (MiniGameRewardDescription)+20]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3 (MiniGameRewardDescription)+24]");
				object obj2 = num - 0;
				flag = obj2 == null;
			}
			else
			{
				flag = false;
			}
			object obj3 = !flag;
			bool flag2;
			if (obj3 == null)
			{
				object obj4 = obj - 17179869184L;
				flag2 = obj4 == null;
			}
			else
			{
				flag2 = false;
			}
			List<Card> list2 = default(List<Card>);
			if (!flag2)
			{
				List<Card> list;
				object obj5;
				do
				{
					list = GenerateExampleCards();
					bool flag3 = Enumerable.SequenceEqual((IEnumerable<object>)list, (IEnumerable<object>)list2);
					bool flag4 = !flag3;
					obj5 = !flag4;
				}
				while (obj5 != null);
				return list;
			}
			return (List<Card>)(object)Enumerable.ToList((IEnumerable<object>)list2);
		}
		return (List<Card>)(object)new NullReferenceException();
	}

	private List<Card> GenerateExampleCards()
	{
		//IL_0050: Expected O, but got I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_00be: Expected O, but got I
		MiniGameRewardDescription rewardDescription = RewardDescription;
		if ((nint)rewardDescription.<Conditions>k__BackingField != 1)
		{
			bool flag = (object)rewardDescription.<Conditions>k__BackingField == null;
			object obj = !flag;
			if (obj == null)
			{
				return GenerateRankSequence();
			}
			object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
			ex..ctor();
			object obj3 = (nint)0 + (nint)2784;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			return (List<Card>)(object)new OutOfMemoryException();
		}
		return GenerateSuitsGroup();
	}

	private List<Card> GenerateRankSequence()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0026: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00c2: Expected O, but got I
		//IL_00df: Expected O, but got I
		//IL_00ee: Expected O, but got I4
		//IL_00fe: Expected O, but got I
		//IL_0120: Expected O, but got I4
		//IL_0149: Expected O, but got I
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_0169: Expected O, but got I
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_019d: Expected O, but got I
		//IL_01bf: Expected O, but got I4
		//IL_01ed: Expected I, but got O
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected I4, but got Unknown
		//IL_026e: Expected O, but got I
		//IL_027a: Expected O, but got I
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_029a: Expected O, but got I
		//IL_02e2: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3752;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = (nint)0 + (nint)2936;
			object obj4 = obj2 + 16;
			obj4 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			IEnumerable<Suit> all = SuitMethods.GetAll();
			List<System.Int32Enum> array = Enumerable.ToList((IEnumerable<System.Int32Enum>)all);
			System.Int32Enum int32Enum = ArraysExtensions.Random(array);
			MiniGameRewardDescription rewardDescription = RewardDescription;
			if (RewardDescription != null)
			{
				object handle = typeof(IAsyncEnumerable<>) + 2832;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v4 (MiniGameRewardDescription)+24]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v4 (MiniGameRewardDescription)+24]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v5+28]");
				object obj6 = num + 0;
				object obj7 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X28_v3+E0]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v12+E4]");
				bool flag = (nint)0 == 0;
				object obj9 = !flag;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj10 = (nint)0 + (nint)3104;
				object obj11 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3040;
				object obj12 = (nint)0 + (nint)1880;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v4 (MiniGameRewardDescription)+20]");
				object obj13 = 0 - obj6;
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X28_v3+98]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v7+E4]");
				bool flag2 = (nint)0 == 0;
				object obj15 = !flag2;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Array values = Enum.GetValues(typeFromHandle);
				IEnumerable<System.Int32Enum> source = Enumerable.Cast<System.Int32Enum>(values);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Func<System.Int32Enum, bool> func = default(Func<System.Int32Enum, bool>);
				func..ctor(obj2, (IntPtr)obj12);
				IEnumerable<System.Int32Enum> source2 = Enumerable.Where(source, func);
				int maxExclusive = obj13 + 2;
				int count = UnityEngine.Random.Range(0, maxExclusive);
				IEnumerable<System.Int32Enum> source3 = Enumerable.Skip(source2, count);
				MiniGameRewardDescription rewardDescription2 = RewardDescription;
				if (RewardDescription != null)
				{
					object obj16 = (nint)0 + (nint)896;
					object obj17 = (nint)0 + (nint)2600;
					object obj18 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3048;
					object obj19 = (nint)0 + (nint)1888;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v8 (MiniGameRewardDescription)+28]");
					IEnumerable<System.Int32Enum> source4 = Enumerable.Take(source3, 0);
					List<System.Int32Enum> source5 = Enumerable.ToList(source4);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Func<System.Int32Enum, object> func2 = default(Func<System.Int32Enum, object>);
					func2..ctor(obj2, (IntPtr)obj19);
					IEnumerable<object> source6 = Enumerable.Select(source5, func2);
					return (List<Card>)(object)Enumerable.ToList(source6);
				}
			}
		}
		return (List<Card>)(object)new NullReferenceException();
	}

	private List<Card> GenerateSuitsGroup()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0026: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00a2: Expected O, but got I
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00f9: Expected O, but got I4
		//IL_0384: Expected O, but got I
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected O, but got Unknown
		//IL_03a8: Expected O, but got I
		//IL_03b8: Expected O, but got I
		//IL_03da: Expected O, but got I4
		//IL_0195: Expected O, but got I4
		//IL_01a5: Expected O, but got I
		//IL_01c7: Expected O, but got I4
		//IL_01f0: Expected O, but got I
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_0210: Expected O, but got I
		//IL_021c: Expected O, but got I
		//IL_0229: Expected O, but got I
		//IL_0246: Expected O, but got I
		//IL_0268: Expected O, but got I4
		//IL_0140: Expected O, but got I4
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected O, but got Unknown
		//IL_0412: Expected O, but got I
		//IL_0423: Expected I, but got O
		//IL_0441: Expected O, but got I
		//IL_0296: Expected I, but got O
		//IL_0170: Expected O, but got I
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected O, but got Unknown
		//IL_02fa: Expected O, but got I
		//IL_030b: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3760;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = (nint)0 + (nint)3000;
			object obj4 = obj2 + 16;
			obj4 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			IEnumerable<Suit> all = SuitMethods.GetAll();
			List<System.Int32Enum> list = Enumerable.ToList((IEnumerable<System.Int32Enum>)all);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9A56C");
			MiniGameRewardDescription rewardDescription = RewardDescription;
			if (RewardDescription != null)
			{
				object obj5 = (nint)0 + (nint)920;
				object obj6 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3744;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v4 (MiniGameRewardDescription)+28]");
				IEnumerable<System.Int32Enum> source2 = default(IEnumerable<System.Int32Enum>);
				IEnumerable<System.Int32Enum> source = Enumerable.Take(source2, 0);
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v15+E4]");
				bool flag = (nint)0 == 0;
				object obj8 = !flag;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj7 = obj6;
				}
				object obj9 = (nint)0 + (nint)2520;
				object handle = typeof(IAsyncEnumerable<>) + 2832;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v15+B8]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v18+8]");
				Func<System.Int32Enum, System.Int32Enum> keySelector = (Func<System.Int32Enum, System.Int32Enum>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v18+8]");
				bool flag2 = (nint)0 == 0;
				object obj11 = !flag2;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v15+E4]");
					bool flag3 = (nint)0 == 0;
					object obj12 = !flag3;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj13 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v24+B8]");
						obj10 = 0;
					}
					object obj14 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3744;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj15 = (nint)0 + (nint)1872;
					Func<System.Int32Enum, System.Int32Enum> func = default(Func<System.Int32Enum, System.Int32Enum>);
					func..ctor(obj10, (IntPtr)obj15);
					object obj16 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v23+B8]");
					object obj17 = (nint)0 + (nint)8;
					obj17 = func;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					keySelector = func;
				}
				IOrderedEnumerable<System.Int32Enum> source3 = Enumerable.OrderByDescending(source, keySelector);
				object obj18 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X26_v2+E0]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v19+E4]");
				bool flag4 = (nint)0 == 0;
				object obj20 = !flag4;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj21 = (nint)0 + (nint)3104;
				object obj22 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3040;
				object obj23 = (nint)0 + (nint)1896;
				object obj24 = (nint)0 + (nint)3712;
				object obj25 = (nint)0 + (nint)2912;
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X26_v2+98]");
				object obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v9+E4]");
				bool flag5 = (nint)0 == 0;
				object obj27 = !flag5;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Array values = Enum.GetValues(typeFromHandle);
				IEnumerable<System.Int32Enum> source4 = Enumerable.Cast<System.Int32Enum>(values);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Func<System.Int32Enum, bool> func2 = default(Func<System.Int32Enum, bool>);
				func2..ctor(obj2, (IntPtr)obj23);
				IEnumerable<System.Int32Enum> source5 = Enumerable.Where(source4, func2);
				List<System.Int32Enum> array = Enumerable.ToList(source5);
				System.Int32Enum int32Enum = ArraysExtensions.Random(array);
				object obj28 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3728;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj29 = (nint)0 + (nint)1904;
				Func<System.Int32Enum, object> func3 = default(Func<System.Int32Enum, object>);
				func3..ctor(obj2, (IntPtr)obj29);
				IEnumerable<object> source6 = Enumerable.Select(source3, func3);
				return (List<Card>)(object)Enumerable.ToList(source6);
			}
		}
		return (List<Card>)(object)new NullReferenceException();
	}

	public MiniGameRewardItemWithExample()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 416;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 1696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj3 = this + 88;
		obj3 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj4 = this + 96;
		obj4 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((MonoBehaviour)this)..ctor();
	}
}
