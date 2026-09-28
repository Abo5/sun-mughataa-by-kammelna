# جرد تغطية البلوت — قائمة العمل (مُعاد توليدها آليًا)

> **مُولَّدة من `source-code/il2cpp-dump/script.json.gz`** بمطابقة تقاطعية مع العناوين المذكورة في
> [الفصل ١٥](../15-تدقيق-ARM64.md). حجم الدالة = عنوان الدالة التالية − عنوانها.
> المعيار: **≥150 بايت**، مع استبعاد قوالب الـ64 بايت (`NotImplementedException`).

| المقياس | القيمة |
|---|---|
| عناوين مفكوكة ومُوثَّقة | **211** |
| متبقٍّ ≥150B في أصناف البلوت | **595** |

## ⚠️ تصحيح تصنيف

النسخة السابقة من هذا الملف كانت مُصنَّفة يدويًا، وكانت **خاطئة**: وضعت
`BalootUtils.PlayableCards` و`BalootUtils.CheckWhoEats` و`BalootAiLogic` في «الطبقة ٤ —
غير ضرورية»، وهي في الحقيقة **أهم دوال القواعد في اللعبة كلها**. هذه النسخة مُولَّدة
آليًا من `script.json.gz` فلا تعتمد على تصنيف يدوي.

---

## أ — قواعد ومنطق (45 دالة) — **أولوية قصوى**

| الحجم | الصنف | الدالة | العنوان |
|---|---|---|---|
| 6460B | `BalootRoundBoardPopup` | **ShowRoundBoard** | `0x4F9F88C` |
| 160B | `BalootRoundBoardPopup` | **ShowAnimation** | `0x4FA1444` |
| 4420B | `BalootUtils` | **PlayableCards** | `0x51FAA34` |
| 1880B | `BalootUtils` | **CheckWhoEats** | `0x520584C` |
| 2016B | `CardGameEndScores` | **SetCardGameEndScores** | `0x52F9774` |
| 1196B | `CardGameEndScores` | **TestPopulate** | `0x5301EC4` |
| 596B | `CardGameEndScores` | **get_Achievements** | `0x5301BE4` |
| 308B | `CardGameEndScores` | **<get_Achievements>b__88_0** | `0x53023DC` |
| 844B | `CardUtilExtensions` | **GetCardsWithSuits** | `0x530C448` |
| 844B | `CardUtilExtensions` | **GetCardsWithRanks** | `0x530C0F4` |
| 844B | `CardUtilExtensions` | **GetCards** | `0x530BDA0` |
| 236B | `CardUtilExtensions` | **<Contains>b__0** | `0x530CDD8` |
| 236B | `CardUtilExtensions` | **<Contains>b__0** | `0x530CCC0` |
| 232B | `CardUtilExtensions` | **Contains** | `0x530BCB0` |
| 232B | `CardUtilExtensions` | **Contains** | `0x530BBC0` |
| 232B | `CardUtilExtensions` | **Contains** | `0x530BAD0` |
| 1740B | `CheatingInfo` | **.ctor** | `0x530DA88` |
| 892B | `CheatingInfo` | **CreateCheatingData** | `0x530E4B0` |
| 576B | `CheatingInfo` | **CreateCheatingData** | `0x530E270` |
| 1616B | `BalootBiddingOptions` | **GetBiddingOptionsFromState** | `0x51FC460` |
| 1540B | `BalootBiddingOptions` | **BiddingOptionFromSfsObject** | `0x520013C` |
| 1192B | `BalootAiLogic` | **PlayCard** | `0x51FA500` |
| 728B | `BalootAiLogic` | **GetEatingCards** | `0x51FBB78` |
| 528B | `BalootAiLogic` | **Bid** | `0x51FC250` |
| 212B | `BalootAiLogic` | **GetMinCard** | `0x51FC17C` |
| 212B | `BalootAiLogic` | **GetMaxCard** | `0x51FBFB0` |
| 2096B | `BalootRoundScore` | **Record** | `0x52FE624` |
| 1936B | `CardGameStatistics` | **SetStatistics** | `0x52FF2B8` |
| 628B | `BalootStatistics` | **AddStat** | `0x52FFA48` |
| 528B | `BalootStatistics` | **SetStatistics** | `0x52FF0A8` |
| 404B | `BalootStatistics` | **StatisticsInfo** | `0x52FFCF8` |
| 632B | `BalootPlayer` | **UpdatePlayerState** | `0x52FCB10` |
| 236B | `BalootPlayer` | **get_IsRoundDoubler** | `0x52FC840` |
| 220B | `BalootPlayer` | **get_Game** | `0x52FC92C` |
| 576B | `LiveCatchingInfo` | **SendCheatingData** | `0x4F8DC90` |
| 476B | `LiveCatchingInfo` | **.ctor** | `0x4F8E950` |
| 824B | `BalootEndScores` | **SetCardGameEndScores** | `0x52F943C` |
| 756B | `CardGameHighlights` | **SetHighlights** | `0x5302570` |
| 456B | `BalootPlayingManager` | **ClearPlayersVariables** | `0x5208904` |
| 204B | `BalootPlayingManager` | **<UpdateDeclaredProjectsFirstMove>b__4_2** | `0x5208E88` |
| 332B | `CardUtils` | **EncodeBinaryLongCards** | `0x530A800` |
| 300B | `CardUtils` | **EncodeBinaryLongCards** | `0x530A94C` |
| 552B | `BalootCardUtils` | **get_AllBalootCards** | `0x52F8C2C` |
| 248B | `BalootGameController` | **<BuildRoundState>b__1** | `0x52074D8` |
| 248B | `BalootGameController` | **<BuildRoundState>b__0** | `0x52073E0` |

