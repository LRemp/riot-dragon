﻿namespace backend.Models
{
    public class Player: SummonerData
    {
        public int TeamId { get; set; }
        public string? Role { get; set; }
        public string? ChampionName { get; set; }
        public int ChampionLevel { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
        public int GoldEarned { get; set; }
        public int TotalMinionsKilled { get; set; }
        public Item? Item1 { get; set; }
        public Item? Item2 { get; set; }
        public Item? Item3 { get; set; }
        public Item? Item4 { get; set; }
        public Item? Item5 { get; set; }
        public Item? Item6 { get; set; }
    }
    /*
     {
                        "allInPings": 1,
                        "assistMePings": 0,
                        "assists": 24,
                        "baitPings": 0,
                        "baronKills": 0,
                        "basicPings": 0,
                        "bountyLevel": 6,
                        "challenges": {
                            "12AssistStreakCount": 0,
                            "abilityUses": 134,
                            "acesBefore15Minutes": 0,
                            "alliedJungleMonsterKills": 0,
                            "baronTakedowns": 0,
                            "blastConeOppositeOpponentCount": 0,
                            "bountyGold": 750,
                            "buffsStolen": 0,
                            "completeSupportQuestInTime": 0,
                            "controlWardsPlaced": 0,
                            "damagePerMinute": 931.6689771209712,
                            "damageTakenOnTeamPercentage": 0.1531541442172356,
                            "dancedWithRiftHerald": 0,
                            "deathsByEnemyChamps": 6,
                            "dodgeSkillShotsSmallWindow": 8,
                            "doubleAces": 0,
                            "dragonTakedowns": 0,
                            "earlyLaningPhaseGoldExpAdvantage": 0,
                            "effectiveHealAndShielding": 0,
                            "elderDragonKillsWithOpposingSoul": 0,
                            "elderDragonMultikills": 0,
                            "enemyChampionImmobilizations": 0,
                            "enemyJungleMonsterKills": 0,
                            "epicMonsterKillsNearEnemyJungler": 0,
                            "epicMonsterKillsWithin30SecondsOfSpawn": 0,
                            "epicMonsterSteals": 0,
                            "epicMonsterStolenWithoutSmite": 0,
                            "firstTurretKilledTime": 268.13513929622945,
                            "flawlessAces": 0,
                            "fullTeamTakedown": 7,
                            "gameLength": 1460.5146724347994,
                            "getTakedownsInAllLanesEarlyJungleAsLaner": 0,
                            "goldPerMinute": 757.2976545957132,
                            "hadOpenNexus": 0,
                            "immobilizeAndKillWithAlly": 0,
                            "initialBuffCount": 0,
                            "initialCrabCount": 0,
                            "jungleCsBefore10Minutes": 0,
                            "junglerTakedownsNearDamagedEpicMonster": 0,
                            "kTurretsDestroyedBeforePlatesFall": 1,
                            "kda": 5.428571428571429,
                            "killAfterHiddenWithAlly": 3,
                            "killParticipation": 0.6031746031746031,
                            "killedChampTookFullTeamDamageSurvived": 0,
                            "killingSprees": 3,
                            "killsNearEnemyTurret": 0,
                            "killsOnOtherLanesEarlyJungleAsLaner": 0,
                            "killsOnRecentlyHealedByAramPack": 0,
                            "killsUnderOwnTurret": 7,
                            "killsWithHelpFromEpicMonster": 0,
                            "knockEnemyIntoTeamAndKill": 0,
                            "landSkillShotsEarlyGame": 22,
                            "laneMinionsFirst10Minutes": 28,
                            "laningPhaseGoldExpAdvantage": 0,
                            "legendaryCount": 0,
                            "lostAnInhibitor": 0,
                            "maxCsAdvantageOnLaneOpponent": 79,
                            "maxKillDeficit": 11,
                            "maxLevelLeadLaneOpponent": 2,
                            "moreEnemyJungleThanOpponent": 0,
                            "multiKillOneSpell": 0,
                            "multiTurretRiftHeraldCount": 0,
                            "multikills": 1,
                            "multikillsAfterAggressiveFlash": 0,
                            "mythicItemUsed": 6673,
                            "outerTurretExecutesBefore10Minutes": 1,
                            "outnumberedKills": 1,
                            "outnumberedNexusKill": 0,
                            "perfectDragonSoulsTaken": 0,
                            "perfectGame": 0,
                            "pickKillWithAlly": 32,
                            "poroExplosions": 0,
                            "quickCleanse": 0,
                            "quickFirstTurret": 0,
                            "quickSoloKills": 0,
                            "riftHeraldTakedowns": 0,
                            "saveAllyFromDeath": 0,
                            "scuttleCrabKills": 0,
                            "shortestTimeToAceFromFirstTakedown": 22.364609615117843,
                            "skillshotsDodged": 44,
                            "skillshotsHit": 86,
                            "snowballsHit": 1,
                            "soloBaronKills": 0,
                            "soloKills": 1,
                            "stealthWardsPlaced": 0,
                            "survivedSingleDigitHpCount": 0,
                            "survivedThreeImmobilizesInFight": 0,
                            "takedownOnFirstTurret": 0,
                            "takedowns": 38,
                            "takedownsAfterGainingLevelAdvantage": 0,
                            "takedownsBeforeJungleMinionSpawn": 2,
                            "takedownsFirstXMinutes": 16,
                            "takedownsInAlcove": 0,
                            "takedownsInEnemyFountain": 0,
                            "teamBaronKills": 0,
                            "teamDamagePercentage": 0.13794078282189748,
                            "teamElderDragonKills": 0,
                            "teamRiftHeraldKills": 0,
                            "threeWardsOneSweeperCount": 0,
                            "tookLargeDamageSurvived": 0,
                            "turretPlatesTaken": 0,
                            "turretTakedowns": 4,
                            "turretsTakenWithRiftHerald": 0,
                            "twentyMinionsIn3SecondsCount": 4,
                            "unseenRecalls": 0,
                            "visionScoreAdvantageLaneOpponent": -1,
                            "visionScorePerMinute": 0,
                            "wardTakedowns": 1,
                            "wardTakedownsBefore20M": 1,
                            "wardsGuarded": 0
                        },
                        "champExperience": 30582,
                        "champLevel": 18,
                        "championId": 15,
                        "championName": "Sivir",
                        "championTransform": 0,
                        "commandPings": 6,
                        "consumablesPurchased": 2,
                        "damageDealtToBuildings": 2283,
                        "damageDealtToObjectives": 2283,
                        "damageDealtToTurrets": 2283,
                        "damageSelfMitigated": 11406,
                        "dangerPings": 0,
                        "deaths": 7,
                        "detectorWardsPlaced": 0,
                        "doubleKills": 1,
                        "dragonKills": 0,
                        "eligibleForProgression": true,
                        "enemyMissingPings": 1,
                        "enemyVisionPings": 0,
                        "firstBloodAssist": true,
                        "firstBloodKill": false,
                        "firstTowerAssist": true,
                        "firstTowerKill": false,
                        "gameEndedInEarlySurrender": false,
                        "gameEndedInSurrender": false,
                        "getBackPings": 0,
                        "goldEarned": 18434,
                        "goldSpent": 14400,
                        "holdPings": 0,
                        "individualPosition": "Invalid",
                        "inhibitorKills": 1,
                        "inhibitorTakedowns": 1,
                        "inhibitorsLost": 0,
                        "item0": 6673,
                        "item1": 3094,
                        "item2": 3006,
                        "item3": 3072,
                        "item4": 6676,
                        "item5": 1053,
                        "item6": 2052,
                        "itemsPurchased": 16,
                        "killingSprees": 3,
                        "kills": 14,
                        "lane": "TOP",
                        "largestCriticalStrike": 619,
                        "largestKillingSpree": 6,
                        "largestMultiKill": 2,
                        "longestTimeSpentLiving": 394,
                        "magicDamageDealt": 3704,
                        "magicDamageDealtToChampions": 1052,
                        "magicDamageTaken": 23186,
                        "needVisionPings": 0,
                        "neutralMinionsKilled": 0,
                        "nexusKills": 1,
                        "nexusLost": 0,
                        "nexusTakedowns": 1,
                        "objectivesStolen": 0,
                        "objectivesStolenAssists": 0,
                        "onMyWayPings": 0,
                        "participantId": 1,
                        "pentaKills": 0,
                        "perks": {
                            "statPerks": {
                                "defense": 5002,
                                "flex": 5008,
                                "offense": 5005
                            },
                            "styles": [
                                {
                                    "description": "primaryStyle",
                                    "selections": [
                                        {
                                            "perk": 8021,
                                            "var1": 3033,
                                            "var2": 2306,
                                            "var3": 0
                                        },
                                        {
                                            "perk": 9111,
                                            "var1": 931,
                                            "var2": 380,
                                            "var3": 0
                                        },
                                        {
                                            "perk": 9103,
                                            "var1": 11,
                                            "var2": 50,
                                            "var3": 0
                                        },
                                        {
                                            "perk": 8299,
                                            "var1": 560,
                                            "var2": 0,
                                            "var3": 0
                                        }
                                    ],
                                    "style": 8000
                                },
                                {
                                    "description": "subStyle",
                                    "selections": [
                                        {
                                            "perk": 8139,
                                            "var1": 1324,
                                            "var2": 0,
                                            "var3": 0
                                        },
                                        {
                                            "perk": 8138,
                                            "var1": 18,
                                            "var2": 0,
                                            "var3": 0
                                        }
                                    ],
                                    "style": 8100
                                }
                            ]
                        },
                        "physicalDamageDealt": 101282,
                        "physicalDamageDealtToChampions": 21302,
                        "physicalDamageTaken": 3871,
                        "profileIcon": 4655,
                        "pushPings": 0,
                        "puuid": "it3bT5aeDu2uyQdYUYxVG8l9ZSf6l_AWJx3f1LCmhxFXmUxlyxYROeFol8mSyZ81PkiLXiQfGAuLrw",
                        "quadraKills": 0,
                        "riotIdName": "",
                        "riotIdTagline": "",
                        "role": "SUPPORT",
                        "sightWardsBoughtInGame": 0,
                        "spell1Casts": 78,
                        "spell2Casts": 39,
                        "spell3Casts": 10,
                        "spell4Casts": 7,
                        "summoner1Casts": 5,
                        "summoner1Id": 4,
                        "summoner2Casts": 3,
                        "summoner2Id": 32,
                        "summonerId": "DB0jGUOWSqOM7vVygPtVv05qZ6Ke6dnbnu_PMSo52b12SgM7",
                        "summonerLevel": 108,
                        "summonerName": "CoA Kenji",
                        "teamEarlySurrendered": false,
                        "teamId": 100,
                        "teamPosition": "",
                        "timeCCingOthers": 0,
                        "timePlayed": 1460,
                        "totalDamageDealt": 105365,
                        "totalDamageDealtToChampions": 22678,
                        "totalDamageShieldedOnTeammates": 0,
                        "totalDamageTaken": 27267,
                        "totalHeal": 6762,
                        "totalHealsOnTeammates": 0,
                        "totalMinionsKilled": 100,
                        "totalTimeCCDealt": 0,
                        "totalTimeSpentDead": 194,
                        "totalUnitsHealed": 1,
                        "tripleKills": 0,
                        "trueDamageDealt": 378,
                        "trueDamageDealtToChampions": 323,
                        "trueDamageTaken": 210,
                        "turretKills": 2,
                        "turretTakedowns": 4,
                        "turretsLost": 1,
                        "unrealKills": 0,
                        "visionClearedPings": 0,
                        "visionScore": 0,
                        "visionWardsBoughtInGame": 0,
                        "wardsKilled": 0,
                        "wardsPlaced": 0,
                        "win": true
                    },
     */
}
