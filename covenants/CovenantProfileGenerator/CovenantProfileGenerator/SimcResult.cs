// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
using Newtonsoft.Json;
using System.Collections.Generic;

public class Rng
{
    public string name { get; set; }
}

public class ShadowlandsBETA
{
    public int build_level { get; set; }
    public string wow_version { get; set; }
    public string hotfix_date { get; set; }
    public int hotfix_build { get; set; }
    public string hotfix_hash { get; set; }
}

public class Dbc
{
    [JsonProperty("shadowlands-BETA")]
    public ShadowlandsBETA ShadowlandsBETA { get; set; }
    public string version_used { get; set; }
}

public class Options
{
    public bool debug { get; set; }
    public double max_time { get; set; }
    public double expected_iteration_time { get; set; }
    public double vary_combat_length { get; set; }
    public int iterations { get; set; }
    public double target_error { get; set; }
    public int threads { get; set; }
    public string seed { get; set; }
    public bool single_actor_batch { get; set; }
    public double queue_lag { get; set; }
    public double queue_lag_stddev { get; set; }
    public double gcd_lag { get; set; }
    public double gcd_lag_stddev { get; set; }
    public double channel_lag { get; set; }
    public double channel_lag_stddev { get; set; }
    public double queue_gcd_reduction { get; set; }
    public int strict_gcd_queue { get; set; }
    public double confidence { get; set; }
    public double confidence_estimator { get; set; }
    public double world_lag { get; set; }
    public double world_lag_stddev { get; set; }
    public double travel_variance { get; set; }
    public double default_skill { get; set; }
    public double reaction_time { get; set; }
    public double regen_periodicity { get; set; }
    public double ignite_sampling_delta { get; set; }
    public bool fixed_time { get; set; }
    public bool optimize_expressions { get; set; }
    public int optimal_raid { get; set; }
    public int log { get; set; }
    public int debug_each { get; set; }
    public int stat_cache { get; set; }
    public int max_aoe_enemies { get; set; }
    public bool show_etmi { get; set; }
    public double tmi_window_global { get; set; }
    public double tmi_bin_size { get; set; }
    public double enemy_death_pct { get; set; }
    public bool challenge_mode { get; set; }
    public int timewalk { get; set; }
    public bool pvp_crit { get; set; }
    public Rng rng { get; set; }
    public int deterministic { get; set; }
    public int average_range { get; set; }
    public int average_gauss { get; set; }
    public string fight_style { get; set; }
    public double default_aura_delay { get; set; }
    public double default_aura_delay_stddev { get; set; }
    public Dbc dbc { get; set; }
}

public class Overrides
{
    public int arcane_intellect { get; set; }
    public int battle_shout { get; set; }
    public int power_word_fortitude { get; set; }
    public int chaos_brand { get; set; }
    public int mystic_touch { get; set; }
    public int mortal_wounds { get; set; }
    public int bleeding { get; set; }
    public int bloodlust { get; set; }
    public int bloodlust_percent { get; set; }
    public double bloodlust_time { get; set; }
}

public class Talent
{
    public int tier { get; set; }
    public int id { get; set; }
    public int spell_id { get; set; }
    public string name { get; set; }
}

public class ShadowlandsBETA2
{
    public int build_level { get; set; }
    public string wow_version { get; set; }
    public string hotfix_date { get; set; }
    public int hotfix_build { get; set; }
    public string hotfix_hash { get; set; }
}

public class Dbc2
{
    [JsonProperty("shadowlands-BETA")]
    public ShadowlandsBETA2 ShadowlandsBETA { get; set; }
    public string version_used { get; set; }
}

public class FightLength
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class ExecutedForegroundActions
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class Dmg
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class CompoundDmg
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class TimelineDmg
{
    public double mean { get; set; }
    public double mean_std_dev { get; set; }
    public double min { get; set; }
    public double max { get; set; }
    public List<double> data { get; set; }
}

