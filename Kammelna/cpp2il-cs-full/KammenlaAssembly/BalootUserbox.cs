using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using GoogleMobileAds.Api.AdManager;
using Kammelna.Server.Models.Clans;
using TMPro;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class BalootUserbox : Userbox
{
	public GameObject project1Object;

	public GameObject project2Object;

	public RectTransform projectsContainer;

	public TextMeshProUGUI project1Text;

	public TextMeshProUGUI project2Text;

	private float projectOriginalY;

	private DelayedActionTimer projectsTimer;

	private Vector2 projectsContainerSize;

	public GameObject doubleObject;

	public TextMeshProUGUI doubleText;

	public RectTransform doubleContainer;

	private Vector2 doubleContainerSize;

	private float doubleOriginalY;

	protected GameSoundAlbum soundAlbum;

	public GameObject sawaObject;

	public RectTransform sawaContainer;

	private Vector2 sawaContainerSize;

	private float sawaOriginalY;

	public GameObject kashoObject;

	public RectTransform kashoContainer;

	private Vector2 kashoContainerSize;

	private float kashoOriginalY;

	private new BalootPlayer player
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			BalootPlayer balootPlayer = (BalootPlayer)base.<player>k__BackingField;
			if (base.<player>k__BackingField != null)
			{
				object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2016;
				object obj2 = obj;
				nint num = (nint)balootPlayer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<BalootPlayer>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<BalootPlayer>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v9-8]");
					if (0 == (nint)obj2)
					{
						goto IL_00ad;
					}
				}
				return (BalootPlayer)(object)new InvalidCastException();
			}
			goto IL_00ad;
			IL_00ad:
			return (BalootPlayer)base.<player>k__BackingField;
		}
	}

	private new BalootGame game
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			BalootGame balootGame = (BalootGame)base.game;
			if ((object)base.game != null)
			{
				object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1984;
				object obj2 = obj;
				nint num = (nint)balootGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<BalootGame>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<BalootGame>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v9-8]");
					if (0 == (nint)obj2)
					{
						goto IL_00ad;
					}
				}
				return (BalootGame)(object)new InvalidCastException();
			}
			goto IL_00ad;
			IL_00ad:
			return (BalootGame)base.game;
		}
	}

	protected override void Awake()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0379: Expected O, but got I4
		//IL_00ba: Expected O, but got I4
		//IL_00c3: Expected O, but got I4
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected O, but got Unknown
		//IL_03d4: Expected O, but got I4
		//IL_04da: Expected O, but got I4
		//IL_0155: Expected O, but got I4
		//IL_015e: Expected O, but got I4
		//IL_0409: Expected O, but got I4
		//IL_043d: Expected O, but got I4
		//IL_0446: Expected O, but got I4
		//IL_044f: Expected O, but got I4
		//IL_0472: Expected O, but got I4
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected O, but got Unknown
		//IL_0535: Expected O, but got I4
		//IL_063b: Expected O, but got I4
		//IL_0210: Expected O, but got I4
		//IL_0219: Expected O, but got I4
		//IL_056a: Expected O, but got I4
		//IL_059e: Expected O, but got I4
		//IL_05a7: Expected O, but got I4
		//IL_05c0: Expected O, but got I4
		//IL_05d3: Expected O, but got I4
		//IL_0667: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Expected O, but got Unknown
		//IL_0696: Expected O, but got I4
		//IL_077e: Expected O, but got I4
		//IL_06cb: Expected O, but got I4
		//IL_06ff: Expected O, but got I4
		//IL_0708: Expected O, but got I4
		//IL_0721: Expected O, but got I4
		//IL_0734: Expected O, but got I4
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_031b: Expected O, but got I4
		//IL_0346: Expected O, but got I4
		base.Awake();
		doubleObject.SetActive(value: false);
		sawaObject.SetActive(value: false);
		kashoObject.SetActive(value: false);
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		project1Object.SetActive(value: false);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v4+E4]");
		Vector2 vector;
		if ((nint)0 != 0)
		{
			bool flag = doubleContainer;
			bool flag2 = !flag;
			object obj3 = !flag2;
			vector = (Vector2)0;
			if (obj3 == null)
			{
				goto IL_00d1;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = doubleContainer;
			bool flag4 = !flag3;
			vector = (Vector2)0;
			if (flag4)
			{
				goto IL_00d1;
			}
		}
		Rect rect = doubleContainer.rect;
		object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X0_v47+E4]");
		bool flag5 = (nint)0 == 0;
		object obj6 = !flag5;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector2 vector2 = default(Vector2);
		doubleContainerSize = vector2;
		RectTransform rectTransform = UIExtensions.rectTransform(doubleContainer);
		Vector2 vector3 = doubleContainerSize;
		rectTransform.sizeDelta = (Vector2)0;
		UnityEngine.Object obj7 = sawaContainer;
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v18+E4]");
		bool flag6 = (nint)0 == 0;
		object obj9 = !flag6;
		object obj10 = 0;
		object obj11 = 0;
		Vector2 vector4 = doubleContainerSize;
		Vector2 vector5 = vector2;
		object obj13 = default(object);
		object obj12 = obj13;
		vector = (Vector2)0;
		UnityEngine.Object obj14 = sawaContainer;
		if (obj9 != null)
		{
			goto IL_0132;
		}
		goto IL_048a;
		IL_0649:
		Rect rect2 = kashoContainer.rect;
		object obj15 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v19+E4]");
		bool flag7 = (nint)0 == 0;
		object obj17 = !flag7;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		kashoContainerSize = vector5;
		RectTransform rectTransform2 = UIExtensions.rectTransform(kashoContainer);
		vector3 = kashoContainerSize;
		rectTransform2.sizeDelta = (Vector2)0;
		UnityEngine.Object obj18 = projectsContainer;
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v6+E4]");
		bool flag8 = (nint)0 == 0;
		object obj20 = !flag8;
		obj10 = 0;
		vector2 = vector5;
		obj13 = obj12;
		object obj21 = 0;
		Vector2 vector6 = kashoContainerSize;
		Vector2 vector7 = (Vector2)0;
		UnityEngine.Object obj22 = projectsContainer;
		if (obj20 != null)
		{
			goto IL_02a8;
		}
		goto IL_074c;
		IL_01ed:
		UnityEngine.Object obj23;
		bool flag9 = obj23;
		bool flag10 = !flag9;
		object obj24 = !flag10;
		vector7 = (Vector2)0;
		object obj25 = obj10;
		Vector2 vector8 = vector3;
		vector5 = vector2;
		obj12 = obj13;
		if (obj24 == null)
		{
			goto IL_0247;
		}
		goto IL_0649;
		IL_05eb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj26;
		bool flag11 = obj26;
		bool flag12 = !flag11;
		obj10 = obj25;
		vector3 = vector8;
		vector2 = vector5;
		obj13 = obj12;
		vector7 = (Vector2)0;
		if (flag12)
		{
			goto IL_0247;
		}
		goto IL_0649;
		IL_02a8:
		if ((bool)obj18)
		{
			goto IL_02ce;
		}
		return;
		IL_02ce:
		Rect rect3 = projectsContainer.rect;
		object obj27 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		object obj28 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X0_v60+E4]");
		bool flag13 = (nint)0 == 0;
		object obj29 = !flag13;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		projectsContainerSize = vector2;
		RectTransform rectTransform3 = UIExtensions.rectTransform(projectsContainer);
		rectTransform3.sizeDelta = (Vector2)0;
		return;
		IL_00d1:
		obj7 = sawaContainer;
		obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v18+E4]");
		bool flag14 = (nint)0 == 0;
		obj11 = obj10;
		vector4 = vector3;
		vector5 = vector2;
		obj12 = obj13;
		obj14 = sawaContainer;
		if (!flag14)
		{
			goto IL_0132;
		}
		goto IL_048a;
		IL_048a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag15 = obj14;
		bool flag16 = !flag15;
		obj10 = obj11;
		vector3 = vector4;
		vector2 = vector5;
		obj13 = obj12;
		Vector2 vector9 = (Vector2)0;
		if (flag16)
		{
			goto IL_018c;
		}
		goto IL_04e8;
		IL_0132:
		bool flag17 = obj7;
		bool flag18 = !flag17;
		object obj30 = !flag18;
		vector9 = (Vector2)0;
		obj11 = obj10;
		vector4 = vector3;
		vector5 = vector2;
		obj12 = obj13;
		if (obj30 == null)
		{
			goto IL_018c;
		}
		goto IL_04e8;
		IL_04e8:
		Rect rect4 = sawaContainer.rect;
		object obj31 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		object obj32 = obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X0_v33+E4]");
		bool flag19 = (nint)0 == 0;
		object obj33 = !flag19;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		sawaContainerSize = vector5;
		RectTransform rectTransform4 = UIExtensions.rectTransform(sawaContainer);
		vector3 = sawaContainerSize;
		rectTransform4.sizeDelta = (Vector2)0;
		obj23 = kashoContainer;
		object obj34 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v12+E4]");
		bool flag20 = (nint)0 == 0;
		object obj35 = !flag20;
		obj10 = 0;
		vector2 = vector5;
		obj13 = obj12;
		obj25 = 0;
		vector8 = sawaContainerSize;
		vector9 = (Vector2)0;
		obj26 = kashoContainer;
		if (obj35 != null)
		{
			goto IL_01ed;
		}
		goto IL_05eb;
		IL_074c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag21 = obj22;
		bool flag22 = !flag21;
		object obj36 = !flag22;
		obj10 = obj21;
		vector3 = vector6;
		vector2 = vector5;
		obj13 = obj12;
		if (obj36 == null)
		{
			return;
		}
		goto IL_02ce;
		IL_0247:
		obj18 = projectsContainer;
		obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v6+E4]");
		bool flag23 = (nint)0 == 0;
		obj21 = obj10;
		vector6 = vector3;
		vector5 = vector2;
		obj12 = obj13;
		obj22 = projectsContainer;
		if (!flag23)
		{
			goto IL_02a8;
		}
		goto IL_074c;
		IL_018c:
		obj23 = kashoContainer;
		obj34 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v12+E4]");
		bool flag24 = (nint)0 == 0;
		obj25 = obj10;
		vector8 = vector3;
		vector5 = vector2;
		obj12 = obj13;
		obj26 = kashoContainer;
		if (!flag24)
		{
			goto IL_01ed;
		}
		goto IL_05eb;
	}

	protected override void OnRoundStart()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_004a: Expected I, but got O
		//IL_0073: Expected O, but got I4
		//IL_00a7: Expected O, but got I
		//IL_0114: Expected I, but got O
		//IL_013d: Expected O, but got I4
		//IL_0171: Expected O, but got I
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		if ((object)cardsRevealer != null)
		{
			cardsRevealer.HideImmediate();
			HideKasho();
			HideSawa();
			CardGamePlayer cardGamePlayer = base.<player>k__BackingField;
			if (base.<player>k__BackingField != null)
			{
				object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2016;
				object obj2 = obj;
				nint num = (nint)cardGamePlayer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v8 (Il2CppClass<CardGamePlayer>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X1_v5+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v8 (Il2CppClass<CardGamePlayer>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X1_v5+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v10-8]");
					if (0 == (nint)obj2)
					{
						if (!base.<player>k__BackingField.IsDealer)
						{
							return;
						}
						GameSoundManager instance = GameSoundManager.Instance;
						CardGamePlayer cardGamePlayer2 = base.<player>k__BackingField;
						if (base.<player>k__BackingField != null)
						{
							object obj6 = obj;
							nint num4 = (nint)cardGamePlayer2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X9_v5 (Il2CppClass<CardGamePlayer>)+130]");
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X1_v7+130]");
							bool flag2 = num5 < 0;
							object obj7 = !flag2;
							object obj8 = ~obj7;
							if (obj8 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X9_v5 (Il2CppClass<CardGamePlayer>)+C8]");
								nint num6 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X1_v7+130]");
								object obj9 = num6 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X9_v7-8]");
								if (0 == (nint)obj6)
								{
									if ((object)instance != null)
									{
										instance.PlaySound(BalootSound.AWAL, ((KPlayer)cardGamePlayer2).<Index>k__BackingField);
										object text = "alignContent" + 3464;
										ShowGameBubble((string)text);
										return;
									}
									goto IL_01f1;
								}
							}
							throw new InvalidCastException();
						}
						goto IL_01f1;
					}
				}
				goto IL_01ff;
			}
		}
		goto IL_01f1;
		IL_01f1:
		NullReferenceException ex = new NullReferenceException();
		goto IL_01ff;
		IL_01ff:
		throw new InvalidCastException();
	}

	protected override void OnGameStatusUpdate()
	{
		//IL_0016: Expected O, but got I
		//IL_00cc: Expected O, but got I
		//IL_00e6: Expected O, but got I4
		//IL_004f: Expected O, but got I
		//IL_0092: Expected O, but got I4
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_012d: Expected I, but got O
		//IL_0156: Expected O, but got I4
		//IL_018a: Expected O, but got I
		//IL_02ff: Expected O, but got I
		//IL_0319: Expected O, but got I4
		//IL_0345: Expected I, but got O
		//IL_036e: Expected O, but got I4
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_0200: Expected I, but got O
		//IL_0229: Expected O, but got I4
		//IL_03a2: Expected O, but got I
		//IL_025d: Expected O, but got I
		//IL_053b: Expected O, but got I
		//IL_055b: Expected O, but got I
		//IL_0575: Expected O, but got I4
		//IL_02b6: Expected O, but got I
		//IL_05a0: Expected I, but got O
		//IL_05c9: Expected O, but got I4
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected O, but got Unknown
		//IL_0418: Expected I, but got O
		//IL_0441: Expected O, but got I4
		//IL_05fd: Expected O, but got I
		//IL_0475: Expected O, but got I
		//IL_0636: Expected O, but got I
		//IL_050b: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6854]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			base.OnGameStatusUpdate();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6851]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_006c;
			}
		}
		else
		{
			_ = 1;
			base.OnGameStatusUpdate();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6851]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_006c;
			}
		}
		_ = 1;
		CardGamePlayer cardGamePlayer = base.<player>k__BackingField;
		goto IL_0109;
		IL_0329:
		_ = 1;
		goto IL_065b;
		IL_0645:
		throw new NullReferenceException();
		IL_0679:
		CardGamePlayer cardGamePlayer2 = base.<player>k__BackingField;
		object obj6;
		object obj5 = obj6;
		nint num = (nint)cardGamePlayer2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v15 (Il2CppClass<CardGamePlayer>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X1_v9+130]");
		bool flag2 = num2 < 0;
		object obj7 = !flag2;
		object obj8 = ~obj7;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v15 (Il2CppClass<CardGamePlayer>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X1_v9+130]");
			object obj9 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v17-8]");
			if (0 == (nint)obj5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v11 (CardGamePlayer)+70]");
				SetProjects((List<string>)0);
				return;
			}
		}
		goto IL_0637;
		IL_006c:
		cardGamePlayer = base.<player>k__BackingField;
		bool flag3 = base.<player>k__BackingField == null;
		object obj10 = !flag3;
		if (obj10 != null)
		{
			goto IL_0109;
		}
		goto IL_0645;
		IL_0109:
		obj6 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2016;
		object obj11 = obj6;
		nint num4 = (nint)cardGamePlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4 (Il2CppClass<CardGamePlayer>)+130]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X1_v2+130]");
		bool flag4 = num5 < 0;
		object obj12 = !flag4;
		object obj13 = ~obj12;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4 (Il2CppClass<CardGamePlayer>)+C8]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X1_v2+130]");
			object obj14 = num6 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v7-8]");
			if (0 == (nint)obj11)
			{
				if (!cardGamePlayer.IsRoundBidder)
				{
					SetBidInfo(Suit.NONE, BalootGame.BalootGameMode.NotDetermined);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6851]");
					object obj15 = (nint)0 & (nint)1;
					bool flag5 = obj15 == null;
					object obj16 = !flag5;
					if (obj16 == null)
					{
						goto IL_0329;
					}
					goto IL_065b;
				}
				CardGame cardGame = base.game;
				object obj17 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1984;
				object obj18 = obj17;
				nint num7 = (nint)cardGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v42 (Il2CppClass<CardGame>)+130]");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X1_v19+130]");
				bool flag6 = num8 < 0;
				object obj19 = !flag6;
				object obj20 = ~obj19;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v42 (Il2CppClass<CardGame>)+C8]");
					nint num9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X1_v19+130]");
					object obj21 = num9 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v44-8]");
					if (0 == (nint)obj18)
					{
						Suit <TrumpSuit>k__BackingField = cardGame.<TrumpSuit>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v32 (CardGame)+178]");
						SetBidInfo(<TrumpSuit>k__BackingField, BalootGame.BalootGameMode.NotDetermined);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6851]");
						object obj22 = (nint)0 & (nint)1;
						if (obj22 == null)
						{
							goto IL_0329;
						}
						goto IL_065b;
					}
				}
			}
		}
		goto IL_0637;
		IL_065b:
		BalootPlayer balootPlayer = (BalootPlayer)base.<player>k__BackingField;
		object obj23 = obj6;
		nint num10 = (nint)balootPlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v10 (Il2CppClass<BalootPlayer>)+130]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X1_v6+130]");
		bool flag7 = num11 < 0;
		object obj24 = !flag7;
		object obj25 = ~obj24;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v10 (Il2CppClass<BalootPlayer>)+C8]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X1_v6+130]");
			object obj26 = num12 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v12-8]");
			if (0 == (nint)obj23)
			{
				if (!balootPlayer.IsRoundDoubler)
				{
					goto IL_052f;
				}
				BalootUserbox balootUserbox = (BalootUserbox)(object)base.game;
				object obj27 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1984;
				object obj28 = obj27;
				nint num13 = (nint)balootUserbox;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v29 (Il2CppClass<BalootUserbox>)+130]");
				nint num14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X1_v14+130]");
				bool flag8 = num14 < 0;
				object obj29 = !flag8;
				object obj30 = ~obj29;
				if (obj30 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v29 (Il2CppClass<BalootUserbox>)+C8]");
					nint num15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X1_v14+130]");
					object obj31 = num15 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v31-8]");
					if (0 == (nint)obj28)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v20 (BalootUserbox)+17C]");
						if ((nint)0 == 0)
						{
							goto IL_052f;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v20 (BalootUserbox)+17C]");
						nint num16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v20 (BalootUserbox)+184]");
						string gameExtraModeText = balootUserbox.GetGameExtraModeText((BalootGame.BalootExtraGameMode)num16, hokomClose: false);
						SetDouble(gameExtraModeText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6851]");
						object obj32 = (nint)0 & (nint)1;
						if (obj32 == null)
						{
							goto IL_0584;
						}
						goto IL_0679;
					}
				}
			}
		}
		goto IL_0637;
		IL_052f:
		object obj33 = (nint)0 + (nint)2000;
		SetDouble((string)obj33);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6851]");
		object obj34 = (nint)0 & (nint)1;
		bool flag9 = obj34 == null;
		object obj35 = !flag9;
		if (obj35 == null)
		{
			goto IL_0584;
		}
		goto IL_0679;
		IL_0584:
		_ = 1;
		goto IL_0679;
		IL_0637:
		InvalidCastException ex = new InvalidCastException();
		goto IL_0645;
	}

	protected override void OnPlayerDidLastAction()
	{
		//IL_0016: Expected O, but got I
		//IL_00de: Expected O, but got I
		//IL_00f8: Expected O, but got I4
		//IL_0101: Expected O, but got I4
		//IL_010a: Expected O, but got I4
		//IL_004f: Expected O, but got I
		//IL_0067: Expected O, but got I4
		//IL_0070: Expected O, but got I4
		//IL_00a4: Expected O, but got I4
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_0173: Expected I, but got O
		//IL_019c: Expected O, but got I4
		//IL_01d0: Expected O, but got I
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_0531: Expected O, but got I
		//IL_054b: Expected O, but got I4
		//IL_0574: Expected I, but got O
		//IL_059d: Expected O, but got I4
		//IL_0274: Expected I, but got O
		//IL_029d: Expected O, but got I4
		//IL_05d1: Expected O, but got I
		//IL_02d1: Expected O, but got I
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Expected O, but got Unknown
		//IL_0995: Expected O, but got I
		//IL_09af: Expected O, but got I4
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected O, but got Unknown
		//IL_0370: Expected O, but got I4
		//IL_0379: Expected O, but got I4
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Expected O, but got Unknown
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected O, but got Unknown
		//IL_03c0: Expected O, but got I4
		//IL_09d8: Expected I, but got O
		//IL_0a01: Expected O, but got I4
		//IL_0ae7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aec: Expected O, but got Unknown
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Expected O, but got Unknown
		//IL_068b: Expected I, but got O
		//IL_06b4: Expected O, but got I4
		//IL_0401: Expected I, but got O
		//IL_042a: Expected O, but got I4
		//IL_0a35: Expected O, but got I
		//IL_0b1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b21: Expected O, but got Unknown
		//IL_0b3f: Expected O, but got I4
		//IL_06e8: Expected O, but got I
		//IL_045e: Expected O, but got I
		//IL_071f: Expected O, but got I
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected O, but got Unknown
		//IL_0a92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a97: Expected O, but got Unknown
		//IL_0b53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b58: Expected O, but got Unknown
		//IL_0b68: Expected I, but got O
		//IL_0b91: Expected O, but got I4
		//IL_1006: Expected O, but got I
		//IL_1020: Expected O, but got I4
		//IL_085b: Expected I, but got O
		//IL_0884: Expected O, but got I4
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected O, but got Unknown
		//IL_0bc5: Expected O, but got I
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Expected O, but got Unknown
		//IL_1049: Expected I, but got O
		//IL_1072: Expected O, but got I4
		//IL_08b8: Expected O, but got I
		//IL_10a6: Expected O, but got I
		//IL_08ef: Expected O, but got I
		//IL_0787: Expected I, but got O
		//IL_07b0: Expected O, but got I4
		//IL_0c29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2e: Expected O, but got Unknown
		//IL_07e4: Expected O, but got I
		//IL_0e34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e39: Expected O, but got Unknown
		//IL_0e64: Expected O, but got I4
		//IL_0fdb: Expected O, but got I
		//IL_1103: Unknown result type (might be due to invalid IL or missing references)
		//IL_1108: Expected O, but got Unknown
		//IL_0e7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e81: Expected O, but got Unknown
		//IL_0eac: Expected O, but got I4
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c98: Expected O, but got Unknown
		//IL_0cc2: Expected O, but got I4
		//IL_097e: Expected O, but got I
		//IL_0846: Expected O, but got I
		//IL_0ec4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec9: Expected O, but got Unknown
		//IL_0ef4: Expected O, but got I4
		//IL_0d12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d17: Expected O, but got Unknown
		//IL_0d41: Expected O, but got I4
		//IL_0f0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f11: Expected O, but got Unknown
		//IL_0f3c: Expected O, but got I4
		//IL_0d7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7f: Expected O, but got Unknown
		//IL_0d9a: Expected O, but got I
		//IL_0da8: Expected I, but got O
		//IL_0db7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbc: Expected O, but got Unknown
		//IL_0de6: Expected O, but got I4
		//IL_0f54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f59: Expected O, but got Unknown
		//IL_0f84: Expected O, but got I4
		//IL_0f9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa1: Expected O, but got Unknown
		//IL_1175: Expected O, but got I4
		//IL_118d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1192: Expected O, but got Unknown
		//IL_1242: Unknown result type (might be due to invalid IL or missing references)
		//IL_1247: Expected O, but got Unknown
		//IL_1272: Expected O, but got I4
		//IL_12c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12cb: Expected O, but got Unknown
		//IL_128b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1290: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6855]");
		object obj = (nint)0 & (nint)1;
		object obj4;
		object obj3;
		if (obj != null)
		{
			base.OnPlayerDidLastAction();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6852]");
			object obj2 = (nint)0 & (nint)1;
			bool flag = obj2 == null;
			obj3 = 152985600;
			obj4 = 152985600;
			if (!flag)
			{
				goto IL_007e;
			}
		}
		else
		{
			_ = 1;
			base.OnPlayerDidLastAction();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6852]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj3 = 152985600;
			obj4 = 152985600;
			if (obj6 != null)
			{
				goto IL_007e;
			}
		}
		_ = 1;
		CardGame cardGame = base.game;
		bool flag3 = (object)base.game == null;
		obj3 = obj4;
		if (!flag3)
		{
			goto IL_014f;
		}
		goto IL_12d9;
		IL_1359:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameSoundManager instance = GameSoundManager.Instance;
		CardGamePlayer cardGamePlayer = base.<player>k__BackingField;
		if (base.<player>k__BackingField == null)
		{
			goto IL_12d9;
		}
		object obj7 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2016;
		object obj8 = obj7;
		nint num = (nint)cardGamePlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X9_v21 (Il2CppClass<CardGamePlayer>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X1_v29+130]");
		bool flag4 = num2 < 0;
		object obj9 = !flag4;
		object obj10 = ~obj9;
		IEnumerable<string> sounds;
		string text;
		object obj35;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X9_v21 (Il2CppClass<CardGamePlayer>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X1_v29+130]");
			object obj11 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v979 @ X9_v23-8]");
			if (0 == (nint)obj8)
			{
				if ((object)instance != null)
				{
					instance.PlaySounds(sounds, ((KPlayer)cardGamePlayer).<Index>k__BackingField);
					object obj12 = "placementId" + 1864;
					if (text == (string)obj12)
					{
						GameSoundManager instance2 = GameSoundManager.Instance;
						if ((object)instance2 == null)
						{
							goto IL_12d9;
						}
						object obj13 = typeof(DataRelation) + 712;
						object obj14 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1027 @ X0_v115+E4]");
						bool flag5 = (nint)0 == 0;
						object obj15 = !flag5;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						DateTime now = DateTime.Now;
						TimeSpan timeSpan = instance2.<endTime>k__BackingField - now;
						object obj16 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
						object obj17 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1095 @ X0_v121+E4]");
						bool flag6 = (nint)0 == 0;
						object obj18 = !flag6;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						TimeSpan timeSpan2 = default(TimeSpan);
						int milliseconds = timeSpan2.Milliseconds;
						object obj19 = typeof(SqlSingle[]) + 2376;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj20 = (nint)0 + (nint)2416;
						Action action = default(Action);
						action..ctor(this, (IntPtr)obj20);
						object obj21 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
						object obj22 = obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1125 @ X0_v127+E4]");
						bool flag7 = (nint)0 == 0;
						object obj23 = !flag7;
						if (obj23 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						float seconds = (float)milliseconds / 1.1488461E+09f;
						Coroutine coroutine = CoroutineDummy.WaitForSeconds(seconds, action);
					}
					object obj24 = "startPosition" + 3024;
					bool flag8 = text == (string)obj24;
					bool flag9 = !flag8;
					object obj25 = !flag9;
					if (obj25 == null)
					{
						object obj26 = "destinationTimeZone" + 760;
						bool flag10 = text == (string)obj26;
						bool flag11 = !flag10;
						object obj27 = !flag11;
						if (obj27 == null)
						{
							object obj28 = "getSecondRescanTask" + 2952;
							bool flag12 = text == (string)obj28;
							bool flag13 = !flag12;
							object obj29 = !flag13;
							if (obj29 == null)
							{
								object obj30 = "utf-32" + 2760;
								bool flag14 = text == (string)obj30;
								bool flag15 = !flag14;
								object obj31 = !flag15;
								if (obj31 == null)
								{
									object obj32 = "utf-32" + 1144;
									bool flag16 = text == (string)obj32;
									bool flag17 = !flag16;
									object obj33 = !flag17;
									if (obj33 == null)
									{
										object obj34 = "clear_mass_tournaments" + 56;
										if (!(text == (string)obj34))
										{
											bool flag18 = text == (string)obj35;
											bool flag19 = !flag18;
											object obj36 = !flag19;
											if (obj36 == null)
											{
												object obj37 = "getSecondRescanTask" + 3056;
												if (!(text == (string)obj37))
												{
													object obj38 = "startPosition" + 2936;
													bool flag20 = text == (string)obj38;
													bool flag21 = !flag20;
													object obj39 = !flag21;
													if (obj39 == null)
													{
														object obj40 = "utf-32" + 1160;
														if (!(text == (string)obj40))
														{
															goto IL_14d1;
														}
													}
													object obj41 = "not" + 3528;
													text = (string)obj41;
													goto IL_14d1;
												}
											}
											BalootGame balootGame = game;
											if ((object)balootGame != null)
											{
												BalootGame balootGame2 = game;
												if ((object)balootGame2 != null)
												{
													string gameExtraModeText = ((BalootUserbox)(object)balootGame2).GetGameExtraModeText(balootGame.<ExtraGameMode>k__BackingField, balootGame2.<IsHokomClosed>k__BackingField);
													text = gameExtraModeText;
													goto IL_14d1;
												}
											}
											goto IL_12d9;
										}
									}
								}
							}
						}
					}
					object obj42 = (nint)0 + (nint)2736;
					TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(bubbleImage, 0f, 0.3f);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
					TweenerCore<Color, Color, ColorOptions> tweenerCore2 = ShortcutExtensionsTMPText.DOFade(bubbleText, 0f, 0.3f);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
					return;
				}
				goto IL_12d9;
			}
		}
		goto IL_12f2;
		IL_12e7:
		throw new InvalidCastException();
		IL_12d9:
		NullReferenceException ex = new NullReferenceException();
		goto IL_12e7;
		IL_007e:
		cardGame = base.game;
		bool flag22 = (object)base.game == null;
		object obj43 = !flag22;
		if (obj43 != null)
		{
			goto IL_014f;
		}
		goto IL_12d9;
		IL_014f:
		object obj44 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1984;
		object obj45 = obj44;
		nint num4 = (nint)cardGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v7 (Il2CppClass<CardGame>)+130]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X1_v5+130]");
		bool flag23 = num5 < 0;
		object obj46 = !flag23;
		object obj47 = ~obj46;
		object obj73;
		if (obj47 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v7 (Il2CppClass<CardGame>)+C8]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X1_v5+130]");
			object obj48 = num6 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v9-8]");
			if (0 == (nint)obj45)
			{
				CardGameLastActionInfo lastAction = cardGame.LastAction;
				if (lastAction == null)
				{
					goto IL_12d9;
				}
				object obj49 = "___# Content push apply failed [{0}]: {1}" + 2656;
				if (((LastActionInfo)lastAction).<Action>k__BackingField == (string)obj49)
				{
					CardGame cardGame2 = base.game;
					if ((object)base.game == null)
					{
						goto IL_12d9;
					}
					object obj50 = obj44;
					nint num7 = (nint)cardGame2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v65 (Il2CppClass<CardGame>)+130]");
					nint num8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X1_v24+130]");
					bool flag24 = num8 < 0;
					object obj51 = !flag24;
					object obj52 = ~obj51;
					if (obj52 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v65 (Il2CppClass<CardGame>)+C8]");
						nint num9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X1_v24+130]");
						object obj53 = num9 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v67-8]");
						if (0 == (nint)obj50)
						{
							CardGameLastActionInfo lastAction2 = base.game.LastAction;
							if (lastAction2 != null)
							{
								text = lastAction2.<BidType>k__BackingField;
								obj35 = "getSecondRescanTask" + 3064;
								bool flag25 = lastAction2.<BidType>k__BackingField == (string)obj35;
								bool flag26 = !flag25;
								object obj54 = !flag26;
								object obj55 = 0;
								if (obj54 == null)
								{
									object obj56 = "getSecondRescanTask" + 3056;
									bool flag27 = lastAction2.<BidType>k__BackingField == (string)obj56;
									bool flag28 = !flag27;
									obj55 = 0;
									if (flag28)
									{
										object obj57 = typeof(SqlSingle[]) + 32;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
										IEnumerable<string> enumerable = default(IEnumerable<string>);
										if (enumerable == null)
										{
											goto IL_12d9;
										}
										object obj58 = enumerable + 32;
										obj58 = lastAction2.<BidType>k__BackingField;
										sounds = enumerable;
										obj55 = 0;
										goto IL_1359;
									}
								}
								object obj59 = typeof(SqlSingle[]) + 32;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
								CardGame cardGame3 = base.game;
								if ((object)base.game != null)
								{
									object obj60 = obj44;
									nint num10 = (nint)cardGame3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v127 (Il2CppClass<CardGame>)+130]");
									nint num11 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X1_v59+130]");
									bool flag29 = num11 < 0;
									object obj61 = !flag29;
									object obj62 = ~obj61;
									if (obj62 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v127 (Il2CppClass<CardGame>)+C8]");
										nint num12 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X1_v59+130]");
										object obj63 = num12 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X8_v129-8]");
										if (0 == (nint)obj60)
										{
											object obj64 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2592;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
											Enum enumeration = default(Enum);
											string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
											IEnumerable<string> enumerable2 = default(IEnumerable<string>);
											if (enumerable2 == null)
											{
												goto IL_12d9;
											}
											object obj65 = enumerable2 + 32;
											obj65 = friendlyName;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											object obj58 = enumerable2 + 40;
											obj58 = text;
											sounds = enumerable2;
											goto IL_1359;
										}
									}
									goto IL_12e7;
								}
							}
							goto IL_12d9;
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6852]");
					object obj66 = (nint)0 & (nint)1;
					bool flag30 = obj66 == null;
					object obj67 = !flag30;
					if (obj67 == null)
					{
						_ = 1;
					}
					CardGame cardGame4 = base.game;
					if ((object)base.game == null)
					{
						goto IL_12d9;
					}
					object obj68 = obj44;
					nint num13 = (nint)cardGame4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v16 (Il2CppClass<CardGame>)+130]");
					nint num14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X1_v9+130]");
					bool flag31 = num14 < 0;
					object obj69 = !flag31;
					object obj70 = ~obj69;
					if (obj70 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v16 (Il2CppClass<CardGame>)+C8]");
						nint num15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X1_v9+130]");
						object obj71 = num15 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X8_v18-8]");
						if (0 == (nint)obj68)
						{
							CardGameLastActionInfo lastAction3 = base.game.LastAction;
							if (lastAction3 == null)
							{
								goto IL_12d9;
							}
							object obj72 = "___# Content push apply failed [{0}]: {1}" + 2664;
							if (((LastActionInfo)lastAction3).<Action>k__BackingField == (string)obj72)
							{
								CardGamePlayer cardGamePlayer2 = base.<player>k__BackingField;
								if (base.<player>k__BackingField == null)
								{
									goto IL_12d9;
								}
								obj73 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2016;
								object obj74 = obj73;
								nint num16 = (nint)cardGamePlayer2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v42 (Il2CppClass<CardGamePlayer>)+130]");
								nint num17 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X1_v18+130]");
								bool flag32 = num17 < 0;
								object obj75 = !flag32;
								object obj76 = ~obj75;
								if (obj76 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v42 (Il2CppClass<CardGamePlayer>)+C8]");
									nint num18 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X1_v18+130]");
									object obj77 = num18 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X8_v44-8]");
									if (0 == (nint)obj74)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v41 (CardGamePlayer)+70]");
										object obj78 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v41 (CardGamePlayer)+70]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X8_v46+18]");
											if ((nint)0 != 0)
											{
												GameSoundManager instance3 = GameSoundManager.Instance;
												CardGamePlayer cardGamePlayer3 = base.<player>k__BackingField;
												if (base.<player>k__BackingField == null)
												{
													goto IL_12d9;
												}
												object obj79 = obj73;
												nint num19 = (nint)cardGamePlayer3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X9_v13 (Il2CppClass<CardGamePlayer>)+130]");
												nint num20 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X1_v22+130]");
												bool flag33 = num20 < 0;
												object obj80 = !flag33;
												object obj81 = ~obj80;
												if (obj81 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X9_v13 (Il2CppClass<CardGamePlayer>)+C8]");
													nint num21 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X1_v22+130]");
													object obj82 = num21 + 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v975 @ X9_v15-8]");
													if (0 == (nint)obj79)
													{
														if ((object)instance3 == null)
														{
															goto IL_12d9;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v56 (CardGamePlayer)+70]");
														instance3.PlaySounds((IEnumerable<string>)0, ((KPlayer)cardGamePlayer3).<Index>k__BackingField);
														goto IL_13c3;
													}
												}
												goto IL_12f2;
											}
										}
										goto IL_13c3;
									}
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X22_v5+852]");
								object obj83 = (nint)0 & (nint)1;
								bool flag34 = obj83 == null;
								object obj84 = !flag34;
								if (obj84 == null)
								{
									_ = 1;
								}
								CardGame cardGame5 = base.game;
								if ((object)base.game == null)
								{
									goto IL_12d9;
								}
								object obj85 = obj44;
								nint num22 = (nint)cardGame5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v24 (Il2CppClass<CardGame>)+130]");
								nint num23 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X1_v12+130]");
								bool flag35 = num23 < 0;
								object obj86 = !flag35;
								object obj87 = ~obj86;
								if (obj87 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v24 (Il2CppClass<CardGame>)+C8]");
									nint num24 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X1_v12+130]");
									object obj88 = num24 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X8_v26-8]");
									if (0 == (nint)obj85)
									{
										CardGameLastActionInfo lastAction4 = base.game.LastAction;
										if (lastAction4 != null)
										{
											object obj89 = "___# Content push apply failed [{0}]: {1}" + 2712;
											if (((LastActionInfo)lastAction4).<Action>k__BackingField == (string)obj89)
											{
												<OnPlayerDidLastAction>g__FireCardRevealSound|29_0();
												ShowSawa();
												return;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X22_v5+852]");
											object obj90 = (nint)0 & (nint)1;
											bool flag36 = obj90 == null;
											object obj91 = !flag36;
											if (obj91 == null)
											{
												_ = 1;
											}
											CardGame cardGame6 = base.game;
											if ((object)base.game != null)
											{
												object obj92 = obj44;
												nint num25 = (nint)cardGame6;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X8_v32 (Il2CppClass<CardGame>)+130]");
												nint num26 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X1_v15+130]");
												bool flag37 = num26 < 0;
												object obj93 = !flag37;
												object obj94 = ~obj93;
												if (obj94 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X8_v32 (Il2CppClass<CardGame>)+C8]");
													nint num27 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X1_v15+130]");
													object obj95 = num27 + 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v983 @ X8_v34-8]");
													if (0 == (nint)obj92)
													{
														CardGameLastActionInfo lastAction5 = base.game.LastAction;
														if (lastAction5 != null)
														{
															object obj96 = "___# Content push apply failed [{0}]: {1}" + 2704;
															if (((LastActionInfo)lastAction5).<Action>k__BackingField == (string)obj96)
															{
																<OnPlayerDidLastAction>g__FireCardRevealSound|29_0();
																ShowKasho();
															}
															return;
														}
														goto IL_12d9;
													}
												}
												goto IL_12e7;
											}
										}
										goto IL_12d9;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_12e7;
		IL_13c3:
		CardGamePlayer cardGamePlayer4 = base.<player>k__BackingField;
		if (base.<player>k__BackingField == null)
		{
			goto IL_12d9;
		}
		object obj97 = obj73;
		nint num28 = (nint)cardGamePlayer4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v48 (Il2CppClass<CardGamePlayer>)+130]");
		nint num29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X1_v20+130]");
		bool flag38 = num29 < 0;
		object obj98 = !flag38;
		object obj99 = ~obj98;
		if (obj99 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v48 (Il2CppClass<CardGamePlayer>)+C8]");
			nint num30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X1_v20+130]");
			object obj100 = num30 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ X8_v50-8]");
			if (0 == (nint)obj97)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v43 (CardGamePlayer)+78]");
				List<Card> list = (List<Card>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v43 (CardGamePlayer)+78]");
				if ((nint)0 != 0 && list._size >= 1)
				{
					if ((object)cardsRevealer != null)
					{
						CardsRevealer obj101 = cardsRevealer;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v43 (CardGamePlayer)+78]");
						obj101.ShowCards((List<Card>)0, 5f, 2f);
						return;
					}
					goto IL_12d9;
				}
				return;
			}
		}
		goto IL_12e7;
		IL_12f2:
		InvalidCastException ex2 = new InvalidCastException();
		throw new IndexOutOfRangeException();
		IL_14d1:
		ShowGameBubble(text);
	}

	private unsafe void SetBidInfo(Suit suite, BalootGame.BalootGameMode gameMode)
	{
		//IL_01d7: Expected O, but got I4
		//IL_01e7: Expected O, but got I
		//IL_01f7: Expected O, but got I
		//IL_001f: Expected O, but got I4
		//IL_014a: Expected O, but got Ref
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_033c: Expected O, but got I4
		//IL_00c5: Expected F4, but got O
		//IL_00c5: Expected O, but got I4
		//IL_02f9: Expected O, but got I4
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00f8: Expected O, but got I
		//IL_0106: Expected I, but got O
		//IL_03c1: Expected F4, but got O
		//IL_03c1: Expected O, but got I4
		//IL_0117: Expected O, but got I
		if (suite == Suit.NONE)
		{
			bool flag = gameMode == BalootGame.BalootGameMode.NotDetermined;
			object obj = !flag;
			if (obj == null)
			{
				object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v33+E4]");
				if ((nint)0 != 0)
				{
					if ((bool)betContainer)
					{
						goto IL_0096;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag2 = betContainer;
					bool flag3 = !flag2;
					object obj4 = !flag3;
					if (obj4 != null)
					{
						goto IL_0096;
					}
				}
				betObject.SetActive(value: false);
				return;
			}
		}
		Image image;
		Component component;
		if (gameMode != BalootGame.BalootGameMode.NotDetermined)
		{
			object obj5 = default(object);
			string text = ((Enum)(&obj5)).ToString();
			string text2 = text.ToLower();
			TextMeshProExtensions.Localize(betText, text2);
			image = betImage;
			bool flag4 = suite != Suit.NONE;
			component = betImage;
			if (!flag4)
			{
				goto IL_01a8;
			}
		}
		else
		{
			object obj6 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v12+90]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v13+B8]");
			object text3 = 0;
			betText.text = (string)text3;
			image = betImage;
			bool flag5 = suite == Suit.NONE;
			component = betImage;
			if (flag5)
			{
				goto IL_01a8;
			}
		}
		Sprite suitSprite = spritesStore.GetSuitSprite(suite);
		image.sprite = suitSprite;
		GameObject gameObject = betImage.gameObject;
		bool active = true;
		goto IL_03eb;
		IL_0096:
		int num = ShortcutExtensions.DOKill(betContainer);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOSizeDelta(betContainer, (Vector2)0, (float)betContainerSize);
		object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = (nint)0 + (nint)2424;
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj9);
		object obj10 = (nint)0 + (nint)2488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		return;
		IL_01a8:
		gameObject = component.gameObject;
		active = false;
		goto IL_03eb;
		IL_03eb:
		gameObject.SetActive(active);
		betObject.SetActive(value: true);
		object obj11 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			bool flag6 = betContainer;
			bool flag7 = !flag6;
			object obj13 = !flag7;
			if (obj13 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!betContainer)
			{
				return;
			}
		}
		int num2 = ShortcutExtensions.DOKill(betContainer);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOSizeDelta(betContainer, (Vector2)0, (float)betContainerSize);
	}

	private void ShowSawa()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00eb: Expected O, but got I4
		//IL_00ad: Expected F4, but got O
		//IL_00ad: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		sawaObject.SetActive(value: true);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			if (!sawaContainer)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = sawaContainer;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				return;
			}
		}
		int num = ShortcutExtensions.DOKill(sawaContainer);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOSizeDelta(sawaContainer, (Vector2)0, (float)sawaContainerSize);
	}

	private void HideSawa()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_017d: Expected O, but got I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00d7: Expected O, but got I
		//IL_00e3: Expected O, but got I
		//IL_0112: Expected F4, but got O
		//IL_0112: Expected O, but got I4
		//IL_01c7: Expected O, but got I4
		//IL_0133: Expected I, but got O
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67FF]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			obj5 = sawaContainer;
			obj6 = sawaContainer;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = sawaContainer;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = sawaContainer;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			goto IL_00b7;
		}
		goto IL_01d5;
		IL_00b7:
		object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj10 = (nint)0 + (nint)2408;
		object obj11 = (nint)0 + (nint)2488;
		int num = ShortcutExtensions.DOKill(sawaContainer);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOSizeDelta(sawaContainer, (Vector2)0, (float)sawaContainerSize);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj10);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		return;
		IL_01d5:
		sawaObject.SetActive(value: false);
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
		goto IL_01d5;
	}

	private void ShowKasho()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00eb: Expected O, but got I4
		//IL_00ad: Expected F4, but got O
		//IL_00ad: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		kashoObject.SetActive(value: true);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			if (!kashoContainer)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = kashoContainer;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				return;
			}
		}
		int num = ShortcutExtensions.DOKill(kashoContainer);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOSizeDelta(kashoContainer, (Vector2)0, (float)kashoContainerSize);
	}

	private void HideKasho()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_017d: Expected O, but got I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00d7: Expected O, but got I
		//IL_00e3: Expected O, but got I
		//IL_0112: Expected F4, but got O
		//IL_0112: Expected O, but got I4
		//IL_01c7: Expected O, but got I4
		//IL_0133: Expected I, but got O
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6801]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			obj5 = kashoContainer;
			obj6 = kashoContainer;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = kashoContainer;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = kashoContainer;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			goto IL_00b7;
		}
		goto IL_01d5;
		IL_00b7:
		object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj10 = (nint)0 + (nint)2400;
		object obj11 = (nint)0 + (nint)2488;
		int num = ShortcutExtensions.DOKill(kashoContainer);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOSizeDelta(kashoContainer, (Vector2)0, (float)kashoContainerSize);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj10);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		return;
		IL_01d5:
		kashoObject.SetActive(value: false);
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
		goto IL_01d5;
	}

	private void SetDouble(string text)
	{
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_021f: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_018e: Expected F4, but got O
		//IL_018e: Expected O, but got I4
		//IL_0089: Expected F4, but got O
		//IL_0089: Expected O, but got I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00bc: Expected O, but got I
		//IL_00ca: Expected I, but got O
		//IL_00db: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		if (string.IsNullOrEmpty(text))
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v20+E4]");
			if ((nint)0 != 0)
			{
				if ((bool)doubleContainer)
				{
					goto IL_005a;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag = doubleContainer;
				bool flag2 = !flag;
				object obj3 = !flag2;
				if (obj3 != null)
				{
					goto IL_005a;
				}
			}
			doubleObject.SetActive(value: false);
			return;
		}
		TextMeshProExtensions.Localize(doubleText, text);
		doubleObject.SetActive(value: true);
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			if (!doubleContainer)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = doubleContainer;
			bool flag4 = !flag3;
			object obj5 = !flag4;
			if (obj5 == null)
			{
				return;
			}
		}
		int num = ShortcutExtensions.DOKill(doubleContainer);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOSizeDelta(doubleContainer, (Vector2)0, (float)doubleContainerSize);
		return;
		IL_005a:
		int num2 = ShortcutExtensions.DOKill(doubleContainer);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOSizeDelta(doubleContainer, (Vector2)0, (float)doubleContainerSize);
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj7 = (nint)0 + (nint)2432;
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj7);
		object obj8 = (nint)0 + (nint)2488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	private void SetProjects(List<string> projects)
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_012b: Expected O, but got I
		//IL_0143: Expected I, but got O
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_00c4: Expected O, but got I4
		//IL_00f8: Expected O, but got I4
		//IL_01be: Expected F4, but got O
		//IL_01be: Expected O, but got I4
		//IL_01e9: Expected O, but got I4
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected I4, but got Unknown
		//IL_0261: Expected O, but got I4
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected I4, but got Unknown
		GameObject gameObject;
		if (projects != null && projects._size != 0)
		{
			object text = ((List<object>)(object)projects).get_Item(0);
			TextMeshProExtensions.Localize(project1Text, (string)text);
			project1Object.SetActive(value: true);
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v11+E4]");
			if ((nint)0 != 0)
			{
				bool flag = projectsContainer;
				bool flag2 = !flag;
				object obj3 = !flag2;
				if (obj3 == null)
				{
					goto IL_00d2;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				if (!projectsContainer)
				{
					goto IL_00d2;
				}
			}
			int num = ShortcutExtensions.DOKill(projectsContainer);
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOSizeDelta(projectsContainer, (Vector2)0, (float)projectsContainerSize);
			gameObject = project2Object;
			goto IL_01d6;
		}
		object obj4 = typeof(SqlSingle[]) + 2376;
		object obj5 = (nint)0 + (nint)2440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj5);
		projectsTimer.End(action);
		return;
		IL_01d6:
		object obj6 = projects._size - 1;
		bool flag3 = (nint)obj6 < 0;
		bool flag4 = obj6 == null;
		int num2 = projects._size ^ 1;
		int num3 = projects._size ^ obj6;
		int num4 = num2 & num3;
		bool flag5 = num4 < 0;
		bool flag6 = flag3 == flag5;
		object obj7 = !flag4;
		bool active = (byte)((flag6 & obj7) ? 1 : 0) != 0;
		gameObject.SetActive(active);
		if (projects._size >= 2)
		{
			object text2 = ((List<object>)(object)projects).get_Item(1);
			TextMeshProExtensions.Localize(project2Text, (string)text2);
		}
		projectsTimer.Start();
		return;
		IL_00d2:
		gameObject = project2Object;
		bool flag7 = (object)project2Object == null;
		object obj8 = !flag7;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01d6;
	}

	private string GetGameExtraModeText(BalootGame.BalootExtraGameMode gameExtraMode, bool hokomClose)
	{
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0142: Expected O, but got I4
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00b3: Expected O, but got I
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		object result;
		object obj;
		switch (gameExtraMode)
		{
		case BalootGame.BalootExtraGameMode.Triple:
			return "tournament_participate_warning_body_with_tickets_warning_daily" + 624;
		case BalootGame.BalootExtraGameMode.Qahwa:
			return "placementId" + 1864;
		default:
			return (string)((nint)0 + (nint)2000);
		case BalootGame.BalootExtraGameMode.Double:
			result = "getSecondRescanTask" + 3064;
			obj = "getSecondRescanTask" + 3056;
			break;
		case BalootGame.BalootExtraGameMode.Four:
			result = "fetch_products" + 1160;
			obj = "fetch_products" + 1152;
			break;
		}
		bool flag = !hokomClose;
		object obj2 = !flag;
		object obj3 = ~obj2;
		if (obj3 == null)
		{
			result = obj;
		}
		return (string)result;
	}

	public BalootUserbox()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00ca: Expected O, but got I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj2 = typeof(DataRelation) + 1840;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan delay = TimeSpan.FromSeconds(1.0000000001164153);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DelayedActionTimer delayedActionTimer = default(DelayedActionTimer);
		delayedActionTimer..ctor(delay);
		projectsTimer = delayedActionTimer;
		object obj5 = this + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base._restingLocalScale = 1f;
		((MonoBehaviour)this)..ctor();
	}

	private void <OnPlayerDidLastAction>b__29_1()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
	}

	private unsafe void <OnPlayerDidLastAction>g__FireCardRevealSound|29_0()
	{
		//IL_0016: Expected O, but got I
		//IL_00db: Expected O, but got I
		//IL_00f5: Expected O, but got I4
		//IL_009c: Expected O, but got I4
		//IL_0059: Expected O, but got I
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0157: Expected I, but got O
		//IL_015f: Expected I, but got O
		//IL_018a: Expected O, but got I4
		//IL_01c6: Expected O, but got I
		//IL_022f: Expected I, but got O
		//IL_04dc: Expected I, but got O
		//IL_024a: Expected O, but got I
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_026a: Expected O, but got I
		//IL_0276: Expected O, but got I
		//IL_056a: Expected I, but got O
		//IL_03db: Expected I, but got O
		//IL_03fe: Expected O, but got I4
		//IL_02b5: Expected I, but got O
		//IL_02bd: Expected I, but got O
		//IL_02e6: Expected O, but got I4
		//IL_0480: Expected O, but got I4
		//IL_031a: Expected O, but got I
		//IL_03ce: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6856]");
		object obj = (nint)0 & (nint)1;
		nint num;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6852]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6852]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_0076;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6852]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6852]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0076;
			}
		}
		_ = 1;
		KGame kGame = base.game;
		bool flag2 = (object)base.game == null;
		num = 1;
		if (!flag2)
		{
			goto IL_013b;
		}
		goto IL_054c;
		IL_0403:
		if ((object)soundAlbum != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
			SingleSound singleSound = default(SingleSound);
			SoundChannel.PlaySFXSound(singleSound);
			return;
		}
		goto IL_054c;
		IL_0485:
		InvalidCastException ex = new InvalidCastException();
		nint num2 = default(nint);
		bool flag3 = num2 != 1;
		OutOfMemoryException ex2 = (OutOfMemoryException)(object)ex;
		object obj5 = default(object);
		List<object>.Enumerator enumerator;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num2 = (nint)obj5;
			enumerator.Dispose();
			object obj6 = default(object);
			bool flag4 = obj6 == null;
			enumerator2 = enumerator;
			List<object>.Enumerator enumerator3 = (List<object>.Enumerator)obj6;
			if (flag4)
			{
				goto IL_0403;
			}
			ex2 = new OutOfMemoryException();
			enumerator3 = (List<object>.Enumerator)obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2238514");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_054c:
		NullReferenceException ex3 = new NullReferenceException();
		enumerator = enumerator2;
		goto IL_0485;
		IL_0076:
		kGame = base.game;
		bool flag5 = (object)base.game == null;
		object obj7 = !flag5;
		if (obj7 != null)
		{
			goto IL_013b;
		}
		goto IL_054c;
		IL_013b:
		object obj8 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1984;
		num2 = (nint)obj8;
		num = (nint)kGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v4 (Il2CppClass<KGame>)+130]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X1_v3 (Il2CppMethodInfo)+130]");
		bool flag6 = num3 < 0;
		object obj9 = !flag6;
		object obj10 = ~obj9;
		enumerator = enumerator2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v4 (Il2CppClass<KGame>)+C8]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X1_v3 (Il2CppMethodInfo)+130]");
			object obj11 = num4 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v10-8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v10-8]");
			bool flag7 = 0 != num2;
			enumerator = enumerator2;
			if (!flag7)
			{
				List<KPlayer> players = kGame.Players;
				bool flag8 = players == null;
				num2 = unchecked((nint)null);
				if (!flag8)
				{
					object obj12 = (nint)0 + (nint)2944;
					object obj13 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2016;
					object obj14 = (nint)0 + (nint)2408;
					obj5 = (nint)0 + (nint)2936;
					List<object>.Enumerator enumerator4 = ((List<object>)(object)players).GetEnumerator();
					num = (nint)(&enumerator2);
					object obj15 = default(object);
					List<object>.Enumerator enumerator5;
					List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
					while (true)
					{
						num2 = (nint)obj12;
						if (!enumerator2.MoveNext())
						{
							break;
						}
						if (obj15 == null)
						{
							goto IL_036a;
						}
						num2 = (nint)obj13;
						nint num5 = (nint)obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v18 (Il2CppClass<KGame>)+130]");
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X1_v3 (Il2CppMethodInfo)+130]");
						bool flag9 = num6 < 0;
						object obj16 = !flag9;
						object obj17 = ~obj16;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v18 (Il2CppClass<KGame>)+C8]");
							nint num7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X1_v3 (Il2CppMethodInfo)+130]");
							object obj18 = num7 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v23-8]");
							num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v23-8]");
							flag7 = 0 != num2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v23-8]");
							num5 = 0;
							if (!flag7)
							{
								goto IL_036a;
							}
						}
						InvalidCastException ex4 = new InvalidCastException();
						goto IL_0465;
						IL_0465:
						enumerator2 = enumerator3;
						enumerator5 = enumerator3;
						enumerator3 = (List<object>.Enumerator)0;
						goto IL_054c;
						IL_036a:
						GameSoundManager instance = GameSoundManager.Instance;
						if (obj15 != null)
						{
							if ((object)instance != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ stack_-68+70]");
								nint num8 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ stack_-68+10]");
								instance.PlaySounds((IEnumerable<string>)num8, 0);
								continue;
							}
							NullReferenceException ex5 = new NullReferenceException();
						}
						else
						{
							NullReferenceException ex6 = new NullReferenceException();
						}
						goto IL_0465;
					}
					num2 = (nint)obj5;
					enumerator2.Dispose();
					enumerator2 = enumerator3;
					enumerator5 = enumerator3;
					enumerator3 = (List<object>.Enumerator)0;
					goto IL_0403;
				}
				goto IL_054c;
			}
		}
		goto IL_0485;
	}

	private void <SetBidInfo>b__30_0()
	{
		betObject.SetActive(value: false);
	}

	private void <HideSawa>b__32_0()
	{
		sawaObject.SetActive(value: false);
	}

	private void <HideKasho>b__34_0()
	{
		kashoObject.SetActive(value: false);
	}

	private void <SetDouble>b__35_0()
	{
		doubleObject.SetActive(value: false);
	}

	private void <SetProjects>b__36_0()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_017d: Expected O, but got I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00d7: Expected O, but got I
		//IL_00e3: Expected O, but got I
		//IL_0112: Expected F4, but got O
		//IL_0112: Expected O, but got I4
		//IL_01c7: Expected O, but got I4
		//IL_0133: Expected I, but got O
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6807]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			obj5 = projectsContainer;
			obj6 = projectsContainer;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = projectsContainer;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = projectsContainer;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			goto IL_00b7;
		}
		goto IL_01d5;
		IL_00b7:
		object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj10 = (nint)0 + (nint)2448;
		object obj11 = (nint)0 + (nint)2488;
		int num = ShortcutExtensions.DOKill(projectsContainer);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOSizeDelta(projectsContainer, (Vector2)0, (float)projectsContainerSize);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj10);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		return;
		IL_01d5:
		project1Object.SetActive(value: false);
		project2Object.SetActive(value: false);
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
		goto IL_01d5;
	}

	private void <SetProjects>b__36_1()
	{
		project1Object.SetActive(value: false);
		project2Object.SetActive(value: false);
	}
}
