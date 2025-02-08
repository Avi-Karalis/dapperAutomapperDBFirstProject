using Microsoft.Extensions.DependencyInjection;
using AdminPanel.Service.Interfaces;
using AdminPanel.Service.Services;

namespace AdminPanel.Service.DependencyResolver {
    public static class Services {
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services.AddScoped(typeof(ICrudService<>), typeof(CrudService<>));
            services.AddScoped<IAccountsService, AccountsService>();
            services.AddScoped<ICacheService, CacheService>();
            services.AddScoped<ICacheLocksService, CacheLocksService>();
            services.AddScoped<ICnvAccountUsersService, CnvAccountUsersService>();
            services.AddScoped<ICnvAnnouncementsService, CnvAnnouncementsService>();
            services.AddScoped<ICnvCommonGroupsService, CnvCommonGroupsService>();
            services.AddScoped<ICnvCourseAssignmentsService, CnvCourseAssignmentsService>();
            services.AddScoped<ICnvCourseDiscussionTopicsService, CnvCourseDiscussionTopicsService>();
            services.AddScoped<ICnvCourseDiscussionTopicsEntriesService, CnvCourseDiscussionTopicsEntriesService>();
            services.AddScoped<ICnvCourseEnrollmentsService, CnvCourseEnrollmentsService>();
            services.AddScoped<ICnvCourseEnrollmentsUsersService, CnvCourseEnrollmentsUsersService>();
            services.AddScoped<ICnvCourseFilesService, CnvCourseFilesService>();
            services.AddScoped<ICnvCourseFoldersService, CnvCourseFoldersService>();
            services.AddScoped<ICnvCourseModuleItemsService, CnvCourseModuleItemsService>();
            services.AddScoped<ICnvCourseModulesService, CnvCourseModulesService>();
            services.AddScoped<ICnvCoursePagesService, CnvCoursePagesService>();
            services.AddScoped<ICnvCourseQuizzesService, CnvCourseQuizzesService>();
            services.AddScoped<ICnvCourseRecentStudentsService, CnvCourseRecentStudentsService>();
            services.AddScoped<ICnvCourseSectionsService, CnvCourseSectionsService>();
            services.AddScoped<ICnvCourseSettingsService, CnvCourseSettingsService>();
            services.AddScoped<ICnvCourseTabsService, CnvCourseTabsService>();
            services.AddScoped<ICnvCourseUsersService, CnvCourseUsersService>();
            services.AddScoped<ICnvCoursesService, CnvCoursesService>();
            services.AddScoped<ICnvGradebookFeedService, CnvGradebookFeedService>();
            services.AddScoped<ICnvSessionsService, CnvSessionsService>();
            services.AddScoped<ICnvSubAccountsService, CnvSubAccountsService>();
            services.AddScoped<ICnvSubmissionsService, CnvSubmissionsService>();
            services.AddScoped<ICompaniesService, CompaniesService>();
            services.AddScoped<ICompaniesExtService, CompaniesExtService>();
            services.AddScoped<ICompanyUsersService, CompanyUsersService>();
            services.AddScoped<ICourseLikesService, CourseLikesService>();
            services.AddScoped<ICourseTranslationsService, CourseTranslationsService>();
            services.AddScoped<ICoursesService, CoursesService>();
            services.AddScoped<IDotnetPersonService, DotnetPersonService>();
            services.AddScoped<IDotnetPersonalaccesstokenService, DotnetPersonalaccesstokenService>();
            services.AddScoped<IDotnetUploadService, DotnetUploadService>();
            services.AddScoped<IDotnetUserService, DotnetUserService>();
            services.AddScoped<IEventTestsService, EventTestsService>();
            services.AddScoped<ILanguagesService, LanguagesService>();
            services.AddScoped<ILanguagesExtService, LanguagesExtService>();
            services.AddScoped<ILanguagesI18nService, LanguagesI18nService>();
            services.AddScoped<ILmsAssignmentsService, LmsAssignmentsService>();
            services.AddScoped<ILmsAssignmentsI18nService, LmsAssignmentsI18nService>();
            services.AddScoped<ILmsChatService, LmsChatService>();
            services.AddScoped<ILmsCompaniesRelService, LmsCompaniesRelService>();
            services.AddScoped<ILmsCompanyContractsService, LmsCompanyContractsService>();
            services.AddScoped<ILmsCourseAccountsService, LmsCourseAccountsService>();
            services.AddScoped<ILmsCourseAssetsService, LmsCourseAssetsService>();
            services.AddScoped<ILmsCourseAttachmentsService, LmsCourseAttachmentsService>();
            services.AddScoped<ILmsCourseAttachmentsI18nService, LmsCourseAttachmentsI18nService>();
            services.AddScoped<ILmsCourseDiscussionsService, LmsCourseDiscussionsService>();
            services.AddScoped<ILmsCourseSessionAccountTransactionsService, LmsCourseSessionAccountTransactionsService>();
            services.AddScoped<ILmsCourseSessionAccountsService, LmsCourseSessionAccountsService>();
            services.AddScoped<ILmsCourseSessionsService, LmsCourseSessionsService>();
            services.AddScoped<ILmsCourseSessionsTranslationsService, LmsCourseSessionsTranslationsService>();
            services.AddScoped<ILmsCourseTaxonomiesService, LmsCourseTaxonomiesService>();
            services.AddScoped<ILmsCourseTransactionsService, LmsCourseTransactionsService>();
            services.AddScoped<ILmsDeletionLogsService, LmsDeletionLogsService>();
            services.AddScoped<ILmsIntegrationService, LmsIntegrationService>();
            services.AddScoped<ILmsLovsService, LmsLovsService>();
            services.AddScoped<ILmsMenusService, LmsMenusService>();
            services.AddScoped<ILmsPositionRolesService, LmsPositionRolesService>();
            services.AddScoped<ILmsPositionsService, LmsPositionsService>();
            services.AddScoped<ILmsTablesService, LmsTablesService>();
            services.AddScoped<ILmsTaxonomiesService, LmsTaxonomiesService>();
            services.AddScoped<ILmsTaxonomyTranslationsService, LmsTaxonomyTranslationsService>();
            services.AddScoped<ILmsTranslationLanguagesService, LmsTranslationLanguagesService>();
            services.AddScoped<ILmsTranslationsService, LmsTranslationsService>();
            services.AddScoped<IMediaUploadsService, MediaUploadsService>();
            services.AddScoped<IMgrCanvasAccountUsersService, MgrCanvasAccountUsersService>();
            services.AddScoped<IMgrCanvasAccountsService, MgrCanvasAccountsService>();
            services.AddScoped<IMgrCanvasCourseService, MgrCanvasCourseService>();
            services.AddScoped<IMgrCanvasCourseQuizzesService, MgrCanvasCourseQuizzesService>();
            services.AddScoped<IMgrCanvasCoursesService, MgrCanvasCoursesService>();
            services.AddScoped<IMgrCanvasCoursesBckService, MgrCanvasCoursesBckService>();
            services.AddScoped<IMgrCanvasCoursesTempService, MgrCanvasCoursesTempService>();
            services.AddScoped<IMgrCanvasDiscussionEntriesService, MgrCanvasDiscussionEntriesService>();
            services.AddScoped<IMgrCanvasDiscussionTopicsService, MgrCanvasDiscussionTopicsService>();
            services.AddScoped<IMgrCanvasEnrollmentsService, MgrCanvasEnrollmentsService>();
            services.AddScoped<IMgrCanvasSectionsService, MgrCanvasSectionsService>();
            services.AddScoped<IMgrCanvasStateService, MgrCanvasStateService>();
            services.AddScoped<IMgrCanvasUsersService, MgrCanvasUsersService>();
            services.AddScoped<IMigrationsService, MigrationsService>();
            services.AddScoped<IModelHasPermissionsService, ModelHasPermissionsService>();
            services.AddScoped<IModelHasRolesService, ModelHasRolesService>();
            services.AddScoped<INestedSetTestService, NestedSetTestService>();
            services.AddScoped<IPcTokensService, PcTokensService>();
            services.AddScoped<IPclmsAccountModulesService, PclmsAccountModulesService>();
            services.AddScoped<IPclmsAccountUsersService, PclmsAccountUsersService>();
            services.AddScoped<IPclmsAccountsService, PclmsAccountsService>();
            services.AddScoped<IPclmsAccountsBckService, PclmsAccountsBckService>();
            services.AddScoped<IPclmsAccountsNsService, PclmsAccountsNsService>();
            services.AddScoped<IPclmsCourseModulesService, PclmsCourseModulesService>();
            services.AddScoped<IPclmsCourseQuestionAnswersService, PclmsCourseQuestionAnswersService>();
            services.AddScoped<IPclmsCourseQuestionsService, PclmsCourseQuestionsService>();
            services.AddScoped<IPclmsCourseQuizzesService, PclmsCourseQuizzesService>();
            services.AddScoped<IPclmsCourseSectionsService, PclmsCourseSectionsService>();
            services.AddScoped<IPclmsCourseTypesService, PclmsCourseTypesService>();
            services.AddScoped<IPclmsCourseUsersService, PclmsCourseUsersService>();
            services.AddScoped<IPclmsCoursesService, PclmsCoursesService>();
            services.AddScoped<IPclmsFilesService, PclmsFilesService>();
            services.AddScoped<IPclmsFoldersService, PclmsFoldersService>();
            services.AddScoped<IPclmsPagesService, PclmsPagesService>();
            services.AddScoped<IPclmsPermissionsService, PclmsPermissionsService>();
            services.AddScoped<IPclmsRolePermissionsService, PclmsRolePermissionsService>();
            services.AddScoped<IPclmsRolesService, PclmsRolesService>();
            services.AddScoped<IPclmsSettingsService, PclmsSettingsService>();
            services.AddScoped<IPclmsTagsService, PclmsTagsService>();
            services.AddScoped<IPclmsTagsI18nService, PclmsTagsI18nService>();
            services.AddScoped<IPclmsTokensService, PclmsTokensService>();
            services.AddScoped<IPclmsUserRolesService, PclmsUserRolesService>();
            services.AddScoped<IPclmsUsersService, PclmsUsersService>();
            services.AddScoped<IPclmsWatchdogService, PclmsWatchdogService>();
            services.AddScoped<IPermissionsService, PermissionsService>();
            services.AddScoped<IPersonalAccessTokensService, PersonalAccessTokensService>();
            services.AddScoped<IQueueJobsService, QueueJobsService>();
            services.AddScoped<IRoleHasPermissionsService, RoleHasPermissionsService>();
            services.AddScoped<IRolesService, RolesService>();
            services.AddScoped<ISectionContentTranslationsService, SectionContentTranslationsService>();
            services.AddScoped<ISectionContentsService, SectionContentsService>();
            services.AddScoped<ISectionTranslationsService, SectionTranslationsService>();
            services.AddScoped<ISectionsService, SectionsService>();
            services.AddScoped<ISessionsService, SessionsService>();
            services.AddScoped<ITempPclmsCoursesService, TempPclmsCoursesService>();
            services.AddScoped<ITestRedisMessagesService, TestRedisMessagesService>();
            return services;
        }
    }
}