# مراجع: القيم المُسلسلة من مشهد البلوت (Unity typetree)

**المصدر**: `Data/Raw/aa/iOS/scenes_scenes_03game_baloot_*.bundle`
**محرّك**: Unity `6000.3.8f1` — شجرة الأنواع (typetree) **موجودة** في هذا البناء، فكل حقول
الـ `MonoBehaviour` قابلة للقراءة مباشرة.

---

## 1. `CardGameVisualControls` (نسخة واحدة) ⭐

```json
{
  "localCardMoveDuration"  : 0.2,
  "localCardMoveDelay"     : 0.0,
  "localCardRotDuration"   : 0.25,
  "localCardScaleDuration" : 0.5,
  "serverCardMoveDuration" : 0.4,
  "serverCardMoveDelay"    : 0.2,
  "serverCardRotDuration"  : 0.6,
  "serverCardScaleDuration": 0.6,
  "localCardStartScale"    : [1.6, 1.6, 1.6],
  "serverCardStartScale"   : [0.65, 0.65, 0.65],
  "cardSlotFlingY"         : 1860.0,
  "allUserboxes"           : [5 مراجع],
  "eatingCardsSprites"     : [4 مراجع],
  "playingCardsSprites"    : [4 مراجع]
}
```

### `UserboxCardPlayIntroRotation` (AnimationCurve)
| time | value | inSlope = outSlope | inWeight = outWeight |
|---|---|---|---|
| 0.00277007 | −0.03124994 | 0.57692301 | 0.33333334 |
| 0.21395859 | 0.13509932 | 0.97514862 | 0.33333334 |
| 0.36580583 | 0.51022553 | 3.64922595 | 0.33333334 |
| 0.49650162 | 0.86583948 | 0.41603595 | 0.33333334 |
| 1.00000000 | 1.00000000 | 2.653e−06 | 0.33333334 |

`m_PreInfinity = 2`, `m_PostInfinity = 2` (PingPong), `m_RotationOrder = 4`

### `UserboxCardPlayIntroScale` (AnimationCurve)
| time | value | inSlope | outSlope |
|---|---|---|---|
| 0.00000000 | 0.00000000 | 0.05827115 | 0.05827115 |
| 0.14767686 | 0.64161611 | 2.73914671 | 2.73914671 |
| 0.50000000 | **1.02500000** | 0.0 | 0.0 |
| 0.65000000 | **0.99000001** | −0.04649162 | 0.06919476 |
| 1.00000000 | 1.00000000 | 0.0 | 0.0 |

`m_PreInfinity = 2`, `m_PostInfinity = 2`

---

## 2. `Hand`

```json
{ "maxCardsInBottomRow": 8, "gameCardsSprite": [13 مراجع] }
```
(المقارنة: جاكارو يستخدم نفس القيمة 8 لكن يده 13 ورقة ⇒ صفّان)

---

## 3. `BalootUserbox` (10 نسخ)

```json
{ "isPlayerPrefab": 0, "direction": 3, "_restingLocalScale": 1.0,
  "originalHandRootScale": [0,0,0], "cardBacks": [8 مراجع] }
```

---

## 4. `CardsRevealer` (30 نسخة)
```json
{ "cardObjects": [7 مراجع], "cardSprites": [7 مراجع] }
```

## 5. `CatchButtons` / `SawaButtons`
```json
{ "horizontal": 0 }     // ترتيب عمودي
```

## 6. `AcesText`
```json
{ "useCommas": 1 }
```

## 7. `GameSoundManager`
```json
{ "cardSounds": [14 مرجع] }   // أصوات رمي الورقة، تُختار عشوائيًا
```

---

## 8. مكوّنات `DOTweenAnimation` في المشهد (16 نسخة)

| animationType | القيمة | المدة | easeType | loops | loopType |
|---|---|---|---|---|---|
| 5 = Scale | 0.0 | 0.3 | **26 = InBack** | 1 | — |
| 5 = Scale | 1.0 | 0.3 | **27 = OutBack** | 1 | — |
| 4 = Rotate | (0,0,−360) | 1.5 | **1 = Linear** | −1 (∞) | Restart |
| 7 = Fade/Scale | — | 1.0 | **4 = InOutSine** | −1 (∞) | **1 = Yoyo** |
| 1 = LocalMove | (0,−12,0) | 0.3 | **6 = OutQuad** | 0 | — |
| 7 | 1.0 | 0.25 | **6 = OutQuad** | 0 | — |

---

## 9. جرد مكوّنات مشهد البلوت (جوال)

```
452 Image                144 TextMeshProUGUI        76 CheatingCard
 74 LocalizeTextMeshProUGUI  73 Button              53 LayoutElement
 31 EmoteViewer           30 CardsRevealer          24 HorizontalLayoutGroup
 21 VerticalLayoutGroup   18 HighlightsItem         17 UiToggler
 16 GraphicRaycaster      16 DOTweenAnimation       14 TextMeshPro
 13 UsernameSetter        13 AvatarImageSetter      13 AvatarInitializer
 13 GameCard              12 Slider                 12 Timer
 12 ScreenCutoutFixer     12 AspectRatioFitter      10 BalootUserbox
 10 EndGameScore           9 RankUIModular           8 SwipeWheelChoice
  6 SlideAnimationHelper   6 GameComponentsStore     6 HighlightsView
  5 GiftsShowcase          5 SpriteSheetPlayer       5 RotatingLoadingIndicator
  1 كلٌّ من: BalootGame, CardGameVisualControls, CardGameUiControls, Hand,
             GameStateUI, FloorCard, ProjectButtons, SawaButtons, CatchButtons,
             KashoButton, BalootBiddingButtons, BalootPlayingButtons, AcesText,
             HintText, StreakText, AllowTeammateUi, GameSoundManager, PopupUI,
             LeaveRoomPopup, BackToPlayPopup, HintsPopup, GameReplayManager,
             FireModeManager, AnimatedItemController, SportTeamRoomTheme,
             RaterWinsCounter, LastMatchCacher, MenuAdsHandler, BlurOptimized,
             DismissibleBlocker, GiftsController, RankUI, ScreenManager
```

---

## 10. سكربت القراءة

```python
import UnityPy, glob, json
UnityPy.config.FALLBACK_UNITY_VERSION = "6000.3.8f1"

# فهرس أسماء الأصناف (MonoScript) عبر كل الحزم
idx = {}
for f in glob.glob("Data/Raw/aa/iOS/*.bundle"):
    try: env = UnityPy.load(f)
    except: continue
    for o in env.objects:
        if o.type.name == "MonoScript":
            idx[o.path_id] = o.read().m_ClassName

# قراءة قيم مكوّن معيّن
env = UnityPy.load(glob.glob("Data/Raw/aa/iOS/scenes_scenes_03game_baloot*.bundle")[0])
for o in env.objects:
    if o.type.name != "MonoBehaviour": continue
    tt  = o.read_typetree()
    cls = idx.get((tt.get("m_Script") or {}).get("m_PathID"))
    if cls == "CardGameVisualControls":
        print(json.dumps(tt, indent=1, default=str))
```
