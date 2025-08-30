namespace SingleResponsibility.PracticalExample;

/// <summary>
/// PRACTICAL EXAMPLE - Blog System
/// Demonstrates how SRP creates a maintainable, testable system
/// </summary>

// ========== DOMAIN MODELS ==========
// Each model has single responsibility: hold data

public class BlogPost
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Content { get; set; } = "";
    public string Author { get; set; } = "";
    public DateTime PublishedDate { get; set; }
    public List<string> Tags { get; set; } = new List<string>();
    public bool IsPublished { get; set; }
}

public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = "";
    public string Email { get; set; } = "";
    public string PasswordHash { get; set; } = "";
    public DateTime RegisteredDate { get; set; }
    public List<string> Roles { get; set; } = new List<string>();
}

public class Comment
{
    public int Id { get; set; }
    public int PostId { get; set; }
    public string AuthorName { get; set; } = "";
    public string Content { get; set; } = "";
    public DateTime CreatedDate { get; set; }
    public bool IsApproved { get; set; }
}

// ========== REPOSITORIES ==========
// Single Responsibility: Data persistence

/// <summary>
/// SINGLE RESPONSIBILITY: Manage blog post persistence
/// </summary>
public class BlogPostRepository
{
    private readonly List<BlogPost> _posts = new List<BlogPost>();

    public void Save(BlogPost post)
    {
        if (post.Id == 0)
        {
            post.Id = _posts.Count + 1;
            _posts.Add(post);
            Console.WriteLine($"[SRP] BlogPostRepository: Saved new post '{post.Title}'");
        }
        else
        {
            var index = _posts.FindIndex(p => p.Id == post.Id);
            if (index >= 0)
            {
                _posts[index] = post;
                Console.WriteLine($"[SRP] BlogPostRepository: Updated post '{post.Title}'");
            }
        }
    }

    public BlogPost? GetById(int id)
    {
        return _posts.FirstOrDefault(p => p.Id == id);
    }

    public List<BlogPost> GetPublishedPosts()
    {
        return _posts.Where(p => p.IsPublished).OrderByDescending(p => p.PublishedDate).ToList();
    }

    public List<BlogPost> GetByAuthor(string author)
    {
        return _posts.Where(p => p.Author == author).ToList();
    }

    public List<BlogPost> GetByTag(string tag)
    {
        return _posts.Where(p => p.Tags.Contains(tag)).ToList();
    }
}

/// <summary>
/// SINGLE RESPONSIBILITY: Manage user persistence
/// </summary>
public class UserRepository
{
    private readonly List<User> _users = new List<User>();

    public void Save(User user)
    {
        if (user.Id == 0)
        {
            user.Id = _users.Count + 1;
            _users.Add(user);
            Console.WriteLine($"[SRP] UserRepository: Saved new user '{user.Username}'");
        }
    }

    public User? GetByUsername(string username)
    {
        return _users.FirstOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
    }

    public User? GetByEmail(string email)
    {
        return _users.FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
    }

    public bool Exists(string username)
    {
        return _users.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
    }
}

// ========== SERVICES ==========
// Each service has a specific responsibility

/// <summary>
/// SINGLE RESPONSIBILITY: Handle authentication
/// </summary>
public class AuthenticationService
{
    private readonly UserRepository _userRepository;
    private readonly PasswordHasher _passwordHasher;

    public AuthenticationService(UserRepository userRepository, PasswordHasher passwordHasher)
    {
        _userRepository = userRepository;
        _passwordHasher = passwordHasher;
    }

    public bool Register(string username, string email, string password)
    {
        Console.WriteLine($"[SRP] AuthenticationService: Registering user '{username}'");
        
        if (_userRepository.Exists(username))
        {
            Console.WriteLine($"[SRP] AuthenticationService: Username already exists");
            return false;
        }

        var user = new User
        {
            Username = username,
            Email = email,
            PasswordHash = _passwordHasher.HashPassword(password),
            RegisteredDate = DateTime.Now,
            Roles = new List<string> { "User" }
        };

        _userRepository.Save(user);
        return true;
    }

