using System.Collections.Generic;
using System.Linq;
using DevTutorialWebApp.Models;

namespace DevTutorialWebApp.Services
{
    public partial class RoadmapService
    {
        private void UpdateSQLDatabaseDeveloperRoadmap(List<Roadmap> roadmaps)
        {
            var sqlDev = roadmaps.FirstOrDefault(r => r.Id == 15);
            if (sqlDev != null)
            {
                // Update the SQL & Database Developer roadmap with comprehensive structure
                sqlDev.Title = "SQL & Database Developer / Admin";
                sqlDev.Description = "Master database design, SQL development, administration, and modern data technologies";
                sqlDev.Duration = "8-12 months";
                sqlDev.Difficulty = "Beginner to Expert";
                sqlDev.Context = "SQL and database development encompasses relational databases, NoSQL systems, cloud databases, and big data technologies. This comprehensive path covers everything from SQL fundamentals to advanced administration, performance tuning, and modern data architectures.";
                
                sqlDev.Prerequisites = new List<string>
                {
                    "Basic understanding of data and information concepts",
                    "Logical thinking and problem-solving skills",
                    "Basic computer literacy",
                    "Interest in data management and analysis"
                };
                
                sqlDev.CareerPaths = new List<string>
                {
                    "SQL Developer ($65K-$120K)",
                    "Database Administrator ($75K-$140K)",
                    "Database Architect ($100K-$180K)",
                    "Data Engineer ($85K-$160K)",
                    "Cloud Database Specialist ($90K-$170K)"
                };

                // Replace existing steps with comprehensive 20-category structure
                sqlDev.Steps = new List<RoadmapStep>
                {
                    // 1. Database Fundamentals
                    new RoadmapStep
                    {
                        Id = 1501,
                        RoadmapId = 15,
                        Title = "Database Fundamentals",
                        Duration = "2-3 weeks",
                        Content = "Master the foundational concepts of database systems and relational theory",
                        KeyConcepts = new List<string> 
                        { 
                            "Relational Database Concepts",
                            "Normalization (1NF-BCNF)",
                            "Keys & Constraints",
                            "ACID Properties",
                            "OLTP vs OLAP"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 15011, StepId = 1501, Description = "Understand relational database theory" },
                            new LearningObjective { Id = 15012, StepId = 1501, Description = "Apply normalization principles" },
                            new LearningObjective { Id = 15013, StepId = 1501, Description = "Design database schemas with proper constraints" },
                            new LearningObjective { Id = 15014, StepId = 1501, Description = "Differentiate between OLTP and OLAP systems" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 15011, StepId = 1501, Title = "Database System Concepts", Type = "Book", Url = "https://www.db-book.com/" },
                            new Resource { Id = 15012, StepId = 1501, Title = "SQL Tutorial", Type = "Tutorial", Url = "https://www.w3schools.com/sql/" }
                        }
                    },

                    // 2. SQL Language
                    new RoadmapStep
                    {
                        Id = 1502,
                        RoadmapId = 15,
                        Title = "SQL Language Mastery",
                        Duration = "3-4 weeks",
                        Content = "Master all aspects of the SQL language including DDL, DML, DCL, and TCL",
                        KeyConcepts = new List<string>
                        {
                            "DDL (CREATE, ALTER, DROP)",
                            "DML (SELECT, INSERT, UPDATE, DELETE)",
                            "DCL (GRANT, REVOKE)",
                            "TCL (BEGIN, COMMIT, ROLLBACK)",
                            "MERGE Statements"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 15021, StepId = 1502, Description = "Write complex DDL statements" },
                            new LearningObjective { Id = 15022, StepId = 1502, Description = "Master DML operations" },
                            new LearningObjective { Id = 15023, StepId = 1502, Description = "Implement security with DCL" },
                            new LearningObjective { Id = 15024, StepId = 1502, Description = "Control transactions effectively" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 15021, StepId = 1502, Title = "SQL Reference Guide", Type = "Documentation", Url = "https://docs.microsoft.com/sql/t-sql/language-reference" },
                            new Resource { Id = 15022, StepId = 1502, Title = "PostgreSQL Documentation", Type = "Documentation", Url = "https://www.postgresql.org/docs/" }
                        }
                    },

                    // 3. Query Development
                    new RoadmapStep
                    {
                        Id = 1503,
                        RoadmapId = 15,
                        Title = "Advanced Query Development",
                        Duration = "4-5 weeks",
                        Content = "Master complex query patterns, optimization, and advanced SQL features",
                        KeyConcepts = new List<string>
                        {
                            "Complex JOINs",
                            "Subqueries & CTEs",
                            "Window Functions",
                            "PIVOT/UNPIVOT",
                            "Query Optimization"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 15031, StepId = 1503, Description = "Write complex multi-table JOINs" },
                            new LearningObjective { Id = 15032, StepId = 1503, Description = "Master window functions for analytics" },
                            new LearningObjective { Id = 15033, StepId = 1503, Description = "Use CTEs for readable queries" },
                            new LearningObjective { Id = 15034, StepId = 1503, Description = "Optimize query performance" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 15031, StepId = 1503, Title = "SQL Performance Explained", Type = "Book", Url = "https://sql-performance-explained.com/" },
                            new Resource { Id = 15032, StepId = 1503, Title = "Window Functions Guide", Type = "Tutorial", Url = "https://mode.com/sql-tutorial/sql-window-functions/" }
                        }
                    },

