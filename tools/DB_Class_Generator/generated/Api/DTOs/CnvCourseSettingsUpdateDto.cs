using System.ComponentModel.DataAnnotations;
namespace AdminPanel.Api.DTOs {
    public class CnvCourseSettingsUpdateDto : IDto {
        public int RowId { get; set; } = 0;
        public ulong CourseId { get; set; } = 0;
        public int PageNo { get; set; } = 0;
        public int AllowFinalGradeOverride { get; set; } = 0;
        public int AllowStudentDiscussionTopics { get; set; } = 0;
        public int AllowStudentForumAttachments { get; set; } = 0;
        public int AllowStudentDiscussionEditing { get; set; } = 0;
        public int AllowStudentDiscussionReporting { get; set; } = 0;
        public int AllowStudentAnonymousDiscussionTopics { get; set; } = 0;
        public int FilterSpeedGraderByStudentGroup { get; set; } = 0;
        public int GradingStandardEnabled { get; set; } = 0;
        public string GradingStandardId { get; set; } = string.Empty;
        public string GradePassbackSetting { get; set; } = string.Empty;
        public int AllowStudentOrganizedGroups { get; set; } = 0;
        public int HideFinalGrades { get; set; } = 0;
        public int HideDistributionGraphs { get; set; } = 0;
        public int HideSectionsOnCourseUsersPage { get; set; } = 0;
        public int LockAllAnnouncements { get; set; } = 0;
        public int UsageRightsRequired { get; set; } = 0;
        public int RestrictStudentPastView { get; set; } = 0;
        public int RestrictStudentFutureView { get; set; } = 0;
        public int RestrictQuantitativeData { get; set; } = 0;
        public int ShowAnnouncementsOnHomePage { get; set; } = 0;
        public string HomePageAnnouncementLimit { get; set; } = string.Empty;
        public int SyllabusCourseSummary { get; set; } = 0;
        public int HomeroomCourse { get; set; } = 0;
        public string ImageUrl { get; set; } = string.Empty;
        public string ImageId { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string BannerImageUrl { get; set; } = string.Empty;
        public string BannerImageId { get; set; } = string.Empty;
        public string BannerImage { get; set; } = string.Empty;
        public string CourseColor { get; set; } = string.Empty;
        public string FriendlyName { get; set; } = string.Empty;
        public string DefaultDueTime { get; set; } = string.Empty;
        public int ConditionalRelease { get; set; } = 0;
    }
}