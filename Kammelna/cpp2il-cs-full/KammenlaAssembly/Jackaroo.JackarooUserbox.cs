using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using UnityEngine;

namespace Jackaroo;

public class JackarooUserbox : Userbox
{
	private sealed class <>c__DisplayClass17_0
	{
		public JackarooUserbox <>4__this;

		public Card cardToBurn;

		internal void <TryPlayBurnOtherCardRandom>b__0()
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			//IL_002e: Expected I, but got O
			//IL_0057: Expected O, but got I4
			//IL_008b: Expected O, but got I
			//IL_00c8: Expected O, but got I
			//IL_00de: Expected I4, but got I8
			JackarooUserbox jackarooUserbox = <>4__this;
			KPlayer <player>k__BackingField = ((Userbox)jackarooUserbox).<player>k__BackingField;
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 272;
			object obj2 = obj;
			nint num = (nint)<player>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X9_v3 (Il2CppClass<KPlayer>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v9+130]");
			bool flag = num2 < 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X9_v3 (Il2CppClass<KPlayer>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v9+130]");
				object obj5 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X9_v5-8]");
				if (0 == (nint)obj2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X1_v4 (KPlayer)+70]");
					JackarooPlayer nextPlayer = ((JackarooGame)0).GetNextPlayer(<player>k__BackingField);
					int? gameActionId = -1;
					jackarooUserbox._jackarooGameVisualControls.PlayCard(cardToBurn, nextPlayer, null, isEventFromServer: true, withCollision: true, gameActionId, 0, playImmediately: false, hideStartingPoint: false);
					return;
				}
			}
			throw new InvalidCastException();
		}
	}

	private JackarooCardGameVisualControls _jackarooGameVisualControls;

	private JackarooBoardMono _jackarooBoard;

	private Card _thrownCard;

	private Transform _transform;

	private new JackarooPlayer player
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			JackarooPlayer jackarooPlayer = (JackarooPlayer)base.<player>k__BackingField;
			if (base.<player>k__BackingField != null)
			{
				object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 272;
				object obj2 = obj;
				nint num = (nint)jackarooPlayer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<Jackaroo.JackarooPlayer>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<Jackaroo.JackarooPlayer>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v9-8]");
					if (0 == (nint)obj2)
					{
						goto IL_00ad;
					}
				}
				return (JackarooPlayer)(object)new InvalidCastException();
			}
			goto IL_00ad;
			IL_00ad:
			return (JackarooPlayer)base.<player>k__BackingField;
		}
	}

	private new JackarooGame game
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			JackarooGame jackarooGame = (JackarooGame)base.game;
			if ((object)base.game != null)
			{
				object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
				object obj2 = obj;
				nint num = (nint)jackarooGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<Jackaroo.JackarooGame>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<Jackaroo.JackarooGame>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v9-8]");
					if (0 == (nint)obj2)
					{
						goto IL_00ad;
					}
				}
				return (JackarooGame)(object)new InvalidCastException();
			}
			goto IL_00ad;
			IL_00ad:
			return (JackarooGame)base.game;
		}
	}

	protected override void Awake()
	{
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_014a: Expected O, but got I
		//IL_017e: Expected O, but got I4
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0029: Expected I, but got O
		//IL_0052: Expected O, but got I4
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected O, but got Unknown
		//IL_022a: Expected O, but got I
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_007a: Expected I, but got O
		//IL_00a3: Expected O, but got I4
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_0378: Expected I, but got O
		//IL_03a1: Expected O, but got I4
		//IL_0276: Expected O, but got I
		//IL_02aa: Expected O, but got I4
		//IL_00df: Expected O, but got I
		//IL_0319: Expected O, but got I
		//IL_034d: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		base.Awake();
		CardGameVisualControls cardGameVisualControls = gameVisualControls;
		object obj3;
		object obj14;
		object obj12;
		object obj11;
		if ((object)gameVisualControls != null)
		{
			object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 152;
			obj3 = obj2;
			nint num = (nint)cardGameVisualControls;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X11_v3 (Il2CppClass<CardGameVisualControls>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X9_v5+130]");
			bool flag = num2 < 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				object obj5 = this + 480;
				_jackarooGameVisualControls = null;
				nint num3 = (nint)cardGameVisualControls;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X11_v12 (Il2CppClass<CardGameVisualControls>)+130]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X9_v5+130]");
				bool flag2 = num4 < 0;
				object obj6 = !flag2;
				object obj7 = ~obj6;
				object obj8 = obj5;
				if (obj7 == null)
				{
					goto IL_00c2;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X11_v3 (Il2CppClass<CardGameVisualControls>)+C8]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X9_v5+130]");
				object obj9 = num5 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X11_v6-8]");
				CardGameVisualControls jackarooGameVisualControls = ((0 != (nint)obj3) ? null : gameVisualControls);
				object obj5 = this + 480;
				_jackarooGameVisualControls = (JackarooCardGameVisualControls)jackarooGameVisualControls;
				nint num3 = (nint)cardGameVisualControls;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X11_v12 (Il2CppClass<CardGameVisualControls>)+130]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X9_v5+130]");
				bool flag3 = num6 < 0;
				object obj10 = !flag3;
				object obj8 = obj5;
				if (obj10 != null)
				{
					goto IL_00c2;
				}
			}
			obj11 = (nint)0 + (nint)112;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v12+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				obj14 = obj11;
				CardGameVisualControls cardGameVisualControls2 = null;
				goto IL_0199;
			}
		}
		else
		{
			object obj15 = this + 480;
			_jackarooGameVisualControls = null;
			obj14 = (nint)0 + (nint)112;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v12+E4]");
			bool flag5 = (nint)0 == 0;
			object obj16 = !flag5;
			CardGameVisualControls cardGameVisualControls2 = null;
			obj11 = obj14;
			if (obj16 == null)
			{
				goto IL_0199;
			}
		}
		goto IL_01b0;
		IL_00c2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X11_v12 (Il2CppClass<CardGameVisualControls>)+C8]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X9_v5+130]");
		object obj17 = num7 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X10_v4-8]");
		if (0 == (nint)obj3)
		{
			CardGameVisualControls cardGameVisualControls2 = gameVisualControls;
		}
		else
		{
			CardGameVisualControls cardGameVisualControls2 = null;
		}
		obj11 = (nint)0 + (nint)112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v12+E4]");
		bool flag6 = (nint)0 == 0;
		object obj18 = !flag6;
		if (obj18 == null)
		{
			obj14 = obj11;
			goto IL_0199;
		}
		goto IL_01b0;
		IL_0199:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj11 = obj14;
		goto IL_01b0;
		IL_01b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		JackarooBoardMono jackarooBoard = default(JackarooBoardMono);
		_jackarooBoard = jackarooBoard;
		object obj19 = this + 488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Transform transform = base.transform;
		_transform = transform;
		object obj20 = this + 504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	protected override void OnGameStatusUpdate()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_002f: Expected I, but got O
		//IL_0058: Expected O, but got I4
		//IL_008c: Expected O, but got I
		base.OnGameStatusUpdate();
		CardGamePlayer cardGamePlayer = base.<player>k__BackingField;
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 272;
		object obj2 = obj;
		nint num = (nint)cardGamePlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<CardGamePlayer>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v3+130]");
		bool flag = num2 < 0;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<CardGamePlayer>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v3+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v9-8]");
			if (0 == (nint)obj2)
			{
				bool isDealer = cardGamePlayer.IsDealer;
				SetDealer(isDealer);
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	protected override void OnPlayerDidLastAction()
	{
		//IL_0016: Expected O, but got I
		//IL_00bb: Expected O, but got I
		//IL_00d5: Expected O, but got I4
		//IL_008c: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_011c: Expected I, but got O
		//IL_0145: Expected O, but got I4
		//IL_0179: Expected O, but got I
		//IL_01b0: Expected O, but got I
		//IL_01e5: Expected O, but got I
		//IL_0227: Expected O, but got I
		//IL_0227: Expected O, but got I
		//IL_0245: Expected O, but got I4
		//IL_024e: Expected O, but got I4
		//IL_0359: Expected I, but got O
		//IL_0382: Expected O, but got I4
		//IL_0279: Expected O, but got I
		//IL_0279: Expected O, but got I
		//IL_0291: Expected O, but got I4
		//IL_03b6: Expected O, but got I
		//IL_02c9: Expected O, but got I4
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected O, but got Unknown
		//IL_0401: Expected O, but got I
		//IL_0420: Expected O, but got I
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected O, but got Unknown
		//IL_0455: Expected O, but got I
		//IL_0301: Expected O, but got I4
		//IL_04a6: Expected O, but got I4
		//IL_0336: Expected O, but got I4
		//IL_04dc: Expected O, but got I4
		//IL_0512: Expected O, but got I4
		//IL_05f0: Expected O, but got I4
		//IL_05b8: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E806D]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E806C]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_0066;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E806C]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0066;
			}
		}
		_ = 1;
		CardGame cardGame = base.game;
		goto IL_00f8;
		IL_0670:
		throw new NullReferenceException();
		IL_00f8:
		object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
		object obj6 = obj5;
		nint num = (nint)cardGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v4 (Il2CppClass<CardGame>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X1_v2+130]");
		bool flag2 = num2 < 0;
		object obj7 = !flag2;
		object obj8 = ~obj7;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v4 (Il2CppClass<CardGame>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X1_v2+130]");
			object obj9 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v7-8]");
			if (0 == (nint)obj6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (CardGame)+170]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (CardGame)+170]");
				if ((nint)0 == 0)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (CardGame)+178]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (CardGame)+178]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X22_v3+18]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X23_v5+18]");
					bool flag3 = (string)num4 != (string)0;
					bool flag4 = !flag3;
					object obj12 = !flag4;
					object obj13 = 0;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X22_v3+30]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X23_v5+30]");
						bool flag5 = object.Equals(num5, 0);
						bool flag6 = !flag5;
						obj13 = 0;
						if (!flag6)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X22_v3+38]");
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X23_v5+38]");
							bool flag7 = num6 != 0;
							obj13 = 0;
							if (!flag7)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X22_v3+3C]");
								nint num7 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X23_v5+3C]");
								bool flag8 = num7 != 0;
								obj13 = 0;
								if (!flag8)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X22_v3+40]");
									nint num8 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X23_v5+40]");
									bool flag9 = num8 == 0;
									obj13 = 0;
									if (flag9)
									{
										return;
									}
								}
							}
						}
					}
				}
				CardGame cardGame2 = base.game;
				object obj14 = obj5;
				nint num9 = (nint)cardGame2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v13 (Il2CppClass<CardGame>)+130]");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X1_v6+130]");
				bool flag10 = num10 < 0;
				object obj15 = !flag10;
				object obj16 = ~obj15;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v13 (Il2CppClass<CardGame>)+C8]");
					nint num11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X1_v6+130]");
					object obj17 = num11 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v15-8]");
					if (0 == (nint)obj14)
					{
						object obj18 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 232;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v9 (CardGame)+170]");
						CardGameLastActionInfo cardGameLastActionInfo = (CardGameLastActionInfo)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v9 (CardGame)+170]");
						CardGameLastActionInfo cardGameLastActionInfo2 = default(CardGameLastActionInfo);
						cardGameLastActionInfo2..ctor((CardGameLastActionInfo)0);
						((LastActionInfo)cardGameLastActionInfo2).<ActionPlayer>k__BackingField = ((LastActionInfo)cardGameLastActionInfo).<ActionPlayer>k__BackingField;
						object obj19 = cardGameLastActionInfo2 + 48;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X22_v6 (CardGameLastActionInfo)+30]");
						obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X22_v6 (CardGameLastActionInfo)+38]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X22_v6 (CardGameLastActionInfo)+40]");
						_ = 0;
						bool flag11 = TryPlayThrownCard((JackarooLastActionInfo)cardGameLastActionInfo2);
						bool flag12 = !flag11;
						object obj20 = !flag12;
						if (obj20 != null)
						{
							return;
						}
						bool flag13 = TryPlayOutOfTime((JackarooLastActionInfo)cardGameLastActionInfo2);
						bool flag14 = !flag13;
						object obj21 = !flag14;
						if (obj21 != null)
						{
							return;
						}
						bool flag15 = TryPlayBurnOtherCardRandom((JackarooLastActionInfo)cardGameLastActionInfo2);
						bool flag16 = !flag15;
						object obj22 = !flag16;
						if (obj22 != null || TryPlaySteal((JackarooLastActionInfo)cardGameLastActionInfo2))
						{
							return;
						}
						JackarooPlayer jackarooPlayer = player;
						if (jackarooPlayer.IsMe)
						{
							JackarooPlayer jackarooPlayer2 = player;
							bool isHumanSeated = jackarooPlayer2.IsHumanSeated;
							bool flag17 = !isHumanSeated;
							object obj23 = !flag17;
							if (obj23 != null)
							{
								return;
							}
						}
						int? gameActionId = GetGameActionId((JackarooLastActionInfo)cardGameLastActionInfo2);
						bool flag18 = _thrownCard == null;
						object obj24 = !flag18;
						if (obj24 == null)
						{
							JackarooPlayer playerToPlay = player;
							PlayCard((Card)obj19, playerToPlay, gameActionId);
						}
						ClearActionState();
						RefreshShownCards();
						cardsRevealer.HideGracefully();
						GameAction? emote = ResolveGameAction(gameActionId);
						_jackarooBoard.OnPlayerDidLastAction((JackarooLastActionInfo)cardGameLastActionInfo2, emote);
						return;
					}
				}
			}
		}
		InvalidCastException ex = new InvalidCastException();
		goto IL_0670;
		IL_0066:
		cardGame = base.game;
		bool flag19 = (object)base.game == null;
		object obj25 = !flag19;
		if (obj25 != null)
		{
			goto IL_00f8;
		}
		goto IL_0670;
	}

	private void ClearActionState()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0045: Expected I, but got O
		//IL_006e: Expected O, but got I4
		//IL_00a2: Expected O, but got I
		_thrownCard = null;
		object obj = this + 496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		CardGame cardGame = base.game;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
		object obj3 = obj2;
		nint num = (nint)cardGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v6 (Il2CppClass<CardGame>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X1_v3+130]");
		bool flag = num2 < 0;
		object obj4 = !flag;
		object obj5 = ~obj4;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v6 (Il2CppClass<CardGame>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X1_v3+130]");
			object obj6 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v9-8]");
			if (0 == (nint)obj3)
			{
				_ = 0;
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	private unsafe static int? GetGameActionId(JackarooLastActionInfo action)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_003f: Expected O, but got I4
		//IL_00bf: Expected I4, but got I8
		//IL_00c7: Expected O, but got Ref
		//IL_011b: Expected native int or pointer, but got O
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I4
		//IL_00de: Expected O, but got I4
		//IL_00a3: Expected I4, but got I8
		//IL_00ab: Expected O, but got Ref
		int? result;
		object obj3;
		object obj4;
		if (action != null)
		{
			result = ((CardGameLastActionInfo)action).<GameActionItemId>k__BackingField;
			object obj = (??)((CardGameLastActionInfo)action).<GameActionItemId>k__BackingField & 1;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 != null)
			{
				goto IL_010e;
			}
			int value;
			int? num;
			object obj5 = default(object);
			if (action.<JackarooAction>k__BackingField != JackarooActions.STEAL)
			{
				if (action.<JackarooAction>k__BackingField != JackarooActions.BURN_MY_CARD)
				{
					obj3 = 0;
					obj4 = 0;
					goto IL_013b;
				}
				value = -1;
				num = (int?)(object)(&obj5);
			}
			else
			{
				value = -2;
				num = (int?)(object)(&obj5);
			}
			*(int?*)(nint)num = value;
			obj3 = obj5 & -256;
			obj4 = obj5;
			goto IL_013b;
		}
		return (int?)new NullReferenceException();
		IL_010e:
		return result;
		IL_013b:
		object obj6 = obj4 & 0xFF;
		result = obj6 | obj3;
		goto IL_010e;
	}

	private static GameAction? ResolveGameAction(int? gameActionId)
	{
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_0126: Expected O, but got I4
		//IL_0014: Expected O, but got I4
		//IL_0023: Expected O, but got I4
		//IL_0033: Expected O, but got I
		//IL_01ce: Expected O, but got I
		//IL_01f0: Expected O, but got I4
		//IL_01f9: Expected O, but got I4
		//IL_0075: Expected O, but got I
		//IL_0095: Expected O, but got I4
		//IL_00d8: Expected O, but got I4
		//IL_024d: Expected O, but got I4
		//IL_0256: Expected O, but got I4
		//IL_028d: Expected I4, but got O
		//IL_0132: Expected O, but got I
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_0182: Expected O, but got I4
		object obj = (??)gameActionId & 1;
		if (obj == null)
		{
			goto IL_0120;
		}
		object handle = 147423232 + 3704;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X21_v4+E0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v4+E4]");
		Type typeFromHandle;
		Type enumType;
		object obj6;
		object obj4;
		if ((nint)0 != 0)
		{
			typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X21_v4+98]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = 0;
			enumType = typeFromHandle;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_00b3;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X21_v4+98]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj5 = 0;
			enumType = typeFromHandle;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_00b3;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Array values = Enum.GetValues(enumType);
		bool flag3 = values == null;
		object obj8 = !flag3;
		object obj9 = 0;
		obj4 = obj6;
		if (obj8 != null)
		{
			goto IL_00e6;
		}
		goto IL_026c;
		IL_026c:
		NullReferenceException ex = new NullReferenceException();
		goto IL_027a;
		IL_027a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return JackarooGame.ToGameActionId((int)ex);
		IL_0120:
		return (GameAction?)(object)0;
		IL_00e6:
		object obj10 = (object?)gameActionId >> 32;
		int length = values.Length;
		if (length > (nint)obj10)
		{
			goto IL_0120;
		}
		object obj11 = (nint)0 + (nint)3176;
		obj9 = obj11;
		int? num = default(int?);
		int value = num.Value;
		object obj12 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
		obj4 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v7+E4]");
		bool flag4 = (nint)0 == 0;
		ex = (NullReferenceException)value;
		if (!flag4)
		{
			return JackarooGame.ToGameActionId(value);
		}
		goto IL_027a;
		IL_00b3:
		values = Enum.GetValues(typeFromHandle);
		bool flag5 = values == null;
		obj9 = 0;
		if (!flag5)
		{
			goto IL_00e6;
		}
		goto IL_026c;
	}

	private bool TryPlayThrownCard(JackarooLastActionInfo lastAction)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0044: Expected O, but got I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_007b: Expected I, but got O
		//IL_00a4: Expected O, but got I4
		//IL_0236: Expected I4, but got O
		//IL_00d8: Expected O, but got I
		//IL_0126: Expected O, but got I4
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_0201: Expected O, but got I4
		//IL_014e: Expected I, but got O
		//IL_0177: Expected O, but got I4
		//IL_01ab: Expected O, but got I
		object obj = "___# Content push apply failed [{0}]: {1}" + 2672;
		bool flag = ((LastActionInfo)lastAction).<Action>k__BackingField != (string)obj;
		bool flag2 = !flag;
		object obj2 = !flag2;
		CardGamePlayer cardGamePlayer;
		if (obj2 == null)
		{
			KPlayer kPlayer = base.<player>k__BackingField;
			object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 272;
			object obj4 = obj3;
			nint num = (nint)kPlayer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v11 (Il2CppClass<KPlayer>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X1_v6+130]");
			bool flag3 = num2 < 0;
			object obj5 = !flag3;
			object obj6 = ~obj5;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v11 (Il2CppClass<KPlayer>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X1_v6+130]");
				object obj7 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v13-8]");
				if (0 == (nint)obj4)
				{
					bool isMe = kPlayer.IsMe;
					bool flag4 = !isMe;
					object obj8 = !flag4;
					cardGamePlayer = null;
					if (obj8 != null)
					{
						goto IL_0236;
					}
					cardGamePlayer = base.<player>k__BackingField;
					if (base.<player>k__BackingField == null)
					{
						goto IL_01d2;
					}
					object obj9 = obj3;
					nint num4 = (nint)cardGamePlayer;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v22 (Il2CppClass<CardGamePlayer>)+130]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X1_v13+130]");
					bool flag5 = num5 < 0;
					object obj10 = !flag5;
					object obj11 = ~obj10;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v22 (Il2CppClass<CardGamePlayer>)+C8]");
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X1_v13+130]");
						object obj12 = num6 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X8_v24-8]");
						if (0 == (nint)obj9)
						{
							goto IL_01d2;
						}
					}
				}
			}
			InvalidCastException ex = new InvalidCastException();
			return (byte)(int)ex != 0;
		}
		goto IL_0206;
		IL_01d2:
		_jackarooGameVisualControls.PlayCard(lastAction.<Card>k__BackingField, cardGamePlayer, null, isEventFromServer: true, withCollision: true, (int?)(object)0, 0, playImmediately: false, hideStartingPoint: false);
		goto IL_0236;
		IL_0206:
		return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		IL_0236:
		Card thrownCard = CardUtilExtensions.Clone(lastAction.<Card>k__BackingField);
		_thrownCard = thrownCard;
		object obj13 = this + 496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		goto IL_0206;
	}

	private bool TryPlayOutOfTime(JackarooLastActionInfo lastAction)
	{
		//IL_046e: Expected I4, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0029: Expected I, but got O
		//IL_0052: Expected O, but got I4
		//IL_0086: Expected O, but got I
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_00fe: Expected I, but got O
		//IL_0127: Expected O, but got I4
		//IL_015b: Expected O, but got I
		//IL_01d1: Expected I, but got O
		//IL_01fa: Expected O, but got I4
		//IL_022e: Expected O, but got I
		//IL_02b6: Expected I, but got O
		//IL_02df: Expected O, but got I4
		//IL_0313: Expected O, but got I
		//IL_03e0: Expected O, but got I4
		KPlayer kPlayer = base.<player>k__BackingField;
		bool flag2;
		GameAction? emote;
		if (base.<player>k__BackingField != null)
		{
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 272;
			object obj2 = obj;
			nint num = (nint)kPlayer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4 (Il2CppClass<KPlayer>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X1_v2+130]");
			bool flag = num2 < 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4 (Il2CppClass<KPlayer>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X1_v2+130]");
				object obj5 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v7-8]");
				if (0 == (nint)obj2)
				{
					flag2 = base.<player>k__BackingField.IsMe;
					if (!flag2)
					{
						goto IL_0497;
					}
					KGame kGame = base.game;
					if ((object)base.game == null)
					{
						goto IL_0460;
					}
					object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
					object obj7 = obj6;
					nint num4 = (nint)kGame;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v14 (Il2CppClass<KGame>)+130]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X1_v6+130]");
					bool flag3 = num5 < 0;
					object obj8 = !flag3;
					object obj9 = ~obj8;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v14 (Il2CppClass<KGame>)+C8]");
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X1_v6+130]");
						object obj10 = num6 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X8_v16-8]");
						if (0 == (nint)obj7)
						{
							if (base.game.IsSpectator)
							{
								flag2 = false;
								goto IL_0497;
							}
							KPlayer kPlayer2 = base.<player>k__BackingField;
							if (base.<player>k__BackingField == null)
							{
								goto IL_0460;
							}
							object obj11 = obj;
							nint num7 = (nint)kPlayer2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v20 (Il2CppClass<KPlayer>)+130]");
							nint num8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X1_v8+130]");
							bool flag4 = num8 < 0;
							object obj12 = !flag4;
							object obj13 = ~obj12;
							if (obj13 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v20 (Il2CppClass<KPlayer>)+C8]");
								nint num9 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X1_v8+130]");
								object obj14 = num9 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v22-8]");
								if (0 == (nint)obj11)
								{
									SeatStatus seatStatus = base.<player>k__BackingField.SeatStatus;
									if (seatStatus != SeatStatus.Idle)
									{
										goto IL_044c;
									}
									if (lastAction != null)
									{
										CardGamePlayer cardGamePlayer = base.<player>k__BackingField;
										if (base.<player>k__BackingField != null)
										{
											Card card = (Card)obj;
											nint num10 = (nint)cardGamePlayer;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v27 (Il2CppClass<CardGamePlayer>)+130]");
											nint num11 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X1_v14 (Card)+130]");
											bool flag5 = num11 < 0;
											object obj15 = !flag5;
											object obj16 = ~obj15;
											if (obj16 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v27 (Il2CppClass<CardGamePlayer>)+C8]");
												nint num12 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X1_v14 (Card)+130]");
												object obj17 = num12 + 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v29-8]");
												if (0 == (nint)card)
												{
													if (((LastActionInfo)lastAction).<ActionPlayer>k__BackingField == ((KPlayer)cardGamePlayer).<Index>k__BackingField)
													{
														int? gameActionId = GetGameActionId(lastAction);
														emote = ResolveGameAction(gameActionId);
														if (_thrownCard != null)
														{
															card = lastAction.<Card>k__BackingField;
															bool flag6 = _thrownCard.Equals(lastAction.<Card>k__BackingField);
															bool flag7 = !flag6;
															object obj18 = !flag7;
															if (obj18 != null)
															{
																goto IL_0414;
															}
														}
														JackarooPlayer playerToPlay = player;
														PlayCard(lastAction.<Card>k__BackingField, playerToPlay, gameActionId);
														goto IL_0414;
													}
													goto IL_044c;
												}
											}
											goto IL_0452;
										}
									}
									goto IL_0460;
								}
							}
						}
					}
				}
			}
			goto IL_0452;
		}
		goto IL_0460;
		IL_0414:
		if ((object)_jackarooBoard != null)
		{
			_jackarooBoard.OnPlayerDidLastAction(lastAction, emote);
			return true;
		}
		goto IL_0460;
		IL_044c:
		return false;
		IL_0460:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0497:
		return flag2;
		IL_0452:
		InvalidCastException ex2 = new InvalidCastException();
		goto IL_0460;
	}

	private bool TryPlaySteal(JackarooLastActionInfo lastAction)
	{
		//IL_053c: Expected O, but got I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0053: Expected I, but got O
		//IL_007c: Expected O, but got I4
		//IL_0578: Expected I4, but got O
		//IL_00b0: Expected O, but got I
		//IL_00fe: Expected O, but got I4
		//IL_015d: Expected O, but got I4
		//IL_0235: Expected O, but got I4
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_0180: Expected I, but got O
		//IL_01a9: Expected O, but got I4
		//IL_030e: Expected I4, but got I8
		//IL_0324: Expected O, but got I
		//IL_033e: Expected O, but got I4
		//IL_02e8: Expected O, but got I4
		//IL_029d: Expected O, but got I
		//IL_01dd: Expected O, but got I
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected O, but got Unknown
		//IL_039d: Expected I, but got O
		//IL_03c6: Expected O, but got I4
		//IL_03fa: Expected O, but got I
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Expected O, but got Unknown
		//IL_0449: Expected I, but got O
		//IL_0472: Expected O, but got I4
		//IL_04a6: Expected O, but got I
		if (lastAction.<JackarooAction>k__BackingField != JackarooActions.STEAL)
		{
			goto IL_0529;
		}
		KPlayer kPlayer = base.<player>k__BackingField;
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 272;
		object obj2 = obj;
		nint num = (nint)kPlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X8_v9 (Il2CppClass<KPlayer>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X1_v5+130]");
		bool flag = num2 < 0;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X8_v9 (Il2CppClass<KPlayer>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X1_v5+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v11-8]");
			if (0 == (nint)obj2)
			{
				bool isMe = kPlayer.IsMe;
				bool flag2 = !isMe;
				object obj6 = !flag2;
				if (obj6 != null)
				{
					goto IL_0529;
				}
				if (_thrownCard != null)
				{
					bool flag3 = _thrownCard.Equals(lastAction.<Card>k__BackingField);
					bool flag4 = !flag3;
					object obj7 = !flag4;
					if (obj7 != null)
					{
						goto IL_024a;
					}
				}
				CardGamePlayer cardGamePlayer = base.<player>k__BackingField;
				if (base.<player>k__BackingField == null)
				{
					goto IL_0204;
				}
				object obj8 = obj;
				nint num4 = (nint)cardGamePlayer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v48 (Il2CppClass<CardGamePlayer>)+130]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X1_v23+130]");
				bool flag5 = num5 < 0;
				object obj9 = !flag5;
				object obj10 = ~obj9;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v48 (Il2CppClass<CardGamePlayer>)+C8]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X1_v23+130]");
					object obj11 = num6 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X8_v50-8]");
					if (0 == (nint)obj8)
					{
						goto IL_0204;
					}
				}
			}
		}
		goto IL_056a;
		IL_0379:
		object obj12 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
		object obj13 = obj12;
		CardGame cardGame;
		nint num7 = (nint)cardGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v17 (Il2CppClass<CardGame>)+130]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X1_v9+130]");
		bool flag6 = num8 < 0;
		object obj14 = !flag6;
		object obj15 = ~obj14;
		object card;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v17 (Il2CppClass<CardGame>)+C8]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X1_v9+130]");
			object obj16 = num9 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v19-8]");
			if (0 == (nint)obj13)
			{
				card = Enumerable.Last((IEnumerable<object>)cardGame.<OrderedPlayedCards>k__BackingField);
				CardGamePlayer cardGamePlayer2 = base.<player>k__BackingField;
				if (base.<player>k__BackingField == null)
				{
					goto IL_04cd;
				}
				object obj17 = obj;
				nint num10 = (nint)cardGamePlayer2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v29 (Il2CppClass<CardGamePlayer>)+130]");
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X1_v15+130]");
				bool flag7 = num11 < 0;
				object obj18 = !flag7;
				object obj19 = ~obj18;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v29 (Il2CppClass<CardGamePlayer>)+C8]");
					nint num12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X1_v15+130]");
					object obj20 = num12 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v31-8]");
					if (0 == (nint)obj17)
					{
						goto IL_04cd;
					}
				}
			}
		}
		goto IL_056a;
		IL_0204:
		_jackarooGameVisualControls.PlayCard(lastAction.<Card>k__BackingField, base.<player>k__BackingField, null, isEventFromServer: true, withCollision: true, (int?)(object)0, 0, playImmediately: false, hideStartingPoint: false);
		cardsRevealer.HideGracefully();
		goto IL_024a;
		IL_024a:
		int? num13 = ((CardGameLastActionInfo)lastAction).<GameActionItemId>k__BackingField;
		object obj21 = (??)((CardGameLastActionInfo)lastAction).<GameActionItemId>k__BackingField & 1;
		int? num14;
		if (obj21 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E806C]");
			object obj22 = (nint)0 & (nint)1;
			bool flag8 = obj22 == null;
			num14 = num13;
			if (!flag8)
			{
				goto IL_02c2;
			}
		}
		else
		{
			int? num15 = -2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E806C]");
			object obj23 = (nint)0 & (nint)1;
			bool flag9 = obj23 == null;
			object obj24 = !flag9;
			num13 = num15;
			num14 = num15;
			if (obj24 != null)
			{
				goto IL_02c2;
			}
		}
		_ = 1;
		cardGame = base.game;
		num13 = num14;
		goto IL_0379;
		IL_0529:
		object obj25 = lastAction.<JackarooAction>k__BackingField - 262144;
		return obj25 == null;
		IL_056a:
		InvalidCastException ex = new InvalidCastException();
		return (byte)(int)ex != 0;
		IL_04cd:
		_jackarooGameVisualControls.PlayCard((Card)card, base.<player>k__BackingField, null, isEventFromServer: true, withCollision: true, num13, 0, playImmediately: false, hideStartingPoint: false);
		Card thrownCard = CardUtilExtensions.Clone((Card)card);
		_thrownCard = thrownCard;
		object obj26 = this + 496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		goto IL_0529;
		IL_02c2:
		cardGame = base.game;
		bool flag10 = (object)base.game == null;
		object obj27 = !flag10;
		if (obj27 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0379;
	}

	private bool TryPlayBurnOtherCardRandom(JackarooLastActionInfo lastAction)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_04a2: Expected O, but got I4
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0089: Expected I, but got O
		//IL_00b2: Expected O, but got I4
		//IL_04eb: Expected I4, but got O
		//IL_00e6: Expected O, but got I
		//IL_0134: Expected O, but got I4
		//IL_0193: Expected O, but got I4
		//IL_026b: Expected O, but got I4
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected O, but got Unknown
		//IL_01b6: Expected I, but got O
		//IL_01df: Expected O, but got I4
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected O, but got Unknown
		//IL_02cd: Expected I, but got O
		//IL_02f6: Expected O, but got I4
		//IL_0213: Expected O, but got I
		//IL_032a: Expected O, but got I
		//IL_0391: Expected O, but got I
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected O, but got Unknown
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected O, but got Unknown
		//IL_0408: Expected O, but got I
		//IL_0419: Expected I, but got O
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected O, but got Unknown
		//IL_0457: Expected O, but got I4
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 896;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (lastAction.<JackarooAction>k__BackingField != JackarooActions.BURN_OTHER_CARD_RANDOM)
		{
			goto IL_048f;
		}
		KPlayer kPlayer = base.<player>k__BackingField;
		object obj4 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 272;
		object obj5 = obj4;
		nint num = (nint)kPlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v9 (Il2CppClass<KPlayer>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X1_v7+130]");
		bool flag = num2 < 0;
		object obj6 = !flag;
		object obj7 = ~obj6;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v9 (Il2CppClass<KPlayer>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X1_v7+130]");
			object obj8 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v11-8]");
			if (0 == (nint)obj5)
			{
				bool isMe = kPlayer.IsMe;
				bool flag2 = !isMe;
				object obj9 = !flag2;
				if (obj9 != null)
				{
					goto IL_048f;
				}
				if (_thrownCard != null)
				{
					bool flag3 = _thrownCard.Equals(lastAction.<Card>k__BackingField);
					bool flag4 = !flag3;
					object obj10 = !flag4;
					if (obj10 != null)
					{
						goto IL_0514;
					}
				}
				CardGamePlayer cardGamePlayer = base.<player>k__BackingField;
				if (base.<player>k__BackingField == null)
				{
					goto IL_023a;
				}
				object obj11 = obj4;
				nint num4 = (nint)cardGamePlayer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v39 (Il2CppClass<CardGamePlayer>)+130]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X1_v22+130]");
				bool flag5 = num5 < 0;
				object obj12 = !flag5;
				object obj13 = ~obj12;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v39 (Il2CppClass<CardGamePlayer>)+C8]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X1_v22+130]");
					object obj14 = num6 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X8_v41-8]");
					if (0 == (nint)obj11)
					{
						goto IL_023a;
					}
				}
			}
		}
		goto IL_04dd;
		IL_0514:
		CardGame cardGame = base.game;
		object obj15 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
		object obj16 = obj15;
		nint num7 = (nint)cardGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v18 (Il2CppClass<CardGame>)+130]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X1_v10+130]");
		bool flag6 = num8 < 0;
		object obj17 = !flag6;
		object obj18 = ~obj17;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v18 (Il2CppClass<CardGame>)+C8]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X1_v10+130]");
			object obj19 = num9 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v20-8]");
			if (0 == (nint)obj16)
			{
				int rotatedNextIndex = IntegerExtensions.GetRotatedNextIndex(((LastActionInfo)lastAction).<ActionPlayer>k__BackingField, 1, 1, 5);
				int index = rotatedNextIndex - 1;
				object obj20 = (nint)0 + (nint)2760;
				object card = ((List<object>)(object)cardGame.<PlayedCards>k__BackingField).get_Item(index);
				Card card2 = CardUtilExtensions.Clone((Card)card);
				object obj21 = obj2 + 24;
				obj21 = card2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj22 = typeof(SqlSingle[]) + 2376;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj23 = (nint)0 + (nint)2392;
				Action action = default(Action);
				action..ctor(obj2, (IntPtr)obj23);
				object obj24 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
				object obj25 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v32+E4]");
				bool flag7 = (nint)0 == 0;
				object obj26 = !flag7;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.5f, action);
				goto IL_048f;
			}
		}
		goto IL_04dd;
		IL_023a:
		_jackarooGameVisualControls.PlayCard(lastAction.<Card>k__BackingField, base.<player>k__BackingField, null, isEventFromServer: true, withCollision: true, (int?)(object)0, 0, playImmediately: false, hideStartingPoint: false);
		cardsRevealer.HideGracefully();
		_thrownCard = lastAction.<Card>k__BackingField;
		object obj27 = this + 496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		goto IL_0514;
		IL_048f:
		object obj28 = lastAction.<JackarooAction>k__BackingField - 65536;
		return obj28 == null;
		IL_04dd:
		InvalidCastException ex = new InvalidCastException();
		return (byte)(int)ex != 0;
	}

	protected override void PlayPlayerPlayedCard()
	{
	}

	private void PlayCard(Card cardToPlay, CardGamePlayer playerToPlay, int? gameActionId)
	{
		_jackarooGameVisualControls.PlayCard(cardToPlay, playerToPlay, null, isEventFromServer: true, withCollision: true, gameActionId, 0, playImmediately: false, hideStartingPoint: false);
	}

	protected override void OnGamePerspectiveChanged(bool isPerspectiveTopDown)
	{
		//IL_01c5: Expected O, but got I4
		//IL_01fb: Expected F4, but got I8
		//IL_041c: Expected F4, but got I8
		//IL_0429: Expected F4, but got I8
		//IL_01e9: Expected F4, but got I8
		//IL_02b1: Expected O, but got I4
		//IL_00e7: Expected O, but got I4
		//IL_0115: Expected F4, but got I4
		//IL_045a: Expected O, but got I4
		//IL_02d3: Expected O, but got I4
		//IL_0107: Expected F4, but got I4
		//IL_0083: Expected O, but got I4
		//IL_047c: Expected O, but got I4
		//IL_0131: Expected F4, but got I4
		//IL_00b1: Expected F4, but got I4
		//IL_04ad: Expected O, but got I4
		//IL_0304: Expected O, but got I4
		//IL_0123: Expected F4, but got I4
		//IL_0298: Expected F4, but got I4
		//IL_02a1: Expected F4, but got I4
		//IL_00a3: Expected F4, but got I4
		//IL_023f: Expected F8, but got I4
		//IL_014d: Expected F4, but got I4
		//IL_04de: Expected O, but got I4
		//IL_0326: Expected O, but got I4
		//IL_013f: Expected F4, but got I4
		//IL_0169: Expected F4, but got I4
		//IL_0500: Expected O, but got I4
		//IL_0357: Expected O, but got I4
		//IL_015b: Expected F4, but got I4
		//IL_0522: Expected O, but got I4
		//IL_0379: Expected O, but got I4
		//IL_0566: Expected O, but got I4
		//IL_057d: Expected F4, but got I4
		//IL_0264: Expected F8, but got I4
		//IL_03d4: Expected F4, but got I4
		Transform target;
		float duration;
		float endValue2;
		float duration2;
		bool flag5;
		float num7;
		float num8;
		if (direction != UserBoxDirection.Left)
		{
			if (direction == UserBoxDirection.Top)
			{
				bool isTablet = ScreenUtility.IsTablet;
				bool isTablet2 = ScreenUtility.IsTablet;
				bool flag = !isTablet;
				object obj = !flag;
				object obj2 = ~obj;
				float num = ((obj2 != null) ? 1.1421286E+09f : 1.1426202E+09f);
				object obj3 = !flag;
				object obj4 = ~obj3;
				float num2 = ((obj4 != null) ? 1.1418829E+09f : 1.1426202E+09f);
				bool flag2 = !isTablet2;
				object obj5 = !flag2;
				object obj6 = ~obj5;
				float num3 = ((obj6 != null) ? 1.06199776E+09f : 1.0636755E+09f);
				object obj7 = !flag2;
				object obj8 = ~obj7;
				float num4 = ((obj8 != null) ? 1.06032006E+09f : 1.06132666E+09f);
				bool flag3 = !isPerspectiveTopDown;
				object obj9 = !flag3;
				object obj10 = ~obj9;
				float num5 = ((obj10 != null) ? num4 : num3);
				object obj11 = !flag3;
				object obj12 = ~obj11;
				float endValue = ((obj12 != null) ? num2 : num);
				int num6 = ShortcutExtensions.DOKill(_transform);
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMoveY(_transform, endValue, 0.2f);
				target = _transform;
				duration = 1.04522054E+09f;
				endValue2 = num5;
				goto IL_03e1;
			}
			if (direction != UserBoxDirection.Right)
			{
				return;
			}
			bool isTablet3 = ScreenUtility.IsTablet;
			bool flag4 = !isTablet3;
			object obj13 = !flag4;
			object obj14 = ~obj13;
			duration2 = ((obj14 != null) ? 1.1390812E+09f : 1.1439309E+09f);
			bool isTablet4 = ScreenUtility.IsTablet;
			flag5 = !isTablet4;
			num7 = 1.1393434E+09f;
			num8 = 1.1444224E+09f;
		}
		else
		{
			bool isTablet5 = ScreenUtility.IsTablet;
			bool flag6 = !isTablet5;
			object obj15 = !flag6;
			object obj16 = ~obj15;
			duration2 = ((obj16 != null) ? 3.285975E+09f : 3.2913326E+09f);
			bool isTablet6 = ScreenUtility.IsTablet;
			flag5 = !isTablet6;
			num7 = 3.2863027E+09f;
			num8 = 3.2917422E+09f;
		}
		object obj17 = !flag5;
		object obj18 = ~obj17;
		float num9 = ((obj18 != null) ? num7 : num8);
		bool isTablet7 = ScreenUtility.IsTablet;
		bool isTablet8 = ScreenUtility.IsTablet;
		bool flag7 = !isTablet7;
		object obj19 = !flag7;
		object obj20 = ~obj19;
		if (obj20 == null)
		{
		}
		object obj21 = !flag7;
		object obj22 = ~obj21;
		if (obj22 == null)
		{
		}
		bool flag8 = !isTablet8;
		object obj23 = !flag8;
		object obj24 = ~obj23;
		double num10 = ((obj24 != null) ? 1061997773.0 : 1.0);
		bool flag9 = !isPerspectiveTopDown;
		object obj25 = !flag9;
		object obj26 = ~obj25;
		if (obj26 != null)
		{
			duration2 = num9;
		}
		object obj27 = !flag9;
		object obj28 = ~obj27;
		if (obj28 == null)
		{
		}
		object obj29 = !flag9;
		object obj30 = ~obj29;
		double num11 = ((obj30 != null) ? num10 : 1063675494.0);
		int num12 = ShortcutExtensions.DOKill(_transform);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOLocalMove(_transform, (Vector3)0, duration2);
		target = _transform;
		duration = 1.04522054E+09f;
		endValue2 = (float)num11;
		goto IL_03e1;
		IL_03e1:
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = ShortcutExtensions.DOScale(target, endValue2, duration);
	}

	protected override bool CanJoinGame()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_004f: Expected O, but got I4
		//IL_00cf: Expected I4, but got O
		bool flag = base.CanJoinGame();
		if (flag)
		{
			object obj = typeof(Queue<string>) + 848;
			object obj2 = (nint)0 + (nint)2200;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			if ((object)sessionModel != null)
			{
				User localUser = sessionModel.LocalUser;
				return SFSKammelnaUserExtensions.IsSubscribed(localUser);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		return flag;
	}
}
