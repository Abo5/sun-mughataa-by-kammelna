using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Firebase;
using Firebase.Auth;
using Kammelna.Server;
using Spine;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

namespace Social;

public abstract class SocialUtilityAdapterBase : ISocialUtilityAdapter
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<KammelnaResponseModel<bool>> <>9__11_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <TwitterLinkCallback>b__11_1(KammelnaResponseModel<bool> response)
		{
			if (response.Succeeded)
			{
				SFS.SendRefreshStatus();
			}
		}
	}

	private sealed class <>c__DisplayClass10_0
	{
		public string userId;

		public string email;

		public string displayName;

		public SocialPlatform platform;

		public SocialUtilityAdapterBase <>4__this;

		internal void <SigninCallbackHelper>b__0(Task<FirebaseUser> task)
		{
			//IL_002c: Expected O, but got I4
			//IL_037b: Expected O, but got I
			//IL_0046: Expected O, but got I
			//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bc: Expected O, but got Unknown
			//IL_03ef: Expected O, but got I
			//IL_040c: Expected I, but got O
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected O, but got Unknown
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Expected O, but got Unknown
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Expected O, but got Unknown
			//IL_0104: Expected O, but got I4
			//IL_0139: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Expected O, but got Unknown
			//IL_0432: Expected I, but got O
			//IL_018e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0193: Expected O, but got Unknown
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b3: Expected O, but got Unknown
			//IL_01db: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e0: Expected O, but got Unknown
			//IL_020a: Expected O, but got I4
			//IL_048a: Unknown result type (might be due to invalid IL or missing references)
			//IL_048f: Expected O, but got Unknown
			//IL_04cb: Expected O, but got I4
			//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e7: Expected O, but got Unknown
			//IL_050f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0514: Expected O, but got Unknown
			//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f4: Expected O, but got Unknown
			//IL_032d: Expected O, but got I4
			Task<FirebaseUser> task2 = default(Task<FirebaseUser>);
			if (task2 != null)
			{
				bool isFaulted = task2.IsFaulted;
				bool flag = !isFaulted;
				object obj = !flag;
				if (obj == null)
				{
					object obj2 = (nint)0 + (nint)1416;
					object result = ((Task<object>)(object)task2).Result;
					if (result != null)
					{
						string text = ((FirebaseUser)result).Email;
						string text2 = ((FirebaseUser)result).DisplayName;
						object obj3 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 360;
						object obj4 = "&action=sign-up" + 3976;
						string message = (string)obj3 + text + (string)obj4 + text2;
						object obj5 = typeof(DataRelation) + 856;
						object obj6 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v34+E4]");
						bool flag2 = (nint)0 == 0;
						object obj7 = !flag2;
						if (obj7 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Debug.Log(message);
						object obj8 = typeof(System.Formats.Asn1.SetOfValueComparer) + 832;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						SocialUser socialUser = default(SocialUser);
						socialUser..ctor();
						string text3 = ((FirebaseUser)result).UserId;
						if (socialUser != null)
						{
							object obj9 = socialUser + 16;
							obj9 = text3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj10 = socialUser + 24;
							obj10 = userId;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj11 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
							object obj12 = obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v48+E4]");
							bool flag3 = (nint)0 == 0;
							object obj13 = !flag3;
							if (obj13 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							string text5;
							if (StringsExtensions.IsNullOrEmpty(email))
							{
								string text4 = ((FirebaseUser)result).Email;
								text5 = text4;
							}
							else
							{
								text5 = email;
							}
							object obj14 = socialUser + 32;
							obj14 = text5;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj15 = obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v56+E4]");
							bool flag4 = (nint)0 == 0;
							object obj16 = !flag4;
							if (obj16 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							string text7;
							if (StringsExtensions.IsNullOrEmpty(displayName))
							{
								string text6 = ((FirebaseUser)result).DisplayName;
								text7 = text6;
							}
							else
							{
								text7 = displayName;
							}
							object obj17 = socialUser + 40;
							obj17 = text7;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							string phoneNumber = ((FirebaseUser)result).PhoneNumber;
							object obj18 = socialUser + 48;
							obj18 = phoneNumber;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj19 = typeof(System.Formats.Asn1.SetOfValueComparer) + 848;
							socialUser.<Platform>k__BackingField = platform;
							object obj20 = obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v69+E4]");
							bool flag5 = (nint)0 == 0;
							object obj21 = !flag5;
							if (obj21 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							SocialUtilities.TriggerRetrievedSocialToken(socialUser);
							return;
						}
						NullReferenceException ex = new NullReferenceException();
						nint num = (nint)obj4;
						task2 = (Task<FirebaseUser>)(object)text3;
					}
					else
					{
						object obj22 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 792;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						FirebaseException ex2 = default(FirebaseException);
						ex2..ctor(1);
						object obj23 = (nint)0 + (nint)4000;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
						OutOfMemoryException ex3 = new OutOfMemoryException();
						nint num = unchecked((nint)null);
						Task<FirebaseUser> task3 = default(Task<FirebaseUser>);
						task2 = task3;
						NullReferenceException ex = (NullReferenceException)(object)ex3;
					}
				}
				else
				{
					AggregateException exception = task2.Exception;
					object obj24 = (nint)0 + (nint)4000;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					OutOfMemoryException ex4 = new OutOfMemoryException();
					Task<FirebaseUser> task4 = default(Task<FirebaseUser>);
					task2 = task4;
					NullReferenceException ex = (NullReferenceException)(object)ex4;
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		}
	}

	private sealed class <>c__DisplayClass11_0
	{
		public string userID;

		public SocialUtilityAdapterBase <>4__this;

		internal void <TwitterLinkCallback>b__0(Task<FirebaseUser> task)
		{
			//IL_002c: Expected O, but got I4
			//IL_020c: Expected O, but got I
			//IL_0046: Expected O, but got I
			//IL_0248: Unknown result type (might be due to invalid IL or missing references)
			//IL_024d: Expected O, but got Unknown
			//IL_0280: Expected O, but got I
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Expected O, but got Unknown
			//IL_0135: Expected O, but got I
			//IL_0145: Expected O, but got I
			//IL_0167: Expected O, but got I4
			//IL_00ce: Expected O, but got I
			//IL_00de: Expected O, but got I
			//IL_0100: Expected O, but got I4
			//IL_0197: Expected O, but got I4
			//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0303: Expected O, but got Unknown
			//IL_0319: Expected O, but got I
			//IL_032a: Expected I, but got O
			//IL_0348: Expected O, but got I
			//IL_01c7: Expected O, but got I
			string userId;
			object obj3;
			object obj5;
			Action<KammelnaResponseModel<bool>> callback;
			Task<FirebaseUser> task2 = default(Task<FirebaseUser>);
			if (task2 != null)
			{
				bool isFaulted = task2.IsFaulted;
				bool flag = !isFaulted;
				object obj = !flag;
				if (obj == null)
				{
					object obj2 = (nint)0 + (nint)1416;
					object result = ((Task<object>)(object)task2).Result;
					if (result != null)
					{
						userId = ((FirebaseUser)result).UserId;
						obj3 = typeof(SkeletonBinary.SkeletonInput) + 376;
						object obj4 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v32+E4]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v32+B8]");
							obj5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v9+8]");
							callback = (Action<KammelnaResponseModel<bool>>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v9+8]");
							bool flag2 = (nint)0 == 0;
							object obj6 = !flag2;
							if (obj6 == null)
							{
								goto IL_0175;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj4 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v32+B8]");
							obj5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v9+8]");
							callback = (Action<KammelnaResponseModel<bool>>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v9+8]");
							bool flag3 = (nint)0 == 0;
							object obj7 = !flag3;
							if (obj7 == null)
							{
								goto IL_0175;
							}
						}
						goto IL_01cc;
					}
					object obj8 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 792;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					FirebaseException ex = default(FirebaseException);
					ex..ctor(1);
					object obj9 = (nint)0 + (nint)4008;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					OutOfMemoryException ex2 = new OutOfMemoryException();
					Task<FirebaseUser> task3 = default(Task<FirebaseUser>);
					task2 = task3;
					NullReferenceException ex3 = (NullReferenceException)(object)ex2;
				}
				else
				{
					AggregateException exception = task2.Exception;
					object obj10 = (nint)0 + (nint)4008;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					OutOfMemoryException ex4 = new OutOfMemoryException();
					Task<FirebaseUser> task4 = default(Task<FirebaseUser>);
					task2 = task4;
					NullReferenceException ex3 = (NullReferenceException)(object)ex4;
				}
			}
			else
			{
				NullReferenceException ex3 = new NullReferenceException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_0175:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v32+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj12 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v15+B8]");
				obj5 = 0;
			}
			object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)3992;
			Action<object> action = default(Action<object>);
			action..ctor(obj5, (IntPtr)obj14);
			object obj15 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v14+B8]");
			object obj16 = (nint)0 + (nint)8;
			obj16 = action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			callback = action;
			goto IL_01cc;
			IL_01cc:
			KammelnaRequests.LinkSocialPlatform(SocialPlatform.Twitter, userId, userID, callback);
		}
	}

	public abstract void FacebookLogin();

	public abstract void AppleLogin();

	public abstract void GoogleLogin();

	public abstract void TwitterPostText(string text);

	public abstract void TwitterPostImage(string path, string text);

	public abstract void LogoutAll();

	public void InitAuth()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0129: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0181: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 736;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E86]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 768;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 768;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		FirebaseApp defaultInstance = FirebaseApp.DefaultInstance;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		FirebaseApp app = defaultInstance;
		if (obj9 != null)
		{
			goto IL_00d7;
		}
		goto IL_0197;
		IL_00d7:
		FirebaseAuth auth = FirebaseAuth.GetAuth(defaultInstance);
		return;
		IL_0197:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		FirebaseAuth auth2 = FirebaseAuth.GetAuth(app);
		return;
		IL_0099:
		defaultInstance = FirebaseApp.DefaultInstance;
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v2+E4]");
		bool flag4 = (nint)0 == 0;
		app = defaultInstance;
		if (!flag4)
		{
			goto IL_00d7;
		}
		goto IL_0197;
	}

	public void FacebookLoginCallback(string accessToken, string userId, string email)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_013e: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0196: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E87]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 152;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 152;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		FirebaseAuth defaultInstance = FirebaseAuth.DefaultInstance;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v1+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 != null)
		{
			goto IL_00cf;
		}
		goto IL_01a4;
		IL_00cf:
		Credential credential = FacebookAuthProvider.GetCredential(accessToken);
		SigninCallbackHelper(credential, email, userId, SocialPlatform.Facebook);
		return;
		IL_01a4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_00cf;
		IL_0099:
		FirebaseAuth defaultInstance2 = FirebaseAuth.DefaultInstance;
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v1+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00cf;
		}
		goto IL_01a4;
	}

	public void GoogleLoginCallback(string idToken, string accessToken, string userId, string email)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0142: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_019a: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E88]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 3032;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 3032;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		FirebaseAuth defaultInstance = FirebaseAuth.DefaultInstance;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v1+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 != null)
		{
			goto IL_00cf;
		}
		goto IL_01a8;
		IL_00cf:
		Credential credential = GoogleAuthProvider.GetCredential(idToken, accessToken);
		SigninCallbackHelper(credential, email, userId, SocialPlatform.Google);
		return;
		IL_01a8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_00cf;
		IL_0099:
		FirebaseAuth defaultInstance2 = FirebaseAuth.DefaultInstance;
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v1+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00cf;
		}
		goto IL_01a8;
	}

	public void TwitterLoginCallback(string accessToken, string secret, string userId, string email)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0142: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_019a: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E89]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2392;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2392;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		FirebaseAuth defaultInstance = FirebaseAuth.DefaultInstance;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v1+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 != null)
		{
			goto IL_00cf;
		}
		goto IL_01a8;
		IL_00cf:
		Credential credential = TwitterAuthProvider.GetCredential(accessToken, secret);
		SigninCallbackHelper(credential, email, userId, SocialPlatform.Twitter);
		return;
		IL_01a8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_00cf;
		IL_0099:
		FirebaseAuth defaultInstance2 = FirebaseAuth.DefaultInstance;
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v1+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00cf;
		}
		goto IL_01a8;
	}

	protected void SigninCallbackHelper(Credential credential, string email, string userId, SocialPlatform platform, string displayName = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00e3: Expected O, but got I4
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_012e: Expected O, but got I
		//IL_013a: Expected O, but got I
		//IL_016b: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 768;
		object obj4 = obj2 + 16;
		obj4 = userId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 24;
		obj5 = email;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 32;
		obj6 = displayName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 48;
		obj7 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v18+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FirebaseAuth defaultInstance = FirebaseAuth.DefaultInstance;
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 928;
		object obj11 = (nint)0 + (nint)4000;
		object obj12 = (nint)0 + (nint)992;
		Task<FirebaseUser> task = defaultInstance.SignInWithCredentialAsync(credential);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj11);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3047354");
	}

	public void TwitterLinkCallback(string accessToken, string secret, string userID)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_01bb: Expected O, but got I4
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_012c: Expected O, but got I
		//IL_0138: Expected O, but got I
		//IL_0213: Expected O, but got I4
		//IL_0169: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 768;
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2392;
		object obj5 = obj2 + 16;
		obj5 = userID;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 24;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v12+E4]");
		FirebaseAuth firebaseAuth;
		FirebaseAuth firebaseAuth2;
		if ((nint)0 != 0)
		{
			FirebaseAuth defaultInstance = FirebaseAuth.DefaultInstance;
			object obj8 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			firebaseAuth = defaultInstance;
			firebaseAuth2 = defaultInstance;
			if (!flag)
			{
				goto IL_00f6;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			FirebaseAuth defaultInstance2 = FirebaseAuth.DefaultInstance;
			object obj8 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			firebaseAuth = defaultInstance2;
			firebaseAuth2 = defaultInstance2;
			if (obj9 != null)
			{
				goto IL_00f6;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Credential credential = TwitterAuthProvider.GetCredential(accessToken, secret);
		bool flag3 = firebaseAuth2 == null;
		object obj10 = !flag3;
		firebaseAuth = firebaseAuth2;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_010c;
		IL_00f6:
		credential = TwitterAuthProvider.GetCredential(accessToken, secret);
		goto IL_010c;
		IL_010c:
		object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 928;
		object obj12 = (nint)0 + (nint)4008;
		object obj13 = (nint)0 + (nint)992;
		Task<FirebaseUser> task = firebaseAuth.SignInWithCredentialAsync(credential);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj12);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3047354");
	}
}