---

## ب — واجهات اللعب (187 دالة)

| الحجم | الصنف | الدالة | العنوان |
|---|---|---|---|
| 3436B | `Userbox` | **FixDirection** | `0x4FBDF38` |
| 1496B | `Userbox` | **UnRegisterEventListeners** | `0x4FBD960` |
| 1232B | `Userbox` | **RegisterEventListeners** | `0x4FBD490` |
| 980B | `Userbox` | **Awake** | `0x4FB9070` |
| 884B | `Userbox` | **StartVoiceAnimation** | `0x4FC0298` |
| 868B | `Userbox` | **OnGameInitialized** | `0x4FBD120` |
| 836B | `Userbox` | **ReorganizeCards** | `0x4FC0748` |
| 640B | `Userbox` | **RefreshVoiceUI** | `0x4FBFB9C` |
| … | `Userbox` | *(+33 أخرى)* | |
| 3484B | `MiniGameHand` | **AnimateDrawCards** | `0x4F498DC` |
| 2508B | `MiniGameHand` | **HighlightRewards** | `0x4F4A90C` |
| 1200B | `MiniGameHand` | **CardSelected** | `0x4F49024` |
| 1024B | `MiniGameHand` | **ReturnRewardCards** | `0x4F494DC` |
| 804B | `MiniGameHand` | **Awake** | `0x4F48C18` |
| 412B | `MiniGameHand` | **OnMoveSent** | `0x4F4B5CC` |
| 368B | `MiniGameHand` | **SendMove** | `0x4F4BB24` |
| 344B | `MiniGameHand` | **OnGameStart** | `0x4F4B414` |
| … | `MiniGameHand` | *(+14 أخرى)* | |
| 1976B | `CheatingCatchPopup` | **ShowCheatingBoard** | `0x4F8CC50` |
| 1280B | `CheatingCatchPopup` | **UpdateCatcherTip** | `0x4F8C16C` |
| 776B | `CheatingCatchPopup` | **Clear** | `0x4F8BB2C` |
| 748B | `CheatingCatchPopup` | **ShowCheatingResult** | `0x4F8D49C` |
| 736B | `CheatingCatchPopup` | **GetCheatMode** | `0x4F8C6A4` |
| 620B | `CheatingCatchPopup` | **Awake** | `0x4F8B8C0` |
| 608B | `CheatingCatchPopup` | **InitializeCheatingBoxes<object>** | `0x2D21984` |
| 448B | `CheatingCatchPopup` | **OnCardClicked** | `0x4F8D874` |
| … | `CheatingCatchPopup` | *(+13 أخرى)* | |
| 2236B | `BalootBiddingButtons` | **SubmitBid** | `0x4F82AB8` |
| 696B | `BalootBiddingButtons` | **ShowBid** | `0x4F82054` |
| 676B | `BalootBiddingButtons` | **UpdateShowBid** | `0x4F824A8` |
| 568B | `BalootBiddingButtons` | **UpdateStateButtons** | `0x4F83374` |
| 504B | `BalootBiddingButtons` | **MitigateMissClicks** | `0x4F835AC` |
| 456B | `BalootBiddingButtons` | **ShowPredetermineBid** | `0x4F81CFC` |
| 412B | `BalootBiddingButtons` | **HandleBiddingButtons** | `0x4F8230C` |
| 400B | `BalootBiddingButtons` | **isDefaultBidString** | `0x4F8274C` |
| … | `BalootBiddingButtons` | *(+7 أخرى)* | |
| 672B | `PopupUI` | **Show** | `0x5135A4C` |
| 552B | `PopupUI` | **Awake** | `0x5135824` |
| 460B | `PopupUI` | **HideBlur** | `0x5136400` |
| 436B | `PopupUI` | **ShowBlur** | `0x5135DCC` |
| 368B | `PopupUI` | **ShowBlurOnly** | `0x5135F80` |
| 344B | `PopupUI` | **PopFromParent** | `0x5136854` |
| 344B | `PopupUI` | **PopFromCustomParent** | `0x51366FC` |
| 340B | `PopupUI` | **ShrinkToParent** | `0x51369AC` |
| … | `PopupUI` | *(+7 أخرى)* | |
| 736B | `CardBackSetter` | **ShowCardsAnimated** | `0x50C9660` |
| 548B | `CardBackSetter` | **AssignCardBackHelper** | `0x50C8F64` |
| 500B | `CardBackSetter` | **<AssignImage>b__0** | `0x50C9F34` |
| 480B | `CardBackSetter` | **ShowCards** | `0x50C9940` |
| 468B | `CardBackSetter` | **AssignEffect** | `0x50C92E0` |
| 428B | `CardBackSetter` | **AssignImage** | `0x50C94B4` |
| 376B | `CardBackSetter` | **Initialize** | `0x50C9B28` |
| 344B | `CardBackSetter` | **AssignMaterial** | `0x50C9188` |
| … | `CardBackSetter` | *(+3 أخرى)* | |
| 768B | `KGameUiControls` | **SetGameToLoading** | `0x4F9BB1C` |
| 588B | `KGameUiControls` | **RegisterEvents** | `0x4F9B1EC` |
| 548B | `KGameUiControls` | **OnButtonExitClick** | `0x4F9B830` |
| 212B | `KGameUiControls` | **OnDestroy** | `0x4F9B438` |
| 200B | `KGameUiControls` | **OnGameStateUpdated** | `0x4F9B50C` |
| 200B | `KGameUiControls` | **Init** | `0x4F9BA54` |
| 200B | `KGameUiControls` | **Awake** | `0x4F9B124` |
| 192B | `KGameUiControls` | **ShowOfflineUi** | `0x4F9C030` |
| … | `KGameUiControls` | *(+4 أخرى)* | |
| 908B | `SawaButtons` | **Start** | `0x4F8EE5C` |
| 480B | `SawaButtons` | **SendSawa** | `0x4F8F6F8` |
| 388B | `SawaButtons` | **ToggleSawaPanel** | `0x4F8F9AC` |
| 336B | `SawaButtons` | **OnGameStateUpdated** | `0x4F8F2CC` |
| 228B | `SawaButtons` | **Submit** | `0x4F8F614` |
| 228B | `SawaButtons` | **OnDestroy** | `0x4F8F1E8` |
| 212B | `SawaButtons` | **UpdateMessage** | `0x4F8F41C` |
| 212B | `SawaButtons` | **DontShowAgainToggleChanged** | `0x4F8F540` |
| … | `SawaButtons` | *(+2 أخرى)* | |
| 664B | `ProjectButtons` | **OnProjectButtonClick** | `0x4F9E308` |
| 660B | `ProjectButtons` | **Awake** | `0x4F9D94C` |
| 360B | `ProjectButtons` | **UpdateLabels** | `0x4F9DFE8` |
| 360B | `ProjectButtons` | **OnGameStateUpdated** | `0x4F9DD94` |
| 304B | `ProjectButtons` | **GetProjects** | `0x4F9E700` |
| 288B | `ProjectButtons` | **ResetProjects** | `0x4F9DBE0` |
| 272B | `ProjectButtons` | **ToggleProjectsPanel** | `0x4F9E150` |
| 260B | `ProjectButtons` | **ShowProjectsError** | `0x4F9E5FC` |
| … | `ProjectButtons` | *(+1 أخرى)* | |
| 788B | `CatchButtons` | **Start** | `0x4F8AB74` |
| 412B | `CatchButtons` | **HandleCatchButtons** | `0x4F8B168` |
| 332B | `CatchButtons` | **OnGameStateUpdated** | `0x4F8AFCC` |
| 316B | `CatchButtons` | **SendCatch** | `0x4F8B37C` |
| 216B | `CatchButtons` | **FillCatchButtonsDictionary** | `0x4F8AA9C` |
| 176B | `CatchButtons` | **Clear** | `0x4F8AE88` |
| 1224B | `BalootPlayingButtons` | **Start** | `0x4FB7D88` |
| 388B | `BalootPlayingButtons` | **OnDestroy** | `0x4FB836C` |
| 200B | `BalootPlayingButtons` | **<Start>b__10_0** | `0x4FB8B54` |
| 180B | `BalootPlayingButtons` | **HideContainer** | `0x4FB8250` |
| 672B | `AllowTeammateUi` | **OnGameStatusUpdated** | `0x4F7F8BC` |
| 344B | `AllowTeammateUi` | **Awake** | `0x4F7F764` |
| 208B | `AllowTeammateUi` | **Refuse** | `0x4F7FD70` |
| 208B | `AllowTeammateUi` | **Accept** | `0x4F7FCA0` |
| 184B | `AllowTeammateUi` | **Hide** | `0x4F7FBE8` |
| 424B | `GameStateUI` | **Awake** | `0x4F930D4` |
| 384B | `GameStateUI` | **OnGameStateUpdated** | `0x4F9327C` |
| 260B | `GameStateUI` | **ShowAcceptNext** | `0x4F93530` |
| 212B | `GameStateUI` | **ShowAcceptNextAfterDelay** | `0x4F93714` |
| 180B | `GameStateUI` | **ShouldAcceptNext** | `0x4F9347C` |
| 860B | `SawaCatchPopup` | **OnCheating** | `0x4F8FE28` |
| 332B | `SawaCatchPopup` | **Awake** | `0x4F8FCDC` |
| 408B | `BaseCheatingBox` | **Populate** | `0x4F8A4EC` |
| 208B | `BaseCheatingBox` | **Highlight** | `0x4F8A75C` |
| 180B | `BaseCheatingBox` | **remove_OnCardClicked** | `0x4F8A388` |
| 180B | `BaseCheatingBox` | **add_OnCardClicked** | `0x4F8A2D4` |
| 176B | `BaseCheatingBox` | **Awake** | `0x4F8A43C` |
| 348B | `KashoButton` | **Start** | `0x4F83C1C` |
| 300B | `KashoButton` | **ShowButton** | `0x4F83F54` |
| 172B | `KashoButton` | **Submit** | `0x4F83D78` |
| 168B | `KashoButton` | **HideButton** | `0x4F83E24` |