public class Dps
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
    public double median { get; set; }
    public double variance { get; set; }
    public double std_dev { get; set; }
    public double mean_variance { get; set; }
    public double mean_std_dev { get; set; }
}

public class Dpse
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class TargetMetric
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
    public double median { get; set; }
    public double variance { get; set; }
    public double std_dev { get; set; }
    public double mean_variance { get; set; }
    public double mean_std_dev { get; set; }
}

public class Attribute
{
    public double strength { get; set; }
    public double agility { get; set; }
    public double stamina { get; set; }
    public double intellect { get; set; }
}

public class Resources
{
    public double mana { get; set; }
}

public class Stats
{
    public double spell_power { get; set; }
    public double spell_crit { get; set; }
    public double attack_crit { get; set; }
    public double spell_haste { get; set; }
    public double attack_haste { get; set; }
    public double spell_speed { get; set; }
    public double attack_speed { get; set; }
    public double mastery_value { get; set; }
    public double damage_versatility { get; set; }
    public double heal_versatility { get; set; }
    public double mitigation_versatility { get; set; }
    public double crit_rating { get; set; }
    public double crit_pct { get; set; }
    public double haste_rating { get; set; }
    public double haste_pct { get; set; }
    public double mastery_rating { get; set; }
    public double mastery_pct { get; set; }
    public double versatility_rating { get; set; }
    public double versatility_pct { get; set; }
    public double speed_pct { get; set; }
    public double manareg_per_second { get; set; }
    public double dodge { get; set; }
}

public class BuffedStats
{
    public Attribute attribute { get; set; }
    public Resources resources { get; set; }
    public Stats stats { get; set; }
}

public class Mana
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class ResourceLost
{
    public Mana mana { get; set; }
}

public class Mana2
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class CombatEndResource
{
    public Mana2 mana { get; set; }
}

public class Mana3
{
    public double mean { get; set; }
    public double mean_std_dev { get; set; }
    public double min { get; set; }
    public double max { get; set; }
    public List<double> data { get; set; }
}

public class ResourceTimelines
{
    public Mana3 mana { get; set; }
}

public class Resources2
{
    public double mana { get; set; }
}

public class ResourcesMax
{
    public double mana { get; set; }
}

public class ActionSequencePrecombat
{
    public double time { get; set; }
    public int id { get; set; }
    public string name { get; set; }
    public string target { get; set; }
    public string spell_name { get; set; }
    public Resources2 resources { get; set; }
    public ResourcesMax resources_max { get; set; }
}

public class Resources3
{
    public double mana { get; set; }
}

public class ResourcesMax2
{
    public double mana { get; set; }
}

public class Buff
{
    public int id { get; set; }
    public string name { get; set; }
    public int stacks { get; set; }
}

public class ActionSequence
{
    public double time { get; set; }
    public int id { get; set; }
    public string name { get; set; }
    public string target { get; set; }
    public string spell_name { get; set; }
    public Resources3 resources { get; set; }
    public ResourcesMax2 resources_max { get; set; }
    public List<Buff> buffs { get; set; }
}

public class CollectedData
{
    public FightLength fight_length { get; set; }
    public ExecutedForegroundActions executed_foreground_actions { get; set; }
    public Dmg dmg { get; set; }
    public CompoundDmg compound_dmg { get; set; }
    public TimelineDmg timeline_dmg { get; set; }
    public Dps dps { get; set; }
    public Dpse dpse { get; set; }
    public TargetMetric target_metric { get; set; }
    public BuffedStats buffed_stats { get; set; }
    public ResourceLost resource_lost { get; set; }
    public CombatEndResource combat_end_resource { get; set; }
    public ResourceTimelines resource_timelines { get; set; }
    public List<ActionSequencePrecombat> action_sequence_precombat { get; set; }
    public List<ActionSequence> action_sequence { get; set; }
}

public class Cooldown
{
    public string name { get; set; }
    public double duration { get; set; }
}

