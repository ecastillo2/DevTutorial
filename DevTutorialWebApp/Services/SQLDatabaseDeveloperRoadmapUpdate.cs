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
                            "Relational Database Concepts - Understanding the foundational theory of relational databases including tables (relations), rows (tuples), columns (attributes), and the mathematical principles of relational algebra. Learn how data is organized into structured tables with defined relationships, ensuring data integrity and enabling complex queries across multiple related entities.",
                            "Normalization (1NF-BCNF) - Master the process of organizing data to minimize redundancy and dependency. First Normal Form (1NF) eliminates repeating groups, Second Normal Form (2NF) removes partial dependencies, Third Normal Form (3NF) eliminates transitive dependencies, and Boyce-Codd Normal Form (BCNF) handles additional anomalies. Understand when to normalize for data integrity and when to denormalize for performance.",
                            "Keys & Constraints - Primary keys uniquely identify rows and enforce entity integrity. Foreign keys maintain referential integrity between tables. Unique constraints prevent duplicate values, check constraints enforce business rules, and default constraints provide automatic values. Understanding these mechanisms is crucial for maintaining data quality and implementing business logic at the database level.",
                            "ACID Properties - Atomicity ensures transactions are all-or-nothing operations. Consistency maintains database integrity before and after transactions. Isolation prevents concurrent transactions from interfering with each other. Durability guarantees committed changes persist even after system failures. These properties form the foundation of reliable database systems and transaction processing.",
                            "OLTP vs OLAP - Online Transaction Processing (OLTP) systems handle day-to-day transactional operations with normalized schemas optimized for insert/update/delete operations. Online Analytical Processing (OLAP) systems support complex analytical queries with denormalized schemas (star/snowflake) optimized for read-heavy reporting and business intelligence workloads."
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
                            "DDL (CREATE, ALTER, DROP) - Data Definition Language commands structure and modify database objects. CREATE establishes new tables, indexes, views, and procedures. ALTER modifies existing structures by adding columns, changing data types, or updating constraints. DROP removes objects permanently. Master the syntax for creating complex table structures with appropriate data types, constraints, and relationships.",
                            "DML (SELECT, INSERT, UPDATE, DELETE) - Data Manipulation Language forms the core of database interaction. SELECT retrieves data with filtering (WHERE), grouping (GROUP BY), and ordering (ORDER BY). INSERT adds new records with single or bulk operations. UPDATE modifies existing data with conditional logic. DELETE removes records while maintaining referential integrity. Learn to write efficient DML statements that handle large datasets.",
                            "DCL (GRANT, REVOKE) - Data Control Language manages database security and access permissions. GRANT assigns specific privileges (SELECT, INSERT, UPDATE, DELETE, EXECUTE) to users and roles at database, schema, table, or column levels. REVOKE removes previously granted permissions. Implement principle of least privilege, role-based access control, and understand permission inheritance in database security hierarchies.",
                            "TCL (BEGIN, COMMIT, ROLLBACK) - Transaction Control Language manages logical units of work. BEGIN starts explicit transactions, COMMIT permanently saves changes, and ROLLBACK undoes modifications. SAVEPOINT creates intermediate rollback points. Master transaction isolation levels, handle concurrent access patterns, and implement proper error handling to maintain data consistency across complex multi-statement operations.",
                            "MERGE Statements - Combines INSERT, UPDATE, and DELETE operations in a single atomic statement based on join conditions. Efficiently synchronizes data between tables, handles upserts (update or insert), and manages slowly changing dimensions in data warehouses. Understand MATCHED and NOT MATCHED clauses, OUTPUT options for auditing, and performance implications compared to separate DML operations."
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
                            "Complex JOINs - Master INNER, LEFT, RIGHT, FULL OUTER, and CROSS JOINs for combining data from multiple tables. Understand self-joins for hierarchical data, multi-table joins with proper join order, and non-equi joins for range-based matching. Learn to identify and resolve join performance issues, handle NULL values in outer joins, and use join hints when necessary for optimization.",
                            "Subqueries & CTEs - Subqueries provide inline data filtering in SELECT, FROM, and WHERE clauses. Common Table Expressions (CTEs) improve query readability and enable recursive operations for hierarchical data traversal. Master correlated subqueries that reference outer query columns, EXISTS/NOT EXISTS patterns, and recursive CTEs for organizational charts, bill-of-materials, and graph traversal scenarios.",
                            "Window Functions - Perform calculations across row sets without grouping. ROW_NUMBER assigns sequential integers, RANK and DENSE_RANK handle ties differently, and NTILE creates equal groups. Aggregate functions (SUM, AVG, COUNT) with OVER clause maintain detail rows. LAG/LEAD access previous/next rows, and FIRST_VALUE/LAST_VALUE retrieve boundary values. Define window frames with ROWS/RANGE for moving averages and running totals.",
                            "PIVOT/UNPIVOT - Transform row data into columns (PIVOT) or columns into rows (UNPIVOT) for reporting and analysis. Create crosstab reports, convert normalized data to denormalized format for dashboards, and handle dynamic column generation. Understand performance implications, NULL handling in pivoted data, and alternatives like conditional aggregation for complex transformations.",
                            "Query Optimization - Analyze execution plans to identify bottlenecks like table scans, missing indexes, and inefficient joins. Understand query optimizer behavior, statistics importance, and parameter sniffing. Apply optimization techniques including index hints, query rewriting, temporary table usage, and batch processing. Monitor resource consumption (CPU, memory, I/O) and use query store for performance trending."
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
                            "Stored Procedures - Precompiled database programs that encapsulate business logic, improve performance through plan reuse, and enhance security by preventing SQL injection. Create procedures with input/output parameters, return values, and result sets. Implement complex workflows, conditional logic, loops, and cursors. Understand procedure caching, recompilation triggers, and best practices for maintainable code.",
                            "User-Defined Functions - Scalar functions return single values for use in SELECT lists and WHERE clauses. Table-valued functions return result sets and can be joined like tables. Inline TVFs provide better performance than multi-statement TVFs. Understand deterministic vs non-deterministic functions, schema binding for indexed views, and performance implications of function usage in queries.",
                            "Triggers - Special procedures that automatically execute in response to DML events (INSERT, UPDATE, DELETE) or DDL changes. Implement audit trails, enforce complex business rules, maintain denormalized data, and synchronize related tables. Master INSTEAD OF triggers for updateable views, understand trigger order and nesting, and handle inserted/deleted virtual tables for change tracking.",
                            "Dynamic SQL - Construct and execute SQL statements at runtime for flexible query generation. Use sp_executesql for parameterized queries to prevent SQL injection and enable plan reuse. Handle variable table/column names, build conditional WHERE clauses, and generate administrative scripts. Understand security contexts, EXECUTE AS clauses, and performance implications of dynamic execution.",
                            "Error Handling - Implement robust error handling with TRY-CATCH blocks to gracefully handle runtime errors. Use THROW/RAISERROR to generate custom errors with severity levels and state codes. Capture error information with ERROR_NUMBER, ERROR_MESSAGE, and ERROR_LINE functions. Design retry logic for deadlocks, implement logging mechanisms, and ensure proper transaction rollback in error scenarios."
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
                            "Index Types & Strategies - Clustered indexes define physical data order and should be narrow, unique, and ever-increasing. Non-clustered indexes provide alternate access paths with included columns for covering queries. Filtered indexes optimize specific data subsets. Columnstore indexes compress and accelerate analytical workloads. Design indexes balancing query performance against maintenance overhead, considering selectivity, sort order, and included columns.",
                            "Execution Plans - Visual representations of query optimizer's chosen data access methods. Analyze actual vs estimated plans to identify cardinality estimation errors. Understand operators like nested loops, merge joins, hash joins, seeks vs scans, and parallelism. Identify expensive operations through cost percentages, examine data flow and row counts, and recognize anti-patterns like implicit conversions and missing statistics.",
                            "Query Optimization - Systematic approach to improving query performance through index tuning, query rewriting, and resource management. Eliminate unnecessary joins and subqueries, use appropriate join types, and leverage set-based operations over cursors. Implement query hints judiciously, optimize tempdb usage, and consider indexed views for complex aggregations. Monitor wait statistics to identify resource bottlenecks.",
                            "Statistics Management - Database statistics provide data distribution information enabling optimal execution plan selection. Understand histogram construction, density vectors, and cardinality estimation. Configure auto-update statistics thresholds, implement manual statistics maintenance for large tables, and use filtered statistics for skewed data. Monitor statistics age and accuracy, addressing ascending key problems in sequential data.",
                            "Performance Monitoring - Establish performance baselines using DMVs (Dynamic Management Views) for wait statistics, query performance, and resource utilization. Configure extended events for lightweight tracing, capture blocking and deadlock graphs, and monitor tempdb contention. Implement alerts for critical metrics, use query store for regression detection, and maintain performance trending data for capacity planning."
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
                            "Installation & Configuration - Plan and execute database server installations considering hardware requirements, storage configuration, and network settings. Configure memory allocation, parallel processing, tempdb optimization, and default file locations. Set appropriate authentication modes, collation settings, and service accounts. Implement post-installation security hardening, configure firewall rules, and establish baseline configurations.",
                            "Backup & Recovery - Design comprehensive backup strategies combining full, differential, and transaction log backups to meet Recovery Point Objectives (RPO) and Recovery Time Objectives (RTO). Implement backup compression, encryption, and verification. Master point-in-time recovery, page-level restore, and piecemeal restore for partial database recovery. Test recovery procedures regularly and document disaster recovery runbooks.",
                            "User Management - Create and manage database users, roles, and schemas following security best practices. Implement role-based access control (RBAC) with appropriate permission granularity. Configure authentication methods including Windows, SQL, and Azure AD authentication. Manage orphaned users, implement password policies, and audit user access patterns. Use contained databases for simplified user management in cloud environments.",
                            "Database Maintenance - Establish maintenance routines for index defragmentation, statistics updates, and consistency checks (DBCC CHECKDB). Implement automated cleanup of historical data, backup files, and job history. Configure database mail for notifications, set up maintenance plans or custom scripts, and schedule jobs during maintenance windows. Monitor database growth and implement proactive capacity management.",
                            "Multi-tenant Management - Design and implement multi-tenant architectures using shared database, shared schema, or database-per-tenant patterns. Manage resource governance to prevent noisy neighbor issues, implement row-level security for data isolation, and design scalable connection pooling strategies. Automate tenant provisioning, implement usage monitoring and chargeback mechanisms, and ensure compliance with data residency requirements."
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
                            "Isolation Levels - Control transaction visibility and concurrency behavior. READ UNCOMMITTED allows dirty reads but maximum concurrency. READ COMMITTED prevents dirty reads using shared locks. REPEATABLE READ holds locks preventing non-repeatable reads. SERIALIZABLE provides complete isolation preventing phantom reads. SNAPSHOT uses row versioning for consistent views. Choose appropriate levels balancing consistency needs against concurrency requirements.",
                            "Locking Mechanisms - Understand lock hierarchy from row to page to table levels. Shared locks allow concurrent reads, exclusive locks prevent all access, and update locks prevent deadlocks during read-modify-write operations. Intent locks indicate future lock requirements at lower levels. Monitor lock escalation, implement lock hints when necessary, and design queries to minimize lock duration and scope.",
                            "Deadlock Resolution - Circular blocking where transactions wait for resources held by each other. Database engines automatically detect and resolve deadlocks by rolling back the victim transaction with lowest cost. Analyze deadlock graphs to identify patterns, redesign transaction order to prevent deadlocks, and implement retry logic with exponential backoff. Use consistent resource access order across transactions.",
                            "Optimistic vs Pessimistic - Pessimistic concurrency uses locks assuming conflicts will occur, suitable for high-contention scenarios. Optimistic concurrency assumes conflicts are rare, using version checking or timestamps to detect changes before committing. Implement rowversion columns for optimistic concurrency, handle update conflicts gracefully, and choose strategies based on application patterns and conflict frequency.",
                            "MVCC - Multi-Version Concurrency Control maintains multiple versions of data rows, enabling readers to access consistent snapshots without blocking writers. Understand version store in tempdb, monitor version cleanup performance, and manage long-running transactions that prevent version cleanup. Leverage MVCC for read-heavy workloads, reporting queries, and scenarios requiring consistent data views without locking overhead."
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
                            "ER Diagrams - Entity-Relationship diagrams visualize database structure showing entities (tables), attributes (columns), and relationships (foreign keys). Use Chen or Crow's Foot notation to represent cardinality (one-to-one, one-to-many, many-to-many) and optionality. Create conceptual models for business understanding, logical models for design, and physical models for implementation including indexes and partitioning.",
                            "Dimensional Modeling - Design methodology for data warehouses optimizing query performance and user understanding. Identify business processes, grain, dimensions, and facts. Create conformed dimensions for enterprise consistency, design slowly changing dimension strategies (Type 1 overwrite, Type 2 historical tracking, Type 3 limited history), and implement surrogate keys for performance and flexibility.",
                            "Star & Snowflake Schemas - Star schema centralizes facts surrounded by denormalized dimension tables, providing simpler queries and better performance. Snowflake schema normalizes dimensions into multiple related tables, reducing storage but increasing query complexity. Choose schemas based on query patterns, data volume, and update frequency. Implement hybrid approaches for optimal balance.",
                            "Data Vault - Flexible, scalable modeling approach for enterprise data warehouses. Hubs store business keys, Links capture relationships, and Satellites track descriptive attributes over time. Enables parallel loading, historical tracking, and agile development. Design for auditability, implement hash keys for performance, and create business vault layer for reporting. Handle late-arriving data and relationship changes gracefully.",
                            "Master Data Management - Centralized approach to managing critical business entities (customers, products, locations) across systems. Implement golden record strategies, design match and merge rules, and establish data governance processes. Create MDM hubs with survivorship rules, implement data quality scoring, and synchronize master data across operational systems. Handle hierarchy management and cross-reference resolution."
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
                            "ETL vs ELT - Extract-Transform-Load processes data transformations in staging area before loading, suitable for complex transformations and limited target resources. Extract-Load-Transform leverages target system computing power, ideal for cloud data warehouses and big data platforms. Choose based on data volume, transformation complexity, network bandwidth, and target system capabilities. Implement hybrid approaches for optimal performance.",
                            "Data Pipelines - Automated workflows moving and transforming data between systems. Design idempotent pipelines supporting restart and recovery, implement incremental loading for efficiency, and handle late-arriving data. Use orchestration tools for dependency management, implement data quality checkpoints, and monitor pipeline health. Design for scalability with parallel processing and partitioning strategies.",
                            "Change Data Capture - Identify and capture data modifications for incremental processing. Implement CDC using database triggers, transaction logs, timestamps, or specialized CDC tools. Handle deletes with soft delete flags or audit tables. Design for minimal source system impact, ensure transactional consistency, and manage CDC table growth. Support real-time and batch CDC patterns.",
                            "Data Transformation - Convert data from source to target formats including type conversions, aggregations, and business rule applications. Implement data cleansing for standardization, deduplication, and validation. Design reusable transformation components, handle NULL values and data quality issues, and maintain transformation lineage. Use pushdown optimization to leverage database processing power.",
                            "Integration Tools - Master enterprise integration platforms (SSIS, Informatica, Talend) and cloud services (ADF, AWS Glue). Understand connectors for various data sources, implement error handling and retry logic, and design for monitoring and alerting. Leverage built-in transformations, create custom components when needed, and implement proper logging and auditing throughout integration processes."
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
                            "Authentication & Authorization - Authentication verifies user identity through passwords, Windows authentication, or certificates. Authorization controls resource access through roles and permissions. Implement principle of least privilege, use database roles for group management, and separate schema ownership from access permissions. Configure strong password policies and multi-factor authentication where supported.",
                            "Row-Level Security - Filter data access at row level based on user characteristics without application changes. Create security predicates using inline table-valued functions, implement both filter predicates (SELECT) and block predicates (INSERT, UPDATE, DELETE). Design for performance with proper indexing, handle security context in stored procedures, and test thoroughly for data leakage scenarios.",
                            "Encryption (TDE, Always Encrypted) - Transparent Data Encryption protects data at rest by encrypting database files, backups, and logs. Always Encrypted protects sensitive data from high-privileged users by encrypting at column level with keys stored outside database. Implement key rotation procedures, understand performance impacts, and design for regulatory compliance. Handle encrypted data in applications appropriately.",
                            "SQL Injection Prevention - Protect against malicious SQL code injection through user inputs. Use parameterized queries and stored procedures exclusively, validate and sanitize all inputs, and implement whitelist validation for dynamic SQL. Escape special characters, use least-privileged database accounts, and regularly scan for vulnerabilities. Implement defense in depth with multiple security layers.",
                            "Auditing & Compliance - Track database access and modifications for security and regulatory requirements. Configure database audit specifications for sensitive data access, implement change tracking for data modifications, and use temporal tables for historical data. Design audit data retention policies, protect audit logs from tampering, and create compliance reports for regulations like GDPR, HIPAA, and SOX."
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
                            "Backup Strategies - Design comprehensive backup solutions combining full backups (complete database copy), differential backups (changes since last full), and transaction log backups (point-in-time recovery). Implement backup compression and encryption, verify backup integrity, and test restore procedures regularly. Store backups following 3-2-1 rule: three copies, two different media types, one offsite location.",
                            "AlwaysOn/Clustering - AlwaysOn Availability Groups provide database-level protection with multiple replicas, automatic failover, and readable secondaries. Failover Cluster Instances offer instance-level protection with shared storage. Configure quorum models, implement proper network redundancy, and design for geographic distribution. Monitor synchronization health and test failover procedures regularly.",
                            "Replication - Distribute data across servers using snapshot (point-in-time copy), transactional (near real-time), or merge replication (bidirectional sync). Design publication and subscription topology, handle conflict resolution in merge replication, and monitor replication latency. Use for reporting offload, geographic distribution, and mobile synchronization scenarios. Understand limitations and maintenance requirements.",
                            "Log Shipping - Automated backup, copy, and restore of transaction logs to maintain warm standby servers. Configure primary and secondary servers, set backup/copy/restore job schedules, and implement monitoring. Design for minimal data loss with frequent log backups, automate failover procedures where possible, and maintain documentation for manual failover steps when needed.",
                            "RPO/RTO Planning - Recovery Point Objective defines maximum acceptable data loss measured in time. Recovery Time Objective specifies maximum acceptable downtime. Analyze business requirements, design solutions meeting objectives within budget constraints, and document procedures. Calculate storage requirements, test recovery scenarios, and implement automated monitoring to ensure objectives are continuously met."
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
                            "Performance Monitoring - Continuously track database metrics including CPU usage, memory consumption, disk I/O, and network throughput. Monitor query performance using DMVs, extended events, and query store. Identify top resource consumers, long-running queries, and blocking chains. Implement performance dashboards, trend analysis, and capacity planning based on historical data.",
                            "Health Checks - Implement automated health checks validating database availability, connectivity, and performance thresholds. Check for corruption using DBCC CHECKDB, monitor error logs for critical issues, and validate backup success. Design health score algorithms, implement automated remediation where possible, and integrate with enterprise monitoring systems for centralized alerting.",
                            "Maintenance Plans - Schedule regular maintenance tasks including index reorganization/rebuilds based on fragmentation levels, statistics updates for optimal query plans, and cleanup of old backups and job history. Balance maintenance overhead against system availability, implement online operations where possible, and use maintenance windows effectively. Automate using SQL Agent jobs or PowerShell.",
                            "Alerting Systems - Configure proactive alerts for critical conditions including disk space, long-running queries, failed jobs, and security violations. Design alert escalation procedures, implement intelligent filtering to reduce noise, and integrate with incident management systems. Use severity levels appropriately, include actionable information in alerts, and maintain on-call procedures.",
                            "Baseline Metrics - Establish normal performance patterns for comparison during troubleshooting. Capture key metrics during different workload periods (peak, off-peak, month-end processing). Document baseline query performance, resource utilization, and growth trends. Use baselines for capacity planning, performance troubleshooting, and SLA management. Update baselines after significant changes."
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
                            "Hadoop/Spark Integration - Connect traditional databases with big data ecosystems using PolyBase, Spark SQL, or specialized connectors. Query Hadoop data directly from SQL, push computation to Spark for complex analytics, and implement hybrid architectures. Understand data format considerations (Parquet, ORC, Avro), manage schema evolution, and optimize data movement between systems.",
                            "Data Lakes - Centralized repositories storing structured and unstructured data in native formats. Design folder hierarchies for data organization, implement metadata catalogs for discovery, and enforce security at file/folder levels. Use for exploratory analytics, machine learning datasets, and raw data preservation. Balance flexibility with governance requirements.",
                            "Columnar Storage - Store data by columns rather than rows for analytical workloads. Achieve high compression ratios, improve query performance for aggregations, and reduce I/O for column-subset queries. Implement columnstore indexes in traditional databases, understand batch mode processing, and design for optimal segment elimination. Handle real-time updates with delta stores.",
                            "Real-Time Analytics - Process and analyze streaming data with minimal latency using technologies like Kafka, Stream Analytics, or Change Data Capture. Design lambda architectures combining batch and stream processing, implement windowing functions for time-based analytics, and handle late-arriving data. Balance latency requirements with accuracy and completeness.",
                            "Partitioning Strategies - Divide large tables into manageable chunks based on range, list, or hash algorithms. Implement partition elimination for query performance, enable partition switching for fast data loading, and design sliding window scenarios for historical data management. Consider partitioning overhead, choose appropriate partition keys, and align with maintenance strategies."
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
                            "Azure SQL/AWS RDS - Platform-as-a-Service database offerings providing managed infrastructure, automated backups, and high availability. Configure service tiers based on DTU/vCore requirements, implement geo-replication for disaster recovery, and leverage platform features like automatic tuning. Understand pricing models, network security options, and integration with cloud services.",
                            "Serverless Databases - Auto-scaling compute resources that pause during inactivity to minimize costs. Ideal for intermittent, unpredictable workloads with automatic resume on connection. Configure auto-pause delays, understand cold start implications, and design applications for connection resiliency. Monitor scaling events and optimize for cost-performance balance.",
                            "Elastic Scaling - Dynamically adjust database resources based on workload demands. Implement horizontal scaling with sharding or read replicas, vertical scaling with online tier changes, and auto-scaling based on metrics. Design applications for scale-out scenarios, handle connection routing, and implement circuit breakers for overload protection.",
                            "Multi-Region Deployment - Distribute databases across geographic regions for low latency and disaster recovery. Implement active-passive or active-active configurations, handle conflict resolution for multi-master scenarios, and design for eventual consistency. Consider data residency requirements, network latency impacts, and implement region failover procedures.",
                            "Cloud Migration - Move on-premises databases to cloud platforms using lift-and-shift, re-platform, or re-architect approaches. Assess compatibility using migration tools, plan for minimal downtime using replication or backup/restore, and validate performance post-migration. Handle network connectivity, security changes, and optimize for cloud-native features progressively."
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
                            "Document Stores - Schema-flexible databases storing JSON/BSON documents ideal for hierarchical data and rapid development. Master MongoDB or CosmosDB for collections, indexing strategies, and aggregation pipelines. Design document schemas balancing normalization vs denormalization, implement sharding for scalability, and handle eventual consistency in distributed scenarios.",
                            "Key-Value Stores - High-performance databases mapping keys to values, optimized for caching and session storage. Implement Redis or DynamoDB for sub-millisecond latency, design efficient key naming conventions, and handle memory management. Use for caching layers, real-time leaderboards, and distributed locks. Understand persistence options and cluster configurations.",
                            "Graph Databases - Specialized systems storing nodes, edges, and properties for connected data analysis. Master Neo4j or Amazon Neptune for social networks, recommendation engines, and fraud detection. Write Cypher or Gremlin queries for pattern matching, implement efficient traversal algorithms, and optimize for deep relationship queries.",
                            "Time-Series Databases - Optimized for timestamped data from IoT devices, monitoring systems, and financial markets. Use InfluxDB or TimescaleDB with specialized compression, retention policies, and continuous aggregations. Design for high write throughput, implement downsampling strategies, and create real-time dashboards. Handle out-of-order data and backfilling scenarios.",
                            "NewSQL Systems - Modern databases combining SQL compatibility with NoSQL scalability using distributed architectures. Implement CockroachDB or Google Spanner for global consistency, automatic sharding, and ACID transactions at scale. Understand consensus algorithms (Raft, Paxos), design for geo-distributed deployments, and handle clock synchronization challenges."
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
                            "GDPR/HIPAA Compliance - Implement technical controls for data privacy regulations. GDPR requires consent management, right to erasure, and data portability. HIPAA mandates encryption, access controls, and audit trails for protected health information. Design for data minimization, implement privacy by design principles, and maintain compliance documentation.",
                            "Data Retention Policies - Define lifecycle rules for data storage, archival, and deletion based on legal and business requirements. Implement automated retention schedules, handle legal holds, and ensure secure data destruction. Design for different retention periods across data types, implement archival strategies for historical data, and maintain audit trails of retention actions.",
                            "Data Lineage - Track data flow from source to destination including all transformations and aggregations. Implement column-level lineage for impact analysis, document transformation logic, and maintain version history. Use for regulatory compliance, debugging data issues, and understanding dependencies. Integrate with data catalog tools for comprehensive governance.",
                            "Metadata Management - Centralize technical, business, and operational metadata in data catalogs. Document data definitions, quality rules, and ownership information. Implement automated metadata discovery, maintain business glossaries, and enable self-service data discovery. Use for impact analysis, data quality monitoring, and compliance reporting.",
                            "Data Classification - Categorize data based on sensitivity levels (public, internal, confidential, restricted) to apply appropriate security controls. Implement automated classification using patterns and rules, tag data at creation, and enforce handling policies. Design for regulatory requirements, integrate with DLP systems, and maintain classification accuracy through regular reviews."
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
                            "Database Version Control - Track all database changes including schema, stored procedures, and reference data in source control systems. Use migration tools like Flyway or Liquibase for versioned deployments, implement branching strategies for parallel development, and maintain rollback scripts. Document change reasons and handle merge conflicts in database code.",
                            "CI/CD for Databases - Automate database deployment pipelines including build, test, and release stages. Implement static code analysis for SQL, run unit tests on database objects, and execute integration tests against realistic data. Use tools like Azure DevOps or Jenkins, implement approval gates for production, and maintain deployment rollback capabilities.",
                            "Automated Testing - Create comprehensive test suites for database functionality including unit tests for stored procedures, integration tests for data flows, and performance regression tests. Use tSQLt or similar frameworks, implement test data management strategies, and maintain high code coverage. Design tests for idempotency and isolation.",
                            "Blue-Green Deployments - Minimize deployment risk using parallel environments with instant switchover capabilities. Implement schema versioning for backward compatibility, design applications for multiple schema versions, and synchronize data between environments. Handle stateful components carefully, test thoroughly before switching, and maintain rapid rollback procedures.",
                            "Infrastructure as Code - Define database infrastructure using declarative templates (ARM, CloudFormation, Terraform). Version control infrastructure definitions, implement automated provisioning pipelines, and maintain environment parity. Design for idempotent deployments, handle secrets management securely, and implement proper state management for infrastructure changes."
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
                            "PowerShell for SQL - Master SQL Server PowerShell module (SqlServer) for administrative automation. Write scripts for instance management, database deployment, and security configuration. Implement error handling with try-catch blocks, use pipeline processing for efficiency, and create reusable functions. Integrate with SQL Agent jobs and handle credentials securely.",
                            "Bash Scripting - Automate Linux database administration using shell scripts for backup automation, log rotation, and monitoring. Master command-line tools (psql, mysql, mongosh), implement robust error handling, and use cron for scheduling. Create portable scripts, handle environment variables properly, and implement logging for troubleshooting.",
                            "Python Database APIs - Use libraries like psycopg2, PyMySQL, and SQLAlchemy for database interaction. Implement connection pooling, handle transactions properly, and use parameterized queries for security. Create data pipeline scripts, automate report generation, and integrate with modern DevOps tools. Handle exceptions gracefully and implement retry logic.",
                            "Automated Backups - Design backup automation considering frequency, retention, and storage locations. Implement compression and encryption, validate backup integrity, and test restore procedures. Create intelligent scripts handling full/differential/log backups, monitor backup success, and alert on failures. Implement backup catalog maintenance and storage optimization.",
                            "Job Scheduling - Configure SQL Agent, cron, or cloud schedulers for routine task automation. Design job dependencies and workflows, implement failure notifications, and handle job concurrency. Create maintenance windows, implement job monitoring dashboards, and maintain job documentation. Handle time zone considerations and design for high availability scenarios."
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
                            "Query Plan Analysis - Deep dive into execution plan operators understanding their algorithms and cost models. Analyze plan cache for patterns, identify parameter sniffing issues, and optimize for plan stability. Use plan guides for consistency, understand parallel plan considerations, and correlate plans with wait statistics. Master plan comparison techniques and regression detection.",
                            "Partitioning Strategies - Design partition schemes for large table management using range (temporal data), list (categorical), or hash (even distribution) methods. Implement partition elimination in queries, use partition switching for fast loads, and align indexes with partitions. Handle cross-partition queries efficiently and design for maintenance operations.",
                            "In-Memory OLTP - Leverage memory-optimized tables for extreme OLTP performance eliminating locks and latches. Design for hash and range indexes, understand durability options, and migrate hot tables strategically. Handle memory pressure, implement resource pools, and design native stored procedures. Monitor memory usage and garbage collection impact.",
                            "Caching Layers - Implement multi-tier caching using application memory, distributed caches (Redis), and database buffer pools. Design cache invalidation strategies, handle cache warming, and monitor hit ratios. Use for expensive query results, session data, and reference data. Balance memory usage with performance gains and handle cache consistency.",
                            "Sharding - Horizontally partition data across multiple database instances for massive scalability. Design shard keys for even distribution, implement cross-shard query routing, and handle distributed transactions. Use consistent hashing for dynamic scaling, implement shard management tools, and design for fault tolerance. Handle resharding scenarios and maintain global consistency."
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
                            "In-Memory Databases - Entire database resides in RAM for microsecond latency using products like SAP HANA, Redis, or MemSQL. Understand persistence strategies, handle memory constraints, and design for high availability with replication. Leverage columnar compression, implement proper backup strategies, and optimize for CPU cache efficiency. Monitor memory fragmentation and growth patterns.",
                            "Graph Extensions in SQL - Use SQL Server graph features or PostgreSQL AGE extension for connected data analysis within relational databases. Create node and edge tables, write MATCH queries for pattern detection, and implement shortest path algorithms. Combine graph and relational queries, understand performance characteristics, and design hybrid data models.",
                            "Blockchain Databases - Immutable, distributed ledgers for audit trails and trust scenarios using SQL Server Ledger or Amazon QLDB. Implement cryptographic verification, design for append-only patterns, and handle distributed consensus. Use for regulatory compliance, supply chain tracking, and financial audit trails. Understand performance trade-offs and integration challenges.",
                            "AI/ML Integration - Embed machine learning models directly in databases using SQL Server ML Services or PostgreSQL MADlib. Train models on database data, implement real-time scoring in queries, and handle model versioning. Use for predictive analytics, anomaly detection, and recommendation systems. Design for performance and resource governance.",
                            "Edge Computing - Deploy lightweight databases at edge locations for IoT and distributed scenarios. Implement data synchronization with central databases, handle intermittent connectivity, and design for resource constraints. Use SQLite, SQL Server IoT Edge, or specialized edge databases. Implement conflict resolution and ensure data consistency across locations."
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