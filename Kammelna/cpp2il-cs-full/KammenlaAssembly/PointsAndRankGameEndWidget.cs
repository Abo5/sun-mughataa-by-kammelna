using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class PointsAndRankGameEndWidget : GameEndWidget
{
	[Serializable]
	public class PerformanceCriteria
	{
		public Image Border;

		public TextMeshProUGUI Value;

		public void Setup(PlayerPerformance performance, PlayerPerformanceSprites sprites)
		{
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Expected O, but got Unknown
			//IL_0061: Expected O, but got I
			Sprite stampBorder = sprites.GetStampBorder(performance);
			Border.sprite = stampBorder;
			Color stampColor = sprites.GetStampColor(performance);
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1008;
			Value.color = (Color)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Enum enumeration = default(Enum);
			string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
			TextMeshProExtensions.Localize(Value, friendlyName);
		}

		public void Setup(CheatingPerformance performance, PlayerPerformanceSprites sprites)
		{
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Expected O, but got Unknown
			//IL_0061: Expected O, but got I
			Sprite stampBorder = sprites.GetStampBorder(performance);
			Border.sprite = stampBorder;
			Color stampColor = sprites.GetStampColor(performance);
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 936;
			Value.color = (Color)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Enum enumeration = default(Enum);
			string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
			TextMeshProExtensions.Localize(Value, friendlyName);
		}
	}

	private sealed class <>c__DisplayClass24_0
	{
		public PointsAndRankGameEndWidget <>4__this;

		public int currPoints;

		internal void <AnimatedPopulate>b__0()
		{
			PointsAndRankGameEndWidget pointsAndRankGameEndWidget = <>4__this;
			CardGameEndScores gameEnd = pointsAndRankGameEndWidget.gameEnd;
			pointsAndRankGameEndWidget.AnimatePointsSlider(gameEnd.<PreviousPoints>k__BackingField, currPoints);
		}
	}

	private sealed class <>c__DisplayClass27_0
	{
		public PointsAndRankGameEndWidget <>4__this;

		public int maxSubRank;

		public int newPoints;

		public PlayerRank prevRank;

		public int minSubRank;

		public Action <>9__3;

		internal void <AnimatePointsSlider>b__0()
		{
			PointsAndRankGameEndWidget pointsAndRankGameEndWidget = <>4__this;
			int points = maxSubRank + 1;
			pointsAndRankGameEndWidget.giantRank.SetRank(points, isNew: false, alsoAnimate: true);
			int prePoints = maxSubRank + 1;
			<>4__this.AnimatePointsSlider(prePoints, newPoints);
			PlayerRank playerRank = prevRank;
			if (playerRank.<SubRanksCount>k__BackingField == 4)
			{
				<>4__this.ShowRankingAnimation(rankedUp: true);
				<>4__this.PlayRankUpSound();
			}
			else
			{
				<>4__this.PlaySubRankUpSound();
			}
		}

		internal void <AnimatePointsSlider>b__1()
		{
			PointsAndRankGameEndWidget pointsAndRankGameEndWidget = <>4__this;
			int points = minSubRank - 1;
			pointsAndRankGameEndWidget.giantRank.SetRank(points, isNew: false, alsoAnimate: true);
			int prePoints = minSubRank - 1;
			<>4__this.AnimatePointsSlider(prePoints, newPoints);
			PlayerRank playerRank = prevRank;
			if (playerRank.<SubRanksCount>k__BackingField != 0)
			{
				<>4__this.PlaySubRankDownSound();
				return;
			}
			<>4__this.ShowRankingAnimation(rankedUp: false);
			<>4__this.PlayRankDownSound();
		}

		internal void <AnimatePointsSlider>b__2()
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected O, but got Unknown
			//IL_0032: Expected O, but got I4
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Expected O, but got Unknown
			//IL_006a: Expected O, but got I
			//IL_0078: Expected I, but got O
			PointsAndRankGameEndWidget pointsAndRankGameEndWidget = <>4__this;
			object obj = this + 48;
			Action callBack = (Action)obj;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				object obj3 = typeof(SqlSingle[]) + 2376;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj4 = (nint)0 + (nint)1200;
				Action action = default(Action);
				action..ctor(this, (IntPtr)obj4);
				<>9__3 = action;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				callBack = action;
			}
			pointsAndRankGameEndWidget.criteriaSection.AnimateOverallStamps(callBack);
		}

		internal void <AnimatePointsSlider>b__3()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0020: Expected O, but got I
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			//IL_0078: Expected I, but got O
			//IL_00a2: Expected O, but got I4
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = (nint)0 + (nint)1432;
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(<>4__this, (IntPtr)obj2);
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.2f, action);
		}
	}

	private sealed class <>c__DisplayClass28_0
	{
		public PointsAndRankGameEndWidget <>4__this;

		public float tweenTo;

		public int nowPoints;

		public int earnedPointsFinalVal;

		public Action callBack;

		internal void <StartAnimation>b__0()
		{
			<>4__this.StartAnimation2(tweenTo, nowPoints, earnedPointsFinalVal, callBack);
		}
	}

	private sealed class <>c__DisplayClass29_0
	{
		public PointsAndRankGameEndWidget <>4__this;

		public float tweenTo;

		public Action callBack;

		public TweenCallback <>9__1;

		public DOGetter<float> <>9__2;

		public DOSetter<float> <>9__3;

		internal void <StartAnimation2>b__1()
		{
			<>4__this.StartAnimation2Point1(tweenTo);
		}

		internal float <StartAnimation2>b__2()
		{
			PointsAndRankGameEndWidget pointsAndRankGameEndWidget = <>4__this;
			PointsProgressBar pointsBar = pointsAndRankGameEndWidget.PointsBar;
			Vector2 anchorMax = pointsBar.PointsIndicator.anchorMax;
			float result = default(float);
			return result;
		}

		internal void <StartAnimation2>b__3(float val)
		{
			PointsAndRankGameEndWidget pointsAndRankGameEndWidget = <>4__this;
			PointsProgressBar pointsBar = pointsAndRankGameEndWidget.PointsBar;
			UIExtensions.SetAnchorX(pointsBar.PointsIndicator, val);
		}

		internal void <StartAnimation2>b__0()
		{
			Action action = callBack;
			if (callBack != null)
			{
				IntPtr invoke_impl = ((Delegate)action).invoke_impl;
				IntPtr method_code = ((Delegate)action).method_code;
				IntPtr method = ((Delegate)action).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass32_0
	{
		public Animator animator;

		internal bool <RankAnimation>b__0()
		{
			//IL_008b: Expected I4, but got O
			//IL_0072: Invalid comparison between F4 and I4
			if ((object)animator != null)
			{
				AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);
				AnimatorStateInfo animatorStateInfo = default(AnimatorStateInfo);
				float normalizedTime = animatorStateInfo.normalizedTime;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTZ not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIT not yet implemented.\"");
				float num = normalizedTime - 1.0651855E+09f;
				return num < 0f;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <RankAnimation>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public Animator animator;

		private <>c__DisplayClass32_0 <>8__1;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <RankAnimation>d__32(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0309: Expected I4, but got I8
			//IL_0418: Expected I4, but got O
			//IL_0198: Expected I4, but got I8
			//IL_0040: Expected O, but got I4
			//IL_005d: Expected I4, but got I8
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected O, but got Unknown
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected O, but got Unknown
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Expected O, but got Unknown
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected O, but got Unknown
			//IL_03d2: Expected O, but got I4
			//IL_0269: Unknown result type (might be due to invalid IL or missing references)
			//IL_026e: Expected O, but got Unknown
			//IL_0289: Expected O, but got I
			//IL_029c: Expected I, but got O
			//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b0: Expected O, but got Unknown
			//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03eb: Expected O, but got Unknown
			//IL_03f4: Expected O, but got I4
			//IL_0184: Expected O, but got I4
			//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d7: Expected O, but got Unknown
			if (<>1__state != 2)
			{
				if (<>1__state == 1)
				{
					<>1__state = -1;
					goto IL_0437;
				}
				bool flag = <>1__state == 0;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_0396;
				}
				<>1__state = -1;
				object obj2 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2856;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj3 = default(object);
				obj3..ctor();
				object obj4 = this + 40;
				obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if (obj4 != null)
				{
					object obj5 = obj4 + 16;
					obj5 = animator;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					<>c__DisplayClass32_0 <>c__DisplayClass32_ = <>8__1;
					if (<>8__1 != null)
					{
						object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
						object obj7 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v25+E4]");
						if ((nint)0 != 0)
						{
							if (<>c__DisplayClass32_.animator == null)
							{
								object obj8 = 0;
								goto IL_03e0;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							bool flag2 = <>c__DisplayClass32_.animator == null;
							bool flag3 = !flag2;
							object obj8 = 0;
							if (!flag3)
							{
								goto IL_03e0;
							}
						}
						goto IL_0437;
					}
				}
			}
			else
			{
				<>1__state = -1;
				<>c__DisplayClass32_0 <>c__DisplayClass32_2 = <>8__1;
				if (<>8__1 != null && (object)<>c__DisplayClass32_2.animator != null)
				{
					GameObject gameObject = <>c__DisplayClass32_2.animator.gameObject;
					if ((object)gameObject != null)
					{
						gameObject.SetActive(value: false);
						goto IL_0396;
					}
				}
			}
			goto IL_040a;
			IL_0396:
			return false;
			IL_040a:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0437:
			<>c__DisplayClass32_0 <>c__DisplayClass32_3 = <>8__1;
			if (<>8__1 != null && (object)<>c__DisplayClass32_3.animator != null)
			{
				GameObject gameObject2 = <>c__DisplayClass32_3.animator.gameObject;
				if ((object)gameObject2 != null)
				{
					gameObject2.SetActive(value: true);
					<>c__DisplayClass32_0 <>c__DisplayClass32_4 = <>8__1;
					if (<>8__1 != null && (object)<>c__DisplayClass32_4.animator != null)
					{
						<>c__DisplayClass32_4.animator.Play(0);
						object obj9 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2128;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj10 = (nint)0 + (nint)1248;
						Func<bool> func = default(Func<bool>);
						func..ctor((object)<>8__1, (IntPtr)obj10);
						object obj11 = typeof(UsageHint) + 1688;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						WaitWhile waitWhile = default(WaitWhile);
						waitWhile..ctor(func);
						object obj12 = this + 24;
						obj12 = waitWhile;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						_ = 2;
						return true;
					}
				}
			}
			goto IL_040a;
			IL_03e0:
			object obj13 = this + 24;
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 1;
			return true;
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
			object obj2 = (nint)0 + (nint)1256;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	public RankUI giantRank;

	public PointsProgressBar PointsBar;

	public RectTransform PointsSectionContainer;

	private GameSoundAlbum gameSoundAlbum;

	public TextMeshProUGUI EarnedOrDeducted;

	public TextMeshProUGUI EarnedPointsValue;

	public float pointsFillTime = 1.5f;

	private PlayerPerformanceSprites performanceSprites;

	public PopupUI stampsTarget;

	public CriteriaSection criteriaSection;

	private GameObject winningStreak;

	private TextMeshProUGUI bonusText;

	private Animator RankUpAnimation;

	private Animator RankDownAnimation;

	private Animator RankTextAnimation;

	public LayoutElement AvatarSection;

	public RectTransform BodySection;

	private CardGameEndScores gameEnd;

	public static readonly Color PointsGreen;

	public static readonly Color PointsRed;

	private bool IsFriendly
	{
		get
		{
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c9: Expected O, but got Unknown
			//IL_01eb: Expected O, but got I4
			//IL_00b7: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			//IL_006c: Expected O, but got I
			//IL_021b: Expected O, but got I4
			//IL_01be: Expected I4, but got O
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Expected O, but got Unknown
			//IL_0113: Expected O, but got I4
			//IL_013c: Expected O, but got I
			object obj = this + 32;
			KGame kGame = (KGame)obj;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v27+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj6 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
				obj = kGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if ((object)kGame == null)
				{
					goto IL_01b0;
				}
			}
			bool flag3 = (byte)(int)kGame.Room != 0;
			if (flag3)
			{
				KGame kGame2 = (KGame)obj;
				bool flag4 = obj == null;
				object obj7 = !flag4;
				if (obj7 == null)
				{
					object obj8 = typeof(MemberAchievementClanFeedData) + 2976;
					object obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v13+E4]");
					bool flag5 = (nint)0 == 0;
					object obj10 = !flag5;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj11 = (nint)0 + (nint)24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
					obj = kGame2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					if ((object)kGame2 == null)
					{
						goto IL_01b0;
					}
				}
				Room room = kGame2.Room;
				GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room);
				return GameTypeExtensions.IsFriendly(gameType);
			}
			return flag3;
			IL_01b0:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public override void PrepareAnimation(CardGameEndScores rankReport)
	{
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_00a6: Expected O, but got I4
		//IL_00da: Expected O, but got I4
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0133: Expected O, but got I
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_0254: Expected I4, but got O
		//IL_027e: Expected O, but got I4
		//IL_0286: Expected I4, but got O
		//IL_0198: Expected O, but got I4
		//IL_0300: Expected O, but got I
		//IL_032f: Expected I4, but got O
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_01f9: Expected I4, but got O
		//IL_0223: Expected O, but got I4
		//IL_0368: Expected O, but got I4
		//IL_037e: Expected O, but got I
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected O, but got Unknown
		//IL_042d: Expected O, but got I4
		//IL_0239: Expected I4, but got O
		//IL_03e7: Expected O, but got I4
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected O, but got Unknown
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Expected O, but got Unknown
		//IL_0479: Expected O, but got I4
		//IL_04a2: Expected O, but got I
		object obj = this + 176;
		CardGameEndScores cardGameEndScores = default(CardGameEndScores);
		obj = cardGameEndScores;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		CardGameEndScores cardGameEndScores2 = (CardGameEndScores)obj;
		int bonusPoints = ((CardGameEndScores)obj).BonusPoints;
		object obj2 = obj;
		GameObject gameObject = criteriaSection.gameObject;
		bool active;
		if (IsFriendly)
		{
			active = false;
		}
		else
		{
			object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v56+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Games currentGame = Preferences.CurrentGame;
			object obj6 = currentGame - 2;
			bool flag2 = obj6 == null;
			bool flag3 = !flag2;
			active = flag3;
		}
		gameObject.SetActive(active);
		object obj7 = typeof(Queue<string>) + 848;
		object obj8 = (nint)0 + (nint)2200;
		criteriaSection.InitPerformanceVars(cardGameEndScores);
		int points;
		int num;
		if (IsFriendly)
		{
			object obj9 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v48+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			User localUser = sessionModel.LocalUser;
			PlayerRank rank = SFSKammelnaUserExtensions.GetRank(localUser);
			object obj11 = rank + 24;
			points = (int)obj11;
			object obj12 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v45+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				num = (int)obj11;
				goto IL_0294;
			}
		}
		else
		{
			object obj14 = obj + 40;
			num = (int)obj14;
			object obj12 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v45+E4]");
			bool flag6 = (nint)0 == 0;
			object obj15 = !flag6;
			points = (int)obj14;
			if (obj15 == null)
			{
				goto IL_0294;
			}
		}
		goto IL_02ab;
		IL_04d0:
		CardGame cardGame;
		criteriaSection.PrepareCheatAndCatch(cardGame);
		GameObject gameObject2 = base.gameObject;
		gameObject2.SetActive(value: true);
		return;
		IL_02ab:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		bool isNew = SFSKammelnaUserExtensions.IsNew(localUser2);
		int num2 = cardGameEndScores2.<CurrentPoints>k__BackingField - bonusPoints;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v4+28]");
		object obj16 = (nint)num2 - (nint)0;
		giantRank.SetRank(points, isNew);
		object obj17 = ~obj16;
		bool earned = (byte)(obj17 >> 31) != 0;
		InitializeEarnedPoints(earned);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v4+28]");
		InitializeBlueProgressPosition(0, num2);
		InitializeStreak();
		object obj18 = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E679E]");
		object obj19 = (nint)0 & (nint)1;
		object obj20;
		if (obj19 != null)
		{
			obj20 = this + 32;
			cardGame = (CardGame)obj20;
			if (obj20 != null)
			{
				goto IL_03cb;
			}
		}
		else
		{
			_ = 1;
			obj20 = this + 32;
			cardGame = (CardGame)obj20;
			bool flag7 = obj20 == null;
			object obj21 = !flag7;
			if (obj21 != null)
			{
				goto IL_03cb;
			}
		}
		object obj22 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v31+E4]");
		bool flag8 = (nint)0 == 0;
		object obj24 = !flag8;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj25 = (nint)0 + (nint)24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		CardGame cardGame2 = default(CardGame);
		obj20 = cardGame2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		cardGame = cardGame2;
		goto IL_04d0;
		IL_03cb:
		bool flag9 = (object)criteriaSection == null;
		object obj26 = !flag9;
		if (obj26 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_04d0;
		IL_0294:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		points = num;
		goto IL_02ab;
	}

	public override void Populate(CardGameEndScores rankReport)
	{
		CardGameEndScores cardGameEndScores = gameEnd;
		int bonusPoints = gameEnd.BonusPoints;
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		CardGameEndScores cardGameEndScores2 = gameEnd;
		int newPoints = cardGameEndScores.<CurrentPoints>k__BackingField - bonusPoints;
		AnimatePointsSlider(cardGameEndScores2.<PreviousPoints>k__BackingField, newPoints);
	}

	public override Sequence AnimatedPopulate(CardGameEndScores rankReport)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0074: Expected O, but got I4
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01ae: Expected O, but got I
		//IL_01c9: Expected I, but got O
		//IL_0208: Expected O, but got I4
		//IL_03b9: Expected O, but got I4
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected O, but got Unknown
		//IL_0408: Expected O, but got I4
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Expected I4, but got Unknown
		//IL_0484: Expected O, but got I4
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_0261: Expected O, but got I4
		//IL_02b0: Expected F8, but got I4
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass24_0 <>c__DisplayClass24_ = default(<>c__DisplayClass24_0);
		<>c__DisplayClass24_..ctor();
		if (<>c__DisplayClass24_ != null)
		{
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj3 = <>c__DisplayClass24_ + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sequence sequence = DOTween.Sequence();
			if (rankReport != null)
			{
				CardGameEndScores cardGameEndScores = gameEnd;
				if (gameEnd != null)
				{
					int bonusPoints = gameEnd.BonusPoints;
					int currPoints = cardGameEndScores.<CurrentPoints>k__BackingField - bonusPoints;
					<>c__DisplayClass24_.currPoints = currPoints;
					CardGameEndScores cardGameEndScores2 = gameEnd;
					if (gameEnd != null)
					{
						object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						PlayerRank playerRank = default(PlayerRank);
						playerRank..ctor(cardGameEndScores2.<PreviousPoints>k__BackingField);
						if (playerRank != null)
						{
							object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
							object obj8 = (nint)0 + (nint)1168;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							TweenCallback tweenCallback = default(TweenCallback);
							tweenCallback..ctor(<>c__DisplayClass24_, (IntPtr)obj8);
							Sequence sequence2 = TweenSettingsExtensions.AppendCallback(sequence, tweenCallback);
							bool isFriendly = IsFriendly;
							bool flag2 = !isFriendly;
							object obj9 = !flag2;
							double num = 0.25;
							if (obj9 == null)
							{
								object obj10 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
								object obj11 = obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v27+E4]");
								bool flag3 = (nint)0 == 0;
								object obj12 = !flag3;
								if (obj12 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Games currentGame = Preferences.CurrentGame;
								num = ((currentGame != Games.Jackaroo) ? 3.25 : 1067869798.0);
							}
							double num2 = num + 0.75;
							bool flag4 = rankReport.<BonusPercentage>k__BackingField < 0;
							bool flag5 = rankReport.<BonusPercentage>k__BackingField == 0;
							int num3 = rankReport.<BonusPercentage>k__BackingField ^ rankReport.<BonusPercentage>k__BackingField;
							int num4 = rankReport.<BonusPercentage>k__BackingField & num3;
							bool flag6 = num4 < 0;
							bool flag7 = flag4 == flag6;
							object obj13 = !flag5;
							object obj14 = flag7 & obj13;
							object obj15 = ~obj14;
							if (obj15 == null)
							{
								num = num2;
							}
							double num5 = num + 1.5;
							object obj16 = rankReport.<CurrentPoints>k__BackingField - playerRank.<MaxSubRankLimit>k__BackingField;
							bool flag8 = (nint)obj16 < 0;
							bool flag9 = obj16 == null;
							int num6 = rankReport.<CurrentPoints>k__BackingField ^ playerRank.<MaxSubRankLimit>k__BackingField;
							int num7 = rankReport.<CurrentPoints>k__BackingField ^ obj16;
							int num8 = num6 & num7;
							bool flag10 = num8 < 0;
							bool flag11 = flag8 == flag10;
							object obj17 = !flag9;
							object obj18 = flag11 & obj17;
							object obj19 = ~obj18;
							float interval = ((obj19 != null) ? ((float)num) : ((float)num5));
							Sequence sequence3 = TweenSettingsExtensions.AppendInterval(sequence, interval);
							return sequence;
						}
					}
				}
			}
		}
		return (Sequence)(object)new NullReferenceException();
	}

	public override bool ShouldShow(CardGameEndScores rankReport)
	{
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01df: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_020f: Expected O, but got I4
		//IL_006c: Expected O, but got I
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_011d: Expected O, but got I4
		//IL_01b2: Expected I4, but got O
		//IL_0146: Expected O, but got I
		object obj = this + 32;
		KGame kGame = (KGame)obj;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 == null)
		{
			object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v27+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj6 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			obj = kGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if ((object)kGame == null)
			{
				goto IL_01a4;
			}
		}
		if (kGame.IsSpectator)
		{
			return false;
		}
		KGame kGame2 = (KGame)obj;
		bool flag3 = obj == null;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			object obj8 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v12+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj11 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			obj = kGame2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if ((object)kGame2 == null)
			{
				goto IL_01a4;
			}
		}
		bool isChallenge = kGame2.IsChallenge;
		return (byte)((isChallenge ? 1u : 0u) ^ 1u) != 0;
		IL_01a4:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public override void Disable()
	{
		GameObject gameObject = criteriaSection.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = base.gameObject;
		gameObject2.SetActive(value: false);
	}

	private void AnimatePointsSlider(int prePoints, int newPoints)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_0239: Expected O, but got I4
		//IL_01b7: Expected O, but got I4
		//IL_028f: Expected O, but got I4
		//IL_02aa: Expected O, but got I4
		//IL_01e0: Expected O, but got I4
		//IL_05ef: Expected O, but got I4
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Expected I4, but got Unknown
		//IL_0666: Expected O, but got I4
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected O, but got Unknown
		//IL_04d3: Expected O, but got I4
		//IL_0370: Expected O, but got I4
		//IL_07ea: Expected O, but got I4
		//IL_0801: Expected O, but got I4
		//IL_082d: Invalid comparison between F8 and I4
		//IL_083c: Invalid comparison between F8 and I4
		//IL_0854: Expected O, but got F8
		//IL_0861: Expected O, but got F8
		//IL_0896: Expected O, but got I4
		//IL_089e: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a3: Expected O, but got Unknown
		//IL_08d5: Invalid comparison between F8 and I4
		//IL_0542: Expected O, but got I4
		//IL_08fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0900: Expected O, but got Unknown
		//IL_06d1: Expected F8, but got I4
		//IL_042c: Expected O, but got I4
		//IL_0447: Expected O, but got I4
		//IL_0595: Expected O, but got I4
		//IL_05b0: Expected O, but got I4
		//IL_0799: Expected O, but got I
		//IL_07aa: Expected I, but got O
		//IL_06f9: Expected O, but got I
		//IL_070a: Expected I, but got O
		//IL_0761: Expected O, but got I
		//IL_0772: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass27_0 <>c__DisplayClass27_ = default(<>c__DisplayClass27_0);
		<>c__DisplayClass27_..ctor();
		object obj2 = <>c__DisplayClass27_ + 16;
		obj2 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		InitializeBlueProgressPosition(prePoints, newPoints);
		if (IsFriendly)
		{
			return;
		}
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerRank playerRank = default(PlayerRank);
		playerRank..ctor(prePoints);
		object obj4 = <>c__DisplayClass27_ + 32;
		obj4 = playerRank;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v4+1C]");
		int minSubRank = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v5 (System.Int32)+20]");
		<>c__DisplayClass27_.maxSubRank = 0;
		<>c__DisplayClass27_.minSubRank = minSubRank;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v15+E4]");
		Games currentGame;
		Games games;
		if ((nint)0 != 0)
		{
			currentGame = Preferences.CurrentGame;
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v35+E4]");
			bool flag = (nint)0 == 0;
			games = currentGame;
			if (!flag)
			{
				goto IL_0189;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			currentGame = Preferences.CurrentGame;
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v35+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			games = currentGame;
			if (obj9 != null)
			{
				goto IL_0189;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		int requiredPoints = PlayerRank.GetRequiredPoints(games, PlayerRank.Ranks.Master, 5);
		bool flag3 = prePoints >= requiredPoints;
		object obj10 = 0;
		int num = 5;
		PlayerRank.Ranks ranks = PlayerRank.Ranks.Master;
		object obj11 = 0;
		int num2 = 5;
		PlayerRank.Ranks ranks2 = PlayerRank.Ranks.Master;
		if (!flag3)
		{
			goto IL_02ca;
		}
		goto IL_05d0;
		IL_07d8:
		int newPoints2;
		object obj12 = newPoints2 - <>c__DisplayClass27_.minSubRank;
		object obj13 = <>c__DisplayClass27_.maxSubRank - <>c__DisplayClass27_.minSubRank;
		double num3 = (double)obj12 / (double)obj13;
		double num4 = num3 - 1.0;
		bool flag4 = num4 < 0.0;
		bool flag5 = num4 == 0.0;
		object obj14 = num3 ^ 1.0;
		object obj15 = num3 ^ num4;
		object obj16 = obj14 & obj15;
		bool flag6 = (nint)obj16 < 0;
		bool flag7 = flag4 == flag6;
		object obj17 = !flag5;
		object obj18 = flag7 & obj17;
		object obj19 = ~obj18;
		double num5 = ((obj19 != null) ? num3 : 1.0);
		double num6 = ((!(num3 < 0.0)) ? num5 : 0.0);
		object obj20 = typeof(SqlSingle[]) + 2376;
		if (newPoints2 > <>c__DisplayClass27_.maxSubRank)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj21 = (nint)0 + (nint)1176;
			Action action = default(Action);
			action..ctor(<>c__DisplayClass27_, (IntPtr)obj21);
			StartAnimation((float)num6, <>c__DisplayClass27_.maxSubRank, action);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		float tweenTo;
		int nowPoints;
		if (newPoints2 < <>c__DisplayClass27_.minSubRank)
		{
			object obj22 = (nint)0 + (nint)1184;
			action2..ctor(<>c__DisplayClass27_, (IntPtr)obj22);
			tweenTo = (float)num6;
			nowPoints = <>c__DisplayClass27_.minSubRank;
		}
		else
		{
			object obj23 = (nint)0 + (nint)1192;
			action2..ctor(<>c__DisplayClass27_, (IntPtr)obj23);
			tweenTo = (float)num6;
			nowPoints = newPoints2;
		}
		StartAnimation(tweenTo, nowPoints, action2);
		return;
		IL_0467:
		newPoints2 = <>c__DisplayClass27_.newPoints;
		object obj24;
		obj11 = obj24;
		int num7;
		num2 = num7;
		PlayerRank.Ranks ranks3;
		ranks2 = ranks3;
		goto IL_07d8;
		IL_0335:
		Games games2;
		int requiredPoints2 = PlayerRank.GetRequiredPoints(games2, PlayerRank.Ranks.Master, 4);
		newPoints2 = <>c__DisplayClass27_.newPoints;
		bool flag8 = prePoints < requiredPoints2;
		obj11 = 0;
		num2 = 4;
		ranks2 = PlayerRank.Ranks.Master;
		Games currentGame2;
		if (!flag8)
		{
			object obj25 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X0_v39+E4]");
			Games games3;
			if ((nint)0 != 0)
			{
				currentGame2 = Preferences.CurrentGame;
				object obj26 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v29+E4]");
				bool flag9 = (nint)0 == 0;
				games3 = currentGame2;
				if (!flag9)
				{
					goto IL_03fb;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				currentGame2 = Preferences.CurrentGame;
				object obj26 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v29+E4]");
				bool flag10 = (nint)0 == 0;
				object obj27 = !flag10;
				games3 = currentGame2;
				if (obj27 != null)
				{
					goto IL_03fb;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			int requiredPoints3 = PlayerRank.GetRequiredPoints(games3, PlayerRank.Ranks.Master, 5);
			bool flag11 = newPoints2 < requiredPoints3;
			obj24 = 0;
			num7 = 5;
			ranks3 = PlayerRank.Ranks.Master;
			obj11 = 0;
			num2 = 5;
			ranks2 = PlayerRank.Ranks.Master;
			if (flag11)
			{
				goto IL_0467;
			}
			goto IL_05d0;
		}
		goto IL_07d8;
		IL_05d0:
		newPoints2 = <>c__DisplayClass27_.newPoints;
		object obj28 = <>c__DisplayClass27_.newPoints - prePoints;
		bool flag12 = (nint)obj28 < 0;
		bool flag13 = obj28 == null;
		int num8 = <>c__DisplayClass27_.newPoints ^ prePoints;
		int num9 = <>c__DisplayClass27_.newPoints ^ obj28;
		int num10 = num8 & num9;
		bool flag14 = num10 < 0;
		bool flag15 = flag12 == flag14;
		object obj29 = !flag13;
		object obj30 = flag15 & obj29;
		object obj31 = ~obj30;
		int maxSubRank = ((obj31 != null) ? prePoints : <>c__DisplayClass27_.newPoints);
		<>c__DisplayClass27_.maxSubRank = maxSubRank;
		goto IL_07d8;
		IL_0189:
		int requiredPoints4 = PlayerRank.GetRequiredPoints(currentGame, PlayerRank.Ranks.Master, 5);
		bool flag16 = prePoints < requiredPoints4;
		obj10 = 0;
		num = 5;
		ranks = PlayerRank.Ranks.Master;
		if (flag16)
		{
			goto IL_02ca;
		}
		obj11 = 0;
		num2 = 5;
		ranks2 = PlayerRank.Ranks.Master;
		goto IL_05d0;
		IL_02ca:
		object obj32 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X0_v29+E4]");
		Games games4;
		if ((nint)0 != 0)
		{
			games2 = Preferences.CurrentGame;
			object obj33 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X8_v25+E4]");
			bool flag17 = (nint)0 == 0;
			games4 = games2;
			if (!flag17)
			{
				goto IL_0335;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			games2 = Preferences.CurrentGame;
			object obj33 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X8_v25+E4]");
			bool flag18 = (nint)0 == 0;
			object obj34 = !flag18;
			games4 = games2;
			if (obj34 != null)
			{
				goto IL_0335;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		games2 = games4;
		goto IL_0335;
		IL_03fb:
		int requiredPoints5 = PlayerRank.GetRequiredPoints(currentGame2, PlayerRank.Ranks.Master, 5);
		bool flag19 = newPoints2 >= requiredPoints5;
		obj24 = 0;
		num7 = 5;
		ranks3 = PlayerRank.Ranks.Master;
		obj11 = 0;
		num2 = 5;
		ranks2 = PlayerRank.Ranks.Master;
		if (!flag19)
		{
			goto IL_0467;
		}
		goto IL_05d0;
	}

	private void StartAnimation(float tweenTo, int nowPoints, Action callBack = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_00ae: Expected O, but got I4
		//IL_0147: Expected O, but got I4
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_020e: Expected O, but got I
		//IL_024e: Expected I, but got O
		//IL_018c: Expected O, but got I
		//IL_01a2: Expected O, but got I
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass28_0 <>c__DisplayClass28_ = default(<>c__DisplayClass28_0);
		<>c__DisplayClass28_..ctor();
		object obj2 = <>c__DisplayClass28_ + 16;
		obj2 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = <>c__DisplayClass28_ + 40;
		obj3 = callBack;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		PointsBar.FixCurrentValuePosition();
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence s = DOTween.Sequence();
		CardGameEndScores cardGameEndScores = gameEnd;
		int earnedPointsFinalVal = <>c__DisplayClass28_.nowPoints - cardGameEndScores.<PreviousPoints>k__BackingField;
		<>c__DisplayClass28_.earnedPointsFinalVal = earnedPointsFinalVal;
		GameObject gameObject = EarnedPointsValue.gameObject;
		bool activeSelf = gameObject.activeSelf;
		bool flag2 = !activeSelf;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			RectTransform rectTransform = EarnedPointsValue.rectTransform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(rectTransform, 0f, 0.3f);
			object obj8 = (nint)0 + (nint)2904;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			object obj9 = (nint)0 + (nint)2440;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305835C");
			Tween t = default(Tween);
			Sequence sequence = TweenSettingsExtensions.Append(s, t);
			GameObject gameObject2 = EarnedPointsValue.gameObject;
			gameObject2.SetActive(value: true);
		}
		object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj11 = (nint)0 + (nint)1208;
		Sequence t2 = PointsBar.StartAnimation();
		Sequence sequence2 = TweenSettingsExtensions.Join(s, t2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(<>c__DisplayClass28_, (IntPtr)obj11);
		Sequence sequence3 = TweenSettingsExtensions.AppendCallback(s, tweenCallback);
	}

	private void StartAnimation2(float tweenTo, int nowPoints, int earnedPointsFinalVal, Action callBack)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_009e: Expected O, but got I4
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0260: Expected O, but got I4
		//IL_0269: Expected F4, but got I4
		//IL_03bf: Expected O, but got I4
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected O, but got Unknown
		//IL_031f: Expected O, but got I4
		//IL_0328: Expected F4, but got I4
		//IL_0331: Expected F4, but got I4
		//IL_1423: Unknown result type (might be due to invalid IL or missing references)
		//IL_1428: Expected O, but got Unknown
		//IL_144a: Expected O, but got I4
		//IL_0380: Expected F4, but got I4
		//IL_0389: Expected F4, but got I4
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected O, but got Unknown
		//IL_04fc: Expected O, but got I4
		//IL_072d: Expected F4, but got I4
		//IL_0743: Expected F4, but got I4
		//IL_0525: Expected O, but got I
		//IL_14a3: Expected O, but got I4
		//IL_0690: Expected O, but got I4
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Expected O, but got Unknown
		//IL_05f0: Expected O, but got I4
		//IL_0619: Expected O, but got I
		//IL_088c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0891: Expected O, but got Unknown
		//IL_089d: Expected O, but got I
		//IL_0a2f: Expected O, but got I4
		//IL_1377: Expected O, but got I
		//IL_1383: Expected O, but got I
		//IL_1392: Unknown result type (might be due to invalid IL or missing references)
		//IL_1397: Expected O, but got Unknown
		//IL_13b2: Expected I, but got O
		//IL_0a77: Expected O, but got I4
		//IL_0a80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a85: Expected O, but got Unknown
		//IL_0ac0: Expected O, but got I4
		//IL_0ad8: Expected F4, but got I4
		//IL_0ae1: Expected O, but got I4
		//IL_0be4: Expected O, but got I4
		//IL_0c01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c06: Expected O, but got Unknown
		//IL_0c1c: Expected O, but got I
		//IL_0c2d: Expected I, but got O
		//IL_0cea: Invalid comparison between F8 and I4
		//IL_0cf9: Invalid comparison between F8 and I4
		//IL_0d11: Expected O, but got F8
		//IL_0d1e: Expected O, but got F8
		//IL_0d53: Expected O, but got I4
		//IL_0d5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d60: Expected O, but got Unknown
		//IL_0c48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4d: Expected O, but got Unknown
		//IL_1544: Invalid comparison between F4 and I4
		//IL_156b: Expected F4, but got I
		//IL_0d9f: Expected F4, but got I4
		//IL_1206: Unknown result type (might be due to invalid IL or missing references)
		//IL_120b: Expected O, but got Unknown
		//IL_1221: Expected O, but got I
		//IL_1229: Expected I, but got O
		//IL_123a: Expected I, but got O
		//IL_1255: Unknown result type (might be due to invalid IL or missing references)
		//IL_125a: Expected O, but got Unknown
		//IL_1290: Expected O, but got I4
		//IL_12ba: Expected I, but got O
		//IL_0e51: Invalid comparison between F4 and I4
		//IL_0e60: Invalid comparison between F4 and I4
		//IL_0e6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e74: Expected O, but got Unknown
		//IL_0e81: Expected O, but got F4
		//IL_0eb6: Expected O, but got I4
		//IL_0ebe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec3: Expected O, but got Unknown
		//IL_12e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ec: Expected O, but got Unknown
		//IL_1302: Expected O, but got I
		//IL_130a: Expected I, but got O
		//IL_131b: Expected I, but got O
		//IL_1336: Unknown result type (might be due to invalid IL or missing references)
		//IL_133b: Expected O, but got Unknown
		//IL_15e7: Invalid comparison between F4 and I4
		//IL_0ee3: Expected F4, but got I4
		//IL_160d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1612: Expected O, but got Unknown
		//IL_163c: Expected O, but got I4
		//IL_0efe: Expected F4, but got I4
		//IL_0f5d: Expected O, but got I
		//IL_0fb1: Expected O, but got I
		//IL_0fb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbe: Expected I4, but got Unknown
		//IL_1020: Unknown result type (might be due to invalid IL or missing references)
		//IL_1025: Expected O, but got Unknown
		//IL_104f: Expected O, but got I4
		//IL_1106: Unknown result type (might be due to invalid IL or missing references)
		//IL_110b: Expected O, but got Unknown
		//IL_1113: Unknown result type (might be due to invalid IL or missing references)
		//IL_1118: Expected I4, but got Unknown
		//IL_1695: Expected O, but got I
		//IL_16b9: Expected O, but got I4
		//IL_1099: Expected I4, but got I8
		//IL_0b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4d: Expected O, but got Unknown
		//IL_0b6f: Expected F4, but got I4
		//IL_0b78: Expected O, but got I4
		//IL_0ba1: Expected F4, but got I4
		//IL_0baa: Expected O, but got I4
		//IL_11ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b0: Expected O, but got Unknown
		//IL_11da: Expected O, but got I4
		//IL_14ff: Expected O, but got I
		//IL_1523: Expected O, but got I4
		//IL_1528: Expected I, but got O
		//IL_0b1b: Expected I4, but got I8
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass29_0 <>c__DisplayClass29_ = default(<>c__DisplayClass29_0);
		<>c__DisplayClass29_..ctor();
		Sequence s;
		object obj8 = default(object);
		float num6;
		float num7;
		float num8;
		float num10;
		float num12;
		double num11;
		if (<>c__DisplayClass29_ != null)
		{
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj3 = <>c__DisplayClass29_ + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = <>c__DisplayClass29_ + 32;
			obj4 = callBack;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			s = DOTween.Sequence();
			if ((object)criteriaSection != null)
			{
				criteriaSection.AnimatePerformanceStamps();
				CardGameEndScores cardGameEndScores = gameEnd;
				if (gameEnd != null)
				{
					object obj7 = typeof(TypeConverter<ushort, char>) + 3912;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					if (obj8 != null)
					{
						double num = (double)cardGameEndScores.<CheatingPerformance>k__BackingField + 1.0;
						double num2 = (double)cardGameEndScores.<PlayStylePerformance>k__BackingField + 1.0;
						double num3 = num2 + num;
						double num4 = num2 / num3;
						double num5 = num / num3;
						PointsProgressBar pointsBar = PointsBar;
						if ((object)PointsBar != null)
						{
							Image blueProgressBar = pointsBar.BlueProgressBar;
							if ((object)pointsBar.BlueProgressBar != null)
							{
								num6 = blueProgressBar.m_FillAmount;
								bool flag2 = FloatExtensions.IsNearlyEqualTo(blueProgressBar.m_FillAmount, 1f, 0.01f);
								bool flag3 = !flag2;
								object obj9 = !flag3;
								num7 = 1.00898176E+09f;
								num8 = 1f;
								if (obj9 != null)
								{
									goto IL_0397;
								}
								PointsProgressBar pointsBar2 = PointsBar;
								if ((object)PointsBar != null)
								{
									Image blueProgressBar2 = pointsBar2.BlueProgressBar;
									if ((object)pointsBar2.BlueProgressBar != null)
									{
										num6 = blueProgressBar2.m_FillAmount;
										bool flag4 = FloatExtensions.IsNearlyEqualTo(blueProgressBar2.m_FillAmount, 0f, 0.01f);
										bool flag5 = !flag4;
										object obj10 = !flag5;
										num7 = 1.00898176E+09f;
										num8 = 0f;
										if (obj10 == null)
										{
											num6 = <>c__DisplayClass29_.tweenTo;
											bool flag6 = FloatExtensions.IsNearlyEqualTo(<>c__DisplayClass29_.tweenTo, 0f, 0.01f);
											bool flag7 = !flag6;
											num7 = 1.00898176E+09f;
											num8 = 0f;
											if (flag7)
											{
												num6 = <>c__DisplayClass29_.tweenTo;
												bool flag8 = FloatExtensions.IsNearlyEqualTo(<>c__DisplayClass29_.tweenTo, 1f, 0.01f);
												int num9 = (flag8 ? 1 : 0) | earnedPointsFinalVal;
												bool flag9 = num9 == 0;
												num7 = 1.00898176E+09f;
												num8 = 1f;
												num10 = 1.00898176E+09f;
												num11 = 1.0;
												num12 = <>c__DisplayClass29_.tweenTo;
												if (flag9)
												{
													goto IL_03e5;
												}
												goto IL_076b;
											}
										}
										goto IL_0397;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_13d8;
		IL_1458:
		PointsProgressBar pointsBar3 = PointsBar;
		object obj15;
		if ((object)PointsBar != null)
		{
			Image blueProgressBar3 = pointsBar3.BlueProgressBar;
			if ((object)pointsBar3.BlueProgressBar != null && (object)pointsBar3.PointsIndicator != null)
			{
				Vector2 anchorMax = pointsBar3.PointsIndicator.anchorMax;
				PointsProgressBar pointsBar4 = PointsBar;
				if ((object)PointsBar != null && (object)pointsBar4.pointsCurrent != null)
				{
					string text = pointsBar4.pointsCurrent.text;
					if (text != null)
					{
						object oldValue = "&action=sign-up" + 3400;
						object obj11 = (nint)0 + (nint)2000;
						string s2 = text.Replace((string)oldValue, (string)obj11);
						int num13 = int.Parse(s2);
						PointsProgressBar pointsBar5 = PointsBar;
						if ((object)PointsBar != null)
						{
							Image blueProgressBar4 = pointsBar5.BlueProgressBar;
							if ((object)pointsBar5.BlueProgressBar != null && (object)pointsBar5.PointsIndicator != null)
							{
								float num14 = blueProgressBar4.m_FillAmount;
								Vector2 anchorMax2 = pointsBar5.PointsIndicator.anchorMax;
								PointsProgressBar pointsBar6 = PointsBar;
								if ((object)PointsBar != null && (object)pointsBar6.pointsCurrent != null)
								{
									string text2 = pointsBar6.pointsCurrent.text;
									if (text2 != null)
									{
										string text3 = (string)obj11;
										string s3 = text2.Replace((string)oldValue, (string)obj11);
										int num15 = int.Parse(s3);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X22_v8+18]");
										bool flag10 = (nint)0 < (nint)1;
										bool flag11 = false;
										object obj12 = 0;
										if (flag10)
										{
											goto IL_136b;
										}
										float num16 = <>c__DisplayClass29_.tweenTo - blueProgressBar3.m_FillAmount;
										float num17 = <>c__DisplayClass29_.tweenTo - num12;
										object obj13 = nowPoints - num13;
										object obj14 = obj15 + 32;
										object obj17 = default(object);
										object obj16 = obj17;
										IntPtr intPtr = default(IntPtr);
										nint num18 = intPtr;
										int num19 = num15;
										int num20 = 0;
										bool flag12 = false;
										string text4 = (string)obj11;
										object obj18 = 0;
										float num21 = num10;
										float num22 = num16;
										float num23 = earnedPointsFinalVal;
										object obj19 = 0;
										float num24 = num12;
										TweenCallback tweenCallback = default(TweenCallback);
										DOGetter<float> dOGetter3 = default(DOGetter<float>);
										DOSetter<float> dOSetter = default(DOSetter<float>);
										Tween t = default(Tween);
										int num37 = default(int);
										Tween t2 = default(Tween);
										int num39 = default(int);
										Tween t3 = default(Tween);
										while (true)
										{
											TweenCallback callback = <>c__DisplayClass29_.<>9__1;
											bool flag13 = <>c__DisplayClass29_.<>9__1 == null;
											object obj20 = !flag13;
											if (obj20 == null)
											{
												object obj21 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
												object obj22 = (nint)0 + (nint)1224;
												tweenCallback..ctor(<>c__DisplayClass29_, (IntPtr)obj22);
												<>c__DisplayClass29_.<>9__1 = tweenCallback;
												object obj23 = <>c__DisplayClass29_ + 40;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												flag12 = false;
												callback = tweenCallback;
											}
											Sequence sequence = TweenSettingsExtensions.AppendCallback(s, callback);
											PointsProgressBar pointsBar7 = PointsBar;
											if ((object)PointsBar == null)
											{
												break;
											}
											float num25 = num16;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X25_v8+v178 @ X28_v7*4]");
											float num26 = num25 * 0f;
											num14 += num26;
											double num27 = (double)num14 - 1.0;
											bool flag14 = num27 < 0.0;
											bool flag15 = num27 == 0.0;
											object obj24 = (double)num14 ^ 1.0;
											object obj25 = (double)num14 ^ num27;
											object obj26 = obj24 & obj25;
											bool flag16 = (nint)obj26 < 0;
											bool flag17 = flag14 == flag16;
											object obj27 = !flag15;
											object obj28 = flag17 & obj27;
											object obj29 = ~obj28;
											double num28 = ((obj29 != null) ? ((double)num14) : 1.0);
											float endValue = ((!(num14 < 1.01435046E+09f)) ? ((float)num28) : 1.01435046E+09f);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X22_v8+18]");
											num21 = 0f;
											float num29 = pointsFillTime;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X22_v8+18]");
											float duration = num29 / 0f;
											TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFillAmount(pointsBar7.BlueProgressBar, endValue, duration);
											Sequence sequence2 = TweenSettingsExtensions.Append(s, tweenerCore);
											DOGetter<float> dOGetter = <>c__DisplayClass29_.<>9__2;
											DOSetter<float> setter;
											DOGetter<float> dOGetter2;
											nint num30;
											Tween tween;
											if (<>c__DisplayClass29_.<>9__2 != null)
											{
												bool flag18 = <>c__DisplayClass29_.<>9__3 == null;
												num30 = 0;
												tween = tweenerCore;
												setter = <>c__DisplayClass29_.<>9__3;
												bool flag19 = flag12;
												nint num31 = 0;
												Tween tween2 = tweenerCore;
												dOGetter2 = dOGetter;
												if (!flag18)
												{
													goto IL_0e12;
												}
											}
											else
											{
												object obj30 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 56;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
												object obj31 = (nint)0 + (nint)1232;
												num30 = (nint)obj31;
												dOGetter3..ctor((object)<>c__DisplayClass29_, (IntPtr)obj31);
												<>c__DisplayClass29_.<>9__2 = dOGetter3;
												object obj32 = <>c__DisplayClass29_ + 48;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												setter = <>c__DisplayClass29_.<>9__3;
												bool flag20 = <>c__DisplayClass29_.<>9__3 == null;
												object obj33 = !flag20;
												flag12 = false;
												tween = (Tween)(object)dOGetter3;
												dOGetter = dOGetter3;
												bool flag19 = false;
												nint num31 = (nint)obj31;
												Tween tween2 = (Tween)(object)dOGetter3;
												dOGetter2 = dOGetter3;
												if (obj33 != null)
												{
													goto IL_0e12;
												}
											}
											object obj34 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 136;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
											object obj35 = (nint)0 + (nint)1240;
											num30 = (nint)obj35;
											dOSetter..ctor((object)<>c__DisplayClass29_, (IntPtr)obj35);
											<>c__DisplayClass29_.<>9__3 = dOSetter;
											object obj36 = <>c__DisplayClass29_ + 56;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											flag12 = false;
											tween = (Tween)(object)dOSetter;
											setter = dOSetter;
											dOGetter = dOGetter2;
											goto IL_0e12;
											IL_0e12:
											float num32 = num17;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X25_v8+v178 @ X28_v7*4]");
											float num33 = num32 * 0f;
											num24 += num33;
											float num34 = num24 - 1.0651016E+09f;
											bool flag21 = num34 < 0f;
											bool flag22 = num34 == 0f;
											object obj37 = num24 ^ 0x3F7C28F6;
											object obj38 = num24 ^ num34;
											object obj39 = obj37 & obj38;
											bool flag23 = (nint)obj39 < 0;
											bool flag24 = flag21 == flag23;
											object obj40 = !flag22;
											object obj41 = flag24 & obj40;
											object obj42 = ~obj41;
											float num35 = ((obj42 != null) ? num24 : 1.0651016E+09f);
											float endValue2 = ((!(num24 < 1.01435046E+09f)) ? num35 : 1.01435046E+09f);
											object obj43 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
											object obj44 = obj43;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X0_v61+E4]");
											bool flag25 = (nint)0 == 0;
											object obj45 = !flag25;
											if (obj45 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											float num36 = pointsFillTime;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X22_v8+18]");
											num22 = num36 / 0f;
											TweenerCore<float, float, FloatOptions> tweenerCore2 = DOTween.To(dOGetter, setter, endValue2, num22);
											object obj46 = (nint)0 + (nint)2864;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
											Sequence sequence3 = TweenSettingsExtensions.Join(s, t);
											if ((object)EarnedPointsValue == null)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X25_v8+v178 @ X28_v7*4]");
											object obj47 = (nint)0 * (nint)earnedPointsFinalVal;
											num20 += obj47;
											string text5 = EarnedPointsValue.text;
											string text6 = num37.ToString();
											bool flag26 = text5 != text6;
											bool flag27 = !flag26;
											bool flag28 = (byte)num18 != 0;
											if (!flag27)
											{
												object obj48 = typeof(SqlSingle[]) + 3912;
												object obj49 = obj48;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1028 @ X0_v93+E4]");
												bool flag29 = (nint)0 == 0;
												object obj50 = !flag29;
												if (obj50 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												int endValue3 = (int)((num20 != 2139095040) ? num20 : 2147483648L);
												float num38 = pointsFillTime;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X22_v8+18]");
												float duration2 = num38 / 0f;
												Tweener tweener = AnimationExtensions.DONumber(EarnedPointsValue, endValue3, duration2, useCommas: false, includeSign: true);
												object obj51 = (nint)0 + (nint)2944;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
												Sequence sequence4 = TweenSettingsExtensions.Join(s, t2);
												obj16 = 0;
												flag28 = false;
												flag12 = true;
											}
											PointsProgressBar pointsBar8 = PointsBar;
											if ((object)PointsBar == null || (object)pointsBar8.pointsCurrent == null)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X25_v8+v178 @ X28_v7*4]");
											object obj52 = 0 * obj13;
											num19 += obj52;
											string text7 = pointsBar8.pointsCurrent.text;
											string text8 = num39.ToString();
											bool flag30 = text7 != text8;
											bool flag31 = !flag30;
											num18 = (flag28 ? 1 : 0);
											text4 = null;
											if (!flag31)
											{
												PointsProgressBar pointsBar9 = PointsBar;
												if ((object)PointsBar == null)
												{
													break;
												}
												object obj53 = typeof(SqlSingle[]) + 3912;
												object obj54 = obj53;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1116 @ X8_v51+E4]");
												bool flag32 = (nint)0 == 0;
												object obj55 = !flag32;
												if (obj55 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												int endValue4 = (int)((num19 != 2139095040) ? num19 : 2147483648L);
												float num40 = pointsFillTime;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X22_v8+18]");
												float duration3 = num40 / 0f;
												Tweener tweener2 = AnimationExtensions.DONumber(pointsBar9.pointsCurrent, endValue4, duration3, useCommas: true);
												object obj56 = (nint)0 + (nint)2944;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
												Sequence sequence5 = TweenSettingsExtensions.Join(s, t3);
												obj16 = 0;
												num18 = unchecked((nint)null);
												flag12 = false;
												text4 = null;
											}
											Sequence sequence6 = TweenSettingsExtensions.AppendInterval(s, 0.1f);
											obj18++;
											object obj57 = obj18;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X22_v8+18]");
											bool flag33 = (nint)obj57 >= 0;
											num23 = 1.03683194E+09f;
											obj19 = 0;
											flag11 = flag12;
											text3 = text4;
											num10 = num21;
											num11 = num22;
											num12 = 1.03683194E+09f;
											obj12 = 0;
											if (!flag33)
											{
												continue;
											}
											goto IL_136b;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_13d8;
		IL_03e5:
		object obj58 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj59 = obj58;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X0_v110+E4]");
		if ((nint)0 != 0)
		{
			Games currentGame = Preferences.CurrentGame;
			if (currentGame == Games.Jackaroo)
			{
				num10 = num7;
				num11 = num8;
				num12 = num6;
				goto IL_076b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Games currentGame2 = Preferences.CurrentGame;
			bool flag34 = currentGame2 == Games.Jackaroo;
			num10 = num7;
			num11 = num8;
			num12 = num6;
			if (flag34)
			{
				goto IL_076b;
			}
		}
		object obj60 = this + 32;
		KGame kGame = (KGame)obj60;
		bool flag35 = obj60 == null;
		object obj61 = !flag35;
		if (obj61 == null)
		{
			object obj62 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj63 = obj62;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X0_v135+E4]");
			bool flag36 = (nint)0 == 0;
			object obj64 = !flag36;
			if (obj64 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj65 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			obj60 = kGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if ((object)kGame == null)
			{
				goto IL_13d8;
			}
		}
		Room room = kGame.Room;
		bool flag37 = room == null;
		num10 = num7;
		num11 = num8;
		num12 = num6;
		obj15 = obj8;
		if (!flag37)
		{
			KGame kGame2 = (KGame)obj60;
			bool flag38 = obj60 == null;
			object obj66 = !flag38;
			if (obj66 == null)
			{
				object obj67 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj68 = obj67;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X0_v121+E4]");
				bool flag39 = (nint)0 == 0;
				object obj69 = !flag39;
				if (obj69 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj70 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
				obj60 = kGame2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if ((object)kGame2 == null)
				{
					goto IL_13d8;
				}
			}
			Room room2 = kGame2.Room;
			bool flag40 = SFSKammelnaRoomExtensions.IsCheatingAllowed(room2);
			bool flag41 = !flag40;
			object obj71 = !flag41;
			num10 = num7;
			num11 = num8;
			num12 = num6;
			obj15 = obj8;
			if (obj71 == null)
			{
				num10 = num7;
				num11 = num8;
				num12 = num6;
				goto IL_076b;
			}
		}
		goto IL_1458;
		IL_0397:
		int num41 = 1 | earnedPointsFinalVal;
		bool flag42 = num41 == 0;
		object obj72 = !flag42;
		num10 = num7;
		num11 = num8;
		num12 = num6;
		if (obj72 == null)
		{
			goto IL_03e5;
		}
		goto IL_076b;
		IL_076b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj73 = default(object);
		if (obj73 == null)
		{
			goto IL_13d8;
		}
		_ = 1065353216;
		obj15 = obj73;
		goto IL_1458;
		IL_13d8:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_136b:
		object obj74 = (nint)0 + (nint)1216;
		object obj75 = (nint)0 + (nint)2408;
		object obj76 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback2 = default(TweenCallback);
		tweenCallback2..ctor(<>c__DisplayClass29_, (IntPtr)obj74);
		Sequence sequence7 = TweenSettingsExtensions.AppendCallback(s, tweenCallback2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
	}

	private void StartAnimation2Point1(float tweenTo)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01de: Expected O, but got I4
		//IL_0041: Invalid comparison between F4 and I
		//IL_00a4: Invalid comparison between F4 and I
		//IL_00fc: Expected O, but got I
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_020c: Expected O, but got I
		//IL_00d9: Expected O, but got I
		//IL_0085: Expected O, but got I
		//IL_010f: Expected I, but got O
		//IL_014a: Expected O, but got I
		//IL_0156: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence s = DOTween.Sequence();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6FBE038]");
		Component pointsParent;
		object obj4;
		if (tweenTo < 0f)
		{
			PointsProgressBar pointsBar = PointsBar;
			pointsParent = pointsBar.PointsParent;
			obj4 = (nint)0 + (nint)1408;
		}
		else
		{
			PointsProgressBar pointsBar2 = PointsBar;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6FC2E08]");
			if (tweenTo > 0f)
			{
				pointsParent = pointsBar2.PointsParent;
				obj4 = (nint)0 + (nint)1416;
			}
			else
			{
				pointsParent = pointsBar2.PointsParent;
				obj4 = (nint)0 + (nint)1424;
			}
		}
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj6 = (nint)0 + (nint)2504;
		Transform target = pointsParent.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target, 1f, 0.001f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		Tween t = default(Tween);
		Sequence sequence = TweenSettingsExtensions.Append(s, t);
		PointsProgressBar pointsBar3 = PointsBar;
		object obj7 = (nint)0 + (nint)2872;
		object obj8 = (nint)0 + (nint)2408;
		RectTransform rectTransform = pointsBar3.pointsCurrent.rectTransform;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOAnchorPosX(rectTransform, 0f, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t2 = default(Tween);
		Sequence sequence2 = TweenSettingsExtensions.Join(s, t2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
	}

	private void ShowRankingAnimation(bool rankedUp)
	{
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected O, but got Unknown
		//IL_0128: Expected O, but got I
		//IL_0145: Expected O, but got I4
		//IL_0165: Expected O, but got I
		//IL_017f: Expected O, but got I4
		//IL_0195: Expected F8, but got I4
		//IL_019e: Expected F8, but got I4
		//IL_01b4: Expected O, but got I4
		//IL_01ca: Expected F8, but got I4
		//IL_01d3: Expected F8, but got I4
		//IL_01e9: Expected O, but got I4
		//IL_0025: Expected O, but got I
		//IL_0042: Expected O, but got I4
		//IL_0062: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_00f9: Expected O, but got I4
		//IL_028a: Expected O, but got I
		//IL_02b9: Expected O, but got I4
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected O, but got Unknown
		//IL_03ad: Expected O, but got I
		//IL_03e5: Expected O, but got I
		//IL_0400: Expected O, but got I4
		//IL_042b: Expected O, but got I
		//IL_046e: Expected O, but got I4
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2864;
		Animator animator;
		double num;
		double num2;
		double num3;
		double num4;
		Color color;
		Animator animator2;
		double num5;
		double num6;
		double num7;
		double num8;
		Color color2;
		if (rankedUp)
		{
			GameObject gameObject = RankTextAnimation.gameObject;
			object obj2 = (nint)0 + (nint)1440;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
			SpriteRenderer spriteRenderer = default(SpriteRenderer);
			spriteRenderer.color = (Color)0;
			animator = RankUpAnimation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67AE]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			num = 1.0;
			num2 = 1.0;
			num3 = 1.0;
			num4 = 1.0;
			color = (Color)0;
			if (flag)
			{
				goto IL_0201;
			}
			num5 = 1.0;
			num6 = 1.0;
			num7 = 1.0;
			num8 = 1.0;
			color2 = (Color)0;
			animator2 = RankUpAnimation;
		}
		else
		{
			GameObject gameObject2 = RankTextAnimation.gameObject;
			object obj4 = (nint)0 + (nint)1440;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
			SpriteRenderer spriteRenderer2 = default(SpriteRenderer);
			spriteRenderer2.color = (Color)0;
			animator = RankDownAnimation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67AE]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			num = 1.0;
			num2 = 0.0;
			num3 = 0.0;
			num4 = 1.0;
			color = (Color)0;
			num5 = 1.0;
			num6 = 0.0;
			num7 = 0.0;
			num8 = 1.0;
			color2 = (Color)0;
			animator2 = RankDownAnimation;
			if (obj6 == null)
			{
				goto IL_0201;
			}
		}
		goto IL_035b;
		IL_035b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<RankAnimation>d__32 <RankAnimation>d__ = default(<RankAnimation>d__32);
		<RankAnimation>d__..ctor(0);
		object obj7 = <RankAnimation>d__ + 32;
		obj7 = animator2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = StartCoroutine(<RankAnimation>d__);
		RankUI rankUI = giantRank;
		object obj8 = (nint)0 + (nint)2944;
		Transform target = rankUI.rankTitle.transform;
		Tweener tweener = ShortcutExtensions.DOPunchScale(target, (Vector3)10, 0.15f, 0, 0.15f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<RankAnimation>d__32 <RankAnimation>d__2 = default(<RankAnimation>d__32);
		<RankAnimation>d__2..ctor(0);
		object obj9 = <RankAnimation>d__2 + 32;
		obj9 = RankTextAnimation;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine2 = StartCoroutine(<RankAnimation>d__2);
		RectTransform target2 = UIExtensions.rectTransform(AvatarSection);
		object obj10 = typeof(UsageHint) + 816;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v13+B8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v14+C]");
		float duration = 0f * 1.0418651E+09f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v14+14]");
		object obj13 = (nint)0 * (nint)1028443341;
		float elasticity = default(float);
		Tweener tweener2 = ShortcutExtensions.DOPunchScale(target2, (Vector3)2, duration, 0, elasticity);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		object obj14 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v21+B8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v22+24]");
		float duration2 = 0f * (float)obj13;
		Tweener tweener3 = ShortcutExtensions.DOPunchPosition(BodySection, (Vector3)2, duration2, 0, elasticity);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		return;
		IL_0201:
		_ = 1;
		num5 = num;
		num6 = num2;
		num7 = num3;
		num8 = num4;
		color2 = color;
		animator2 = animator;
		goto IL_035b;
	}

	private IEnumerator RankAnimation(Animator animator)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<RankAnimation>d__32 <RankAnimation>d__ = default(<RankAnimation>d__32);
		<RankAnimation>d__..ctor(0);
		if (<RankAnimation>d__ != null)
		{
			object obj2 = <RankAnimation>d__ + 32;
			obj2 = animator;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return <RankAnimation>d__;
		}
		return (IEnumerator)new NullReferenceException();
	}

	private void AnimateWinningStreak()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0101: Expected O, but got I4
		//IL_028b: Expected O, but got I
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected I4, but got Unknown
		//IL_02c8: Invalid comparison between F8 and I4
		//IL_02d7: Invalid comparison between F8 and I4
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected I4, but got Unknown
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected I4, but got Unknown
		//IL_0331: Expected O, but got I4
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_012f: Expected I, but got O
		//IL_013f: Expected O, but got I
		//IL_0362: Expected I4, but got F8
		//IL_01e7: Expected O, but got I
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Expected O, but got Unknown
		//IL_0184: Expected O, but got I
		//IL_09f1: Expected O, but got I
		//IL_0a01: Expected F4, but got I
		//IL_0a11: Expected F4, but got I
		//IL_0a21: Expected F4, but got I
		//IL_0a3b: Expected F4, but got I
		//IL_0a3b: Expected O, but got I4
		//IL_01c2: Expected O, but got I4
		//IL_03e8: Expected O, but got I
		//IL_0412: Expected F8, but got I4
		//IL_041a: Expected O, but got I4
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Expected O, but got Unknown
		//IL_059f: Expected O, but got I4
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected O, but got Unknown
		//IL_0612: Expected O, but got I4
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected O, but got Unknown
		//IL_0667: Expected O, but got I
		//IL_0475: Expected O, but got I
		//IL_0483: Expected I, but got O
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected O, but got Unknown
		//IL_04c1: Expected O, but got I4
		//IL_0682: Expected O, but got I
		//IL_053a: Expected F4, but got I4
		//IL_0543: Expected F4, but got I4
		//IL_054c: Expected O, but got I4
		//IL_0701: Unknown result type (might be due to invalid IL or missing references)
		//IL_0706: Expected O, but got Unknown
		//IL_0721: Expected O, but got I
		//IL_072f: Expected I, but got O
		//IL_073e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0743: Expected O, but got Unknown
		//IL_075e: Expected O, but got I
		//IL_076c: Expected I, but got O
		//IL_07ba: Invalid comparison between F4 and I4
		//IL_07c9: Invalid comparison between F4 and I4
		//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Expected O, but got Unknown
		//IL_07ea: Expected O, but got F4
		//IL_081f: Expected O, but got I4
		//IL_0827: Unknown result type (might be due to invalid IL or missing references)
		//IL_082c: Expected O, but got Unknown
		//IL_0a4d: Invalid comparison between F4 and I4
		//IL_084c: Expected F4, but got I4
		//IL_0a8a: Expected O, but got I
		//IL_0aa0: Expected O, but got I
		//IL_0867: Expected F4, but got I4
		//IL_08dc: Invalid comparison between F4 and I4
		//IL_08eb: Invalid comparison between F4 and I4
		//IL_0903: Expected O, but got F8
		//IL_0910: Expected O, but got F4
		//IL_0945: Expected O, but got I4
		//IL_094d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0952: Expected O, but got Unknown
		//IL_0ab8: Invalid comparison between F4 and I4
		//IL_0b02: Expected O, but got I
		//IL_0991: Expected F4, but got I4
		CardGameEndScores cardGameEndScores = gameEnd;
		if (cardGameEndScores.<CurrentPoints>k__BackingField <= cardGameEndScores.<PreviousPoints>k__BackingField || cardGameEndScores.<BonusPercentage>k__BackingField < 1)
		{
			return;
		}
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerRank playerRank = default(PlayerRank);
		playerRank..ctor(cardGameEndScores.<CurrentPoints>k__BackingField);
		CardGameEndScores cardGameEndScores2 = gameEnd;
		int bonusPoints = gameEnd.BonusPoints;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		int points = cardGameEndScores2.<CurrentPoints>k__BackingField - bonusPoints;
		PlayerRank playerRank2 = default(PlayerRank);
		playerRank2..ctor(points);
		bool flag = playerRank.<SubRanksCount>k__BackingField == playerRank2.<SubRanksCount>k__BackingField;
		object obj2 = 0;
		int num = 0;
		if (!flag)
		{
			RankUI rankUI = giantRank;
			nint num2 = (nint)rankUI;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v76 (Il2CppClass<RankUI>)+1B0]");
			obj2 = 0;
			rankUI.SetRank(playerRank, alsoAnimate: true);
			CardGameEndScores cardGameEndScores3;
			if (playerRank.<SubRanksCount>k__BackingField != 0)
			{
				object obj3 = (nint)0 + (nint)2408;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
				SingleSound singleSound = default(SingleSound);
				SoundChannel.PlaySFXSound(singleSound);
				cardGameEndScores3 = gameEnd;
				bool flag2 = gameEnd == null;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					throw new NullReferenceException();
				}
			}
			else
			{
				object obj5 = (nint)0 + (nint)2408;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
				SingleSound singleSound2 = default(SingleSound);
				SoundChannel.PlaySFXSound(singleSound2);
				cardGameEndScores3 = gameEnd;
			}
			num = cardGameEndScores3.<CurrentPoints>k__BackingField;
			int prePoints = playerRank.<MinSubRankLimit>k__BackingField + 1;
			InitializeBlueProgressPosition(prePoints, cardGameEndScores3.<CurrentPoints>k__BackingField);
		}
		int <MinSubRankLimit>k__BackingField = playerRank.<MinSubRankLimit>k__BackingField;
		int bonusPoints2 = gameEnd.BonusPoints;
		CardGameEndScores cardGameEndScores4 = gameEnd;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X20_v5 (System.Int32)+20]");
		object obj6 = -playerRank.<MinSubRankLimit>k__BackingField;
		int num3 = bonusPoints2 / obj6;
		int num4 = cardGameEndScores4.<BonusPercentage>k__BackingField / 1167867904;
		double num5 = (double)num3 - 1.0;
		bool flag3 = num5 < 0.0;
		bool flag4 = num5 == 0.0;
		int num6 = num3 ^ 1.0;
		int num7 = num3 ^ num5;
		int num8 = num6 & num7;
		bool flag5 = num8 < 0;
		bool flag6 = flag3 == flag5;
		object obj7 = !flag4;
		object obj8 = flag6 & obj7;
		object obj9 = ~obj8;
		int num9 = ((obj9 != null) ? num3 : 1);
		int num10 = ((num3 >= num4) ? num9 : num4);
		Transform target = winningStreak.transform;
		object obj10 = typeof(UsageHint) + 816;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v14+B8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X8_v15+C]");
		float num11 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X8_v15+10]");
		float num12 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X8_v15+14]");
		float num13 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X8_v15+C]");
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target, (Vector3)0, 0f);
		Transform transform = bonusText.transform;
		Transform parent = transform.parent;
		object obj13 = (nint)0 + (nint)3816;
		RectTransform rectTransform = (RectTransform)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Graphic graphic = default(Graphic);
		bool flag7 = (object)graphic == null;
		double num14 = 1045220557.0;
		Action action = (Action)num;
		if (!flag7)
		{
			CardGameEndScores cardGameEndScores5 = gameEnd;
			RectTransform rectTransform2 = UIExtensions.rectTransform(stampsTarget);
			object obj14 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj15 = (nint)0 + (nint)1384;
			Action action2 = default(Action);
			action2..ctor(this, (IntPtr)obj15);
			object obj16 = typeof(SqlSingle[]) + 3912;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X0_v58+E4]");
			bool flag8 = (nint)0 == 0;
			object obj18 = !flag8;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			num13 = (float)cardGameEndScores5.<BonusPercentage>k__BackingField / 10f;
			AnimationExtensions.DOStamp(graphic, 0.3f, 40f, num13, 3f, 0.4f, rectTransform2, action2);
			num14 = 3.0;
			num12 = 1.1093934E+09f;
			num11 = 1.0502537E+09f;
			obj2 = 0;
			action = action2;
			rectTransform = rectTransform2;
		}
		object obj19 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X0_v22+E4]");
		bool flag9 = (nint)0 == 0;
		object obj21 = !flag9;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence s = DOTween.Sequence();
		CardGameEndScores cardGameEndScores6 = gameEnd;
		object obj22 = typeof(SqlSingle[]) + 3912;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X0_v26+E4]");
		bool flag10 = (nint)0 == 0;
		object obj24 = !flag10;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tweener tweener = AnimationExtensions.DONumber(EarnedPointsValue, cardGameEndScores6.<GamePoints>k__BackingField, 0.2f, useCommas: false, includeSign: true);
		object obj25 = (nint)0 + (nint)2800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		object obj26 = (nint)0 + (nint)2944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		PointsProgressBar pointsBar = PointsBar;
		CardGameEndScores cardGameEndScores7 = gameEnd;
		Tweener tweener2 = AnimationExtensions.DONumber(pointsBar.pointsCurrent, cardGameEndScores7.<CurrentPoints>k__BackingField, 0.2f, useCommas: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		object obj27 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj28 = (nint)0 + (nint)1392;
		DOGetter<float> dOGetter = default(DOGetter<float>);
		dOGetter..ctor((object)this, (IntPtr)obj28);
		object obj29 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj30 = (nint)0 + (nint)1400;
		DOSetter<float> dOSetter = default(DOSetter<float>);
		dOSetter..ctor((object)this, (IntPtr)obj30);
		PointsProgressBar pointsBar2 = PointsBar;
		Image blueProgressBar = pointsBar2.BlueProgressBar;
		float num15 = (float)num10 + blueProgressBar.m_FillAmount;
		float num16 = num15 - 1.0651016E+09f;
		bool flag11 = num16 < 0f;
		bool flag12 = num16 == 0f;
		object obj31 = num15 ^ 0x3F7C28F6;
		object obj32 = num15 ^ num16;
		object obj33 = obj31 & obj32;
		bool flag13 = (nint)obj33 < 0;
		bool flag14 = flag11 == flag13;
		object obj34 = !flag12;
		object obj35 = flag14 & obj34;
		object obj36 = ~obj35;
		float num17 = ((obj36 != null) ? num15 : 1.0651016E+09f);
		float endValue = ((!(num15 < 1.01435046E+09f)) ? num17 : 1.01435046E+09f);
		TweenerCore<float, float, FloatOptions> tweenerCore2 = DOTween.To(dOGetter, dOSetter, endValue, 0.2f);
		object obj37 = (nint)0 + (nint)2864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		object obj38 = (nint)0 + (nint)2752;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		Tween t = default(Tween);
		Sequence sequence = TweenSettingsExtensions.Append(s, t);
		PointsProgressBar pointsBar3 = PointsBar;
		Image blueProgressBar2 = pointsBar3.BlueProgressBar;
		float num18 = (float)num10 + blueProgressBar2.m_FillAmount;
		float num19 = num18 - 1f;
		bool flag15 = num19 < 0f;
		bool flag16 = num19 == 0f;
		object obj39 = (double)num18 ^ 1.0;
		object obj40 = num18 ^ num19;
		object obj41 = obj39 & obj40;
		bool flag17 = (nint)obj41 < 0;
		bool flag18 = flag15 == flag17;
		object obj42 = !flag16;
		object obj43 = flag18 & obj42;
		object obj44 = ~obj43;
		float num20 = ((obj44 != null) ? num18 : 1f);
		float endValue2 = ((!(num18 < 1.01435046E+09f)) ? num20 : 1.01435046E+09f);
		TweenerCore<float, float, FloatOptions> t2 = DOTweenModuleUI.DOFillAmount(blueProgressBar2, endValue2, 0.2f);
		Sequence sequence2 = TweenSettingsExtensions.Join(s, t2);
		object obj45 = (nint)0 + (nint)2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
	}

	private void InitializeBlueProgressPosition(int prePoints, int newPoints)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0079: Expected O, but got I4
		//IL_0086: Expected O, but got I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerRank playerRank = default(PlayerRank);
		playerRank..ctor(prePoints);
		int maxSubRank = playerRank.<MaxSubRankLimit>k__BackingField;
		if (prePoints >= 56000 && newPoints >= 60000)
		{
			bool flag = newPoints < prePoints;
			object obj2 = !flag;
			object obj3 = newPoints - prePoints;
			bool flag2 = obj3 == null;
			object obj4 = ~obj2;
			object obj5 = obj4 | flag2;
			maxSubRank = prePoints;
			if (obj5 == null)
			{
				CardGameEndScores cardGameEndScores = gameEnd;
				maxSubRank = cardGameEndScores.<CurrentPoints>k__BackingField;
			}
		}
		PointsBar.Initialize(playerRank, maxSubRank, playerRank.<MinSubRankLimit>k__BackingField, prePoints, newPoints);
	}

	private void InitializeStreak()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_00cc: Expected O, but got I4
		object obj = "&action=sign-up" + 3352;
		object obj2 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 3912;
		int num = default(int);
		string text = num.ToString();
		string text2 = (string)obj + text + (string)obj2;
		bonusText.text = text2;
		Transform transform = bonusText.transform;
		Transform parent = transform.parent;
		GameObject gameObject = parent.gameObject;
		gameObject.SetActive(value: false);
		Transform transform2 = winningStreak.transform;
		transform2.localScale = (Vector3)0;
	}

	private void InitializeEarnedPoints(bool earned)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0073: Expected O, but got I4
		//IL_007c: Expected O, but got I4
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_019f: Expected O, but got I4
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0132: Expected O, but got I4
		//IL_00b1: Expected O, but got I4
		//IL_00ba: Expected O, but got I4
		//IL_01f7: Expected O, but got I4
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		object text = ", stale={0}" + 3424;
		EarnedPointsValue.text = (string)text;
		GameObject gameObject = EarnedPointsValue.gameObject;
		gameObject.SetActive(value: false);
		bool isFriendly = IsFriendly;
		bool flag = !isFriendly;
		object obj = !flag;
		Vector3 vector = (Vector3)0;
		if (obj == null)
		{
			PointsProgressBar pointsBar = PointsBar;
			pointsBar.PointsIndicator.localScale = (Vector3)0;
			vector = (Vector3)0;
		}
		PlayerPerformanceSprites playerPerformanceSprites = performanceSprites;
		object text2;
		if (earned)
		{
			PlayerPerformanceSprites.StampBorder stampBorder = playerPerformanceSprites.stampBorder;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1336;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v17+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			text2 = "Drop Menu Toggle" + 1880;
		}
		else
		{
			PlayerPerformanceSprites.StampBorder stampBorder2 = playerPerformanceSprites.stampBorder;
			object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1336;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v13+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			text2 = "DNQUALIFIER" + 2016;
		}
		Color fontColor = default(Color);
		<InitializeEarnedPoints>g__SetupUi|36_0((string)text2, (Color)0, fontColor);
	}

	private void PlaySubRankDownSound()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
	}

	private void PlaySubRankUpSound()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
	}

	private void PlayRankUpSound()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
	}

	private void PlayRankDownSound()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
	}

	private void PlayStampSound(PlayerPerformance stampLevel)
	{
		SingleSound stampSound = gameSoundAlbum.GetStampSound(stampLevel);
		SoundChannel.PlaySFXSound(stampSound);
	}

	static PointsAndRankGameEndWidget()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_0041: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1336;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252CF0]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252D00]");
		_ = 0;
	}

	private void <StartAnimation2Point1>b__30_0()
	{
		//IL_0034: Expected O, but got I4
		PointsProgressBar pointsBar = PointsBar;
		RectTransform rectTransform = UIExtensions.rectTransform(pointsBar.PointsParent);
		rectTransform.pivot = (Vector2)0;
		PointsProgressBar pointsBar2 = PointsBar;
		pointsBar2.pointsCurrent.alignment = TextAlignmentOptions.Right;
	}

	private void <StartAnimation2Point1>b__30_1()
	{
		//IL_0034: Expected O, but got I4
		PointsProgressBar pointsBar = PointsBar;
		RectTransform rectTransform = UIExtensions.rectTransform(pointsBar.PointsParent);
		rectTransform.pivot = (Vector2)0;
		PointsProgressBar pointsBar2 = PointsBar;
		pointsBar2.pointsCurrent.alignment = TextAlignmentOptions.Left;
	}

	private void <StartAnimation2Point1>b__30_2()
	{
		//IL_0034: Expected O, but got I4
		PointsProgressBar pointsBar = PointsBar;
		RectTransform rectTransform = UIExtensions.rectTransform(pointsBar.PointsParent);
		rectTransform.pivot = (Vector2)0;
		PointsProgressBar pointsBar2 = PointsBar;
		pointsBar2.pointsCurrent.alignment = TextAlignmentOptions.Center;
	}

	private void <AnimateWinningStreak>b__33_0()
	{
		SingleSound stampSound = gameSoundAlbum.GetStampSound(PlayerPerformance.Excellent);
		SoundChannel.PlaySFXSound(stampSound);
	}

	private float <AnimateWinningStreak>b__33_1()
	{
		PointsProgressBar pointsBar = PointsBar;
		Vector2 anchorMax = pointsBar.PointsIndicator.anchorMax;
		float result = default(float);
		return result;
	}

	private void <AnimateWinningStreak>b__33_2(float val)
	{
		PointsProgressBar pointsBar = PointsBar;
		UIExtensions.SetAnchorX(pointsBar.PointsIndicator, val);
	}

	private void <InitializeEarnedPoints>g__SetupUi|36_0(string text, Color borderColor, Color fontColor)
	{
		//IL_0012: Expected O, but got I
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0064: Expected O, but got I4
		//IL_0099: Expected O, but got I
		//IL_00b3: Expected O, but got I4
		string text2 = default(string);
		TextMeshProExtensions.Localize(EarnedOrDeducted, text2);
		EarnedPointsValue.color = (Color)0;
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 160;
		Material fontMaterial = EarnedPointsValue.fontMaterial;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v6+B8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v7+2C]");
		fontMaterial.SetColor(0, (Color)0);
	}
}
