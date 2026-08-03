using AfricaMarketIntelligence.Backgroundjob;
using AfricaMarketIntelligence.Backgroundjob.logging;
using AfricaMarketIntelligence.Common.Implementation;
using AfricaMarketIntelligence.Common.Interface;
using AfricaMarketIntelligence.IServices;
using AfricaMarketIntelligence.Services;

namespace AfricaMarketIntelligence.Common.DI
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            services.AddHostedService<ChannelWorker>();
            services.AddHostedService<AiJobService>();
            services.AddHostedService<EmergingTrendsCacheWorker>();
            services.AddScoped<Download>();
            services.AddHostedService<LogWorker>();
            // Channels
            services.AddSingleton<ChannelService>();
            services.AddSingleton<LogChannelService>();
            services.AddScoped<IAppLogger, AppLogger>();


            services.AddScoped<IAIAnalyzeService, AIAnalyzeService>();
            services.AddScoped<IChatService, ChatService>();
            services.AddScoped<IQuestionService, QuestionService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IPillarService, PillarService>();
            services.AddScoped<IAssessmentResponseService, AssessmentResponseService>();
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ICountryUserService, CountryUserService>();
            services.AddScoped<ISignalDashboardService, SignalDashboardService>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<IPublicService, PublicService>();
            services.AddScoped<IKpiService, KpiService>();
            services.AddScoped<IAIComputationService, AIComputationService>();
            services.AddScoped<ICommonService, CommonService>();
            services.AddScoped<Interface.IPdfGeneratorService, Implementation.PdfGeneratorService>();
            services.AddScoped<IDocxGeneratorService, DocxGeneratorService>();
            services.AddScoped<IDocumentGeneratorService, DocumentGeneratorService>();
            return services;
        }
    }
}
