using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Nop.Plugin.Widgets.JakiriReviews.Services;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Widgets.JakiriReviews.Components
{
    /// <summary>
    /// Represents the view component to place a widget into pages
    /// </summary>
    [ViewComponent(Name = JakiriReviewsDefaults.VIEW_COMPONENT)]
    public class JakiriReviewsViewComponent : NopViewComponent
    {
        #region Fields

        private readonly JakiriReviewsService _jakiriReviewsService;
        private readonly JakiriReviewsSettings _jakiriReviewsSettings;

        #endregion

        #region Ctor

        public JakiriReviewsViewComponent(JakiriReviewsService jakiriReviewsService,
            JakiriReviewsSettings jakiriReviewsSettings)
        {
            _jakiriReviewsService = jakiriReviewsService;
            _jakiriReviewsSettings = jakiriReviewsSettings;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Invoke view component
        /// </summary>
        /// <param name="widgetZone">Widget zone name</param>
        /// <param name="additionalData">Additional data</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the view component result
        /// </returns>
        public async Task<IViewComponentResult> InvokeAsync(string widgetZone, object additionalData)
        {
            var script = widgetZone != _jakiriReviewsSettings.WidgetZone
                ? string.Empty
                : await _jakiriReviewsService.PrepareScriptAsync();

            return new HtmlContentViewComponentResult(new HtmlString(script ?? string.Empty));
        }

        #endregion
    }
}