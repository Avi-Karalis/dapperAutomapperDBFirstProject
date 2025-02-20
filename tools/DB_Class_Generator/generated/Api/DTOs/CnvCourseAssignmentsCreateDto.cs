using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CnvCourseAssignmentsCreateDto : IDto {
        public int RowId { get; set; } = 0;
        public ulong CourseId { get; set; } = 0;
        public int PageNo { get; set; } = 0;
        public string Description { get; set; } = string.Empty;
        public string DueAt { get; set; } = string.Empty;
        public string UnlockAt { get; set; } = string.Empty;
        public string LockAt { get; set; } = string.Empty;
        public ulong PointsPossible { get; set; } = 0;
        public string GradingType { get; set; } = string.Empty;
        public ulong AssignmentGroupId { get; set; } = 0;
        public string GradingStandardId { get; set; } = string.Empty;
        public string CreatedAt { get; set; } = string.Empty;
        public string UpdatedAt { get; set; } = string.Empty;
        public int PeerReviews { get; set; } = 0;
        public int AutomaticPeerReviews { get; set; } = 0;
        public ulong Position { get; set; } = 0;
        public int GradeGroupStudentsIndividually { get; set; } = 0;
        public int AnonymousPeerReviews { get; set; } = 0;
        public string GroupCategoryId { get; set; } = string.Empty;
        public int PostToSis { get; set; } = 0;
        public int ModeratedGrading { get; set; } = 0;
        public int OmitFromFinalGrade { get; set; } = 0;
        public int IntraGroupPeerReviews { get; set; } = 0;
        public int AnonymousInstructorAnnotations { get; set; } = 0;
        public int AnonymousGrading { get; set; } = 0;
        public int GradersAnonymousToGraders { get; set; } = 0;
        public ulong GraderCount { get; set; } = 0;
        public int GraderCommentsVisibleToGraders { get; set; } = 0;
        public string FinalGraderId { get; set; } = string.Empty;
        public int GraderNamesVisibleToFinalGrader { get; set; } = 0;
        public ulong AllowedAttempts { get; set; } = 0;
        public string AnnotatableAttachmentId { get; set; } = string.Empty;
        public int HideInGradebook { get; set; } = 0;
        public string SecureParams { get; set; } = string.Empty;
        public string LtiContextId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string SubmissionTypes__0 { get; set; } = string.Empty;
        public int HasSubmittedSubmissions { get; set; } = 0;
        public int DueDateRequired { get; set; } = 0;
        public ulong MaxNameLength { get; set; } = 0;
        public int InClosedGradingPeriod { get; set; } = 0;
        public int GradedSubmissionsExist { get; set; } = 0;
        public int IsQuizAssignment { get; set; } = 0;
        public int CanDuplicate { get; set; } = 0;
        public string OriginalCourseId { get; set; } = string.Empty;
        public string OriginalAssignmentId { get; set; } = string.Empty;
        public string OriginalLtiResourceLinkId { get; set; } = string.Empty;
        public string OriginalAssignmentName { get; set; } = string.Empty;
        public string OriginalQuizId { get; set; } = string.Empty;
        public string WorkflowState { get; set; } = string.Empty;
        public int ImportantDates { get; set; } = 0;
        public int IsQuizLtiAssignment { get; set; } = 0;
        public string FrozenAttributes__0 { get; set; } = string.Empty;
        public string ExternalToolTagAttributes_Url { get; set; } = string.Empty;
        public string ExternalToolTagAttributes_NewTab { get; set; } = string.Empty;
        public string ExternalToolTagAttributes_ExternalData { get; set; } = string.Empty;
        public string ExternalToolTagAttributes_ResourceLinkId { get; set; } = string.Empty;
        public string ExternalToolTagAttributes_ResourceLinkTitle { get; set; } = string.Empty;
        public string ExternalToolTagAttributes_ContentType { get; set; } = string.Empty;
        public ulong ExternalToolTagAttributes_ContentId { get; set; } = 0;
        public string ExternalToolTagAttributes_CustomParams { get; set; } = string.Empty;
        public int Muted { get; set; } = 0;
        public string HtmlUrl { get; set; } = string.Empty;
        public int HasOverrides { get; set; } = 0;
        public string Url { get; set; } = string.Empty;
        public ulong NeedsGradingCount { get; set; } = 0;
        public string SisAssignmentId { get; set; } = string.Empty;
        public string IntegrationId { get; set; } = string.Empty;
        public int Published { get; set; } = 0;
        public int Unpublishable { get; set; } = 0;
        public int OnlyVisibleToOverrides { get; set; } = 0;
        public int VisibleToEveryone { get; set; } = 0;
        public int LockedForUser { get; set; } = 0;
        public string SubmissionsDownloadUrl { get; set; } = string.Empty;
        public int PostManually { get; set; } = 0;
        public int AnonymizeStudents { get; set; } = 0;
        public int RequireLockdownBrowser { get; set; } = 0;
        public int RestrictQuantitativeData { get; set; } = 0;
    }
}