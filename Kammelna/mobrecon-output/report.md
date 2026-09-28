# Analysis Report net.peakgames.kammelna

*Generated at 2026-09-18 11:45:48 by mobrecon (Go)*

## File

| Field | Value |
|-------|--------|
| Path | `/Users/qppn/Downloads/ipa-1h37p27m.ipa` |
| Platform | IPA |
| Size | 333.4 MB |
| SHA256 | `93ee85c48e39687aea53fddebb39441f10fb1d6b85ed62e5945b69c897ec913a` |

## App identity

| Field | Value |
|-------|--------|
| Package | net.peakgames.kammelna |
| Name | كملنا Enjoy |
| Version | 3.9.5 |
| Version code | 295 |
| Min SDK | - |
| Target SDK | - |

## Detected frameworks

- Alamofire
- NSURLSession
- React Native
- Volley

## API summary

| Category | Count |
|-------|-------|
| Base URLs | 0 |
| Full URLs | 210 |
| WebSockets | 0 |
| REST paths | 8 |
| Retrofit | 0 |
| OkHttp | 0 |

Total: **219** findings — full sorted list in `apis.txt`

## Secrets summary

| Severity | Count |
|---------|-------|
| Critical | 1 |
| High | 5 |
| Medium | 17 |
| Low | 0 |

Top findings:

- **[critical] OAuth Client Secret**: `client_secret":"A6B090DCB655C3597E3A70740A3B4B841AA3BACAC52164C621EAC98FEE6FC24F"` (Payload/كملنا.app/Data/Raw/agconnect-services.json)
- **[high] Google API Key**: `AIzaSyBqOz4td-AE3HhzppwMYc6zofmgPH-m8bo` (Payload/كملنا.app/Data/Raw/google-services-desktop.json)
- **[high] Google API Key**: `AIzaSyBqOz4td-AE3HhzppwMYc6zofmgPH-m8bo` (Payload/كملنا.app/Data/Raw/google-services.json)
- **[high] Password Assignment**: `api_key":"CgB6e3x9fhl9oyecOtg7vSVnXAUO7xY2nyW+a9wVO18tyILsJO1HYiiLBBThI1n3YCpGlIUaBanfLfFj` (Payload/كملنا.app/Data/Raw/agconnect-services.json)
- **[high] Password Assignment**: `client_secret":"A6B090DCB655C3597E3A70740A3B4B841AA3BACAC52164C621EAC98FEE6FC24F"` (Payload/كملنا.app/Data/Raw/agconnect-services.json)
- **[high] Telegram Bot Token**: `7897647536:AAHw_Jp2EkCGMqOMQtLSI_89lmq67Zcq6RM` (Payload/كملنا.app/Frameworks/AricoKamlena.dylib)
- **[medium] AdMob App ID**: `ca-app-pub-3940256099942544/2934735716` (Payload/كملنا.app/GoogleService-Info.plist)
- **[medium] AdMob App ID**: `ca-app-pub-3940256099942544/2934735716` (Payload/كملنا.app/Frameworks/UnityFramework.framework/GoogleService-Info.plist)
- **[medium] AdMob App ID**: `ca-app-pub-3940256099942544/4411468910` (Payload/كملنا.app/GoogleService-Info.plist)
- **[medium] AdMob App ID**: `ca-app-pub-3940256099942544/4411468910` (Payload/كملنا.app/Frameworks/UnityFramework.framework/GoogleService-Info.plist)
- **[medium] Firebase Realtime DB URL**: `https://kammelna-b3ae7.firebaseio.com` (Payload/كملنا.app/GoogleService-Info.plist)
- **[medium] Firebase Realtime DB URL**: `https://kammelna-b3ae7.firebaseio.com` (Payload/كملنا.app/Data/Raw/google-services-desktop.json)
- **[medium] Firebase Realtime DB URL**: `https://kammelna-b3ae7.firebaseio.com` (Payload/كملنا.app/Data/Raw/google-services.json)
- **[medium] Firebase Realtime DB URL**: `https://kammelna-b3ae7.firebaseio.com` (Payload/كملنا.app/Frameworks/UnityFramework.framework/GoogleService-Info.plist)
- **[medium] Generic Key Assignment**: `api_key":"CgB6e3x9fhl9oyecOtg7vSVnXAUO7xY2nyW+a9wVO18tyILsJO1HYiiLBBThI1n3YCpGlIUaBanfLfFj` (Payload/كملنا.app/Data/Raw/agconnect-services.json)

Full sorted list in `secrets.txt` (23 findings)

## Notes

- bundle folder: Payload/كملنا.app/

