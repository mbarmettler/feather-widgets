﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Telerik.Sitefinity.Frontend.Comments.Mvc.Models;
using Telerik.Sitefinity.Frontend.Comments.Mvc.StringResources;
using Telerik.Sitefinity.Frontend.Mvc.Infrastructure.Controllers;
using Telerik.Sitefinity.Frontend.Mvc.Infrastructure.Controllers.Attributes;
using Telerik.Sitefinity.Modules.Pages.Configuration;
using Telerik.Sitefinity.Mvc;

namespace Telerik.Sitefinity.Frontend.Comments.Mvc.Controllers
{
    /// <summary>
    /// This class represents the controller of the Comments widget.
    /// </summary>
    [Localization(typeof(CommentsResources))]
    [ControllerToolboxItem(Name = "Comments_MVC", Title = "Comments", SectionName = ToolboxesConfig.ContentToolboxSectionName, ModuleName = "Comments", CssClass = CommentsController.WidgetIconCssClass)]
    public class CommentsController:Controller
    {
        #region Properties

        /// <summary>
        /// Gets the Comments widget model.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public virtual ICommentsModel Model
        {
            get
            {
                if (this.model == null)
                    this.model = ControllerModelFactory.GetModel<ICommentsModel>(this.GetType());

                return this.model;
            }
        }

        #endregion

        #region Actions

        public ActionResult Index(int? page)
        {
            return this.View();
        }

        #endregion

        #region Private fields and constants

        internal const string WidgetIconCssClass = "sfCommentsIcn sfMvcIcn";
        private ICommentsModel model;

        #endregion
    }
}