                    // 4. Stored Procedures & Programmability
                    new RoadmapStep
                    {
                        Id = 1504,
                        RoadmapId = 15,
                        Title = "Database Programmability",
                        Duration = "3-4 weeks",
                        Content = "Learn server-side programming with stored procedures, functions, and triggers",
                        KeyConcepts = new List<string>
                        {
                            "Stored Procedures",
                            "User-Defined Functions",
                            "Triggers",
                            "Dynamic SQL",
                            "Error Handling"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 15041, StepId = 1504, Description = "Create complex stored procedures" },
                            new LearningObjective { Id = 15042, StepId = 1504, Description = "Implement business logic with functions" },
                            new LearningObjective { Id = 15043, StepId = 1504, Description = "Use triggers appropriately" },
                            new LearningObjective { Id = 15044, StepId = 1504, Description = "Handle errors and transactions" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 15041, StepId = 1504, Title = "T-SQL Programming", Type = "Book", Url = "https://www.amazon.com/T-SQL-Fundamentals-3rd-Itzik-Ben-Gan/dp/150930200X" },
                            new Resource { Id = 15042, StepId = 1504, Title = "PL/pgSQL Documentation", Type = "Documentation", Url = "https://www.postgresql.org/docs/current/plpgsql.html" }
                        }
                    },