    public User? Login(string username, string password)
    {
        Console.WriteLine($"[SRP] AuthenticationService: Authenticating user '{username}'");
        
        var user = _userRepository.GetByUsername(username);
        if (user != null && _passwordHasher.VerifyPassword(password, user.PasswordHash))
        {
            Console.WriteLine($"[SRP] AuthenticationService: Login successful");
            return user;
        }

        Console.WriteLine($"[SRP] AuthenticationService: Login failed");
        return null;
    }
}

/// <summary>
/// SINGLE RESPONSIBILITY: Hash and verify passwords
/// </summary>
public class PasswordHasher
{
    public string HashPassword(string password)
    {
        Console.WriteLine($"[SRP] PasswordHasher: Hashing password");
        // Simplified hashing for demo
        return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password + "salt"));
    }

    public bool VerifyPassword(string password, string hash)
    {
        Console.WriteLine($"[SRP] PasswordHasher: Verifying password");
        return HashPassword(password) == hash;
    }
}

/// <summary>
/// SINGLE RESPONSIBILITY: Validate blog posts
/// </summary>
public class BlogPostValidator
{
    public ValidationResult Validate(BlogPost post)
    {
        Console.WriteLine($"[SRP] BlogPostValidator: Validating post");
        
        var errors = new List<string>();

        if (string.IsNullOrWhiteSpace(post.Title))
            errors.Add("Title is required");
        else if (post.Title.Length > 200)
            errors.Add("Title must be 200 characters or less");

        if (string.IsNullOrWhiteSpace(post.Content))
            errors.Add("Content is required");
        else if (post.Content.Length < 10)
            errors.Add("Content must be at least 10 characters");

        if (string.IsNullOrWhiteSpace(post.Author))
            errors.Add("Author is required");

        return new ValidationResult
        {
            IsValid = errors.Count == 0,
            Errors = errors
        };
    }
}

/// <summary>
/// SINGLE RESPONSIBILITY: Handle blog post publishing workflow
/// </summary>
public class BlogPublishingService
{
    private readonly BlogPostRepository _postRepository;
    private readonly BlogPostValidator _validator;
    private readonly NotificationService _notificationService;

    public BlogPublishingService(
        BlogPostRepository postRepository, 
        BlogPostValidator validator,
        NotificationService notificationService)
    {
        _postRepository = postRepository;
        _validator = validator;
        _notificationService = notificationService;
    }

    public bool PublishPost(BlogPost post)
    {
        Console.WriteLine($"[SRP] BlogPublishingService: Publishing post '{post.Title}'");
        
        // Validate
        var validationResult = _validator.Validate(post);
        if (!validationResult.IsValid)
        {
            Console.WriteLine($"[SRP] BlogPublishingService: Validation failed");
            foreach (var error in validationResult.Errors)
            {
                Console.WriteLine($"  - {error}");
            }
            return false;
        }

        // Publish
        post.IsPublished = true;
        post.PublishedDate = DateTime.Now;
        _postRepository.Save(post);

        // Notify
        _notificationService.NotifyNewPost(post);

        return true;
    }

    public void UnpublishPost(int postId)
    {
        var post = _postRepository.GetById(postId);
        if (post != null)
        {
            post.IsPublished = false;
            _postRepository.Save(post);
            Console.WriteLine($"[SRP] BlogPublishingService: Unpublished post '{post.Title}'");
        }
    }
}

/// <summary>
/// SINGLE RESPONSIBILITY: Send notifications
/// </summary>
public class NotificationService
{
    private readonly EmailService _emailService;
    private readonly List<string> _subscribers = new List<string>();

    public NotificationService(EmailService emailService)
    {
        _emailService = emailService;
    }

    public void Subscribe(string email)
    {
        _subscribers.Add(email);
        Console.WriteLine($"[SRP] NotificationService: Added subscriber '{email}'");
    }

    public void NotifyNewPost(BlogPost post)
    {
        Console.WriteLine($"[SRP] NotificationService: Notifying subscribers about '{post.Title}'");
        
        foreach (var subscriber in _subscribers)
        {
            _emailService.SendEmail(
                subscriber,
                $"New Post: {post.Title}",
                $"Check out our new post by {post.Author}!"
            );
        }
    }
}

