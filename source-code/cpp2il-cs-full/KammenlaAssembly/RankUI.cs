using System;
using System.Buffers.Text;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class RankUI : RankSetter
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static TweenCallback <>9__15_2;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 4040;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <AnimateRank>b__15_2()
		{
		}
	}

	private sealed class <>c__DisplayClass15_0
	{
		public RankUI <>4__this;

		public PlayerRank playerRank;

		internal void <AnimateRank>b__0()
		{
			<>4__this.UpdateRank(playerRank);
			RankUI rankUI = <>4__this;
			TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(rankUI.rankImage, 1f, 0.3f);
		}

		internal void <AnimateRank>b__1()
		{
			//IL_0031: Expected O, but got I
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			//IL_0155: Expected O, but got I
			//IL_0165: Expected O, but got I
			//IL_0175: Expected O, but got I
			//IL_0197: Expected O, but got I4
			//IL_01bf: Expected O, but got I
			//IL_00ba: Expected O, but got I
			//IL_00ca: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_00fc: Expected O, but got I4
			//IL_01ef: Expected O, but got I4
			//IL_025b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0260: Expected O, but got Unknown
			//IL_0276: Expected O, but got I
			//IL_0287: Expected I, but got O
			//IL_02a5: Expected O, but got I
			//IL_0132: Expected O, but got I
			//IL_021f: Expected O, but got I
			<>4__this.UpdateRank(playerRank);
			RankUI rankUI = <>4__this;
			object obj = (nint)0 + (nint)2904;
			object obj2 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 4040;
			Transform transform = rankUI.rankImage.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(transform, 1f, 0.7f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v13+E4]");
			object obj5;
			object obj8 = default(object);
			object obj9;
			object obj10;
			object obj4;
			object obj7;
			TweenCallback tweenCallback;
			if ((nint)0 != 0)
			{
				obj4 = (nint)0 + (nint)2504;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v13+B8]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v10+8]");
				tweenCallback = (TweenCallback)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v10+8]");
				bool flag = (nint)0 == 0;
				object obj6 = !flag;
				obj7 = obj8;
				if (obj6 == null)
				{
					obj9 = obj4;
					obj10 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v10+8]");
					TweenCallback tweenCallback2 = (TweenCallback)0;
					goto IL_01cd;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
				obj9 = (nint)0 + (nint)2504;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v13+B8]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v10+8]");
				TweenCallback tweenCallback2 = (TweenCallback)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v10+8]");
				bool flag2 = (nint)0 == 0;
				object obj11 = !flag2;
				obj10 = obj8;
				obj4 = obj9;
				obj7 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v10+8]");
				tweenCallback = (TweenCallback)0;
				if (obj11 == null)
				{
					goto IL_01cd;
				}
			}
			goto IL_0241;
			IL_01cd:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v13+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj13 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v16+B8]");
				obj5 = 0;
			}
			object obj14 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj15 = (nint)0 + (nint)3096;
			TweenCallback tweenCallback3 = default(TweenCallback);
			tweenCallback3..ctor(obj5, (IntPtr)obj15);
			object obj16 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v15+B8]");
			object obj17 = (nint)0 + (nint)8;
			obj17 = tweenCallback3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj4 = obj9;
			obj7 = obj10;
			tweenCallback = tweenCallback3;
			goto IL_0241;
			IL_0241:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		}
	}

	private RankSprites rankSprites;

	private RankFonts fonts;

	private RankSprites backgroundsSprite;

	private RankColors stageColors;

	public Image rankImage;

	public Image[] subranks;

	public TextMeshProUGUI rankTitle;

	public Image rankBackground;

	public Image Shadow;

	public TextMeshProUGUI StageNumber;

	private int testRank = 1;

	public override void SetRank(PlayerRank playerRank, bool alsoAnimate = false)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0112: Expected O, but got I4
		//IL_00af: Expected O, but got I4
		//IL_00c6: Expected O, but got I4
		//IL_015b: Expected O, but got I4
		//IL_02bd: Expected O, but got I4
		//IL_02d3: Expected O, but got I4
		//IL_01a2: Expected O, but got I
		//IL_02f7: Expected I4, but got O
		//IL_0275: Expected O, but got I4
		//IL_027e: Expected O, but got I4
		//IL_020c: Expected O, but got I4
		//IL_0235: Expected O, but got I4
		//IL_05d9: Expected O, but got I4
		//IL_03b1: Expected I4, but got O
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected O, but got Unknown
		//IL_035c: Expected O, but got I4
		//IL_0364: Expected I4, but got O
		//IL_0798: Expected O, but got I
		//IL_07a0: Expected I, but got O
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected O, but got Unknown
		//IL_047b: Expected O, but got I4
		//IL_086f: Expected O, but got I4
		//IL_0659: Expected O, but got I4
		//IL_0662: Expected O, but got I4
		//IL_0805: Expected O, but got I4
		//IL_080d: Expected I, but got O
		//IL_0816: Expected O, but got I4
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected O, but got Unknown
		//IL_03d6: Expected O, but got I4
		//IL_0384: Expected I4, but got O
		//IL_088e: Expected O, but got I
		//IL_0896: Expected I, but got O
		//IL_03ec: Expected O, but got I
		//IL_08fb: Expected O, but got I4
		//IL_0904: Expected O, but got I4
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected O, but got Unknown
		//IL_042a: Expected O, but got I4
		//IL_0957: Expected O, but got I4
		//IL_04c4: Expected O, but got I4
		//IL_06fb: Expected O, but got I
		//IL_0725: Expected I, but got O
		//IL_051d: Expected O, but got I
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Expected O, but got Unknown
		//IL_055e: Expected O, but got I4
		//IL_0570: Expected O, but got I4
		if (playerRank == null)
		{
			return;
		}
		RankSprites rankSprites = this.rankSprites;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		UnityEngine.Object obj2;
		UnityEngine.Object obj4;
		if (!rankSprites.CardStyle)
		{
			obj2 = rankImage;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v52+E4]");
			bool flag = (nint)0 == 0;
			obj4 = rankImage;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			playerRank.<IsNew>k__BackingField = false;
			obj2 = rankImage;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v52+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			obj4 = rankImage;
			if (obj5 != null)
			{
				goto IL_008b;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj4 != null;
		bool flag4 = !flag3;
		object obj6 = 0;
		Sprite sprite = null;
		if (!flag4)
		{
			goto IL_016e;
		}
		goto IL_02ca;
		IL_05ec:
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X0_v17+E4]");
		bool flag5 = (nint)0 == 0;
		UnityEngine.Object obj8 = rankBackground;
		nint num2 = default(nint);
		nint num = num2;
		UnityEngine.Object obj9 = rankBackground;
		if (!flag5)
		{
			goto IL_0635;
		}
		goto IL_0836;
		IL_0675:
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X0_v8+E4]");
		bool flag6 = (nint)0 == 0;
		UnityEngine.Object stageNumber = StageNumber;
		UnityEngine.Object obj11;
		Sprite sprite2 = (Sprite)obj11;
		UnityEngine.Object stageNumber2 = StageNumber;
		if (!flag6)
		{
			goto IL_06be;
		}
		goto IL_0924;
		IL_06e5:
		TextMeshProUGUI stageNumber3 = StageNumber;
		object obj12 = (nint)0 + (nint)2008;
		Color color = stageColors.GetFor(playerRank.<Rank>k__BackingField);
		nint num3 = (nint)stageNumber3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v329 @ X8_v24 (Il2CppClass<TMPro.TextMeshProUGUI>)+2A8] (should have been resolved before IL gen)");
		goto IL_072f;
		IL_06be:
		if (stageNumber != null)
		{
			goto IL_06e5;
		}
		return;
		IL_008b:
		bool flag7 = obj2 != null;
		bool flag8 = !flag7;
		object obj13 = !flag8;
		if (obj13 != null)
		{
			goto IL_016e;
		}
		obj6 = 0;
		sprite = null;
		goto IL_02ca;
		IL_016e:
		if (alsoAnimate)
		{
			Image image = rankImage;
			object obj14 = (nint)0 + (nint)2040;
			object obj15 = ((RanksData<object>)(object)this.rankSprites).GetFor(playerRank);
			object obj16 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X0_v64+E4]");
			if ((nint)0 != 0)
			{
				bool flag9 = image.m_Sprite != (UnityEngine.Object)obj15;
				bool flag10 = !flag9;
				obj6 = 0;
				if (!flag10)
				{
					goto IL_021a;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag11 = image.m_Sprite != (UnityEngine.Object)obj15;
				bool flag12 = !flag11;
				object obj17 = !flag12;
				obj6 = 0;
				if (obj17 != null)
				{
					goto IL_021a;
				}
			}
		}
		object obj18 = ((RanksData<object>)(object)this.rankSprites).GetFor(playerRank);
		rankImage.sprite = (Sprite)obj18;
		obj6 = 0;
		sprite = (Sprite)obj18;
		goto IL_02ca;
		IL_0836:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag13 = obj9 != null;
		bool flag14 = !flag13;
		num2 = num;
		object obj19 = 0;
		obj11 = null;
		if (flag14)
		{
			goto IL_0675;
		}
		goto IL_0882;
		IL_0882:
		object obj20 = (nint)0 + (nint)2048;
		num2 = (nint)obj20;
		object obj21 = ((RanksData<object>)(object)backgroundsSprite).GetFor(playerRank.<Rank>k__BackingField, isNew: false);
		rankBackground.sprite = (Sprite)obj21;
		stageNumber = StageNumber;
		obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X0_v8+E4]");
		bool flag15 = (nint)0 == 0;
		object obj22 = !flag15;
		obj19 = 0;
		sprite2 = (Sprite)obj21;
		stageNumber2 = StageNumber;
		if (obj22 != null)
		{
			goto IL_06be;
		}
		goto IL_0924;
		IL_0924:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag16 = stageNumber2 != null;
		bool flag17 = !flag16;
		object obj23 = !flag17;
		if (obj23 == null)
		{
			return;
		}
		goto IL_06e5;
		IL_076b:
		string rankName = playerRank.RankName;
		TextMeshProExtensions.Localize(rankTitle, rankName);
		object obj24 = (nint)0 + (nint)2024;
		num2 = (nint)obj24;
		object obj25 = ((RanksData<object>)(object)fonts).GetFor(playerRank.<Rank>k__BackingField, isNew: false);
		rankTitle.fontMaterial = (Material)obj25;
		obj8 = rankBackground;
		obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X0_v17+E4]");
		bool flag18 = (nint)0 == 0;
		object obj26 = !flag18;
		num = (nint)obj24;
		obj6 = 0;
		Material material = (Material)obj25;
		obj9 = rankBackground;
		if (obj26 != null)
		{
			goto IL_0635;
		}
		goto IL_0836;
		IL_021a:
		AnimateRank(playerRank);
		sprite = (Sprite)(object)playerRank;
		object obj27 = 1;
		goto IL_0983;
		IL_072f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag19 = rankTitle;
		bool flag20 = !flag19;
		material = null;
		if (flag20)
		{
			goto IL_05ec;
		}
		goto IL_076b;
		IL_02ca:
		obj27 = 0;
		goto IL_0983;
		IL_0983:
		RankSprites rankSprites2 = this.rankSprites;
		bool flag21 = !rankSprites2.HasSubRanks;
		bool flag22 = (byte)(int)sprite != 0;
		if (!flag21)
		{
			if (alsoAnimate)
			{
				object obj28 = obj27 | playerRank.<IsNew>k__BackingField;
				object obj29 = obj28 & 1;
				bool flag23 = obj29 == null;
				object obj30 = !flag23;
				flag22 = (byte)(int)sprite != 0;
				if (obj30 == null)
				{
					AnimateSubRank(playerRank);
					flag22 = (byte)(int)playerRank != 0;
				}
			}
			else
			{
				Image[] array = subranks;
				bool flag24 = array.Length < 1;
				flag22 = (byte)(int)sprite != 0;
				if (!flag24)
				{
					object obj31 = array + 32;
					object obj32 = 0;
					bool flag25;
					do
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X25_v7+v159 @ X23_v9*8]");
						GameObject gameObject = ((Component)0).gameObject;
						obj32++;
						gameObject.SetActive(value: false);
						flag25 = (nint)obj32 < array.Length;
						obj6 = 0;
						flag22 = false;
					}
					while (flag25);
				}
				object obj33 = obj27 | playerRank.<IsNew>k__BackingField;
				object obj34 = obj33 & 1;
				bool flag26 = obj34 == null;
				object obj35 = !flag26;
				if (obj35 == null && playerRank.<SubRanksCount>k__BackingField >= 1)
				{
					object obj36 = obj6;
					bool flag27 = flag22;
					object obj37 = 0;
					bool flag29;
					do
					{
						Image[] array2 = subranks;
						bool flag28 = (nint)obj37 >= array2.Length;
						obj6 = obj36;
						flag22 = flag27;
						if (flag28)
						{
							break;
						}
						object obj38 = (object)array2 + obj37;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v37+20]");
						GameObject gameObject2 = ((Component)0).gameObject;
						gameObject2.SetActive(value: true);
						obj37++;
						flag29 = (nint)obj37 < playerRank.<SubRanksCount>k__BackingField;
						obj6 = 0;
						flag22 = true;
						obj36 = 0;
						flag27 = true;
					}
					while (flag29);
				}
			}
		}
		object obj39 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X0_v7+E4]");
		if ((nint)0 == 0)
		{
			goto IL_072f;
		}
		bool flag30 = rankTitle;
		bool flag31 = !flag30;
		object obj40 = !flag31;
		material = null;
		if (obj40 == null)
		{
			goto IL_05ec;
		}
		goto IL_076b;
		IL_0635:
		bool flag32 = obj8 != null;
		bool flag33 = !flag32;
		object obj41 = !flag33;
		obj19 = 0;
		obj11 = null;
		if (obj41 == null)
		{
			goto IL_0675;
		}
		goto IL_0882;
	}

	public override void SetAlpha(float alphaValue)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01f5: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_00cc: Expected O, but got I4
		//IL_029d: Expected O, but got I4
		//IL_0147: Expected O, but got I4
		//IL_0158: Expected O, but got I4
		//IL_0166: Expected O, but got I4
		//IL_0248: Expected O, but got I4
		//IL_0256: Expected O, but got I4
		//IL_0190: Expected O, but got I4
		//IL_0305: Expected O, but got I4
		//IL_0313: Expected O, but got I4
		//IL_04f1: Expected O, but got I4
		//IL_04ff: Expected O, but got I4
		//IL_0421: Expected O, but got I4
		//IL_042a: Expected O, but got I4
		//IL_0438: Expected O, but got I4
		//IL_0546: Expected O, but got I4
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected O, but got Unknown
		//IL_03c9: Expected O, but got I4
		//IL_05d4: Expected O, but got I
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Expected O, but got Unknown
		//IL_05b0: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E79D0]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v36+E4]");
			bool flag = (nint)0 == 0;
			obj5 = rankImage;
			obj6 = rankImage;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v36+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = rankImage;
			obj6 = rankImage;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object obj8 = 0;
		UnityEngine.Object obj9 = null;
		object obj10 = 0;
		if (flag4)
		{
			goto IL_00da;
		}
		goto IL_0264;
		IL_04ae:
		float num = default(float);
		UIExtensions.SetAlpha(Shadow, num);
		return;
		IL_03ce:
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v2+E4]");
		object obj15;
		object obj13;
		UnityEngine.Object obj14;
		if ((nint)0 != 0)
		{
			bool flag5 = StageNumber != null;
			bool flag6 = !flag5;
			object obj12 = !flag6;
			obj13 = 0;
			obj14 = null;
			obj15 = 0;
			if (obj12 == null)
			{
				goto IL_0446;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = StageNumber != null;
			bool flag8 = !flag7;
			obj13 = 0;
			obj14 = null;
			obj15 = 0;
			if (flag8)
			{
				goto IL_0446;
			}
		}
		UIExtensions.SetAlpha(StageNumber, num);
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v4+E4]");
		bool flag9 = (nint)0 == 0;
		object obj17 = !flag9;
		UnityEngine.Object shadow = Shadow;
		float num2 = num;
		obj13 = obj15;
		obj14 = null;
		UnityEngine.Object shadow2 = Shadow;
		if (obj17 != null)
		{
			goto IL_0487;
		}
		goto IL_057d;
		IL_0487:
		if (shadow != null)
		{
			goto IL_04ae;
		}
		return;
		IL_0091:
		bool flag10 = obj5 != null;
		bool flag11 = !flag10;
		object obj18 = !flag11;
		obj8 = 0;
		obj9 = null;
		obj10 = 0;
		if (obj18 == null)
		{
			goto IL_00da;
		}
		goto IL_0264;
		IL_0264:
		UIExtensions.SetAlpha(rankImage, num);
		object obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v29+E4]");
		bool flag12 = (nint)0 == 0;
		object obj20 = !flag12;
		UnityEngine.Object obj21 = rankBackground;
		float num3 = num;
		obj8 = obj10;
		obj9 = null;
		UnityEngine.Object obj22 = rankBackground;
		if (obj20 != null)
		{
			goto IL_0123;
		}
		goto IL_02d4;
		IL_00da:
		obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v29+E4]");
		bool flag13 = (nint)0 == 0;
		obj21 = rankBackground;
		num3 = num;
		obj22 = rankBackground;
		if (!flag13)
		{
			goto IL_0123;
		}
		goto IL_02d4;
		IL_02d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag14 = obj22 != null;
		bool flag15 = !flag14;
		object obj23 = 0;
		UnityEngine.Object obj24 = null;
		object obj25 = 0;
		if (flag15)
		{
			goto IL_0174;
		}
		goto IL_0321;
		IL_0123:
		bool flag16 = obj21 != null;
		bool flag17 = !flag16;
		object obj26 = !flag17;
		num3 = num;
		obj23 = 0;
		obj24 = null;
		obj25 = 0;
		if (obj26 == null)
		{
			goto IL_0174;
		}
		goto IL_0321;
		IL_0321:
		UIExtensions.SetAlpha(rankBackground, num);
		Image[] array = subranks;
		bool flag18 = subranks == null;
		num3 = num;
		obj23 = obj25;
		obj24 = null;
		num2 = num;
		UnityEngine.Object obj27 = null;
		if (!flag18)
		{
			goto IL_037b;
		}
		goto IL_03ce;
		IL_0174:
		bool flag19 = subranks == null;
		object obj28 = !flag19;
		array = subranks;
		if (obj28 != null)
		{
			goto IL_037b;
		}
		num2 = num3;
		obj25 = obj23;
		obj27 = obj24;
		goto IL_03ce;
		IL_037b:
		bool flag20 = array.Length < 1;
		num2 = num3;
		obj25 = obj23;
		obj27 = obj24;
		if (!flag20)
		{
			object obj29 = array + 32;
			object obj30 = 0;
			bool flag21;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X23_v5+v222 @ X22_v6*8]");
				UIExtensions.SetAlpha((Graphic)0, num);
				obj30++;
				flag21 = (nint)obj30 < array.Length;
				num2 = num;
				obj25 = obj23;
				obj27 = null;
			}
			while (flag21);
		}
		goto IL_03ce;
		IL_057d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag22 = shadow2 != null;
		bool flag23 = !flag22;
		object obj31 = !flag23;
		if (obj31 == null)
		{
			return;
		}
		goto IL_04ae;
		IL_0446:
		obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v4+E4]");
		bool flag24 = (nint)0 == 0;
		shadow = Shadow;
		shadow2 = Shadow;
		if (!flag24)
		{
			goto IL_0487;
		}
		goto IL_057d;
	}

	public override void Initialize(AvatarData avatarData)
	{
		//IL_0012: Expected I, but got O
		//IL_0022: Expected O, but got I
		//IL_0032: Expected O, but got I
		PlayerRank <Rank>k__BackingField = avatarData.<Rank>k__BackingField;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<RankUI>)+1A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<RankUI>)+1B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v5 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public override void Initialize(User user)
	{
		//IL_0012: Expected I, but got O
		//IL_0022: Expected O, but got I
		//IL_0032: Expected O, but got I
		PlayerRank rank = SFSKammelnaUserExtensions.GetRank(user);
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1 (Il2CppClass<RankUI>)+1A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1 (Il2CppClass<RankUI>)+1B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v18 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public override void Clear()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003b: Expected I, but got O
		//IL_004b: Expected O, but got I
		//IL_005b: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerRank playerRank = default(PlayerRank);
		playerRank..ctor(PlayerRank.Ranks.Beginner, isNew: true);
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3 (Il2CppClass<RankUI>)+1A8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3 (Il2CppClass<RankUI>)+1B0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v51 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void AnimateRank(PlayerRank playerRank)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_011f: Expected O, but got I
		//IL_0135: Expected O, but got I
		//IL_0141: Expected O, but got I
		//IL_014a: Expected F4, but got I4
		//IL_0153: Expected F4, but got I4
		//IL_015c: Expected O, but got I4
		//IL_00b4: Expected O, but got I
		//IL_00c0: Expected O, but got I
		//IL_00c9: Expected F4, but got I4
		//IL_00d2: Expected F4, but got I4
		//IL_00db: Expected O, but got I4
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_01b1: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 4048;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = playerRank;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		RankSprites rankSprites = this.rankSprites;
		object obj6;
		if (rankSprites.CardStyle)
		{
			TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(rankImage, 0.4f, 0.3f);
			object obj5 = (nint)0 + (nint)2456;
			obj6 = (nint)0 + (nint)3104;
			float num = 1.0502537E+09f;
			float num2 = 1.05360915E+09f;
			object obj7 = 0;
			TweenerCore<Color, Color, ColorOptions> tweenerCore2 = tweenerCore;
		}
		else
		{
			Transform target = rankImage.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = ShortcutExtensions.DOScale(target, 0f, 0.7f);
			object obj8 = (nint)0 + (nint)2904;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			object obj5 = (nint)0 + (nint)2504;
			obj6 = (nint)0 + (nint)3112;
			float num = 1.06032006E+09f;
			float num2 = 0f;
			object obj7 = 26;
			TweenerCore<Color, Color, ColorOptions> tweenerCore4 = default(TweenerCore<Color, Color, ColorOptions>);
			TweenerCore<Color, Color, ColorOptions> tweenerCore2 = tweenerCore4;
		}
		object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(obj2, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	private void UpdateRank(PlayerRank playerRank)
	{
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_021f: Expected O, but got I4
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0152: Expected O, but got I4
		//IL_0235: Expected O, but got I
		//IL_0168: Expected O, but got I
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		if ((object)rankSprites != null)
		{
			PlayerRank rank = default(PlayerRank);
			object sprite = ((RanksData<object>)(object)rankSprites).GetFor(rank);
			if ((object)rankImage != null)
			{
				rankImage.sprite = (Sprite)sprite;
				Image[] array = subranks;
				if (subranks != null && (object)array[0] != null)
				{
					GameObject gameObject = array[0].gameObject;
					if ((object)gameObject != null)
					{
						bool activeSelf = gameObject.activeSelf;
						Image[] array2 = subranks;
						if (activeSelf)
						{
							if (subranks != null)
							{
								if (array2.Length < 1)
								{
									return;
								}
								object obj = subranks + 32;
								object obj2 = 0;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X21_v7+v132 @ X20_v11*8]");
									if ((nint)0 == 0)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X21_v7+v132 @ X20_v11*8]");
									GameObject gameObject2 = ((Component)0).gameObject;
									if ((object)gameObject2 == null)
									{
										break;
									}
									obj2++;
									gameObject2.SetActive(value: false);
									if ((nint)obj2 >= array2.Length)
									{
										return;
									}
								}
							}
						}
						else if (subranks != null)
						{
							if (array2.Length < 1)
							{
								return;
							}
							object obj3 = subranks + 32;
							object obj4 = 0;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X21_v6+v133 @ X20_v8*8]");
								if ((nint)0 == 0)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X21_v6+v133 @ X20_v8*8]");
								GameObject gameObject3 = ((Component)0).gameObject;
								if ((object)gameObject3 == null)
								{
									break;
								}
								obj4++;
								gameObject3.SetActive(value: true);
								if ((nint)obj4 >= array2.Length)
								{
									return;
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private void AnimateSubRank(PlayerRank playerRank)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_003f: Expected O, but got I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_032c: Expected O, but got I
		//IL_0125: Expected O, but got I
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_016d: Expected O, but got I4
		//IL_03b7: Expected O, but got I4
		//IL_01bf: Expected O, but got I4
		//IL_03fb: Expected O, but got I
		//IL_0429: Expected O, but got I4
		//IL_0203: Expected O, but got I
		//IL_0231: Expected O, but got I4
		//IL_0279: Expected O, but got I4
		//IL_02bd: Expected O, but got I
		//IL_02f1: Expected I, but got O
		Image[] array = subranks;
		if (subranks != null)
		{
			if (playerRank != null)
			{
				object obj = typeof(SqlSingle[]) + 3912;
				object obj2 = 4;
				do
				{
					object obj3 = obj2 - 4;
					if ((nint)obj3 >= array.Length)
					{
						return;
					}
					if ((nint)obj3 < playerRank.<SubRanksCount>k__BackingField)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v8 (UnityEngine.UI.Image[])+v154 @ X22_v6*8]");
						if ((nint)0 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v8 (UnityEngine.UI.Image[])+v154 @ X22_v6*8]");
						GameObject gameObject = ((Component)0).gameObject;
						if ((object)gameObject == null)
						{
							break;
						}
						bool activeSelf = gameObject.activeSelf;
						bool flag = !activeSelf;
						object obj4 = !flag;
						if (obj4 == null)
						{
							Image[] array2 = subranks;
							if (subranks == null)
							{
								break;
							}
							bool flag2 = (nint)obj3 < array2.Length;
							object obj5 = !flag2;
							if (obj5 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v11 (UnityEngine.UI.Image[])+v154 @ X22_v6*8]");
								if ((nint)0 == 0)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v11 (UnityEngine.UI.Image[])+v154 @ X22_v6*8]");
								RectTransform rectTransform = ((Graphic)0).rectTransform;
								object obj6 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v12+E4]");
								bool flag3 = (nint)0 == 0;
								object obj7 = !flag3;
								Transform rect = rectTransform;
								if (obj7 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									rect = rectTransform;
								}
								AnimationExtensions.AnimRankGain(rect);
								Image[] array3 = subranks;
								if (subranks == null)
								{
									break;
								}
								bool flag4 = (nint)obj3 < array3.Length;
								object obj8 = !flag4;
								if (obj8 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v13 (UnityEngine.UI.Image[])+v154 @ X22_v6*8]");
									if ((nint)0 == 0)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v13 (UnityEngine.UI.Image[])+v154 @ X22_v6*8]");
									GameObject gameObject2 = ((Component)0).gameObject;
									if ((object)gameObject2 == null)
									{
										break;
									}
									gameObject2.SetActive(value: true);
									nint num = unchecked((nint)null);
									goto IL_0065;
								}
							}
							goto IL_0474;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v8 (UnityEngine.UI.Image[])+v154 @ X22_v6*8]");
						if ((nint)0 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v8 (UnityEngine.UI.Image[])+v154 @ X22_v6*8]");
						GameObject gameObject3 = ((Component)0).gameObject;
						if ((object)gameObject3 == null)
						{
							break;
						}
						if (gameObject3.activeSelf)
						{
							Image[] array4 = subranks;
							if (subranks == null)
							{
								break;
							}
							bool flag5 = (nint)obj3 < array4.Length;
							object obj9 = !flag5;
							if (obj9 != null)
							{
								goto IL_0474;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v9 (UnityEngine.UI.Image[])+v154 @ X22_v6*8]");
							if ((nint)0 == 0)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v9 (UnityEngine.UI.Image[])+v154 @ X22_v6*8]");
							RectTransform rectTransform2 = ((Graphic)0).rectTransform;
							object obj10 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v10+E4]");
							bool flag6 = (nint)0 == 0;
							object obj11 = !flag6;
							if (obj11 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							AnimationExtensions.AnimLoseHeart(rectTransform2, 1, skipIntro: true);
							nint num = 1;
						}
					}
					goto IL_0065;
					IL_0065:
					array = subranks;
					obj2++;
				}
				while (subranks != null);
			}
			else if (array.Length <= 0)
			{
				return;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0474;
		IL_0474:
		throw new IndexOutOfRangeException();
	}

	private void TestRank()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004c: Expected O, but got I4
		//IL_0094: Expected I, but got O
		//IL_00a4: Expected O, but got I
		//IL_00b4: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		object obj2 = testRank + 1;
		PlayerRank.Ranks rank = (PlayerRank.Ranks)(testRank = (((nint)obj2 >= 7) ? 1 : (testRank + 1)));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerRank playerRank = default(PlayerRank);
		playerRank..ctor(rank);
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v4 (Il2CppClass<RankUI>)+1A8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v4 (Il2CppClass<RankUI>)+1B0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v68 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
