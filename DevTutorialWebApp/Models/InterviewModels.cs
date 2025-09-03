using System;
using System.Collections.Generic;

namespace DevTutorialWebApp.Models
{
    public class InterviewCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public List<InterviewTopic> Topics { get; set; } = new List<InterviewTopic>();
    }

    public class InterviewTopic
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Difficulty { get; set; }
        public List<InterviewQuestion> Questions { get; set; } = new List<InterviewQuestion>();
    }

    public class InterviewQuestion
    {
        public int Id { get; set; }
        public int TopicId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string Difficulty { get; set; } // Easy, Medium, Hard
        public List<string> KeyPoints { get; set; } = new List<string>();
        public string CodeExample { get; set; }
        public List<string> FollowUpQuestions { get; set; } = new List<string>();
    }

    public static class InterviewDifficulty
    {
        public const string Easy = "Easy";
        public const string Medium = "Medium";
        public const string Hard = "Hard";
    }
}