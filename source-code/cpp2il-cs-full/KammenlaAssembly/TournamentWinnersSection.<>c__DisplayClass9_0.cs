using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using HuaweiMobileServices.Location.Location;
using Spine;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TournamentWinnersSection : MonoBehaviour
{
	private sealed class <>c__DisplayClass9_0
	{
		public int tier;

		public TournamentWinnersSection <>4__this;

		public List<LeaderBoardPlayer> winners;

		internal bool <Populate>b__0(LeaderBoardPlayer player)
		{
			//IL_0050: Expected I4, but got O
			//IL_001c: Expected O, but got I
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected I4, but got Unknown
			if (player != null)
			{
				int num = tier;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [player @ X1 (LeaderBoardPlayer)+28]");
				object obj = (nint)num - (nint)0;
				bool flag = obj == null;
				return (byte)((flag & (??)player.MonthlyWinningTier) ? 1 : 0) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal void <Populate>g__PopulateInternal|1()
		{
			<>4__this.PopulateImages(tier);
			<>4__this.PopulateWinners(winners);
		}

		internal void <Populate>b__2()
		{
			//IL_0099: Expected O, but got I4
			//IL_00cb: Expected F4, but got I4
			<>4__this.PopulateImages(tier);
			<>4__this.PopulateWinners(winners);
			Transform transform = <>4__this.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(transform, 1f, 0.3f);
			TournamentWinnersSection tournamentWinnersSection = <>4__this;
			bool flag = Enumerable.Any((IEnumerable<object>)winners);
			bool flag2 = !flag;
			object obj = !flag2;
			object obj2 = ~obj;
			float endValue = ((obj2 != null) ? 1.06032006E+09f : 1f);
			TweenerCore<float, float, FloatOptions> tweenerCore2 = DOTweenModuleUI.DOFade(tournamentWinnersSection.canvasGroup, endValue, 0.3f);
		}
	}

	private TopPlaceItem[] playerItems;

	private TextMeshProUGUI titleText;

	private Image titleImage;

	private Image trophy;

	private CanvasGroup canvasGroup;

	private TournamentSprites sprites;

	private int lastTier;

	public void SetTitle(string title)
	{
		TextMeshProExtensions.FixArabic(titleText, title);
	}

	public void Populate(List<LeaderBoardPlayer> players)
	{
		Populate(players, lastTier, animate: false);
	}

	public void Populate(List<LeaderBoardPlayer> players, int tier, bool animate = true)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0046: Expected O, but got I
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_009b: Expected I, but got O
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_020d: Expected O, but got I
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_01b1: Expected O, but got I
		//IL_01c2: Expected I, but got O
		//IL_01d3: Expected O, but got I
		object obj = typeof(SkeletonBinary.SkeletonInput) + 4008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2248;
		object obj4 = (nint)0 + (nint)552;
		object obj5 = (nint)0 + (nint)856;
		object obj6 = obj2 + 24;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
		lastTier = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj4);
		IEnumerable<object> source = Enumerable.Where(players, func);
		IEnumerable<object> source2 = Enumerable.Take(source, 2);
		List<object> list = Enumerable.ToList(source2);
		object obj7 = obj2 + 32;
		obj7 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (animate)
		{
			Transform target = base.transform;
			int num = ShortcutExtensions.DOKill(target, complete: true);
			int num2 = ShortcutExtensions.DOKill(canvasGroup, complete: true);
			Transform target2 = base.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target2, 0.8f, 0.3f);
			TweenerCore<float, float, FloatOptions> tweenerCore2 = DOTweenModuleUI.DOFade(canvasGroup, 0f, 0.3f);
			object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)560;
			TweenCallback tweenCallback = default(TweenCallback);
			tweenCallback..ctor(obj2, (IntPtr)obj9);
			object obj10 = (nint)0 + (nint)2480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		}
		else
		{
			object obj11 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
			((TournamentWinnersSection)obj11).PopulateImages(0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+18]");
			((TournamentWinnersSection)0).PopulateWinners((List<LeaderBoardPlayer>)obj7);
		}
	}

	private void PopulateWinners(List<LeaderBoardPlayer> winners)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0109: Expected O, but got I
		//IL_00b1: Expected O, but got I
		//IL_00f3: Expected O, but got I
		TopPlaceItem[] array = playerItems;
		if (winners != null)
		{
			int num = 0;
			while (num < array.Length)
			{
				object obj = array + num;
				if (num < winners._size)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v8+20]");
					GameObject gameObject = ((Component)0).gameObject;
					gameObject.SetActive(value: true);
					object player = ((List<object>)(object)winners).get_Item(num);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v8+20]");
					((TopPlaceItem)0).Populate((LeaderBoardPlayer)player);
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v8+20]");
					GameObject gameObject2 = ((Component)0).gameObject;
					gameObject2.SetActive(value: false);
				}
				num++;
				array = playerItems;
			}
		}
		else if (array.Length >= 1)
		{
			throw new NullReferenceException();
		}
	}

	private void PopulateImages(int tierInt)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)1592;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D712E8");
		System.Int32Enum value = default(System.Int32Enum);
		System.Int32Enum? subType = value;
		Sprite monthlyTournamentFirstCup = sprites.GetMonthlyTournamentFirstCup((TournamentSubType?)subType);
		trophy.sprite = monthlyTournamentFirstCup;
		System.Int32Enum? subType2 = value;
		Sprite monthlyTournamentTypeTitle = sprites.GetMonthlyTournamentTypeTitle((TournamentSubType?)subType2);
		titleImage.sprite = monthlyTournamentTypeTitle;
	}
}
