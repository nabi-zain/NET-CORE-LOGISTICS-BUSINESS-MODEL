namespace Triton.Service.Utils
{
    public static class HtmlHelper
    {
        public static string AlertMessage(string message, string color)
        {
            return $"<div class='{color}'>{message}</div>";
        }

        public static string Save => "<div class='alert alert-success' role='alert'><strong>Success! </strong> The record has been saved!</div>";
        public static string Update => "<div class='alert alert-success' role='alert'><strong>Success! </strong> The record has been updated!</div>";
        public static string Create => "<div class='alert alert-success' role='alert'><strong>Success! </strong> The record has been created!</div>";
        public static string Delete => "<div class='alert alert-danger' role='alert'><strong>Success! </strong> The record has been deleted!</div>";
        public static string Error => "<div class='alert alert-danger' role='alert'><strong>Error!</strong> An error has occurred. Please re-check and report to IT if it persists.</div>";
        public static string Warning => "<div class='alert alert-warning' role='alert'><strong>Warning! </strong> Something is not right with your changes!</div>";
        public static string Info => "<div class='alert alert-info' role='alert'><strong>INFO</strong> Please take note!</div>";
        public static string Success => "<div class='alert alert-success' role='alert'><strong>Success! </strong> Your changes were successful!</div>";
        public static string Failure => "<div class='alert alert-danger' role='alert'><strong>Failure! </strong> Your changes failed to be save</div>";
        public static string NoData => "<div class='alert alert-danger' role='alert'><strong>Failure! </strong>There is no data available</div>";
    }
}