public class Buff2
{
    public string name { get; set; }
    public string spell_name { get; set; }
    public string spell_school { get; set; }
    public int spell { get; set; }
    public double start_count { get; set; }
    public double refresh_count { get; set; }
    public double interval { get; set; }
    public double trigger { get; set; }
    public double duration { get; set; }
    public double uptime { get; set; }
    public double overflow_stacks { get; set; }
    public double overflow_total { get; set; }
    public double? expire_count { get; set; }
    public double? default_value { get; set; }
    public Cooldown cooldown { get; set; }
    public double? benefit { get; set; }
}

public class Cooldown2
{
    public string name { get; set; }
    public double duration { get; set; }
}

public class BuffsConstant
{
    public string name { get; set; }
    public string spell_name { get; set; }
    public string spell_school { get; set; }
    public int spell { get; set; }
    public double start_count { get; set; }
    public double duration { get; set; }
    public double uptime { get; set; }
    public double benefit { get; set; }
    public double default_value { get; set; }
    public Cooldown2 cooldown { get; set; }
}

public class Mana4
{
    public double actual { get; set; }
    public double overflow { get; set; }
    public double count { get; set; }
}

public class Gain
{
    public string name { get; set; }
    public Mana4 mana { get; set; }
}

public class NumExecutes
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class TotalExecuteTime
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class PortionAps
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class PortionApse
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class ActualAmount
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class TotalAmount
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class TotalIntervals
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class NumDirectResults
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class ActualAmount2
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class AvgActualAmount
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class TotalAmount2
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class FightActualAmount
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class FightTotalAmount
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class OverkillPct
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class Count
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class Crit
{
    public ActualAmount2 actual_amount { get; set; }
    public AvgActualAmount avg_actual_amount { get; set; }
    public TotalAmount2 total_amount { get; set; }
    public FightActualAmount fight_actual_amount { get; set; }
    public FightTotalAmount fight_total_amount { get; set; }
    public OverkillPct overkill_pct { get; set; }
    public Count count { get; set; }
    public double pct { get; set; }
}

public class ActualAmount3
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class AvgActualAmount2
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class TotalAmount3
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class FightActualAmount2
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class FightTotalAmount2
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class OverkillPct2
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class Count2
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class Hit
{
    public ActualAmount3 actual_amount { get; set; }
    public AvgActualAmount2 avg_actual_amount { get; set; }
    public TotalAmount3 total_amount { get; set; }
    public FightActualAmount2 fight_actual_amount { get; set; }
    public FightTotalAmount2 fight_total_amount { get; set; }
    public OverkillPct2 overkill_pct { get; set; }
    public Count2 count { get; set; }
    public double pct { get; set; }
}

public class DirectResults
{
    public Crit crit { get; set; }
    public Hit hit { get; set; }
}

public class Mana5
{
    public double actual { get; set; }
    public double overflow { get; set; }
    public double count { get; set; }
}

public class ResourceGain
{
    public string name { get; set; }
    public Mana5 mana { get; set; }
}

public class NumTicks
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class NumTickResults
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class TotalTickTime
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class ActualAmount4
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class AvgActualAmount3
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class TotalAmount4
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class FightActualAmount3
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class FightTotalAmount3
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class OverkillPct3
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class Count3
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class Crit2
{
    public ActualAmount4 actual_amount { get; set; }
    public AvgActualAmount3 avg_actual_amount { get; set; }
    public TotalAmount4 total_amount { get; set; }
    public FightActualAmount3 fight_actual_amount { get; set; }
    public FightTotalAmount3 fight_total_amount { get; set; }
    public OverkillPct3 overkill_pct { get; set; }
    public Count3 count { get; set; }
    public double pct { get; set; }
}

public class ActualAmount5
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class AvgActualAmount4
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class TotalAmount5
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class FightActualAmount4
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class FightTotalAmount4
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class OverkillPct4
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class Count4
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class Hit2
{
    public ActualAmount5 actual_amount { get; set; }
    public AvgActualAmount4 avg_actual_amount { get; set; }
    public TotalAmount5 total_amount { get; set; }
    public FightActualAmount4 fight_actual_amount { get; set; }
    public FightTotalAmount4 fight_total_amount { get; set; }
    public OverkillPct4 overkill_pct { get; set; }
    public Count4 count { get; set; }
    public double pct { get; set; }
}

