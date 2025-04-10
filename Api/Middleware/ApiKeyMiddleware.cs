namespace Api.Middleware
{
    public class ApiKeyMiddleware
    {
        private readonly RequestDelegate _next;
        private const string ApiKeyQueryName = "api_key";
        private readonly List<string> _allowedApiKeys;

        public ApiKeyMiddleware(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            
            var apiKeysFromEnv = Environment.GetEnvironmentVariable("ALLOWED_API_KEYS");
            _allowedApiKeys = apiKeysFromEnv?.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList() ?? new List<string>();

            if (!_allowedApiKeys.Any())
            {
                Console.WriteLine("WARNING: No API keys configured in environment:AllowedApiKeys.");
            }
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (!context.Request.Query.TryGetValue(ApiKeyQueryName, out var extractedApiKey) || extractedApiKey.Count == 0)
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await context.Response.WriteAsync("API Key was not provided.");
                return;
            }

            var apiKey = extractedApiKey.ToString();

            if (!_allowedApiKeys.Contains(apiKey))
            {
                context.Response.StatusCode = StatusCodes.Status403Forbidden;
                await context.Response.WriteAsync("Invalid API Key.");
                return;
            }

            await _next(context);
        }
    }
}
