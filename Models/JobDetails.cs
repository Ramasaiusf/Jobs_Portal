namespace Jobs_Portal.Models
{
    public class JobDetails
    {
        public string job_id { get; set; }
        public string agency { get; set; }
        public string posting_type { get; set; }
        public string number_of_positions { get; set; }
        public string business_title { get; set; }
        public string civil_service_title { get; set; }
        public string title_classification { get; set; }
        public string title_code_no { get; set; }
        public string level { get; set; }
        public string job_category { get; set; }
        public string full_time_part_time_indicator { get; set; }
        public string career_level { get; set; }
        public string salary_range_from { get; set; }
        public string salary_range_to { get; set; }
        public string salary_frequency { get; set; }
        public string work_location { get; set; }
        public string division_work_unit { get; set; }
        public string job_description { get; set; }
        public string minimum_qual_requirements { get; set; }
        public string preferred_skills { get; set; }
        public string additional_information { get; set; }
        public string to_apply { get; set; }
        public string residency_requirement { get; set; }
        public DateTime posting_date { get; set; }
        public DateTime posting_updated { get; set; }
        public DateTime process_date { get; set; }
    }
    

}