public class TickResults
{
    public Crit2 crit { get; set; }
    public Hit2 hit { get; set; }
}

public class NumExecutes2
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class PortionAps2
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class PortionApse2
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class ActualAmount6
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class TotalAmount6
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class TotalIntervals2
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class NumDirectResults2
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class ActualAmount7
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class AvgActualAmount5
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class TotalAmount7
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class FightActualAmount5
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class FightTotalAmount5
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class OverkillPct5
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class Count5
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class Crit3
{
    public ActualAmount7 actual_amount { get; set; }
    public AvgActualAmount5 avg_actual_amount { get; set; }
    public TotalAmount7 total_amount { get; set; }
    public FightActualAmount5 fight_actual_amount { get; set; }
    public FightTotalAmount5 fight_total_amount { get; set; }
    public OverkillPct5 overkill_pct { get; set; }
    public Count5 count { get; set; }
    public double pct { get; set; }
}

public class ActualAmount8
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class AvgActualAmount6
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class TotalAmount8
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class FightActualAmount6
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class FightTotalAmount6
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class OverkillPct6
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class Count6
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class Hit3
{
    public ActualAmount8 actual_amount { get; set; }
    public AvgActualAmount6 avg_actual_amount { get; set; }
    public TotalAmount8 total_amount { get; set; }
    public FightActualAmount6 fight_actual_amount { get; set; }
    public FightTotalAmount6 fight_total_amount { get; set; }
    public OverkillPct6 overkill_pct { get; set; }
    public Count6 count { get; set; }
    public double pct { get; set; }
}

public class DirectResults2
{
    public Crit3 crit { get; set; }
    public Hit3 hit { get; set; }
}

public class TotalExecuteTime2
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class Child
{
    public int id { get; set; }
    public string spell_name { get; set; }
    public string name { get; set; }
    public string school { get; set; }
    public string type { get; set; }
    public NumExecutes2 num_executes { get; set; }
    public double compound_amount { get; set; }
    public PortionAps2 portion_aps { get; set; }
    public PortionApse2 portion_apse { get; set; }
    public double portion_amount { get; set; }
    public ActualAmount6 actual_amount { get; set; }
    public TotalAmount6 total_amount { get; set; }
    public TotalIntervals2 total_intervals { get; set; }
    public NumDirectResults2 num_direct_results { get; set; }
    public DirectResults2 direct_results { get; set; }
    public TotalExecuteTime2 total_execute_time { get; set; }
}

public class Stat
{
    public int id { get; set; }
    public string spell_name { get; set; }
    public string name { get; set; }
    public string school { get; set; }
    public string type { get; set; }
    public NumExecutes num_executes { get; set; }
    public double compound_amount { get; set; }
    public TotalExecuteTime total_execute_time { get; set; }
    public PortionAps portion_aps { get; set; }
    public PortionApse portion_apse { get; set; }
    public double portion_amount { get; set; }
    public ActualAmount actual_amount { get; set; }
    public TotalAmount total_amount { get; set; }
    public TotalIntervals total_intervals { get; set; }
    public NumDirectResults num_direct_results { get; set; }
    public DirectResults direct_results { get; set; }
    public ResourceGain resource_gain { get; set; }
    public NumTicks num_ticks { get; set; }
    public NumTickResults num_tick_results { get; set; }
    public TotalTickTime total_tick_time { get; set; }
    public TickResults tick_results { get; set; }
    public List<Child> children { get; set; }
}

public class StatsPets
{
}

public class Gear
{
}

public class Custom
{
}

