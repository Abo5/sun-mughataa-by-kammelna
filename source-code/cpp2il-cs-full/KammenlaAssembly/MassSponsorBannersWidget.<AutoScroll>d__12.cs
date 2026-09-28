using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Server.Models;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.UI;
using UnityEngine.InputSystem.XR;

public class MassSponsorBannersWidget : MassWidget
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<MassBannerItem, GameObject> <>9__7_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3000;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal GameObject <Populate>b__7_0(MassBannerItem c)
		{
			if ((object)c != null)
			{
				return c.gameObject;
			}
			return (GameObject)(object)new NullReferenceException();
		}
	}

	private sealed class <AutoScroll>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public MassSponsorBannersWidget <>4__this;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <AutoScroll>d__12(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0070: Expected I4, but got I8
			//IL_01b3: Expected I4, but got O
			//IL_0021: Expected O, but got I4
			//IL_003e: Expected I4, but got I8
			//IL_0211: Unknown result type (might be due to invalid IL or missing references)
			//IL_0216: Expected O, but got Unknown
			//IL_0238: Unknown result type (might be due to invalid IL or missing references)
			//IL_023d: Expected O, but got Unknown
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Expected O, but got Unknown
			//IL_014d: Expected O, but got I4
			bool flag3;
			if (<>1__state != 1)
			{
				bool flag = <>1__state == 0;
				object obj = !flag;
				if (obj == null)
				{
					<>1__state = -1;
					goto IL_0202;
				}
			}
			else
			{
				MassSponsorBannersWidget massSponsorBannersWidget = <>4__this;
				<>1__state = -1;
				if ((object)<>4__this == null)
				{
					goto IL_01a5;
				}
				MassEventModel tournamentData = massSponsorBannersWidget.TournamentData;
				if (massSponsorBannersWidget.TournamentData != null)
				{
					List<MassEventSponsorBannerViewModel> <SponsorBanners>k__BackingField = tournamentData.<SponsorBanners>k__BackingField;
					if (tournamentData.<SponsorBanners>k__BackingField != null && <SponsorBanners>k__BackingField._size >= 2)
					{
						object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
						object obj3 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v16+E4]");
						bool flag2 = (nint)0 == 0;
						object obj4 = !flag2;
						if (obj4 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						flag3 = massSponsorBannersWidget.uiPicker;
						if (!flag3)
						{
							goto IL_01fd;
						}
						if ((object)massSponsorBannersWidget.uiPicker == null)
						{
							goto IL_01a5;
						}
						massSponsorBannersWidget.uiPicker.MoveToNextCircular();
						goto IL_0202;
					}
				}
			}
			return false;
			IL_01fd:
			return flag3;
			IL_0202:
			object obj5 = typeof(UsageHint) + 1640;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			WaitForSeconds waitForSeconds = default(WaitForSeconds);
			waitForSeconds..ctor(3f);
			object obj6 = this + 24;
			obj6 = waitForSeconds;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 1;
			flag3 = true;
			goto IL_01fd;
			IL_01a5:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
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
			object obj2 = (nint)0 + (nint)792;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private RectTransform bannersList;

	private MassBannerItem bannersItemPrefab;

	private UIPicker uiPicker;

	private DiscreteProgressIndicator pagination;

	private List<MassBannerItem> _bannerUis;

	private void OnEnable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = StartCoroutine((IEnumerator)obj2);
	}

	protected override void Initialize()
	{
		MassEventModel tournamentData = TournamentData;
		if (ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)tournamentData.<SponsorBanners>k__BackingField))
		{
			GameObject gameObject = base.gameObject;
			gameObject.SetActive(value: false);
		}
		else
		{
			MassEventModel tournamentData2 = TournamentData;
			Populate(tournamentData2.<SponsorBanners>k__BackingField);
		}
	}

	private void Populate(List<MassEventSponsorBannerViewModel> banners)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0114: Expected O, but got I
		//IL_0124: Expected O, but got I
		//IL_0146: Expected O, but got I4
		//IL_00de: Expected O, but got I4
		//IL_0079: Expected O, but got I
		//IL_0089: Expected O, but got I
		//IL_0177: Expected O, but got I4
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_0257: Expected O, but got I
		//IL_0268: Expected I, but got O
		//IL_0286: Expected O, but got I
		//IL_01a7: Expected O, but got I
		InitializeBanners(banners);
		InitializePagination(banners);
		GameObject gameObject = uiPicker.gameObject;
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3000;
		gameObject.SetActive(value: true);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v13+E4]");
		object obj3;
		Func<object, object> selector;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v13+B8]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v8+8]");
			selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v8+8]");
			if ((nint)0 != 0)
			{
				goto IL_00af;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v13+B8]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v8+8]");
			selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v8+8]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_00af;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v13+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v14+B8]");
			obj3 = 0;
		}
		object obj7 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = (nint)0 + (nint)784;
		Func<object, object> func = default(Func<object, object>);
		func..ctor(obj3, (IntPtr)obj8);
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v13+B8]");
		object obj10 = (nint)0 + (nint)8;
		obj10 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		IEnumerable<object> itemsList = Enumerable.Select(_bannerUis, func);
		goto IL_01c4;
		IL_00af:
		itemsList = Enumerable.Select(_bannerUis, selector);
		bool flag3 = (object)uiPicker == null;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01c4;
		IL_01c4:
		uiPicker.setItemsList((IEnumerable<GameObject>)itemsList);
		SetPickersEvents();
		if (banners._size <= 1)
		{
			uiPicker.DisableScrolling();
		}
	}

	private void InitializeBanners(List<MassEventSponsorBannerViewModel> banners)
	{
		//IL_0012: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0032: Expected O, but got I
		//IL_003e: Expected O, but got I
		//IL_004a: Expected O, but got I
		//IL_034c: Expected O, but got I4
		//IL_012a: Expected O, but got I4
		//IL_032d: Expected I, but got O
		//IL_0304: Expected I, but got O
		//IL_02e9: Expected I, but got I8
		//IL_024d: Expected O, but got I4
		//IL_006c: Expected O, but got I
		//IL_007c: Expected O, but got I
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected O, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_02bf: Expected I, but got I8
		object obj5 = default(object);
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		List<MassEventSponsorBannerViewModel> list = default(List<MassEventSponsorBannerViewModel>);
		if (list != null)
		{
			object obj = (nint)0 + (nint)3280;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj3 = (nint)0 + (nint)960;
			object obj4 = (nint)0 + (nint)3720;
			obj5 = (nint)0 + (nint)3272;
			List<object>.Enumerator enumerator = ((List<object>)(object)list).GetEnumerator();
			List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
			MassBannerItem massBannerItem = default(MassBannerItem);
			MassEventSponsorBannerViewModel massEventSponsorBannerViewModel = default(MassEventSponsorBannerViewModel);
			while (true)
			{
				list = (List<MassEventSponsorBannerViewModel>)obj;
				if (enumerator2.MoveNext())
				{
					if ((object)bannersList != null)
					{
						Transform transform = bannersList.transform;
						object obj6 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v26+E4]");
						bool flag = (nint)0 == 0;
						object obj7 = !flag;
						if (obj7 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
						MassEventModel tournamentData = TournamentData;
						if (TournamentData != null)
						{
							if ((object)massBannerItem != null)
							{
								massBannerItem.Populate(massEventSponsorBannerViewModel, tournamentData.<Id>k__BackingField);
								List<object> bannerUis = (List<object>)(object)_bannerUis;
								nint num;
								if (_bannerUis != null)
								{
									object obj8 = obj4;
									int version = bannerUis._version + 1;
									bannerUis._version = version;
									object[] items = bannerUis._items;
									if (bannerUis._items != null)
									{
										bool flag2 = bannerUis._size < items.Length;
										object obj9 = !flag2;
										if (obj9 != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v15+20]");
											object obj10 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v17+C0]");
											object obj11 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v18+70]");
											num = 0;
											((List<object>)(object)_bannerUis).AddWithResize((object)massBannerItem);
										}
										else
										{
											int size = bannerUis._size + 1;
											bannerUis._size = size;
											object obj12 = bannerUis._items + bannerUis._size;
											object obj13 = obj12 + 32;
											obj13 = massBannerItem;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											num = (nint)tournamentData.<Id>k__BackingField;
										}
										continue;
									}
								}
								NullReferenceException ex = new NullReferenceException();
								num = (nint)tournamentData.<Id>k__BackingField;
								list = (List<MassEventSponsorBannerViewModel>)(object)massEventSponsorBannerViewModel;
							}
							else
							{
								NullReferenceException ex2 = new NullReferenceException();
								nint num = unchecked((nint)null);
								list = (List<MassEventSponsorBannerViewModel>)(object)transform;
							}
						}
						else
						{
							NullReferenceException ex3 = new NullReferenceException();
							nint num = unchecked((nint)null);
							list = (List<MassEventSponsorBannerViewModel>)(object)transform;
						}
					}
					else
					{
						NullReferenceException ex4 = new NullReferenceException();
					}
					break;
				}
				enumerator2.Dispose();
				return;
			}
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			enumerator3 = enumerator4;
			enumerator4 = (List<object>.Enumerator)0;
		}
		NullReferenceException ex5 = new NullReferenceException();
		bool flag3 = (nint)list != 1;
		OutOfMemoryException ex6 = (OutOfMemoryException)(object)ex5;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			list = (List<MassEventSponsorBannerViewModel>)obj5;
			enumerator3.Dispose();
			object obj14 = default(object);
			if (obj14 == null)
			{
				return;
			}
			ex6 = new OutOfMemoryException();
			List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2237314");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void InitializePagination(List<MassEventSponsorBannerViewModel> banners)
	{
		//IL_002c: Expected O, but got I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected I4, but got Unknown
		//IL_00a4: Expected O, but got I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected I4, but got Unknown
		GameObject gameObject = pagination.gameObject;
		object obj = banners._size - 1;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		int num = banners._size ^ 1;
		int num2 = banners._size ^ obj;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag2;
		bool active = (byte)((flag4 & obj2) ? 1 : 0) != 0;
		gameObject.SetActive(active);
		pagination.MaxProgress = banners._size;
		pagination.CurrentProgress = 1;
	}

	private void SetPickersEvents()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_009e: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0071: Expected I, but got O
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 968;
		object obj2 = (nint)0 + (nint)3288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UIPicker.OnSelectDelegate onSelectDelegate = default(UIPicker.OnSelectDelegate);
		onSelectDelegate..ctor(this, (IntPtr)obj2);
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)3280;
		uiPicker.OnChange += onSelectDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj4);
		uiPicker.OnUserInteraction += action;
	}

	private void SwitchPage()
	{
		UIPicker uIPicker = uiPicker;
		int currentProgress = uIPicker._currentSelectionIndex + 1;
		pagination.CurrentProgress = currentProgress;
	}

	private IEnumerator AutoScroll()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private void OnUserInteraction()
	{
		StopAllCoroutines();
	}

	public MassSponsorBannersWidget()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 2224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 88;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((MonoBehaviour)this)..ctor();
	}
}
