INSERT INTO Title (BusinessTitle, TitleClassification, CivilServiceTitle)
VALUES
    ('Manager', 'Management', 'Executive Manager'),
    ('Developer', 'Information Technology', 'Software Developer'),
    ('Analyst', 'Finance', 'Financial Analyst'),
    ('Engineer', 'Engineering', 'Software Engineer'),
    ('Designer', 'Creative', 'Graphic Designer');

INSERT INTO Level (CareerLevel, JobCategory)
VALUES
    ('Entry Level', 'Information Technology'),
    ('Senior Level', 'Finance'),
    ('Junior Level', 'Engineering'),
    ('Managerial Level', 'Management'),
    ('Experienced', 'Creative');

INSERT INTO Job (TitleCodeNo, TitleCodeNo1, PostingType, Agency, NumberOfPositions, LevelID, ResidencyRequirement, RecruitmentContact, SalaryFrequency, SalaryRangeFrom, SalaryRangeTo, FullTimePartTimeIndicator, WorkLocationAgency, DivisionWorkUnit, MinimumQualRequirements, JobDescription, PreferredSkills, ToApply, HoursShift, PostingDate, PostUntil, PostingUpdated, ProcessDate, WorkLocation1, AdditionalInformation)
VALUES
    (1, 101, 'Full-Time', 'ABC Corp', 5, 1, 'Local', 'John Doe', 'Annual', 50000.0, 75000.0, 'Full-Time', 'Office', 'IT Department', 'Bachelor''s degree in IT required', 'Responsible for software development', 'C#, Java, SQL', 'Apply through our website', '9:00 AM - 5:00 PM', '2023-11-01', '2023-12-01', '2023-11-15', '2023-10-30', 'New York', 'See our website for more information'),
    (2, 102, 'Part-Time', 'XYZ Inc', 3, 3, 'Local', 'Jane Smith', 'Hourly', 15.0, 25.0, 'Part-Time', 'Office', 'Finance Department', 'Finance degree required', 'Analyze financial data', 'Accounting, Excel', 'Send your resume to hr@xyz.com', '10:00 AM - 2:00 PM', '2023-11-05', '2023-11-30', '2023-11-10', '2023-10-25', 'Los Angeles', 'Contact us for inquiries'),
    (3, 103, 'Full-Time', 'Tech Solutions', 2, 4, 'Local', 'Mary Johnson', 'Annual', 60000.0, 90000.0, 'Full-Time', 'Office', 'Engineering Department', 'Engineering degree required', 'Design and develop software', 'C++, Python', 'Submit your application on our website', '8:30 AM - 4:30 PM', '2023-10-20', '2023-11-20', '2023-11-15', '2023-10-25', 'San Francisco', 'No additional information available'),
    (4, 104, 'Full-Time', 'ABC Corp', 1, 2, 'Local', 'David Lee', 'Annual', 55000.0, 80000.0, 'Full-Time', 'Office', 'Finance Department', 'Finance degree required', 'Financial analysis', 'Accounting, Excel', 'Apply through our website', '9:00 AM - 5:00 PM', '2023-11-10', '2023-12-10', '2023-11-15', '2023-10-31', 'Chicago', 'See our website for more details'),
    (5, 105, 'Full-Time', 'Tech Solutions', 3, 3, 'Local', 'Sarah Brown', 'Annual', 55000.0, 85000.0, 'Full-Time', 'Office', 'Engineering Department', 'Engineering degree required', 'Software development', 'Java, JavaScript', 'Submit your application on our website', '9:00 AM - 5:00 PM', '2023-10-15', '2023-11-15', '2023-10-20', '2023-09-25', 'Seattle', 'Contact us for more information');
