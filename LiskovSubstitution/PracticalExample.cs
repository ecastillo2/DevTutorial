namespace LiskovSubstitution.PracticalExample;

/// <summary>
/// PRACTICAL EXAMPLE - Content Management System
/// Demonstrates LSP in a real-world scenario
/// </summary>

// ========== CONTENT HIERARCHY ==========

/// <summary>
/// Base interface for all content
/// </summary>
public interface IContent
{
    string Id { get; }
    string Title { get; }
    DateTime CreatedAt { get; }
    string GetContentType();
    string GetSummary();
}

/// <summary>
/// Interface for content that can be published
/// </summary>
public interface IPublishableContent
{
    bool IsPublished { get; }
    DateTime? PublishedAt { get; }
    void Publish();
    void Unpublish();
}

/// <summary>
/// Interface for content that can be edited
/// </summary>
public interface IEditableContent
{
    DateTime? LastModifiedAt { get; }
    void UpdateTitle(string newTitle);
    void UpdateContent(string newContent);
}

/// <summary>
/// Interface for content with comments
/// </summary>
public interface ICommentableContent
{
    List<Comment> GetComments();
    void AddComment(Comment comment);
    void RemoveComment(string commentId);
    bool AllowsComments { get; }
}

/// <summary>
/// Interface for content that can be versioned
/// </summary>
public interface IVersionedContent
{
    int Version { get; }
    List<ContentVersion> GetVersionHistory();
    void SaveNewVersion(string reason);
    void RestoreVersion(int version);
}

/// <summary>
/// Blog Post - editable, publishable, commentable, and versioned
/// </summary>
public class BlogPost : IContent, IEditableContent, IPublishableContent, ICommentableContent, IVersionedContent
{
    private string content;
    private readonly List<Comment> comments = new List<Comment>();
    private readonly List<ContentVersion> versions = new List<ContentVersion>();
    
    public string Id { get; }
    public string Title { get; private set; }
    public DateTime CreatedAt { get; }
    public DateTime? LastModifiedAt { get; private set; }
    public bool IsPublished { get; private set; }
    public DateTime? PublishedAt { get; private set; }
    public int Version { get; private set; } = 1;
    public bool AllowsComments => IsPublished;

    public BlogPost(string id, string title, string content)
    {
        Id = id;
        Title = title;
        this.content = content;
        CreatedAt = DateTime.Now;
    }

    public string GetContentType()
    {
        return "Blog Post";
    }

    public string GetSummary()
    {
        return content.Length > 100 ? content.Substring(0, 100) + "..." : content;
    }

    public void UpdateTitle(string newTitle)
    {
        Title = newTitle;
        LastModifiedAt = DateTime.Now;
    }

    public void UpdateContent(string newContent)
    {
        content = newContent;
        LastModifiedAt = DateTime.Now;
    }

    public void Publish()
    {
        if (!IsPublished)
        {
            IsPublished = true;
            PublishedAt = DateTime.Now;
            Console.WriteLine($"Blog post '{Title}' published");
        }
    }

    public void Unpublish()
    {
        if (IsPublished)
        {
            IsPublished = false;
            Console.WriteLine($"Blog post '{Title}' unpublished");
        }
    }

    public List<Comment> GetComments()
    {
        return new List<Comment>(comments);
    }

    public void AddComment(Comment comment)
    {
        if (!AllowsComments)
            throw new InvalidOperationException("Comments not allowed on unpublished posts");
        
        comments.Add(comment);
        Console.WriteLine($"Comment added to blog post '{Title}'");
    }

    public void RemoveComment(string commentId)
    {
        comments.RemoveAll(c => c.Id == commentId);
    }

    public List<ContentVersion> GetVersionHistory()
    {
        return new List<ContentVersion>(versions);
    }

    public void SaveNewVersion(string reason)
    {
        versions.Add(new ContentVersion
        {
            Version = Version,
            Content = content,
            Title = Title,
            SavedAt = DateTime.Now,
            Reason = reason
        });
        Version++;
    }

    public void RestoreVersion(int version)
    {
        var historicVersion = versions.FirstOrDefault(v => v.Version == version);
        if (historicVersion != null)
        {
            content = historicVersion.Content;
            Title = historicVersion.Title;
            LastModifiedAt = DateTime.Now;
            SaveNewVersion($"Restored from version {version}");
        }
    }
}