/// <summary>
/// SINGLE RESPONSIBILITY: Send emails
/// </summary>
public class EmailService
{
    public void SendEmail(string to, string subject, string body)
    {
        Console.WriteLine($"[SRP] EmailService: Sending email");
        Console.WriteLine($"  To: {to}");
        Console.WriteLine($"  Subject: {subject}");
        Console.WriteLine($"  Body: {body}");
    }
}

/// <summary>
/// SINGLE RESPONSIBILITY: Generate blog statistics
/// </summary>
public class BlogStatisticsService
{
    private readonly BlogPostRepository _postRepository;

    public BlogStatisticsService(BlogPostRepository postRepository)
    {
        _postRepository = postRepository;
    }

    public BlogStatistics GenerateStatistics()
    {
        Console.WriteLine($"[SRP] BlogStatisticsService: Generating statistics");
        
        var allPosts = _postRepository.GetPublishedPosts();
        
        return new BlogStatistics
        {
            TotalPosts = allPosts.Count,
            TotalAuthors = allPosts.Select(p => p.Author).Distinct().Count(),
            AveragePostLength = allPosts.Any() ? (int)allPosts.Average(p => p.Content.Length) : 0,
            MostUsedTags = allPosts
                .SelectMany(p => p.Tags)
                .GroupBy(t => t)
                .OrderByDescending(g => g.Count())
                .Take(5)
                .Select(g => new TagCount { Tag = g.Key, Count = g.Count() })
                .ToList(),
            PostsByMonth = allPosts
                .GroupBy(p => new { p.PublishedDate.Year, p.PublishedDate.Month })
                .Select(g => new MonthlyPostCount 
                { 
                    Year = g.Key.Year, 
                    Month = g.Key.Month, 
                    Count = g.Count() 
                })
                .ToList()
        };
    }
}

/// <summary>
/// SINGLE RESPONSIBILITY: Generate RSS feed
/// </summary>
public class RssFeedGenerator
{
    private readonly BlogPostRepository _postRepository;

    public RssFeedGenerator(BlogPostRepository postRepository)
    {
        _postRepository = postRepository;
    }

    public string GenerateFeed()
    {
        Console.WriteLine($"[SRP] RssFeedGenerator: Generating RSS feed");
        
        var posts = _postRepository.GetPublishedPosts().Take(10);
        
        var feed = new System.Text.StringBuilder();
        feed.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
        feed.AppendLine("<rss version=\"2.0\">");
        feed.AppendLine("<channel>");
        feed.AppendLine("<title>My Blog</title>");
        feed.AppendLine("<description>Latest posts from my blog</description>");
        
        foreach (var post in posts)
        {
            feed.AppendLine("<item>");
            feed.AppendLine($"<title>{post.Title}</title>");
            feed.AppendLine($"<description>{post.Content.Substring(0, Math.Min(200, post.Content.Length))}...</description>");
            feed.AppendLine($"<author>{post.Author}</author>");
            feed.AppendLine($"<pubDate>{post.PublishedDate:R}</pubDate>");
            feed.AppendLine("</item>");
        }
        
        feed.AppendLine("</channel>");
        feed.AppendLine("</rss>");
        
        return feed.ToString();
    }
}

// ========== SUPPORTING CLASSES ==========

public class ValidationResult
{
    public bool IsValid { get; set; }
    public List<string> Errors { get; set; } = new List<string>();
}

public class BlogStatistics
{
    public int TotalPosts { get; set; }
    public int TotalAuthors { get; set; }
    public int AveragePostLength { get; set; }
    public List<TagCount> MostUsedTags { get; set; } = new List<TagCount>();
    public List<MonthlyPostCount> PostsByMonth { get; set; } = new List<MonthlyPostCount>();
}

public class TagCount
{
    public string Tag { get; set; } = "";
    public int Count { get; set; }
}

public class MonthlyPostCount
{
    public int Year { get; set; }
    public int Month { get; set; }
    public int Count { get; set; }
}