---

## ج — التعليم/التدريب (84 دالة)

`TutorialCards..cctor` وحدها **76 KB** من جداول ثابتة (مجموعات أوراق الدروس).
تُقرأ عند الحاجة من `global-metadata.dat` لا بالتفكيك.

| الحجم | الصنف | الدالة | العنوان |
|---|---|---|---|
| 73868B | `TutorialCards` | **.cctor** | `0x520B8E4` |
| 588B | `TutorialCards` | **AddArrayCards** | `0x520B698` |
| 564B | `TutorialCards` | **GetDistributionSecondPhase** | `0x520B25C` |
| 564B | `TutorialCards` | **GetDistributionFirstPhase** | `0x520B028` |
| 324B | `TutorialCards` | **GetFloor** | `0x520B490` |
| … | `TutorialCards` | *(+1 أخرى)* | |
| 1988B | `TutorialGameController` | **GetWantedToPlayCards** | `0x521FC00` |
| 1540B | `TutorialGameController` | **CatchCheating** | `0x521E70C` |
| 1100B | `TutorialGameController` | **GetEatingsSFSArray** | `0x521F1E0` |
| 804B | `TutorialGameController` | **SetUpCheatingData** | `0x521ED10` |
| 748B | `TutorialGameController` | **SendGameState** | `0x521F914` |
| … | `TutorialGameController` | *(+14 أخرى)* | |
| 1564B | `Tutorial` | **MoveNext** | `0x5070B5C` |
| 1416B | `Tutorial` | **ShowPage** | `0x5070000` |
| 552B | `Tutorial` | **MoveNext** | `0x50711CC` |
| 456B | `Tutorial` | **SetupButtons** | `0x506FD8C` |
| 400B | `Tutorial` | **<SetupButtons>g__Call|0** | `0x50708AC` |
| … | `Tutorial` | *(+5 أخرى)* | |
| 1140B | `TutorialOnboarding` | **TabletSwitchPopup** | `0x4EF6634` |
| 608B | `TutorialOnboarding` | **AnimationStart** | `0x4EF5E50` |
| 604B | `TutorialOnboarding` | **AnimationAwake** | `0x4EF5BF0` |
| 564B | `TutorialOnboarding` | **AnimationExit** | `0x4EF6400` |
| 536B | `TutorialOnboarding` | **Start** | `0x4EF58B4` |
| … | `TutorialOnboarding` | *(+7 أخرى)* | |
| 3028B | `TutorialTipsAndErrors` | **.cctor** | `0x5071D14` |
| 708B | `TutorialTipsAndErrors` | **SetupErrorMessage** | `0x507193C` |
| 940B | `TutorialGame` | **.ctor** | `0x52F7DB4` |
| 388B | `TutorialGame` | **GetErrorMessage** | `0x52F7B6C` |
| 292B | `TutorialGame` | **GetBalootBiddingOption** | `0x52F79B0` |
| 276B | `TutorialGame` | **GetAiOptions** | `0x52F7884` |
| 188B | `TutorialGame` | **OnEndRound** | `0x52F7CF8` |
| 380B | `Array` | **InternalArray__IndexOf<TutorialError>** | `0x2B17EBC` |
| 368B | `Array` | **InternalArray__ICollection_Contains<TutorialError>** | `0x29EAF0C` |
| 348B | `Array` | **InternalArray__set_Item<TutorialError>** | `0x2BBEB4C` |
| 252B | `Array` | **InternalArray__IEnumerable_GetEnumerator<TutorialError>** | `0x2A668D4` |
| 188B | `Array` | **InternalArray__get_Item<TutorialError>** | `0x2B6BF5C` |
| … | `Array` | *(+1 أخرى)* | |
| 1368B | `TutorialUiControl` | **ShowEndTutorial** | `0x4F7B0E4` |
| 240B | `TutorialUiControl` | **Awake** | `0x4F7AFF4` |
| 720B | `TutorialGameAssetFetcher` | **MoveNext** | `0x52F8468` |
| 532B | `TutorialGameAssetFetcher` | **MoveNext** | `0x52F878C` |
| 284B | `TutorialGameAssetFetcher` | **.cctor** | `0x52F831C` |
| 604B | `BalootTutorialAiLogic` | **PlayCard** | `0x520AA78` |
| 532B | `BalootTutorialAiLogic` | **Bid** | `0x520ACD4` |
| 320B | `BalootTutorialAiLogic` | **GetAction** | `0x520AEE8` |
| 372B | `TutorialErrorPanel` | **ShowErrorMessage** | `0x50717C8` |
| 360B | `TutorialErrorPanel` | **Start** | `0x5071444` |
| 248B | `TutorialErrorPanel` | **OnDestroy** | `0x50715AC` |
| 180B | `TutorialErrorPanel` | **Hide** | `0x5071710` |
| 744B | `TutorialTipsPanel` | **SetUpAllText** | `0x5072A24` |
| 240B | `TutorialTipsPanel` | **Awake** | `0x50728E8` |
| 272B | `CheatingCatchPopup` | **HandleTutorialState** | `0x4F8BE38` |
| 224B | `CheatingCatchPopup` | **HighlightTutorialCards** | `0x4F8DF98` |
| 180B | `GameEventsChannel` | **remove_OnTutorialCardPreventedToPlay** | `0x50DB230` |
| 180B | `GameEventsChannel` | **add_OnTutorialCardPreventedToPlay** | `0x50DB17C` |
| 348B | `EmptyInternalEnumerator<TutorialError>` | **.cctor** | `0x477EC20` |
| 336B | `BalootPlayingButtons` | **HandleTutorialState** | `0x4FB8538` |
| 296B | `BaseCheatingBox` | **HighlightTutorialCheatingCards** | `0x4F8A924` |
| 240B | `InternalEnumerator<TutorialError>` | **get_Current** | `0x4C930B4` |
| 204B | `TutorialTopbar` | **SetTutorialTitle** | `0x4F7AF04` |
| 196B | `TrackerLibrary` | **OnboardingTutorialScreenViewed** | `0x5197998` |