public class Player
{
    public string name { get; set; }
    public string race { get; set; }
    public int level { get; set; }
    public string role { get; set; }
    public string specialization { get; set; }
    public string profile_source { get; set; }
    public List<Talent> talents { get; set; }
    public int party { get; set; }
    public int ready_type { get; set; }
    public bool bugs { get; set; }
    public bool scale_player { get; set; }
    public bool potion_used { get; set; }
    public string timeofday { get; set; }
    public string zandalari_loa { get; set; }
    public string vulpera_tricks { get; set; }
    public int invert_scaling { get; set; }
    public double reaction_offset { get; set; }
    public double reaction_max { get; set; }
    public double reaction_mean { get; set; }
    public double reaction_stddev { get; set; }
    public double reaction_nu { get; set; }
    public double world_lag { get; set; }
    public double brain_lag { get; set; }
    public double brain_lag_stddev { get; set; }
    public bool world_lag_override { get; set; }
    public bool world_lag_stddev_override { get; set; }
    public Dbc2 dbc { get; set; }
    public double base_mana_regen_per_second { get; set; }
    public CollectedData collected_data { get; set; }
    public List<Buff2> buffs { get; set; }
    public List<BuffsConstant> buffs_constant { get; set; }
    public List<object> procs { get; set; }
    public List<Gain> gains { get; set; }
    public List<Stat> stats { get; set; }
    public StatsPets stats_pets { get; set; }
    public Gear gear { get; set; }
    public Custom custom { get; set; }
}

public class Result
{
    public string name { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
    public double stddev { get; set; }
    public double mean_stddev { get; set; }
    public double mean_error { get; set; }
    public double median { get; set; }
    public double first_quartile { get; set; }
    public double third_quartile { get; set; }
    public int iterations { get; set; }
}

public class Profilesets
{
    public string metric { get; set; }
    public List<Result> results { get; set; }
}

public class SimulationLength
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
    public double median { get; set; }
    public double variance { get; set; }
    public double std_dev { get; set; }
    public double mean_variance { get; set; }
    public double mean_std_dev { get; set; }
}

public class RaidDps
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class TotalDmg
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class Statistics
{
    public double elapsed_cpu_seconds { get; set; }
    public double elapsed_time_seconds { get; set; }
    public double init_time_seconds { get; set; }
    public double merge_time_seconds { get; set; }
    public double analyze_time_seconds { get; set; }
    public SimulationLength simulation_length { get; set; }
    public int total_events_processed { get; set; }
    public RaidDps raid_dps { get; set; }
    public TotalDmg total_dmg { get; set; }
}

public class ShadowlandsBETA3
{
    public int build_level { get; set; }
    public string wow_version { get; set; }
    public string hotfix_date { get; set; }
    public int hotfix_build { get; set; }
    public string hotfix_hash { get; set; }
}

public class Dbc3
{
    [JsonProperty("shadowlands-BETA")]
    public ShadowlandsBETA3 ShadowlandsBETA { get; set; }
    public string version_used { get; set; }
}

public class FightLength2
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
    public double min { get; set; }
    public double max { get; set; }
}

public class Attribute2
{
}

public class Resources4
{
    public double health { get; set; }
}

public class Stats2
{
    public double attack_crit { get; set; }
    public double spell_haste { get; set; }
    public double attack_haste { get; set; }
    public double spell_speed { get; set; }
    public double attack_speed { get; set; }
    public double crit_pct { get; set; }
    public double speed_pct { get; set; }
    public double armor { get; set; }
    public double dodge { get; set; }
    public double parry { get; set; }
    public double block { get; set; }
}

public class BuffedStats2
{
    public Attribute2 attribute { get; set; }
    public Resources4 resources { get; set; }
    public Stats2 stats { get; set; }
}

public class Health
{
    public double sum { get; set; }
    public int count { get; set; }
    public double mean { get; set; }
}

public class ResourceLost2
{
    public Health health { get; set; }
}

public class Health2
{
    public double mean { get; set; }
    public double mean_std_dev { get; set; }
    public double min { get; set; }
    public double max { get; set; }
    public List<double> data { get; set; }
}

