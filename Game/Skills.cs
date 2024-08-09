//By AlSch092 @ Github
﻿using System.Collections.Generic;

namespace Mir4ClientEmulator.Game
{

    //"Name","SkillId","NameSid","GroupNoteSid","NoteSid","EffectSid","SpecialLevel","SpecialNoteSid","SpecialToolTipTitle","SpecialToolTip","Icon","Icon_Gray","NameImgId","SkillType","ClassId","FixSkillSlot","Group","SkillProductType","UseControlTime","SkillUseCount","SkillUseTime","ConditionTarget","ConditionType","ConditionValue","ConditionRange","ConditionCheckTime","ChainUseSkillLv","ChainSkillID","ChainSkillDelay","ChainSkillCount","Cooltime","LevelUpCooltime","MaxCooltime","AddCooltime","GlobalCooltime","SkillCostType","SkillCost","AddSkillCost","SkillCostType_1","SkillCost_1","AttackLink","AttackAniTime","EndCutAniTime","HitCount","NextNormalSkilLink","NextNormalSkilProb","DarkChange","DamageType","MulDamage","LevelUpMulDamage","AddDamage","LevelUpAddDamage","MulDamage_1","LevelUpMulDamage_1","AddDamage_1","LevelUpAddDamage_1","AbilityType_1","AbilityValue_1","LevelUpValue_1","AbilityTime_1","AbilityType_2","AbilityValue_2","LevelUpValue_2","AbilityTime_2","AbilityType_3","AbilityValue_3","LevelUpValue_3","AbilityTime_3","AbilityType_4","AbilityValue_4","LevelUpValue_4","AbilityTime_4","ReqClassLevel","ReqBloodLevel","ReqForceLevel","ReqCheckQuest","MaxSkillLevel","LevelUpCostType","LevelUpDefaultCost","LevelUpCost","LevelUpCostType1","LevelUpDefaultCost1","LevelUpCost1","SkillItemId","OpenItemCost","LevelUpItemDefaultCost","LevelUpItemCost","ItemSmallIcon","CombatPoint","LevelUpCombatPoint","StateConUse","MoveConUse","IndicatorType","IndicatorIndex","IndicatorAngle","IndicatorMin","IndicatorMax","IndicatorWidth","IndicatorOffset","MainSkillID","Targeting","TargetHeight","BlockingCheck","SkillCostGroupID","SmiteBuffID","AutoLearnPassive","Skill_MODPassive","Passive","UIViewOrder"
    public class Skill
    {
        public int Name { get; set; }
        public int SkillId { get; set; }
        public int NameSid { get; set; }
        public int GroupNoteSid { get; set; }
        public int NoteSid { get; set; }
        public int EffectSid { get; set; }
        public string SpecialLevel { get; set; }
        public string SpecialNoteSid { get; set; }
        public string SpecialToolTipTitle { get; set; }
        public string SpecialToolTip { get; set; }
        public int Icon { get; set; }
        public int Icon_Gray { get; set; }
        public string NameImgId { get; set; }
        public int SkillType { get; set; }
        public int ClassId { get; set; }
        public int FixSkillSlot { get; set; }
        public int Group { get; set; }
        public int SkillProductType { get; set; }
        public double UseControlTime { get; set; }
        public int SkillUseCount { get; set; }
        public double SkillUseTime { get; set; }
        public int ConditionTarget { get; set; }
        public int ConditionType { get; set; }
        public int ConditionValue { get; set; }
        public int ConditionRange { get; set; }
        public double ConditionCheckTime { get; set; }
        public int ChainUseSkillLv { get; set; }
        public int ChainSkillID { get; set; }
        public int ChainSkillDelay { get; set; }
        public int ChainSkillCount { get; set; }
        public double Cooltime { get; set; }
        public double LevelUpCooltime { get; set; }
        public double MaxCooltime { get; set; }
        public string AddCooltime { get; set; }
        public double GlobalCooltime { get; set; }
        public int SkillCostType { get; set; }
        public int SkillCost { get; set; }
        public string AddSkillCost { get; set; }
        public int SkillCostType_1 { get; set; }
        public int SkillCost_1 { get; set; }
        public string AttackLink { get; set; }
        public double AttackAniTime { get; set; }
        public double EndCutAniTime { get; set; }
        public int HitCount { get; set; }
        public string NextNormalSkilLink { get; set; }
        public int NextNormalSkilProb { get; set; }
        public int DarkChange { get; set; }
        public int DamageType { get; set; }
        public int MulDamage { get; set; }
        public int LevelUpMulDamage { get; set; }
        public int AddDamage { get; set; }
        public int LevelUpAddDamage { get; set; }
        public int MulDamage_1 { get; set; }
        public int LevelUpMulDamage_1 { get; set; }
        public int AddDamage_1 { get; set; }
        public int LevelUpAddDamage_1 { get; set; }
        public int AbilityType_1 { get; set; }
        public int AbilityValue_1 { get; set; }
        public int LevelUpValue_1 { get; set; }
        public int AbilityTime_1 { get; set; }
        public int AbilityType_2 { get; set; }
        public int AbilityValue_2 { get; set; }
        public int LevelUpValue_2 { get; set; }
        public int AbilityTime_2 { get; set; }
        public int AbilityType_3 { get; set; }
        public int AbilityValue_3 { get; set; }
        public int LevelUpValue_3 { get; set; }
        public int AbilityTime_3 { get; set; }
        public int AbilityType_4 { get; set; }
        public int AbilityValue_4 { get; set; }
        public int LevelUpValue_4 { get; set; }
        public int AbilityTime_4 { get; set; }
        public int ReqClassLevel { get; set; }
        public int ReqBloodLevel { get; set; }
        public int ReqForceLevel { get; set; }
        public int ReqCheckQuest { get; set; }
        public int MaxSkillLevel { get; set; }
        public int LevelUpCostType { get; set; }
        public int LevelUpDefaultCost { get; set; }
        public int LevelUpCost { get; set; }
        public int LevelUpCostType1 { get; set; }
        public int LevelUpDefaultCost1 { get; set; }
        public int LevelUpCost1 { get; set; }
        public int SkillItemId { get; set; }
        public int OpenItemCost { get; set; }
        public int LevelUpItemDefaultCost { get; set; }
        public int LevelUpItemCost { get; set; }
        public int ItemSmallIcon { get; set; }
        public int CombatPoint { get; set; }
        public int LevelUpCombatPoint { get; set; }
        public int StateConUse { get; set; }
        public int MoveConUse { get; set; }
        public int IndicatorType { get; set; }
        public int IndicatorIndex { get; set; }
        public int IndicatorAngle { get; set; }
        public int IndicatorMin { get; set; }
        public int IndicatorMax { get; set; }
        public int IndicatorWidth { get; set; }
        public int IndicatorOffset { get; set; }
        public int MainSkillID { get; set; }
        public int Targeting { get; set; }
        public int TargetHeight { get; set; }
        public int BlockingCheck { get; set; }
        public int SkillCostGroupID { get; set; }
        public string SmiteBuffID { get; set; }
        public string AutoLearnPassive { get; set; }
        public string Skill_MODPassive { get; set; }
        public string Passive { get; set; }
        public int UIViewOrder { get; set; }

