namespace BiebWebApp.Models
{
    // Model representing an error view
    public class ErrorViewModel
    {
        // The request ID associated with the error
        public string? RequestId { get; set; }

        // Indicates whether to show the request ID or not
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
