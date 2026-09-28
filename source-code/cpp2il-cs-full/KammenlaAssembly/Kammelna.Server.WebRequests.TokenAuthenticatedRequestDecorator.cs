using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Security.Authentication;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.TextCore;
using Util;

namespace Kammelna.Server.WebRequests;

public class TokenAuthenticatedRequestDecorator<TResponse> : WebRequestDecorator<TResponse>
{
	private sealed class <Execute>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public TokenAuthenticatedRequestDecorator<TResponse> <>4__this;

		private IEnumerator <enumerator>5__2;

		private PerformIntegrityCheckOperation <integrityCheck>5__3;

		private RefreshAuthTokenRequest <tokenRequest>5__4;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <Execute>d__8(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_033e: Expected I4, but got I8
			//IL_0e95: Expected I4, but got O
			//IL_06cc: Expected I4, but got I8
			//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a9: Expected O, but got Unknown
			//IL_0a1d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a22: Expected O, but got Unknown
			//IL_0499: Expected I4, but got I8
			//IL_09dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e2: Expected O, but got Unknown
			//IL_09f8: Expected O, but got I
			//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e6: Expected O, but got Unknown
			//IL_02f6: Expected I4, but got I8
			//IL_031c: Expected O, but got I4
			//IL_0a71: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a76: Expected O, but got Unknown
			//IL_0a7e: Expected I, but got O
			//IL_0a8e: Expected O, but got I
			//IL_0733: Unknown result type (might be due to invalid IL or missing references)
			//IL_0738: Expected O, but got Unknown
			//IL_050f: Expected O, but got I
			//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d0: Expected O, but got Unknown
			//IL_05d8: Expected I, but got O
			//IL_05e8: Expected O, but got I
			//IL_007d: Expected I4, but got I8
			//IL_0b27: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b2c: Expected O, but got Unknown
			//IL_0b44: Expected O, but got I4
			//IL_0b4d: Expected O, but got I4
			//IL_076c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0771: Expected O, but got Unknown
			//IL_07c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_07cc: Expected O, but got Unknown
			//IL_07d5: Expected O, but got I4
			//IL_0681: Unknown result type (might be due to invalid IL or missing references)
			//IL_0686: Expected O, but got Unknown
			//IL_06a0: Expected O, but got I4
			//IL_06a9: Expected O, but got I4
			//IL_0ac9: Expected O, but got I
			//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e6: Expected O, but got Unknown
			//IL_079c: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a1: Expected O, but got Unknown
			//IL_07bc: Expected O, but got I4
			//IL_0810: Expected O, but got I4
			//IL_0623: Expected O, but got I
			//IL_0416: Unknown result type (might be due to invalid IL or missing references)
			//IL_041b: Expected O, but got Unknown
			//IL_024c: Expected O, but got I
			//IL_0e10: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e15: Expected O, but got Unknown
			//IL_0c38: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c3d: Expected O, but got Unknown
			//IL_0c46: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c4b: Expected O, but got Unknown
			//IL_0c5e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c63: Expected O, but got Unknown
			//IL_0c7d: Expected O, but got I4
			//IL_043d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0442: Expected O, but got Unknown
			//IL_045a: Unknown result type (might be due to invalid IL or missing references)
			//IL_045f: Expected O, but got Unknown
			//IL_0577: Unknown result type (might be due to invalid IL or missing references)
			//IL_057c: Expected O, but got Unknown
			//IL_092f: Expected I, but got O
			//IL_093f: Expected O, but got I
			//IL_08b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_08bb: Expected O, but got Unknown
			//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_08c9: Expected O, but got Unknown
			//IL_08dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e1: Expected O, but got Unknown
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Expected O, but got Unknown
			//IL_0b8c: Expected I, but got O
			//IL_0b9c: Expected O, but got I
			//IL_0ad7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0adc: Expected O, but got Unknown
			//IL_0ae5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aea: Expected O, but got Unknown
			//IL_09ce: Expected O, but got I4
			//IL_0631: Unknown result type (might be due to invalid IL or missing references)
			//IL_0636: Expected O, but got Unknown
			//IL_063f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0644: Expected O, but got Unknown
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected O, but got Unknown
			//IL_0c2b: Expected O, but got I4
			//IL_084c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0851: Expected O, but got Unknown
			//IL_0867: Expected O, but got I
			//IL_0f1f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f24: Expected O, but got Unknown
			//IL_0f3f: Expected O, but got I4
			//IL_097a: Expected O, but got I
			//IL_014d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Expected O, but got Unknown
			//IL_016d: Expected O, but got I4
			//IL_0f9c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fa1: Expected O, but got Unknown
			//IL_0fbc: Expected O, but got I4
			//IL_0bd7: Expected O, but got I
			//IL_087c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0881: Expected O, but got Unknown
			//IL_088a: Expected O, but got I4
			//IL_0e62: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e67: Expected O, but got Unknown
			//IL_0e6f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e74: Expected O, but got Unknown
			//IL_0e7d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e82: Expected O, but got Unknown
			//IL_0e34: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e39: Expected O, but got Unknown
			//IL_0e41: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e46: Expected O, but got Unknown
			//IL_0e4f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e54: Expected O, but got Unknown
			//IL_0988: Unknown result type (might be due to invalid IL or missing references)
			//IL_098d: Expected O, but got Unknown
			//IL_0996: Unknown result type (might be due to invalid IL or missing references)
			//IL_099b: Expected O, but got Unknown
			//IL_0be5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bea: Expected O, but got Unknown
			//IL_0bf3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bf8: Expected O, but got Unknown
			//IL_0d63: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d68: Expected O, but got Unknown
			//IL_0d98: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d9d: Expected O, but got Unknown
			//IL_0dbf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dc4: Expected O, but got Unknown
			//IL_0ddc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0de1: Expected O, but got Unknown
			//IL_0e01: Expected O, but got I4
			bool result;
			IEnumerator enumerator;
			object obj3;
			object obj4;
			object obj15 = default(object);
			if (<>1__state > 2)
			{
				if (<>1__state <= 4)
				{
					if (<>1__state == 3)
					{
						<>1__state = -1;
						goto IL_0a39;
					}
					bool flag = <>1__state != 4;
					result = false;
					if (flag)
					{
						goto IL_0eb7;
					}
					<>1__state = -1;
					TokenModel refreshToken = Authentication.RefreshToken;
					if (refreshToken != null)
					{
						string deviceId = UserDeviceIDRecorder.DeviceId;
						PerformIntegrityCheckOperation performIntegrityCheckOperation = <integrityCheck>5__3;
						if (<integrityCheck>5__3 != null)
						{
							object obj = typeof(System.Buffers.Text.ParserHelpers) + 3856;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							RefreshAuthTokenRequest refreshAuthTokenRequest = default(RefreshAuthTokenRequest);
							refreshAuthTokenRequest..ctor(refreshToken.<Token>k__BackingField, deviceId, performIntegrityCheckOperation.<Result>k__BackingField);
							object obj2 = this + 56;
							obj2 = refreshAuthTokenRequest;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Coroutine coroutine = WebRequestExtensions.Send((IWebRequest<object>)obj2);
							obj3 = this + 24;
							obj3 = coroutine;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							obj4 = 5;
							goto IL_0ebc;
						}
					}
				}
				else if (<>1__state != 5)
				{
					bool flag2 = <>1__state != 6;
					result = false;
					if (flag2)
					{
						goto IL_0eb7;
					}
					<>1__state = -1;
					enumerator = <enumerator>5__2;
					bool flag3 = <enumerator>5__2 == null;
					object obj5 = !flag3;
					if (obj5 != null)
					{
						goto IL_05bc;
					}
				}
				else
				{
					object obj6 = this + 56;
					object obj7 = obj6;
					_ = 4294967295L;
					if (obj6 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v74+20]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v74+20]");
							if (((KammelnaResponseModel<object>)0).Succeeded)
							{
								if (<>4__this != null)
								{
									<>4__this.Dispose();
									((TokenAuthenticatedRequestDecorator<>)(object)<>4__this).Setup();
									nint num = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3EB56E4");
									object obj8 = this + 40;
									object obj9 = default(object);
									obj8 = obj9;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									enumerator = <enumerator>5__2;
									if (<enumerator>5__2 != null)
									{
										goto IL_05bc;
									}
								}
							}
							else
							{
								object obj10 = this + 48;
								obj10 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								bool flag4 = <>4__this == null;
								object obj11 = !flag4;
								if (obj11 != null)
								{
									goto IL_0e06;
								}
							}
						}
					}
				}
			}
			else if (<>1__state != 0)
			{
				if (<>1__state != 1)
				{
					bool flag5 = <>1__state != 2;
					result = false;
					if (flag5)
					{
						goto IL_0eb7;
					}
					object obj12 = this + 56;
					object obj13 = obj12;
					_ = 4294967295L;
					if (obj12 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X8_v53+20]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X8_v53+20]");
							if (((KammelnaResponseModel<object>)0).Succeeded)
							{
								if (<>4__this != null)
								{
									nint num2 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3EB54AC");
									goto IL_0876;
								}
							}
							else if (<>4__this != null)
							{
								object obj14 = "Picking audio files is not supported on iOS" + 1176;
								nint num3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X8_v60 (Il2CppRgctx<Kammelna.Server.WebRequests.TokenAuthenticatedRequestDecorator`1+<Execute>d__8>)+20]");
								obj15 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3EB52A0");
								goto IL_0876;
							}
						}
					}
				}
				else
				{
					<>1__state = -1;
					TokenModel refreshToken2 = Authentication.RefreshToken;
					if (refreshToken2 != null)
					{
						string deviceId2 = UserDeviceIDRecorder.DeviceId;
						PerformIntegrityCheckOperation performIntegrityCheckOperation2 = <integrityCheck>5__3;
						if (<integrityCheck>5__3 != null)
						{
							object obj16 = typeof(System.Buffers.Text.ParserHelpers) + 3856;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							RefreshAuthTokenRequest refreshAuthTokenRequest2 = default(RefreshAuthTokenRequest);
							refreshAuthTokenRequest2..ctor(refreshToken2.<Token>k__BackingField, deviceId2, performIntegrityCheckOperation2.<Result>k__BackingField);
							object obj17 = this + 56;
							obj17 = refreshAuthTokenRequest2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Coroutine coroutine2 = WebRequestExtensions.Send((IWebRequest<object>)obj17);
							obj3 = this + 24;
							obj3 = coroutine2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							obj4 = 2;
							goto IL_0ebc;
						}
					}
				}
			}
			else
			{
				<>1__state = -1;
				if (<>4__this != null)
				{
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3EB55E8");
					object obj18 = default(object);
					if (obj18 != null)
					{
						if (Authentication.CanLogin())
						{
							TokenModel refreshToken3 = Authentication.RefreshToken;
							if (refreshToken3 == null)
							{
								goto IL_0e87;
							}
							object obj19 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2728;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							GetRefreshChallengeRequest getRefreshChallengeRequest = default(GetRefreshChallengeRequest);
							getRefreshChallengeRequest..ctor(refreshToken3.<Token>k__BackingField);
							object obj20 = typeof(System.Buffers.Text.ParserHelpers) + 256;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							PerformIntegrityCheckOperation performIntegrityCheckOperation3 = default(PerformIntegrityCheckOperation);
							performIntegrityCheckOperation3..ctor(getRefreshChallengeRequest);
							object obj21 = this + 48;
							obj21 = performIntegrityCheckOperation3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj22 = this + 24;
							obj22 = obj21;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							_ = 1;
							result = true;
							goto IL_0eb7;
						}
						object obj23 = "Picking audio files is not supported on iOS" + 1136;
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X8_v41 (Il2CppRgctx<Kammelna.Server.WebRequests.TokenAuthenticatedRequestDecorator`1+<Execute>d__8>)+20]");
						obj15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3EB52A0");
					}
					goto IL_0a07;
				}
			}
			goto IL_0e87;
			IL_0876:
			object obj24 = this + 48;
			obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			goto IL_0a07;
			IL_09bb:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj15 = 1;
			goto IL_0f0f;
			IL_0c18:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj15 = 1;
			goto IL_0f8c;
			IL_0f8c:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v941 @ X0_v29] (should have been resolved before IL gen)");
			obj3 = this + 24;
			object obj25 = default(object);
			obj3 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj4 = 3;
			goto IL_0ebc;
			IL_0ebc:
			return true;
			IL_06b7:
			return false;
			IL_0e06:
			object obj26 = "Picking audio files is not supported on iOS" + 1024;
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3EB52A0");
			return false;
			IL_0e87:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0a07:
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3EB56E4");
			object obj27 = this + 40;
			object obj28 = default(object);
			obj27 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			goto IL_0a39;
			IL_0b0a:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v569 @ X0_v38] (should have been resolved before IL gen)");
			object obj30 = default(object);
			object obj29 = obj30 & 1;
			bool flag6 = obj29 == null;
			obj15 = 0;
			object obj31 = 0;
			if (!flag6)
			{
				goto IL_0b5b;
			}
			goto IL_0c93;
			IL_0c93:
			if (<>4__this != null)
			{
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @424F2AC");
				UnityWebRequest unityWebRequest = default(UnityWebRequest);
				if (unityWebRequest != null)
				{
					long responseCode = unityWebRequest.responseCode;
					if (responseCode != 401)
					{
						goto IL_06b7;
					}
					if (!Authentication.CanLogin())
					{
						goto IL_0e06;
					}
					TokenModel refreshToken4 = Authentication.RefreshToken;
					if (refreshToken4 != null)
					{
						object obj32 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2728;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						GetRefreshChallengeRequest getRefreshChallengeRequest2 = default(GetRefreshChallengeRequest);
						getRefreshChallengeRequest2..ctor(refreshToken4.<Token>k__BackingField);
						object obj33 = typeof(System.Buffers.Text.ParserHelpers) + 256;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						PerformIntegrityCheckOperation performIntegrityCheckOperation4 = default(PerformIntegrityCheckOperation);
						performIntegrityCheckOperation4..ctor(getRefreshChallengeRequest2);
						object obj34 = this + 48;
						obj34 = performIntegrityCheckOperation4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						obj3 = this + 24;
						obj3 = obj34;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						obj4 = 4;
						goto IL_0ebc;
					}
				}
			}
			goto IL_0e87;
			IL_0f0f:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v970 @ X0_v91] (should have been resolved before IL gen)");
			obj3 = this + 24;
			object obj35 = default(object);
			obj3 = obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj4 = 6;
			goto IL_0ebc;
			IL_08fe:
			IEnumerator enumerator2 = <enumerator>5__2;
			if (<enumerator>5__2 == null)
			{
				goto IL_0e87;
			}
			nint num9 = (nint)enumerator2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ X8_v66 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ X8_v66 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_09bb;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ X8_v66 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
			object obj37 = (nint)0 + (nint)8;
			object obj38;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v891 @ X10_v23-8]");
				if (0 == (nint)obj38)
				{
					break;
				}
				obj37 += 16;
				obj36--;
				if ((nint)obj36 != 1)
				{
					continue;
				}
				goto IL_09bb;
			}
			object obj39 = obj37 + 1;
			object obj40 = num9 + obj39;
			object obj41 = obj40 + 312;
			goto IL_0f0f;
			IL_0a39:
			IEnumerator enumerator3 = <enumerator>5__2;
			object obj42;
			if (<enumerator>5__2 != null)
			{
				obj42 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
				nint num10 = (nint)enumerator3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v13 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				object obj43 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v13 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0b0a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v13 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
				object obj44 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X10_v15-8]");
					if (0 == (nint)obj42)
					{
						break;
					}
					obj44 += 16;
					obj43--;
					if ((nint)obj43 != 1)
					{
						continue;
					}
					goto IL_0b0a;
				}
				object obj45 = num10 + obj44;
				object obj46 = obj45 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v687 @ X0_v41] (should have been resolved before IL gen)");
				object obj48 = default(object);
				object obj47 = obj48 & 1;
				bool flag7 = obj47 == null;
				object obj49 = !flag7;
				obj31 = obj15;
				if (obj49 != null)
				{
					goto IL_0b5b;
				}
				goto IL_0c93;
			}
			goto IL_0e87;
			IL_0eb7:
			return result;
			IL_0b5b:
			IEnumerator enumerator4 = <enumerator>5__2;
			if (<enumerator>5__2 == null)
			{
				goto IL_0e87;
			}
			nint num11 = (nint)enumerator4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X8_v23 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			object obj50 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X8_v23 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0c18;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X8_v23 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
			object obj51 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v870 @ X10_v10-8]");
				if (0 == (nint)obj42)
				{
					break;
				}
				obj51 += 16;
				obj50--;
				if ((nint)obj50 != 1)
				{
					continue;
				}
				goto IL_0c18;
			}
			object obj52 = obj51 + 1;
			object obj53 = num11 + obj52;
			object obj54 = obj53 + 312;
			goto IL_0f8c;
			IL_0664:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v598 @ X0_v100] (should have been resolved before IL gen)");
			object obj56 = default(object);
			object obj55 = obj56 & 1;
			bool flag8 = obj55 == null;
			object obj57 = !flag8;
			obj15 = 0;
			if (obj57 == null)
			{
				goto IL_06b7;
			}
			goto IL_08fe;
			IL_05bc:
			obj38 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
			nint num12 = (nint)enumerator;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v64 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			object obj58 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v64 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0664;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v64 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
			object obj59 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X10_v28-8]");
				if (0 == (nint)obj38)
				{
					break;
				}
				obj59 += 16;
				obj58--;
				if ((nint)obj58 != 1)
				{
					continue;
				}
				goto IL_0664;
			}
			object obj60 = num12 + obj59;
			object obj61 = obj60 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v700 @ X0_v103] (should have been resolved before IL gen)");
			object obj63 = default(object);
			object obj62 = obj63 & 1;
			if (obj62 == null)
			{
				goto IL_06b7;
			}
			goto IL_08fe;
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
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			throw new OutOfMemoryException();
		}
	}

	private sealed class <Materialize>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public TokenAuthenticatedRequestDecorator<TResponse> <>4__this;

		private IEnumerator <steps>5__2;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <Materialize>d__7(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00a3: Expected I4, but got I8
			//IL_0021: Expected O, but got I4
			//IL_036c: Expected I4, but got O
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Expected O, but got Unknown
			//IL_00c4: Expected I, but got O
			//IL_00d4: Expected O, but got I
			//IL_003e: Expected I4, but got I8
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Expected O, but got Unknown
			//IL_018a: Expected O, but got I4
			//IL_010f: Expected O, but got I
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected O, but got Unknown
			//IL_0275: Unknown result type (might be due to invalid IL or missing references)
			//IL_027a: Expected O, but got Unknown
			//IL_0283: Unknown result type (might be due to invalid IL or missing references)
			//IL_0288: Expected O, but got Unknown
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Expected O, but got Unknown
			//IL_02ba: Expected O, but got I4
			//IL_01c9: Expected I, but got O
			//IL_01d9: Expected O, but got I
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected O, but got Unknown
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Expected O, but got Unknown
			//IL_0325: Expected O, but got I
			//IL_0268: Expected O, but got I4
			//IL_040c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0411: Expected O, but got Unknown
			//IL_0214: Expected O, but got I
			//IL_0339: Unknown result type (might be due to invalid IL or missing references)
			//IL_033e: Expected O, but got Unknown
			//IL_0346: Unknown result type (might be due to invalid IL or missing references)
			//IL_034b: Expected O, but got Unknown
			//IL_0354: Unknown result type (might be due to invalid IL or missing references)
			//IL_0359: Expected O, but got Unknown
			//IL_0222: Unknown result type (might be due to invalid IL or missing references)
			//IL_0227: Expected O, but got Unknown
			//IL_0230: Unknown result type (might be due to invalid IL or missing references)
			//IL_0235: Expected O, but got Unknown
			if (<>1__state != 1)
			{
				bool flag = <>1__state == 0;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_032a;
				}
				<>1__state = -1;
				if (<>4__this == null)
				{
					goto IL_035e;
				}
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3EB56C4");
				object obj2 = this + 40;
				object obj3 = default(object);
				obj2 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				<>1__state = -1;
			}
			IEnumerator enumerator = <steps>5__2;
			object obj4;
			if (<steps>5__2 != null)
			{
				obj4 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
				nint num2 = (nint)enumerator;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v5 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v5 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0150;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v5 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
				object obj6 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X10_v12-8]");
					if (0 == (nint)obj4)
					{
						break;
					}
					obj6 += 16;
					obj5--;
					if ((nint)obj5 != 1)
					{
						continue;
					}
					goto IL_0150;
				}
				object obj7 = num2 + obj6;
				object obj8 = obj7 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v287 @ X0_v21] (should have been resolved before IL gen)");
				object obj10 = default(object);
				object obj9 = obj10 & 1;
				bool flag2 = obj9 == null;
				object obj11 = !flag2;
				if (obj11 != null)
				{
					goto IL_0198;
				}
				goto IL_02c8;
			}
			goto IL_035e;
			IL_0255:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj12 = 1;
			goto IL_03fc;
			IL_0198:
			IEnumerator enumerator2 = <steps>5__2;
			if (<steps>5__2 == null)
			{
				goto IL_035e;
			}
			nint num3 = (nint)enumerator2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v10 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v10 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0255;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v10 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
			object obj14 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X10_v7-8]");
				if (0 == (nint)obj4)
				{
					break;
				}
				obj14 += 16;
				obj13--;
				if ((nint)obj13 != 1)
				{
					continue;
				}
				goto IL_0255;
			}
			object obj15 = obj14 + 1;
			object obj16 = num3 + obj15;
			object obj17 = obj16 + 312;
			goto IL_03fc;
			IL_0150:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v256 @ X0_v18] (should have been resolved before IL gen)");
			object obj19 = default(object);
			object obj18 = obj19 & 1;
			bool flag3 = obj18 == null;
			obj12 = 0;
			if (!flag3)
			{
				goto IL_0198;
			}
			goto IL_02c8;
			IL_02c8:
			if (<>4__this != null)
			{
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @424F358");
				object obj20 = default(object);
				if (obj20 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v5+38]");
					JwtRefreshUtil.ApplyIfPresent((string)0);
					goto IL_032a;
				}
			}
			goto IL_035e;
			IL_032a:
			return false;
			IL_035e:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_03fc:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v357 @ X0_v8] (should have been resolved before IL gen)");
			object obj21 = this + 24;
			object obj22 = default(object);
			obj21 = obj22;
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
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			throw new OutOfMemoryException();
		}
	}

	private const string AuthorizationHeader = "Authorization";

	private const string DefaultHeaderValue = "Bearer DummyValueRequiredByAsp";

	private readonly bool <IsOptional>k__BackingField;

	private bool IsOptional
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.TokenAuthenticatedRequestDecorator`1<TResponse>)+18]");
			return false;
		}
	}

	public TokenAuthenticatedRequestDecorator(IWebRequest<TResponse> request, bool isOptional)
	{
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @424F4BC");
	}

	public override void Setup()
	{
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @424F4F0");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3EB54AC");
	}

	public override IEnumerator Materialize()
	{
		//IL_0016: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0054: Expected O, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.TokenAuthenticatedRequestDecorator`1>)+30]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.TokenAuthenticatedRequestDecorator`1>)+30]");
		object obj2 = (nint)0 + (nint)309;
		object obj3 = obj2 & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @45A9AA4");
		IEnumerator enumerator = default(IEnumerator);
		if (enumerator != null)
		{
			object obj5 = enumerator + 32;
			obj5 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return enumerator;
		}
		return (IEnumerator)new NullReferenceException();
	}

	public override IEnumerator Execute()
	{
		//IL_0016: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0054: Expected O, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.TokenAuthenticatedRequestDecorator`1>)+40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.TokenAuthenticatedRequestDecorator`1>)+40]");
		object obj2 = (nint)0 + (nint)309;
		object obj3 = obj2 & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @449C830");
		IEnumerator enumerator = default(IEnumerator);
		if (enumerator != null)
		{
			object obj5 = enumerator + 32;
			obj5 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return enumerator;
		}
		return (IEnumerator)new NullReferenceException();
	}

	private void HandleAuthenticationFailed(string stage)
	{
		//IL_0016: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_006d: Expected O, but got I
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.TokenAuthenticatedRequestDecorator`1<TResponse>)+18]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			return;
		}
		object obj2 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = (nint)0 + (nint)3848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Action action = default(Action);
		IntPtr method = default(IntPtr);
		action..ctor(null, method);
		object obj4 = "AvailableVoices" + 768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		string buttonText = default(string);
		PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateError(action, buttonText);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9D050");
		object obj5 = "SERVICE_DISABLED" + 3600;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		string title = default(string);
		IPopupWindowBuilderNeedsBody popupWindowBuilderNeedsBody = popupWindowBuilder.Titled(title);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9D050");
		object obj6 = typeof(System.IOAsyncCallback) + 384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		object obj7 = "Unsupported map type" + 720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CA86B8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9D050");
		object obj8 = typeof(System.IOAsyncCallback) + 368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9DB58");
		object obj9 = typeof(SqlSingle[]) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9D050");
		object obj10 = "WhiteSmoke" + 2416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9AC34");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9D050");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9AC34");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9D050");
		object obj11 = "[{0}]:{1}" + 464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9AC34");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9D050");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D9C9F8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9D050");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9AC34");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9D050");
		object obj12 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9AC34");
		string[] array = default(string[]);
		string message = string.Concat(array);
		object obj13 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		AuthenticationException ex = default(AuthenticationException);
		ex..ctor(message);
		throw new OutOfMemoryException();
	}

	private void InitializeAuthHeader()
	{
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		object name = "Added Tournament Prizes And Features" + 3864;
		TokenModel accessToken = Authentication.AccessToken;
		if (accessToken != null && accessToken.IsValid)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @424F2AC");
			TokenModel accessToken2 = Authentication.AccessToken;
			object obj = "AvailableVoices" + 1328;
			string value = (string)obj + accessToken2.<Token>k__BackingField;
			UnityWebRequest unityWebRequest = default(UnityWebRequest);
			unityWebRequest.SetRequestHeader((string)name, value);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.TokenAuthenticatedRequestDecorator`1<TResponse>)+18]");
		if ((nint)0 != 1 || Authentication.CanLogin())
		{
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @424F2AC");
			object value2 = "AvailableVoices" + 1336;
			UnityWebRequest unityWebRequest2 = default(UnityWebRequest);
			unityWebRequest2.SetRequestHeader((string)name, (string)value2);
		}
	}

	private bool IsNotAuthorized()
	{
		//IL_00ca: Expected I4, but got O
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_00a6: Expected O, but got I
		if (this != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @424F2AC");
			UnityWebRequest unityWebRequest = default(UnityWebRequest);
			if (unityWebRequest != null)
			{
				object name = "Added Tournament Prizes And Features" + 3864;
				object obj = "AvailableVoices" + 1336;
				string requestHeader = unityWebRequest.GetRequestHeader((string)name);
				if (requestHeader == (string)obj)
				{
					return true;
				}
				object obj2 = (nint)0 + (nint)2000;
				return requestHeader == (string)obj2;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private IEnumerator <>n__0()
	{
		if (this != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @424F618");
			IEnumerator result = default(IEnumerator);
			return result;
		}
		return (IEnumerator)new NullReferenceException();
	}

	private IEnumerator <>n__1()
	{
		if (this != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @424F59C");
			IEnumerator result = default(IEnumerator);
			return result;
		}
		return (IEnumerator)new NullReferenceException();
	}
}
