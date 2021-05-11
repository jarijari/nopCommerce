using Nop.Core.Configuration;

namespace Nop.Plugin.Widgets.JakiriReviews
{
    /// <summary>
    /// Represents plugin settings
    /// </summary>
    public class JakiriReviewsSettings : ISettings
    {
        /// <summary>
        /// Gets or sets an installation script
        /// </summary>
        public string Script { get; set; }

        /// <summary>
        /// Gets or sets a widget zone name to place a widget
        /// </summary>
        public string WidgetZone { get; set; }
    }
}