        public static void InitializeSkillsList(Dictionary<int, int> SkillList, e_class eClass)
        {
            if (SkillList == null)
                SkillList = new Dictionary<int, int>();

            if (eClass == e_class.Warrior) //normal attacks, minimum incase sending skills doesnt give response
            {
                if (!SkillList.ContainsKey(10010))
                    SkillList.Add(10010, 1);
            }
            else if (eClass == e_class.Sorcerer)
            {
                if (!SkillList.ContainsKey(20010))
                    SkillList.Add(20010, 1);
            }
            else if (eClass == e_class.Taoist)
            {
                if (!SkillList.ContainsKey(30010))
                    SkillList.Add(30010, 1);
            }
            else if (eClass == e_class.Arbalist)
            {
                if (!SkillList.ContainsKey(40010))
                    SkillList.Add(40010, 1);
            }
            else if (eClass == e_class.Lancer)
            {
                if (!SkillList.ContainsKey(50010))
                    SkillList.Add(50010, 1);
            }
            else if (eClass == e_class.Darkest)
            {
                if (!SkillList.ContainsKey(60010))
                    SkillList.Add(60010, 1);
            }
        }
    }


    //"Name","AttackId","AniIndex","AniTime","MontageType","Section","SkillId","AniType","MainAttack","NextAttackLink","ImpactStartTime","AttackType","MoveType","MoveRange","DelayMove","MoveTime",
    //"MoveAngleMin","MoveAngleMax","ViewTarget","AttackUseType","TargetDistanceMin","TargetDistanceMax","MonScaleApply","TargetType","TargetSubType","TargetValue","ImpactType","ImpactSpawnType",
    //"ImpactTime","StrikeDelay","AttackAngle","AttackDistanceMin","AttackDistanceMax","AttackWidth","AttackHeight","LocationOffset","RotationOffset","SocketName","BulletType","BulletMoveType","BulletCount",
    //"BulletSpeed","BulletTime","BulletSocketName","PierceType","PenetrateCount","LaunchGapDelay","BulletEffect","BulletEffectScale","BulletRotationOffset","BulletAngleSpeed","CurveData","SpeedData","AfterType",
    //"AfterValue","DamageAttribute","DamageType","MulDamage","LevelUpMulDamage","AddDamage","LevelUpAddDamage","MagicDamage","LevelUpMagicDamage","AddMagicDamage","LevelUpAddMagicDamage","AggroRate","SkillTotem",
    //"SkillTotemTarget","SkillTotemTime","SkillTotemCount","ActType","ActDistance","SuperIgnore","SuperArmor","CCStance","CCSection","CrowdControlType","CCDirection","CrowdControlValue","CrowdControlHeight",
    //"CrowdControlValueEx","CrowdControlTime","CCBuff","CCUserCheck","CCEffect","CCEffectSocket","CCEffectHeight","CCEffectScale","CCMaterialPath","HitReactionProb","GuideEffectApplyType","GuideEffect","GuideEffectScale",
    //"GuideEffectAliveTime","GuideEffectScalingTime","ActEffect","ActEffectScale","HitEffect","CriticalHitEffect","HitEffectScale","HitEffectSound","Emissive_Dcolor","Fresnel_Exponenth","Fresnel_BaseReflect","EmissiveTime",
    //"CameraShake","DieReaction","Buff","AttackRagePoint","HitRagePoint","BulletCurveTime","BulletHeight","Passive","GetMasteryPoint"
    //
    //
    public class SkillAttack
    {
        public int Name { get; set; }
        public int AttackId { get; set; }
        public int AniIndex { get; set; }
        public double AniTime { get; set; }
        public int MontageType { get; set; }
        public string Section { get; set; }
        public int SkillId { get; set; }
        public int AniType { get; set; }
        public int MainAttack { get; set; }
        public int NextAttackLink { get; set; }
        public double ImpactStartTime { get; set; }
        public int AttackType { get; set; }
        public int MoveType { get; set; }
        public int MoveRange { get; set; }
        public float DelayMove { get; set; }
        public double MoveTime { get; set; }
        public double MoveAngleMin { get; set; }
        public double MoveAngleMax { get; set; }
        public int ViewTarget { get; set; }
        public int AttackUseType { get; set; }
        public double TargetDistanceMin { get; set; }
        public double TargetDistanceMax { get; set; }
        public int MonScaleApply { get; set; }
        public int TargetType { get; set; }
        public int TargetSubType { get; set; }
        public int TargetValue { get; set; }
        public int ImpactType { get; set; }
        public int ImpactSpawnType { get; set; }
        public string ImpactTime { get; set; }
        public float StrikeDelay { get; set; }
        public int AttackAngle { get; set; }
        public int AttackDistanceMin { get; set; }
        public int AttackDistanceMax { get; set; }
        public int AttackWidth { get; set; }
        public int AttackHeight { get; set; }
        public string LocationOffset { get; set; }
        public double RotationOffset { get; set; }
        public string SocketName { get; set; }
        public int BulletType { get; set; }
        public int BulletMoveType { get; set; }
        public int BulletCount { get; set; }
        public int BulletSpeed { get; set; }
        public double BulletTime { get; set; }
        public string BulletSocketName { get; set; }
        public int PierceType { get; set; }
        public int PenetrateCount { get; set; }
        public int LaunchGapDelay { get; set; }
        public int BulletEffect { get; set; }
        public int BulletEffectScale { get; set; }
        public string BulletRotationOffset { get; set; }
        public int BulletAngleSpeed { get; set; }
        public string CurveData { get; set; }
        public int SpeedData { get; set; }
        public int AfterType { get; set; }
        public int AfterValue { get; set; }
        public int DamageAttribute { get; set; }
        public int DamageType { get; set; }
        public int MulDamage { get; set; }
        public int LevelUpMulDamage { get; set; }
        public int AddDamage { get; set; }
        public int LevelUpAddDamage { get; set; }
        public int MagicDamage { get; set; }
        public int LevelUpMagicDamage { get; set; }
        public int AddMagicDamage { get; set; }
        public int LevelUpAddMagicDamage { get; set; }
        public int AggroRate { get; set; }
        public int SkillTotem { get; set; }
        public int SkillTotemTarget { get; set; }
        public double SkillTotemTime { get; set; }
        public int SkillTotemCount { get; set; }
        public int ActType { get; set; }
        public int ActDistance { get; set; }
        public int SuperIgnore { get; set; }
        public int SuperArmor { get; set; }
        public int CCStance { get; set; }
        public string CCSection { get; set; }
        public int CrowdControlType { get; set; }
        public int CCDirection { get; set; }
        public int CrowdControlValue { get; set; }
        public int CrowdControlHeight { get; set; }
        public float CrowdControlValueEx { get; set; }
        public double CrowdControlTime { get; set; }
        public string CCBuff { get; set; }
        public int CCUserCheck { get; set; }
        public int CCEffect { get; set; }
        public string CCEffectSocket { get; set; }
        public int CCEffectHeight { get; set; }
        public int CCEffectScale { get; set; }
        public string CCMaterialPath { get; set; }
        public int HitReactionProb { get; set; }
        public int GuideEffectApplyType { get; set; }
        public int GuideEffect { get; set; }
        public double GuideEffectScale { get; set; }
        public double GuideEffectAliveTime { get; set; }
        public double GuideEffectScalingTime { get; set; }
        public int ActEffect { get; set; }
        public int ActEffectScale { get; set; }
        public int HitEffect { get; set; }
        public int CriticalHitEffect { get; set; }
        public int HitEffectScale { get; set; }
        public int HitEffectSound { get; set; }
        public string Emissive_Dcolor { get; set; }
        public int Fresnel_Exponenth { get; set; }
        public double Fresnel_BaseReflect { get; set; }
        public double EmissiveTime { get; set; }
        public int CameraShake { get; set; }
        public int DieReaction { get; set; }
        public string Buff { get; set; }
        public int AttackRagePoint { get; set; }
        public int HitRagePoint { get; set; }
        public double BulletCurveTime { get; set; }
        public int BulletHeight { get; set; }
        public string Passive { get; set; }
        public string GetMasteryPoint { get; set; }
    }