---

## د — بنية تحتية مشتركة (279 دالة)

شبكة، صوت، أنيميشن عام، صناديق المقاعد. غير حاملة لقواعد لعب.

| الحجم | الصنف | الدالة | العنوان |
|---|---|---|---|
| 1960B | `KGame` | **OnExtensionResponse** | `0x5311314` |
| 1240B | `KGame` | **TrySeatPlayer** | `0x5311AFC` |
| 724B | `KGame` | **get_IsSpectator** | `0x530EDCC` |
| 720B | `KGame` | **UpdateGameState** | `0x531258C` |
| 672B | `KGame` | **<ExitGame>b__215_0** | `0x5314C4C` |
| 592B | `KGame` | **IsGameBalanced** | `0x53147CC` |
| … | `KGame` | *(+83 أخرى)* | |
| 2144B | `AnimationExtensions` | **AnimLoseHeart** | `0x4EBE710` |
| 720B | `AnimationExtensions` | **DONumber** | `0x4EBFE80` |
| 684B | `AnimationExtensions` | **AnimPulsing** | `0x4EBE1CC` |
| 620B | `AnimationExtensions` | **<DOStamp>b__0** | `0x4EC12CC` |
| 572B | `AnimationExtensions` | **DONumber** | `0x4EBFA0C` |
| 568B | `AnimationExtensions` | **DOStamp** | `0x4EC0314` |
| … | `AnimationExtensions` | *(+20 أخرى)* | |
| 1276B | `GameSoundManager` | **PlaySounds** | `0x4F71910` |
| 956B | `GameSoundManager` | **InitPooledAudioSources** | `0x4F70F54` |
| 660B | `GameSoundManager` | **Start** | `0x4F70C44` |
| 548B | `GameSoundManager` | **SetSoundActors** | `0x4F71310` |
| 504B | `GameSoundManager` | **PlaySounds** | `0x4F71718` |
| 384B | `GameSoundManager` | **PlayClipWithExtras** | `0x4F72534` |
| … | `GameSoundManager` | *(+14 أخرى)* | |
| 1140B | `CardGame` | **UpdateGameState** | `0x52FAB98` |
| 836B | `CardGame` | **OnGameCancelled** | `0x5300FDC` |
| 480B | `CardGame` | **SeatPlayer** | `0x5300DAC` |
| 464B | `CardGame` | **PlayCard** | `0x5301520` |
| 384B | `CardGame` | **AssignPlayedCards** | `0x5300A78` |
| 348B | `CardGame` | **TrackEndGame** | `0x52FB76C` |
| … | `CardGame` | *(+8 أخرى)* | |
| 656B | `CardGameVisualControls` | **ResetEatingCards** | `0x53071EC` |
| 476B | `CardGameVisualControls` | **OnGameStateUpdated** | `0x5304C64` |
| 432B | `CardGameVisualControls` | **CardCollisionAnim** | `0x5306A10` |
| 428B | `CardGameVisualControls` | **ShowControls** | `0x5305CF8` |
| 416B | `CardGameVisualControls` | **EatCards** | `0x5304978` |
| 388B | `CardGameVisualControls` | **HideControls** | `0x5305F0C` |
| … | `CardGameVisualControls` | *(+8 أخرى)* | |
| 1060B | `BalootGame` | **Init** | `0x52FA414` |
| 1036B | `BalootGame` | **PlayCard** | `0x52FB208` |
| 576B | `BalootGame` | **UpdateGameState** | `0x52FA958` |
| 284B | `BalootGame` | **ExtraGameModeFromString** | `0x52FB0EC` |
| 236B | `BalootGame` | **get_MyPlayer** | `0x52FA0CC` |
| 232B | `BalootGame` | **get_MyTeammate** | `0x52FA1B8` |
| … | `BalootGame` | *(+5 أخرى)* | |
| 1248B | `Hand` | **UpdatePriceTag** | `0x4F9A78C` |
| 396B | `Hand` | **RegisterEventListeners** | `0x4F98744` |
| 380B | `Hand` | **UnRegisterEventListeners** | `0x4F988D0` |
| 280B | `Hand` | **RefreshSpecialPlayPrice** | `0x4F979E8` |
| 208B | `Hand` | **PlayItsMyTurnVibration** | `0x4F99EB0` |
| 200B | `Hand` | **ShowHandCardsBacks** | `0x4F99A4C` |
| … | `Hand` | *(+5 أخرى)* | |
| 660B | `EnumExtensions` | **ToEnum<__Il2CppFullySharedGenericStructType>** | `0x2D714F0` |
| 520B | `EnumExtensions` | **ToggleFlag<__Il2CppFullySharedGenericStructType>** | `0x2D71784` |
| 520B | `EnumExtensions` | **ToEnum<Int32Enum>** | `0x2D712E8` |
| 520B | `EnumExtensions` | **RemoveFlag<__Il2CppFullySharedGenericStructType>** | `0x2D710E0` |
| 520B | `EnumExtensions` | **AddFlag<__Il2CppFullySharedGenericStructType>** | `0x2D70D14` |
| 360B | `EnumExtensions` | **GetFriendlyName** | `0x4EAAE20` |
| … | `EnumExtensions` | *(+2 أخرى)* | |
| 680B | `SlideAnimationHelper` | **SlideIn** | `0x4F4131C` |
| 496B | `SlideAnimationHelper` | **SlideOut** | `0x4F416F8` |
| 320B | `SlideAnimationHelper` | **ShowImmediate** | `0x4F41B2C` |
| 316B | `SlideAnimationHelper` | **HideImmediate** | `0x4F410F4` |
| 288B | `SlideAnimationHelper` | **GetSlideDownDistance** | `0x4F41A0C` |
| 284B | `SlideAnimationHelper` | **GetSlideUpDistance** | `0x4F418F0` |
| … | `SlideAnimationHelper` | *(+2 أخرى)* | |
| 1656B | `ClanFeedLoader` | **SyncClanGameCards** | `0x52B2D64` |
| 336B | `ClanFeedLoader` | **AddLiveGameCard** | `0x52B4A90` |
| 260B | `ClanFeedLoader` | **<SyncClanGameCards>b__1** | `0x52B54D8` |
| 176B | `ClanFeedLoader` | **<SyncClanGameCards>b__24_0** | `0x52B521C` |
| 1132B | `BalootGameSoundControls` | **OnGameEnd** | `0x52FC308` |
| 1036B | `BalootGameSoundControls` | **OnRoundEnd** | `0x52FBE2C` |
| 220B | `BalootGameSoundControls` | **get_balootGame** | `0x52FBCD4` |
| 376B | `BalootUserbox` | **OnRoundStart** | `0x4FB9444` |
| 368B | `BalootUserbox` | **<SetProjects>b__36_0** | `0x4FBB8D8` |
| 348B | `BalootUserbox` | **HideSawa** | `0x4FB9734` |
| 348B | `BalootUserbox` | **HideKasho** | `0x4FB95D8` |
| 216B | `BalootUserbox` | **ShowSawa** | `0x4FBB580` |
| 216B | `BalootUserbox` | **ShowKasho** | `0x4FBB658` |
| … | `BalootUserbox` | *(+1 أخرى)* | |
| 1640B | `ClanChatBox` | **SyncClanGameCards** | `0x52A2678` |
| 280B | `ClanChatBox` | **<SyncClanGameCards>b__1** | `0x52AA868` |
| 332B | `KPlayer` | **UpdateUser** | `0x5316970` |
| 220B | `KPlayer` | **get_NickName** | `0x53161EC` |
| 188B | `KPlayer` | **FireEvents** | `0x5316ABC` |
| 172B | `KPlayer` | **UserChanged** | `0x5316B94` |
| 168B | `KPlayer` | **get_IsRoomOwner** | `0x5316480` |
| 164B | `KPlayer` | **remove_OnUserChanged** | `0x5316740` |
| … | `KPlayer` | *(+4 أخرى)* | |
| 408B | `GameCard` | **CardPreparedForClick** | `0x4F91980` |
| 332B | `GameCard` | **CardPrepared** | `0x4F91834` |
| 272B | `GameCard` | **SetSpecialPlayPrice** | `0x4F91EB0` |
| 228B | `GameCard` | **CardInHand** | `0x4F91750` |
| 192B | `GameCard` | **SetSprite** | `0x4F91C54` |
| 172B | `GameCard` | **Start** | `0x4F91BA8` |
| … | `GameCard` | *(+1 أخرى)* | |
| 636B | `KGameVisualControls` | **Init** | `0x5315B8C` |
| 376B | `KGameVisualControls` | **GetNextPlayerUserbox** | `0x5315F38` |
| 292B | `KGameVisualControls` | **get_ActiveUserBoxes** | `0x53159D8` |
| 240B | `KGameVisualControls` | **get_hand** | `0x53157E8` |
| 176B | `KGameVisualControls` | **GetActiveUserbox** | `0x5309684` |
| 264B | `MiniGameCard` | **CardPreparedForDiscard** | `0x4F45490` |
| 236B | `MiniGameCard` | **OnStatusChange** | `0x4F452E0` |
| 208B | `MiniGameCard` | **Start** | `0x4F45598` |
| 196B | `MiniGameCard` | **OnPointerEnter** | `0x4F45728` |
| 196B | `MiniGameCard` | **CardInHand** | `0x4F453CC` |
| 192B | `MiniGameCard` | **OnPointerDown** | `0x4F45668` |
| … | `MiniGameCard` | *(+2 أخرى)* | |
| 504B | `CardAction` | **ToString** | `0x53084F8` |
| 296B | `CardAction` | **InitCardPlay** | `0x53054DC` |
| 284B | `CardAction` | **.ctor** | `0x53083DC` |
| 260B | `CardAction` | **InitEating** | `0x53056E8` |
| 244B | `CardAction` | **InitReorganizeHand** | `0x53058B4` |
| 360B | `SpecialSawaAnimation` | **ModifyAllSortLayer** | `0x5145B9C` |
| 320B | `SpecialSawaAnimation` | **<SetShadows>b__0** | `0x5146BC4` |
| 232B | `SpecialSawaAnimation` | **SetOnCompleteCallback** | `0x514654C` |
| 168B | `SpecialSawaAnimation` | **ModifySortLayer** | `0x5146668` |
| 164B | `SpecialSawaAnimation` | **GetUserBoxSideDirection** | `0x514647C` |
| 668B | `ScenesEnumExtensions` | **GetName** | `0x4EB228C` |
| 300B | `ScenesEnumExtensions` | **GetSceneEnum** | `0x4EB2528` |
| 152B | `ScenesEnumExtensions` | **IsEqual** | `0x4EAFE5C` |
| 940B | `GameReplayManager` | **OnCardGameEnd** | `0x5238BAC` |
| 800B | `Statistic` | **BalootMock** | `0x53037FC` |
| 380B | `CardDistributor` | **GetUserboxByRotatedIndex** | `0x51C08A0` |
| 216B | `CardDistributor` | **<GetUserboxByRotatedIndex>b__0** | `0x51C0CF8` |
| 588B | `KGameExtensions` | **GetClientContext** | `0x5315504` |
| 316B | `CardGameSoundControls` | **Init** | `0x5303614` |
| 208B | `CardGameSoundControls` | **get_MyTeamIndex** | `0x52FC238` |
| 436B | `CardGameRoundScore` | **Record** | `0x52FEE54` |
| 184B | `TrackerLibrary` | **GameKashoButtonClicked** | `0x519C9A0` |
| 184B | `TrackerLibrary` | **GameCardSlapClicked** | `0x519CEE0` |
| 368B | `BalootScores` | **SaveRoundScore** | `0x52FE384` |
| 356B | `HololensHand` | **FinishSetup** | `0x60334CC` |
| 348B | `CardsOrganizer` | **.cctor** | `0x31B2CC8` |
| 164B | `PlayerSwitchSeatDelegate` | **.ctor** | `0x5314EEC` |
| 152B | `PlayerSwitchSeatDelegate` | **BeginInvoke** | `0x5314FA4` |
| 244B | `BalootOfflinePlayer` | **.ctor** | `0x52008A4` |
| 228B | `BalootGameModeExtensions` | **ToClientString** | `0x52FBB60` |
| 204B | `CardGameLastActionInfo` | **.ctor** | `0x530D1D8` |
| 160B | `CardsOrganizer<object>` | **get_AllowMyTurnHandAnimation** | `0x4389010` |
