using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;

public class MatchMakingPopUp : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<KPlayer, bool> <>9__28_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3248;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <InitializeCards>b__28_0(KPlayer p)
		{
			//IL_003d: Expected I4, but got O
			if (p != null)
			{
				return p.IsHuman;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private PopupUI popup;

	private GameEventsChannel gameEventsChannel;

	private Animator animator;

	private Animator[] playerCardAnimators;

	private AudioClip Firstsound;

	private AudioSource source;

	private AudioClip Secodsound;

	private AudioClip thirdsound;

	private AudioClip fourthsound;

	private AudioClip fifthsound;

	private ParticleSystem flyingZats;

	protected static readonly int Animate;

	protected static readonly int Hide;

	protected static readonly int Show;

	private KGame game;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00d8: Expected O, but got I
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_0116: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0063: Expected I, but got O
		//IL_00a1: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)136;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj6 = this + 120;
		object obj7 = default(object);
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v4 (Il2CppClass<MatchMakingPopUp>)+190]");
		Action action = default(Action);
		action..ctor(this, (IntPtr)0);
		gameEventsChannel.OnShowAnimation += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v6 (Il2CppClass<MatchMakingPopUp>)+1A0]");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)0);
		gameEventsChannel.OnHideAnimation += action2;
	}

	protected virtual void TestAnimate()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_004e: Expected O, but got I4
		//IL_0083: Expected O, but got I
		//IL_00b7: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3880;
		popup.PopFromCenter();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v5+B8]");
		object obj5 = 0;
		Animator obj6 = animator;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v6+4]");
		obj6.ResetTrigger(0);
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v7+B8]");
		object obj8 = 0;
		Animator obj9 = animator;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v8+8]");
		obj9.SetTrigger(0);
		flyingZats.Play();
	}

	protected virtual void ShowAnimation()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0059: Expected O, but got I4
		//IL_008e: Expected O, but got I
		//IL_00c2: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3880;
		popup.PopFromCenter();
		InitializeCards();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v5+B8]");
		object obj5 = 0;
		Animator obj6 = animator;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v6+4]");
		obj6.ResetTrigger(0);
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v7+B8]");
		object obj8 = 0;
		Animator obj9 = animator;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v8+8]");
		obj9.SetTrigger(0);
		flyingZats.Play();
	}

	protected virtual void HideAnimation()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_004e: Expected O, but got I4
		//IL_0083: Expected O, but got I
		//IL_00b7: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3880;
		popup.ShrinkToParent();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v5+B8]");
		object obj5 = 0;
		Animator obj6 = animator;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v6+8]");
		obj6.ResetTrigger(0);
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v7+B8]");
		object obj8 = 0;
		Animator obj9 = animator;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v8+4]");
		obj9.SetTrigger(0);
		flyingZats.Stop();
	}

	public void AnimateFirstSet()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_009f: Expected O, but got I
		//IL_00b6: Expected I4, but got O
		//IL_012c: Expected O, but got I4
		//IL_0188: Expected O, but got I
		//IL_019f: Expected I4, but got O
		Animator[] array = playerCardAnimators;
		if (playerCardAnimators != null)
		{
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3880;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((object)array[0] != null)
			{
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v7+B8]");
				object obj5 = 0;
				array[0].SetTrigger((int)obj5);
				Animator[] array2 = playerCardAnimators;
				if (playerCardAnimators != null)
				{
					if (array2.Length < 3)
					{
						return;
					}
					object obj6 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v9+E4]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if ((object)array2[2] != null)
					{
						object obj8 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v11+B8]");
						object obj9 = 0;
						array2[2].SetTrigger((int)obj9);
						return;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	public void AnimateSecondSet()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_009f: Expected O, but got I
		//IL_00b6: Expected I4, but got O
		//IL_012c: Expected O, but got I4
		//IL_0188: Expected O, but got I
		//IL_019f: Expected I4, but got O
		Animator[] array = playerCardAnimators;
		if (playerCardAnimators != null)
		{
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3880;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((object)array[1] != null)
			{
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v7+B8]");
				object obj5 = 0;
				array[1].SetTrigger((int)obj5);
				Animator[] array2 = playerCardAnimators;
				if (playerCardAnimators != null)
				{
					if (array2.Length < 4)
					{
						return;
					}
					object obj6 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v9+E4]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if ((object)array2[3] != null)
					{
						object obj8 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v11+B8]");
						object obj9 = 0;
						array2[3].SetTrigger((int)obj9);
						return;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	public void PlayFirstsound()
	{
		//IL_000c: Expected O, but got I
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = (nint)0 + (nint)3608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 72;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((AudioSource)obj2).PlayOneShot(Firstsound, 0.5f);
	}

	public void PlaySecondsound()
	{
		//IL_000c: Expected O, but got I
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = (nint)0 + (nint)3608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 72;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((AudioSource)obj2).PlayOneShot(Secodsound, 0.5f);
	}

	public void PlayThirdsound()
	{
		//IL_000c: Expected O, but got I
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		object obj = (nint)0 + (nint)3608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 72;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((AudioSource)obj2).PlayOneShot(thirdsound);
	}

	public void PlayFourthsound()
	{
		//IL_000c: Expected O, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		object obj = (nint)0 + (nint)3608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 72;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((AudioSource)obj2).PlayOneShot(fourthsound, 0.1f);
	}

	public void PlayFifthsound()
	{
		//IL_000c: Expected O, but got I
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		object obj = (nint)0 + (nint)3608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 72;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((AudioSource)obj2).PlayOneShot(fifthsound);
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0076: Expected I, but got O
		//IL_003c: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3 (Il2CppClass<MatchMakingPopUp>)+190]");
		Action action = default(Action);
		action..ctor(this, (IntPtr)0);
		gameEventsChannel.OnShowAnimation -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v5 (Il2CppClass<MatchMakingPopUp>)+1A0]");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)0);
		gameEventsChannel.OnHideAnimation -= action2;
	}

	public void OnAnimateHideComplete()
	{
		popup.HidePopup(hideContentNow: false);
		gameEventsChannel.TriggerMatchMakingPopupHideComplete();
	}

	private void InitializeCards()
	{
		//IL_04db: Expected O, but got I
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0182: Expected O, but got I
		//IL_01c6: Expected O, but got I
		//IL_01d6: Expected O, but got I
		//IL_01f8: Expected O, but got I4
		//IL_02b2: Expected I4, but got O
		//IL_02bd: Expected I4, but got O
		//IL_0269: Expected O, but got I
		//IL_028e: Expected O, but got I
		//IL_00ca: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_00fc: Expected O, but got I4
		//IL_0228: Expected O, but got I4
		//IL_02d7: Expected O, but got I
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Expected O, but got Unknown
		//IL_051c: Expected O, but got I
		//IL_052d: Expected I, but got O
		//IL_054b: Expected O, but got I
		//IL_0566: Expected O, but got I4
		//IL_0258: Expected O, but got I
		//IL_02fd: Expected O, but got I4
		//IL_030f: Expected I4, but got O
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected O, but got Unknown
		//IL_0388: Expected O, but got I4
		//IL_03cb: Expected O, but got I
		//IL_03e0: Expected O, but got I
		//IL_03ea: Expected I4, but got O
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected O, but got Unknown
		//IL_0403: Expected I4, but got O
		//IL_040e: Expected O, but got I4
		//IL_0417: Expected O, but got I4
		//IL_0430: Expected O, but got I
		//IL_043a: Expected I4, but got O
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6116]");
		bool flag = false;
		bool flag2 = (object)game == null;
		IntPtr intPtr = default(IntPtr);
		KPlayer kPlayer = (KPlayer)(nint)intPtr;
		List<KPlayer> players;
		object obj3;
		object[] array2;
		Func<object, bool> predicate;
		object obj;
		if (!flag2)
		{
			bool isChallenge = game.IsChallenge;
			if (isChallenge)
			{
				bool flag3 = (object)game == null;
				kPlayer = null;
				flag = isChallenge;
				if (!flag3)
				{
					players = game.Players;
					obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3248;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X0_v26+E4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X0_v26+B8]");
						obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v22+8]");
						predicate = (Func<object, bool>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v22+8]");
						bool flag4 = (nint)0 == 0;
						object obj4 = !flag4;
						if (obj4 == null)
						{
							goto IL_0206;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj2 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X0_v26+B8]");
						obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v22+8]");
						predicate = (Func<object, bool>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v22+8]");
						bool flag5 = (nint)0 == 0;
						object obj5 = !flag5;
						if (obj5 == null)
						{
							goto IL_0206;
						}
					}
					goto IL_025d;
				}
			}
			else
			{
				bool flag6 = (object)game == null;
				kPlayer = null;
				flag = isChallenge;
				if (!flag6)
				{
					List<KPlayer> players2 = game.Players;
					bool flag7 = players2 == null;
					kPlayer = null;
					flag = isChallenge;
					if (!flag7)
					{
						object obj6 = (nint)0 + (nint)2864;
						kPlayer = (KPlayer)obj6;
						object[] array = ((List<object>)(object)players2).ToArray();
						array2 = array;
						goto IL_02a8;
					}
				}
			}
		}
		goto IL_0448;
		IL_0206:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X0_v26+E4]");
		bool flag8 = (nint)0 == 0;
		object obj7 = !flag8;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v28+B8]");
			obj3 = 0;
		}
		object obj9 = obj3;
		object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)1104;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj3, (IntPtr)obj11);
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v27+B8]");
		object obj13 = (nint)0 + (nint)8;
		obj13 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj14 = 0;
		predicate = func;
		goto IL_025d;
		IL_025d:
		object obj15 = (nint)0 + (nint)3560;
		object obj16 = obj15;
		IEnumerable<object> enumerable = Enumerable.Where(players, predicate);
		object obj17 = (nint)0 + (nint)1376;
		kPlayer = (KPlayer)obj17;
		array2 = Enumerable.ToArray(enumerable);
		goto IL_02a8;
		IL_02a8:
		flag = (byte)(int)playerCardAnimators != 0;
		if ((int)(~playerCardAnimators) == 0)
		{
			predicate = (Func<object, bool>)((nint)0 + (nint)3616);
			if (array2 != null)
			{
				object obj18 = 4;
				KPlayer kPlayer2 = kPlayer;
				bool flag9 = (byte)(int)playerCardAnimators != 0;
				AvatarInitializer avatarInitializer = default(AvatarInitializer);
				object obj21;
				do
				{
					obj = obj18 - 4;
					object obj19 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v10 (System.Boolean)+18]");
					if ((nint)obj19 < 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v10 (System.Boolean)+v101 @ X22_v8 (System.Object)*8]");
						bool flag10 = (nint)0 == 0;
						obj9 = obj18;
						kPlayer = kPlayer2;
						flag = flag9;
						if (flag10)
						{
							break;
						}
						kPlayer = (KPlayer)(object)predicate;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
						flag = (byte)array2.Length != 0;
						bool flag11 = (nint)obj < array2.Length;
						object obj20 = !flag11;
						if (obj20 == null)
						{
							bool flag12 = (object)avatarInitializer == null;
							obj9 = obj18;
							if (flag12)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v13 (System.Object[])+v101 @ X22_v8 (System.Object)*8]");
							kPlayer = (KPlayer)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v13 (System.Object[])+v101 @ X22_v8 (System.Object)*8]");
							avatarInitializer.Initialize((KPlayer)0);
							flag = (byte)(int)playerCardAnimators != 0;
							obj9 = obj18 + 1;
							bool flag13 = (byte)(int)(~playerCardAnimators) != 0;
							obj21 = !flag13;
							obj16 = 0;
							obj18 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v13 (System.Object[])+v100 @ X22_v6 (System.Object)*8]");
							kPlayer2 = (KPlayer)0;
							flag9 = (byte)(int)playerCardAnimators != 0;
							continue;
						}
						throw new IndexOutOfRangeException();
					}
					return;
				}
				while (obj21 != null);
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v3 (System.Boolean)+18]");
				if ((nint)0 < (nint)1)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v3 (System.Boolean)+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
					throw new NullReferenceException();
				}
			}
		}
		goto IL_0448;
		IL_0448:
		throw new NullReferenceException();
	}

	static MatchMakingPopUp()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0089: Expected O, but got I
		//IL_0091: Expected O, but got I4
		//IL_00b6: Expected O, but got I
		//IL_005e: Expected O, but got I
		object obj = "alignContent" + 472;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3880;
		object obj3 = "HH:mm:ss.ffZ" + 1328;
		object obj4 = "SetRoomVariables request error" + 560;
		int num = Animator.StringToHash((string)obj);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v3+B8]");
		object obj6 = 0;
		obj6 = num;
		int num2 = Animator.StringToHash((string)obj3);
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v5+B8]");
		object obj8 = 0;
		int num3 = Animator.StringToHash((string)obj4);
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v7+B8]");
		object obj10 = 0;
	}
}
