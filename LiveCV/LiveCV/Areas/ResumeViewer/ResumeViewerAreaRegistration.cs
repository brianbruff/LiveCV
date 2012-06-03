﻿using System.Web.Mvc;

namespace LiveCV.Areas.ResumeViewer
{
    public class ResumeViewerAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "ResumeViewer";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "ResumeViewer_default",
                "ResumeViewer/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