    //public class Skills
    //{
    //public void AddArbalistSkills()
    //{
    //    Skill s = new Skill();
    //    s.Id = 40010;
    //    s.AttackId = 4001001;
    //    s.Name = "Attack_1";
    //    s.Stages = 1; //not sure
    //    s.IsOnCooldown = false;

    //    Skill _s = new Skill();
    //    s.Id = 40020;
    //    s.AttackId = 4002001;
    //    s.Name = "Attack_2";
    //    s.Stages = 1; //not sure
    //    s.IsOnCooldown = false;

    //    Skill s2 = new Skill();
    //    s2.Id = 4111;
    //    s2.AttackId = 411101;
    //    s2.Name = "Attack_4_111_01";
    //    s2.IsOnCooldown = false;

    //    Skill ArrowRain = new Skill(); //ultimate skill!
    //    ArrowRain.Id = 0;
    //    ArrowRain.AttackId = 0; 
    //    ArrowRain.Stages = 6;
    //    ArrowRain.ManaConsumed = 710;
    //    ArrowRain.Cooldown = 10.0f;
    //    ArrowRain.Name = "Arrow Rain";
    //    ArrowRain.IsOnCooldown = false;

    //    Skill Quickshot = new Skill();
    //    Quickshot.Id = 4101;
    //    Quickshot.AttackId = 410101; //increases by 1 each stage, this skill can be sent 6x in 1 second (or all stages / 1 second)
    //    Quickshot.Stages = 6;
    //    Quickshot.ManaConsumed = 162;
    //    Quickshot.Cooldown = 12.0f;
    //    Quickshot.Name = "Quick Shot";
    //    Quickshot.IsOnCooldown = false;

