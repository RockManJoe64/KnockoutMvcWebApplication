﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace KnockoutMvcWebApplication.ModelBinder
{
  public class FromJsonAttribute : CustomModelBinderAttribute
  {
    private static readonly JavaScriptSerializer serializer = new JavaScriptSerializer();

    public override IModelBinder GetBinder()
    {
      return new JsonModelBinder();
    }

    private class JsonModelBinder : IModelBinder
    {
      public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
      {
        var stringified = controllerContext.HttpContext.Request[bindingContext.ModelName];
        if (string.IsNullOrEmpty(stringified))
          return null;
        return serializer.Deserialize(stringified, bindingContext.ModelType);
      }
      
    }
  }
}