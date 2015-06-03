using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Selenium.DataService.Models.Mapping;

namespace Selenium.DataService.Models
{
    public partial class ChmActivityContext : DbContext
    {
        static ChmActivityContext()
        {
            Database.SetInitializer<ChmActivityContext>(null);
        }

        public ChmActivityContext()
            : base("Name=ChmActivityContext")
        {
        }

        public DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public DbSet<ACTIVE_CHECKIN> ACTIVE_CHECKIN { get; set; }
        public DbSet<Active_Checkin_History> Active_Checkin_History { get; set; }
        public DbSet<ACTIVE_DETAIL_CHECKIN> ACTIVE_DETAIL_CHECKIN { get; set; }
        public DbSet<Active_Detail_Checkin_History> Active_Detail_Checkin_History { get; set; }
        public DbSet<ACTIVITY> ACTIVITies { get; set; }
        public DbSet<ACTIVITY_ATTRIBUTE> ACTIVITY_ATTRIBUTE { get; set; }
        public DbSet<ACTIVITY_DETAIL> ACTIVITY_DETAIL { get; set; }
        public DbSet<ACTIVITY_DETAIL_ATTRIBUTE> ACTIVITY_DETAIL_ATTRIBUTE { get; set; }
        public DbSet<ACTIVITY_DETAIL_INSTANCE> ACTIVITY_DETAIL_INSTANCE { get; set; }
        public DbSet<ACTIVITY_DETAIL_INSTANCE_ATTRIBUTE> ACTIVITY_DETAIL_INSTANCE_ATTRIBUTE { get; set; }
        public DbSet<ACTIVITY_EXPERIENCE> ACTIVITY_EXPERIENCE { get; set; }
        public DbSet<ACTIVITY_EXPERIENCE_REQUIREMENT> ACTIVITY_EXPERIENCE_REQUIREMENT { get; set; }
        public DbSet<ACTIVITY_GROUP> ACTIVITY_GROUP { get; set; }
        public DbSet<ACTIVITY_INSTANCE> ACTIVITY_INSTANCE { get; set; }
        public DbSet<ACTIVITY_INSTANCE_ATTRIBUTE> ACTIVITY_INSTANCE_ATTRIBUTE { get; set; }
        public DbSet<activity_instance_date_helper> activity_instance_date_helper { get; set; }
        public DbSet<ACTIVITY_MINISTRY> ACTIVITY_MINISTRY { get; set; }
        public DbSet<ACTIVITY_PROPERTY> ACTIVITY_PROPERTY { get; set; }
        public DbSet<ACTIVITY_PROPERTY_ACTIVITY_DETAIL> ACTIVITY_PROPERTY_ACTIVITY_DETAIL { get; set; }
        public DbSet<ACTIVITY_PROPERTY_LOV> ACTIVITY_PROPERTY_LOV { get; set; }
        public DbSet<ACTIVITY_RECURRENCE> ACTIVITY_RECURRENCE { get; set; }
        public DbSet<ACTIVITY_REGISTRATION> ACTIVITY_REGISTRATION { get; set; }
        public DbSet<ACTIVITY_REGISTRATION_ACTIVITY_INSTANCE> ACTIVITY_REGISTRATION_ACTIVITY_INSTANCE { get; set; }
        public DbSet<ACTIVITY_REGISTRATION_ACTIVITY_TIME> ACTIVITY_REGISTRATION_ACTIVITY_TIME { get; set; }
        public DbSet<ACTIVITY_REGISTRATION_JOIN> ACTIVITY_REGISTRATION_JOIN { get; set; }
        public DbSet<ACTIVITY_REQUIREMENT> ACTIVITY_REQUIREMENT { get; set; }
        public DbSet<ACTIVITY_SERIES> ACTIVITY_SERIES { get; set; }
        public DbSet<ACTIVITY_TAG> ACTIVITY_TAG { get; set; }
        public DbSet<ACTIVITY_TIME> ACTIVITY_TIME { get; set; }
        public DbSet<ACTIVITY_TIME_ACTIVITY_INSTANCE> ACTIVITY_TIME_ACTIVITY_INSTANCE { get; set; }
        public DbSet<ACTIVITY_TYPE> ACTIVITY_TYPE { get; set; }
        public DbSet<ACTIVITY_TYPE_ACTIVITY> ACTIVITY_TYPE_ACTIVITY { get; set; }
        public DbSet<AssignmentHistory> AssignmentHistories { get; set; }
        public DbSet<AUTOMATIC_ATTENDANCE_RULE> AUTOMATIC_ATTENDANCE_RULE { get; set; }
        public DbSet<CHECK_IN_MACHINE> CHECK_IN_MACHINE { get; set; }
        public DbSet<CHURCH_SECURE_CODE> CHURCH_SECURE_CODE { get; set; }
        public DbSet<COLOR_SET> COLOR_SET { get; set; }
        public DbSet<COLOR_SET_ELEMENT> COLOR_SET_ELEMENT { get; set; }
        public DbSet<COMMONCC> COMMONCCs { get; set; }
        public DbSet<COMMONCHECK> COMMONCHECKs { get; set; }
        public DbSet<CTRL_DATE_TABLE> CTRL_DATE_TABLE { get; set; }
        public DbSet<CURRENCY_ITEM> CURRENCY_ITEM { get; set; }
        public DbSet<DATA_TYPE> DATA_TYPE { get; set; }
        public DbSet<DATA_TYPE_VALIDATION_EXPRESSION_TYPE> DATA_TYPE_VALIDATION_EXPRESSION_TYPE { get; set; }
        public DbSet<Date_Range_Type> Date_Range_Type { get; set; }
        public DbSet<dtproperty> dtproperties { get; set; }
        public DbSet<ELEMENT> ELEMENTs { get; set; }
        public DbSet<EMAIL_MESSAGE> EMAIL_MESSAGE { get; set; }
        public DbSet<FORM> FORMs { get; set; }
        public DbSet<FORM_HEADER> FORM_HEADER { get; set; }
        public DbSet<FORM_INDIVIDUAL> FORM_INDIVIDUAL { get; set; }
        public DbSet<FORM_INDIVIDUAL_SET> FORM_INDIVIDUAL_SET { get; set; }
        public DbSet<FORM_INDIVIDUAL_SET_NOTE> FORM_INDIVIDUAL_SET_NOTE { get; set; }
        public DbSet<FORM_INDIVIDUAL_STATUS_TYPE> FORM_INDIVIDUAL_STATUS_TYPE { get; set; }
        public DbSet<FORM_ITEM> FORM_ITEM { get; set; }
        public DbSet<FORM_ITEM_OPTION> FORM_ITEM_OPTION { get; set; }
        public DbSet<FORM_ITEM_OPTION_INDIVIDUAL> FORM_ITEM_OPTION_INDIVIDUAL { get; set; }
        public DbSet<FORM_ITEM_TEXT> FORM_ITEM_TEXT { get; set; }
        public DbSet<FORM_ITEM_TEXT_INDIVIDUAL> FORM_ITEM_TEXT_INDIVIDUAL { get; set; }
        public DbSet<FORM_ITEM_TYPE> FORM_ITEM_TYPE { get; set; }
        public DbSet<FORM_PAGE> FORM_PAGE { get; set; }
        public DbSet<FORM_PROMOTION_CODE> FORM_PROMOTION_CODE { get; set; }
        public DbSet<FORM_RELATIONSHIP> FORM_RELATIONSHIP { get; set; }
        public DbSet<FORM_RELATIONSHIP_TYPE> FORM_RELATIONSHIP_TYPE { get; set; }
        public DbSet<FORM_TYPE> FORM_TYPE { get; set; }
        public DbSet<FREQ_TAG_COMMENT> FREQ_TAG_COMMENT { get; set; }
        public DbSet<GFT_JOB> GFT_JOB { get; set; }
        public DbSet<GFT_JOB_ATTRIBUTE> GFT_JOB_ATTRIBUTE { get; set; }
        public DbSet<GFT_JOB_CATEGORY> GFT_JOB_CATEGORY { get; set; }
        public DbSet<GLOBAL_ACTIVITY> GLOBAL_ACTIVITY { get; set; }
        public DbSet<GLOBAL_ACTIVITY_TIME> GLOBAL_ACTIVITY_TIME { get; set; }
        public DbSet<GLOBAL_MINISTRY> GLOBAL_MINISTRY { get; set; }
        public DbSet<HOUSEHOLD_ATTENDANCE> HOUSEHOLD_ATTENDANCE { get; set; }
        public DbSet<INDIVIDUAL_CUSTOM_REGISTRATION> INDIVIDUAL_CUSTOM_REGISTRATION { get; set; }
        public DbSet<INDIVIDUAL_GROUP> INDIVIDUAL_GROUP { get; set; }
        public DbSet<INDIVIDUAL_INSTANCE> INDIVIDUAL_INSTANCE { get; set; }
        public DbSet<INDIVIDUAL_INSTANCE_HISTORY> INDIVIDUAL_INSTANCE_HISTORY { get; set; }
        public DbSet<INDIVIDUAL_PAYMENT> INDIVIDUAL_PAYMENT { get; set; }
        public DbSet<INDIVIDUAL_PAYMENT_REFUND> INDIVIDUAL_PAYMENT_REFUND { get; set; }
        public DbSet<INDIVIDUAL_PREFS> INDIVIDUAL_PREFS { get; set; }
        public DbSet<INDIVIDUAL_REGISTRATION> INDIVIDUAL_REGISTRATION { get; set; }
        public DbSet<INDIVIDUAL_REGISTRATION_2> INDIVIDUAL_REGISTRATION_2 { get; set; }
        public DbSet<INDIVIDUAL_REGISTRATION_ITEM> INDIVIDUAL_REGISTRATION_ITEM { get; set; }
        public DbSet<INDIVIDUAL_REGISTRATION_ITEM_LOV> INDIVIDUAL_REGISTRATION_ITEM_LOV { get; set; }
        public DbSet<INDIVIDUAL_TYPE> INDIVIDUAL_TYPE { get; set; }
        public DbSet<INDIVIDUAL_TYPE_GROUP> INDIVIDUAL_TYPE_GROUP { get; set; }
        public DbSet<INTEGER_ITEM> INTEGER_ITEM { get; set; }
        public DbSet<JOB> JOBs { get; set; }
        public DbSet<JOB_ATTRIBUTE> JOB_ATTRIBUTE { get; set; }
        public DbSet<JOB_ATTRIBUTE_GROUP> JOB_ATTRIBUTE_GROUP { get; set; }
        public DbSet<JOB_INFORMATION> JOB_INFORMATION { get; set; }
        public DbSet<JOB_JOB_ATTRIBUTE> JOB_JOB_ATTRIBUTE { get; set; }
        public DbSet<JOB_JOB_INFORMATION> JOB_JOB_INFORMATION { get; set; }
        public DbSet<JOB_MARITAL_STATUS> JOB_MARITAL_STATUS { get; set; }
        public DbSet<JOB_REQUIREMENT> JOB_REQUIREMENT { get; set; }
        public DbSet<JOB_STATUS_RESTRICTION> JOB_STATUS_RESTRICTION { get; set; }
        public DbSet<LifeChurch_Activity_Whitelist> LifeChurch_Activity_Whitelist { get; set; }
        public DbSet<MINISTRY> MINISTRies { get; set; }
        public DbSet<ministry_user_backup> ministry_user_backup { get; set; }
        public DbSet<MULTIPLE_DISCOUNT> MULTIPLE_DISCOUNT { get; set; }
        public DbSet<OPTION_TABLE> OPTION_TABLE { get; set; }
        public DbSet<PAY_ITEM> PAY_ITEM { get; set; }
        public DbSet<PAY_ITEM_DETAIL> PAY_ITEM_DETAIL { get; set; }
        public DbSet<PAY_ITEM_FORM> PAY_ITEM_FORM { get; set; }
        public DbSet<PAY_ITEM_FORM_ITEM_OPTION> PAY_ITEM_FORM_ITEM_OPTION { get; set; }
        public DbSet<PAY_ITEM_TYPE> PAY_ITEM_TYPE { get; set; }
        public DbSet<PAY_LINE_ITEM> PAY_LINE_ITEM { get; set; }
        public DbSet<PAY_ORDER> PAY_ORDER { get; set; }
        public DbSet<PAY_ORDER_SET> PAY_ORDER_SET { get; set; }
        public DbSet<PAY_ORDER_STATUS_TYPE> PAY_ORDER_STATUS_TYPE { get; set; }
        public DbSet<PAY_PAYMENT> PAY_PAYMENT { get; set; }
        public DbSet<PAY_PAYMENT_REQUIREMENT> PAY_PAYMENT_REQUIREMENT { get; set; }
        public DbSet<PAY_PAYMENT_REQUIREMENT_TYPE> PAY_PAYMENT_REQUIREMENT_TYPE { get; set; }
        public DbSet<PAY_PRICING_ADJUSTMENT> PAY_PRICING_ADJUSTMENT { get; set; }
        public DbSet<PAY_PRICING_ADJUSTMENT_LINE_ITEM> PAY_PRICING_ADJUSTMENT_LINE_ITEM { get; set; }
        public DbSet<PAY_PRICING_ADJUSTMENT_ORDER> PAY_PRICING_ADJUSTMENT_ORDER { get; set; }
        public DbSet<PAY_PRICING_ADJUSTMENT_ORDER_SET> PAY_PRICING_ADJUSTMENT_ORDER_SET { get; set; }
        public DbSet<PAY_PRICING_ADJUSTMENT_TYPE> PAY_PRICING_ADJUSTMENT_TYPE { get; set; }
        public DbSet<PAY_PRICING_ITEM> PAY_PRICING_ITEM { get; set; }
        public DbSet<PAY_PROMOTION_CODE> PAY_PROMOTION_CODE { get; set; }
        public DbSet<PAY_TRANSACTION> PAY_TRANSACTION { get; set; }
        public DbSet<PAY_TRANSACTION_STATUS_TYPE> PAY_TRANSACTION_STATUS_TYPE { get; set; }
        public DbSet<PAY_TRANSACTION_TYPE> PAY_TRANSACTION_TYPE { get; set; }
        public DbSet<PREF_BY_TYPE> PREF_BY_TYPE { get; set; }
        public DbSet<PROMOTION_CODE> PROMOTION_CODE { get; set; }
        public DbSet<QUESTION_TEXT> QUESTION_TEXT { get; set; }
        public DbSet<REFERENCE> REFERENCEs { get; set; }
        public DbSet<REFERENCE_INSTANCE> REFERENCE_INSTANCE { get; set; }
        public DbSet<REFERENCE_INTERVIEW> REFERENCE_INTERVIEW { get; set; }
        public DbSet<REFERENCE_ITEM_LOV> REFERENCE_ITEM_LOV { get; set; }
        public DbSet<REFERENCE_QUESTION> REFERENCE_QUESTION { get; set; }
        public DbSet<REGISTRATION_ACTIVITY_DETAIL> REGISTRATION_ACTIVITY_DETAIL { get; set; }
        public DbSet<REGISTRATION_CUSTOM> REGISTRATION_CUSTOM { get; set; }
        public DbSet<REGISTRATION_CUSTOM_LOV> REGISTRATION_CUSTOM_LOV { get; set; }
        public DbSet<REGISTRATION_GROUP> REGISTRATION_GROUP { get; set; }
        public DbSet<REGISTRATION_INSTANCE> REGISTRATION_INSTANCE { get; set; }
        public DbSet<REGISTRATION_INSTANCE_PAYMENT> REGISTRATION_INSTANCE_PAYMENT { get; set; }
        public DbSet<REGISTRATION_ITEM> REGISTRATION_ITEM { get; set; }
        public DbSet<REGISTRATION_ITEM_LOV> REGISTRATION_ITEM_LOV { get; set; }
        public DbSet<REGISTRATION_ITEM_TYPE> REGISTRATION_ITEM_TYPE { get; set; }
        public DbSet<REGISTRATION_PAYMENT> REGISTRATION_PAYMENT { get; set; }
        public DbSet<REGISTRATION_PAYMENT_2> REGISTRATION_PAYMENT_2 { get; set; }
        public DbSet<REGISTRATION_PAYMENT_OPTION> REGISTRATION_PAYMENT_OPTION { get; set; }
        public DbSet<REGISTRATION_PAYMENT_TYPE> REGISTRATION_PAYMENT_TYPE { get; set; }
        public DbSet<REGISTRATION_STATUS> REGISTRATION_STATUS { get; set; }
        public DbSet<REQUIRED_ACTIVITY_ATTRIBUTE> REQUIRED_ACTIVITY_ATTRIBUTE { get; set; }
        public DbSet<RG_ACTIVITY_REGISTRATION> RG_ACTIVITY_REGISTRATION { get; set; }
        public DbSet<RG_ACTIVITY_REGISTRATION_SCHEDULE> RG_ACTIVITY_REGISTRATION_SCHEDULE { get; set; }
        public DbSet<RG_INDIVIDUAL_REGISTRATION> RG_INDIVIDUAL_REGISTRATION { get; set; }
        public DbSet<SECURE_CODE> SECURE_CODE { get; set; }
        public DbSet<SERIES_TOPIC> SERIES_TOPIC { get; set; }
        public DbSet<STAFFING_NEED> STAFFING_NEED { get; set; }
        public DbSet<STAFFING_PREF> STAFFING_PREF { get; set; }
        public DbSet<STAFFING_RECURRENCE> STAFFING_RECURRENCE { get; set; }
        public DbSet<STAFFING_SCHEDULE> STAFFING_SCHEDULE { get; set; }
        public DbSet<STAFFING_SCHEDULE_EDIT> STAFFING_SCHEDULE_EDIT { get; set; }
        public DbSet<TAG_DATA_FIELD> TAG_DATA_FIELD { get; set; }
        public DbSet<TAG_ITEM> TAG_ITEM { get; set; }
        public DbSet<TAG_LOGO> TAG_LOGO { get; set; }
        public DbSet<TAG_TEMPLATE> TAG_TEMPLATE { get; set; }
        public DbSet<TAG_TEMPLATE_ITEM> TAG_TEMPLATE_ITEM { get; set; }
        public DbSet<TEXT_ITEM> TEXT_ITEM { get; set; }
        public DbSet<THEME> THEMEs { get; set; }
        public DbSet<TRIGGER_CONFIG> TRIGGER_CONFIG { get; set; }
        public DbSet<VISITOR> VISITORs { get; set; }
        public DbSet<VOLUNTEER_APPLICATION> VOLUNTEER_APPLICATION { get; set; }
        public DbSet<VOLUNTEER_OPPORTUNITY> VOLUNTEER_OPPORTUNITY { get; set; }
        public DbSet<VOLUNTEER_OPPORTUNITY_INSTANCE> VOLUNTEER_OPPORTUNITY_INSTANCE { get; set; }
        public DbSet<VOLUNTEER_OPPORTUNITY_INSTANCE_ITEM> VOLUNTEER_OPPORTUNITY_INSTANCE_ITEM { get; set; }
        public DbSet<VOLUNTEER_OPPORTUNITY_INSTANCE_NOTE> VOLUNTEER_OPPORTUNITY_INSTANCE_NOTE { get; set; }
        public DbSet<VOLUNTEER_OPPORTUNITY_REFERENCE_ITEM> VOLUNTEER_OPPORTUNITY_REFERENCE_ITEM { get; set; }
        public DbSet<VOLUNTEER_OPPORTUNITY_REJECTION_NOTE> VOLUNTEER_OPPORTUNITY_REJECTION_NOTE { get; set; }
        public DbSet<VOLUNTEER_OPPORTUNITY_REQUIREMENT> VOLUNTEER_OPPORTUNITY_REQUIREMENT { get; set; }
        public DbSet<VOLUNTEER_OPPORTUNITY_STATUS> VOLUNTEER_OPPORTUNITY_STATUS { get; set; }
        public DbSet<VOLUNTEER_OPPORTUNITY_USER> VOLUNTEER_OPPORTUNITY_USER { get; set; }
        public DbSet<ATTENDANCE_HISTORY_VIEW> ATTENDANCE_HISTORY_VIEW { get; set; }
        public DbSet<INDIVIDUAL_INSTANCE_COUNTS_V> INDIVIDUAL_INSTANCE_COUNTS_V { get; set; }
        public DbSet<INDIVIDUAL_INSTANCE_HISTORY_V> INDIVIDUAL_INSTANCE_HISTORY_V { get; set; }
        public DbSet<LAST_ACTIVITY_INSTANCE_FOR_HOUSEHOLD_TEST> LAST_ACTIVITY_INSTANCE_FOR_HOUSEHOLD_TEST { get; set; }
        public DbSet<LAST_ACTIVITY_INSTANCE_FOR_HOUSEHOLD_V> LAST_ACTIVITY_INSTANCE_FOR_HOUSEHOLD_V { get; set; }
        public DbSet<MINISTRY_USER> MINISTRY_USER { get; set; }
        public DbSet<STAFFING_SCHEDULE_INSTANCE> STAFFING_SCHEDULE_INSTANCE { get; set; }
        public DbSet<STAFFING_SCHEDULE_INSTANCE2> STAFFING_SCHEDULE_INSTANCE2 { get; set; }
        public DbSet<syncobj_0x3030443943353933> syncobj_0x3030443943353933 { get; set; }
        public DbSet<syncobj_0x3032414231423941> syncobj_0x3032414231423941 { get; set; }
        public DbSet<syncobj_0x3037323741344334> syncobj_0x3037323741344334 { get; set; }
        public DbSet<syncobj_0x3037463042434430> syncobj_0x3037463042434430 { get; set; }
        public DbSet<syncobj_0x3039414332303843> syncobj_0x3039414332303843 { get; set; }
        public DbSet<syncobj_0x3041334230303239> syncobj_0x3041334230303239 { get; set; }
        public DbSet<syncobj_0x3041393642383039> syncobj_0x3041393642383039 { get; set; }
        public DbSet<syncobj_0x3131373341424637> syncobj_0x3131373341424637 { get; set; }
        public DbSet<syncobj_0x3132333539364141> syncobj_0x3132333539364141 { get; set; }
        public DbSet<syncobj_0x3135413731354535> syncobj_0x3135413731354535 { get; set; }
        public DbSet<syncobj_0x3137394244323541> syncobj_0x3137394244323541 { get; set; }
        public DbSet<syncobj_0x3141423145464242> syncobj_0x3141423145464242 { get; set; }
        public DbSet<syncobj_0x3141423639303244> syncobj_0x3141423639303244 { get; set; }
        public DbSet<syncobj_0x3144394535353943> syncobj_0x3144394535353943 { get; set; }
        public DbSet<syncobj_0x3144443731393838> syncobj_0x3144443731393838 { get; set; }
        public DbSet<syncobj_0x3146423031323132> syncobj_0x3146423031323132 { get; set; }
        public DbSet<syncobj_0x3230343535324543> syncobj_0x3230343535324543 { get; set; }
        public DbSet<syncobj_0x3239383033453136> syncobj_0x3239383033453136 { get; set; }
        public DbSet<syncobj_0x3245423836363436> syncobj_0x3245423836363436 { get; set; }
        public DbSet<syncobj_0x3330344646443139> syncobj_0x3330344646443139 { get; set; }
        public DbSet<syncobj_0x3331393638463337> syncobj_0x3331393638463337 { get; set; }
        public DbSet<syncobj_0x3331454143424430> syncobj_0x3331454143424430 { get; set; }
        public DbSet<syncobj_0x3333363631303832> syncobj_0x3333363631303832 { get; set; }
        public DbSet<syncobj_0x3337413442364242> syncobj_0x3337413442364242 { get; set; }
        public DbSet<syncobj_0x3338353532393431> syncobj_0x3338353532393431 { get; set; }
        public DbSet<syncobj_0x3342424141333438> syncobj_0x3342424141333438 { get; set; }
        public DbSet<syncobj_0x3346423833413431> syncobj_0x3346423833413431 { get; set; }
        public DbSet<syncobj_0x3430373230313239> syncobj_0x3430373230313239 { get; set; }
        public DbSet<syncobj_0x3431373441314537> syncobj_0x3431373441314537 { get; set; }
        public DbSet<syncobj_0x3432393232333731> syncobj_0x3432393232333731 { get; set; }
        public DbSet<syncobj_0x3433433333313343> syncobj_0x3433433333313343 { get; set; }
        public DbSet<syncobj_0x3434443233344334> syncobj_0x3434443233344334 { get; set; }
        public DbSet<syncobj_0x3444443238313142> syncobj_0x3444443238313142 { get; set; }
        public DbSet<syncobj_0x3445454641374145> syncobj_0x3445454641374145 { get; set; }
        public DbSet<syncobj_0x3446333441413636> syncobj_0x3446333441413636 { get; set; }
        public DbSet<syncobj_0x3530303043453236> syncobj_0x3530303043453236 { get; set; }
        public DbSet<syncobj_0x3530374342434137> syncobj_0x3530374342434137 { get; set; }
        public DbSet<syncobj_0x3538383334333533> syncobj_0x3538383334333533 { get; set; }
        public DbSet<syncobj_0x3538413941433933> syncobj_0x3538413941433933 { get; set; }
        public DbSet<syncobj_0x3545344532453346> syncobj_0x3545344532453346 { get; set; }
        public DbSet<syncobj_0x3545373631354444> syncobj_0x3545373631354444 { get; set; }
        public DbSet<syncobj_0x3630443630373230> syncobj_0x3630443630373230 { get; set; }
        public DbSet<syncobj_0x3633343230313241> syncobj_0x3633343230313241 { get; set; }
        public DbSet<syncobj_0x3633363434443137> syncobj_0x3633363434443137 { get; set; }
        public DbSet<syncobj_0x3634364543454330> syncobj_0x3634364543454330 { get; set; }
        public DbSet<syncobj_0x3635343632423642> syncobj_0x3635343632423642 { get; set; }
        public DbSet<syncobj_0x3635373739433137> syncobj_0x3635373739433137 { get; set; }
        public DbSet<syncobj_0x3636433230443546> syncobj_0x3636433230443546 { get; set; }
        public DbSet<syncobj_0x3642313430323145> syncobj_0x3642313430323145 { get; set; }
        public DbSet<syncobj_0x3731323836343535> syncobj_0x3731323836343535 { get; set; }
        public DbSet<syncobj_0x3733353342313444> syncobj_0x3733353342313444 { get; set; }
        public DbSet<syncobj_0x3733363633333632> syncobj_0x3733363633333632 { get; set; }
        public DbSet<syncobj_0x3735323032433842> syncobj_0x3735323032433842 { get; set; }
        public DbSet<syncobj_0x3736374641393338> syncobj_0x3736374641393338 { get; set; }
        public DbSet<syncobj_0x3737334543413737> syncobj_0x3737334543413737 { get; set; }
        public DbSet<syncobj_0x3741413843413742> syncobj_0x3741413843413742 { get; set; }
        public DbSet<syncobj_0x3742383445313738> syncobj_0x3742383445313738 { get; set; }
        public DbSet<syncobj_0x3742464633464136> syncobj_0x3742464633464136 { get; set; }
        public DbSet<syncobj_0x3743394445354337> syncobj_0x3743394445354337 { get; set; }
        public DbSet<syncobj_0x3745383342334430> syncobj_0x3745383342334430 { get; set; }
        public DbSet<syncobj_0x3831354236444330> syncobj_0x3831354236444330 { get; set; }
        public DbSet<syncobj_0x3833393131324443> syncobj_0x3833393131324443 { get; set; }
        public DbSet<syncobj_0x3836413735414236> syncobj_0x3836413735414236 { get; set; }
        public DbSet<syncobj_0x3837363943313431> syncobj_0x3837363943313431 { get; set; }
        public DbSet<syncobj_0x3839393036393835> syncobj_0x3839393036393835 { get; set; }
        public DbSet<syncobj_0x3846463245364430> syncobj_0x3846463245364430 { get; set; }
        public DbSet<syncobj_0x3930444632324330> syncobj_0x3930444632324330 { get; set; }
        public DbSet<syncobj_0x3931353939304544> syncobj_0x3931353939304544 { get; set; }
        public DbSet<syncobj_0x3939304446303644> syncobj_0x3939304446303644 { get; set; }
        public DbSet<syncobj_0x3942343344383233> syncobj_0x3942343344383233 { get; set; }
        public DbSet<syncobj_0x3942434134363038> syncobj_0x3942434134363038 { get; set; }
        public DbSet<syncobj_0x3943394343443546> syncobj_0x3943394343443546 { get; set; }
        public DbSet<syncobj_0x3944463438373645> syncobj_0x3944463438373645 { get; set; }
        public DbSet<syncobj_0x4131363332373536> syncobj_0x4131363332373536 { get; set; }
        public DbSet<syncobj_0x4131363541393745> syncobj_0x4131363541393745 { get; set; }
        public DbSet<syncobj_0x4131413038393333> syncobj_0x4131413038393333 { get; set; }
        public DbSet<syncobj_0x4135393734364246> syncobj_0x4135393734364246 { get; set; }
        public DbSet<syncobj_0x4136313735383143> syncobj_0x4136313735383143 { get; set; }
        public DbSet<syncobj_0x4136373331343234> syncobj_0x4136373331343234 { get; set; }
        public DbSet<syncobj_0x4138374339393243> syncobj_0x4138374339393243 { get; set; }
        public DbSet<syncobj_0x4144364238373337> syncobj_0x4144364238373337 { get; set; }
        public DbSet<syncobj_0x4146353038323545> syncobj_0x4146353038323545 { get; set; }
        public DbSet<syncobj_0x4235323737343041> syncobj_0x4235323737343041 { get; set; }
        public DbSet<syncobj_0x4235453632374243> syncobj_0x4235453632374243 { get; set; }
        public DbSet<syncobj_0x4236433941393233> syncobj_0x4236433941393233 { get; set; }
        public DbSet<syncobj_0x4241434236413538> syncobj_0x4241434236413538 { get; set; }
        public DbSet<syncobj_0x4242453445363334> syncobj_0x4242453445363334 { get; set; }
        public DbSet<syncobj_0x4246333136463232> syncobj_0x4246333136463232 { get; set; }
        public DbSet<syncobj_0x4330393534304246> syncobj_0x4330393534304246 { get; set; }
        public DbSet<syncobj_0x4332383443343437> syncobj_0x4332383443343437 { get; set; }
        public DbSet<syncobj_0x4333383439333841> syncobj_0x4333383439333841 { get; set; }
        public DbSet<syncobj_0x4336344335393631> syncobj_0x4336344335393631 { get; set; }
        public DbSet<syncobj_0x4337303245454232> syncobj_0x4337303245454232 { get; set; }
        public DbSet<syncobj_0x4341413446463839> syncobj_0x4341413446463839 { get; set; }
        public DbSet<syncobj_0x4342303142334333> syncobj_0x4342303142334333 { get; set; }
        public DbSet<syncobj_0x4343304138463538> syncobj_0x4343304138463538 { get; set; }
        public DbSet<syncobj_0x4343464432374534> syncobj_0x4343464432374534 { get; set; }
        public DbSet<syncobj_0x4344353042424546> syncobj_0x4344353042424546 { get; set; }
        public DbSet<syncobj_0x4345314337353141> syncobj_0x4345314337353141 { get; set; }
        public DbSet<syncobj_0x4346363742363846> syncobj_0x4346363742363846 { get; set; }
        public DbSet<syncobj_0x4431433133353345> syncobj_0x4431433133353345 { get; set; }
        public DbSet<syncobj_0x4435324536423239> syncobj_0x4435324536423239 { get; set; }
        public DbSet<syncobj_0x4437303733393732> syncobj_0x4437303733393732 { get; set; }
        public DbSet<syncobj_0x4437354430324337> syncobj_0x4437354430324337 { get; set; }
        public DbSet<syncobj_0x4438393646343643> syncobj_0x4438393646343643 { get; set; }
        public DbSet<syncobj_0x4439393838433436> syncobj_0x4439393838433436 { get; set; }
        public DbSet<syncobj_0x4444314634333537> syncobj_0x4444314634333537 { get; set; }
        public DbSet<syncobj_0x4445364136453237> syncobj_0x4445364136453237 { get; set; }
        public DbSet<syncobj_0x4446383936324646> syncobj_0x4446383936324646 { get; set; }
        public DbSet<syncobj_0x4446434332384236> syncobj_0x4446434332384236 { get; set; }
        public DbSet<syncobj_0x4533393931374336> syncobj_0x4533393931374336 { get; set; }
        public DbSet<syncobj_0x4534333641463131> syncobj_0x4534333641463131 { get; set; }
        public DbSet<syncobj_0x4535333933344335> syncobj_0x4535333933344335 { get; set; }
        public DbSet<syncobj_0x4539424543393636> syncobj_0x4539424543393636 { get; set; }
        public DbSet<syncobj_0x4542413737424435> syncobj_0x4542413737424435 { get; set; }
        public DbSet<syncobj_0x4631323442334233> syncobj_0x4631323442334233 { get; set; }
        public DbSet<syncobj_0x4632353735373139> syncobj_0x4632353735373139 { get; set; }
        public DbSet<syncobj_0x4633314346463736> syncobj_0x4633314346463736 { get; set; }
        public DbSet<syncobj_0x4636384237393942> syncobj_0x4636384237393942 { get; set; }
        public DbSet<syncobj_0x4644383232374341> syncobj_0x4644383232374341 { get; set; }
        public DbSet<syncobj_0x4644464634394638> syncobj_0x4644464634394638 { get; set; }
        public DbSet<vw_ActivityMinistryRLC> vw_ActivityMinistryRLC { get; set; }
        public DbSet<vw_MismatchedActivityTimes> vw_MismatchedActivityTimes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new C__RefactorLogMap());
            modelBuilder.Configurations.Add(new ACTIVE_CHECKINMap());
            modelBuilder.Configurations.Add(new Active_Checkin_HistoryMap());
            modelBuilder.Configurations.Add(new ACTIVE_DETAIL_CHECKINMap());
            modelBuilder.Configurations.Add(new Active_Detail_Checkin_HistoryMap());
            modelBuilder.Configurations.Add(new ACTIVITYMap());
            modelBuilder.Configurations.Add(new ACTIVITY_ATTRIBUTEMap());
            modelBuilder.Configurations.Add(new ACTIVITY_DETAILMap());
            modelBuilder.Configurations.Add(new ACTIVITY_DETAIL_ATTRIBUTEMap());
            modelBuilder.Configurations.Add(new ACTIVITY_DETAIL_INSTANCEMap());
            modelBuilder.Configurations.Add(new ACTIVITY_DETAIL_INSTANCE_ATTRIBUTEMap());
            modelBuilder.Configurations.Add(new ACTIVITY_EXPERIENCEMap());
            modelBuilder.Configurations.Add(new ACTIVITY_EXPERIENCE_REQUIREMENTMap());
            modelBuilder.Configurations.Add(new ACTIVITY_GROUPMap());
            modelBuilder.Configurations.Add(new ACTIVITY_INSTANCEMap());
            modelBuilder.Configurations.Add(new ACTIVITY_INSTANCE_ATTRIBUTEMap());
            modelBuilder.Configurations.Add(new activity_instance_date_helperMap());
            modelBuilder.Configurations.Add(new ACTIVITY_MINISTRYMap());
            modelBuilder.Configurations.Add(new ACTIVITY_PROPERTYMap());
            modelBuilder.Configurations.Add(new ACTIVITY_PROPERTY_ACTIVITY_DETAILMap());
            modelBuilder.Configurations.Add(new ACTIVITY_PROPERTY_LOVMap());
            modelBuilder.Configurations.Add(new ACTIVITY_RECURRENCEMap());
            modelBuilder.Configurations.Add(new ACTIVITY_REGISTRATIONMap());
            modelBuilder.Configurations.Add(new ACTIVITY_REGISTRATION_ACTIVITY_INSTANCEMap());
            modelBuilder.Configurations.Add(new ACTIVITY_REGISTRATION_ACTIVITY_TIMEMap());
            modelBuilder.Configurations.Add(new ACTIVITY_REGISTRATION_JOINMap());
            modelBuilder.Configurations.Add(new ACTIVITY_REQUIREMENTMap());
            modelBuilder.Configurations.Add(new ACTIVITY_SERIESMap());
            modelBuilder.Configurations.Add(new ACTIVITY_TAGMap());
            modelBuilder.Configurations.Add(new ACTIVITY_TIMEMap());
            modelBuilder.Configurations.Add(new ACTIVITY_TIME_ACTIVITY_INSTANCEMap());
            modelBuilder.Configurations.Add(new ACTIVITY_TYPEMap());
            modelBuilder.Configurations.Add(new ACTIVITY_TYPE_ACTIVITYMap());
            modelBuilder.Configurations.Add(new AssignmentHistoryMap());
            modelBuilder.Configurations.Add(new AUTOMATIC_ATTENDANCE_RULEMap());
            modelBuilder.Configurations.Add(new CHECK_IN_MACHINEMap());
            modelBuilder.Configurations.Add(new CHURCH_SECURE_CODEMap());
            modelBuilder.Configurations.Add(new COLOR_SETMap());
            modelBuilder.Configurations.Add(new COLOR_SET_ELEMENTMap());
            modelBuilder.Configurations.Add(new COMMONCCMap());
            modelBuilder.Configurations.Add(new COMMONCHECKMap());
            modelBuilder.Configurations.Add(new CTRL_DATE_TABLEMap());
            modelBuilder.Configurations.Add(new CURRENCY_ITEMMap());
            modelBuilder.Configurations.Add(new DATA_TYPEMap());
            modelBuilder.Configurations.Add(new DATA_TYPE_VALIDATION_EXPRESSION_TYPEMap());
            modelBuilder.Configurations.Add(new Date_Range_TypeMap());
            modelBuilder.Configurations.Add(new dtpropertyMap());
            modelBuilder.Configurations.Add(new ELEMENTMap());
            modelBuilder.Configurations.Add(new EMAIL_MESSAGEMap());
            modelBuilder.Configurations.Add(new FORMMap());
            modelBuilder.Configurations.Add(new FORM_HEADERMap());
            modelBuilder.Configurations.Add(new FORM_INDIVIDUALMap());
            modelBuilder.Configurations.Add(new FORM_INDIVIDUAL_SETMap());
            modelBuilder.Configurations.Add(new FORM_INDIVIDUAL_SET_NOTEMap());
            modelBuilder.Configurations.Add(new FORM_INDIVIDUAL_STATUS_TYPEMap());
            modelBuilder.Configurations.Add(new FORM_ITEMMap());
            modelBuilder.Configurations.Add(new FORM_ITEM_OPTIONMap());
            modelBuilder.Configurations.Add(new FORM_ITEM_OPTION_INDIVIDUALMap());
            modelBuilder.Configurations.Add(new FORM_ITEM_TEXTMap());
            modelBuilder.Configurations.Add(new FORM_ITEM_TEXT_INDIVIDUALMap());
            modelBuilder.Configurations.Add(new FORM_ITEM_TYPEMap());
            modelBuilder.Configurations.Add(new FORM_PAGEMap());
            modelBuilder.Configurations.Add(new FORM_PROMOTION_CODEMap());
            modelBuilder.Configurations.Add(new FORM_RELATIONSHIPMap());
            modelBuilder.Configurations.Add(new FORM_RELATIONSHIP_TYPEMap());
            modelBuilder.Configurations.Add(new FORM_TYPEMap());
            modelBuilder.Configurations.Add(new FREQ_TAG_COMMENTMap());
            modelBuilder.Configurations.Add(new GFT_JOBMap());
            modelBuilder.Configurations.Add(new GFT_JOB_ATTRIBUTEMap());
            modelBuilder.Configurations.Add(new GFT_JOB_CATEGORYMap());
            modelBuilder.Configurations.Add(new GLOBAL_ACTIVITYMap());
            modelBuilder.Configurations.Add(new GLOBAL_ACTIVITY_TIMEMap());
            modelBuilder.Configurations.Add(new GLOBAL_MINISTRYMap());
            modelBuilder.Configurations.Add(new HOUSEHOLD_ATTENDANCEMap());
            modelBuilder.Configurations.Add(new INDIVIDUAL_CUSTOM_REGISTRATIONMap());
            modelBuilder.Configurations.Add(new INDIVIDUAL_GROUPMap());
            modelBuilder.Configurations.Add(new INDIVIDUAL_INSTANCEMap());
            modelBuilder.Configurations.Add(new INDIVIDUAL_INSTANCE_HISTORYMap());
            modelBuilder.Configurations.Add(new INDIVIDUAL_PAYMENTMap());
            modelBuilder.Configurations.Add(new INDIVIDUAL_PAYMENT_REFUNDMap());
            modelBuilder.Configurations.Add(new INDIVIDUAL_PREFSMap());
            modelBuilder.Configurations.Add(new INDIVIDUAL_REGISTRATIONMap());
            modelBuilder.Configurations.Add(new INDIVIDUAL_REGISTRATION_2Map());
            modelBuilder.Configurations.Add(new INDIVIDUAL_REGISTRATION_ITEMMap());
            modelBuilder.Configurations.Add(new INDIVIDUAL_REGISTRATION_ITEM_LOVMap());
            modelBuilder.Configurations.Add(new INDIVIDUAL_TYPEMap());
            modelBuilder.Configurations.Add(new INDIVIDUAL_TYPE_GROUPMap());
            modelBuilder.Configurations.Add(new INTEGER_ITEMMap());
            modelBuilder.Configurations.Add(new JOBMap());
            modelBuilder.Configurations.Add(new JOB_ATTRIBUTEMap());
            modelBuilder.Configurations.Add(new JOB_ATTRIBUTE_GROUPMap());
            modelBuilder.Configurations.Add(new JOB_INFORMATIONMap());
            modelBuilder.Configurations.Add(new JOB_JOB_ATTRIBUTEMap());
            modelBuilder.Configurations.Add(new JOB_JOB_INFORMATIONMap());
            modelBuilder.Configurations.Add(new JOB_MARITAL_STATUSMap());
            modelBuilder.Configurations.Add(new JOB_REQUIREMENTMap());
            modelBuilder.Configurations.Add(new JOB_STATUS_RESTRICTIONMap());
            modelBuilder.Configurations.Add(new LifeChurch_Activity_WhitelistMap());
            modelBuilder.Configurations.Add(new MINISTRYMap());
            modelBuilder.Configurations.Add(new ministry_user_backupMap());
            modelBuilder.Configurations.Add(new MULTIPLE_DISCOUNTMap());
            modelBuilder.Configurations.Add(new OPTION_TABLEMap());
            modelBuilder.Configurations.Add(new PAY_ITEMMap());
            modelBuilder.Configurations.Add(new PAY_ITEM_DETAILMap());
            modelBuilder.Configurations.Add(new PAY_ITEM_FORMMap());
            modelBuilder.Configurations.Add(new PAY_ITEM_FORM_ITEM_OPTIONMap());
            modelBuilder.Configurations.Add(new PAY_ITEM_TYPEMap());
            modelBuilder.Configurations.Add(new PAY_LINE_ITEMMap());
            modelBuilder.Configurations.Add(new PAY_ORDERMap());
            modelBuilder.Configurations.Add(new PAY_ORDER_SETMap());
            modelBuilder.Configurations.Add(new PAY_ORDER_STATUS_TYPEMap());
            modelBuilder.Configurations.Add(new PAY_PAYMENTMap());
            modelBuilder.Configurations.Add(new PAY_PAYMENT_REQUIREMENTMap());
            modelBuilder.Configurations.Add(new PAY_PAYMENT_REQUIREMENT_TYPEMap());
            modelBuilder.Configurations.Add(new PAY_PRICING_ADJUSTMENTMap());
            modelBuilder.Configurations.Add(new PAY_PRICING_ADJUSTMENT_LINE_ITEMMap());
            modelBuilder.Configurations.Add(new PAY_PRICING_ADJUSTMENT_ORDERMap());
            modelBuilder.Configurations.Add(new PAY_PRICING_ADJUSTMENT_ORDER_SETMap());
            modelBuilder.Configurations.Add(new PAY_PRICING_ADJUSTMENT_TYPEMap());
            modelBuilder.Configurations.Add(new PAY_PRICING_ITEMMap());
            modelBuilder.Configurations.Add(new PAY_PROMOTION_CODEMap());
            modelBuilder.Configurations.Add(new PAY_TRANSACTIONMap());
            modelBuilder.Configurations.Add(new PAY_TRANSACTION_STATUS_TYPEMap());
            modelBuilder.Configurations.Add(new PAY_TRANSACTION_TYPEMap());
            modelBuilder.Configurations.Add(new PREF_BY_TYPEMap());
            modelBuilder.Configurations.Add(new PROMOTION_CODEMap());
            modelBuilder.Configurations.Add(new QUESTION_TEXTMap());
            modelBuilder.Configurations.Add(new REFERENCEMap());
            modelBuilder.Configurations.Add(new REFERENCE_INSTANCEMap());
            modelBuilder.Configurations.Add(new REFERENCE_INTERVIEWMap());
            modelBuilder.Configurations.Add(new REFERENCE_ITEM_LOVMap());
            modelBuilder.Configurations.Add(new REFERENCE_QUESTIONMap());
            modelBuilder.Configurations.Add(new REGISTRATION_ACTIVITY_DETAILMap());
            modelBuilder.Configurations.Add(new REGISTRATION_CUSTOMMap());
            modelBuilder.Configurations.Add(new REGISTRATION_CUSTOM_LOVMap());
            modelBuilder.Configurations.Add(new REGISTRATION_GROUPMap());
            modelBuilder.Configurations.Add(new REGISTRATION_INSTANCEMap());
            modelBuilder.Configurations.Add(new REGISTRATION_INSTANCE_PAYMENTMap());
            modelBuilder.Configurations.Add(new REGISTRATION_ITEMMap());
            modelBuilder.Configurations.Add(new REGISTRATION_ITEM_LOVMap());
            modelBuilder.Configurations.Add(new REGISTRATION_ITEM_TYPEMap());
            modelBuilder.Configurations.Add(new REGISTRATION_PAYMENTMap());
            modelBuilder.Configurations.Add(new REGISTRATION_PAYMENT_2Map());
            modelBuilder.Configurations.Add(new REGISTRATION_PAYMENT_OPTIONMap());
            modelBuilder.Configurations.Add(new REGISTRATION_PAYMENT_TYPEMap());
            modelBuilder.Configurations.Add(new REGISTRATION_STATUSMap());
            modelBuilder.Configurations.Add(new REQUIRED_ACTIVITY_ATTRIBUTEMap());
            modelBuilder.Configurations.Add(new RG_ACTIVITY_REGISTRATIONMap());
            modelBuilder.Configurations.Add(new RG_ACTIVITY_REGISTRATION_SCHEDULEMap());
            modelBuilder.Configurations.Add(new RG_INDIVIDUAL_REGISTRATIONMap());
            modelBuilder.Configurations.Add(new SECURE_CODEMap());
            modelBuilder.Configurations.Add(new SERIES_TOPICMap());
            modelBuilder.Configurations.Add(new STAFFING_NEEDMap());
            modelBuilder.Configurations.Add(new STAFFING_PREFMap());
            modelBuilder.Configurations.Add(new STAFFING_RECURRENCEMap());
            modelBuilder.Configurations.Add(new STAFFING_SCHEDULEMap());
            modelBuilder.Configurations.Add(new STAFFING_SCHEDULE_EDITMap());
            modelBuilder.Configurations.Add(new TAG_DATA_FIELDMap());
            modelBuilder.Configurations.Add(new TAG_ITEMMap());
            modelBuilder.Configurations.Add(new TAG_LOGOMap());
            modelBuilder.Configurations.Add(new TAG_TEMPLATEMap());
            modelBuilder.Configurations.Add(new TAG_TEMPLATE_ITEMMap());
            modelBuilder.Configurations.Add(new TEXT_ITEMMap());
            modelBuilder.Configurations.Add(new THEMEMap());
            modelBuilder.Configurations.Add(new TRIGGER_CONFIGMap());
            modelBuilder.Configurations.Add(new VISITORMap());
            modelBuilder.Configurations.Add(new VOLUNTEER_APPLICATIONMap());
            modelBuilder.Configurations.Add(new VOLUNTEER_OPPORTUNITYMap());
            modelBuilder.Configurations.Add(new VOLUNTEER_OPPORTUNITY_INSTANCEMap());
            modelBuilder.Configurations.Add(new VOLUNTEER_OPPORTUNITY_INSTANCE_ITEMMap());
            modelBuilder.Configurations.Add(new VOLUNTEER_OPPORTUNITY_INSTANCE_NOTEMap());
            modelBuilder.Configurations.Add(new VOLUNTEER_OPPORTUNITY_REFERENCE_ITEMMap());
            modelBuilder.Configurations.Add(new VOLUNTEER_OPPORTUNITY_REJECTION_NOTEMap());
            modelBuilder.Configurations.Add(new VOLUNTEER_OPPORTUNITY_REQUIREMENTMap());
            modelBuilder.Configurations.Add(new VOLUNTEER_OPPORTUNITY_STATUSMap());
            modelBuilder.Configurations.Add(new VOLUNTEER_OPPORTUNITY_USERMap());
            modelBuilder.Configurations.Add(new ATTENDANCE_HISTORY_VIEWMap());
            modelBuilder.Configurations.Add(new INDIVIDUAL_INSTANCE_COUNTS_VMap());
            modelBuilder.Configurations.Add(new INDIVIDUAL_INSTANCE_HISTORY_VMap());
            modelBuilder.Configurations.Add(new LAST_ACTIVITY_INSTANCE_FOR_HOUSEHOLD_TESTMap());
            modelBuilder.Configurations.Add(new LAST_ACTIVITY_INSTANCE_FOR_HOUSEHOLD_VMap());
            modelBuilder.Configurations.Add(new MINISTRY_USERMap());
            modelBuilder.Configurations.Add(new STAFFING_SCHEDULE_INSTANCEMap());
            modelBuilder.Configurations.Add(new STAFFING_SCHEDULE_INSTANCE2Map());
            modelBuilder.Configurations.Add(new syncobj_0x3030443943353933Map());
            modelBuilder.Configurations.Add(new syncobj_0x3032414231423941Map());
            modelBuilder.Configurations.Add(new syncobj_0x3037323741344334Map());
            modelBuilder.Configurations.Add(new syncobj_0x3037463042434430Map());
            modelBuilder.Configurations.Add(new syncobj_0x3039414332303843Map());
            modelBuilder.Configurations.Add(new syncobj_0x3041334230303239Map());
            modelBuilder.Configurations.Add(new syncobj_0x3041393642383039Map());
            modelBuilder.Configurations.Add(new syncobj_0x3131373341424637Map());
            modelBuilder.Configurations.Add(new syncobj_0x3132333539364141Map());
            modelBuilder.Configurations.Add(new syncobj_0x3135413731354535Map());
            modelBuilder.Configurations.Add(new syncobj_0x3137394244323541Map());
            modelBuilder.Configurations.Add(new syncobj_0x3141423145464242Map());
            modelBuilder.Configurations.Add(new syncobj_0x3141423639303244Map());
            modelBuilder.Configurations.Add(new syncobj_0x3144394535353943Map());
            modelBuilder.Configurations.Add(new syncobj_0x3144443731393838Map());
            modelBuilder.Configurations.Add(new syncobj_0x3146423031323132Map());
            modelBuilder.Configurations.Add(new syncobj_0x3230343535324543Map());
            modelBuilder.Configurations.Add(new syncobj_0x3239383033453136Map());
            modelBuilder.Configurations.Add(new syncobj_0x3245423836363436Map());
            modelBuilder.Configurations.Add(new syncobj_0x3330344646443139Map());
            modelBuilder.Configurations.Add(new syncobj_0x3331393638463337Map());
            modelBuilder.Configurations.Add(new syncobj_0x3331454143424430Map());
            modelBuilder.Configurations.Add(new syncobj_0x3333363631303832Map());
            modelBuilder.Configurations.Add(new syncobj_0x3337413442364242Map());
            modelBuilder.Configurations.Add(new syncobj_0x3338353532393431Map());
            modelBuilder.Configurations.Add(new syncobj_0x3342424141333438Map());
            modelBuilder.Configurations.Add(new syncobj_0x3346423833413431Map());
            modelBuilder.Configurations.Add(new syncobj_0x3430373230313239Map());
            modelBuilder.Configurations.Add(new syncobj_0x3431373441314537Map());
            modelBuilder.Configurations.Add(new syncobj_0x3432393232333731Map());
            modelBuilder.Configurations.Add(new syncobj_0x3433433333313343Map());
            modelBuilder.Configurations.Add(new syncobj_0x3434443233344334Map());
            modelBuilder.Configurations.Add(new syncobj_0x3444443238313142Map());
            modelBuilder.Configurations.Add(new syncobj_0x3445454641374145Map());
            modelBuilder.Configurations.Add(new syncobj_0x3446333441413636Map());
            modelBuilder.Configurations.Add(new syncobj_0x3530303043453236Map());
            modelBuilder.Configurations.Add(new syncobj_0x3530374342434137Map());
            modelBuilder.Configurations.Add(new syncobj_0x3538383334333533Map());
            modelBuilder.Configurations.Add(new syncobj_0x3538413941433933Map());
            modelBuilder.Configurations.Add(new syncobj_0x3545344532453346Map());
            modelBuilder.Configurations.Add(new syncobj_0x3545373631354444Map());
            modelBuilder.Configurations.Add(new syncobj_0x3630443630373230Map());
            modelBuilder.Configurations.Add(new syncobj_0x3633343230313241Map());
            modelBuilder.Configurations.Add(new syncobj_0x3633363434443137Map());
            modelBuilder.Configurations.Add(new syncobj_0x3634364543454330Map());
            modelBuilder.Configurations.Add(new syncobj_0x3635343632423642Map());
            modelBuilder.Configurations.Add(new syncobj_0x3635373739433137Map());
            modelBuilder.Configurations.Add(new syncobj_0x3636433230443546Map());
            modelBuilder.Configurations.Add(new syncobj_0x3642313430323145Map());
            modelBuilder.Configurations.Add(new syncobj_0x3731323836343535Map());
            modelBuilder.Configurations.Add(new syncobj_0x3733353342313444Map());
            modelBuilder.Configurations.Add(new syncobj_0x3733363633333632Map());
            modelBuilder.Configurations.Add(new syncobj_0x3735323032433842Map());
            modelBuilder.Configurations.Add(new syncobj_0x3736374641393338Map());
            modelBuilder.Configurations.Add(new syncobj_0x3737334543413737Map());
            modelBuilder.Configurations.Add(new syncobj_0x3741413843413742Map());
            modelBuilder.Configurations.Add(new syncobj_0x3742383445313738Map());
            modelBuilder.Configurations.Add(new syncobj_0x3742464633464136Map());
            modelBuilder.Configurations.Add(new syncobj_0x3743394445354337Map());
            modelBuilder.Configurations.Add(new syncobj_0x3745383342334430Map());
            modelBuilder.Configurations.Add(new syncobj_0x3831354236444330Map());
            modelBuilder.Configurations.Add(new syncobj_0x3833393131324443Map());
            modelBuilder.Configurations.Add(new syncobj_0x3836413735414236Map());
            modelBuilder.Configurations.Add(new syncobj_0x3837363943313431Map());
            modelBuilder.Configurations.Add(new syncobj_0x3839393036393835Map());
            modelBuilder.Configurations.Add(new syncobj_0x3846463245364430Map());
            modelBuilder.Configurations.Add(new syncobj_0x3930444632324330Map());
            modelBuilder.Configurations.Add(new syncobj_0x3931353939304544Map());
            modelBuilder.Configurations.Add(new syncobj_0x3939304446303644Map());
            modelBuilder.Configurations.Add(new syncobj_0x3942343344383233Map());
            modelBuilder.Configurations.Add(new syncobj_0x3942434134363038Map());
            modelBuilder.Configurations.Add(new syncobj_0x3943394343443546Map());
            modelBuilder.Configurations.Add(new syncobj_0x3944463438373645Map());
            modelBuilder.Configurations.Add(new syncobj_0x4131363332373536Map());
            modelBuilder.Configurations.Add(new syncobj_0x4131363541393745Map());
            modelBuilder.Configurations.Add(new syncobj_0x4131413038393333Map());
            modelBuilder.Configurations.Add(new syncobj_0x4135393734364246Map());
            modelBuilder.Configurations.Add(new syncobj_0x4136313735383143Map());
            modelBuilder.Configurations.Add(new syncobj_0x4136373331343234Map());
            modelBuilder.Configurations.Add(new syncobj_0x4138374339393243Map());
            modelBuilder.Configurations.Add(new syncobj_0x4144364238373337Map());
            modelBuilder.Configurations.Add(new syncobj_0x4146353038323545Map());
            modelBuilder.Configurations.Add(new syncobj_0x4235323737343041Map());
            modelBuilder.Configurations.Add(new syncobj_0x4235453632374243Map());
            modelBuilder.Configurations.Add(new syncobj_0x4236433941393233Map());
            modelBuilder.Configurations.Add(new syncobj_0x4241434236413538Map());
            modelBuilder.Configurations.Add(new syncobj_0x4242453445363334Map());
            modelBuilder.Configurations.Add(new syncobj_0x4246333136463232Map());
            modelBuilder.Configurations.Add(new syncobj_0x4330393534304246Map());
            modelBuilder.Configurations.Add(new syncobj_0x4332383443343437Map());
            modelBuilder.Configurations.Add(new syncobj_0x4333383439333841Map());
            modelBuilder.Configurations.Add(new syncobj_0x4336344335393631Map());
            modelBuilder.Configurations.Add(new syncobj_0x4337303245454232Map());
            modelBuilder.Configurations.Add(new syncobj_0x4341413446463839Map());
            modelBuilder.Configurations.Add(new syncobj_0x4342303142334333Map());
            modelBuilder.Configurations.Add(new syncobj_0x4343304138463538Map());
            modelBuilder.Configurations.Add(new syncobj_0x4343464432374534Map());
            modelBuilder.Configurations.Add(new syncobj_0x4344353042424546Map());
            modelBuilder.Configurations.Add(new syncobj_0x4345314337353141Map());
            modelBuilder.Configurations.Add(new syncobj_0x4346363742363846Map());
            modelBuilder.Configurations.Add(new syncobj_0x4431433133353345Map());
            modelBuilder.Configurations.Add(new syncobj_0x4435324536423239Map());
            modelBuilder.Configurations.Add(new syncobj_0x4437303733393732Map());
            modelBuilder.Configurations.Add(new syncobj_0x4437354430324337Map());
            modelBuilder.Configurations.Add(new syncobj_0x4438393646343643Map());
            modelBuilder.Configurations.Add(new syncobj_0x4439393838433436Map());
            modelBuilder.Configurations.Add(new syncobj_0x4444314634333537Map());
            modelBuilder.Configurations.Add(new syncobj_0x4445364136453237Map());
            modelBuilder.Configurations.Add(new syncobj_0x4446383936324646Map());
            modelBuilder.Configurations.Add(new syncobj_0x4446434332384236Map());
            modelBuilder.Configurations.Add(new syncobj_0x4533393931374336Map());
            modelBuilder.Configurations.Add(new syncobj_0x4534333641463131Map());
            modelBuilder.Configurations.Add(new syncobj_0x4535333933344335Map());
            modelBuilder.Configurations.Add(new syncobj_0x4539424543393636Map());
            modelBuilder.Configurations.Add(new syncobj_0x4542413737424435Map());
            modelBuilder.Configurations.Add(new syncobj_0x4631323442334233Map());
            modelBuilder.Configurations.Add(new syncobj_0x4632353735373139Map());
            modelBuilder.Configurations.Add(new syncobj_0x4633314346463736Map());
            modelBuilder.Configurations.Add(new syncobj_0x4636384237393942Map());
            modelBuilder.Configurations.Add(new syncobj_0x4644383232374341Map());
            modelBuilder.Configurations.Add(new syncobj_0x4644464634394638Map());
            modelBuilder.Configurations.Add(new vw_ActivityMinistryRLCMap());
            modelBuilder.Configurations.Add(new vw_MismatchedActivityTimesMap());
        }
    }
}
