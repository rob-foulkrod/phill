namespace Aura.Web.Models
{
    /// <summary>
    /// Represents an error within the application.
    /// </summary>
    public class ErrorViewModel
    {
        /// <summary>
        /// Gets or sets the request ID for this error.
        /// </summary>
        public string? RequestId { get; set; }

        /// <summary>
        /// Gets a value indicating whether the current <see cref="RequestId"/> is valid for display.
        /// </summary>
        public bool ShowRequestId => !string.IsNullOrEmpty(this.RequestId);
    }
}