/// <summary>
/// News Article - publishable and commentable, but not directly editable
/// </summary>
public class NewsArticle : IContent, IPublishableContent, ICommentableContent
{
    private readonly string content;
    private readonly List<Comment> comments = new List<Comment>();
    
    public string Id { get; }
    public string Title { get; }
    public string Author { get; }
    public DateTime CreatedAt { get; }
    public bool IsPublished { get; private set; }
    public DateTime? PublishedAt { get; private set; }
    public bool AllowsComments => IsPublished;

    public NewsArticle(string id, string title, string author, string content)
    {
        Id = id;
        Title = title;
        Author = author;
        this.content = content;
        CreatedAt = DateTime.Now;
    }

    public string GetContentType()
    {
        return "News Article";
    }

    public string GetSummary()
    {
        return $"By {Author} - {content.Substring(0, Math.Min(content.Length, 100))}...";
    }

    public void Publish()
    {
        if (!IsPublished)
        {
            IsPublished = true;
            PublishedAt = DateTime.Now;
            Console.WriteLine($"News article '{Title}' by {Author} published");
        }
    }

    public void Unpublish()
    {
        if (IsPublished)
        {
            IsPublished = false;
            Console.WriteLine($"News article '{Title}' unpublished");
        }
    }

    public List<Comment> GetComments()
    {
        return new List<Comment>(comments);
    }

    public void AddComment(Comment comment)
    {
        if (!AllowsComments)
            throw new InvalidOperationException("Comments not allowed on unpublished articles");
        
        comments.Add(comment);
    }

    public void RemoveComment(string commentId)
    {
        comments.RemoveAll(c => c.Id == commentId);
    }
}

/// <summary>
/// Static Page - editable and versioned, but not commentable
/// </summary>
public class StaticPage : IContent, IEditableContent, IVersionedContent
{
    private string content;
    private readonly List<ContentVersion> versions = new List<ContentVersion>();
    
    public string Id { get; }
    public string Title { get; private set; }
    public string Slug { get; }
    public DateTime CreatedAt { get; }
    public DateTime? LastModifiedAt { get; private set; }
    public int Version { get; private set; } = 1;

    public StaticPage(string id, string title, string slug, string content)
    {
        Id = id;
        Title = title;
        Slug = slug;
        this.content = content;
        CreatedAt = DateTime.Now;
    }

    public string GetContentType()
    {
        return "Static Page";
    }

    public string GetSummary()
    {
        return $"/{Slug} - {Title}";
    }

    public void UpdateTitle(string newTitle)
    {
        Title = newTitle;
        LastModifiedAt = DateTime.Now;
    }

    public void UpdateContent(string newContent)
    {
        content = newContent;
        LastModifiedAt = DateTime.Now;
    }

    public List<ContentVersion> GetVersionHistory()
    {
        return new List<ContentVersion>(versions);
    }

    public void SaveNewVersion(string reason)
    {
        versions.Add(new ContentVersion
        {
            Version = Version,
            Content = content,
            Title = Title,
            SavedAt = DateTime.Now,
            Reason = reason
        });
        Version++;
    }

    public void RestoreVersion(int version)
    {
        var historicVersion = versions.FirstOrDefault(v => v.Version == version);
        if (historicVersion != null)
        {
            content = historicVersion.Content;
            Title = historicVersion.Title;
            LastModifiedAt = DateTime.Now;
            SaveNewVersion($"Restored from version {version}");
        }
    }
}

/// <summary>
/// Announcement - simple content, only publishable
/// </summary>
public class Announcement : IContent, IPublishableContent
{
    private readonly string message;
    
    public string Id { get; }
    public string Title { get; }
    public DateTime CreatedAt { get; }
    public bool IsPublished { get; private set; }
    public DateTime? PublishedAt { get; private set; }
    public DateTime? ExpiresAt { get; }

    public Announcement(string id, string title, string message, DateTime? expiresAt = null)
    {
        Id = id;
        Title = title;
        this.message = message;
        CreatedAt = DateTime.Now;
        ExpiresAt = expiresAt;
    }

    public string GetContentType()
    {
        return "Announcement";
    }

    public string GetSummary()
    {
        return message;
    }

    public void Publish()
    {
        if (!IsPublished && (ExpiresAt == null || ExpiresAt > DateTime.Now))
        {
            IsPublished = true;
            PublishedAt = DateTime.Now;
            Console.WriteLine($"Announcement '{Title}' published");
        }
    }

    public void Unpublish()
    {
        if (IsPublished)
        {
            IsPublished = false;
            Console.WriteLine($"Announcement '{Title}' unpublished");
        }
    }
}

