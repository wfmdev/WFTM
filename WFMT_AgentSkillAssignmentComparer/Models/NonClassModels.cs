namespace WFMT_AgentSkillAssignmentComparer.Models
{
    public enum ComparisonType
    {
        SHOW_A,
        SHOW_B,
        MISSING_FROM_B,
        NEW_IN_B,
        CHANGED_IN_B,
        CHANGED_AND_NEW_IN_B,
        ALL_DIFFERENCES_IN_B
    }
}