public class ResourceTimelines2
{
    public Health2 health { get; set; }
}

public class CollectedData2
{
    public FightLength2 fight_length { get; set; }
    public BuffedStats2 buffed_stats { get; set; }
    public ResourceLost2 resource_lost { get; set; }
    public ResourceTimelines2 resource_timelines { get; set; }
}

public class Buff3
{
    public string name { get; set; }
    public string spell_name { get; set; }
    public string spell_school { get; set; }
    public double start_count { get; set; }
    public double duration { get; set; }
    public double uptime { get; set; }
    public int? spell { get; set; }
    public string source { get; set; }
    public double? interval { get; set; }
    public double? trigger { get; set; }
    public double? expire_count { get; set; }
}

public class Cooldown3
{
    public string name { get; set; }
    public double duration { get; set; }
}

public class BuffsConstant2
{
    public string name { get; set; }
    public string spell_name { get; set; }
    public string spell_school { get; set; }
    public int spell { get; set; }
    public double start_count { get; set; }
    public double duration { get; set; }
    public double uptime { get; set; }
    public double benefit { get; set; }
    public double default_value { get; set; }
    public Cooldown3 cooldown { get; set; }
}

public class StatsPets2
{
}

public class Gear2
{
}

public class Custom2
{
}

public class Target
{
    public string name { get; set; }
    public string race { get; set; }
    public int level { get; set; }
    public string role { get; set; }
    public string specialization { get; set; }
    public string profile_source { get; set; }
    public List<object> talents { get; set; }
    public int party { get; set; }
    public int ready_type { get; set; }
    public bool bugs { get; set; }
    public bool scale_player { get; set; }
    public bool potion_used { get; set; }
    public string timeofday { get; set; }
    public string zandalari_loa { get; set; }
    public string vulpera_tricks { get; set; }
    public double death_pct { get; set; }
    public double height { get; set; }
    public double combat_reach { get; set; }
    public int invert_scaling { get; set; }
    public double reaction_offset { get; set; }
    public double reaction_max { get; set; }
    public double reaction_mean { get; set; }
    public double reaction_stddev { get; set; }
    public double reaction_nu { get; set; }
    public double world_lag { get; set; }
    public double brain_lag { get; set; }
    public double brain_lag_stddev { get; set; }
    public bool world_lag_override { get; set; }
    public bool world_lag_stddev_override { get; set; }
    public Dbc3 dbc { get; set; }
    public CollectedData2 collected_data { get; set; }
    public List<Buff3> buffs { get; set; }
    public List<BuffsConstant2> buffs_constant { get; set; }
    public List<object> procs { get; set; }
    public List<object> gains { get; set; }
    public List<object> stats { get; set; }
    public StatsPets2 stats_pets { get; set; }
    public Gear2 gear { get; set; }
    public Custom2 custom { get; set; }
}

public class Cooldown4
{
    public string name { get; set; }
    public double duration { get; set; }
}

public class SimAura
{
    public string name { get; set; }
    public string spell_name { get; set; }
    public string spell_school { get; set; }
    public int spell { get; set; }
    public double start_count { get; set; }
    public double duration { get; set; }
    public double uptime { get; set; }
    public double benefit { get; set; }
    public double default_value { get; set; }
    public Cooldown4 cooldown { get; set; }
}

public class Sim
{
    public Options options { get; set; }
    public Overrides overrides { get; set; }
    public List<Player> players { get; set; }
    public Profilesets profilesets { get; set; }
    public Statistics statistics { get; set; }
    public List<Target> targets { get; set; }
    public List<SimAura> sim_auras { get; set; }
}

public class SimcResult
{
    public string version { get; set; }
    public string report_version { get; set; }
    public int ptr_enabled { get; set; }
    public int beta_enabled { get; set; }
    public string build_date { get; set; }
    public string build_time { get; set; }
    public int timestamp { get; set; }
    public string git_revision { get; set; }
    public string git_branch { get; set; }
    public Sim sim { get; set; }
}