    //    Skill PainstrikeGale = new Skill();
    //    PainstrikeGale.Id = 4106;
    //    PainstrikeGale.AttackId = 410601;
    //    PainstrikeGale.Stages = 2;
    //    PainstrikeGale.ManaConsumed = 263;
    //    PainstrikeGale.Cooldown = 20.0f;
    //    PainstrikeGale.Name = "Painstrike Gale";
    //    PainstrikeGale.IsOnCooldown = false;

    //    Skill IllusionArrow = new Skill();
    //    IllusionArrow.Id = 4102;
    //    IllusionArrow.AttackId = 410201;
    //    IllusionArrow.Stages = 4;
    //    IllusionArrow.ManaConsumed = 253;
    //    IllusionArrow.Cooldown = 22.0f;
    //    IllusionArrow.Name = "Illusion Arrow";
    //    IllusionArrow.IsOnCooldown = false;

    //    Skill BurstShell = new Skill();
    //    BurstShell.Id = 4103;
    //    BurstShell.AttackId = 410301;
    //    BurstShell.Stages = 3;
    //    BurstShell.ManaConsumed = 213;
    //    BurstShell.Cooldown = 26.0f;
    //    BurstShell.Name = "Burst Shell";
    //    BurstShell.IsOnCooldown = false;

    //    ArbalistSkills.Add(s);
    //    ArbalistSkills.Add(_s);
    //    ArbalistSkills.Add(s2); //basic attacks
    //    ArbalistSkills.Add(Quickshot);
    //    //ArbalistSkills.Add(ArrowRain);
    //    ArbalistSkills.Add(PainstrikeGale);
    //    ArbalistSkills.Add(IllusionArrow);
    //    ArbalistSkills.Add(BurstShell);
    //}
    //}
}