                    // 5. Indexes & Performance
                    new RoadmapStep
                    {
                        Id = 1505,
                        RoadmapId = 15,
                        Title = "Indexes & Performance Tuning",
                        Duration = "4-5 weeks",
                        Content = "Master indexing strategies and performance optimization techniques",
                        KeyConcepts = new List<string>
                        {
                            "Index Types & Strategies",
                            "Execution Plans",
                            "Query Optimization",
                            "Statistics Management",
                            "Performance Monitoring"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 15051, StepId = 1505, Description = "Design effective indexing strategies" },
                            new LearningObjective { Id = 15052, StepId = 1505, Description = "Analyze and optimize execution plans" },
                            new LearningObjective { Id = 15053, StepId = 1505, Description = "Maintain index and statistics health" },
                            new LearningObjective { Id = 15054, StepId = 1505, Description = "Identify and resolve performance bottlenecks" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 15051, StepId = 1505, Title = "SQL Server Execution Plans", Type = "Book", Url = "https://www.red-gate.com/simple-talk/books/sql-server-execution-plans-third-edition/" },
                            new Resource { Id = 15052, StepId = 1505, Title = "Use The Index, Luke", Type = "Website", Url = "https://use-the-index-luke.com/" }
                        }
                    },

                    // 6. Database Administration
                    new RoadmapStep
                    {
                        Id = 1506,
                        RoadmapId = 15,
                        Title = "Database Administration",
                        Duration = "4-5 weeks",
                        Content = "Learn essential DBA tasks including backup, recovery, and maintenance",
                        KeyConcepts = new List<string>
                        {
                            "Installation & Configuration",
                            "Backup & Recovery",
                            "User Management",
                            "Database Maintenance",
                            "Multi-tenant Management"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 15061, StepId = 1506, Description = "Install and configure database systems" },
                            new LearningObjective { Id = 15062, StepId = 1506, Description = "Implement backup and recovery strategies" },
                            new LearningObjective { Id = 15063, StepId = 1506, Description = "Manage users and permissions" },
                            new LearningObjective { Id = 15064, StepId = 1506, Description = "Perform routine maintenance tasks" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 15061, StepId = 1506, Title = "SQL Server Administration", Type = "Course", Url = "https://docs.microsoft.com/learn/paths/sql-server-2017-on-linux/" },
                            new Resource { Id = 15062, StepId = 1506, Title = "PostgreSQL Administration", Type = "Book", Url = "https://www.postgresql.org/docs/current/admin.html" }
                        }
                    },

                    // 7. Transactions & Concurrency
                    new RoadmapStep
                    {
                        Id = 1507,
                        RoadmapId = 15,
                        Title = "Transactions & Concurrency Control",
                        Duration = "3-4 weeks",
                        Content = "Master transaction management and concurrency control mechanisms",
                        KeyConcepts = new List<string>
                        {
                            "Isolation Levels",
                            "Locking Mechanisms",
                            "Deadlock Resolution",
                            "Optimistic vs Pessimistic",
                            "MVCC"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 15071, StepId = 1507, Description = "Implement appropriate isolation levels" },
                            new LearningObjective { Id = 15072, StepId = 1507, Description = "Handle locking and blocking issues" },
                            new LearningObjective { Id = 15073, StepId = 1507, Description = "Detect and resolve deadlocks" },
                            new LearningObjective { Id = 15074, StepId = 1507, Description = "Design for concurrency" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 15071, StepId = 1507, Title = "Concurrency Control", Type = "Article", Url = "https://www.red-gate.com/simple-talk/sql/t-sql-programming/concurrency-control/" },
                            new Resource { Id = 15072, StepId = 1507, Title = "Transaction Processing", Type = "Book", Url = "https://www.amazon.com/Transaction-Processing-Concepts-Techniques-Management/dp/1558601902" }
                        }
                    },

                    // 8. Data Modeling & Design
                    new RoadmapStep
                    {
                        Id = 1508,
                        RoadmapId = 15,
                        Title = "Data Modeling & Design",
                        Duration = "4-5 weeks",
                        Content = "Master data modeling techniques for various database paradigms",
                        KeyConcepts = new List<string>
                        {
                            "ER Diagrams",
                            "Dimensional Modeling",
                            "Star & Snowflake Schemas",
                            "Data Vault",
                            "Master Data Management"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 15081, StepId = 1508, Description = "Create conceptual and physical models" },
                            new LearningObjective { Id = 15082, StepId = 1508, Description = "Design data warehouses" },
                            new LearningObjective { Id = 15083, StepId = 1508, Description = "Implement slowly changing dimensions" },
                            new LearningObjective { Id = 15084, StepId = 1508, Description = "Apply MDM principles" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 15081, StepId = 1508, Title = "The Data Warehouse Toolkit", Type = "Book", Url = "https://www.amazon.com/Data-Warehouse-Toolkit-Definitive-Dimensional/dp/1118530802" },
                            new Resource { Id = 15082, StepId = 1508, Title = "Data Modeling Zone", Type = "Website", Url = "http://www.datamodelingzone.com/" }
                        }
                    },

                    // 9. ETL & Data Integration
                    new RoadmapStep
                    {
                        Id = 1509,
                        RoadmapId = 15,
                        Title = "ETL & Data Integration",
                        Duration = "4-5 weeks",
                        Content = "Learn data integration patterns and ETL/ELT processes",
                        KeyConcepts = new List<string>
                        {
                            "ETL vs ELT",
                            "Data Pipelines",
                            "Change Data Capture",
                            "Data Transformation",
                            "Integration Tools"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 15091, StepId = 1509, Description = "Design ETL/ELT pipelines" },
                            new LearningObjective { Id = 15092, StepId = 1509, Description = "Implement CDC strategies" },
                            new LearningObjective { Id = 15093, StepId = 1509, Description = "Use integration tools effectively" },
                            new LearningObjective { Id = 15094, StepId = 1509, Description = "Handle data quality issues" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 15091, StepId = 1509, Title = "Data Integration Guide", Type = "Book", Url = "https://www.amazon.com/Pentaho-Kettle-Solutions-Building-Integration/dp/0470635177" },
                            new Resource { Id = 15092, StepId = 1509, Title = "SSIS Tutorial", Type = "Tutorial", Url = "https://docs.microsoft.com/sql/integration-services/" }
                        }
                    },

                    // 10. Security
                    new RoadmapStep
                    {
                        Id = 1510,
                        RoadmapId = 15,
                        Title = "Database Security",
                        Duration = "3-4 weeks",
                        Content = "Implement comprehensive database security measures",
                        KeyConcepts = new List<string>
                        {
                            "Authentication & Authorization",
                            "Row-Level Security",
                            "Encryption (TDE, Always Encrypted)",
                            "SQL Injection Prevention",
                            "Auditing & Compliance"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 15101, StepId = 1510, Description = "Implement authentication mechanisms" },
                            new LearningObjective { Id = 15102, StepId = 1510, Description = "Configure encryption at rest and in transit" },
                            new LearningObjective { Id = 15103, StepId = 1510, Description = "Prevent SQL injection attacks" },
                            new LearningObjective { Id = 15104, StepId = 1510, Description = "Set up auditing and compliance" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 15101, StepId = 1510, Title = "Database Security", Type = "Course", Url = "https://www.pluralsight.com/courses/database-security" },
                            new Resource { Id = 15102, StepId = 1510, Title = "SQL Injection Prevention", Type = "Guide", Url = "https://cheatsheetseries.owasp.org/cheatsheets/SQL_Injection_Prevention_Cheat_Sheet.html" }
                        }
                    },

                    // 11. High Availability & Disaster Recovery
                    new RoadmapStep
                    {
                        Id = 1511,
                        RoadmapId = 15,
                        Title = "High Availability & Disaster Recovery",
                        Duration = "4-5 weeks",
                        Content = "Design and implement HA/DR solutions for critical databases",
                        KeyConcepts = new List<string>
                        {
                            "Backup Strategies",
                            "AlwaysOn/Clustering",
                            "Replication",
                            "Log Shipping",
                            "RPO/RTO Planning"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 15111, StepId = 1511, Description = "Design HA/DR strategies" },
                            new LearningObjective { Id = 15112, StepId = 1511, Description = "Implement failover clustering" },
                            new LearningObjective { Id = 15113, StepId = 1511, Description = "Configure replication" },
                            new LearningObjective { Id = 15114, StepId = 1511, Description = "Test disaster recovery plans" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 15111, StepId = 1511, Title = "Pro SQL Server HA/DR", Type = "Book", Url = "https://www.apress.com/gp/book/9781484220719" },
                            new Resource { Id = 15112, StepId = 1511, Title = "PostgreSQL Replication", Type = "Documentation", Url = "https://www.postgresql.org/docs/current/high-availability.html" }
                        }
                    },

                    // 12. Monitoring & Maintenance
                    new RoadmapStep
                    {
                        Id = 1512,
                        RoadmapId = 15,
                        Title = "Monitoring & Maintenance",
                        Duration = "3-4 weeks",
                        Content = "Implement comprehensive monitoring and maintenance strategies",
                        KeyConcepts = new List<string>
                        {
                            "Performance Monitoring",
                            "Health Checks",
                            "Maintenance Plans",
                            "Alerting Systems",
                            "Baseline Metrics"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 15121, StepId = 1512, Description = "Set up monitoring infrastructure" },
                            new LearningObjective { Id = 15122, StepId = 1512, Description = "Create maintenance plans" },
                            new LearningObjective { Id = 15123, StepId = 1512, Description = "Configure alerting systems" },
                            new LearningObjective { Id = 15124, StepId = 1512, Description = "Establish performance baselines" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 15121, StepId = 1512, Title = "SQL Server Monitoring", Type = "Guide", Url = "https://docs.microsoft.com/sql/relational-databases/performance/monitor-and-tune-for-performance" },
                            new Resource { Id = 15122, StepId = 1512, Title = "Prometheus for Databases", Type = "Tutorial", Url = "https://prometheus.io/docs/guides/mysqld-exporter/" }
                        }
                    },

                    // 13. Big Data & Advanced Analytics
                    new RoadmapStep
                    {
                        Id = 1513,
                        RoadmapId = 15,
                        Title = "Big Data & Advanced Analytics",
                        Duration = "4-5 weeks",
                        Content = "Work with big data technologies and advanced analytics platforms",
                        KeyConcepts = new List<string>
                        {
                            "Hadoop/Spark Integration",
                            "Data Lakes",
                            "Columnar Storage",
                            "Real-Time Analytics",
                            "Partitioning Strategies"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 15131, StepId = 1513, Description = "Integrate with big data platforms" },
                            new LearningObjective { Id = 15132, StepId = 1513, Description = "Design data lake architectures" },
                            new LearningObjective { Id = 15133, StepId = 1513, Description = "Implement real-time analytics" },
                            new LearningObjective { Id = 15134, StepId = 1513, Description = "Optimize for analytical workloads" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 15131, StepId = 1513, Title = "Big Data Analytics", Type = "Course", Url = "https://www.coursera.org/learn/big-data-analytics" },
                            new Resource { Id = 15132, StepId = 1513, Title = "Apache Spark SQL", Type = "Documentation", Url = "https://spark.apache.org/docs/latest/sql-programming-guide.html" }
                        }
                    },

                    // 14. Cloud Databases
                    new RoadmapStep
                    {
                        Id = 1514,
                        RoadmapId = 15,
                        Title = "Cloud Database Technologies",
                        Duration = "4-5 weeks",
                        Content = "Master cloud database services and migration strategies",
                        KeyConcepts = new List<string>
                        {
                            "Azure SQL/AWS RDS",
                            "Serverless Databases",
                            "Elastic Scaling",
                            "Multi-Region Deployment",
                            "Cloud Migration"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 15141, StepId = 1514, Description = "Deploy databases in cloud platforms" },
                            new LearningObjective { Id = 15142, StepId = 1514, Description = "Implement auto-scaling strategies" },
                            new LearningObjective { Id = 15143, StepId = 1514, Description = "Design for multi-region deployment" },
                            new LearningObjective { Id = 15144, StepId = 1514, Description = "Migrate on-premises databases to cloud" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 15141, StepId = 1514, Title = "Azure SQL Documentation", Type = "Documentation", Url = "https://docs.microsoft.com/azure/azure-sql/" },
                            new Resource { Id = 15142, StepId = 1514, Title = "AWS RDS Guide", Type = "Guide", Url = "https://docs.aws.amazon.com/rds/" }
                        }
                    },

                    // 15. NoSQL & Modern Databases
                    new RoadmapStep
                    {
                        Id = 1515,
                        RoadmapId = 15,
                        Title = "NoSQL & Modern Database Systems",
                        Duration = "4-5 weeks",
                        Content = "Explore NoSQL databases and modern data storage paradigms",
                        KeyConcepts = new List<string>
                        {
                            "Document Stores",
                            "Key-Value Stores",
                            "Graph Databases",
                            "Time-Series Databases",
                            "NewSQL Systems"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 15151, StepId = 1515, Description = "Choose appropriate NoSQL solutions" },
                            new LearningObjective { Id = 15152, StepId = 1515, Description = "Work with document databases" },
                            new LearningObjective { Id = 15153, StepId = 1515, Description = "Implement graph database solutions" },
                            new LearningObjective { Id = 15154, StepId = 1515, Description = "Design polyglot persistence architectures" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 15151, StepId = 1515, Title = "NoSQL Distilled", Type = "Book", Url = "https://martinfowler.com/books/nosql.html" },
                            new Resource { Id = 15152, StepId = 1515, Title = "MongoDB University", Type = "Course", Url = "https://university.mongodb.com/" }
                        }
                    },

                    // 16. Data Governance & Compliance
                    new RoadmapStep
                    {
                        Id = 1516,
                        RoadmapId = 15,
                        Title = "Data Governance & Compliance",
                        Duration = "2-3 weeks",
                        Content = "Implement data governance frameworks and ensure compliance",
                        KeyConcepts = new List<string>
                        {
                            "GDPR/HIPAA Compliance",
                            "Data Retention Policies",
                            "Data Lineage",
                            "Metadata Management",
                            "Data Classification"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 15161, StepId = 1516, Description = "Implement compliance requirements" },
                            new LearningObjective { Id = 15162, StepId = 1516, Description = "Design data retention policies" },
                            new LearningObjective { Id = 15163, StepId = 1516, Description = "Track data lineage" },
                            new LearningObjective { Id = 15164, StepId = 1516, Description = "Classify and protect sensitive data" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 15161, StepId = 1516, Title = "Data Governance", Type = "Book", Url = "https://www.amazon.com/Data-Governance-How-Design-Operating/dp/0124158293" },
                            new Resource { Id = 15162, StepId = 1516, Title = "GDPR for Databases", Type = "Guide", Url = "https://gdpr.eu/data-protection/" }
                        }
                    },

                    // 17. DevOps for Databases
                    new RoadmapStep
                    {
                        Id = 1517,
                        RoadmapId = 15,
                        Title = "Database DevOps",
                        Duration = "3-4 weeks",
                        Content = "Implement DevOps practices for database development and deployment",
                        KeyConcepts = new List<string>
                        {
                            "Database Version Control",
                            "CI/CD for Databases",
                            "Automated Testing",
                            "Blue-Green Deployments",
                            "Infrastructure as Code"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 15171, StepId = 1517, Description = "Version control database changes" },
                            new LearningObjective { Id = 15172, StepId = 1517, Description = "Build CI/CD pipelines for databases" },
                            new LearningObjective { Id = 15173, StepId = 1517, Description = "Automate database testing" },
                            new LearningObjective { Id = 15174, StepId = 1517, Description = "Implement safe deployment strategies" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 15171, StepId = 1517, Title = "Database DevOps", Type = "Course", Url = "https://www.red-gate.com/hub/university/courses/database-devops" },
                            new Resource { Id = 15172, StepId = 1517, Title = "Flyway Documentation", Type = "Documentation", Url = "https://flywaydb.org/documentation/" }
                        }
                    },

                    // 18. Scripting & Automation
                    new RoadmapStep
                    {
                        Id = 1518,
                        RoadmapId = 15,
                        Title = "Database Scripting & Automation",
                        Duration = "2-3 weeks",
                        Content = "Automate database tasks with scripting languages and tools",
                        KeyConcepts = new List<string>
                        {
                            "PowerShell for SQL",
                            "Bash Scripting",
                            "Python Database APIs",
                            "Automated Backups",
                            "Job Scheduling"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 15181, StepId = 1518, Description = "Write database automation scripts" },
                            new LearningObjective { Id = 15182, StepId = 1518, Description = "Automate routine DBA tasks" },
                            new LearningObjective { Id = 15183, StepId = 1518, Description = "Create monitoring scripts" },
                            new LearningObjective { Id = 15184, StepId = 1518, Description = "Schedule and orchestrate jobs" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 15181, StepId = 1518, Title = "PowerShell for SQL Server", Type = "Course", Url = "https://docs.microsoft.com/powershell/module/sqlserver/" },
                            new Resource { Id = 15182, StepId = 1518, Title = "Python Database Programming", Type = "Tutorial", Url = "https://realpython.com/python-sql-libraries/" }
                        }
                    },

                    // 19. Performance & Optimization
                    new RoadmapStep
                    {
                        Id = 1519,
                        RoadmapId = 15,
                        Title = "Advanced Performance Optimization",
                        Duration = "4-5 weeks",
                        Content = "Master advanced performance tuning and optimization techniques",
                        KeyConcepts = new List<string>
                        {
                            "Query Plan Analysis",
                            "Partitioning Strategies",
                            "In-Memory OLTP",
                            "Caching Layers",
                            "Sharding"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 15191, StepId = 1519, Description = "Analyze complex query plans" },
                            new LearningObjective { Id = 15192, StepId = 1519, Description = "Implement partitioning strategies" },
                            new LearningObjective { Id = 15193, StepId = 1519, Description = "Use in-memory technologies" },
                            new LearningObjective { Id = 15194, StepId = 1519, Description = "Design for horizontal scaling" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 15191, StepId = 1519, Title = "SQL Tuning", Type = "Book", Url = "https://www.amazon.com/SQL-Tuning-Generating-Optimal-Execution/dp/0596005733" },
                            new Resource { Id = 15192, StepId = 1519, Title = "Database Internals", Type = "Book", Url = "https://www.databass.dev/" }
                        }
                    },

                    // 20. Emerging & Specialized Topics
                    new RoadmapStep
                    {
                        Id = 1520,
                        RoadmapId = 15,
                        Title = "Emerging Database Technologies",
                        Duration = "3-4 weeks",
                        Content = "Explore cutting-edge database technologies and future trends",
                        KeyConcepts = new List<string>
                        {
                            "In-Memory Databases",
                            "Graph Extensions in SQL",
                            "Blockchain Databases",
                            "AI/ML Integration",
                            "Edge Computing"
                        },
                        Objectives = new List<LearningObjective>
                        {
                            new LearningObjective { Id = 15201, StepId = 1520, Description = "Work with in-memory database systems" },
                            new LearningObjective { Id = 15202, StepId = 1520, Description = "Implement graph capabilities in SQL" },
                            new LearningObjective { Id = 15203, StepId = 1520, Description = "Integrate ML with databases" },
                            new LearningObjective { Id = 15204, StepId = 1520, Description = "Design for edge computing scenarios" }
                        },
                        Resources = new List<Resource>
                        {
                            new Resource { Id = 15201, StepId = 1520, Title = "SAP HANA Development", Type = "Course", Url = "https://open.sap.com/courses/hana1" },
                            new Resource { Id = 15202, StepId = 1520, Title = "SQL Graph", Type = "Documentation", Url = "https://docs.microsoft.com/sql/relational-databases/graphs/sql-graph-overview" }
                        }
                    }
                };

                // Add practical exercises for each step
                foreach (var step in sqlDev.Steps)
                {
                    step.PracticalExercises = GetSQLPracticalExercisesForStep(step.Id);
                }
            }
        }

        private List<string> GetSQLPracticalExercisesForStep(int stepId)
        {
            return stepId switch
            {
                1501 => new List<string>
                {
                    "Design and normalize a database for an e-commerce platform",
                    "Convert a denormalized spreadsheet to 3NF",
                    "Create ER diagrams for a library management system",
                    "Implement ACID properties in transaction scenarios"
                },
                1502 => new List<string>
                {
                    "Create a complete database schema with constraints",
                    "Write complex DML statements for data manipulation",
                    "Implement role-based security with DCL",
                    "Build transaction scripts with proper error handling"
                },
                1503 => new List<string>
                {
                    "Write complex analytical queries using window functions",
                    "Optimize slow queries using execution plans",
                    "Create pivot tables for reporting",
                    "Build recursive CTEs for hierarchical data"
                },
                1504 => new List<string>
                {
                    "Create a stored procedure for order processing",
                    "Build user-defined functions for business calculations",
                    "Implement audit triggers for data changes",
                    "Write dynamic SQL with proper security"
                },
                1505 => new List<string>
                {
                    "Design indexing strategy for a high-traffic application",
                    "Analyze and optimize query execution plans",
                    "Implement columnstore indexes for analytics",
                    "Create index maintenance routines"
                },
                1506 => new List<string>
                {
                    "Set up automated backup and recovery procedures",
                    "Configure database security and user permissions",
                    "Implement database maintenance plans",
                    "Create disaster recovery documentation"
                },
                1507 => new List<string>
                {
                    "Implement different isolation levels and test effects",
                    "Create deadlock scenarios and resolution strategies",
                    "Design optimistic concurrency patterns",
                    "Build retry logic for transaction conflicts"
                },
                1508 => new List<string>
                {
                    "Design a star schema for a data warehouse",
                    "Implement slowly changing dimensions",
                    "Create data vault models",
                    "Build dimensional models for analytics"
                },
                1509 => new List<string>
                {
                    "Build an ETL pipeline with error handling",
                    "Implement change data capture",
                    "Create data quality validation routines",
                    "Design incremental load strategies"
                },
                1510 => new List<string>
                {
                    "Implement row-level security",
                    "Configure transparent data encryption",
                    "Build SQL injection prevention measures",
                    "Create comprehensive audit trails"
                },
                1511 => new List<string>
                {
                    "Configure AlwaysOn availability groups",
                    "Implement database replication",
                    "Design and test failover procedures",
                    "Create disaster recovery runbooks"
                },
                1512 => new List<string>
                {
                    "Set up comprehensive monitoring dashboards",
                    "Create custom performance alerts",
                    "Build automated maintenance procedures",
                    "Implement baseline performance tracking"
                },
                1513 => new List<string>
                {
                    "Integrate SQL with Spark for big data analytics",
                    "Implement partitioning for large tables",
                    "Build real-time analytics pipelines",
                    "Create data lake integration patterns"
                },
                1514 => new List<string>
                {
                    "Migrate on-premises database to cloud",
                    "Implement serverless database solutions",
                    "Configure auto-scaling for cloud databases",
                    "Design multi-region database deployment"
                },
                1515 => new List<string>
                {
                    "Build a document store solution with MongoDB",
                    "Implement graph queries with Neo4j",
                    "Create time-series database for IoT data",
                    "Design polyglot persistence architecture"
                },
                1516 => new List<string>
                {
                    "Implement GDPR compliance for databases",
                    "Create data retention policies",
                    "Build data lineage tracking",
                    "Design data classification system"
                },
                1517 => new List<string>
                {
                    "Set up database version control with Flyway",
                    "Create CI/CD pipeline for database changes",
                    "Implement automated database testing",
                    "Build blue-green deployment for databases"
                },
                1518 => new List<string>
                {
                    "Automate DBA tasks with PowerShell",
                    "Create monitoring scripts in Python",
                    "Build backup automation scripts",
                    "Implement job scheduling framework"
                },
                1519 => new List<string>
                {
                    "Optimize complex query performance",
                    "Implement database sharding",
                    "Configure in-memory OLTP",
                    "Design caching strategies with Redis"
                },
                1520 => new List<string>
                {
                    "Implement ML services in SQL Server",
                    "Build graph queries in SQL",
                    "Create blockchain-backed audit tables",
                    "Design edge database synchronization"
                },
                _ => new List<string>()
            };
        }
    }
}