// ========== CONTENT SERVICES ==========

/// <summary>
/// Content Repository that works with any IContent
/// </summary>
public class ContentRepository
{
    private readonly Dictionary<string, IContent> contents = new Dictionary<string, IContent>();

    public void Add(IContent content)
    {
        contents[content.Id] = content;
        Console.WriteLine($"Added {content.GetContentType()}: {content.Title}");
    }

    public IContent? GetById(string id)
    {
        return contents.TryGetValue(id, out var content) ? content : null;
    }

    public List<IContent> GetAll()
    {
        return contents.Values.ToList();
    }

    public List<T> GetByType<T>() where T : IContent
    {
        return contents.Values.OfType<T>().ToList();
    }
}

/// <summary>
/// Publishing Service that works with any IPublishableContent
/// </summary>
public class PublishingService
{
    public void PublishContent(IPublishableContent content)
    {
        if (!content.IsPublished)
        {
            content.Publish();
            Console.WriteLine("Content published successfully");
        }
        else
        {
            Console.WriteLine("Content is already published");
        }
    }

    public void UnpublishContent(IPublishableContent content)
    {
        if (content.IsPublished)
        {
            content.Unpublish();
            Console.WriteLine("Content unpublished successfully");
        }
    }

    public void SchedulePublishing(IPublishableContent content, DateTime publishAt)
    {
        Console.WriteLine($"Scheduled publishing at {publishAt}");
        // In real implementation, would use a job scheduler
    }
}

/// <summary>
/// Comment Service that works with any ICommentableContent
/// </summary>
public class CommentService
{
    public void AddComment(ICommentableContent content, string author, string text)
    {
        if (!content.AllowsComments)
        {
            Console.WriteLine("Comments are not allowed on this content");
            return;
        }

        var comment = new Comment
        {
            Id = Guid.NewGuid().ToString(),
            Author = author,
            Text = text,
            PostedAt = DateTime.Now
        };

        content.AddComment(comment);
    }

    public void ModerateComments(ICommentableContent content)
    {
        var comments = content.GetComments();
        Console.WriteLine($"Moderating {comments.Count} comments");
        
        // Example: Remove spam comments
        foreach (var comment in comments.Where(c => c.Text.Contains("spam", StringComparison.OrdinalIgnoreCase)))
        {
            content.RemoveComment(comment.Id);
            Console.WriteLine($"Removed spam comment from {comment.Author}");
        }
    }
}

/// <summary>
/// Version Control Service that works with any IVersionedContent
/// </summary>
public class VersionControlService
{
    public void CreateCheckpoint(IVersionedContent content, string reason)
    {
        content.SaveNewVersion(reason);
        Console.WriteLine($"Created version {content.Version} - {reason}");
    }

    public void ShowVersionHistory(IVersionedContent content)
    {
        var history = content.GetVersionHistory();
        Console.WriteLine($"\nVersion History ({history.Count} versions):");
        
        foreach (var version in history.OrderByDescending(v => v.SavedAt))
        {
            Console.WriteLine($"  v{version.Version} - {version.SavedAt:yyyy-MM-dd HH:mm} - {version.Reason}");
        }
    }

    public void RestorePreviousVersion(IVersionedContent content)
    {
        var history = content.GetVersionHistory();
        if (history.Any())
        {
            var previousVersion = history.OrderByDescending(v => v.Version).First();
            content.RestoreVersion(previousVersion.Version);
            Console.WriteLine($"Restored to version {previousVersion.Version}");
        }
    }
}

/// <summary>
/// Editor Service that works with any IEditableContent
/// </summary>
public class EditorService
{
    public void UpdateContent(IEditableContent content, string newTitle, string newContent)
    {
        content.UpdateTitle(newTitle);
        content.UpdateContent(newContent);
        Console.WriteLine($"Content updated. Last modified: {content.LastModifiedAt}");
    }

    public bool HasBeenModified(IEditableContent content)
    {
        return content.LastModifiedAt.HasValue;
    }
}

// ========== SUPPORTING CLASSES ==========

public class Comment
{
    public string Id { get; set; } = "";
    public string Author { get; set; } = "";
    public string Text { get; set; } = "";
    public DateTime PostedAt { get; set; }
}

public class ContentVersion
{
    public int Version { get; set; }
    public string Title { get; set; } = "";
    public string Content { get; set; } = "";
    public DateTime SavedAt { get; set; }
    public string Reason { get; set; } = "";
}