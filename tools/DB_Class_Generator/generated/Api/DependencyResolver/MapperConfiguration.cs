using AdminPanel.Api.Mappers;
using Microsoft.Extensions.DependencyInjection;

namespace AdminPanel.Api.DependencyResolver {
    public static class MapperConfiguration {
        public static IServiceCollection AddAutoMapperProfiles(this IServiceCollection services) {
            services.AddAutoMapper(typeof(Accounts).Assembly);
services.AddAutoMapper(typeof(Cache).Assembly);
services.AddAutoMapper(typeof(CacheLocks).Assembly);
services.AddAutoMapper(typeof(CnvAccountUsers).Assembly);
services.AddAutoMapper(typeof(CnvAnnouncements).Assembly);
services.AddAutoMapper(typeof(CnvCommonGroups).Assembly);
services.AddAutoMapper(typeof(CnvCourseAssignments).Assembly);
services.AddAutoMapper(typeof(CnvCourseDiscussionTopics).Assembly);
services.AddAutoMapper(typeof(CnvCourseDiscussionTopicsEntries).Assembly);
services.AddAutoMapper(typeof(CnvCourseEnrollments).Assembly);
services.AddAutoMapper(typeof(CnvCourseEnrollmentsUsers).Assembly);
services.AddAutoMapper(typeof(CnvCourseFiles).Assembly);
services.AddAutoMapper(typeof(CnvCourseFolders).Assembly);
services.AddAutoMapper(typeof(CnvCourseModuleItems).Assembly);
services.AddAutoMapper(typeof(CnvCourseModules).Assembly);
services.AddAutoMapper(typeof(CnvCoursePages).Assembly);
services.AddAutoMapper(typeof(CnvCourseQuizzes).Assembly);
services.AddAutoMapper(typeof(CnvCourseRecentStudents).Assembly);
services.AddAutoMapper(typeof(CnvCourseSections).Assembly);
services.AddAutoMapper(typeof(CnvCourseSettings).Assembly);
services.AddAutoMapper(typeof(CnvCourseTabs).Assembly);
services.AddAutoMapper(typeof(CnvCourseUsers).Assembly);
services.AddAutoMapper(typeof(CnvCourses).Assembly);
services.AddAutoMapper(typeof(CnvGradebookFeed).Assembly);
services.AddAutoMapper(typeof(CnvSessions).Assembly);
services.AddAutoMapper(typeof(CnvSubAccounts).Assembly);
services.AddAutoMapper(typeof(CnvSubmissions).Assembly);
services.AddAutoMapper(typeof(Companies).Assembly);
services.AddAutoMapper(typeof(CompaniesExt).Assembly);
services.AddAutoMapper(typeof(CompanyUsers).Assembly);
services.AddAutoMapper(typeof(CourseLikes).Assembly);
services.AddAutoMapper(typeof(CourseTranslations).Assembly);
services.AddAutoMapper(typeof(Courses).Assembly);
services.AddAutoMapper(typeof(DotnetPerson).Assembly);
services.AddAutoMapper(typeof(DotnetPersonalaccesstoken).Assembly);
services.AddAutoMapper(typeof(DotnetUpload).Assembly);
services.AddAutoMapper(typeof(DotnetUser).Assembly);
services.AddAutoMapper(typeof(EventTests).Assembly);
services.AddAutoMapper(typeof(Languages).Assembly);
services.AddAutoMapper(typeof(LanguagesExt).Assembly);
services.AddAutoMapper(typeof(LanguagesI18n).Assembly);
services.AddAutoMapper(typeof(LmsAssignments).Assembly);
services.AddAutoMapper(typeof(LmsAssignmentsI18n).Assembly);
services.AddAutoMapper(typeof(LmsChat).Assembly);
services.AddAutoMapper(typeof(LmsCompaniesRel).Assembly);
services.AddAutoMapper(typeof(LmsCompanyContracts).Assembly);
services.AddAutoMapper(typeof(LmsCourseAccounts).Assembly);
services.AddAutoMapper(typeof(LmsCourseAssets).Assembly);
services.AddAutoMapper(typeof(LmsCourseAttachments).Assembly);
services.AddAutoMapper(typeof(LmsCourseAttachmentsI18n).Assembly);
services.AddAutoMapper(typeof(LmsCourseDiscussions).Assembly);
services.AddAutoMapper(typeof(LmsCourseSessionAccountTransactions).Assembly);
services.AddAutoMapper(typeof(LmsCourseSessionAccounts).Assembly);
services.AddAutoMapper(typeof(LmsCourseSessions).Assembly);
services.AddAutoMapper(typeof(LmsCourseSessionsTranslations).Assembly);
services.AddAutoMapper(typeof(LmsCourseTaxonomies).Assembly);
services.AddAutoMapper(typeof(LmsCourseTransactions).Assembly);
services.AddAutoMapper(typeof(LmsDeletionLogs).Assembly);
services.AddAutoMapper(typeof(LmsIntegration).Assembly);
services.AddAutoMapper(typeof(LmsLovs).Assembly);
services.AddAutoMapper(typeof(LmsMenus).Assembly);
services.AddAutoMapper(typeof(LmsPositionRoles).Assembly);
services.AddAutoMapper(typeof(LmsPositions).Assembly);
services.AddAutoMapper(typeof(LmsTables).Assembly);
services.AddAutoMapper(typeof(LmsTaxonomies).Assembly);
services.AddAutoMapper(typeof(LmsTaxonomyTranslations).Assembly);
services.AddAutoMapper(typeof(LmsTranslationLanguages).Assembly);
services.AddAutoMapper(typeof(LmsTranslations).Assembly);
services.AddAutoMapper(typeof(MediaUploads).Assembly);
services.AddAutoMapper(typeof(MgrCanvasAccountUsers).Assembly);
services.AddAutoMapper(typeof(MgrCanvasAccounts).Assembly);
services.AddAutoMapper(typeof(MgrCanvasCourse).Assembly);
services.AddAutoMapper(typeof(MgrCanvasCourseQuizzes).Assembly);
services.AddAutoMapper(typeof(MgrCanvasCourses).Assembly);
services.AddAutoMapper(typeof(MgrCanvasCoursesBck).Assembly);
services.AddAutoMapper(typeof(MgrCanvasCoursesTemp).Assembly);
services.AddAutoMapper(typeof(MgrCanvasDiscussionEntries).Assembly);
services.AddAutoMapper(typeof(MgrCanvasDiscussionTopics).Assembly);
services.AddAutoMapper(typeof(MgrCanvasEnrollments).Assembly);
services.AddAutoMapper(typeof(MgrCanvasSections).Assembly);
services.AddAutoMapper(typeof(MgrCanvasState).Assembly);
services.AddAutoMapper(typeof(MgrCanvasUsers).Assembly);
services.AddAutoMapper(typeof(Migrations).Assembly);
services.AddAutoMapper(typeof(ModelHasPermissions).Assembly);
services.AddAutoMapper(typeof(ModelHasRoles).Assembly);
services.AddAutoMapper(typeof(NestedSetTest).Assembly);
services.AddAutoMapper(typeof(PcTokens).Assembly);
services.AddAutoMapper(typeof(PclmsAccountModules).Assembly);
services.AddAutoMapper(typeof(PclmsAccountUsers).Assembly);
services.AddAutoMapper(typeof(PclmsAccounts).Assembly);
services.AddAutoMapper(typeof(PclmsAccountsBck).Assembly);
services.AddAutoMapper(typeof(PclmsAccountsNs).Assembly);
services.AddAutoMapper(typeof(PclmsCourseModules).Assembly);
services.AddAutoMapper(typeof(PclmsCourseQuestionAnswers).Assembly);
services.AddAutoMapper(typeof(PclmsCourseQuestions).Assembly);
services.AddAutoMapper(typeof(PclmsCourseQuizzes).Assembly);
services.AddAutoMapper(typeof(PclmsCourseSections).Assembly);
services.AddAutoMapper(typeof(PclmsCourseTypes).Assembly);
services.AddAutoMapper(typeof(PclmsCourseUsers).Assembly);
services.AddAutoMapper(typeof(PclmsCourses).Assembly);
services.AddAutoMapper(typeof(PclmsFiles).Assembly);
services.AddAutoMapper(typeof(PclmsFolders).Assembly);
services.AddAutoMapper(typeof(PclmsPages).Assembly);
services.AddAutoMapper(typeof(PclmsPermissions).Assembly);
services.AddAutoMapper(typeof(PclmsRolePermissions).Assembly);
services.AddAutoMapper(typeof(PclmsRoles).Assembly);
services.AddAutoMapper(typeof(PclmsSettings).Assembly);
services.AddAutoMapper(typeof(PclmsTags).Assembly);
services.AddAutoMapper(typeof(PclmsTagsI18n).Assembly);
services.AddAutoMapper(typeof(PclmsTokens).Assembly);
services.AddAutoMapper(typeof(PclmsUserRoles).Assembly);
services.AddAutoMapper(typeof(PclmsUsers).Assembly);
services.AddAutoMapper(typeof(PclmsWatchdog).Assembly);
services.AddAutoMapper(typeof(Permissions).Assembly);
services.AddAutoMapper(typeof(PersonalAccessTokens).Assembly);
services.AddAutoMapper(typeof(QueueJobs).Assembly);
services.AddAutoMapper(typeof(RoleHasPermissions).Assembly);
services.AddAutoMapper(typeof(Roles).Assembly);
services.AddAutoMapper(typeof(SectionContentTranslations).Assembly);
services.AddAutoMapper(typeof(SectionContents).Assembly);
services.AddAutoMapper(typeof(SectionTranslations).Assembly);
services.AddAutoMapper(typeof(Sections).Assembly);
services.AddAutoMapper(typeof(Sessions).Assembly);
services.AddAutoMapper(typeof(TempPclmsCourses).Assembly);
services.AddAutoMapper(typeof(TestRedisMessages).Assembly);

            return services;
        }
    }
}